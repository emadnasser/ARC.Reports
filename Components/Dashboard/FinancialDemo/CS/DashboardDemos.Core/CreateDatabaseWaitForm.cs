using System;
using System.Collections.Generic;
using DevExpress.XtraWaitForm;

namespace DashboardDemos.Core {
    public partial class CreateDatabaseWaitForm : WaitForm {
        public CreateDatabaseWaitForm() {
            InitializeComponent();
            progressBar.Properties.Maximum  = DashboardDemosUtils.DatabaseCreationMaxStep;
        }
        public override void SetCaption(string caption) {
            base.SetCaption(caption);
            labelCaption.Text = caption;
        }
        void timerProgress_Tick(object sender, EventArgs e) {
            progressBar.EditValue = DashboardDemosUtils.DatabaseCreationCurrentStep;
        }
        void CreateDatabaseWaitForm_Load(object sender, EventArgs e) {
            timerProgress.Start();
        }

    }
}
