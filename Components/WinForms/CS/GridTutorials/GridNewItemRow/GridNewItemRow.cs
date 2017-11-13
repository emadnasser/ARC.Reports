using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraEditors.Controls;

namespace DevExpress.XtraGrid.Demos.Tutorials {
	/// <summary>
	/// Summary description for GridNewItemRow.
	/// </summary>
	public partial class GridNewItemRow : TutorialControl {
		public GridNewItemRow() {
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		private void GridNewItemRow_Load(object sender, System.EventArgs e) {
			InitNWindData();
			InitGrid();
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

		private void InitGrid() {
			imageComboBoxEdit1.Properties.Items.Add(new ImageComboBoxItem("None", NewItemRowPosition.None));
			imageComboBoxEdit1.Properties.Items.Add(new ImageComboBoxItem("Top", NewItemRowPosition.Top));
			imageComboBoxEdit1.Properties.Items.Add(new ImageComboBoxItem("Bottom", NewItemRowPosition.Bottom));
			imageComboBoxEdit1.SelectedIndex = 1;
			gridView1.FocusedRowHandle = gridView1.RowCount - 1;
		}

      //<gridControl1>
		private void gridView1_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e) {
			DataRow row = gridView1.GetDataRow(e.RowHandle);
			row["Quantity"] = 1;
			row["UnitPrice"] = 0;
			row["Discount"] = 0;
			row["OrderID"] = 99999;
		}
      //</gridControl1>

      //<imageComboBoxEdit1>
		private void imageComboBoxEdit1_SelectedIndexChanged(object sender, System.EventArgs e) {
			gridView1.OptionsView.NewItemRowPosition = (NewItemRowPosition)imageComboBoxEdit1.EditValue;		
		}
      //</imageComboBoxEdit1>
        public override bool SetNewWhatsThisPadding { get { return true; } }
	}
}
