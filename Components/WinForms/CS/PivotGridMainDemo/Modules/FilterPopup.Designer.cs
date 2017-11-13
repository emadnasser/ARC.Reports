namespace DevExpress.XtraPivotGrid.Demos.Modules {
    partial class FilterPopup {
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
            DevExpress.XtraPivotGrid.PivotGridStyleFormatCondition pivotGridStyleFormatCondition1 = new DevExpress.XtraPivotGrid.PivotGridStyleFormatCondition();
            DevExpress.XtraPivotGrid.PivotGridGroup pivotGridGroup1 = new DevExpress.XtraPivotGrid.PivotGridGroup();
            DevExpress.XtraPivotGrid.PivotGridGroup pivotGridGroup2 = new DevExpress.XtraPivotGrid.PivotGridGroup();
            this.fieldGroupCategoryName = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldGroupProductName = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldGroupYear = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldGroupQuarter = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldGroupMonth = new DevExpress.XtraPivotGrid.PivotGridField();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.chkShowToolbar = new DevExpress.XtraEditors.CheckEdit();
            this.chkAllowTree = new DevExpress.XtraEditors.CheckEdit();
            this.chkAllowContextMenu = new DevExpress.XtraEditors.CheckEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.tcFilter = new DevExpress.XtraTab.XtraTabControl();
            this.tabPageFieldFilter = new DevExpress.XtraTab.XtraTabPage();
            this.pivotFilter = new DevExpress.XtraPivotGrid.PivotGridControl();
            this.fieldExtendedPrice = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldProductName = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldYear = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldCategoryName = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldQuantity = new DevExpress.XtraPivotGrid.PivotGridField();
            this.tabPageGroupFilter = new DevExpress.XtraTab.XtraTabPage();
            this.pivotGroupFilter = new DevExpress.XtraPivotGrid.PivotGridControl();
            this.fieldGroupOrderAmount = new DevExpress.XtraPivotGrid.PivotGridField();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.chkInvertFilter = new DevExpress.XtraEditors.CheckEdit();
            this.chkRadioMode = new DevExpress.XtraEditors.CheckEdit();
            this.chkShowOnlyAvailableItems = new DevExpress.XtraEditors.CheckEdit();
            this.chkMultiSelection = new DevExpress.XtraEditors.CheckEdit();
            this.chkIncrementalSearch = new DevExpress.XtraEditors.CheckEdit();
            this.chkShowNewValues = new DevExpress.XtraEditors.CheckEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkShowToolbar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkAllowTree.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkAllowContextMenu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tcFilter)).BeginInit();
            this.tcFilter.SuspendLayout();
            this.tabPageFieldFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pivotFilter)).BeginInit();
            this.tabPageGroupFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pivotGroupFilter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkInvertFilter.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkRadioMode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkShowOnlyAvailableItems.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkMultiSelection.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkIncrementalSearch.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkShowNewValues.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // fieldGroupCategoryName
            // 
            this.fieldGroupCategoryName.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldGroupCategoryName.AreaIndex = 0;
            this.fieldGroupCategoryName.Caption = "Category Name";
            this.fieldGroupCategoryName.FieldName = "CategoryName";
            this.fieldGroupCategoryName.Name = "fieldGroupCategoryName";
            this.fieldGroupCategoryName.Width = 150;
            // 
            // fieldGroupProductName
            // 
            this.fieldGroupProductName.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldGroupProductName.AreaIndex = 1;
            this.fieldGroupProductName.Caption = "Product Name";
            this.fieldGroupProductName.FieldName = "ProductName";
            this.fieldGroupProductName.Name = "fieldGroupProductName";
            this.fieldGroupProductName.Width = 170;
            // 
            // fieldGroupYear
            // 
            this.fieldGroupYear.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.fieldGroupYear.AreaIndex = 0;
            this.fieldGroupYear.Caption = "Year";
            this.fieldGroupYear.FieldName = "OrderDate";
            this.fieldGroupYear.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateYear;
            this.fieldGroupYear.Name = "fieldGroupYear";
            this.fieldGroupYear.UnboundFieldName = "fieldGroupYear";
            // 
            // fieldGroupQuarter
            // 
            this.fieldGroupQuarter.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.fieldGroupQuarter.AreaIndex = 1;
            this.fieldGroupQuarter.Caption = "Quarter";
            this.fieldGroupQuarter.FieldName = "OrderDate";
            this.fieldGroupQuarter.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateQuarter;
            this.fieldGroupQuarter.Name = "fieldGroupQuarter";
            this.fieldGroupQuarter.UnboundFieldName = "fieldGroupQuarter";
            this.fieldGroupQuarter.ValueFormat.FormatString = "Quarter {0}";
            this.fieldGroupQuarter.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            // 
            // fieldGroupMonth
            // 
            this.fieldGroupMonth.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.fieldGroupMonth.AreaIndex = 2;
            this.fieldGroupMonth.Caption = "Month";
            this.fieldGroupMonth.FieldName = "OrderDate";
            this.fieldGroupMonth.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateMonth;
            this.fieldGroupMonth.Name = "fieldGroupMonth";
            this.fieldGroupMonth.UnboundFieldName = "fieldGroupMonth";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panelControl1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tcFilter, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panelControl2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(705, 345);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.chkShowToolbar);
            this.panelControl1.Controls.Add(this.chkAllowTree);
            this.panelControl1.Controls.Add(this.chkAllowContextMenu);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(705, 29);
            this.panelControl1.TabIndex = 3;
            // 
            // chkShowToolbar
            // 
            this.chkShowToolbar.EditValue = true;
            this.chkShowToolbar.Location = new System.Drawing.Point(113, 5);
            this.chkShowToolbar.Name = "chkShowToolbar";
            this.chkShowToolbar.Properties.Caption = "Show Toolbar";
            this.chkShowToolbar.Size = new System.Drawing.Size(91, 19);
            this.chkShowToolbar.TabIndex = 7;
            this.chkShowToolbar.CheckedChanged += new System.EventHandler(this.chkShowToolbar_CheckedChanged);
            // 
            // chkAllowTree
            // 
            this.chkAllowTree.EditValue = true;
            this.chkAllowTree.Location = new System.Drawing.Point(401, 5);
            this.chkAllowTree.Name = "chkAllowTree";
            this.chkAllowTree.Properties.Caption = "Allow Tree";
            this.chkAllowTree.Size = new System.Drawing.Size(85, 19);
            this.chkAllowTree.TabIndex = 2;
            this.chkAllowTree.CheckedChanged += new System.EventHandler(this.chkAllowTree_CheckedChanged);
            // 
            // chkAllowContextMenu
            // 
            this.chkAllowContextMenu.EditValue = true;
            this.chkAllowContextMenu.Location = new System.Drawing.Point(272, 5);
            this.chkAllowContextMenu.Name = "chkAllowContextMenu";
            this.chkAllowContextMenu.Properties.Caption = "Allow Context Menu";
            this.chkAllowContextMenu.Size = new System.Drawing.Size(123, 19);
            this.chkAllowContextMenu.TabIndex = 0;
            this.chkAllowContextMenu.CheckedChanged += new System.EventHandler(this.allowContextMenu_CheckedChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(6, 8);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(101, 13);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Filter Popup Options:";
            // 
            // tcFilter
            // 
            this.tcFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcFilter.Location = new System.Drawing.Point(3, 100);
            this.tcFilter.Name = "tcFilter";
            this.tcFilter.SelectedTabPage = this.tabPageFieldFilter;
            this.tcFilter.Size = new System.Drawing.Size(699, 242);
            this.tcFilter.TabIndex = 6;
            this.tcFilter.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tabPageFieldFilter,
            this.tabPageGroupFilter});
            this.tcFilter.SelectedPageChanged += new DevExpress.XtraTab.TabPageChangedEventHandler(this.tcFilter_SelectedPageChanged);
            // 
            // tabPageFieldFilter
            // 
            this.tabPageFieldFilter.Controls.Add(this.pivotFilter);
            this.tabPageFieldFilter.Name = "tabPageFieldFilter";
            this.tabPageFieldFilter.Size = new System.Drawing.Size(693, 214);
            this.tabPageFieldFilter.Text = "Field Filter";
            // 
            // pivotFilter
            // 
            this.pivotFilter.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pivotFilter.Cursor = System.Windows.Forms.Cursors.Default;
            this.pivotFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pivotFilter.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {
            this.fieldExtendedPrice,
            this.fieldProductName,
            this.fieldYear,
            this.fieldCategoryName,
            this.fieldQuantity});
            pivotGridStyleFormatCondition1.Expression = "[Extended Price] > 0";
            pivotGridStyleFormatCondition1.FieldName = "";
            this.pivotFilter.FormatConditions.AddRange(new DevExpress.XtraPivotGrid.PivotGridStyleFormatCondition[] {
            pivotGridStyleFormatCondition1});
            this.pivotFilter.Location = new System.Drawing.Point(0, 0);
            this.pivotFilter.Name = "pivotFilter";
            this.pivotFilter.OptionsCustomization.AllowHideFields = DevExpress.XtraPivotGrid.AllowHideFieldsType.Never;
            this.pivotFilter.Size = new System.Drawing.Size(693, 214);
            this.pivotFilter.TabIndex = 7;
            // 
            // fieldExtendedPrice
            // 
            this.fieldExtendedPrice.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldExtendedPrice.AreaIndex = 0;
            this.fieldExtendedPrice.CellFormat.FormatString = "c";
            this.fieldExtendedPrice.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldExtendedPrice.FieldName = "Extended Price";
            this.fieldExtendedPrice.Name = "fieldExtendedPrice";
            this.fieldExtendedPrice.Options.AllowDrag = DevExpress.Utils.DefaultBoolean.False;
            // 
            // fieldProductName
            // 
            this.fieldProductName.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldProductName.AreaIndex = 0;
            this.fieldProductName.Caption = "Product Name";
            this.fieldProductName.FieldName = "ProductName";
            this.fieldProductName.Name = "fieldProductName";
            this.fieldProductName.Options.AllowDrag = DevExpress.Utils.DefaultBoolean.False;
            // 
            // fieldYear
            // 
            this.fieldYear.AreaIndex = 0;
            this.fieldYear.Caption = "Year";
            this.fieldYear.FieldName = "OrderDate";
            this.fieldYear.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateYear;
            this.fieldYear.Name = "fieldYear";
            this.fieldYear.Options.AllowDrag = DevExpress.Utils.DefaultBoolean.False;
            this.fieldYear.UnboundFieldName = "fieldYear";
            // 
            // fieldCategoryName
            // 
            this.fieldCategoryName.AreaIndex = 1;
            this.fieldCategoryName.Caption = "Category Name";
            this.fieldCategoryName.FieldName = "CategoryName";
            this.fieldCategoryName.Name = "fieldCategoryName";
            this.fieldCategoryName.Options.AllowDrag = DevExpress.Utils.DefaultBoolean.False;
            // 
            // fieldQuantity
            // 
            this.fieldQuantity.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldQuantity.AreaIndex = 1;
            this.fieldQuantity.Caption = "Quantity";
            this.fieldQuantity.FieldName = "Quantity";
            this.fieldQuantity.Name = "fieldQuantity";
            this.fieldQuantity.Options.AllowDrag = DevExpress.Utils.DefaultBoolean.False;
            // 
            // tabPageGroupFilter
            // 
            this.tabPageGroupFilter.Controls.Add(this.pivotGroupFilter);
            this.tabPageGroupFilter.Name = "tabPageGroupFilter";
            this.tabPageGroupFilter.Size = new System.Drawing.Size(693, 214);
            this.tabPageGroupFilter.Text = "Group Filter";
            // 
            // pivotGroupFilter
            // 
            this.pivotGroupFilter.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pivotGroupFilter.Cursor = System.Windows.Forms.Cursors.Default;
            this.pivotGroupFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pivotGroupFilter.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {
            this.fieldGroupCategoryName,
            this.fieldGroupProductName,
            this.fieldGroupOrderAmount,
            this.fieldGroupYear,
            this.fieldGroupQuarter,
            this.fieldGroupMonth});
            pivotGridGroup1.Fields.Add(this.fieldGroupCategoryName);
            pivotGridGroup1.Fields.Add(this.fieldGroupProductName);
            pivotGridGroup1.Hierarchy = null;
            pivotGridGroup1.ShowNewValues = true;
            pivotGridGroup2.Fields.Add(this.fieldGroupYear);
            pivotGridGroup2.Fields.Add(this.fieldGroupQuarter);
            pivotGridGroup2.Fields.Add(this.fieldGroupMonth);
            pivotGridGroup2.Hierarchy = null;
            pivotGridGroup2.ShowNewValues = true;
            this.pivotGroupFilter.Groups.AddRange(new DevExpress.XtraPivotGrid.PivotGridGroup[] {
            pivotGridGroup1,
            pivotGridGroup2});
            this.pivotGroupFilter.Location = new System.Drawing.Point(0, 0);
            this.pivotGroupFilter.Name = "pivotGroupFilter";
            this.pivotGroupFilter.OptionsView.ShowFilterHeaders = false;
            this.pivotGroupFilter.Size = new System.Drawing.Size(693, 214);
            this.pivotGroupFilter.TabIndex = 14;
            // 
            // fieldGroupOrderAmount
            // 
            this.fieldGroupOrderAmount.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldGroupOrderAmount.AreaIndex = 0;
            this.fieldGroupOrderAmount.Caption = "Order Amount";
            this.fieldGroupOrderAmount.FieldName = "Extended Price";
            this.fieldGroupOrderAmount.Name = "fieldGroupOrderAmount";
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.chkInvertFilter);
            this.panelControl2.Controls.Add(this.chkRadioMode);
            this.panelControl2.Controls.Add(this.chkShowOnlyAvailableItems);
            this.panelControl2.Controls.Add(this.chkMultiSelection);
            this.panelControl2.Controls.Add(this.chkIncrementalSearch);
            this.panelControl2.Controls.Add(this.chkShowNewValues);
            this.panelControl2.Controls.Add(this.labelControl2);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 37);
            this.panelControl2.Margin = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(705, 52);
            this.panelControl2.TabIndex = 7;
            // 
            // chkInvertFilter
            // 
            this.chkInvertFilter.EditValue = true;
            this.chkInvertFilter.Location = new System.Drawing.Point(399, 28);
            this.chkInvertFilter.Name = "chkInvertFilter";
            this.chkInvertFilter.Properties.Caption = "Invert Filter";
            this.chkInvertFilter.Size = new System.Drawing.Size(82, 19);
            this.chkInvertFilter.TabIndex = 14;
            this.chkInvertFilter.CheckedChanged += new System.EventHandler(this.chkInvertFilter_CheckedChanged);
            // 
            // chkRadioMode
            // 
            this.chkRadioMode.EditValue = true;
            this.chkRadioMode.Location = new System.Drawing.Point(399, 4);
            this.chkRadioMode.Name = "chkRadioMode";
            this.chkRadioMode.Properties.Caption = "Radio Mode";
            this.chkRadioMode.Size = new System.Drawing.Size(83, 19);
            this.chkRadioMode.TabIndex = 13;
            this.chkRadioMode.CheckedChanged += new System.EventHandler(this.chkRadioMode_CheckedChanged);
            // 
            // chkShowOnlyAvailableItems
            // 
            this.chkShowOnlyAvailableItems.EditValue = true;
            this.chkShowOnlyAvailableItems.Location = new System.Drawing.Point(113, 4);
            this.chkShowOnlyAvailableItems.Name = "chkShowOnlyAvailableItems";
            this.chkShowOnlyAvailableItems.Properties.Caption = "Show Only Available Items";
            this.chkShowOnlyAvailableItems.Size = new System.Drawing.Size(153, 19);
            this.chkShowOnlyAvailableItems.TabIndex = 12;
            this.chkShowOnlyAvailableItems.CheckedChanged += new System.EventHandler(this.chkShowOnlyAvailableItems_CheckedChanged);
            // 
            // chkMultiSelection
            // 
            this.chkMultiSelection.Location = new System.Drawing.Point(272, 28);
            this.chkMultiSelection.Name = "chkMultiSelection";
            this.chkMultiSelection.Properties.Caption = "Multi-Selection";
            this.chkMultiSelection.Size = new System.Drawing.Size(91, 19);
            this.chkMultiSelection.TabIndex = 10;
            this.chkMultiSelection.CheckedChanged += new System.EventHandler(this.chkMultiSelection_CheckedChanged);
            // 
            // chkIncrementalSearch
            // 
            this.chkIncrementalSearch.Location = new System.Drawing.Point(272, 4);
            this.chkIncrementalSearch.Name = "chkIncrementalSearch";
            this.chkIncrementalSearch.Properties.Caption = "Incremental Search";
            this.chkIncrementalSearch.Size = new System.Drawing.Size(121, 19);
            this.chkIncrementalSearch.TabIndex = 11;
            this.chkIncrementalSearch.CheckedChanged += new System.EventHandler(this.chkIncrementalSearch_CheckedChanged);
            // 
            // chkShowNewValues
            // 
            this.chkShowNewValues.Location = new System.Drawing.Point(113, 28);
            this.chkShowNewValues.Name = "chkShowNewValues";
            this.chkShowNewValues.Properties.Caption = "Show New Field Values";
            this.chkShowNewValues.Size = new System.Drawing.Size(136, 19);
            this.chkShowNewValues.TabIndex = 8;
            this.chkShowNewValues.CheckedChanged += new System.EventHandler(this.chkFilterTypeExcluded_CheckedChanged);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(6, 7);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(80, 13);
            this.labelControl2.TabIndex = 9;
            this.labelControl2.Text = "Toolbar Buttons:";
            // 
            // FilterPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FilterPopup";
            this.Size = new System.Drawing.Size(705, 345);
            this.Load += new System.EventHandler(this.FilterPopup_Load);
            this.VisibleChanged += new System.EventHandler(this.FilterPopup_VisibleChanged);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkShowToolbar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkAllowTree.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkAllowContextMenu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tcFilter)).EndInit();
            this.tcFilter.ResumeLayout(false);
            this.tabPageFieldFilter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pivotFilter)).EndInit();
            this.tabPageGroupFilter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pivotGroupFilter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkInvertFilter.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkRadioMode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkShowOnlyAvailableItems.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkMultiSelection.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkIncrementalSearch.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkShowNewValues.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.CheckEdit chkAllowContextMenu;
        private DevExpress.XtraEditors.CheckEdit chkAllowTree;
        private DevExpress.XtraTab.XtraTabControl tcFilter;
        private DevExpress.XtraTab.XtraTabPage tabPageFieldFilter;
        private DevExpress.XtraTab.XtraTabPage tabPageGroupFilter;
        private PivotGridControl pivotFilter;
        private PivotGridField fieldExtendedPrice;
        private PivotGridField fieldProductName;
        private PivotGridControl pivotGroupFilter;
        private PivotGridField fieldGroupCategoryName;
        private PivotGridField fieldGroupProductName;
        private PivotGridField fieldGroupOrderAmount;
        private PivotGridField fieldGroupYear;
        private PivotGridField fieldGroupQuarter;
        private PivotGridField fieldGroupMonth;
        private PivotGridField fieldYear;
        private PivotGridField fieldCategoryName;
        private PivotGridField fieldQuantity;
        private DevExpress.XtraEditors.CheckEdit chkShowToolbar;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.CheckEdit chkShowOnlyAvailableItems;
        private DevExpress.XtraEditors.CheckEdit chkMultiSelection;
        private DevExpress.XtraEditors.CheckEdit chkIncrementalSearch;
        private DevExpress.XtraEditors.CheckEdit chkShowNewValues;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.CheckEdit chkInvertFilter;
        private DevExpress.XtraEditors.CheckEdit chkRadioMode;

    }
}
