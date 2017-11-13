using System;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Security;
using DevExpress.ExpressApp.Win;
using DevExpress.ExpressApp.Xpo;
using DevExpress.ExpressApp.EF;
using System.Data.Common;
using XCRM.Module.Data;

namespace XCRM.Win {
	public partial class XCRMWinApplication : WinApplication {
		public XCRMWinApplication() {
			InitializeComponent();
		}
		private void XCRMWinApplication_DatabaseVersionMismatch(object sender, DatabaseVersionMismatchEventArgs e) {
			e.Updater.Update();
			e.Handled = true;
		}
        private void XCRMWinApplication_LastLogonParametersRead(object sender, LastLogonParametersReadEventArgs e) {
            // Just to read demo user name for logon.
            AuthenticationStandardLogonParameters logonParameters = e.LogonObject as AuthenticationStandardLogonParameters;
            if(logonParameters != null) {
                if(String.IsNullOrEmpty(logonParameters.UserName)) {
					logonParameters.UserName = XCRM.Module.Updater.AdministratorUserName;
                }
            }
        }
        protected override DevExpress.ExpressApp.Core.ControllersManager CreateControllersManager() {
            DevExpress.ExpressApp.Core.ControllersManager result = base.CreateControllersManager();
            result.RegisterController(new Demo.Module.Win.DemoAboutInfoController());
            result.RegisterController(new Demo.Module.Win.DashboardCustomizeController());
            return result;
        }
        protected override void CreateDefaultObjectSpaceProvider(CreateCustomObjectSpaceProviderEventArgs args) {
            if (args.Connection != null) {
                args.ObjectSpaceProvider = new EFObjectSpaceProvider(typeof(XCRMDbContext), TypesInfo, null, (DbConnection)args.Connection);
            } else {
                args.ObjectSpaceProvider = new EFObjectSpaceProvider(typeof(XCRMDbContext), TypesInfo, null, args.ConnectionString);
            }
        }
        /*private static XCRMXpoDataStoreProvider provider;
        protected override void OnCreateCustomObjectSpaceProvider(CreateCustomObjectSpaceProviderEventArgs args) {
            base.OnCreateCustomObjectSpaceProvider(args);
            provider = new XCRMXpoDataStoreProvider();
            args.ObjectSpaceProvider = new ObjectSpaceProvider(provider);
            provider.Initialize(this.XPDictionary,
                string.Format(@"XpoProvider=XmlDataSet; Read Only=True; Data Source={0}nwind.xml", AppDomain.CurrentDomain.SetupInformation.ApplicationBase),
                this.ConnectionString);
        }*/
	}
}
