using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DevExpress.XtraSpellChecker.Demos {
	static class Program {
		[STAThread]
		static void Main() {
			DevExpress.UserSkins.BonusSkins.Register();
			Application.Run(new frmMain());
		}

	}
}
