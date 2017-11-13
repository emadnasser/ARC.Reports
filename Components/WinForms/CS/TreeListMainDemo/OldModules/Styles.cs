using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using DevExpress.XtraTreeList;
using DevExpress.Utils;
using DevExpress.XtraBars;
using DevExpress.DXperience.Demos;
using DevExpress.XtraEditors;

namespace DevExpress.XtraTreeList.Demos {
    /// <summary>
    /// Summary description for TreeListStyles.
    /// </summary>
    public partial class TreeListStyles : TutorialControl {
        public TreeListStyles() {
            InitializeComponent();
            InitData();
            InitEditors();
            InitStyles();
        }

        private DataView dataView;
        protected override string BarName { get { return "Styles"; } }
        protected override BarManager Manager { get { return barManager1; } }
        protected override void InitBarInfo() {
            this.BarInfos.Add(new BarInfo("AutoWidth", new ItemClickEventHandler(AutoWidthClick), imageList2.Images[0], true, false, false));
            this.BarInfos.Add(new BarInfo("Show Indent As RowStyle", new ItemClickEventHandler(ShowIndentAsRowStyleClick), imageList2.Images[1], true, false, false));
            this.BarInfos.Add(new BarInfo("Show Buttons", new ItemClickEventHandler(ShowButtonsClick), imageList2.Images[2], true, false, false));
            this.BarInfos.Add(new BarInfo("Show Root", new ItemClickEventHandler(ShowRootClick), imageList2.Images[3], true, false, false));
            this.BarInfos.Add(new BarInfo("Show Focused Frame", new ItemClickEventHandler(ShowFocusedFrameClick), imageList2.Images[4], true, false, false));
            this.BarInfos.Add(new BarInfo("Show Indicator", new ItemClickEventHandler(ShowIndicatorClick), imageList2.Images[5], true, false, false));
            this.BarInfos.Add(new BarInfo("Show Columns", new ItemClickEventHandler(ShowColumnsClick), imageList2.Images[6], true, false, false));
            this.BarInfos.Add(new BarInfo("Show VertLines", new ItemClickEventHandler(ShowVertLinesClick), imageList2.Images[7], true, false, false));
            this.BarInfos.Add(new BarInfo("Show HorzLines", new ItemClickEventHandler(ShowHorzLinesClick), imageList2.Images[8], true, false, false));
            this.BarInfos.Add(new BarInfo("Show Row Footer Summary", new ItemClickEventHandler(ShowRowFooterSummaryClick), imageList2.Images[13], true, false, false));
            this.BarInfos.Add(new BarInfo("Show Summary Footer", new ItemClickEventHandler(ShowSummaryFooterClick), imageList2.Images[14], true, false, false));
            this.BarInfos.Add(new BarInfo("Show Button Mode", null, imageList2.Images[10], false, false, true,
                new BarInfo[] {new BarInfo("Show Always", new ItemClickEventHandler(ShowAlwaysClick), null, true, treeList1.ShowButtonMode == ShowButtonModeEnum.ShowAlways, false), 
				new BarInfo("Show For Focused Cell", new ItemClickEventHandler(ShowForFocusedCellClick), null, true, treeList1.ShowButtonMode == ShowButtonModeEnum.ShowForFocusedCell, false),
				new BarInfo("Show For Focused Row", new ItemClickEventHandler(ShowForFocusedRowClick), null, true, treeList1.ShowButtonMode == ShowButtonModeEnum.ShowForFocusedRow, false),
				new BarInfo("Show Only In Editor", new ItemClickEventHandler(ShowOnlyInEditorClick), null, true, treeList1.ShowButtonMode == ShowButtonModeEnum.ShowOnlyInEditor, false)}, 1));
            this.BarInfos.Add(new BarInfo("TreeLine Style", null, imageList2.Images[11], false, false, false,
                new BarInfo[] {new BarInfo("Dark", new ItemClickEventHandler(DarkClick), null, true, treeList1.TreeLineStyle == LineStyle.Dark, false), 
				new BarInfo("Large", new ItemClickEventHandler(LargeClick), null, true, treeList1.TreeLineStyle == LineStyle.Large, false),
				new BarInfo("Light", new ItemClickEventHandler(LightClick), null, true, treeList1.TreeLineStyle == LineStyle.Light, false),
				new BarInfo("Percent50", new ItemClickEventHandler(Percent50Click), null, true, treeList1.TreeLineStyle == LineStyle.Percent50, false),
				new BarInfo("Solid", new ItemClickEventHandler(SolidClick), null, true, treeList1.TreeLineStyle == LineStyle.Solid, false),
				new BarInfo("Wide", new ItemClickEventHandler(WideClick), null, true, treeList1.TreeLineStyle == LineStyle.Wide, false), 
				new BarInfo("None", new ItemClickEventHandler(NoneClick), null, true, treeList1.TreeLineStyle == LineStyle.None, false)}, 2));
            this.BarInfos.Add(new BarInfo("Show Customization Form", new ItemClickEventHandler(ShowCustomizationFormClick), imageList2.Images[15], true, false, true));
            this.BarInfos.Add(new BarInfo("Drag Nodes", new ItemClickEventHandler(DragNodesClick), imageList2.Images[12], true, false, false));
            this.BarInfos.Add(new BarInfo("Print Preview", new ItemClickEventHandler(PrintPreviewClick), imageList2.Images[16], false, false, true));
            this.BarInfos.Add(new BarInfo("Print Designer", new ItemClickEventHandler(PrintDesignerClick), imageList2.Images[17], false, false, false));

            InitOptions();
        }

        void AutoWidthClick(object sender, ItemClickEventArgs e) {
            treeList1.OptionsView.AutoWidth = GetBarItemPushed(0);
        }
        void ShowIndentAsRowStyleClick(object sender, ItemClickEventArgs e) {
            treeList1.OptionsView.ShowIndentAsRowStyle = GetBarItemPushed(1);
        }
        void ShowButtonsClick(object sender, ItemClickEventArgs e) {
            treeList1.OptionsView.ShowButtons = GetBarItemPushed(2);
        }
        void ShowRootClick(object sender, ItemClickEventArgs e) {
            treeList1.OptionsView.ShowRoot = GetBarItemPushed(3);
        }
        void ShowFocusedFrameClick(object sender, ItemClickEventArgs e) {
            treeList1.OptionsView.FocusRectStyle = GetBarItemPushed(4) ? DrawFocusRectStyle.CellFocus : DrawFocusRectStyle.None;
        }
        void ShowIndicatorClick(object sender, ItemClickEventArgs e) {
            treeList1.OptionsView.ShowIndicator = GetBarItemPushed(5);
        }
        void ShowColumnsClick(object sender, ItemClickEventArgs e) {
            treeList1.OptionsView.ShowColumns = GetBarItemPushed(6);
        }
        void ShowVertLinesClick(object sender, ItemClickEventArgs e) {
            treeList1.OptionsView.ShowVertLines = GetBarItemPushed(7);
        }
        void ShowHorzLinesClick(object sender, ItemClickEventArgs e) {
            treeList1.OptionsView.ShowHorzLines = GetBarItemPushed(8);
        }
        void ShowRowFooterSummaryClick(object sender, ItemClickEventArgs e) {
            treeList1.OptionsView.ShowRowFooterSummary = GetBarItemPushed(9);
        }
        void ShowSummaryFooterClick(object sender, ItemClickEventArgs e) {
            treeList1.OptionsView.ShowSummaryFooter = GetBarItemPushed(10);
        }
        void ShowCustomizationFormClick(object sender, ItemClickEventArgs e) {
            if(GetBarItemPushed(13)) treeList1.ColumnsCustomization();
            else treeList1.DestroyCustomization();
        }
        void DragNodesClick(object sender, ItemClickEventArgs e) {
            treeList1.OptionsDragAndDrop.DragNodesMode = GetBarItemPushed(14) ? DragNodesMode.Single : DragNodesMode.None;
        }

        void PrintPreviewClick(object sender, ItemClickEventArgs e) {
            Cursor currentCursor = Cursor.Current;
            Cursor.Current = Cursors.WaitCursor;
            treeList1.ShowPrintPreview();
            Cursor.Current = currentCursor;
        }

        void PrintDesignerClick(object sender, ItemClickEventArgs e) {
            Cursor currentCursor = Cursor.Current;
            Cursor.Current = Cursors.WaitCursor;
            DevExpress.XtraEditors.XtraForm frm = new DevExpress.XtraEditors.XtraForm();
            frm.Text = "Print Designer";
            DevExpress.XtraTreeList.Frames.TreeListPrinting print = new DevExpress.XtraTreeList.Frames.TreeListPrinting();
            print.InitFrame(treeList1, "PrintingReport management", null);
            print.Dock = DockStyle.Fill;
            frm.Controls.Add(print);
            frm.Size = print.UserControlSize;
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowDialog();
            Cursor.Current = currentCursor;
        }

        void ShowAlwaysClick(object sender, ItemClickEventArgs e) {
            treeList1.ShowButtonMode = ShowButtonModeEnum.ShowAlways;
        }

        void ShowForFocusedCellClick(object sender, ItemClickEventArgs e) {
            treeList1.ShowButtonMode = ShowButtonModeEnum.ShowForFocusedCell;
        }

        void ShowForFocusedRowClick(object sender, ItemClickEventArgs e) {
            treeList1.ShowButtonMode = ShowButtonModeEnum.ShowForFocusedRow;
        }

        void ShowOnlyInEditorClick(object sender, ItemClickEventArgs e) {
            treeList1.ShowButtonMode = ShowButtonModeEnum.ShowOnlyInEditor;
        }

        void DarkClick(object sender, ItemClickEventArgs e) {
            treeList1.TreeLineStyle = LineStyle.Dark;
        }

        void LargeClick(object sender, ItemClickEventArgs e) {
            treeList1.TreeLineStyle = LineStyle.Large;
        }

        void LightClick(object sender, ItemClickEventArgs e) {
            treeList1.TreeLineStyle = LineStyle.Light;
        }

        void Percent50Click(object sender, ItemClickEventArgs e) {
            treeList1.TreeLineStyle = LineStyle.Percent50;
        }

        void SolidClick(object sender, ItemClickEventArgs e) {
            treeList1.TreeLineStyle = LineStyle.Solid;
        }

        void WideClick(object sender, ItemClickEventArgs e) {
            treeList1.TreeLineStyle = LineStyle.Wide;
        }

        void NoneClick(object sender, ItemClickEventArgs e) {
            treeList1.TreeLineStyle = LineStyle.None;
        }
        private void InitOptions() {
            SetBarItemChecked(0, treeList1.OptionsView.AutoWidth);
            SetBarItemChecked(1, treeList1.OptionsView.ShowIndentAsRowStyle);
            SetBarItemChecked(2, treeList1.OptionsView.ShowButtons);
            SetBarItemChecked(3, treeList1.OptionsView.ShowRoot);
            SetBarItemChecked(4, treeList1.OptionsView.FocusRectStyle != DrawFocusRectStyle.None);
            SetBarItemChecked(5, treeList1.OptionsView.ShowIndicator);
            SetBarItemChecked(6, treeList1.OptionsView.ShowColumns);
            SetBarItemChecked(7, treeList1.OptionsView.ShowVertLines);
            SetBarItemChecked(8, treeList1.OptionsView.ShowHorzLines);
            SetBarItemChecked(9, treeList1.OptionsView.ShowRowFooterSummary);
            SetBarItemChecked(10, treeList1.OptionsView.ShowSummaryFooter);
            SetBarItemChecked(14, treeList1.OptionsDragAndDrop.DragNodesMode != DragNodesMode.None);
        }

        private void InitData() {
            string DBFileName = DevExpress.Utils.FilesHelper.FindingFileName(Application.StartupPath, "Data\\Departments.xml");
            if(DBFileName != "") {
                DataSet dataSet = new DataSet();
                dataSet.ReadXml(DBFileName);
                treeList1.DataSource = dataView = dataSet.Tables[0].DefaultView;
                treeList1.PopulateColumns();
                treeList1.ExpandAll();
                treeList1.BestFitColumns();
            }
        }

        private void InitEditors() {
            DevExpress.XtraEditors.Repository.RepositoryItemComboBox cb = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            treeList1.RepositoryItems.Add(cb);
            DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit se = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            treeList1.RepositoryItems.Add(se);

            string s, oldLocation = "";
            DataView dv = new DataView(dataView.Table);
            dv.Sort = "[Location] ASC";
            for(int i = 0; i < dv.Count; i++) {
                s = dv[i].Row.ItemArray.GetValue(5) as string;
                if(s != oldLocation)
                    cb.Items.Add(s);
                oldLocation = s;
            }
            cb.DropDownRows = 10;

            DevExpress.XtraTreeList.Columns.TreeListColumn col;

            treeList1.Columns["Location"].ColumnEdit = cb;
            col = treeList1.Columns["Budget"];
            col.ColumnEdit = se;
            col.Format.FormatString = "c";
            col.RowFooterSummary = col.SummaryFooter = SummaryItemType.Sum;
            col.RowFooterSummaryStrFormat = col.SummaryFooterStrFormat = "Sum={0:c}";
            col.AllNodesSummary = true;
            col = treeList1.Columns["Check"];
            col.RowFooterSummary = SummaryItemType.Sum;
            col.RowFooterSummaryStrFormat = "Checked: {0}";
        }

        private void TreeListStyles_Load(object sender, System.EventArgs e) {
            chbAlphaBlending.Checked = false;
        }

        private void InitStyles() {
            xapp = new DevExpress.XtraTreeList.Design.XAppearances(System.Environment.GetFolderPath(System.Environment.SpecialFolder.System) + "\\DevExpress.XtraTreeList.Appearances.xml", ceNewStyles.Checked);
            lsStyles.Items.AddRange(xapp.FormatNames);
            lsStyles.SelectedIndex = lsStyles.Items.Count > 1 ? 1 : 0;
            InitAppearanceList(treeList1);
        }

        void InitAppearanceList(TreeList tl) {
            lbcAppearances.Items.Clear();
            PropertyDescriptorCollection collection = TypeDescriptor.GetProperties(tl.Appearance);
            for(int i = 0; i < collection.Count; i++)
                if(collection[i].PropertyType == typeof(AppearanceObject))
                    lbcAppearances.Items.Add(collection[i].Name);
            lbcAppearances.SelectedIndex = 0;
        }

        private void lsStyles_SelectedIndexChanged(object sender, System.EventArgs e) {
            if(lsStyles.SelectedItem != null)
                xapp.LoadScheme(lsStyles.SelectedItem.ToString(), treeList1);
            treeList1.SetDefaultRowHeight();
            if(chbAlphaBlending.Checked) xtraTreeListBlending1.RefreshStyles();
        }

        private void ceNewStyles_CheckedChanged(object sender, System.EventArgs e) {
            if(xapp != null) xapp.ShowNewStylesOnly = ceNewStyles.Checked;
            int index = lsStyles.SelectedIndex;
            lsStyles.Items.Clear();
            lsStyles.Items.AddRange(xapp.FormatNames);
            lsStyles.SelectedIndex = index;
        }

        private void lbcAppearances_SelectedIndexChanged(object sender, System.EventArgs e) {
            propertyGrid1.SelectedObjects = SelectedObjects;
        }

        AppearanceObject GetAppearanceObjectByName(TreeList tl, string name) {
            if(tl.Appearance == null) return null;
            else return tl.Appearance.GetAppearance(name);
        }
        object[] SelectedObjects {
            get {
                if(lbcAppearances.SelectedItem == null) return null;
                ArrayList ret = new ArrayList();
                for(int i = 0; i < lbcAppearances.SelectedIndices.Count; i++) {
                    object obj = GetAppearanceObjectByName(treeList1, lbcAppearances.GetItem(lbcAppearances.SelectedIndices[i]).ToString());
                    ret.Add(obj);
                }
                return ret.ToArray();
            }
        }

        private void treeList1_GetSelectImage(object sender, DevExpress.XtraTreeList.GetSelectImageEventArgs e) {
            if(e.FocusedNode)
                e.NodeImageIndex += 7;
        }

        private void chbAlphaBlending_CheckedChanged(object sender, System.EventArgs e) {
            DevExpress.XtraEditors.CheckEdit chb = sender as DevExpress.XtraEditors.CheckEdit;
            xtraTreeListBlending1.Enabled = chb.Checked;
            btnAlphaBlending.Enabled = chb.Checked;
        }

        private void btnAlphaBlending_Click(object sender, System.EventArgs e) {
            xtraTreeListBlending1.ShowDialog();
        }

        private void treeList1_ShowCustomizationForm(object sender, System.EventArgs e) {
            SetBarItemChecked(13, true);
        }

        private void treeList1_HideCustomizationForm(object sender, System.EventArgs e) {
            SetBarItemChecked(13, false);
        }
    }
}
