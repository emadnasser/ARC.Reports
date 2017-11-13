using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;


namespace DevExpress.XtraGrid.Demos.Tutorials {
	public partial class About : TutorialControl {
		public About() {
			// This call is required by the Windows Form Designer.
			InitializeComponent();

			// TODO: Add any initialization after the InitializeComponent call
		}

		void LoadAbout(string fileName, RichTextBox rtb) {
			string aboutFile = DevExpress.Utils.FilesHelper.FindingFileName(Application.StartupPath, "\\Data\\" + fileName);
			try {
				if(aboutFile != "") rtb.LoadFile(aboutFile);
			} catch(Exception ex) {
				DevExpress.XtraEditors.XtraMessageBox.Show(this, ex.Message, ex.Source);
			}
		}

		private void About_Load(object sender, System.EventArgs e) {
			LoadAbout("XtraGridNewFeatures.rtf", rtbAboutNew);
			LoadAbout("XtraGridAbout.rtf", rtbAbout);
		}
	}
}

