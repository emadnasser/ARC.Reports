using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace DevExpress.XtraGrid.Demos.Tutorials {
    /// <summary>
    /// Summary description for GridIncrementalSearch.
    /// </summary>
    public partial class GridIncrementalSearch : TutorialControl {
        public GridIncrementalSearch() {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();

            //
            // TODO: Add any constructor code after InitializeComponent call
            //
        }
        string[] searshString = new string[] { "c", "a", "{BS}", "h", "a", "n", "{BS}", "{BS}", "e", "f", " ", "a", "n", "t", "o", "n", "'", "s", " ", "c", "^{DOWN}", "^{DOWN}", "^{DOWN}", "^{DOWN}", "^{DOWN}", "^{DOWN}", "^{HOME}", "{RIGHT}" };
        int searchKeyIndex = 0;

        private void GridIncrementalSearch_Load(object sender, System.EventArgs e) {
            lbEvent.Text = "Press ESC key to stop auto-incremental search.";
            InitNWindData();
            gridView1.FocusedColumn = gridColumn2;
            timer1.Start();
        }

        string tblGrid = "[Order Details]";
        string tblLookUp = "Products";
        protected override void InitMDBData(string connectionString) {
            DataSet ds = new DataSet();
            System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter = new System.Data.OleDb.OleDbDataAdapter("SELECT * FROM " + tblGrid, connectionString);
            oleDbDataAdapter.Fill(ds, tblGrid);
            oleDbDataAdapter = new System.Data.OleDb.OleDbDataAdapter("SELECT * FROM " + tblLookUp, connectionString);
            oleDbDataAdapter.Fill(ds, tblLookUp);
            gridControl1.DataSource = ds.Tables[tblGrid];
            repositoryItemLookUpEdit1.DataSource = ds.Tables[tblLookUp];
        }
        protected override void InitXMLData(string dataFileName) {
            DataSet ds = new DataSet();
            ds.ReadXml(dataFileName);
            gridControl1.ShowOnlyPredefinedDetails = true;
            gridControl1.DataSource = ds.Tables[tblGrid];
            repositoryItemLookUpEdit1.DataSource = ds.Tables[tblLookUp];
        }

        private void gridControl1_ProcessGridKey(object sender, System.Windows.Forms.KeyEventArgs e) {
            if(e.KeyCode == Keys.Escape) StopSearch();
        }
        private void gridControl1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e) {
            StopSearch();
        }
        private void StopSearch() {
            timer1.Stop();
            lbEvent.Text = "Auto-Incremental Searching is available against any XtraGrid column WITHOUT writing any source code! With its blinding fast speed, your users can find information quickly when large amounts of data are displayed within the XtraGrid. Use Ctrl+Down to find the next match and Ctrl+Up to find the previous match.";
        }


        private void timer1_Tick(object sender, System.EventArgs e) {
            if(Form.ActiveForm == null || !this.Visible) return;
            gridControl1.Focus();
            if(searchKeyIndex > searshString.Length - 1)
                searchKeyIndex = 0;
            else {
                SendKeys.Send(searshString[searchKeyIndex]);
                searchKeyIndex++;
            }
        }
        public override bool SetNewWhatsThisPadding { get { return true; } }
    }
}
