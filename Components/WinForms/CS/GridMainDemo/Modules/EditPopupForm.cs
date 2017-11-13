using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Columns;

namespace DevExpress.XtraGrid.Demos {
	/// <summary>
	/// Summary description for PopupForm.
	/// </summary>
	public partial class PopupForm : DevExpress.XtraEditors.XtraForm {
		public PopupForm() {
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		public DataRow Row {
			get { return cardView1.GetDataRow(0); }
		}

		private void InitLocation(Form frm) {
			this.Top = frm.Top + (frm.Height - this.Height) / 2;
			this.Left = frm.Left + (frm.Width - this.Width) / 2;
		}

		public void InitData(Form frm, GridControl grid, GridView view, DataRow row) {
			InitLocation(frm);
			foreach(GridColumn col in view.Columns) {
				GridColumn column = cardView1.Columns.Add();
                column.Caption = col.GetTextCaption();
				column.FieldName = col.FieldName;
				column.ColumnEdit = col.ColumnEdit;
				column.DisplayFormat.Assign(col.DisplayFormat);
				column.VisibleIndex = col.VisibleIndex;
			}
			DataTable tbl = ((DataView)grid.DataSource).Table.Clone();
			tbl.Rows.Add(row.ItemArray);		
			gridControl1.DataSource = tbl;
			cardView1.FocusedColumn = cardView1.Columns[0];
		}

		private void simpleButton1_Click(object sender, System.EventArgs e) {
			Row.EndEdit();
		}
	}
}
