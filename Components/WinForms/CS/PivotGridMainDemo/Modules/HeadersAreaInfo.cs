using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;

namespace DevExpress.XtraPivotGrid.Demos.Modules {
	/// <summary>
	/// Summary description for HeadersAreaInfo.
	/// </summary>
	public partial class HeadersAreaInfo : DevExpress.XtraEditors.XtraUserControl {
		public HeadersAreaInfo() {
			// This call is required by the Windows.Forms Form Designer.
			InitializeComponent();
			// TODO: Add any initialization after the InitForm call
		}

		public void Init(PivotGridHitInfo info) {
			if(info == null || info.HeadersAreaInfo == null) {
				this.Visible = false;
				return;
			}
			this.Visible = true;
			textEdit1.Text = string.Format("{0}", info.HeadersAreaInfo.Area);
			textEdit2.Text = string.Format("{0}", info.HeadersAreaInfo.Field);
		}
	}
}
