using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace DevExpress.XtraTreeList.Demos.Tutorials {
    /// <summary>
    /// Summary description for ColumnCustomization.
    /// </summary>
    public partial class ColumnCustomization : TutorialControl {
        public ColumnCustomization() {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();
            InitData();
            //
            // TODO: Add any constructor code after InitializeComponent call
            //
        }

        bool customization = false;
        private void InitData() {
            string DBFileName = DevExpress.Utils.FilesHelper.FindingFileName(Application.StartupPath, "Data\\BioLife.xml");
            if(DBFileName != "") {
                DataSet dataSet = new DataSet();
                dataSet.ReadXml(DBFileName);
                treeList1.DataSource = dataSet.Tables[0].DefaultView;
                treeList1.PopulateColumns();
                HideColumns(new string[] { "Notes", "Picture", "RecordDate", "Mark" });
                treeList1.BestFitColumns();
                treeList1.ExpandAll();
            }
        }

        private void HideColumns(string[] names) {
            foreach(string s in names)
                treeList1.Columns[s].VisibleIndex = -1;
        }


        private void treeList1_ShowCustomizationForm(object sender, System.EventArgs e) {
            customization = true;
            checkBox1.Checked = true;
            customization = false;
        }

        private void treeList1_HideCustomizationForm(object sender, System.EventArgs e) {
            customization = true;
            checkBox1.Checked = false;
            customization = false;
        }

        //<checkBox1>
        private void checkBox1_CheckedChanged(object sender, System.EventArgs e) {
            if(customization) return;
            if(checkBox1.Checked)
                treeList1.ColumnsCustomization();
            else
                treeList1.DestroyCustomization();
        }
        //</checkBox1>

        private void ColumnCustomization_Load(object sender, System.EventArgs e) {
            treeList1.ColumnsCustomization();
        }

        public override void StartWhatsThis() {
            checkBox1.Checked = false;
        }
    }
}
