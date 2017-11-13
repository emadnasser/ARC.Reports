Namespace DevExpress.XtraGrid.Demos
    Partial Public Class ColumnCustomization
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
            Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(ColumnCustomization))
            Me.checkEdit3 = New DevExpress.XtraEditors.CheckEdit()
            Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl()
            Me.checkEdit4 = New DevExpress.XtraEditors.CheckEdit()
            Me.simpleButton1 = New DevExpress.XtraEditors.SimpleButton()
            Me.checkEdit1 = New DevExpress.XtraEditors.CheckEdit()
            Me.checkEdit2 = New DevExpress.XtraEditors.CheckEdit()
            Me.ccbSnapMode = New DevExpress.XtraEditors.CheckedComboBoxEdit()
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.emptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.emptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.layoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.emptySpaceItem3 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
            Me.advBandedGridView1 = New DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView()
            Me.gridBand4 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
            Me.gridBand5 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
            Me.colFirstName = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.colLastName = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.gridBand6 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
            Me.colCountry = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.colCity = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.colRegion = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.colPostalCode = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.colAddress = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.gridBand7 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
            Me.colBirthDate = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.colHireDate = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.colTitle = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.colTitleOfCourtesy = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.colHomePhone = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.colExtension = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.colPhoto = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.colNotes = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.repositoryItemMemoEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
            Me.gridBand1 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
            Me.gridBand3 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
            Me.colOrderID = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.colUnitPrice = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.repositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
            Me.colQuantity = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.repositoryItemSpinEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
            Me.colDiscount = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.repositoryItemTextEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
            Me.gridBand2 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
            Me.colProductName = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.colDiscontinued = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.colQuantityPerUnit = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.colReorderLevel = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.colUnitsInStock = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.colUnitsOnOrder = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.colIcon = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.colCategoryName = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.gridBand8 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
            Me.gridBand9 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
            Me.colCustomers_CompanyName = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.colContactTitle = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.colContactName = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.gridBand10 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
            Me.colCustomers_Phone = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.colFax = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.navigationPane1 = New DevExpress.XtraBars.Navigation.NavigationPane()
            Me.navigationPage1 = New DevExpress.XtraBars.Navigation.NavigationPage()
            Me.panel1 = New System.Windows.Forms.Panel()
            DirectCast(Me.checkEdit3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl1.SuspendLayout()
            DirectCast(Me.checkEdit4.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.checkEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.checkEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.ccbSnapMode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.emptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.emptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.emptySpaceItem3, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.advBandedGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.repositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.repositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.repositoryItemSpinEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.repositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.navigationPane1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.navigationPane1.SuspendLayout()
            Me.navigationPage1.SuspendLayout()
            Me.panel1.SuspendLayout()
            Me.SuspendLayout()
            ' 
            ' checkEdit3
            ' 
            resources.ApplyResources(Me.checkEdit3, "checkEdit3")
            Me.checkEdit3.Name = "checkEdit3"
            Me.checkEdit3.Properties.Caption = resources.GetString("checkEdit3.Properties.Caption")
            Me.checkEdit3.StyleController = Me.layoutControl1
            ' 
            ' layoutControl1
            ' 
            Me.layoutControl1.AllowCustomization = False
            Me.layoutControl1.Controls.Add(Me.checkEdit4)
            Me.layoutControl1.Controls.Add(Me.checkEdit3)
            Me.layoutControl1.Controls.Add(Me.simpleButton1)
            Me.layoutControl1.Controls.Add(Me.checkEdit1)
            Me.layoutControl1.Controls.Add(Me.checkEdit2)
            Me.layoutControl1.Controls.Add(Me.ccbSnapMode)
            resources.ApplyResources(Me.layoutControl1, "layoutControl1")
            Me.layoutControl1.Name = "layoutControl1"
            Me.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(1032, 180, 695, 586)
            Me.layoutControl1.Root = Me.layoutControlGroup1
            ' 
            ' checkEdit4
            ' 
            resources.ApplyResources(Me.checkEdit4, "checkEdit4")
            Me.checkEdit4.Name = "checkEdit4"
            Me.checkEdit4.Properties.Caption = resources.GetString("checkEdit4.Properties.Caption")
            Me.checkEdit4.StyleController = Me.layoutControl1
            ' 
            ' simpleButton1
            ' 
            resources.ApplyResources(Me.simpleButton1, "simpleButton1")
            Me.simpleButton1.Name = "simpleButton1"
            Me.simpleButton1.StyleController = Me.layoutControl1
            ' 
            ' checkEdit1
            ' 
            resources.ApplyResources(Me.checkEdit1, "checkEdit1")
            Me.checkEdit1.Name = "checkEdit1"
            Me.checkEdit1.Properties.Caption = resources.GetString("checkEdit1.Properties.Caption")
            Me.checkEdit1.StyleController = Me.layoutControl1
            ' 
            ' checkEdit2
            ' 
            resources.ApplyResources(Me.checkEdit2, "checkEdit2")
            Me.checkEdit2.Name = "checkEdit2"
            Me.checkEdit2.Properties.Caption = resources.GetString("checkEdit2.Properties.Caption")
            Me.checkEdit2.StyleController = Me.layoutControl1
            ' 
            ' ccbSnapMode
            ' 
            resources.ApplyResources(Me.ccbSnapMode, "ccbSnapMode")
            Me.ccbSnapMode.Name = "ccbSnapMode"
            Me.ccbSnapMode.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton((DirectCast(resources.GetObject("ccbSnapMode.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines)))})
            Me.ccbSnapMode.StyleController = Me.layoutControl1
            ' 
            ' layoutControlGroup1
            ' 
            Me.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True
            Me.layoutControlGroup1.GroupBordersVisible = False
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.layoutControlItem1, Me.layoutControlItem3, Me.layoutControlItem2, Me.layoutControlItem4, Me.emptySpaceItem1, Me.emptySpaceItem2, Me.layoutControlItem5, Me.layoutControlItem6, Me.emptySpaceItem3})
            Me.layoutControlGroup1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup1.Name = "Root"
            Me.layoutControlGroup1.Size = New System.Drawing.Size(237, 505)
            Me.layoutControlGroup1.TextVisible = False
            ' 
            ' layoutControlItem1
            ' 
            Me.layoutControlItem1.Control = Me.simpleButton1
            Me.layoutControlItem1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem1.Name = "layoutControlItem1"
            Me.layoutControlItem1.Size = New System.Drawing.Size(217, 24)
            Me.layoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem1.TextVisible = False
            ' 
            ' layoutControlItem3
            ' 
            Me.layoutControlItem3.Control = Me.checkEdit2
            Me.layoutControlItem3.Location = New System.Drawing.Point(0, 34)
            Me.layoutControlItem3.Name = "layoutControlItem3"
            Me.layoutControlItem3.Size = New System.Drawing.Size(217, 23)
            Me.layoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem3.TextVisible = False
            ' 
            ' layoutControlItem2
            ' 
            Me.layoutControlItem2.Control = Me.checkEdit1
            Me.layoutControlItem2.Location = New System.Drawing.Point(0, 57)
            Me.layoutControlItem2.Name = "layoutControlItem2"
            Me.layoutControlItem2.Size = New System.Drawing.Size(217, 23)
            Me.layoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem2.TextVisible = False
            ' 
            ' layoutControlItem4
            ' 
            Me.layoutControlItem4.Control = Me.checkEdit3
            Me.layoutControlItem4.Location = New System.Drawing.Point(0, 80)
            Me.layoutControlItem4.Name = "layoutControlItem4"
            Me.layoutControlItem4.Size = New System.Drawing.Size(217, 23)
            Me.layoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem4.TextVisible = False
            ' 
            ' emptySpaceItem1
            ' 
            Me.emptySpaceItem1.AllowHotTrack = False
            Me.emptySpaceItem1.Location = New System.Drawing.Point(0, 24)
            Me.emptySpaceItem1.MaxSize = New System.Drawing.Size(0, 10)
            Me.emptySpaceItem1.MinSize = New System.Drawing.Size(10, 10)
            Me.emptySpaceItem1.Name = "emptySpaceItem1"
            Me.emptySpaceItem1.Size = New System.Drawing.Size(217, 10)
            Me.emptySpaceItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.emptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
            ' 
            ' emptySpaceItem2
            ' 
            Me.emptySpaceItem2.AllowHotTrack = False
            Me.emptySpaceItem2.Location = New System.Drawing.Point(0, 176)
            Me.emptySpaceItem2.Name = "emptySpaceItem2"
            Me.emptySpaceItem2.Size = New System.Drawing.Size(217, 309)
            Me.emptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
            ' 
            ' layoutControlItem5
            ' 
            Me.layoutControlItem5.Control = Me.checkEdit4
            Me.layoutControlItem5.Location = New System.Drawing.Point(0, 103)
            Me.layoutControlItem5.Name = "layoutControlItem5"
            Me.layoutControlItem5.Size = New System.Drawing.Size(217, 23)
            Me.layoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem5.TextVisible = False
            ' 
            ' layoutControlItem6
            ' 
            Me.layoutControlItem6.Control = Me.ccbSnapMode
            Me.layoutControlItem6.Location = New System.Drawing.Point(0, 136)
            Me.layoutControlItem6.Name = "layoutControlItem6"
            Me.layoutControlItem6.Size = New System.Drawing.Size(217, 40)
            resources.ApplyResources(Me.layoutControlItem6, "layoutControlItem6")
            Me.layoutControlItem6.TextLocation = DevExpress.Utils.Locations.Top
            Me.layoutControlItem6.TextSize = New System.Drawing.Size(154, 13)
            ' 
            ' emptySpaceItem3
            ' 
            Me.emptySpaceItem3.AllowHotTrack = False
            Me.emptySpaceItem3.Location = New System.Drawing.Point(0, 126)
            Me.emptySpaceItem3.Name = "emptySpaceItem3"
            Me.emptySpaceItem3.Size = New System.Drawing.Size(217, 10)
            Me.emptySpaceItem3.TextSize = New System.Drawing.Size(0, 0)
            ' 
            ' gridControl1
            ' 
            resources.ApplyResources(Me.gridControl1, "gridControl1")
            Me.gridControl1.MainView = Me.advBandedGridView1
            Me.gridControl1.Name = "gridControl1"
            Me.gridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() { Me.repositoryItemSpinEdit1, Me.repositoryItemMemoEdit1, Me.repositoryItemTextEdit1, Me.repositoryItemTextEdit2})
            Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.advBandedGridView1})
            ' 
            ' advBandedGridView1
            ' 
            Me.advBandedGridView1.Bands.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() { Me.gridBand4, Me.gridBand1, Me.gridBand8})
            Me.advBandedGridView1.Columns.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn() { Me.colOrderID, Me.colUnitPrice, Me.colQuantity, Me.colDiscount, Me.colProductName, Me.colCategoryName, Me.colQuantityPerUnit, Me.colReorderLevel, Me.colUnitsInStock, Me.colUnitsOnOrder, Me.colDiscontinued, Me.colIcon, Me.colFirstName, Me.colLastName, Me.colTitle, Me.colTitleOfCourtesy, Me.colBirthDate, Me.colHireDate, Me.colAddress, Me.colCity, Me.colCountry, Me.colPostalCode, Me.colRegion, Me.colNotes, Me.colHomePhone, Me.colExtension, Me.colPhoto, Me.colCustomers_CompanyName, Me.colContactName, Me.colContactTitle, Me.colCustomers_Phone, Me.colFax})
            Me.advBandedGridView1.GridControl = Me.gridControl1
            Me.advBandedGridView1.Name = "advBandedGridView1"
            Me.advBandedGridView1.OptionsClipboard.ClipboardMode = DevExpress.Export.ClipboardMode.Formatted
            Me.advBandedGridView1.OptionsCustomization.AllowChangeColumnParent = True
            Me.advBandedGridView1.OptionsCustomization.CustomizationFormSearchBoxVisible = True
            Me.advBandedGridView1.OptionsCustomization.CustomizationFormSnapMode = (CType((DevExpress.Utils.Controls.SnapMode.OwnerControl Or DevExpress.Utils.Controls.SnapMode.OwnerForm), DevExpress.Utils.Controls.SnapMode))
            Me.advBandedGridView1.OptionsView.AllowGlyphSkinning = True
            Me.advBandedGridView1.OptionsView.AllowHtmlDrawHeaders = True
            Me.advBandedGridView1.OptionsView.ShowGroupPanel = False
            Me.advBandedGridView1.RowSeparatorHeight = 1
            Me.advBandedGridView1.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() { New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colOrderID, DevExpress.Data.ColumnSortOrder.Ascending)})
            ' 
            ' gridBand4
            ' 
            resources.ApplyResources(Me.gridBand4, "gridBand4")
            Me.gridBand4.Children.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() { Me.gridBand5, Me.gridBand6, Me.gridBand7})
            Me.gridBand4.VisibleIndex = 0
            ' 
            ' gridBand5
            ' 
            resources.ApplyResources(Me.gridBand5, "gridBand5")
            Me.gridBand5.Columns.Add(Me.colFirstName)
            Me.gridBand5.Columns.Add(Me.colLastName)
            Me.gridBand5.VisibleIndex = 0
            ' 
            ' colFirstName
            ' 
            Me.colFirstName.FieldName = "FirstName"
            Me.colFirstName.Name = "colFirstName"
            resources.ApplyResources(Me.colFirstName, "colFirstName")
            ' 
            ' colLastName
            ' 
            Me.colLastName.FieldName = "LastName"
            Me.colLastName.Name = "colLastName"
            Me.colLastName.RowIndex = 1
            resources.ApplyResources(Me.colLastName, "colLastName")
            ' 
            ' gridBand6
            ' 
            resources.ApplyResources(Me.gridBand6, "gridBand6")
            Me.gridBand6.Columns.Add(Me.colCountry)
            Me.gridBand6.Columns.Add(Me.colCity)
            Me.gridBand6.Columns.Add(Me.colRegion)
            Me.gridBand6.Columns.Add(Me.colPostalCode)
            Me.gridBand6.Columns.Add(Me.colAddress)
            Me.gridBand6.VisibleIndex = 1
            ' 
            ' colCountry
            ' 
            resources.ApplyResources(Me.colCountry, "colCountry")
            Me.colCountry.FieldName = "Employees.Country"
            Me.colCountry.Name = "colCountry"
            ' 
            ' colCity
            ' 
            resources.ApplyResources(Me.colCity, "colCity")
            Me.colCity.FieldName = "Employees.City"
            Me.colCity.Name = "colCity"
            ' 
            ' colRegion
            ' 
            resources.ApplyResources(Me.colRegion, "colRegion")
            Me.colRegion.FieldName = "Employees.Region"
            Me.colRegion.Name = "colRegion"
            ' 
            ' colPostalCode
            ' 
            resources.ApplyResources(Me.colPostalCode, "colPostalCode")
            Me.colPostalCode.FieldName = "Employees.PostalCode"
            Me.colPostalCode.Name = "colPostalCode"
            ' 
            ' colAddress
            ' 
            resources.ApplyResources(Me.colAddress, "colAddress")
            Me.colAddress.FieldName = "Employees.Address"
            Me.colAddress.Name = "colAddress"
            Me.colAddress.RowIndex = 1
            ' 
            ' gridBand7
            ' 
            resources.ApplyResources(Me.gridBand7, "gridBand7")
            Me.gridBand7.Columns.Add(Me.colBirthDate)
            Me.gridBand7.Columns.Add(Me.colHireDate)
            Me.gridBand7.Columns.Add(Me.colTitle)
            Me.gridBand7.Columns.Add(Me.colTitleOfCourtesy)
            Me.gridBand7.Columns.Add(Me.colHomePhone)
            Me.gridBand7.Columns.Add(Me.colExtension)
            Me.gridBand7.Columns.Add(Me.colPhoto)
            Me.gridBand7.Columns.Add(Me.colNotes)
            Me.gridBand7.Image = (DirectCast(resources.GetObject("gridBand7.Image"), System.Drawing.Image))
            Me.gridBand7.VisibleIndex = -1
            ' 
            ' colBirthDate
            ' 
            Me.colBirthDate.FieldName = "BirthDate"
            Me.colBirthDate.Name = "colBirthDate"
            ' 
            ' colHireDate
            ' 
            Me.colHireDate.FieldName = "HireDate"
            Me.colHireDate.Image = (DirectCast(resources.GetObject("colHireDate.Image"), System.Drawing.Image))
            Me.colHireDate.Name = "colHireDate"
            ' 
            ' colTitle
            ' 
            Me.colTitle.FieldName = "Title"
            Me.colTitle.Name = "colTitle"
            ' 
            ' colTitleOfCourtesy
            ' 
            Me.colTitleOfCourtesy.FieldName = "TitleOfCourtesy"
            Me.colTitleOfCourtesy.Name = "colTitleOfCourtesy"
            ' 
            ' colHomePhone
            ' 
            Me.colHomePhone.FieldName = "HomePhone"
            Me.colHomePhone.Name = "colHomePhone"
            ' 
            ' colExtension
            ' 
            Me.colExtension.FieldName = "Extension"
            Me.colExtension.Name = "colExtension"
            ' 
            ' colPhoto
            ' 
            Me.colPhoto.FieldName = "Photo"
            Me.colPhoto.Name = "colPhoto"
            Me.colPhoto.RowCount = 2
            resources.ApplyResources(Me.colPhoto, "colPhoto")
            ' 
            ' colNotes
            ' 
            Me.colNotes.ColumnEdit = Me.repositoryItemMemoEdit1
            Me.colNotes.FieldName = "Notes"
            Me.colNotes.Name = "colNotes"
            Me.colNotes.RowCount = 2
            resources.ApplyResources(Me.colNotes, "colNotes")
            ' 
            ' repositoryItemMemoEdit1
            ' 
            Me.repositoryItemMemoEdit1.Name = "repositoryItemMemoEdit1"
            ' 
            ' gridBand1
            ' 
            resources.ApplyResources(Me.gridBand1, "gridBand1")
            Me.gridBand1.Children.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() { Me.gridBand3, Me.gridBand2})
            Me.gridBand1.Image = (DirectCast(resources.GetObject("gridBand1.Image"), System.Drawing.Image))
            Me.gridBand1.VisibleIndex = 1
            ' 
            ' gridBand3
            ' 
            resources.ApplyResources(Me.gridBand3, "gridBand3")
            Me.gridBand3.Columns.Add(Me.colOrderID)
            Me.gridBand3.Columns.Add(Me.colUnitPrice)
            Me.gridBand3.Columns.Add(Me.colQuantity)
            Me.gridBand3.Columns.Add(Me.colDiscount)
            Me.gridBand3.VisibleIndex = 0
            ' 
            ' colOrderID
            ' 
            resources.ApplyResources(Me.colOrderID, "colOrderID")
            Me.colOrderID.FieldName = "Order Details.OrderID"
            Me.colOrderID.Name = "colOrderID"
            ' 
            ' colUnitPrice
            ' 
            resources.ApplyResources(Me.colUnitPrice, "colUnitPrice")
            Me.colUnitPrice.ColumnEdit = Me.repositoryItemTextEdit1
            Me.colUnitPrice.FieldName = "Order Details.UnitPrice"
            Me.colUnitPrice.Name = "colUnitPrice"
            ' 
            ' repositoryItemTextEdit1
            ' 
            resources.ApplyResources(Me.repositoryItemTextEdit1, "repositoryItemTextEdit1")
            Me.repositoryItemTextEdit1.Mask.EditMask = resources.GetString("repositoryItemTextEdit1.Mask.EditMask")
            Me.repositoryItemTextEdit1.Mask.MaskType = (DirectCast(resources.GetObject("repositoryItemTextEdit1.Mask.MaskType"), DevExpress.XtraEditors.Mask.MaskType))
            Me.repositoryItemTextEdit1.Mask.UseMaskAsDisplayFormat = (DirectCast(resources.GetObject("repositoryItemTextEdit1.Mask.UseMaskAsDisplayFormat"), Boolean))
            Me.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1"
            ' 
            ' colQuantity
            ' 
            Me.colQuantity.ColumnEdit = Me.repositoryItemSpinEdit1
            Me.colQuantity.FieldName = "Quantity"
            Me.colQuantity.Name = "colQuantity"
            Me.colQuantity.RowIndex = 1
            resources.ApplyResources(Me.colQuantity, "colQuantity")
            ' 
            ' repositoryItemSpinEdit1
            ' 
            resources.ApplyResources(Me.repositoryItemSpinEdit1, "repositoryItemSpinEdit1")
            Me.repositoryItemSpinEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton((DirectCast(resources.GetObject("repositoryItemSpinEdit1.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines)))})
            Me.repositoryItemSpinEdit1.IsFloatValue = False
            Me.repositoryItemSpinEdit1.Mask.EditMask = resources.GetString("repositoryItemSpinEdit1.Mask.EditMask")
            Me.repositoryItemSpinEdit1.Name = "repositoryItemSpinEdit1"
            ' 
            ' colDiscount
            ' 
            Me.colDiscount.ColumnEdit = Me.repositoryItemTextEdit2
            Me.colDiscount.FieldName = "Discount"
            Me.colDiscount.Name = "colDiscount"
            Me.colDiscount.RowIndex = 1
            resources.ApplyResources(Me.colDiscount, "colDiscount")
            ' 
            ' repositoryItemTextEdit2
            ' 
            resources.ApplyResources(Me.repositoryItemTextEdit2, "repositoryItemTextEdit2")
            Me.repositoryItemTextEdit2.Mask.EditMask = resources.GetString("repositoryItemTextEdit2.Mask.EditMask")
            Me.repositoryItemTextEdit2.Mask.MaskType = (DirectCast(resources.GetObject("repositoryItemTextEdit2.Mask.MaskType"), DevExpress.XtraEditors.Mask.MaskType))
            Me.repositoryItemTextEdit2.Mask.UseMaskAsDisplayFormat = (DirectCast(resources.GetObject("repositoryItemTextEdit2.Mask.UseMaskAsDisplayFormat"), Boolean))
            Me.repositoryItemTextEdit2.Name = "repositoryItemTextEdit2"
            ' 
            ' gridBand2
            ' 
            resources.ApplyResources(Me.gridBand2, "gridBand2")
            Me.gridBand2.Columns.Add(Me.colProductName)
            Me.gridBand2.Columns.Add(Me.colDiscontinued)
            Me.gridBand2.Columns.Add(Me.colQuantityPerUnit)
            Me.gridBand2.Columns.Add(Me.colReorderLevel)
            Me.gridBand2.Columns.Add(Me.colUnitsInStock)
            Me.gridBand2.Columns.Add(Me.colUnitsOnOrder)
            Me.gridBand2.Columns.Add(Me.colIcon)
            Me.gridBand2.Columns.Add(Me.colCategoryName)
            Me.gridBand2.VisibleIndex = 1
            ' 
            ' colProductName
            ' 
            Me.colProductName.FieldName = "ProductName"
            Me.colProductName.Name = "colProductName"
            resources.ApplyResources(Me.colProductName, "colProductName")
            ' 
            ' colDiscontinued
            ' 
            Me.colDiscontinued.FieldName = "Discontinued"
            Me.colDiscontinued.Image = (DirectCast(resources.GetObject("colDiscontinued.Image"), System.Drawing.Image))
            Me.colDiscontinued.Name = "colDiscontinued"
            ' 
            ' colQuantityPerUnit
            ' 
            Me.colQuantityPerUnit.FieldName = "QuantityPerUnit"
            Me.colQuantityPerUnit.Name = "colQuantityPerUnit"
            ' 
            ' colReorderLevel
            ' 
            Me.colReorderLevel.ColumnEdit = Me.repositoryItemSpinEdit1
            Me.colReorderLevel.FieldName = "ReorderLevel"
            Me.colReorderLevel.Name = "colReorderLevel"
            ' 
            ' colUnitsInStock
            ' 
            Me.colUnitsInStock.ColumnEdit = Me.repositoryItemSpinEdit1
            Me.colUnitsInStock.FieldName = "UnitsInStock"
            Me.colUnitsInStock.Name = "colUnitsInStock"
            ' 
            ' colUnitsOnOrder
            ' 
            Me.colUnitsOnOrder.ColumnEdit = Me.repositoryItemSpinEdit1
            Me.colUnitsOnOrder.FieldName = "UnitsOnOrder"
            Me.colUnitsOnOrder.Name = "colUnitsOnOrder"
            ' 
            ' colIcon
            ' 
            resources.ApplyResources(Me.colIcon, "colIcon")
            Me.colIcon.FieldName = "Icon_17"
            Me.colIcon.Image = (DirectCast(resources.GetObject("colIcon.Image"), System.Drawing.Image))
            Me.colIcon.Name = "colIcon"
            Me.colIcon.OptionsColumn.ShowCaption = False
            Me.colIcon.OptionsFilter.AllowFilter = False
            Me.colIcon.RowIndex = 1
            ' 
            ' colCategoryName
            ' 
            Me.colCategoryName.FieldName = "CategoryName"
            Me.colCategoryName.Name = "colCategoryName"
            Me.colCategoryName.RowIndex = 1
            resources.ApplyResources(Me.colCategoryName, "colCategoryName")
            ' 
            ' gridBand8
            ' 
            resources.ApplyResources(Me.gridBand8, "gridBand8")
            Me.gridBand8.Children.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() { Me.gridBand9, Me.gridBand10})
            Me.gridBand8.VisibleIndex = -1
            ' 
            ' gridBand9
            ' 
            resources.ApplyResources(Me.gridBand9, "gridBand9")
            Me.gridBand9.Columns.Add(Me.colCustomers_CompanyName)
            Me.gridBand9.Columns.Add(Me.colContactTitle)
            Me.gridBand9.Columns.Add(Me.colContactName)
            Me.gridBand9.VisibleIndex = -1
            ' 
            ' colCustomers_CompanyName
            ' 
            resources.ApplyResources(Me.colCustomers_CompanyName, "colCustomers_CompanyName")
            Me.colCustomers_CompanyName.FieldName = "Customers.CompanyName"
            Me.colCustomers_CompanyName.Name = "colCustomers_CompanyName"
            ' 
            ' colContactTitle
            ' 
            Me.colContactTitle.FieldName = "ContactTitle"
            Me.colContactTitle.Name = "colContactTitle"
            Me.colContactTitle.RowIndex = 1
            resources.ApplyResources(Me.colContactTitle, "colContactTitle")
            ' 
            ' colContactName
            ' 
            Me.colContactName.FieldName = "ContactName"
            Me.colContactName.Name = "colContactName"
            Me.colContactName.RowIndex = 1
            resources.ApplyResources(Me.colContactName, "colContactName")
            ' 
            ' gridBand10
            ' 
            resources.ApplyResources(Me.gridBand10, "gridBand10")
            Me.gridBand10.Columns.Add(Me.colCustomers_Phone)
            Me.gridBand10.Columns.Add(Me.colFax)
            Me.gridBand10.VisibleIndex = -1
            ' 
            ' colCustomers_Phone
            ' 
            resources.ApplyResources(Me.colCustomers_Phone, "colCustomers_Phone")
            Me.colCustomers_Phone.FieldName = "Customers.Phone"
            Me.colCustomers_Phone.Name = "colCustomers_Phone"
            ' 
            ' colFax
            ' 
            Me.colFax.FieldName = "Fax"
            Me.colFax.Name = "colFax"
            Me.colFax.RowIndex = 1
            resources.ApplyResources(Me.colFax, "colFax")
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
            Me.navigationPane1.RegularSize = New System.Drawing.Size(287, 565)
            Me.navigationPane1.SelectedPage = Me.navigationPage1
            ' 
            ' navigationPage1
            ' 
            Me.navigationPage1.Caption = "Options"
            Me.navigationPage1.Controls.Add(Me.layoutControl1)
            Me.navigationPage1.Image = (DirectCast(resources.GetObject("navigationPage1.Image"), System.Drawing.Image))
            Me.navigationPage1.Name = "navigationPage1"
            resources.ApplyResources(Me.navigationPage1, "navigationPage1")
            ' 
            ' panel1
            ' 
            Me.panel1.Controls.Add(Me.gridControl1)
            resources.ApplyResources(Me.panel1, "panel1")
            Me.panel1.Name = "panel1"
            ' 
            ' ColumnCustomization
            ' 
            resources.ApplyResources(Me, "$this")
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.panel1)
            Me.Controls.Add(Me.navigationPane1)
            Me.Name = "ColumnCustomization"
            DirectCast(Me.checkEdit3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl1.ResumeLayout(False)
            DirectCast(Me.checkEdit4.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.checkEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.checkEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.ccbSnapMode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.emptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.emptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.emptySpaceItem3, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.advBandedGridView1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.repositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.repositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.repositoryItemSpinEdit1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.repositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.navigationPane1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.navigationPane1.ResumeLayout(False)
            Me.navigationPage1.ResumeLayout(False)
            Me.panel1.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub

        #End Region
        Private gridControl1 As DevExpress.XtraGrid.GridControl
        Private WithEvents simpleButton1 As DevExpress.XtraEditors.SimpleButton
        Private WithEvents checkEdit1 As DevExpress.XtraEditors.CheckEdit
        Private WithEvents checkEdit2 As DevExpress.XtraEditors.CheckEdit
        Private WithEvents checkEdit3 As DevExpress.XtraEditors.CheckEdit
        Private components As System.ComponentModel.IContainer = Nothing
        Private layoutControl1 As XtraLayout.LayoutControl
        Private layoutControlGroup1 As XtraLayout.LayoutControlGroup
        Private layoutControlItem1 As XtraLayout.LayoutControlItem
        Private layoutControlItem3 As XtraLayout.LayoutControlItem
        Private layoutControlItem2 As XtraLayout.LayoutControlItem
        Private layoutControlItem4 As XtraLayout.LayoutControlItem
        Private emptySpaceItem1 As XtraLayout.EmptySpaceItem
        Private emptySpaceItem2 As XtraLayout.EmptySpaceItem
        Private WithEvents advBandedGridView1 As Views.BandedGrid.AdvBandedGridView
        Private colUnitPrice As Views.BandedGrid.BandedGridColumn
        Private colOrderID As Views.BandedGrid.BandedGridColumn
        Private colQuantity As Views.BandedGrid.BandedGridColumn
        Private colDiscount As Views.BandedGrid.BandedGridColumn
        Private colProductName As Views.BandedGrid.BandedGridColumn
        Private colCategoryName As Views.BandedGrid.BandedGridColumn
        Private colDiscontinued As Views.BandedGrid.BandedGridColumn
        Private colQuantityPerUnit As Views.BandedGrid.BandedGridColumn
        Private colReorderLevel As Views.BandedGrid.BandedGridColumn
        Private colUnitsInStock As Views.BandedGrid.BandedGridColumn
        Private colUnitsOnOrder As Views.BandedGrid.BandedGridColumn
        Private colIcon As Views.BandedGrid.BandedGridColumn
        Private repositoryItemSpinEdit1 As XtraEditors.Repository.RepositoryItemSpinEdit
        Private colFirstName As Views.BandedGrid.BandedGridColumn
        Private colLastName As Views.BandedGrid.BandedGridColumn
        Private colCountry As Views.BandedGrid.BandedGridColumn
        Private colRegion As Views.BandedGrid.BandedGridColumn
        Private colCity As Views.BandedGrid.BandedGridColumn
        Private colAddress As Views.BandedGrid.BandedGridColumn
        Private colPostalCode As Views.BandedGrid.BandedGridColumn
        Private colBirthDate As Views.BandedGrid.BandedGridColumn
        Private colHireDate As Views.BandedGrid.BandedGridColumn
        Private colTitle As Views.BandedGrid.BandedGridColumn
        Private colTitleOfCourtesy As Views.BandedGrid.BandedGridColumn
        Private colHomePhone As Views.BandedGrid.BandedGridColumn
        Private colExtension As Views.BandedGrid.BandedGridColumn
        Private colNotes As Views.BandedGrid.BandedGridColumn
        Private colPhoto As Views.BandedGrid.BandedGridColumn
        Private repositoryItemMemoEdit1 As XtraEditors.Repository.RepositoryItemMemoEdit
        Private repositoryItemTextEdit1 As XtraEditors.Repository.RepositoryItemTextEdit
        Private repositoryItemTextEdit2 As XtraEditors.Repository.RepositoryItemTextEdit
        Private colCustomers_CompanyName As Views.BandedGrid.BandedGridColumn
        Private colContactName As Views.BandedGrid.BandedGridColumn
        Private colContactTitle As Views.BandedGrid.BandedGridColumn
        Private colCustomers_Phone As Views.BandedGrid.BandedGridColumn
        Private colFax As Views.BandedGrid.BandedGridColumn
        Private gridBand4 As Views.BandedGrid.GridBand
        Private gridBand5 As Views.BandedGrid.GridBand
        Private gridBand6 As Views.BandedGrid.GridBand
        Private gridBand7 As Views.BandedGrid.GridBand
        Private gridBand1 As Views.BandedGrid.GridBand
        Private gridBand3 As Views.BandedGrid.GridBand
        Private gridBand2 As Views.BandedGrid.GridBand
        Private gridBand8 As Views.BandedGrid.GridBand
        Private gridBand9 As Views.BandedGrid.GridBand
        Private gridBand10 As Views.BandedGrid.GridBand
        Private WithEvents checkEdit4 As XtraEditors.CheckEdit
        Private layoutControlItem5 As XtraLayout.LayoutControlItem
        Private navigationPane1 As XtraBars.Navigation.NavigationPane
        Private navigationPage1 As XtraBars.Navigation.NavigationPage
        Private panel1 As System.Windows.Forms.Panel
        Private layoutControlItem6 As XtraLayout.LayoutControlItem
        Private emptySpaceItem3 As XtraLayout.EmptySpaceItem
        Private WithEvents ccbSnapMode As XtraEditors.CheckedComboBoxEdit
    End Class
End Namespace
