Namespace DevExpress.DevAV.Modules
    Partial Public Class Customers
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
            Dim gridLevelNode2 As New DevExpress.XtraGrid.GridLevelNode()
            Dim galleryItemGroup1 As New DevExpress.XtraBars.Ribbon.GalleryItemGroup()
            Dim galleryItem1 As New DevExpress.XtraBars.Ribbon.GalleryItem()
            Dim galleryItem2 As New DevExpress.XtraBars.Ribbon.GalleryItem()
            Dim galleryItem3 As New DevExpress.XtraBars.Ribbon.GalleryItem()
            Dim skinPaddingEdges1 As New DevExpress.Skins.SkinPaddingEdges()
            Dim skinPaddingEdges2 As New DevExpress.Skins.SkinPaddingEdges()
            Me.lvEmployees = New DevExpress.XtraGrid.Views.Layout.LayoutView()
            Me.colPhoto = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
            Me.layoutViewField_colPhoto = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
            Me.colFullName1 = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
            Me.layoutViewField_colFullName1 = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
            Me.colAddress1 = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
            Me.repositoryItemMemoEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
            Me.layoutViewField_colAddress1 = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
            Me.colEmail1 = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
            Me.layoutViewField_colEmail1 = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
            Me.colMobilePhone = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
            Me.layoutViewField_colMobilePhone = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
            Me.gridControl = New DevExpress.XtraGrid.GridControl()
            Me.bindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.gvOrders = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.colEmployee = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colInvoiceNumber = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colOrderDate = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colShipDate = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colSaleAmount = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colShippingAmount = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colTotalAmount = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.gridView = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.colName = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colAddress = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colCity = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colState = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colZipCode = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colPhone = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colLogo = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colFax = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colWebsite = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colProfile = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colStatus = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colBillingAddress = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colAnnualRevenue = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colTotalEmployees = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colTotalStores = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.ribbonControl = New DevExpress.XtraBars.Ribbon.RibbonControl()
            Me.biNewCustomer = New DevExpress.XtraBars.BarButtonItem()
            Me.biNewGroup = New DevExpress.XtraBars.BarButtonItem()
            Me.biDelete = New DevExpress.XtraBars.BarButtonItem()
            Me.biShowList = New DevExpress.XtraBars.BarCheckItem()
            Me.biShowCard = New DevExpress.XtraBars.BarCheckItem()
            Me.biMap = New DevExpress.XtraBars.BarButtonItem()
            Me.barSubItem1 = New DevExpress.XtraBars.BarSubItem()
            Me.bmiNewCustomer = New DevExpress.XtraBars.BarButtonItem()
            Me.bmiNewGroup = New DevExpress.XtraBars.BarButtonItem()
            Me.biEdit = New DevExpress.XtraBars.BarButtonItem()
            Me.biPrintSubItem = New DevExpress.XtraBars.BarSubItem()
            Me.bmiPrintProfile = New DevExpress.XtraBars.BarButtonItem()
            Me.bmiPrintContactDirectory = New DevExpress.XtraBars.BarButtonItem()
            Me.bmiPrintSalesSummary = New DevExpress.XtraBars.BarButtonItem()
            Me.bmiPrintSalesDetail = New DevExpress.XtraBars.BarButtonItem()
            Me.biSalesAnalysis = New DevExpress.XtraBars.BarButtonItem()
            Me.galleryQuickReports = New DevExpress.XtraBars.RibbonGalleryBarItem()
            Me.biChangeViewSubItem = New DevExpress.XtraBars.BarSubItem()
            Me.bmiShowList = New DevExpress.XtraBars.BarCheckItem()
            Me.bmiShowCard = New DevExpress.XtraBars.BarCheckItem()
            Me.biViewSettings = New DevExpress.XtraBars.BarButtonItem()
            Me.biResetView = New DevExpress.XtraBars.BarButtonItem()
            Me.biDataPaneSubItem = New DevExpress.XtraBars.BarSubItem()
            Me.bmiHorizontalLayout = New DevExpress.XtraBars.BarCheckItem()
            Me.bmiVerticalLayout = New DevExpress.XtraBars.BarCheckItem()
            Me.bmiHideDetail = New DevExpress.XtraBars.BarCheckItem()
            Me.biReverseSort = New DevExpress.XtraBars.BarButtonItem()
            Me.biAddColumns = New DevExpress.XtraBars.BarCheckItem()
            Me.biExpandCollapse = New DevExpress.XtraBars.BarButtonItem()
            Me.hiItemsCount = New DevExpress.XtraBars.BarHeaderItem()
            Me.ribbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
            Me.ribbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            Me.ribbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            Me.ribbonPageGroup3 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            Me.ribbonPageGroup7 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            Me.ribbonPageGroup4 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            Me.ribbonPageGroup6 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            Me.biNewCustomFilter = New DevExpress.XtraBars.BarButtonItem()
            Me.ribbonPage2 = New DevExpress.XtraBars.Ribbon.RibbonPage()
            Me.ribbonPageGroup8 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            Me.ribbonPageGroup5 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            Me.ribbonPageGroup9 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            Me.ribbonStatusBar = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
            Me.layoutView = New DevExpress.XtraGrid.Views.Layout.LayoutView()
            Me.colName1 = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
            Me.layoutViewField_colName1 = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
            Me.colHomeOffice = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
            Me.layoutViewField_colHomeOffice = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
            Me.colBillingAddress1 = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
            Me.layoutViewField_colBillingAddress1 = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
            Me.colImage = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
            Me.layoutViewField_layoutViewColumn1 = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
            Me.layoutViewCard1 = New DevExpress.XtraGrid.Views.Layout.LayoutViewCard()
            Me.layoutViewCard2 = New DevExpress.XtraGrid.Views.Layout.LayoutViewCard()
            Me.Item1 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.moduleLayout = New DevExpress.XtraLayout.LayoutControl()
            Me.pnlView = New DevExpress.XtraEditors.PanelControl()
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.detailItem = New DevExpress.XtraLayout.LayoutControlItem()
            Me.splitterItem = New DevExpress.XtraLayout.SplitterItem()
            CType(Me.mvvmContext, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.lvEmployees, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutViewField_colPhoto, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutViewField_colFullName1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutViewField_colAddress1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutViewField_colEmail1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutViewField_colMobilePhone, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gridControl, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.bindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gvOrders, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gridView, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ribbonControl, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutView, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutViewField_colName1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutViewField_colHomeOffice, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutViewField_colBillingAddress1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutViewField_layoutViewColumn1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutViewCard1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutViewCard2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Item1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.moduleLayout, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.moduleLayout.SuspendLayout()
            CType(Me.pnlView, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.detailItem, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.splitterItem, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            Me.lvEmployees.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.lvEmployees.CardCaptionFormat = "{3}"
            Me.lvEmployees.CardHorzInterval = 20
            Me.lvEmployees.CardMinSize = New System.Drawing.Size(300, 180)
            Me.lvEmployees.CardVertInterval = 20
            Me.lvEmployees.Columns.AddRange(New DevExpress.XtraGrid.Columns.LayoutViewColumn() { Me.colPhoto, Me.colFullName1, Me.colAddress1, Me.colEmail1, Me.colMobilePhone})
            Me.lvEmployees.FieldCaptionFormat = "{0}"
            Me.lvEmployees.GridControl = Me.gridControl
            Me.lvEmployees.HiddenItems.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.layoutViewField_colFullName1})
            Me.lvEmployees.Name = "lvEmployees"
            Me.lvEmployees.OptionsBehavior.AllowRuntimeCustomization = False
            Me.lvEmployees.OptionsBehavior.Editable = False
            Me.lvEmployees.OptionsBehavior.ReadOnly = True
            Me.lvEmployees.OptionsFind.AlwaysVisible = True
            Me.lvEmployees.OptionsFind.FindNullPrompt = "Search Employees (Ctrl + F)"
            Me.lvEmployees.OptionsFind.ShowClearButton = False
            Me.lvEmployees.OptionsFind.ShowCloseButton = False
            Me.lvEmployees.OptionsFind.ShowFindButton = False
            Me.lvEmployees.OptionsItemText.TextToControlDistance = 2
            Me.lvEmployees.OptionsView.AllowHotTrackFields = False
            Me.lvEmployees.OptionsView.FocusRectStyle = DevExpress.XtraGrid.Views.Layout.FocusRectStyle.None
            Me.lvEmployees.OptionsView.ShowHeaderPanel = False
            Me.lvEmployees.OptionsView.ViewMode = DevExpress.XtraGrid.Views.Layout.LayoutViewMode.Row
            Me.lvEmployees.TemplateCard = Me.layoutViewCard2
            Me.colPhoto.CustomizationCaption = "Photo"
            Me.colPhoto.FieldName = "Photo"
            Me.colPhoto.LayoutViewField = Me.layoutViewField_colPhoto
            Me.colPhoto.Name = "colPhoto"
            Me.colPhoto.OptionsColumn.AllowEdit = False
            Me.colPhoto.OptionsColumn.AllowFocus = False
            Me.colPhoto.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False
            Me.colPhoto.OptionsFilter.AllowFilter = False
            Me.layoutViewField_colPhoto.EditorPreferredWidth = 106
            Me.layoutViewField_colPhoto.Location = New System.Drawing.Point(0, 0)
            Me.layoutViewField_colPhoto.MaxSize = New System.Drawing.Size(120, 136)
            Me.layoutViewField_colPhoto.MinSize = New System.Drawing.Size(120, 136)
            Me.layoutViewField_colPhoto.Name = "layoutViewField_colPhoto"
            Me.layoutViewField_colPhoto.Padding = New DevExpress.XtraLayout.Utils.Padding(2, 12, 2, 2)
            Me.layoutViewField_colPhoto.Size = New System.Drawing.Size(120, 162)
            Me.layoutViewField_colPhoto.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.layoutViewField_colPhoto.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutViewField_colPhoto.TextVisible = False
            Me.colFullName1.CustomizationCaption = "Full Name"
            Me.colFullName1.FieldName = "FullName"
            Me.colFullName1.LayoutViewField = Me.layoutViewField_colFullName1
            Me.colFullName1.Name = "colFullName1"
            Me.colFullName1.OptionsColumn.AllowFocus = False
            Me.layoutViewField_colFullName1.EditorPreferredWidth = 20
            Me.layoutViewField_colFullName1.Location = New System.Drawing.Point(0, 0)
            Me.layoutViewField_colFullName1.Name = "layoutViewField_colFullName1"
            Me.layoutViewField_colFullName1.Size = New System.Drawing.Size(272, 138)
            Me.layoutViewField_colFullName1.TextSize = New System.Drawing.Size(67, 13)
            Me.colAddress1.Caption = "ADDRESS"
            Me.colAddress1.ColumnEdit = Me.repositoryItemMemoEdit1
            Me.colAddress1.CustomizationCaption = "ADDRESS"
            Me.colAddress1.FieldName = "Address"
            Me.colAddress1.LayoutViewField = Me.layoutViewField_colAddress1
            Me.colAddress1.Name = "colAddress1"
            Me.colAddress1.OptionsColumn.AllowFocus = False
            Me.colAddress1.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False
            Me.colAddress1.OptionsFilter.AllowFilter = False
            Me.repositoryItemMemoEdit1.Name = "repositoryItemMemoEdit1"
            Me.layoutViewField_colAddress1.EditorPreferredWidth = 148
            Me.layoutViewField_colAddress1.Location = New System.Drawing.Point(120, 0)
            Me.layoutViewField_colAddress1.MaxSize = New System.Drawing.Size(152, 62)
            Me.layoutViewField_colAddress1.MinSize = New System.Drawing.Size(152, 62)
            Me.layoutViewField_colAddress1.Name = "layoutViewField_colAddress1"
            Me.layoutViewField_colAddress1.Size = New System.Drawing.Size(152, 62)
            Me.layoutViewField_colAddress1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.layoutViewField_colAddress1.TextLocation = DevExpress.Utils.Locations.Top
            Me.layoutViewField_colAddress1.TextSize = New System.Drawing.Size(46, 13)
            Me.colEmail1.Caption = "EMAIL"
            Me.colEmail1.CustomizationCaption = "EMAIL"
            Me.colEmail1.FieldName = "Email"
            Me.colEmail1.LayoutViewField = Me.layoutViewField_colEmail1
            Me.colEmail1.Name = "colEmail1"
            Me.colEmail1.OptionsColumn.AllowFocus = False
            Me.colEmail1.OptionsFilter.AllowFilter = False
            Me.layoutViewField_colEmail1.EditorPreferredWidth = 148
            Me.layoutViewField_colEmail1.Location = New System.Drawing.Point(120, 62)
            Me.layoutViewField_colEmail1.Name = "layoutViewField_colEmail1"
            Me.layoutViewField_colEmail1.Padding = New DevExpress.XtraLayout.Utils.Padding(2, 2, 8, 2)
            Me.layoutViewField_colEmail1.Size = New System.Drawing.Size(152, 45)
            Me.layoutViewField_colEmail1.TextLocation = DevExpress.Utils.Locations.Top
            Me.layoutViewField_colEmail1.TextSize = New System.Drawing.Size(46, 13)
            Me.colMobilePhone.Caption = "PHONE"
            Me.colMobilePhone.CustomizationCaption = "PHONE"
            Me.colMobilePhone.FieldName = "MobilePhone"
            Me.colMobilePhone.LayoutViewField = Me.layoutViewField_colMobilePhone
            Me.colMobilePhone.Name = "colMobilePhone"
            Me.colMobilePhone.OptionsColumn.AllowFocus = False
            Me.colMobilePhone.OptionsFilter.AllowFilter = False
            Me.layoutViewField_colMobilePhone.EditorPreferredWidth = 148
            Me.layoutViewField_colMobilePhone.Location = New System.Drawing.Point(120, 107)
            Me.layoutViewField_colMobilePhone.Name = "layoutViewField_colMobilePhone"
            Me.layoutViewField_colMobilePhone.Padding = New DevExpress.XtraLayout.Utils.Padding(2, 2, 8, 2)
            Me.layoutViewField_colMobilePhone.Size = New System.Drawing.Size(152, 45)
            Me.layoutViewField_colMobilePhone.TextLocation = DevExpress.Utils.Locations.Top
            Me.layoutViewField_colMobilePhone.TextSize = New System.Drawing.Size(46, 13)
            Me.gridControl.DataSource = Me.bindingSource
            gridLevelNode1.LevelTemplate = Me.lvEmployees
            gridLevelNode1.RelationName = "Employees"
            gridLevelNode2.LevelTemplate = Me.gvOrders
            gridLevelNode2.RelationName = "Orders"
            Me.gridControl.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() { gridLevelNode1, gridLevelNode2})
            Me.gridControl.Location = New System.Drawing.Point(6, 14)
            Me.gridControl.MainView = Me.gridView
            Me.gridControl.Margin = New System.Windows.Forms.Padding(12)
            Me.gridControl.MenuManager = Me.ribbonControl
            Me.gridControl.Name = "gridControl"
            Me.gridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() { Me.repositoryItemMemoEdit1})
            Me.gridControl.ShowOnlyPredefinedDetails = True
            Me.gridControl.Size = New System.Drawing.Size(784, 604)
            Me.gridControl.TabIndex = 1
            Me.gridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.gvOrders, Me.gridView, Me.layoutView, Me.lvEmployees})
            Me.bindingSource.DataSource = GetType(DevExpress.DevAV.Customer)
            Me.gvOrders.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.gvOrders.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() { Me.colEmployee, Me.colInvoiceNumber, Me.colOrderDate, Me.colShipDate, Me.colSaleAmount, Me.colShippingAmount, Me.colTotalAmount})
            Me.gvOrders.GridControl = Me.gridControl
            Me.gvOrders.Name = "gvOrders"
            Me.gvOrders.OptionsView.ShowFooter = True
            Me.gvOrders.OptionsView.ShowGroupPanel = False
            Me.gvOrders.OptionsView.ShowIndicator = False
            Me.gvOrders.OptionsView.ShowVerticalLines = DevExpress.Utils.DefaultBoolean.False
            Me.colEmployee.Caption = "EMPLOYEE"
            Me.colEmployee.FieldName = "Employee.FullName"
            Me.colEmployee.Name = "colEmployee"
            Me.colEmployee.OptionsColumn.AllowFocus = False
            Me.colEmployee.Visible = True
            Me.colEmployee.VisibleIndex = 1
            Me.colEmployee.Width = 317
            Me.colInvoiceNumber.Caption = "INVOICE NUMBER"
            Me.colInvoiceNumber.FieldName = "InvoiceNumber"
            Me.colInvoiceNumber.Name = "colInvoiceNumber"
            Me.colInvoiceNumber.OptionsColumn.AllowFocus = False
            Me.colInvoiceNumber.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() { New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "InvoiceNumber", "{0}")})
            Me.colInvoiceNumber.Visible = True
            Me.colInvoiceNumber.VisibleIndex = 0
            Me.colInvoiceNumber.Width = 161
            Me.colOrderDate.Caption = "ORDER DATE"
            Me.colOrderDate.FieldName = "OrderDate"
            Me.colOrderDate.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.DateRange
            Me.colOrderDate.Name = "colOrderDate"
            Me.colOrderDate.OptionsColumn.AllowFocus = False
            Me.colOrderDate.Visible = True
            Me.colOrderDate.VisibleIndex = 2
            Me.colOrderDate.Width = 161
            Me.colShipDate.Caption = "SHIP DATE"
            Me.colShipDate.FieldName = "ShipDate"
            Me.colShipDate.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.DateRange
            Me.colShipDate.Name = "colShipDate"
            Me.colShipDate.OptionsColumn.AllowFocus = False
            Me.colShipDate.Visible = True
            Me.colShipDate.VisibleIndex = 3
            Me.colShipDate.Width = 161
            Me.colSaleAmount.Caption = "SALE AMOUNT"
            Me.colSaleAmount.DisplayFormat.FormatString = "c"
            Me.colSaleAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colSaleAmount.FieldName = "SaleAmount"
            Me.colSaleAmount.Name = "colSaleAmount"
            Me.colSaleAmount.OptionsColumn.AllowFocus = False
            Me.colSaleAmount.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() { New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "SaleAmount", "SUM={0:c}")})
            Me.colSaleAmount.Visible = True
            Me.colSaleAmount.VisibleIndex = 4
            Me.colSaleAmount.Width = 161
            Me.colShippingAmount.Caption = "SHIPPING AMOUNT"
            Me.colShippingAmount.DisplayFormat.FormatString = "c"
            Me.colShippingAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colShippingAmount.FieldName = "ShippingAmount"
            Me.colShippingAmount.Name = "colShippingAmount"
            Me.colShippingAmount.OptionsColumn.AllowFocus = False
            Me.colShippingAmount.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() { New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "ShippingAmount", "SUM={0:c}")})
            Me.colShippingAmount.Visible = True
            Me.colShippingAmount.VisibleIndex = 5
            Me.colShippingAmount.Width = 161
            Me.colTotalAmount.Caption = "TOTAL AMOUNT"
            Me.colTotalAmount.DisplayFormat.FormatString = "c"
            Me.colTotalAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colTotalAmount.FieldName = "TotalAmount"
            Me.colTotalAmount.Name = "colTotalAmount"
            Me.colTotalAmount.OptionsColumn.AllowFocus = False
            Me.colTotalAmount.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() { New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TotalAmount", "SUM={0:c}")})
            Me.colTotalAmount.Visible = True
            Me.colTotalAmount.VisibleIndex = 6
            Me.colTotalAmount.Width = 167
            Me.gridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() { Me.colName, Me.colAddress, Me.colCity, Me.colState, Me.colZipCode, Me.colPhone, Me.colLogo, Me.colFax, Me.colWebsite, Me.colProfile, Me.colStatus, Me.colBillingAddress, Me.colAnnualRevenue, Me.colTotalEmployees, Me.colTotalStores})
            Me.gridView.DetailVerticalIndent = 10
            Me.gridView.GridControl = Me.gridControl
            Me.gridView.Name = "gridView"
            Me.gridView.OptionsBehavior.AllowPixelScrolling = DevExpress.Utils.DefaultBoolean.False
            Me.gridView.OptionsBehavior.AutoExpandAllGroups = True
            Me.gridView.OptionsBehavior.Editable = False
            Me.gridView.OptionsBehavior.ReadOnly = True
            Me.gridView.OptionsDetail.AllowZoomDetail = False
            Me.gridView.OptionsDetail.SmartDetailExpandButtonMode = DevExpress.XtraGrid.Views.Grid.DetailExpandButtonMode.CheckAllDetails
            Me.gridView.OptionsDetail.SmartDetailHeight = True
            Me.gridView.OptionsFilter.ColumnFilterPopupMode = DevExpress.XtraGrid.Columns.ColumnFilterPopupMode.Excel
            Me.gridView.OptionsFind.AlwaysVisible = True
            Me.gridView.OptionsFind.FindNullPrompt = "Search Customers (Ctrl + F)"
            Me.gridView.OptionsFind.ShowClearButton = False
            Me.gridView.OptionsFind.ShowFindButton = False
            Me.gridView.OptionsSelection.MultiSelect = True
            Me.gridView.OptionsView.ShowGroupPanel = False
            Me.gridView.OptionsView.ShowIndicator = False
            Me.gridView.OptionsView.ShowVerticalLines = DevExpress.Utils.DefaultBoolean.False
            Me.gridView.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() { New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colName, DevExpress.Data.ColumnSortOrder.Ascending)})
            Me.colName.Caption = "CUSTOMER"
            Me.colName.FieldName = "Name"
            Me.colName.Name = "colName"
            Me.colName.OptionsColumn.AllowFocus = False
            Me.colName.Visible = True
            Me.colName.VisibleIndex = 1
            Me.colName.Width = 222
            Me.colAddress.Caption = "ADDRESS"
            Me.colAddress.FieldName = "HomeOffice.Line"
            Me.colAddress.Name = "colAddress"
            Me.colAddress.OptionsColumn.AllowFocus = False
            Me.colAddress.Visible = True
            Me.colAddress.VisibleIndex = 2
            Me.colAddress.Width = 113
            Me.colCity.Caption = "CITY"
            Me.colCity.FieldName = "HomeOffice.City"
            Me.colCity.Name = "colCity"
            Me.colCity.OptionsColumn.AllowFocus = False
            Me.colCity.Visible = True
            Me.colCity.VisibleIndex = 4
            Me.colCity.Width = 71
            Me.colState.Caption = "STATE"
            Me.colState.FieldName = "HomeOffice.State"
            Me.colState.Name = "colState"
            Me.colState.OptionsColumn.AllowFocus = False
            Me.colState.Visible = True
            Me.colState.VisibleIndex = 3
            Me.colState.Width = 68
            Me.colZipCode.Caption = "ZIP CODE"
            Me.colZipCode.FieldName = "HomeOffice.ZipCode"
            Me.colZipCode.Name = "colZipCode"
            Me.colZipCode.OptionsColumn.AllowFocus = False
            Me.colZipCode.Visible = True
            Me.colZipCode.VisibleIndex = 5
            Me.colZipCode.Width = 90
            Me.colPhone.Caption = "PHONE"
            Me.colPhone.FieldName = "Phone"
            Me.colPhone.Name = "colPhone"
            Me.colPhone.OptionsColumn.AllowFocus = False
            Me.colPhone.Visible = True
            Me.colPhone.VisibleIndex = 6
            Me.colPhone.Width = 156
            Me.colLogo.Caption = "LOGO"
            Me.colLogo.FieldName = "Image"
            Me.colLogo.Image = My.Resources.icon_brand_16
            Me.colLogo.ImageAlignment = System.Drawing.StringAlignment.Center
            Me.colLogo.Name = "colLogo"
            Me.colLogo.OptionsColumn.AllowFocus = False
            Me.colLogo.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False
            Me.colLogo.OptionsColumn.AllowSize = False
            Me.colLogo.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False
            Me.colLogo.OptionsColumn.FixedWidth = True
            Me.colLogo.OptionsColumn.ShowCaption = False
            Me.colLogo.OptionsFilter.AllowFilter = False
            Me.colLogo.Visible = True
            Me.colLogo.VisibleIndex = 0
            Me.colLogo.Width = 57
            Me.colFax.Caption = "FAX"
            Me.colFax.FieldName = "Fax"
            Me.colFax.Name = "colFax"
            Me.colFax.OptionsColumn.AllowFocus = False
            Me.colWebsite.Caption = "WEBSITE"
            Me.colWebsite.FieldName = "Website"
            Me.colWebsite.Name = "colWebsite"
            Me.colWebsite.OptionsColumn.AllowFocus = False
            Me.colProfile.Caption = "PROFILE"
            Me.colProfile.FieldName = "Profile"
            Me.colProfile.Name = "colProfile"
            Me.colProfile.OptionsColumn.AllowFocus = False
            Me.colStatus.Caption = "STATUS"
            Me.colStatus.FieldName = "Status"
            Me.colStatus.Name = "colStatus"
            Me.colStatus.OptionsColumn.AllowFocus = False
            Me.colBillingAddress.Caption = "BILLING ADDRESS"
            Me.colBillingAddress.FieldName = "BillingAddress"
            Me.colBillingAddress.Name = "colBillingAddress"
            Me.colBillingAddress.OptionsColumn.AllowFocus = False
            Me.colAnnualRevenue.Caption = "ANNUAL REVENUE"
            Me.colAnnualRevenue.DisplayFormat.FormatString = "{0:c}"
            Me.colAnnualRevenue.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colAnnualRevenue.FieldName = "AnnualRevenue"
            Me.colAnnualRevenue.Name = "colAnnualRevenue"
            Me.colAnnualRevenue.OptionsColumn.AllowFocus = False
            Me.colTotalEmployees.Caption = "TOTAL EMPLOYEES"
            Me.colTotalEmployees.DisplayFormat.FormatString = "{0:n0}"
            Me.colTotalEmployees.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colTotalEmployees.FieldName = "TotalEmployees"
            Me.colTotalEmployees.Name = "colTotalEmployees"
            Me.colTotalEmployees.OptionsColumn.AllowFocus = False
            Me.colTotalStores.Caption = "TOTAL STORES"
            Me.colTotalStores.FieldName = "TotalStores"
            Me.colTotalStores.Name = "colTotalStores"
            Me.colTotalStores.OptionsColumn.AllowFocus = False
            Me.ribbonControl.ExpandCollapseItem.Id = 0
            Me.ribbonControl.Items.AddRange(New DevExpress.XtraBars.BarItem() { Me.ribbonControl.ExpandCollapseItem, Me.biNewCustomer, Me.biNewGroup, Me.biDelete, Me.biShowList, Me.biShowCard, Me.biMap, Me.barSubItem1, Me.bmiNewCustomer, Me.bmiNewGroup, Me.biEdit, Me.biPrintSubItem, Me.biSalesAnalysis, Me.galleryQuickReports, Me.bmiPrintSalesSummary, Me.bmiPrintProfile, Me.bmiPrintContactDirectory, Me.biChangeViewSubItem, Me.biViewSettings, Me.biResetView, Me.biDataPaneSubItem, Me.bmiHorizontalLayout, Me.bmiVerticalLayout, Me.bmiHideDetail, Me.biReverseSort, Me.biAddColumns, Me.biExpandCollapse, Me.bmiShowCard, Me.bmiShowList, Me.bmiPrintSalesDetail, Me.hiItemsCount})
            Me.ribbonControl.Location = New System.Drawing.Point(0, 0)
            Me.ribbonControl.MaxItemId = 36
            Me.ribbonControl.Name = "ribbonControl"
            Me.ribbonControl.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() { Me.ribbonPage1, Me.ribbonPage2})
            Me.ribbonControl.Size = New System.Drawing.Size(1280, 141)
            Me.ribbonControl.StatusBar = Me.ribbonStatusBar
            Me.biNewCustomer.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False
            Me.biNewCustomer.Caption = "New Customer"
            Me.biNewCustomer.Id = 1
            Me.biNewCustomer.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            Me.biNewCustomer.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.NewCustomer.svg"
            Me.biNewCustomer.Name = "biNewCustomer"
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
            Me.biShowList.Name = "biShowList"
            Me.biShowCard.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False
            Me.biShowCard.Caption = "Card"
            Me.biShowCard.GroupIndex = 1
            Me.biShowCard.Id = 5
            Me.biShowCard.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            Me.biShowCard.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.Card.svg"
            Me.biShowCard.Name = "biShowCard"
            Me.biMap.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False
            Me.biMap.Caption = "Sales Map"
            Me.biMap.Id = 8
            Me.biMap.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            Me.biMap.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.Mapit.svg"
            Me.biMap.Name = "biMap"
            Me.barSubItem1.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False
            Me.barSubItem1.Caption = "New Items"
            Me.barSubItem1.Id = 10
            Me.barSubItem1.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            Me.barSubItem1.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.NewItem.svg"
            Me.barSubItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {
                New DevExpress.XtraBars.LinkPersistInfo(Me.bmiNewCustomer),
                New DevExpress.XtraBars.LinkPersistInfo(Me.bmiNewGroup)
            })
            Me.barSubItem1.Name = "barSubItem1"
            Me.barSubItem1.ShowNavigationHeader = DevExpress.Utils.DefaultBoolean.True
            Me.bmiNewCustomer.Caption = "New Customer"
            Me.bmiNewCustomer.Id = 11
            Me.bmiNewCustomer.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            Me.bmiNewCustomer.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.NewCustomer.svg?Size=16x16"
            Me.bmiNewCustomer.Name = "bmiNewCustomer"
            Me.bmiNewGroup.Caption = "New Group"
            Me.bmiNewGroup.Id = 12
            Me.bmiNewGroup.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            Me.bmiNewGroup.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.NewGroup.svg?Size=16x16"
            Me.bmiNewGroup.Name = "bmiNewGroup"
            Me.biEdit.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False
            Me.biEdit.Caption = "Edit"
            Me.biEdit.Id = 13
            Me.biEdit.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            Me.biEdit.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.Edit.svg"
            Me.biEdit.Name = "biEdit"
            Me.biPrintSubItem.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False
            Me.biPrintSubItem.Caption = "Print"
            Me.biPrintSubItem.Id = 15
            Me.biPrintSubItem.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            Me.biPrintSubItem.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.Print.svg"
            Me.biPrintSubItem.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {
                New DevExpress.XtraBars.LinkPersistInfo(Me.bmiPrintProfile),
                New DevExpress.XtraBars.LinkPersistInfo(Me.bmiPrintContactDirectory),
                New DevExpress.XtraBars.LinkPersistInfo(Me.bmiPrintSalesSummary),
                New DevExpress.XtraBars.LinkPersistInfo(Me.bmiPrintSalesDetail)
            })
            Me.biPrintSubItem.Name = "biPrintSubItem"
            Me.biPrintSubItem.ShowNavigationHeader = DevExpress.Utils.DefaultBoolean.True
            Me.bmiPrintProfile.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False
            Me.bmiPrintProfile.Caption = "Customer Profile"
            Me.bmiPrintProfile.Id = 19
            Me.bmiPrintProfile.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            Me.bmiPrintProfile.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.ProfileReport.svg?Size=16x16"
            Me.bmiPrintProfile.Name = "bmiPrintProfile"
            Me.bmiPrintContactDirectory.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False
            Me.bmiPrintContactDirectory.Caption = "Employees"
            Me.bmiPrintContactDirectory.Id = 20
            Me.bmiPrintContactDirectory.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            Me.bmiPrintContactDirectory.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.EmployeeCard.svg?Size=16x16"
            Me.bmiPrintContactDirectory.Name = "bmiPrintContactDirectory"
            Me.bmiPrintSalesSummary.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False
            Me.bmiPrintSalesSummary.Caption = "Sales Summary"
            Me.bmiPrintSalesSummary.Id = 18
            Me.bmiPrintSalesSummary.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            Me.bmiPrintSalesSummary.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.SalesSummary2.svg?Size=16x16"
            Me.bmiPrintSalesSummary.Name = "bmiPrintSalesSummary"
            Me.bmiPrintSalesDetail.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False
            Me.bmiPrintSalesDetail.Caption = "Sales Detail"
            Me.bmiPrintSalesDetail.Id = 34
            Me.bmiPrintSalesDetail.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            Me.bmiPrintSalesDetail.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.SalesInvoise2.svg?Size=16x16"
            Me.bmiPrintSalesDetail.Name = "bmiPrintSalesDetail"
            Me.biSalesAnalysis.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False
            Me.biSalesAnalysis.Caption = "Sales Analysis"
            Me.biSalesAnalysis.Id = 16
            Me.biSalesAnalysis.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            Me.biSalesAnalysis.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.SalesAnalysis.svg"
            Me.biSalesAnalysis.Name = "biSalesAnalysis"
            Me.galleryQuickReports.Caption = "ribbonGalleryBarItem1"
            Me.galleryQuickReports.Gallery.ColumnCount = 2
            Me.galleryQuickReports.Gallery.DrawImageBackground = False
            galleryItemGroup1.Caption = "Group1"
            galleryItem1.Caption = "Sales Report"
            galleryItem1.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            galleryItem1.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.SalesSummary.svg?Size=16x16"
            galleryItem2.Caption = "Locations"
            galleryItem2.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            galleryItem2.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.Mapit.svg?Size=16x16"
            galleryItem3.Caption = "Employees"
            galleryItem3.Image = My.Resources.icon_customer_quick_employees_16
            galleryItemGroup1.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { galleryItem1, galleryItem2, galleryItem3})
            Me.galleryQuickReports.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() { galleryItemGroup1})
            Me.galleryQuickReports.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Left
            skinPaddingEdges1.Bottom = -3
            skinPaddingEdges1.Top = -3
            Me.galleryQuickReports.Gallery.ItemImagePadding = skinPaddingEdges1
            skinPaddingEdges2.Bottom = -1
            skinPaddingEdges2.Top = -1
            Me.galleryQuickReports.Gallery.ItemTextPadding = skinPaddingEdges2
            Me.galleryQuickReports.Gallery.ShowItemText = True
            Me.galleryQuickReports.Id = 17
            Me.galleryQuickReports.Name = "galleryQuickReports"
            Me.biChangeViewSubItem.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False
            Me.biChangeViewSubItem.Caption = "Change View"
            Me.biChangeViewSubItem.Id = 21
            Me.biChangeViewSubItem.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            Me.biChangeViewSubItem.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.ChangeView.svg"
            Me.biChangeViewSubItem.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {
                New DevExpress.XtraBars.LinkPersistInfo(Me.bmiShowList),
                New DevExpress.XtraBars.LinkPersistInfo(Me.bmiShowCard)
            })
            Me.biChangeViewSubItem.Name = "biChangeViewSubItem"
            Me.biChangeViewSubItem.ShowNavigationHeader = DevExpress.Utils.DefaultBoolean.True
            Me.bmiShowList.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False
            Me.bmiShowList.Caption = "List"
            Me.bmiShowList.Id = 33
            Me.bmiShowList.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            Me.bmiShowList.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.List.svg?Size=32x32"
            Me.bmiShowList.Name = "bmiShowList"
            Me.bmiShowCard.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False
            Me.bmiShowCard.Caption = "Card"
            Me.bmiShowCard.Id = 32
            Me.bmiShowCard.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            Me.bmiShowCard.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.Card.svg"
            Me.bmiShowCard.Name = "bmiShowCard"
            Me.biViewSettings.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False
            Me.biViewSettings.Caption = "View Settings"
            Me.biViewSettings.Id = 22
            Me.biViewSettings.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            Me.biViewSettings.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.ViewSetting.svg"
            Me.biViewSettings.Name = "biViewSettings"
            Me.biResetView.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False
            Me.biResetView.Caption = "Reset View"
            Me.biResetView.Id = 23
            Me.biResetView.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            Me.biResetView.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.ResetView.svg"
            Me.biResetView.Name = "biResetView"
            Me.biDataPaneSubItem.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False
            Me.biDataPaneSubItem.Caption = "Data Pane"
            Me.biDataPaneSubItem.Id = 24
            Me.biDataPaneSubItem.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            Me.biDataPaneSubItem.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.DataPanel.svg"
            Me.biDataPaneSubItem.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {
                New DevExpress.XtraBars.LinkPersistInfo(Me.bmiHorizontalLayout),
                New DevExpress.XtraBars.LinkPersistInfo(Me.bmiVerticalLayout),
                New DevExpress.XtraBars.LinkPersistInfo(Me.bmiHideDetail)
            })
            Me.biDataPaneSubItem.Name = "biDataPaneSubItem"
            Me.biDataPaneSubItem.ShowNavigationHeader = DevExpress.Utils.DefaultBoolean.True
            Me.bmiHorizontalLayout.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False
            Me.bmiHorizontalLayout.Caption = "Right"
            Me.bmiHorizontalLayout.Id = 25
            Me.bmiHorizontalLayout.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            Me.bmiHorizontalLayout.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.PanelRight.svg?Size=16x16"
            Me.bmiHorizontalLayout.Name = "bmiHorizontalLayout"
            Me.bmiVerticalLayout.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False
            Me.bmiVerticalLayout.Caption = "Bottom"
            Me.bmiVerticalLayout.Id = 26
            Me.bmiVerticalLayout.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            Me.bmiVerticalLayout.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.PanelBottom.svg?Size=16x16"
            Me.bmiVerticalLayout.Name = "bmiVerticalLayout"
            Me.bmiHideDetail.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False
            Me.bmiHideDetail.Caption = "Off"
            Me.bmiHideDetail.Id = 27
            Me.bmiHideDetail.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            Me.bmiHideDetail.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.PanelOff.svg?Size=16x16"
            Me.bmiHideDetail.Name = "bmiHideDetail"
            Me.biReverseSort.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False
            Me.biReverseSort.Caption = "Reverse Sort"
            Me.biReverseSort.Id = 28
            Me.biReverseSort.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            Me.biReverseSort.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.ReversSort.svg?Size=16x16"
            Me.biReverseSort.Name = "biReverseSort"
            Me.biAddColumns.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False
            Me.biAddColumns.Caption = "Add Columns"
            Me.biAddColumns.Id = 30
            Me.biAddColumns.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            Me.biAddColumns.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.AddColumn.svg?Size=16x16"
            Me.biAddColumns.Name = "biAddColumns"
            Me.biExpandCollapse.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False
            Me.biExpandCollapse.Caption = "Expand/Collapse"
            Me.biExpandCollapse.Id = 31
            Me.biExpandCollapse.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            Me.biExpandCollapse.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.ExpandCollapse.svg?Size=16x16"
            Me.biExpandCollapse.Name = "biExpandCollapse"
            Me.hiItemsCount.Caption = "RECORDS: 0"
            Me.hiItemsCount.Id = 35
            Me.hiItemsCount.Name = "hiItemsCount"
            Me.ribbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() { Me.ribbonPageGroup1, Me.ribbonPageGroup2, Me.ribbonPageGroup3, Me.ribbonPageGroup7, Me.ribbonPageGroup4, Me.ribbonPageGroup6})
            Me.ribbonPage1.Name = "ribbonPage1"
            Me.ribbonPage1.Text = "HOME"
            Me.ribbonPageGroup1.AllowTextClipping = False
            Me.ribbonPageGroup1.ItemLinks.Add(Me.biNewCustomer)
            Me.ribbonPageGroup1.ItemLinks.Add(Me.biNewGroup)
            Me.ribbonPageGroup1.ItemLinks.Add(Me.barSubItem1)
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
            Me.ribbonPageGroup3.ItemLinks.Add(Me.biSalesAnalysis)
            Me.ribbonPageGroup3.MergeOrder = 0
            Me.ribbonPageGroup3.Name = "ribbonPageGroup3"
            Me.ribbonPageGroup3.ShowCaptionButton = False
            Me.ribbonPageGroup3.Text = "Actions"
            Me.ribbonPageGroup7.AllowTextClipping = False
            Me.ribbonPageGroup7.ItemLinks.Add(Me.galleryQuickReports)
            Me.ribbonPageGroup7.MergeOrder = 0
            Me.ribbonPageGroup7.Name = "ribbonPageGroup7"
            Me.ribbonPageGroup7.ShowCaptionButton = False
            Me.ribbonPageGroup7.Text = "Quick Reports"
            Me.ribbonPageGroup4.AllowTextClipping = False
            Me.ribbonPageGroup4.ItemLinks.Add(Me.biShowList)
            Me.ribbonPageGroup4.ItemLinks.Add(Me.biShowCard)
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
            Me.biNewCustomFilter.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False
            Me.biNewCustomFilter.Caption = "Custom Filter"
            Me.biNewCustomFilter.Id = 9
            Me.biNewCustomFilter.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            Me.biNewCustomFilter.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.Filter.svg"
            Me.biNewCustomFilter.Name = "biNewCustomFilter"
            Me.ribbonPage2.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() { Me.ribbonPageGroup8, Me.ribbonPageGroup5, Me.ribbonPageGroup9})
            Me.ribbonPage2.Name = "ribbonPage2"
            Me.ribbonPage2.Text = "VIEW"
            Me.ribbonPageGroup8.AllowTextClipping = False
            Me.ribbonPageGroup8.ItemLinks.Add(Me.biChangeViewSubItem)
            Me.ribbonPageGroup8.ItemLinks.Add(Me.biViewSettings)
            Me.ribbonPageGroup8.ItemLinks.Add(Me.biResetView)
            Me.ribbonPageGroup8.MergeOrder = 0
            Me.ribbonPageGroup8.Name = "ribbonPageGroup8"
            Me.ribbonPageGroup8.ShowCaptionButton = False
            Me.ribbonPageGroup8.Text = "Current View"
            Me.ribbonPageGroup5.AllowTextClipping = False
            Me.ribbonPageGroup5.ItemLinks.Add(Me.biDataPaneSubItem)
            Me.ribbonPageGroup5.MergeOrder = 1
            Me.ribbonPageGroup5.Name = "ribbonPageGroup5"
            Me.ribbonPageGroup5.ShowCaptionButton = False
            Me.ribbonPageGroup5.Text = "Layout"
            Me.ribbonPageGroup9.AllowTextClipping = False
            Me.ribbonPageGroup9.ItemLinks.Add(Me.biReverseSort)
            Me.ribbonPageGroup9.ItemLinks.Add(Me.biAddColumns)
            Me.ribbonPageGroup9.ItemLinks.Add(Me.biExpandCollapse)
            Me.ribbonPageGroup9.MergeOrder = 1
            Me.ribbonPageGroup9.Name = "ribbonPageGroup9"
            Me.ribbonPageGroup9.ShowCaptionButton = False
            Me.ribbonStatusBar.ItemLinks.Add(Me.hiItemsCount)
            Me.ribbonStatusBar.Location = New System.Drawing.Point(0, 773)
            Me.ribbonStatusBar.Name = "ribbonStatusBar"
            Me.ribbonStatusBar.Ribbon = Me.ribbonControl
            Me.ribbonStatusBar.Size = New System.Drawing.Size(1280, 27)
            Me.layoutView.CardCaptionFormat = "{2}"
            Me.layoutView.CardMinSize = New System.Drawing.Size(231, 165)
            Me.layoutView.Columns.AddRange(New DevExpress.XtraGrid.Columns.LayoutViewColumn() { Me.colName1, Me.colHomeOffice, Me.colBillingAddress1, Me.colImage})
            Me.layoutView.FieldCaptionFormat = "{0}"
            Me.layoutView.GridControl = Me.gridControl
            Me.layoutView.HiddenItems.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.layoutViewField_colName1})
            Me.layoutView.Name = "layoutView"
            Me.layoutView.OptionsBehavior.AllowExpandCollapse = False
            Me.layoutView.OptionsBehavior.AllowRuntimeCustomization = False
            Me.layoutView.OptionsBehavior.Editable = False
            Me.layoutView.OptionsBehavior.ReadOnly = True
            Me.layoutView.OptionsMultiRecordMode.MultiRowScrollBarOrientation = DevExpress.XtraGrid.Views.Layout.ScrollBarOrientation.Vertical
            Me.layoutView.OptionsSelection.MultiSelect = True
            Me.layoutView.OptionsView.AllowHotTrackFields = False
            Me.layoutView.OptionsView.FocusRectStyle = DevExpress.XtraGrid.Views.Layout.FocusRectStyle.None
            Me.layoutView.OptionsView.ShowHeaderPanel = False
            Me.layoutView.OptionsView.ViewMode = DevExpress.XtraGrid.Views.Layout.LayoutViewMode.MultiRow
            Me.layoutView.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() { New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colName1, DevExpress.Data.ColumnSortOrder.Ascending)})
            Me.layoutView.TemplateCard = Me.layoutViewCard1
            Me.colName1.FieldName = "Name"
            Me.colName1.LayoutViewField = Me.layoutViewField_colName1
            Me.colName1.Name = "colName1"
            Me.layoutViewField_colName1.EditorPreferredWidth = 20
            Me.layoutViewField_colName1.Location = New System.Drawing.Point(0, 0)
            Me.layoutViewField_colName1.Name = "layoutViewField_colName1"
            Me.layoutViewField_colName1.Size = New System.Drawing.Size(209, 68)
            Me.layoutViewField_colName1.TextSize = New System.Drawing.Size(72, 13)
            Me.colHomeOffice.Caption = "HOME OFFICE"
            Me.colHomeOffice.ColumnEdit = Me.repositoryItemMemoEdit1
            Me.colHomeOffice.FieldName = "HomeOffice"
            Me.colHomeOffice.LayoutViewField = Me.layoutViewField_colHomeOffice
            Me.colHomeOffice.Name = "colHomeOffice"
            Me.colHomeOffice.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False
            Me.colHomeOffice.OptionsFilter.AllowFilter = False
            Me.layoutViewField_colHomeOffice.EditorPreferredWidth = 124
            Me.layoutViewField_colHomeOffice.Location = New System.Drawing.Point(83, 0)
            Me.layoutViewField_colHomeOffice.Name = "layoutViewField_colHomeOffice"
            Me.layoutViewField_colHomeOffice.Size = New System.Drawing.Size(128, 62)
            Me.layoutViewField_colHomeOffice.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
            Me.layoutViewField_colHomeOffice.TextLocation = DevExpress.Utils.Locations.Top
            Me.layoutViewField_colHomeOffice.TextSize = New System.Drawing.Size(87, 13)
            Me.layoutViewField_colHomeOffice.TextToControlDistance = 0
            Me.colBillingAddress1.Caption = "BILLING ADDRESS"
            Me.colBillingAddress1.ColumnEdit = Me.repositoryItemMemoEdit1
            Me.colBillingAddress1.FieldName = "BillingAddress"
            Me.colBillingAddress1.LayoutViewField = Me.layoutViewField_colBillingAddress1
            Me.colBillingAddress1.Name = "colBillingAddress1"
            Me.colBillingAddress1.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False
            Me.colBillingAddress1.OptionsFilter.AllowFilter = False
            Me.layoutViewField_colBillingAddress1.EditorPreferredWidth = 124
            Me.layoutViewField_colBillingAddress1.Location = New System.Drawing.Point(83, 62)
            Me.layoutViewField_colBillingAddress1.Name = "layoutViewField_colBillingAddress1"
            Me.layoutViewField_colBillingAddress1.Size = New System.Drawing.Size(128, 64)
            Me.layoutViewField_colBillingAddress1.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
            Me.layoutViewField_colBillingAddress1.TextLocation = DevExpress.Utils.Locations.Top
            Me.layoutViewField_colBillingAddress1.TextSize = New System.Drawing.Size(87, 13)
            Me.layoutViewField_colBillingAddress1.TextToControlDistance = 0
            Me.colImage.Caption = "IMAGE"
            Me.colImage.FieldName = "Image"
            Me.colImage.LayoutViewField = Me.layoutViewField_layoutViewColumn1
            Me.colImage.Name = "colImage"
            Me.colImage.OptionsColumn.AllowEdit = False
            Me.colImage.OptionsColumn.AllowFocus = False
            Me.colImage.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False
            Me.colImage.OptionsFilter.AllowFilter = False
            Me.layoutViewField_layoutViewColumn1.EditorPreferredWidth = 79
            Me.layoutViewField_layoutViewColumn1.Location = New System.Drawing.Point(0, 0)
            Me.layoutViewField_layoutViewColumn1.Name = "layoutViewField_layoutViewColumn1"
            Me.layoutViewField_layoutViewColumn1.Size = New System.Drawing.Size(83, 126)
            Me.layoutViewField_layoutViewColumn1.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutViewField_layoutViewColumn1.TextVisible = False
            Me.layoutViewCard1.CustomizationFormText = "TemplateCard"
            Me.layoutViewCard1.HeaderButtonsLocation = DevExpress.Utils.GroupElementLocation.AfterText
            Me.layoutViewCard1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.layoutViewField_colHomeOffice, Me.layoutViewField_colBillingAddress1, Me.layoutViewField_layoutViewColumn1})
            Me.layoutViewCard1.Name = "layoutViewTemplateCard"
            Me.layoutViewCard1.OptionsItemText.TextToControlDistance = 5
            Me.layoutViewCard1.Text = "TemplateCard"
            Me.layoutViewCard2.CustomizationFormText = "TemplateCard"
            Me.layoutViewCard2.HeaderButtonsLocation = DevExpress.Utils.GroupElementLocation.AfterText
            Me.layoutViewCard2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.layoutViewField_colAddress1, Me.layoutViewField_colEmail1, Me.layoutViewField_colPhoto, Me.layoutViewField_colMobilePhone, Me.Item1})
            Me.layoutViewCard2.Name = "layoutViewCard2"
            Me.layoutViewCard2.OptionsItemText.TextToControlDistance = 2
            Me.layoutViewCard2.Text = "TemplateCard"
            Me.Item1.AllowHotTrack = False
            Me.Item1.CustomizationFormText = "Item1"
            Me.Item1.Location = New System.Drawing.Point(120, 152)
            Me.Item1.Name = "Item1"
            Me.Item1.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.Item1.Size = New System.Drawing.Size(152, 10)
            Me.Item1.TextSize = New System.Drawing.Size(0, 0)
            Me.moduleLayout.AllowCustomization = False
            Me.moduleLayout.Controls.Add(Me.pnlView)
            Me.moduleLayout.Controls.Add(Me.gridControl)
            Me.moduleLayout.Dock = System.Windows.Forms.DockStyle.Fill
            Me.moduleLayout.Location = New System.Drawing.Point(0, 141)
            Me.moduleLayout.MenuManager = Me.ribbonControl
            Me.moduleLayout.Name = "moduleLayout"
            Me.moduleLayout.Root = Me.layoutControlGroup1
            Me.moduleLayout.Size = New System.Drawing.Size(1280, 632)
            Me.moduleLayout.TabIndex = 5
            Me.moduleLayout.Text = "moduleLayout"
            Me.pnlView.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.pnlView.Location = New System.Drawing.Point(799, 14)
            Me.pnlView.Name = "pnlView"
            Me.pnlView.Size = New System.Drawing.Size(467, 604)
            Me.pnlView.TabIndex = 4
            Me.layoutControlGroup1.CustomizationFormText = "Root"
            Me.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True
            Me.layoutControlGroup1.GroupBordersVisible = False
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.layoutControlItem1, Me.detailItem, Me.splitterItem})
            Me.layoutControlGroup1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup1.Name = "Root"
            Me.layoutControlGroup1.Padding = New DevExpress.XtraLayout.Utils.Padding(4, 12, 12, 12)
            Me.layoutControlGroup1.Size = New System.Drawing.Size(1280, 632)
            Me.layoutControlGroup1.TextVisible = False
            Me.layoutControlItem1.Control = Me.gridControl
            Me.layoutControlItem1.CustomizationFormText = "layoutControlItem1"
            Me.layoutControlItem1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem1.Name = "layoutControlItem1"
            Me.layoutControlItem1.Size = New System.Drawing.Size(788, 608)
            Me.layoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem1.TextVisible = False
            Me.detailItem.Control = Me.pnlView
            Me.detailItem.CustomizationFormText = "detailItem"
            Me.detailItem.Location = New System.Drawing.Point(793, 0)
            Me.detailItem.Name = "detailItem"
            Me.detailItem.Size = New System.Drawing.Size(471, 608)
            Me.detailItem.TextSize = New System.Drawing.Size(0, 0)
            Me.detailItem.TextVisible = False
            Me.splitterItem.AllowHotTrack = True
            Me.splitterItem.CustomizationFormText = "splitterItem"
            Me.splitterItem.Location = New System.Drawing.Point(788, 0)
            Me.splitterItem.Name = "splitterItem"
            Me.splitterItem.Size = New System.Drawing.Size(5, 608)
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.moduleLayout)
            Me.Controls.Add(Me.ribbonControl)
            Me.Controls.Add(Me.ribbonStatusBar)
            Me.Name = "Customers"
            Me.Size = New System.Drawing.Size(1280, 800)
            CType(Me.mvvmContext, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.lvEmployees, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutViewField_colPhoto, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutViewField_colFullName1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutViewField_colAddress1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutViewField_colEmail1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutViewField_colMobilePhone, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gridControl, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.bindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gvOrders, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gridView, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ribbonControl, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutView, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutViewField_colName1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutViewField_colHomeOffice, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutViewField_colBillingAddress1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutViewField_layoutViewColumn1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutViewCard1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutViewCard2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Item1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.moduleLayout, System.ComponentModel.ISupportInitialize).EndInit()
            Me.moduleLayout.ResumeLayout(False)
            CType(Me.pnlView, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.detailItem, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.splitterItem, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        #End Region

        Private ribbonControl As XtraBars.Ribbon.RibbonControl
        Private ribbonStatusBar As XtraBars.Ribbon.RibbonStatusBar
        Private ribbonPage1 As XtraBars.Ribbon.RibbonPage
        Private ribbonPage2 As XtraBars.Ribbon.RibbonPage
        Private ribbonPageGroup1 As XtraBars.Ribbon.RibbonPageGroup
        Private biNewCustomer As XtraBars.BarButtonItem
        Private biNewGroup As XtraBars.BarButtonItem
        Private biNewCustomFilter As XtraBars.BarButtonItem
        Private biDelete As XtraBars.BarButtonItem
        Private ribbonPageGroup2 As XtraBars.Ribbon.RibbonPageGroup
        Private ribbonPageGroup3 As XtraBars.Ribbon.RibbonPageGroup
        Private ribbonPageGroup4 As XtraBars.Ribbon.RibbonPageGroup
        Private ribbonPageGroup5 As XtraBars.Ribbon.RibbonPageGroup
        Private ribbonPageGroup6 As XtraBars.Ribbon.RibbonPageGroup
        Private gridControl As XtraGrid.GridControl
        Private gridView As XtraGrid.Views.Grid.GridView
        Private bindingSource As System.Windows.Forms.BindingSource
        Private biShowList As XtraBars.BarCheckItem
        Private biShowCard As XtraBars.BarCheckItem
        Private biMap As XtraBars.BarButtonItem
        Private barSubItem1 As XtraBars.BarSubItem
        Private bmiNewCustomer As XtraBars.BarButtonItem
        Private bmiNewGroup As XtraBars.BarButtonItem
        Private biEdit As XtraBars.BarButtonItem
        Private layoutView As XtraGrid.Views.Layout.LayoutView
        Private moduleLayout As XtraLayout.LayoutControl
        Private layoutControlGroup1 As XtraLayout.LayoutControlGroup
        Private layoutControlItem1 As XtraLayout.LayoutControlItem
        Private pnlView As XtraEditors.PanelControl
        Private detailItem As XtraLayout.LayoutControlItem
        Private splitterItem As XtraLayout.SplitterItem
        Private colName1 As XtraGrid.Columns.LayoutViewColumn
        Private colBillingAddress1 As XtraGrid.Columns.LayoutViewColumn
        Private colHomeOffice As XtraGrid.Columns.LayoutViewColumn
        Private colName As XtraGrid.Columns.GridColumn
        Private WithEvents lvEmployees As XtraGrid.Views.Layout.LayoutView
        Private gvOrders As XtraGrid.Views.Grid.GridView
        Private colPhoto As XtraGrid.Columns.LayoutViewColumn
        Private colFullName1 As XtraGrid.Columns.LayoutViewColumn
        Private colAddress1 As XtraGrid.Columns.LayoutViewColumn
        Private colEmail1 As XtraGrid.Columns.LayoutViewColumn
        Private colMobilePhone As XtraGrid.Columns.LayoutViewColumn
        Private colAddress As XtraGrid.Columns.GridColumn
        Private colPhone As XtraGrid.Columns.GridColumn
        Private colCity As XtraGrid.Columns.GridColumn
        Private colState As XtraGrid.Columns.GridColumn
        Private colZipCode As XtraGrid.Columns.GridColumn
        Private colInvoiceNumber As XtraGrid.Columns.GridColumn
        Private colEmployee As XtraGrid.Columns.GridColumn
        Private colOrderDate As XtraGrid.Columns.GridColumn
        Private colShipDate As XtraGrid.Columns.GridColumn
        Private colSaleAmount As XtraGrid.Columns.GridColumn
        Private colShippingAmount As XtraGrid.Columns.GridColumn
        Private colTotalAmount As XtraGrid.Columns.GridColumn
        Private repositoryItemMemoEdit1 As XtraEditors.Repository.RepositoryItemMemoEdit
        Private biPrintSubItem As XtraBars.BarSubItem
        Private biSalesAnalysis As XtraBars.BarButtonItem
        Private galleryQuickReports As XtraBars.RibbonGalleryBarItem
        Private ribbonPageGroup7 As XtraBars.Ribbon.RibbonPageGroup
        Private bmiPrintSalesSummary As XtraBars.BarButtonItem
        Private bmiPrintProfile As XtraBars.BarButtonItem
        Private bmiPrintContactDirectory As XtraBars.BarButtonItem
        Private ribbonPageGroup8 As XtraBars.Ribbon.RibbonPageGroup
        Private biChangeViewSubItem As XtraBars.BarSubItem
        Private biViewSettings As XtraBars.BarButtonItem
        Private biResetView As XtraBars.BarButtonItem
        Private biDataPaneSubItem As XtraBars.BarSubItem
        Private bmiHorizontalLayout As XtraBars.BarCheckItem
        Private bmiVerticalLayout As XtraBars.BarCheckItem
        Private bmiHideDetail As XtraBars.BarCheckItem
        Private WithEvents biReverseSort As XtraBars.BarButtonItem
        Private WithEvents biAddColumns As XtraBars.BarCheckItem
        Private WithEvents biExpandCollapse As XtraBars.BarButtonItem
        Private ribbonPageGroup9 As XtraBars.Ribbon.RibbonPageGroup
        Private bmiShowList As XtraBars.BarCheckItem
        Private bmiShowCard As XtraBars.BarCheckItem
        Private bmiPrintSalesDetail As XtraBars.BarButtonItem
        Private hiItemsCount As XtraBars.BarHeaderItem
        Private colLogo As XtraGrid.Columns.GridColumn
        Private colFax As XtraGrid.Columns.GridColumn
        Private colWebsite As XtraGrid.Columns.GridColumn
        Private colProfile As XtraGrid.Columns.GridColumn
        Private colStatus As XtraGrid.Columns.GridColumn
        Private colBillingAddress As XtraGrid.Columns.GridColumn
        Private colAnnualRevenue As XtraGrid.Columns.GridColumn
        Private colTotalEmployees As XtraGrid.Columns.GridColumn
        Private colTotalStores As XtraGrid.Columns.GridColumn
        Private colImage As XtraGrid.Columns.LayoutViewColumn
        Private layoutViewField_colName1 As XtraGrid.Views.Layout.LayoutViewField
        Private layoutViewField_colHomeOffice As XtraGrid.Views.Layout.LayoutViewField
        Private layoutViewField_colBillingAddress1 As XtraGrid.Views.Layout.LayoutViewField
        Private layoutViewField_layoutViewColumn1 As XtraGrid.Views.Layout.LayoutViewField
        Private layoutViewCard1 As XtraGrid.Views.Layout.LayoutViewCard
        Private layoutViewField_colPhoto As XtraGrid.Views.Layout.LayoutViewField
        Private layoutViewField_colFullName1 As XtraGrid.Views.Layout.LayoutViewField
        Private layoutViewField_colAddress1 As XtraGrid.Views.Layout.LayoutViewField
        Private layoutViewField_colEmail1 As XtraGrid.Views.Layout.LayoutViewField
        Private layoutViewField_colMobilePhone As XtraGrid.Views.Layout.LayoutViewField
        Private layoutViewCard2 As XtraGrid.Views.Layout.LayoutViewCard
        Private Item1 As XtraLayout.EmptySpaceItem
    End Class
End Namespace
