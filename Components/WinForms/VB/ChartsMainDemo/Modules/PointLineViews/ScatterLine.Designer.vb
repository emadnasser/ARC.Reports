Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.XtraCharts.Demos.PointLineViews
	Partial Public Class ScatterLineDemo
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

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Dim xyDiagram1 As New DevExpress.XtraCharts.XYDiagram()
			Dim series1 As New DevExpress.XtraCharts.Series()
			Dim pointSeriesLabel1 As New DevExpress.XtraCharts.PointSeriesLabel()
			Dim scatterLineSeriesView1 As New DevExpress.XtraCharts.ScatterLineSeriesView()
			Dim xySeriesBlowUpAnimation1 As New DevExpress.XtraCharts.XYSeriesBlowUpAnimation()
			Dim xyMarkerSlideAnimation1 As New DevExpress.XtraCharts.XYMarkerSlideAnimation()
			Dim series2 As New DevExpress.XtraCharts.Series()
			Dim pointSeriesLabel2 As New DevExpress.XtraCharts.PointSeriesLabel()
			Dim scatterLineSeriesView2 As New DevExpress.XtraCharts.ScatterLineSeriesView()
			Dim xySeriesBlowUpAnimation2 As New DevExpress.XtraCharts.XYSeriesBlowUpAnimation()
			Dim xyMarkerSlideAnimation2 As New DevExpress.XtraCharts.XYMarkerSlideAnimation()
			Dim series3 As New DevExpress.XtraCharts.Series()
			Dim pointSeriesLabel3 As New DevExpress.XtraCharts.PointSeriesLabel()
			Dim scatterLineSeriesView3 As New DevExpress.XtraCharts.ScatterLineSeriesView()
			Dim xySeriesBlowUpAnimation3 As New DevExpress.XtraCharts.XYSeriesBlowUpAnimation()
			Dim xyMarkerSlideAnimation3 As New DevExpress.XtraCharts.XYMarkerSlideAnimation()
			Dim chartTitle1 As New DevExpress.XtraCharts.ChartTitle()
			Me.chart = New DevExpress.XtraCharts.ChartControl()
			Me.lbThickness = New DevExpress.XtraEditors.LabelControl()
			Me.comboBoxEditFunctionType = New DevExpress.XtraEditors.ComboBoxEdit()
			CType(Me.checkEditShowMarkers.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.comboBoxEditMarkerKind.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.comboBoxEditLabelAngle.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.comboBoxEditMarkerSize.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.panel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panel.SuspendLayout()
			CType(Me.checkEditShowLabels.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panelRoot.SuspendLayout()
			CType(Me.chart, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(xyDiagram1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(series1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(pointSeriesLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(scatterLineSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(series2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(pointSeriesLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(scatterLineSeriesView2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(series3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(pointSeriesLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(scatterLineSeriesView3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.comboBoxEditFunctionType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' checkEditShowMarkers
			' 
			Me.checkEditShowMarkers.TabIndex = 3
			' 
			' comboBoxEditMarkerKind
			' 
			Me.comboBoxEditMarkerKind.TabIndex = 0
			' 
			' comboBoxEditLabelAngle
			' 
			Me.comboBoxEditLabelAngle.Visible = False
			' 
			' comboBoxEditMarkerSize
			' 
			Me.comboBoxEditMarkerSize.TabIndex = 1
			' 
			' labelAngle
			' 
			Me.labelAngle.Visible = False
			' 
			' panel
			' 
			Me.panel.Controls.Add(Me.comboBoxEditFunctionType)
			Me.panel.Controls.Add(Me.lbThickness)
			Me.panel.Controls.SetChildIndex(Me.comboBoxEditMarkerSize, 0)
			Me.panel.Controls.SetChildIndex(Me.comboBoxEditMarkerKind, 0)
			Me.panel.Controls.SetChildIndex(Me.comboBoxEditLabelAngle, 0)
			Me.panel.Controls.SetChildIndex(Me.labelAngle, 0)
			Me.panel.Controls.SetChildIndex(Me.labelMarkerKind, 0)
			Me.panel.Controls.SetChildIndex(Me.labelMarkerSize, 0)
			Me.panel.Controls.SetChildIndex(Me.checkEditShowLabels, 0)
			Me.panel.Controls.SetChildIndex(Me.checkEditShowMarkers, 0)
			Me.panel.Controls.SetChildIndex(Me.lbThickness, 0)
			Me.panel.Controls.SetChildIndex(Me.comboBoxEditFunctionType, 0)
			' 
			' checkEditShowLabels
			' 
			Me.checkEditShowLabels.TabIndex = 4
			' 
			' chart
			' 
			Me.chart.CrosshairEnabled = DevExpress.Utils.DefaultBoolean.False
			Me.chart.DataBindings = Nothing
			xyDiagram1.AxisX.Alignment = DevExpress.XtraCharts.AxisAlignment.Zero
			xyDiagram1.AxisX.GridLines.MinorVisible = True
			xyDiagram1.AxisX.GridLines.Visible = True
			xyDiagram1.AxisX.Tickmarks.CrossAxis = True
			xyDiagram1.AxisX.Title.Text = "Arguments"
			xyDiagram1.AxisX.VisibleInPanesSerializable = "-1"
			xyDiagram1.AxisY.Alignment = DevExpress.XtraCharts.AxisAlignment.Zero
			xyDiagram1.AxisY.GridLines.MinorVisible = True
			xyDiagram1.AxisY.Tickmarks.CrossAxis = True
			xyDiagram1.AxisY.Title.Text = "Values"
			xyDiagram1.AxisY.VisibleInPanesSerializable = "-1"
			xyDiagram1.LabelsResolveOverlappingMinIndent = 3
			Me.chart.Diagram = xyDiagram1
			Me.chart.Dock = System.Windows.Forms.DockStyle.Fill
			Me.chart.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Right
			Me.chart.Legend.Name = "Default Legend"
			Me.chart.Location = New System.Drawing.Point(0, 74)
			Me.chart.Name = "chart"
			series1.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Numerical
			pointSeriesLabel1.ResolveOverlappingMode = DevExpress.XtraCharts.ResolveOverlappingMode.HideOverlapped
			pointSeriesLabel1.TextPattern = "{V:F1}"
			series1.Label = pointSeriesLabel1
			series1.LabelsVisibility = DevExpress.Utils.DefaultBoolean.False
			series1.Name = "Archimedean Spiral"
			scatterLineSeriesView1.LineMarkerOptions.Size = 8
			scatterLineSeriesView1.SeriesAnimation = xySeriesBlowUpAnimation1
			xyMarkerSlideAnimation1.BeginTime = System.TimeSpan.Parse("00:00:01.2000000")
			xyMarkerSlideAnimation1.Direction = DevExpress.XtraCharts.XYMarkerSlideAnimationDirection.FromLeftTopCorner
			scatterLineSeriesView1.SeriesPointAnimation = xyMarkerSlideAnimation1
			series1.View = scatterLineSeriesView1
			series2.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Numerical
			pointSeriesLabel2.ResolveOverlappingMode = DevExpress.XtraCharts.ResolveOverlappingMode.HideOverlapped
			pointSeriesLabel2.TextPattern = "{V:F1}"
			series2.Label = pointSeriesLabel2
			series2.LabelsVisibility = DevExpress.Utils.DefaultBoolean.False
			series2.Name = "Cardioid"
			scatterLineSeriesView2.LineMarkerOptions.Size = 8
			scatterLineSeriesView2.SeriesAnimation = xySeriesBlowUpAnimation2
			xyMarkerSlideAnimation2.BeginTime = System.TimeSpan.Parse("00:00:01.2000000")
			xyMarkerSlideAnimation2.Direction = DevExpress.XtraCharts.XYMarkerSlideAnimationDirection.FromLeftTopCorner
			scatterLineSeriesView2.SeriesPointAnimation = xyMarkerSlideAnimation2
			series2.View = scatterLineSeriesView2
			series3.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Numerical
			pointSeriesLabel3.ResolveOverlappingMode = DevExpress.XtraCharts.ResolveOverlappingMode.HideOverlapped
			pointSeriesLabel3.TextPattern = "{V:F1}"
			series3.Label = pointSeriesLabel3
			series3.Name = "Cartesian Folium"
			scatterLineSeriesView3.LineMarkerOptions.Size = 8
			scatterLineSeriesView3.SeriesAnimation = xySeriesBlowUpAnimation3
			xyMarkerSlideAnimation3.BeginTime = System.TimeSpan.Parse("00:00:01.2000000")
			xyMarkerSlideAnimation3.Direction = DevExpress.XtraCharts.XYMarkerSlideAnimationDirection.FromLeftTopCorner
			scatterLineSeriesView3.SeriesPointAnimation = xyMarkerSlideAnimation3
			series3.View = scatterLineSeriesView3
			Me.chart.SeriesSerializable = New DevExpress.XtraCharts.Series() { series1, series2, series3}
			Me.chart.Size = New System.Drawing.Size(700, 426)
			Me.chart.TabIndex = 2
			Me.chart.TabStop = False
			chartTitle1.Text = "Function in Cartesian Coordinates"
			Me.chart.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() { chartTitle1})
			Me.chart.ToolTipEnabled = DevExpress.Utils.DefaultBoolean.True
			' 
			' lbThickness
			' 
			Me.lbThickness.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
			Me.lbThickness.Location = New System.Drawing.Point(193, 9)
			Me.lbThickness.Name = "lbThickness"
			Me.lbThickness.Size = New System.Drawing.Size(50, 20)
			Me.lbThickness.TabIndex = 59
			Me.lbThickness.Text = "Function:"
			' 
			' comboBoxEditFunctionType
			' 
			Me.comboBoxEditFunctionType.EditValue = ""
			Me.comboBoxEditFunctionType.Location = New System.Drawing.Point(241, 9)
			Me.comboBoxEditFunctionType.Margin = New System.Windows.Forms.Padding(0, 0, 10, 10)
			Me.comboBoxEditFunctionType.Name = "comboBoxEditFunctionType"
			Me.comboBoxEditFunctionType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.comboBoxEditFunctionType.Properties.Items.AddRange(New Object() { "Archimedean Spiral", "Cardioid", "Cartesian Folium"})
			Me.comboBoxEditFunctionType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
			Me.comboBoxEditFunctionType.Size = New System.Drawing.Size(147, 20)
			Me.comboBoxEditFunctionType.TabIndex = 2
'			Me.comboBoxEditFunctionType.SelectedIndexChanged += New System.EventHandler(Me.comboBoxEditFunctionType_SelectedIndexChanged);
			' 
			' ScatterLineDemo
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.chart)
			Me.Name = "ScatterLineDemo"
			Me.Controls.SetChildIndex(Me.panelRoot, 0)
			Me.Controls.SetChildIndex(Me.chart, 0)
			CType(Me.checkEditShowMarkers.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.comboBoxEditMarkerKind.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.comboBoxEditLabelAngle.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.comboBoxEditMarkerSize.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.panel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panel.ResumeLayout(False)
			Me.panel.PerformLayout()
			CType(Me.checkEditShowLabels.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panelRoot.ResumeLayout(False)
			CType(xyDiagram1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(pointSeriesLabel1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(scatterLineSeriesView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(series1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(pointSeriesLabel2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(scatterLineSeriesView2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(series2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(pointSeriesLabel3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(scatterLineSeriesView3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(series3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.chart, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.comboBoxEditFunctionType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private chart As ChartControl
		Private lbThickness As DevExpress.XtraEditors.LabelControl
		Protected WithEvents comboBoxEditFunctionType As DevExpress.XtraEditors.ComboBoxEdit
	End Class
End Namespace
