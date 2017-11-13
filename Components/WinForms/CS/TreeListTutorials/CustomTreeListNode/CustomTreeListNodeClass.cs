using System;
using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.Nodes;

namespace DevExpress.XtraTreeList.Demos.Tutorials {
	//<treeList1>
    public class CustomTLNode : TreeListNode {
		public CustomTLNode(int id, TreeListNodes owner) : base(id, owner) {
		}
		private string NodeParameters() {
			string s = "Node " + this.Id.ToString();
			if(this.HasChildren) {
				s += "; ChildNodes Count = " + this.Nodes.Count;
				if(this.Expanded)
					s += "; Expanded"; 
			}
			if(this.Tag != null && !this.Tag.Equals(""))
				s +="; Tag: " + this.Tag.ToString(); 
			return s;
		}
        public override object this[object columnID] {
			get { return NodeParameters(); }
			set { 
				if(columnID.Equals(this.TreeList.Columns[0])) {
					this.Tag = value; 
					this.TreeList.LayoutChanged();
				}
			}
		}	
	}
    //</treeList1>

	public class CustomTreeList : TreeList {
		//returns a CustomTLNode object
		protected override TreeListNode CreateNode(int nodeID, TreeListNodes owner, object tag) {
			return new CustomTLNode(nodeID, owner);
		}
		protected override void RaiseCellValueChanged(CellValueChangedEventArgs e) {
			CustomTLNode node = e.Node as CustomTLNode;
			if(e.Column == Columns[0]) {
				node[e.Column] = e.Value;
				RefreshRowsInfo();
			}
			base.RaiseCellValueChanged(e);
		}
		protected override DevExpress.XtraEditors.Container.EditorContainerHelper CreateHelper() {
			return new CustomTreeListContainerHelper(this);
		}
	}

	public class CustomTreeListContainerHelper : TreeListContainerHelper {
		public CustomTreeListContainerHelper(TreeList owner) : base(owner) {}
		public override void ActivateEditor(DevExpress.XtraEditors.Repository.RepositoryItem ritem, DevExpress.XtraEditors.Container.UpdateEditorInfoArgs args) {
			args = new DevExpress.XtraEditors.Container.UpdateEditorInfoArgs(args.MakeReadOnly, args.Bounds, args.Appearance, Owner.FocusedNode.Tag, args.LookAndFeel, args.ErrorText);
			base.ActivateEditor(ritem, args);
		}
	}
}
