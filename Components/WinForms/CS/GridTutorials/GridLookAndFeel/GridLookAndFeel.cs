using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using DevExpress.XtraEditors.Repository;

namespace DevExpress.XtraGrid.Demos.Tutorials {
	/// <summary>
	/// Summary description for GridLookAndFeel.
	/// </summary>
	public partial class GridLookAndFeel : TutorialControl{
		public GridLookAndFeel() {
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		private void GridLookAndFeel_Load(object sender, System.EventArgs e) {
			InitHelper.InitAdvBandedView(gridControl1);
			InitLookAndFeelRadioGroup();
		}

		private void InitLookAndFeelRadioGroup() {
			bool useXP = DevExpress.Utils.WXPaint.Painter.ThemesEnabled;
			if(!useXP) {
				for(int i = 0; i < 2; i++)
					radioGroup1.Properties.Items.RemoveAt(radioGroup1.Properties.Items.Count - 1);
			}
			radioGroup1.SelectedIndex = 3;
		}

      //<radioGroup1>
		private void radioGroup1_SelectedIndexChanged(object sender, System.EventArgs e) {
			DevExpress.XtraEditors.RadioGroup group = sender as DevExpress.XtraEditors.RadioGroup;
			string lookAndFeel = group.EditValue.ToString();
			gridControl1.SwitchPaintStyle(lookAndFeel);
		}
      //</radioGroup1>

		public override bool ShowLookAndFeel { get { return false;}}
	}
}
