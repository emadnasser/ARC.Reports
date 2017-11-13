using System;
using System.Configuration;
using System.Windows.Forms;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Security;
using DevExpress.ExpressApp.Win.SystemModule;
using DevExpress.Persistent.Base;
using DevExpress.XtraBars.Ribbon;
using FeatureCenter.Module.Win;

namespace FeatureCenter.Win
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
		[STAThread]
        static void Main()
        {
            //XafTypesInfo.Instance.RegisterEntity("PropertyLogicImplementation", typeof(FeatureCenter.Module.DC.IPropertyLogicImplementation));
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			EditModelPermission.AlwaysGranted = System.Diagnostics.Debugger.IsAttached;
			FeatureCenterWindowsFormsApplication xafApplication = new FeatureCenterWindowsFormsApplication();
            if(Tracing.GetFileLocationFromSettings() == FileLocation.CurrentUserApplicationDataFolder) {
                Tracing.LocalUserAppDataPath = Application.LocalUserAppDataPath;
            }
            Tracing.Initialize();
            xafApplication.LinkNewObjectToParentImmediately = false;
            xafApplication.EnableModelCache = true;
            // Refer to the http://documentation.devexpress.com/#Xaf/CustomDocument2680 help article for more details on how to provide a custom splash form.
            //xafApplication.SplashScreen = new DevExpress.ExpressApp.Win.Utils.DXSplashScreen();
            xafApplication.CreateCustomTemplate += new EventHandler<CreateCustomTemplateEventArgs>(xafApplication_CreateCustomTemplate);

			if(ConfigurationManager.ConnectionStrings["ConnectionString"] != null) {
				xafApplication.ConnectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
			}
            DevExpress.ExpressApp.ScriptRecorder.ScriptRecorderControllerBase.ScriptRecorderEnabled = true;
            if(System.Diagnostics.Debugger.IsAttached && xafApplication.CheckCompatibilityType == CheckCompatibilityType.DatabaseSchema) {
                xafApplication.DatabaseUpdateMode = DatabaseUpdateMode.UpdateDatabaseAlways;
            }
            try
            {
				xafApplication.Setup();
				xafApplication.Start();
            }
            catch (Exception e)
            {
				xafApplication.HandleException(e);
            }
        }

        static void xafApplication_CreateCustomTemplate(object sender, CreateCustomTemplateEventArgs e) {
            bool isRibbon = ((IModelOptionsWin)e.Application.Model.Options).FormStyle == RibbonFormStyle.Ribbon;
            if(e.Context == TemplateContext.ApplicationWindow) {
                if(isRibbon) {
                    e.Template = new MainRibbonForm();
                }
                else {
                    e.Template = new MainForm();
                }
            }
            else if(e.Context == TemplateContext.View) {
                if(isRibbon) {
                    e.Template = new DetailRibbonForm();
                }
                else {
                    e.Template = new DetailForm();
                }
            }
        }
    }
}
