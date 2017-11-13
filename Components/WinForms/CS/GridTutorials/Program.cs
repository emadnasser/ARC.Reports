using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DevExpress.XtraGrid.Demos.Tutorials {
    static class Program {
		[STAThread]
		static void Main() {
            DevExpress.UserSkins.BonusSkins.Register();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new frmMain());
		}

    }
}
