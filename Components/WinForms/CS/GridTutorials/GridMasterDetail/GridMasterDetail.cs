using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace DevExpress.XtraGrid.Demos.Tutorials {
    /// <summary>
    /// Summary description for GridMasterDetail.
    /// </summary>
    public partial class GridMasterDetail : TutorialControl {
        public GridMasterDetail() {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();

            //
            // TODO: Add any constructor code after InitializeComponent call
            //
        }
        bool updateValues = false;
        private void GridMasterDetail_Load(object sender, System.EventArgs e) {
            InitData();
            InitEditors();
            gridView1.SetMasterRowExpandedEx(0, 0, true);
            gridView1.SetMasterRowExpanded(1, true);
            gridView1.SetMasterRowExpanded(3, true);
        }

        void InitData() {
            System.IO.Stream stream = System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceStream("GridTutorials.GridMasterDetail.Parents.xml");
            dsParents1.ReadXml(stream, XmlReadMode.IgnoreSchema);
        }


        void InitEditors() {
            imageComboBoxEdit1.Properties.Items.AddEnum(typeof(DevExpress.XtraGrid.Views.Grid.DetailExpandButtonMode));
            updateValues = true;
            imageComboBoxEdit1.EditValue = gridView1.OptionsDetail.SmartDetailExpandButtonMode;
            checkEdit1.EditValue = gridView1.OptionsDetail.EnableDetailToolTip;
            checkEdit2.EditValue = gridView1.OptionsDetail.ShowDetailTabs;
            updateValues = false;
        }

        //<imageComboBoxEdit1>
        private void imageComboBoxEdit1_SelectedIndexChanged(object sender, System.EventArgs e) {
            if(updateValues) return;
            DevExpress.XtraEditors.ImageComboBoxEdit edit = sender as DevExpress.XtraEditors.ImageComboBoxEdit;
            gridView1.OptionsDetail.SmartDetailExpandButtonMode =
                (DevExpress.XtraGrid.Views.Grid.DetailExpandButtonMode)edit.EditValue;
        }
        //</imageComboBoxEdit1>

        //<checkEdit1>
        private void checkEdit1_CheckedChanged(object sender, System.EventArgs e) {
            if(updateValues) return;
            DevExpress.XtraEditors.CheckEdit checkEdit = sender as DevExpress.XtraEditors.CheckEdit;
            gridView1.OptionsDetail.EnableDetailToolTip = checkEdit.Checked;
        }
        //</checkEdit1>

        //<checkEdit2>
        private void checkEdit2_CheckedChanged(object sender, System.EventArgs e) {
            if(updateValues) return;
            DevExpress.XtraEditors.CheckEdit checkEdit = sender as DevExpress.XtraEditors.CheckEdit;
            gridView1.OptionsDetail.ShowDetailTabs = checkEdit.Checked;
        }
        //</checkEdit2>
    }
}
