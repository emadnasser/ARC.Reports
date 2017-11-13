using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace DevExpress.XtraVerticalGrid.Demos.Tutorials {
    /// <summary>
    /// Summary description for UnboundMode.
    /// </summary>
    public partial class UnboundMode : TutorialControl {
        public UnboundMode() {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();
            //
            // TODO: Add any constructor code after InitializeComponent call
            //
        }

        private void UnboundMode_Load(object sender, System.EventArgs e) {
            RowsCreator.CreateRows(0, vGridControl1);
            treeView1.ExpandAll();
        }

        private void treeView1_AfterExpand(object sender, System.Windows.Forms.TreeViewEventArgs e) {
            if(e.Node.Nodes.Count > 0) e.Node.ImageIndex = e.Node.SelectedImageIndex = 2;
        }

        private void treeView1_AfterCollapse(object sender, System.Windows.Forms.TreeViewEventArgs e) {
            if(e.Node.Nodes.Count > 0) e.Node.ImageIndex = e.Node.SelectedImageIndex = 1;
        }

        private void treeView1_AfterSelect(object sender, System.Windows.Forms.TreeViewEventArgs e) {
            if(e.Node.Nodes.Count == 0) {
                foreach(TreeNode node in treeView1.Nodes[0].Nodes)
                    node.ImageIndex = node.SelectedImageIndex = 0;
                e.Node.ImageIndex = e.Node.SelectedImageIndex = 3;
                RowsCreator.CreateRows(e.Node.Index, vGridControl1);
            }
        }
    }
}
