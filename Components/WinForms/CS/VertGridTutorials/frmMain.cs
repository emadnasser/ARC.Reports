using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using DevExpress.Tutorials;
using DevExpress.DXperience.Demos;

namespace DevExpress.XtraVerticalGrid.Demos.Tutorials {
	/// <summary>
	/// Summary description for frmMain.
	/// </summary>
	public partial class frmMain : DevExpress.Tutorials.FrmMain {
		public frmMain() {
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		private void frmMain_Load(object sender, System.EventArgs e) {
			RegisterTutorials.Register();
			TutorialsInfo.FillListBox(this.listBoxControl1, new string[] {RegisterTutorials.NewFeaturesString});
			listBoxControl1.SortOrder = SortOrder.Ascending;
			listBoxControl1.SelectedIndex = -1;
			ShowModule(RegisterTutorials.NewFeaturesString);
		}
        protected override LookAndFeelMenu CreateMenu(DevExpress.XtraBars.BarManager manager, DevExpress.LookAndFeel.DefaultLookAndFeel lookAndFeel) {
            return new VertGridTutorialMenu(manager, lookAndFeel, "Tutorial examples for the " + AssemblyInfo.SRAssemblyVertGrid);
        }
		private void listBoxControl1_SelectedIndexChanged(object sender, System.EventArgs e) {
			if(listBoxControl1.SelectedItem != null)
				ShowModule(listBoxControl1.SelectedItem.ToString());
		}

		void ShowModule(string name) {
			pcMain.SuspendLayout();
			try {
				DevExpress.Tutorials.ModuleBase module = TutorialsInfo.ShowModule(name, gcContainer, this.MainMenu, defaultLookAndFeel);
				SelectModule(module, true); 
			} finally {
				pcMain.ResumeLayout();
			}
		}
	}
}
