namespace DevExpress.DevAV {
    using System;
    using System.Drawing;
    using System.IO;
    using System.Reflection;
    using System.Windows.Forms;
    using DevExpress.Internal;
    using DevExpress.Utils.Taskbar;

    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        const string AppName = "DevExpressWinOutlookInspiredApp";
        [STAThread]
        static void Main() {
            TaskbarAssistant.Default.Initialize();
            AppDomain.CurrentDomain.AssemblyResolve += OnCurrentDomainAssemblyResolve;
            DataDirectoryHelper.LocalPrefix = "WinOutlookInspiredApp";
            bool exit;
            using(DataDirectoryHelper.SingleInstanceApplicationGuard(AppName, out exit)) {
                if(exit)
                    return;
                DevExpress.XtraEditors.WindowsFormsSettings.SetDPIAware();
                DevExpress.XtraEditors.WindowsFormsSettings.EnableFormSkins();
                DevExpress.XtraEditors.WindowsFormsSettings.DefaultLookAndFeel.SetSkinStyle("Office 2016 Colorful");
                DevExpress.XtraEditors.WindowsFormsSettings.AllowPixelScrolling = Utils.DefaultBoolean.True;
                DevExpress.Utils.AppearanceObject.DefaultFont = new Font("Segoe UI", AppHelper.GetDefaultSize());
                DevExpress.XtraEditors.WindowsFormsSettings.ScrollUIMode = XtraEditors.ScrollUIMode.Touch;
                DevExpress.XtraEditors.WindowsFormsSettings.CustomizationFormSnapMode = Utils.Controls.SnapMode.OwnerControl;
                DevExpress.XtraEditors.WindowsFormsSettings.ColumnFilterPopupMode = XtraEditors.ColumnFilterPopupMode.Excel;
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                using(new StartUpProcess()) {
                    using(StartUpProcess.Status.Subscribe(new DemoStartUp())) {
                        Application.Run(new MainForm());
                    }
                }
            }
        }
        static Assembly OnCurrentDomainAssemblyResolve(object sender, ResolveEventArgs args) {
            string partialName = DevExpress.Utils.AssemblyHelper.GetPartialName(args.Name).ToLower();
            if(partialName == "entityframework" || partialName == "system.data.sqlite" || partialName == "system.data.sqlite.ef6") {
                string path = Path.Combine(Path.GetDirectoryName(typeof(Program).Assembly.Location), partialName + ".dll");
                return Assembly.LoadFrom(path);
            }
            return null;
        }
    }
}
