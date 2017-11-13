Namespace DevExpress.XtraGrid.Demos
    Partial Public Class CardViewControl
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
            Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(CardViewControl))
            Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
            Me.cardView1 = New DevExpress.XtraGrid.Views.Card.CardView()
            Me.colTrademark = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colName = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colModification = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colCategory = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colBodyStyle = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colPhoto = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.repositoryItemPictureEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit()
            Me.colDescription = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.repositoryItemMemoExEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit()
            Me.colDeliveryDate = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colPrice = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colInStock = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.ceAutoHorzWidth = New DevExpress.XtraEditors.CheckEdit()
            Me.layoutControl3 = New DevExpress.XtraLayout.LayoutControl()
            Me.seMaxRows = New DevExpress.XtraEditors.SpinEdit()
            Me.seMaxColumns = New DevExpress.XtraEditors.SpinEdit()
            Me.layoutControlGroup3 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.emptySpaceItem6 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.emptySpaceItem7 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.layoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.sbRecords = New DevExpress.XtraEditors.SimpleButton()
            Me.layoutControl4 = New DevExpress.XtraLayout.LayoutControl()
            Me.ceMultiSelect = New DevExpress.XtraEditors.CheckEdit()
            Me.layoutControlGroup4 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.emptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.layoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem11 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.ceFiltering = New DevExpress.XtraEditors.CheckEdit()
            Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl()
            Me.ceSorting = New DevExpress.XtraEditors.CheckEdit()
            Me.ceCustomize = New DevExpress.XtraEditors.CheckEdit()
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.emptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.emptySpaceItem3 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.icbFormat = New DevExpress.XtraEditors.ImageComboBoxEdit()
            Me.layoutControl2 = New DevExpress.XtraLayout.LayoutControl()
            Me.ceButtons = New DevExpress.XtraEditors.CheckEdit()
            Me.ceImage = New DevExpress.XtraEditors.CheckEdit()
            Me.layoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.emptySpaceItem4 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.emptySpaceItem5 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.timer1 = New System.Windows.Forms.Timer(Me.components)
            Me.navigationPane1 = New DevExpress.XtraBars.Navigation.NavigationPane()
            Me.navigationPage3 = New DevExpress.XtraBars.Navigation.NavigationPage()
            Me.navigationPage2 = New DevExpress.XtraBars.Navigation.NavigationPage()
            Me.navigationPage1 = New DevExpress.XtraBars.Navigation.NavigationPage()
            Me.navigationPage4 = New DevExpress.XtraBars.Navigation.NavigationPage()
            Me.pnlGrid = New DevExpress.XtraEditors.PanelControl()
            DirectCast(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.cardView1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.repositoryItemPictureEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.repositoryItemMemoExEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.ceAutoHorzWidth.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutControl3, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl3.SuspendLayout()
            DirectCast(Me.seMaxRows.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.seMaxColumns.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutControlGroup3, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.emptySpaceItem6, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.emptySpaceItem7, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutControl4, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl4.SuspendLayout()
            DirectCast(Me.ceMultiSelect.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutControlGroup4, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.emptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutControlItem11, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.ceFiltering.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl1.SuspendLayout()
            DirectCast(Me.ceSorting.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.ceCustomize.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutControlItem10, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.emptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.emptySpaceItem3, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.icbFormat.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutControl2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl2.SuspendLayout()
            DirectCast(Me.ceButtons.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.ceImage.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.emptySpaceItem4, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.emptySpaceItem5, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.navigationPane1.SuspendLayout()
            Me.navigationPage3.SuspendLayout()
            Me.navigationPage2.SuspendLayout()
            Me.navigationPage1.SuspendLayout()
            Me.navigationPage4.SuspendLayout()
            DirectCast(Me.pnlGrid, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.pnlGrid.SuspendLayout()
            Me.SuspendLayout()
            ' 
            ' gridControl1
            ' 
            resources.ApplyResources(Me.gridControl1, "gridControl1")
            Me.gridControl1.MainView = Me.cardView1
            Me.gridControl1.Name = "gridControl1"
            Me.gridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() { Me.repositoryItemMemoExEdit1, Me.repositoryItemPictureEdit1})
            Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.cardView1})
            ' 
            ' cardView1
            ' 
            resources.ApplyResources(Me.cardView1, "cardView1")
            Me.cardView1.CardWidth = 300
            Me.cardView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() { Me.colTrademark, Me.colName, Me.colModification, Me.colCategory, Me.colBodyStyle, Me.colPhoto, Me.colDescription, Me.colDeliveryDate, Me.colPrice, Me.colInStock})
            Me.cardView1.FocusedCardTopFieldIndex = 0
            Me.cardView1.GridControl = Me.gridControl1
            Me.cardView1.Name = "cardView1"
            Me.cardView1.OptionsBehavior.FieldAutoHeight = True
            ' 
            ' colTrademark
            ' 
            Me.colTrademark.FieldName = "Trademark"
            Me.colTrademark.Name = "colTrademark"
            resources.ApplyResources(Me.colTrademark, "colTrademark")
            ' 
            ' colName
            ' 
            Me.colName.FieldName = "Name"
            Me.colName.Name = "colName"
            resources.ApplyResources(Me.colName, "colName")
            ' 
            ' colModification
            ' 
            Me.colModification.FieldName = "Modification"
            Me.colModification.Name = "colModification"
            resources.ApplyResources(Me.colModification, "colModification")
            ' 
            ' colCategory
            ' 
            Me.colCategory.FieldName = "Category"
            Me.colCategory.Name = "colCategory"
            resources.ApplyResources(Me.colCategory, "colCategory")
            ' 
            ' colBodyStyle
            ' 
            Me.colBodyStyle.FieldName = "BodyStyle"
            Me.colBodyStyle.Name = "colBodyStyle"
            resources.ApplyResources(Me.colBodyStyle, "colBodyStyle")
            ' 
            ' colPhoto
            ' 
            Me.colPhoto.ColumnEdit = Me.repositoryItemPictureEdit1
            Me.colPhoto.FieldName = "Photo"
            Me.colPhoto.Name = "colPhoto"
            resources.ApplyResources(Me.colPhoto, "colPhoto")
            ' 
            ' repositoryItemPictureEdit1
            ' 
            Me.repositoryItemPictureEdit1.CustomHeight = 110
            Me.repositoryItemPictureEdit1.Name = "repositoryItemPictureEdit1"
            Me.repositoryItemPictureEdit1.PictureInterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic
            Me.repositoryItemPictureEdit1.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze
            ' 
            ' colDescription
            ' 
            Me.colDescription.ColumnEdit = Me.repositoryItemMemoExEdit1
            Me.colDescription.FieldName = "Description"
            Me.colDescription.Name = "colDescription"
            resources.ApplyResources(Me.colDescription, "colDescription")
            ' 
            ' repositoryItemMemoExEdit1
            ' 
            resources.ApplyResources(Me.repositoryItemMemoExEdit1, "repositoryItemMemoExEdit1")
            Me.repositoryItemMemoExEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton((DirectCast(resources.GetObject("repositoryItemMemoExEdit1.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines)))})
            Me.repositoryItemMemoExEdit1.Name = "repositoryItemMemoExEdit1"
            Me.repositoryItemMemoExEdit1.PopupFormSize = New System.Drawing.Size(350, 150)
            ' 
            ' colDeliveryDate
            ' 
            Me.colDeliveryDate.FieldName = "DeliveryDate"
            Me.colDeliveryDate.Name = "colDeliveryDate"
            ' 
            ' colPrice
            ' 
            Me.colPrice.FieldName = "Price"
            Me.colPrice.Name = "colPrice"
            resources.ApplyResources(Me.colPrice, "colPrice")
            ' 
            ' colInStock
            ' 
            Me.colInStock.FieldName = "InStock"
            Me.colInStock.Name = "colInStock"
            resources.ApplyResources(Me.colInStock, "colInStock")
            ' 
            ' ceAutoHorzWidth
            ' 
            resources.ApplyResources(Me.ceAutoHorzWidth, "ceAutoHorzWidth")
            Me.ceAutoHorzWidth.Name = "ceAutoHorzWidth"
            Me.ceAutoHorzWidth.Properties.Caption = resources.GetString("ceAutoHorzWidth.Properties.Caption")
            Me.ceAutoHorzWidth.StyleController = Me.layoutControl3
            ' 
            ' layoutControl3
            ' 
            Me.layoutControl3.AllowCustomization = False
            Me.layoutControl3.Controls.Add(Me.ceAutoHorzWidth)
            Me.layoutControl3.Controls.Add(Me.seMaxRows)
            Me.layoutControl3.Controls.Add(Me.seMaxColumns)
            resources.ApplyResources(Me.layoutControl3, "layoutControl3")
            Me.layoutControl3.Name = "layoutControl3"
            Me.layoutControl3.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(892, 161, 450, 350)
            Me.layoutControl3.Root = Me.layoutControlGroup3
            ' 
            ' seMaxRows
            ' 
            resources.ApplyResources(Me.seMaxRows, "seMaxRows")
            Me.seMaxRows.Name = "seMaxRows"
            Me.seMaxRows.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
            Me.seMaxRows.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default
            Me.seMaxRows.Properties.IsFloatValue = False
            Me.seMaxRows.Properties.Mask.EditMask = resources.GetString("seMaxRows.Properties.Mask.EditMask")
            Me.seMaxRows.Properties.MaxValue = New Decimal(New Integer() { 7, 0, 0, 0})
            Me.seMaxRows.Properties.MinValue = New Decimal(New Integer() { 1, 0, 0, -2147483648})
            Me.seMaxRows.Properties.ValidateOnEnterKey = True
            Me.seMaxRows.StyleController = Me.layoutControl3
            ' 
            ' seMaxColumns
            ' 
            resources.ApplyResources(Me.seMaxColumns, "seMaxColumns")
            Me.seMaxColumns.Name = "seMaxColumns"
            Me.seMaxColumns.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
            Me.seMaxColumns.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default
            Me.seMaxColumns.Properties.IsFloatValue = False
            Me.seMaxColumns.Properties.Mask.EditMask = resources.GetString("seMaxColumns.Properties.Mask.EditMask")
            Me.seMaxColumns.Properties.MaxValue = New Decimal(New Integer() { 7, 0, 0, 0})
            Me.seMaxColumns.Properties.MinValue = New Decimal(New Integer() { 1, 0, 0, -2147483648})
            Me.seMaxColumns.Properties.ValidateOnEnterKey = True
            Me.seMaxColumns.StyleController = Me.layoutControl3
            ' 
            ' layoutControlGroup3
            ' 
            Me.layoutControlGroup3.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True
            Me.layoutControlGroup3.GroupBordersVisible = False
            Me.layoutControlGroup3.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.layoutControlItem5, Me.layoutControlItem6, Me.emptySpaceItem6, Me.emptySpaceItem7, Me.layoutControlItem7})
            Me.layoutControlGroup3.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup3.Name = "Root"
            Me.layoutControlGroup3.Size = New System.Drawing.Size(196, 609)
            Me.layoutControlGroup3.TextVisible = False
            ' 
            ' layoutControlItem5
            ' 
            Me.layoutControlItem5.Control = Me.seMaxColumns
            Me.layoutControlItem5.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem5.Name = "layoutControlItem5"
            Me.layoutControlItem5.Size = New System.Drawing.Size(176, 24)
            resources.ApplyResources(Me.layoutControlItem5, "layoutControlItem5")
            Me.layoutControlItem5.TextSize = New System.Drawing.Size(91, 13)
            ' 
            ' layoutControlItem6
            ' 
            Me.layoutControlItem6.Control = Me.seMaxRows
            Me.layoutControlItem6.Location = New System.Drawing.Point(0, 24)
            Me.layoutControlItem6.Name = "layoutControlItem6"
            Me.layoutControlItem6.Size = New System.Drawing.Size(176, 24)
            resources.ApplyResources(Me.layoutControlItem6, "layoutControlItem6")
            Me.layoutControlItem6.TextSize = New System.Drawing.Size(91, 13)
            ' 
            ' emptySpaceItem6
            ' 
            Me.emptySpaceItem6.AllowHotTrack = False
            Me.emptySpaceItem6.Location = New System.Drawing.Point(0, 83)
            Me.emptySpaceItem6.Name = "emptySpaceItem6"
            Me.emptySpaceItem6.Size = New System.Drawing.Size(176, 506)
            Me.emptySpaceItem6.TextSize = New System.Drawing.Size(0, 0)
            ' 
            ' emptySpaceItem7
            ' 
            Me.emptySpaceItem7.AllowHotTrack = False
            Me.emptySpaceItem7.Location = New System.Drawing.Point(0, 48)
            Me.emptySpaceItem7.Name = "emptySpaceItem7"
            Me.emptySpaceItem7.Size = New System.Drawing.Size(176, 12)
            Me.emptySpaceItem7.TextSize = New System.Drawing.Size(0, 0)
            ' 
            ' layoutControlItem7
            ' 
            Me.layoutControlItem7.Control = Me.ceAutoHorzWidth
            Me.layoutControlItem7.Location = New System.Drawing.Point(0, 60)
            Me.layoutControlItem7.Name = "layoutControlItem7"
            Me.layoutControlItem7.Size = New System.Drawing.Size(176, 23)
            Me.layoutControlItem7.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem7.TextVisible = False
            ' 
            ' sbRecords
            ' 
            resources.ApplyResources(Me.sbRecords, "sbRecords")
            Me.sbRecords.Name = "sbRecords"
            Me.sbRecords.StyleController = Me.layoutControl4
            ' 
            ' layoutControl4
            ' 
            Me.layoutControl4.AllowCustomization = False
            Me.layoutControl4.Controls.Add(Me.sbRecords)
            Me.layoutControl4.Controls.Add(Me.ceMultiSelect)
            resources.ApplyResources(Me.layoutControl4, "layoutControl4")
            Me.layoutControl4.Name = "layoutControl4"
            Me.layoutControl4.Root = Me.layoutControlGroup4
            ' 
            ' ceMultiSelect
            ' 
            resources.ApplyResources(Me.ceMultiSelect, "ceMultiSelect")
            Me.ceMultiSelect.Name = "ceMultiSelect"
            Me.ceMultiSelect.Properties.Caption = resources.GetString("ceMultiSelect.Properties.Caption")
            Me.ceMultiSelect.StyleController = Me.layoutControl4
            ' 
            ' layoutControlGroup4
            ' 
            Me.layoutControlGroup4.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True
            Me.layoutControlGroup4.GroupBordersVisible = False
            Me.layoutControlGroup4.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.emptySpaceItem1, Me.layoutControlItem8, Me.layoutControlItem11})
            Me.layoutControlGroup4.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup4.Name = "layoutControlGroup4"
            Me.layoutControlGroup4.Size = New System.Drawing.Size(196, 609)
            Me.layoutControlGroup4.TextVisible = False
            ' 
            ' emptySpaceItem1
            ' 
            Me.emptySpaceItem1.AllowHotTrack = False
            Me.emptySpaceItem1.Location = New System.Drawing.Point(0, 23)
            Me.emptySpaceItem1.Name = "emptySpaceItem1"
            Me.emptySpaceItem1.Size = New System.Drawing.Size(176, 540)
            Me.emptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
            ' 
            ' layoutControlItem8
            ' 
            Me.layoutControlItem8.Control = Me.ceMultiSelect
            Me.layoutControlItem8.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem8.Name = "layoutControlItem8"
            Me.layoutControlItem8.Size = New System.Drawing.Size(176, 23)
            Me.layoutControlItem8.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem8.TextVisible = False
            ' 
            ' layoutControlItem11
            ' 
            Me.layoutControlItem11.Control = Me.sbRecords
            Me.layoutControlItem11.Location = New System.Drawing.Point(0, 563)
            Me.layoutControlItem11.Name = "layoutControlItem11"
            Me.layoutControlItem11.Size = New System.Drawing.Size(176, 26)
            Me.layoutControlItem11.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem11.TextVisible = False
            ' 
            ' ceFiltering
            ' 
            resources.ApplyResources(Me.ceFiltering, "ceFiltering")
            Me.ceFiltering.Name = "ceFiltering"
            Me.ceFiltering.Properties.Caption = resources.GetString("ceFiltering.Properties.Caption")
            Me.ceFiltering.StyleController = Me.layoutControl1
            ' 
            ' layoutControl1
            ' 
            Me.layoutControl1.AllowCustomization = False
            Me.layoutControl1.Controls.Add(Me.ceFiltering)
            Me.layoutControl1.Controls.Add(Me.ceSorting)
            Me.layoutControl1.Controls.Add(Me.ceCustomize)
            resources.ApplyResources(Me.layoutControl1, "layoutControl1")
            Me.layoutControl1.Name = "layoutControl1"
            Me.layoutControl1.Root = Me.layoutControlGroup1
            ' 
            ' ceSorting
            ' 
            resources.ApplyResources(Me.ceSorting, "ceSorting")
            Me.ceSorting.Name = "ceSorting"
            Me.ceSorting.Properties.Caption = resources.GetString("ceSorting.Properties.Caption")
            Me.ceSorting.StyleController = Me.layoutControl1
            ' 
            ' ceCustomize
            ' 
            resources.ApplyResources(Me.ceCustomize, "ceCustomize")
            Me.ceCustomize.Name = "ceCustomize"
            Me.ceCustomize.Properties.Caption = resources.GetString("ceCustomize.Properties.Caption")
            Me.ceCustomize.StyleController = Me.layoutControl1
            ' 
            ' layoutControlGroup1
            ' 
            Me.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True
            Me.layoutControlGroup1.GroupBordersVisible = False
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.layoutControlItem1, Me.layoutControlItem9, Me.layoutControlItem10, Me.emptySpaceItem2, Me.emptySpaceItem3})
            Me.layoutControlGroup1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup1.Name = "layoutControlGroup1"
            Me.layoutControlGroup1.Size = New System.Drawing.Size(196, 609)
            Me.layoutControlGroup1.TextVisible = False
            ' 
            ' layoutControlItem1
            ' 
            Me.layoutControlItem1.Control = Me.ceCustomize
            Me.layoutControlItem1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem1.Name = "layoutControlItem1"
            Me.layoutControlItem1.Size = New System.Drawing.Size(176, 23)
            Me.layoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem1.TextVisible = False
            ' 
            ' layoutControlItem9
            ' 
            Me.layoutControlItem9.Control = Me.ceSorting
            Me.layoutControlItem9.Location = New System.Drawing.Point(0, 35)
            Me.layoutControlItem9.Name = "layoutControlItem9"
            Me.layoutControlItem9.Size = New System.Drawing.Size(176, 23)
            Me.layoutControlItem9.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem9.TextVisible = False
            ' 
            ' layoutControlItem10
            ' 
            Me.layoutControlItem10.Control = Me.ceFiltering
            Me.layoutControlItem10.Location = New System.Drawing.Point(0, 58)
            Me.layoutControlItem10.Name = "layoutControlItem10"
            Me.layoutControlItem10.Size = New System.Drawing.Size(176, 23)
            Me.layoutControlItem10.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem10.TextVisible = False
            ' 
            ' emptySpaceItem2
            ' 
            Me.emptySpaceItem2.AllowHotTrack = False
            Me.emptySpaceItem2.Location = New System.Drawing.Point(0, 81)
            Me.emptySpaceItem2.Name = "emptySpaceItem2"
            Me.emptySpaceItem2.Size = New System.Drawing.Size(176, 508)
            Me.emptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
            ' 
            ' emptySpaceItem3
            ' 
            Me.emptySpaceItem3.AllowHotTrack = False
            Me.emptySpaceItem3.Location = New System.Drawing.Point(0, 23)
            Me.emptySpaceItem3.Name = "emptySpaceItem3"
            Me.emptySpaceItem3.Size = New System.Drawing.Size(176, 12)
            Me.emptySpaceItem3.TextSize = New System.Drawing.Size(0, 0)
            ' 
            ' icbFormat
            ' 
            resources.ApplyResources(Me.icbFormat, "icbFormat")
            Me.icbFormat.Name = "icbFormat"
            Me.icbFormat.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton((DirectCast(resources.GetObject("icbFormat.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines)))})
            Me.icbFormat.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.ImageComboBoxItem() {
                New DevExpress.XtraEditors.Controls.ImageComboBoxItem(resources.GetString("icbFormat.Properties.Items"), resources.GetString("icbFormat.Properties.Items1"), (DirectCast(resources.GetObject("icbFormat.Properties.Items2"), Integer))),
                New DevExpress.XtraEditors.Controls.ImageComboBoxItem(resources.GetString("icbFormat.Properties.Items3"), resources.GetString("icbFormat.Properties.Items4"), (DirectCast(resources.GetObject("icbFormat.Properties.Items5"), Integer))),
                New DevExpress.XtraEditors.Controls.ImageComboBoxItem(resources.GetString("icbFormat.Properties.Items6"), resources.GetString("icbFormat.Properties.Items7"), (DirectCast(resources.GetObject("icbFormat.Properties.Items8"), Integer))),
                New DevExpress.XtraEditors.Controls.ImageComboBoxItem(resources.GetString("icbFormat.Properties.Items9"), resources.GetString("icbFormat.Properties.Items10"), (DirectCast(resources.GetObject("icbFormat.Properties.Items11"), Integer))),
                New DevExpress.XtraEditors.Controls.ImageComboBoxItem(resources.GetString("icbFormat.Properties.Items12"), resources.GetString("icbFormat.Properties.Items13"), (DirectCast(resources.GetObject("icbFormat.Properties.Items14"), Integer)))
            })
            Me.icbFormat.StyleController = Me.layoutControl2
            ' 
            ' layoutControl2
            ' 
            Me.layoutControl2.AllowCustomization = False
            Me.layoutControl2.Controls.Add(Me.icbFormat)
            Me.layoutControl2.Controls.Add(Me.ceButtons)
            Me.layoutControl2.Controls.Add(Me.ceImage)
            resources.ApplyResources(Me.layoutControl2, "layoutControl2")
            Me.layoutControl2.Name = "layoutControl2"
            Me.layoutControl2.Root = Me.layoutControlGroup2
            ' 
            ' ceButtons
            ' 
            resources.ApplyResources(Me.ceButtons, "ceButtons")
            Me.ceButtons.Name = "ceButtons"
            Me.ceButtons.Properties.Caption = resources.GetString("ceButtons.Properties.Caption")
            Me.ceButtons.StyleController = Me.layoutControl2
            ' 
            ' ceImage
            ' 
            resources.ApplyResources(Me.ceImage, "ceImage")
            Me.ceImage.Name = "ceImage"
            Me.ceImage.Properties.Caption = resources.GetString("ceImage.Properties.Caption")
            Me.ceImage.StyleController = Me.layoutControl2
            ' 
            ' layoutControlGroup2
            ' 
            Me.layoutControlGroup2.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True
            Me.layoutControlGroup2.GroupBordersVisible = False
            Me.layoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.layoutControlItem2, Me.layoutControlItem3, Me.layoutControlItem4, Me.emptySpaceItem4, Me.emptySpaceItem5})
            Me.layoutControlGroup2.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup2.Name = "layoutControlGroup2"
            Me.layoutControlGroup2.Size = New System.Drawing.Size(196, 609)
            Me.layoutControlGroup2.TextVisible = False
            ' 
            ' layoutControlItem2
            ' 
            Me.layoutControlItem2.Control = Me.ceImage
            Me.layoutControlItem2.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem2.Name = "layoutControlItem2"
            Me.layoutControlItem2.Size = New System.Drawing.Size(176, 23)
            Me.layoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem2.TextVisible = False
            ' 
            ' layoutControlItem3
            ' 
            Me.layoutControlItem3.Control = Me.ceButtons
            Me.layoutControlItem3.Location = New System.Drawing.Point(0, 23)
            Me.layoutControlItem3.Name = "layoutControlItem3"
            Me.layoutControlItem3.Size = New System.Drawing.Size(176, 23)
            Me.layoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem3.TextVisible = False
            ' 
            ' layoutControlItem4
            ' 
            Me.layoutControlItem4.Control = Me.icbFormat
            Me.layoutControlItem4.Location = New System.Drawing.Point(0, 58)
            Me.layoutControlItem4.Name = "layoutControlItem4"
            Me.layoutControlItem4.Size = New System.Drawing.Size(176, 24)
            resources.ApplyResources(Me.layoutControlItem4, "layoutControlItem4")
            Me.layoutControlItem4.TextSize = New System.Drawing.Size(78, 13)
            ' 
            ' emptySpaceItem4
            ' 
            Me.emptySpaceItem4.AllowHotTrack = False
            Me.emptySpaceItem4.Location = New System.Drawing.Point(0, 82)
            Me.emptySpaceItem4.Name = "emptySpaceItem4"
            Me.emptySpaceItem4.Size = New System.Drawing.Size(176, 507)
            Me.emptySpaceItem4.TextSize = New System.Drawing.Size(0, 0)
            ' 
            ' emptySpaceItem5
            ' 
            Me.emptySpaceItem5.AllowHotTrack = False
            Me.emptySpaceItem5.Location = New System.Drawing.Point(0, 46)
            Me.emptySpaceItem5.Name = "emptySpaceItem5"
            Me.emptySpaceItem5.Size = New System.Drawing.Size(176, 12)
            Me.emptySpaceItem5.TextSize = New System.Drawing.Size(0, 0)
            ' 
            ' timer1
            ' 
            Me.timer1.Interval = 500
            ' 
            ' navigationPane1
            ' 
            Me.navigationPane1.Controls.Add(Me.navigationPage3)
            Me.navigationPane1.Controls.Add(Me.navigationPage2)
            Me.navigationPane1.Controls.Add(Me.navigationPage1)
            Me.navigationPane1.Controls.Add(Me.navigationPage4)
            resources.ApplyResources(Me.navigationPane1, "navigationPane1")
            Me.navigationPane1.ItemOrientation = System.Windows.Forms.Orientation.Vertical
            Me.navigationPane1.Name = "navigationPane1"
            Me.navigationPane1.PageProperties.AppearanceCaption.Options.UseTextOptions = True
            Me.navigationPane1.PageProperties.AppearanceCaption.TextOptions.Trimming = Utils.Trimming.EllipsisCharacter
            Me.navigationPane1.PageProperties.ShowExpandButton = False
            Me.navigationPane1.PageProperties.ShowMode = DevExpress.XtraBars.Navigation.ItemShowMode.Text
            Me.navigationPane1.Pages.AddRange(New DevExpress.XtraBars.Navigation.NavigationPageBase() { Me.navigationPage1, Me.navigationPage2, Me.navigationPage3, Me.navigationPage4})
            Me.navigationPane1.RegularSize = New System.Drawing.Size(239, 669)
            Me.navigationPane1.SelectedPage = Me.navigationPage1
            Me.navigationPane1.SelectedPageIndex = 0
            ' 
            ' navigationPage3
            ' 
            Me.navigationPage3.Caption = "Layout"
            Me.navigationPage3.Controls.Add(Me.layoutControl3)
            Me.navigationPage3.ImageUri.Uri = "New"
            Me.navigationPage3.Name = "navigationPage3"
            resources.ApplyResources(Me.navigationPage3, "navigationPage3")
            ' 
            ' navigationPage2
            ' 
            Me.navigationPage2.Caption = "Advanced Captions"
            Me.navigationPage2.Controls.Add(Me.layoutControl2)
            Me.navigationPage2.ImageUri.Uri = "New"
            Me.navigationPage2.Name = "navigationPage2"
            resources.ApplyResources(Me.navigationPage2, "navigationPage2")
            ' 
            ' navigationPage1
            ' 
            Me.navigationPage1.Caption = "Filtering, Sorting, Customize"
            Me.navigationPage1.Controls.Add(Me.layoutControl1)
            Me.navigationPage1.ImageUri.Uri = "New"
            Me.navigationPage1.Name = "navigationPage1"
            resources.ApplyResources(Me.navigationPage1, "navigationPage1")
            ' 
            ' navigationPage4
            ' 
            Me.navigationPage4.Caption = "Multiple Card Selection"
            Me.navigationPage4.Controls.Add(Me.layoutControl4)
            Me.navigationPage4.ImageUri.Uri = "New"
            Me.navigationPage4.Name = "navigationPage4"
            resources.ApplyResources(Me.navigationPage4, "navigationPage4")
            ' 
            ' pnlGrid
            ' 
            Me.pnlGrid.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.pnlGrid.Controls.Add(Me.gridControl1)
            resources.ApplyResources(Me.pnlGrid, "pnlGrid")
            Me.pnlGrid.Name = "pnlGrid"
            ' 
            ' CardViewControl
            ' 
            resources.ApplyResources(Me, "$this")
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.pnlGrid)
            Me.Controls.Add(Me.navigationPane1)
            Me.Name = "CardViewControl"
            DirectCast(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.cardView1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.repositoryItemPictureEdit1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.repositoryItemMemoExEdit1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.ceAutoHorzWidth.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutControl3, System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl3.ResumeLayout(False)
            DirectCast(Me.seMaxRows.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.seMaxColumns.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutControlGroup3, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.emptySpaceItem6, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.emptySpaceItem7, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutControl4, System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl4.ResumeLayout(False)
            DirectCast(Me.ceMultiSelect.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutControlGroup4, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.emptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutControlItem11, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.ceFiltering.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl1.ResumeLayout(False)
            DirectCast(Me.ceSorting.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.ceCustomize.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutControlItem10, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.emptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.emptySpaceItem3, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.icbFormat.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutControl2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl2.ResumeLayout(False)
            DirectCast(Me.ceButtons.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.ceImage.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.emptySpaceItem4, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.emptySpaceItem5, System.ComponentModel.ISupportInitialize).EndInit()
            Me.navigationPane1.ResumeLayout(False)
            Me.navigationPage3.ResumeLayout(False)
            Me.navigationPage2.ResumeLayout(False)
            Me.navigationPage1.ResumeLayout(False)
            Me.navigationPage4.ResumeLayout(False)
            DirectCast(Me.pnlGrid, System.ComponentModel.ISupportInitialize).EndInit()
            Me.pnlGrid.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub

        #End Region
        Private gridControl1 As DevExpress.XtraGrid.GridControl
        Private timer1 As System.Windows.Forms.Timer
        Private WithEvents cardView1 As DevExpress.XtraGrid.Views.Card.CardView
        Private WithEvents ceCustomize As DevExpress.XtraEditors.CheckEdit
        Private repositoryItemMemoExEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
        Private repositoryItemPictureEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit
        Private WithEvents ceImage As DevExpress.XtraEditors.CheckEdit
        Private WithEvents ceButtons As DevExpress.XtraEditors.CheckEdit
        Private WithEvents icbFormat As DevExpress.XtraEditors.ImageComboBoxEdit
        Private WithEvents seMaxColumns As DevExpress.XtraEditors.SpinEdit
        Private WithEvents ceAutoHorzWidth As DevExpress.XtraEditors.CheckEdit
        Private WithEvents seMaxRows As DevExpress.XtraEditors.SpinEdit
        Private WithEvents ceMultiSelect As DevExpress.XtraEditors.CheckEdit
        Private WithEvents sbRecords As DevExpress.XtraEditors.SimpleButton
        Private WithEvents ceSorting As DevExpress.XtraEditors.CheckEdit
        Private WithEvents ceFiltering As DevExpress.XtraEditors.CheckEdit
        Private components As System.ComponentModel.IContainer = Nothing
        Private layoutControl1 As XtraLayout.LayoutControl
        Private layoutControlGroup1 As XtraLayout.LayoutControlGroup
        Private layoutControlItem1 As XtraLayout.LayoutControlItem
        Private layoutControlItem9 As XtraLayout.LayoutControlItem
        Private layoutControlItem10 As XtraLayout.LayoutControlItem
        Private emptySpaceItem2 As XtraLayout.EmptySpaceItem
        Private emptySpaceItem3 As XtraLayout.EmptySpaceItem
        Private WithEvents navigationPane1 As XtraBars.Navigation.NavigationPane
        Private navigationPage3 As XtraBars.Navigation.NavigationPage
        Private layoutControl3 As XtraLayout.LayoutControl
        Private layoutControlGroup3 As XtraLayout.LayoutControlGroup
        Private navigationPage2 As XtraBars.Navigation.NavigationPage
        Private layoutControl2 As XtraLayout.LayoutControl
        Private layoutControlGroup2 As XtraLayout.LayoutControlGroup
        Private navigationPage1 As XtraBars.Navigation.NavigationPage
        Private navigationPage4 As XtraBars.Navigation.NavigationPage
        Private layoutControl4 As XtraLayout.LayoutControl
        Private layoutControlGroup4 As XtraLayout.LayoutControlGroup
        Private emptySpaceItem1 As XtraLayout.EmptySpaceItem
        Private layoutControlItem2 As XtraLayout.LayoutControlItem
        Private layoutControlItem3 As XtraLayout.LayoutControlItem
        Private layoutControlItem4 As XtraLayout.LayoutControlItem
        Private emptySpaceItem4 As XtraLayout.EmptySpaceItem
        Private emptySpaceItem5 As XtraLayout.EmptySpaceItem
        Private layoutControlItem5 As XtraLayout.LayoutControlItem
        Private layoutControlItem6 As XtraLayout.LayoutControlItem
        Private emptySpaceItem6 As XtraLayout.EmptySpaceItem
        Private emptySpaceItem7 As XtraLayout.EmptySpaceItem
        Private layoutControlItem7 As XtraLayout.LayoutControlItem
        Private layoutControlItem8 As XtraLayout.LayoutControlItem
        Private layoutControlItem11 As XtraLayout.LayoutControlItem
        Private pnlGrid As XtraEditors.PanelControl
        Private colTrademark As Columns.GridColumn
        Private colName As Columns.GridColumn
        Private colModification As Columns.GridColumn
        Private colCategory As Columns.GridColumn
        Private colBodyStyle As Columns.GridColumn
        Private colPhoto As Columns.GridColumn
        Private colDescription As Columns.GridColumn
        Private colDeliveryDate As Columns.GridColumn
        Private colPrice As Columns.GridColumn
        Private colInStock As Columns.GridColumn
    End Class
End Namespace
