using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using DevExpress.XtraTreeList.Nodes;

namespace DevExpress.XtraTreeList.Demos.Tutorials {
    /// <summary>
    /// Summary description for NodeChecking.
    /// </summary>
    public partial class NodeChecking : TutorialControl {
        public NodeChecking() {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();
            InitData();
            //
            // TODO: Add any constructor code after InitializeComponent call
            //
        }
        public override bool SetNewWhatsThisPadding { get { return true; } }
        private void InitData() {
            DevExpress.XtraTreeList.Design.XViews xv = new DevExpress.XtraTreeList.Design.XViews(treeList1);
            treeList1.SetNodeCheckState(treeList1.Nodes[0].Nodes[0], CheckState.Checked, true);
        }
        // <chkAllowRecursive>
        private void chkAllowRecursive_Properties_CheckedChanged(object sender, EventArgs e) {
            treeList1.OptionsBehavior.AllowRecursiveNodeChecking = chkAllowRecursive.Checked;
        }
        // </chkAllowRecursive>
        // <chkAllowIndeterminate>
        private void chkAllowIndeterminate_CheckedChanged(object sender, EventArgs e) {
            treeList1.OptionsBehavior.AllowIndeterminateCheckState = chkAllowIndeterminate.Checked;
        }
        // </chkAllowIndeterminate>
    }
}
