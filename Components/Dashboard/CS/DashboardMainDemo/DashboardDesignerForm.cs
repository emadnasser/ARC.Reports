using System;
using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.DashboardCommon;
using DevExpress.Utils;
using DevExpress.XtraBars.Ribbon;

namespace DashboardMainDemo {
    public partial class DashboardDesignerForm : RibbonForm {
        bool saveDashboard;

        public Dashboard Dashboard { get { return dashboardDesigner.Dashboard; } }
        public bool SaveDashboard { get { return saveDashboard; } }

        public DashboardDesignerForm(Dashboard dashboard) {
            InitializeComponent();
            Icon = ResourceImageHelper.CreateIconFromResourcesEx("DashboardMainDemo.AppIcon.ico", typeof(frmMain).Assembly);            
            dashboardDesigner.Dashboard = dashboard;
        }
		
        protected override void OnClosing(CancelEventArgs e) {
            base.OnClosing(e);
            if(dashboardDesigner.IsDashboardModified) {
                DialogResult result = XtraMessageBox.Show(LookAndFeel, this, "Do you want to save changes ?", "Dashboard Designer", 
                    MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if(result == DialogResult.Cancel)
                    e.Cancel = true;
                else
                    saveDashboard = result == DialogResult.Yes;
            }
        }

        void DashboardDesignerForm_Load(object sender, EventArgs e) {
            //Comment out the following lines to enable the New, Open, Save and Save As buttons in the Ribbon, 
            //as well as the Backstage View that allows you to quickly reopen recent dashboards.
            fileRibbonPageGroup1.Enabled = false;
            fileNewBarItem1.Enabled = false;
            fileOpenBarItem1.Enabled = false;
            ribbonControl1.Toolbar.ItemLinks.Remove(fileSaveBarItem1);
            dashboardBackstageViewControl1.Enabled = false;
        }
   }
}
