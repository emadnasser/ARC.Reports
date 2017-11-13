using System;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using DevExpress.Skins;
using DevExpress.Skins.Info;
using DevExpress.Internal;

namespace DevExpress.DevAV {
    internal static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main() {
            AppDomain.CurrentDomain.AssemblyResolve += OnCurrentDomainAssemblyResolve;
            DataDirectoryHelper.LocalPrefix = "WinHybridApp";
            bool exit;
            using(IDisposable singleInstanceApplicationGuard = DataDirectoryHelper.SingleInstanceApplicationGuard("DevExpressWinHybridApp", out exit)) {
                if(exit && IsTablet)
                    return;
                DevExpress.XtraEditors.WindowsFormsSettings.SetDPIAware();
                DevExpress.XtraEditors.WindowsFormsSettings.EnableFormSkins();
                DevExpress.XtraEditors.WindowsFormsSettings.AllowPixelScrolling = Utils.DefaultBoolean.True;
                DevExpress.XtraEditors.WindowsFormsSettings.ScrollUIMode = XtraEditors.ScrollUIMode.Touch;
                ((DevExpress.LookAndFeel.Design.UserLookAndFeelDefault)DevExpress.LookAndFeel.Design.UserLookAndFeelDefault.Default).LoadSettings(() =>
                {
                    var skinCreator = new SkinBlobXmlCreator("HybridApp", "DevExpress.DevAV.SkinData.", typeof(Program).Assembly, null);
                    SkinManager.Default.RegisterSkin(skinCreator);
                });
                LookAndFeel.UserLookAndFeel.Default.SetSkinStyle("HybridApp");
                float fontSize = 11f;
                DevExpress.XtraEditors.WindowsFormsSettings.DefaultFont = new Font("Segoe UI", fontSize);
                DevExpress.XtraEditors.WindowsFormsSettings.DefaultMenuFont = new Font("Segoe UI", fontSize);
                Application.CurrentCulture = CultureInfo.GetCultureInfo("en-us");
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                MainForm = new DevAV.MainForm() { Icon = AppIcon };
                if(Program.IsTablet)
                    SetupAsTablet();
                Application.Run(MainForm);
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
        static bool? isTablet = null;
        public static bool IsTablet {
            get {
                if(isTablet == null) {
                    isTablet = DevExpress.DevAV.Common.Utils.DeviceDetector.IsTablet;
                }
                return isTablet.Value;
            }
        }
        public static Icon AppIcon {
            get { return DevExpress.Utils.ResourceImageHelper.CreateIconFromResourcesEx("DevExpress.DevAV.Resources.AppIcon.ico", typeof(MainForm).Assembly); }
        }
        public static MainForm MainForm {
            get;
            private set;
        }
        public static void SetupAsTablet() {
            MainForm.ShowTileNavPane();
            MainForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            MainForm.WindowState = FormWindowState.Maximized;
            DevExpress.XtraEditors.WindowsFormsSettings.PopupMenuStyle = XtraEditors.Controls.PopupMenuStyle.RadialMenu;
            DevExpress.Utils.TouchHelpers.TouchKeyboardSupport.EnableTouchKeyboard = true;
        }
    }
}
