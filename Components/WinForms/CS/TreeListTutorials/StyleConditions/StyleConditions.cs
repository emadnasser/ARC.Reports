using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace DevExpress.XtraTreeList.Demos.Tutorials {
    /// <summary>
    /// Summary description for StyleConditions.
    /// </summary>
    public partial class StyleConditions : TutorialControl {
        public StyleConditions() {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();
            treeList1.ExpandAll();
            treeList2.ExpandAll();
            //
            // TODO: Add any constructor code after InitializeComponent call
            //
        }

        //<treeList1>
        private void treeList1_CustomDrawNodeCell(object sender, DevExpress.XtraTreeList.CustomDrawNodeCellEventArgs e) {
            if((e.Node == treeList1.FocusedNode && e.Column != treeList1.FocusedColumn) || e.Node == null || e.Column == null) return;
            if(e.Node[3].Equals(true)) {
                e.Appearance.Font = new Font(DevExpress.Utils.AppearanceObject.DefaultFont, FontStyle.Strikeout);
                e.Appearance.ForeColor = SystemColors.ControlDark;
            }
        }
        //</treeList1>

        //<checkBox1>
        private void treeList1_NodeCellStyle(object sender, DevExpress.XtraTreeList.GetCustomNodeCellStyleEventArgs e) {
            if(e.Node == treeList1.FocusedNode) return;
            if(e.Column.FieldName != "Name" && checkBox1.Checked) return;
            switch(e.Node[2].ToString()) {
                case "0":
                    e.Appearance.BackColor = Color.MediumSpringGreen;
                    break;
                case "1":
                    e.Appearance.BackColor = Color.LightSkyBlue;
                    break;
                case "2":
                    e.Appearance.BackColor = Color.FromArgb(255, 128, 128);
                    e.Appearance.ForeColor = Color.White;
                    break;
            }
        }

        private void checkBox1_CheckedChanged(object sender, System.EventArgs e) {
            treeList1.LayoutChanged();
        }
        //</checkBox1>

        //<simpleButton1>
        private void simpleButton1_Click(object sender, System.EventArgs e) {
            StyleConditionsForm dlg = new StyleConditionsForm(treeList2.FormatConditions);
            dlg.ShowDialog(this);
            dlg.Dispose();
        }
        //</simpleButton1>
    }
}
