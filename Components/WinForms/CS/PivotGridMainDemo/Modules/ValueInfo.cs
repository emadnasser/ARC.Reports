using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;

namespace DevExpress.XtraPivotGrid.Demos.Modules {
	/// <summary>
	/// Summary description for ValueInfo.
	/// </summary>
	public partial class ValueInfo : DevExpress.XtraEditors.XtraUserControl {
		public ValueInfo() {
			// This call is required by the Windows.Forms Form Designer.
			InitializeComponent();
			// TODO: Add any initialization after the InitForm call
		}

		public void Init(PivotGridHitInfo info) {
			if(info == null || info.ValueInfo == null) {
				this.Visible = false;
				return;
			}
			this.Visible = true;
			textEdit1.Text = string.Format("{0}", info.ValueInfo.Value);
			textEdit2.Text = string.Format("{0}", info.ValueInfo.Field);
			textEdit3.Text = string.Format("{0}", info.ValueInfo.ValueType);
		}
	}
}
