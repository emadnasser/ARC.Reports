using System;
using System.Windows.Forms;
using System.Collections.Generic;

namespace DevExpress.XtraSpreadsheet.Demos {
	static class Program {
		[STAThread]
		static void Main() {
            DemoUtils.SetDatabasePath();
			DevExpress.UserSkins.BonusSkins.Register();
			Application.Run(new frmMain());
		}
	}
}
