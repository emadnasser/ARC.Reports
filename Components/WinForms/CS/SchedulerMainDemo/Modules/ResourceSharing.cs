using System;

namespace DevExpress.XtraScheduler.Demos {
    public partial class ResourceSharingModule : DevExpress.XtraScheduler.Demos.TutorialControl {
        const string AttendeeDescription = "The following persons are invited:\r\n";

        public ResourceSharingModule() {
            // This call is required by the Windows Form Designer.
            InitializeComponent();

            // TODO: Add any initialization after the InitializeComponent call
        }
        public override SchedulerControl PrintingSchedulerControl { get { return schedulerControl; } }

        private void GroupByDateModule_Load(object sender, System.EventArgs e) {
            schedulerControl.Start = DateTime.Today;
            DemoUtils.FillResources(schedulerStorage, int.MaxValue);
            //schedulerControl.GroupType = SchedulerGroupType.Resource;
            //schedulerStorage.Appointments.ResourceSharing = true;
            PrepareMeetings();
        }

        #region data initialization
        void PrepareMeetings() {
            int resourceCount = schedulerStorage.Resources.Count;
            System.Diagnostics.Debug.Assert(resourceCount == 8);

            schedulerStorage.BeginUpdate();
            try {
                DateTime today = DateTime.Today;
                Appointment apt = CreateMeeting("Morning meeting", today + TimeSpan.FromHours(9), new int[] { 1, 3, 5 });
                apt.StatusKey = 2;
                apt.LabelKey = 2;
                schedulerStorage.Appointments.Add(apt);

                int dayShift = DemoUtils.RandomInstance.Next(3);
                apt = CreateMeeting("Product delivery planning", today + TimeSpan.FromDays(dayShift) + TimeSpan.FromHours(12), new int[] { 2, 4, 5 });
                apt.StatusKey = 2;
                apt.LabelKey = 5;
                schedulerStorage.Appointments.Add(apt);

                dayShift = DemoUtils.RandomInstance.Next(3);
                apt = CreateMeeting("New product concept presentation", today + TimeSpan.FromDays(dayShift) + TimeSpan.FromHours(14), new int[] { 2, 3, 6 });
                apt.StatusKey = 1;
                apt.LabelKey = 6;
                schedulerStorage.Appointments.Add(apt);

                dayShift = DemoUtils.RandomInstance.Next(3);
                apt = CreateMeeting("Discussion", today + TimeSpan.FromDays(dayShift) + TimeSpan.FromHours(16), new int[] { 1, 2, 3, 5 });
                apt.StatusKey = 2;
                apt.LabelKey = 5;
                schedulerStorage.Appointments.Add(apt);

                dayShift = DemoUtils.RandomInstance.Next(3);
                apt = CreateMeeting("New employee interview", today + TimeSpan.FromDays(dayShift) + TimeSpan.FromHours(11), new int[] { 2, 3 });
                apt.StatusKey = 1;
                apt.LabelKey = 4;
                schedulerStorage.Appointments.Add(apt);
            }
            finally {
                schedulerStorage.EndUpdate();
            }
        }
        Appointment CreateMeeting(string subject, DateTime date, int[] participants) {
            Appointment apt = schedulerStorage.CreateAppointment(AppointmentType.Normal);
            apt.Start = date;
            apt.Duration = TimeSpan.FromHours(1);
            apt.Subject = subject;

            string description = AttendeeDescription;
            int count = participants.Length;
            for (int i = 0; i < count; i++) {
                Resource resource = schedulerStorage.Resources[participants[i]];
                description += String.Format("{0}\r\n", resource.Caption);
                apt.ResourceIds.Add(resource.Id);
            }
            apt.Description = description;
            return apt;
        }
        #endregion
        private void schedulerStorage_AppointmentChanging(object sender, PersistentObjectCancelEventArgs e) {
            Appointment apt = e.Object as Appointment;
            apt.Description = AttendeeDescription + GetAttendeeNames(apt.ResourceIds);
        }
        private string GetAttendeeNames(AppointmentResourceIdCollection resIds) {
            string result = string.Empty;
            ResourceCollection resources = schedulerStorage.Resources.Items;
            foreach (Resource resource in resources) {
                if (resIds.Contains(resource.Id))
                    result += String.Format("{0}\r\n", resource.Caption);
            }
            return result;
        }

    }
}

