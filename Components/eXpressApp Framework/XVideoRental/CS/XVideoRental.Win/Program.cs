using System;
using System.Configuration;
using System.Windows.Forms;
using DevExpress.ExpressApp.Security;
using DevExpress.ExpressApp.Win.Utils;
using DevExpress.Internal;
using DevExpress.ExpressApp;

namespace XVideoRental.Win {
	static class Program {

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main(string[] arguments) {

#if DEBUG
			DevExpress.ExpressApp.Win.EasyTest.EasyTestRemotingRegistration.Register();
#endif

			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			EditModelPermission.AlwaysGranted = System.Diagnostics.Debugger.IsAttached;
			var winApplication = new XVideoRentalWindowsFormsApplication();
#if !DEBUG
            winApplication.SplashScreen = new DXSplashScreen();
#endif
			ConnectionStringSettings connectionStringSettings = ConfigurationManager.ConnectionStrings["ConnectionString"];
			if(connectionStringSettings != null) {
				winApplication.ConnectionString = connectionStringSettings.ConnectionString;
			}
			else if(string.IsNullOrEmpty(winApplication.ConnectionString) && winApplication.Connection == null) {
				connectionStringSettings = ConfigurationManager.ConnectionStrings["SqlExpressConnectionString"];
				if(connectionStringSettings != null) {
					winApplication.ConnectionString = DbEngineDetector.PatchConnectionString(connectionStringSettings.ConnectionString);
				}
			}
            if(System.Diagnostics.Debugger.IsAttached && winApplication.CheckCompatibilityType == CheckCompatibilityType.DatabaseSchema) {
                winApplication.DatabaseUpdateMode = DatabaseUpdateMode.UpdateDatabaseAlways;
            } 
            try {
				winApplication.Setup();
				winApplication.Start();
			} catch(Exception e) {
				winApplication.HandleException(e);
			}
		}
	}

}
