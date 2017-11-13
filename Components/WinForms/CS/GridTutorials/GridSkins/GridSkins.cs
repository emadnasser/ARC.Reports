using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
//<comboBoxEdit1>
using DevExpress.Skins;
//</comboBoxEdit1>
using DevExpress.XtraEditors;
using DevExpress.LookAndFeel;

namespace DevExpress.XtraGrid.Demos.Tutorials {
	/// <summary>
	/// Summary description for GridSkins.
	/// </summary>
	public partial class GridSkins : TutorialControl {
		public GridSkins() {
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		private void GridSkins_Load(object sender, System.EventArgs e) {
			DevExpress.XtraGrid.Design.XViewsPrinting xv = new DevExpress.XtraGrid.Design.XViewsPrinting(gridControl1, true);
			gridView1.ExpandAllGroups();
			InitSkinNames(comboBoxEdit1, gridControl1.LookAndFeel);
		}
		//<comboBoxEdit1>
		void InitSkinNames(ComboBoxEdit comboBox, UserLookAndFeel lookAndFeel) {
			foreach(SkinContainer cnt in SkinManager.Default.Skins) 
				comboBox.Properties.Items.Add(cnt.SkinName);
			comboBox.EditValue = lookAndFeel.SkinName;
		}

		private void comboBoxEdit1_SelectedIndexChanged(object sender, System.EventArgs e) {
			ComboBoxEdit cb = sender as ComboBoxEdit;
			gridControl1.LookAndFeel.SkinName = cb.EditValue.ToString();
		}
		//</comboBoxEdit1>

		public override bool ShowLookAndFeel { get { return false;}}
	}
}
