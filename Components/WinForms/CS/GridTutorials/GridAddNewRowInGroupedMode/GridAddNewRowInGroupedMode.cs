using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace DevExpress.XtraGrid.Demos.Tutorials {
	/// <summary>
	/// Summary description for GridAddNewRowInGroupedMode.
	/// </summary>
	public partial class GridAddNewRowInGroupedMode : TutorialControl {
		public GridAddNewRowInGroupedMode() {
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}
		private void GridAddNewRowInGroupedMode_Load(object sender, System.EventArgs e) {
			InitNWindData();
			gridView1.ExpandAllGroups();
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
		
		//<simpleButton1>
		private void simpleButton1_Click(object sender, System.EventArgs e) {
			AddRow(gridView1);
		}

        void AddRow(DevExpress.XtraGrid.Views.Grid.GridView view) {
            int prevDataRowIndex = view.GetFocusedDataSourceRowIndex();
            view.AddNewRow();
            if (view.GroupCount >= 0 && prevDataRowIndex >= 0) {
                //Initialize group values
                foreach (DevExpress.XtraGrid.Columns.GridColumn groupColumn in view.GroupedColumns) {
                    object val = view.GetRowCellValue(prevDataRowIndex, groupColumn);
                    view.SetFocusedRowCellValue(groupColumn, val);
                }
                view.UpdateCurrentRow();
            }
            view.ShowEditor();
        }
        //</simpleButton1>
	}
}
