using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using DevExpress.XtraEditors.Repository;

namespace DevExpress.XtraGrid.Demos.Tutorials {
	/// <summary>
	/// Summary description for GridHitInfoForm.
	/// </summary>
	public partial class GridHitInfoForm : TutorialControl {
		public GridHitInfoForm() {
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		private void GridHitInfoForm_Load(object sender, System.EventArgs e) {
			InitHelper.InitAdvBandedView(gridControl1);
		}

		//<gridControl1>
		private void gridControl1_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e) {
			ShowHitInfo(advBandedGridView1.CalcHitInfo(new Point(e.X, e.Y)));
		}
		
		private void ShowHitInfo(DevExpress.XtraGrid.Views.BandedGrid.ViewInfo.BandedGridHitInfo hi) {
			DevExpress.XtraGrid.Views.Base.ColumnView cgv = 
				(DevExpress.XtraGrid.Views.Base.ColumnView)gridControl1.MainView;		
			lbHitTest.Text = hi.HitTest.ToString();
			lbBand.Text = hi.Band == null ? "No band" : hi.Band.Caption;
            lbColumn.Text = hi.Column == null ? "No column" : hi.Column.GetTextCaption();
			lbRow.Text = hi.RowHandle.ToString();
			if(hi.Column == null || hi.RowHandle == -1)
				lbCellValue.Text = " ";
			else 
				lbCellValue.Text = (hi.Column.FieldName == "Picture" ? "Picture" :
					cgv.GetRowCellDisplayText(hi.RowHandle, hi.Column));
			
		}
		//</gridControl1>
        public override bool SetNewWhatsThisPadding { get { return true; } }
	}
}
