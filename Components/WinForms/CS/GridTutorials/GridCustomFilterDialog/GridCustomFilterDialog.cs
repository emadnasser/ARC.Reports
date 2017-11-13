using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace DevExpress.XtraGrid.Demos.Tutorials {
    /// <summary>
    /// Summary description for GridCustomFilterDialog.
    /// </summary>
    public partial class GridCustomFilterDialog : TutorialControl {
        public GridCustomFilterDialog() {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();

            //
            // TODO: Add any constructor code after InitializeComponent call
            //
        }

        private void GridCustomFilterDialog_Load(object sender, System.EventArgs e) {
            InitNWindData();
            radioGroup1.SelectedIndex = 1;
        }

        string tblName = "Products";
        protected override void InitMDBData(string connectionString) {
            DataSet ds = new DataSet();
            System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter = new System.Data.OleDb.OleDbDataAdapter("SELECT * FROM " + tblName, connectionString);
            oleDbDataAdapter.Fill(ds, tblName);

            gridControl1.DataSource = ds.Tables[tblName];
        }
        protected override void InitXMLData(string dataFileName) {
            DataSet ds = new DataSet();
            ds.ReadXml(dataFileName);
            gridControl1.ShowOnlyPredefinedDetails = true;
            gridControl1.DataSource = ds.Tables[tblName];
        }

        //<radioGroup1>
        string filterColumn = "UnitPrice";
        private void radioGroup1_SelectedIndexChanged(object sender, System.EventArgs e) {
            int editValue = (int)radioGroup1.EditValue;
            if(editValue == 0) {
                gridView1.OptionsFilter.UseNewCustomFilterDialog = false;
                gridView1.Columns[filterColumn].FilterInfo = new Columns.ColumnFilterInfo(Columns.ColumnFilterType.Custom, null, "[UnitPrice] <= 20");
            }
            else {
                gridView1.OptionsFilter.UseNewCustomFilterDialog = true;
                gridView1.Columns[filterColumn].FilterInfo = new Columns.ColumnFilterInfo(Columns.ColumnFilterType.Custom, null, "[UnitPrice] > [UnitsInStock]");
            }
        }

        private void gridView1_CustomFilterDialog(object sender, DevExpress.XtraGrid.Views.Grid.CustomFilterDialogEventArgs e) {
            if(radioGroup1.EditValue.Equals(2)) {
                DevExpress.XtraGrid.Views.Grid.GridView gv = sender as DevExpress.XtraGrid.Views.Grid.GridView;
                e.Handled = true;
                e.FilterInfo = null;
                DevExpress.XtraGrid.Filter.FilterCustomDialog2 dlg = 
					new DevExpress.XtraGrid.Filter.FilterCustomDialog2(e.Column, gv.Columns, true);
                dlg.ShowDialog();
            }
        }
        //</radioGroup1>
    }
}
