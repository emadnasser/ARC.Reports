using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

using DevExpress.Persistent.Base;
using DevExpress.Persistent.Base.General;
using DevExpress.ExpressApp.DC;

namespace EFDemo.Module.Data {
    [DefaultProperty("Subject")]
    [MetadataType(typeof(TaskMetadata))]
    public partial class Task : ITask {
		[Action(ImageName = "State_Task_Completed")]
		public void MarkCompleted() {
            Status = TaskStatus.Completed;
        }
        public TaskStatus Status {
            get { return (TaskStatus)Status_Int; }
            set {
				Status_Int = (Int32)value;
				if(value == TaskStatus.Completed) {
					DateCompleted = DateTime.Now;
				}
				else {
					DateCompleted = null;
				}
			}
        }

        // ITask
        DateTime ITask.DateCompleted {
            get {
                if(DateCompleted.HasValue) {
                    return DateCompleted.Value;
                }
                else {
                    return DateTime.MinValue;
                }
            }
        }
        DateTime ITask.DueDate {
            get {
                if(DueDate.HasValue) {
                    return DueDate.Value;
                }
                else {
                    return DateTime.MinValue;
                }
            }
            set { DueDate = value; }
        }
        DateTime ITask.StartDate {
            get {
                if(StartDate.HasValue) {
                    return StartDate.Value;
                }
                else {
                    return DateTime.MinValue;
                }
            }
            set { StartDate = value; }
        }
    }

    public class TaskMetadata {
        [Browsable(false)]
        public Int32 ID { get; set; }
		[FieldSize(FieldSizeAttribute.Unlimited)]
        public String Description { get; set; }
		[Browsable(false)]
		public Int32 Status_Int { get; set; }
    }
}
