using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace DevExpress.XtraVerticalGrid.Demos.Tutorials {
    /// <summary>
    /// Summary description for LayoutAndPaintStyles.
    /// </summary>
    public partial class LayoutAndPaintStyles : TutorialControl {
        public LayoutAndPaintStyles() {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();
            //
            // TODO: Add any constructor code after InitializeComponent call
            //
        }

        private void LayoutAndPaintStyles_Load(object sender, System.EventArgs e) {
            DevExpress.XtraVerticalGrid.Design.XViews.ConfigureDemoView(vGridControl1);
            AdjustmentGrid();
        }

        private void AdjustmentGrid() {
            switch(vGridControl1.LayoutStyle) {
                case LayoutViewStyle.BandsView:
                    radioGroup1.EditValue = 0;
                    break;
                case LayoutViewStyle.SingleRecordView:
                    radioGroup1.EditValue = 1;
                    break;
                case LayoutViewStyle.MultiRecordView:
                    radioGroup1.EditValue = 2;
                    break;
            }
            spinEdit1.Value = vGridControl1.BandsInterval;
        }

        //<radioGroup1>
        private void radioGroup1_SelectedIndexChanged(object sender, System.EventArgs e) {
            spinEdit1.Enabled = false;
            if(radioGroup1.EditValue.Equals(0)) {
                vGridControl1.LayoutStyle = LayoutViewStyle.BandsView;
                spinEdit1.Enabled = true;
            }
            if(radioGroup1.EditValue.Equals(1)) vGridControl1.LayoutStyle = LayoutViewStyle.SingleRecordView;
            if(radioGroup1.EditValue.Equals(2)) vGridControl1.LayoutStyle = LayoutViewStyle.MultiRecordView;

        }
        //</radioGroup1>

        //<spinEdit1>
        private void spinEdit1_ValueChanged(object sender, System.EventArgs e) {
            vGridControl1.BandsInterval = (int)spinEdit1.Value;
            spinEdit1.Value = vGridControl1.BandsInterval;
        }
        //</spinEdit1>
    }
}
