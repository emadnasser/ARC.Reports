using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DevExpress.XtraBars.Demos.BrowserDemo {
    static class Program {
        [STAThread]
        static void Main() {
            DevExpress.Skins.SkinManager.EnableFormSkins();
            DevExpress.Utils.BrowserEmulationHelper.DisableBrowserEmulation(System.Reflection.Assembly.GetEntryAssembly().GetName().Name);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            new frmMain().Show();
            Application.Run();
        }

    }
}
