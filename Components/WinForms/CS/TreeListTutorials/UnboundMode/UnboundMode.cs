using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.IO;
using DevExpress.XtraTreeList.Nodes;

namespace DevExpress.XtraTreeList.Demos.Tutorials {
    /// <summary>
    /// Summary description for UnboundMode.
    /// </summary>
    public partial class UnboundMode : TutorialControl {
        public UnboundMode() {
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
            InitFolders(Directory.GetDirectoryRoot(Directory.GetCurrentDirectory()), null);
        }

        private void InitFolders(string path, TreeListNode pNode) {
            treeList1.BeginUnboundLoad();
            TreeListNode node;
            DirectoryInfo di;
            try {
                string[] root = Directory.GetDirectories(path);
                foreach(string s in root) {
                    try {
                        di = new DirectoryInfo(s);
                        node = treeList1.AppendNode(new object[] { s, di.Name, "Folder", null }, pNode);
                        node.StateImageIndex = 0;
                        node.HasChildren = HasFiles(s);
                        if(node.HasChildren)
                            node.Tag = true;
                    }
                    catch { }
                }
            }
            catch { }
            InitFiles(path, pNode);
            treeList1.EndUnboundLoad();
        }

        private void InitFiles(string path, TreeListNode pNode) {
            TreeListNode node;
            FileInfo fi;
            try {
                string[] root = Directory.GetFiles(path);
                foreach(string s in root) {
                    fi = new FileInfo(s);
                    node = treeList1.AppendNode(new object[] { s, fi.Name, "File", fi.Length }, pNode);
                    node.StateImageIndex = 1;
                    node.HasChildren = false;
                }
            }
            catch { }
        }

        private bool HasFiles(string path) {
            string[] root = Directory.GetFiles(path);
            if(root.Length > 0) return true;
            root = Directory.GetDirectories(path);
            if(root.Length > 0) return true;
            return false;
        }

        private void treeList1_BeforeExpand(object sender, DevExpress.XtraTreeList.BeforeExpandEventArgs e) {
            if(e.Node.Tag != null) {
                Cursor currentCursor = Cursor.Current;
                Cursor.Current = Cursors.WaitCursor;
                InitFolders(e.Node.GetDisplayText("FullName"), e.Node);
                e.Node.Tag = null;
                Cursor.Current = currentCursor;
            }
        }

        private void treeList1_AfterExpand(object sender, DevExpress.XtraTreeList.NodeEventArgs e) {
            if(e.Node.StateImageIndex != 1) e.Node.StateImageIndex = 2;
        }

        private void treeList1_AfterCollapse(object sender, DevExpress.XtraTreeList.NodeEventArgs e) {
            if(e.Node.StateImageIndex != 1) e.Node.StateImageIndex = 0;
        }
    }
}
