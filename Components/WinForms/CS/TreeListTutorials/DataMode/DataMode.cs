using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace DevExpress.XtraTreeList.Demos.Tutorials {
    /// <summary>
    /// Summary description for DataMode.
    /// </summary>
    public partial class DataMode : TutorialControl {
        //<treeList1>
        public DataMode() {
            InitializeComponent();
            InitData();
        }
        //</treeList1>
        public override bool SetNewWhatsThisPadding { get { return true; } }
        //<treeList1>
        private void InitData() {
            string DBFileName = DevExpress.Utils.FilesHelper.FindingFileName(Application.StartupPath, "Data\\Departments.xml");
            if(DBFileName != "") {
                DataSet dataSet = new DataSet();
                dataSet.ReadXml(DBFileName);
                treeList1.DataSource = dataSet.Tables[0].DefaultView;
                treeList1.PopulateColumns();
                treeList1.BestFitColumns();
                treeList1.ExpandAll();
            }
        }
        //</treeList1>

        private void DataMode_Load(object sender, System.EventArgs e) {
            if(treeList1.Columns["Budget"] == null) return;
            treeList1.Columns["Budget"].Format.FormatString = "c";
            treeList1.BestFitColumns();
        }
    }
}
