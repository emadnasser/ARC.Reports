Namespace DevExpress.XtraGrid.Demos
	Partial Public Class SearchLookUpEditDemo
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SearchLookUpEditDemo))
            Dim StyleFormatCondition1 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
            Dim StyleFormatCondition2 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
            Me.colCategoryID = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.repositoryItemImageComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox()
            Me.colDiscontinued = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.xtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
            Me.xtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
            Me.xtraScrollableControl1 = New DevExpress.XtraEditors.XtraScrollableControl()
            Me.panelControl1 = New DevExpress.XtraEditors.GroupControl()
            Me.dataNavigator1 = New DevExpress.XtraEditors.DataNavigator()
            Me.dsNWindProducts1 = New dsNWindProducts()
            Me.searchLookUpEdit1 = New DevExpress.XtraGrid.Demos.SearchLookUpEditWithGlyph()
            Me.gridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.colProductName = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colQuantityPerUnit = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colUnitPrice = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.imageList2 = New System.Windows.Forms.ImageList(Me.components)
            Me.xtraTabPage2 = New DevExpress.XtraTab.XtraTabPage()
            Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
            Me.dsNWindCustomers1 = New dsNWindCustomers()
            Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.colOrderID = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colCustomerID = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.repositoryItemSearchLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit()
            Me.repositoryItemSearchLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.colCompanyName = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colContactName = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colContactTitle = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colEmployeeID = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.repositoryItemSearchLookUpEdit2 = New DevExpress.XtraGrid.Demos.RepositoryItemSearchLookUpEditWithGlyph()
            Me.repositoryItemPictureEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit()
            Me.repositoryItemMemoEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
            Me.repositoryItemSearchLookUpEdit2View = New DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView()
            Me.gridBand1 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
            Me.colPhoto = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.gridBand2 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
            Me.colFirstName = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.colLastName = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.colNotes = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.colOrderDate = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colRequiredDate = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colShipName = New DevExpress.XtraGrid.Columns.GridColumn()
            CType(Me.repositoryItemImageComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.xtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.xtraTabControl1.SuspendLayout()
            Me.xtraTabPage1.SuspendLayout()
            Me.xtraScrollableControl1.SuspendLayout()
            CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panelControl1.SuspendLayout()
            CType(Me.dsNWindProducts1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.searchLookUpEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.xtraTabPage2.SuspendLayout()
            CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dsNWindCustomers1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repositoryItemSearchLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repositoryItemSearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repositoryItemSearchLookUpEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repositoryItemPictureEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repositoryItemSearchLookUpEdit2View, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'colCategoryID
            '
            Me.colCategoryID.ColumnEdit = Me.repositoryItemImageComboBox1
            Me.colCategoryID.FieldName = "CategoryID"
            resources.ApplyResources(Me.colCategoryID, "colCategoryID")
            Me.colCategoryID.Name = "colCategoryID"
            Me.colCategoryID.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.[True]
            Me.colCategoryID.OptionsColumn.AllowMove = False
            Me.colCategoryID.OptionsColumn.AllowSize = False
            Me.colCategoryID.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
            Me.colCategoryID.OptionsColumn.FixedWidth = True
            Me.colCategoryID.OptionsFilter.AllowFilter = False
            '
            'repositoryItemImageComboBox1
            '
            resources.ApplyResources(Me.repositoryItemImageComboBox1, "repositoryItemImageComboBox1")
            Me.repositoryItemImageComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("repositoryItemImageComboBox1.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
            Me.repositoryItemImageComboBox1.Items.AddRange(New DevExpress.XtraEditors.Controls.ImageComboBoxItem() {New DevExpress.XtraEditors.Controls.ImageComboBoxItem(resources.GetString("repositoryItemImageComboBox1.Items"), CType(resources.GetObject("repositoryItemImageComboBox1.Items1"), Object), CType(resources.GetObject("repositoryItemImageComboBox1.Items2"), Integer)), New DevExpress.XtraEditors.Controls.ImageComboBoxItem(resources.GetString("repositoryItemImageComboBox1.Items3"), CType(resources.GetObject("repositoryItemImageComboBox1.Items4"), Object), CType(resources.GetObject("repositoryItemImageComboBox1.Items5"), Integer)), New DevExpress.XtraEditors.Controls.ImageComboBoxItem(resources.GetString("repositoryItemImageComboBox1.Items6"), CType(resources.GetObject("repositoryItemImageComboBox1.Items7"), Object), CType(resources.GetObject("repositoryItemImageComboBox1.Items8"), Integer)), New DevExpress.XtraEditors.Controls.ImageComboBoxItem(resources.GetString("repositoryItemImageComboBox1.Items9"), CType(resources.GetObject("repositoryItemImageComboBox1.Items10"), Object), CType(resources.GetObject("repositoryItemImageComboBox1.Items11"), Integer)), New DevExpress.XtraEditors.Controls.ImageComboBoxItem(resources.GetString("repositoryItemImageComboBox1.Items12"), CType(resources.GetObject("repositoryItemImageComboBox1.Items13"), Object), CType(resources.GetObject("repositoryItemImageComboBox1.Items14"), Integer)), New DevExpress.XtraEditors.Controls.ImageComboBoxItem(resources.GetString("repositoryItemImageComboBox1.Items15"), CType(resources.GetObject("repositoryItemImageComboBox1.Items16"), Object), CType(resources.GetObject("repositoryItemImageComboBox1.Items17"), Integer)), New DevExpress.XtraEditors.Controls.ImageComboBoxItem(resources.GetString("repositoryItemImageComboBox1.Items18"), CType(resources.GetObject("repositoryItemImageComboBox1.Items19"), Object), CType(resources.GetObject("repositoryItemImageComboBox1.Items20"), Integer)), New DevExpress.XtraEditors.Controls.ImageComboBoxItem(resources.GetString("repositoryItemImageComboBox1.Items21"), CType(resources.GetObject("repositoryItemImageComboBox1.Items22"), Object), CType(resources.GetObject("repositoryItemImageComboBox1.Items23"), Integer))})
            Me.repositoryItemImageComboBox1.Name = "repositoryItemImageComboBox1"
            '
            'colDiscontinued
            '
            resources.ApplyResources(Me.colDiscontinued, "colDiscontinued")
            Me.colDiscontinued.FieldName = "Discontinued"
            Me.colDiscontinued.Name = "colDiscontinued"
            '
            'xtraTabControl1
            '
            resources.ApplyResources(Me.xtraTabControl1, "xtraTabControl1")
            Me.xtraTabControl1.Name = "xtraTabControl1"
            Me.xtraTabControl1.SelectedTabPage = Me.xtraTabPage1
            Me.xtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.xtraTabPage1, Me.xtraTabPage2})
            '
            'xtraTabPage1
            '
            Me.xtraTabPage1.Controls.Add(Me.xtraScrollableControl1)
            Me.xtraTabPage1.Name = "xtraTabPage1"
            resources.ApplyResources(Me.xtraTabPage1, "xtraTabPage1")
            '
            'xtraScrollableControl1
            '
            Me.xtraScrollableControl1.Controls.Add(Me.panelControl1)
            resources.ApplyResources(Me.xtraScrollableControl1, "xtraScrollableControl1")
            Me.xtraScrollableControl1.Name = "xtraScrollableControl1"
            '
            'panelControl1
            '
            Me.panelControl1.Appearance.BackColor = CType(resources.GetObject("panelControl1.Appearance.BackColor"), System.Drawing.Color)
            Me.panelControl1.Appearance.Options.UseBackColor = True
            Me.panelControl1.CaptionImageUri.Uri = ""
            Me.panelControl1.Controls.Add(Me.dataNavigator1)
            Me.panelControl1.Controls.Add(Me.searchLookUpEdit1)
            resources.ApplyResources(Me.panelControl1, "panelControl1")
            Me.panelControl1.Name = "panelControl1"
            '
            'dataNavigator1
            '
            Me.dataNavigator1.Buttons.Append.Visible = False
            Me.dataNavigator1.Buttons.CancelEdit.Visible = False
            Me.dataNavigator1.Buttons.EndEdit.Visible = False
            Me.dataNavigator1.Buttons.NextPage.Visible = False
            Me.dataNavigator1.Buttons.PrevPage.Visible = False
            Me.dataNavigator1.Buttons.Remove.Visible = False
            Me.dataNavigator1.DataSource = Me.dsNWindProducts1.Order_Details
            resources.ApplyResources(Me.dataNavigator1, "dataNavigator1")
            Me.dataNavigator1.Name = "dataNavigator1"
            '
            'dsNWindProducts1
            '
            Me.dsNWindProducts1.DataSetName = "dsNWindProducts"
            Me.dsNWindProducts1.Locale = New System.Globalization.CultureInfo("en-US")
            Me.dsNWindProducts1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
            '
            'searchLookUpEdit1
            '
            Me.searchLookUpEdit1.AllowDrop = True
            resources.ApplyResources(Me.searchLookUpEdit1, "searchLookUpEdit1")
            Me.searchLookUpEdit1.Image = Nothing
            Me.searchLookUpEdit1.Name = "searchLookUpEdit1"
            Me.searchLookUpEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("searchLookUpEdit1.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
            Me.searchLookUpEdit1.Properties.DataSource = Me.dsNWindProducts1.Products
            Me.searchLookUpEdit1.Properties.DisplayMember = "ProductName"
            Me.searchLookUpEdit1.Properties.PopupFormSize = New System.Drawing.Size(500, 0)
            Me.searchLookUpEdit1.Properties.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repositoryItemImageComboBox1})
            Me.searchLookUpEdit1.Properties.ValueMember = "ProductID"
            Me.searchLookUpEdit1.Properties.View = Me.gridLookUpEdit1View
            '
            'gridLookUpEdit1View
            '
            Me.gridLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCategoryID, Me.colProductName, Me.colQuantityPerUnit, Me.colUnitPrice, Me.colDiscontinued})
            Me.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
            StyleFormatCondition1.Appearance.ForeColor = CType(resources.GetObject("resource.ForeColor"), System.Drawing.Color)
            StyleFormatCondition1.Appearance.Options.UseForeColor = True
            StyleFormatCondition1.ApplyToRow = True
            StyleFormatCondition1.Column = Me.colCategoryID
            StyleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
            StyleFormatCondition1.Value1 = 1
            StyleFormatCondition2.Appearance.Font = CType(resources.GetObject("resource.Font"), System.Drawing.Font)
            StyleFormatCondition2.Appearance.ForeColor = CType(resources.GetObject("resource.ForeColor1"), System.Drawing.Color)
            StyleFormatCondition2.Appearance.Options.UseFont = True
            StyleFormatCondition2.Appearance.Options.UseForeColor = True
            StyleFormatCondition2.ApplyToRow = True
            StyleFormatCondition2.Column = Me.colDiscontinued
            StyleFormatCondition2.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
            StyleFormatCondition2.Value1 = True
            Me.gridLookUpEdit1View.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition1, StyleFormatCondition2})
            Me.gridLookUpEdit1View.Images = Me.imageList2
            Me.gridLookUpEdit1View.Name = "gridLookUpEdit1View"
            Me.gridLookUpEdit1View.OptionsFind.FindFilterColumns = "ProductName;QuantityPerUnit;UnitPrice"
            Me.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
            Me.gridLookUpEdit1View.OptionsView.ShowGroupPanel = False
            Me.gridLookUpEdit1View.OptionsView.ShowIndicator = False
            '
            'colProductName
            '
            resources.ApplyResources(Me.colProductName, "colProductName")
            Me.colProductName.FieldName = "ProductName"
            Me.colProductName.Name = "colProductName"
            '
            'colQuantityPerUnit
            '
            resources.ApplyResources(Me.colQuantityPerUnit, "colQuantityPerUnit")
            Me.colQuantityPerUnit.FieldName = "QuantityPerUnit"
            Me.colQuantityPerUnit.Name = "colQuantityPerUnit"
            '
            'colUnitPrice
            '
            resources.ApplyResources(Me.colUnitPrice, "colUnitPrice")
            Me.colUnitPrice.DisplayFormat.FormatString = "c"
            Me.colUnitPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colUnitPrice.FieldName = "UnitPrice"
            Me.colUnitPrice.Name = "colUnitPrice"
            '
            'imageList2
            '
            Me.imageList2.ImageStream = CType(resources.GetObject("imageList2.ImageStream"), System.Windows.Forms.ImageListStreamer)
            Me.imageList2.TransparentColor = System.Drawing.Color.Magenta
            Me.imageList2.Images.SetKeyName(0, "")
            '
            'xtraTabPage2
            '
            Me.xtraTabPage2.Controls.Add(Me.gridControl1)
            Me.xtraTabPage2.Name = "xtraTabPage2"
            resources.ApplyResources(Me.xtraTabPage2, "xtraTabPage2")
            '
            'gridControl1
            '
            Me.gridControl1.DataSource = Me.dsNWindCustomers1.Orders
            resources.ApplyResources(Me.gridControl1, "gridControl1")
            Me.gridControl1.MainView = Me.gridView1
            Me.gridControl1.Name = "gridControl1"
            Me.gridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repositoryItemSearchLookUpEdit1, Me.repositoryItemSearchLookUpEdit2})
            Me.gridControl1.ShowOnlyPredefinedDetails = True
            Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView1})
            '
            'dsNWindCustomers1
            '
            Me.dsNWindCustomers1.DataSetName = "dsNWindCustomers"
            Me.dsNWindCustomers1.Locale = New System.Globalization.CultureInfo("en-US")
            Me.dsNWindCustomers1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
            '
            'gridView1
            '
            Me.gridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colOrderID, Me.colCustomerID, Me.colEmployeeID, Me.colOrderDate, Me.colRequiredDate, Me.colShipName})
            Me.gridView1.GridControl = Me.gridControl1
            Me.gridView1.Name = "gridView1"
            '
            'colOrderID
            '
            resources.ApplyResources(Me.colOrderID, "colOrderID")
            Me.colOrderID.FieldName = "OrderID"
            Me.colOrderID.Name = "colOrderID"
            Me.colOrderID.OptionsFilter.AllowFilter = False
            '
            'colCustomerID
            '
            Me.colCustomerID.AppearanceHeader.Font = CType(resources.GetObject("colCustomerID.AppearanceHeader.Font"), System.Drawing.Font)
            Me.colCustomerID.AppearanceHeader.Options.UseFont = True
            resources.ApplyResources(Me.colCustomerID, "colCustomerID")
            Me.colCustomerID.ColumnEdit = Me.repositoryItemSearchLookUpEdit1
            Me.colCustomerID.FieldName = "CustomerID"
            Me.colCustomerID.Name = "colCustomerID"
            '
            'repositoryItemSearchLookUpEdit1
            '
            resources.ApplyResources(Me.repositoryItemSearchLookUpEdit1, "repositoryItemSearchLookUpEdit1")
            Me.repositoryItemSearchLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("repositoryItemSearchLookUpEdit1.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
            Me.repositoryItemSearchLookUpEdit1.DataSource = Me.dsNWindCustomers1.Customers
            Me.repositoryItemSearchLookUpEdit1.DisplayMember = "CompanyName"
            Me.repositoryItemSearchLookUpEdit1.Name = "repositoryItemSearchLookUpEdit1"
            Me.repositoryItemSearchLookUpEdit1.PopupFormSize = New System.Drawing.Size(400, 0)
            Me.repositoryItemSearchLookUpEdit1.ValueMember = "CustomerID"
            Me.repositoryItemSearchLookUpEdit1.View = Me.repositoryItemSearchLookUpEdit1View
            '
            'repositoryItemSearchLookUpEdit1View
            '
            Me.repositoryItemSearchLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCompanyName, Me.colContactName, Me.colContactTitle})
            Me.repositoryItemSearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
            Me.repositoryItemSearchLookUpEdit1View.Name = "repositoryItemSearchLookUpEdit1View"
            Me.repositoryItemSearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
            Me.repositoryItemSearchLookUpEdit1View.OptionsView.AutoCalcPreviewLineCount = True
            Me.repositoryItemSearchLookUpEdit1View.OptionsView.ShowAutoFilterRow = True
            Me.repositoryItemSearchLookUpEdit1View.OptionsView.ShowGroupPanel = False
            Me.repositoryItemSearchLookUpEdit1View.OptionsView.ShowIndicator = False
            Me.repositoryItemSearchLookUpEdit1View.OptionsView.ShowPreview = True
            '
            'colCompanyName
            '
            resources.ApplyResources(Me.colCompanyName, "colCompanyName")
            Me.colCompanyName.FieldName = "CompanyName"
            Me.colCompanyName.Name = "colCompanyName"
            '
            'colContactName
            '
            resources.ApplyResources(Me.colContactName, "colContactName")
            Me.colContactName.FieldName = "ContactName"
            Me.colContactName.Name = "colContactName"
            '
            'colContactTitle
            '
            resources.ApplyResources(Me.colContactTitle, "colContactTitle")
            Me.colContactTitle.FieldName = "ContactTitle"
            Me.colContactTitle.Name = "colContactTitle"
            '
            'colEmployeeID
            '
            Me.colEmployeeID.AppearanceHeader.Font = CType(resources.GetObject("colEmployeeID.AppearanceHeader.Font"), System.Drawing.Font)
            Me.colEmployeeID.AppearanceHeader.Options.UseFont = True
            resources.ApplyResources(Me.colEmployeeID, "colEmployeeID")
            Me.colEmployeeID.ColumnEdit = Me.repositoryItemSearchLookUpEdit2
            Me.colEmployeeID.FieldName = "EmployeeID"
            Me.colEmployeeID.Name = "colEmployeeID"
            '
            'repositoryItemSearchLookUpEdit2
            '
            resources.ApplyResources(Me.repositoryItemSearchLookUpEdit2, "repositoryItemSearchLookUpEdit2")
            Me.repositoryItemSearchLookUpEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("repositoryItemSearchLookUpEdit2.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
            Me.repositoryItemSearchLookUpEdit2.DataSource = Me.dsNWindCustomers1.Employees
            Me.repositoryItemSearchLookUpEdit2.DisplayMember = "Name"
            Me.repositoryItemSearchLookUpEdit2.Name = "repositoryItemSearchLookUpEdit2"
            Me.repositoryItemSearchLookUpEdit2.PopupFormSize = New System.Drawing.Size(400, 0)
            Me.repositoryItemSearchLookUpEdit2.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repositoryItemPictureEdit1, Me.repositoryItemMemoEdit1})
            Me.repositoryItemSearchLookUpEdit2.ValueMember = "EmployeeID"
            Me.repositoryItemSearchLookUpEdit2.View = Me.repositoryItemSearchLookUpEdit2View
            Me.repositoryItemSearchLookUpEdit2.ViewType = DevExpress.XtraEditors.Repository.GridLookUpViewType.AdvBandedView
            '
            'repositoryItemPictureEdit1
            '
            Me.repositoryItemPictureEdit1.Name = "repositoryItemPictureEdit1"
            Me.repositoryItemPictureEdit1.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze
            '
            'repositoryItemMemoEdit1
            '
            Me.repositoryItemMemoEdit1.Name = "repositoryItemMemoEdit1"
            '
            'repositoryItemSearchLookUpEdit2View
            '
            Me.repositoryItemSearchLookUpEdit2View.Bands.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() {Me.gridBand1, Me.gridBand2})
            Me.repositoryItemSearchLookUpEdit2View.Columns.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn() {Me.colPhoto, Me.colFirstName, Me.colLastName, Me.colNotes})
            Me.repositoryItemSearchLookUpEdit2View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
            Me.repositoryItemSearchLookUpEdit2View.Name = "repositoryItemSearchLookUpEdit2View"
            Me.repositoryItemSearchLookUpEdit2View.OptionsSelection.EnableAppearanceFocusedCell = False
            Me.repositoryItemSearchLookUpEdit2View.OptionsView.ColumnAutoWidth = True
            Me.repositoryItemSearchLookUpEdit2View.OptionsView.ShowColumnHeaders = False
            Me.repositoryItemSearchLookUpEdit2View.OptionsView.ShowGroupPanel = False
            Me.repositoryItemSearchLookUpEdit2View.OptionsView.ShowIndicator = False
            '
            'gridBand1
            '
            resources.ApplyResources(Me.gridBand1, "gridBand1")
            Me.gridBand1.Columns.Add(Me.colPhoto)
            Me.gridBand1.OptionsBand.FixedWidth = True
            Me.gridBand1.VisibleIndex = 0
            '
            'colPhoto
            '
            resources.ApplyResources(Me.colPhoto, "colPhoto")
            Me.colPhoto.ColumnEdit = Me.repositoryItemPictureEdit1
            Me.colPhoto.FieldName = "Photo"
            Me.colPhoto.Name = "colPhoto"
            Me.colPhoto.RowCount = 4
            '
            'gridBand2
            '
            resources.ApplyResources(Me.gridBand2, "gridBand2")
            Me.gridBand2.Columns.Add(Me.colFirstName)
            Me.gridBand2.Columns.Add(Me.colLastName)
            Me.gridBand2.Columns.Add(Me.colNotes)
            Me.gridBand2.VisibleIndex = 1
            '
            'colFirstName
            '
            resources.ApplyResources(Me.colFirstName, "colFirstName")
            Me.colFirstName.FieldName = "FirstName"
            Me.colFirstName.Name = "colFirstName"
            '
            'colLastName
            '
            resources.ApplyResources(Me.colLastName, "colLastName")
            Me.colLastName.FieldName = "LastName"
            Me.colLastName.Name = "colLastName"
            '
            'colNotes
            '
            Me.colNotes.AutoFillDown = True
            resources.ApplyResources(Me.colNotes, "colNotes")
            Me.colNotes.ColumnEdit = Me.repositoryItemMemoEdit1
            Me.colNotes.FieldName = "Notes"
            Me.colNotes.Name = "colNotes"
            Me.colNotes.RowIndex = 1
            '
            'colOrderDate
            '
            resources.ApplyResources(Me.colOrderDate, "colOrderDate")
            Me.colOrderDate.FieldName = "OrderDate"
            Me.colOrderDate.Name = "colOrderDate"
            '
            'colRequiredDate
            '
            resources.ApplyResources(Me.colRequiredDate, "colRequiredDate")
            Me.colRequiredDate.FieldName = "RequiredDate"
            Me.colRequiredDate.Name = "colRequiredDate"
            '
            'colShipName
            '
            resources.ApplyResources(Me.colShipName, "colShipName")
            Me.colShipName.FieldName = "ShipName"
            Me.colShipName.Name = "colShipName"
            '
            'SearchLookUpEditDemo
            '
            resources.ApplyResources(Me, "$this")
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.xtraTabControl1)
            Me.Name = "SearchLookUpEditDemo"
            CType(Me.repositoryItemImageComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.xtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.xtraTabControl1.ResumeLayout(False)
            Me.xtraTabPage1.ResumeLayout(False)
            Me.xtraScrollableControl1.ResumeLayout(False)
            CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panelControl1.ResumeLayout(False)
            CType(Me.dsNWindProducts1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.searchLookUpEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
            Me.xtraTabPage2.ResumeLayout(False)
            CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dsNWindCustomers1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repositoryItemSearchLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repositoryItemSearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repositoryItemSearchLookUpEdit2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repositoryItemPictureEdit1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repositoryItemSearchLookUpEdit2View, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

		#End Region
		Private xtraTabControl1 As DevExpress.XtraTab.XtraTabControl
		Private xtraTabPage1 As DevExpress.XtraTab.XtraTabPage
		Private xtraTabPage2 As DevExpress.XtraTab.XtraTabPage
		Private panelControl1 As DevExpress.XtraEditors.GroupControl
		Private WithEvents searchLookUpEdit1 As SearchLookUpEditWithGlyph
		Private gridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
		Private dsNWindProducts1 As dsNWindProducts
		Private dataNavigator1 As DevExpress.XtraEditors.DataNavigator
		Private colCategoryID As DevExpress.XtraGrid.Columns.GridColumn
		Private colProductName As DevExpress.XtraGrid.Columns.GridColumn
		Private colQuantityPerUnit As DevExpress.XtraGrid.Columns.GridColumn
		Private colUnitPrice As DevExpress.XtraGrid.Columns.GridColumn
		Private colDiscontinued As DevExpress.XtraGrid.Columns.GridColumn
		Private repositoryItemImageComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox
        Private imageList2 As System.Windows.Forms.ImageList
		Private gridControl1 As DevExpress.XtraGrid.GridControl
		Private gridView1 As DevExpress.XtraGrid.Views.Grid.GridView
		Private colCustomerID As DevExpress.XtraGrid.Columns.GridColumn
		Private colEmployeeID As DevExpress.XtraGrid.Columns.GridColumn
		Private colOrderDate As DevExpress.XtraGrid.Columns.GridColumn
		Private colOrderID As DevExpress.XtraGrid.Columns.GridColumn
		Private colRequiredDate As DevExpress.XtraGrid.Columns.GridColumn
		Private colShipName As DevExpress.XtraGrid.Columns.GridColumn
		Private repositoryItemSearchLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit
		Private WithEvents repositoryItemSearchLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
		Private colCompanyName As DevExpress.XtraGrid.Columns.GridColumn
		Private colContactName As DevExpress.XtraGrid.Columns.GridColumn
		Private colContactTitle As DevExpress.XtraGrid.Columns.GridColumn
		Private repositoryItemSearchLookUpEdit2 As RepositoryItemSearchLookUpEditWithGlyph
		Private repositoryItemSearchLookUpEdit2View As DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView
		Private gridBand1 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
		Private gridBand2 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
		Private colPhoto As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
		Private repositoryItemPictureEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit
		Private colFirstName As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
		Private colLastName As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
		Private colNotes As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
		Private repositoryItemMemoEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
		Private dsNWindCustomers1 As dsNWindCustomers
		Private components As System.ComponentModel.IContainer = Nothing
		Private xtraScrollableControl1 As DevExpress.XtraEditors.XtraScrollableControl

	End Class
End Namespace
