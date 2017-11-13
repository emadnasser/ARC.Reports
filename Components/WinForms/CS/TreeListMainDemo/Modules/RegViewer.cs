using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using Microsoft.Win32;
using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.Nodes;
using DevExpress.Utils;
using DevExpress.XtraBars;
using DevExpress.DXperience.Demos;

namespace DevExpress.XtraTreeList.Demos {
    public partial class TreeListRegViewer : TutorialControl {
        public override TreeList ExportControl { get { return null; } }
        protected override string BarName { get { return "RegViewer"; } }
        protected override BarManager Manager { get { return barManager1; } }
        protected override void InitBarInfo() {
            this.BarInfos.Add(new BarInfo("Display Style", new ItemClickEventHandler(StyleClick), imageCollection3.Images[0], true, true, false));
            this.BarInfos.Add(new BarInfo("Full Collapse", new ItemClickEventHandler(CollapseClick), imageCollection3.Images[1], false, false, true));
            this.BarInfos.Add(new BarInfo("Show First Footer", new ItemClickEventHandler(ShowFirstFooterClick), imageCollection3.Images[2], true, false, false));
            this.BarInfos.Add(new BarInfo("Show Second Footer", new ItemClickEventHandler(ShowSecondFooterClick), imageCollection3.Images[3], true, false, false));
            this.BarInfos.Add(new BarInfo("Show Preview", new ItemClickEventHandler(ShowPreviewClick), imageCollection3.Images[4], true, false, false));
            this.BarInfos.Add(new BarInfo("Columns Selector", new ItemClickEventHandler(ColumnsSelectorClick), imageCollection3.Images[5], true, false, false));
        }

        public TreeListRegViewer() {
            InitializeComponent();
            TutorialInfo.WhatsThisCodeFile = "CS\\TreeListMainDemo\\Modules\\RegViewer.cs";
            TutorialInfo.WhatsThisXMLFile = "DevExpress.XtraTreeList.Demos.CodeInfo.RegViewer.xml";
        }

        //<treeList1>
        private Array root = Enum.GetValues(typeof(RegistryHive));
        private string[] rootNames;

        private void TreeListRegViewer_Load(object sender, System.EventArgs e) {
            CreateArrayWithNames();
            AppendNodes(rootNames, null, "", "");
            //<skip>
            SetAppearances(treeList1, treeList2);
            ResetOddEvenAppearance(treeList1);
            //</skip>
        }
        //</treeList1>

        void StyleClick(object sender, ItemClickEventArgs e) {
            if (GetBarItemPushed(0)) {
                treeList1.Dock = DockStyle.Left;
                splitter1.Dock = DockStyle.Left;
                treeList1.Width = Width / 3;
            }
            else {
                treeList1.Dock = DockStyle.Top;
                splitter1.Dock = DockStyle.Top;
                treeList1.Height = Height / 2;
            }
        }
        void CollapseClick(object sender, ItemClickEventArgs e) {
            treeList1.CollapseAll();
        }
        void ShowFirstFooterClick(object sender, ItemClickEventArgs e) {
            treeList1.OptionsView.ShowSummaryFooter = GetBarItemPushed(2);
        }
        void ShowSecondFooterClick(object sender, ItemClickEventArgs e) {
            treeList2.OptionsView.ShowSummaryFooter = GetBarItemPushed(3);
        }
        void ShowPreviewClick(object sender, ItemClickEventArgs e) {
            treeList1.OptionsView.ShowPreview =
            treeList1.OptionsView.AutoCalcPreviewLineCount =
            treeList1.OptionsView.ShowHorzLines = GetBarItemPushed(4);
        }
        void ColumnsSelectorClick(object sender, ItemClickEventArgs e) {
            if (GetBarItemPushed(5)) treeList2.ColumnsCustomization();
            else treeList2.DestroyCustomization();
        }
        

        //<treeList1>
        /*
         ~Add root nodes representing root Registry Keys:
         */
        private void AppendNodes(string[] names, TreeListNode aNode, string root, string root2) {
            Cursor currentCursor = Cursor.Current;
            Cursor.Current = Cursors.WaitCursor;

            treeList1.BeginUnboundLoad();
            TreeListNode node;
            foreach (string s in names) {
                node = treeList1.AppendNode(new object[] { s }, aNode);
                try {
                    if (root == "")
                        node.HasChildren = KeyByName(s, "").SubKeyCount > 0;
                    else
                        node.HasChildren = KeyByName(root, (root2 != "" ? root2 + "\\" + s : s)).SubKeyCount > 0;
                    node.Tag = true;
                }
                catch { }
            }
            treeList1.EndUnboundLoad();

            Cursor.Current = currentCursor;
        }
        /*
         ~Append child nodes (child Registry Keys) when a node is expanded:
         */
        private void treeList1_BeforeExpand(object sender, DevExpress.XtraTreeList.BeforeExpandEventArgs e) {
            if (Convert.ToBoolean(e.Node.Tag)) {
                string fullName = FullNameByNode(e.Node, 0);
                string name1 = RegKey(fullName, 0);
                string name2 = RegKey(fullName, 2);
                RegistryKey rk = KeyByName(name1, name2);
                string[] names = rk.GetSubKeyNames();
                AppendNodes(names, e.Node, name1, name2);
            }
            e.Node.Tag = false;
        }
        /*
         ~Expand/collapse nodes when pressing the Right and Left Arrow keyboard buttons:
         */
        private void treeList1_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e) {
            TreeList tl = sender as TreeList;
            if (tl.FocusedNode != null) {
                if (e.KeyCode == Keys.Right) {
                    if (!tl.FocusedNode.Expanded && tl.FocusedNode.HasChildren)
                        tl.FocusedNode.Expanded = true;
                    else tl.MoveNextVisible();
                }
                if (e.KeyCode == Keys.Left) {
                    if (tl.FocusedNode.Expanded)
                        tl.FocusedNode.Expanded = false;
                    else tl.MovePrevVisible();
                }
            }
        }

        private void CreateArrayWithNames() {
            rootNames = new string[root.Length];
            for (int i = 0; i < root.Length; i++)
                rootNames[i] = StringKeyByRegistryHive((RegistryHive)root.GetValue(i));
        }
        private string StringKeyByRegistryHive(RegistryHive hKey) {
            return RegistryKey.OpenRemoteBaseKey(hKey, "").Name;
        }
        private RegistryKey KeyByName(string name, string subName) {
            int ind = -1;
            for (int i = 0; i < rootNames.Length; i++)
                if (name == rootNames.GetValue(i).ToString()) {
                    ind = i;
                    break;
                }
            if (ind > -1)
                try {
                    if (subName != "")
                        return RegistryKey.OpenRemoteBaseKey((RegistryHive)root.GetValue(ind), "").OpenSubKey(subName);
                    else
                        return RegistryKey.OpenRemoteBaseKey((RegistryHive)root.GetValue(ind), "");
                }
                catch { }
            return null;
        }
        //</treeList1>

        //<treeList2>
        private void treeList1_FocusedNodeChanged(object sender, DevExpress.XtraTreeList.FocusedNodeChangedEventArgs e) {
            string s = FullNameByNode(e.Node, 0);
            barStaticItem1.Caption = s;
            AppendValues(s);
        }

        private void AppendValues(string key) {
            Cursor currentCursor = Cursor.Current;
            Cursor.Current = Cursors.WaitCursor;

            treeList2.BeginUnboundLoad();
            treeList2.ClearNodes();
            TreeListNode node;
            RegistryKey rk = KeyByName(RegKey(key, 0), RegKey(key, 2));
            try {
                string[] values = rk.GetValueNames();
                foreach (string s in values) {
                    object obj = rk.GetValue(s);
                    node = treeList2.AppendNode(new object[] { s == "" ? "(Default)" : s, obj, obj.GetType().ToString() }, null);
                }
            }
            catch { }
            treeList2.EndUnboundLoad();
            Cursor.Current = currentCursor;
        }
        //</treeList2>

        private void SetAppearances(TreeList sourceTreeList, TreeList treeList) {
            treeList.Appearance.Assign(sourceTreeList.Appearance);
        }

        private void ResetOddEvenAppearance(TreeList tl) {
            tl.Appearance.OddRow.Reset();
            tl.Appearance.EvenRow.Reset();
        }

        private string RegKey(string s, int i) {
            string[] sArr = s.Split('\\');
            if (i == 0) return sArr[0];
            else if (i == 1) return sArr[sArr.Length - 1];
            else {
                string ret = "";
                for (int n = 1; n < sArr.Length; n++)
                    ret += sArr[n] + (n < sArr.Length - 1 ? "\\" : "");
                return ret;
            }
        }
        private string FullNameByNode(TreeListNode node, int columnId) {
            string ret = node.GetValue(columnId).ToString();
            while (node.ParentNode != null) {
                node = node.ParentNode;
                ret = node.GetValue(columnId).ToString() + "\\" + ret;
            }
            return ret;
        }
        

        private void treeList1_GetSelectImage(object sender, DevExpress.XtraTreeList.GetSelectImageEventArgs e) {
            if (e.Node.ParentNode == null) e.NodeImageIndex = 0;
            else e.NodeImageIndex = (e.FocusedNode) ? 2 : 1;
        }

        private void treeList2_GetSelectImage(object sender, DevExpress.XtraTreeList.GetSelectImageEventArgs e) {
            string s = e.Node.GetValue(colType).ToString();
            if (s == "System.Byte[]") e.NodeImageIndex = 2;
            else if (s == "System.Int32") e.NodeImageIndex = 1;
            else e.NodeImageIndex = 0;
        }
        private string ByteToString(byte[] b) {
            string ret = "";
            int app = 10;
            for (int i = 0; i < b.Length && i < app; i++) {
                ret += b.GetValue(i).ToString() + (i == app - 1 && i != b.Length - 1 ? "..." : " ");
            }
            return ret;
        }
        private void treeList2_GetNodeDisplayValue(object sender, DevExpress.XtraTreeList.GetNodeDisplayValueEventArgs e) {
            if (e.Column.AbsoluteIndex == 1) {
                if (e.Node.GetValue(2).ToString() == "System.Byte[]") {
                    e.Value = ByteToString((byte[])e.Value);
                }
                if (e.Node.GetValue(2).ToString() == "System.String") {
                    e.Value = string.Format("\"{0}\"", e.Value);
                }
            }
        }

        

        private void treeList2_HideCustomizationForm(object sender, System.EventArgs e) {
            SetBarItemChecked(5, false);
        }

        private void treeList1_GetPreviewText(object sender, DevExpress.XtraTreeList.GetPreviewTextEventArgs e) {
            e.PreviewText = FullNameByNode(e.Node, 0);
        }

        private void treeList2_ShowCustomizationForm(object sender, System.EventArgs e) {
            SetBarItemChecked(5, true);
        }
    }
}
