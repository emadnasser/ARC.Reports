using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace DevExpress.XtraGrid.Demos.Tutorials {
    /// <summary>
    /// Summary description for GridRelations.
    /// </summary>
    public partial class GridRelations : TutorialControl {
        public GridRelations() {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();

            //
            // TODO: Add any constructor code after InitializeComponent call
            //
        }

        //<gridControl1>
        private void GridRelations_Load(object sender, System.EventArgs e) {
            InitNWindData();
            gridView1.SetMasterRowExpanded(0, true);
        }

        string tblMaster = "Products";
        string tblDetail = "[Order Details]";
        protected override void InitMDBData(string connectionString) {
            DataSet ds = new DataSet();

            System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter1 = new System.Data.OleDb.OleDbDataAdapter("SELECT * FROM " + tblMaster, connectionString);
            System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter2 = new System.Data.OleDb.OleDbDataAdapter("SELECT * FROM " + tblDetail, connectionString);
            oleDbDataAdapter1.Fill(ds, tblMaster);
            oleDbDataAdapter2.Fill(ds, tblDetail);

            //Add master detail relation ship for the dataset.
            ds.Relations.Add("OrderDetails",
                ds.Tables[tblMaster].Columns["ProductID"],
                ds.Tables[tblDetail].Columns["ProductID"]);

            gridControl1.DataSource = ds.Tables[tblMaster];
        }
        //</gridControl1>
        
        protected override void InitXMLData(string dataFileName) {
            DataSet ds = new DataSet();
            ds.ReadXml(dataFileName);
            gridControl1.DataSource = ds.Tables[tblMaster];
        }
        public override bool SetNewWhatsThisPadding { get { return true; } }
    }
}
