using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace DevExpress.XtraGrid.Demos.Tutorials {
    /// <summary>
    /// Summary description for GridSeveralDataViewsOneDataTable.
    /// </summary>
    public partial class GridSeveralDataViewsOneDataTable : TutorialControl {
        public GridSeveralDataViewsOneDataTable() {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();
            //
            // TODO: Add any constructor code after InitializeComponent call
            //
        }

        private void GridSeveralDataViewsOneDataTable_Load(object sender, System.EventArgs e) {
            InitNWindData();
        }

        //<checkEdit1>
        DataView dv1, dv2;

        //</checkEdit1>

        string tblName = "[Order Details]";
        protected override void InitMDBData(string connectionString) {
            DataSet ds = new DataSet();
            System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter = new System.Data.OleDb.OleDbDataAdapter("SELECT * FROM " + tblName, connectionString);
            oleDbDataAdapter.Fill(ds, tblName);

            //<checkEdit1>
            DataTable dt = ds.Tables[tblName];
            dv1 = new DataView(dt);
            dv2 = new DataView(dt);
            //</checkEdit1>

            gridControl1.DataSource = dv1;
            gridControl1.MainView.PopulateColumns();

            SetDataSource(gridControl2);
            gridControl2.MainView.PopulateColumns();
        }
        protected override void InitXMLData(string dataFileName) {
            DataSet ds = new DataSet();
            ds.ReadXml(dataFileName);
            gridControl1.ShowOnlyPredefinedDetails = true;
            gridControl2.ShowOnlyPredefinedDetails = true;

            DataTable dt = ds.Tables[tblName];
            dv1 = new DataView(dt);
            dv2 = new DataView(dt);

            gridControl1.DataSource = dv1;
            gridControl1.MainView.PopulateColumns();

            SetDataSource(gridControl2);
            gridControl2.MainView.PopulateColumns();
        }

        //<checkEdit1>
        private void SetDataSource(GridControl grid) {
            if(checkEdit1.Checked) grid.DataSource = dv1;
            else grid.DataSource = dv2;
        }

        private void checkEdit1_CheckedChanged(object sender, System.EventArgs e) {
            SetDataSource(gridControl2);
            gridView1.FocusedRowHandle = 0;
        }
        //</checkEdit1>
    }
}
