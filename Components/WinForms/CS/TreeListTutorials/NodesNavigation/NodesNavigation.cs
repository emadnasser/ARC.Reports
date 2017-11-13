using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace DevExpress.XtraTreeList.Demos.Tutorials {
    /// <summary>
    /// Summary description for NodesNavigation.
    /// </summary>
    public partial class NodesNavigation : TutorialControl {
        public NodesNavigation() {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();
            //
            // TODO: Add any constructor code after InitializeComponent call
            //
        }

        //<button1>
        private void button1_Click(object sender, System.EventArgs e) {
            treeList1.MoveFirst();
        }
        //</button1>

        //<button2>
        private void button2_Click(object sender, System.EventArgs e) {
            treeList1.MovePrev();
        }
        //</button2>

        //<button3>
        private void button3_Click(object sender, System.EventArgs e) {
            treeList1.MovePrevVisible();
        }
        //</button3>

        //<button4>
        private void button4_Click(object sender, System.EventArgs e) {
            treeList1.MoveNext();
        }
        //</button4>

        //<button5>
        private void button5_Click(object sender, System.EventArgs e) {
            treeList1.MoveNextVisible();
        }
        //</button5>

        //<button6>
        private void button6_Click(object sender, System.EventArgs e) {
            treeList1.MoveLast();
        }
        //</button6>

        //<button7>
        private void button7_Click(object sender, System.EventArgs e) {
            treeList1.MoveLastVisible();
        }
        //</button7>
    }
}
