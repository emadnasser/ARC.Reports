using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraGrid.Views.Layout.ViewInfo;
using DevExpress.XtraLayout.Customization;
using DevExpress.XtraGrid.Views.Layout;
using DevExpress.XtraLayout.Utils;
using System.Data.OleDb;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.DXperience.Demos;
using DevExpress.XtraEditors.Controls;

namespace DevExpress.XtraGrid.Demos {
    public partial class AdvancedGridEditing : BaseLayoutModule {
        //<allowEditOnDoubleClick>
        bool allowEditOnDoubleClickCore;
        //</allowEditOnDoubleClick>
        public AdvancedGridEditing() {
            CreateWaitDialog();
            InitializeComponent();
            TutorialInfo.WhatsThisCodeFile = "CS\\GridMainDemo\\ModulesLayoutView\\AdvancedGridEditing.cs";
            TutorialInfo.WhatsThisXMLFile = "DevExpress.XtraGrid.Demos.CodeInfo.AdvancedGridEditing.xml";
            InitData();
            InitControls();
        }
        protected void InitControls() {
            this.layoutControl1.SizeChanged += new System.EventHandler(this.layoutControl1_SizeChanged);
            //<cbMasterTablePosition>
            this.cbMasterTablePosition.SelectedIndexChanged += new System.EventHandler(this.cbMasterTablePosition_SelectedIndexChanged);
            //</cbMasterTablePosition>
            foreach(MasterTablePosition mode in Enum.GetValues(typeof(MasterTablePosition)))
                cbMasterTablePosition.Properties.Items.Add(new ImageComboBoxItem(EnumTitlesKeeper<MasterTablePosition>.GetTitle(mode), mode, -1));
            cbMasterTablePosition.EditValue = MasterTablePosition.Left;
            //<masterGrid>
            employesLayoutView.CustomUnboundColumnData += new CustomColumnDataEventHandler(employesLayoutView_CustomUnboundColumnData);
            //</masterGrid>

            viewOrderGridView.ForceDoubleClick = true;
            //<allowEditOnDoubleClick>
            this.viewOrderGridView.DoubleClick += new System.EventHandler(this.viewOrderGridView_DoubleClick);
            //</allowEditOnDoubleClick>
            this.editOrderlayoutView.MouseDown += new MouseEventHandler(editOrderlayoutView_MouseDown);
            //<detailShowHideBtn>
            this.detailShowHideBtn.Click += new System.EventHandler(this.detailShowHideBtn_Click);
            //</detailShowHideBtn>
            allowEditOnDoubleClickCore = allowEditOnDoubleClick.Checked;
            editOrderlayoutView.OptionsBehavior.AutoFocusCardOnScrolling = true;
            editOrderlayoutView.OptionsBehavior.AllowSwitchViewModes = false;
            this.BorderStyle = BorderStyle.None;
            this.layoutControl1.Root.GroupBordersVisible = false;
        }
        //<masterGrid>
        protected void employesLayoutView_CustomUnboundColumnData(object sender, CustomColumnDataEventArgs e) {
            if(e.Column == colFullName) {
                DataRow row = ((DataRowView)e.Row).Row;
                e.Value = String.Format("{0} {1}", row["FirstName"], row["LastName"]);
            }
        }
        //</masterGrid>
        protected virtual void InitData() {
            DataSet ds = NWindDataSet();
            BindingSource masterBindingSource = new BindingSource(ds, "Employees");
            masterGrid.DataSource = masterBindingSource;
            BindingSource detailBindingSource = new BindingSource(masterBindingSource, "EmployeesOrders");
            detailGrid.DataSource = detailBindingSource;
            //<masterGrid>
            /*
             ~Note: the following code is set at desing-time and shown here for educational purposes only.
             masterGrid.MainView = employesLayoutView;
             */
            //</masterGrid>
        }
        public enum MasterTablePosition { Left, Top, Right, Bottom };
        //<cbMasterTablePosition>
        protected void cbMasterTablePosition_SelectedIndexChanged(object sender, EventArgs e) {
            MasterTablePosition position = (MasterTablePosition)cbMasterTablePosition.EditValue;
            switch(position) {
                case MasterTablePosition.Left: SetMasterTableLeftPlacement(); break;
                case MasterTablePosition.Top: SetMasterTableTopPlacement(); break;
                case MasterTablePosition.Right: SetMasterTableRightPlacement(); break;
                case MasterTablePosition.Bottom: SetMasterTableBottomPlacement(); break;
            }
        }
        
        protected void SetMasterTableLeftPlacement() {
            LayoutItemDragController dc = 
                new LayoutItemDragController(masterTableItem, detailTableItem, InsertLocation.Before, LayoutType.Horizontal);
            DoDragItem(dc);
            SetMasterViewColumnLayout();
        }
        protected void SetMasterTableRightPlacement() {
            LayoutItemDragController dc = 
                new LayoutItemDragController(masterTableItem, detailTableItem, InsertLocation.After, LayoutType.Horizontal);
            DoDragItem(dc);
            SetMasterViewColumnLayout();
        }
        private void SetMasterTableTopPlacement() {
            LayoutItemDragController dc = 
                new LayoutItemDragController(masterTableItem, detailTableItem, InsertLocation.Before, LayoutType.Vertical);
            DoDragItem(dc);
            SetMasterViewRowLayout();
        }
        protected void SetMasterTableBottomPlacement() {
            LayoutItemDragController dc = 
                new LayoutItemDragController(masterTableItem, detailTableItem, InsertLocation.After, LayoutType.Vertical);
            DoDragItem(dc);
            SetMasterViewRowLayout();
        }
        protected void DoDragItem(LayoutItemDragController dc) {
            masterTableItem.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Default;
            masterTableItem.Move(dc);
        }
        protected void SetMasterViewColumnLayout() {
            SetMasterItemVerticalSize();
            editOrderlayoutView.BeginUpdate();
            employesLayoutView.OptionsBehavior.AllowSwitchViewModes = true;
            employesLayoutView.OptionsView.ViewMode = LayoutViewMode.Column;
            employesLayoutView.OptionsMultiRecordMode.StretchCardToViewWidth = true;
            employesLayoutView.OptionsBehavior.AllowSwitchViewModes = false;
            editOrderlayoutView.EndUpdate();
        }
        protected void SetMasterViewRowLayout() {
            SetMasterItemHorizontalSize();
            editOrderlayoutView.BeginUpdate();
            employesLayoutView.OptionsBehavior.AllowSwitchViewModes = true;
            employesLayoutView.OptionsMultiRecordMode.StretchCardToViewWidth = false;
            employesLayoutView.OptionsView.ViewMode = LayoutViewMode.Row;
            employesLayoutView.OptionsBehavior.AllowSwitchViewModes = false;
            employesLayoutView.TemplateCard.Update();
            editOrderlayoutView.EndUpdate();
        }
        //</cbMasterTablePosition>
        SizeF scaleFactor = new SizeF(1, 1);
        protected override void ScaleControl(SizeF factor, BoundsSpecified specified) {
            base.ScaleControl(factor, specified);
            scaleFactor = factor;
        }
        bool isVertical = false;
        int MasterItemWidth { get { return (int)(150 * scaleFactor.Width); } }
        int MasterItemHeight { get { return (int)(160 * scaleFactor.Height); } }
        protected void SetMasterItemVerticalSize() {
            isVertical = true;
            masterTableItem.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            masterTableItem.MinSize = new Size(MasterItemWidth, 0);
            masterTableItem.MaxSize = new Size(MasterItemWidth, 0);
            masterTableItem.Size = new Size(MasterItemWidth, 0);
        }
        protected void SetMasterItemHorizontalSize() {
            isVertical = false;
            masterTableItem.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            masterTableItem.MinSize = new Size(0, MasterItemHeight);
            masterTableItem.MaxSize = new Size(0, MasterItemHeight);
            masterTableItem.Size = new Size(0, MasterItemHeight);
        }
        protected void layoutControl1_SizeChanged(object sender, EventArgs e) {
            if(isVertical) SetMasterItemVerticalSize();
            else SetMasterItemHorizontalSize();
        }

        bool fExtendedEditMode = false;
        string strHideExtendedMode = Properties.Resources.Back;
        string strShowExtendedMode = Properties.Resources.EditOrder;
        protected void HideDetail(int rowHandle) {
            detailGrid.MainView.PostEditor();
            int datasourceRowIndex = editOrderlayoutView.GetDataSourceRowIndex(rowHandle);  
            //<detailGrid>
            detailGrid.MainView = viewOrderGridView;
            //</detailGrid>
            SynchronizeOrdersView(datasourceRowIndex);
            detailGrid.UseEmbeddedNavigator = false;
            detailShowHideBtn.Text = strShowExtendedMode;
            fExtendedEditMode = (detailGrid.MainView == editOrderlayoutView);
        }
        //<detailShowHideBtn>
        //<allowEditOnDoubleClick>
        //<detailGrid>
        protected void ShowDetail(int rowHandle) {
            int datasourceRowIndex = viewOrderGridView.GetDataSourceRowIndex(rowHandle);            
            detailGrid.MainView = editOrderlayoutView;
            SynchronizeOrdersDetailView(datasourceRowIndex);
            detailGrid.UseEmbeddedNavigator = true;
            detailShowHideBtn.Text = strHideExtendedMode;
            fExtendedEditMode = (detailGrid.MainView == editOrderlayoutView);
        }
        //</detailGrid>
        
        protected void SynchronizeOrdersView(int dataSourceRowIndex) {
            int rowHandle = viewOrderGridView.GetRowHandle(dataSourceRowIndex);
            viewOrderGridView.FocusedRowHandle = rowHandle;
        }
        //<detailGrid>
        protected void SynchronizeOrdersDetailView(int dataSourceRowIndex) {
            int rowHandle = editOrderlayoutView.GetRowHandle(dataSourceRowIndex);
            editOrderlayoutView.VisibleRecordIndex = editOrderlayoutView.GetVisibleIndex(rowHandle);
            editOrderlayoutView.FocusedRowHandle = dataSourceRowIndex;
        }
        //</detailGrid>
        //</detailShowHideBtn>
        protected void viewOrderGridView_DoubleClick(object sender, EventArgs e) {
            MouseEventArgs ea = e as MouseEventArgs;
            if(ea==null || !allowEditOnDoubleClickCore) return;
            GridHitInfo hi = viewOrderGridView.CalcHitInfo(ea.Location);
            if(hi.InRow) ShowDetail(hi.RowHandle);
        }
        //</allowEditOnDoubleClick>
        protected void editOrderlayoutView_MouseDown(object sender, MouseEventArgs e) {
            if(e.Button == MouseButtons.Right) {
                LayoutViewHitInfo hi = editOrderlayoutView.CalcHitInfo(e.Location);
                if(hi.InCard) HideDetail(hi.RowHandle);
            }
        }
        //<detailShowHideBtn>
        protected void detailShowHideBtn_Click(object sender, EventArgs e) {
            if(fExtendedEditMode) HideDetail((detailGrid.MainView as ColumnView).FocusedRowHandle);
            else ShowDetail((detailGrid.MainView as ColumnView).FocusedRowHandle);
        }
        //</detailShowHideBtn>
        //<allowEditOnDoubleClick>
        protected void allowEditOnDoubleClick_CheckedChanged(object sender, EventArgs e) {
            allowEditOnDoubleClickCore = allowEditOnDoubleClick.Checked;
        }
        //</allowEditOnDoubleClick>
    }
}
