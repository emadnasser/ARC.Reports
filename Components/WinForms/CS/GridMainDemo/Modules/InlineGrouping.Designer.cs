﻿namespace DevExpress.XtraGrid.Demos
{
    partial class InlineGrouping
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InlineGrouping));
            DevExpress.XtraGrid.GridFormatRule gridFormatRule1 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleValue formatConditionRuleValue1 = new DevExpress.XtraEditors.FormatConditionRuleValue();
            this.colInStock = new DevExpress.XtraGrid.Columns.GridColumn();
            this.navigationPane1 = new DevExpress.XtraBars.Navigation.NavigationPane();
            this.navigationPage1 = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.ceGroupExpandedOnSorting = new DevExpress.XtraEditors.CheckEdit();
            this.ceAutoExpandAllGroups = new DevExpress.XtraEditors.CheckEdit();
            this.ceShowExpandCollapseButtons = new DevExpress.XtraEditors.CheckEdit();
            this.icbGroupDrawMode = new DevExpress.XtraEditors.ImageComboBoxEdit();
            this.ceAllowPartialGroups = new DevExpress.XtraEditors.CheckEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTrademarkImage = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTrademark = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModification = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCategory = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBodyStyle = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemMemoExEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit();
            this.colDeliveryDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPhoto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemImageEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemImageEdit();
            this.navigationPane1.SuspendLayout();
            this.navigationPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ceGroupExpandedOnSorting.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceAutoExpandAllGroups.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceShowExpandCollapseButtons.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icbGroupDrawMode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceAllowPartialGroups.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoExEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // colInStock
            // 
            this.colInStock.FieldName = "InStock";
            this.colInStock.Name = "colInStock";
            this.colInStock.Width = 90;
            // 
            // navigationPane1
            // 
            this.navigationPane1.Controls.Add(this.navigationPage1);
            this.navigationPane1.Dock = System.Windows.Forms.DockStyle.Right;
            this.navigationPane1.Location = new System.Drawing.Point(678, 0);
            this.navigationPane1.Name = "navigationPane1";
            this.navigationPane1.PageProperties.AppearanceCaption.Options.UseTextOptions = true;
            this.navigationPane1.PageProperties.AppearanceCaption.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter;
            this.navigationPane1.PageProperties.ShowExpandButton = false;
            this.navigationPane1.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.navigationPage1});
            this.navigationPane1.RegularSize = new System.Drawing.Size(277, 591);
            this.navigationPane1.SelectedPage = this.navigationPage1;
            this.navigationPane1.SelectedPageIndex = 0;
            this.navigationPane1.Size = new System.Drawing.Size(277, 591);
            this.navigationPane1.TabIndex = 8;
            this.navigationPane1.Text = "navigationPane1";
            // 
            // navigationPage1
            // 
            this.navigationPage1.Caption = "Options";
            this.navigationPage1.Controls.Add(this.layoutControl1);
            this.navigationPage1.Image = ((System.Drawing.Image)(resources.GetObject("navigationPage1.Image")));
            this.navigationPage1.ImageUri.Uri = "New";
            this.navigationPage1.Name = "navigationPage1";
            this.navigationPage1.Size = new System.Drawing.Size(227, 531);
            // 
            // layoutControl1
            // 
            this.layoutControl1.AllowCustomization = false;
            this.layoutControl1.Controls.Add(this.ceGroupExpandedOnSorting);
            this.layoutControl1.Controls.Add(this.ceAutoExpandAllGroups);
            this.layoutControl1.Controls.Add(this.ceShowExpandCollapseButtons);
            this.layoutControl1.Controls.Add(this.icbGroupDrawMode);
            this.layoutControl1.Controls.Add(this.ceAllowPartialGroups);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(1032, 180, 450, 350);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(227, 531);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // ceGroupExpandedOnSorting
            // 
            this.ceGroupExpandedOnSorting.Location = new System.Drawing.Point(12, 141);
            this.ceGroupExpandedOnSorting.Name = "ceGroupExpandedOnSorting";
            this.ceGroupExpandedOnSorting.Properties.Caption = "Keep Group Expanded On Sorting";
            this.ceGroupExpandedOnSorting.Size = new System.Drawing.Size(203, 19);
            this.ceGroupExpandedOnSorting.StyleController = this.layoutControl1;
            this.ceGroupExpandedOnSorting.TabIndex = 8;
            this.ceGroupExpandedOnSorting.CheckedChanged += new System.EventHandler(this.ceGroupExpandedOnSorting_CheckedChanged);
            // 
            // ceAutoExpandAllGroups
            // 
            this.ceAutoExpandAllGroups.Location = new System.Drawing.Point(12, 118);
            this.ceAutoExpandAllGroups.Name = "ceAutoExpandAllGroups";
            this.ceAutoExpandAllGroups.Properties.Caption = "Auto Expand All Groups";
            this.ceAutoExpandAllGroups.Size = new System.Drawing.Size(203, 19);
            this.ceAutoExpandAllGroups.StyleController = this.layoutControl1;
            this.ceAutoExpandAllGroups.TabIndex = 7;
            this.ceAutoExpandAllGroups.CheckedChanged += new System.EventHandler(this.ceAutoExpandAllGroups_CheckedChanged);
            // 
            // ceShowExpandCollapseButtons
            // 
            this.ceShowExpandCollapseButtons.Location = new System.Drawing.Point(12, 85);
            this.ceShowExpandCollapseButtons.Name = "ceShowExpandCollapseButtons";
            this.ceShowExpandCollapseButtons.Properties.Caption = "Show Group Buttons";
            this.ceShowExpandCollapseButtons.Size = new System.Drawing.Size(203, 19);
            this.ceShowExpandCollapseButtons.StyleController = this.layoutControl1;
            this.ceShowExpandCollapseButtons.TabIndex = 6;
            this.ceShowExpandCollapseButtons.CheckedChanged += new System.EventHandler(this.ceShowExpandCollapsButtons_CheckedChanged);
            // 
            // icbGroupDrawMode
            // 
            this.icbGroupDrawMode.Location = new System.Drawing.Point(12, 61);
            this.icbGroupDrawMode.Name = "icbGroupDrawMode";
            this.icbGroupDrawMode.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.icbGroupDrawMode.Size = new System.Drawing.Size(203, 20);
            this.icbGroupDrawMode.StyleController = this.layoutControl1;
            this.icbGroupDrawMode.TabIndex = 5;
            this.icbGroupDrawMode.SelectedIndexChanged += new System.EventHandler(this.icbGroupDrawMode_SelectedIndexChanged);
            // 
            // ceAllowPartialGroups
            // 
            this.ceAllowPartialGroups.Location = new System.Drawing.Point(12, 12);
            this.ceAllowPartialGroups.Name = "ceAllowPartialGroups";
            this.ceAllowPartialGroups.Properties.AllowHtmlDraw = DevExpress.Utils.DefaultBoolean.True;
            this.ceAllowPartialGroups.Properties.Caption = "<b>Allow Partial Groups";
            this.ceAllowPartialGroups.Size = new System.Drawing.Size(203, 19);
            this.ceAllowPartialGroups.StyleController = this.layoutControl1;
            this.ceAllowPartialGroups.TabIndex = 4;
            this.ceAllowPartialGroups.CheckedChanged += new System.EventHandler(this.ceAllowPartialGroups_CheckedChanged);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.emptySpaceItem1,
            this.emptySpaceItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.emptySpaceItem3});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(227, 531);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.ceAllowPartialGroups;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(207, 23);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.icbGroupDrawMode;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 33);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(207, 40);
            this.layoutControlItem2.Text = "Group Draw Mode:";
            this.layoutControlItem2.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(90, 13);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 23);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(207, 10);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(0, 152);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(207, 359);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.ceShowExpandCollapseButtons;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 73);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(207, 23);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.ceAutoExpandAllGroups;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 106);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(207, 23);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.ceGroupExpandedOnSorting;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 129);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(207, 23);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // emptySpaceItem3
            // 
            this.emptySpaceItem3.AllowHotTrack = false;
            this.emptySpaceItem3.Location = new System.Drawing.Point(0, 96);
            this.emptySpaceItem3.Name = "emptySpaceItem3";
            this.emptySpaceItem3.Size = new System.Drawing.Size(207, 10);
            this.emptySpaceItem3.TextSize = new System.Drawing.Size(0, 0);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gridControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.panel1.Size = new System.Drawing.Size(678, 591);
            this.panel1.TabIndex = 9;
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemImageEdit1,
            this.repositoryItemMemoExEdit1});
            this.gridControl1.Size = new System.Drawing.Size(668, 591);
            this.gridControl1.TabIndex = 4;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTrademarkImage,
            this.colTrademark,
            this.colName,
            this.colModification,
            this.colCategory,
            this.colPrice,
            this.colBodyStyle,
            this.colDescription,
            this.colDeliveryDate,
            this.colInStock,
            this.colPhoto});
            gridFormatRule1.ApplyToRow = true;
            gridFormatRule1.Column = this.colInStock;
            gridFormatRule1.Name = "Format0";
            formatConditionRuleValue1.Appearance.ForeColor = System.Drawing.Color.DarkGray;
            formatConditionRuleValue1.Appearance.Options.UseForeColor = true;
            formatConditionRuleValue1.Condition = DevExpress.XtraEditors.FormatCondition.Equal;
            formatConditionRuleValue1.PredefinedName = "Strikeout Text";
            formatConditionRuleValue1.Value1 = false;
            gridFormatRule1.Rule = formatConditionRuleValue1;
            this.gridView1.FormatRules.Add(gridFormatRule1);
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.GroupCount = 1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AllowPartialGroups = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsBehavior.AllowPixelScrolling = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsBehavior.AutoExpandAllGroups = true;
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsDetail.EnableMasterViewMode = false;
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colDeliveryDate, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colTrademarkImage
            // 
            this.colTrademarkImage.FieldName = "TrademarkImage";
            this.colTrademarkImage.Image = ((System.Drawing.Image)(resources.GetObject("colTrademarkImage.Image")));
            this.colTrademarkImage.ImageAlignment = System.Drawing.StringAlignment.Center;
            this.colTrademarkImage.Name = "colTrademarkImage";
            this.colTrademarkImage.OptionsColumn.AllowFocus = false;
            this.colTrademarkImage.OptionsColumn.AllowSize = false;
            this.colTrademarkImage.OptionsColumn.FixedWidth = true;
            this.colTrademarkImage.OptionsColumn.ShowCaption = false;
            this.colTrademarkImage.OptionsFilter.AllowFilter = false;
            this.colTrademarkImage.Visible = true;
            this.colTrademarkImage.VisibleIndex = 1;
            this.colTrademarkImage.Width = 66;
            // 
            // colTrademark
            // 
            this.colTrademark.FieldName = "Trademark";
            this.colTrademark.Name = "colTrademark";
            this.colTrademark.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            this.colTrademark.Visible = true;
            this.colTrademark.VisibleIndex = 2;
            this.colTrademark.Width = 142;
            // 
            // colName
            // 
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 3;
            this.colName.Width = 131;
            // 
            // colModification
            // 
            this.colModification.FieldName = "Modification";
            this.colModification.Name = "colModification";
            this.colModification.Visible = true;
            this.colModification.VisibleIndex = 4;
            this.colModification.Width = 134;
            // 
            // colCategory
            // 
            this.colCategory.FieldName = "Category";
            this.colCategory.Name = "colCategory";
            this.colCategory.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            this.colCategory.Visible = true;
            this.colCategory.VisibleIndex = 5;
            this.colCategory.Width = 130;
            // 
            // colPrice
            // 
            this.colPrice.FieldName = "Price";
            this.colPrice.Name = "colPrice";
            this.colPrice.Visible = true;
            this.colPrice.VisibleIndex = 6;
            this.colPrice.Width = 121;
            // 
            // colBodyStyle
            // 
            this.colBodyStyle.FieldName = "BodyStyle";
            this.colBodyStyle.Name = "colBodyStyle";
            this.colBodyStyle.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            this.colBodyStyle.Width = 117;
            // 
            // colDescription
            // 
            this.colDescription.ColumnEdit = this.repositoryItemMemoExEdit1;
            this.colDescription.FieldName = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.OptionsFilter.AllowFilter = false;
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 7;
            this.colDescription.Width = 83;
            // 
            // repositoryItemMemoExEdit1
            // 
            this.repositoryItemMemoExEdit1.AutoHeight = false;
            this.repositoryItemMemoExEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemMemoExEdit1.Name = "repositoryItemMemoExEdit1";
            this.repositoryItemMemoExEdit1.PopupFormMinSize = new System.Drawing.Size(300, 150);
            // 
            // colDeliveryDate
            // 
            this.colDeliveryDate.FieldName = "DeliveryDate";
            this.colDeliveryDate.Name = "colDeliveryDate";
            this.colDeliveryDate.Visible = true;
            this.colDeliveryDate.VisibleIndex = 0;
            this.colDeliveryDate.Width = 127;
            // 
            // colPhoto
            // 
            this.colPhoto.ColumnEdit = this.repositoryItemImageEdit1;
            this.colPhoto.FieldName = "Photo";
            this.colPhoto.Name = "colPhoto";
            this.colPhoto.OptionsFilter.AllowFilter = false;
            this.colPhoto.Width = 91;
            // 
            // repositoryItemImageEdit1
            // 
            this.repositoryItemImageEdit1.AutoHeight = false;
            this.repositoryItemImageEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemImageEdit1.Name = "repositoryItemImageEdit1";
            this.repositoryItemImageEdit1.PopupFormMinSize = new System.Drawing.Size(300, 150);
            this.repositoryItemImageEdit1.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            // 
            // InlineGrouping
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.navigationPane1);
            this.Name = "InlineGrouping";
            this.Size = new System.Drawing.Size(955, 591);
            this.navigationPane1.ResumeLayout(false);
            this.navigationPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ceGroupExpandedOnSorting.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceAutoExpandAllGroups.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceShowExpandCollapseButtons.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icbGroupDrawMode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceAllowPartialGroups.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoExEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageEdit1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private XtraBars.Navigation.NavigationPane navigationPane1;
        private XtraBars.Navigation.NavigationPage navigationPage1;
        private XtraLayout.LayoutControl layoutControl1;
        private XtraLayout.LayoutControlGroup layoutControlGroup1;
        private System.Windows.Forms.Panel panel1;
        private GridControl gridControl1;
        private Views.Grid.GridView gridView1;
        private Columns.GridColumn colTrademarkImage;
        private Columns.GridColumn colTrademark;
        private Columns.GridColumn colName;
        private Columns.GridColumn colModification;
        private Columns.GridColumn colCategory;
        private Columns.GridColumn colPrice;
        private Columns.GridColumn colBodyStyle;
        private Columns.GridColumn colDescription;
        private Columns.GridColumn colDeliveryDate;
        private Columns.GridColumn colInStock;
        private Columns.GridColumn colPhoto;
        private XtraEditors.Repository.RepositoryItemMemoExEdit repositoryItemMemoExEdit1;
        private XtraEditors.Repository.RepositoryItemImageEdit repositoryItemImageEdit1;
        private XtraEditors.CheckEdit ceAllowPartialGroups;
        private XtraLayout.LayoutControlItem layoutControlItem1;
        private XtraEditors.ImageComboBoxEdit icbGroupDrawMode;
        private XtraLayout.LayoutControlItem layoutControlItem2;
        private XtraLayout.EmptySpaceItem emptySpaceItem1;
        private XtraLayout.EmptySpaceItem emptySpaceItem2;
        private XtraEditors.CheckEdit ceShowExpandCollapseButtons;
        private XtraLayout.LayoutControlItem layoutControlItem3;
        private XtraEditors.CheckEdit ceGroupExpandedOnSorting;
        private XtraEditors.CheckEdit ceAutoExpandAllGroups;
        private XtraLayout.LayoutControlItem layoutControlItem4;
        private XtraLayout.LayoutControlItem layoutControlItem5;
        private XtraLayout.EmptySpaceItem emptySpaceItem3;
    }
}
