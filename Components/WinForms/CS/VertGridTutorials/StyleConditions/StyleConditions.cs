using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace DevExpress.XtraVerticalGrid.Demos.Tutorials {
    /// <summary>
    /// Summary description for StyleConditions.
    /// </summary>
    public partial class StyleConditions : TutorialControl {
        public StyleConditions() {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();
            //
            // TODO: Add any constructor code after InitializeComponent call
            //
        }

        private void StyleConditions_Load(object sender, System.EventArgs e) {
            DevExpress.XtraVerticalGrid.Design.XViews.ConfigureDemoView(vGridControl1);
        }

        //<checkBox1>
        Color[] multiEditorColors = new Color[] { Color.LightSkyBlue, Color.LemonChiffon };
        private void CustomDraw(DevExpress.XtraVerticalGrid.Events.CustomDrawRowEventArgs e, int cellIndex) {
            if(e.Row.Properties.Caption == "First Name" || e.Row.Properties.Caption == "Last Name")
                e.Appearance.Font = new Font(DevExpress.Utils.AppearanceObject.DefaultFont, FontStyle.Bold);
            if(e.Row is DevExpress.XtraVerticalGrid.Rows.MultiEditorRow) {
                int i = ((e.Row.Index + cellIndex) % 2);
                e.Appearance.BackColor = multiEditorColors[i];
                e.Appearance.ForeColor = Color.Black;
            }
            if(e.Row.Properties.Caption == "Hire Date") {
                e.Appearance.Font = new Font(DevExpress.Utils.AppearanceObject.DefaultFont, FontStyle.Strikeout);
                e.Appearance.ForeColor = SystemColors.ControlDark;
            }
            if(e.Row.Properties.Caption == "Birth Date") {
                e.Appearance.Font = new Font(DevExpress.Utils.AppearanceObject.DefaultFont, FontStyle.Italic);
                e.Appearance.BackColor = Color.Yellow;
                e.Appearance.ForeColor = Color.Black;
            }
        }

        private void vGridControl1_CustomDrawRowValueCell(object sender, DevExpress.XtraVerticalGrid.Events.CustomDrawRowValueCellEventArgs e) {
            CustomDraw(e, e.CellIndex);
        }

        private void vGridControl1_CustomDrawRowHeaderCell(object sender, DevExpress.XtraVerticalGrid.Events.CustomDrawRowHeaderCellEventArgs e) {
            if(!checkBox1.Checked)
                CustomDraw(e, e.CellIndex);
        }

        private void checkBox1_CheckedChanged(object sender, System.EventArgs e) {
            vGridControl1.LayoutChanged();
        }
        //</checkBox1>
    }
}
