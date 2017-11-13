using System;
using System.Windows.Forms;
using System.Collections.Generic;

namespace DevExpress.XtraMap.Demos {
	static class Program {
		[STAThread]
		static void Main() {
			DevExpress.UserSkins.BonusSkins.Register();
			Application.Run(new frmMain());
		}

	}
}
