using System;
using System.Configuration;
using System.Windows.Forms;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Demos;
using DevExpress.ExpressApp.Security;
using DevExpress.ExpressApp.Security.ClientServer;
using DevExpress.ExpressApp.Security.Strategy;
using DevExpress.ExpressApp.Updating;
using SecurityDemo.Module;
using DevExpress.Internal;
using DevExpress.Persistent.BaseImpl.PermissionPolicy;
using System.Collections.Generic;
using DevExpress.ExpressApp.DC;

namespace SecurityDemo.Win {
    static class Program {
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] arguments) {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            SecurityDemoWindowsFormsApplication application = new SecurityDemoWindowsFormsApplication();
            application.CreateCustomTemplate += new EventHandler<CreateCustomTemplateEventArgs>(xafApplication_CreateCustomTemplate);
            application.CreateCustomLogonWindowObjectSpace += new EventHandler<CreateCustomLogonWindowObjectSpaceEventArgs>(application_CreateCustomLogonWindowObjectSpace);
            application.CreateCustomLogonWindowControllers += new EventHandler<CreateCustomLogonWindowControllersEventArgs>(application_CreateCustomLogonWindowControllers);

            try {
                ConnectionStringSettings connectionStringSettings = ConfigurationManager.ConnectionStrings["ConnectionString"];
                if(connectionStringSettings != null) {
                    application.ConnectionString = connectionStringSettings.ConnectionString;
                }
                else if(string.IsNullOrEmpty(application.ConnectionString) && application.Connection == null) {
                    connectionStringSettings = ConfigurationManager.ConnectionStrings["SqlExpressConnectionString"];
                    if(connectionStringSettings != null) {
                        application.ConnectionString = DbEngineDetector.PatchConnectionString(connectionStringSettings.ConnectionString);
                    }
                }


                SecurityStrategyComplex security = new SecurityStrategyComplex(typeof(PermissionPolicyUser), typeof(PermissionPolicyRole), new SecurityDemoAuthentication());
                security.SupportNavigationPermissionsForTypes = false;
                application.Security = security;
                application.CreateCustomObjectSpaceProvider += delegate (object sender, CreateCustomObjectSpaceProviderEventArgs e) {
                    e.ObjectSpaceProvider = new SecuredObjectSpaceProvider(security, e.ConnectionString, e.Connection, false);
                    e.ObjectSpaceProviders.Add(new NonPersistentObjectSpaceProvider(application.TypesInfo, new NonPersistentTypeInfoSource(application.TypesInfo, new List<Type>() { typeof(SecurityDemoAuthenticationLogonParameters) })));
                };
                application.DatabaseVersionMismatch += delegate (object sender, DatabaseVersionMismatchEventArgs e) {
                    try {
                        e.Updater.Update();
                        e.Handled = true;
                    }
                    catch(CompatibilityException exception) {
                        if(exception.Error is CompatibilityUnableToOpenDatabaseError) {
                            throw new UserFriendlyException(
                            "The connection to the database failed. This demo requires the local instance of Microsoft SQL Server Express. To use another database server,\r\nopen the demo solution in Visual Studio and modify connection string in the \"app.config\" file.");
                        }
                    }
                };

                if(System.Diagnostics.Debugger.IsAttached && application.CheckCompatibilityType == CheckCompatibilityType.DatabaseSchema) {
                    application.DatabaseUpdateMode = DatabaseUpdateMode.UpdateDatabaseAlways;
                }

                application.Setup();
                application.Start();
            }
            catch(Exception e) {
                application.HandleException(e);
            }
        }

        static void application_CreateCustomLogonWindowControllers(object sender, CreateCustomLogonWindowControllersEventArgs e) {
            e.Controllers.Add(((XafApplication)sender).CreateController<ShowHintController>());
        }
        static void application_CreateCustomLogonWindowObjectSpace(object sender, CreateCustomLogonWindowObjectSpaceEventArgs e) {
            e.ObjectSpace = ((XafApplication)sender).CreateObjectSpace(typeof(SecurityDemoAuthenticationLogonParameters));
            if(e.ObjectSpace is NonPersistentObjectSpace) {
                ((NonPersistentObjectSpace)e.ObjectSpace).AdditionalObjectSpaces.Add(((XafApplication)sender).CreateObjectSpace(typeof(PermissionPolicyUser)));
            }
        }

        static void xafApplication_CreateCustomTemplate(object sender, CreateCustomTemplateEventArgs e) {
            if(e.Context.Name == TemplateContext.ApplicationWindow) {
                e.Template = new FeatureCenter.Module.Win.MainForm();
            }
            if(e.Context.Name == TemplateContext.PopupWindow) {
                e.Template = new FeatureCenter.Module.Win.PopupForm();
            }
        }
    }
}
