using System;
using System.Windows.Forms;
using System.Data.OleDb;

namespace DevExpress.XtraGauges.Demos {
    public partial class Databinding : TutorialControl {
        public Databinding() {
            InitializeComponent();
            InitData();
        }
        protected void InitData() {
            string DBFileName = DevExpress.Utils.FilesHelper.FindingFileName(Application.StartupPath, "Data\\nwind.mdb");
            if(DBFileName != "") {
                string con = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + DBFileName;
                OleDbDataAdapter oleDBAdapter = new OleDbDataAdapter("SELECT * FROM Products", con);

                SetWaitDialogCaption("Loading Products...");
                oleDBAdapter.Fill(dsCategories.Products);
            }
        }
    }
}
