using System;
using System.IO;
using DashboardDemos.Core;
using DevExpress.DashboardWeb;
using DevExpress.DataAccess.ConnectionParameters;


namespace FinancialDemo.Tablet {
    public partial class DashboardViewer : System.Web.UI.Page {
        const int dashboardId = 1;
        string dashboardStorageConnectionString, financialDemoConnectionString;
        protected override void OnPreInit(EventArgs e) {
            base.OnPreInit(e);
            if(Request.UserAgent != null && Request.UserAgent.IndexOf("AppleWebKit", StringComparison.CurrentCultureIgnoreCase) > -1) {
                ClientTarget = "uplevel";
            }
        }

        protected override void OnInit(EventArgs e) {
            base.OnInit(e);
            dashboardStorageConnectionString = DashboardDemosUtils.DashboardStorageConnectionString;
            financialDemoConnectionString = DashboardDemosUtils.FinancialDemoConnectionString;          
        }
        protected void Page_Load(object sender, EventArgs e) {
            if (IsPostBack)
                return;
            if (!string.IsNullOrEmpty(dashboardStorageConnectionString))
            ASPxDashboardViewer1.DashboardId = "FinancialDashboard";
        }

        protected void ASPxDashboardViewer1_ConfigureDataConnection(object sender, ConfigureDataConnectionWebEventArgs e) {
            if(e.ConnectionName == "FinanceDemoConnection") {
                CustomStringConnectionParameters connectionParams = new CustomStringConnectionParameters(financialDemoConnectionString);
                e.ConnectionParameters = connectionParams;
            }
            
        }
        protected void ASPxDashboardViewer1_DashboardLoading(object sender, DashboardLoadingEventArgs e) {
            try {
                using(MemoryStream stream = DashboardDemosUtils.GetDashboardStream(dashboardStorageConnectionString, dashboardId))
                    using(StreamReader streamReader = new StreamReader(stream))
                        e.DashboardXml = streamReader.ReadToEnd();
            }
            catch(Exception ex) {
                throw ex;
            }
        }
    }
}
