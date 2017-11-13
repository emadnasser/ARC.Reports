Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.XtraCharts.Demos.RadarPolarViews
	Partial Public Class ScatterRadarLineDemo
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
			Dim radarDiagram1 As New DevExpress.XtraCharts.RadarDiagram()
			Dim series1 As New DevExpress.XtraCharts.Series()
			Dim radarPointSeriesLabel1 As New DevExpress.XtraCharts.RadarPointSeriesLabel()
			Dim scatterRadarLineSeriesView1 As New DevExpress.XtraCharts.ScatterRadarLineSeriesView()
			Dim circularSeriesSpinZoomInAnimation1 As New DevExpress.XtraCharts.CircularSeriesSpinZoomInAnimation()
			Dim exponentialEasingFunction1 As New DevExpress.XtraCharts.ExponentialEasingFunction()
			Dim chartTitle1 As New DevExpress.XtraCharts.ChartTitle()
			Dim chartTitle2 As New DevExpress.XtraCharts.ChartTitle()
			Me.chart = New DevExpress.XtraCharts.ChartControl()
			Me.checkEditShowMarkers = New DevExpress.XtraEditors.CheckEdit()
			Me.comboBoxEditFunctionType = New DevExpress.XtraEditors.ComboBoxEdit()
			Me.labelFunction = New DevExpress.XtraEditors.LabelControl()
			CType(Me.comboBoxEditMarkerKind.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.comboBoxEditMarkerSize.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.comboBoxEditDiagramStyle.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.panel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panel.SuspendLayout()
			CType(Me.checkEditShowLabels.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panelRoot.SuspendLayout()
			CType(Me.chart, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(radarDiagram1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(series1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(radarPointSeriesLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(scatterRadarLineSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.checkEditShowMarkers.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.comboBoxEditFunctionType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' comboBoxEditMarkerKind
			' 
			' 
			' comboBoxEditMarkerSize
			' 
			' 
			' comboBoxEditDiagramStyle
			' 
			' 
			' panel
			' 
			Me.panel.Controls.Add(Me.comboBoxEditFunctionType)
			Me.panel.Controls.Add(Me.labelFunction)
			Me.panel.Controls.Add(Me.checkEditShowMarkers)
			Me.panel.Controls.SetChildIndex(Me.comboBoxEditMarkerSize, 0)
			Me.panel.Controls.SetChildIndex(Me.comboBoxEditDiagramStyle, 0)
			Me.panel.Controls.SetChildIndex(Me.comboBoxEditMarkerKind, 0)
			Me.panel.Controls.SetChildIndex(Me.checkEditShowLabels, 0)
			Me.panel.Controls.SetChildIndex(Me.checkEditShowMarkers, 0)
			Me.panel.Controls.SetChildIndex(Me.labelFunction, 0)
			Me.panel.Controls.SetChildIndex(Me.comboBoxEditFunctionType, 0)
			' 
			' checkEditShowLabels
			' 
			Me.checkEditShowLabels.Location = New System.Drawing.Point(602, 37)
			Me.checkEditShowLabels.Size = New System.Drawing.Size(82, 19)
			Me.checkEditShowLabels.TabIndex = 6
			' 
			' chart
			' 
			Me.chart.DataBindings = Nothing
			radarDiagram1.AxisX.GridLines.MinorVisible = True
			radarDiagram1.AxisX.Label.TextPattern = "{A:0.##}"
			radarDiagram1.AxisX.NumericScaleOptions.AutoGrid = False
			radarDiagram1.AxisX.NumericScaleOptions.GridSpacing = 0.523598R
			radarDiagram1.AxisX.WholeRange.Auto = False
			radarDiagram1.AxisX.WholeRange.AutoSideMargins = False
			radarDiagram1.AxisX.WholeRange.MaxValueSerializable = "6.28"
			radarDiagram1.AxisX.WholeRange.MinValueSerializable = "0"
			radarDiagram1.AxisX.WholeRange.SideMarginsValue = 0R
			radarDiagram1.AxisY.GridLines.MinorVisible = True
			radarDiagram1.StartAngleInDegrees = 270R
			Me.chart.Diagram = radarDiagram1
			Me.chart.Dock = System.Windows.Forms.DockStyle.Fill
			Me.chart.Legend.Name = "Default Legend"
			Me.chart.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False
			Me.chart.Location = New System.Drawing.Point(0, 74)
			Me.chart.Name = "chart"
			radarPointSeriesLabel1.ResolveOverlappingMode = DevExpress.XtraCharts.ResolveOverlappingMode.HideOverlapped
			radarPointSeriesLabel1.TextPattern = "{V:N2}"
			series1.Label = radarPointSeriesLabel1
			series1.Name = "Function"
			series1.ToolTipPointPattern = "{A:F2}: {V:F2}"
			scatterRadarLineSeriesView1.Closed = False
			scatterRadarLineSeriesView1.MarkerVisibility = DevExpress.Utils.DefaultBoolean.False
			exponentialEasingFunction1.EasingMode = DevExpress.XtraCharts.EasingMode.Out
			exponentialEasingFunction1.Exponent = 5R
			circularSeriesSpinZoomInAnimation1.EasingFunction = exponentialEasingFunction1
			scatterRadarLineSeriesView1.SeriesAnimation = circularSeriesSpinZoomInAnimation1
			series1.View = scatterRadarLineSeriesView1
			Me.chart.SeriesSerializable = New DevExpress.XtraCharts.Series() { series1}
			Me.chart.Size = New System.Drawing.Size(700, 426)
			Me.chart.TabIndex = 1
			Me.chart.TabStop = False
			chartTitle1.Text = "Function in Polar Coordinates"
			chartTitle2.Alignment = System.Drawing.StringAlignment.Far
			chartTitle2.Dock = DevExpress.XtraCharts.ChartTitleDockStyle.Bottom
			chartTitle2.Font = New System.Drawing.Font("Tahoma", 8F)
			chartTitle2.Text = ""
			chartTitle2.TextColor = System.Drawing.Color.Gray
			Me.chart.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() { chartTitle1, chartTitle2})
			' 
			' checkEditShowMarkers
			' 
			Me.checkEditShowMarkers.Anchor = (CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.checkEditShowMarkers.Location = New System.Drawing.Point(602, 9)
			Me.checkEditShowMarkers.Margin = New System.Windows.Forms.Padding(0)
			Me.checkEditShowMarkers.Name = "checkEditShowMarkers"
			Me.checkEditShowMarkers.Properties.Caption = "Show markers"
			Me.checkEditShowMarkers.Size = New System.Drawing.Size(88, 19)
			Me.checkEditShowMarkers.TabIndex = 5
'			Me.checkEditShowMarkers.CheckedChanged += New System.EventHandler(Me.checkEditShowMarkers_CheckedChanged);
			' 
			' comboBoxEditFunctionType
			' 
			Me.comboBoxEditFunctionType.EditValue = ""
			Me.comboBoxEditFunctionType.Location = New System.Drawing.Point(245, 9)
			Me.comboBoxEditFunctionType.Margin = New System.Windows.Forms.Padding(0, 0, 10, 10)
			Me.comboBoxEditFunctionType.Name = "comboBoxEditFunctionType"
			Me.comboBoxEditFunctionType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.comboBoxEditFunctionType.Properties.Items.AddRange(New Object() { "Archimedean Spiral", "Polar Rose", "Polar Folium"})
			Me.comboBoxEditFunctionType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
			Me.comboBoxEditFunctionType.Size = New System.Drawing.Size(80, 20)
			Me.comboBoxEditFunctionType.TabIndex = 4
'			Me.comboBoxEditFunctionType.SelectedIndexChanged += New System.EventHandler(Me.comboBoxEditFunctionType_SelectedIndexChanged);
			' 
			' labelFunction
			' 
			Me.labelFunction.Location = New System.Drawing.Point(173, 12)
			Me.labelFunction.Margin = New System.Windows.Forms.Padding(7)
			Me.labelFunction.Name = "labelFunction"
			Me.labelFunction.Size = New System.Drawing.Size(45, 13)
			Me.labelFunction.TabIndex = 8
			Me.labelFunction.Text = "Function:"
			' 
			' ScatterRadarLineDemo
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.chart)
			Me.Name = "ScatterRadarLineDemo"
			Me.Controls.SetChildIndex(Me.panelRoot, 0)
			Me.Controls.SetChildIndex(Me.chart, 0)
			CType(Me.comboBoxEditMarkerKind.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.comboBoxEditMarkerSize.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.comboBoxEditDiagramStyle.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.panel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panel.ResumeLayout(False)
			Me.panel.PerformLayout()
			CType(Me.checkEditShowLabels.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panelRoot.ResumeLayout(False)
			CType(radarDiagram1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(radarPointSeriesLabel1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(scatterRadarLineSeriesView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(series1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.chart, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.checkEditShowMarkers.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.comboBoxEditFunctionType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region
		Private components As System.ComponentModel.IContainer = Nothing
		Private WithEvents checkEditShowMarkers As DevExpress.XtraEditors.CheckEdit
		Private WithEvents comboBoxEditFunctionType As DevExpress.XtraEditors.ComboBoxEdit
		Private labelFunction As DevExpress.XtraEditors.LabelControl
	End Class
End Namespace
