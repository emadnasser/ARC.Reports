using System;

namespace DevExpress.XtraScheduler.Demos {
	public partial class GroupByResourceModule : DevExpress.XtraScheduler.Demos.TutorialControl {
		public GroupByResourceModule() {
			// This call is required by the Windows Form Designer.
			InitializeComponent();

			// TODO: Add any initialization after the InitializeComponent call
		}
		public override SchedulerControl PrintingSchedulerControl { get { return schedulerControl; } }

		private void GroupByResourceModule_Load(object sender, System.EventArgs e) {
            CarsDataHelper.FillData(schedulerControl, schedulerStorage);
        }
		private void GroupByResourceModule_VisibleChanged(object sender, EventArgs e) {
			if (Visible)
				UpdateCaption();
		}
		void UpdateCaption() {
			Caption.Text = String.Format("Grouping {0}", TutorialName);
		}
	}
}

