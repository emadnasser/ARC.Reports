using System;

namespace DevExpress.XtraScheduler.Demos {
	public partial class GroupByDateModule : DevExpress.XtraScheduler.Demos.TutorialControl {
		public GroupByDateModule() {
			// This call is required by the Windows Form Designer.
			InitializeComponent();
		}
		public override SchedulerControl PrintingSchedulerControl { get { return schedulerControl; } }

		private void GroupByDateModule_Load(object sender, System.EventArgs e) {
            CarsDataHelper.FillData(schedulerControl, schedulerStorage);
        }
		private void GroupByDateModule_VisibleChanged(object sender, EventArgs e) {
			if (Visible)
				UpdateCaption();
		}
		void UpdateCaption() {
			Caption.Text = String.Format("Grouping {0}", TutorialName);
		}
	}
}

