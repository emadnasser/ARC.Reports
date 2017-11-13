using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace DevExpress.XtraTreeList.Demos.Tutorials {
    /// <summary>
    /// Summary description for Preview.
    /// </summary>
    public partial class Preview : TutorialControl {
        public Preview() {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();
            InitData();
            InitOptions();
            //
            // TODO: Add any constructor code after InitializeComponent call
            //
        }

        private void InitData() {
            string DBFileName = DevExpress.Utils.FilesHelper.FindingFileName(Application.StartupPath, "Data\\BioLife.xml");
            if(DBFileName != "") {
                DataSet dataSet = new DataSet();
                dataSet.ReadXml(DBFileName);
                treeList1.DataSource = dataSet.Tables[0].DefaultView;
                treeList1.PopulateColumns();
                HideColumns(new string[] { "Notes", "Picture", "RecordDate" });
                treeList1.BestFitColumns();
                treeList1.ExpandAll();
                foreach(DevExpress.XtraTreeList.Columns.TreeListColumn col in treeList1.Columns)
                    comboBox1.Properties.Items.Add(col.FieldName);
                comboBox1.SelectedItem = "Notes";
            }
        }

        private void HideColumns(string[] names) {
            foreach(string s in names)
                treeList1.Columns[s].VisibleIndex = -1;
        }

        private void InitOptions() {
            checkBox1.Checked = treeList1.OptionsView.ShowPreview;
            checkBox2.Checked = treeList1.OptionsView.AutoCalcPreviewLineCount;
        }

        //<comboBox1>
        private void comboBox1_SelectedIndexChanged(object sender, System.EventArgs e) {
            treeList1.PreviewFieldName = comboBox1.SelectedItem.ToString();
        }
        //</comboBox1>

        //<checkBox1>
        private void checkBox1_CheckedChanged(object sender, System.EventArgs e) {
            DevExpress.XtraEditors.CheckEdit chb = sender as DevExpress.XtraEditors.CheckEdit;
            treeList1.OptionsView.ShowPreview = chb.Checked;
        }
        //</checkBox1>

        //<checkBox2>
        private void checkBox2_CheckedChanged(object sender, System.EventArgs e) {
            DevExpress.XtraEditors.CheckEdit chb = sender as DevExpress.XtraEditors.CheckEdit;
            treeList1.OptionsView.AutoCalcPreviewLineCount = chb.Checked;
        }
        //</checkBox2>

        //<checkBox3>
        private void treeList1_GetPreviewText(object sender, DevExpress.XtraTreeList.GetPreviewTextEventArgs e) {
            if(checkBox3.Checked)
                e.PreviewText = "This is a description for " + e.Node.GetDisplayText(3);
        }

        private void checkBox3_CheckedChanged(object sender, System.EventArgs e) {
            comboBox1.Enabled = label3.Enabled = !checkBox3.Checked;
            treeList1.LayoutChanged();
        }
        //</checkBox3>
    }
}
