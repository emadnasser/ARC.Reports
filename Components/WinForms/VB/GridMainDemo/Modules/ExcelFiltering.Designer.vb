Namespace DevExpress.XtraGrid.Demos
    Partial Public Class ExcelFiltering
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ExcelFiltering))
            Dim GridFormatRule1 As DevExpress.XtraGrid.GridFormatRule = New DevExpress.XtraGrid.GridFormatRule()
            Dim FormatConditionRuleIconSet1 As DevExpress.XtraEditors.FormatConditionRuleIconSet = New DevExpress.XtraEditors.FormatConditionRuleIconSet()
            Dim FormatConditionIconSet1 As DevExpress.XtraEditors.FormatConditionIconSet = New DevExpress.XtraEditors.FormatConditionIconSet()
            Dim FormatConditionIconSetIcon1 As DevExpress.XtraEditors.FormatConditionIconSetIcon = New DevExpress.XtraEditors.FormatConditionIconSetIcon()
            Dim FormatConditionIconSetIcon2 As DevExpress.XtraEditors.FormatConditionIconSetIcon = New DevExpress.XtraEditors.FormatConditionIconSetIcon()
            Dim FormatConditionIconSetIcon3 As DevExpress.XtraEditors.FormatConditionIconSetIcon = New DevExpress.XtraEditors.FormatConditionIconSetIcon()
            Dim GridFormatRule2 As DevExpress.XtraGrid.GridFormatRule = New DevExpress.XtraGrid.GridFormatRule()
            Dim FormatConditionRuleIconSet2 As DevExpress.XtraEditors.FormatConditionRuleIconSet = New DevExpress.XtraEditors.FormatConditionRuleIconSet()
            Dim FormatConditionIconSet2 As DevExpress.XtraEditors.FormatConditionIconSet = New DevExpress.XtraEditors.FormatConditionIconSet()
            Dim FormatConditionIconSetIcon4 As DevExpress.XtraEditors.FormatConditionIconSetIcon = New DevExpress.XtraEditors.FormatConditionIconSetIcon()
            Dim FormatConditionIconSetIcon5 As DevExpress.XtraEditors.FormatConditionIconSetIcon = New DevExpress.XtraEditors.FormatConditionIconSetIcon()
            Dim FormatConditionIconSetIcon6 As DevExpress.XtraEditors.FormatConditionIconSetIcon = New DevExpress.XtraEditors.FormatConditionIconSetIcon()
            Dim GridFormatRule3 As DevExpress.XtraGrid.GridFormatRule = New DevExpress.XtraGrid.GridFormatRule()
            Dim FormatConditionRuleIconSet3 As DevExpress.XtraEditors.FormatConditionRuleIconSet = New DevExpress.XtraEditors.FormatConditionRuleIconSet()
            Dim FormatConditionIconSet3 As DevExpress.XtraEditors.FormatConditionIconSet = New DevExpress.XtraEditors.FormatConditionIconSet()
            Dim FormatConditionIconSetIcon7 As DevExpress.XtraEditors.FormatConditionIconSetIcon = New DevExpress.XtraEditors.FormatConditionIconSetIcon()
            Dim FormatConditionIconSetIcon8 As DevExpress.XtraEditors.FormatConditionIconSetIcon = New DevExpress.XtraEditors.FormatConditionIconSetIcon()
            Dim FormatConditionIconSetIcon9 As DevExpress.XtraEditors.FormatConditionIconSetIcon = New DevExpress.XtraEditors.FormatConditionIconSetIcon()
            Dim GridFormatRule4 As DevExpress.XtraGrid.GridFormatRule = New DevExpress.XtraGrid.GridFormatRule()
            Dim FormatConditionRuleDataBar1 As DevExpress.XtraEditors.FormatConditionRuleDataBar = New DevExpress.XtraEditors.FormatConditionRuleDataBar()
            Me.bcDiscount = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.repositoryItemTextEdit4 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
            Me.bcMPGCity = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.bcMPGHighway = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.bcPrice = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.repositoryItemTextEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
            Me.repositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
            Me.repositoryItemSpinEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
            Me.repositoryItemTextEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
            Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
            Me.bandedGridView1 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridView()
            Me.gridBand1 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
            Me.bcOrderID = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.repositoryItemTextEdit5 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
            Me.bcSalesDate = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.gridBand2 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
            Me.bcPhoto = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.bcTrademark = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.bcName = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.bcModification = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.gridBand3 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
            Me.bcCylinders = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.bcTransmissionSpeeds = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.bcCategory = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.bcDoors = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.bcBodyStyle = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.bcHorsepower = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.bcTorque = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.bcTransmissionType = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            CType(Me.repositoryItemTextEdit4, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repositoryItemTextEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repositoryItemSpinEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.bandedGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repositoryItemTextEdit5, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'bcDiscount
            '
            Me.bcDiscount.ColumnEdit = Me.repositoryItemTextEdit4
            Me.bcDiscount.FieldName = "Discount"
            Me.bcDiscount.Image = CType(resources.GetObject("bcDiscount.Image"), System.Drawing.Image)
            Me.bcDiscount.Name = "bcDiscount"
            Me.bcDiscount.OptionsFilter.PopupExcelFilterDefaultTab = DevExpress.XtraGrid.Columns.ExcelFilterDefaultTab.Filters
            Me.bcDiscount.OptionsFilter.PopupExcelFilterEnumFilters = DevExpress.XtraGrid.Columns.ExcelFilterEnumFilters.AllFilters
            Me.bcDiscount.Visible = True
            '
            'repositoryItemTextEdit4
            '
            Me.repositoryItemTextEdit4.AutoHeight = False
            Me.repositoryItemTextEdit4.Mask.EditMask = "p"
            Me.repositoryItemTextEdit4.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
            Me.repositoryItemTextEdit4.Mask.UseMaskAsDisplayFormat = True
            Me.repositoryItemTextEdit4.Name = "repositoryItemTextEdit4"
            '
            'bcMPGCity
            '
            Me.bcMPGCity.Caption = "MPG <b>City"
            Me.bcMPGCity.FieldName = "MPGCity"
            Me.bcMPGCity.Name = "bcMPGCity"
            Me.bcMPGCity.OptionsFilter.PopupExcelFilterDefaultTab = DevExpress.XtraGrid.Columns.ExcelFilterDefaultTab.Filters
            Me.bcMPGCity.OptionsFilter.PopupExcelFilterEnumFilters = DevExpress.XtraGrid.Columns.ExcelFilterEnumFilters.AllFilters
            Me.bcMPGCity.Visible = True
            '
            'bcMPGHighway
            '
            Me.bcMPGHighway.Caption = "MPG <b>Highway"
            Me.bcMPGHighway.FieldName = "MPGHighway"
            Me.bcMPGHighway.Name = "bcMPGHighway"
            Me.bcMPGHighway.OptionsFilter.PopupExcelFilterDefaultTab = DevExpress.XtraGrid.Columns.ExcelFilterDefaultTab.Filters
            Me.bcMPGHighway.OptionsFilter.PopupExcelFilterEnumFilters = DevExpress.XtraGrid.Columns.ExcelFilterEnumFilters.AllFilters
            Me.bcMPGHighway.Visible = True
            '
            'bcPrice
            '
            Me.bcPrice.FieldName = "ModelPrice"
            Me.bcPrice.Name = "bcPrice"
            Me.bcPrice.OptionsFilter.PopupExcelFilterDefaultTab = DevExpress.XtraGrid.Columns.ExcelFilterDefaultTab.Filters
            Me.bcPrice.OptionsFilter.PopupExcelFilterEnumFilters = DevExpress.XtraGrid.Columns.ExcelFilterEnumFilters.AllFilters
            Me.bcPrice.Visible = True
            Me.bcPrice.Width = 150
            '
            'repositoryItemTextEdit3
            '
            Me.repositoryItemTextEdit3.AutoHeight = False
            Me.repositoryItemTextEdit3.Mask.EditMask = "n"
            Me.repositoryItemTextEdit3.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
            Me.repositoryItemTextEdit3.Name = "repositoryItemTextEdit3"
            '
            'repositoryItemTextEdit1
            '
            Me.repositoryItemTextEdit1.AutoHeight = False
            Me.repositoryItemTextEdit1.Mask.EditMask = "p"
            Me.repositoryItemTextEdit1.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
            Me.repositoryItemTextEdit1.Mask.UseMaskAsDisplayFormat = True
            Me.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1"
            '
            'repositoryItemSpinEdit1
            '
            Me.repositoryItemSpinEdit1.AutoHeight = False
            Me.repositoryItemSpinEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.repositoryItemSpinEdit1.Name = "repositoryItemSpinEdit1"
            '
            'repositoryItemTextEdit2
            '
            Me.repositoryItemTextEdit2.AutoHeight = False
            Me.repositoryItemTextEdit2.Mask.EditMask = "p0"
            Me.repositoryItemTextEdit2.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
            Me.repositoryItemTextEdit2.Mask.UseMaskAsDisplayFormat = True
            Me.repositoryItemTextEdit2.Name = "repositoryItemTextEdit2"
            '
            'gridControl1
            '
            Me.gridControl1.Cursor = System.Windows.Forms.Cursors.Default
            Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.gridControl1.Location = New System.Drawing.Point(0, 0)
            Me.gridControl1.MainView = Me.bandedGridView1
            Me.gridControl1.Name = "gridControl1"
            Me.gridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repositoryItemSpinEdit1, Me.repositoryItemTextEdit1, Me.repositoryItemTextEdit2, Me.repositoryItemTextEdit3, Me.repositoryItemTextEdit4, Me.repositoryItemTextEdit5})
            Me.gridControl1.Size = New System.Drawing.Size(944, 562)
            Me.gridControl1.TabIndex = 0
            Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.bandedGridView1})
            '
            'bandedGridView1
            '
            Me.bandedGridView1.Bands.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() {Me.gridBand1, Me.gridBand2, Me.gridBand3})
            Me.bandedGridView1.Columns.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn() {Me.bcTrademark, Me.bcName, Me.bcModification, Me.bcCategory, Me.bcPrice, Me.bcMPGCity, Me.bcMPGHighway, Me.bcDoors, Me.bcBodyStyle, Me.bcCylinders, Me.bcHorsepower, Me.bcTorque, Me.bcTransmissionSpeeds, Me.bcTransmissionType, Me.bcPhoto, Me.bcSalesDate, Me.bcOrderID, Me.bcDiscount})
            GridFormatRule1.Column = Me.bcDiscount
            GridFormatRule1.Name = "Format0"
            FormatConditionIconSet1.CategoryName = "Ratings"
            FormatConditionIconSetIcon1.PredefinedName = "Stars3_1.png"
            FormatConditionIconSetIcon1.Value = New Decimal(New Integer() {67, 0, 0, 0})
            FormatConditionIconSetIcon1.ValueComparison = DevExpress.XtraEditors.FormatConditionComparisonType.GreaterOrEqual
            FormatConditionIconSetIcon2.PredefinedName = "Stars3_2.png"
            FormatConditionIconSetIcon2.Value = New Decimal(New Integer() {33, 0, 0, 0})
            FormatConditionIconSetIcon2.ValueComparison = DevExpress.XtraEditors.FormatConditionComparisonType.GreaterOrEqual
            FormatConditionIconSetIcon3.PredefinedName = "Stars3_3.png"
            FormatConditionIconSetIcon3.ValueComparison = DevExpress.XtraEditors.FormatConditionComparisonType.GreaterOrEqual
            FormatConditionIconSet1.Icons.Add(FormatConditionIconSetIcon1)
            FormatConditionIconSet1.Icons.Add(FormatConditionIconSetIcon2)
            FormatConditionIconSet1.Icons.Add(FormatConditionIconSetIcon3)
            FormatConditionIconSet1.Name = "Stars3"
            FormatConditionIconSet1.ValueType = DevExpress.XtraEditors.FormatConditionValueType.Percent
            FormatConditionRuleIconSet1.IconSet = FormatConditionIconSet1
            GridFormatRule1.Rule = FormatConditionRuleIconSet1
            GridFormatRule2.Column = Me.bcMPGCity
            GridFormatRule2.Name = "Format1"
            FormatConditionIconSet2.CategoryName = "Directional"
            FormatConditionIconSetIcon4.PredefinedName = "Arrows3_1.png"
            FormatConditionIconSetIcon4.Value = New Decimal(New Integer() {67, 0, 0, 0})
            FormatConditionIconSetIcon4.ValueComparison = DevExpress.XtraEditors.FormatConditionComparisonType.GreaterOrEqual
            FormatConditionIconSetIcon5.PredefinedName = "Arrows3_2.png"
            FormatConditionIconSetIcon5.Value = New Decimal(New Integer() {33, 0, 0, 0})
            FormatConditionIconSetIcon5.ValueComparison = DevExpress.XtraEditors.FormatConditionComparisonType.GreaterOrEqual
            FormatConditionIconSetIcon6.PredefinedName = "Arrows3_3.png"
            FormatConditionIconSetIcon6.ValueComparison = DevExpress.XtraEditors.FormatConditionComparisonType.GreaterOrEqual
            FormatConditionIconSet2.Icons.Add(FormatConditionIconSetIcon4)
            FormatConditionIconSet2.Icons.Add(FormatConditionIconSetIcon5)
            FormatConditionIconSet2.Icons.Add(FormatConditionIconSetIcon6)
            FormatConditionIconSet2.Name = "Arrows3Colored"
            FormatConditionIconSet2.ValueType = DevExpress.XtraEditors.FormatConditionValueType.Percent
            FormatConditionRuleIconSet2.IconSet = FormatConditionIconSet2
            GridFormatRule2.Rule = FormatConditionRuleIconSet2
            GridFormatRule3.Column = Me.bcMPGHighway
            GridFormatRule3.Name = "Format2"
            FormatConditionIconSet3.CategoryName = "Directional"
            FormatConditionIconSetIcon7.PredefinedName = "Arrows3_1.png"
            FormatConditionIconSetIcon7.Value = New Decimal(New Integer() {67, 0, 0, 0})
            FormatConditionIconSetIcon7.ValueComparison = DevExpress.XtraEditors.FormatConditionComparisonType.GreaterOrEqual
            FormatConditionIconSetIcon8.PredefinedName = "Arrows3_2.png"
            FormatConditionIconSetIcon8.Value = New Decimal(New Integer() {33, 0, 0, 0})
            FormatConditionIconSetIcon8.ValueComparison = DevExpress.XtraEditors.FormatConditionComparisonType.GreaterOrEqual
            FormatConditionIconSetIcon9.PredefinedName = "Arrows3_3.png"
            FormatConditionIconSetIcon9.ValueComparison = DevExpress.XtraEditors.FormatConditionComparisonType.GreaterOrEqual
            FormatConditionIconSet3.Icons.Add(FormatConditionIconSetIcon7)
            FormatConditionIconSet3.Icons.Add(FormatConditionIconSetIcon8)
            FormatConditionIconSet3.Icons.Add(FormatConditionIconSetIcon9)
            FormatConditionIconSet3.Name = "Arrows3Colored"
            FormatConditionIconSet3.ValueType = DevExpress.XtraEditors.FormatConditionValueType.Percent
            FormatConditionRuleIconSet3.IconSet = FormatConditionIconSet3
            GridFormatRule3.Rule = FormatConditionRuleIconSet3
            GridFormatRule4.Column = Me.bcPrice
            GridFormatRule4.Name = "Format3"
            FormatConditionRuleDataBar1.AutomaticType = DevExpress.XtraEditors.FormatConditionAutomaticType.ZeroBased
            FormatConditionRuleDataBar1.PredefinedName = "Mint"
            GridFormatRule4.Rule = FormatConditionRuleDataBar1
            Me.bandedGridView1.FormatRules.Add(GridFormatRule1)
            Me.bandedGridView1.FormatRules.Add(GridFormatRule2)
            Me.bandedGridView1.FormatRules.Add(GridFormatRule3)
            Me.bandedGridView1.FormatRules.Add(GridFormatRule4)
            Me.bandedGridView1.GridControl = Me.gridControl1
            Me.bandedGridView1.Name = "bandedGridView1"
            Me.bandedGridView1.OptionsBehavior.AllowPixelScrolling = DevExpress.Utils.DefaultBoolean.[True]
            Me.bandedGridView1.OptionsBehavior.AutoExpandAllGroups = True
            Me.bandedGridView1.OptionsClipboard.ClipboardMode = DevExpress.Export.ClipboardMode.Formatted
            Me.bandedGridView1.OptionsCustomization.AllowChangeColumnParent = True
            Me.bandedGridView1.OptionsCustomization.CustomizationFormSnapMode = DevExpress.Utils.Controls.SnapMode.OwnerControl
            Me.bandedGridView1.OptionsCustomization.ShowBandsInCustomizationForm = False
            Me.bandedGridView1.OptionsDetail.EnableMasterViewMode = False
            Me.bandedGridView1.OptionsFilter.ColumnFilterPopupMode = DevExpress.XtraGrid.Columns.ColumnFilterPopupMode.Excel
            Me.bandedGridView1.OptionsView.AllowHtmlDrawHeaders = True
            Me.bandedGridView1.OptionsView.ShowGroupPanel = False
            '
            'gridBand1
            '
            Me.gridBand1.Caption = "Order Info"
            Me.gridBand1.Columns.Add(Me.bcOrderID)
            Me.gridBand1.Columns.Add(Me.bcPrice)
            Me.gridBand1.Columns.Add(Me.bcDiscount)
            Me.gridBand1.Columns.Add(Me.bcSalesDate)
            Me.gridBand1.Name = "gridBand1"
            Me.gridBand1.VisibleIndex = 0
            Me.gridBand1.Width = 350
            '
            'bcOrderID
            '
            Me.bcOrderID.Caption = "ID"
            Me.bcOrderID.ColumnEdit = Me.repositoryItemTextEdit5
            Me.bcOrderID.FieldName = "OrderID"
            Me.bcOrderID.Name = "bcOrderID"
            Me.bcOrderID.OptionsColumn.AllowEdit = False
            Me.bcOrderID.OptionsFilter.PopupExcelFilterDefaultTab = DevExpress.XtraGrid.Columns.ExcelFilterDefaultTab.Filters
            Me.bcOrderID.OptionsFilter.PopupExcelFilterEnumFilters = DevExpress.XtraGrid.Columns.ExcelFilterEnumFilters.AllFilters
            Me.bcOrderID.Visible = True
            Me.bcOrderID.Width = 50
            '
            'repositoryItemTextEdit5
            '
            Me.repositoryItemTextEdit5.AutoHeight = False
            Me.repositoryItemTextEdit5.Mask.EditMask = "d5"
            Me.repositoryItemTextEdit5.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
            Me.repositoryItemTextEdit5.Mask.UseMaskAsDisplayFormat = True
            Me.repositoryItemTextEdit5.Name = "repositoryItemTextEdit5"
            '
            'bcSalesDate
            '
            Me.bcSalesDate.FieldName = "SalesDate"
            Me.bcSalesDate.Name = "bcSalesDate"
            Me.bcSalesDate.OptionsFilter.PopupExcelFilterDefaultTab = DevExpress.XtraGrid.Columns.ExcelFilterDefaultTab.Filters
            Me.bcSalesDate.OptionsFilter.PopupExcelFilterEnumFilters = DevExpress.XtraGrid.Columns.ExcelFilterEnumFilters.AllFilters
            Me.bcSalesDate.Visible = True
            '
            'gridBand2
            '
            Me.gridBand2.Caption = "Model"
            Me.gridBand2.Columns.Add(Me.bcPhoto)
            Me.gridBand2.Columns.Add(Me.bcTrademark)
            Me.gridBand2.Columns.Add(Me.bcName)
            Me.gridBand2.Columns.Add(Me.bcModification)
            Me.gridBand2.Name = "gridBand2"
            Me.gridBand2.VisibleIndex = 1
            Me.gridBand2.Width = 360
            '
            'bcPhoto
            '
            Me.bcPhoto.FieldName = "Photo"
            Me.bcPhoto.Name = "bcPhoto"
            Me.bcPhoto.OptionsFilter.AllowFilter = False
            Me.bcPhoto.OptionsFilter.PopupExcelFilterDefaultTab = DevExpress.XtraGrid.Columns.ExcelFilterDefaultTab.Filters
            Me.bcPhoto.OptionsFilter.PopupExcelFilterEnumFilters = DevExpress.XtraGrid.Columns.ExcelFilterEnumFilters.AllFilters
            Me.bcPhoto.Width = 64
            '
            'bcTrademark
            '
            Me.bcTrademark.FieldName = "Trademark"
            Me.bcTrademark.Name = "bcTrademark"
            Me.bcTrademark.OptionsFilter.PopupExcelFilterDefaultTab = DevExpress.XtraGrid.Columns.ExcelFilterDefaultTab.Filters
            Me.bcTrademark.OptionsFilter.PopupExcelFilterEnumFilters = DevExpress.XtraGrid.Columns.ExcelFilterEnumFilters.AllFilters
            Me.bcTrademark.Visible = True
            Me.bcTrademark.Width = 100
            '
            'bcName
            '
            Me.bcName.FieldName = "Name"
            Me.bcName.Name = "bcName"
            Me.bcName.OptionsFilter.PopupExcelFilterDefaultTab = DevExpress.XtraGrid.Columns.ExcelFilterDefaultTab.Filters
            Me.bcName.OptionsFilter.PopupExcelFilterEnumFilters = DevExpress.XtraGrid.Columns.ExcelFilterEnumFilters.AllFilters
            Me.bcName.Visible = True
            Me.bcName.Width = 100
            '
            'bcModification
            '
            Me.bcModification.FieldName = "Modification"
            Me.bcModification.Name = "bcModification"
            Me.bcModification.OptionsFilter.PopupExcelFilterDefaultTab = DevExpress.XtraGrid.Columns.ExcelFilterDefaultTab.Filters
            Me.bcModification.OptionsFilter.PopupExcelFilterEnumFilters = DevExpress.XtraGrid.Columns.ExcelFilterEnumFilters.AllFilters
            Me.bcModification.Visible = True
            Me.bcModification.Width = 160
            '
            'gridBand3
            '
            Me.gridBand3.Caption = "Performance"
            Me.gridBand3.Columns.Add(Me.bcMPGCity)
            Me.gridBand3.Columns.Add(Me.bcMPGHighway)
            Me.gridBand3.Columns.Add(Me.bcCylinders)
            Me.gridBand3.Columns.Add(Me.bcTransmissionSpeeds)
            Me.gridBand3.Image = CType(resources.GetObject("gridBand3.Image"), System.Drawing.Image)
            Me.gridBand3.Name = "gridBand3"
            Me.gridBand3.VisibleIndex = 2
            Me.gridBand3.Width = 210
            '
            'bcCylinders
            '
            Me.bcCylinders.FieldName = "Cylinders"
            Me.bcCylinders.Name = "bcCylinders"
            Me.bcCylinders.OptionsFilter.PopupExcelFilterDefaultTab = DevExpress.XtraGrid.Columns.ExcelFilterDefaultTab.Filters
            Me.bcCylinders.OptionsFilter.PopupExcelFilterEnumFilters = DevExpress.XtraGrid.Columns.ExcelFilterEnumFilters.AllFilters
            Me.bcCylinders.Visible = True
            Me.bcCylinders.Width = 60
            '
            'bcTransmissionSpeeds
            '
            Me.bcTransmissionSpeeds.FieldName = "TransmissionSpeeds"
            Me.bcTransmissionSpeeds.Name = "bcTransmissionSpeeds"
            Me.bcTransmissionSpeeds.OptionsFilter.PopupExcelFilterDefaultTab = DevExpress.XtraGrid.Columns.ExcelFilterDefaultTab.Filters
            Me.bcTransmissionSpeeds.OptionsFilter.PopupExcelFilterEnumFilters = DevExpress.XtraGrid.Columns.ExcelFilterEnumFilters.AllFilters
            '
            'bcCategory
            '
            Me.bcCategory.FieldName = "Category"
            Me.bcCategory.Name = "bcCategory"
            Me.bcCategory.OptionsFilter.PopupExcelFilterDefaultTab = DevExpress.XtraGrid.Columns.ExcelFilterDefaultTab.Filters
            Me.bcCategory.OptionsFilter.PopupExcelFilterEnumFilters = DevExpress.XtraGrid.Columns.ExcelFilterEnumFilters.AllFilters
            Me.bcCategory.Width = 84
            '
            'bcDoors
            '
            Me.bcDoors.FieldName = "Doors"
            Me.bcDoors.Name = "bcDoors"
            Me.bcDoors.OptionsFilter.PopupExcelFilterDefaultTab = DevExpress.XtraGrid.Columns.ExcelFilterDefaultTab.Filters
            Me.bcDoors.OptionsFilter.PopupExcelFilterEnumFilters = DevExpress.XtraGrid.Columns.ExcelFilterEnumFilters.AllFilters
            '
            'bcBodyStyle
            '
            Me.bcBodyStyle.FieldName = "BodyStyle"
            Me.bcBodyStyle.Name = "bcBodyStyle"
            Me.bcBodyStyle.OptionsFilter.PopupExcelFilterDefaultTab = DevExpress.XtraGrid.Columns.ExcelFilterDefaultTab.Filters
            Me.bcBodyStyle.OptionsFilter.PopupExcelFilterEnumFilters = DevExpress.XtraGrid.Columns.ExcelFilterEnumFilters.AllFilters
            Me.bcBodyStyle.Width = 92
            '
            'bcHorsepower
            '
            Me.bcHorsepower.FieldName = "Horsepower"
            Me.bcHorsepower.Name = "bcHorsepower"
            Me.bcHorsepower.OptionsFilter.PopupExcelFilterDefaultTab = DevExpress.XtraGrid.Columns.ExcelFilterDefaultTab.Filters
            Me.bcHorsepower.OptionsFilter.PopupExcelFilterEnumFilters = DevExpress.XtraGrid.Columns.ExcelFilterEnumFilters.AllFilters
            Me.bcHorsepower.Width = 71
            '
            'bcTorque
            '
            Me.bcTorque.FieldName = "Torque"
            Me.bcTorque.Name = "bcTorque"
            Me.bcTorque.OptionsFilter.PopupExcelFilterDefaultTab = DevExpress.XtraGrid.Columns.ExcelFilterDefaultTab.Filters
            Me.bcTorque.OptionsFilter.PopupExcelFilterEnumFilters = DevExpress.XtraGrid.Columns.ExcelFilterEnumFilters.AllFilters
            Me.bcTorque.Width = 83
            '
            'bcTransmissionType
            '
            Me.bcTransmissionType.FieldName = "TransmissionType"
            Me.bcTransmissionType.Name = "bcTransmissionType"
            Me.bcTransmissionType.OptionsFilter.PopupExcelFilterDefaultTab = DevExpress.XtraGrid.Columns.ExcelFilterDefaultTab.Filters
            Me.bcTransmissionType.OptionsFilter.PopupExcelFilterEnumFilters = DevExpress.XtraGrid.Columns.ExcelFilterEnumFilters.AllFilters
            '
            'ExcelFiltering
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.gridControl1)
            Me.Name = "ExcelFiltering"
            Me.Size = New System.Drawing.Size(944, 562)
            CType(Me.repositoryItemTextEdit4, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repositoryItemTextEdit3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repositoryItemSpinEdit1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.bandedGridView1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repositoryItemTextEdit5, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        #End Region

        Private gridControl1 As GridControl
        Private repositoryItemSpinEdit1 As XtraEditors.Repository.RepositoryItemSpinEdit
        Private repositoryItemTextEdit1 As XtraEditors.Repository.RepositoryItemTextEdit
        Private repositoryItemTextEdit2 As XtraEditors.Repository.RepositoryItemTextEdit
        Private repositoryItemTextEdit3 As XtraEditors.Repository.RepositoryItemTextEdit
        Private bandedGridView1 As Views.BandedGrid.BandedGridView
        Private bcTrademark As Views.BandedGrid.BandedGridColumn
        Private bcName As Views.BandedGrid.BandedGridColumn
        Private bcModification As Views.BandedGrid.BandedGridColumn
        Private bcCategory As Views.BandedGrid.BandedGridColumn
        Private bcBodyStyle As Views.BandedGrid.BandedGridColumn
        Private bcMPGCity As Views.BandedGrid.BandedGridColumn
        Private bcMPGHighway As Views.BandedGrid.BandedGridColumn
        Private bcHorsepower As Views.BandedGrid.BandedGridColumn
        Private bcTorque As Views.BandedGrid.BandedGridColumn
        Private bcPhoto As Views.BandedGrid.BandedGridColumn
        Private bcPrice As Views.BandedGrid.BandedGridColumn
        Private bcDoors As Views.BandedGrid.BandedGridColumn
        Private bcCylinders As Views.BandedGrid.BandedGridColumn
        Private bcTransmissionSpeeds As Views.BandedGrid.BandedGridColumn
        Private bcTransmissionType As Views.BandedGrid.BandedGridColumn
        Private bcSalesDate As Views.BandedGrid.BandedGridColumn
        Private bcOrderID As Views.BandedGrid.BandedGridColumn
        Private bcDiscount As Views.BandedGrid.BandedGridColumn
        Private gridBand1 As Views.BandedGrid.GridBand
        Private repositoryItemTextEdit5 As XtraEditors.Repository.RepositoryItemTextEdit
        Private repositoryItemTextEdit4 As XtraEditors.Repository.RepositoryItemTextEdit
        Private gridBand2 As Views.BandedGrid.GridBand
        Private gridBand3 As Views.BandedGrid.GridBand
    End Class
End Namespace
