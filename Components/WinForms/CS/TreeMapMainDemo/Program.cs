using System;
using System.Windows.Forms;

namespace DevExpress.XtraTreeMap.Demos {
	static class Program {
		[STAThread]
		static void Main() {
			DevExpress.UserSkins.BonusSkins.Register();
			Application.Run(new frmMain());
		}
	}
}
