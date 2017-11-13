using System;
using System.IO;
using DashboardDemos.Core;
using DevExpress.DashboardWeb;
using DevExpress.DataAccess.ConnectionParameters;

namespace FinancialDemo.Web {
    public partial class Default : System.Web.UI.Page {
        const int dashboardId = 1;
        string connectionString;
        protected override void OnInit(EventArgs e) {
            base.OnInit(e);                        
            connectionString = DashboardDemosUtils.FinancialDemoConnectionString;
            if(DashboardDemosUtils.ShouldRecreateDatabases(null))
                          Response.Redirect("DatabaseGenerationForm.aspx");                                    
        }
        protected void Page_Load(object sender, EventArgs e) {
            if (IsPostBack)
                return;
            if (!string.IsNullOrEmpty(connectionString))
                ASPxDashboardViewer1.DashboardId = "FinancialDashboard";
        }

        protected void ASPxDashboardViewer1_ConfigureDataConnection(object sender, ConfigureDataConnectionWebEventArgs e) {
            if(e.ConnectionName == "FinanceDemoConnection") {
                CustomStringConnectionParameters connectionParams = new CustomStringConnectionParameters(connectionString);
                e.ConnectionParameters = connectionParams;
            }
        }
        protected void ASPxDashboardViewer1_DashboardLoading(object sender, DashboardLoadingEventArgs e) {
            try {
                using(MemoryStream stream = DashboardDemosUtils.GetDashboardStream(DashboardDemosUtils.DashboardStorageConnectionString, dashboardId))
                    using(StreamReader streamReader = new StreamReader(stream))
                        e.DashboardXml = streamReader.ReadToEnd();
            }
            catch(Exception ex) {
                throw ex;
            }
        }
    }
}
