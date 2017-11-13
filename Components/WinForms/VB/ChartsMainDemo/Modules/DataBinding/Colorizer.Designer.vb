Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.XtraCharts.Demos.DataBinding
	Partial Public Class ColorizerDemo
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
			Dim xyDiagram1 As New DevExpress.XtraCharts.XYDiagram()
			Dim series1 As New DevExpress.XtraCharts.Series()
			Dim bubbleSeriesLabel1 As New DevExpress.XtraCharts.BubbleSeriesLabel()
			Dim bubbleSeriesView1 As New DevExpress.XtraCharts.BubbleSeriesView()
			Dim xyMarkerSlideAnimation1 As New DevExpress.XtraCharts.XYMarkerSlideAnimation()
			Dim elasticEasingFunction1 As New DevExpress.XtraCharts.ElasticEasingFunction()
			Dim bubbleSeriesView2 As New DevExpress.XtraCharts.BubbleSeriesView()
			Dim chartTitle1 As New DevExpress.XtraCharts.ChartTitle()
			Me.chart = New DevExpress.XtraCharts.ChartControl()
			CType(Me.panel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panel.SuspendLayout()
			CType(Me.checkEditShowLabels.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panelRoot.SuspendLayout()
			CType(Me.chart, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(xyDiagram1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(series1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(bubbleSeriesLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(bubbleSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(bubbleSeriesView2, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' panel
			' 
			Me.panel.Size = New System.Drawing.Size(700, 37)
			' 
			' checkEditShowLabels
			' 
			Me.checkEditShowLabels.Location = New System.Drawing.Point(606, 9)
			Me.checkEditShowLabels.Size = New System.Drawing.Size(82, 19)
			' 
			' panelRoot
			' 
			Me.panelRoot.Size = New System.Drawing.Size(700, 45)
			' 
			' chart
			' 
			Me.chart.AnimationStartMode = DevExpress.XtraCharts.ChartAnimationMode.OnDataChanged
			Me.chart.CrosshairEnabled = DevExpress.Utils.DefaultBoolean.False
			Me.chart.DataBindings = Nothing
			xyDiagram1.AxisX.Tickmarks.MinorVisible = False
			xyDiagram1.AxisX.VisibleInPanesSerializable = "-1"
			xyDiagram1.AxisX.VisualRange.Auto = False
			xyDiagram1.AxisX.VisualRange.AutoSideMargins = False
			xyDiagram1.AxisX.VisualRange.MaxValueSerializable = "9"
			xyDiagram1.AxisX.VisualRange.MinValueSerializable = "0"
			xyDiagram1.AxisX.VisualRange.SideMarginsValue = 0.7R
			xyDiagram1.AxisX.WholeRange.AutoSideMargins = False
			xyDiagram1.AxisX.WholeRange.SideMarginsValue = 0.7R
			xyDiagram1.AxisY.NumericScaleOptions.AutoGrid = False
			xyDiagram1.AxisY.NumericScaleOptions.GridAlignment = DevExpress.XtraCharts.NumericGridAlignment.Thousands
			xyDiagram1.AxisY.NumericScaleOptions.GridSpacing = 10R
			xyDiagram1.AxisY.Title.Text = "GDP per capita, $"
			xyDiagram1.AxisY.Title.Visibility = DevExpress.Utils.DefaultBoolean.True
			xyDiagram1.AxisY.VisibleInPanesSerializable = "-1"
			xyDiagram1.AxisY.WholeRange.AlwaysShowZeroLevel = False
			Me.chart.Diagram = xyDiagram1
			Me.chart.Dock = System.Windows.Forms.DockStyle.Fill
			Me.chart.Legend.Name = "Default Legend"
			Me.chart.Legend.Visibility = DevExpress.Utils.DefaultBoolean.True
			Me.chart.Location = New System.Drawing.Point(0, 45)
			Me.chart.Name = "chart"
			Me.chart.PaletteRepository.Add("ColorizerPalette", New DevExpress.XtraCharts.Palette("ColorizerPalette", DevExpress.XtraCharts.PaletteScaleMode.Repeat, New DevExpress.XtraCharts.PaletteEntry() { New DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.FromArgb((CInt(Fix((CByte(255))))), (CInt(Fix((CByte(90))))), (CInt(Fix((CByte(25)))))), System.Drawing.Color.FromArgb((CInt(Fix((CByte(255))))), (CInt(Fix((CByte(90))))), (CInt(Fix((CByte(25))))))), New DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.FromArgb((CInt(Fix((CByte(254))))), (CInt(Fix((CByte(173))))), (CInt(Fix((CByte(45)))))), System.Drawing.Color.FromArgb((CInt(Fix((CByte(254))))), (CInt(Fix((CByte(173))))), (CInt(Fix((CByte(45))))))), New DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.FromArgb((CInt(Fix((CByte(229))))), (CInt(Fix((CByte(227))))), (CInt(Fix((CByte(53)))))), System.Drawing.Color.FromArgb((CInt(Fix((CByte(229))))), (CInt(Fix((CByte(227))))), (CInt(Fix((CByte(53))))))), New DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.FromArgb((CInt(Fix((CByte(172))))), (CInt(Fix((CByte(228))))), (CInt(Fix((CByte(92)))))), System.Drawing.Color.FromArgb((CInt(Fix((CByte(172))))), (CInt(Fix((CByte(228))))), (CInt(Fix((CByte(92))))))), New DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.FromArgb((CInt(Fix((CByte(110))))), (CInt(Fix((CByte(201))))), (CInt(Fix((CByte(92)))))), System.Drawing.Color.FromArgb((CInt(Fix((CByte(110))))), (CInt(Fix((CByte(201))))), (CInt(Fix((CByte(92)))))))}))
			bubbleSeriesLabel1.TextPattern = "{W:0,,.00} M"
			series1.Label = bubbleSeriesLabel1
			series1.Name = "Series 1"
			series1.ToolTipPointPattern = "{A}" & Constants.vbLf & "GDP per capita: {V:0.00}$" & Constants.vbLf & "Population: {W:0,,.00} M" & Constants.vbLf & "HPI: {HINT}"
			bubbleSeriesView1.MaxSize = 1.4R
			bubbleSeriesView1.MinSize = 0.6R
			xyMarkerSlideAnimation1.Direction = DevExpress.XtraCharts.XYMarkerSlideAnimationDirection.FromLeftTopCorner
			xyMarkerSlideAnimation1.Duration = System.TimeSpan.Parse("00:00:01.5000000")
			elasticEasingFunction1.EasingMode = DevExpress.XtraCharts.EasingMode.Out
			xyMarkerSlideAnimation1.EasingFunction = elasticEasingFunction1
			xyMarkerSlideAnimation1.PointDelay = System.TimeSpan.Parse("00:00:00.1000000")
			xyMarkerSlideAnimation1.PointOrder = DevExpress.XtraCharts.PointAnimationOrder.Random
			bubbleSeriesView1.SeriesPointAnimation = xyMarkerSlideAnimation1
			bubbleSeriesView1.Transparency = (CByte(90))
			series1.View = bubbleSeriesView1
			Me.chart.SeriesSerializable = New DevExpress.XtraCharts.Series() { series1}
			Me.chart.SeriesTemplate.View = bubbleSeriesView2
			Me.chart.Size = New System.Drawing.Size(700, 455)
			Me.chart.TabIndex = 2
			chartTitle1.Text = "Happy Planet Index for G20"
			Me.chart.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() { chartTitle1})
			Me.chart.ToolTipEnabled = DevExpress.Utils.DefaultBoolean.True
			' 
			' ColorizerDemo
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.chart)
			Me.Name = "ColorizerDemo"
			Me.Controls.SetChildIndex(Me.panelRoot, 0)
			Me.Controls.SetChildIndex(Me.chart, 0)
			CType(Me.panel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panel.ResumeLayout(False)
			CType(Me.checkEditShowLabels.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panelRoot.ResumeLayout(False)
			CType(xyDiagram1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(bubbleSeriesLabel1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(bubbleSeriesView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(series1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(bubbleSeriesView2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.chart, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private chart As ChartControl
	End Class
End Namespace
