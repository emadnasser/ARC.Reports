Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.XtraMap.Demos
	Partial Public Class WorldWeather
		''' <summary> 
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary> 
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			OnDispose(disposing)
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
			Dim xyDiagram1 As New DevExpress.XtraCharts.XYDiagram()
			Dim series1 As New DevExpress.XtraCharts.Series()
			Dim lineSeriesView1 As New DevExpress.XtraCharts.LineSeriesView()
			Dim lineSeriesView2 As New DevExpress.XtraCharts.LineSeriesView()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(WorldWeather))
			Me.TilesLayer = New DevExpress.XtraMap.ImageLayer()
			Me.BingDataProvider = New DevExpress.XtraMap.BingMapDataProvider()
			Me.ItemsLayer = New DevExpress.XtraMap.VectorItemsLayer()
			Me.ListSourceDataAdapter = New DevExpress.XtraMap.ListSourceDataAdapter()
			Me.mapControl1 = New DevExpress.XtraMap.MapControl()
			Me.chartControl1 = New DevExpress.XtraCharts.ChartControl()
			Me.mapContainerPanel = New DevExpress.XtraEditors.PanelControl()
			Me.chartPanel = New DevExpress.XtraEditors.PanelControl()
			Me.panelControl2 = New DevExpress.XtraEditors.PanelControl()
			Me.lbTemperature = New DevExpress.XtraEditors.LabelControl()
			Me.peWeatherIcon = New DevExpress.XtraEditors.PictureEdit()
			Me.lbCity = New DevExpress.XtraEditors.LabelControl()
			Me.chkFahrenheit = New DevExpress.XtraBars.BarCheckItem()
			Me.chkCelsius = New DevExpress.XtraBars.BarCheckItem()
			Me.chkShowChart = New DevExpress.XtraBars.BarCheckItem()
			Me.rpgTemperatureUnits = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
			CType(Me.mapControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.chartControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(xyDiagram1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(series1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(lineSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(lineSeriesView2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.mapContainerPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.mapContainerPanel.SuspendLayout()
			CType(Me.chartPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.chartPanel.SuspendLayout()
			CType(Me.panelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panelControl2.SuspendLayout()
			CType(Me.peWeatherIcon.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' TilesLayer
			' 
			Me.TilesLayer.DataProvider = Me.BingDataProvider
			' 
			' BingDataProvider
			' 
			Me.BingDataProvider.Kind = DevExpress.XtraMap.BingMapKind.Area
			' 
			' ItemsLayer
			' 
			Me.ItemsLayer.Data = Me.ListSourceDataAdapter
			' 
			' ListSourceDataAdapter
			' 
			Me.ListSourceDataAdapter.Mappings.Latitude = "Latitude"
			Me.ListSourceDataAdapter.Mappings.Longitude = "Longitude"
			Me.ListSourceDataAdapter.Mappings.Text = "CelsiusDisplayText"
			' 
			' mapControl1
			' 
			Me.mapControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.mapControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.mapControl1.Layers.Add(Me.TilesLayer)
			Me.mapControl1.Layers.Add(Me.ItemsLayer)
			Me.mapControl1.Location = New System.Drawing.Point(2, 2)
			Me.mapControl1.MaxZoomLevel = 5R
			Me.mapControl1.MinZoomLevel = 3R
			Me.mapControl1.Name = "mapControl1"
			Me.mapControl1.NavigationPanelOptions.Visible = False
			Me.mapControl1.SelectionMode = DevExpress.XtraMap.ElementSelectionMode.Single
			Me.mapControl1.Size = New System.Drawing.Size(597, 335)
			Me.mapControl1.TabIndex = 0
			Me.mapControl1.ZoomLevel = 3R
'			Me.mapControl1.SelectionChanging += New DevExpress.XtraMap.MapSelectionChangingEventHandler(Me.mapControl1_SelectionChanging);
'			Me.mapControl1.SelectionChanged += New DevExpress.XtraMap.MapSelectionChangedEventHandler(Me.mapControl1_SelectionChanged);
			' 
			' chartControl1
			' 
			Me.chartControl1.BackColor = System.Drawing.Color.Black
			Me.chartControl1.BorderOptions.Visibility = DevExpress.Utils.DefaultBoolean.False
			Me.chartControl1.DataBindings = Nothing
			xyDiagram1.AxisX.Color = System.Drawing.Color.FromArgb((CInt(Fix((CByte(173))))), (CInt(Fix((CByte(173))))), (CInt(Fix((CByte(173))))))
			xyDiagram1.AxisX.DateTimeScaleOptions.MeasureUnit = DevExpress.XtraCharts.DateTimeMeasureUnit.Hour
			xyDiagram1.AxisX.GridLines.Color = System.Drawing.Color.FromArgb((CInt(Fix((CByte(96))))), (CInt(Fix((CByte(160))))), (CInt(Fix((CByte(160))))), (CInt(Fix((CByte(160))))))
			xyDiagram1.AxisX.GridLines.MinorColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(21))))), (CInt(Fix((CByte(128))))), (CInt(Fix((CByte(128))))), (CInt(Fix((CByte(128))))))
			xyDiagram1.AxisX.GridLines.MinorVisible = True
			xyDiagram1.AxisX.GridLines.Visible = True
			xyDiagram1.AxisX.Interlaced = True
			xyDiagram1.AxisX.InterlacedColor = System.Drawing.Color.Transparent
			xyDiagram1.AxisX.Label.ResolveOverlappingOptions.AllowHide = False
			xyDiagram1.AxisX.Label.ResolveOverlappingOptions.AllowRotate = False
			xyDiagram1.AxisX.Label.ResolveOverlappingOptions.AllowStagger = False
			xyDiagram1.AxisX.Label.TextColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(173))))), (CInt(Fix((CByte(173))))), (CInt(Fix((CByte(173))))))
			xyDiagram1.AxisX.Label.TextPattern = "{A:d}"
			xyDiagram1.AxisX.Tickmarks.MinorVisible = False
			xyDiagram1.AxisX.Tickmarks.Visible = False
			xyDiagram1.AxisX.Visibility = DevExpress.Utils.DefaultBoolean.True
			xyDiagram1.AxisX.VisibleInPanesSerializable = "-1"
			xyDiagram1.AxisY.Color = System.Drawing.Color.FromArgb((CInt(Fix((CByte(195))))), (CInt(Fix((CByte(195))))), (CInt(Fix((CByte(195))))))
			xyDiagram1.AxisY.GridLines.Color = System.Drawing.Color.FromArgb((CInt(Fix((CByte(96))))), (CInt(Fix((CByte(160))))), (CInt(Fix((CByte(160))))), (CInt(Fix((CByte(160))))))
			xyDiagram1.AxisY.GridLines.MinorColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(21))))), (CInt(Fix((CByte(128))))), (CInt(Fix((CByte(128))))), (CInt(Fix((CByte(128))))))
			xyDiagram1.AxisY.InterlacedColor = System.Drawing.Color.Transparent
			xyDiagram1.AxisY.Label.ResolveOverlappingOptions.AllowRotate = False
			xyDiagram1.AxisY.Label.ResolveOverlappingOptions.AllowStagger = False
			xyDiagram1.AxisY.Label.TextColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(173))))), (CInt(Fix((CByte(173))))), (CInt(Fix((CByte(173))))))
			xyDiagram1.AxisY.Tickmarks.MinorVisible = False
			xyDiagram1.AxisY.Tickmarks.Visible = False
			xyDiagram1.AxisY.Visibility = DevExpress.Utils.DefaultBoolean.True
			xyDiagram1.AxisY.VisibleInPanesSerializable = "-1"
			xyDiagram1.AxisY.WholeRange.AlwaysShowZeroLevel = False
			xyDiagram1.DefaultPane.BackColor = System.Drawing.Color.Transparent
			xyDiagram1.Margins.Bottom = 2
			xyDiagram1.Margins.Left = 0
			xyDiagram1.Margins.Right = 0
			xyDiagram1.Margins.Top = 2
			Me.chartControl1.Diagram = xyDiagram1
			Me.chartControl1.Dock = System.Windows.Forms.DockStyle.Bottom
			Me.chartControl1.Legend.Name = "Default Legend"
			Me.chartControl1.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False
			Me.chartControl1.Location = New System.Drawing.Point(15, 72)
			Me.chartControl1.Margin = New System.Windows.Forms.Padding(0)
			Me.chartControl1.Name = "chartControl1"
			series1.ArgumentDataMember = "CurrentDateTime"
			series1.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.DateTime
			series1.CrosshairLabelPattern = "{A:g}: {V}"
			series1.Name = "Series 1"
			series1.ValueDataMembersSerializable = "Weather.CelsiusTemperature"
			series1.View = lineSeriesView1
			Me.chartControl1.SeriesSerializable = New DevExpress.XtraCharts.Series() { series1}
			Me.chartControl1.SeriesTemplate.View = lineSeriesView2
			Me.chartControl1.Size = New System.Drawing.Size(280, 179)
			Me.chartControl1.TabIndex = 14
			' 
			' mapContainerPanel
			' 
			Me.mapContainerPanel.Controls.Add(Me.chartPanel)
			Me.mapContainerPanel.Controls.Add(Me.mapControl1)
			Me.mapContainerPanel.Dock = System.Windows.Forms.DockStyle.Fill
			Me.mapContainerPanel.Location = New System.Drawing.Point(0, 141)
			Me.mapContainerPanel.Name = "mapContainerPanel"
			Me.mapContainerPanel.Size = New System.Drawing.Size(601, 339)
			Me.mapContainerPanel.TabIndex = 15
			' 
			' chartPanel
			' 
			Me.chartPanel.Appearance.BackColor = System.Drawing.Color.Black
			Me.chartPanel.Appearance.BorderColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(64))))), (CInt(Fix((CByte(71))))), (CInt(Fix((CByte(80))))))
			Me.chartPanel.Appearance.Options.UseBackColor = True
			Me.chartPanel.Appearance.Options.UseBorderColor = True
			Me.chartPanel.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
			Me.chartPanel.Controls.Add(Me.panelControl2)
			Me.chartPanel.Controls.Add(Me.chartControl1)
			Me.chartPanel.Location = New System.Drawing.Point(21, 21)
			Me.chartPanel.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat
			Me.chartPanel.LookAndFeel.UseDefaultLookAndFeel = False
			Me.chartPanel.Name = "chartPanel"
			Me.chartPanel.Padding = New System.Windows.Forms.Padding(13, 13, 23, 14)
			Me.chartPanel.Size = New System.Drawing.Size(320, 267)
			Me.chartPanel.TabIndex = 15
			' 
			' panelControl2
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
			' lbTemperature
			' 
			Me.lbTemperature.Appearance.Font = New System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(204)))
			Me.lbTemperature.Appearance.ForeColor = System.Drawing.Color.White
			Me.lbTemperature.Appearance.Options.UseFont = True
			Me.lbTemperature.Appearance.Options.UseForeColor = True
			Me.lbTemperature.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
			Me.lbTemperature.Location = New System.Drawing.Point(53, 26)
			Me.lbTemperature.Name = "lbTemperature"
			Me.lbTemperature.Size = New System.Drawing.Size(182, 34)
			Me.lbTemperature.TabIndex = 2
			' 
			' peWeatherIcon
			' 
			Me.peWeatherIcon.Location = New System.Drawing.Point(0, 19)
			Me.peWeatherIcon.MenuManager = Me
			Me.peWeatherIcon.Name = "peWeatherIcon"
			Me.peWeatherIcon.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
			Me.peWeatherIcon.Properties.Appearance.Options.UseBackColor = True
			Me.peWeatherIcon.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.peWeatherIcon.Properties.NullText = " "
			Me.peWeatherIcon.Properties.PictureAlignment = System.Drawing.ContentAlignment.TopLeft
			Me.peWeatherIcon.Properties.ShowMenu = False
			Me.peWeatherIcon.Properties.ZoomAccelerationFactor = 1R
			Me.peWeatherIcon.Size = New System.Drawing.Size(49, 41)
			Me.peWeatherIcon.TabIndex = 1
			' 
			' lbCity
			' 
			Me.lbCity.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.lbCity.Appearance.ForeColor = System.Drawing.Color.White
			Me.lbCity.Appearance.Options.UseFont = True
			Me.lbCity.Appearance.Options.UseForeColor = True
			Me.lbCity.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
			Me.lbCity.Location = New System.Drawing.Point(14, 0)
			Me.lbCity.Name = "lbCity"
			Me.lbCity.Size = New System.Drawing.Size(249, 21)
			Me.lbCity.TabIndex = 0
			' 
			' chkFahrenheit
			' 
			Me.chkFahrenheit.Caption = "Fahrenheit"
			Me.chkFahrenheit.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
			Me.chkFahrenheit.Glyph = (CType(resources.GetObject("chkFahrenheit.Glyph"), System.Drawing.Image))
			Me.chkFahrenheit.GroupIndex = 1
			Me.chkFahrenheit.Id = 1
			Me.chkFahrenheit.LargeGlyph = (CType(resources.GetObject("chkFahrenheit.LargeGlyph"), System.Drawing.Image))
			Me.chkFahrenheit.Name = "chkFahrenheit"
			Me.chkFahrenheit.Tag = 0
'			Me.chkFahrenheit.CheckedChanged += New DevExpress.XtraBars.ItemClickEventHandler(Me.chkFahrenheit_CheckedChanged);
			' 
			' chkCelsius
			' 
			Me.chkCelsius.BindableChecked = True
			Me.chkCelsius.Caption = "Celsius"
			Me.chkCelsius.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
			Me.chkCelsius.Checked = True
			Me.chkCelsius.Glyph = (CType(resources.GetObject("chkCelsius.Glyph"), System.Drawing.Image))
			Me.chkCelsius.GroupIndex = 1
			Me.chkCelsius.Id = 2
			Me.chkCelsius.LargeGlyph = (CType(resources.GetObject("chkCelsius.LargeGlyph"), System.Drawing.Image))
			Me.chkCelsius.Name = "chkCelsius"
			Me.chkCelsius.Tag = 0
'			Me.chkCelsius.CheckedChanged += New DevExpress.XtraBars.ItemClickEventHandler(Me.chkFahrenheit_CheckedChanged);
			' 
			' chkShowChart
			' 
			Me.chkShowChart.BindableChecked = True
			Me.chkShowChart.Caption = "Details"
			Me.chkShowChart.Checked = True
			Me.chkShowChart.Glyph = (CType(resources.GetObject("chkShowChart.Glyph"), System.Drawing.Image))
			Me.chkShowChart.Id = 5
			Me.chkShowChart.LargeGlyph = (CType(resources.GetObject("chkShowChart.LargeGlyph"), System.Drawing.Image))
			Me.chkShowChart.Name = "chkShowChart"
'			Me.chkShowChart.ItemClick += New DevExpress.XtraBars.ItemClickEventHandler(Me.chkShowChart_ItemClick);
			' 
			' rpgTemperatureUnits
			' 
			Me.rpgTemperatureUnits.AllowTextClipping = False
			Me.rpgTemperatureUnits.ItemLinks.Add(Me.chkShowChart)
			Me.rpgTemperatureUnits.ItemLinks.Add(Me.chkFahrenheit)
			Me.rpgTemperatureUnits.ItemLinks.Add(Me.chkCelsius)
			Me.rpgTemperatureUnits.Name = "rpgTemperatureUnits"
			Me.rpgTemperatureUnits.Text = "Temperature Options"
			' 
			' WorldWeather
			' 
			Me.Appearance.Options.UseFont = True
			Me.Controls.Add(Me.mapContainerPanel)
			Me.Name = "WorldWeather"
			Me.Size = New System.Drawing.Size(601, 480)
			Me.Controls.SetChildIndex(Me.mapContainerPanel, 0)
			CType(Me.mapControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(xyDiagram1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(lineSeriesView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(series1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(lineSeriesView2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.chartControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.mapContainerPanel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.mapContainerPanel.ResumeLayout(False)
			CType(Me.chartPanel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.chartPanel.ResumeLayout(False)
			CType(Me.panelControl2, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panelControl2.ResumeLayout(False)
			CType(Me.peWeatherIcon.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private WithEvents mapControl1 As MapControl
		Private chartControl1 As XtraCharts.ChartControl
		Private mapContainerPanel As XtraEditors.PanelControl
		Private chartPanel As XtraEditors.PanelControl
		Private panelControl2 As XtraEditors.PanelControl
		Private lbTemperature As XtraEditors.LabelControl
		Private peWeatherIcon As XtraEditors.PictureEdit
		Private lbCity As XtraEditors.LabelControl
		Private rpgTemperatureUnits As XtraBars.Ribbon.RibbonPageGroup
		'private XtraBars.Ribbon.RibbonPageGroup rpgShow;
		Private WithEvents chkFahrenheit As XtraBars.BarCheckItem
		Private WithEvents chkCelsius As XtraBars.BarCheckItem
		Private TilesLayer As ImageLayer
		Private ItemsLayer As VectorItemsLayer
		Private ListSourceDataAdapter As ListSourceDataAdapter
		Private BingDataProvider As BingMapDataProvider
		Private WithEvents chkShowChart As XtraBars.BarCheckItem
	End Class
End Namespace
