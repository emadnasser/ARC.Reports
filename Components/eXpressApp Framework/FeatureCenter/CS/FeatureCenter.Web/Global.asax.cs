using System;
using System.Configuration;
using System.Web;
using DevExpress.ExpressApp.Web;
using DevExpress.ExpressApp.Web.TestScripts;
using DevExpress.ExpressApp.Xpo;
using DevExpress.Web;
using DevExpress.Persistent.Base;
using DevExpress.ExpressApp.Notifications;
using DevExpress.ExpressApp;

namespace FeatureCenter.Web
{
    public class Global : System.Web.HttpApplication
    {
        public Global() {
#if DEBUG
            DevExpress.EasyTest.Framework.EasyTestTracer.Tracer.SetTraceLevel(System.Diagnostics.TraceLevel.Verbose);
#endif
            InitializeComponent();
        }
        protected void Application_Start(Object sender, EventArgs e)
        {
            WebApplication.EnableMultipleBrowserTabsSupport = true;
            try {
                ASPxWebControl.CallbackError += new EventHandler(Application_Error);
            }
            catch(Exception exception) {
                Tracing.Tracer.LogError(exception);
                throw exception;
            }
        }
        protected void Session_Start(Object sender, EventArgs e)
        {
            Tracing.Initialize();
            FeatureCenterAspNetApplication application = new FeatureCenterAspNetApplication();
            application.EnableModelCache = true;
            application.LinkNewObjectToParentImmediately = false;
            WebApplication.SetInstance(Session, application);

            NotificationsModule notificationsModule = application.Modules.FindModule<NotificationsModule>();
            notificationsModule.NotificationsRefreshInterval = TimeSpan.FromMinutes(1);

            DevExpress.ExpressApp.ScriptRecorder.ScriptRecorderControllerBase.ScriptRecorderEnabled = true;
            if(System.Diagnostics.Debugger.IsAttached && WebApplication.Instance.CheckCompatibilityType == CheckCompatibilityType.DatabaseSchema) {
                WebApplication.Instance.DatabaseUpdateMode = DatabaseUpdateMode.UpdateDatabaseAlways;
            }
			application.Setup();
			application.Start();
        }
        protected void Application_BeginRequest(Object sender, EventArgs e) {
        }
        protected void Application_EndRequest(Object sender, EventArgs e)
        {
        }
        protected void Application_AuthenticateRequest(Object sender, EventArgs e)
        {
        }
        protected void Application_Error(Object sender, EventArgs e)
        {
            ErrorHandling.Instance.ProcessApplicationError();
        }
        protected void Session_End(Object sender, EventArgs e)
        {
            WebApplication.DisposeInstance(Session);
        }
        protected void Application_End(Object sender, EventArgs e)
        {
        }
        #region Web Form Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
        }
        #endregion
    }
}
