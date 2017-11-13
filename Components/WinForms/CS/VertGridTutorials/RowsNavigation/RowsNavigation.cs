using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace DevExpress.XtraVerticalGrid.Demos.Tutorials {
    /// <summary>
    /// Summary description for RowsNavigation.
    /// </summary>
    public partial class RowsNavigation : TutorialControl {
        public RowsNavigation() {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();
            //
            // TODO: Add any constructor code after InitializeComponent call
            //
        }

        private void RowsNavigation_Load(object sender, System.EventArgs e) {
            DevExpress.XtraVerticalGrid.Design.XViews.ConfigureDemoView(vGridControl1);
            vGridControl1.FocusedRow = vGridControl1.Rows[0].ChildRows[0];
        }

        //<button1>
        private void button1_Click(object sender, System.EventArgs e) {
            vGridControl1.FocusFirst();
        }
        //</button1>

        //<button2>
        private void button2_Click(object sender, System.EventArgs e) {
            vGridControl1.FocusPrev();
        }
        //</button2>

        //<button3>
        private void button3_Click(object sender, System.EventArgs e) {
            vGridControl1.FocusNext();
        }
        //</button3>

        //<button4>
        private void button4_Click(object sender, System.EventArgs e) {
            vGridControl1.FocusLast();
        }
        //</button4>
    }
}
