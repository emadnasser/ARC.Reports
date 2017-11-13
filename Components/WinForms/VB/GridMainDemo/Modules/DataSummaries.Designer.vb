Namespace DevExpress.XtraGrid.Demos
    Partial Public Class DataSummaries
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
            Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(DataSummaries))
            Dim gridLevelNode1 As New DevExpress.XtraGrid.GridLevelNode()
            Dim styleFormatCondition1 As New DevExpress.XtraGrid.StyleFormatCondition()
            Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.colOrderID = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colPrice = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.repositoryItemSpinEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
            Me.colQuantity = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colDiscount = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colSubTotal = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colProduct = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.repositoryItemLookUpEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
            Me.dsNWindProducts1 = New dsNWindProducts()
            Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
            Me.advBandedGridView1 = New DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView()
            Me.gridBand1 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
            Me.colProductName = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.colCategoryID = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.repositoryItemImageComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox()
            Me.colProductID = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.colSupplierID = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.repositoryItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
            Me.gridBand2 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
            Me.colUnitPrice = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.repositoryItemCalcEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit()
            Me.colQuantityPerUnit = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.colReorderLevel = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.colDiscontinued = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.colUnitsOnOrder = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.colUnitsInStock = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.navigationPane1 = New DevExpress.XtraBars.Navigation.NavigationPane()
            Me.navigationPage1 = New DevExpress.XtraBars.Navigation.NavigationPage()
            Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl()
            Me.ceMasterDetail = New DevExpress.XtraEditors.CheckEdit()
            Me.chShowFooter = New DevExpress.XtraEditors.CheckEdit()
            Me.chAlignSummary = New DevExpress.XtraEditors.CheckEdit()
            Me.chDisplaySummary = New DevExpress.XtraEditors.CheckEdit()
            Me.chMultiSummary = New DevExpress.XtraEditors.CheckEdit()
            Me.chSummary = New DevExpress.XtraEditors.CheckEdit()
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.emptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.emptySpaceItem3 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.layoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
            DirectCast(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.repositoryItemSpinEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.repositoryItemLookUpEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.dsNWindProducts1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.advBandedGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.repositoryItemImageComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.repositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.repositoryItemCalcEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.navigationPane1.SuspendLayout()
            Me.navigationPage1.SuspendLayout()
            DirectCast(Me.layoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl1.SuspendLayout()
            DirectCast(Me.ceMasterDetail.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.chShowFooter.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.chAlignSummary.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.chDisplaySummary.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.chMultiSummary.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.chSummary.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.emptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.emptySpaceItem3, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panelControl1.SuspendLayout()
            Me.SuspendLayout()
            ' 
            ' gridView1
            ' 
            Me.gridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() { Me.colOrderID, Me.colPrice, Me.colQuantity, Me.colDiscount, Me.colSubTotal, Me.colProduct})
            Me.gridView1.GridControl = Me.gridControl1
            Me.gridView1.Name = "gridView1"
            Me.gridView1.OptionsClipboard.ClipboardMode = DevExpress.Export.ClipboardMode.Formatted
            Me.gridView1.OptionsView.ColumnAutoWidth = False
            Me.gridView1.OptionsView.ShowGroupPanel = False
            ' 
            ' colOrderID
            ' 
            resources.ApplyResources(Me.colOrderID, "colOrderID")
            Me.colOrderID.FieldName = "OrderID"
            Me.colOrderID.Name = "colOrderID"
            Me.colOrderID.OptionsFilter.AllowFilter = False
            Me.colOrderID.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() { New DevExpress.XtraGrid.GridColumnSummaryItem((DirectCast(resources.GetObject("colOrderID.Summary"), DevExpress.Data.SummaryItemType)))})
            ' 
            ' colPrice
            ' 
            resources.ApplyResources(Me.colPrice, "colPrice")
            Me.colPrice.ColumnEdit = Me.repositoryItemSpinEdit1
            Me.colPrice.DisplayFormat.FormatString = "c"
            Me.colPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colPrice.FieldName = "UnitPrice"
            Me.colPrice.Name = "colPrice"
            ' 
            ' repositoryItemSpinEdit1
            ' 
            Me.repositoryItemSpinEdit1.AllowFocused = False
            resources.ApplyResources(Me.repositoryItemSpinEdit1, "repositoryItemSpinEdit1")
            Me.repositoryItemSpinEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
            Me.repositoryItemSpinEdit1.IsFloatValue = False
            Me.repositoryItemSpinEdit1.Mask.EditMask = resources.GetString("repositoryItemSpinEdit1.Mask.EditMask")
            Me.repositoryItemSpinEdit1.Name = "repositoryItemSpinEdit1"
            ' 
            ' colQuantity
            ' 
            resources.ApplyResources(Me.colQuantity, "colQuantity")
            Me.colQuantity.ColumnEdit = Me.repositoryItemSpinEdit1
            Me.colQuantity.FieldName = "Quantity"
            Me.colQuantity.Name = "colQuantity"
            Me.colQuantity.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() { New DevExpress.XtraGrid.GridColumnSummaryItem((DirectCast(resources.GetObject("colQuantity.Summary"), DevExpress.Data.SummaryItemType)), resources.GetString("colQuantity.Summary1"), resources.GetString("colQuantity.Summary2"))})
            ' 
            ' colDiscount
            ' 
            resources.ApplyResources(Me.colDiscount, "colDiscount")
            Me.colDiscount.DisplayFormat.FormatString = "p"
            Me.colDiscount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colDiscount.FieldName = "Discount"
            Me.colDiscount.Name = "colDiscount"
            Me.colDiscount.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() { New DevExpress.XtraGrid.GridColumnSummaryItem((DirectCast(resources.GetObject("colDiscount.Summary"), DevExpress.Data.SummaryItemType)), resources.GetString("colDiscount.Summary1"), resources.GetString("colDiscount.Summary2"))})
            ' 
            ' colSubTotal
            ' 
            Me.colSubTotal.AppearanceCell.Font = (DirectCast(resources.GetObject("colSubTotal.AppearanceCell.Font"), System.Drawing.Font))
            Me.colSubTotal.AppearanceCell.Options.UseFont = True
            resources.ApplyResources(Me.colSubTotal, "colSubTotal")
            Me.colSubTotal.DisplayFormat.FormatString = "c"
            Me.colSubTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colSubTotal.FieldName = "SubTotal"
            Me.colSubTotal.Name = "colSubTotal"
            Me.colSubTotal.OptionsColumn.AllowEdit = False
            Me.colSubTotal.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() { New DevExpress.XtraGrid.GridColumnSummaryItem((DirectCast(resources.GetObject("colSubTotal.Summary"), DevExpress.Data.SummaryItemType)), resources.GetString("colSubTotal.Summary1"), resources.GetString("colSubTotal.Summary2"))})
            ' 
            ' colProduct
            ' 
            resources.ApplyResources(Me.colProduct, "colProduct")
            Me.colProduct.ColumnEdit = Me.repositoryItemLookUpEdit2
            Me.colProduct.FieldName = "ProductID"
            Me.colProduct.Name = "colProduct"
            ' 
            ' repositoryItemLookUpEdit2
            ' 
            resources.ApplyResources(Me.repositoryItemLookUpEdit2, "repositoryItemLookUpEdit2")
            Me.repositoryItemLookUpEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton((DirectCast(resources.GetObject("repositoryItemLookUpEdit2.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines)))})
            Me.repositoryItemLookUpEdit2.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() { New DevExpress.XtraEditors.Controls.LookUpColumnInfo(resources.GetString("repositoryItemLookUpEdit2.Columns"), resources.GetString("repositoryItemLookUpEdit2.Columns1"))})
            Me.repositoryItemLookUpEdit2.DataSource = Me.dsNWindProducts1.Products
            Me.repositoryItemLookUpEdit2.DisplayMember = "ProductName"
            Me.repositoryItemLookUpEdit2.DropDownRows = 12
            Me.repositoryItemLookUpEdit2.Name = "repositoryItemLookUpEdit2"
            Me.repositoryItemLookUpEdit2.ShowHeader = False
            Me.repositoryItemLookUpEdit2.ValueMember = "ProductID"
            ' 
            ' dsNWindProducts1
            ' 
            Me.dsNWindProducts1.DataSetName = "dsNWindProducts"
            Me.dsNWindProducts1.Locale = New System.Globalization.CultureInfo("en-US")
            Me.dsNWindProducts1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
            ' 
            ' gridControl1
            ' 
            Me.gridControl1.DataSource = Me.dsNWindProducts1.Products
            resources.ApplyResources(Me.gridControl1, "gridControl1")
            gridLevelNode1.LevelTemplate = Me.gridView1
            gridLevelNode1.RelationName = "ProductsOrder_x0020_Details"
            Me.gridControl1.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() { gridLevelNode1})
            Me.gridControl1.MainView = Me.advBandedGridView1
            Me.gridControl1.Name = "gridControl1"
            Me.gridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() { Me.repositoryItemImageComboBox1, Me.repositoryItemCalcEdit1, Me.repositoryItemSpinEdit1, Me.repositoryItemLookUpEdit1, Me.repositoryItemLookUpEdit2})
            Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.advBandedGridView1, Me.gridView1})
            ' 
            ' advBandedGridView1
            ' 
            Me.advBandedGridView1.Bands.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() { Me.gridBand1, Me.gridBand2})
            Me.advBandedGridView1.Columns.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn() { Me.colProductID, Me.colProductName, Me.colSupplierID, Me.colCategoryID, Me.colQuantityPerUnit, Me.colUnitPrice, Me.colUnitsInStock, Me.colUnitsOnOrder, Me.colReorderLevel, Me.colDiscontinued})
            styleFormatCondition1.Appearance.Font = (DirectCast(resources.GetObject("resource.Font"), System.Drawing.Font))
            styleFormatCondition1.Appearance.ForeColor = (DirectCast(resources.GetObject("resource.ForeColor"), System.Drawing.Color))
            styleFormatCondition1.Appearance.Options.UseFont = True
            styleFormatCondition1.Appearance.Options.UseForeColor = True
            styleFormatCondition1.ApplyToRow = True
            styleFormatCondition1.Column = Me.colDiscontinued
            styleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
            styleFormatCondition1.Value1 = True
            Me.advBandedGridView1.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() { styleFormatCondition1})
            Me.advBandedGridView1.GridControl = Me.gridControl1
            Me.advBandedGridView1.Name = "advBandedGridView1"
            Me.advBandedGridView1.OptionsDetail.ShowDetailTabs = False
            Me.advBandedGridView1.OptionsMenu.ShowGroupSummaryEditorItem = True
            Me.advBandedGridView1.OptionsPrint.PrintDetails = True
            Me.advBandedGridView1.RowSeparatorHeight = 1
            ' 
            ' gridBand1
            ' 
            resources.ApplyResources(Me.gridBand1, "gridBand1")
            Me.gridBand1.Columns.Add(Me.colProductName)
            Me.gridBand1.Columns.Add(Me.colCategoryID)
            Me.gridBand1.Columns.Add(Me.colProductID)
            Me.gridBand1.Columns.Add(Me.colSupplierID)
            Me.gridBand1.VisibleIndex = 0
            ' 
            ' colProductName
            ' 
            resources.ApplyResources(Me.colProductName, "colProductName")
            Me.colProductName.FieldName = "ProductName"
            Me.colProductName.Name = "colProductName"
            Me.colProductName.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() { New DevExpress.XtraGrid.GridColumnSummaryItem((DirectCast(resources.GetObject("colProductName.Summary"), DevExpress.Data.SummaryItemType)))})
            ' 
            ' colCategoryID
            ' 
            resources.ApplyResources(Me.colCategoryID, "colCategoryID")
            Me.colCategoryID.ColumnEdit = Me.repositoryItemImageComboBox1
            Me.colCategoryID.FieldName = "CategoryID"
            Me.colCategoryID.Name = "colCategoryID"
            Me.colCategoryID.RowIndex = 1
            ' 
            ' repositoryItemImageComboBox1
            ' 
            Me.repositoryItemImageComboBox1.AllowFocused = False
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
            ' 
            ' colSupplierID
            ' 
            Me.colSupplierID.AppearanceCell.Options.UseTextOptions = True
            Me.colSupplierID.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
            resources.ApplyResources(Me.colSupplierID, "colSupplierID")
            Me.colSupplierID.ColumnEdit = Me.repositoryItemLookUpEdit1
            Me.colSupplierID.FieldName = "SupplierID"
            Me.colSupplierID.Name = "colSupplierID"
            Me.colSupplierID.RowIndex = 1
            ' 
            ' repositoryItemLookUpEdit1
            ' 
            resources.ApplyResources(Me.repositoryItemLookUpEdit1, "repositoryItemLookUpEdit1")
            Me.repositoryItemLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton((DirectCast(resources.GetObject("repositoryItemLookUpEdit1.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines)))})
            Me.repositoryItemLookUpEdit1.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {
                New DevExpress.XtraEditors.Controls.LookUpColumnInfo(resources.GetString("repositoryItemLookUpEdit1.Columns"), resources.GetString("repositoryItemLookUpEdit1.Columns1"), (DirectCast(resources.GetObject("repositoryItemLookUpEdit1.Columns2"), Integer)), (DirectCast(resources.GetObject("repositoryItemLookUpEdit1.Columns3"), DevExpress.Utils.FormatType)), resources.GetString("repositoryItemLookUpEdit1.Columns4"), (DirectCast(resources.GetObject("repositoryItemLookUpEdit1.Columns5"), Boolean)), (DirectCast(resources.GetObject("repositoryItemLookUpEdit1.Columns6"), DevExpress.Utils.HorzAlignment))),
                New DevExpress.XtraEditors.Controls.LookUpColumnInfo(resources.GetString("repositoryItemLookUpEdit1.Columns7"), resources.GetString("repositoryItemLookUpEdit1.Columns8"), (DirectCast(resources.GetObject("repositoryItemLookUpEdit1.Columns9"), Integer)), (DirectCast(resources.GetObject("repositoryItemLookUpEdit1.Columns10"), DevExpress.Utils.FormatType)), resources.GetString("repositoryItemLookUpEdit1.Columns11"), (DirectCast(resources.GetObject("repositoryItemLookUpEdit1.Columns12"), Boolean)), (DirectCast(resources.GetObject("repositoryItemLookUpEdit1.Columns13"), DevExpress.Utils.HorzAlignment))),
                New DevExpress.XtraEditors.Controls.LookUpColumnInfo(resources.GetString("repositoryItemLookUpEdit1.Columns14"), resources.GetString("repositoryItemLookUpEdit1.Columns15"), (DirectCast(resources.GetObject("repositoryItemLookUpEdit1.Columns16"), Integer)), (DirectCast(resources.GetObject("repositoryItemLookUpEdit1.Columns17"), DevExpress.Utils.FormatType)), resources.GetString("repositoryItemLookUpEdit1.Columns18"), (DirectCast(resources.GetObject("repositoryItemLookUpEdit1.Columns19"), Boolean)), (DirectCast(resources.GetObject("repositoryItemLookUpEdit1.Columns20"), DevExpress.Utils.HorzAlignment)))
            })
            Me.repositoryItemLookUpEdit1.DataSource = Me.dsNWindProducts1.Suppliers
            Me.repositoryItemLookUpEdit1.DisplayMember = "ContactName"
            Me.repositoryItemLookUpEdit1.DropDownRows = 10
            Me.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1"
            Me.repositoryItemLookUpEdit1.PopupWidth = 420
            Me.repositoryItemLookUpEdit1.ValueMember = "SupplierID"
            ' 
            ' gridBand2
            ' 
            resources.ApplyResources(Me.gridBand2, "gridBand2")
            Me.gridBand2.Columns.Add(Me.colUnitPrice)
            Me.gridBand2.Columns.Add(Me.colQuantityPerUnit)
            Me.gridBand2.Columns.Add(Me.colReorderLevel)
            Me.gridBand2.Columns.Add(Me.colDiscontinued)
            Me.gridBand2.Columns.Add(Me.colUnitsOnOrder)
            Me.gridBand2.Columns.Add(Me.colUnitsInStock)
            Me.gridBand2.VisibleIndex = 1
            ' 
            ' colUnitPrice
            ' 
            resources.ApplyResources(Me.colUnitPrice, "colUnitPrice")
            Me.colUnitPrice.ColumnEdit = Me.repositoryItemCalcEdit1
            Me.colUnitPrice.DisplayFormat.FormatString = "c"
            Me.colUnitPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colUnitPrice.FieldName = "UnitPrice"
            Me.colUnitPrice.Name = "colUnitPrice"
            Me.colUnitPrice.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() { New DevExpress.XtraGrid.GridColumnSummaryItem((DirectCast(resources.GetObject("colUnitPrice.Summary"), DevExpress.Data.SummaryItemType)), resources.GetString("colUnitPrice.Summary1"), resources.GetString("colUnitPrice.Summary2"))})
            ' 
            ' repositoryItemCalcEdit1
            ' 
            Me.repositoryItemCalcEdit1.AllowFocused = False
            resources.ApplyResources(Me.repositoryItemCalcEdit1, "repositoryItemCalcEdit1")
            Me.repositoryItemCalcEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton((DirectCast(resources.GetObject("repositoryItemCalcEdit1.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines)))})
            Me.repositoryItemCalcEdit1.Name = "repositoryItemCalcEdit1"
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
            Me.colReorderLevel.RowIndex = 1
            Me.colReorderLevel.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() { New DevExpress.XtraGrid.GridColumnSummaryItem((DirectCast(resources.GetObject("colReorderLevel.Summary"), DevExpress.Data.SummaryItemType)), resources.GetString("colReorderLevel.Summary1"), resources.GetString("colReorderLevel.Summary2"))})
            ' 
            ' colDiscontinued
            ' 
            resources.ApplyResources(Me.colDiscontinued, "colDiscontinued")
            Me.colDiscontinued.FieldName = "Discontinued"
            Me.colDiscontinued.Name = "colDiscontinued"
            ' 
            ' colUnitsOnOrder
            ' 
            resources.ApplyResources(Me.colUnitsOnOrder, "colUnitsOnOrder")
            Me.colUnitsOnOrder.ColumnEdit = Me.repositoryItemSpinEdit1
            Me.colUnitsOnOrder.FieldName = "UnitsOnOrder"
            Me.colUnitsOnOrder.Name = "colUnitsOnOrder"
            Me.colUnitsOnOrder.RowIndex = 1
            ' 
            ' colUnitsInStock
            ' 
            resources.ApplyResources(Me.colUnitsInStock, "colUnitsInStock")
            Me.colUnitsInStock.ColumnEdit = Me.repositoryItemSpinEdit1
            Me.colUnitsInStock.FieldName = "UnitsInStock"
            Me.colUnitsInStock.Name = "colUnitsInStock"
            Me.colUnitsInStock.RowIndex = 1
            Me.colUnitsInStock.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() { New DevExpress.XtraGrid.GridColumnSummaryItem((DirectCast(resources.GetObject("colUnitsInStock.Summary"), DevExpress.Data.SummaryItemType)), resources.GetString("colUnitsInStock.Summary1"), resources.GetString("colUnitsInStock.Summary2"))})
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
            Me.navigationPane1.RegularSize = New System.Drawing.Size(240, 501)
            Me.navigationPane1.SelectedPage = Me.navigationPage1
            Me.navigationPane1.SelectedPageIndex = 0
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
            ' layoutControl1
            ' 
            Me.layoutControl1.AllowCustomization = False
            Me.layoutControl1.Controls.Add(Me.ceMasterDetail)
            Me.layoutControl1.Controls.Add(Me.chShowFooter)
            Me.layoutControl1.Controls.Add(Me.chAlignSummary)
            Me.layoutControl1.Controls.Add(Me.chDisplaySummary)
            Me.layoutControl1.Controls.Add(Me.chMultiSummary)
            Me.layoutControl1.Controls.Add(Me.chSummary)
            resources.ApplyResources(Me.layoutControl1, "layoutControl1")
            Me.layoutControl1.Name = "layoutControl1"
            Me.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(1032, 180, 450, 350)
            Me.layoutControl1.Root = Me.layoutControlGroup1
            ' 
            ' ceMasterDetail
            ' 
            resources.ApplyResources(Me.ceMasterDetail, "ceMasterDetail")
            Me.ceMasterDetail.Name = "ceMasterDetail"
            Me.ceMasterDetail.Properties.Caption = resources.GetString("ceMasterDetail.Properties.Caption")
            Me.ceMasterDetail.StyleController = Me.layoutControl1
            ' 
            ' chShowFooter
            ' 
            resources.ApplyResources(Me.chShowFooter, "chShowFooter")
            Me.chShowFooter.Name = "chShowFooter"
            Me.chShowFooter.Properties.Caption = resources.GetString("chShowFooter.Properties.Caption")
            Me.chShowFooter.StyleController = Me.layoutControl1
            ' 
            ' chAlignSummary
            ' 
            resources.ApplyResources(Me.chAlignSummary, "chAlignSummary")
            Me.chAlignSummary.Name = "chAlignSummary"
            Me.chAlignSummary.Properties.AllowHtmlDraw = DevExpress.Utils.DefaultBoolean.True
            Me.chAlignSummary.Properties.Caption = resources.GetString("chAlignSummary.Properties.Caption")
            Me.chAlignSummary.StyleController = Me.layoutControl1
            ' 
            ' chDisplaySummary
            ' 
            resources.ApplyResources(Me.chDisplaySummary, "chDisplaySummary")
            Me.chDisplaySummary.Name = "chDisplaySummary"
            Me.chDisplaySummary.Properties.Caption = resources.GetString("chDisplaySummary.Properties.Caption")
            Me.chDisplaySummary.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Radio
            Me.chDisplaySummary.Properties.RadioGroupIndex = 0
            Me.chDisplaySummary.Properties.Tag = "Display Summary"
            Me.chDisplaySummary.StyleController = Me.layoutControl1
            Me.chDisplaySummary.TabStop = False
            ' 
            ' chMultiSummary
            ' 
            resources.ApplyResources(Me.chMultiSummary, "chMultiSummary")
            Me.chMultiSummary.Name = "chMultiSummary"
            Me.chMultiSummary.Properties.Caption = resources.GetString("chMultiSummary.Properties.Caption")
            Me.chMultiSummary.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Radio
            Me.chMultiSummary.Properties.RadioGroupIndex = 0
            Me.chMultiSummary.Properties.Tag = "Multi Summary"
            Me.chMultiSummary.StyleController = Me.layoutControl1
            Me.chMultiSummary.TabStop = False
            ' 
            ' chSummary
            ' 
            resources.ApplyResources(Me.chSummary, "chSummary")
            Me.chSummary.Name = "chSummary"
            Me.chSummary.Properties.Caption = resources.GetString("chSummary.Properties.Caption")
            Me.chSummary.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Radio
            Me.chSummary.Properties.RadioGroupIndex = 0
            Me.chSummary.Properties.Tag = "Summary"
            Me.chSummary.StyleController = Me.layoutControl1
            Me.chSummary.TabStop = False
            ' 
            ' layoutControlGroup1
            ' 
            Me.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True
            Me.layoutControlGroup1.GroupBordersVisible = False
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.layoutControlItem1, Me.layoutControlItem2, Me.layoutControlItem3, Me.layoutControlItem4, Me.emptySpaceItem2, Me.emptySpaceItem3, Me.layoutControlItem5, Me.layoutControlItem6})
            Me.layoutControlGroup1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup1.Name = "Root"
            Me.layoutControlGroup1.Size = New System.Drawing.Size(190, 441)
            Me.layoutControlGroup1.TextVisible = False
            ' 
            ' layoutControlItem1
            ' 
            Me.layoutControlItem1.Control = Me.chSummary
            Me.layoutControlItem1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem1.Name = "layoutControlItem1"
            Me.layoutControlItem1.Size = New System.Drawing.Size(170, 23)
            Me.layoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem1.TextVisible = False
            ' 
            ' layoutControlItem2
            ' 
            Me.layoutControlItem2.Control = Me.chMultiSummary
            Me.layoutControlItem2.Location = New System.Drawing.Point(0, 23)
            Me.layoutControlItem2.Name = "layoutControlItem2"
            Me.layoutControlItem2.Size = New System.Drawing.Size(170, 23)
            Me.layoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem2.TextVisible = False
            ' 
            ' layoutControlItem3
            ' 
            Me.layoutControlItem3.Control = Me.chDisplaySummary
            Me.layoutControlItem3.Location = New System.Drawing.Point(0, 46)
            Me.layoutControlItem3.Name = "layoutControlItem3"
            Me.layoutControlItem3.Size = New System.Drawing.Size(170, 23)
            Me.layoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem3.TextVisible = False
            ' 
            ' layoutControlItem4
            ' 
            Me.layoutControlItem4.Control = Me.chAlignSummary
            Me.layoutControlItem4.Location = New System.Drawing.Point(26, 69)
            Me.layoutControlItem4.Name = "layoutControlItem4"
            Me.layoutControlItem4.Size = New System.Drawing.Size(144, 23)
            Me.layoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem4.TextVisible = False
            ' 
            ' emptySpaceItem2
            ' 
            Me.emptySpaceItem2.AllowHotTrack = False
            Me.emptySpaceItem2.Location = New System.Drawing.Point(0, 69)
            Me.emptySpaceItem2.Name = "emptySpaceItem2"
            Me.emptySpaceItem2.Size = New System.Drawing.Size(26, 23)
            Me.emptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
            ' 
            ' emptySpaceItem3
            ' 
            Me.emptySpaceItem3.AllowHotTrack = False
            Me.emptySpaceItem3.Location = New System.Drawing.Point(0, 92)
            Me.emptySpaceItem3.Name = "emptySpaceItem3"
            Me.emptySpaceItem3.Size = New System.Drawing.Size(170, 283)
            Me.emptySpaceItem3.TextSize = New System.Drawing.Size(0, 0)
            ' 
            ' layoutControlItem5
            ' 
            Me.layoutControlItem5.Control = Me.chShowFooter
            Me.layoutControlItem5.Location = New System.Drawing.Point(0, 375)
            Me.layoutControlItem5.Name = "layoutControlItem5"
            Me.layoutControlItem5.Size = New System.Drawing.Size(170, 23)
            Me.layoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem5.TextVisible = False
            ' 
            ' layoutControlItem6
            ' 
            Me.layoutControlItem6.Control = Me.ceMasterDetail
            Me.layoutControlItem6.Location = New System.Drawing.Point(0, 398)
            Me.layoutControlItem6.Name = "layoutControlItem6"
            Me.layoutControlItem6.Size = New System.Drawing.Size(170, 23)
            Me.layoutControlItem6.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem6.TextVisible = False
            ' 
            ' panelControl1
            ' 
            Me.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.panelControl1.Controls.Add(Me.gridControl1)
            resources.ApplyResources(Me.panelControl1, "panelControl1")
            Me.panelControl1.Name = "panelControl1"
            ' 
            ' DataSummaries
            ' 
            resources.ApplyResources(Me, "$this")
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.panelControl1)
            Me.Controls.Add(Me.navigationPane1)
            Me.Name = "DataSummaries"
            DirectCast(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.repositoryItemSpinEdit1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.repositoryItemLookUpEdit2, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.dsNWindProducts1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.advBandedGridView1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.repositoryItemImageComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.repositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.repositoryItemCalcEdit1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.navigationPane1.ResumeLayout(False)
            Me.navigationPage1.ResumeLayout(False)
            DirectCast(Me.layoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl1.ResumeLayout(False)
            DirectCast(Me.ceMasterDetail.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.chShowFooter.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.chAlignSummary.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.chDisplaySummary.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.chMultiSummary.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.chSummary.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.emptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.emptySpaceItem3, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panelControl1.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub

        #End Region

        Private colUnitsOnOrder As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Private colDiscount As DevExpress.XtraGrid.Columns.GridColumn
        Private gridBand1 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
        Private colProductName As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Private colCategoryID As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Private colProductID As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Private colSupplierID As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Private colDiscontinued As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Private gridBand2 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
        Private colUnitPrice As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Private colQuantityPerUnit As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Private colReorderLevel As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Private colUnitsInStock As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Private colOrderID As DevExpress.XtraGrid.Columns.GridColumn
        Private colPrice As DevExpress.XtraGrid.Columns.GridColumn
        Private WithEvents gridView1 As DevExpress.XtraGrid.Views.Grid.GridView
        Private colQuantity As DevExpress.XtraGrid.Columns.GridColumn
        Private advBandedGridView1 As DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView
        Private gridControl1 As DevExpress.XtraGrid.GridControl
        Private components As System.ComponentModel.IContainer = Nothing
        Private colSubTotal As DevExpress.XtraGrid.Columns.GridColumn
        Private repositoryItemImageComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox
        Private repositoryItemCalcEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
        Private repositoryItemSpinEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
        Private dsNWindProducts1 As dsNWindProducts
        Private repositoryItemLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Private navigationPane1 As XtraBars.Navigation.NavigationPane
        Private navigationPage1 As XtraBars.Navigation.NavigationPage
        Private layoutControl1 As XtraLayout.LayoutControl
        Private WithEvents chShowFooter As XtraEditors.CheckEdit
        Private WithEvents chAlignSummary As XtraEditors.CheckEdit
        Private WithEvents chDisplaySummary As XtraEditors.CheckEdit
        Private WithEvents chMultiSummary As XtraEditors.CheckEdit
        Private WithEvents chSummary As XtraEditors.CheckEdit
        Private layoutControlGroup1 As XtraLayout.LayoutControlGroup
        Private layoutControlItem1 As XtraLayout.LayoutControlItem
        Private layoutControlItem2 As XtraLayout.LayoutControlItem
        Private layoutControlItem3 As XtraLayout.LayoutControlItem
        Private layoutControlItem4 As XtraLayout.LayoutControlItem
        Private emptySpaceItem2 As XtraLayout.EmptySpaceItem
        Private emptySpaceItem3 As XtraLayout.EmptySpaceItem
        Private layoutControlItem5 As XtraLayout.LayoutControlItem
        Private panelControl1 As XtraEditors.PanelControl
        Private WithEvents ceMasterDetail As XtraEditors.CheckEdit
        Private layoutControlItem6 As XtraLayout.LayoutControlItem
        Private colProduct As Columns.GridColumn
        Private repositoryItemLookUpEdit2 As XtraEditors.Repository.RepositoryItemLookUpEdit
    End Class
End Namespace
