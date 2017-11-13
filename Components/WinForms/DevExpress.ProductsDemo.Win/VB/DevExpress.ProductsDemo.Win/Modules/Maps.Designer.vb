Imports DevExpress.XtraMap
Namespace DevExpress.ProductsDemo.Win.Modules
	Partial Public Class MapsModule
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
            Dim ImageTilesLayer1 As DevExpress.XtraMap.ImageLayer = New DevExpress.XtraMap.ImageLayer()
            Dim VectorItemsLayer1 As DevExpress.XtraMap.VectorItemsLayer = New DevExpress.XtraMap.VectorItemsLayer()
            Dim ListSourceDataAdapter1 As DevExpress.XtraMap.ListSourceDataAdapter = New DevExpress.XtraMap.ListSourceDataAdapter()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MapsModule))
            Dim XyDiagram1 As DevExpress.XtraCharts.XYDiagram = New DevExpress.XtraCharts.XYDiagram()
            Dim Series1 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
            Dim LineSeriesView1 As DevExpress.XtraCharts.LineSeriesView = New DevExpress.XtraCharts.LineSeriesView()
            Dim LineSeriesView2 As DevExpress.XtraCharts.LineSeriesView = New DevExpress.XtraCharts.LineSeriesView()
            Me.mapContainerPanel = New DevExpress.XtraEditors.PanelControl()
            Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl()
            Me.mapControl1 = New DevExpress.XtraMap.MapControl()
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.ribbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
            Me.chkBingRoad = New DevExpress.XtraBars.BarCheckItem()
            Me.chkBingArea = New DevExpress.XtraBars.BarCheckItem()
            Me.chkBingHybrid = New DevExpress.XtraBars.BarCheckItem()
            Me.chkFahrenheit = New DevExpress.XtraBars.BarCheckItem()
            Me.chkCelsius = New DevExpress.XtraBars.BarCheckItem()
            Me.viewRibbonPage1 = New DevExpress.XtraScheduler.UI.ViewRibbonPage()
            Me.activeViewRibbonPageGroup1 = New DevExpress.XtraScheduler.UI.ActiveViewRibbonPageGroup()
            Me.timeScaleRibbonPageGroup1 = New DevExpress.XtraScheduler.UI.TimeScaleRibbonPageGroup()
            Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
            Me.panelControl2 = New DevExpress.XtraEditors.PanelControl()
            Me.lbTemperature = New DevExpress.XtraEditors.LabelControl()
            Me.peWeatherIcon = New DevExpress.XtraEditors.PictureEdit()
            Me.lbCity = New DevExpress.XtraEditors.LabelControl()
            Me.chartControl1 = New DevExpress.XtraCharts.ChartControl()
            CType(Me.mapContainerPanel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.mapContainerPanel.SuspendLayout()
            CType(Me.layoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl1.SuspendLayout()
            CType(Me.mapControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panelControl1.SuspendLayout()
            CType(Me.panelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panelControl2.SuspendLayout()
            CType(Me.peWeatherIcon.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.chartControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(XyDiagram1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Series1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(LineSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(LineSeriesView2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'mapContainerPanel
            '
            Me.mapContainerPanel.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.mapContainerPanel.Controls.Add(Me.layoutControl1)
            Me.mapContainerPanel.Dock = System.Windows.Forms.DockStyle.Fill
            Me.mapContainerPanel.Location = New System.Drawing.Point(0, 142)
            Me.mapContainerPanel.Margin = New System.Windows.Forms.Padding(23)
            Me.mapContainerPanel.Name = "mapContainerPanel"
            Me.mapContainerPanel.Size = New System.Drawing.Size(1053, 597)
            Me.mapContainerPanel.TabIndex = 15
            '
            'layoutControl1
            '
            Me.layoutControl1.Controls.Add(Me.mapControl1)
            Me.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layoutControl1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControl1.Name = "layoutControl1"
            Me.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(376, 238, 905, 577)
            Me.layoutControl1.Root = Me.layoutControlGroup1
            Me.layoutControl1.Size = New System.Drawing.Size(1053, 597)
            Me.layoutControl1.TabIndex = 16
            Me.layoutControl1.Text = "layoutControl1"
            '
            'mapControl1
            '
            Me.mapControl1.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(7, Byte), Integer), CType(CType(21, Byte), Integer))
            Me.mapControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.mapControl1.CenterPoint = New DevExpress.XtraMap.GeoPoint(5.0R, -70.0R)
            ListSourceDataAdapter1.Mappings.Latitude = "Latitude"
            ListSourceDataAdapter1.Mappings.Longitude = "Longitude"
            ListSourceDataAdapter1.Mappings.Text = "CelsiusDisplayText"
            VectorItemsLayer1.Data = ListSourceDataAdapter1
            Me.mapControl1.Layers.Add(ImageTilesLayer1)
            Me.mapControl1.Layers.Add(VectorItemsLayer1)
            Me.mapControl1.Location = New System.Drawing.Point(12, 12)
            Me.mapControl1.MinZoomLevel = 1.7R
            Me.mapControl1.Name = "mapControl1"
            Me.mapControl1.SelectionMode = DevExpress.XtraMap.ElementSelectionMode.[Single]
            Me.mapControl1.Size = New System.Drawing.Size(1029, 573)
            Me.mapControl1.TabIndex = 17
            Me.mapControl1.ZoomLevel = 3.0R
            '
            'layoutControlGroup1
            '
            Me.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1"
            Me.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.layoutControlGroup1.GroupBordersVisible = False
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem1})
            Me.layoutControlGroup1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup1.Name = "layoutControlGroup1"
            Me.layoutControlGroup1.Size = New System.Drawing.Size(1053, 597)
            Me.layoutControlGroup1.Text = "layoutControlGroup1"
            Me.layoutControlGroup1.TextVisible = False
            '
            'layoutControlItem1
            '
            Me.layoutControlItem1.Control = Me.mapControl1
            Me.layoutControlItem1.CustomizationFormText = "layoutControlItem1"
            Me.layoutControlItem1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem1.Name = "layoutControlItem1"
            Me.layoutControlItem1.Size = New System.Drawing.Size(1033, 577)
            Me.layoutControlItem1.Text = "layoutControlItem1"
            Me.layoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem1.TextToControlDistance = 0
            Me.layoutControlItem1.TextVisible = False
            '
            'ribbonControl1
            '
            Me.ribbonControl1.ExpandCollapseItem.Id = 0
            Me.ribbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.ribbonControl1.ExpandCollapseItem, Me.chkBingRoad, Me.chkBingArea, Me.chkBingHybrid, Me.chkFahrenheit, Me.chkCelsius})
            Me.ribbonControl1.Location = New System.Drawing.Point(0, 0)
            Me.ribbonControl1.MaxItemId = 45
            Me.ribbonControl1.Name = "ribbonControl1"
            Me.ribbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.viewRibbonPage1})
            Me.ribbonControl1.Size = New System.Drawing.Size(1053, 142)
            '
            'chkBingRoad
            '
            Me.chkBingRoad.Caption = "Road"
            Me.chkBingRoad.Glyph = CType(resources.GetObject("chkBingRoad.Glyph"), System.Drawing.Image)
            Me.chkBingRoad.GroupIndex = 1
            Me.chkBingRoad.Id = 40
            Me.chkBingRoad.LargeGlyph = CType(resources.GetObject("chkBingRoad.LargeGlyph"), System.Drawing.Image)
            Me.chkBingRoad.Name = "chkBingRoad"
            Me.chkBingRoad.Tag = 0
            '
            'chkBingArea
            '
            Me.chkBingArea.Caption = "Area"
            Me.chkBingArea.Checked = True
            Me.chkBingArea.Glyph = CType(resources.GetObject("chkBingArea.Glyph"), System.Drawing.Image)
            Me.chkBingArea.GroupIndex = 1
            Me.chkBingArea.Id = 41
            Me.chkBingArea.LargeGlyph = CType(resources.GetObject("chkBingArea.LargeGlyph"), System.Drawing.Image)
            Me.chkBingArea.Name = "chkBingArea"
            Me.chkBingArea.Tag = 1
            '
            'chkBingHybrid
            '
            Me.chkBingHybrid.Caption = "Hybrid"
            Me.chkBingHybrid.Glyph = CType(resources.GetObject("chkBingHybrid.Glyph"), System.Drawing.Image)
            Me.chkBingHybrid.GroupIndex = 1
            Me.chkBingHybrid.Id = 42
            Me.chkBingHybrid.LargeGlyph = CType(resources.GetObject("chkBingHybrid.LargeGlyph"), System.Drawing.Image)
            Me.chkBingHybrid.Name = "chkBingHybrid"
            Me.chkBingHybrid.Tag = 2
            '
            'chkFahrenheit
            '
            Me.chkFahrenheit.Caption = "Fahrenheit"
            Me.chkFahrenheit.Glyph = CType(resources.GetObject("chkFahrenheit.Glyph"), System.Drawing.Image)
            Me.chkFahrenheit.GroupIndex = 1
            Me.chkFahrenheit.Id = 43
            Me.chkFahrenheit.LargeGlyph = CType(resources.GetObject("chkFahrenheit.LargeGlyph"), System.Drawing.Image)
            Me.chkFahrenheit.Name = "chkFahrenheit"
            Me.chkFahrenheit.Tag = 0
            '
            'chkCelsius
            '
            Me.chkCelsius.Caption = "Celsius"
            Me.chkCelsius.Checked = True
            Me.chkCelsius.Glyph = CType(resources.GetObject("chkCelsius.Glyph"), System.Drawing.Image)
            Me.chkCelsius.GroupIndex = 1
            Me.chkCelsius.Id = 44
            Me.chkCelsius.LargeGlyph = CType(resources.GetObject("chkCelsius.LargeGlyph"), System.Drawing.Image)
            Me.chkCelsius.Name = "chkCelsius"
            Me.chkCelsius.Tag = 1
            '
            'viewRibbonPage1
            '
            Me.viewRibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.activeViewRibbonPageGroup1, Me.timeScaleRibbonPageGroup1})
            Me.viewRibbonPage1.Name = "viewRibbonPage1"
            '
            'activeViewRibbonPageGroup1
            '
            Me.activeViewRibbonPageGroup1.AllowTextClipping = False
            Me.activeViewRibbonPageGroup1.ItemLinks.Add(Me.chkBingRoad)
            Me.activeViewRibbonPageGroup1.ItemLinks.Add(Me.chkBingArea)
            Me.activeViewRibbonPageGroup1.ItemLinks.Add(Me.chkBingHybrid)
            Me.activeViewRibbonPageGroup1.Name = "activeViewRibbonPageGroup1"
            Me.activeViewRibbonPageGroup1.Text = "BingMap Kind"
            '
            'timeScaleRibbonPageGroup1
            '
            Me.timeScaleRibbonPageGroup1.AllowTextClipping = False
            Me.timeScaleRibbonPageGroup1.ItemLinks.Add(Me.chkFahrenheit)
            Me.timeScaleRibbonPageGroup1.ItemLinks.Add(Me.chkCelsius)
            Me.timeScaleRibbonPageGroup1.Name = "timeScaleRibbonPageGroup1"
            Me.timeScaleRibbonPageGroup1.Text = "TemperatureUnit"
            '
            'panelControl1
            '
            Me.panelControl1.Appearance.BackColor = System.Drawing.Color.Black
            Me.panelControl1.Appearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(80, Byte), Integer))
            Me.panelControl1.Appearance.Options.UseBackColor = True
            Me.panelControl1.Appearance.Options.UseBorderColor = True
            Me.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
            Me.panelControl1.Controls.Add(Me.panelControl2)
            Me.panelControl1.Controls.Add(Me.chartControl1)
            Me.panelControl1.Location = New System.Drawing.Point(21, 21)
            Me.panelControl1.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat
            Me.panelControl1.LookAndFeel.UseDefaultLookAndFeel = False
            Me.panelControl1.Name = "panelControl1"
            Me.panelControl1.Padding = New System.Windows.Forms.Padding(13, 13, 23, 14)
            Me.panelControl1.Size = New System.Drawing.Size(320, 267)
            Me.panelControl1.TabIndex = 17
            '
            'panelControl2
            '
            Me.panelControl2.Appearance.BackColor = System.Drawing.Color.Black
            Me.panelControl2.Appearance.Options.UseBackColor = True
            Me.panelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.panelControl2.Controls.Add(Me.lbTemperature)
            Me.panelControl2.Controls.Add(Me.peWeatherIcon)
            Me.panelControl2.Controls.Add(Me.lbCity)
            Me.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill
            Me.panelControl2.Location = New System.Drawing.Point(15, 15)
            Me.panelControl2.LookAndFeel.UseDefaultLookAndFeel = False
            Me.panelControl2.Name = "panelControl2"
            Me.panelControl2.Size = New System.Drawing.Size(280, 57)
            Me.panelControl2.TabIndex = 15
            '
            'lbTemperature
            '
            Me.lbTemperature.Appearance.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
            Me.lbTemperature.Appearance.ForeColor = System.Drawing.Color.White
            Me.lbTemperature.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
            Me.lbTemperature.Location = New System.Drawing.Point(53, 26)
            Me.lbTemperature.Name = "lbTemperature"
            Me.lbTemperature.Size = New System.Drawing.Size(182, 34)
            Me.lbTemperature.TabIndex = 2
            '
            'peWeatherIcon
            '
            Me.peWeatherIcon.Location = New System.Drawing.Point(0, 19)
            Me.peWeatherIcon.Name = "peWeatherIcon"
            Me.peWeatherIcon.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
            Me.peWeatherIcon.Properties.Appearance.Options.UseBackColor = True
            Me.peWeatherIcon.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.peWeatherIcon.Properties.NullText = " "
            Me.peWeatherIcon.Properties.PictureAlignment = System.Drawing.ContentAlignment.TopLeft
            Me.peWeatherIcon.Properties.ShowMenu = False
            Me.peWeatherIcon.Size = New System.Drawing.Size(49, 41)
            Me.peWeatherIcon.TabIndex = 1
            '
            'lbCity
            '
            Me.lbCity.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lbCity.Appearance.ForeColor = System.Drawing.Color.White
            Me.lbCity.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
            Me.lbCity.Location = New System.Drawing.Point(14, 0)
            Me.lbCity.Name = "lbCity"
            Me.lbCity.Size = New System.Drawing.Size(249, 21)
            Me.lbCity.TabIndex = 0
            '
            'chartControl1
            '
            Me.chartControl1.BackColor = System.Drawing.Color.Black
            Me.chartControl1.BorderOptions.Visibility = DevExpress.Utils.DefaultBoolean.[False]
            XyDiagram1.AxisX.Color = System.Drawing.Color.FromArgb(CType(CType(173, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(173, Byte), Integer))
            XyDiagram1.AxisX.DateTimeScaleOptions.AutoGrid = False
            XyDiagram1.AxisX.DateTimeScaleOptions.GridAlignment = DevExpress.XtraCharts.DateTimeGridAlignment.Day
            XyDiagram1.AxisX.DateTimeScaleOptions.MeasureUnit = DevExpress.XtraCharts.DateTimeMeasureUnit.Hour
            XyDiagram1.AxisX.GridLines.Color = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(160, Byte), Integer))
            XyDiagram1.AxisX.GridLines.MinorColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
            XyDiagram1.AxisX.GridLines.MinorVisible = True
            XyDiagram1.AxisX.GridLines.Visible = True
            XyDiagram1.AxisX.Interlaced = True
            XyDiagram1.AxisX.InterlacedColor = System.Drawing.Color.Transparent
            XyDiagram1.AxisX.Label.ResolveOverlappingOptions.AllowHide = False
            XyDiagram1.AxisX.Label.ResolveOverlappingOptions.AllowRotate = False
            XyDiagram1.AxisX.Label.ResolveOverlappingOptions.AllowStagger = False
            XyDiagram1.AxisX.Label.TextColor = System.Drawing.Color.FromArgb(CType(CType(173, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(173, Byte), Integer))
            XyDiagram1.AxisX.Label.TextPattern = "{A:dd.MM}"
            XyDiagram1.AxisX.Tickmarks.MinorVisible = False
            XyDiagram1.AxisX.Tickmarks.Visible = False
            XyDiagram1.AxisX.VisibleInPanesSerializable = "-1"
            XyDiagram1.AxisY.Color = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(195, Byte), Integer))
            XyDiagram1.AxisY.GridLines.Color = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(160, Byte), Integer))
            XyDiagram1.AxisY.GridLines.MinorColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
            XyDiagram1.AxisY.InterlacedColor = System.Drawing.Color.Transparent
            XyDiagram1.AxisY.Label.ResolveOverlappingOptions.AllowRotate = False
            XyDiagram1.AxisY.Label.ResolveOverlappingOptions.AllowStagger = False
            XyDiagram1.AxisY.Label.TextColor = System.Drawing.Color.FromArgb(CType(CType(173, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(173, Byte), Integer))
            XyDiagram1.AxisY.Tickmarks.MinorVisible = False
            XyDiagram1.AxisY.Tickmarks.Visible = False
            XyDiagram1.AxisY.VisibleInPanesSerializable = "-1"
            XyDiagram1.AxisY.WholeRange.AlwaysShowZeroLevel = False
            XyDiagram1.DefaultPane.BackColor = System.Drawing.Color.Transparent
            XyDiagram1.Margins.Bottom = 2
            XyDiagram1.Margins.Left = 0
            XyDiagram1.Margins.Right = 0
            XyDiagram1.Margins.Top = 2
            Me.chartControl1.Diagram = XyDiagram1
            Me.chartControl1.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.chartControl1.Legend.Visibility = Utils.DefaultBoolean.False
            Me.chartControl1.Location = New System.Drawing.Point(15, 72)
            Me.chartControl1.Margin = New System.Windows.Forms.Padding(0)
            Me.chartControl1.Name = "chartControl1"
            Series1.ArgumentDataMember = "DateTime"
            Series1.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.DateTime
            Series1.CrosshairLabelPattern = "{A:g}: {V}"
            Series1.Name = "Series 1"
            Series1.ValueDataMembersSerializable = "Weather.CelsiusTemperature"
            Series1.View = LineSeriesView1
            Me.chartControl1.SeriesSerializable = New DevExpress.XtraCharts.Series() {Series1}
            Me.chartControl1.SeriesTemplate.View = LineSeriesView2
            Me.chartControl1.Size = New System.Drawing.Size(280, 179)
            Me.chartControl1.TabIndex = 14
            '
            'MapsModule
            '
            Me.Appearance.Options.UseFont = True
            Me.Controls.Add(Me.panelControl1)
            Me.Controls.Add(Me.mapContainerPanel)
            Me.Controls.Add(Me.ribbonControl1)
            Me.Name = "MapsModule"
            Me.Size = New System.Drawing.Size(1053, 739)
            CType(Me.mapContainerPanel, System.ComponentModel.ISupportInitialize).EndInit()
            Me.mapContainerPanel.ResumeLayout(False)
            CType(Me.layoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl1.ResumeLayout(False)
            CType(Me.mapControl1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panelControl1.ResumeLayout(False)
            CType(Me.panelControl2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panelControl2.ResumeLayout(False)
            CType(Me.peWeatherIcon.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(XyDiagram1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(LineSeriesView1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Series1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(LineSeriesView2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.chartControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

		#End Region

		Private mapContainerPanel As XtraEditors.PanelControl
		Private ribbonControl1 As XtraBars.Ribbon.RibbonControl
		Private viewRibbonPage1 As XtraScheduler.UI.ViewRibbonPage
		Private activeViewRibbonPageGroup1 As XtraScheduler.UI.ActiveViewRibbonPageGroup
		Private timeScaleRibbonPageGroup1 As XtraScheduler.UI.TimeScaleRibbonPageGroup
		Private WithEvents chkBingRoad As XtraBars.BarCheckItem
		Private WithEvents chkBingArea As XtraBars.BarCheckItem
		Private WithEvents chkBingHybrid As XtraBars.BarCheckItem
		Private WithEvents chkFahrenheit As XtraBars.BarCheckItem
		Private WithEvents chkCelsius As XtraBars.BarCheckItem
		Private layoutControl1 As XtraLayout.LayoutControl
		Private WithEvents mapControl1 As MapControl
		Private layoutControlGroup1 As XtraLayout.LayoutControlGroup
		Private layoutControlItem1 As XtraLayout.LayoutControlItem
		Private panelControl1 As XtraEditors.PanelControl
		Private panelControl2 As XtraEditors.PanelControl
		Private lbTemperature As XtraEditors.LabelControl
		Private peWeatherIcon As XtraEditors.PictureEdit
		Private lbCity As XtraEditors.LabelControl
		Private chartControl1 As XtraCharts.ChartControl

	End Class
End Namespace
