using System;
using System.Windows.Forms;

namespace DevExpress.XtraGauges.Demos {
    static class Program {
        [STAThread]
        static void Main(string[] arguments) {
            DevExpress.UserSkins.BonusSkins.Register();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(new frmMain(arguments));
        }
    }
}
