using System;
using System.Linq;
using System.Web.Mvc;
using System.Web.Routing;
using DevExpress.Web.Mvc;
using DevExpress.XtraReports.Security;

namespace DevExpress.Web.Demos {
    // Note: For instructions on enabling IIS6 or IIS7 classic mode,
    // visit http://go.microsoft.com/?LinkId=9394801
    public class MvcApplication : System.Web.HttpApplication {
        public static void RegisterRoutes(RouteCollection routes) {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.IgnoreRoute("{resource}.ashx/{*pathInfo}");

            routes.MapRoute(
                "Default",                                              // Route name
                "{controller}/{action}/{id}",                           // URL with parameters
                new { controller = "Home", action = "Index", id = "" }  // Parameter defaults
            );
        }

        protected void Application_Start() {
            
            RegisterRoutes(RouteTable.Routes);
            DevExpress.XtraReports.Web.ReportDesigner.Native.ReportDesignerBootstrapper.SessionState = System.Web.SessionState.SessionStateBehavior.Required;
            DevExpress.XtraReports.Web.WebDocumentViewer.Native.WebDocumentViewerBootstrapper.SessionState = System.Web.SessionState.SessionStateBehavior.Required;
            DevExpress.XtraReports.Web.WebDocumentViewer.DefaultWebDocumentViewerContainer.RegisterWebDocumentViewerDrillThroughProcessor<WebDocumentViewerDrillThroughProcessor>();
            DevExpress.XtraReports.Web.ReportDesigner.DefaultReportDesignerContainer.RegisterDataSourceWizardConnectionStringsProvider<DataSourceWizardConnectionStringsProvider>();
            ModelBinders.Binders.DefaultBinder = new DevExpressEditorsBinder();
            DevExpress.Internal.DataDirectoryHelper.DataFolderName = "App_Data";
            DevExpress.XtraReports.Web.Extensions.ReportStorageWebExtension.RegisterExtensionGlobal(DemoReportStorageExtension.ReportStorageExtension);
            //DevExpress.XtraReports.Native.ReportStorageService.RegisterTool(new DevExpress.Web.Demos.Code.Designer.ReportStorageTool());
            DevExpress.Web.ASPxWebControl.CallbackError += new EventHandler(CallbackError);
            DevExpress.XtraReports.Web.WebDocumentViewer.DefaultWebDocumentViewerContainer.UseFileDocumentStorage(Server.MapPath("~/App_Data/WebDocumentViewerCache"));
            DevExpress.XtraReports.Web.Native.ClientControls.Services.DefaultLoggingService.SetInstance(new DemoLoggingService());
            DevExpress.XtraReports.Web.ASPxReportDesigner.ShouldClearReportScripts = true;
            ScriptPermissionManager.GlobalInstance = new ScriptPermissionManager(ExecutionMode.Unrestricted);
        }

        void CallbackError(object sender, EventArgs e) {
            // Logging exceptions occur on callback events of DevExpress ASP.NET MVC controls.
            // To learn more, see http://www.devexpress.com/Support/Center/Example/Details/E4588
        }

        protected void Session_Start(object sender, EventArgs e) {
            Session["urls"] = ReportDemoHelper.Reports.ToDictionary((x) => x.Key, (x) => x.Key);
        }

        protected void Application_PreRequestHandlerExecute(object sender, EventArgs e) {
            DevExpressHelper.Theme = Utils.CurrentTheme;
            if(DevExpressHelper.IsCallback)
                Utils.RegisterCurrentMvcDemoOnCallback();
        }
    }
}
