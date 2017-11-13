using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;

namespace DevExpress.XtraPivotGrid.Demos.Modules {
	/// <summary>
	/// Summary description for CellInfo.
	/// </summary>
	public partial class CellInfo : DevExpress.XtraEditors.XtraUserControl {
		public CellInfo() {
			// This call is required by the Windows.Forms Form Designer.
			InitializeComponent();
			// TODO: Add any initialization after the InitForm call
		}

		public void Init(PivotGridHitInfo info) {
			if(info == null || info.CellInfo == null) {
				this.Visible = false;
				return;
			}
			this.Visible = true;
			textEdit1.Text = info.CellInfo.DisplayText;
			textEdit2.Text = string.Format("{0}", info.CellInfo.Value);
			textEdit3.Text = string.Format("{0}, {1}", info.CellInfo.ColumnIndex, info.CellInfo.RowIndex);
            textEdit4.Text = info.CellInfo.DataField != null ? info.CellInfo.DataField.ToString() : "";
		}
	}
}
