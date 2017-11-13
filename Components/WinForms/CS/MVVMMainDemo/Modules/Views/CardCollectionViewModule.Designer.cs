﻿namespace DevExpress.MVVM.Demos.Views {
    partial class CardCollectionViewModule {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bbiNew = new DevExpress.XtraBars.BarButtonItem();
            this.bbiEdit = new DevExpress.XtraBars.BarButtonItem();
            this.bbiDelete = new DevExpress.XtraBars.BarButtonItem();
            this.bbiRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.gridControl = new DevExpress.XtraGrid.GridControl();
            this.layoutView = new DevExpress.XtraGrid.Views.Layout.LayoutView();
            this.layoutViewCard1 = new DevExpress.XtraGrid.Views.Layout.LayoutViewCard();
            this.mvvmContext = new DevExpress.Utils.MVVM.MVVMContext(this.components);
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.sourceCode = new DevExpress.DXperience.Demos.CodeDemo.RichEditUserControl();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.viewItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.sourceCodeItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.splitter = new DevExpress.XtraLayout.SplitterItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewCard1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sourceCodeItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitter)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.bbiNew,
            this.bbiEdit,
            this.bbiDelete,
            this.bbiRefresh});
            this.ribbonControl1.Location = new System.Drawing.Point(5, 0);
            this.ribbonControl1.MaxItemId = 8;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013;
            this.ribbonControl1.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.Size = new System.Drawing.Size(779, 116);
            this.ribbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // bbiNew
            // 
            this.bbiNew.Caption = "New";
            this.bbiNew.Id = 1;
            this.bbiNew.ImageUri.Uri = "New";
            this.bbiNew.Name = "bbiNew";
            // 
            // bbiEdit
            // 
            this.bbiEdit.Caption = "Edit";
            this.bbiEdit.Enabled = false;
            this.bbiEdit.Id = 2;
            this.bbiEdit.ImageUri.Uri = "Edit";
            this.bbiEdit.Name = "bbiEdit";
            // 
            // bbiDelete
            // 
            this.bbiDelete.Caption = "Delete";
            this.bbiDelete.Enabled = false;
            this.bbiDelete.Id = 3;
            this.bbiDelete.ImageUri.Uri = "Delete";
            this.bbiDelete.Name = "bbiDelete";
            // 
            // bbiRefresh
            // 
            this.bbiRefresh.Caption = "Refresh";
            this.bbiRefresh.Id = 4;
            this.bbiRefresh.ImageUri.Uri = "Refresh";
            this.bbiRefresh.Name = "bbiRefresh";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "ACCOUNTS";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.AllowTextClipping = false;
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiNew);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiEdit);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiDelete);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiRefresh);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.ShowCaptionButton = false;
            this.ribbonPageGroup1.Text = "Actions";
            // 
            // gridControl
            // 
            this.gridControl.Location = new System.Drawing.Point(2, 2);
            this.gridControl.MainView = this.layoutView;
            this.gridControl.MenuManager = this.ribbonControl1;
            this.gridControl.Name = "gridControl";
            this.gridControl.Size = new System.Drawing.Size(775, 114);
            this.gridControl.TabIndex = 3;
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.layoutView});
            // 
            // layoutView
            // 
            this.layoutView.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.layoutView.GridControl = this.gridControl;
            this.layoutView.Name = "layoutView";
            this.layoutView.OptionsBehavior.AllowExpandCollapse = false;
            this.layoutView.OptionsBehavior.Editable = false;
            this.layoutView.OptionsBehavior.ReadOnly = true;
            this.layoutView.OptionsView.AllowHotTrackFields = false;
            this.layoutView.OptionsView.ShowHeaderPanel = false;
            this.layoutView.OptionsView.ViewMode = DevExpress.XtraGrid.Views.Layout.LayoutViewMode.Row;
            this.layoutView.TemplateCard = this.layoutViewCard1;
            // 
            // layoutViewCard1
            // 
            this.layoutViewCard1.HeaderButtonsLocation = DevExpress.Utils.GroupElementLocation.AfterText;
            this.layoutViewCard1.Name = "layoutViewCard1";
            // 
            // mvvmContext
            // 
            this.mvvmContext.BindingExpressions.AddRange(new DevExpress.Utils.MVVM.BindingExpression[] {
            DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(DevExpress.MVVM.Demos.ViewModels.AccountCollectionViewModel), "New", this.bbiNew),
            DevExpress.Utils.MVVM.BindingExpression.CreateParameterizedCommandBinding(typeof(DevExpress.MVVM.Demos.ViewModels.AccountCollectionViewModel), "Edit", "SelectedEntity", this.bbiEdit),
            DevExpress.Utils.MVVM.BindingExpression.CreateParameterizedCommandBinding(typeof(DevExpress.MVVM.Demos.ViewModels.AccountCollectionViewModel), "Delete", "SelectedEntity", this.bbiDelete),
            DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(DevExpress.MVVM.Demos.ViewModels.AccountCollectionViewModel), "Refresh", this.bbiRefresh)});
            this.mvvmContext.ContainerControl = this;
            this.mvvmContext.ViewModelType = typeof(DevExpress.MVVM.Demos.ViewModels.AccountCollectionViewModel);
            // 
            // layoutControl1
            // 
            this.layoutControl1.AllowCustomization = false;
            this.layoutControl1.Controls.Add(this.sourceCode);
            this.layoutControl1.Controls.Add(this.gridControl);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(5, 116);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(779, 311);
            this.layoutControl1.TabIndex = 5;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // sourceCode
            // 
            this.sourceCode.CurrentNestedType = null;
            this.sourceCode.Location = new System.Drawing.Point(0, 123);
            this.sourceCode.Margin = new System.Windows.Forms.Padding(0);
            this.sourceCode.Name = "sourceCode";
            this.sourceCode.RichText = "";
            this.sourceCode.Size = new System.Drawing.Size(779, 188);
            this.sourceCode.TabIndex = 5;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.False;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.viewItem,
            this.sourceCodeItem,
            this.splitter});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(779, 311);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // viewItem
            // 
            this.viewItem.Control = this.gridControl;
            this.viewItem.Location = new System.Drawing.Point(0, 0);
            this.viewItem.Name = "viewItem";
            this.viewItem.Size = new System.Drawing.Size(779, 118);
            this.viewItem.TextSize = new System.Drawing.Size(0, 0);
            this.viewItem.TextVisible = false;
            // 
            // sourceCodeItem
            // 
            this.sourceCodeItem.Control = this.sourceCode;
            this.sourceCodeItem.Location = new System.Drawing.Point(0, 123);
            this.sourceCodeItem.Name = "sourceCodeItem";
            this.sourceCodeItem.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.sourceCodeItem.Size = new System.Drawing.Size(779, 188);
            this.sourceCodeItem.TextSize = new System.Drawing.Size(0, 0);
            this.sourceCodeItem.TextVisible = false;
            // 
            // splitter
            // 
            this.splitter.AllowHotTrack = true;
            this.splitter.Location = new System.Drawing.Point(0, 118);
            this.splitter.Name = "splitter";
            this.splitter.Size = new System.Drawing.Size(779, 5);
            // 
            // CardCollectionViewModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "CardCollectionViewModule";
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewCard1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sourceCodeItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private XtraBars.Ribbon.RibbonControl ribbonControl1;
        private XtraBars.BarButtonItem bbiNew;
        private XtraBars.BarButtonItem bbiEdit;
        private XtraBars.BarButtonItem bbiDelete;
        private XtraBars.BarButtonItem bbiRefresh;
        private XtraBars.Ribbon.RibbonPage ribbonPage1;
        private XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private XtraGrid.GridControl gridControl;
        private Utils.MVVM.MVVMContext mvvmContext;
        private XtraGrid.Views.Layout.LayoutView layoutView;
        private XtraGrid.Views.Layout.LayoutViewCard layoutViewCard1;
        private XtraLayout.LayoutControl layoutControl1;
        private XtraLayout.LayoutControlGroup layoutControlGroup1;
        private XtraLayout.LayoutControlItem viewItem;
        private DXperience.Demos.CodeDemo.RichEditUserControl sourceCode;
        private XtraLayout.LayoutControlItem sourceCodeItem;
        private XtraLayout.SplitterItem splitter;
    }
}
