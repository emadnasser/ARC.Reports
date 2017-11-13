Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.XtraCharts.Demos.CustomDraw
	Partial Public Class PolarDiagramCustomPaintDemo
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
			Dim polarDiagram1 As New DevExpress.XtraCharts.PolarDiagram()
			Dim series1 As New DevExpress.XtraCharts.Series()
			Dim radarPointSeriesLabel1 As New DevExpress.XtraCharts.RadarPointSeriesLabel()
			Dim polarPointSeriesView1 As New DevExpress.XtraCharts.PolarPointSeriesView()
			Dim polarPointSeriesView2 As New DevExpress.XtraCharts.PolarPointSeriesView()
			Dim chartTitle1 As New DevExpress.XtraCharts.ChartTitle()
			Me.chart = New DevExpress.XtraCharts.ChartControl()
			Me.timer = New System.Windows.Forms.Timer(Me.components)
			CType(Me.panel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panel.SuspendLayout()
			CType(Me.checkEditShowLabels.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panelRoot.SuspendLayout()
			CType(Me.chart, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(polarDiagram1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(series1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(radarPointSeriesLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(polarPointSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(polarPointSeriesView2, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' panel
			' 
			Me.panel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
			Me.panel.Size = New System.Drawing.Size(700, 38)
			' 
			' checkEditShowLabels
			' 
			Me.checkEditShowLabels.Location = New System.Drawing.Point(609, 9)
			Me.checkEditShowLabels.Size = New System.Drawing.Size(82, 19)
			' 
			' panelRoot
			' 
			Me.panelRoot.Size = New System.Drawing.Size(700, 46)
			Me.panelRoot.Visible = False
			' 
			' chart
			' 
			Me.chart.CacheToMemory = True
			Me.chart.DataBindings = Nothing
			polarDiagram1.AxisX.Interlaced = True
			polarDiagram1.AxisY.Visible = False
			polarDiagram1.AxisY.VisualRange.Auto = False
			polarDiagram1.AxisY.VisualRange.MaxValueSerializable = "20"
			polarDiagram1.AxisY.VisualRange.MinValueSerializable = "0"
			polarDiagram1.AxisY.WholeRange.Auto = False
			polarDiagram1.AxisY.WholeRange.MaxValueSerializable = "20"
			polarDiagram1.AxisY.WholeRange.MinValueSerializable = "0"
			Me.chart.Diagram = polarDiagram1
			Me.chart.Dock = System.Windows.Forms.DockStyle.Fill
			Me.chart.Legend.MaxHorizontalPercentage = 30R
			Me.chart.Legend.Name = "Default Legend"
			Me.chart.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False
			Me.chart.Location = New System.Drawing.Point(0, 46)
			Me.chart.Name = "chart"
			series1.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Numerical
			radarPointSeriesLabel1.Font = New System.Drawing.Font("Tahoma", 6F)
			radarPointSeriesLabel1.ResolveOverlappingMode = DevExpress.XtraCharts.ResolveOverlappingMode.HideOverlapped
			series1.Label = radarPointSeriesLabel1
			series1.Name = "Random Series"
			series1.View = polarPointSeriesView1
			Me.chart.SeriesSerializable = New DevExpress.XtraCharts.Series() { series1}
			Me.chart.SeriesTemplate.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Numerical
			Me.chart.SeriesTemplate.View = polarPointSeriesView2
			Me.chart.Size = New System.Drawing.Size(700, 454)
			Me.chart.TabIndex = 2
			chartTitle1.Text = "Hit the Target"
			Me.chart.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() { chartTitle1})
'			Me.chart.CustomPaint += New DevExpress.XtraCharts.CustomPaintEventHandler(Me.chart_CustomPaint);
'			Me.chart.MouseDown += New System.Windows.Forms.MouseEventHandler(Me.chart_MouseDown);
			' 
			' timer
			' 
'			Me.timer.Tick += New System.EventHandler(Me.timer_Tick);
			' 
			' PolarDiagramCustomPaintDemo
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.chart)
			Me.Name = "PolarDiagramCustomPaintDemo"
			Me.Controls.SetChildIndex(Me.panelRoot, 0)
			Me.Controls.SetChildIndex(Me.chart, 0)
			CType(Me.panel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panel.ResumeLayout(False)
			CType(Me.checkEditShowLabels.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panelRoot.ResumeLayout(False)
			CType(polarDiagram1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(radarPointSeriesLabel1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(polarPointSeriesView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(series1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(polarPointSeriesView2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.chart, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private WithEvents chart As ChartControl
		Private WithEvents timer As System.Windows.Forms.Timer

	End Class
End Namespace
