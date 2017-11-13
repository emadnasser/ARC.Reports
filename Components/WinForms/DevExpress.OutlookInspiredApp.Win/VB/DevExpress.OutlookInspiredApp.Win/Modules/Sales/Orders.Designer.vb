Namespace DevExpress.DevAV.Modules
    Partial Public Class Orders
        ''' <summary> 
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary> 
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Component Designer generated code"

        ''' <summary> 
        ''' Required method for Designer support - do not modify 
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim gridLevelNode1 As New DevExpress.XtraGrid.GridLevelNode()
            Dim gridFormatRule1 As New DevExpress.XtraGrid.GridFormatRule()
            Dim formatConditionRuleDataBar1 As New DevExpress.XtraEditors.FormatConditionRuleDataBar()
            Dim galleryItemGroup1 As New DevExpress.XtraBars.Ribbon.GalleryItemGroup()
            Dim galleryItem1 As New DevExpress.XtraBars.Ribbon.GalleryItem()
            Dim galleryItem2 As New DevExpress.XtraBars.Ribbon.GalleryItem()
            Dim galleryItem3 As New DevExpress.XtraBars.Ribbon.GalleryItem()
            Dim galleryItem4 As New DevExpress.XtraBars.Ribbon.GalleryItem()
            Dim skinPaddingEdges1 As New DevExpress.Skins.SkinPaddingEdges()
            Dim skinPaddingEdges2 As New DevExpress.Skins.SkinPaddingEdges()
            Me.gridViewOrderItems = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.colProduct = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colProductUnits = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colProductPrice = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colDiscount = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colTotal = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colId = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.gridControl = New DevExpress.XtraGrid.GridControl()
            Me.bindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.gridView = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.colInvoiceNumber = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colOrderDate = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colTotalAmount = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colStore = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colCustomer = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colShipDate1 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colShippingAmount = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.repositoryItemMemoEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
            Me.modueLayout = New DevExpress.XtraLayout.LayoutControl()
            Me.pnlView = New DevExpress.XtraEditors.PanelControl()
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.masterItem = New DevExpress.XtraLayout.LayoutControlItem()
            Me.detailItem = New DevExpress.XtraLayout.LayoutControlItem()
            Me.splitterItem = New DevExpress.XtraLayout.SplitterItem()
            Me.ribbonControl = New DevExpress.XtraBars.Ribbon.RibbonControl()
            Me.biNewOrder = New DevExpress.XtraBars.BarButtonItem()
            Me.biNewGroup = New DevExpress.XtraBars.BarButtonItem()
            Me.biDelete = New DevExpress.XtraBars.BarButtonItem()
            Me.biShowList = New DevExpress.XtraBars.BarCheckItem()
            Me.biMap = New DevExpress.XtraBars.BarButtonItem()
            Me.biNewSubItem = New DevExpress.XtraBars.BarSubItem()
            Me.bmiNewOrder = New DevExpress.XtraBars.BarButtonItem()
            Me.bmiNewGroup = New DevExpress.XtraBars.BarButtonItem()
            Me.biChangeViewSubItem = New DevExpress.XtraBars.BarSubItem()
            Me.bmiShowList = New DevExpress.XtraBars.BarCheckItem()
            Me.biDataPaneSubItem = New DevExpress.XtraBars.BarSubItem()
            Me.bmiHorizontalLayout = New DevExpress.XtraBars.BarCheckItem()
            Me.bmiVerticalLayout = New DevExpress.XtraBars.BarCheckItem()
            Me.bmiHideDetail = New DevExpress.XtraBars.BarCheckItem()
            Me.biResetView = New DevExpress.XtraBars.BarButtonItem()
            Me.biPrintSubItem = New DevExpress.XtraBars.BarSubItem()
            Me.bmiPrintInvoice = New DevExpress.XtraBars.BarButtonItem()
            Me.bmiPrintSalesSummary = New DevExpress.XtraBars.BarButtonItem()
            Me.bmiPrintSalesAnalysis = New DevExpress.XtraBars.BarButtonItem()
            Me.biEdit = New DevExpress.XtraBars.BarButtonItem()
            Me.galleryQuickReports = New DevExpress.XtraBars.RibbonGalleryBarItem()
            Me.biViewSettings = New DevExpress.XtraBars.BarButtonItem()
            Me.biReverseSort = New DevExpress.XtraBars.BarButtonItem()
            Me.biAddColumns = New DevExpress.XtraBars.BarCheckItem()
            Me.biExpandCollapse = New DevExpress.XtraBars.BarButtonItem()
            Me.biNewCustomFilter = New DevExpress.XtraBars.BarButtonItem()
            Me.hiItemsCount = New DevExpress.XtraBars.BarHeaderItem()
            Me.ribbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
            Me.ribbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            Me.ribbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            Me.ribbonPageGroup3 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            Me.ribbonPageGroup8 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            Me.ribbonPageGroup4 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            Me.ribbonPageGroup6 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            Me.ribbonPage2 = New DevExpress.XtraBars.Ribbon.RibbonPage()
            Me.ribbonPageGroup5 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            Me.ribbonPageGroup7 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            Me.ribbonPageGroup9 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            Me.ribbonStatusBar = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
            CType(Me.mvvmContext, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gridViewOrderItems, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gridControl, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.bindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gridView, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.modueLayout, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.modueLayout.SuspendLayout()
            CType(Me.pnlView, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.masterItem, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.detailItem, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.splitterItem, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ribbonControl, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            Me.gridViewOrderItems.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() { Me.colProduct, Me.colProductUnits, Me.colProductPrice, Me.colDiscount, Me.colTotal, Me.colId})
            Me.gridViewOrderItems.GridControl = Me.gridControl
            Me.gridViewOrderItems.Name = "gridViewOrderItems"
            Me.gridViewOrderItems.OptionsView.AllowHtmlDrawHeaders = True
            Me.gridViewOrderItems.OptionsView.ShowFooter = True
            Me.gridViewOrderItems.OptionsView.ShowGroupPanel = False
            Me.gridViewOrderItems.OptionsView.ShowIndicator = False
            Me.gridViewOrderItems.OptionsView.ShowVerticalLines = DevExpress.Utils.DefaultBoolean.False
            Me.colProduct.Caption = "<b>PRODUCT</b>"
            Me.colProduct.FieldName = "Product.Name"
            Me.colProduct.Name = "colProduct"
            Me.colProduct.OptionsColumn.AllowFocus = False
            Me.colProduct.Visible = True
            Me.colProduct.VisibleIndex = 0
            Me.colProductUnits.Caption = "UNITS"
            Me.colProductUnits.FieldName = "ProductUnits"
            Me.colProductUnits.Name = "colProductUnits"
            Me.colProductUnits.OptionsColumn.AllowFocus = False
            Me.colProductUnits.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() { New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "ProductUnits", "SUM={0}")})
            Me.colProductUnits.Visible = True
            Me.colProductUnits.VisibleIndex = 1
            Me.colProductPrice.Caption = "UNIT PRICE"
            Me.colProductPrice.DisplayFormat.FormatString = "c"
            Me.colProductPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colProductPrice.FieldName = "ProductPrice"
            Me.colProductPrice.Name = "colProductPrice"
            Me.colProductPrice.OptionsColumn.AllowFocus = False
            Me.colProductPrice.Visible = True
            Me.colProductPrice.VisibleIndex = 2
            Me.colDiscount.Caption = "DISCOUNT"
            Me.colDiscount.DisplayFormat.FormatString = "c"
            Me.colDiscount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colDiscount.FieldName = "Discount"
            Me.colDiscount.Name = "colDiscount"
            Me.colDiscount.OptionsColumn.AllowFocus = False
            Me.colDiscount.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() { New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Average, "Discount", "AVG={0:c}")})
            Me.colDiscount.Visible = True
            Me.colDiscount.VisibleIndex = 3
            Me.colTotal.Caption = "TOTAL"
            Me.colTotal.DisplayFormat.FormatString = "c"
            Me.colTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colTotal.FieldName = "Total"
            Me.colTotal.Name = "colTotal"
            Me.colTotal.OptionsColumn.AllowFocus = False
            Me.colTotal.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() { New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Total", "SUM={0:c}")})
            Me.colTotal.Visible = True
            Me.colTotal.VisibleIndex = 4
            Me.colId.FieldName = "Id"
            Me.colId.Name = "colId"
            Me.colId.OptionsColumn.AllowFocus = False
            Me.gridControl.DataSource = Me.bindingSource
            gridLevelNode1.LevelTemplate = Me.gridViewOrderItems
            gridLevelNode1.RelationName = "OrderItems"
            Me.gridControl.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() { gridLevelNode1})
            Me.gridControl.Location = New System.Drawing.Point(4, 12)
            Me.gridControl.MainView = Me.gridView
            Me.gridControl.Margin = New System.Windows.Forms.Padding(12)
            Me.gridControl.Name = "gridControl"
            Me.gridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() { Me.repositoryItemMemoEdit1})
            Me.gridControl.ShowOnlyPredefinedDetails = True
            Me.gridControl.Size = New System.Drawing.Size(782, 539)
            Me.gridControl.TabIndex = 1
            Me.gridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.gridView, Me.gridViewOrderItems})
            Me.bindingSource.DataSource = GetType(DevExpress.DevAV.Order)
            Me.gridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() { Me.colInvoiceNumber, Me.colOrderDate, Me.colTotalAmount, Me.colStore, Me.colCustomer, Me.colShipDate1, Me.colShippingAmount})
            Me.gridView.DetailVerticalIndent = 20
            gridFormatRule1.Column = Me.colTotalAmount
            gridFormatRule1.Name = "Format0"
            formatConditionRuleDataBar1.PredefinedName = "Mint Gradient"
            gridFormatRule1.Rule = formatConditionRuleDataBar1
            Me.gridView.FormatRules.Add(gridFormatRule1)
            Me.gridView.GridControl = Me.gridControl
            Me.gridView.Name = "gridView"
            Me.gridView.OptionsBehavior.AutoExpandAllGroups = True
            Me.gridView.OptionsBehavior.Editable = False
            Me.gridView.OptionsBehavior.ReadOnly = True
            Me.gridView.OptionsDetail.AllowZoomDetail = False
            Me.gridView.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Embedded
            Me.gridView.OptionsDetail.ShowDetailTabs = False
            Me.gridView.OptionsDetail.SmartDetailExpandButtonMode = DevExpress.XtraGrid.Views.Grid.DetailExpandButtonMode.AlwaysEnabled
            Me.gridView.OptionsDetail.SmartDetailHeight = True
            Me.gridView.OptionsFind.AlwaysVisible = True
            Me.gridView.OptionsFind.FindNullPrompt = "Search Orders (Ctrl + F)"
            Me.gridView.OptionsFind.ShowClearButton = False
            Me.gridView.OptionsFind.ShowFindButton = False
            Me.gridView.OptionsView.ShowGroupPanel = False
            Me.gridView.OptionsView.ShowVerticalLines = DevExpress.Utils.DefaultBoolean.False
            Me.gridView.OptionsBehavior.AllowPixelScrolling = Utils.DefaultBoolean.False
            Me.gridView.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() { New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colOrderDate, DevExpress.Data.ColumnSortOrder.Ascending)})
            Me.colInvoiceNumber.Caption = "INVOICE #"
            Me.colInvoiceNumber.FieldName = "InvoiceNumber"
            Me.colInvoiceNumber.Name = "colInvoiceNumber"
            Me.colInvoiceNumber.OptionsColumn.AllowFocus = False
            Me.colInvoiceNumber.Visible = True
            Me.colInvoiceNumber.VisibleIndex = 0
            Me.colInvoiceNumber.Width = 106
            Me.colOrderDate.Caption = "ORDER DATE"
            Me.colOrderDate.FieldName = "OrderDate"
            Me.colOrderDate.Name = "colOrderDate"
            Me.colOrderDate.OptionsColumn.AllowFocus = False
            Me.colOrderDate.Visible = True
            Me.colOrderDate.VisibleIndex = 1
            Me.colOrderDate.Width = 133
            Me.colTotalAmount.Caption = "ORDER TOTAL"
            Me.colTotalAmount.DisplayFormat.FormatString = "c"
            Me.colTotalAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colTotalAmount.FieldName = "TotalAmount"
            Me.colTotalAmount.Name = "colTotalAmount"
            Me.colTotalAmount.OptionsColumn.AllowFocus = False
            Me.colTotalAmount.Visible = True
            Me.colTotalAmount.VisibleIndex = 4
            Me.colTotalAmount.Width = 149
            Me.colStore.Caption = "STORE"
            Me.colStore.FieldName = "Store.CrestCity"
            Me.colStore.Name = "colStore"
            Me.colStore.OptionsColumn.AllowFocus = False
            Me.colStore.Visible = True
            Me.colStore.VisibleIndex = 3
            Me.colStore.Width = 180
            Me.colCustomer.Caption = "COMPANY"
            Me.colCustomer.FieldName = "Customer.Name"
            Me.colCustomer.Name = "colCustomer"
            Me.colCustomer.OptionsColumn.AllowFocus = False
            Me.colCustomer.Visible = True
            Me.colCustomer.VisibleIndex = 2
            Me.colCustomer.Width = 191
            Me.colShipDate1.Caption = "SHIP DATE"
            Me.colShipDate1.FieldName = "ShipDate"
            Me.colShipDate1.Name = "colShipDate1"
            Me.colShipDate1.OptionsColumn.AllowFocus = False
            Me.colShippingAmount.Caption = "SHIPPING AMOUNT"
            Me.colShippingAmount.DisplayFormat.FormatString = "c"
            Me.colShippingAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colShippingAmount.FieldName = "ShippingAmount"
            Me.colShippingAmount.Name = "colShippingAmount"
            Me.colShippingAmount.OptionsColumn.AllowFocus = False
            Me.repositoryItemMemoEdit1.Name = "repositoryItemMemoEdit1"
            Me.modueLayout.AllowCustomization = False
            Me.modueLayout.Controls.Add(Me.pnlView)
            Me.modueLayout.Controls.Add(Me.gridControl)
            Me.modueLayout.Dock = System.Windows.Forms.DockStyle.Fill
            Me.modueLayout.Location = New System.Drawing.Point(0, 141)
            Me.modueLayout.Name = "modueLayout"
            Me.modueLayout.Root = Me.layoutControlGroup1
            Me.modueLayout.Size = New System.Drawing.Size(1273, 563)
            Me.modueLayout.TabIndex = 5
            Me.modueLayout.Text = "modueLayout"
            Me.pnlView.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.pnlView.Location = New System.Drawing.Point(795, 12)
            Me.pnlView.Name = "pnlView"
            Me.pnlView.Size = New System.Drawing.Size(466, 539)
            Me.pnlView.TabIndex = 4
            Me.layoutControlGroup1.CustomizationFormText = "Root"
            Me.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True
            Me.layoutControlGroup1.GroupBordersVisible = False
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.masterItem, Me.detailItem, Me.splitterItem})
            Me.layoutControlGroup1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup1.Name = "Root"
            Me.layoutControlGroup1.Padding = New DevExpress.XtraLayout.Utils.Padding(2, 10, 10, 10)
            Me.layoutControlGroup1.Size = New System.Drawing.Size(1273, 563)
            Me.layoutControlGroup1.TextVisible = False
            Me.masterItem.Control = Me.gridControl
            Me.masterItem.CustomizationFormText = "masterItem"
            Me.masterItem.Location = New System.Drawing.Point(0, 0)
            Me.masterItem.Name = "masterItem"
            Me.masterItem.Size = New System.Drawing.Size(786, 543)
            Me.masterItem.TextSize = New System.Drawing.Size(0, 0)
            Me.masterItem.TextVisible = False
            Me.detailItem.Control = Me.pnlView
            Me.detailItem.CustomizationFormText = "detailItem"
            Me.detailItem.Location = New System.Drawing.Point(791, 0)
            Me.detailItem.Name = "detailItem"
            Me.detailItem.Size = New System.Drawing.Size(470, 543)
            Me.detailItem.TextSize = New System.Drawing.Size(0, 0)
            Me.detailItem.TextVisible = False
            Me.splitterItem.AllowHotTrack = True
            Me.splitterItem.CustomizationFormText = "splitterItem1"
            Me.splitterItem.Location = New System.Drawing.Point(786, 0)
            Me.splitterItem.Name = "splitterItem1"
            Me.splitterItem.Size = New System.Drawing.Size(5, 543)
            Me.ribbonControl.ExpandCollapseItem.Id = 0
            Me.ribbonControl.Items.AddRange(New DevExpress.XtraBars.BarItem() { Me.ribbonControl.ExpandCollapseItem, Me.biNewOrder, Me.biNewGroup, Me.biDelete, Me.biShowList, Me.biMap, Me.biNewSubItem, Me.biChangeViewSubItem, Me.biDataPaneSubItem, Me.bmiHideDetail, Me.bmiHorizontalLayout, Me.bmiVerticalLayout, Me.biResetView, Me.bmiShowList, Me.bmiNewOrder, Me.bmiNewGroup, Me.biPrintSubItem, Me.bmiPrintInvoice, Me.biEdit, Me.galleryQuickReports, Me.biViewSettings, Me.biReverseSort, Me.biAddColumns, Me.biExpandCollapse, Me.biNewCustomFilter, Me.bmiPrintSalesSummary, Me.bmiPrintSalesAnalysis, Me.hiItemsCount})
            Me.ribbonControl.Location = New System.Drawing.Point(0, 0)
            Me.ribbonControl.MaxItemId = 11
            Me.ribbonControl.Name = "ribbonControl"
            Me.ribbonControl.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() { Me.ribbonPage1, Me.ribbonPage2})
            Me.ribbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013
            Me.ribbonControl.Size = New System.Drawing.Size(1273, 141)
            Me.ribbonControl.StatusBar = Me.ribbonStatusBar
            Me.biNewOrder.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False
            Me.biNewOrder.Caption = "New Order"
            Me.biNewOrder.Id = 1
            Me.biNewOrder.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            Me.biNewOrder.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.NewOrder.svg"
            Me.biNewOrder.Name = "biNewOrder"
            Me.biNewGroup.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False
            Me.biNewGroup.Caption = "New Group"
            Me.biNewGroup.Id = 2
            Me.biNewGroup.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            Me.biNewGroup.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.NewGroup.svg"
            Me.biNewGroup.Name = "biNewGroup"
            Me.biDelete.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False
            Me.biDelete.Caption = "Delete"
            Me.biDelete.Id = 3
            Me.biDelete.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            Me.biDelete.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.Delete.svg"
            Me.biDelete.Name = "biDelete"
            Me.biShowList.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False
            Me.biShowList.Caption = "List"
            Me.biShowList.GroupIndex = 1
            Me.biShowList.Id = 4
            Me.biShowList.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            Me.biShowList.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.List.svg"
            Me.biShowList.LargeImageIndex = 37
            Me.biShowList.Name = "biShowList"
            Me.biMap.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False
            Me.biMap.Caption = "Shipping Map"
            Me.biMap.Id = 8
            Me.biMap.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            Me.biMap.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.Mapit.svg"
            Me.biMap.Name = "biMap"
            Me.biNewSubItem.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False
            Me.biNewSubItem.Caption = "New Items"
            Me.biNewSubItem.Id = 10
            Me.biNewSubItem.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            Me.biNewSubItem.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.NewItem.svg"
            Me.biNewSubItem.LargeImageIndex = 29
            Me.biNewSubItem.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {
                New DevExpress.XtraBars.LinkPersistInfo(Me.bmiNewOrder),
                New DevExpress.XtraBars.LinkPersistInfo(Me.bmiNewGroup)
            })
            Me.biNewSubItem.Name = "biNewSubItem"
            Me.biNewSubItem.ShowNavigationHeader = DevExpress.Utils.DefaultBoolean.True
            Me.bmiNewOrder.Caption = "New Order"
            Me.bmiNewOrder.Glyph = My.Resources.icon_new_sales_16
            Me.bmiNewOrder.Id = 11
            Me.bmiNewOrder.Name = "bmiNewOrder"
            Me.bmiNewGroup.Caption = "New Group"
            Me.bmiNewGroup.Glyph = My.Resources.icon_new_group_16
            Me.bmiNewGroup.Id = 12
            Me.bmiNewGroup.Name = "bmiNewGroup"
            Me.biChangeViewSubItem.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False
            Me.biChangeViewSubItem.Caption = "Change View"
            Me.biChangeViewSubItem.Id = 10
            Me.biChangeViewSubItem.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            Me.biChangeViewSubItem.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.ChangeView.svg"
            Me.biChangeViewSubItem.LargeImageIndex = 40
            Me.biChangeViewSubItem.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.bmiShowList)})
            Me.biChangeViewSubItem.Name = "biChangeViewSubItem"
            Me.biChangeViewSubItem.ShowNavigationHeader = DevExpress.Utils.DefaultBoolean.True
            Me.bmiShowList.Caption = "List"
            Me.bmiShowList.Glyph = My.Resources.icon_list_32
            Me.bmiShowList.GroupIndex = 3
            Me.bmiShowList.Id = 4
            Me.bmiShowList.Name = "bmiShowList"
            Me.biDataPaneSubItem.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False
            Me.biDataPaneSubItem.Caption = "Data Pane"
            Me.biDataPaneSubItem.Id = 10
            Me.biDataPaneSubItem.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            Me.biDataPaneSubItem.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.DataPanel.svg"
            Me.biDataPaneSubItem.LargeImageIndex = 41
            Me.biDataPaneSubItem.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {
                New DevExpress.XtraBars.LinkPersistInfo(Me.bmiHorizontalLayout),
                New DevExpress.XtraBars.LinkPersistInfo(Me.bmiVerticalLayout),
                New DevExpress.XtraBars.LinkPersistInfo(Me.bmiHideDetail)
            })
            Me.biDataPaneSubItem.Name = "biDataPaneSubItem"
            Me.biDataPaneSubItem.ShowNavigationHeader = DevExpress.Utils.DefaultBoolean.True
            Me.bmiHorizontalLayout.Caption = "Right"
            Me.bmiHorizontalLayout.GroupIndex = 2
            Me.bmiHorizontalLayout.Id = 6
            Me.bmiHorizontalLayout.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            Me.bmiHorizontalLayout.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.DataPanel.svg?Size=16x16"
            Me.bmiHorizontalLayout.Name = "bmiHorizontalLayout"
            Me.bmiVerticalLayout.Caption = "Bottom"
            Me.bmiVerticalLayout.GroupIndex = 2
            Me.bmiVerticalLayout.Id = 7
            Me.bmiVerticalLayout.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            Me.bmiVerticalLayout.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.PanelBottom.svg?Size=16x16"
            Me.bmiVerticalLayout.Name = "bmiVerticalLayout"
            Me.bmiHideDetail.Caption = "Off"
            Me.bmiHideDetail.GroupIndex = 2
            Me.bmiHideDetail.Id = 7
            Me.bmiHideDetail.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            Me.bmiHideDetail.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.PanelOff.svg?Size=16x16"
            Me.bmiHideDetail.Name = "bmiHideDetail"
            Me.biResetView.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False
            Me.biResetView.Caption = "Reset View"
            Me.biResetView.Id = 9
            Me.biResetView.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            Me.biResetView.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.ResetView.svg"
            Me.biResetView.Name = "biResetView"
            Me.biPrintSubItem.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False
            Me.biPrintSubItem.Caption = "Print"
            Me.biPrintSubItem.Id = 10
            Me.biPrintSubItem.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            Me.biPrintSubItem.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.Print.svg"
            Me.biPrintSubItem.LargeImageIndex = 30
            Me.biPrintSubItem.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {
                New DevExpress.XtraBars.LinkPersistInfo(Me.bmiPrintInvoice),
                New DevExpress.XtraBars.LinkPersistInfo(Me.bmiPrintSalesSummary),
                New DevExpress.XtraBars.LinkPersistInfo(Me.bmiPrintSalesAnalysis)
            })
            Me.biPrintSubItem.Name = "biPrintSubItem"
            Me.biPrintSubItem.ShowNavigationHeader = DevExpress.Utils.DefaultBoolean.True
            Me.bmiPrintInvoice.Caption = "Invoice"
            Me.bmiPrintInvoice.Glyph = My.Resources.icon_sales_invoice_16
            Me.bmiPrintInvoice.GroupIndex = 5
            Me.bmiPrintInvoice.Id = 6
            Me.bmiPrintInvoice.Name = "bmiPrintInvoice"
            Me.bmiPrintSalesSummary.Caption = "Summary Report"
            Me.bmiPrintSalesSummary.Glyph = My.Resources.icon_sales_report_16
            Me.bmiPrintSalesSummary.Id = 9
            Me.bmiPrintSalesSummary.Name = "bmiPrintSalesSummary"
            Me.bmiPrintSalesAnalysis.Caption = "Sales Analisys"
            Me.bmiPrintSalesAnalysis.Glyph = My.Resources.icon_sales_by_store_16
            Me.bmiPrintSalesAnalysis.Id = 10
            Me.bmiPrintSalesAnalysis.Name = "bmiPrintSalesAnalysis"
            Me.biEdit.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False
            Me.biEdit.Caption = "Edit"
            Me.biEdit.Id = 13
            Me.biEdit.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            Me.biEdit.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.Edit.svg"
            Me.biEdit.Name = "biEdit"
            Me.galleryQuickReports.Caption = "ribbonGalleryBarItem1"
            Me.galleryQuickReports.Gallery.ColumnCount = 2
            Me.galleryQuickReports.Gallery.DrawImageBackground = False
            galleryItemGroup1.Caption = "Group1"
            galleryItem1.Caption = "Sales Report"
            galleryItem1.Image = My.Resources.icon_sales_quick_report_16
            galleryItem2.Caption = "Thank You"
            galleryItem2.Image = My.Resources.icon_sales_quick_thankyou_16
            galleryItem3.Caption = "Sales by Store"
            galleryItem3.Image = My.Resources.icon_sales_quick_summary_16
            galleryItem4.Caption = "Invoice"
            galleryItem4.Image = My.Resources.icon_sales_quick_invoice_16
            galleryItemGroup1.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { galleryItem1, galleryItem2, galleryItem3, galleryItem4})
            Me.galleryQuickReports.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() { galleryItemGroup1})
            Me.galleryQuickReports.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Left
            skinPaddingEdges1.Bottom = -3
            skinPaddingEdges1.Top = -3
            Me.galleryQuickReports.Gallery.ItemImagePadding = skinPaddingEdges1
            skinPaddingEdges2.Bottom = -1
            skinPaddingEdges2.Top = -1
            Me.galleryQuickReports.Gallery.ItemTextPadding = skinPaddingEdges2
            Me.galleryQuickReports.Gallery.ShowItemText = True
            Me.galleryQuickReports.Id = 15
            Me.galleryQuickReports.Name = "galleryQuickReports"
            Me.biViewSettings.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False
            Me.biViewSettings.Caption = "View Settings"
            Me.biViewSettings.Id = 3
            Me.biViewSettings.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            Me.biViewSettings.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.ViewSetting.svg"
            Me.biViewSettings.Name = "biViewSettings"
            Me.biReverseSort.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False
            Me.biReverseSort.Caption = "Reverse Sort"
            Me.biReverseSort.Id = 4
            Me.biReverseSort.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            Me.biReverseSort.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.ReversSort.svg?Size=16x16"
            Me.biReverseSort.Name = "biReverseSort"
            Me.biAddColumns.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False
            Me.biAddColumns.Caption = "Add Columns"
            Me.biAddColumns.Id = 5
            Me.biAddColumns.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            Me.biAddColumns.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.AddColumn.svg?Size=16x16"
            Me.biAddColumns.Name = "biAddColumns"
            Me.biExpandCollapse.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False
            Me.biExpandCollapse.Caption = "Expand/Collapse"
            Me.biExpandCollapse.Id = 6
            Me.biExpandCollapse.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            Me.biExpandCollapse.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.ExpandCollapse.svg?Size=16x16"
            Me.biExpandCollapse.Name = "biExpandCollapse"
            Me.biNewCustomFilter.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False
            Me.biNewCustomFilter.Caption = "Custom Filter"
            Me.biNewCustomFilter.Id = 8
            Me.biNewCustomFilter.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            Me.biNewCustomFilter.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.Filter.svg"
            Me.biNewCustomFilter.Name = "biNewCustomFilter"
            Me.hiItemsCount.Caption = "RECORDS: 0"
            Me.hiItemsCount.Id = 7
            Me.hiItemsCount.Name = "hiItemsCount"
            Me.ribbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() { Me.ribbonPageGroup1, Me.ribbonPageGroup2, Me.ribbonPageGroup3, Me.ribbonPageGroup8, Me.ribbonPageGroup4, Me.ribbonPageGroup6})
            Me.ribbonPage1.Name = "ribbonPage1"
            Me.ribbonPage1.Text = "HOME"
            Me.ribbonPageGroup1.AllowTextClipping = False
            Me.ribbonPageGroup1.ItemLinks.Add(Me.biNewOrder)
            Me.ribbonPageGroup1.ItemLinks.Add(Me.biNewGroup)
            Me.ribbonPageGroup1.ItemLinks.Add(Me.biNewSubItem)
            Me.ribbonPageGroup1.MergeOrder = 0
            Me.ribbonPageGroup1.Name = "ribbonPageGroup1"
            Me.ribbonPageGroup1.ShowCaptionButton = False
            Me.ribbonPageGroup1.Text = "New"
            Me.ribbonPageGroup2.AllowTextClipping = False
            Me.ribbonPageGroup2.ItemLinks.Add(Me.biDelete)
            Me.ribbonPageGroup2.MergeOrder = 0
            Me.ribbonPageGroup2.Name = "ribbonPageGroup2"
            Me.ribbonPageGroup2.ShowCaptionButton = False
            Me.ribbonPageGroup2.Text = "Delete"
            Me.ribbonPageGroup3.AllowTextClipping = False
            Me.ribbonPageGroup3.ItemLinks.Add(Me.biEdit)
            Me.ribbonPageGroup3.ItemLinks.Add(Me.biPrintSubItem)
            Me.ribbonPageGroup3.MergeOrder = 0
            Me.ribbonPageGroup3.Name = "ribbonPageGroup3"
            Me.ribbonPageGroup3.ShowCaptionButton = False
            Me.ribbonPageGroup3.Text = "Actions"
            Me.ribbonPageGroup8.AllowTextClipping = False
            Me.ribbonPageGroup8.ItemLinks.Add(Me.galleryQuickReports)
            Me.ribbonPageGroup8.MergeOrder = 0
            Me.ribbonPageGroup8.Name = "ribbonPageGroup8"
            Me.ribbonPageGroup8.ShowCaptionButton = False
            Me.ribbonPageGroup8.Text = "Quick Reports"
            Me.ribbonPageGroup4.AllowTextClipping = False
            Me.ribbonPageGroup4.ItemLinks.Add(Me.biShowList)
            Me.ribbonPageGroup4.ItemLinks.Add(Me.biMap)
            Me.ribbonPageGroup4.MergeOrder = 0
            Me.ribbonPageGroup4.Name = "ribbonPageGroup4"
            Me.ribbonPageGroup4.ShowCaptionButton = False
            Me.ribbonPageGroup4.Text = "View"
            Me.ribbonPageGroup6.AllowTextClipping = False
            Me.ribbonPageGroup6.ItemLinks.Add(Me.biNewCustomFilter)
            Me.ribbonPageGroup6.MergeOrder = 0
            Me.ribbonPageGroup6.Name = "ribbonPageGroup6"
            Me.ribbonPageGroup6.ShowCaptionButton = False
            Me.ribbonPageGroup6.Text = "Find"
            Me.ribbonPage2.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() { Me.ribbonPageGroup5, Me.ribbonPageGroup7, Me.ribbonPageGroup9})
            Me.ribbonPage2.Name = "ribbonPage2"
            Me.ribbonPage2.Text = "VIEW"
            Me.ribbonPageGroup5.AllowTextClipping = False
            Me.ribbonPageGroup5.ItemLinks.Add(Me.biChangeViewSubItem)
            Me.ribbonPageGroup5.ItemLinks.Add(Me.biViewSettings)
            Me.ribbonPageGroup5.ItemLinks.Add(Me.biResetView)
            Me.ribbonPageGroup5.MergeOrder = 0
            Me.ribbonPageGroup5.Name = "ribbonPageGroup5"
            Me.ribbonPageGroup5.ShowCaptionButton = False
            Me.ribbonPageGroup5.Text = "Current View"
            Me.ribbonPageGroup7.AllowTextClipping = False
            Me.ribbonPageGroup7.ItemLinks.Add(Me.biDataPaneSubItem)
            Me.ribbonPageGroup7.MergeOrder = 1
            Me.ribbonPageGroup7.Name = "ribbonPageGroup7"
            Me.ribbonPageGroup7.ShowCaptionButton = False
            Me.ribbonPageGroup7.Text = "Layout"
            Me.ribbonPageGroup9.AllowTextClipping = False
            Me.ribbonPageGroup9.ItemLinks.Add(Me.biReverseSort)
            Me.ribbonPageGroup9.ItemLinks.Add(Me.biAddColumns)
            Me.ribbonPageGroup9.ItemLinks.Add(Me.biExpandCollapse)
            Me.ribbonPageGroup9.MergeOrder = 1
            Me.ribbonPageGroup9.Name = "ribbonPageGroup9"
            Me.ribbonStatusBar.ItemLinks.Add(Me.hiItemsCount)
            Me.ribbonStatusBar.Location = New System.Drawing.Point(0, 704)
            Me.ribbonStatusBar.Name = "ribbonStatusBar"
            Me.ribbonStatusBar.Ribbon = Me.ribbonControl
            Me.ribbonStatusBar.Size = New System.Drawing.Size(1273, 27)
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.modueLayout)
            Me.Controls.Add(Me.ribbonControl)
            Me.Controls.Add(Me.ribbonStatusBar)
            Me.Margin = New System.Windows.Forms.Padding(6)
            Me.Name = "Orders"
            Me.Size = New System.Drawing.Size(1273, 731)
            CType(Me.mvvmContext, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gridViewOrderItems, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gridControl, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.bindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gridView, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.modueLayout, System.ComponentModel.ISupportInitialize).EndInit()
            Me.modueLayout.ResumeLayout(False)
            CType(Me.pnlView, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.masterItem, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.detailItem, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.splitterItem, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ribbonControl, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        #End Region

        Private gridControl As XtraGrid.GridControl
        Private gridView As XtraGrid.Views.Grid.GridView
        Private bindingSource As System.Windows.Forms.BindingSource
        Private modueLayout As XtraLayout.LayoutControl
        Private layoutControlGroup1 As XtraLayout.LayoutControlGroup
        Private masterItem As XtraLayout.LayoutControlItem
        Private pnlView As XtraEditors.PanelControl
        Private detailItem As XtraLayout.LayoutControlItem
        Private splitterItem As XtraLayout.SplitterItem
        Private repositoryItemMemoEdit1 As XtraEditors.Repository.RepositoryItemMemoEdit
        Private colOrderDate As XtraGrid.Columns.GridColumn
        Private colTotalAmount As XtraGrid.Columns.GridColumn
        Private gridViewOrderItems As XtraGrid.Views.Grid.GridView
        Private colProduct As XtraGrid.Columns.GridColumn
        Private colProductUnits As XtraGrid.Columns.GridColumn
        Private colProductPrice As XtraGrid.Columns.GridColumn
        Private colDiscount As XtraGrid.Columns.GridColumn
        Private colTotal As XtraGrid.Columns.GridColumn
        Private colId As XtraGrid.Columns.GridColumn
        Private ribbonControl As XtraBars.Ribbon.RibbonControl
        Private biNewOrder As XtraBars.BarButtonItem
        Private biNewGroup As XtraBars.BarButtonItem
        Private biDelete As XtraBars.BarButtonItem
        Private biShowList As XtraBars.BarCheckItem
        Private biMap As XtraBars.BarButtonItem
        Private biNewSubItem As XtraBars.BarSubItem
        Private bmiNewOrder As XtraBars.BarButtonItem
        Private bmiNewGroup As XtraBars.BarButtonItem
        Private biChangeViewSubItem As XtraBars.BarSubItem
        Private bmiShowList As XtraBars.BarCheckItem
        Private biDataPaneSubItem As XtraBars.BarSubItem
        Private bmiHorizontalLayout As XtraBars.BarCheckItem
        Private bmiVerticalLayout As XtraBars.BarCheckItem
        Private bmiHideDetail As XtraBars.BarCheckItem
        Private biResetView As XtraBars.BarButtonItem
        Private biPrintSubItem As XtraBars.BarSubItem
        Private bmiPrintInvoice As XtraBars.BarButtonItem
        Private bmiPrintSalesSummary As XtraBars.BarButtonItem
        Private bmiPrintSalesAnalysis As XtraBars.BarButtonItem
        Private biEdit As XtraBars.BarButtonItem
        Private galleryQuickReports As XtraBars.RibbonGalleryBarItem
        Private biViewSettings As XtraBars.BarButtonItem
        Private WithEvents biReverseSort As XtraBars.BarButtonItem
        Private WithEvents biAddColumns As XtraBars.BarCheckItem
        Private WithEvents biExpandCollapse As XtraBars.BarButtonItem
        Private ribbonPage1 As XtraBars.Ribbon.RibbonPage
        Private ribbonPageGroup1 As XtraBars.Ribbon.RibbonPageGroup
        Private ribbonPageGroup2 As XtraBars.Ribbon.RibbonPageGroup
        Private ribbonPageGroup3 As XtraBars.Ribbon.RibbonPageGroup
        Private ribbonPageGroup8 As XtraBars.Ribbon.RibbonPageGroup
        Private ribbonPageGroup4 As XtraBars.Ribbon.RibbonPageGroup
        Private ribbonPageGroup6 As XtraBars.Ribbon.RibbonPageGroup
        Private ribbonPage2 As XtraBars.Ribbon.RibbonPage
        Private ribbonPageGroup5 As XtraBars.Ribbon.RibbonPageGroup
        Private ribbonPageGroup7 As XtraBars.Ribbon.RibbonPageGroup
        Private ribbonPageGroup9 As XtraBars.Ribbon.RibbonPageGroup
        Private ribbonStatusBar As XtraBars.Ribbon.RibbonStatusBar
        Private hiItemsCount As XtraBars.BarHeaderItem
        Private colInvoiceNumber As XtraGrid.Columns.GridColumn
        Private colStore As XtraGrid.Columns.GridColumn
        Private colCustomer As XtraGrid.Columns.GridColumn
        Private colShipDate1 As XtraGrid.Columns.GridColumn
        Private colShippingAmount As XtraGrid.Columns.GridColumn
        Private biNewCustomFilter As XtraBars.BarButtonItem
    End Class
End Namespace
