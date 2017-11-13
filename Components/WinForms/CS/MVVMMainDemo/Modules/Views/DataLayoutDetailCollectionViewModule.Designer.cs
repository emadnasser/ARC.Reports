﻿namespace DevExpress.MVVM.Demos.Views {
    partial class DataLayoutDetailCollectionViewModule {
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
            this.dataLayout = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.sourceCode = new DevExpress.DXperience.Demos.CodeDemo.RichEditUserControl();
            this.NameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.bindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.AmountSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.Transaction_DetailsUserControl = new DevExpress.XtraEditors.XtraUserControl();
            this.TransactionsGrid = new DevExpress.XtraGrid.GridControl();
            this.transactionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.transactionsGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bbiSave = new DevExpress.XtraBars.BarButtonItem();
            this.bbiReset = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForName = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForAmount = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForTransactionsGrid = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForSourceCode = new DevExpress.XtraLayout.LayoutControlItem();
            this.splitterItem1 = new DevExpress.XtraLayout.SplitterItem();
            this.mvvmContext = new DevExpress.Utils.MVVM.MVVMContext(this.components);
            this.bbiTransaction_DetailsNew = new DevExpress.XtraBars.BarButtonItem();
            this.bbiTransaction_DetailsEdit = new DevExpress.XtraBars.BarButtonItem();
            this.bbiTransaction_DetailsDelete = new DevExpress.XtraBars.BarButtonItem();
            this.bbiTransaction_DetailsRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.Transaction_DetailsBarManager = new DevExpress.XtraBars.BarManager(this.components);
            this.Transaction_DetailsBar = new DevExpress.XtraBars.Bar();
            this.Transactions_DetailsPopUpMenu = new DevExpress.XtraBars.PopupMenu(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayout)).BeginInit();
            this.dataLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AmountSpinEdit.Properties)).BeginInit();
            this.Transaction_DetailsUserControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TransactionsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForTransactionsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForSourceCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Transaction_DetailsBarManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Transactions_DetailsPopUpMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // dataLayout
            // 
            this.dataLayout.AllowCustomization = false;
            this.dataLayout.Controls.Add(this.sourceCode);
            this.dataLayout.Controls.Add(this.NameTextEdit);
            this.dataLayout.Controls.Add(this.AmountSpinEdit);
            this.dataLayout.Controls.Add(this.Transaction_DetailsUserControl);
            this.dataLayout.DataSource = this.bindingSource;
            this.dataLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayout.Location = new System.Drawing.Point(5, 116);
            this.dataLayout.Name = "dataLayout";
            this.dataLayout.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(902, 104, 919, 581);
            this.dataLayout.Root = this.Root;
            this.dataLayout.Size = new System.Drawing.Size(675, 317);
            this.dataLayout.TabIndex = 0;
            this.dataLayout.Text = "dataLayoutControl1";
            // 
            // sourceCode
            // 
            this.sourceCode.CurrentNestedType = null;
            this.sourceCode.Location = new System.Drawing.Point(12, 226);
            this.sourceCode.Margin = new System.Windows.Forms.Padding(0);
            this.sourceCode.Name = "sourceCode";
            this.sourceCode.RichText = "";
            this.sourceCode.Size = new System.Drawing.Size(651, 79);
            this.sourceCode.TabIndex = 6;
            // 
            // NameTextEdit
            // 
            this.NameTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSource, "Name", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.NameTextEdit.Location = new System.Drawing.Point(76, 12);
            this.NameTextEdit.Name = "NameTextEdit";
            this.NameTextEdit.Size = new System.Drawing.Size(587, 20);
            this.NameTextEdit.StyleController = this.dataLayout;
            this.NameTextEdit.TabIndex = 0;
            // 
            // bindingSource
            // 
            this.bindingSource.DataSource = typeof(DevExpress.MVVM.Demos.Model.Account);
            // 
            // AmountSpinEdit
            // 
            this.AmountSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSource, "Amount", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.AmountSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.AmountSpinEdit.Location = new System.Drawing.Point(76, 36);
            this.AmountSpinEdit.Name = "AmountSpinEdit";
            this.AmountSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.AmountSpinEdit.Size = new System.Drawing.Size(587, 20);
            this.AmountSpinEdit.StyleController = this.dataLayout;
            this.AmountSpinEdit.TabIndex = 2;
            // 
            // Transaction_DetailsUserControl
            // 
            this.Transaction_DetailsUserControl.Controls.Add(this.TransactionsGrid);
            this.Transaction_DetailsUserControl.Controls.Add(this.barDockControlLeft);
            this.Transaction_DetailsUserControl.Controls.Add(this.barDockControlRight);
            this.Transaction_DetailsUserControl.Controls.Add(this.barDockControlBottom);
            this.Transaction_DetailsUserControl.Controls.Add(this.barDockControlTop);
            this.Transaction_DetailsUserControl.Location = new System.Drawing.Point(76, 60);
            this.Transaction_DetailsUserControl.MinimumSize = new System.Drawing.Size(100, 100);
            this.Transaction_DetailsUserControl.Name = "Transaction_DetailsUserControl";
            this.Transaction_DetailsUserControl.Size = new System.Drawing.Size(587, 157);
            this.Transaction_DetailsUserControl.TabIndex = 17;
            // 
            // TransactionsGrid
            // 
            this.TransactionsGrid.DataSource = this.transactionBindingSource;
            this.TransactionsGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TransactionsGrid.Location = new System.Drawing.Point(0, 24);
            this.TransactionsGrid.MainView = this.transactionsGridView;
            this.TransactionsGrid.MenuManager = this.ribbonControl1;
            this.TransactionsGrid.Name = "TransactionsGrid";
            this.TransactionsGrid.Size = new System.Drawing.Size(587, 133);
            this.TransactionsGrid.TabIndex = 6;
            this.TransactionsGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.transactionsGridView});
            // 
            // transactionBindingSource
            // 
            this.transactionBindingSource.DataSource = typeof(DevExpress.MVVM.Demos.Model.Transaction);
            // 
            // transactionsGridView
            // 
            this.transactionsGridView.GridControl = this.TransactionsGrid;
            this.transactionsGridView.Name = "transactionsGridView";
            this.transactionsGridView.OptionsBehavior.Editable = false;
            this.transactionsGridView.OptionsView.ShowGroupPanel = false;
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.bbiSave,
            this.bbiReset
            });
            this.ribbonControl1.Location = new System.Drawing.Point(5, 0);
            this.ribbonControl1.MaxItemId = 8;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013;
            this.ribbonControl1.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.Size = new System.Drawing.Size(675, 116);
            this.ribbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // bbiSave
            // 
            this.bbiSave.Caption = "Save";
            this.bbiSave.Enabled = false;
            this.bbiSave.Id = 2;
            this.bbiSave.ImageUri.Uri = "Save";
            this.bbiSave.Name = "bbiSave";
            // 
            // bbiReset
            // 
            this.bbiReset.Caption = "Reset Changes";
            this.bbiReset.Enabled = false;
            this.bbiReset.Id = 5;
            this.bbiReset.ImageUri.Uri = "Reset";
            this.bbiReset.Name = "bbiReset";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup3
            });
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "ACCOUNT";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.AllowTextClipping = false;
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiSave);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.ShowCaptionButton = false;
            this.ribbonPageGroup1.Text = "Save";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.AllowTextClipping = false;
            this.ribbonPageGroup3.ItemLinks.Add(this.bbiReset);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.ShowCaptionButton = false;
            this.ribbonPageGroup3.Text = "Edit";
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 133);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(587, 24);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 133);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 157);
            this.barDockControlBottom.Size = new System.Drawing.Size(587, 0);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(587, 24);
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup1,
            this.ItemForSourceCode,
            this.splitterItem1});
            this.Root.Location = new System.Drawing.Point(0, 0);
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(675, 317);
            this.Root.TextVisible = false;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForName,
            this.ItemForAmount,
            this.ItemForTransactionsGrid});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "autoGeneratedGroup0";
            this.layoutControlGroup1.Size = new System.Drawing.Size(655, 209);
            // 
            // ItemForName
            // 
            this.ItemForName.Control = this.NameTextEdit;
            this.ItemForName.Location = new System.Drawing.Point(0, 0);
            this.ItemForName.Name = "ItemForName";
            this.ItemForName.Size = new System.Drawing.Size(655, 24);
            this.ItemForName.Text = "Name";
            this.ItemForName.TextSize = new System.Drawing.Size(61, 13);
            // 
            // ItemForAmount
            // 
            this.ItemForAmount.Control = this.AmountSpinEdit;
            this.ItemForAmount.Location = new System.Drawing.Point(0, 24);
            this.ItemForAmount.Name = "ItemForAmount";
            this.ItemForAmount.Size = new System.Drawing.Size(655, 24);
            this.ItemForAmount.Text = "Amount";
            this.ItemForAmount.TextSize = new System.Drawing.Size(61, 13);
            // 
            // ItemForTransactionsGrid
            // 
            this.ItemForTransactionsGrid.Control = this.Transaction_DetailsUserControl;
            this.ItemForTransactionsGrid.Location = new System.Drawing.Point(0, 48);
            this.ItemForTransactionsGrid.Name = "layoutControlItem1";
            this.ItemForTransactionsGrid.Size = new System.Drawing.Size(655, 161);
            this.ItemForTransactionsGrid.StartNewLine = true;
            this.ItemForTransactionsGrid.Text = "Transactions";
            this.ItemForTransactionsGrid.TextSize = new System.Drawing.Size(61, 13);
            // 
            // ItemForSourceCode
            // 
            this.ItemForSourceCode.Control = this.sourceCode;
            this.ItemForSourceCode.Location = new System.Drawing.Point(0, 214);
            this.ItemForSourceCode.Name = "ItemForSourceCode";
            this.ItemForSourceCode.Size = new System.Drawing.Size(655, 83);
            this.ItemForSourceCode.Text = "SourceCode";
            this.ItemForSourceCode.TextSize = new System.Drawing.Size(0, 0);
            this.ItemForSourceCode.TextVisible = false;
            // 
            // splitterItem1
            // 
            this.splitterItem1.AllowHotTrack = true;
            this.splitterItem1.Location = new System.Drawing.Point(0, 209);
            this.splitterItem1.Name = "splitterItem2";
            this.splitterItem1.Size = new System.Drawing.Size(655, 5);
            // 
            // mvvmContext
            // 
            this.mvvmContext.BindingExpressions.AddRange(new DevExpress.Utils.MVVM.BindingExpression[] {
            DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(DevExpress.MVVM.Demos.ViewModels.AccountViewModel), "Save", this.bbiSave),
            DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(DevExpress.MVVM.Demos.ViewModels.AccountViewModel), "Reset", this.bbiReset)});
            this.mvvmContext.ContainerControl = this;
            this.mvvmContext.RegistrationExpressions.AddRange(new DevExpress.Utils.MVVM.RegistrationExpression[] {
            DevExpress.Utils.MVVM.RegistrationExpression.RegisterLayoutSerializationService(null, false, DevExpress.Utils.DefaultBoolean.True, this.dataLayout)});
            this.mvvmContext.ViewModelType = typeof(DevExpress.MVVM.Demos.ViewModels.AccountViewModel);
            // 
            // bbiTransaction_DetailsNew
            // 
            this.bbiTransaction_DetailsNew.Caption = "New";
            this.bbiTransaction_DetailsNew.Id = 0;
            this.bbiTransaction_DetailsNew.ImageUri.Uri = "New";
            this.bbiTransaction_DetailsNew.Name = "bbiTransaction_DetailsNew";
            this.bbiTransaction_DetailsNew.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // bbiTransaction_DetailsEdit
            // 
            this.bbiTransaction_DetailsEdit.Caption = "Edit";
            this.bbiTransaction_DetailsEdit.Id = 1;
            this.bbiTransaction_DetailsEdit.ImageUri.Uri = "Edit";
            this.bbiTransaction_DetailsEdit.Name = "bbiTransaction_DetailsEdit";
            this.bbiTransaction_DetailsEdit.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // bbiTransaction_DetailsDelete
            // 
            this.bbiTransaction_DetailsDelete.Caption = "Delete";
            this.bbiTransaction_DetailsDelete.Id = 2;
            this.bbiTransaction_DetailsDelete.ImageUri.Uri = "Delete";
            this.bbiTransaction_DetailsDelete.Name = "bbiTransaction_DetailsDelete";
            this.bbiTransaction_DetailsDelete.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // bbiTransaction_DetailsRefresh
            // 
            this.bbiTransaction_DetailsRefresh.Caption = "Refresh";
            this.bbiTransaction_DetailsRefresh.Id = 3;
            this.bbiTransaction_DetailsRefresh.ImageUri.Uri = "Refresh";
            this.bbiTransaction_DetailsRefresh.Name = "bbiTransaction_DetailsRefresh";
            this.bbiTransaction_DetailsRefresh.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // Transaction_DetailsBarManager
            // 
            this.Transaction_DetailsBarManager.AllowCustomization = false;
            this.Transaction_DetailsBarManager.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.Transaction_DetailsBar});
            this.Transaction_DetailsBarManager.DockControls.Add(this.barDockControlTop);
            this.Transaction_DetailsBarManager.DockControls.Add(this.barDockControlBottom);
            this.Transaction_DetailsBarManager.DockControls.Add(this.barDockControlLeft);
            this.Transaction_DetailsBarManager.DockControls.Add(this.barDockControlRight);
            this.Transaction_DetailsBarManager.Form = this.Transaction_DetailsUserControl;
            this.Transaction_DetailsBarManager.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.bbiTransaction_DetailsNew,
            this.bbiTransaction_DetailsEdit,
            this.bbiTransaction_DetailsDelete,
            this.bbiTransaction_DetailsRefresh});
            this.Transaction_DetailsBarManager.MainMenu = this.Transaction_DetailsBar;
            this.Transaction_DetailsBarManager.MaxItemId = 4;
            // 
            // Transaction_DetailsBar
            // 
            this.Transaction_DetailsBar.BarName = "Transaction_Details";
            this.Transaction_DetailsBar.DockCol = 0;
            this.Transaction_DetailsBar.DockRow = 0;
            this.Transaction_DetailsBar.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.Transaction_DetailsBar.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiTransaction_DetailsNew),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiTransaction_DetailsEdit),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiTransaction_DetailsDelete),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiTransaction_DetailsRefresh)});
            this.Transaction_DetailsBar.OptionsBar.AllowQuickCustomization = false;
            this.Transaction_DetailsBar.OptionsBar.DrawDragBorder = false;
            this.Transaction_DetailsBar.Text = "Transaction_Details";
            // 
            // Transactions_DetailsPopUpMenu
            // 
            this.Transactions_DetailsPopUpMenu.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiTransaction_DetailsNew),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiTransaction_DetailsEdit),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiTransaction_DetailsDelete),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiTransaction_DetailsRefresh)});
            this.Transactions_DetailsPopUpMenu.Manager = this.Transaction_DetailsBarManager;
            this.Transactions_DetailsPopUpMenu.Name = "Transactions_DetailsPopUpMenu";
            // 
            // DataLayoutNestedCollectionViewModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.Controls.Add(this.dataLayout);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "DataLayoutNestedCollectionViewModule";
            this.Size = new System.Drawing.Size(680, 438);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayout)).EndInit();
            this.dataLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AmountSpinEdit.Properties)).EndInit();
            this.Transaction_DetailsUserControl.ResumeLayout(false);
            this.Transaction_DetailsUserControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TransactionsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForTransactionsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForSourceCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Transaction_DetailsBarManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Transactions_DetailsPopUpMenu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }        
        #endregion

        private DevExpress.XtraDataLayout.DataLayoutControl dataLayout;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.Utils.MVVM.MVVMContext mvvmContext;
        private System.Windows.Forms.BindingSource bindingSource;
        private DevExpress.XtraEditors.TextEdit NameTextEdit;
        private DevExpress.XtraEditors.SpinEdit AmountSpinEdit;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem ItemForName;
        private DevExpress.XtraLayout.LayoutControlItem ItemForAmount;
        private DevExpress.XtraLayout.LayoutControlItem ItemForSourceCode;
        private XtraBars.BarButtonItem bbiSave;
        private XtraBars.BarButtonItem bbiReset;
        private XtraBars.Ribbon.RibbonControl ribbonControl1;
        private XtraBars.Ribbon.RibbonPage ribbonPage1;
        private XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private System.Windows.Forms.BindingSource transactionBindingSource;
        private XtraBars.BarButtonItem bbiTransaction_DetailsNew;
        private XtraBars.BarButtonItem bbiTransaction_DetailsEdit;
        private XtraBars.BarButtonItem bbiTransaction_DetailsDelete;
        private XtraBars.BarButtonItem bbiTransaction_DetailsRefresh;
        private XtraGrid.GridControl TransactionsGrid;
        private XtraGrid.Views.Grid.GridView transactionsGridView;
        private XtraLayout.LayoutControlItem ItemForTransactionsGrid;
        private XtraEditors.XtraUserControl Transaction_DetailsUserControl;
        private XtraBars.BarDockControl barDockControlLeft;
        private XtraBars.BarDockControl barDockControlRight;
        private XtraBars.BarDockControl barDockControlBottom;
        private XtraBars.BarDockControl barDockControlTop;
        private XtraBars.BarManager Transaction_DetailsBarManager;
        private XtraBars.Bar Transaction_DetailsBar;
        private XtraBars.PopupMenu Transactions_DetailsPopUpMenu;
        private DXperience.Demos.CodeDemo.RichEditUserControl sourceCode;
        private XtraLayout.SplitterItem splitterItem1;
    }
}
