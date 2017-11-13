using System;
using System.Windows.Forms;

namespace DevExpress.XtraScheduler.Demos {
    static class Program {
        [STAThread]
        static void Main() {
            SchedulerDemoLogify.Register();

            DevExpress.UserSkins.BonusSkins.Register();
            Application.Run(new frmMain());
        }
    }
}
