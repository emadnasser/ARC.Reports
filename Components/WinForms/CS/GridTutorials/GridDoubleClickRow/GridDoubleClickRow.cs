using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using DevExpress.XtraEditors.Repository;

namespace DevExpress.XtraGrid.Demos.Tutorials {
	/// <summary>
	/// Summary description for GridDoubleClickRow.
	/// </summary>
	public partial class GridDoubleClickRow : TutorialControl {
		public GridDoubleClickRow() {
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		private void InitGrid() {
			advBandedGridView1.OptionsBehavior.Editable = false;
			advBandedGridView1.Columns["Transmiss Speed Count"].GroupIndex = 0;
			advBandedGridView1.ExpandAllGroups();
		}

		private void GridDoubleClickRow_Load(object sender, System.EventArgs e) {
			InitHelper.InitAdvBandedView(gridControl1);
			InitGrid();
		}

      //<gridControl1>
		private void gridControl1_DoubleClick(object sender, System.EventArgs e) {
			DevExpress.XtraGrid.Views.BandedGrid.ViewInfo.BandedGridHitInfo hi = 
				advBandedGridView1.CalcHitInfo((sender as Control).PointToClient(Control.MousePosition));
			
			if(hi.RowHandle >= 0) 
				ShowDataRow(advBandedGridView1.GetDataRow(hi.RowHandle), "", Color.White);
			else if(advBandedGridView1.FocusedRowHandle >= 0)
                ShowDataRow(advBandedGridView1.GetFocusedDataRow(), "Focused Row: ", Color.Yellow);
			else
				ShowDataRow(null, "Empty...", Color.DeepSkyBlue);
		}
      //</gridControl1>

		private void ShowDataRow(DataRow dr, string fs, Color c) {
			string s = "";
			if(dr != null) {
				object[] items = dr.ItemArray;
				foreach(object o in items) 
					s = (s == "" ? "" : s + "; ") + o.ToString();
			}
			lbRow.BackColor = c;
			lbRow.Text = fs + s;
		}
        public override bool SetNewWhatsThisPadding { get { return true; } }
	}
}
