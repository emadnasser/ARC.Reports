using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace DevExpress.XtraVerticalGrid.Demos.Tutorials {
    /// <summary>
    /// Summary description for CategoryRowButtons.
    /// </summary>
    public partial class CategoryRowButtons : TutorialControl {
        public CategoryRowButtons() {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();
            //
            // TODO: Add any constructor code after InitializeComponent call
            //
        }

        private void CategoryRowButtons_Load(object sender, System.EventArgs e) {
            DevExpress.XtraVerticalGrid.Design.XViews.ConfigureDemoView(vGridControl1);
        }

        //<radioGroup1>
        private void radioGroup1_SelectedIndexChanged(object sender, System.EventArgs e) {
            vGridControl1.TreeButtonStyle = radioGroup1.EditValue.Equals(0) ?
                DevExpress.XtraVerticalGrid.TreeButtonStyle.ExplorerBar : DevExpress.XtraVerticalGrid.TreeButtonStyle.TreeView;
        }
        //</radioGroup1>
    }
}
