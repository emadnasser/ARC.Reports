using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Globalization;
using DevExpress.XtraEditors.Repository;

namespace DevExpress.XtraGrid.Demos {
    static class Program {
        [STAThread]
        static void Main(string[] arguments) {
            //DevExpress.Skins.SkinManager.SetDPIAware();
            RepositoryItemTextEdit.MaxToolTipTextLength = 1000;
            DevExpress.Utils.LocalizationHelper.SetCurrentCulture(arguments);            
            CultureInfo demoCI = (CultureInfo)Application.CurrentCulture.Clone();
            demoCI.NumberFormat.CurrencySymbol = "$";
            demoCI.NumberFormat.CurrencyDecimalDigits = 2;
            Application.CurrentCulture = demoCI;
            DevExpress.UserSkins.BonusSkins.Register();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMain(arguments));
        }
    }
}
