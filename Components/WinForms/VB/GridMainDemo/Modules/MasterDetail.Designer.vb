Imports DevExpress.Export

Namespace DevExpress.XtraGrid.Demos
    Partial Public Class MasterDetail
        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing Then
                If components IsNot Nothing Then
                    components.Dispose()
                End If
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(MasterDetail))
            Dim styleFormatCondition1 As New DevExpress.XtraGrid.StyleFormatCondition()
            Dim gridLevelNode1 As New DevExpress.XtraGrid.GridLevelNode()
            Dim gridLevelNode2 As New DevExpress.XtraGrid.GridLevelNode()
            Dim gridLevelNode3 As New DevExpress.XtraGrid.GridLevelNode()
            Me.colDiscontinued = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.colCategoryID = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.repositoryItemImageComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox()
            Me.colProductID = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colProductName = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colQuantityPerUnit = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colReorderLevel = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.repositoryItemSpinEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
            Me.colUnitPrice = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.repositoryItemCalcEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit()
            Me.colUnitsInStock = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colUnitsOnOrder = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
            Me.dsNWindSupplier1 = New dsNWindSupplier()
            Me.cardView1 = New DevExpress.XtraGrid.Views.Card.CardView()
            Me.colCategoryName = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colPicture = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.repositoryItemImageEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemImageEdit()
            Me.colDescription = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.repositoryItemMemoExEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit()
            Me.colProductName1 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.advBandedGridView1 = New DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView()
            Me.gridBand2 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
            Me.colCompanyName = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.colSupplierID = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.colContactName = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.colContactTitle = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.gridBand1 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
            Me.colRegion = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.repositoryItemComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
            Me.colCountry = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.repositoryItemComboBox2 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
            Me.colCity = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.colPostalCode = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.colAddress = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.colPhone = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.colFax = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.imageList2 = New System.Windows.Forms.ImageList(Me.components)
            Me.gridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.colDiscount = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colOrderID = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colQuantity = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colUnitPrice1 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colSubTotal = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.imageComboBoxEdit1 = New DevExpress.XtraEditors.ImageComboBoxEdit()
            Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
            Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl()
            Me.seVertIndent = New DevExpress.XtraEditors.SpinEdit()
            Me.ceToolTips = New DevExpress.XtraEditors.CheckEdit()
            Me.ceTabs = New DevExpress.XtraEditors.CheckEdit()
            Me.ceMain = New DevExpress.XtraEditors.CheckEdit()
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.emptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.emptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.lciZooming = New DevExpress.XtraLayout.LayoutControlItem()
            Me.lciDetailIndent = New DevExpress.XtraLayout.LayoutControlItem()
            Me.navigationPane1 = New DevExpress.XtraBars.Navigation.NavigationPane()
            Me.navigationPage1 = New DevExpress.XtraBars.Navigation.NavigationPage()
            Me.pnlGrid = New DevExpress.XtraEditors.PanelControl()
            Me.icbDetailMode = New DevExpress.XtraEditors.ImageComboBoxEdit()
            Me.layoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.ceShowEmbeddedDetailIndent = New DevExpress.XtraEditors.CheckEdit()
            Me.layoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.emptySpaceItem3 = New DevExpress.XtraLayout.EmptySpaceItem()
            DirectCast(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.repositoryItemImageComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.repositoryItemSpinEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.repositoryItemCalcEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.dsNWindSupplier1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.cardView1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.repositoryItemImageEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.repositoryItemMemoExEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.advBandedGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.repositoryItemComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.repositoryItemComboBox2, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.gridView2, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.imageComboBoxEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl1.SuspendLayout()
            DirectCast(Me.seVertIndent.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.ceToolTips.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.ceTabs.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.ceMain.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.emptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.emptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.lciZooming, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.lciDetailIndent, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.navigationPane1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.navigationPane1.SuspendLayout()
            Me.navigationPage1.SuspendLayout()
            DirectCast(Me.pnlGrid, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.pnlGrid.SuspendLayout()
            DirectCast(Me.icbDetailMode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.ceShowEmbeddedDetailIndent.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.emptySpaceItem3, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' colDiscontinued
            ' 
            resources.ApplyResources(Me.colDiscontinued, "colDiscontinued")
            Me.colDiscontinued.FieldName = "Discontinued"
            Me.colDiscontinued.Name = "colDiscontinued"
            ' 
            ' gridView1
            ' 
            Me.gridView1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            resources.ApplyResources(Me.gridView1, "gridView1")
            Me.gridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() { Me.colCategoryID, Me.colDiscontinued, Me.colProductID, Me.colProductName, Me.colQuantityPerUnit, Me.colReorderLevel, Me.colUnitPrice, Me.colUnitsInStock, Me.colUnitsOnOrder})
            Me.gridView1.DetailHeight = 300
            styleFormatCondition1.Appearance.Font = (DirectCast(resources.GetObject("resource.Font"), System.Drawing.Font))
            styleFormatCondition1.Appearance.ForeColor = (DirectCast(resources.GetObject("resource.ForeColor"), System.Drawing.Color))
            styleFormatCondition1.Appearance.Options.UseFont = True
            styleFormatCondition1.Appearance.Options.UseForeColor = True
            styleFormatCondition1.ApplyToRow = True
            styleFormatCondition1.Column = Me.colDiscontinued
            styleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
            styleFormatCondition1.Value1 = True
            Me.gridView1.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() { styleFormatCondition1})
            Me.gridView1.GridControl = Me.gridControl1
            Me.gridView1.Images = Me.imageList2
            Me.gridView1.Name = "gridView1"
            Me.gridView1.OptionsClipboard.ClipboardMode = DevExpress.Export.ClipboardMode.Formatted
            Me.gridView1.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default
            Me.gridView1.OptionsDetail.ShowDetailTabs = False
            Me.gridView1.OptionsView.AllowHtmlDrawHeaders = True
            Me.gridView1.OptionsView.ShowChildrenInGroupPanel = True
            Me.gridView1.OptionsView.ShowGroupPanel = False
            ' 
            ' colCategoryID
            ' 
            resources.ApplyResources(Me.colCategoryID, "colCategoryID")
            Me.colCategoryID.ColumnEdit = Me.repositoryItemImageComboBox1
            Me.colCategoryID.FieldName = "CategoryID"
            Me.colCategoryID.Name = "colCategoryID"
            ' 
            ' repositoryItemImageComboBox1
            ' 
            resources.ApplyResources(Me.repositoryItemImageComboBox1, "repositoryItemImageComboBox1")
            Me.repositoryItemImageComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton((DirectCast(resources.GetObject("repositoryItemImageComboBox1.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines)))})
            Me.repositoryItemImageComboBox1.Items.AddRange(New DevExpress.XtraEditors.Controls.ImageComboBoxItem() {
                New DevExpress.XtraEditors.Controls.ImageComboBoxItem(resources.GetString("repositoryItemImageComboBox1.Items"), (DirectCast(resources.GetObject("repositoryItemImageComboBox1.Items1"), Object)), (DirectCast(resources.GetObject("repositoryItemImageComboBox1.Items2"), Integer))),
                New DevExpress.XtraEditors.Controls.ImageComboBoxItem(resources.GetString("repositoryItemImageComboBox1.Items3"), (DirectCast(resources.GetObject("repositoryItemImageComboBox1.Items4"), Object)), (DirectCast(resources.GetObject("repositoryItemImageComboBox1.Items5"), Integer))),
                New DevExpress.XtraEditors.Controls.ImageComboBoxItem(resources.GetString("repositoryItemImageComboBox1.Items6"), (DirectCast(resources.GetObject("repositoryItemImageComboBox1.Items7"), Object)), (DirectCast(resources.GetObject("repositoryItemImageComboBox1.Items8"), Integer))),
                New DevExpress.XtraEditors.Controls.ImageComboBoxItem(resources.GetString("repositoryItemImageComboBox1.Items9"), (DirectCast(resources.GetObject("repositoryItemImageComboBox1.Items10"), Object)), (DirectCast(resources.GetObject("repositoryItemImageComboBox1.Items11"), Integer))),
                New DevExpress.XtraEditors.Controls.ImageComboBoxItem(resources.GetString("repositoryItemImageComboBox1.Items12"), (DirectCast(resources.GetObject("repositoryItemImageComboBox1.Items13"), Object)), (DirectCast(resources.GetObject("repositoryItemImageComboBox1.Items14"), Integer))),
                New DevExpress.XtraEditors.Controls.ImageComboBoxItem(resources.GetString("repositoryItemImageComboBox1.Items15"), (DirectCast(resources.GetObject("repositoryItemImageComboBox1.Items16"), Object)), (DirectCast(resources.GetObject("repositoryItemImageComboBox1.Items17"), Integer))),
                New DevExpress.XtraEditors.Controls.ImageComboBoxItem(resources.GetString("repositoryItemImageComboBox1.Items18"), (DirectCast(resources.GetObject("repositoryItemImageComboBox1.Items19"), Object)), (DirectCast(resources.GetObject("repositoryItemImageComboBox1.Items20"), Integer))),
                New DevExpress.XtraEditors.Controls.ImageComboBoxItem(resources.GetString("repositoryItemImageComboBox1.Items21"), (DirectCast(resources.GetObject("repositoryItemImageComboBox1.Items22"), Object)), (DirectCast(resources.GetObject("repositoryItemImageComboBox1.Items23"), Integer)))
            })
            Me.repositoryItemImageComboBox1.Name = "repositoryItemImageComboBox1"
            ' 
            ' colProductID
            ' 
            resources.ApplyResources(Me.colProductID, "colProductID")
            Me.colProductID.FieldName = "ProductID"
            Me.colProductID.Name = "colProductID"
            Me.colProductID.OptionsFilter.AllowFilter = False
            ' 
            ' colProductName
            ' 
            resources.ApplyResources(Me.colProductName, "colProductName")
            Me.colProductName.FieldName = "ProductName"
            Me.colProductName.Name = "colProductName"
            ' 
            ' colQuantityPerUnit
            ' 
            resources.ApplyResources(Me.colQuantityPerUnit, "colQuantityPerUnit")
            Me.colQuantityPerUnit.FieldName = "QuantityPerUnit"
            Me.colQuantityPerUnit.Name = "colQuantityPerUnit"
            ' 
            ' colReorderLevel
            ' 
            resources.ApplyResources(Me.colReorderLevel, "colReorderLevel")
            Me.colReorderLevel.ColumnEdit = Me.repositoryItemSpinEdit1
            Me.colReorderLevel.FieldName = "ReorderLevel"
            Me.colReorderLevel.Name = "colReorderLevel"
            ' 
            ' repositoryItemSpinEdit1
            ' 
            resources.ApplyResources(Me.repositoryItemSpinEdit1, "repositoryItemSpinEdit1")
            Me.repositoryItemSpinEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
            Me.repositoryItemSpinEdit1.IsFloatValue = False
            Me.repositoryItemSpinEdit1.Mask.EditMask = resources.GetString("repositoryItemSpinEdit1.Mask.EditMask")
            Me.repositoryItemSpinEdit1.Name = "repositoryItemSpinEdit1"
            ' 
            ' colUnitPrice
            ' 
            resources.ApplyResources(Me.colUnitPrice, "colUnitPrice")
            Me.colUnitPrice.ColumnEdit = Me.repositoryItemCalcEdit1
            Me.colUnitPrice.DisplayFormat.FormatString = "c"
            Me.colUnitPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colUnitPrice.FieldName = "UnitPrice"
            Me.colUnitPrice.Name = "colUnitPrice"
            ' 
            ' repositoryItemCalcEdit1
            ' 
            resources.ApplyResources(Me.repositoryItemCalcEdit1, "repositoryItemCalcEdit1")
            Me.repositoryItemCalcEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton((DirectCast(resources.GetObject("repositoryItemCalcEdit1.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines)))})
            Me.repositoryItemCalcEdit1.Name = "repositoryItemCalcEdit1"
            ' 
            ' colUnitsInStock
            ' 
            resources.ApplyResources(Me.colUnitsInStock, "colUnitsInStock")
            Me.colUnitsInStock.ColumnEdit = Me.repositoryItemSpinEdit1
            Me.colUnitsInStock.FieldName = "UnitsInStock"
            Me.colUnitsInStock.Name = "colUnitsInStock"
            ' 
            ' colUnitsOnOrder
            ' 
            resources.ApplyResources(Me.colUnitsOnOrder, "colUnitsOnOrder")
            Me.colUnitsOnOrder.ColumnEdit = Me.repositoryItemSpinEdit1
            Me.colUnitsOnOrder.FieldName = "UnitsOnOrder"
            Me.colUnitsOnOrder.Name = "colUnitsOnOrder"
            ' 
            ' gridControl1
            ' 
            Me.gridControl1.DataSource = Me.dsNWindSupplier1.Suppliers
            resources.ApplyResources(Me.gridControl1, "gridControl1")
            gridLevelNode1.LevelTemplate = Me.gridView1
            gridLevelNode2.LevelTemplate = Me.gridView2
            gridLevelNode2.RelationName = "ProductsOrder_x0020_Details"
            gridLevelNode1.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() { gridLevelNode2})
            gridLevelNode1.RelationName = "SuppliersProducts"
            gridLevelNode3.LevelTemplate = Me.cardView1
            gridLevelNode3.RelationName = "SuppliersCategoryProducts"
            Me.gridControl1.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() { gridLevelNode1, gridLevelNode3})
            Me.gridControl1.MainView = Me.advBandedGridView1
            Me.gridControl1.Name = "gridControl1"
            Me.gridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() { Me.repositoryItemImageEdit1, Me.repositoryItemMemoExEdit1, Me.repositoryItemImageComboBox1, Me.repositoryItemCalcEdit1, Me.repositoryItemSpinEdit1, Me.repositoryItemComboBox1, Me.repositoryItemComboBox2})
            Me.gridControl1.ShowOnlyPredefinedDetails = True
            Me.gridControl1.UseEmbeddedNavigator = True
            Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.cardView1, Me.advBandedGridView1, Me.gridView2, Me.gridView1})
            ' 
            ' dsNWindSupplier1
            ' 
            Me.dsNWindSupplier1.DataSetName = "dsNWindSupplier"
            Me.dsNWindSupplier1.Locale = New System.Globalization.CultureInfo("en-US")
            Me.dsNWindSupplier1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
            ' 
            ' cardView1
            ' 
            Me.cardView1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            resources.ApplyResources(Me.cardView1, "cardView1")
            Me.cardView1.CardWidth = 250
            Me.cardView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() { Me.colCategoryName, Me.colPicture, Me.colDescription, Me.colProductName1})
            Me.cardView1.DetailHeight = 120
            Me.cardView1.FocusedCardTopFieldIndex = 0
            Me.cardView1.GridControl = Me.gridControl1
            Me.cardView1.MaximumCardColumns = 4
            Me.cardView1.Name = "cardView1"
            Me.cardView1.OptionsView.ShowHorzScrollBar = False
            Me.cardView1.OptionsView.ShowLines = False
            ' 
            ' colCategoryName
            ' 
            resources.ApplyResources(Me.colCategoryName, "colCategoryName")
            Me.colCategoryName.FieldName = "CategoryName"
            Me.colCategoryName.Name = "colCategoryName"
            ' 
            ' colPicture
            ' 
            resources.ApplyResources(Me.colPicture, "colPicture")
            Me.colPicture.ColumnEdit = Me.repositoryItemImageEdit1
            Me.colPicture.FieldName = "Picture"
            Me.colPicture.Name = "colPicture"
            ' 
            ' repositoryItemImageEdit1
            ' 
            resources.ApplyResources(Me.repositoryItemImageEdit1, "repositoryItemImageEdit1")
            Me.repositoryItemImageEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton((DirectCast(resources.GetObject("repositoryItemImageEdit1.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines)))})
            Me.repositoryItemImageEdit1.Name = "repositoryItemImageEdit1"
            ' 
            ' colDescription
            ' 
            resources.ApplyResources(Me.colDescription, "colDescription")
            Me.colDescription.ColumnEdit = Me.repositoryItemMemoExEdit1
            Me.colDescription.FieldName = "Description"
            Me.colDescription.Name = "colDescription"
            ' 
            ' repositoryItemMemoExEdit1
            ' 
            resources.ApplyResources(Me.repositoryItemMemoExEdit1, "repositoryItemMemoExEdit1")
            Me.repositoryItemMemoExEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton((DirectCast(resources.GetObject("repositoryItemMemoExEdit1.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines)))})
            Me.repositoryItemMemoExEdit1.Name = "repositoryItemMemoExEdit1"
            ' 
            ' colProductName1
            ' 
            resources.ApplyResources(Me.colProductName1, "colProductName1")
            Me.colProductName1.FieldName = "ProductName"
            Me.colProductName1.Name = "colProductName1"
            ' 
            ' advBandedGridView1
            ' 
            Me.advBandedGridView1.Bands.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() { Me.gridBand2, Me.gridBand1})
            resources.ApplyResources(Me.advBandedGridView1, "advBandedGridView1")
            Me.advBandedGridView1.Columns.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn() { Me.colAddress, Me.colCity, Me.colCompanyName, Me.colContactName, Me.colContactTitle, Me.colCountry, Me.colFax, Me.colPhone, Me.colPostalCode, Me.colRegion, Me.colSupplierID})
            Me.advBandedGridView1.DetailHeight = 300
            Me.advBandedGridView1.GridControl = Me.gridControl1
            Me.advBandedGridView1.Images = Me.imageList2
            Me.advBandedGridView1.Name = "advBandedGridView1"
            Me.advBandedGridView1.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Embedded
            Me.advBandedGridView1.OptionsDetail.ShowEmbeddedDetailIndent = DevExpress.Utils.DefaultBoolean.True
            Me.advBandedGridView1.OptionsMenu.EnableGroupPanelMenu = False
            Me.advBandedGridView1.OptionsPrint.PrintDetails = True
            Me.advBandedGridView1.OptionsView.AllowHtmlDrawHeaders = True
            Me.advBandedGridView1.OptionsView.ShowChildrenInGroupPanel = True
            Me.advBandedGridView1.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() { New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colRegion, DevExpress.Data.ColumnSortOrder.Ascending)})
            ' 
            ' gridBand2
            ' 
            resources.ApplyResources(Me.gridBand2, "gridBand2")
            Me.gridBand2.Columns.Add(Me.colCompanyName)
            Me.gridBand2.Columns.Add(Me.colSupplierID)
            Me.gridBand2.Columns.Add(Me.colContactName)
            Me.gridBand2.Columns.Add(Me.colContactTitle)
            Me.gridBand2.VisibleIndex = 0
            ' 
            ' colCompanyName
            ' 
            resources.ApplyResources(Me.colCompanyName, "colCompanyName")
            Me.colCompanyName.FieldName = "CompanyName"
            Me.colCompanyName.Name = "colCompanyName"
            ' 
            ' colSupplierID
            ' 
            resources.ApplyResources(Me.colSupplierID, "colSupplierID")
            Me.colSupplierID.FieldName = "SupplierID"
            Me.colSupplierID.Name = "colSupplierID"
            ' 
            ' colContactName
            ' 
            resources.ApplyResources(Me.colContactName, "colContactName")
            Me.colContactName.FieldName = "ContactName"
            Me.colContactName.Image = My.Resources.contact_16x16
            Me.colContactName.Name = "colContactName"
            Me.colContactName.RowIndex = 1
            ' 
            ' colContactTitle
            ' 
            resources.ApplyResources(Me.colContactTitle, "colContactTitle")
            Me.colContactTitle.FieldName = "ContactTitle"
            Me.colContactTitle.Name = "colContactTitle"
            Me.colContactTitle.RowIndex = 1
            ' 
            ' gridBand1
            ' 
            resources.ApplyResources(Me.gridBand1, "gridBand1")
            Me.gridBand1.Columns.Add(Me.colRegion)
            Me.gridBand1.Columns.Add(Me.colCountry)
            Me.gridBand1.Columns.Add(Me.colCity)
            Me.gridBand1.Columns.Add(Me.colPostalCode)
            Me.gridBand1.Columns.Add(Me.colAddress)
            Me.gridBand1.Columns.Add(Me.colPhone)
            Me.gridBand1.Columns.Add(Me.colFax)
            Me.gridBand1.Image = (DirectCast(resources.GetObject("gridBand1.Image"), System.Drawing.Image))
            Me.gridBand1.VisibleIndex = 1
            ' 
            ' colRegion
            ' 
            resources.ApplyResources(Me.colRegion, "colRegion")
            Me.colRegion.ColumnEdit = Me.repositoryItemComboBox1
            Me.colRegion.FieldName = "Region"
            Me.colRegion.Name = "colRegion"
            ' 
            ' repositoryItemComboBox1
            ' 
            resources.ApplyResources(Me.repositoryItemComboBox1, "repositoryItemComboBox1")
            Me.repositoryItemComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton((DirectCast(resources.GetObject("repositoryItemComboBox1.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines)))})
            Me.repositoryItemComboBox1.Items.AddRange(New Object() { resources.GetString("repositoryItemComboBox1.Items"), resources.GetString("repositoryItemComboBox1.Items1"), resources.GetString("repositoryItemComboBox1.Items2"), resources.GetString("repositoryItemComboBox1.Items3"), resources.GetString("repositoryItemComboBox1.Items4"), resources.GetString("repositoryItemComboBox1.Items5"), resources.GetString("repositoryItemComboBox1.Items6"), resources.GetString("repositoryItemComboBox1.Items7"), resources.GetString("repositoryItemComboBox1.Items8"), resources.GetString("repositoryItemComboBox1.Items9"), resources.GetString("repositoryItemComboBox1.Items10"), resources.GetString("repositoryItemComboBox1.Items11"), resources.GetString("repositoryItemComboBox1.Items12"), resources.GetString("repositoryItemComboBox1.Items13"), resources.GetString("repositoryItemComboBox1.Items14"), resources.GetString("repositoryItemComboBox1.Items15"), resources.GetString("repositoryItemComboBox1.Items16"), resources.GetString("repositoryItemComboBox1.Items17"), resources.GetString("repositoryItemComboBox1.Items18")})
            Me.repositoryItemComboBox1.Name = "repositoryItemComboBox1"
            ' 
            ' colCountry
            ' 
            resources.ApplyResources(Me.colCountry, "colCountry")
            Me.colCountry.ColumnEdit = Me.repositoryItemComboBox2
            Me.colCountry.FieldName = "Country"
            Me.colCountry.Name = "colCountry"
            ' 
            ' repositoryItemComboBox2
            ' 
            resources.ApplyResources(Me.repositoryItemComboBox2, "repositoryItemComboBox2")
            Me.repositoryItemComboBox2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton((DirectCast(resources.GetObject("repositoryItemComboBox2.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines)))})
            Me.repositoryItemComboBox2.Items.AddRange(New Object() { resources.GetString("repositoryItemComboBox2.Items"), resources.GetString("repositoryItemComboBox2.Items1"), resources.GetString("repositoryItemComboBox2.Items2"), resources.GetString("repositoryItemComboBox2.Items3"), resources.GetString("repositoryItemComboBox2.Items4"), resources.GetString("repositoryItemComboBox2.Items5"), resources.GetString("repositoryItemComboBox2.Items6"), resources.GetString("repositoryItemComboBox2.Items7"), resources.GetString("repositoryItemComboBox2.Items8"), resources.GetString("repositoryItemComboBox2.Items9"), resources.GetString("repositoryItemComboBox2.Items10"), resources.GetString("repositoryItemComboBox2.Items11"), resources.GetString("repositoryItemComboBox2.Items12"), resources.GetString("repositoryItemComboBox2.Items13"), resources.GetString("repositoryItemComboBox2.Items14"), resources.GetString("repositoryItemComboBox2.Items15"), resources.GetString("repositoryItemComboBox2.Items16"), resources.GetString("repositoryItemComboBox2.Items17"), resources.GetString("repositoryItemComboBox2.Items18"), resources.GetString("repositoryItemComboBox2.Items19"), resources.GetString("repositoryItemComboBox2.Items20")})
            Me.repositoryItemComboBox2.Name = "repositoryItemComboBox2"
            ' 
            ' colCity
            ' 
            resources.ApplyResources(Me.colCity, "colCity")
            Me.colCity.FieldName = "City"
            Me.colCity.Name = "colCity"
            ' 
            ' colPostalCode
            ' 
            resources.ApplyResources(Me.colPostalCode, "colPostalCode")
            Me.colPostalCode.FieldName = "PostalCode"
            Me.colPostalCode.Name = "colPostalCode"
            ' 
            ' colAddress
            ' 
            resources.ApplyResources(Me.colAddress, "colAddress")
            Me.colAddress.FieldName = "Address"
            Me.colAddress.Name = "colAddress"
            Me.colAddress.RowIndex = 1
            ' 
            ' colPhone
            ' 
            resources.ApplyResources(Me.colPhone, "colPhone")
            Me.colPhone.FieldName = "Phone"
            Me.colPhone.Name = "colPhone"
            Me.colPhone.RowIndex = 1
            ' 
            ' colFax
            ' 
            resources.ApplyResources(Me.colFax, "colFax")
            Me.colFax.FieldName = "Fax"
            Me.colFax.Name = "colFax"
            Me.colFax.RowIndex = 1
            ' 
            ' imageList2
            ' 
            Me.imageList2.ImageStream = (DirectCast(resources.GetObject("imageList2.ImageStream"), System.Windows.Forms.ImageListStreamer))
            Me.imageList2.TransparentColor = System.Drawing.Color.Magenta
            Me.imageList2.Images.SetKeyName(0, "")
            ' 
            ' gridView2
            ' 
            Me.gridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() { Me.colDiscount, Me.colOrderID, Me.colQuantity, Me.colUnitPrice1, Me.colSubTotal})
            Me.gridView2.GridControl = Me.gridControl1
            Me.gridView2.GroupCount = 1
            Me.gridView2.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() { New DevExpress.XtraGrid.GridGroupSummaryItem((DirectCast(resources.GetObject("gridView2.GroupSummary"), DevExpress.Data.SummaryItemType)), resources.GetString("gridView2.GroupSummary1"), (DirectCast(resources.GetObject("gridView2.GroupSummary2"), DevExpress.XtraGrid.Columns.GridColumn)), resources.GetString("gridView2.GroupSummary3"))})
            Me.gridView2.Images = Me.imageList2
            Me.gridView2.Name = "gridView2"
            Me.gridView2.OptionsClipboard.ClipboardMode = DevExpress.Export.ClipboardMode.Formatted
            Me.gridView2.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default
            Me.gridView2.OptionsView.AllowHtmlDrawHeaders = True
            Me.gridView2.OptionsView.ColumnAutoWidth = False
            Me.gridView2.OptionsView.ShowGroupPanel = False
            Me.gridView2.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() { New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colUnitPrice1, DevExpress.Data.ColumnSortOrder.Ascending)})
            resources.ApplyResources(Me.gridView2, "gridView2")
            ' 
            ' colDiscount
            ' 
            resources.ApplyResources(Me.colDiscount, "colDiscount")
            Me.colDiscount.DisplayFormat.FormatString = "p"
            Me.colDiscount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colDiscount.FieldName = "Discount"
            Me.colDiscount.Name = "colDiscount"
            ' 
            ' colOrderID
            ' 
            resources.ApplyResources(Me.colOrderID, "colOrderID")
            Me.colOrderID.FieldName = "OrderID"
            Me.colOrderID.Name = "colOrderID"
            Me.colOrderID.OptionsFilter.AllowFilter = False
            ' 
            ' colQuantity
            ' 
            resources.ApplyResources(Me.colQuantity, "colQuantity")
            Me.colQuantity.ColumnEdit = Me.repositoryItemSpinEdit1
            Me.colQuantity.FieldName = "Quantity"
            Me.colQuantity.Name = "colQuantity"
            ' 
            ' colUnitPrice1
            ' 
            resources.ApplyResources(Me.colUnitPrice1, "colUnitPrice1")
            Me.colUnitPrice1.ColumnEdit = Me.repositoryItemCalcEdit1
            Me.colUnitPrice1.DisplayFormat.FormatString = "c"
            Me.colUnitPrice1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colUnitPrice1.FieldName = "UnitPrice"
            Me.colUnitPrice1.Image = My.Resources.sale_16x16
            Me.colUnitPrice1.Name = "colUnitPrice1"
            ' 
            ' colSubTotal
            ' 
            resources.ApplyResources(Me.colSubTotal, "colSubTotal")
            Me.colSubTotal.DisplayFormat.FormatString = "c"
            Me.colSubTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colSubTotal.FieldName = "SubTotal"
            Me.colSubTotal.Name = "colSubTotal"
            Me.colSubTotal.OptionsColumn.AllowEdit = False
            ' 
            ' imageComboBoxEdit1
            ' 
            resources.ApplyResources(Me.imageComboBoxEdit1, "imageComboBoxEdit1")
            Me.imageComboBoxEdit1.Name = "imageComboBoxEdit1"
            Me.imageComboBoxEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton((DirectCast(resources.GetObject("imageComboBoxEdit1.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines)))})
            Me.imageComboBoxEdit1.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.ImageComboBoxItem() {
                New DevExpress.XtraEditors.Controls.ImageComboBoxItem(resources.GetString("imageComboBoxEdit1.Properties.Items"), (DirectCast(resources.GetObject("imageComboBoxEdit1.Properties.Items1"), Object)), (DirectCast(resources.GetObject("imageComboBoxEdit1.Properties.Items2"), Integer))),
                New DevExpress.XtraEditors.Controls.ImageComboBoxItem(resources.GetString("imageComboBoxEdit1.Properties.Items3"), (DirectCast(resources.GetObject("imageComboBoxEdit1.Properties.Items4"), Object)), (DirectCast(resources.GetObject("imageComboBoxEdit1.Properties.Items5"), Integer))),
                New DevExpress.XtraEditors.Controls.ImageComboBoxItem(resources.GetString("imageComboBoxEdit1.Properties.Items6"), (DirectCast(resources.GetObject("imageComboBoxEdit1.Properties.Items7"), Object)), (DirectCast(resources.GetObject("imageComboBoxEdit1.Properties.Items8"), Integer)))
            })
            Me.imageComboBoxEdit1.Properties.SmallImages = Me.imageList1
            Me.imageComboBoxEdit1.StyleController = Me.layoutControl1
            ' 
            ' imageList1
            ' 
            Me.imageList1.ImageStream = (DirectCast(resources.GetObject("imageList1.ImageStream"), System.Windows.Forms.ImageListStreamer))
            Me.imageList1.TransparentColor = System.Drawing.Color.Magenta
            Me.imageList1.Images.SetKeyName(0, "")
            Me.imageList1.Images.SetKeyName(1, "")
            Me.imageList1.Images.SetKeyName(2, "")
            ' 
            ' layoutControl1
            ' 
            Me.layoutControl1.AllowCustomization = False
            Me.layoutControl1.Controls.Add(Me.ceShowEmbeddedDetailIndent)
            Me.layoutControl1.Controls.Add(Me.icbDetailMode)
            Me.layoutControl1.Controls.Add(Me.seVertIndent)
            Me.layoutControl1.Controls.Add(Me.imageComboBoxEdit1)
            Me.layoutControl1.Controls.Add(Me.ceToolTips)
            Me.layoutControl1.Controls.Add(Me.ceTabs)
            Me.layoutControl1.Controls.Add(Me.ceMain)
            resources.ApplyResources(Me.layoutControl1, "layoutControl1")
            Me.layoutControl1.Name = "layoutControl1"
            Me.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(1032, 180, 450, 350)
            Me.layoutControl1.Root = Me.layoutControlGroup1
            ' 
            ' seVertIndent
            ' 
            resources.ApplyResources(Me.seVertIndent, "seVertIndent")
            Me.seVertIndent.Name = "seVertIndent"
            Me.seVertIndent.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
            Me.seVertIndent.Properties.IsFloatValue = False
            Me.seVertIndent.Properties.Mask.EditMask = resources.GetString("seVertIndent.Properties.Mask.EditMask")
            Me.seVertIndent.Properties.MaxValue = New Decimal(New Integer() { 20, 0, 0, 0})
            Me.seVertIndent.StyleController = Me.layoutControl1
            ' 
            ' ceToolTips
            ' 
            resources.ApplyResources(Me.ceToolTips, "ceToolTips")
            Me.ceToolTips.Name = "ceToolTips"
            Me.ceToolTips.Properties.Caption = resources.GetString("ceToolTips.Properties.Caption")
            Me.ceToolTips.StyleController = Me.layoutControl1
            ' 
            ' ceTabs
            ' 
            resources.ApplyResources(Me.ceTabs, "ceTabs")
            Me.ceTabs.Name = "ceTabs"
            Me.ceTabs.Properties.Caption = resources.GetString("ceTabs.Properties.Caption")
            Me.ceTabs.StyleController = Me.layoutControl1
            ' 
            ' ceMain
            ' 
            resources.ApplyResources(Me.ceMain, "ceMain")
            Me.ceMain.Name = "ceMain"
            Me.ceMain.Properties.Appearance.Font = (DirectCast(resources.GetObject("ceMain.Properties.Appearance.Font"), System.Drawing.Font))
            Me.ceMain.Properties.Appearance.Options.UseFont = True
            Me.ceMain.Properties.Caption = resources.GetString("ceMain.Properties.Caption")
            Me.ceMain.StyleController = Me.layoutControl1
            ' 
            ' layoutControlGroup1
            ' 
            Me.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True
            Me.layoutControlGroup1.GroupBordersVisible = False
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.layoutControlItem1, Me.layoutControlItem2, Me.layoutControlItem3, Me.emptySpaceItem1, Me.emptySpaceItem2, Me.lciZooming, Me.lciDetailIndent, Me.layoutControlItem6, Me.layoutControlItem7, Me.emptySpaceItem3})
            Me.layoutControlGroup1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup1.Name = "Root"
            Me.layoutControlGroup1.Size = New System.Drawing.Size(249, 489)
            Me.layoutControlGroup1.TextVisible = False
            ' 
            ' layoutControlItem1
            ' 
            Me.layoutControlItem1.Control = Me.ceMain
            Me.layoutControlItem1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem1.Name = "layoutControlItem1"
            Me.layoutControlItem1.Size = New System.Drawing.Size(229, 23)
            Me.layoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem1.TextVisible = False
            ' 
            ' layoutControlItem2
            ' 
            Me.layoutControlItem2.Control = Me.ceTabs
            Me.layoutControlItem2.Location = New System.Drawing.Point(0, 109)
            Me.layoutControlItem2.Name = "layoutControlItem2"
            Me.layoutControlItem2.Size = New System.Drawing.Size(229, 23)
            Me.layoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem2.TextVisible = False
            ' 
            ' layoutControlItem3
            ' 
            Me.layoutControlItem3.Control = Me.ceToolTips
            Me.layoutControlItem3.Location = New System.Drawing.Point(0, 132)
            Me.layoutControlItem3.Name = "layoutControlItem3"
            Me.layoutControlItem3.Size = New System.Drawing.Size(229, 23)
            Me.layoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem3.TextVisible = False
            ' 
            ' emptySpaceItem1
            ' 
            Me.emptySpaceItem1.AllowHotTrack = False
            Me.emptySpaceItem1.Location = New System.Drawing.Point(0, 203)
            Me.emptySpaceItem1.Name = "emptySpaceItem1"
            Me.emptySpaceItem1.Size = New System.Drawing.Size(229, 266)
            Me.emptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
            ' 
            ' emptySpaceItem2
            ' 
            Me.emptySpaceItem2.AllowHotTrack = False
            Me.emptySpaceItem2.Location = New System.Drawing.Point(0, 23)
            Me.emptySpaceItem2.Name = "emptySpaceItem2"
            Me.emptySpaceItem2.Size = New System.Drawing.Size(229, 18)
            Me.emptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
            ' 
            ' lciZooming
            ' 
            Me.lciZooming.Control = Me.imageComboBoxEdit1
            Me.lciZooming.Location = New System.Drawing.Point(0, 155)
            Me.lciZooming.Name = "lciZooming"
            Me.lciZooming.Size = New System.Drawing.Size(229, 24)
            resources.ApplyResources(Me.lciZooming, "lciZooming")
            Me.lciZooming.TextSize = New System.Drawing.Size(104, 13)
            ' 
            ' lciDetailIndent
            ' 
            Me.lciDetailIndent.Control = Me.seVertIndent
            Me.lciDetailIndent.Location = New System.Drawing.Point(0, 179)
            Me.lciDetailIndent.Name = "lciDetailIndent"
            Me.lciDetailIndent.Size = New System.Drawing.Size(229, 24)
            resources.ApplyResources(Me.lciDetailIndent, "lciDetailIndent")
            Me.lciDetailIndent.TextSize = New System.Drawing.Size(104, 13)
            ' 
            ' navigationPane1
            ' 
            Me.navigationPane1.Controls.Add(Me.navigationPage1)
            resources.ApplyResources(Me.navigationPane1, "navigationPane1")
            Me.navigationPane1.Name = "navigationPane1"
            Me.navigationPane1.PageProperties.AppearanceCaption.Options.UseTextOptions = True
            Me.navigationPane1.PageProperties.AppearanceCaption.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter
            Me.navigationPane1.PageProperties.ShowExpandButton = False
            Me.navigationPane1.Pages.AddRange(New DevExpress.XtraBars.Navigation.NavigationPageBase() { Me.navigationPage1})
            Me.navigationPane1.RegularSize = New System.Drawing.Size(299, 549)
            Me.navigationPane1.SelectedPage = Me.navigationPage1
            ' 
            ' navigationPage1
            ' 
            Me.navigationPage1.Caption = "Options"
            Me.navigationPage1.Controls.Add(Me.layoutControl1)
            Me.navigationPage1.Image = (DirectCast(resources.GetObject("navigationPage1.Image"), System.Drawing.Image))
            Me.navigationPage1.ImageUri.Uri = "New"
            Me.navigationPage1.Name = "navigationPage1"
            resources.ApplyResources(Me.navigationPage1, "navigationPage1")
            ' 
            ' pnlGrid
            ' 
            Me.pnlGrid.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.pnlGrid.Controls.Add(Me.gridControl1)
            resources.ApplyResources(Me.pnlGrid, "pnlGrid")
            Me.pnlGrid.Name = "pnlGrid"
            ' 
            ' icbDetailMode
            ' 
            resources.ApplyResources(Me.icbDetailMode, "icbDetailMode")
            Me.icbDetailMode.Name = "icbDetailMode"
            Me.icbDetailMode.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton((DirectCast(resources.GetObject("imageComboBoxEdit2.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines)))})
            Me.icbDetailMode.StyleController = Me.layoutControl1
            ' 
            ' layoutControlItem6
            ' 
            Me.layoutControlItem6.AllowHtmlStringInCaption = True
            Me.layoutControlItem6.Control = Me.icbDetailMode
            Me.layoutControlItem6.Location = New System.Drawing.Point(0, 41)
            Me.layoutControlItem6.Name = "layoutControlItem6"
            Me.layoutControlItem6.Size = New System.Drawing.Size(229, 24)
            resources.ApplyResources(Me.layoutControlItem6, "layoutControlItem6")
            Me.layoutControlItem6.TextSize = New System.Drawing.Size(104, 13)
            ' 
            ' ceShowEmbeddedDetailIndent
            ' 
            resources.ApplyResources(Me.ceShowEmbeddedDetailIndent, "ceShowEmbeddedDetailIndent")
            Me.ceShowEmbeddedDetailIndent.Name = "ceShowEmbeddedDetailIndent"
            Me.ceShowEmbeddedDetailIndent.Properties.Caption = resources.GetString("checkEdit1.Properties.Caption")
            Me.ceShowEmbeddedDetailIndent.StyleController = Me.layoutControl1
            ' 
            ' layoutControlItem7
            ' 
            Me.layoutControlItem7.Control = Me.ceShowEmbeddedDetailIndent
            Me.layoutControlItem7.Location = New System.Drawing.Point(0, 65)
            Me.layoutControlItem7.Name = "layoutControlItem7"
            Me.layoutControlItem7.Size = New System.Drawing.Size(229, 23)
            Me.layoutControlItem7.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem7.TextVisible = False
            ' 
            ' emptySpaceItem3
            ' 
            Me.emptySpaceItem3.AllowHotTrack = False
            Me.emptySpaceItem3.Location = New System.Drawing.Point(0, 88)
            Me.emptySpaceItem3.Name = "emptySpaceItem3"
            Me.emptySpaceItem3.Size = New System.Drawing.Size(229, 21)
            Me.emptySpaceItem3.TextSize = New System.Drawing.Size(0, 0)
            ' 
            ' MasterDetail
            ' 
            resources.ApplyResources(Me, "$this")
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.pnlGrid)
            Me.Controls.Add(Me.navigationPane1)
            Me.Name = "MasterDetail"
            DirectCast(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.repositoryItemImageComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.repositoryItemSpinEdit1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.repositoryItemCalcEdit1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.dsNWindSupplier1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.cardView1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.repositoryItemImageEdit1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.repositoryItemMemoExEdit1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.advBandedGridView1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.repositoryItemComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.repositoryItemComboBox2, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.gridView2, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.imageComboBoxEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl1.ResumeLayout(False)
            DirectCast(Me.seVertIndent.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.ceToolTips.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.ceTabs.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.ceMain.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.emptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.emptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.lciZooming, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.lciDetailIndent, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.navigationPane1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.navigationPane1.ResumeLayout(False)
            Me.navigationPage1.ResumeLayout(False)
            DirectCast(Me.pnlGrid, System.ComponentModel.ISupportInitialize).EndInit()
            Me.pnlGrid.ResumeLayout(False)
            DirectCast(Me.icbDetailMode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.ceShowEmbeddedDetailIndent.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.emptySpaceItem3, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        #End Region
        Private colDescription As DevExpress.XtraGrid.Columns.GridColumn
        Private colRegion As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Private gridBand1 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
        Private colCountry As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Private colCity As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Private colPostalCode As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Private colAddress As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Private colPhone As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Private colFax As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Private colContactTitle As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Private colPicture As DevExpress.XtraGrid.Columns.GridColumn
        Private cardView1 As DevExpress.XtraGrid.Views.Card.CardView
        Private colCategoryName As DevExpress.XtraGrid.Columns.GridColumn
        Private colProductName1 As DevExpress.XtraGrid.Columns.GridColumn
        Private advBandedGridView1 As DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView
        Private gridBand2 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
        Private colCompanyName As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Private colSupplierID As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Private colContactName As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Private gridView2 As DevExpress.XtraGrid.Views.Grid.GridView
        Private colDiscount As DevExpress.XtraGrid.Columns.GridColumn
        Private colOrderID As DevExpress.XtraGrid.Columns.GridColumn
        Private colQuantity As DevExpress.XtraGrid.Columns.GridColumn
        Private colUnitPrice1 As DevExpress.XtraGrid.Columns.GridColumn
        Private colSubTotal As DevExpress.XtraGrid.Columns.GridColumn
        Private gridControl1 As DevExpress.XtraGrid.GridControl
        Private gridView1 As DevExpress.XtraGrid.Views.Grid.GridView
        Private colCategoryID As DevExpress.XtraGrid.Columns.GridColumn
        Private colDiscontinued As DevExpress.XtraGrid.Columns.GridColumn
        Private colProductID As DevExpress.XtraGrid.Columns.GridColumn
        Private colProductName As DevExpress.XtraGrid.Columns.GridColumn
        Private colQuantityPerUnit As DevExpress.XtraGrid.Columns.GridColumn
        Private colReorderLevel As DevExpress.XtraGrid.Columns.GridColumn
        Private colUnitPrice As DevExpress.XtraGrid.Columns.GridColumn
        Private colUnitsInStock As DevExpress.XtraGrid.Columns.GridColumn
        Private colUnitsOnOrder As DevExpress.XtraGrid.Columns.GridColumn
        Private dsNWindSupplier1 As dsNWindSupplier
        Private components As System.ComponentModel.IContainer = Nothing
        Private repositoryItemImageEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemImageEdit
        Private repositoryItemMemoExEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
        Private repositoryItemImageComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox
        Private imageList2 As System.Windows.Forms.ImageList
        Private repositoryItemCalcEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
        Private repositoryItemSpinEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
        Private repositoryItemComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
        Private repositoryItemComboBox2 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
        Private WithEvents imageComboBoxEdit1 As DevExpress.XtraEditors.ImageComboBoxEdit
        Private WithEvents ceTabs As DevExpress.XtraEditors.CheckEdit
        Private WithEvents ceToolTips As DevExpress.XtraEditors.CheckEdit
        Private WithEvents ceMain As DevExpress.XtraEditors.CheckEdit
        Private imageList1 As System.Windows.Forms.ImageList
        Private WithEvents seVertIndent As DevExpress.XtraEditors.SpinEdit
        Private layoutControl1 As XtraLayout.LayoutControl
        Private layoutControlGroup1 As XtraLayout.LayoutControlGroup
        Private layoutControlItem1 As XtraLayout.LayoutControlItem
        Private layoutControlItem2 As XtraLayout.LayoutControlItem
        Private layoutControlItem3 As XtraLayout.LayoutControlItem
        Private emptySpaceItem1 As XtraLayout.EmptySpaceItem
        Private emptySpaceItem2 As XtraLayout.EmptySpaceItem
        Private lciZooming As XtraLayout.LayoutControlItem
        Private lciDetailIndent As XtraLayout.LayoutControlItem
        Private navigationPane1 As XtraBars.Navigation.NavigationPane
        Private navigationPage1 As XtraBars.Navigation.NavigationPage
        Private pnlGrid As XtraEditors.PanelControl
        Private WithEvents ceShowEmbeddedDetailIndent As XtraEditors.CheckEdit
        Private WithEvents icbDetailMode As XtraEditors.ImageComboBoxEdit
        Private layoutControlItem6 As XtraLayout.LayoutControlItem
        Private layoutControlItem7 As XtraLayout.LayoutControlItem
        Private emptySpaceItem3 As XtraLayout.EmptySpaceItem
    End Class
End Namespace
