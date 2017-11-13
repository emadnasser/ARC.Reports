using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.Skins;

namespace TabbedBrowser {
    class TabbedBrowserApplicationContext : ApplicationContext {
        static int formCount;
        public TabbedBrowserApplicationContext() {
            formCount = 0;
            RootMainForm rootForm = new RootMainForm();
            rootForm.Shown += new EventHandler(rootForm_Shown);
            rootForm.Disposed += new EventHandler(rootForm_Disposed);
            rootForm.Show();
        }
        public static void rootForm_Disposed(object sender, EventArgs e) {
            formCount--;
            if(formCount == 0) Application.Exit();
        }
        public static void rootForm_Shown(object sender, EventArgs e) {
            formCount++;
        }
    }
    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            DevExpress.UserSkins.BonusSkins.Register();
            SkinManager.EnableFormSkins();
            DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle("Seven Classic");
            DevExpress.Utils.BrowserEmulationHelper.DisableBrowserEmulation(System.Reflection.Assembly.GetEntryAssembly().GetName().Name);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);            
            Application.Run(new TabbedBrowserApplicationContext());
        }
    }
}
