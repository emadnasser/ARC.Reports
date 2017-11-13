using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using DevExpress.XtraVerticalGrid;

namespace DevExpress.XtraVerticalGrid.Demos.Tutorials {
    /// <summary>
    /// Summary description for ScrollVisibilitySample.
    /// </summary>
    public partial class ScrollVisibilitySample : TutorialControl {
        public ScrollVisibilitySample() {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();
            //
            // TODO: Add any constructor code after InitializeComponent call
            //
        }

        private void ScrollVisibilitySample_Load(object sender, System.EventArgs e) {
            DevExpress.XtraVerticalGrid.Design.XViews.ConfigureDemoView(vGridControl1);
            AdjustmentGrid();
        }

        private void AdjustmentGrid() {
            dataNavigator1.DataSource = vGridControl1.DataSource;
            switch(vGridControl1.LayoutStyle) {
                case LayoutViewStyle.BandsView:
                    radioGroup2.SelectedIndex = 0;
                    break;
                case LayoutViewStyle.SingleRecordView:
                    radioGroup2.SelectedIndex = 1;
                    break;
                case LayoutViewStyle.MultiRecordView:
                    radioGroup2.SelectedIndex = 2;
                    break;
            }
            switch(vGridControl1.ScrollVisibility) {
                case ScrollVisibility.Never:
                    radioGroup1.SelectedIndex = 0;
                    break;
                case ScrollVisibility.Auto:
                    radioGroup1.SelectedIndex = 1;
                    break;
                case ScrollVisibility.Both:
                    radioGroup1.SelectedIndex = 2;
                    break;
                case ScrollVisibility.Horizontal:
                    radioGroup1.SelectedIndex = 3;
                    break;
                case ScrollVisibility.Vertical:
                    radioGroup1.SelectedIndex = 4;
                    break;
            }
            ShowDBNavigator();
        }

        //<radioGroup1>
        private void radioGroup1_SelectedIndexChanged(object sender, System.EventArgs e) {
            switch(radioGroup1.SelectedIndex) {
                case 0: vGridControl1.ScrollVisibility = ScrollVisibility.Never;
                    break;
                case 1: vGridControl1.ScrollVisibility = ScrollVisibility.Auto;
                    break;
                case 2: vGridControl1.ScrollVisibility = ScrollVisibility.Both;
                    break;
                case 3: vGridControl1.ScrollVisibility = ScrollVisibility.Horizontal;
                    break;
                case 4: vGridControl1.ScrollVisibility = ScrollVisibility.Vertical;
                    break;
            }
            ShowDBNavigator();
        }
        //</radioGroup1>

        //<radioGroup2>
        private void radioGroup2_SelectedIndexChanged(object sender, System.EventArgs e) {
            switch(radioGroup2.SelectedIndex) {
                case 0: vGridControl1.LayoutStyle = LayoutViewStyle.BandsView;
                    break;
                case 1: vGridControl1.LayoutStyle = LayoutViewStyle.SingleRecordView;
                    break;
                case 2: vGridControl1.LayoutStyle = LayoutViewStyle.MultiRecordView;
                    break;
            }
            ShowDBNavigator();

        }
        //</radioGroup2>

        private void ShowDBNavigator() {
            panel3.Visible = ((vGridControl1.ScrollVisibility == ScrollVisibility.Never || vGridControl1.ScrollVisibility == ScrollVisibility.Vertical) &&
                (vGridControl1.LayoutStyle == LayoutViewStyle.BandsView || vGridControl1.LayoutStyle == LayoutViewStyle.SingleRecordView));
        }
    }
}
