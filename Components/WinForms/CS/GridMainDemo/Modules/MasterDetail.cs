using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Data.OleDb;
using DevExpress.XtraGrid;
using DevExpress.Utils;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraEditors;
using DevExpress.ActiveDemos;
using DevExpress.XtraEditors.Controls;

namespace DevExpress.XtraGrid.Demos {
    /// <summary>
    /// Summary description for MasterDetail.
    /// </summary>
    public partial class MasterDetail : TutorialControl {
        public MasterDetail() {
            //
            // Required for Windows Form Designer support
            //
            CreateWaitDialog();
            InitializeComponent();
            TutorialInfo.WhatsThisCodeFile = "CS\\GridMainDemo\\Modules\\MasterDetail.cs";
            TutorialInfo.WhatsThisXMLFile = "DevExpress.XtraGrid.Demos.CodeInfo.MasterDetail.xml";
            gridControl1.ForceInitialize();

            InitNWindData();
            InitEditing();
            InitMasterDetailDemo();

            //
            // TODO: Add any constructor code after InitializeComponent call
            //
        }

        public override DevExpress.XtraGrid.Views.Base.BaseView ExportView { get { return advBandedGridView1; } }
        public override bool HasActiveDemo { get { return true; } }
        protected override ActiveDemo CreateActiveDemo() {
            return new ActiveGridDemo(gridControl1);
        }
        protected override void RunGridActiveDemo(ActiveGridDemo activeDemo) {
            icbDetailMode.EditValue = DetailMode.Classic;
            this.advBandedGridView1.CollapseAllDetails();
            imageComboBoxEdit1.SelectedIndex = 1;
            ceTabs.Checked = true;
            ceMain.Checked = true;

            activeDemo.ClickMasterRecordIcon(this.advBandedGridView1, 1);
            advBandedGridView1.TopRowIndex = 0;
            activeDemo.ClickMasterRecordIcon(this.advBandedGridView1, 0);
            GridView detailView = this.advBandedGridView1.GetVisibleDetailView(0) as GridView;
            activeDemo.ColumnBestFit(this.colCategoryID, detailView, Properties.Resources.ActiveGrid_BestFit);
            activeDemo.ColumnResize(this.colCategoryID, detailView, 100);
            activeDemo.ShowMessage(Properties.Resources.ActiveGrid_SynhronizedViews);
            activeDemo.ViewZoom(detailView, Properties.Resources.ActiveGrid_ViewZoom);
            activeDemo.ClickMasterRecordIcon(detailView, 1);
            activeDemo.ClickMasterRecordIcon(detailView, 0);
            if(activeDemo.Actions.Canceled) return;
            if(detailView == null) return;
            GridView subDetailView = detailView.GetVisibleDetailView(0) as GridView;
            ActiveActions.Delay(500);
            activeDemo.ViewZoom(subDetailView, Properties.Resources.ActiveGrid_ViewZoomSubDetail);
            if(activeDemo.Actions.Canceled) return;
            ActiveActions.Delay(500);
            activeDemo.ExpandCollapseRow(subDetailView, 1);
            activeDemo.MoveMouseFromPoint(200, 100);
            activeDemo.ExpandCollapseRow(subDetailView, 0);
            activeDemo.MoveMouseFromPoint(100, 200);
            activeDemo.ViewZoom(subDetailView, Properties.Resources.ActiveGrid_ViewUnzoom);
            activeDemo.MoveMouseFromPoint(200, 200);
            activeDemo.ViewZoom(detailView);
            if(activeDemo.Actions.Canceled) return;
            subDetailView.OptionsView.ShowGroupPanel = true;
            Rectangle r = activeDemo.GetGroupPanelRectangle(subDetailView);
            activeDemo.Actions.MoveMousePointTo(gridControl1, new Point(r.X + 50, r.Top + r.Height / 2));
            activeDemo.ShowMessage(Properties.Resources.ActiveGrid_JoinedGroupPanel);
            r = activeDemo.GetGroupPanelRectangle(this.advBandedGridView1);
            activeDemo.Actions.MoveMousePointTo(gridControl1, new Point(r.X + 50, r.Top + r.Height / 2));
            activeDemo.ShowMessage(Properties.Resources.ActiveGrid_JoinedGroupPanel2);
            if(activeDemo.Actions.Canceled) return;
            subDetailView.OptionsView.ShowGroupPanel = false;
            activeDemo.ClickControlNavigatorButton(NavigatorButtonType.Prev);
            activeDemo.ClickControlNavigatorButton(NavigatorButtonType.Prev);
            activeDemo.ShowMessage(Properties.Resources.ActiveGrid_EmbeddedNavigator);
            activeDemo.ClickControlNavigatorButton(NavigatorButtonType.Next);
            activeDemo.ClickControlNavigatorButton(NavigatorButtonType.Next);
            activeDemo.ClickControlNavigatorButton(NavigatorButtonType.Next);
        }
        #region Init
        private GridControl CurrentGrid { get { return gridControl1; } }
        private GridView MainView { get { return advBandedGridView1; } }
        private GridView ProductView { get { return gridView1; } }

        protected override void InitMDBData(string connectionString) {
            OleDbDataAdapter oleDBAdapter1 = new OleDbDataAdapter("SELECT * FROM Suppliers", connectionString);
            OleDbDataAdapter oleDBAdapter2 = new OleDbDataAdapter("SELECT * FROM Products", connectionString);
            OleDbDataAdapter oleDBAdapter3 = new OleDbDataAdapter("SELECT * FROM [Order Details]", connectionString);
            OleDbDataAdapter oleDBAdapter4 = new OleDbDataAdapter("SELECT * FROM CategoryProducts", connectionString);

            SetWaitDialogCaption(Properties.Resources.LoadingSuppliers);
            oleDBAdapter1.Fill(dsNWindSupplier1.Suppliers);

            SetWaitDialogCaption(Properties.Resources.LoadingProducts);
            oleDBAdapter2.Fill(dsNWindSupplier1.Products);

            SetWaitDialogCaption(Properties.Resources.LoadingOrderDetails);
            oleDBAdapter3.Fill(dsNWindSupplier1.Order_Details);

            SetWaitDialogCaption(Properties.Resources.LoadingCategoryProducts);
            oleDBAdapter4.Fill(dsNWindSupplier1.CategoryProducts);
            DemoHelper.AddCategoryImagesToEdit(connectionString, repositoryItemImageComboBox1);
        }
        private void InitMasterDetailDemo() {
            MainView.BeginUpdate();
            MainView.FocusedRowHandle = 0;
            MainView.SetMasterRowExpanded(MainView.FocusedRowHandle, true);
            GridView gv = MainView.GetVisibleDetailView(MainView.FocusedRowHandle) as GridView;
            if(gv != null) gv.SetMasterRowExpanded(0, true);
            MainView.SetMasterRowExpandedEx(1, 1, true);
            seVertIndent.Value = 4;
            MainView.EndUpdate();
        }
        private void InitEditing() {
            InitCheckButtons();
            SetZoom(imageComboBoxEdit1.SelectedIndex);
        }
        private void InitCheckButtons() {
            icbDetailMode.Properties.Items.Add(DetailMode.Classic.ToString(), DetailMode.Classic, -1);
            icbDetailMode.Properties.Items.Add(DetailMode.Embedded.ToString(), DetailMode.Embedded, -1);
            icbDetailMode.EditValue = MainView.OptionsDetail.DetailMode;
            ceShowEmbeddedDetailIndent.Checked = MainView.OptionsDetail.ShowEmbeddedDetailIndent != Utils.DefaultBoolean.False;
            ceTabs.Checked = MainView.OptionsDetail.ShowDetailTabs;
            ceToolTips.Checked = MainView.OptionsDetail.EnableDetailToolTip;
            ceMain.Checked = MainView.OptionsDetail.EnableMasterViewMode;
        }
        #endregion
        #region Editing
        //<imageComboBoxEdit1>
        private void SetZoom(bool allow, bool auto) {
            MainView.OptionsDetail.AllowZoomDetail = allow;
            MainView.OptionsDetail.AutoZoomDetail = auto;
            ProductView.OptionsDetail.AllowZoomDetail = allow;
            ProductView.OptionsDetail.AutoZoomDetail = auto;
        }

        void SetZoom(int index) {
            switch(index) {
                case 0: //"Auto Zoom"
                    SetZoom(true, true);
                    break;
                case 1: //"Manual Zoom"
                    SetZoom(true, false);
                    break;
                case 2: //"No Zoom"
                    SetZoom(false, false);
                    break;
            }
            MainView.CollapseAllDetails();
        }

        private void imageComboBoxEdit1_SelectedIndexChanged(object sender, System.EventArgs e) {
            SetZoom(imageComboBoxEdit1.SelectedIndex);
        }
        //</imageComboBoxEdit1>
        //<ceTabs>
        private void ceTabs_CheckedChanged(object sender, System.EventArgs e) {
            CheckEdit ce = sender as CheckEdit;
            MainView.OptionsDetail.ShowDetailTabs = ce.Checked;
            MainView.CollapseAllDetails();
            ProductView.BorderStyle = MainView.OptionsDetail.ShowDetailTabs ? BorderStyles.NoBorder : BorderStyles.Default;
        }
        //</ceTabs>
        //<ceToolTips>
        private void ceToolTips_CheckedChanged(object sender, System.EventArgs e) {
            CheckEdit ce = sender as CheckEdit;
            MainView.OptionsDetail.EnableDetailToolTip = ce.Checked;
        }
        //</ceToolTips>
        //<ceMain>
        private void ceMain_CheckedChanged(object sender, System.EventArgs e) {
            CheckEdit ce = sender as CheckEdit;
            MainView.OptionsDetail.EnableMasterViewMode = ce.Checked;
            MainView.OptionsView.ShowChildrenInGroupPanel = ce.Checked;
            //<skip>
            UpdateEnabledOptions();
            InitMasterDetailDemo();
            //</skip>
        }
        //</ceMain>
        void UpdateEnabledOptions() {
            icbDetailMode.Enabled = imageComboBoxEdit1.Enabled = ceTabs.Enabled = ceToolTips.Enabled = MainView.OptionsDetail.EnableMasterViewMode;
            ceShowEmbeddedDetailIndent.Enabled = MainView.OptionsDetail.DetailMode == DetailMode.Embedded && MainView.OptionsDetail.EnableMasterViewMode;
            seVertIndent.Enabled = ceMain.Checked;
            lciDetailIndent.Enabled = lciZooming.Enabled = MainView.OptionsDetail.DetailMode != DetailMode.Embedded;
        }
        //<seVertIndent>
        private void seVertIndent_EditValueChanged(object sender, EventArgs e) {
            foreach(DevExpress.XtraGrid.Views.Base.BaseView view in gridControl1.Views) {
                GridView gView = view as GridView;
                if(gView != null)
                    gView.DetailVerticalIndent = (int)seVertIndent.Value;
            }
        }
        //</seVertIndent>
        private void icbDetailMode_SelectedIndexChanged(object sender, EventArgs e) {
            //<icbDetailMode>
            MainView.OptionsDetail.DetailMode = (DetailMode)icbDetailMode.EditValue;
            //</icbDetailMode>
            UpdateEnabledOptions();
            InitMasterDetailDemo();
            MainView.TopRowIndex = 0;
        }

        //<ceShowEmbeddedDetailIndent>
        private void ceShowEmbeddedDetailIndent_CheckedChanged(object sender, EventArgs e) {
            MainView.OptionsDetail.ShowEmbeddedDetailIndent = ceShowEmbeddedDetailIndent.Checked ? DefaultBoolean.True : DefaultBoolean.False;
        }
        //</ceShowEmbeddedDetailIndent>
        #endregion
        #region GenerateReport

        public override bool AllowGenerateReport { get { return false; } }

        #endregion 
    }
}
