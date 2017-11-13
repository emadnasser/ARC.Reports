using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DevExpress.XtraTreeList.Nodes;
using DevExpress.XtraTreeList.Nodes.Operations;

namespace DevExpress.XtraTreeList.Demos {
    public partial class MultiDragAndDrop : TutorialControl {
        public MultiDragAndDrop() {
            InitializeComponent();
            tl1ClassView.DataSource = ClassViewHelper.GetClassView1();
            tl2ClassView.DataSource = ClassViewHelper.GetClassView2();
            InitTreeList(tl1ClassView);
            InitTreeList(tl2ClassView);
        }
        void InitTreeList(TreeList treeList) {
            treeList.OptionsDragAndDrop.DragNodesMode = DragNodesMode.Multiple;
            treeList.OptionsDragAndDrop.AcceptOuterNodes = true;
            treeList.CustomizeNewNodeFromOuterData += OnTLCustomizeNewNodeFromOuterData;
            treeList.BeforeDropNode += OnTLBeforeDropNode;
            treeList.BeforeDragNode += OnTLBeforeDragNode;
            treeList.DragOver += OnTLDragOver;
            treeList.DragDrop += OnTLDragDrop;
            treeList.DragLeave += OnTLDragLeave;
            treeList.GiveFeedback += OnTLGiveFeedback;
            treeList.CalcNodeDragImageIndex += OnTLCalcNodeDragImageIndex;
            treeList.ExpandAll();
        }

        void OnTLCalcNodeDragImageIndex(object sender, CalcNodeDragImageIndexEventArgs e) {
            DXDragEventArgs args = e.DragArgs.GetDXDragEventArgs(sender as TreeList);
            IDragNodesProvider provider = args.Data.GetData(typeof(IDragNodesProvider)) as IDragNodesProvider;
            if(provider == null) return;
            if(!AllowDropNodes(args, provider))
                e.ImageIndex = -1;
        }
        void OnTLGiveFeedback(object sender, GiveFeedbackEventArgs e) {
            e.UseDefaultCursors = false;
        }
        void OnTLDragLeave(object sender, EventArgs e) {
            SetDefaultCursor();
        }
        void OnTLDragDrop(object sender, DragEventArgs e) {
            SetDefaultCursor();
        }
        void OnTLDragOver(object sender, DragEventArgs e) {
            IDragNodesProvider provider = e.Data.GetData(typeof(IDragNodesProvider)) as IDragNodesProvider;
            if(provider == null) e.Effect = DragDropEffects.None;
            else {
                DXDragEventArgs args = e.GetDXDragEventArgs((TreeList)sender);
                e.Effect = GetDragDropEffect(args, provider);
            }
            SetDragCursor(e.Effect);
        }
        DragDropEffects GetDragDropEffect(DXDragEventArgs e, IDragNodesProvider provider) {
            return AllowDropNodes(e, provider) ? e.Effect : DragDropEffects.None;
        }
        bool AllowDropNodes(DXDragEventArgs e, IDragNodesProvider provider) {
            if(e.HitInfo.HitTest.RowInfo == null) return true;
            TreeListNode destNode = e.HitInfo.HitTest.RowInfo.Node;
            if(destNode == null) return true;
            if(e.DragInsertPosition == DragInsertPosition.None) return true;
            int destLevel = e.DragInsertPosition == DragInsertPosition.AsChild ? destNode.Level + 1 : destNode.Level;
            foreach(TreeListNode node in provider.DragNodes) {
                if(destNode.ParentNode == node.ParentNode) return false;
                if(destLevel != node.Level) return false;
            }
            return true;
        }
        TreeListNode HasAsParent(TreeListNode node1, TreeListNode node2) {
            if(node1.Level > node2.Level)
                return node1.HasAsParent(node2) ? node1 : null;
            if(node1.Level < node2.Level)
                return node2.HasAsParent(node1) ? node2 : null;
            return null;
        }
        void OnTLBeforeDragNode(object sender, BeforeDragNodeEventArgs e) {
            if(e.Nodes.Count <= 1) return;
            int i = 0, j = i + 1;
            List<TreeListNode> nonDragNodes = new List<TreeListNode>();
            while(i != e.Nodes.Count - 1) {
                TreeListNode nonDragNode = HasAsParent(e.Nodes[i], e.Nodes[j]);
                if(nonDragNode != null)
                    nonDragNodes.Add(nonDragNode);
                if(j == e.Nodes.Count - 1) {
                    i++;
                    j = i + 1;
                }
                else
                    j++;
            }
            if(nonDragNodes.Count == 0) return;
            foreach(TreeListNode node in nonDragNodes)
                e.Nodes.Remove(node);
        }
        bool AllowDropNode(TreeListNode sourceNode, TreeListNodes nodes) {
            foreach(TreeListNode node in nodes) {
                object value1 = sourceNode.GetValue("Name");
                object value2 = node.GetValue("Name");
                if(object.Equals(value1, value2)) return true;
            }
            return false;
        }
        void OnTLBeforeDropNode(object sender, BeforeDropNodeEventArgs e) {
            if(e.IsCopy) return;
            TreeListNodes nodes = e.DestinationNode == null ? ((TreeList)sender).Nodes : e.DestinationNode.Nodes;
            e.Cancel = AllowDropNode(e.SourceNode, nodes);
        }
        void OnTLCustomizeNewNodeFromOuterData(object sender, CustomizeNewNodeFromOuterDataEventArgs e) {
            TreeList treeList = (TreeList)sender;
            e.NewData[treeList.ParentFieldName] = e.DestinationNode == null ? 0 : e.DestinationNode[treeList.KeyFieldName];
            e.NewData[treeList.KeyFieldName] = treeList.AllNodesCount ;
            e.NewData[treeList.ImageIndexFieldName] = e.SourceNode[treeList.ImageIndexFieldName];
        }
        private void ceAcceptOuterNodesChanged(object sender, EventArgs e) {
            tl1ClassView.OptionsDragAndDrop.AcceptOuterNodes = tl2ClassView.OptionsDragAndDrop.AcceptOuterNodes = ceAcceptOuterNodes.Checked;
        }
        private void ceMultipleNodesDragAndDropChanged(object sender, EventArgs e) {
            tl1ClassView.OptionsDragAndDrop.DragNodesMode = tl2ClassView.OptionsDragAndDrop.DragNodesMode =
                ceMultipleNodesDragAndDrop.Checked ? DragNodesMode.Multiple : DragNodesMode.Single;
            tl1ClassView.OptionsSelection.MultiSelect = tl2ClassView.OptionsSelection.MultiSelect = ceMultipleNodesDragAndDrop.Checked;
        }
        private void SetDefaultCursor() {
            Cursor = Cursors.Default;
        }
        private void SetDragCursor(DragDropEffects e) {
            if(e == DragDropEffects.Move)
                Cursor = new Cursor(System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceStream("DevExpress.XtraTreeList.Demos.Images.move.ico"));
            if(e == DragDropEffects.Copy)
                Cursor = new Cursor(System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceStream("DevExpress.XtraTreeList.Demos.Images.copy.ico"));
            if(e == DragDropEffects.None)
                Cursor = Cursors.No;
        }
    }
}
