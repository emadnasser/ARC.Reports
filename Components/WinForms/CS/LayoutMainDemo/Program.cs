using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DevExpress.XtraLayout.Demos {
    static class Program {
        [STAThread]
        static void Main() {
            DevExpress.UserSkins.BonusSkins.Register();
            Application.EnableVisualStyles();
            DevExpress.Utils.BrowserEmulationHelper.DisableBrowserEmulation(System.Reflection.Assembly.GetEntryAssembly().GetName().Name);
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMain());
        }

    }
}
