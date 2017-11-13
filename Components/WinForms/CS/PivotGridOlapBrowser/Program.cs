using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DevExpress.XtraPivotGrid;
using DevExpress.XtraEditors;

namespace PivotGridOlapBrowser {
    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            DevExpress.Skins.SkinManager.EnableFormSkins();
            Application.SetCompatibleTextRenderingDefault(false);

            if(!AdomdMetaGetter.IsProviderAvailable) {
                XtraMessageBox.Show("You should install Adomd Client assemblies and Ole Db Provider for Analysis Services "+
                    "before running this demo", null, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Application.Run(new MainForm());
        }
    }
}
