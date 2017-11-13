using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using DevExpress.XtraEditors.Repository;

namespace DevExpress.XtraGrid.Demos.Tutorials {
	/// <summary>
	/// Summary description for GridBandedViewNavigation.
	/// </summary>
	public partial class GridBandedViewNavigation : TutorialControl {
		public GridBandedViewNavigation() {
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		private void GridBandedViewNavigation_Load(object sender, System.EventArgs e) {
			InitHelper.InitAdvBandedView(gridControl1);
			InitOptions();
		}

		private void InitOptions() {
         checkEdit1.Checked = advBandedGridView1.OptionsNavigation.UseAdvHorzNavigation;
			checkEdit2.Checked = advBandedGridView1.OptionsNavigation.UseAdvVertNavigation;
		}

      //<checkEdit1>
		private void checkEdit1_CheckedChanged(object sender, System.EventArgs e) {
			DevExpress.XtraEditors.CheckEdit edit = sender as DevExpress.XtraEditors.CheckEdit;
			advBandedGridView1.OptionsNavigation.UseAdvHorzNavigation = edit.Checked;
		}
      //</checkEdit1>

      //<checkEdit2>
		private void checkEdit2_CheckedChanged(object sender, System.EventArgs e) {
			DevExpress.XtraEditors.CheckEdit edit = sender as DevExpress.XtraEditors.CheckEdit;
			advBandedGridView1.OptionsNavigation.UseAdvVertNavigation = edit.Checked;
		}
      //</checkEdit2>
	}
}
