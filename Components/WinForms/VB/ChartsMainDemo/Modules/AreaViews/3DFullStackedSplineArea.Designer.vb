Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.XtraCharts.Demos.AreaViews
	Partial Public Class FullStackedSplineArea3dDemo
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
			Dim xyDiagram3D2 As New DevExpress.XtraCharts.XYDiagram3D()
			Dim fullStackedSplineArea3DSeriesView2 As New DevExpress.XtraCharts.FullStackedSplineArea3DSeriesView()
			Dim chartTitle2 As New DevExpress.XtraCharts.ChartTitle()
			Me.chart = New DevExpress.XtraCharts.ChartControl()
			Me.checkValueAsPercent = New DevExpress.XtraEditors.CheckEdit()
			CType(Me.comboTransparencies.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.comboBoxEditPerspective.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.panel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panel.SuspendLayout()
			CType(Me.checkEditShowLabels.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panelRoot.SuspendLayout()
			CType(Me.chart, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(xyDiagram3D2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(fullStackedSplineArea3DSeriesView2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.checkValueAsPercent.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
			' panel
			' 
			Me.panel.Controls.Add(Me.checkValueAsPercent)
			Me.panel.Controls.SetChildIndex(Me.checkValueAsPercent, 0)
			Me.panel.Controls.SetChildIndex(Me.btnDefaultAngles, 0)
			Me.panel.Controls.SetChildIndex(Me.checkEditShowLabels, 0)
			Me.panel.Controls.SetChildIndex(Me.comboTransparencies, 0)
			Me.panel.Controls.SetChildIndex(Me.comboBoxEditPerspective, 0)
			' 
			' checkEditShowLabels
			' 
			Me.checkEditShowLabels.Location = New System.Drawing.Point(584, 37)
			Me.checkEditShowLabels.TabIndex = 4
			' 
			' chart
			' 
			Me.chart.DataBindings = Nothing
			xyDiagram3D2.AxisX.DateTimeScaleOptions.MeasureUnit = DevExpress.XtraCharts.DateTimeMeasureUnit.Year
			xyDiagram3D2.AxisX.WholeRange.AutoSideMargins = False
			xyDiagram3D2.AxisX.WholeRange.SideMarginsValue = 0R
			xyDiagram3D2.AxisY.Interlaced = False
			xyDiagram3D2.AxisY.Label.TextPattern = "{V:P0}"
			xyDiagram3D2.AxisY.WholeRange.AutoSideMargins = False
			xyDiagram3D2.AxisY.WholeRange.SideMarginsValue = 0R
			xyDiagram3D2.RotationMatrixSerializable = "0.766044443118978;-0.219846310392954;0.604022773555054;0;0;0.939692620785908;0.34" & "2020143325669;0;-0.642787609686539;-0.262002630229385;0.719846310392954;0;0;0;0;" & "1"
			xyDiagram3D2.RuntimeRotation = True
			xyDiagram3D2.RuntimeScrolling = True
			xyDiagram3D2.RuntimeZooming = True
			xyDiagram3D2.VerticalScrollPercent = 5R
			xyDiagram3D2.ZoomPercent = 130
			Me.chart.Diagram = xyDiagram3D2
			Me.chart.Dock = System.Windows.Forms.DockStyle.Fill
			Me.chart.Legend.Direction = DevExpress.XtraCharts.LegendDirection.BottomToTop
			Me.chart.Legend.Name = "Default Legend"
			Me.chart.Location = New System.Drawing.Point(0, 74)
			Me.chart.Name = "chart"
			Me.chart.SeriesDataMember = "Company"
			Me.chart.SeriesSerializable = New DevExpress.XtraCharts.Series(){}
			Me.chart.SeriesTemplate.ArgumentDataMember = "Year"
			Me.chart.SeriesTemplate.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.DateTime
			Me.chart.SeriesTemplate.LabelsVisibility = DevExpress.Utils.DefaultBoolean.False
			Me.chart.SeriesTemplate.ValueDataMembersSerializable = "Sales"
			fullStackedSplineArea3DSeriesView2.AreaWidth = 1R
			Me.chart.SeriesTemplate.View = fullStackedSplineArea3DSeriesView2
			Me.chart.Size = New System.Drawing.Size(700, 426)
			Me.chart.TabIndex = 2
			chartTitle2.Text = "Market Share Over Time"
			Me.chart.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() { chartTitle2})
			' 
			' checkValueAsPercent
			' 
			Me.checkValueAsPercent.Anchor = (CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.checkValueAsPercent.Location = New System.Drawing.Point(584, 9)
			Me.checkValueAsPercent.Margin = New System.Windows.Forms.Padding(0)
			Me.checkValueAsPercent.Name = "checkValueAsPercent"
			Me.checkValueAsPercent.Properties.Caption = "Value As Percent"
			Me.checkValueAsPercent.Size = New System.Drawing.Size(104, 19)
			Me.checkValueAsPercent.TabIndex = 3
'			Me.checkValueAsPercent.CheckedChanged += New System.EventHandler(Me.checkEditValueAsPercent_CheckedChanged);
			' 
			' FullStackedSplineArea3dDemo
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.chart)
			Me.Name = "FullStackedSplineArea3dDemo"
			Me.Controls.SetChildIndex(Me.panelRoot, 0)
			Me.Controls.SetChildIndex(Me.chart, 0)
			CType(Me.comboTransparencies.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.comboBoxEditPerspective.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.panel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panel.ResumeLayout(False)
			Me.panel.PerformLayout()
			CType(Me.checkEditShowLabels.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panelRoot.ResumeLayout(False)
			CType(xyDiagram3D2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(fullStackedSplineArea3DSeriesView2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.chart, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.checkValueAsPercent.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region
		Private components As System.ComponentModel.IContainer = Nothing
	End Class
End Namespace
