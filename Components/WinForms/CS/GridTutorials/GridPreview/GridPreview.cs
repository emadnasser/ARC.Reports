using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace DevExpress.XtraGrid.Demos.Tutorials {
	/// <summary>
	/// Summary description for GridPreview.
	/// </summary>
	public partial class GridPreview : TutorialControl {
		public GridPreview() {
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		private void GridPreview_Load(object sender, System.EventArgs e) {
			InitNWindData();
			InitGrid();
		}

        string tblName = "Employees";
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

		private void InitGrid() {
			checkEdit1.Checked = true;
			checkEdit2.Checked = true;
			checkEdit3.Checked = false;
			foreach(DevExpress.XtraGrid.Columns.GridColumn column in gridView1.Columns)
				comboBoxEdit1.Properties.Items.Add(column.FieldName);
			comboBoxEdit1.EditValue = "Notes";
			spinEdit1.Value = gridView1.PreviewIndent;
		}

      //<checkEdit1>
		private void checkEdit1_CheckedChanged(object sender, System.EventArgs e) {
			DevExpress.XtraEditors.CheckEdit checkEdit = sender as DevExpress.XtraEditors.CheckEdit;
			gridView1.OptionsView.ShowPreview = checkEdit.Checked;
		}
      //</checkEdit1>

      //<checkEdit2>
		private void checkEdit2_CheckedChanged(object sender, System.EventArgs e) {
			DevExpress.XtraEditors.CheckEdit checkEdit = sender as DevExpress.XtraEditors.CheckEdit;
			gridView1.OptionsView.AutoCalcPreviewLineCount = checkEdit.Checked;
		}
      //</checkEdit2>
		
      //<checkEdit3>
		private void checkEdit3_CheckedChanged(object sender, System.EventArgs e) {
			DevExpress.XtraEditors.CheckEdit checkEdit = sender as DevExpress.XtraEditors.CheckEdit;
			gridView1.Invalidate();
			spinEdit1.Enabled = !checkEdit.Checked;
		}
      //</checkEdit3>
		
      //<comboBoxEdit1>
		private void comboBoxEdit1_SelectedIndexChanged(object sender, System.EventArgs e) {
			DevExpress.XtraEditors.ComboBoxEdit comboBox = sender as DevExpress.XtraEditors.ComboBoxEdit;
			gridView1.PreviewFieldName = comboBox.EditValue.ToString();
		}
      //</comboBoxEdit1>
	
      //<checkEdit3>
		private void gridView1_CustomDrawRowPreview(object sender, DevExpress.XtraGrid.Views.Base.RowObjectCustomDrawEventArgs e) {
			if(checkEdit3.Checked) {
				int dx = 5;
				Rectangle r = e.Bounds;
				r.X += e.Bounds.Height + dx * 2;
				r.Width -= e.Bounds.Height + dx * 2;
				e.Graphics.DrawImage(DevExpress.XtraEditors.Controls.ByteImageConverter.FromByteArray((byte[])gridView1.GetDataRow(e.RowHandle)["Photo"]), e.Bounds.X + dx, e.Bounds.Y, e.Bounds.Height, e.Bounds.Height);
				e.Appearance.DrawString(e.Cache, gridView1.GetRowPreviewDisplayText(e.RowHandle), r);
				e.Handled = true;
			}
		}
	  //</checkEdit3>
		private void spinEdit1_EditValueChanged(object sender, System.EventArgs e) {
			DevExpress.XtraEditors.SpinEdit spinEdit = sender as DevExpress.XtraEditors.SpinEdit;
			gridView1.PreviewIndent = Convert.ToInt32(spinEdit1.Value);
		}
	}
}
