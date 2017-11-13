using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

using DevExpress.Persistent.Base;
using DevExpress.ExpressApp.ConditionalAppearance;
using DevExpress.ExpressApp.Model;

namespace EFDemo.Module.Data {
    [DefaultClassOptions]
    [ModelDefault("Caption", "Task")]
    [Appearance("FontColorRed", AppearanceItemType = "ViewItem", TargetItems = "*", Context = "ListView", Criteria = "Status!='Completed'", FontColor = "Red")]
    [MetadataType(typeof(DemoTaskMetadata))]
    public partial class DemoTask {
        public DemoTask()
            : base() {
            Priority = Priority.Normal;
        }
        public override String ToString() {
            return Subject;
        }
		[Action(ToolTip = "Postpone the task to the next day", ImageName = "State_Task_Deferred")]
		public void Postpone() {
            if(DueDate == DateTime.MinValue) {
                DueDate = DateTime.Now;
            }
            DueDate = DueDate + TimeSpan.FromDays(1);
        }
		[Appearance("PriorityBackColorPink", AppearanceItemType = "ViewItem", Criteria = "Priority=2", BackColor = "0xfff0f0")]
        public Priority Priority {
            get { return (Priority)Priority_Int; }
            set { Priority_Int = (Int32)value; }
        }
    }

    public class DemoTaskMetadata {
    }
}
