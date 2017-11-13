using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.Nodes;
using DevExpress.XtraEditors.Controls;

namespace DevExpress.XtraTreeList.Demos {
    public partial class TreeListDragDrop : TutorialControl {
        public TreeListDragDrop() {
            InitializeComponent();
            TutorialInfo.WhatsThisCodeFile = "CS\\TreeListMainDemo\\Modules\\DragDrop.cs;CS\\TreeListMainDemo\\Modules\\DragObject.cs";
            TutorialInfo.WhatsThisXMLFile = "DevExpress.XtraTreeList.Demos.CodeInfo.DragDrop.xml";
            InitData();

            //<treeList1>
            /*
            ~Note: the following properties are set at design time and listed here only for demonstration purposes.
            ~Allow the TreeList to accept objects during drag-and-drop:
            treeList1.AllowDrop = true;
            ~Enable node drag-and-drop:
            treeList1.OptionsBehavior.DragNodes = true;
            ~Allow end-users to clone nodes during drag-and-drop by holding the CTRL key down:
            treeList1.OptionsBehavior.CanCloneNodesOnDrop = true;
            */
            //</treeList1>
            
            //<label1>
            /*
            ~Note: the following property is set at design time and listed here only for demonstration purposes.
             ~Allow the label to accept objects during drag-and-drop:
             label1.AllowDrop = true;
            */
            //</label1>

        }
		
        public override TreeList ExportControl { get { return treeList1; } }

        private void InitData() {
            TreeListNode node = treeList1.Nodes.Add("Project: Betaron", new DateTime(2011, 05, 01), new DateTime(2011, 09, 20), 0);
            node.StateImageIndex = 0;
            node.Nodes.Add("Planning", new DateTime(2011, 05, 12), new DateTime(2011, 06, 15), 0).StateImageIndex = 0;
            node.Nodes.Add("Design", new DateTime(2011, 05, 12), new DateTime(2011, 06, 15), 0).StateImageIndex = 0;
            node.Nodes.Add("Development", new DateTime(2011, 07, 16), new DateTime(2011, 09, 20), 0).StateImageIndex = 0;
            node.Nodes.Add("Testing and Delivery", new DateTime(2011, 08, 12), new DateTime(2011, 10, 17), 0).StateImageIndex = 0;
            node.Nodes[0].Nodes.Add("Market research", new DateTime(2011, 05, 01), new DateTime(2011, 05, 13), 0).StateImageIndex = 2;
            node.Nodes[0].Nodes.Add("Making specification", new DateTime(2011, 05, 14), new DateTime(2011, 06, 04), 2).StateImageIndex = 2;
            node.Nodes[0].Nodes.Add("Documentation", new DateTime(2011, 06, 05), new DateTime(2011, 06, 15), 0).StateImageIndex = 2;
            node.Nodes[1].Nodes.Add("Design of a web pages", new DateTime(2011, 07, 16), new DateTime(2011, 07, 28), 1).StateImageIndex = 2;
            node.Nodes[1].Nodes.Add("Pages layout", new DateTime(2011, 08, 01), new DateTime(2011, 09, 20), 2).StateImageIndex = 2;
            node.Nodes[2].Nodes.Add("Design", new DateTime(2011, 07, 16), new DateTime(2011, 07, 28), 2).StateImageIndex = 2;
            node.Nodes[2].Nodes.Add("Coding", new DateTime(2011, 08, 01), new DateTime(2011, 09, 20), 1).StateImageIndex = 2;
            node.Nodes[3].Nodes.Add("Testing", new DateTime(2011, 08, 12), new DateTime(2011, 08, 28), 2).StateImageIndex = 2;
            node.Nodes[3].Nodes.Add("Content", new DateTime(2011, 09, 1), new DateTime(2011, 09, 24), 1).StateImageIndex = 2;
            treeList1.ExpandAll();
        }
        
        
        private TreeListNode GetVisibleNodeAbove(TreeListNode node) {
            int visIndex = treeList1.GetVisibleIndexByNode(node);
            return treeList1.GetNodeByVisibleIndex(visIndex - 1);
        }

        //<imageListBoxControl1>
        private ImageListBoxItem newItem = null;

        private void imageListBoxControl1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e) {
            int index = imageListBoxControl1.IndexFromPoint(new Point(e.X, e.Y));
            if(index >= 0)
                newItem = imageListBoxControl1.Items[index];
        }

        private void imageListBoxControl1_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e) {
            if(newItem == null || e.Button != MouseButtons.Left) return;
            imageListBoxControl1.DoDragDrop(new DragObject(newItem.ImageIndex), DragDropEffects.Copy);
        }

        private void imageListBoxControl1_GiveFeedback(object sender, System.Windows.Forms.GiveFeedbackEventArgs e) {
            e.UseDefaultCursors = false;
        }
        //</imageListBoxControl1>


        //<treeList1>
        private void treeList1_DragDrop(object sender, System.Windows.Forms.DragEventArgs e) {
            DXDragEventArgs args = treeList1.GetDXDragEventArgs(e);
            DragObject dobj = GetDragObject(args.Data);
            if(dobj != null) {
                TreeListNode node = args.TargetNode;
                if(args.HitInfo.HitInfoType == HitInfoType.Empty || node != null) {
                    node = treeList1.AppendNode(dobj.DragData, node);
                    node.StateImageIndex = dobj.ImageIndex;
                    treeList1.MakeNodeVisible(node);
                    TreeListNode parentNode = node.ParentNode;
                    if(parentNode != null && (e.KeyState & 4) != 0) {
                        int index = -1;
                        if(parentNode.ParentNode != null)
                            index = parentNode.ParentNode.Nodes.IndexOf(parentNode);
                        treeList1.MoveNode(node, parentNode.ParentNode);
                        treeList1.SetNodeIndex(node, index);
                    }
                }
            }
            SetDefaultCursor();
        }

        private void treeList1_DragLeave(object sender, System.EventArgs e) {
            SetDefaultCursor();
        }

        private void treeList1_DragOver(object sender, System.Windows.Forms.DragEventArgs e) {
            DXDragEventArgs args = treeList1.GetDXDragEventArgs(e);
            if(args.Node == null) {
                if(args.HitInfo.HitInfoType == HitInfoType.Empty || args.TargetNode != null)
                    args.Effect = DragDropEffects.Copy;
                else
                    args.Effect = DragDropEffects.None;
            }
            SetDragCursor(args.Effect);
        }
        private void treeList1_GiveFeedback(object sender, System.Windows.Forms.GiveFeedbackEventArgs e) {
            e.UseDefaultCursors = false;
        }

        private DragObject GetDragObject(IDataObject data) {
            return data.GetData(typeof(DragObject)) as DragObject;
        }
        private TreeListNode GetDragNode(IDataObject data) {
            return data.GetData(typeof(TreeListNode)) as TreeListNode;
        }

        private void SetDefaultCursor() {
            Cursor = Cursors.Default;
        }
        private void SetDragCursor(DragDropEffects e) {
            if (e == DragDropEffects.Move)
                Cursor = new Cursor(System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceStream("DevExpress.XtraTreeList.Demos.Images.move.ico"));
            if (e == DragDropEffects.Copy)
                Cursor = new Cursor(System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceStream("DevExpress.XtraTreeList.Demos.Images.copy.ico"));
            if (e == DragDropEffects.None)
                Cursor = Cursors.No;
        }
        //</treeList1>

        //<label1>
        private void label1_DragEnter(object sender, System.Windows.Forms.DragEventArgs e) {
            TreeListNode node = GetDragNode(e.Data);
            if(node != null) {
                e.Effect = DragDropEffects.Copy;
                Cursor = new Cursor(System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceStream("DevExpress.XtraTreeList.Demos.Images.delete.ico"));
                label1.Appearance.ImageIndex = 1;
            }
            else
                Cursor = Cursors.No;
        }
        private void SetDefaultLabel() {
            label1.Appearance.ImageIndex = 0;
            SetDefaultCursor();
        }
        private void label1_DragLeave(object sender, System.EventArgs e) {
            SetDefaultLabel();
        }

        private void label1_DragDrop(object sender, System.Windows.Forms.DragEventArgs e) {
            TreeListNode node = GetDragNode(e.Data);
            if(node != null) {
                treeList1.DeleteNode(node);
            }
            SetDefaultLabel();
        }
        //</label1>

    }
}
