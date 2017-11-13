using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace DevExpress.XtraGrid.Demos.Tutorials {
    /// <summary>
    /// Summary description for GridFilteredView.
    /// </summary>
    public partial class GridFilteredView : TutorialControl {
        public GridFilteredView() {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();

            //
            // TODO: Add any constructor code after InitializeComponent call
            //
        }

        private void GridFilteredView_Load(object sender, System.EventArgs e) {
            InitNWindData();
            SetFilterString();
        }

        string tblGrid = "[Order Details]";
        string tblLookUp = "Products";
        protected override void InitMDBData(string connectionString) {
            DataSet ds = new DataSet();
            System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter = new System.Data.OleDb.OleDbDataAdapter("SELECT * FROM " + tblGrid, connectionString);
            oleDbDataAdapter.Fill(ds, tblGrid);
            oleDbDataAdapter = new System.Data.OleDb.OleDbDataAdapter("SELECT * FROM " + tblLookUp, connectionString);
            oleDbDataAdapter.Fill(ds, tblLookUp);

            //<gridControl1>
            gridControl1.DataSource = CreateFilteredView(ds.Tables[tblGrid], "Discount <> 0");
            //</gridControl1>
            repositoryItemLookUpEdit1.DataSource = ds.Tables[tblLookUp];
        }
        protected override void InitXMLData(string dataFileName) {
            DataSet ds = new DataSet();
            ds.ReadXml(dataFileName);
            gridControl1.ShowOnlyPredefinedDetails = true;
            gridControl1.DataSource = CreateFilteredView(ds.Tables[tblGrid], "Discount <> 0");
            repositoryItemLookUpEdit1.DataSource = ds.Tables[tblLookUp];
        }

        //<gridControl1>
        private FilteredDataView CreateFilteredView(DataTable tbl, string filterString) {
            FilteredDataView ret = new FilteredDataView(tbl);
            this.filterString = filterString;
            lbFilter.Text = filterString;
            return ret;
        }
        //</gridControl1>

        //<checkEdit1>
        private string filterString = "";
        private void SetFilterString() {
            FilteredDataView fdv = gridControl1.DataSource as FilteredDataView;
            if(fdv == null) return;
            fdv.AdditionalRowFilter = checkEdit1.Checked ? this.filterString : "";
        }

        private void checkEdit1_CheckedChanged(object sender, System.EventArgs e) {
            SetFilterString();
        }
        //</checkEdit1>
        public override bool SetNewWhatsThisPadding { get { return true; } }
    }
}
