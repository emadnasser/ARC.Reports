using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DevExpress.XtraTreeList.Demos {
    public partial class Bands : DevExpress.XtraTreeList.Demos.TutorialControl {
        public override TreeList ExportControl { get { return treeList; } }
        public Bands() {
            InitializeComponent();
            InitSpaceObjectsData();
            InitEditors();
        }
        DataTable spaceObjectsTable;
        void InitSpaceObjectsData() {
            string DBFileName = DevExpress.Utils.FilesHelper.FindingFileName(Application.StartupPath, "Data\\SpaceObjects.xml");
            if(DBFileName != "") {
                DataSet dataSet = new DataSet();
                dataSet.ReadXml(DBFileName);
                spaceObjectsTable = dataSet.Tables[0];
                spaceObjectsTable.PrimaryKey = new DataColumn[] { spaceObjectsTable.Columns["ObjectId"] };
                treeList.DataSource = spaceObjectsTable;
                treeList.KeyFieldName = "ObjectId";
                treeList.ParentFieldName = "ParentId";
                treeList.ExpandAll();
            }
        }
        private void InitEditors() {
            ceShowBandPanel.Checked = treeList.OptionsView.ShowBandsMode == Utils.DefaultBoolean.True;
            ceAllowBandMoving.Checked = treeList.OptionsCustomization.AllowBandMoving;
            ceAllowBandResizing.Checked = treeList.OptionsCustomization.AllowBandResizing;
            ceAllowChangeBandParent.Checked = treeList.OptionsCustomization.AllowChangeBandParent;
            ceAllowChangeColumnParent.Checked = treeList.OptionsCustomization.AllowChangeColumnParent;
            ceShowBandInCustomizationForm.Checked = treeList.OptionsCustomization.ShowBandsInCustomizationForm;
        }
        private void ceShowBandPanel_CheckedChanged(object sender, EventArgs e) {
            treeList.OptionsView.ShowBandsMode = ceShowBandPanel.Checked ? Utils.DefaultBoolean.True : Utils.DefaultBoolean.False;
        }

        private void ceAllowChangeBandParent_CheckedChanged(object sender, EventArgs e) {
            treeList.OptionsCustomization.AllowChangeBandParent = ceAllowChangeBandParent.Checked;
        }

        private void ceAllowChangeColumnParent_CheckedChanged(object sender, EventArgs e) {
            treeList.OptionsCustomization.AllowChangeColumnParent = ceAllowChangeColumnParent.Checked;
        }

        private void ceAllowBandMoving_CheckedChanged(object sender, EventArgs e) {
            treeList.OptionsCustomization.AllowBandMoving = ceAllowBandMoving.Checked;
        }

        private void ceAllowBandResizing_CheckedChanged(object sender, EventArgs e) {
            treeList.OptionsCustomization.AllowBandResizing = ceAllowBandResizing.Checked;
        }

        private void ceShowBandInCustomizationForm_CheckedChanged(object sender, EventArgs e) {
            treeList.OptionsCustomization.ShowBandsInCustomizationForm = ceShowBandInCustomizationForm.Checked;
        }
    }

}
