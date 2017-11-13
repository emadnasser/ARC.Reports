using System;
using System.Windows.Forms;
using System.Collections.Generic;
using DevExpress.XtraSpellChecker.Native;
using DevExpress.XtraRichEdit.SpellChecker;

namespace DevExpress.XtraRichEdit.Demos {
	static class Program {
		[STAThread]
		static void Main() {
			DevExpress.UserSkins.BonusSkins.Register();
			Application.Run(new frmMain());
		}

	}
}
