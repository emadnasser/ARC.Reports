using DevExpress.DashboardWeb;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Dashboards.Web;
using DevExpress.Persistent.Base;
using System;
using DevExpress.DataAccess.ConnectionParameters;
using XCRM.Module.Dashboards;

namespace XCRM.Module.Web.Controllers {
    public class DashboardCustomizeController : ViewController<DetailView> {
        public DashboardCustomizeController() {
            TargetObjectType = typeof(IDashboardData);
        }
        protected override void OnActivated() {
            base.OnActivated();

            WebDashboardViewerViewItem dashboardViewerViewItem = View.FindItem("DashboardViewer") as WebDashboardViewerViewItem;
            if(dashboardViewerViewItem != null) {
                dashboardViewerViewItem.ControlCreated += DashboardViewerViewItem_ControlCreated;
            }
        }

        private void DashboardViewerViewItem_ControlCreated(object sender, EventArgs e) {
            WebDashboardViewerViewItem dashboardViewerViewItem = sender as WebDashboardViewerViewItem;
            dashboardViewerViewItem.DashboardDesigner.Height = 760;
            dashboardViewerViewItem.DashboardDesigner.ConfigureDataConnection += DashboardDesigner_ConfigureDataConnection;
        }

        private void DashboardDesigner_ConfigureDataConnection(object sender, ConfigureDataConnectionWebEventArgs e) {
            if(e.ConnectionName == "ShippingCountries_XCRM") {
                e.ConnectionParameters = new MsSqlConnectionParameters();
                SqlDashboardHelper.SetupSqlParameters(ObjectSpace, (MsSqlConnectionParameters)e.ConnectionParameters);
            }
        }

        protected override void OnDeactivated() {
            WebDashboardViewerViewItem dashboardViewerViewItem = View.FindItem("DashboardViewer") as WebDashboardViewerViewItem;
            if(dashboardViewerViewItem != null) {
                dashboardViewerViewItem.ControlCreated -= DashboardViewerViewItem_ControlCreated;
            }

            base.OnDeactivated();
        }
    }
}
