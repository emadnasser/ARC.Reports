using System;
using System.Windows.Forms;
using DevExpress.XtraSplashScreen;

namespace DevExpress.XtraBars.Demos.RibbonSimplePad {
    static class Program {
        [STAThread]
        static void Main() {
            DevExpress.UserSkins.BonusSkins.Register();
            DevExpress.Skins.SkinManager.EnableFormSkins();
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            SplashScreenManager.ShowForm((Form)null, typeof(RibbonSimplePadSplashScreen), true, true);
            Application.Run(new frmMain());
        }
    }
}
