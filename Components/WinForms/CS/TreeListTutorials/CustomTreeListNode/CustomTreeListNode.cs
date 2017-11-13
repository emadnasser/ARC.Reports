using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace DevExpress.XtraTreeList.Demos.Tutorials {
    /// <summary>
    /// Summary description for CustomTreeListNode.
    /// </summary>
    public partial class CustomTreeListNode : TutorialControl {
        public CustomTreeListNode() {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();
            treeList1.AppendNode(null, null);
            //
            // TODO: Add any constructor code after InitializeComponent call
            //
        }
        public override bool SetNewWhatsThisPadding { get { return true; } }
        private void treeList1_FocusedNodeChanged(object sender, DevExpress.XtraTreeList.FocusedNodeChangedEventArgs e) {
            button2.Enabled = button3.Enabled = e.Node != null;
        }

        private void button1_Click(object sender, System.EventArgs e) {
            treeList1.FocusedNode = treeList1.AppendNode(null, null);
        }

        private void button2_Click(object sender, System.EventArgs e) {
            if(treeList1.FocusedNode != null)
                treeList1.FocusedNode = treeList1.AppendNode(null, treeList1.FocusedNode);
        }

        private void button3_Click(object sender, System.EventArgs e) {
            if(treeList1.FocusedNode != null)
                treeList1.DeleteNode(treeList1.FocusedNode);
        }
    }
}
