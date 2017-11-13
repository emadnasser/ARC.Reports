using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace DevExpress.XtraVerticalGrid.Demos.Tutorials {
	/// <summary>
	/// Summary description for SimpleMode.
	/// </summary>
	public partial class SimpleMode : TutorialControl {
		public SimpleMode() {
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}
        public override bool SetNewWhatsThisPadding { get { return true; } }
		private void SimpleMode_Load(object sender, System.EventArgs e) {
			InitData();
		}

		private void InitData() {
			vGridControl1.DataSource = new Contacts();
		}
	}
}
