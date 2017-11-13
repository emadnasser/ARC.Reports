using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.DXperience.Demos.CodeDemo;
using DevExpress.XtraEditors;
using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.Columns;
using DevExpress.XtraTreeList.Nodes;
using DevExpress.XtraTreeList.Nodes.Operations;
using DevExpress.XtraTreeList.StyleFormatConditions;

namespace Examples {
    [CodeExampleClass("Data binding", "Examples.cs")]
    [CodeExampleHighlightTokens("TreeListColumn", "IVirtualTreeListData", "TreeList", "VirtualTreeGetCellValueInfo", "List","IList", "Data", "TreeListNode")]
    public static class DataBindingExamples {
        [CodeExampleSetUp]
        public static object[] SetUp(XtraUserControl sampleHost) {
            TreeList treeList = new TreeList();
            treeList.Dock = System.Windows.Forms.DockStyle.Fill;
            treeList.Parent = sampleHost;
            PanelControl panel = new PanelControl();
            panel.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            panel.Dock = DockStyle.Top;
            panel.Parent = sampleHost;
            panel.Height = 30;
            SimpleButton button = new SimpleButton();
            button.Text = "Append node";
            button.Dock = DockStyle.Top;
            button.Parent = panel;
            button.Height = button.CalcBestSize().Height;
            return new object[] { treeList, button };
        }
        [CodeExampleTearDown]
        public static void TearDown(XtraUserControl sampleHost) {
            foreach(Control control in sampleHost.Controls)
                control.Dispose();
            sampleHost.Controls.Clear();
        }
        [CodeExampleCase("Unbound mode", new Type[] { typeof(DataBindingHelper) })]
        public static void InitializeDataUnboundMode(TreeList treeList, SimpleButton button) {
            TreeListColumn column = treeList.Columns.AddVisible("Node");
            column.Caption = "Node";
            bool res = DataBindingHelper.AppendNode(treeList, 10);
            button.Click += (sender, e) =>
            {
                treeList.AppendNode(new object[] { "Custom node" }, null);
            };
        }
        [CodeExampleCase("Virtual mode", new Type[] { typeof(VirtualData) })]
        public static void InitializeDataVirtualMode(TreeList treeList, SimpleButton button) {
            button.Parent.Visible = false;
            TreeListColumn column = treeList.Columns.AddVisible("Node");
            column.Caption = "Node";
            treeList.DataSource = new VirtualData();
        }
        [CodeExampleCase("Bound mode", new Type[] { typeof(DataBindingHelper) })]
        public static void InitializeDataBoundMode(TreeList treeList, SimpleButton button) {
            treeList.ParentFieldName = "ParentID";
            treeList.KeyFieldName = "ID";
            treeList.DataSource = DataBindingHelper.GetDataSource(10);
            button.Click += (sender, e) =>
            {
                treeList.AppendNode(new object[] { 0, treeList.AllNodesCount, "Custom node" }, null);
            };
        }
        [CodeExampleNestedClass]
        public class VirtualData : TreeList.IVirtualTreeListData {
            const int countChildren = 10;
            int parentIDCore;
            public VirtualData() {
                parentIDCore = 0;
            }
            public VirtualData(string value, int parentID) {
                parentIDCore = parentID;
                Node = value;
            }
            public string Node { get; set; }
            #region IVirtualTreeListData Members
            public void VirtualTreeGetCellValue(VirtualTreeGetCellValueInfo info) {
                info.CellData = ((VirtualData)info.Node).Node;
            }
            public void VirtualTreeGetChildNodes(VirtualTreeGetChildNodesInfo info) {
                IList list = new List<VirtualData>();
                int startIndex = (parentIDCore * countChildren) + 1;
                for(int i = startIndex; i <= countChildren + startIndex; i++)
                    list.Add(new VirtualData("Node" + i, i));
                info.Children = list;
            }
            public void VirtualTreeSetCellValue(VirtualTreeSetCellValueInfo info) {
                ((VirtualData)info.Node).Node = info.NewCellData.ToString();
            }
            #endregion
        }
        [CodeExampleNestedClass]
        public static class DataBindingHelper {
            //Unbound mode
            public static bool AppendNode(TreeList treeList, int countNode) {
                for(int i = 1; i <= countNode; i++) {
                    TreeListNode parentNode = treeList.AppendNode(new object[] { "Node" + i }, null);
                    AppendNodeChild(treeList, parentNode, i * countNode, countNode);
                }
                return true;
            }
            static void AppendNodeChild(TreeList treeList, TreeListNode parentNode, int startIndex, int countNode) {
                for(int i = startIndex + 1; i <= countNode + startIndex; i++)
                    treeList.AppendNode(new object[] { "Node" + i }, parentNode);
            }
            //Bound mode
            public static List<Data> GetDataSource(int countNode) {
                List<Data> list = new List<Data>();
                int startIndex = 1;
                for(int i = startIndex; i <= countNode; i++) {
                    list.Add(new Data(0, i, "Node" + i));
                    list.AddRange(GetDataSource(i, i * countNode, countNode));
                }
                return list;
            }
            static List<Data> GetDataSource(int parentID, int startIndex, int countNode) {
                List<Data> list = new List<Data>();
                for(int i = startIndex + 1; i <= countNode + startIndex; i++)
                    list.Add(new Data(parentID, i, "Node" + i));
                return list;
            }
            public class Data {
                public Data() { }
                public Data(int parentID, int id, string value) {
                    ParentID = parentID;
                    ID = id;
                    Node = value;
                }
                public int ParentID { get; set; }
                public int ID { get; set; }
                public string Node { get; set; }
            }
        }
    }
    [CodeExampleClass("Nodes iterator", "Examples.cs")]
    [CodeExampleHighlightTokens("TreeListColumn", "TreeListOperation", "Data", "TreeListNode", "List","IList")]
    public static class NodesIteratorExamples {
        [CodeExampleSetUp]
        public static object[] SetUp(XtraUserControl sampleHost) {
            TreeList treeList = new TreeList();
            treeList.Dock = System.Windows.Forms.DockStyle.Fill;
            treeList.Parent = sampleHost;
            return new object[] { treeList, sampleHost };
        }
        [CodeExampleTearDown]
        public static void TearDown(XtraUserControl sampleHost) {
            foreach(Control control in sampleHost.Controls)
                control.Dispose();
            sampleHost.Controls.Clear();
        }
        [CodeExampleCase("Create custom operation", new Type[] { typeof(DataSourceHelper), typeof(OperationCollapseAllButThis) })]
        public static void CollapseAllButThis(TreeList treeList, XtraUserControl sampleHost) {
            TreeListColumn column = treeList.Columns.AddVisible("Node");
            column.Caption = "Node";
            treeList.DataSource = DataSourceHelper.GetDataSource(0, 1, 10);
            treeList.BeforeExpand += (sender, e) => {
                OperationCollapseAllButThis op = new OperationCollapseAllButThis(e.Node);
                treeList.BeginUpdate();
                if(e.Node.ParentNode == null)
                    treeList.NodesIterator.DoOperation(op);
                else
                    treeList.NodesIterator.DoLocalOperation(op, e.Node.ParentNode.Nodes);
                treeList.EndUpdate();
            };
        }
        [CodeExampleCase("Create custom delegate", new Type[] { typeof(DataSourceHelper) })]
        [CodeExampleUnderlineTokens("CellValueChanged")]
        public static void RecursiveCellChecking(TreeList treeList, XtraUserControl sampleHost) {
            treeList.DataSource = DataSourceHelper.GetDataSource(0, 1, 10);
            TreeListColumn column = treeList.Columns["Check"];
            column.RealColumnEdit.EditValueChanged += (sender, e) =>
            {
                treeList.BeginUpdate();
                treeList.BeginSort();
                treeList.CloseEditor();
            };
            treeList.CellValueChanged += (sender, e) =>
            {
                treeList.NodesIterator.DoLocalOperation(
                    (node) => { node[e.Column] = e.Value; },
                        e.Node.Nodes);
                TreeListNode parent = e.Node.ParentNode;
                bool value = object.Equals(e.Value, true);
                while(parent != null) {
                    bool check = true;
                    if(!value)
                        check = value;
                    else {
                        treeList.NodesIterator.DoLocalOperation(
                            (node) =>
                            {
                                if(object.Equals(node[e.Column], false))
                                    check = false;
                            },
                            parent.Nodes);
                    }
                    parent["Check"] = check;
                    parent = parent.ParentNode;
                }
                treeList.EndSort();
                treeList.EndUpdate();
            };
        }
        [CodeExampleNestedClass]
        public class OperationCollapseAllButThis : TreeListOperation {
            TreeListNode nodeCore;
            public OperationCollapseAllButThis(TreeListNode node) {
                nodeCore = node;
            }
            public override bool NeedsVisitChildren(TreeListNode node) { return true; }
            public override bool CanContinueIteration(TreeListNode node) { return true; }
            public override bool NeedsFullIteration { get { return false; } }
            public override void Execute(TreeListNode node) {
                if(node == nodeCore) return;
                node.Expanded = false;
            }
        }
        [CodeExampleNestedClass]
        public static class DataSourceHelper {
            public static List<Data> GetDataSource(int parentID, int startIndex, int countNode) {
                return GetDataSourceCore(parentID, startIndex, countNode, 0);
            }
            static List<Data> GetDataSourceCore(int parentID, int startIndex, int countNode, int level) {
                List<Data> list = new List<Data>();
                if(level > 2) return list;
                for(int i = startIndex; i < startIndex + countNode; i++) {
                    list.Add(new Data(parentID, i, "Node" + i));
                    list.AddRange(GetDataSourceCore(i, i * countNode + 1, countNode, level + 1));
                }
                return list;
            }
            public class Data {
                public Data(int parentID, int id, string value) {
                    ParentID = parentID;
                    ID = id;
                    Node = value;
                }
                public int ParentID { get; private set; }
                public int ID { get; private set; }
                public string Node { get; set; }
                public bool Check { get; set; }
            }
        }
    }

    [CodeExampleClass("Customization via code", "Examples.cs")]
    [CodeExampleHighlightTokens("TreeListColumn", "TreeListBand", "Color", "SummaryItemType", "Math", "Data","Bitmap", "List",
        "RepositoryItemTextEdit", "FilterEditorViewMode", "FixedStyle", "TreeListMultiSelectMode", "FormatConditionRuleValue", "FormatCondition", 
        "TreeListFormatRule", "FormatConditionRule2ColorScale", "FormatConditionRuleDataBar", "Rectangle","SolidBrush", "IndicatorObjectPainter", "ImageCollection")]
    [CodeExampleUnderlineTokens("BeginUpdate","EndUpdate")]
    public static class CustomizationExamples {
        [CodeExampleSetUp]
        public static object[] SetUp(XtraUserControl sampleHost) {
            TreeList treeList = new TreeList();
            treeList.Dock = System.Windows.Forms.DockStyle.Fill;
            treeList.Parent = sampleHost;
            return new object[] { treeList };
        }
        [CodeExampleTearDown]
        public static void TearDown(XtraUserControl sampleHost) {
            foreach(Control control in sampleHost.Controls)
                control.Dispose();
            sampleHost.Controls.Clear();
        }
        [CodeExampleCase("Custom node height", new Type[] { typeof(DataSourceHelper) })]
        public static void CustomNodeHeight(TreeList treeList) {
            TreeListColumn column = treeList.Columns.AddVisible("Value1");
            column.Caption = "Value";
            treeList.DataSource = DataSourceHelper.GetDataSource(0, 1, 10);
            treeList.OptionsBehavior.AutoNodeHeight = false;
            treeList.OptionsBehavior.Editable = false;
            treeList.RowHeight = 30;
            treeList.CalcNodeHeight += (sender, e) =>
            {
                if(e.Node.Id % 2 != 0)
                    e.NodeHeight = e.NodeHeight * 2;
            };
        }
        [CodeExampleCase("Customizing columns via code", new Type[] { typeof(DataSourceHelper) })]
        public static void CustomizingColumns(TreeList treeList) {
            treeList.BeginUpdate();
            TreeListColumn column1 = treeList.Columns.AddVisible("Value1");
            TreeListColumn column2 = treeList.Columns.AddVisible("Value2");
            TreeListColumn column3 = treeList.Columns.AddVisible("Value3");
            column1.OptionsColumn.AllowEdit = column2.OptionsColumn.AllowEdit = column3.OptionsColumn.AllowEdit = true;
            column3.OptionsColumn.AllowMove = false;
            column3.OptionsColumn.AllowMoveToCustomizationForm = false;
            column1.Caption = "Column1";
            column2.Caption = "Column2";
            column3.Caption = "Column3";
            treeList.DataSource = DataSourceHelper.GetDataSource(0, 1, 10);
            treeList.OptionsBehavior.Editable = false;
            treeList.OptionsCustomization.AllowColumnMoving = true;
            treeList.OptionsCustomization.AllowColumnResizing = true;
            treeList.OptionsCustomization.CustomizationFormSearchBoxVisible = true;
            treeList.BestFitColumns();
            treeList.EndUpdate();
        }
        [CodeExampleCase("Customizing bands via code", new Type[] { typeof(DataSourceHelper) })]
        public static void CustomizingBands(TreeList treeList) {
            treeList.BeginUpdate();
            TreeListColumn column1 = treeList.Columns.AddVisible("Value1");
            TreeListColumn column2 = treeList.Columns.AddVisible("Value2");
            TreeListColumn column3 = treeList.Columns.AddVisible("Value3");
            TreeListColumn column4 = treeList.Columns.AddVisible("Value4");
            TreeListColumn column5 = treeList.Columns.AddVisible("Value5");
            column1.Caption = "Column1";
            column2.Caption = "Column2";
            column3.Caption = "Column3";
            column4.Caption = "Column4";
            column5.Caption = "Column5";
            treeList.OptionsView.AllowBandColumnsMultiRow = true;
            treeList.OptionsView.ShowBandsMode = DevExpress.Utils.DefaultBoolean.True;
            TreeListBand band1 = treeList.Bands.AddBand("Band1");
            TreeListBand band2 = treeList.Bands.AddBand("Band2");
            band2.OptionsBand.AllowMove = false;
            band2.OptionsBand.AllowSize = false;
            band2.OptionsBand.ShowInCustomizationForm = false;
            TreeListBand band3 = band1.Bands.AddBand("Band3");
            TreeListBand band4 = band1.Bands.AddBand("Band4");
            band2.Columns.Add(column2);
            band3.Columns.Add(column1);
            column1.RowIndex = 0;
            band3.Columns.Add(column3);
            column3.RowIndex = 0;
            band3.Columns.Add(column5);
            column5.RowIndex = 1;
            band4.Columns.Add(column4);
            treeList.DataSource = DataSourceHelper.GetDataSource(0, 1, 10);
            treeList.OptionsBehavior.Editable = false;
            treeList.OptionsCustomization.AllowBandResizing = true;
            treeList.OptionsCustomization.AllowBandMoving = true;
            treeList.OptionsCustomization.AllowChangeBandParent = true;
            treeList.OptionsCustomization.AllowChangeColumnParent = true;
            treeList.OptionsCustomization.ShowBandsInCustomizationForm = true;
            treeList.OptionsCustomization.AllowColumnMoving = true;
            treeList.OptionsCustomization.AllowColumnResizing = true;
            treeList.OptionsCustomization.CustomizationFormSearchBoxVisible = true;
            treeList.BestFitColumns();
            treeList.EndUpdate();
        }
        [CodeExampleCase("Binding select image", new Type[] { typeof(DataSourceHelper) })]
        public static void BindingSelectImage(TreeList treeList) {
            treeList.BeginUpdate();
            treeList.ImageIndexFieldName = "ImageIndex";
            treeList.SelectImageList = DataSourceHelper.Images;
            TreeListColumn column1 = treeList.Columns.AddVisible("Value1");
            TreeListColumn column2 = treeList.Columns.AddVisible("Value2");
            TreeListColumn column3 = treeList.Columns.AddVisible("Value3");
            column1.Caption = "Column1";
            column2.Caption = "Column2";
            column3.Caption = "Column3";
            treeList.DataSource = DataSourceHelper.GetDataSource(0, 1, 10);
            treeList.OptionsBehavior.Editable = false;
            treeList.BestFitColumns();
            treeList.EndUpdate();
        }
        [CodeExampleCase("Binding node checkboxes", new Type[] { typeof(DataSourceHelper) })]
        public static void BindingCheckBoxes(TreeList treeList) {
            treeList.BeginUpdate();
            treeList.CheckBoxFieldName = "Value3";
            treeList.OptionsView.ShowCheckBoxes = true;
            TreeListColumn column1 = treeList.Columns.AddVisible("Value1");
            TreeListColumn column2 = treeList.Columns.AddVisible("Value2");
            column1.Caption = "Column1";
            column2.Caption = "Column2";
            treeList.DataSource = DataSourceHelper.GetDataSource(0, 1, 10);
            treeList.OptionsBehavior.Editable = false;
            treeList.BestFitColumns();
            treeList.EndUpdate();
        }
        [CodeExampleCase("Customizing rows via code", new Type[] { typeof(DataSourceHelper) })]
        public static void CustomizingRows(TreeList treeList) {
            treeList.BeginUpdate();
            TreeListColumn column1 = treeList.Columns.AddVisible("Value1");
            TreeListColumn column2 = treeList.Columns.AddVisible("Value2");
            TreeListColumn column3 = treeList.Columns.AddVisible("Value3");
            column1.Caption = "Column1";
            column2.Caption = "Column2";
            column3.Caption = "Column3";
            treeList.DataSource = DataSourceHelper.GetDataSource(0, 1, 10);
            treeList.OptionsBehavior.Editable = false;
            treeList.Appearance.OddRow.BackColor = Color.Honeydew;
            treeList.Appearance.EvenRow.BackColor = Color.SeaShell;
            treeList.OptionsView.EnableAppearanceEvenRow = true;
            treeList.OptionsView.EnableAppearanceOddRow = true;
            treeList.OptionsView.ShowIndentAsRowStyle = false;
            treeList.RowHeight = 35;
            treeList.OptionsBehavior.AutoNodeHeight = false;
            treeList.OptionsBehavior.ResizeNodes = true;
            treeList.BestFitColumns();
            treeList.EndUpdate();
        }
        [CodeExampleCase("Show summary via code", new Type[] { typeof(DataSourceHelper) })]
        public static void ShowSummary(TreeList treeList) {
            treeList.BeginUpdate();
            TreeListColumn column1 = treeList.Columns.AddVisible("Value1");
            TreeListColumn column2 = treeList.Columns.AddVisible("Value2");
            TreeListColumn column3 = treeList.Columns.AddVisible("Value3");
            column1.Caption = "Column1";
            column2.Caption = "Column2";
            column3.Caption = "Column3";
            treeList.DataSource = DataSourceHelper.GetDataSource(0, 1, 10);
            treeList.OptionsView.ShowRowFooterSummary = true;
            treeList.OptionsView.ShowSummaryFooter = true;
            column1.AllNodesSummary = true;
            column1.RowFooterSummary = SummaryItemType.Count;
            column1.SummaryFooter = SummaryItemType.Count;
            column2.AllNodesSummary = true;
            column2.RowFooterSummary = SummaryItemType.Max;
            column2.SummaryFooter = SummaryItemType.Max;
            column3.AllNodesSummary = true;
            column3.RowFooterSummary = SummaryItemType.Min;
            column3.SummaryFooter = SummaryItemType.Min;
            treeList.FooterPanelHeight = 50;
            treeList.BestFitColumns();
            treeList.EndUpdate();
        }
        [CodeExampleCase("Customizing treeList via code", new Type[] { typeof(DataSourceHelper) })]
        public static void CustomizingTreeList(TreeList treeList) {
            treeList.BeginUpdate();
            TreeListColumn column1 = treeList.Columns.AddVisible("Value1");
            TreeListColumn column2 = treeList.Columns.AddVisible("Value2");
            TreeListColumn column3 = treeList.Columns.AddVisible("Value3");
            column1.Caption = "Column1";
            column2.Caption = "Column2";
            column3.Caption = "Column3";
            treeList.DataSource = DataSourceHelper.GetDataSource(0, 1, 10);
            treeList.IndicatorWidth = 20;
            treeList.TreeLevelWidth = 20;
            treeList.ColumnPanelRowHeight = 25;
            treeList.OptionsBehavior.Editable = false;
            treeList.OptionsBehavior.AllowRecursiveNodeChecking = true;
            treeList.OptionsBehavior.AllowIncrementalSearch = true;
            treeList.OptionsView.ShowVertLines = false;
            treeList.OptionsView.ShowHorzLines = false;
            treeList.OptionsView.ShowIndicator = false;
            treeList.OptionsView.ShowColumns = true;
            treeList.OptionsView.ShowCheckBoxes = true;
            treeList.OptionsView.ShowCaption = true;
            treeList.Caption = "TreeList";
            treeList.CaptionHeight = 20;
            treeList.OptionsView.AutoWidth = true;
            treeList.TopVisibleNodeIndex = 10;
            treeList.ExpandAll();
            treeList.BestFitColumns();
            treeList.EndUpdate();
        }
        [CodeExampleCase("Custom cell edit", new Type[] { typeof(DataSourceHelper) })]
        [CodeExampleUnderlineTokens("CustomNodeCellEdit")]
        public static void CustomCellEdit(TreeList treeList) {
            treeList.BeginUpdate();
            TreeListColumn column1 = treeList.Columns.AddVisible("Value1");
            TreeListColumn column2 = treeList.Columns.AddVisible("Value2");
            TreeListColumn column3 = treeList.Columns.AddVisible("Value3");
            column1.Caption = "Column1";
            column2.Caption = "Column2";
            column3.Caption = "Column3";
            treeList.DataSource = DataSourceHelper.GetDataSource(0, 1, 10);
            treeList.CustomNodeCellEdit += (sender, e) =>
            {
                if(e.Column != column3) return;
                if(e.Node.Id % 2 == 0)
                    e.RepositoryItem = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            };
            treeList.BestFitColumns();
            treeList.EndUpdate();
        }
        [CodeExampleCase("Customizing find panel via code", new Type[] { typeof(DataSourceHelper) })]
        public static void CustomizingFindPanel(TreeList treeList) {
            treeList.BeginUpdate();
            TreeListColumn column1 = treeList.Columns.AddVisible("Value1");
            TreeListColumn column2 = treeList.Columns.AddVisible("Value2");
            TreeListColumn column3 = treeList.Columns.AddVisible("Value3");
            column1.Caption = "Column1";
            column2.Caption = "Column2";
            column3.Caption = "Column3";
            treeList.DataSource = DataSourceHelper.GetDataSource(0, 1, 10);
            treeList.OptionsFind.AllowFindPanel = true;
            treeList.OptionsFind.AlwaysVisible = true;
            treeList.OptionsFind.FindMode = FindMode.Always;
            treeList.OptionsFind.FindNullPrompt = "Enter text to search...";
            treeList.OptionsFind.FindDelay = 1000;
            treeList.OptionsFind.ClearFindOnClose = true;
            treeList.OptionsFind.HighlightFindResults = true;
            treeList.OptionsFind.ShowClearButton = true;
            treeList.OptionsFind.ShowCloseButton = false;
            treeList.OptionsFind.ShowFindButton = true;
            treeList.OptionsFind.FindFilterColumns = "*";
            treeList.OptionsBehavior.EnableFiltering = false;
            treeList.BestFitColumns();
            treeList.EndUpdate();
        }
        [CodeExampleCase("Customizing columns filter via code", new Type[] { typeof(DataSourceHelper) })]
        public static void CustomizingColumnsFilter(TreeList treeList) {
            treeList.BeginUpdate();
            TreeListColumn column1 = treeList.Columns.AddVisible("Value1");
            TreeListColumn column2 = treeList.Columns.AddVisible("Value2");
            TreeListColumn column3 = treeList.Columns.AddVisible("Value3");
            column1.Caption = "Column1";
            column2.Caption = "Column2";
            column3.Caption = "Column3";
            column3.OptionsFilter.AllowFilter = false;
            treeList.OptionsBehavior.EnableFiltering = true;
            treeList.DataSource = DataSourceHelper.GetDataSource(0, 1, 10);
            treeList.OptionsFilter.AllowColumnMRUFilterList = true;
            treeList.OptionsFilter.AllowFilterEditor = true;
            treeList.OptionsFilter.AllowMRUFilterList = true;
            treeList.OptionsFilter.ColumnFilterPopupRowCount = 10;
            treeList.OptionsFilter.FilterMode = FilterMode.Standard;
            treeList.OptionsFilter.MRUColumnFilterListCount = 10;
            treeList.OptionsFilter.MRUFilterListPopupCount = 10;
            treeList.OptionsFilter.ShowAllValuesInCheckedFilterPopup = true;
            treeList.OptionsFilter.ShowAllValuesInFilterPopup = true;
            treeList.OptionsFilter.DefaultFilterEditorView = FilterEditorViewMode.Text;
            treeList.OptionsBehavior.ExpandNodesOnFiltering = true;
            treeList.BestFitColumns();
            treeList.EndUpdate();
        }
        [CodeExampleCase("Customizing fixed bands via code", new Type[] { typeof(DataSourceHelper) })]
        public static void CustomizingFixedBands(TreeList treeList) {
            treeList.BeginUpdate();
            treeList.OptionsView.ShowBandsMode = DevExpress.Utils.DefaultBoolean.True;
            TreeListColumn column1 = treeList.Columns.AddVisible("Value1");
            TreeListColumn column2 = treeList.Columns.AddVisible("Value2");
            TreeListColumn column3 = treeList.Columns.AddVisible("Value3");
            TreeListColumn column4 = treeList.Columns.AddVisible("Value4");
            TreeListColumn column5 = treeList.Columns.AddVisible("Value5");
            column1.Caption = "Column1";
            column1.RowIndex = 0;
            column2.Caption = "Column2";
            column2.RowIndex = 1;
            column3.Caption = "Column3";
            column4.Caption = "Column4";
            column5.Caption = "Column5";
            TreeListBand band1 = treeList.Bands.AddBand("Band1");
            TreeListBand band2 = treeList.Bands.AddBand("Band2");
            TreeListBand band3 = treeList.Bands.AddBand("Band3");
            TreeListBand band4 = treeList.Bands.AddBand("Band4");
            band1.Columns.Add(column1);
            band1.Columns.Add(column2);
            band2.Columns.Add(column3);
            band3.Columns.Add(column4);
            band4.Columns.Add(column5);
            band1.Fixed = FixedStyle.Left;
            band4.Fixed = FixedStyle.Right;
            treeList.DataSource = DataSourceHelper.GetDataSource(0, 1, 10);
            treeList.OptionsBehavior.Editable = false;
            treeList.OptionsView.AutoWidth = false;
            treeList.OptionsCustomization.AllowBandResizing = true;
            treeList.OptionsCustomization.AllowBandMoving = true;
            treeList.OptionsCustomization.AllowChangeBandParent = true;
            treeList.OptionsCustomization.AllowChangeColumnParent = true;
            treeList.OptionsCustomization.AllowColumnMoving = true;
            treeList.OptionsCustomization.AllowColumnResizing = true;
            treeList.OptionsView.AllowBandColumnsMultiRow = true;
            treeList.FixedLineWidth = 2;
            treeList.BestFitColumns();
            treeList.EndUpdate();
        }
        [CodeExampleCase("Customizing fixed columns via code", new Type[] { typeof(DataSourceHelper) })]
        public static void CustomizingFixedColumns(TreeList treeList) {
            treeList.BeginUpdate();
            TreeListColumn column1 = treeList.Columns.AddVisible("Value1");
            TreeListColumn column2 = treeList.Columns.AddVisible("Value2");
            TreeListColumn column3 = treeList.Columns.AddVisible("Value3");
            TreeListColumn column4 = treeList.Columns.AddVisible("Value4");
            TreeListColumn column5 = treeList.Columns.AddVisible("Value5");
            column1.Caption = "Column1";
            column2.Caption = "Column2";
            column3.Caption = "Column3";
            column4.Caption = "Column4";
            column5.Caption = "Column5";
            column1.Fixed = FixedStyle.Left;
            column2.Fixed = FixedStyle.Right;
            treeList.DataSource = DataSourceHelper.GetDataSource(0, 1, 10);
            treeList.OptionsBehavior.Editable = false;
            treeList.OptionsView.AutoWidth = false;
            treeList.OptionsCustomization.AllowChangeColumnParent = true;
            treeList.OptionsCustomization.AllowColumnMoving = true;
            treeList.OptionsCustomization.AllowColumnResizing = true;
            treeList.FixedLineWidth = 2;
            treeList.BestFitColumns();
            treeList.EndUpdate();
        }
        [CodeExampleCase("Customizing selection via code", new Type[] { typeof(DataSourceHelper) })]
        public static void CustomizingSelection(TreeList treeList) {
            treeList.BeginUpdate();
            TreeListColumn column1 = treeList.Columns.AddVisible("Value1");
            TreeListColumn column2 = treeList.Columns.AddVisible("Value2");
            TreeListColumn column3 = treeList.Columns.AddVisible("Value3");
            TreeListColumn column4 = treeList.Columns.AddVisible("Value4");
            TreeListColumn column5 = treeList.Columns.AddVisible("Value5");
            column1.Caption = "Column1";
            column2.Caption = "Column2";
            column3.Caption = "Column3";
            column4.Caption = "Column4";
            column5.Caption = "Column5";
            treeList.DataSource = DataSourceHelper.GetDataSource(0, 1, 10);
            treeList.OptionsSelection.MultiSelect = true;
            treeList.OptionsSelection.MultiSelectMode = TreeListMultiSelectMode.CellSelect;
            treeList.OptionsSelection.SelectNodesOnRightClick = false;
            treeList.OptionsSelection.UseIndicatorForSelection = true;
            treeList.OptionsSelection.InvertSelection = false;
            treeList.OptionsBehavior.Editable = false;
            treeList.OptionsBehavior.KeepSelectedOnClick = true;
            treeList.BestFitColumns();
            treeList.EndUpdate();
        }
        [CodeExampleCase("Customizing conditional formatting via code", new Type[] { typeof(DataSourceHelper) })]
        public static void CustomizingConditionalFormatting(TreeList treeList) {
            treeList.BeginUpdate();
            treeList.OptionsMenu.ShowConditionalFormattingItem = true;
            TreeListColumn column1 = treeList.Columns.AddVisible("Value1");
            TreeListColumn column2 = treeList.Columns.AddVisible("Value6");
            TreeListColumn column3 = treeList.Columns.AddVisible("Value3");
            column1.Caption = "Column1";
            column2.Caption = "Column2";
            column3.Caption = "Column3";
            treeList.DataSource = DataSourceHelper.GetDataSource(0, 1, 10);

            FormatConditionRuleValue ruleValue = new FormatConditionRuleValue();
            ruleValue.Condition = FormatCondition.Expression;
            ruleValue.Value1 = 5;
            ruleValue.Expression = "[Value3] == false";
            ruleValue.Appearance.BackColor = Color.LightGreen;
            treeList.FormatRules.Add(column3, ruleValue);

            TreeListFormatRule rule1 = new TreeListFormatRule();
            FormatConditionRule2ColorScale rule2ColorScale = new FormatConditionRule2ColorScale();
            rule1.Column = column2;
            rule1.ColumnApplyTo = column1;
            rule2ColorScale.PredefinedName = "White, Red";
            rule1.Rule = rule2ColorScale;
            treeList.FormatRules.Add(rule1);

            TreeListFormatRule rule2 = new TreeListFormatRule();
            FormatConditionRuleDataBar ruleDataBar = new FormatConditionRuleDataBar();
            rule2.Column = column2;
            rule2.ApplyToRow = true;
            ruleDataBar.PredefinedName = "Blue Gradient";
            rule2.Rule = ruleDataBar;
            treeList.FormatRules.Add(rule2);
            treeList.EndUpdate();
        }
        [CodeExampleCase("Custom draw", new Type[] { typeof(DataSourceHelper) })]
        [CodeExampleUnderlineTokens("CustomDrawNodeCell", "CustomDrawNodeIndent", "CustomDrawColumnHeader", "CustomDrawNodeIndicator")]
        public static void CustomDraw(TreeList treeList) {
            treeList.BeginUpdate();
            TreeListColumn column1 = treeList.Columns.AddVisible("Value1");
            TreeListColumn column2 = treeList.Columns.AddVisible("Value2");
            TreeListColumn column3 = treeList.Columns.AddVisible("Value3");
            column1.Caption = "Column1";
            column2.Caption = "Column2";
            column3.Caption = "Column3";
            treeList.DataSource = DataSourceHelper.GetDataSource(0, 1, 10);
            treeList.CustomDrawNodeCell += (sender, e) =>
            {
                int cellIndex = e.Column.AbsoluteIndex + e.Node.Id;
                if(cellIndex % 2 != 0 && !e.Node.Selected)
                    e.Appearance.BackColor = Color.LightYellow;
            };
            treeList.CustomDrawNodeIndent += (sender, e) =>
            {
                if(e.Node.Id % 2 == 0)
                    e.Appearance.BackColor = Color.LightYellow;
            };
            treeList.CustomDrawColumnHeader += (sender, e) =>
            {
                e.DefaultDraw();
                if(e.Pressed && e.HotTrack) return;
                if(e.Column == null || e.Column.AbsoluteIndex % 2 == 0) {
                    Rectangle realBounds = Rectangle.Inflate(e.Bounds, -1, -1);
                    using(SolidBrush brush = new SolidBrush(Color.LightYellow))
                        e.Graphics.FillRectangle(brush, realBounds);
                    e.Appearance.DrawString(e.Cache, e.Caption, e.CaptionRect);
                }
            };
            treeList.CustomDrawNodeIndicator += (sender, e) =>
            {
                e.DefaultDraw();
                if(e.Node.Id % 2 != 0) {
                    using(SolidBrush brush = new SolidBrush(Color.LightYellow))
                        e.Graphics.FillRectangle(brush, Rectangle.Inflate(e.Bounds, -1, -1));
                    DevExpress.Utils.Drawing.IndicatorObjectPainter painter = e.Painter as DevExpress.Utils.Drawing.IndicatorObjectPainter;
                    if(DevExpress.Utils.ImageCollection.IsImageListImageExists(painter.ImageList, e.ImageIndex)) {
                        Size size = DevExpress.Utils.ImageCollection.GetImageListSize(painter.ImageList);
                        int offsetX = (e.Bounds.Width - size.Width) / 2;
                        int offsetY = (e.Bounds.Height - size.Height) / 2;
                        Rectangle realBounds = Rectangle.Inflate(e.Bounds, -offsetX, -offsetY);
                        DevExpress.Utils.ImageCollection.DrawImageListImage(e.Cache, painter.ImageList, e.ImageIndex, realBounds);
                    }

                };
            };
            treeList.EndUpdate();
        }
        [CodeExampleNestedClass]
        public static class DataSourceHelper {
            public static List<Data> GetDataSource(int parentID, int startIndex, int countNode) {
                return GetDataSourceCore(parentID, startIndex, countNode, 0);
            }
            static List<Data> GetDataSourceCore(int parentID, int startIndex, int countNode, int level) {
                List<Data> list = new List<Data>();
                if(level > 2) return list;
                for(int i = startIndex; i < startIndex + countNode; i++) {
                    list.Add(new Data(parentID, i, i, level, countNode));
                    list.AddRange(GetDataSourceCore(i, i * countNode + 1, countNode, level + 1));
                }
                return list;
            }
            static DevExpress.Utils.ImageCollection imagesCore;
            public static DevExpress.Utils.ImageCollection Images {
                get {
                    if(imagesCore == null) {
                        imagesCore = new DevExpress.Utils.ImageCollection();
                        AddImage(Color.LightCoral, imagesCore);
                        AddImage(Color.LightGreen, imagesCore);
                        AddImage(Color.LightSkyBlue, imagesCore);
                    }
                    return imagesCore;
                }
            }
            static void AddImage(Color color, DevExpress.Utils.ImageCollection images) {
                Bitmap bmp = new Bitmap(16, 16);
                using(Graphics g = Graphics.FromImage(bmp))
                    g.Clear(color);
                images.AddImage(bmp);
            }
            public class Data {
                public Data(int parentID, int id, int value, int level, int countNode) {
                    ParentID = parentID;
                    ID = id;
                    Value1 = "[Row" + value + "; Column1]";
                    Value2 = "[Row" + value + "; Column2]";
                    Value4 = "[Row" + value + "; Column4]";
                    Value5 = "[Row" + value + "; Column5]";
                    Value6 = (double)value / Math.Pow(countNode, level);
                    Value3 = value % 2 == 0;
                    ImageIndex = level;
                }
                public int ParentID { get; private set; }
                public int ID { get; private set; }
                public string Value1 { get; set; }
                public string Value2 { get; set; }
                public bool Value3 { get; set; }
                public string Value4 { get; set; }
                public string Value5 { get; set; }
                public double Value6 { get; set; }
                public int ImageIndex { get; set; }
            }
        }
    }
}
