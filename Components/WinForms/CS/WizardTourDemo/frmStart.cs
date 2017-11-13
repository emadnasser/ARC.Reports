using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.Skins;

namespace DevExpress.XtraWizard.Demos {
    public partial class frmStart : XtraForm {
        public frmStart() {
            InitializeComponent();
            foreach(SkinContainer cnt in SkinManager.Default.Skins) 
                listBoxControl1.Items.Add(cnt.SkinName);
            listBoxControl1.SelectedItem = DevExpress.LookAndFeel.UserLookAndFeel.Default.ActiveSkinName;
        }

        public string SelectedSkinName { get { return listBoxControl1.SelectedItem.ToString(); } }
        public bool AllowAnimation { get { return checkEdit1.Checked; } }
        public bool AllowSkin4Form { get { return checkEdit2.Checked; } }
        public WizardStyle WizardStyle { get { return WizardStyle.Wizard97; } }

        private void listBoxControl1_SelectedIndexChanged(object sender, EventArgs e) {
            DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle(SelectedSkinName);
        }
    }
}
