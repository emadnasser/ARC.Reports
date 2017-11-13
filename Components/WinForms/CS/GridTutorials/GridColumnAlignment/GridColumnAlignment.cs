using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using DevExpress.XtraEditors;

namespace DevExpress.XtraGrid.Demos.Tutorials {
	/// <summary>
	/// Summary description for GridColumnAlignment.
	/// </summary>
	public partial class GridColumnAlignment : TutorialControl {
		public GridColumnAlignment() {
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		private void GridColumnAlignment_Load(object sender, System.EventArgs e) {
			InitNWindData();
			InitComboBoxes();
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

		private void InitComboBoxes() {
            comboBoxEdit1.Properties.Items.AddRange(gridView1.Columns);
			comboBoxEdit2.Properties.Items.AddEnum(typeof(DevExpress.Utils.HorzAlignment));
            comboBoxEdit2.SelectedIndex = 2;
            comboBoxEdit1.SelectedIndex = 1;
        }

      //<comboBoxEdit1>
      //<comboBoxEdit2>
        private void SetColumnStyle(DevExpress.XtraGrid.Columns.GridColumn column, DevExpress.Utils.HorzAlignment alignment) {
			if(column == null) return; 
			column.AppearanceCell.TextOptions.HAlignment = alignment;
		}
      //</comboBoxEdit1>
      //</comboBoxEdit2>

      //<comboBoxEdit1>
      //<comboBoxEdit2>
		private void comboBoxEdit_SelectedIndexChanged(object sender, System.EventArgs e) {
            SetColumnStyle(comboBoxEdit1.EditValue as DevExpress.XtraGrid.Columns.GridColumn, (DevExpress.Utils.HorzAlignment)comboBoxEdit2.EditValue);
		}
      //</comboBoxEdit1>
      //</comboBoxEdit2>
	}
}
