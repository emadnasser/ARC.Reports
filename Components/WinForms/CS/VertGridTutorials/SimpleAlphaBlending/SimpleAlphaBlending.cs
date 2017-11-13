using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace DevExpress.XtraVerticalGrid.Demos.Tutorials {
    /// <summary>
    /// Summary description for SimpleAlphaBlending.
    /// </summary>
    public partial class SimpleAlphaBlending : TutorialControl {
        public SimpleAlphaBlending() {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();
            //
            // TODO: Add any constructor code after InitializeComponent call
            //
        }

        private void SimpleAlphaBlending_Load(object sender, System.EventArgs e) {
            DevExpress.XtraVerticalGrid.Design.XViews.ConfigureDemoView(vGridControl1);
            checkBox1.Checked = true;
        }

        //<checkBox1>
        private void checkBox1_CheckedChanged(object sender, System.EventArgs e) {
            xtraVertGridBlending1.Enabled = checkBox1.Checked;
            button1.Enabled = checkBox1.Checked;
        }
        //</checkBox1>

        //<button1>
        private void button1_Click(object sender, System.EventArgs e) {
            xtraVertGridBlending1.ShowDialog();
        }
        //</button1>
    }
}
