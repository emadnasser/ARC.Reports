Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.XtraCharts.Demos.PointLineViews
	Partial Public Class StackedLine3dDemo
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
			Dim xyDiagram3D1 As New DevExpress.XtraCharts.XYDiagram3D()
			Dim stackedLine3DSeriesLabel1 As New DevExpress.XtraCharts.StackedLine3DSeriesLabel()
			Dim stackedLine3DSeriesView1 As New DevExpress.XtraCharts.StackedLine3DSeriesView()
			Dim chartTitle1 As New DevExpress.XtraCharts.ChartTitle()
			Me.chart = New DevExpress.XtraCharts.ChartControl()
			Me.labelPerspective = New DevExpress.XtraEditors.LabelControl()
			CType(Me.panel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panel.SuspendLayout()
			CType(Me.checkEditShowLabels.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panelRoot.SuspendLayout()
			CType(Me.chart, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(xyDiagram3D1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(stackedLine3DSeriesLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(stackedLine3DSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' panel
			' 
			Me.panel.Controls.Add(Me.labelPerspective)
			Me.panel.Controls.SetChildIndex(Me.btnDefaultAngles, 0)
			Me.panel.Controls.SetChildIndex(Me.checkEditShowLabels, 0)
			Me.panel.Controls.SetChildIndex(Me.labelPerspective, 0)
			' 
			' checkEditShowLabels
			' 
			' 
			' chart
			' 
			Me.chart.DataBindings = Nothing
			xyDiagram3D1.AxisX.DateTimeScaleOptions.MeasureUnit = DevExpress.XtraCharts.DateTimeMeasureUnit.Year
			xyDiagram3D1.AxisY.Label.TextPattern = "${V}M"
			xyDiagram3D1.RotationMatrixSerializable = "0.766044443118978;-0.219846310392954;0.604022773555054;0;0;0.939692620785908;0.34" & "2020143325669;0;-0.642787609686539;-0.262002630229385;0.719846310392954;0;0;0;0;" & "1"
			xyDiagram3D1.RuntimeRotation = True
			xyDiagram3D1.RuntimeScrolling = True
			xyDiagram3D1.RuntimeZooming = True
			xyDiagram3D1.VerticalScrollPercent = 4R
			xyDiagram3D1.ZoomPercent = 130
			Me.chart.Diagram = xyDiagram3D1
			Me.chart.Dock = System.Windows.Forms.DockStyle.Fill
			Me.chart.Legend.Direction = DevExpress.XtraCharts.LegendDirection.BottomToTop
			Me.chart.Legend.Name = "Default Legend"
			Me.chart.Location = New System.Drawing.Point(0, 46)
			Me.chart.Name = "chart"
			Me.chart.SeriesDataMember = "Region"
			Me.chart.SeriesSerializable = New DevExpress.XtraCharts.Series(){}
			Me.chart.SeriesSorting = DevExpress.XtraCharts.SortingMode.Descending
			Me.chart.SeriesTemplate.ArgumentDataMember = "Year"
			Me.chart.SeriesTemplate.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.DateTime
			stackedLine3DSeriesLabel1.TextPattern = "${V}M"
			Me.chart.SeriesTemplate.Label = stackedLine3DSeriesLabel1
			Me.chart.SeriesTemplate.ValueDataMembersSerializable = "Sales"
			Me.chart.SeriesTemplate.View = stackedLine3DSeriesView1
			Me.chart.Size = New System.Drawing.Size(700, 454)
			Me.chart.TabIndex = 1
			chartTitle1.Text = "DevAV Sales"
			Me.chart.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() { chartTitle1})
			' 
			' labelPerspective
			' 
			Me.labelPerspective.Location = New System.Drawing.Point(12, 12)
			Me.labelPerspective.Margin = New System.Windows.Forms.Padding(0, 10, 3, 10)
			Me.labelPerspective.Name = "labelPerspective"
			Me.labelPerspective.Size = New System.Drawing.Size(90, 13)
			Me.labelPerspective.TabIndex = 13
			Me.labelPerspective.Text = "Perspective Angle:"
			' 
			' StackedLine3dDemo
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.chart)
			Me.Name = "StackedLine3dDemo"
			Me.Controls.SetChildIndex(Me.panelRoot, 0)
			Me.Controls.SetChildIndex(Me.chart, 0)
			CType(Me.panel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panel.ResumeLayout(False)
			Me.panel.PerformLayout()
			CType(Me.checkEditShowLabels.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panelRoot.ResumeLayout(False)
			CType(xyDiagram3D1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(stackedLine3DSeriesLabel1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(stackedLine3DSeriesView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.chart, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region
		Private components As System.ComponentModel.IContainer = Nothing
		Private labelPerspective As DevExpress.XtraEditors.LabelControl

	End Class
End Namespace
