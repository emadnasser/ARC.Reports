using System;
using System.Xml;
using System.Linq;
using System.ComponentModel;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects.DataClasses;
using System.ComponentModel.DataAnnotations;
using DevExpress.Persistent.Base;
using DevExpress.ExpressApp;
using DevExpress.Persistent.Base.General;
using DevExpress.Persistent.Validation;
using DevExpress.ExpressApp.DC;
using DevExpress.ExpressApp.SystemModule.Notifications;
using DevExpress.ExpressApp.Model;
using DevExpress.ExpressApp.Filtering;
using DevExpress.XtraScheduler.Xml;

namespace EFDemo.Module.Data {
	[DefaultProperty("Subject")]
	[NavigationItem("Default")]
	[DefaultListViewOptions(true, NewItemRowPosition.None)]
	[MetadataType(typeof(EventMetadata))]
	public partial class Event : IEvent, IRecurrentEvent, IObjectSpaceLink, IXafEntityObject, IReminderEvent {
        private const int NoneReminder = -1;
		private String resourceIds;
		private Boolean isUpdateResourcesDelayed;
		private IObjectSpace objectSpace;
        private IList<PostponeTime> postponeTimes;
        private string cashedReminderInfoXml;
        private Nullable<DateTime> cashedAlarmTime;

		private void UpdateResources() {
			Resources.Clear();
			if(!String.IsNullOrEmpty(resourceIds)) {
				XmlDocument xmlDocument = new XmlDocument();
				xmlDocument.LoadXml(resourceIds);
				foreach(XmlNode xmlNode in xmlDocument.DocumentElement.ChildNodes) {
                    AppointmentResourceIdXmlLoader loader = new AppointmentResourceIdXmlLoader(xmlNode);
                    Object keyMemberValue = loader.ObjectFromXml();
					Object obj = objectSpace.GetObjectByKey(typeof(Resource), keyMemberValue);
					if(obj != null) {
						Resources.Add((Resource)obj);
					}
				}
			}
		}
        private void UpdateRemindersInfoXml(bool UpdateAlarmTime) {
            if(RemindIn.HasValue && AlarmTime.HasValue) {
                AppointmentReminderInfo apptReminder = new AppointmentReminderInfo();
                ReminderInfo reminderInfo = new ReminderInfo();
                reminderInfo.TimeBeforeStart = RemindIn.Value;
                DateTime notNullableStartOn = StartOn.HasValue ? StartOn.Value : DateTime.MinValue;
                if(UpdateAlarmTime) {
                    reminderInfo.AlertTime = AlarmTime.Value;
                }
                else {
                    reminderInfo.AlertTime = notNullableStartOn - RemindIn.Value;
                }
                apptReminder.ReminderInfos.Add(reminderInfo);
                ReminderInfoXml = apptReminder.ToXml();
            }
            else {
                ReminderInfoXml = null;
            }
        }
        private void UpdateAlarmTime() {
            if(!string.IsNullOrEmpty(ReminderInfoXml)) {
                AppointmentReminderInfo appointmentReminderInfo = new AppointmentReminderInfo();
                try {
                    appointmentReminderInfo.FromXml(ReminderInfoXml);
                    AlarmTime = appointmentReminderInfo.ReminderInfos[0].AlertTime;
                }
                catch(XmlException e) {
                    Tracing.Tracer.LogError(e);
                }
            }
            else {
                AlarmTime = null;
                RemindInSeconds = NoneReminder;
                IsPostponed = false;
            }
        }
        private IList<PostponeTime> CreatePostponeTimes() {
            IList<PostponeTime> result = PostponeTime.CreateDefaultPostponeTimesList();
            result.Add(new PostponeTime("None", null, "None"));
            result.Add(new PostponeTime("AtStartTime", TimeSpan.Zero, "At Start Time"));
            CustomizeNotificationsPostponeTimeListEventArgs args = new CustomizeNotificationsPostponeTimeListEventArgs(result);
            if(CustomizeReminderTimeLookup != null) {
                CustomizeReminderTimeLookup(this, args);
            }
            PostponeTime.SortPostponeTimesList(args.PostponeTimesList);
            return args.PostponeTimesList;
        }
		public Event() {
            RemindInSeconds = NoneReminder;
		}
		public void UpdateResourceIds() {
			resourceIds = "<ResourceIds>\r\n";
			foreach(Resource resource in Resources) {
				resourceIds += String.Format("<ResourceId Type=\"{0}\" Value=\"{1}\" />\r\n", resource.Key.GetType().FullName, resource.Key);
			}
			resourceIds += "</ResourceIds>";
		}
		[Browsable(false)]
		public String ResourceId {
			get {
				if(resourceIds == null) {
					UpdateResourceIds();
				}
				return resourceIds;
			}
			set {
				if(resourceIds != value) {
					resourceIds = value;
					if(objectSpace != null) {
						UpdateResources();
					}
					else {
						isUpdateResourcesDelayed = true;
					}
				}
			}
		}
		[Browsable(false)]
		public Object AppointmentId {
			get { return ID; }
		}
		[Browsable(false)]
		[RuleFromBoolProperty("EventIntervalValid", DefaultContexts.Save, "The start date must be less than the end date", SkipNullOrEmptyValues = false, UsedProperties = "StartOn, EndOn")]
		public Boolean IsIntervalValid {
			get { return StartOn <= EndOn; }
		}

        IRecurrentEvent IRecurrentEvent.RecurrencePattern {
			get { return RecurrencePattern; }
			set { RecurrencePattern = (Event)value; }
		}
		DateTime IEvent.StartOn {
			get {
				if(StartOn.HasValue) {
					return StartOn.Value;
				}
				else {
					return DateTime.MinValue;
				}
			}
			set { StartOn = value; }
		}
		DateTime IEvent.EndOn {
			get {
				if(EndOn.HasValue) {
					return EndOn.Value;
				}
				else {
					return DateTime.MinValue;
				}
			}
			set { EndOn = value; }
		}
        [ImmediatePostData]
        [ModelDefault("AllowClear", "False")]
        [DataSourceProperty("PostponeTimeList")]
        [SearchMemberOptions(SearchMemberMode.Exclude)]
        public PostponeTime ReminderTime {
            get {
                if(RemindIn.HasValue) {
                    return PostponeTimeList.Where(x => (x.RemindIn != null && x.RemindIn.Value == RemindIn.Value)).FirstOrDefault();
                }
                else {
                    return PostponeTimeList.Where(x => x.RemindIn == null).FirstOrDefault();
                }
            }
            set {
                if(value.RemindIn.HasValue) {
                    RemindIn = value.RemindIn.Value;
                }
                else {
                    RemindIn = null;
                }
                if(objectSpace != null) {
                    objectSpace.SetModified(this);
                }
            }
        }
        [Browsable(false)]
        public IEnumerable<PostponeTime> PostponeTimeList {
            get {
                if(postponeTimes == null) {
                    postponeTimes = CreatePostponeTimes();
                }
                return postponeTimes;
            }
        }
        [Browsable(false)]
        public TimeSpan? RemindIn {
            get {
                if(RemindInSeconds < 0) {
                    return null;
                }
                else {
                    return TimeSpan.FromSeconds(RemindInSeconds);
                }
            }
            set {
                if(RemindIn.HasValue && value.HasValue && RemindIn.Value != value.Value || RemindIn.HasValue && !value.HasValue || !RemindIn.HasValue && value.HasValue) {
                    OnPropertyChanging("RemindIn");
                    if(value.HasValue) {
                        RemindInSeconds = (int)value.Value.TotalSeconds;
                    }
                    else {
                        RemindInSeconds = NoneReminder;
                    }
                    OnPropertyChanged("RemindIn");
                }
            }
        }
        [VisibleInDetailView(false), VisibleInListView(false), VisibleInLookupListView(false)]
        public string NotificationMessage {
            get { return Subject; }
        }
        [Browsable(false)]
        public object UniqueId {
            get { return ID; }
        }
        partial void OnReminderInfoXmlChanging(global::System.String value) {
            cashedReminderInfoXml = ReminderInfoXml;
        }
        partial void OnAlarmTimeChanging(Nullable<global::System.DateTime> value) {
            cashedAlarmTime = AlarmTime;
        }
        partial void OnReminderInfoXmlChanged() {
            if(ReminderInfoXml != cashedReminderInfoXml && objectSpace != null) {
                UpdateAlarmTime();
            }
        }
        partial void OnAlarmTimeChanged() {
            if(AlarmTime != cashedAlarmTime && objectSpace != null) {
                if(AlarmTime == null) {
                    RemindInSeconds = NoneReminder;
                    IsPostponed = false;
                }
                UpdateRemindersInfoXml(true);
            }
        }

		// IObjectSpaceLink
		IObjectSpace IObjectSpaceLink.ObjectSpace {
			get { return objectSpace; }
			set { objectSpace = value; }
		}

		// IXafEntityObject
		void IXafEntityObject.OnCreated() {
		}
		void IXafEntityObject.OnSaving() {
			if((objectSpace != null) && isUpdateResourcesDelayed) {
				isUpdateResourcesDelayed = false;
				UpdateResources();
			}
		}
		void IXafEntityObject.OnLoaded() {
			Resources.Load();
		}
        public event EventHandler<CustomizeNotificationsPostponeTimeListEventArgs> CustomizeReminderTimeLookup;
	}

	public class EventMetadata {
		[Browsable(false)]
		public Int32 ID { get; set; }

		[FieldSize(250)]
		public String Subject { get; set; }

		[FieldSize(FieldSizeAttribute.Unlimited)]
		public String Description { get; set; }

		[Browsable(false)]
		public Int32 Type { get; set; }

		[NonCloneable]
        [StringLength(300)]
		[DisplayName("Recurrence"), FieldSize(FieldSizeAttribute.Unlimited)]
		public String RecurrenceInfoXml { get; set; }

		[Browsable(false)]
		public EntityCollection<Event> RecurrenceEvents { get; set; }

		[Browsable(false)]
		public Event RecurrencePattern { get; set; }

        [VisibleInDetailView(false), VisibleInListView(false), VisibleInLookupListView(false)]
        public bool IsPostponed { get; set; }

        [VisibleInDetailView(false), VisibleInListView(false), VisibleInLookupListView(false)]
        public Nullable<DateTime> AlarmTime { get; set; }

        [NonCloneable]
        [Browsable(false)]
        [StringLength(200)]
        public string ReminderInfoXml { get; set; }
            
        [Browsable(false)]
        public long RemindInSeconds { get; set; }

        [ImmediatePostData]
        public Boolean AllDay { get; set; }
	}
}
