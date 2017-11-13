using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraEditors;

namespace DevExpress.XtraGrid.Demos.Tutorials {
    /// <summary>
    /// Summary description for GridRowFilterEvent.
    /// </summary>
    public partial class GridRowFilterEvent : TutorialControl {
        public GridRowFilterEvent() {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();

            //
            // TODO: Add any constructor code after InitializeComponent call
            //
        }
        DataView dv = null;
        private void GridRowFilterEvent_Load(object sender, System.EventArgs e) {
            InitNWindData();
            gridView1.Columns[0].SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count;
            gridView1.BestFitColumns();
        }

        string tblName = "Customers";
        protected override void InitMDBData(string connectionString) {
            DataSet ds = new DataSet();
            System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter = new System.Data.OleDb.OleDbDataAdapter("SELECT * FROM " + tblName, connectionString);
            oleDbDataAdapter.Fill(ds, tblName);
            dv = ds.Tables[tblName].DefaultView;
            gridControl1.DataSource = dv;
            gridControl1.MainView.PopulateColumns();
        }
        protected override void InitXMLData(string dataFileName) {
            DataSet ds = new DataSet();
            ds.ReadXml(dataFileName);
            gridControl1.ShowOnlyPredefinedDetails = true;
            gridControl1.DataSource = ds.Tables[tblName];
            gridControl1.MainView.PopulateColumns();
        }

         //<ceHideOddRows>
        //<ceHideEvenRows>
        //<ceRegion>
        //<gridControl1>
        private void gridView1_CustomRowFilter(object sender, DevExpress.XtraGrid.Views.Base.RowFilterEventArgs e) {
            bool handled = ceHideOddRows.Checked || ceHideEvenRows.Checked || ceRegion.Checked;
            if(ceHideOddRows.Checked && e.ListSourceRow % 2 == 1)
                e.Visible = false;
            if(ceHideEvenRows.Checked && e.ListSourceRow % 2 == 0)
                e.Visible = false;
            if(ceRegion.Checked) {
                DataRow row = dv[e.ListSourceRow].Row;
                if(row["Region"] == DBNull.Value)
                    e.Visible = false;
            }
            e.Handled = handled;
        }
        //</gridControl1>

        private void ceEditors__CheckedChanged(object sender, System.EventArgs e) {
            gridView1.RefreshData();
        }
        //</ceHideOddRows>
        //</ceHideEvenRows>
        //</ceRegion>
        public override bool SetNewWhatsThisPadding { get { return true; } }
    }
}
