using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace DevExpress.XtraTreeList.Demos.Tutorials {
    /// <summary>
    /// Summary description for DragDrop.
    /// </summary>
    public partial class DragDrop : TutorialControl {
        public DragDrop() {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();
            InitData();
            //
            // TODO: Add any constructor code after InitializeComponent call
            //
        }

        private void InitData() {
            DevExpress.XtraTreeList.Design.XViews xv = new DevExpress.XtraTreeList.Design.XViews(treeList1);
            checkBox1.Checked = treeList1.OptionsDragAndDrop.DragNodesMode != DragNodesMode.None;
        }

        //<checkBox1>
        private void checkBox1_CheckedChanged(object sender, System.EventArgs e) {
            treeList1.OptionsDragAndDrop.DragNodesMode = checkBox1.Checked ? DragNodesMode.Single : DragNodesMode.None;
        }
        //</checkBox1>

        private DevExpress.XtraTreeList.Nodes.TreeListNode GetDragNode(IDataObject data) {
            return data.GetData(typeof(DevExpress.XtraTreeList.Nodes.TreeListNode)) as DevExpress.XtraTreeList.Nodes.TreeListNode;
        }

        //<listBox1>
        private string GetStringByNode(DevExpress.XtraTreeList.Nodes.TreeListNode node) {
            string ret = "";
            for(int i = 0; i < treeList1.Columns.Count; i++)
                ret += node.GetDisplayText(i) + (i < treeList1.Columns.Count - 1 ? "; " : ".");
            return ret;
        }

        private void listBox1_DragEnter(object sender, System.Windows.Forms.DragEventArgs e) {
            if(GetDragNode(e.Data) != null)
                e.Effect = DragDropEffects.Copy;
        }

        private void listBox1_DragDrop(object sender, System.Windows.Forms.DragEventArgs e) {
            DevExpress.XtraEditors.ListBoxControl lb = sender as DevExpress.XtraEditors.ListBoxControl;
            DevExpress.XtraTreeList.Nodes.TreeListNode node = GetDragNode(e.Data);
            if(node != null) {
                string dragString = GetStringByNode(node);
                int ind = lb.IndexFromPoint(lb.PointToClient(new Point(e.X, e.Y)));
                if(ind == -1)
                    lb.Items.Add(dragString);
                else
                    lb.Items.Insert(ind, dragString);
            }
        }
        //</listBox1>
    }
}
