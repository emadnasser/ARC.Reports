Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.XtraBars.Demos.BarEditors
	Public Partial Class frmMain
		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing Then
				If Not components Is Nothing Then
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
            Me.lastOrder = New DevExpress.XtraBars.BarEditItem()
            Me.repositoryItemDateEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
            Me.barDockControl4 = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControl3 = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControl2 = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControl1 = New DevExpress.XtraBars.BarDockControl()
            Me.iClearFilter = New DevExpress.XtraBars.BarButtonItem()
            Me.iRecords = New DevExpress.XtraBars.BarStaticItem()
            Me.mFile = New DevExpress.XtraBars.BarSubItem()
            Me.iExit = New DevExpress.XtraBars.BarButtonItem()
            Me.barManager1 = New DevExpress.XtraBars.BarManager(Me.components)
            Me.bar1 = New DevExpress.XtraBars.Bar()
            Me.mFilter = New DevExpress.XtraBars.BarSubItem()
            Me.discontinued = New DevExpress.XtraBars.BarEditItem()
            Me.repositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
            Me.categories = New DevExpress.XtraBars.BarEditItem()
            Me.repositoryImageComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox()
            Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
            Me.iAbout = New DevExpress.XtraBars.BarButtonItem()
            Me.bar2 = New DevExpress.XtraBars.Bar()
            Me.bar3 = New DevExpress.XtraBars.Bar()
            Me.iFilter = New DevExpress.XtraBars.BarStaticItem()
            Me.bar4 = New DevExpress.XtraBars.Bar()
            Me.iPaintStyle = New DevExpress.XtraBars.BarSubItem()
            Me.ipsDefault = New DevExpress.XtraBars.BarButtonItem()
            Me.ipsWXP = New DevExpress.XtraBars.BarButtonItem()
            Me.ipsOXP = New DevExpress.XtraBars.BarButtonItem()
            Me.ipsO2K = New DevExpress.XtraBars.BarButtonItem()
            Me.ipsO3 = New DevExpress.XtraBars.BarButtonItem()
            Me.imageList2 = New System.Windows.Forms.ImageList(Me.components)
            Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
            Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.colProductID = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colProductName = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colCategoryID = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colQuantityPerUnit = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colUnitPrice = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colUnitsInStock = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colUnitsOnOrder = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colReorderLevel = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colDiscontinued = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colLastOrder = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
            CType(Me.repositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repositoryItemDateEdit1.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.barManager1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repositoryImageComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panelControl1.SuspendLayout()
            Me.SuspendLayout()
            '
            'lastOrder
            '
            Me.lastOrder.Caption = "Last Order Date < "
            Me.lastOrder.CategoryGuid = New System.Guid("db1c445d-a939-4427-90b2-c7daba2f0f9a")
            Me.lastOrder.Edit = Me.repositoryItemDateEdit1
            Me.lastOrder.EditValue = ""
            Me.lastOrder.Id = 8
            Me.lastOrder.Name = "lastOrder"
            Me.lastOrder.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.Caption
            '
            'repositoryItemDateEdit1
            '
            Me.repositoryItemDateEdit1.AllowFocused = False
            Me.repositoryItemDateEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.repositoryItemDateEdit1.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.repositoryItemDateEdit1.CalendarTimeProperties.CloseUpKey = New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4)
            Me.repositoryItemDateEdit1.CalendarTimeProperties.PopupBorderStyle = DevExpress.XtraEditors.Controls.PopupBorderStyles.[Default]
            Me.repositoryItemDateEdit1.Name = "repositoryItemDateEdit1"
            Me.repositoryItemDateEdit1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
            '
            'barDockControl4
            '
            Me.barDockControl4.CausesValidation = False
            Me.barDockControl4.Dock = System.Windows.Forms.DockStyle.Right
            Me.barDockControl4.Location = New System.Drawing.Point(692, 53)
            Me.barDockControl4.Size = New System.Drawing.Size(0, 240)
            '
            'barDockControl3
            '
            Me.barDockControl3.CausesValidation = False
            Me.barDockControl3.Dock = System.Windows.Forms.DockStyle.Left
            Me.barDockControl3.Location = New System.Drawing.Point(0, 53)
            Me.barDockControl3.Size = New System.Drawing.Size(0, 240)
            '
            'barDockControl2
            '
            Me.barDockControl2.CausesValidation = False
            Me.barDockControl2.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.barDockControl2.Location = New System.Drawing.Point(0, 293)
            Me.barDockControl2.Size = New System.Drawing.Size(692, 28)
            '
            'barDockControl1
            '
            Me.barDockControl1.CausesValidation = False
            Me.barDockControl1.Dock = System.Windows.Forms.DockStyle.Top
            Me.barDockControl1.Location = New System.Drawing.Point(0, 0)
            Me.barDockControl1.Size = New System.Drawing.Size(692, 53)
            '
            'iClearFilter
            '
            Me.iClearFilter.Caption = "Clear Filter"
            Me.iClearFilter.CategoryGuid = New System.Guid("db1c445d-a939-4427-90b2-c7daba2f0f9a")
            Me.iClearFilter.Id = 9
            Me.iClearFilter.ImageIndex = 2
            Me.iClearFilter.Name = "iClearFilter"
            '
            'iRecords
            '
            Me.iRecords.AutoSize = DevExpress.XtraBars.BarStaticItemSize.None
            Me.iRecords.Caption = "Records: "
            Me.iRecords.CategoryGuid = New System.Guid("c50efb7e-86d5-43db-8f6a-468d77d38888")
            Me.iRecords.Id = 6
            Me.iRecords.Name = "iRecords"
            Me.iRecords.RightIndent = 3
            Me.iRecords.TextAlignment = System.Drawing.StringAlignment.Near
            Me.iRecords.Width = 80
            '
            'mFile
            '
            Me.mFile.Caption = "&File"
            Me.mFile.CategoryGuid = New System.Guid("01b4aa47-f56a-49b3-845b-a6dde012966a")
            Me.mFile.Id = 1
            Me.mFile.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.iExit)})
            Me.mFile.Name = "mFile"
            '
            'iExit
            '
            Me.iExit.Caption = "E&xit"
            Me.iExit.CategoryGuid = New System.Guid("2ce5e5b3-891d-4ed7-b3ba-c54e77a23318")
            Me.iExit.Id = 4
            Me.iExit.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X))
            Me.iExit.Name = "iExit"
            '
            'barManager1
            '
            Me.barManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.bar1, Me.bar2, Me.bar3, Me.bar4})
            Me.barManager1.Categories.AddRange(New DevExpress.XtraBars.BarManagerCategory() {New DevExpress.XtraBars.BarManagerCategory("Built-in Menus", New System.Guid("01b4aa47-f56a-49b3-845b-a6dde012966a")), New DevExpress.XtraBars.BarManagerCategory("File", New System.Guid("2ce5e5b3-891d-4ed7-b3ba-c54e77a23318")), New DevExpress.XtraBars.BarManagerCategory("Filter", New System.Guid("db1c445d-a939-4427-90b2-c7daba2f0f9a")), New DevExpress.XtraBars.BarManagerCategory("Status", New System.Guid("c50efb7e-86d5-43db-8f6a-468d77d38888")), New DevExpress.XtraBars.BarManagerCategory("PaintStyles", New System.Guid("d0173875-bf7b-4740-b252-5047db62606c"))})
            Me.barManager1.DockControls.Add(Me.barDockControl1)
            Me.barManager1.DockControls.Add(Me.barDockControl2)
            Me.barManager1.DockControls.Add(Me.barDockControl3)
            Me.barManager1.DockControls.Add(Me.barDockControl4)
            Me.barManager1.Form = Me
            Me.barManager1.Images = Me.imageList2
            Me.barManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.mFile, Me.mFilter, Me.iExit, Me.discontinued, Me.iRecords, Me.iFilter, Me.lastOrder, Me.iClearFilter, Me.categories, Me.iAbout, Me.iPaintStyle, Me.ipsWXP, Me.ipsOXP, Me.ipsO2K, Me.ipsO3, Me.ipsDefault})
            Me.barManager1.MainMenu = Me.bar1
            Me.barManager1.MaxItemId = 16
            Me.barManager1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repositoryItemCheckEdit1, Me.repositoryItemDateEdit1, Me.repositoryImageComboBox1})
            Me.barManager1.StatusBar = Me.bar3
            '
            'bar1
            '
            Me.bar1.BarName = "Main"
            Me.bar1.DockCol = 0
            Me.bar1.DockRow = 0
            Me.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
            Me.bar1.FloatLocation = New System.Drawing.Point(30, 142)
            Me.bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.mFile), New DevExpress.XtraBars.LinkPersistInfo(Me.mFilter), New DevExpress.XtraBars.LinkPersistInfo(Me.iAbout)})
            Me.bar1.OptionsBar.AllowQuickCustomization = False
            Me.bar1.OptionsBar.DrawDragBorder = False
            Me.bar1.OptionsBar.MultiLine = True
            Me.bar1.OptionsBar.UseWholeRow = True
            Me.bar1.Text = "Main"
            '
            'mFilter
            '
            Me.mFilter.Caption = "F&ilter"
            Me.mFilter.CategoryGuid = New System.Guid("01b4aa47-f56a-49b3-845b-a6dde012966a")
            Me.mFilter.Id = 2
            Me.mFilter.ImageIndex = 1
            Me.mFilter.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.Width, Me.discontinued, "", False, True, True, 104), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.Width, Me.lastOrder, "", False, True, True, 104), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.Width, Me.categories, "", False, True, True, 104)})
            Me.mFilter.Name = "mFilter"
            Me.mFilter.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
            '
            'discontinued
            '
            Me.discontinued.Caption = "Discontinued: "
            Me.discontinued.CategoryGuid = New System.Guid("db1c445d-a939-4427-90b2-c7daba2f0f9a")
            Me.discontinued.Edit = Me.repositoryItemCheckEdit1
            Me.discontinued.Id = 5
            Me.discontinued.Name = "discontinued"
            Me.discontinued.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.Caption
            '
            'repositoryItemCheckEdit1
            '
            Me.repositoryItemCheckEdit1.AllowFocused = False
            Me.repositoryItemCheckEdit1.AllowGrayed = True
            Me.repositoryItemCheckEdit1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.[Default]
            Me.repositoryItemCheckEdit1.Caption = "Check"
            Me.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1"
            '
            'categories
            '
            Me.categories.Caption = "Categories:"
            Me.categories.CategoryGuid = New System.Guid("db1c445d-a939-4427-90b2-c7daba2f0f9a")
            Me.categories.Edit = Me.repositoryImageComboBox1
            Me.categories.Id = 10
            Me.categories.Name = "categories"
            Me.categories.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.Caption
            '
            'repositoryImageComboBox1
            '
            Me.repositoryImageComboBox1.AllowFocused = False
            Me.repositoryImageComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.repositoryImageComboBox1.Name = "repositoryImageComboBox1"
            Me.repositoryImageComboBox1.SmallImages = Me.imageList1
            '
            'imageList1
            '
            Me.imageList1.ImageStream = CType(resources.GetObject("imageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
            Me.imageList1.TransparentColor = System.Drawing.Color.Magenta
            Me.imageList1.Images.SetKeyName(0, "")
            Me.imageList1.Images.SetKeyName(1, "")
            Me.imageList1.Images.SetKeyName(2, "")
            Me.imageList1.Images.SetKeyName(3, "")
            Me.imageList1.Images.SetKeyName(4, "")
            Me.imageList1.Images.SetKeyName(5, "")
            Me.imageList1.Images.SetKeyName(6, "")
            Me.imageList1.Images.SetKeyName(7, "")
            '
            'iAbout
            '
            Me.iAbout.Caption = "&About"
            Me.iAbout.CategoryGuid = New System.Guid("01b4aa47-f56a-49b3-845b-a6dde012966a")
            Me.iAbout.Id = 10
            Me.iAbout.ImageIndex = 0
            Me.iAbout.Name = "iAbout"
            Me.iAbout.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
            '
            'bar2
            '
            Me.bar2.BarName = "Filter"
            Me.bar2.DockCol = 0
            Me.bar2.DockRow = 1
            Me.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
            Me.bar2.FloatLocation = New System.Drawing.Point(50, 143)
            Me.bar2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.discontinued), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.Width, Me.lastOrder, "", False, True, True, 100), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.Width, Me.categories, "", False, True, True, 113), New DevExpress.XtraBars.LinkPersistInfo(Me.iClearFilter, True)})
            Me.bar2.Text = "Filter"
            '
            'bar3
            '
            Me.bar3.BarName = "Status"
            Me.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
            Me.bar3.DockCol = 0
            Me.bar3.DockRow = 0
            Me.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
            Me.bar3.FloatLocation = New System.Drawing.Point(51, 454)
            Me.bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.iRecords), New DevExpress.XtraBars.LinkPersistInfo(Me.iFilter)})
            Me.bar3.OptionsBar.AllowQuickCustomization = False
            Me.bar3.OptionsBar.DrawDragBorder = False
            Me.bar3.OptionsBar.DrawSizeGrip = True
            Me.bar3.OptionsBar.RotateWhenVertical = False
            Me.bar3.OptionsBar.UseWholeRow = True
            Me.bar3.Text = "Status"
            '
            'iFilter
            '
            Me.iFilter.AutoSize = DevExpress.XtraBars.BarStaticItemSize.Spring
            Me.iFilter.Caption = "Filter"
            Me.iFilter.CategoryGuid = New System.Guid("c50efb7e-86d5-43db-8f6a-468d77d38888")
            Me.iFilter.Id = 7
            Me.iFilter.Name = "iFilter"
            Me.iFilter.TextAlignment = System.Drawing.StringAlignment.Near
            Me.iFilter.Width = 455
            '
            'bar4
            '
            Me.bar4.BarName = "PaintStyle"
            Me.bar4.DockCol = 1
            Me.bar4.DockRow = 1
            Me.bar4.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
            Me.bar4.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.iPaintStyle)})
            Me.bar4.Offset = 741
            Me.bar4.OptionsBar.AllowQuickCustomization = False
            Me.bar4.OptionsBar.RotateWhenVertical = False
            Me.bar4.Text = "PaintStyle"
            '
            'iPaintStyle
            '
            Me.iPaintStyle.Caption = "Paint Style"
            Me.iPaintStyle.CategoryGuid = New System.Guid("d0173875-bf7b-4740-b252-5047db62606c")
            Me.iPaintStyle.Id = 10
            Me.iPaintStyle.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.ipsDefault), New DevExpress.XtraBars.LinkPersistInfo(Me.ipsWXP), New DevExpress.XtraBars.LinkPersistInfo(Me.ipsOXP), New DevExpress.XtraBars.LinkPersistInfo(Me.ipsO2K), New DevExpress.XtraBars.LinkPersistInfo(Me.ipsO3)})
            Me.iPaintStyle.Name = "iPaintStyle"
            Me.iPaintStyle.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
            '
            'ipsDefault
            '
            Me.ipsDefault.Caption = "Default"
            Me.ipsDefault.CategoryGuid = New System.Guid("d0173875-bf7b-4740-b252-5047db62606c")
            Me.ipsDefault.Description = "Default"
            Me.ipsDefault.Id = 15
            Me.ipsDefault.Name = "ipsDefault"
            '
            'ipsWXP
            '
            Me.ipsWXP.Caption = "Windows XP"
            Me.ipsWXP.CategoryGuid = New System.Guid("d0173875-bf7b-4740-b252-5047db62606c")
            Me.ipsWXP.Description = "WindowsXP"
            Me.ipsWXP.Id = 11
            Me.ipsWXP.ImageIndex = 5
            Me.ipsWXP.Name = "ipsWXP"
            '
            'ipsOXP
            '
            Me.ipsOXP.Caption = "Office XP"
            Me.ipsOXP.CategoryGuid = New System.Guid("d0173875-bf7b-4740-b252-5047db62606c")
            Me.ipsOXP.Description = "OfficeXP"
            Me.ipsOXP.Id = 12
            Me.ipsOXP.ImageIndex = 3
            Me.ipsOXP.Name = "ipsOXP"
            '
            'ipsO2K
            '
            Me.ipsO2K.Caption = "Office 2000"
            Me.ipsO2K.CategoryGuid = New System.Guid("d0173875-bf7b-4740-b252-5047db62606c")
            Me.ipsO2K.Description = "Office2000"
            Me.ipsO2K.Id = 13
            Me.ipsO2K.ImageIndex = 4
            Me.ipsO2K.Name = "ipsO2K"
            '
            'ipsO3
            '
            Me.ipsO3.Caption = "Office 2003"
            Me.ipsO3.CategoryGuid = New System.Guid("d0173875-bf7b-4740-b252-5047db62606c")
            Me.ipsO3.Description = "Office2003"
            Me.ipsO3.Id = 14
            Me.ipsO3.ImageIndex = 6
            Me.ipsO3.Name = "ipsO3"
            '
            'imageList2
            '
            Me.imageList2.ImageStream = CType(resources.GetObject("imageList2.ImageStream"), System.Windows.Forms.ImageListStreamer)
            Me.imageList2.TransparentColor = System.Drawing.Color.Magenta
            Me.imageList2.Images.SetKeyName(0, "")
            Me.imageList2.Images.SetKeyName(1, "")
            Me.imageList2.Images.SetKeyName(2, "")
            Me.imageList2.Images.SetKeyName(3, "")
            Me.imageList2.Images.SetKeyName(4, "")
            Me.imageList2.Images.SetKeyName(5, "")
            Me.imageList2.Images.SetKeyName(6, "")
            '
            'gridControl1
            '
            Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.gridControl1.Location = New System.Drawing.Point(4, 4)
            Me.gridControl1.MainView = Me.gridView1
            Me.gridControl1.Name = "gridControl1"
            Me.gridControl1.Size = New System.Drawing.Size(684, 232)
            Me.gridControl1.TabIndex = 4
            Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView1})
            '
            'gridView1
            '
            Me.gridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colProductID, Me.colProductName, Me.colCategoryID, Me.colQuantityPerUnit, Me.colUnitPrice, Me.colUnitsInStock, Me.colUnitsOnOrder, Me.colReorderLevel, Me.colDiscontinued, Me.colLastOrder})
            Me.gridView1.GridControl = Me.gridControl1
            Me.gridView1.Name = "gridView1"
            Me.gridView1.OptionsBehavior.Editable = False
            Me.gridView1.OptionsCustomization.AllowFilter = False
            Me.gridView1.OptionsView.ShowGroupPanel = False
            '
            'colProductID
            '
            Me.colProductID.Caption = "ID"
            Me.colProductID.FieldName = "ProductID"
            Me.colProductID.Name = "colProductID"
            Me.colProductID.Visible = True
            Me.colProductID.VisibleIndex = 0
            Me.colProductID.Width = 60
            '
            'colProductName
            '
            Me.colProductName.Caption = "Product Name"
            Me.colProductName.FieldName = "ProductName"
            Me.colProductName.Name = "colProductName"
            Me.colProductName.Visible = True
            Me.colProductName.VisibleIndex = 1
            Me.colProductName.Width = 172
            '
            'colCategoryID
            '
            Me.colCategoryID.Caption = "Category"
            Me.colCategoryID.FieldName = "CategoryID"
            Me.colCategoryID.Name = "colCategoryID"
            Me.colCategoryID.Visible = True
            Me.colCategoryID.VisibleIndex = 2
            Me.colCategoryID.Width = 105
            '
            'colQuantityPerUnit
            '
            Me.colQuantityPerUnit.Caption = "Quantity Per Unit"
            Me.colQuantityPerUnit.FieldName = "QuantityPerUnit"
            Me.colQuantityPerUnit.Name = "colQuantityPerUnit"
            Me.colQuantityPerUnit.Visible = True
            Me.colQuantityPerUnit.VisibleIndex = 4
            Me.colQuantityPerUnit.Width = 109
            '
            'colUnitPrice
            '
            Me.colUnitPrice.Caption = "Unit Price"
            Me.colUnitPrice.DisplayFormat.FormatString = "c"
            Me.colUnitPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colUnitPrice.FieldName = "UnitPrice"
            Me.colUnitPrice.Name = "colUnitPrice"
            Me.colUnitPrice.Visible = True
            Me.colUnitPrice.VisibleIndex = 6
            Me.colUnitPrice.Width = 61
            '
            'colUnitsInStock
            '
            Me.colUnitsInStock.Caption = "Units In Stock"
            Me.colUnitsInStock.FieldName = "UnitsInStock"
            Me.colUnitsInStock.Name = "colUnitsInStock"
            Me.colUnitsInStock.Width = 83
            '
            'colUnitsOnOrder
            '
            Me.colUnitsOnOrder.Caption = "Units On Order"
            Me.colUnitsOnOrder.FieldName = "UnitsOnOrder"
            Me.colUnitsOnOrder.Name = "colUnitsOnOrder"
            Me.colUnitsOnOrder.Width = 88
            '
            'colReorderLevel
            '
            Me.colReorderLevel.Caption = "Reorder Level"
            Me.colReorderLevel.FieldName = "ReorderLevel"
            Me.colReorderLevel.Name = "colReorderLevel"
            Me.colReorderLevel.Width = 86
            '
            'colDiscontinued
            '
            Me.colDiscontinued.Caption = "Discontinued"
            Me.colDiscontinued.FieldName = "Discontinued"
            Me.colDiscontinued.Name = "colDiscontinued"
            Me.colDiscontinued.Visible = True
            Me.colDiscontinued.VisibleIndex = 5
            Me.colDiscontinued.Width = 73
            '
            'colLastOrder
            '
            Me.colLastOrder.Caption = "Last Order"
            Me.colLastOrder.FieldName = "LastOrder"
            Me.colLastOrder.Name = "colLastOrder"
            Me.colLastOrder.Visible = True
            Me.colLastOrder.VisibleIndex = 3
            Me.colLastOrder.Width = 65
            '
            'panelControl1
            '
            Me.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.panelControl1.Controls.Add(Me.gridControl1)
            Me.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.panelControl1.Location = New System.Drawing.Point(0, 53)
            Me.panelControl1.Name = "panelControl1"
            Me.panelControl1.Padding = New System.Windows.Forms.Padding(4)
            Me.panelControl1.Size = New System.Drawing.Size(692, 240)
            Me.panelControl1.TabIndex = 5
            '
            'frmMain
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.ClientSize = New System.Drawing.Size(692, 321)
            Me.Controls.Add(Me.panelControl1)
            Me.Controls.Add(Me.barDockControl3)
            Me.Controls.Add(Me.barDockControl4)
            Me.Controls.Add(Me.barDockControl2)
            Me.Controls.Add(Me.barDockControl1)
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Name = "frmMain"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "BarEditors (VB Demo)"
            CType(Me.repositoryItemDateEdit1.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.barManager1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repositoryImageComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panelControl1.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub

		#End Region
		Private barManager1 As DevExpress.XtraBars.BarManager
		Private barDockControl1 As DevExpress.XtraBars.BarDockControl
		Private barDockControl2 As DevExpress.XtraBars.BarDockControl
		Private barDockControl3 As DevExpress.XtraBars.BarDockControl
		Private barDockControl4 As DevExpress.XtraBars.BarDockControl
		Private mFile As DevExpress.XtraBars.BarSubItem
		Private mFilter As DevExpress.XtraBars.BarSubItem
		Private WithEvents iExit As DevExpress.XtraBars.BarButtonItem
		Private imageList1 As System.Windows.Forms.ImageList
		Private imageList2 As System.Windows.Forms.ImageList
		Private WithEvents discontinued As DevExpress.XtraBars.BarEditItem
		Private repositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
		Private iRecords As DevExpress.XtraBars.BarStaticItem
		Private iFilter As DevExpress.XtraBars.BarStaticItem
		Private WithEvents lastOrder As DevExpress.XtraBars.BarEditItem
		Private repositoryItemDateEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
		Private WithEvents iClearFilter As DevExpress.XtraBars.BarButtonItem
		Private WithEvents categories As DevExpress.XtraBars.BarEditItem
		Private repositoryImageComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox
		Private WithEvents iAbout As DevExpress.XtraBars.BarButtonItem
		Private bar1 As DevExpress.XtraBars.Bar
		Private bar2 As DevExpress.XtraBars.Bar
		Private bar3 As DevExpress.XtraBars.Bar
		Private bar4 As DevExpress.XtraBars.Bar
		Private iPaintStyle As DevExpress.XtraBars.BarSubItem
		Private WithEvents ipsWXP As DevExpress.XtraBars.BarButtonItem
		Private WithEvents ipsOXP As DevExpress.XtraBars.BarButtonItem
		Private WithEvents ipsO2K As DevExpress.XtraBars.BarButtonItem
		Private WithEvents ipsO3 As DevExpress.XtraBars.BarButtonItem
		Private WithEvents ipsDefault As DevExpress.XtraBars.BarButtonItem
		Private gridControl1 As DevExpress.XtraGrid.GridControl
		Private gridView1 As DevExpress.XtraGrid.Views.Grid.GridView
		Private colProductID As DevExpress.XtraGrid.Columns.GridColumn
		Private colProductName As DevExpress.XtraGrid.Columns.GridColumn
		Private colCategoryID As DevExpress.XtraGrid.Columns.GridColumn
		Private colQuantityPerUnit As DevExpress.XtraGrid.Columns.GridColumn
		Private colUnitPrice As DevExpress.XtraGrid.Columns.GridColumn
		Private colUnitsInStock As DevExpress.XtraGrid.Columns.GridColumn
		Private colUnitsOnOrder As DevExpress.XtraGrid.Columns.GridColumn
		Private colReorderLevel As DevExpress.XtraGrid.Columns.GridColumn
		Private colDiscontinued As DevExpress.XtraGrid.Columns.GridColumn
		Private colLastOrder As DevExpress.XtraGrid.Columns.GridColumn
		Private panelControl1 As DevExpress.XtraEditors.PanelControl
		Private components As System.ComponentModel.IContainer

	End Class
End Namespace
