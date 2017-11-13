using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using DevExpress.XtraEditors.Repository;

namespace DevExpress.XtraGrid.Demos.Tutorials {
    /// <summary>
    /// Summary description for GridStyleFormats.
    /// </summary>
    public partial class GridStyleFormats : TutorialControl {
        public GridStyleFormats() {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();

            //
            // TODO: Add any constructor code after InitializeComponent call
            //
        }

        private void GridStyleFormats_Load(object sender, System.EventArgs e) {
            InitHelper.InitAdvBandedView(gridControl1);
            InitStyles();
        }

        //<listBoxControl1>
        DevExpress.XtraGrid.Design.XAppearances xapp = new DevExpress.XtraGrid.Design.XAppearances(System.Environment.GetFolderPath(System.Environment.SpecialFolder.System) + "\\DevExpress.XtraGrid.Appearances.xml");
        //</listBoxControl1>
        private void InitStyles() {
            listBoxControl1.Items.Clear();
            listBoxControl1.Items.AddRange(xapp.FormatNames);
            if(listBoxControl1.Items.Count > 1)
                listBoxControl1.SelectedIndex = 1;
        }

        //<listBoxControl1>
        private void listBoxControl1_SelectedIndexChanged(object sender, System.EventArgs e) {
            if(listBoxControl1.SelectedValue != null)
                xapp.LoadScheme(listBoxControl1.SelectedValue.ToString(), gridControl1.MainView);
        }
        //</listBoxControl1>

        public override bool ShowLookAndFeel { get { return false; } }
        public override bool SetNewWhatsThisPadding { get { return true; } }
    }
}
