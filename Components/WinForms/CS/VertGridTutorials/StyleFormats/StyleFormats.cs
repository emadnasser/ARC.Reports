using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace DevExpress.XtraVerticalGrid.Demos.Tutorials {
    /// <summary>
    /// Summary description for StyleFormats.
    /// </summary>
    public partial class StyleFormats : TutorialControl {
        public StyleFormats() {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();
            //
            // TODO: Add any constructor code after InitializeComponent call
            //
        }

        private void StyleFormats_Load(object sender, System.EventArgs e) {
            DevExpress.XtraVerticalGrid.Design.XViews.ConfigureDemoView(vGridControl1);
            InitStyles();
        }

        //<lsStyles>
        DevExpress.XtraVerticalGrid.Design.XAppearances xs = new DevExpress.XtraVerticalGrid.Design.XAppearances(System.Environment.GetFolderPath(System.Environment.SpecialFolder.System) + "\\DevExpress.XtraVerticalGrid.Appearances.xml");
        //</lsStyles>

        private void InitStyles() {
            lsStyles.Items.AddRange(xs.FormatNames);
            lsStyles.SelectedItem = "Blue Office";
        }

        //<lsStyles>
        private void lsStyles_SelectedIndexChanged(object sender, System.EventArgs e) {
            if(lsStyles.SelectedItem != null)
                xs.LoadScheme(lsStyles.SelectedItem.ToString(), vGridControl1);
        }
        //</lsStyles>
    }
}
