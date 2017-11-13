using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace DevExpress.XtraGrid.Demos.Tutorials {
    /// <summary>
    /// Summary description for GridIndicator.
    /// </summary>
    public partial class GridIndicator : TutorialControl {
        public GridIndicator() {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();

            //
            // TODO: Add any constructor code after InitializeComponent call
            //
        }

        private void GridIndicator_Load(object sender, System.EventArgs e) {
            InitData();
            radioGroup1.SelectedIndex = 2;
        }

        private void InitData() {
            DevExpress.XtraGrid.Design.XViewsPrinting xv = new DevExpress.XtraGrid.Design.XViewsPrinting(gridControl1);
        }

        //<radioGroup1>
        bool icon = true;
        private void SetIndicator(int val, bool icon) {
            spinEdit1.EditValue = val;
            this.icon = icon;
            gridView1.Invalidate();
        }

        private void radioGroup1_SelectedIndexChanged(object sender, System.EventArgs e) {
            int val = (int)radioGroup1.EditValue;
            if(val == 0) SetIndicator(12, true);
            else if(val == 1) SetIndicator(50, false);
            else SetIndicator(55, true);
        }
        //</radioGroup1>

        //<spinEdit1>
        private void spinEdit1_EditValueChanged(object sender, System.EventArgs e) {
            gridView1.IndicatorWidth = Convert.ToInt32(spinEdit1.EditValue);
            spinEdit1.EditValue = gridView1.IndicatorWidth;
        }
        //</spinEdit1>

        //<radioGroup1>
        private void gridView1_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e) {
            if(radioGroup1.EditValue == null || radioGroup1.EditValue.Equals(0)) return;
            if(e.Info.IsRowIndicator) {
                e.Info.DisplayText = "Row " + e.RowHandle.ToString();
                if(!icon) e.Info.ImageIndex = -1;
            }
        }
        //</radioGroup1>
    }
}
