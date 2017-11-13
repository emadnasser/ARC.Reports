using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using DevExpress.Utils;
using DevExpress.XtraGrid.Views.Grid;

namespace DevExpress.XtraGrid.Demos.Tutorials {
	/// <summary>
	/// Summary description for GridFocusedRow.
	/// </summary>
	public partial class GridFocusedRow : TutorialControl {
		public GridFocusedRow() {
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		private void GridFocusedRow_Load(object sender, System.EventArgs e) {
			InitNWindData();
			InitGrid();
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

		private void InitGrid() {
			gridView1.FocusedColumn = gridView1.Columns["UnitPrice"];
			gridView1.FocusedRowHandle = 1;
			radioGroup1.SelectedIndex = 2;
		}

      //<radioGroup1>
		private void radioGroup1_SelectedIndexChanged(object sender, System.EventArgs e) {
			int style = (int)radioGroup1.EditValue;
			gridView1.FocusRectStyle = DrawFocusRectStyle.CellFocus;
			gridView1.OptionsSelection.EnableAppearanceFocusedCell = true;
			gridView1.OptionsSelection.EnableAppearanceFocusedRow = true;
			gridView1.OptionsSelection.InvertSelection = false;
			switch(style) {
				case 1: //Row
					gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
					gridView1.FocusRectStyle = DrawFocusRectStyle.RowFocus;
					break;
				case 2: //Cell
					gridView1.OptionsSelection.InvertSelection = true;
					break;
				case 4: //Cell Rect Only
					gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
					gridView1.OptionsSelection.EnableAppearanceFocusedRow = false;
					break;
				case 5: //None
					gridView1.FocusRectStyle = DrawFocusRectStyle.None;
					gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
					gridView1.OptionsSelection.EnableAppearanceFocusedRow = false;
					break;
				
			}
			SetFocusedColumnAppearance(null, gridView1.FocusedColumn);
			gridControl1.Focus();
		}

      //<gridControl1>
		private void SetFocusedColumnAppearance(DevExpress.XtraGrid.Columns.GridColumn col1, DevExpress.XtraGrid.Columns.GridColumn col2) {
			if(radioGroup1.EditValue == null) return;
			if(col1 != null )col1.AppearanceCell.Reset();
			if(col2 != null) 
				if(3.Equals(radioGroup1.EditValue)) {
					col2.AppearanceCell.BackColor = SystemColors.Highlight;
					col2.AppearanceCell.ForeColor = SystemColors.HighlightText;
				} else 
					col2.AppearanceCell.Reset();
		}
      //</radioGroup1>

		private void gridView1_FocusedColumnChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedColumnChangedEventArgs e) {
			SetFocusedColumnAppearance(e.PrevFocusedColumn, e.FocusedColumn);
		}
      //</gridControl1>
        public override bool SetNewWhatsThisPadding { get { return true; } }
	}
}
