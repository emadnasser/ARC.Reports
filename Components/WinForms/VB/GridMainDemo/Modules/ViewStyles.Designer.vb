Namespace DevExpress.XtraGrid.Demos
    Partial Public Class ViewStyles
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
            Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(ViewStyles))
            Dim gridFormatRule1 As New DevExpress.XtraGrid.GridFormatRule()
            Dim formatConditionRuleValue1 As New DevExpress.XtraEditors.FormatConditionRuleValue()
            Dim gridFormatRule2 As New DevExpress.XtraGrid.GridFormatRule()
            Dim formatConditionRuleIconSet1 As New DevExpress.XtraEditors.FormatConditionRuleIconSet()
            Dim formatConditionIconSet1 As New DevExpress.XtraEditors.FormatConditionIconSet()
            Dim formatConditionIconSetIcon1 As New DevExpress.XtraEditors.FormatConditionIconSetIcon()
            Dim formatConditionIconSetIcon2 As New DevExpress.XtraEditors.FormatConditionIconSetIcon()
            Dim formatConditionIconSetIcon3 As New DevExpress.XtraEditors.FormatConditionIconSetIcon()
            Dim gridFormatRule3 As New DevExpress.XtraGrid.GridFormatRule()
            Dim formatConditionRuleIconSet2 As New DevExpress.XtraEditors.FormatConditionRuleIconSet()
            Dim formatConditionIconSet2 As New DevExpress.XtraEditors.FormatConditionIconSet()
            Dim formatConditionIconSetIcon4 As New DevExpress.XtraEditors.FormatConditionIconSetIcon()
            Dim formatConditionIconSetIcon5 As New DevExpress.XtraEditors.FormatConditionIconSetIcon()
            Dim formatConditionIconSetIcon6 As New DevExpress.XtraEditors.FormatConditionIconSetIcon()
            Dim gridFormatRule4 As New DevExpress.XtraGrid.GridFormatRule()
            Dim formatConditionRuleValue2 As New DevExpress.XtraEditors.FormatConditionRuleValue()
            Dim gridFormatRule5 As New DevExpress.XtraGrid.GridFormatRule()
            Dim formatConditionRuleIconSet3 As New DevExpress.XtraEditors.FormatConditionRuleIconSet()
            Dim formatConditionIconSet3 As New DevExpress.XtraEditors.FormatConditionIconSet()
            Dim formatConditionIconSetIcon7 As New DevExpress.XtraEditors.FormatConditionIconSetIcon()
            Dim formatConditionIconSetIcon8 As New DevExpress.XtraEditors.FormatConditionIconSetIcon()
            Dim formatConditionIconSetIcon9 As New DevExpress.XtraEditors.FormatConditionIconSetIcon()
            Dim gridFormatRule6 As New DevExpress.XtraGrid.GridFormatRule()
            Dim formatConditionRuleIconSet4 As New DevExpress.XtraEditors.FormatConditionRuleIconSet()
            Dim formatConditionIconSet4 As New DevExpress.XtraEditors.FormatConditionIconSet()
            Dim formatConditionIconSetIcon10 As New DevExpress.XtraEditors.FormatConditionIconSetIcon()
            Dim formatConditionIconSetIcon11 As New DevExpress.XtraEditors.FormatConditionIconSetIcon()
            Dim formatConditionIconSetIcon12 As New DevExpress.XtraEditors.FormatConditionIconSetIcon()
            Dim gridFormatRule7 As New DevExpress.XtraGrid.GridFormatRule()
            Dim formatConditionRule2ColorScale1 As New DevExpress.XtraEditors.FormatConditionRule2ColorScale()
            Dim gridFormatRule8 As New DevExpress.XtraGrid.GridFormatRule()
            Dim formatConditionRuleValue3 As New DevExpress.XtraEditors.FormatConditionRuleValue()
            Dim gridFormatRule9 As New DevExpress.XtraGrid.GridFormatRule()
            Dim formatConditionRuleIconSet5 As New DevExpress.XtraEditors.FormatConditionRuleIconSet()
            Dim formatConditionIconSet5 As New DevExpress.XtraEditors.FormatConditionIconSet()
            Dim formatConditionIconSetIcon13 As New DevExpress.XtraEditors.FormatConditionIconSetIcon()
            Dim formatConditionIconSetIcon14 As New DevExpress.XtraEditors.FormatConditionIconSetIcon()
            Dim formatConditionIconSetIcon15 As New DevExpress.XtraEditors.FormatConditionIconSetIcon()
            Dim gridFormatRule10 As New DevExpress.XtraGrid.GridFormatRule()
            Dim formatConditionRuleIconSet6 As New DevExpress.XtraEditors.FormatConditionRuleIconSet()
            Dim formatConditionIconSet6 As New DevExpress.XtraEditors.FormatConditionIconSet()
            Dim formatConditionIconSetIcon16 As New DevExpress.XtraEditors.FormatConditionIconSetIcon()
            Dim formatConditionIconSetIcon17 As New DevExpress.XtraEditors.FormatConditionIconSetIcon()
            Dim formatConditionIconSetIcon18 As New DevExpress.XtraEditors.FormatConditionIconSetIcon()
            Me.bgcInStock = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.bgcMPGCity = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.bgcMPGHighway = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.gcInStock = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.gcMPGCity = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.gcMPGHighway = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.gcPrice = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.bcInStock = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.bcMPGCity = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.bcMPGHighway = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.repositoryItemImageComboBox3 = New DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox()
            Me.repositoryItemSpinEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
            Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
            Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
            Me.chAdvBanded = New DevExpress.XtraEditors.CheckButton()
            Me.chBanded = New DevExpress.XtraEditors.CheckButton()
            Me.chCard = New DevExpress.XtraEditors.CheckButton()
            Me.chGrid = New DevExpress.XtraEditors.CheckButton()
            Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
            Me.advBandedGridView1 = New DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView()
            Me.gbMain = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
            Me.bgcID = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.bgcTrademark = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.bgcName = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.bgcModification = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.bgcLogo = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.bgcDescription = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.repositoryItemMemoEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
            Me.gbPerfomance = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
            Me.bgcHorsepower = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.bgcTorque = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.bgcDoors = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.bgcCylinders = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.bgcTransmissionType = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.bgcTransmissionSpeeds = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.gbImage = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
            Me.bgcPhoto = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.gbInfo = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
            Me.pgcCategory = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.bgcBodyStyle = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.bgcPrice = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.bgcDeliveryDate = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.repositoryItemMemoExEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit()
            Me.repositoryItemPictureEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit()
            Me.repositoryItemImageEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemImageEdit()
            Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.gcID = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.gcTrademark = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.gcName = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.gcModification = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.gcCategory = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.gcDoors = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.gcBodyStyle = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.gcCylinders = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.gcHorsepower = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.gcTorque = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.gcTransmissionSpeeds = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.gcTransmissionType = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.gcDescription = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.gcImage = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.gcDeliveryDate = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.gcPhoto = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.bandedGridView1 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridView()
            Me.gridBand1 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
            Me.gridBand2 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
            Me.bcLogo = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.bcTrademark = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.bcName = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.bcModification = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.gridBand3 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
            Me.bcCategory = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.bcBodyStyle = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.gridBand4 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
            Me.gridBand6 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
            Me.gridBand7 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
            Me.bcHorsepower = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.bcTorque = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.gridBand5 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
            Me.bcPhoto = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.bcDescription = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.bcID = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.bcPrice = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.bcDoors = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.bcCylinders = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.bcTransmissionSpeeds = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.bcTransmissionType = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.bcImage = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.bcDeliveryDate = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.cardView1 = New DevExpress.XtraGrid.Views.Card.CardView()
            Me.colTrademark = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colName = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colModification = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colCategory = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colBodyStyle = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colPhoto = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colDescription = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colDeliveryDate = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colPrice = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colInStock = New DevExpress.XtraGrid.Columns.GridColumn()
            DirectCast(Me.repositoryItemImageComboBox3, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.repositoryItemSpinEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panelControl1.SuspendLayout()
            DirectCast(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.advBandedGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.repositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.repositoryItemMemoExEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.repositoryItemPictureEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.repositoryItemImageEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.bandedGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.cardView1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' bgcInStock
            ' 
            Me.bgcInStock.FieldName = "InStock"
            Me.bgcInStock.Name = "bgcInStock"
            ' 
            ' bgcMPGCity
            ' 
            resources.ApplyResources(Me.bgcMPGCity, "bgcMPGCity")
            Me.bgcMPGCity.FieldName = "MPGCity"
            Me.bgcMPGCity.Name = "bgcMPGCity"
            Me.bgcMPGCity.RowIndex = 1
            ' 
            ' bgcMPGHighway
            ' 
            resources.ApplyResources(Me.bgcMPGHighway, "bgcMPGHighway")
            Me.bgcMPGHighway.FieldName = "MPGHighway"
            Me.bgcMPGHighway.Name = "bgcMPGHighway"
            Me.bgcMPGHighway.RowIndex = 1
            ' 
            ' gcInStock
            ' 
            Me.gcInStock.FieldName = "InStock"
            Me.gcInStock.Name = "gcInStock"
            resources.ApplyResources(Me.gcInStock, "gcInStock")
            ' 
            ' gcMPGCity
            ' 
            Me.gcMPGCity.FieldName = "MPGCity"
            Me.gcMPGCity.Name = "gcMPGCity"
            resources.ApplyResources(Me.gcMPGCity, "gcMPGCity")
            ' 
            ' gcMPGHighway
            ' 
            Me.gcMPGHighway.FieldName = "MPGHighway"
            Me.gcMPGHighway.Name = "gcMPGHighway"
            resources.ApplyResources(Me.gcMPGHighway, "gcMPGHighway")
            ' 
            ' gcPrice
            ' 
            Me.gcPrice.FieldName = "Price"
            Me.gcPrice.Name = "gcPrice"
            resources.ApplyResources(Me.gcPrice, "gcPrice")
            ' 
            ' bcInStock
            ' 
            Me.bcInStock.FieldName = "InStock"
            Me.bcInStock.Name = "bcInStock"
            resources.ApplyResources(Me.bcInStock, "bcInStock")
            ' 
            ' bcMPGCity
            ' 
            Me.bcMPGCity.FieldName = "MPGCity"
            Me.bcMPGCity.Name = "bcMPGCity"
            resources.ApplyResources(Me.bcMPGCity, "bcMPGCity")
            ' 
            ' bcMPGHighway
            ' 
            Me.bcMPGHighway.FieldName = "MPGHighway"
            Me.bcMPGHighway.Name = "bcMPGHighway"
            resources.ApplyResources(Me.bcMPGHighway, "bcMPGHighway")
            ' 
            ' repositoryItemImageComboBox3
            ' 
            Me.repositoryItemImageComboBox3.AllowFocused = False
            resources.ApplyResources(Me.repositoryItemImageComboBox3, "repositoryItemImageComboBox3")
            Me.repositoryItemImageComboBox3.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton((DirectCast(resources.GetObject("repositoryItemImageComboBox3.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines)))})
            Me.repositoryItemImageComboBox3.Items.AddRange(New DevExpress.XtraEditors.Controls.ImageComboBoxItem() {
                New DevExpress.XtraEditors.Controls.ImageComboBoxItem(resources.GetString("repositoryItemImageComboBox3.Items"), (DirectCast(resources.GetObject("repositoryItemImageComboBox3.Items1"), Object)), (DirectCast(resources.GetObject("repositoryItemImageComboBox3.Items2"), Integer))),
                New DevExpress.XtraEditors.Controls.ImageComboBoxItem(resources.GetString("repositoryItemImageComboBox3.Items3"), (DirectCast(resources.GetObject("repositoryItemImageComboBox3.Items4"), Object)), (DirectCast(resources.GetObject("repositoryItemImageComboBox3.Items5"), Integer))),
                New DevExpress.XtraEditors.Controls.ImageComboBoxItem(resources.GetString("repositoryItemImageComboBox3.Items6"), (DirectCast(resources.GetObject("repositoryItemImageComboBox3.Items7"), Object)), (DirectCast(resources.GetObject("repositoryItemImageComboBox3.Items8"), Integer)))
            })
            Me.repositoryItemImageComboBox3.Name = "repositoryItemImageComboBox3"
            ' 
            ' repositoryItemSpinEdit3
            ' 
            Me.repositoryItemSpinEdit3.AllowFocused = False
            resources.ApplyResources(Me.repositoryItemSpinEdit3, "repositoryItemSpinEdit3")
            Me.repositoryItemSpinEdit3.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
            Me.repositoryItemSpinEdit3.Name = "repositoryItemSpinEdit3"
            ' 
            ' imageList1
            ' 
            Me.imageList1.ImageStream = (DirectCast(resources.GetObject("imageList1.ImageStream"), System.Windows.Forms.ImageListStreamer))
            Me.imageList1.TransparentColor = System.Drawing.Color.Magenta
            Me.imageList1.Images.SetKeyName(0, "GridView.png")
            Me.imageList1.Images.SetKeyName(1, "CardView.png")
            Me.imageList1.Images.SetKeyName(2, "BandView.png")
            Me.imageList1.Images.SetKeyName(3, "ABandView.png")
            ' 
            ' panelControl1
            ' 
            Me.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.panelControl1.Controls.Add(Me.chAdvBanded)
            Me.panelControl1.Controls.Add(Me.chBanded)
            Me.panelControl1.Controls.Add(Me.chCard)
            Me.panelControl1.Controls.Add(Me.chGrid)
            resources.ApplyResources(Me.panelControl1, "panelControl1")
            Me.panelControl1.Name = "panelControl1"
            ' 
            ' chAdvBanded
            ' 
            Me.chAdvBanded.AllowFocus = False
            Me.chAdvBanded.AllowHtmlDraw = DevExpress.Utils.DefaultBoolean.True
            Me.chAdvBanded.Appearance.FontStyleDelta = (DirectCast(resources.GetObject("chAdvBanded.Appearance.FontStyleDelta"), System.Drawing.FontStyle))
            Me.chAdvBanded.Appearance.Options.UseFont = True
            Me.chAdvBanded.Appearance.Options.UseTextOptions = True
            Me.chAdvBanded.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
            Me.chAdvBanded.Checked = True
            Me.chAdvBanded.Cursor = System.Windows.Forms.Cursors.Hand
            Me.chAdvBanded.ImageIndex = 3
            Me.chAdvBanded.ImageList = Me.imageList1
            resources.ApplyResources(Me.chAdvBanded, "chAdvBanded")
            Me.chAdvBanded.Name = "chAdvBanded"
            Me.chAdvBanded.Tag = "Advanced Banded GridView"
            ' 
            ' chBanded
            ' 
            Me.chBanded.AllowFocus = False
            Me.chBanded.AllowHtmlDraw = DevExpress.Utils.DefaultBoolean.True
            Me.chBanded.Appearance.FontStyleDelta = (DirectCast(resources.GetObject("chBanded.Appearance.FontStyleDelta"), System.Drawing.FontStyle))
            Me.chBanded.Appearance.Options.UseFont = True
            Me.chBanded.Appearance.Options.UseTextOptions = True
            Me.chBanded.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
            Me.chBanded.Cursor = System.Windows.Forms.Cursors.Hand
            Me.chBanded.ImageIndex = 2
            Me.chBanded.ImageList = Me.imageList1
            resources.ApplyResources(Me.chBanded, "chBanded")
            Me.chBanded.Name = "chBanded"
            Me.chBanded.Tag = "Banded GridView"
            ' 
            ' chCard
            ' 
            Me.chCard.AllowFocus = False
            Me.chCard.Appearance.FontStyleDelta = (DirectCast(resources.GetObject("chCard.Appearance.FontStyleDelta"), System.Drawing.FontStyle))
            Me.chCard.Appearance.Options.UseFont = True
            Me.chCard.Appearance.Options.UseTextOptions = True
            Me.chCard.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
            Me.chCard.Cursor = System.Windows.Forms.Cursors.Hand
            Me.chCard.ImageIndex = 1
            Me.chCard.ImageList = Me.imageList1
            resources.ApplyResources(Me.chCard, "chCard")
            Me.chCard.Name = "chCard"
            Me.chCard.Tag = "CardView"
            ' 
            ' chGrid
            ' 
            Me.chGrid.AllowFocus = False
            Me.chGrid.Appearance.FontStyleDelta = (DirectCast(resources.GetObject("chGrid.Appearance.FontStyleDelta"), System.Drawing.FontStyle))
            Me.chGrid.Appearance.Options.UseFont = True
            Me.chGrid.Appearance.Options.UseTextOptions = True
            Me.chGrid.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
            Me.chGrid.Cursor = System.Windows.Forms.Cursors.Hand
            Me.chGrid.ImageIndex = 0
            Me.chGrid.ImageList = Me.imageList1
            resources.ApplyResources(Me.chGrid, "chGrid")
            Me.chGrid.Name = "chGrid"
            Me.chGrid.Tag = "GridView"
            ' 
            ' gridControl1
            ' 
            resources.ApplyResources(Me.gridControl1, "gridControl1")
            Me.gridControl1.MainView = Me.advBandedGridView1
            Me.gridControl1.Name = "gridControl1"
            Me.gridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() { Me.repositoryItemMemoExEdit1, Me.repositoryItemPictureEdit1, Me.repositoryItemMemoEdit1, Me.repositoryItemImageEdit1})
            Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.advBandedGridView1, Me.gridView1, Me.bandedGridView1, Me.cardView1})
            ' 
            ' advBandedGridView1
            ' 
            Me.advBandedGridView1.Bands.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() { Me.gbMain, Me.gbPerfomance, Me.gbImage, Me.gbInfo})
            Me.advBandedGridView1.Columns.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn() { Me.bgcID, Me.bgcTrademark, Me.bgcName, Me.bgcModification, Me.pgcCategory, Me.bgcPrice, Me.bgcMPGCity, Me.bgcMPGHighway, Me.bgcDoors, Me.bgcBodyStyle, Me.bgcCylinders, Me.bgcHorsepower, Me.bgcTorque, Me.bgcDescription, Me.bgcPhoto, Me.bgcTransmissionSpeeds, Me.bgcTransmissionType, Me.bgcDeliveryDate, Me.bgcInStock, Me.bgcLogo})
            gridFormatRule1.ApplyToRow = True
            gridFormatRule1.Column = Me.bgcInStock
            gridFormatRule1.Name = "Format0"
            formatConditionRuleValue1.Appearance.ForeColor = (DirectCast(resources.GetObject("resource.ForeColor"), System.Drawing.Color))
            formatConditionRuleValue1.Appearance.Options.UseForeColor = True
            formatConditionRuleValue1.Condition = DevExpress.XtraEditors.FormatCondition.NotEqual
            formatConditionRuleValue1.PredefinedName = "Strikeout Text"
            formatConditionRuleValue1.Value1 = True
            gridFormatRule1.Rule = formatConditionRuleValue1
            gridFormatRule2.Column = Me.bgcMPGCity
            gridFormatRule2.Name = "Format1"
            formatConditionIconSet1.CategoryName = "Directional"
            formatConditionIconSetIcon1.PredefinedName = "Arrows3_1.png"
            formatConditionIconSetIcon1.Value = New Decimal(New Integer() { 67, 0, 0, 0})
            formatConditionIconSetIcon1.ValueComparison = DevExpress.XtraEditors.FormatConditionComparisonType.GreaterOrEqual
            formatConditionIconSetIcon2.PredefinedName = "Arrows3_2.png"
            formatConditionIconSetIcon2.Value = New Decimal(New Integer() { 33, 0, 0, 0})
            formatConditionIconSetIcon2.ValueComparison = DevExpress.XtraEditors.FormatConditionComparisonType.GreaterOrEqual
            formatConditionIconSetIcon3.PredefinedName = "Arrows3_3.png"
            formatConditionIconSetIcon3.ValueComparison = DevExpress.XtraEditors.FormatConditionComparisonType.GreaterOrEqual
            formatConditionIconSet1.Icons.Add(formatConditionIconSetIcon1)
            formatConditionIconSet1.Icons.Add(formatConditionIconSetIcon2)
            formatConditionIconSet1.Icons.Add(formatConditionIconSetIcon3)
            formatConditionIconSet1.Name = "Arrows3Colored"
            formatConditionIconSet1.ValueType = DevExpress.XtraEditors.FormatConditionValueType.Percent
            formatConditionRuleIconSet1.IconSet = formatConditionIconSet1
            gridFormatRule2.Rule = formatConditionRuleIconSet1
            gridFormatRule3.Column = Me.bgcMPGHighway
            gridFormatRule3.Name = "Format2"
            formatConditionIconSet2.CategoryName = "Directional"
            formatConditionIconSetIcon4.PredefinedName = "Arrows3_1.png"
            formatConditionIconSetIcon4.Value = New Decimal(New Integer() { 67, 0, 0, 0})
            formatConditionIconSetIcon4.ValueComparison = DevExpress.XtraEditors.FormatConditionComparisonType.GreaterOrEqual
            formatConditionIconSetIcon5.PredefinedName = "Arrows3_2.png"
            formatConditionIconSetIcon5.Value = New Decimal(New Integer() { 33, 0, 0, 0})
            formatConditionIconSetIcon5.ValueComparison = DevExpress.XtraEditors.FormatConditionComparisonType.GreaterOrEqual
            formatConditionIconSetIcon6.PredefinedName = "Arrows3_3.png"
            formatConditionIconSetIcon6.ValueComparison = DevExpress.XtraEditors.FormatConditionComparisonType.GreaterOrEqual
            formatConditionIconSet2.Icons.Add(formatConditionIconSetIcon4)
            formatConditionIconSet2.Icons.Add(formatConditionIconSetIcon5)
            formatConditionIconSet2.Icons.Add(formatConditionIconSetIcon6)
            formatConditionIconSet2.Name = "Arrows3Colored"
            formatConditionIconSet2.ValueType = DevExpress.XtraEditors.FormatConditionValueType.Percent
            formatConditionRuleIconSet2.IconSet = formatConditionIconSet2
            gridFormatRule3.Rule = formatConditionRuleIconSet2
            Me.advBandedGridView1.FormatRules.Add(gridFormatRule1)
            Me.advBandedGridView1.FormatRules.Add(gridFormatRule2)
            Me.advBandedGridView1.FormatRules.Add(gridFormatRule3)
            Me.advBandedGridView1.GridControl = Me.gridControl1
            Me.advBandedGridView1.GroupCount = 1
            Me.advBandedGridView1.Name = "advBandedGridView1"
            Me.advBandedGridView1.OptionsBehavior.AutoExpandAllGroups = True
            Me.advBandedGridView1.OptionsClipboard.ClipboardMode = DevExpress.Export.ClipboardMode.Formatted
            Me.advBandedGridView1.OptionsCustomization.AllowChangeColumnParent = True
            Me.advBandedGridView1.OptionsView.AllowHtmlDrawHeaders = True
            Me.advBandedGridView1.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() { New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.bgcBodyStyle, DevExpress.Data.ColumnSortOrder.Ascending)})
            ' 
            ' gbMain
            ' 
            resources.ApplyResources(Me.gbMain, "gbMain")
            Me.gbMain.Columns.Add(Me.bgcID)
            Me.gbMain.Columns.Add(Me.bgcTrademark)
            Me.gbMain.Columns.Add(Me.bgcName)
            Me.gbMain.Columns.Add(Me.bgcModification)
            Me.gbMain.Columns.Add(Me.bgcLogo)
            Me.gbMain.Columns.Add(Me.bgcDescription)
            Me.gbMain.VisibleIndex = 0
            ' 
            ' bgcID
            ' 
            Me.bgcID.FieldName = "ID"
            Me.bgcID.Name = "bgcID"
            ' 
            ' bgcTrademark
            ' 
            resources.ApplyResources(Me.bgcTrademark, "bgcTrademark")
            Me.bgcTrademark.FieldName = "Trademark"
            Me.bgcTrademark.MinWidth = 80
            Me.bgcTrademark.Name = "bgcTrademark"
            Me.bgcTrademark.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
            ' 
            ' bgcName
            ' 
            Me.bgcName.FieldName = "Name"
            Me.bgcName.Name = "bgcName"
            resources.ApplyResources(Me.bgcName, "bgcName")
            ' 
            ' bgcModification
            ' 
            Me.bgcModification.FieldName = "Modification"
            Me.bgcModification.Name = "bgcModification"
            resources.ApplyResources(Me.bgcModification, "bgcModification")
            ' 
            ' bgcLogo
            ' 
            Me.bgcLogo.FieldName = "TrademarkImage"
            Me.bgcLogo.Name = "bgcLogo"
            Me.bgcLogo.RowCount = 2
            Me.bgcLogo.RowIndex = 1
            resources.ApplyResources(Me.bgcLogo, "bgcLogo")
            ' 
            ' bgcDescription
            ' 
            Me.bgcDescription.ColumnEdit = Me.repositoryItemMemoEdit1
            Me.bgcDescription.FieldName = "Description"
            Me.bgcDescription.Image = (DirectCast(resources.GetObject("bgcDescription.Image"), System.Drawing.Image))
            Me.bgcDescription.Name = "bgcDescription"
            Me.bgcDescription.OptionsFilter.AllowFilter = False
            Me.bgcDescription.RowCount = 3
            Me.bgcDescription.RowIndex = 1
            resources.ApplyResources(Me.bgcDescription, "bgcDescription")
            ' 
            ' repositoryItemMemoEdit1
            ' 
            Me.repositoryItemMemoEdit1.Name = "repositoryItemMemoEdit1"
            ' 
            ' gbPerfomance
            ' 
            resources.ApplyResources(Me.gbPerfomance, "gbPerfomance")
            Me.gbPerfomance.Columns.Add(Me.bgcHorsepower)
            Me.gbPerfomance.Columns.Add(Me.bgcTorque)
            Me.gbPerfomance.Columns.Add(Me.bgcMPGCity)
            Me.gbPerfomance.Columns.Add(Me.bgcMPGHighway)
            Me.gbPerfomance.Columns.Add(Me.bgcDoors)
            Me.gbPerfomance.Columns.Add(Me.bgcCylinders)
            Me.gbPerfomance.Columns.Add(Me.bgcTransmissionType)
            Me.gbPerfomance.Columns.Add(Me.bgcTransmissionSpeeds)
            Me.gbPerfomance.Image = (DirectCast(resources.GetObject("gbPerfomance.Image"), System.Drawing.Image))
            Me.gbPerfomance.VisibleIndex = 1
            ' 
            ' bgcHorsepower
            ' 
            Me.bgcHorsepower.FieldName = "Horsepower"
            Me.bgcHorsepower.Name = "bgcHorsepower"
            resources.ApplyResources(Me.bgcHorsepower, "bgcHorsepower")
            ' 
            ' bgcTorque
            ' 
            Me.bgcTorque.FieldName = "Torque"
            Me.bgcTorque.Name = "bgcTorque"
            resources.ApplyResources(Me.bgcTorque, "bgcTorque")
            ' 
            ' bgcDoors
            ' 
            Me.bgcDoors.FieldName = "Doors"
            Me.bgcDoors.Name = "bgcDoors"
            Me.bgcDoors.RowIndex = 2
            resources.ApplyResources(Me.bgcDoors, "bgcDoors")
            ' 
            ' bgcCylinders
            ' 
            Me.bgcCylinders.FieldName = "Cylinders"
            Me.bgcCylinders.Name = "bgcCylinders"
            Me.bgcCylinders.RowIndex = 2
            resources.ApplyResources(Me.bgcCylinders, "bgcCylinders")
            ' 
            ' bgcTransmissionType
            ' 
            Me.bgcTransmissionType.FieldName = "TransmissionType"
            Me.bgcTransmissionType.Name = "bgcTransmissionType"
            Me.bgcTransmissionType.OptionsColumn.ShowInCustomizationForm = False
            Me.bgcTransmissionType.RowIndex = 3
            resources.ApplyResources(Me.bgcTransmissionType, "bgcTransmissionType")
            ' 
            ' bgcTransmissionSpeeds
            ' 
            Me.bgcTransmissionSpeeds.FieldName = "TransmissionSpeeds"
            Me.bgcTransmissionSpeeds.Name = "bgcTransmissionSpeeds"
            Me.bgcTransmissionSpeeds.OptionsColumn.ShowInCustomizationForm = False
            Me.bgcTransmissionSpeeds.RowIndex = 3
            resources.ApplyResources(Me.bgcTransmissionSpeeds, "bgcTransmissionSpeeds")
            ' 
            ' gbImage
            ' 
            resources.ApplyResources(Me.gbImage, "gbImage")
            Me.gbImage.Columns.Add(Me.bgcPhoto)
            Me.gbImage.VisibleIndex = 2
            ' 
            ' bgcPhoto
            ' 
            Me.bgcPhoto.FieldName = "Photo"
            Me.bgcPhoto.Name = "bgcPhoto"
            Me.bgcPhoto.RowCount = 4
            resources.ApplyResources(Me.bgcPhoto, "bgcPhoto")
            ' 
            ' gbInfo
            ' 
            resources.ApplyResources(Me.gbInfo, "gbInfo")
            Me.gbInfo.Columns.Add(Me.pgcCategory)
            Me.gbInfo.Columns.Add(Me.bgcBodyStyle)
            Me.gbInfo.Columns.Add(Me.bgcPrice)
            Me.gbInfo.VisibleIndex = -1
            ' 
            ' pgcCategory
            ' 
            resources.ApplyResources(Me.pgcCategory, "pgcCategory")
            Me.pgcCategory.FieldName = "Category"
            Me.pgcCategory.Name = "pgcCategory"
            Me.pgcCategory.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
            ' 
            ' bgcBodyStyle
            ' 
            resources.ApplyResources(Me.bgcBodyStyle, "bgcBodyStyle")
            Me.bgcBodyStyle.FieldName = "BodyStyle"
            Me.bgcBodyStyle.Name = "bgcBodyStyle"
            Me.bgcBodyStyle.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
            ' 
            ' bgcPrice
            ' 
            Me.bgcPrice.FieldName = "Price"
            Me.bgcPrice.Name = "bgcPrice"
            resources.ApplyResources(Me.bgcPrice, "bgcPrice")
            ' 
            ' bgcDeliveryDate
            ' 
            Me.bgcDeliveryDate.FieldName = "DeliveryDate"
            Me.bgcDeliveryDate.Name = "bgcDeliveryDate"
            ' 
            ' repositoryItemMemoExEdit1
            ' 
            resources.ApplyResources(Me.repositoryItemMemoExEdit1, "repositoryItemMemoExEdit1")
            Me.repositoryItemMemoExEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton((DirectCast(resources.GetObject("repositoryItemMemoExEdit1.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines)))})
            Me.repositoryItemMemoExEdit1.Name = "repositoryItemMemoExEdit1"
            Me.repositoryItemMemoExEdit1.PopupFormSize = New System.Drawing.Size(300, 150)
            ' 
            ' repositoryItemPictureEdit1
            ' 
            Me.repositoryItemPictureEdit1.CustomHeight = 80
            Me.repositoryItemPictureEdit1.Name = "repositoryItemPictureEdit1"
            Me.repositoryItemPictureEdit1.PictureInterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic
            Me.repositoryItemPictureEdit1.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze
            ' 
            ' repositoryItemImageEdit1
            ' 
            resources.ApplyResources(Me.repositoryItemImageEdit1, "repositoryItemImageEdit1")
            Me.repositoryItemImageEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton((DirectCast(resources.GetObject("repositoryItemImageEdit1.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines)))})
            Me.repositoryItemImageEdit1.Name = "repositoryItemImageEdit1"
            Me.repositoryItemImageEdit1.PopupFormSize = New System.Drawing.Size(300, 200)
            Me.repositoryItemImageEdit1.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze
            ' 
            ' gridView1
            ' 
            Me.gridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() { Me.gcID, Me.gcTrademark, Me.gcName, Me.gcModification, Me.gcCategory, Me.gcPrice, Me.gcMPGCity, Me.gcMPGHighway, Me.gcDoors, Me.gcBodyStyle, Me.gcCylinders, Me.gcHorsepower, Me.gcTorque, Me.gcTransmissionSpeeds, Me.gcTransmissionType, Me.gcDescription, Me.gcImage, Me.gcDeliveryDate, Me.gcInStock, Me.gcPhoto})
            gridFormatRule4.ApplyToRow = True
            gridFormatRule4.Column = Me.gcInStock
            gridFormatRule4.Name = "Format0"
            formatConditionRuleValue2.Appearance.ForeColor = (DirectCast(resources.GetObject("resource.ForeColor1"), System.Drawing.Color))
            formatConditionRuleValue2.Appearance.Options.UseForeColor = True
            formatConditionRuleValue2.Condition = DevExpress.XtraEditors.FormatCondition.NotEqual
            formatConditionRuleValue2.PredefinedName = "Strikeout Text"
            formatConditionRuleValue2.Value1 = True
            gridFormatRule4.Rule = formatConditionRuleValue2
            gridFormatRule5.Column = Me.gcMPGCity
            gridFormatRule5.Name = "Format1"
            formatConditionIconSet3.CategoryName = "Directional"
            formatConditionIconSetIcon7.PredefinedName = "Arrows3_1.png"
            formatConditionIconSetIcon7.Value = New Decimal(New Integer() { 67, 0, 0, 0})
            formatConditionIconSetIcon7.ValueComparison = DevExpress.XtraEditors.FormatConditionComparisonType.GreaterOrEqual
            formatConditionIconSetIcon8.PredefinedName = "Arrows3_2.png"
            formatConditionIconSetIcon8.Value = New Decimal(New Integer() { 33, 0, 0, 0})
            formatConditionIconSetIcon8.ValueComparison = DevExpress.XtraEditors.FormatConditionComparisonType.GreaterOrEqual
            formatConditionIconSetIcon9.PredefinedName = "Arrows3_3.png"
            formatConditionIconSetIcon9.ValueComparison = DevExpress.XtraEditors.FormatConditionComparisonType.GreaterOrEqual
            formatConditionIconSet3.Icons.Add(formatConditionIconSetIcon7)
            formatConditionIconSet3.Icons.Add(formatConditionIconSetIcon8)
            formatConditionIconSet3.Icons.Add(formatConditionIconSetIcon9)
            formatConditionIconSet3.Name = "Arrows3Colored"
            formatConditionIconSet3.ValueType = DevExpress.XtraEditors.FormatConditionValueType.Percent
            formatConditionRuleIconSet3.IconSet = formatConditionIconSet3
            gridFormatRule5.Rule = formatConditionRuleIconSet3
            gridFormatRule6.Column = Me.gcMPGHighway
            gridFormatRule6.Name = "Format2"
            formatConditionIconSet4.CategoryName = "Directional"
            formatConditionIconSetIcon10.PredefinedName = "Arrows3_1.png"
            formatConditionIconSetIcon10.Value = New Decimal(New Integer() { 67, 0, 0, 0})
            formatConditionIconSetIcon10.ValueComparison = DevExpress.XtraEditors.FormatConditionComparisonType.GreaterOrEqual
            formatConditionIconSetIcon11.PredefinedName = "Arrows3_2.png"
            formatConditionIconSetIcon11.Value = New Decimal(New Integer() { 33, 0, 0, 0})
            formatConditionIconSetIcon11.ValueComparison = DevExpress.XtraEditors.FormatConditionComparisonType.GreaterOrEqual
            formatConditionIconSetIcon12.PredefinedName = "Arrows3_3.png"
            formatConditionIconSetIcon12.ValueComparison = DevExpress.XtraEditors.FormatConditionComparisonType.GreaterOrEqual
            formatConditionIconSet4.Icons.Add(formatConditionIconSetIcon10)
            formatConditionIconSet4.Icons.Add(formatConditionIconSetIcon11)
            formatConditionIconSet4.Icons.Add(formatConditionIconSetIcon12)
            formatConditionIconSet4.Name = "Arrows3Colored"
            formatConditionIconSet4.ValueType = DevExpress.XtraEditors.FormatConditionValueType.Percent
            formatConditionRuleIconSet4.IconSet = formatConditionIconSet4
            gridFormatRule6.Rule = formatConditionRuleIconSet4
            gridFormatRule7.Column = Me.gcPrice
            gridFormatRule7.Name = "Format3"
            formatConditionRule2ColorScale1.PredefinedName = "White, Red"
            gridFormatRule7.Rule = formatConditionRule2ColorScale1
            Me.gridView1.FormatRules.Add(gridFormatRule4)
            Me.gridView1.FormatRules.Add(gridFormatRule5)
            Me.gridView1.FormatRules.Add(gridFormatRule6)
            Me.gridView1.FormatRules.Add(gridFormatRule7)
            Me.gridView1.GridControl = Me.gridControl1
            Me.gridView1.Name = "gridView1"
            Me.gridView1.OptionsBehavior.AutoExpandAllGroups = True
            Me.gridView1.OptionsClipboard.ClipboardMode = DevExpress.Export.ClipboardMode.Formatted
            Me.gridView1.OptionsView.AllowHtmlDrawHeaders = True
            Me.gridView1.OptionsView.ColumnAutoWidth = False
            Me.gridView1.PreviewFieldName = "Description"
            Me.gridView1.RowHeight = 27
            ' 
            ' gcID
            ' 
            Me.gcID.FieldName = "ID"
            Me.gcID.Name = "gcID"
            ' 
            ' gcTrademark
            ' 
            resources.ApplyResources(Me.gcTrademark, "gcTrademark")
            Me.gcTrademark.FieldName = "Trademark"
            Me.gcTrademark.Name = "gcTrademark"
            Me.gcTrademark.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
            ' 
            ' gcName
            ' 
            resources.ApplyResources(Me.gcName, "gcName")
            Me.gcName.FieldName = "Name"
            Me.gcName.Name = "gcName"
            ' 
            ' gcModification
            ' 
            Me.gcModification.FieldName = "Modification"
            Me.gcModification.Name = "gcModification"
            resources.ApplyResources(Me.gcModification, "gcModification")
            ' 
            ' gcCategory
            ' 
            Me.gcCategory.FieldName = "Category"
            Me.gcCategory.Name = "gcCategory"
            Me.gcCategory.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
            resources.ApplyResources(Me.gcCategory, "gcCategory")
            ' 
            ' gcDoors
            ' 
            Me.gcDoors.FieldName = "Doors"
            Me.gcDoors.Name = "gcDoors"
            resources.ApplyResources(Me.gcDoors, "gcDoors")
            ' 
            ' gcBodyStyle
            ' 
            Me.gcBodyStyle.FieldName = "BodyStyle"
            Me.gcBodyStyle.Name = "gcBodyStyle"
            Me.gcBodyStyle.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
            resources.ApplyResources(Me.gcBodyStyle, "gcBodyStyle")
            ' 
            ' gcCylinders
            ' 
            Me.gcCylinders.FieldName = "Cylinders"
            Me.gcCylinders.Name = "gcCylinders"
            resources.ApplyResources(Me.gcCylinders, "gcCylinders")
            ' 
            ' gcHorsepower
            ' 
            Me.gcHorsepower.FieldName = "Horsepower"
            Me.gcHorsepower.Name = "gcHorsepower"
            resources.ApplyResources(Me.gcHorsepower, "gcHorsepower")
            ' 
            ' gcTorque
            ' 
            Me.gcTorque.FieldName = "Torque"
            Me.gcTorque.Name = "gcTorque"
            resources.ApplyResources(Me.gcTorque, "gcTorque")
            ' 
            ' gcTransmissionSpeeds
            ' 
            Me.gcTransmissionSpeeds.FieldName = "TransmissionSpeeds"
            Me.gcTransmissionSpeeds.Name = "gcTransmissionSpeeds"
            resources.ApplyResources(Me.gcTransmissionSpeeds, "gcTransmissionSpeeds")
            ' 
            ' gcTransmissionType
            ' 
            Me.gcTransmissionType.FieldName = "TransmissionType"
            Me.gcTransmissionType.Name = "gcTransmissionType"
            resources.ApplyResources(Me.gcTransmissionType, "gcTransmissionType")
            ' 
            ' gcDescription
            ' 
            Me.gcDescription.ColumnEdit = Me.repositoryItemMemoExEdit1
            Me.gcDescription.FieldName = "Description"
            Me.gcDescription.Name = "gcDescription"
            Me.gcDescription.OptionsFilter.AllowFilter = False
            resources.ApplyResources(Me.gcDescription, "gcDescription")
            ' 
            ' gcImage
            ' 
            Me.gcImage.FieldName = "Image"
            resources.ApplyResources(Me.gcImage, "gcImage")
            Me.gcImage.Image = (DirectCast(resources.GetObject("gcImage.Image"), System.Drawing.Image))
            Me.gcImage.Name = "gcImage"
            Me.gcImage.OptionsColumn.AllowFocus = False
            Me.gcImage.OptionsColumn.AllowMove = False
            Me.gcImage.OptionsFilter.AllowFilter = False
            ' 
            ' gcDeliveryDate
            ' 
            Me.gcDeliveryDate.FieldName = "DeliveryDate"
            Me.gcDeliveryDate.Name = "gcDeliveryDate"
            resources.ApplyResources(Me.gcDeliveryDate, "gcDeliveryDate")
            ' 
            ' gcPhoto
            ' 
            Me.gcPhoto.ColumnEdit = Me.repositoryItemImageEdit1
            Me.gcPhoto.FieldName = "Photo"
            Me.gcPhoto.Name = "gcPhoto"
            resources.ApplyResources(Me.gcPhoto, "gcPhoto")
            ' 
            ' bandedGridView1
            ' 
            Me.bandedGridView1.Bands.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() { Me.gridBand1, Me.gridBand4, Me.gridBand5})
            Me.bandedGridView1.Columns.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn() { Me.bcID, Me.bcTrademark, Me.bcName, Me.bcModification, Me.bcCategory, Me.bcPrice, Me.bcMPGCity, Me.bcMPGHighway, Me.bcDoors, Me.bcBodyStyle, Me.bcCylinders, Me.bcHorsepower, Me.bcTorque, Me.bcTransmissionSpeeds, Me.bcTransmissionType, Me.bcDescription, Me.bcImage, Me.bcPhoto, Me.bcDeliveryDate, Me.bcInStock, Me.bcLogo})
            gridFormatRule8.ApplyToRow = True
            gridFormatRule8.Column = Me.bcInStock
            gridFormatRule8.Name = "Format0"
            formatConditionRuleValue3.Appearance.ForeColor = (DirectCast(resources.GetObject("resource.ForeColor2"), System.Drawing.Color))
            formatConditionRuleValue3.Appearance.Options.UseForeColor = True
            formatConditionRuleValue3.Condition = DevExpress.XtraEditors.FormatCondition.NotEqual
            formatConditionRuleValue3.PredefinedName = "Strikeout Text"
            formatConditionRuleValue3.Value1 = True
            gridFormatRule8.Rule = formatConditionRuleValue3
            gridFormatRule9.Column = Me.bcMPGCity
            gridFormatRule9.Name = "Format1"
            formatConditionIconSet5.CategoryName = "Directional"
            formatConditionIconSetIcon13.PredefinedName = "Arrows3_1.png"
            formatConditionIconSetIcon13.Value = New Decimal(New Integer() { 67, 0, 0, 0})
            formatConditionIconSetIcon13.ValueComparison = DevExpress.XtraEditors.FormatConditionComparisonType.GreaterOrEqual
            formatConditionIconSetIcon14.PredefinedName = "Arrows3_2.png"
            formatConditionIconSetIcon14.Value = New Decimal(New Integer() { 33, 0, 0, 0})
            formatConditionIconSetIcon14.ValueComparison = DevExpress.XtraEditors.FormatConditionComparisonType.GreaterOrEqual
            formatConditionIconSetIcon15.PredefinedName = "Arrows3_3.png"
            formatConditionIconSetIcon15.ValueComparison = DevExpress.XtraEditors.FormatConditionComparisonType.GreaterOrEqual
            formatConditionIconSet5.Icons.Add(formatConditionIconSetIcon13)
            formatConditionIconSet5.Icons.Add(formatConditionIconSetIcon14)
            formatConditionIconSet5.Icons.Add(formatConditionIconSetIcon15)
            formatConditionIconSet5.Name = "Arrows3Colored"
            formatConditionIconSet5.ValueType = DevExpress.XtraEditors.FormatConditionValueType.Percent
            formatConditionRuleIconSet5.IconSet = formatConditionIconSet5
            gridFormatRule9.Rule = formatConditionRuleIconSet5
            gridFormatRule10.Column = Me.bcMPGHighway
            gridFormatRule10.Name = "Format2"
            formatConditionIconSet6.CategoryName = "Directional"
            formatConditionIconSetIcon16.PredefinedName = "Arrows3_1.png"
            formatConditionIconSetIcon16.Value = New Decimal(New Integer() { 67, 0, 0, 0})
            formatConditionIconSetIcon16.ValueComparison = DevExpress.XtraEditors.FormatConditionComparisonType.GreaterOrEqual
            formatConditionIconSetIcon17.PredefinedName = "Arrows3_2.png"
            formatConditionIconSetIcon17.Value = New Decimal(New Integer() { 33, 0, 0, 0})
            formatConditionIconSetIcon17.ValueComparison = DevExpress.XtraEditors.FormatConditionComparisonType.GreaterOrEqual
            formatConditionIconSetIcon18.PredefinedName = "Arrows3_3.png"
            formatConditionIconSetIcon18.ValueComparison = DevExpress.XtraEditors.FormatConditionComparisonType.GreaterOrEqual
            formatConditionIconSet6.Icons.Add(formatConditionIconSetIcon16)
            formatConditionIconSet6.Icons.Add(formatConditionIconSetIcon17)
            formatConditionIconSet6.Icons.Add(formatConditionIconSetIcon18)
            formatConditionIconSet6.Name = "Arrows3Colored"
            formatConditionIconSet6.ValueType = DevExpress.XtraEditors.FormatConditionValueType.Percent
            formatConditionRuleIconSet6.IconSet = formatConditionIconSet6
            gridFormatRule10.Rule = formatConditionRuleIconSet6
            Me.bandedGridView1.FormatRules.Add(gridFormatRule8)
            Me.bandedGridView1.FormatRules.Add(gridFormatRule9)
            Me.bandedGridView1.FormatRules.Add(gridFormatRule10)
            Me.bandedGridView1.GridControl = Me.gridControl1
            Me.bandedGridView1.GroupCount = 1
            Me.bandedGridView1.Name = "bandedGridView1"
            Me.bandedGridView1.OptionsBehavior.AutoExpandAllGroups = True
            Me.bandedGridView1.OptionsClipboard.ClipboardMode = DevExpress.Export.ClipboardMode.Formatted
            Me.bandedGridView1.OptionsCustomization.AllowChangeColumnParent = True
            Me.bandedGridView1.OptionsView.AllowHtmlDrawHeaders = True
            Me.bandedGridView1.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() { New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.bcCategory, DevExpress.Data.ColumnSortOrder.Ascending)})
            ' 
            ' gridBand1
            ' 
            resources.ApplyResources(Me.gridBand1, "gridBand1")
            Me.gridBand1.Children.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() { Me.gridBand2, Me.gridBand3})
            Me.gridBand1.VisibleIndex = 0
            ' 
            ' gridBand2
            ' 
            resources.ApplyResources(Me.gridBand2, "gridBand2")
            Me.gridBand2.Columns.Add(Me.bcLogo)
            Me.gridBand2.Columns.Add(Me.bcTrademark)
            Me.gridBand2.Columns.Add(Me.bcName)
            Me.gridBand2.Columns.Add(Me.bcModification)
            Me.gridBand2.VisibleIndex = 0
            ' 
            ' bcLogo
            ' 
            resources.ApplyResources(Me.bcLogo, "bcLogo")
            Me.bcLogo.FieldName = "TrademarkImage"
            Me.bcLogo.Image = (DirectCast(resources.GetObject("bcLogo.Image"), System.Drawing.Image))
            Me.bcLogo.Name = "bcLogo"
            Me.bcLogo.OptionsColumn.AllowFocus = False
            Me.bcLogo.OptionsColumn.ReadOnly = True
            Me.bcLogo.OptionsFilter.AllowFilter = False
            ' 
            ' bcTrademark
            ' 
            Me.bcTrademark.FieldName = "Trademark"
            Me.bcTrademark.Name = "bcTrademark"
            Me.bcTrademark.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
            resources.ApplyResources(Me.bcTrademark, "bcTrademark")
            ' 
            ' bcName
            ' 
            Me.bcName.FieldName = "Name"
            Me.bcName.Name = "bcName"
            resources.ApplyResources(Me.bcName, "bcName")
            ' 
            ' bcModification
            ' 
            Me.bcModification.FieldName = "Modification"
            Me.bcModification.Name = "bcModification"
            resources.ApplyResources(Me.bcModification, "bcModification")
            ' 
            ' gridBand3
            ' 
            resources.ApplyResources(Me.gridBand3, "gridBand3")
            Me.gridBand3.Columns.Add(Me.bcCategory)
            Me.gridBand3.Columns.Add(Me.bcBodyStyle)
            Me.gridBand3.VisibleIndex = 1
            ' 
            ' bcCategory
            ' 
            Me.bcCategory.FieldName = "Category"
            Me.bcCategory.Name = "bcCategory"
            Me.bcCategory.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
            resources.ApplyResources(Me.bcCategory, "bcCategory")
            ' 
            ' bcBodyStyle
            ' 
            Me.bcBodyStyle.FieldName = "BodyStyle"
            Me.bcBodyStyle.Name = "bcBodyStyle"
            Me.bcBodyStyle.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
            resources.ApplyResources(Me.bcBodyStyle, "bcBodyStyle")
            ' 
            ' gridBand4
            ' 
            resources.ApplyResources(Me.gridBand4, "gridBand4")
            Me.gridBand4.Children.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() { Me.gridBand6, Me.gridBand7})
            Me.gridBand4.VisibleIndex = 1
            ' 
            ' gridBand6
            ' 
            resources.ApplyResources(Me.gridBand6, "gridBand6")
            Me.gridBand6.Columns.Add(Me.bcMPGCity)
            Me.gridBand6.Columns.Add(Me.bcMPGHighway)
            Me.gridBand6.VisibleIndex = 0
            ' 
            ' gridBand7
            ' 
            resources.ApplyResources(Me.gridBand7, "gridBand7")
            Me.gridBand7.Columns.Add(Me.bcHorsepower)
            Me.gridBand7.Columns.Add(Me.bcTorque)
            Me.gridBand7.VisibleIndex = 1
            ' 
            ' bcHorsepower
            ' 
            Me.bcHorsepower.FieldName = "Horsepower"
            Me.bcHorsepower.Name = "bcHorsepower"
            resources.ApplyResources(Me.bcHorsepower, "bcHorsepower")
            ' 
            ' bcTorque
            ' 
            Me.bcTorque.FieldName = "Torque"
            Me.bcTorque.Name = "bcTorque"
            resources.ApplyResources(Me.bcTorque, "bcTorque")
            ' 
            ' gridBand5
            ' 
            resources.ApplyResources(Me.gridBand5, "gridBand5")
            Me.gridBand5.Columns.Add(Me.bcPhoto)
            Me.gridBand5.Columns.Add(Me.bcDescription)
            Me.gridBand5.Image = (DirectCast(resources.GetObject("gridBand5.Image"), System.Drawing.Image))
            Me.gridBand5.VisibleIndex = 2
            ' 
            ' bcPhoto
            ' 
            Me.bcPhoto.ColumnEdit = Me.repositoryItemImageEdit1
            Me.bcPhoto.FieldName = "Photo"
            Me.bcPhoto.Name = "bcPhoto"
            resources.ApplyResources(Me.bcPhoto, "bcPhoto")
            ' 
            ' bcDescription
            ' 
            Me.bcDescription.ColumnEdit = Me.repositoryItemMemoExEdit1
            Me.bcDescription.FieldName = "Description"
            Me.bcDescription.Name = "bcDescription"
            Me.bcDescription.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False
            Me.bcDescription.OptionsFilter.AllowFilter = False
            resources.ApplyResources(Me.bcDescription, "bcDescription")
            ' 
            ' bcID
            ' 
            Me.bcID.FieldName = "ID"
            Me.bcID.Name = "bcID"
            resources.ApplyResources(Me.bcID, "bcID")
            ' 
            ' bcPrice
            ' 
            Me.bcPrice.FieldName = "Price"
            Me.bcPrice.Name = "bcPrice"
            resources.ApplyResources(Me.bcPrice, "bcPrice")
            ' 
            ' bcDoors
            ' 
            Me.bcDoors.FieldName = "Doors"
            Me.bcDoors.Name = "bcDoors"
            resources.ApplyResources(Me.bcDoors, "bcDoors")
            ' 
            ' bcCylinders
            ' 
            Me.bcCylinders.FieldName = "Cylinders"
            Me.bcCylinders.Name = "bcCylinders"
            resources.ApplyResources(Me.bcCylinders, "bcCylinders")
            ' 
            ' bcTransmissionSpeeds
            ' 
            Me.bcTransmissionSpeeds.FieldName = "TransmissionSpeeds"
            Me.bcTransmissionSpeeds.Name = "bcTransmissionSpeeds"
            resources.ApplyResources(Me.bcTransmissionSpeeds, "bcTransmissionSpeeds")
            ' 
            ' bcTransmissionType
            ' 
            Me.bcTransmissionType.FieldName = "TransmissionType"
            Me.bcTransmissionType.Name = "bcTransmissionType"
            resources.ApplyResources(Me.bcTransmissionType, "bcTransmissionType")
            ' 
            ' bcImage
            ' 
            Me.bcImage.FieldName = "Image"
            Me.bcImage.Name = "bcImage"
            resources.ApplyResources(Me.bcImage, "bcImage")
            ' 
            ' bcDeliveryDate
            ' 
            Me.bcDeliveryDate.FieldName = "DeliveryDate"
            Me.bcDeliveryDate.Name = "bcDeliveryDate"
            resources.ApplyResources(Me.bcDeliveryDate, "bcDeliveryDate")
            ' 
            ' cardView1
            ' 
            Me.cardView1.CardWidth = 255
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
            ' colDescription
            ' 
            Me.colDescription.ColumnEdit = Me.repositoryItemMemoExEdit1
            Me.colDescription.FieldName = "Description"
            Me.colDescription.Name = "colDescription"
            resources.ApplyResources(Me.colDescription, "colDescription")
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
            ' ViewStyles
            ' 
            resources.ApplyResources(Me, "$this")
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.gridControl1)
            Me.Controls.Add(Me.panelControl1)
            Me.Name = "ViewStyles"
            DirectCast(Me.repositoryItemImageComboBox3, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.repositoryItemSpinEdit3, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panelControl1.ResumeLayout(False)
            DirectCast(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.advBandedGridView1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.repositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.repositoryItemMemoExEdit1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.repositoryItemPictureEdit1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.repositoryItemImageEdit1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.bandedGridView1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.cardView1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        #End Region

        Private repositoryItemImageComboBox3 As DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox
        Private repositoryItemSpinEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
        Private imageList1 As System.Windows.Forms.ImageList
        Private components As System.ComponentModel.IContainer
        Private panelControl1 As DevExpress.XtraEditors.PanelControl
        Private WithEvents chAdvBanded As DevExpress.XtraEditors.CheckButton
        Private WithEvents chBanded As DevExpress.XtraEditors.CheckButton
        Private WithEvents chCard As DevExpress.XtraEditors.CheckButton
        Private WithEvents chGrid As DevExpress.XtraEditors.CheckButton
        Private gridControl1 As GridControl
        Private advBandedGridView1 As Views.BandedGrid.AdvBandedGridView
        Private WithEvents gridView1 As Views.Grid.GridView
        Private WithEvents cardView1 As Views.Card.CardView
        Private bandedGridView1 As Views.BandedGrid.BandedGridView
        Private gridBand1 As Views.BandedGrid.GridBand
        Private colTrademark As Columns.GridColumn
        Private colName As Columns.GridColumn
        Private colModification As Columns.GridColumn
        Private colCategory As Columns.GridColumn
        Private colBodyStyle As Columns.GridColumn
        Private colPhoto As Columns.GridColumn
        Private repositoryItemPictureEdit1 As XtraEditors.Repository.RepositoryItemPictureEdit
        Private colDescription As Columns.GridColumn
        Private repositoryItemMemoExEdit1 As XtraEditors.Repository.RepositoryItemMemoExEdit
        Private colDeliveryDate As Columns.GridColumn
        Private colPrice As Columns.GridColumn
        Private colInStock As Columns.GridColumn
        Private gbMain As Views.BandedGrid.GridBand
        Private bgcID As Views.BandedGrid.BandedGridColumn
        Private bgcLogo As Views.BandedGrid.BandedGridColumn
        Private repositoryItemMemoEdit1 As XtraEditors.Repository.RepositoryItemMemoEdit
        Private gbPerfomance As Views.BandedGrid.GridBand
        Private bgcHorsepower As Views.BandedGrid.BandedGridColumn
        Private bgcTorque As Views.BandedGrid.BandedGridColumn
        Private bgcMPGCity As Views.BandedGrid.BandedGridColumn
        Private bgcMPGHighway As Views.BandedGrid.BandedGridColumn
        Private bgcDoors As Views.BandedGrid.BandedGridColumn
        Private bgcCylinders As Views.BandedGrid.BandedGridColumn
        Private gbInfo As Views.BandedGrid.GridBand
        Private gbImage As Views.BandedGrid.GridBand
        Private bgcTransmissionSpeeds As Views.BandedGrid.BandedGridColumn
        Private bgcTransmissionType As Views.BandedGrid.BandedGridColumn
        Private bgcTrademark As Views.BandedGrid.BandedGridColumn
        Private bgcName As Views.BandedGrid.BandedGridColumn
        Private bgcModification As Views.BandedGrid.BandedGridColumn
        Private bgcDescription As Views.BandedGrid.BandedGridColumn
        Private bgcPhoto As Views.BandedGrid.BandedGridColumn
        Private pgcCategory As Views.BandedGrid.BandedGridColumn
        Private bgcBodyStyle As Views.BandedGrid.BandedGridColumn
        Private bgcPrice As Views.BandedGrid.BandedGridColumn
        Private bgcDeliveryDate As Views.BandedGrid.BandedGridColumn
        Private bgcInStock As Views.BandedGrid.BandedGridColumn
        Private gridBand2 As Views.BandedGrid.GridBand
        Private bcLogo As Views.BandedGrid.BandedGridColumn
        Private bcTrademark As Views.BandedGrid.BandedGridColumn
        Private bcName As Views.BandedGrid.BandedGridColumn
        Private bcModification As Views.BandedGrid.BandedGridColumn
        Private gridBand3 As Views.BandedGrid.GridBand
        Private bcCategory As Views.BandedGrid.BandedGridColumn
        Private bcBodyStyle As Views.BandedGrid.BandedGridColumn
        Private gridBand4 As Views.BandedGrid.GridBand
        Private gridBand6 As Views.BandedGrid.GridBand
        Private bcMPGCity As Views.BandedGrid.BandedGridColumn
        Private bcMPGHighway As Views.BandedGrid.BandedGridColumn
        Private gridBand7 As Views.BandedGrid.GridBand
        Private bcHorsepower As Views.BandedGrid.BandedGridColumn
        Private bcTorque As Views.BandedGrid.BandedGridColumn
        Private gridBand5 As Views.BandedGrid.GridBand
        Private bcPhoto As Views.BandedGrid.BandedGridColumn
        Private bcDescription As Views.BandedGrid.BandedGridColumn
        Private bcID As Views.BandedGrid.BandedGridColumn
        Private bcPrice As Views.BandedGrid.BandedGridColumn
        Private bcDoors As Views.BandedGrid.BandedGridColumn
        Private bcCylinders As Views.BandedGrid.BandedGridColumn
        Private bcTransmissionSpeeds As Views.BandedGrid.BandedGridColumn
        Private bcTransmissionType As Views.BandedGrid.BandedGridColumn
        Private bcImage As Views.BandedGrid.BandedGridColumn
        Private bcDeliveryDate As Views.BandedGrid.BandedGridColumn
        Private bcInStock As Views.BandedGrid.BandedGridColumn
        Private repositoryItemImageEdit1 As XtraEditors.Repository.RepositoryItemImageEdit
        Private gcID As Columns.GridColumn
        Private gcTrademark As Columns.GridColumn
        Private gcName As Columns.GridColumn
        Private gcModification As Columns.GridColumn
        Private gcCategory As Columns.GridColumn
        Private gcPrice As Columns.GridColumn
        Private gcMPGCity As Columns.GridColumn
        Private gcMPGHighway As Columns.GridColumn
        Private gcDoors As Columns.GridColumn
        Private gcBodyStyle As Columns.GridColumn
        Private gcCylinders As Columns.GridColumn
        Private gcHorsepower As Columns.GridColumn
        Private gcTorque As Columns.GridColumn
        Private gcTransmissionSpeeds As Columns.GridColumn
        Private gcTransmissionType As Columns.GridColumn
        Private gcDescription As Columns.GridColumn
        Private gcImage As Columns.GridColumn
        Private gcDeliveryDate As Columns.GridColumn
        Private gcInStock As Columns.GridColumn
        Private gcPhoto As Columns.GridColumn
    End Class
End Namespace
