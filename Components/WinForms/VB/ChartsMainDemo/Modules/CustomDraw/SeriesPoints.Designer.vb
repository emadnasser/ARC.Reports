Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.XtraCharts.Demos.CustomDraw
	Partial Public Class SeriesPointsDemo
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
			Dim xyDiagram1 As New DevExpress.XtraCharts.XYDiagram()
			Dim strip1 As New DevExpress.XtraCharts.Strip()
			Dim rectangleGradientFillOptions1 As New DevExpress.XtraCharts.RectangleGradientFillOptions()
			Dim strip2 As New DevExpress.XtraCharts.Strip()
			Dim rectangleGradientFillOptions2 As New DevExpress.XtraCharts.RectangleGradientFillOptions()
			Dim strip3 As New DevExpress.XtraCharts.Strip()
			Dim rectangleGradientFillOptions3 As New DevExpress.XtraCharts.RectangleGradientFillOptions()
			Dim series1 As New DevExpress.XtraCharts.Series()
			Dim sideBySideBarSeriesLabel1 As New DevExpress.XtraCharts.SideBySideBarSeriesLabel()
			Dim sideBySideBarSeriesView1 As New DevExpress.XtraCharts.SideBySideBarSeriesView()
			Dim barSlideAnimation1 As New DevExpress.XtraCharts.BarSlideAnimation()
			Dim bounceEasingFunction1 As New DevExpress.XtraCharts.BounceEasingFunction()
			Dim rectangleGradientFillOptions4 As New DevExpress.XtraCharts.RectangleGradientFillOptions()
			Me.chart = New DevExpress.XtraCharts.ChartControl()
			Me.simpleButtonRandom = New DevExpress.XtraEditors.SimpleButton()
			Me.checkEditCustomDraw = New DevExpress.XtraEditors.CheckEdit()
			CType(Me.panel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panel.SuspendLayout()
			CType(Me.checkEditShowLabels.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panelRoot.SuspendLayout()
			CType(Me.chart, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(xyDiagram1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(strip1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(strip2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(strip3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(series1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(sideBySideBarSeriesLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(sideBySideBarSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.checkEditCustomDraw.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' panel
			' 
			Me.panel.Controls.Add(Me.checkEditCustomDraw)
			Me.panel.Controls.Add(Me.simpleButtonRandom)
			Me.panel.Margin = New System.Windows.Forms.Padding(10, 9, 10, 9)
			Me.panel.Size = New System.Drawing.Size(700, 38)
			Me.panel.Controls.SetChildIndex(Me.checkEditShowLabels, 0)
			Me.panel.Controls.SetChildIndex(Me.simpleButtonRandom, 0)
			Me.panel.Controls.SetChildIndex(Me.checkEditCustomDraw, 0)
			' 
			' checkEditShowLabels
			' 
			Me.checkEditShowLabels.Location = New System.Drawing.Point(606, 9)
			Me.checkEditShowLabels.Size = New System.Drawing.Size(82, 19)
			Me.checkEditShowLabels.TabIndex = 3
			' 
			' panelRoot
			' 
			Me.panelRoot.Size = New System.Drawing.Size(700, 46)
			' 
			' chart
			' 
			Me.chart.DataBindings = Nothing
			xyDiagram1.AxisX.Title.Text = "Arguments"
			xyDiagram1.AxisX.VisibleInPanesSerializable = "-1"
			strip1.Color = System.Drawing.Color.FromArgb((CInt(Fix((CByte(255))))), (CInt(Fix((CByte(181))))), (CInt(Fix((CByte(181))))))
			strip1.FillStyle.FillMode = DevExpress.XtraCharts.FillMode.Gradient
			rectangleGradientFillOptions1.Color2 = System.Drawing.Color.FromArgb((CInt(Fix((CByte(255))))), (CInt(Fix((CByte(219))))), (CInt(Fix((CByte(219))))))
			rectangleGradientFillOptions1.GradientMode = DevExpress.XtraCharts.RectangleGradientMode.BottomToTop
			strip1.FillStyle.Options = rectangleGradientFillOptions1
			strip1.MaxLimit.AxisValueSerializable = "3"
			strip1.MinLimit.AxisValueSerializable = "2"
			strip1.Name = "High"
			strip1.ShowAxisLabel = True
			strip2.Color = System.Drawing.Color.FromArgb((CInt(Fix((CByte(255))))), (CInt(Fix((CByte(220))))), (CInt(Fix((CByte(113))))))
			strip2.FillStyle.FillMode = DevExpress.XtraCharts.FillMode.Gradient
			rectangleGradientFillOptions2.Color2 = System.Drawing.Color.FromArgb((CInt(Fix((CByte(254))))), (CInt(Fix((CByte(245))))), (CInt(Fix((CByte(190))))))
			rectangleGradientFillOptions2.GradientMode = DevExpress.XtraCharts.RectangleGradientMode.BottomToTop
			strip2.FillStyle.Options = rectangleGradientFillOptions2
			strip2.MaxLimit.AxisValueSerializable = "2"
			strip2.MinLimit.AxisValueSerializable = "1"
			strip2.Name = "Middle"
			strip2.ShowAxisLabel = True
			strip3.Color = System.Drawing.Color.FromArgb((CInt(Fix((CByte(192))))), (CInt(Fix((CByte(227))))), (CInt(Fix((CByte(125))))))
			strip3.FillStyle.FillMode = DevExpress.XtraCharts.FillMode.Gradient
			rectangleGradientFillOptions3.Color2 = System.Drawing.Color.FromArgb((CInt(Fix((CByte(214))))), (CInt(Fix((CByte(243))))), (CInt(Fix((CByte(159))))))
			rectangleGradientFillOptions3.GradientMode = DevExpress.XtraCharts.RectangleGradientMode.BottomToTop
			strip3.FillStyle.Options = rectangleGradientFillOptions3
			strip3.MaxLimit.AxisValueSerializable = "1"
			strip3.MinLimit.AxisValueSerializable = "0"
			strip3.Name = "Low"
			strip3.ShowAxisLabel = True
			xyDiagram1.AxisY.Strips.AddRange(New DevExpress.XtraCharts.Strip() { strip1, strip2, strip3})
			xyDiagram1.AxisY.Title.Text = "Values"
			xyDiagram1.AxisY.VisibleInPanesSerializable = "-1"
			xyDiagram1.AxisY.VisualRange.Auto = False
			xyDiagram1.AxisY.VisualRange.MaxValueSerializable = "3"
			xyDiagram1.AxisY.VisualRange.MinValueSerializable = "0"
			xyDiagram1.AxisY.WholeRange.Auto = False
			xyDiagram1.AxisY.WholeRange.AutoSideMargins = False
			xyDiagram1.AxisY.WholeRange.MaxValueSerializable = "3"
			xyDiagram1.AxisY.WholeRange.MinValueSerializable = "0"
			xyDiagram1.AxisY.WholeRange.SideMarginsValue = 0R
			Me.chart.Diagram = xyDiagram1
			Me.chart.Dock = System.Windows.Forms.DockStyle.Fill
			Me.chart.Legend.Name = "Default Legend"
			Me.chart.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False
			Me.chart.Location = New System.Drawing.Point(0, 46)
			Me.chart.Name = "chart"
			sideBySideBarSeriesLabel1.TextPattern = "{V:F1}"
			series1.Label = sideBySideBarSeriesLabel1
			series1.Name = "Series 1"
			barSlideAnimation1.Direction = DevExpress.XtraCharts.AnimationDirection.FromTop
			bounceEasingFunction1.EasingMode = DevExpress.XtraCharts.EasingMode.Out
			barSlideAnimation1.EasingFunction = bounceEasingFunction1
			barSlideAnimation1.PointDelay = System.TimeSpan.Parse("00:00:00.0500000")
			barSlideAnimation1.PointOrder = DevExpress.XtraCharts.PointAnimationOrder.Random
			sideBySideBarSeriesView1.Animation = barSlideAnimation1
			sideBySideBarSeriesView1.Color = System.Drawing.Color.DodgerBlue
			sideBySideBarSeriesView1.FillStyle.FillMode = DevExpress.XtraCharts.FillMode.Gradient
			rectangleGradientFillOptions4.GradientMode = DevExpress.XtraCharts.RectangleGradientMode.RightToLeft
			sideBySideBarSeriesView1.FillStyle.Options = rectangleGradientFillOptions4
			series1.View = sideBySideBarSeriesView1
			Me.chart.SeriesSerializable = New DevExpress.XtraCharts.Series() { series1}
			Me.chart.Size = New System.Drawing.Size(700, 454)
			Me.chart.TabIndex = 1
			Me.chart.TabStop = False
'			Me.chart.CustomDrawSeriesPoint += New DevExpress.XtraCharts.CustomDrawSeriesPointEventHandler(Me.chart_CustomDrawSeriesPoint);
			' 
			' simpleButtonRandom
			' 
			Me.simpleButtonRandom.Location = New System.Drawing.Point(12, 8)
			Me.simpleButtonRandom.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.UltraFlat
			Me.simpleButtonRandom.Margin = New System.Windows.Forms.Padding(0, 0, 10, 0)
			Me.simpleButtonRandom.Name = "simpleButtonRandom"
			Me.simpleButtonRandom.Size = New System.Drawing.Size(85, 22)
			Me.simpleButtonRandom.TabIndex = 0
			Me.simpleButtonRandom.Text = "Create Bars"
'			Me.simpleButtonRandom.Click += New System.EventHandler(Me.simpleButtonRandom_Click);
			' 
			' checkEditCustomDraw
			' 
			Me.checkEditCustomDraw.Location = New System.Drawing.Point(120, 9)
			Me.checkEditCustomDraw.Margin = New System.Windows.Forms.Padding(10)
			Me.checkEditCustomDraw.Name = "checkEditCustomDraw"
			Me.checkEditCustomDraw.Properties.Caption = "Custom Draw"
			Me.checkEditCustomDraw.Size = New System.Drawing.Size(98, 19)
			Me.checkEditCustomDraw.TabIndex = 1
'			Me.checkEditCustomDraw.CheckedChanged += New System.EventHandler(Me.checkEditCustomDraw_CheckedChanged);
			' 
			' SeriesPointsDemo
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.chart)
			Me.Name = "SeriesPointsDemo"
			Me.Controls.SetChildIndex(Me.panelRoot, 0)
			Me.Controls.SetChildIndex(Me.chart, 0)
			CType(Me.panel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panel.ResumeLayout(False)
			CType(Me.checkEditShowLabels.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panelRoot.ResumeLayout(False)
			CType(strip1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(strip2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(strip3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(xyDiagram1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(sideBySideBarSeriesLabel1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(sideBySideBarSeriesView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(series1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.chart, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.checkEditCustomDraw.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub
		#End Region

		Private WithEvents chart As DevExpress.XtraCharts.ChartControl
		Private WithEvents simpleButtonRandom As DevExpress.XtraEditors.SimpleButton
		Private WithEvents checkEditCustomDraw As DevExpress.XtraEditors.CheckEdit
		Private components As System.ComponentModel.IContainer = Nothing

	End Class
End Namespace
