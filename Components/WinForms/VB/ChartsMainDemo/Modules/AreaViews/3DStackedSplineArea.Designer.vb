Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.XtraCharts.Demos.AreaViews
	Partial Public Class StackedSplineArea3dDemo
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
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(StackedSplineArea3dDemo))
			Dim xyDiagram3D1 As New DevExpress.XtraCharts.XYDiagram3D()
			Dim stackedArea3DSeriesLabel1 As New DevExpress.XtraCharts.StackedArea3DSeriesLabel()
			Dim stackedSplineArea3DSeriesView1 As New DevExpress.XtraCharts.StackedSplineArea3DSeriesView()
			Dim chartTitle1 As New DevExpress.XtraCharts.ChartTitle()
			Me.chart = New DevExpress.XtraCharts.ChartControl()
			CType(Me.comboTransparencies.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.comboBoxEditPerspective.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.panel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panel.SuspendLayout()
			CType(Me.checkEditShowLabels.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panelRoot.SuspendLayout()
			CType(Me.chart, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(xyDiagram3D1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(stackedArea3DSeriesLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(stackedSplineArea3DSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' comboTransparencies
			' 
			' 
			' comboBoxEditPerspective
			' 
			resources.ApplyResources(Me.comboBoxEditPerspective, "comboBoxEditPerspective")
			' 
			' checkEditShowLabels
			' 
			' 
			' chart
			' 
			Me.chart.DataBindings = Nothing
			xyDiagram3D1.AxisX.DateTimeScaleOptions.MeasureUnit = DevExpress.XtraCharts.DateTimeMeasureUnit.Year
			xyDiagram3D1.AxisX.WholeRange.AutoSideMargins = False
			xyDiagram3D1.AxisX.WholeRange.SideMarginsValue = 0R
			xyDiagram3D1.AxisY.Interlaced = False
			xyDiagram3D1.AxisY.Label.TextPattern = "${V}M"
			xyDiagram3D1.AxisY.MinorCount = 2
			xyDiagram3D1.RotationMatrixSerializable = "0.766044443118978;-0.219846310392954;0.604022773555054;0;0;0.939692620785908;0.34" & "2020143325669;0;-0.642787609686539;-0.262002630229385;0.719846310392954;0;0;0;0;" & "1"
			xyDiagram3D1.RuntimeRotation = True
			xyDiagram3D1.RuntimeScrolling = True
			xyDiagram3D1.RuntimeZooming = True
			xyDiagram3D1.VerticalScrollPercent = 6R
			xyDiagram3D1.ZoomPercent = 140
			Me.chart.Diagram = xyDiagram3D1
			resources.ApplyResources(Me.chart, "chart")
			Me.chart.Legend.Name = "Default Legend"
			Me.chart.Name = "chart"
			Me.chart.SeriesDataMember = "Region"
			Me.chart.SeriesSerializable = New DevExpress.XtraCharts.Series(){}
			Me.chart.SeriesTemplate.ArgumentDataMember = "Year"
			Me.chart.SeriesTemplate.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.DateTime
			stackedArea3DSeriesLabel1.ResolveOverlappingMode = DevExpress.XtraCharts.ResolveOverlappingMode.HideOverlapped
			Me.chart.SeriesTemplate.Label = stackedArea3DSeriesLabel1
			Me.chart.SeriesTemplate.LabelsVisibility = DevExpress.Utils.DefaultBoolean.False
			Me.chart.SeriesTemplate.ValueDataMembersSerializable = "Sales"
			stackedSplineArea3DSeriesView1.AreaWidth = 1R
			Me.chart.SeriesTemplate.View = stackedSplineArea3DSeriesView1
			resources.ApplyResources(chartTitle1, "chartTitle1")
			Me.chart.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() { chartTitle1})
			' 
			' StackedSplineArea3dDemo
			' 
			resources.ApplyResources(Me, "$this")
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.chart)
			Me.Name = "StackedSplineArea3dDemo"
			Me.Controls.SetChildIndex(Me.panelRoot, 0)
			Me.Controls.SetChildIndex(Me.chart, 0)
			CType(Me.comboTransparencies.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.comboBoxEditPerspective.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.panel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panel.ResumeLayout(False)
			Me.panel.PerformLayout()
			CType(Me.checkEditShowLabels.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panelRoot.ResumeLayout(False)
			CType(xyDiagram3D1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(stackedArea3DSeriesLabel1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(stackedSplineArea3DSeriesView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.chart, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region
		Private components As System.ComponentModel.IContainer = Nothing
	End Class
End Namespace
