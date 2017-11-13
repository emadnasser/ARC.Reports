Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.XtraCharts.Demos.AreaViews
	Partial Public Class Area3dDemo
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
			Dim area3DSeriesLabel1 As New DevExpress.XtraCharts.Area3DSeriesLabel()
			Dim area3DSeriesView1 As New DevExpress.XtraCharts.Area3DSeriesView()
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
			CType(area3DSeriesLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(area3DSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' comboTransparencies
			' 
			Me.comboTransparencies.TabIndex = 0
			' 
			' comboBoxEditPerspective
			' 
			Me.comboBoxEditPerspective.TabIndex = 1
			' 
			' btnDefaultAngles
			' 
			Me.btnDefaultAngles.TabIndex = 2
			' 
			' checkEditShowLabels
			' 
			Me.checkEditShowLabels.TabIndex = 3
			' 
			' chart
			' 
			Me.chart.DataBindings = Nothing
			xyDiagram3D1.AxisX.DateTimeScaleOptions.MeasureUnit = DevExpress.XtraCharts.DateTimeMeasureUnit.Year
			xyDiagram3D1.AxisX.GridLines.Visible = True
			xyDiagram3D1.AxisX.Label.MaxWidth = 70
			xyDiagram3D1.AxisX.WholeRange.AutoSideMargins = False
			xyDiagram3D1.AxisX.WholeRange.SideMarginsValue = 0R
			xyDiagram3D1.AxisY.Label.TextPattern = "${V}K"
			xyDiagram3D1.AxisY.NumericScaleOptions.AutoGrid = False
			xyDiagram3D1.AxisY.NumericScaleOptions.GridAlignment = DevExpress.XtraCharts.NumericGridAlignment.Hundreds
			xyDiagram3D1.AxisY.WholeRange.AlwaysShowZeroLevel = False
			xyDiagram3D1.RotationMatrixSerializable = "0.77646940946579;-0.219846308231354;0.590561509132385;0;0.00596907455474138;0.939" & "692616462708;0.341968059539795;0;-0.630126714706421;-0.262002617120743;0.7309548" & "85482788;0;0;0;0;1"
			xyDiagram3D1.RuntimeRotation = True
			xyDiagram3D1.RuntimeScrolling = True
			xyDiagram3D1.RuntimeZooming = True
			xyDiagram3D1.VerticalScrollPercent = 7R
			xyDiagram3D1.ZoomPercent = 135
			Me.chart.Diagram = xyDiagram3D1
			Me.chart.Dock = System.Windows.Forms.DockStyle.Fill
			Me.chart.Legend.Name = "Default Legend"
			Me.chart.Location = New System.Drawing.Point(0, 74)
			Me.chart.Name = "chart"
			Me.chart.SeriesDataMember = "Company"
			Me.chart.SeriesSerializable = New DevExpress.XtraCharts.Series(){}
			Me.chart.SeriesTemplate.ArgumentDataMember = "Year"
			Me.chart.SeriesTemplate.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.DateTime
			area3DSeriesLabel1.LineVisibility = DevExpress.Utils.DefaultBoolean.True
			Me.chart.SeriesTemplate.Label = area3DSeriesLabel1
			Me.chart.SeriesTemplate.LabelsVisibility = DevExpress.Utils.DefaultBoolean.True
			Me.chart.SeriesTemplate.ValueDataMembersSerializable = "Costs"
			Me.chart.SeriesTemplate.View = area3DSeriesView1
			Me.chart.Size = New System.Drawing.Size(700, 426)
			Me.chart.TabIndex = 7
			chartTitle1.Text = "Outside Vendor Costs"
			Me.chart.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() { chartTitle1})
			' 
			' Area3dDemo
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.chart)
			Me.Name = "Area3dDemo"
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
			CType(area3DSeriesLabel1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(area3DSeriesView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.chart, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private components As System.ComponentModel.IContainer = Nothing

	End Class
End Namespace
