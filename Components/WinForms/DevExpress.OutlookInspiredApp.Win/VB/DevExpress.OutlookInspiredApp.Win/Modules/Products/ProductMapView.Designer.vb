Namespace DevExpress.DevAV.Modules
    Partial Public Class ProductMapView
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
            keyColorColorizer = New DevExpress.DevAV.Modules.Colorizer()
            Dim argumentItemKeyProvider1 As New DevExpress.XtraMap.ArgumentItemKeyProvider()
            Dim xyDiagram1 As New DevExpress.XtraCharts.XYDiagram()
            Dim series1 As New DevExpress.XtraCharts.Series()
            Me.imageTilesLayer1 = New DevExpress.XtraMap.ImageLayer()
            Me.bingMapDataProvider1 = New DevExpress.XtraMap.BingMapDataProvider()
            Me.vectorItemsLayer1 = New DevExpress.XtraMap.VectorItemsLayer()
            Me.pieChartDataAdapter1 = New DevExpress.XtraMap.PieChartDataAdapter()
            Me.bindingSourceMapItem = New System.Windows.Forms.BindingSource(Me.components)
            Me.chartPanel = New DevExpress.XtraEditors.PanelControl()
            Me.periodButtons = New DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel()
            Me.chart = New DevExpress.XtraCharts.ChartControl()
            Me.bindingSourceChart = New System.Windows.Forms.BindingSource(Me.components)
            Me.bindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.ribbonControl = New DevExpress.XtraBars.Ribbon.RibbonControl()
            Me.biSave = New DevExpress.XtraBars.BarButtonItem()
            Me.biClose = New DevExpress.XtraBars.BarButtonItem()
            Me.biSaveAndClose = New DevExpress.XtraBars.BarButtonItem()
            Me.biDelete = New DevExpress.XtraBars.BarButtonItem()
            Me.biLifetime = New DevExpress.XtraBars.BarCheckItem()
            Me.biThisYear = New DevExpress.XtraBars.BarCheckItem()
            Me.biThisMonth = New DevExpress.XtraBars.BarCheckItem()
            Me.biPrint = New DevExpress.XtraBars.BarButtonItem()
            Me.biPrintPreview = New DevExpress.XtraBars.BarButtonItem()
            Me.barExportItem = New DevExpress.XtraBars.BarButtonItem()
            Me.ribbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
            Me.ribbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            Me.ribbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            Me.ribbonPageGroup5 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            Me.ribbonPageGroup4 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            Me.ribbonPageGroup3 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            Me.moduleDataLayout = New DevExpress.XtraDataLayout.DataLayoutControl()
            Me.mapControl = New DevExpress.XtraMap.MapControl()
            Me.NameLabel = New DevExpress.XtraEditors.LabelControl()
            Me.DescriptionLabel = New DevExpress.XtraEditors.LabelControl()
            Me.ImagePictureEdit = New DevExpress.XtraEditors.PictureEdit()
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.ItemForMap = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlGroup3 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.ItemForChartPanel = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlGroup4 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.ItemForImage = New DevExpress.XtraLayout.LayoutControlItem()
            Me.ItemForAddressLine1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.ItemForFullName = New DevExpress.XtraLayout.LayoutControlItem()
            Me.simpleSeparator1 = New DevExpress.XtraLayout.SimpleSeparator()
            Me.simpleSeparator2 = New DevExpress.XtraLayout.SimpleSeparator()
            CType(Me.mvvmContext, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.bindingSourceMapItem, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.chartPanel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.chartPanel.SuspendLayout()
            CType(Me.chart, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(xyDiagram1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(series1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.bindingSourceChart, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.bindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ribbonControl, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.moduleDataLayout, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.moduleDataLayout.SuspendLayout()
            CType(Me.mapControl, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ImagePictureEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ItemForMap, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlGroup3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ItemForChartPanel, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlGroup4, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ItemForImage, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ItemForAddressLine1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ItemForFullName, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.simpleSeparator1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.simpleSeparator2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            Me.imageTilesLayer1.DataProvider = Me.bingMapDataProvider1
            Me.bingMapDataProvider1.Kind = DevExpress.XtraMap.BingMapKind.Road
            keyColorColorizer.ItemKeyProvider = argumentItemKeyProvider1
            Me.vectorItemsLayer1.Colorizer = keyColorColorizer
            Me.vectorItemsLayer1.Data = Me.pieChartDataAdapter1
            Me.vectorItemsLayer1.ToolTipPattern = "City:%A% Total:%V%"
            Me.pieChartDataAdapter1.DataSource = Me.bindingSourceMapItem
            Me.pieChartDataAdapter1.ItemMaxSize = 60
            Me.pieChartDataAdapter1.ItemMinSize = 20
            Me.pieChartDataAdapter1.Mappings.Latitude = "Latitude"
            Me.pieChartDataAdapter1.Mappings.Longitude = "Longitude"
            Me.pieChartDataAdapter1.Mappings.PieSegment = "CustomerName"
            Me.pieChartDataAdapter1.Mappings.Value = "Total"
            Me.pieChartDataAdapter1.PieItemDataMember = "City"
            Me.bindingSourceMapItem.DataSource = GetType(DevExpress.DevAV.MapItem)
            Me.chartPanel.Controls.Add(Me.periodButtons)
            Me.chartPanel.Controls.Add(Me.chart)
            Me.chartPanel.Location = New System.Drawing.Point(736, 150)
            Me.chartPanel.Name = "chartPanel"
            Me.chartPanel.Size = New System.Drawing.Size(476, 484)
            Me.chartPanel.TabIndex = 32
            Me.periodButtons.Buttons.AddRange(New DevExpress.XtraEditors.ButtonPanel.IBaseButton() {
                New DevExpress.XtraBars.Docking2010.WindowsUIButton("This Month", DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton),
                New DevExpress.XtraBars.Docking2010.WindowsUIButton("YTD", DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton),
                New DevExpress.XtraBars.Docking2010.WindowsUIButton("Lifetime", DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton)
            })
            Me.periodButtons.ContentAlignment = System.Drawing.ContentAlignment.BottomRight
            Me.periodButtons.Dock = System.Windows.Forms.DockStyle.Top
            Me.periodButtons.Location = New System.Drawing.Point(2, 2)
            Me.periodButtons.Name = "periodButtons"
            Me.periodButtons.Padding = New System.Windows.Forms.Padding(0, 0, 44, 0)
            Me.periodButtons.Size = New System.Drawing.Size(472, 32)
            Me.periodButtons.TabIndex = 31
            Me.periodButtons.UseButtonBackgroundImages = False
            Me.chart.BorderOptions.Visibility = DevExpress.Utils.DefaultBoolean.False
            Me.chart.DataBindings = Nothing
            Me.chart.DataSource = Me.bindingSourceChart
            xyDiagram1.AxisX.Label.Visible = False
            xyDiagram1.AxisX.Tickmarks.MinorVisible = False
            xyDiagram1.AxisX.Tickmarks.Visible = False
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1"
            xyDiagram1.AxisY.Label.ResolveOverlappingOptions.AllowRotate = False
            xyDiagram1.AxisY.Label.ResolveOverlappingOptions.AllowStagger = False
            xyDiagram1.AxisY.Label.TextPattern = "{V:$##,#0}"
            xyDiagram1.AxisY.Tickmarks.MinorVisible = False
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1"
            xyDiagram1.Rotated = True
            Me.chart.Diagram = xyDiagram1
            Me.chart.Dock = System.Windows.Forms.DockStyle.Fill
            Me.chart.Legend.Name = "Default Legend"
            Me.chart.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False
            Me.chart.Location = New System.Drawing.Point(2, 2)
            Me.chart.Name = "chart"
            Me.chart.Padding.Bottom = 40
            Me.chart.Padding.Left = 40
            Me.chart.Padding.Right = 40
            Me.chart.Padding.Top = 48
            Me.chart.PaletteName = "Office 2013"
            series1.ArgumentDataMember = "CustomerName"
            series1.ColorDataMember = "CustomerName"
            series1.Name = "Customers"
            series1.SummaryFunction = "SUM([Total])"
            Me.chart.SeriesSerializable = New DevExpress.XtraCharts.Series() { series1}
            Me.chart.Size = New System.Drawing.Size(472, 480)
            Me.chart.TabIndex = 34
            Me.bindingSourceChart.DataSource = GetType(DevExpress.DevAV.MapItem)
            Me.bindingSource.DataSource = GetType(DevExpress.DevAV.ViewModels.ProductMapViewModel)
            Me.ribbonControl.ExpandCollapseItem.Id = 0
            Me.ribbonControl.Items.AddRange(New DevExpress.XtraBars.BarItem() { Me.ribbonControl.ExpandCollapseItem, Me.biSave, Me.biClose, Me.biSaveAndClose, Me.biDelete, Me.biLifetime, Me.biThisYear, Me.biThisMonth, Me.biPrint, Me.biPrintPreview, Me.barExportItem})
            Me.ribbonControl.Location = New System.Drawing.Point(0, 0)
            Me.ribbonControl.MaxItemId = 12
            Me.ribbonControl.Name = "ribbonControl"
            Me.ribbonControl.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() { Me.ribbonPage1})
            Me.ribbonControl.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide
            Me.ribbonControl.Size = New System.Drawing.Size(1226, 120)
            Me.biSave.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False
            Me.biSave.Caption = "Save"
            Me.biSave.Id = 1
            Me.biSave.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            Me.biSave.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.Save.svg"
            Me.biSave.Name = "biSave"
            Me.biClose.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False
            Me.biClose.Caption = "Close"
            Me.biClose.Id = 2
            Me.biClose.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            Me.biClose.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.Close.svg"
            Me.biClose.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.Escape)
            Me.biClose.Name = "biClose"
            Me.biSaveAndClose.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False
            Me.biSaveAndClose.Caption = "Save && Close"
            Me.biSaveAndClose.Id = 3
            Me.biSaveAndClose.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            Me.biSaveAndClose.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.SaveAndClose.svg"
            Me.biSaveAndClose.Name = "biSaveAndClose"
            Me.biDelete.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False
            Me.biDelete.Caption = "Delete"
            Me.biDelete.Id = 4
            Me.biDelete.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            Me.biDelete.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.Delete.svg"
            Me.biDelete.Name = "biDelete"
            Me.biLifetime.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False
            Me.biLifetime.Caption = "Lifetime"
            Me.biLifetime.Id = 5
            Me.biLifetime.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            Me.biLifetime.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.SalesPeriodLifetime.svg"
            Me.biLifetime.Name = "biLifetime"
            Me.biThisYear.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False
            Me.biThisYear.Caption = "This Year"
            Me.biThisYear.Id = 6
            Me.biThisYear.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            Me.biThisYear.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.SalesPeriodYear.svg"
            Me.biThisYear.Name = "biThisYear"
            Me.biThisMonth.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False
            Me.biThisMonth.Caption = "This Month"
            Me.biThisMonth.Id = 7
            Me.biThisMonth.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            Me.biThisMonth.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.SalesPeriodMonth.svg"
            Me.biThisMonth.Name = "biThisMonth"
            Me.biPrint.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False
            Me.biPrint.Caption = "Print"
            Me.biPrint.Id = 8
            Me.biPrint.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            Me.biPrint.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.Print.svg"
            Me.biPrint.Name = "biPrint"
            Me.biPrintPreview.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False
            Me.biPrintPreview.Caption = "Print Preview"
            Me.biPrintPreview.Id = 9
            Me.biPrintPreview.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            Me.biPrintPreview.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.PrintPreview.svg"
            Me.biPrintPreview.Name = "biPrintPreview"
            Me.barExportItem.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False
            Me.barExportItem.Caption = "Export"
            Me.barExportItem.Id = 11
            Me.barExportItem.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            Me.barExportItem.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.Export.svg"
            Me.barExportItem.LargeImageIndex = 50
            Me.barExportItem.Name = "barExportItem"
            Me.ribbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() { Me.ribbonPageGroup1, Me.ribbonPageGroup2, Me.ribbonPageGroup5, Me.ribbonPageGroup4, Me.ribbonPageGroup3})
            Me.ribbonPage1.Name = "ribbonPage1"
            Me.ribbonPage1.Text = "HOME"
            Me.ribbonPageGroup1.AllowTextClipping = False
            Me.ribbonPageGroup1.ItemLinks.Add(Me.biSave)
            Me.ribbonPageGroup1.ItemLinks.Add(Me.biSaveAndClose)
            Me.ribbonPageGroup1.MergeOrder = 0
            Me.ribbonPageGroup1.Name = "ribbonPageGroup1"
            Me.ribbonPageGroup1.ShowCaptionButton = False
            Me.ribbonPageGroup2.AllowTextClipping = False
            Me.ribbonPageGroup2.ItemLinks.Add(Me.biDelete)
            Me.ribbonPageGroup2.MergeOrder = 0
            Me.ribbonPageGroup2.Name = "ribbonPageGroup2"
            Me.ribbonPageGroup2.ShowCaptionButton = False
            Me.ribbonPageGroup2.Text = "Delete"
            Me.ribbonPageGroup5.AllowTextClipping = False
            Me.ribbonPageGroup5.ItemLinks.Add(Me.biPrintPreview)
            Me.ribbonPageGroup5.ItemLinks.Add(Me.biPrint)
            Me.ribbonPageGroup5.ItemLinks.Add(Me.barExportItem)
            Me.ribbonPageGroup5.MergeOrder = 0
            Me.ribbonPageGroup5.Name = "ribbonPageGroup5"
            Me.ribbonPageGroup5.ShowCaptionButton = False
            Me.ribbonPageGroup5.Text = "Print and Export"
            Me.ribbonPageGroup4.AllowTextClipping = False
            Me.ribbonPageGroup4.ItemLinks.Add(Me.biThisMonth)
            Me.ribbonPageGroup4.ItemLinks.Add(Me.biThisYear)
            Me.ribbonPageGroup4.ItemLinks.Add(Me.biLifetime)
            Me.ribbonPageGroup4.MergeOrder = 0
            Me.ribbonPageGroup4.Name = "ribbonPageGroup4"
            Me.ribbonPageGroup4.ShowCaptionButton = False
            Me.ribbonPageGroup4.Text = "Sales Period"
            Me.ribbonPageGroup3.AllowTextClipping = False
            Me.ribbonPageGroup3.ItemLinks.Add(Me.biClose)
            Me.ribbonPageGroup3.MergeOrder = 0
            Me.ribbonPageGroup3.Name = "ribbonPageGroup3"
            Me.ribbonPageGroup3.ShowCaptionButton = False
            Me.ribbonPageGroup3.Text = "Close"
            Me.moduleDataLayout.AllowCustomization = False
            Me.moduleDataLayout.Controls.Add(Me.chartPanel)
            Me.moduleDataLayout.Controls.Add(Me.mapControl)
            Me.moduleDataLayout.Controls.Add(Me.NameLabel)
            Me.moduleDataLayout.Controls.Add(Me.DescriptionLabel)
            Me.moduleDataLayout.Controls.Add(Me.ImagePictureEdit)
            Me.moduleDataLayout.DataSource = Me.bindingSource
            Me.moduleDataLayout.Dock = System.Windows.Forms.DockStyle.Fill
            Me.moduleDataLayout.Location = New System.Drawing.Point(0, 120)
            Me.moduleDataLayout.Name = "moduleDataLayout"
            Me.moduleDataLayout.Root = Me.layoutControlGroup1
            Me.moduleDataLayout.Size = New System.Drawing.Size(1226, 642)
            Me.moduleDataLayout.TabIndex = 2
            Me.moduleDataLayout.Text = "moduleDataLayout"
            Me.mapControl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.mapControl.Cursor = System.Windows.Forms.Cursors.Default
            Me.mapControl.Layers.Add(Me.imageTilesLayer1)
            Me.mapControl.Layers.Add(Me.vectorItemsLayer1)
            Me.mapControl.Location = New System.Drawing.Point(0, 0)
            Me.mapControl.Name = "mapControl"
            Me.mapControl.Size = New System.Drawing.Size(720, 642)
            Me.mapControl.TabIndex = 18
            Me.mapControl.ZoomLevel = 8R
            Me.NameLabel.Appearance.Font = New System.Drawing.Font("Segoe UI", 18F)
            Me.NameLabel.Appearance.Options.UseFont = True
            Me.NameLabel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bindingSource, "Name", True))
            Me.NameLabel.Location = New System.Drawing.Point(856, 8)
            Me.NameLabel.Name = "NameLabel"
            Me.NameLabel.Size = New System.Drawing.Size(356, 32)
            Me.NameLabel.StyleController = Me.moduleDataLayout
            Me.NameLabel.TabIndex = 8
            Me.DescriptionLabel.Appearance.Font = New System.Drawing.Font("Segoe UI", 11F)
            Me.DescriptionLabel.Appearance.Options.UseFont = True
            Me.DescriptionLabel.Appearance.Options.UseTextOptions = True
            Me.DescriptionLabel.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
            Me.DescriptionLabel.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter
            Me.DescriptionLabel.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
            Me.DescriptionLabel.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
            Me.DescriptionLabel.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
            Me.DescriptionLabel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bindingSource, "Description", True))
            Me.DescriptionLabel.Location = New System.Drawing.Point(856, 40)
            Me.DescriptionLabel.Name = "DescriptionLabel"
            Me.DescriptionLabel.Size = New System.Drawing.Size(356, 88)
            Me.DescriptionLabel.StyleController = Me.moduleDataLayout
            Me.DescriptionLabel.TabIndex = 8
            Me.ImagePictureEdit.Cursor = System.Windows.Forms.Cursors.Default
            Me.ImagePictureEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bindingSource, "Image", True))
            Me.ImagePictureEdit.Location = New System.Drawing.Point(736, 8)
            Me.ImagePictureEdit.MenuManager = Me.ribbonControl
            Me.ImagePictureEdit.Name = "ImagePictureEdit"
            Me.ImagePictureEdit.Properties.ReadOnly = True
            Me.ImagePictureEdit.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom
            Me.ImagePictureEdit.Properties.ZoomAccelerationFactor = 1R
            Me.ImagePictureEdit.Size = New System.Drawing.Size(108, 120)
            Me.ImagePictureEdit.StyleController = Me.moduleDataLayout
            Me.ImagePictureEdit.TabIndex = 17
            Me.layoutControlGroup1.CustomizationFormText = "Root"
            Me.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.False
            Me.layoutControlGroup1.GroupBordersVisible = False
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.ItemForMap, Me.layoutControlGroup3, Me.layoutControlGroup4, Me.simpleSeparator1, Me.simpleSeparator2})
            Me.layoutControlGroup1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup1.Name = "Root"
            Me.layoutControlGroup1.OptionsItemText.TextToControlDistance = 6
            Me.layoutControlGroup1.Size = New System.Drawing.Size(1226, 642)
            Me.layoutControlGroup1.TextVisible = False
            Me.ItemForMap.Control = Me.mapControl
            Me.ItemForMap.CustomizationFormText = "map"
            Me.ItemForMap.Location = New System.Drawing.Point(0, 0)
            Me.ItemForMap.Name = "layoutControlItem1"
            Me.ItemForMap.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.ItemForMap.Size = New System.Drawing.Size(720, 642)
            Me.ItemForMap.Text = "map"
            Me.ItemForMap.TextSize = New System.Drawing.Size(0, 0)
            Me.ItemForMap.TextVisible = False
            Me.layoutControlGroup3.CustomizationFormText = "layoutControlGroup3"
            Me.layoutControlGroup3.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True
            Me.layoutControlGroup3.GroupBordersVisible = False
            Me.layoutControlGroup3.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.ItemForChartPanel})
            Me.layoutControlGroup3.Location = New System.Drawing.Point(722, 140)
            Me.layoutControlGroup3.Name = "layoutControlGroup3"
            Me.layoutControlGroup3.Padding = New DevExpress.XtraLayout.Utils.Padding(12, 12, 8, 8)
            Me.layoutControlGroup3.Size = New System.Drawing.Size(504, 502)
            Me.layoutControlGroup3.Spacing = New DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 0)
            Me.layoutControlGroup3.TextVisible = False
            Me.ItemForChartPanel.Control = Me.chartPanel
            Me.ItemForChartPanel.CustomizationFormText = "layoutControlItem2"
            Me.ItemForChartPanel.Location = New System.Drawing.Point(0, 0)
            Me.ItemForChartPanel.Name = "ItemForChartPanel"
            Me.ItemForChartPanel.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.ItemForChartPanel.Size = New System.Drawing.Size(476, 484)
            Me.ItemForChartPanel.TextSize = New System.Drawing.Size(0, 0)
            Me.ItemForChartPanel.TextVisible = False
            Me.layoutControlGroup4.CustomizationFormText = "layoutControlGroup4"
            Me.layoutControlGroup4.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True
            Me.layoutControlGroup4.GroupBordersVisible = False
            Me.layoutControlGroup4.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.ItemForImage, Me.ItemForAddressLine1, Me.ItemForFullName})
            Me.layoutControlGroup4.Location = New System.Drawing.Point(722, 0)
            Me.layoutControlGroup4.Name = "layoutControlGroup4"
            Me.layoutControlGroup4.Padding = New DevExpress.XtraLayout.Utils.Padding(12, 12, 8, 8)
            Me.layoutControlGroup4.Size = New System.Drawing.Size(504, 138)
            Me.layoutControlGroup4.Spacing = New DevExpress.XtraLayout.Utils.Padding(2, 2, 0, 2)
            Me.layoutControlGroup4.TextVisible = False
            Me.ItemForImage.Control = Me.ImagePictureEdit
            Me.ItemForImage.CustomizationFormText = "Image"
            Me.ItemForImage.Location = New System.Drawing.Point(0, 0)
            Me.ItemForImage.MaxSize = New System.Drawing.Size(120, 120)
            Me.ItemForImage.MinSize = New System.Drawing.Size(120, 120)
            Me.ItemForImage.Name = "ItemForImage"
            Me.ItemForImage.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 12, 0, 0)
            Me.ItemForImage.Size = New System.Drawing.Size(120, 120)
            Me.ItemForImage.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.ItemForImage.Text = "Image"
            Me.ItemForImage.TextSize = New System.Drawing.Size(0, 0)
            Me.ItemForImage.TextVisible = False
            Me.ItemForAddressLine1.Control = Me.DescriptionLabel
            Me.ItemForAddressLine1.CustomizationFormText = "Address"
            Me.ItemForAddressLine1.Location = New System.Drawing.Point(120, 32)
            Me.ItemForAddressLine1.MaxSize = New System.Drawing.Size(356, 88)
            Me.ItemForAddressLine1.MinSize = New System.Drawing.Size(356, 88)
            Me.ItemForAddressLine1.Name = "ItemForAddressLine1"
            Me.ItemForAddressLine1.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.ItemForAddressLine1.Size = New System.Drawing.Size(356, 88)
            Me.ItemForAddressLine1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.ItemForAddressLine1.Text = "Address"
            Me.ItemForAddressLine1.TextSize = New System.Drawing.Size(0, 0)
            Me.ItemForAddressLine1.TextVisible = False
            Me.ItemForFullName.Control = Me.NameLabel
            Me.ItemForFullName.CustomizationFormText = "Full Name"
            Me.ItemForFullName.Location = New System.Drawing.Point(120, 0)
            Me.ItemForFullName.Name = "ItemForFullName"
            Me.ItemForFullName.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.ItemForFullName.Size = New System.Drawing.Size(356, 32)
            Me.ItemForFullName.Text = "Full Name"
            Me.ItemForFullName.TextSize = New System.Drawing.Size(0, 0)
            Me.ItemForFullName.TextVisible = False
            Me.simpleSeparator1.AllowHotTrack = False
            Me.simpleSeparator1.CustomizationFormText = "simpleSeparator1"
            Me.simpleSeparator1.Location = New System.Drawing.Point(722, 138)
            Me.simpleSeparator1.Name = "simpleSeparator1"
            Me.simpleSeparator1.Size = New System.Drawing.Size(504, 2)
            Me.simpleSeparator2.AllowHotTrack = False
            Me.simpleSeparator2.CustomizationFormText = "simpleSeparator2"
            Me.simpleSeparator2.Location = New System.Drawing.Point(720, 0)
            Me.simpleSeparator2.Name = "simpleSeparator2"
            Me.simpleSeparator2.Size = New System.Drawing.Size(2, 642)
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.moduleDataLayout)
            Me.Controls.Add(Me.ribbonControl)
            Me.Margin = New System.Windows.Forms.Padding(6)
            Me.Name = "ProductMapView"
            Me.Size = New System.Drawing.Size(1226, 762)
            CType(Me.mvvmContext, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.bindingSourceMapItem, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.chartPanel, System.ComponentModel.ISupportInitialize).EndInit()
            Me.chartPanel.ResumeLayout(False)
            CType(xyDiagram1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(series1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.chart, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.bindingSourceChart, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.bindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ribbonControl, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.moduleDataLayout, System.ComponentModel.ISupportInitialize).EndInit()
            Me.moduleDataLayout.ResumeLayout(False)
            CType(Me.mapControl, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ImagePictureEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ItemForMap, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlGroup3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ItemForChartPanel, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlGroup4, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ItemForImage, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ItemForAddressLine1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ItemForFullName, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.simpleSeparator1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.simpleSeparator2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        #End Region

        Private keyColorColorizer As DevExpress.DevAV.Modules.Colorizer
        Private bindingSource As System.Windows.Forms.BindingSource
        Private ribbonControl As XtraBars.Ribbon.RibbonControl
        Private biSave As XtraBars.BarButtonItem
        Private biClose As XtraBars.BarButtonItem
        Private biSaveAndClose As XtraBars.BarButtonItem
        Private biDelete As XtraBars.BarButtonItem
        Private biLifetime As XtraBars.BarCheckItem
        Private biThisYear As XtraBars.BarCheckItem
        Private biThisMonth As XtraBars.BarCheckItem
        Private biPrint As XtraBars.BarButtonItem
        Private biPrintPreview As XtraBars.BarButtonItem
        Private barExportItem As XtraBars.BarButtonItem
        Private ribbonPage1 As XtraBars.Ribbon.RibbonPage
        Private ribbonPageGroup1 As XtraBars.Ribbon.RibbonPageGroup
        Private ribbonPageGroup2 As XtraBars.Ribbon.RibbonPageGroup
        Private ribbonPageGroup5 As XtraBars.Ribbon.RibbonPageGroup
        Private ribbonPageGroup4 As XtraBars.Ribbon.RibbonPageGroup
        Private ribbonPageGroup3 As XtraBars.Ribbon.RibbonPageGroup
        Private moduleDataLayout As XtraDataLayout.DataLayoutControl
        Private mapControl As XtraMap.MapControl
        Private NameLabel As XtraEditors.LabelControl
        Private DescriptionLabel As XtraEditors.LabelControl
        Private ImagePictureEdit As XtraEditors.PictureEdit
        Private layoutControlGroup1 As XtraLayout.LayoutControlGroup
        Private ItemForMap As XtraLayout.LayoutControlItem
        Private layoutControlGroup3 As XtraLayout.LayoutControlGroup
        Private layoutControlGroup4 As XtraLayout.LayoutControlGroup
        Private ItemForImage As XtraLayout.LayoutControlItem
        Private ItemForAddressLine1 As XtraLayout.LayoutControlItem
        Private ItemForFullName As XtraLayout.LayoutControlItem
        Private simpleSeparator1 As XtraLayout.SimpleSeparator
        Private simpleSeparator2 As XtraLayout.SimpleSeparator
        Private chart As XtraCharts.ChartControl
        Private ItemForChartPanel As XtraLayout.LayoutControlItem
        Private bindingSourceChart As System.Windows.Forms.BindingSource
        Private periodButtons As XtraBars.Docking2010.WindowsUIButtonPanel
        Private chartPanel As DevExpress.XtraEditors.PanelControl
        Private bindingSourceMapItem As System.Windows.Forms.BindingSource
        Private imageTilesLayer1 As XtraMap.ImageLayer
        Private bingMapDataProvider1 As XtraMap.BingMapDataProvider
        Private vectorItemsLayer1 As XtraMap.VectorItemsLayer
        Private pieChartDataAdapter1 As XtraMap.PieChartDataAdapter
    End Class
End Namespace
