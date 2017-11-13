using System;
using System.IO;
using System.Windows.Forms;
using DashboardDemos.Core;
using DevExpress.DashboardCommon;
using DevExpress.DashboardWin;
using DevExpress.DataAccess.Sql;
using DevExpress.DataAccess.ConnectionParameters;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;

namespace FinancialDemo.Designer {
    public partial class DesignerForm : RibbonForm {        
        const int dashboardId = 1;
        string dashboardStorageConnectionString, financialDemoConnectionString, corporateDemoConnectionString;

        public Dashboard Dashboard {
            get { return dashboardDesigner1.Dashboard; }
            set { dashboardDesigner1.Dashboard = value; }
        }
        public DesignerForm() {
            InitializeComponent();
            dashboardDesigner1.ConfigureDataConnection += dashboardDesigner1_ConfigureDataConnection;
            dashboardDesigner1.DashboardSaving += dashboardDesigner1_DashboardSaving;

           
        } 
        void dashboardDesigner1_ConfigureDataConnection(object sender, DashboardConfigureDataConnectionEventArgs e) {
            if(e.ConnectionName == "FinanceDemoConnection") {
                CustomStringConnectionParameters connectionParameters = new CustomStringConnectionParameters(financialDemoConnectionString);
                e.ConnectionParameters = connectionParameters;
            }
        }
        void dashboardDesigner1_DashboardSaving(object sender, DashboardSavingEventArgs e) {
            if(e.Command == DashboardSaveCommand.Save) {
                try {
                    using (MemoryStream saveStream = new MemoryStream()) {
                        Dashboard.SaveToXml(saveStream);
                        DashboardDemosUtils.SaveDashboardStream(dashboardStorageConnectionString, saveStream, dashboardId);
                    }
                    e.Handled = true;
                }
                catch (Exception ex) {
                    XtraMessageBox.Show(ex.Message, "Finance Demo Dashboard Designer", MessageBoxButtons.OK,  MessageBoxIcon.Error);
                }
            }
        }
        void DesignerForm_Load(object sender, EventArgs e) {
            dashboardDesigner1.CreateRibbon();
            dashboardStorageConnectionString = DashboardDemosUtils.DashboardStorageConnectionString;
            financialDemoConnectionString = DashboardDemosUtils.FinancialDemoConnectionString;
            corporateDemoConnectionString = DashboardDemosUtils.CorporateDemoConnectionString;
            if(!string.IsNullOrEmpty(dashboardStorageConnectionString)) {
                if(DashboardDemosUtils.CreateDatabasesWin(dashboardStorageConnectionString, financialDemoConnectionString,corporateDemoConnectionString)) {
                    Dashboard dashboard = new Dashboard();
                    using(MemoryStream ms = DashboardDemosUtils.GetDashboardStream(dashboardStorageConnectionString, dashboardId)) {
                        dashboard.LoadFromXml(ms);
                    }
                    Dashboard = dashboard;
                }
            }
            else {
                XtraMessageBox.Show("This demo requires SQL Server Express or LocalDB installed to automatically create a sample database. Alternatively, you can manually specify a connection string to the server where the database should be created. You can do this in the connections.config file.");
            }
                        
        }
    }
}
