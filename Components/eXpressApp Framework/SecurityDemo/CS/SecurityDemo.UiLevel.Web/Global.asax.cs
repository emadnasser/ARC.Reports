using System;
using System.Configuration;
using System.Web;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Web;
using DevExpress.ExpressApp.Xpo;
using DevExpress.Web;
using SecurityDemo.Module;
using DevExpress.Internal;
using DevExpress.Persistent.BaseImpl.PermissionPolicy;
using DevExpress.ExpressApp.DC;
using System.Collections.Generic;

namespace SecurityDemo.Web {
    public class Global : System.Web.HttpApplication {
        private static NonPersistentTypeInfoSource nonPersistentTypeInfoSource;
        public Global() {
            InitializeComponent();
        }
        protected void Application_Start(Object sender, EventArgs e) {
            WebApplication.EnableMultipleBrowserTabsSupport = true;
            ASPxWebControl.CallbackError += new EventHandler(Application_Error);
        }
        protected void Session_Start(Object sender, EventArgs e) {
            WebApplication.SetInstance(Session, new SecurityDemoAspNetApplication());
            WebApplication.Instance.CreateCustomLogonWindowObjectSpace += new EventHandler<CreateCustomLogonWindowObjectSpaceEventArgs>(Instance_CreateCustomLogonWindowObjectSpace);
            WebApplication.Instance.CreateCustomLogonWindowControllers += new EventHandler<CreateCustomLogonWindowControllersEventArgs>(Instance_CreateCustomLogonWindowControllers);
            WebApplication.Instance.SwitchToNewStyle();

            SetConnectionString(WebApplication.Instance);
            WebApplication.Instance.CreateCustomObjectSpaceProvider += delegate (object sender3, CreateCustomObjectSpaceProviderEventArgs e1) {
                if(nonPersistentTypeInfoSource == null) {
                    nonPersistentTypeInfoSource = new NonPersistentTypeInfoSource(WebApplication.Instance.TypesInfo, new List<Type> { typeof(SecurityDemoAuthenticationLogonParameters) });
                }
                e1.ObjectSpaceProviders.Add(new XPObjectSpaceProvider(e1.ConnectionString, e1.Connection));
                e1.ObjectSpaceProviders.Add(new NonPersistentObjectSpaceProvider(WebApplication.Instance.TypesInfo, nonPersistentTypeInfoSource));
            };

            if(System.Diagnostics.Debugger.IsAttached && WebApplication.Instance.CheckCompatibilityType == CheckCompatibilityType.DatabaseSchema) {
                WebApplication.Instance.DatabaseUpdateMode = DatabaseUpdateMode.UpdateDatabaseAlways;
            }

            WebApplication.Instance.Setup();
            WebApplication.Instance.Start();
        }
        private void SetConnectionString(WebApplication webApplication) {
            string siteMode = ConfigurationManager.AppSettings["SiteMode"];
            if(siteMode != null && siteMode.ToLower() == "true") {
                webApplication.ConnectionString = InMemoryDataStoreProvider.ConnectionString;
            }
            else {
                ConnectionStringSettings connectionStringSettings = ConfigurationManager.ConnectionStrings["ConnectionString"];
                if(connectionStringSettings != null) {
                    webApplication.ConnectionString = connectionStringSettings.ConnectionString;
                }
                else if(string.IsNullOrEmpty(webApplication.ConnectionString) && webApplication.Connection == null) {
                    connectionStringSettings = ConfigurationManager.ConnectionStrings["SqlExpressConnectionString"];
                    if(connectionStringSettings != null) {
                        webApplication.ConnectionString = DbEngineDetector.PatchConnectionString(connectionStringSettings.ConnectionString);
                    }
                }
            }
        }
        private void Instance_CreateCustomLogonWindowControllers(object sender, CreateCustomLogonWindowControllersEventArgs e) {
            e.Controllers.Add(((XafApplication)sender).CreateController<DevExpress.ExpressApp.Demos.ShowHintController>());
        }
        private void Instance_CreateCustomLogonWindowObjectSpace(object sender, CreateCustomLogonWindowObjectSpaceEventArgs e) {
            e.ObjectSpace = ((XafApplication)sender).CreateObjectSpace(typeof(SecurityDemoAuthenticationLogonParameters));
            if(e.ObjectSpace is NonPersistentObjectSpace) {
                ((NonPersistentObjectSpace)e.ObjectSpace).AdditionalObjectSpaces.Add(((XafApplication)sender).CreateObjectSpace(typeof(PermissionPolicyUser)));
            }
        }
        protected void Application_BeginRequest(Object sender, EventArgs e) {
        }
        protected void Application_EndRequest(Object sender, EventArgs e) {
        }
        protected void Application_AuthenticateRequest(Object sender, EventArgs e) {
        }
        protected void Application_Error(Object sender, EventArgs e) {
            ErrorHandling.Instance.ProcessApplicationError();
        }
        protected void Session_End(Object sender, EventArgs e) {
            WebApplication.DisposeInstance(Session);
        }
        protected void Application_End(Object sender, EventArgs e) {
        }
        #region Web Form Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
        }
        #endregion
    }
}
