using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;

namespace DevExpress.XtraNavBar.Demos {
	/// <summary>
	/// Summary description for UserControl1.
	/// </summary>
	public partial class DistanceChanger : DevExpress.XtraEditors.XtraUserControl {
		public DistanceChanger() {
			// This call is required by the Windows.Forms Form Designer.
			InitializeComponent();

			// TODO: Add any initialization after the InitForm call

		}

        public event EventHandler ValueChanged;
		private void checkBox1_CheckedChanged(object sender, System.EventArgs e) {
			trackBar1.Enabled = checkBox1.Checked;
			RaiseValueChanged();
		}

		private void trackBar1_ValueChanged(object sender, System.EventArgs e) {
			RaiseValueChanged();
		}

		void RaiseValueChanged() {
			if(ValueChanged != null)
				ValueChanged(this, EventArgs.Empty);
		}

		public string Caption { 
			get { return label1.Text; } 
			set { label1.Text = value; }
		}
		[DefaultValue(50)]
		public int Maximum { 
			get { return trackBar1.Properties.Maximum; } 
			set { trackBar1.Properties.Maximum = value; }
		}

		[DefaultValue(0)]
		public int Minimum { 
			get { return trackBar1.Properties.Minimum; } 
			set { trackBar1.Properties.Minimum = value; }
		}

		public int Value { 
			get { return trackBar1.Value; }
			set { trackBar1.Value = value; }
		}
		public bool StatusEnabled { get { return checkBox1.Checked; }}
	}
}
