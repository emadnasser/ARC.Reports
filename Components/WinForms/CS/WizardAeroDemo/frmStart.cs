using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.Skins;
using DevExpress.Utils.Drawing.Helpers;

namespace DevExpress.XtraWizard.Demos {
    public partial class frmStart : XtraForm {
        public frmStart() {
            InitializeComponent();
            foreach(SkinContainer cnt in SkinManager.Default.Skins) 
                listBoxControl1.Items.Add(cnt.SkinName);
            listBoxControl1.SelectedItem = DevExpress.LookAndFeel.UserLookAndFeel.Default.ActiveSkinName;
            if(NativeVista.IsVista)
                checkEdit1.Checked = true;
            else checkEdit1.Enabled = false;
        }

        public string SelectedSkinName { get { return listBoxControl1.SelectedItem.ToString(); } }
        public bool AllowNativeVista { get { return checkEdit1.Checked; } }
        
        private void listBoxControl1_SelectedIndexChanged(object sender, EventArgs e) {
            DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle(SelectedSkinName);
        }

        private void checkEdit1_CheckedChanged(object sender, EventArgs e) {
            StylesAdjust(checkEdit1.Checked);
        }

        void StylesAdjust(bool isAero) {
            listBoxControl1.Enabled = !isAero;
            if(isAero) 
                DevExpress.LookAndFeel.UserLookAndFeel.Default.SetWindowsXPStyle();
            else DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle(SelectedSkinName);
        }
    }
}
