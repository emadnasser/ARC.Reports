using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace DevExpress.XtraGrid.Demos.Tutorials {
	/// <summary>
	/// Summary description for GridRowCellStyle.
	/// </summary>
	public partial class GridRowCellStyle : TutorialControl {
		public GridRowCellStyle() {
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		private void GridRowCellStyle_Load(object sender, System.EventArgs e) {
			InitData();
		}

		private void InitData() {
			string DBFileName = DevExpress.Utils.FilesHelper.FindingFileName(Application.StartupPath,"Data\\cars.xml");
			if(DBFileName != "") {
				DataSet ds = new DataSet();
				ds.ReadXml(DBFileName);
				gridControl1.DataSource = ds.Tables[0];
			}
		}

      //<gridControl1>
		private void gridView1_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e) {
			if(e.RowHandle != gridView1.FocusedRowHandle && 
				((e.RowHandle % 2 == 0 && e.Column.VisibleIndex % 2 == 1) || 
				(e.Column.VisibleIndex % 2 == 0 && e.RowHandle % 2 == 1))) {
					e.Appearance.ForeColor = SystemColors.Window;
					e.Appearance.BackColor = SystemColors.WindowText;
			}
		}
      //</gridControl1>
        public override bool SetNewWhatsThisPadding { get { return true; } }
	}
}
