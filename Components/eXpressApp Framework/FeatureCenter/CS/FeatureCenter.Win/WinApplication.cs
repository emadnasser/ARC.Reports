using System;
using System.Configuration;

using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Win;
using DevExpress.ExpressApp.Xpo;
using DevExpress.ExpressApp.EF;
using DevExpress.Internal;
using FeatureCenter.Module;
using FeatureCenter.Module.ListEditors;

namespace FeatureCenter.Win {
	public partial class FeatureCenterWindowsFormsApplication : WinApplication {
		public FeatureCenterWindowsFormsApplication() {
			InitializeComponent();
            this.notificationsModule.NotificationsRefreshInterval = TimeSpan.FromMinutes(1);
		}

		private void FeatureCenterWindowsFormsApplication_DatabaseVersionMismatch(object sender, DevExpress.ExpressApp.DatabaseVersionMismatchEventArgs e) {
			e.Updater.Update();
			e.Handled = true;
		}

		private static FeatureCenterXpoDataStoreProvider provider;
		protected override void CreateDefaultObjectSpaceProvider(CreateCustomObjectSpaceProviderEventArgs args) {
			provider = new FeatureCenterXpoDataStoreProvider();
			args.ObjectSpaceProviders.Add(new XPObjectSpaceProvider(provider, true));
			provider.Initialize(
				String.Format(@"XpoProvider=InMemoryDataStore; Read Only=True; Data Source={0}nwind.xml", AppDomain.CurrentDomain.SetupInformation.ApplicationBase),
				GetConnectionString());
			args.ObjectSpaceProviders.Add(new EFObjectSpaceProvider(typeof(TestDbContext), FeatureCenterModule.GetEFConnectionString()));
            args.ObjectSpaceProviders.Add(new NonPersistentObjectSpaceProvider(TypesInfo, null));
        }
		private String GetConnectionString() {
			String result = null;
			ConnectionStringSettings connectionStringSettings = ConfigurationManager.ConnectionStrings["ConnectionString"];
			if(connectionStringSettings != null) {
				result = connectionStringSettings.ConnectionString;
			}
			else {
				connectionStringSettings = ConfigurationManager.ConnectionStrings["SqlExpressConnectionString"];
				if(connectionStringSettings != null) {
					result = DbEngineDetector.PatchConnectionString(connectionStringSettings.ConnectionString);
				}
			}

			return result;
		}
		// You can also localize or customize built-in XAF status messages by overriding the XafApplication.UpdateStatus method (test the Context parameter with the DevExpress.ExpressApp.Localization.ApplicationStatusMesssageId enumeration value).
		public override void UpdateStatus(string context, string title, string message, params object[] additionalParams) {
			bool localizableDemoFlag = false;
			if(localizableDemoFlag) {
				if(context == DevExpress.ExpressApp.Localization.ApplicationStatusMessageId.ApplicationSetupStarted.ToString()) {
					title = "My localized title";
					message = "My localized message";
				}
			}
			base.UpdateStatus(context, title, message, additionalParams);
		}
	}
}
