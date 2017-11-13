using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace DevExpress.XtraGrid.Demos.Tutorials {
	/// <summary>
	/// Summary description for GridSummaries.
	/// </summary>
	public partial class GridSummaries : TutorialControl {
		public GridSummaries() {
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		private void GridSummaries_Load(object sender, System.EventArgs e) {
            InitNWindData();
			gridView1.ExpandAllGroups();
		}

        string tblGrid = "Products";
        string tblLookUp = "Suppliers";
        protected override void InitMDBData(string connectionString) {
            DataSet ds = new DataSet();
            System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter = new System.Data.OleDb.OleDbDataAdapter("SELECT * FROM " + tblGrid, connectionString);
            oleDbDataAdapter.Fill(ds, tblGrid);
            oleDbDataAdapter = new System.Data.OleDb.OleDbDataAdapter("SELECT * FROM " + tblLookUp, connectionString);
            oleDbDataAdapter.Fill(ds, tblLookUp);

            repositoryItemLookUpEdit1.DataSource = ds.Tables[tblLookUp];
            gridControl1.DataSource = ds.Tables[tblGrid];
        }
        protected override void InitXMLData(string dataFileName) {
            DataSet ds = new DataSet();
            ds.ReadXml(dataFileName);
            gridControl1.ShowOnlyPredefinedDetails = true;

            repositoryItemLookUpEdit1.DataSource = ds.Tables[tblLookUp];
            gridControl1.DataSource = ds.Tables[tblGrid];
        }
        public override bool SetNewWhatsThisPadding { get { return true; } }
	}
}
