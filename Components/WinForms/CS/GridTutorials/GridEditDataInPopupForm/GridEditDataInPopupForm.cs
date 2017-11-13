using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace DevExpress.XtraGrid.Demos.Tutorials {
	/// <summary>
	/// Summary description for GridEditDataInPopupForm.
	/// </summary>
	public partial class GridEditDataInPopupForm : TutorialControl {
		public GridEditDataInPopupForm() {
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		private void GridEditDataInPopupForm_Load(object sender, System.EventArgs e) {
			InitNWindData();
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

      //<gridControl1>
		private bool EditRecord() {
			PopupFormGridEditDataInPopupForm frm = new PopupFormGridEditDataInPopupForm();
			DataRow row = gridView1.GetFocusedDataRow();
			frm.InitData(this.FindForm(), gridControl1, gridView1, row);
			bool ret = frm.ShowDialog() == DialogResult.OK;
			if(ret) {
				row.ItemArray = frm.Row.ItemArray;
				row.EndEdit();
			}
			return ret; 
		}

		private void gridControl1_EmbeddedNavigator_ButtonClick(object sender, DevExpress.XtraEditors.NavigatorButtonClickEventArgs e) {
			if(e.Button.ButtonType == DevExpress.XtraEditors.NavigatorButtonType.Edit) {
				EditRecord();
				e.Handled = true;
			}
			if(e.Button.ButtonType == DevExpress.XtraEditors.NavigatorButtonType.Append) {
				gridView1.AddNewRow();
				if(EditRecord())
					gridView1.UpdateCurrentRow();
				else gridView1.CancelUpdateCurrentRow();
				e.Handled = true;
			}
		}
      //</gridControl1>
        public override bool SetNewWhatsThisPadding { get { return true; } }
	}
}
