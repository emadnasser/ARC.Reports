using DevExpress.Export;

namespace DevExpress.XtraGrid.Demos {
    partial class MasterDetail {
        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing) {
            if(disposing) {
                if(components != null) {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        #region Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MasterDetail));
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition1 = new DevExpress.XtraGrid.StyleFormatCondition();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode2 = new DevExpress.XtraGrid.GridLevelNode();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode3 = new DevExpress.XtraGrid.GridLevelNode();
            this.colDiscontinued = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCategoryID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemImageComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.colProductID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProductName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuantityPerUnit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colReorderLevel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemSpinEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.colUnitPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCalcEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit();
            this.colUnitsInStock = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnitsOnOrder = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.dsNWindSupplier1 = new DevExpress.XtraGrid.Demos.dsNWindSupplier();
            this.cardView1 = new DevExpress.XtraGrid.Views.Card.CardView();
            this.colCategoryName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPicture = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemImageEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemImageEdit();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemMemoExEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit();
            this.colProductName1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.advBandedGridView1 = new DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView();
            this.gridBand2 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colCompanyName = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colSupplierID = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colContactName = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colContactTitle = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand1 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colRegion = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.repositoryItemComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.colCountry = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.repositoryItemComboBox2 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.colCity = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colPostalCode = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colAddress = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colPhone = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colFax = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colDiscount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOrderID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnitPrice1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSubTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.imageComboBoxEdit1 = new DevExpress.XtraEditors.ImageComboBoxEdit();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.seVertIndent = new DevExpress.XtraEditors.SpinEdit();
            this.ceToolTips = new DevExpress.XtraEditors.CheckEdit();
            this.ceTabs = new DevExpress.XtraEditors.CheckEdit();
            this.ceMain = new DevExpress.XtraEditors.CheckEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.lciZooming = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciDetailIndent = new DevExpress.XtraLayout.LayoutControlItem();
            this.navigationPane1 = new DevExpress.XtraBars.Navigation.NavigationPane();
            this.navigationPage1 = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.pnlGrid = new DevExpress.XtraEditors.PanelControl();
            this.icbDetailMode = new DevExpress.XtraEditors.ImageComboBoxEdit();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.ceShowEmbeddedDetailIndent = new DevExpress.XtraEditors.CheckEdit();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCalcEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsNWindSupplier1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoExEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.advBandedGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageComboBoxEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.seVertIndent.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceToolTips.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceTabs.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceMain.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciZooming)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciDetailIndent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.navigationPane1)).BeginInit();
            this.navigationPane1.SuspendLayout();
            this.navigationPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlGrid)).BeginInit();
            this.pnlGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icbDetailMode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceShowEmbeddedDetailIndent.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).BeginInit();
            this.SuspendLayout();
            // 
            // colDiscontinued
            // 
            resources.ApplyResources(this.colDiscontinued, "colDiscontinued");
            this.colDiscontinued.FieldName = "Discontinued";
            this.colDiscontinued.Name = "colDiscontinued";
            // 
            // gridView1
            // 
            this.gridView1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            resources.ApplyResources(this.gridView1, "gridView1");
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCategoryID,
            this.colDiscontinued,
            this.colProductID,
            this.colProductName,
            this.colQuantityPerUnit,
            this.colReorderLevel,
            this.colUnitPrice,
            this.colUnitsInStock,
            this.colUnitsOnOrder});
            this.gridView1.DetailHeight = 300;
            styleFormatCondition1.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("resource.Font")));
            styleFormatCondition1.Appearance.ForeColor = ((System.Drawing.Color)(resources.GetObject("resource.ForeColor")));
            styleFormatCondition1.Appearance.Options.UseFont = true;
            styleFormatCondition1.Appearance.Options.UseForeColor = true;
            styleFormatCondition1.ApplyToRow = true;
            styleFormatCondition1.Column = this.colDiscontinued;
            styleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal;
            styleFormatCondition1.Value1 = true;
            this.gridView1.FormatConditions.AddRange(new DevExpress.XtraGrid.StyleFormatCondition[] {
            styleFormatCondition1});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Images = this.imageList2;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsClipboard.ClipboardMode = DevExpress.Export.ClipboardMode.Formatted;
            this.gridView1.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.gridView1.OptionsDetail.ShowDetailTabs = false;
            this.gridView1.OptionsView.AllowHtmlDrawHeaders = true;
            this.gridView1.OptionsView.ShowChildrenInGroupPanel = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colCategoryID
            // 
            resources.ApplyResources(this.colCategoryID, "colCategoryID");
            this.colCategoryID.ColumnEdit = this.repositoryItemImageComboBox1;
            this.colCategoryID.FieldName = "CategoryID";
            this.colCategoryID.Name = "colCategoryID";
            // 
            // repositoryItemImageComboBox1
            // 
            resources.ApplyResources(this.repositoryItemImageComboBox1, "repositoryItemImageComboBox1");
            this.repositoryItemImageComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("repositoryItemImageComboBox1.Buttons"))))});
            this.repositoryItemImageComboBox1.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem(resources.GetString("repositoryItemImageComboBox1.Items"), ((object)(resources.GetObject("repositoryItemImageComboBox1.Items1"))), ((int)(resources.GetObject("repositoryItemImageComboBox1.Items2")))),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem(resources.GetString("repositoryItemImageComboBox1.Items3"), ((object)(resources.GetObject("repositoryItemImageComboBox1.Items4"))), ((int)(resources.GetObject("repositoryItemImageComboBox1.Items5")))),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem(resources.GetString("repositoryItemImageComboBox1.Items6"), ((object)(resources.GetObject("repositoryItemImageComboBox1.Items7"))), ((int)(resources.GetObject("repositoryItemImageComboBox1.Items8")))),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem(resources.GetString("repositoryItemImageComboBox1.Items9"), ((object)(resources.GetObject("repositoryItemImageComboBox1.Items10"))), ((int)(resources.GetObject("repositoryItemImageComboBox1.Items11")))),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem(resources.GetString("repositoryItemImageComboBox1.Items12"), ((object)(resources.GetObject("repositoryItemImageComboBox1.Items13"))), ((int)(resources.GetObject("repositoryItemImageComboBox1.Items14")))),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem(resources.GetString("repositoryItemImageComboBox1.Items15"), ((object)(resources.GetObject("repositoryItemImageComboBox1.Items16"))), ((int)(resources.GetObject("repositoryItemImageComboBox1.Items17")))),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem(resources.GetString("repositoryItemImageComboBox1.Items18"), ((object)(resources.GetObject("repositoryItemImageComboBox1.Items19"))), ((int)(resources.GetObject("repositoryItemImageComboBox1.Items20")))),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem(resources.GetString("repositoryItemImageComboBox1.Items21"), ((object)(resources.GetObject("repositoryItemImageComboBox1.Items22"))), ((int)(resources.GetObject("repositoryItemImageComboBox1.Items23"))))});
            this.repositoryItemImageComboBox1.Name = "repositoryItemImageComboBox1";
            // 
            // colProductID
            // 
            resources.ApplyResources(this.colProductID, "colProductID");
            this.colProductID.FieldName = "ProductID";
            this.colProductID.Name = "colProductID";
            this.colProductID.OptionsFilter.AllowFilter = false;
            // 
            // colProductName
            // 
            resources.ApplyResources(this.colProductName, "colProductName");
            this.colProductName.FieldName = "ProductName";
            this.colProductName.Name = "colProductName";
            // 
            // colQuantityPerUnit
            // 
            resources.ApplyResources(this.colQuantityPerUnit, "colQuantityPerUnit");
            this.colQuantityPerUnit.FieldName = "QuantityPerUnit";
            this.colQuantityPerUnit.Name = "colQuantityPerUnit";
            // 
            // colReorderLevel
            // 
            resources.ApplyResources(this.colReorderLevel, "colReorderLevel");
            this.colReorderLevel.ColumnEdit = this.repositoryItemSpinEdit1;
            this.colReorderLevel.FieldName = "ReorderLevel";
            this.colReorderLevel.Name = "colReorderLevel";
            // 
            // repositoryItemSpinEdit1
            // 
            resources.ApplyResources(this.repositoryItemSpinEdit1, "repositoryItemSpinEdit1");
            this.repositoryItemSpinEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repositoryItemSpinEdit1.IsFloatValue = false;
            this.repositoryItemSpinEdit1.Mask.EditMask = resources.GetString("repositoryItemSpinEdit1.Mask.EditMask");
            this.repositoryItemSpinEdit1.Name = "repositoryItemSpinEdit1";
            // 
            // colUnitPrice
            // 
            resources.ApplyResources(this.colUnitPrice, "colUnitPrice");
            this.colUnitPrice.ColumnEdit = this.repositoryItemCalcEdit1;
            this.colUnitPrice.DisplayFormat.FormatString = "c";
            this.colUnitPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colUnitPrice.FieldName = "UnitPrice";
            this.colUnitPrice.Name = "colUnitPrice";
            // 
            // repositoryItemCalcEdit1
            // 
            resources.ApplyResources(this.repositoryItemCalcEdit1, "repositoryItemCalcEdit1");
            this.repositoryItemCalcEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("repositoryItemCalcEdit1.Buttons"))))});
            this.repositoryItemCalcEdit1.Name = "repositoryItemCalcEdit1";
            // 
            // colUnitsInStock
            // 
            resources.ApplyResources(this.colUnitsInStock, "colUnitsInStock");
            this.colUnitsInStock.ColumnEdit = this.repositoryItemSpinEdit1;
            this.colUnitsInStock.FieldName = "UnitsInStock";
            this.colUnitsInStock.Name = "colUnitsInStock";
            // 
            // colUnitsOnOrder
            // 
            resources.ApplyResources(this.colUnitsOnOrder, "colUnitsOnOrder");
            this.colUnitsOnOrder.ColumnEdit = this.repositoryItemSpinEdit1;
            this.colUnitsOnOrder.FieldName = "UnitsOnOrder";
            this.colUnitsOnOrder.Name = "colUnitsOnOrder";
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.dsNWindSupplier1.Suppliers;
            resources.ApplyResources(this.gridControl1, "gridControl1");
            gridLevelNode1.LevelTemplate = this.gridView1;
            gridLevelNode2.LevelTemplate = this.gridView2;
            gridLevelNode2.RelationName = "ProductsOrder_x0020_Details";
            gridLevelNode1.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode2});
            gridLevelNode1.RelationName = "SuppliersProducts";
            gridLevelNode3.LevelTemplate = this.cardView1;
            gridLevelNode3.RelationName = "SuppliersCategoryProducts";
            this.gridControl1.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1,
            gridLevelNode3});
            this.gridControl1.MainView = this.advBandedGridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemImageEdit1,
            this.repositoryItemMemoExEdit1,
            this.repositoryItemImageComboBox1,
            this.repositoryItemCalcEdit1,
            this.repositoryItemSpinEdit1,
            this.repositoryItemComboBox1,
            this.repositoryItemComboBox2});
            this.gridControl1.ShowOnlyPredefinedDetails = true;
            this.gridControl1.UseEmbeddedNavigator = true;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.cardView1,
            this.advBandedGridView1,
            this.gridView2,
            this.gridView1});
            // 
            // dsNWindSupplier1
            // 
            this.dsNWindSupplier1.DataSetName = "dsNWindSupplier";
            this.dsNWindSupplier1.Locale = new System.Globalization.CultureInfo("en-US");
            this.dsNWindSupplier1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cardView1
            // 
            this.cardView1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            resources.ApplyResources(this.cardView1, "cardView1");
            this.cardView1.CardWidth = 250;
            this.cardView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCategoryName,
            this.colPicture,
            this.colDescription,
            this.colProductName1});
            this.cardView1.DetailHeight = 120;
            this.cardView1.FocusedCardTopFieldIndex = 0;
            this.cardView1.GridControl = this.gridControl1;
            this.cardView1.MaximumCardColumns = 4;
            this.cardView1.Name = "cardView1";
            this.cardView1.OptionsView.ShowHorzScrollBar = false;
            this.cardView1.OptionsView.ShowLines = false;
            // 
            // colCategoryName
            // 
            resources.ApplyResources(this.colCategoryName, "colCategoryName");
            this.colCategoryName.FieldName = "CategoryName";
            this.colCategoryName.Name = "colCategoryName";
            // 
            // colPicture
            // 
            resources.ApplyResources(this.colPicture, "colPicture");
            this.colPicture.ColumnEdit = this.repositoryItemImageEdit1;
            this.colPicture.FieldName = "Picture";
            this.colPicture.Name = "colPicture";
            // 
            // repositoryItemImageEdit1
            // 
            resources.ApplyResources(this.repositoryItemImageEdit1, "repositoryItemImageEdit1");
            this.repositoryItemImageEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("repositoryItemImageEdit1.Buttons"))))});
            this.repositoryItemImageEdit1.Name = "repositoryItemImageEdit1";
            // 
            // colDescription
            // 
            resources.ApplyResources(this.colDescription, "colDescription");
            this.colDescription.ColumnEdit = this.repositoryItemMemoExEdit1;
            this.colDescription.FieldName = "Description";
            this.colDescription.Name = "colDescription";
            // 
            // repositoryItemMemoExEdit1
            // 
            resources.ApplyResources(this.repositoryItemMemoExEdit1, "repositoryItemMemoExEdit1");
            this.repositoryItemMemoExEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("repositoryItemMemoExEdit1.Buttons"))))});
            this.repositoryItemMemoExEdit1.Name = "repositoryItemMemoExEdit1";
            // 
            // colProductName1
            // 
            resources.ApplyResources(this.colProductName1, "colProductName1");
            this.colProductName1.FieldName = "ProductName";
            this.colProductName1.Name = "colProductName1";
            // 
            // advBandedGridView1
            // 
            this.advBandedGridView1.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.gridBand2,
            this.gridBand1});
            resources.ApplyResources(this.advBandedGridView1, "advBandedGridView1");
            this.advBandedGridView1.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
            this.colAddress,
            this.colCity,
            this.colCompanyName,
            this.colContactName,
            this.colContactTitle,
            this.colCountry,
            this.colFax,
            this.colPhone,
            this.colPostalCode,
            this.colRegion,
            this.colSupplierID});
            this.advBandedGridView1.DetailHeight = 300;
            this.advBandedGridView1.GridControl = this.gridControl1;
            this.advBandedGridView1.Images = this.imageList2;
            this.advBandedGridView1.Name = "advBandedGridView1";
            this.advBandedGridView1.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Embedded;
            this.advBandedGridView1.OptionsDetail.ShowEmbeddedDetailIndent = DevExpress.Utils.DefaultBoolean.True;
            this.advBandedGridView1.OptionsMenu.EnableGroupPanelMenu = false;
            this.advBandedGridView1.OptionsPrint.PrintDetails = true;
            this.advBandedGridView1.OptionsView.AllowHtmlDrawHeaders = true;
            this.advBandedGridView1.OptionsView.ShowChildrenInGroupPanel = true;
            this.advBandedGridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colRegion, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // gridBand2
            // 
            resources.ApplyResources(this.gridBand2, "gridBand2");
            this.gridBand2.Columns.Add(this.colCompanyName);
            this.gridBand2.Columns.Add(this.colSupplierID);
            this.gridBand2.Columns.Add(this.colContactName);
            this.gridBand2.Columns.Add(this.colContactTitle);
            this.gridBand2.VisibleIndex = 0;
            // 
            // colCompanyName
            // 
            resources.ApplyResources(this.colCompanyName, "colCompanyName");
            this.colCompanyName.FieldName = "CompanyName";
            this.colCompanyName.Name = "colCompanyName";
            // 
            // colSupplierID
            // 
            resources.ApplyResources(this.colSupplierID, "colSupplierID");
            this.colSupplierID.FieldName = "SupplierID";
            this.colSupplierID.Name = "colSupplierID";
            // 
            // colContactName
            // 
            resources.ApplyResources(this.colContactName, "colContactName");
            this.colContactName.FieldName = "ContactName";
            this.colContactName.Image = global::DevExpress.XtraGrid.Demos.Properties.Resources.contact_16x16;
            this.colContactName.Name = "colContactName";
            this.colContactName.RowIndex = 1;
            // 
            // colContactTitle
            // 
            resources.ApplyResources(this.colContactTitle, "colContactTitle");
            this.colContactTitle.FieldName = "ContactTitle";
            this.colContactTitle.Name = "colContactTitle";
            this.colContactTitle.RowIndex = 1;
            // 
            // gridBand1
            // 
            resources.ApplyResources(this.gridBand1, "gridBand1");
            this.gridBand1.Columns.Add(this.colRegion);
            this.gridBand1.Columns.Add(this.colCountry);
            this.gridBand1.Columns.Add(this.colCity);
            this.gridBand1.Columns.Add(this.colPostalCode);
            this.gridBand1.Columns.Add(this.colAddress);
            this.gridBand1.Columns.Add(this.colPhone);
            this.gridBand1.Columns.Add(this.colFax);
            this.gridBand1.Image = ((System.Drawing.Image)(resources.GetObject("gridBand1.Image")));
            this.gridBand1.VisibleIndex = 1;
            // 
            // colRegion
            // 
            resources.ApplyResources(this.colRegion, "colRegion");
            this.colRegion.ColumnEdit = this.repositoryItemComboBox1;
            this.colRegion.FieldName = "Region";
            this.colRegion.Name = "colRegion";
            // 
            // repositoryItemComboBox1
            // 
            resources.ApplyResources(this.repositoryItemComboBox1, "repositoryItemComboBox1");
            this.repositoryItemComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("repositoryItemComboBox1.Buttons"))))});
            this.repositoryItemComboBox1.Items.AddRange(new object[] {
            resources.GetString("repositoryItemComboBox1.Items"),
            resources.GetString("repositoryItemComboBox1.Items1"),
            resources.GetString("repositoryItemComboBox1.Items2"),
            resources.GetString("repositoryItemComboBox1.Items3"),
            resources.GetString("repositoryItemComboBox1.Items4"),
            resources.GetString("repositoryItemComboBox1.Items5"),
            resources.GetString("repositoryItemComboBox1.Items6"),
            resources.GetString("repositoryItemComboBox1.Items7"),
            resources.GetString("repositoryItemComboBox1.Items8"),
            resources.GetString("repositoryItemComboBox1.Items9"),
            resources.GetString("repositoryItemComboBox1.Items10"),
            resources.GetString("repositoryItemComboBox1.Items11"),
            resources.GetString("repositoryItemComboBox1.Items12"),
            resources.GetString("repositoryItemComboBox1.Items13"),
            resources.GetString("repositoryItemComboBox1.Items14"),
            resources.GetString("repositoryItemComboBox1.Items15"),
            resources.GetString("repositoryItemComboBox1.Items16"),
            resources.GetString("repositoryItemComboBox1.Items17"),
            resources.GetString("repositoryItemComboBox1.Items18")});
            this.repositoryItemComboBox1.Name = "repositoryItemComboBox1";
            // 
            // colCountry
            // 
            resources.ApplyResources(this.colCountry, "colCountry");
            this.colCountry.ColumnEdit = this.repositoryItemComboBox2;
            this.colCountry.FieldName = "Country";
            this.colCountry.Name = "colCountry";
            // 
            // repositoryItemComboBox2
            // 
            resources.ApplyResources(this.repositoryItemComboBox2, "repositoryItemComboBox2");
            this.repositoryItemComboBox2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("repositoryItemComboBox2.Buttons"))))});
            this.repositoryItemComboBox2.Items.AddRange(new object[] {
            resources.GetString("repositoryItemComboBox2.Items"),
            resources.GetString("repositoryItemComboBox2.Items1"),
            resources.GetString("repositoryItemComboBox2.Items2"),
            resources.GetString("repositoryItemComboBox2.Items3"),
            resources.GetString("repositoryItemComboBox2.Items4"),
            resources.GetString("repositoryItemComboBox2.Items5"),
            resources.GetString("repositoryItemComboBox2.Items6"),
            resources.GetString("repositoryItemComboBox2.Items7"),
            resources.GetString("repositoryItemComboBox2.Items8"),
            resources.GetString("repositoryItemComboBox2.Items9"),
            resources.GetString("repositoryItemComboBox2.Items10"),
            resources.GetString("repositoryItemComboBox2.Items11"),
            resources.GetString("repositoryItemComboBox2.Items12"),
            resources.GetString("repositoryItemComboBox2.Items13"),
            resources.GetString("repositoryItemComboBox2.Items14"),
            resources.GetString("repositoryItemComboBox2.Items15"),
            resources.GetString("repositoryItemComboBox2.Items16"),
            resources.GetString("repositoryItemComboBox2.Items17"),
            resources.GetString("repositoryItemComboBox2.Items18"),
            resources.GetString("repositoryItemComboBox2.Items19"),
            resources.GetString("repositoryItemComboBox2.Items20")});
            this.repositoryItemComboBox2.Name = "repositoryItemComboBox2";
            // 
            // colCity
            // 
            resources.ApplyResources(this.colCity, "colCity");
            this.colCity.FieldName = "City";
            this.colCity.Name = "colCity";
            // 
            // colPostalCode
            // 
            resources.ApplyResources(this.colPostalCode, "colPostalCode");
            this.colPostalCode.FieldName = "PostalCode";
            this.colPostalCode.Name = "colPostalCode";
            // 
            // colAddress
            // 
            resources.ApplyResources(this.colAddress, "colAddress");
            this.colAddress.FieldName = "Address";
            this.colAddress.Name = "colAddress";
            this.colAddress.RowIndex = 1;
            // 
            // colPhone
            // 
            resources.ApplyResources(this.colPhone, "colPhone");
            this.colPhone.FieldName = "Phone";
            this.colPhone.Name = "colPhone";
            this.colPhone.RowIndex = 1;
            // 
            // colFax
            // 
            resources.ApplyResources(this.colFax, "colFax");
            this.colFax.FieldName = "Fax";
            this.colFax.Name = "colFax";
            this.colFax.RowIndex = 1;
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Magenta;
            this.imageList2.Images.SetKeyName(0, "");
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colDiscount,
            this.colOrderID,
            this.colQuantity,
            this.colUnitPrice1,
            this.colSubTotal});
            this.gridView2.GridControl = this.gridControl1;
            this.gridView2.GroupCount = 1;
            this.gridView2.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(((DevExpress.Data.SummaryItemType)(resources.GetObject("gridView2.GroupSummary"))), resources.GetString("gridView2.GroupSummary1"), ((DevExpress.XtraGrid.Columns.GridColumn)(resources.GetObject("gridView2.GroupSummary2"))), resources.GetString("gridView2.GroupSummary3"))});
            this.gridView2.Images = this.imageList2;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsClipboard.ClipboardMode = DevExpress.Export.ClipboardMode.Formatted;
            this.gridView2.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.gridView2.OptionsView.AllowHtmlDrawHeaders = true;
            this.gridView2.OptionsView.ColumnAutoWidth = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            this.gridView2.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colUnitPrice1, DevExpress.Data.ColumnSortOrder.Ascending)});
            resources.ApplyResources(this.gridView2, "gridView2");
            // 
            // colDiscount
            // 
            resources.ApplyResources(this.colDiscount, "colDiscount");
            this.colDiscount.DisplayFormat.FormatString = "p";
            this.colDiscount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colDiscount.FieldName = "Discount";
            this.colDiscount.Name = "colDiscount";
            // 
            // colOrderID
            // 
            resources.ApplyResources(this.colOrderID, "colOrderID");
            this.colOrderID.FieldName = "OrderID";
            this.colOrderID.Name = "colOrderID";
            this.colOrderID.OptionsFilter.AllowFilter = false;
            // 
            // colQuantity
            // 
            resources.ApplyResources(this.colQuantity, "colQuantity");
            this.colQuantity.ColumnEdit = this.repositoryItemSpinEdit1;
            this.colQuantity.FieldName = "Quantity";
            this.colQuantity.Name = "colQuantity";
            // 
            // colUnitPrice1
            // 
            resources.ApplyResources(this.colUnitPrice1, "colUnitPrice1");
            this.colUnitPrice1.ColumnEdit = this.repositoryItemCalcEdit1;
            this.colUnitPrice1.DisplayFormat.FormatString = "c";
            this.colUnitPrice1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colUnitPrice1.FieldName = "UnitPrice";
            this.colUnitPrice1.Image = global::DevExpress.XtraGrid.Demos.Properties.Resources.sale_16x16;
            this.colUnitPrice1.Name = "colUnitPrice1";
            // 
            // colSubTotal
            // 
            resources.ApplyResources(this.colSubTotal, "colSubTotal");
            this.colSubTotal.DisplayFormat.FormatString = "c";
            this.colSubTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colSubTotal.FieldName = "SubTotal";
            this.colSubTotal.Name = "colSubTotal";
            this.colSubTotal.OptionsColumn.AllowEdit = false;
            // 
            // imageComboBoxEdit1
            // 
            resources.ApplyResources(this.imageComboBoxEdit1, "imageComboBoxEdit1");
            this.imageComboBoxEdit1.Name = "imageComboBoxEdit1";
            this.imageComboBoxEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("imageComboBoxEdit1.Properties.Buttons"))))});
            this.imageComboBoxEdit1.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem(resources.GetString("imageComboBoxEdit1.Properties.Items"), ((object)(resources.GetObject("imageComboBoxEdit1.Properties.Items1"))), ((int)(resources.GetObject("imageComboBoxEdit1.Properties.Items2")))),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem(resources.GetString("imageComboBoxEdit1.Properties.Items3"), ((object)(resources.GetObject("imageComboBoxEdit1.Properties.Items4"))), ((int)(resources.GetObject("imageComboBoxEdit1.Properties.Items5")))),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem(resources.GetString("imageComboBoxEdit1.Properties.Items6"), ((object)(resources.GetObject("imageComboBoxEdit1.Properties.Items7"))), ((int)(resources.GetObject("imageComboBoxEdit1.Properties.Items8"))))});
            this.imageComboBoxEdit1.Properties.SmallImages = this.imageList1;
            this.imageComboBoxEdit1.StyleController = this.layoutControl1;
            this.imageComboBoxEdit1.SelectedIndexChanged += new System.EventHandler(this.imageComboBoxEdit1_SelectedIndexChanged);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Magenta;
            this.imageList1.Images.SetKeyName(0, "");
            this.imageList1.Images.SetKeyName(1, "");
            this.imageList1.Images.SetKeyName(2, "");
            // 
            // layoutControl1
            // 
            this.layoutControl1.AllowCustomization = false;
            this.layoutControl1.Controls.Add(this.ceShowEmbeddedDetailIndent);
            this.layoutControl1.Controls.Add(this.icbDetailMode);
            this.layoutControl1.Controls.Add(this.seVertIndent);
            this.layoutControl1.Controls.Add(this.imageComboBoxEdit1);
            this.layoutControl1.Controls.Add(this.ceToolTips);
            this.layoutControl1.Controls.Add(this.ceTabs);
            this.layoutControl1.Controls.Add(this.ceMain);
            resources.ApplyResources(this.layoutControl1, "layoutControl1");
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(1032, 180, 450, 350);
            this.layoutControl1.Root = this.layoutControlGroup1;
            // 
            // seVertIndent
            // 
            resources.ApplyResources(this.seVertIndent, "seVertIndent");
            this.seVertIndent.Name = "seVertIndent";
            this.seVertIndent.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.seVertIndent.Properties.IsFloatValue = false;
            this.seVertIndent.Properties.Mask.EditMask = resources.GetString("seVertIndent.Properties.Mask.EditMask");
            this.seVertIndent.Properties.MaxValue = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.seVertIndent.StyleController = this.layoutControl1;
            this.seVertIndent.EditValueChanged += new System.EventHandler(this.seVertIndent_EditValueChanged);
            // 
            // ceToolTips
            // 
            resources.ApplyResources(this.ceToolTips, "ceToolTips");
            this.ceToolTips.Name = "ceToolTips";
            this.ceToolTips.Properties.Caption = resources.GetString("ceToolTips.Properties.Caption");
            this.ceToolTips.StyleController = this.layoutControl1;
            this.ceToolTips.CheckedChanged += new System.EventHandler(this.ceToolTips_CheckedChanged);
            // 
            // ceTabs
            // 
            resources.ApplyResources(this.ceTabs, "ceTabs");
            this.ceTabs.Name = "ceTabs";
            this.ceTabs.Properties.Caption = resources.GetString("ceTabs.Properties.Caption");
            this.ceTabs.StyleController = this.layoutControl1;
            this.ceTabs.CheckedChanged += new System.EventHandler(this.ceTabs_CheckedChanged);
            // 
            // ceMain
            // 
            resources.ApplyResources(this.ceMain, "ceMain");
            this.ceMain.Name = "ceMain";
            this.ceMain.Properties.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("ceMain.Properties.Appearance.Font")));
            this.ceMain.Properties.Appearance.Options.UseFont = true;
            this.ceMain.Properties.Caption = resources.GetString("ceMain.Properties.Caption");
            this.ceMain.StyleController = this.layoutControl1;
            this.ceMain.CheckedChanged += new System.EventHandler(this.ceMain_CheckedChanged);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.emptySpaceItem1,
            this.emptySpaceItem2,
            this.lciZooming,
            this.lciDetailIndent,
            this.layoutControlItem6,
            this.layoutControlItem7,
            this.emptySpaceItem3});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(249, 489);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.ceMain;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(229, 23);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.ceTabs;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 109);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(229, 23);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.ceToolTips;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 132);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(229, 23);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 203);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(229, 266);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(0, 23);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(229, 18);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // lciZooming
            // 
            this.lciZooming.Control = this.imageComboBoxEdit1;
            this.lciZooming.Location = new System.Drawing.Point(0, 155);
            this.lciZooming.Name = "lciZooming";
            this.lciZooming.Size = new System.Drawing.Size(229, 24);
            resources.ApplyResources(this.lciZooming, "lciZooming");
            this.lciZooming.TextSize = new System.Drawing.Size(104, 13);
            // 
            // lciDetailIndent
            // 
            this.lciDetailIndent.Control = this.seVertIndent;
            this.lciDetailIndent.Location = new System.Drawing.Point(0, 179);
            this.lciDetailIndent.Name = "lciDetailIndent";
            this.lciDetailIndent.Size = new System.Drawing.Size(229, 24);
            resources.ApplyResources(this.lciDetailIndent, "lciDetailIndent");
            this.lciDetailIndent.TextSize = new System.Drawing.Size(104, 13);
            // 
            // navigationPane1
            // 
            this.navigationPane1.Controls.Add(this.navigationPage1);
            resources.ApplyResources(this.navigationPane1, "navigationPane1");
            this.navigationPane1.Name = "navigationPane1";
            this.navigationPane1.PageProperties.AppearanceCaption.Options.UseTextOptions = true;
            this.navigationPane1.PageProperties.AppearanceCaption.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter;
            this.navigationPane1.PageProperties.ShowExpandButton = false;
            this.navigationPane1.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.navigationPage1});
            this.navigationPane1.RegularSize = new System.Drawing.Size(299, 549);
            this.navigationPane1.SelectedPage = this.navigationPage1;
            // 
            // navigationPage1
            // 
            this.navigationPage1.Caption = "Options";
            this.navigationPage1.Controls.Add(this.layoutControl1);
            this.navigationPage1.Image = ((System.Drawing.Image)(resources.GetObject("navigationPage1.Image")));
            this.navigationPage1.ImageUri.Uri = "New";
            this.navigationPage1.Name = "navigationPage1";
            resources.ApplyResources(this.navigationPage1, "navigationPage1");
            // 
            // pnlGrid
            // 
            this.pnlGrid.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pnlGrid.Controls.Add(this.gridControl1);
            resources.ApplyResources(this.pnlGrid, "pnlGrid");
            this.pnlGrid.Name = "pnlGrid";
            // 
            // icbDetailMode
            // 
            resources.ApplyResources(this.icbDetailMode, "icbDetailMode");
            this.icbDetailMode.Name = "icbDetailMode";
            this.icbDetailMode.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("imageComboBoxEdit2.Properties.Buttons"))))});
            this.icbDetailMode.StyleController = this.layoutControl1;
            this.icbDetailMode.SelectedIndexChanged += new System.EventHandler(this.icbDetailMode_SelectedIndexChanged);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.AllowHtmlStringInCaption = true;
            this.layoutControlItem6.Control = this.icbDetailMode;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 41);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(229, 24);
            resources.ApplyResources(this.layoutControlItem6, "layoutControlItem6");
            this.layoutControlItem6.TextSize = new System.Drawing.Size(104, 13);
            // 
            // ceShowEmbeddedDetailIndent
            // 
            resources.ApplyResources(this.ceShowEmbeddedDetailIndent, "ceShowEmbeddedDetailIndent");
            this.ceShowEmbeddedDetailIndent.Name = "ceShowEmbeddedDetailIndent";
            this.ceShowEmbeddedDetailIndent.Properties.Caption = resources.GetString("checkEdit1.Properties.Caption");
            this.ceShowEmbeddedDetailIndent.StyleController = this.layoutControl1;
            this.ceShowEmbeddedDetailIndent.CheckedChanged += new System.EventHandler(this.ceShowEmbeddedDetailIndent_CheckedChanged);
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.ceShowEmbeddedDetailIndent;
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 65);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(229, 23);
            this.layoutControlItem7.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem7.TextVisible = false;
            // 
            // emptySpaceItem3
            // 
            this.emptySpaceItem3.AllowHotTrack = false;
            this.emptySpaceItem3.Location = new System.Drawing.Point(0, 88);
            this.emptySpaceItem3.Name = "emptySpaceItem3";
            this.emptySpaceItem3.Size = new System.Drawing.Size(229, 21);
            this.emptySpaceItem3.TextSize = new System.Drawing.Size(0, 0);
            // 
            // MasterDetail
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlGrid);
            this.Controls.Add(this.navigationPane1);
            this.Name = "MasterDetail";
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCalcEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsNWindSupplier1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoExEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.advBandedGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageComboBoxEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.seVertIndent.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceToolTips.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceTabs.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceMain.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciZooming)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciDetailIndent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.navigationPane1)).EndInit();
            this.navigationPane1.ResumeLayout(false);
            this.navigationPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnlGrid)).EndInit();
            this.pnlGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.icbDetailMode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceShowEmbeddedDetailIndent.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colRegion;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colCountry;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colCity;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colPostalCode;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colAddress;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colPhone;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colFax;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colContactTitle;
        private DevExpress.XtraGrid.Columns.GridColumn colPicture;
        private DevExpress.XtraGrid.Views.Card.CardView cardView1;
        private DevExpress.XtraGrid.Columns.GridColumn colCategoryName;
        private DevExpress.XtraGrid.Columns.GridColumn colProductName1;
        private DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView advBandedGridView1;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand2;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colCompanyName;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colSupplierID;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colContactName;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colDiscount;
        private DevExpress.XtraGrid.Columns.GridColumn colOrderID;
        private DevExpress.XtraGrid.Columns.GridColumn colQuantity;
        private DevExpress.XtraGrid.Columns.GridColumn colUnitPrice1;
        private DevExpress.XtraGrid.Columns.GridColumn colSubTotal;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colCategoryID;
        private DevExpress.XtraGrid.Columns.GridColumn colDiscontinued;
        private DevExpress.XtraGrid.Columns.GridColumn colProductID;
        private DevExpress.XtraGrid.Columns.GridColumn colProductName;
        private DevExpress.XtraGrid.Columns.GridColumn colQuantityPerUnit;
        private DevExpress.XtraGrid.Columns.GridColumn colReorderLevel;
        private DevExpress.XtraGrid.Columns.GridColumn colUnitPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colUnitsInStock;
        private DevExpress.XtraGrid.Columns.GridColumn colUnitsOnOrder;
        private dsNWindSupplier dsNWindSupplier1;
        private System.ComponentModel.IContainer components = null;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageEdit repositoryItemImageEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit repositoryItemMemoExEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox repositoryItemImageComboBox1;
        private System.Windows.Forms.ImageList imageList2;
        private DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit repositoryItemCalcEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repositoryItemSpinEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox1;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox2;
        private DevExpress.XtraEditors.ImageComboBoxEdit imageComboBoxEdit1;
        private DevExpress.XtraEditors.CheckEdit ceTabs;
        private DevExpress.XtraEditors.CheckEdit ceToolTips;
        private DevExpress.XtraEditors.CheckEdit ceMain;
        private System.Windows.Forms.ImageList imageList1;
        private DevExpress.XtraEditors.SpinEdit seVertIndent;
        private XtraLayout.LayoutControl layoutControl1;
        private XtraLayout.LayoutControlGroup layoutControlGroup1;
        private XtraLayout.LayoutControlItem layoutControlItem1;
        private XtraLayout.LayoutControlItem layoutControlItem2;
        private XtraLayout.LayoutControlItem layoutControlItem3;
        private XtraLayout.EmptySpaceItem emptySpaceItem1;
        private XtraLayout.EmptySpaceItem emptySpaceItem2;
        private XtraLayout.LayoutControlItem lciZooming;
        private XtraLayout.LayoutControlItem lciDetailIndent;
        private XtraBars.Navigation.NavigationPane navigationPane1;
        private XtraBars.Navigation.NavigationPage navigationPage1;
        private XtraEditors.PanelControl pnlGrid;
        private XtraEditors.CheckEdit ceShowEmbeddedDetailIndent;
        private XtraEditors.ImageComboBoxEdit icbDetailMode;
        private XtraLayout.LayoutControlItem layoutControlItem6;
        private XtraLayout.LayoutControlItem layoutControlItem7;
        private XtraLayout.EmptySpaceItem emptySpaceItem3;
    }
}
