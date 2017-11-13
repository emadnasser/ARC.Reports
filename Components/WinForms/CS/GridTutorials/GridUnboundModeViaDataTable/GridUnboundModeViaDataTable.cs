using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace DevExpress.XtraGrid.Demos.Tutorials {
    /// <summary>
    /// Summary description for GridUnboundModeViaDataTable.
    /// </summary>
    public partial class GridUnboundModeViaDataTable : TutorialControl {
        public GridUnboundModeViaDataTable() {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();

            //
            // TODO: Add any constructor code after InitializeComponent call
            //
        }

        private void GridUnboundModeViaDataTable_Load(object sender, System.EventArgs e) {
            InitData();
            FillData();
            InitGridColumns();
        }

        //<gridControl1>
        private DataTable data;
        private void InitData() {
            data = new DataTable("ColumnsTable");
            data.BeginInit();
            AddColumn(data, "ID", System.Type.GetType("System.Int32"), true);
            AddColumn(data, "First Name", System.Type.GetType("System.String"));
            AddColumn(data, "Last Name", System.Type.GetType("System.String"));
            AddColumn(data, "Payment Type", System.Type.GetType("System.String"));
            AddColumn(data, "Customer", System.Type.GetType("System.Boolean"));
            AddColumn(data, "Payment Amount", System.Type.GetType("System.Single"));
            data.EndInit();
        }
        //</gridControl1>

        private void AddColumn(DataTable data, string name, System.Type type) { AddColumn(data, name, type, false); }
        private void AddColumn(DataTable data, string name, System.Type type, bool ro) {
            DataColumn col;
            col = new DataColumn(name, type);
            col.Caption = name;
            col.ReadOnly = ro;
            data.Columns.Add(col);
        }

        private void FillData() {
            string[,] sNames = new string[,] { {
				 "Elizabeth", "Lincoln"}, {"Yang", "Wang"}, { 
				 "Patricio", "Simpson"}, {"Francisco", "Chang"}, { 
				 "Ann", "Devon"}, {"Roland", "Mendel"}, { 
				 "Paolo", "Accorti"}, {"Diego", "Roel"}};
            string[] sType = new string[] { "Visa", "Master", "Cash" };
            data.Clear();
            Random rnd = new Random();
            for(int i = 0; i <= sNames.GetUpperBound(0); i++)
                data.Rows.Add(new object[] { i + 1, sNames[i, 0], sNames[i, 1], sType[i % 3], rnd.Next(-1, 1), rnd.Next(10000) * 0.01 });
        }

        //<gridControl1>
        private void InitGridColumns() {
            gridControl1.DataSource = data;
            //The line below creates columns on the fly.
            gridControl1.DefaultView.PopulateColumns();
            gridView1.Columns["Payment Amount"].DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            gridView1.Columns["Payment Amount"].DisplayFormat.FormatString = "c";
            gridView1.BestFitColumns();
        }
        //</gridControl1>
        public override bool SetNewWhatsThisPadding { get { return true; } }
    }
}
