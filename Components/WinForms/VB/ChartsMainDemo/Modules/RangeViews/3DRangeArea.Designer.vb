Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.XtraCharts.Demos.RangeViews
	Partial Public Class RangeArea3dDemo
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
			Dim series1 As New DevExpress.XtraCharts.Series()
			Dim rangeArea3DSeriesLabel1 As New DevExpress.XtraCharts.RangeArea3DSeriesLabel()
			Dim rangeArea3DSeriesView1 As New DevExpress.XtraCharts.RangeArea3DSeriesView()
			Dim overlappedRangeBarSeriesView1 As New DevExpress.XtraCharts.OverlappedRangeBarSeriesView()
			Dim chartTitle1 As New DevExpress.XtraCharts.ChartTitle()
			Dim chartTitle2 As New DevExpress.XtraCharts.ChartTitle()
			Me.chart = New DevExpress.XtraCharts.ChartControl()
			Me.labelLabelKind = New DevExpress.XtraEditors.LabelControl()
			Me.comboBoxLabelKind = New DevExpress.XtraEditors.ComboBoxEdit()
			CType(Me.panel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panel.SuspendLayout()
			CType(Me.checkEditShowLabels.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panelRoot.SuspendLayout()
			CType(Me.chart, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(xyDiagram3D1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(series1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(rangeArea3DSeriesLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(rangeArea3DSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(overlappedRangeBarSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.comboBoxLabelKind.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' panel
			' 
			Me.panel.Controls.Add(Me.comboBoxLabelKind)
			Me.panel.Controls.Add(Me.labelLabelKind)
			Me.panel.Controls.SetChildIndex(Me.btnDefaultAngles, 0)
			Me.panel.Controls.SetChildIndex(Me.checkEditShowLabels, 0)
			Me.panel.Controls.SetChildIndex(Me.labelLabelKind, 0)
			Me.panel.Controls.SetChildIndex(Me.comboBoxLabelKind, 0)
			' 
			' checkEditShowLabels
			' 
			Me.checkEditShowLabels.Location = New System.Drawing.Point(607, 9)
			' 
			' chart
			' 
			Me.chart.DataBindings = Nothing
			xyDiagram3D1.AxisX.DateTimeScaleOptions.AutoGrid = False
			xyDiagram3D1.AxisX.DateTimeScaleOptions.GridAlignment = DevExpress.XtraCharts.DateTimeGridAlignment.Month
			xyDiagram3D1.AxisX.DateTimeScaleOptions.GridSpacing = 2R
			xyDiagram3D1.AxisX.DateTimeScaleOptions.MeasureUnit = DevExpress.XtraCharts.DateTimeMeasureUnit.Month
			xyDiagram3D1.AxisX.Label.TextPattern = "{A:MMMM}"
			xyDiagram3D1.AxisY.Label.TextPattern = "${V}"
			xyDiagram3D1.AxisY.VisualRange.Auto = False
			xyDiagram3D1.AxisY.VisualRange.MaxValueSerializable = "70"
			xyDiagram3D1.AxisY.VisualRange.MinValueSerializable = "30"
			xyDiagram3D1.AxisY.WholeRange.Auto = False
			xyDiagram3D1.AxisY.WholeRange.MaxValueSerializable = "70"
			xyDiagram3D1.AxisY.WholeRange.MinValueSerializable = "30"
			xyDiagram3D1.HorizontalScrollPercent = -2R
			xyDiagram3D1.RotationMatrixSerializable = "0.766044437885284;-0.219846323132515;0.604022800922394;0;0;0.939692616462708;0.34" & "2020153999329;0;-0.642787635326386;-0.262002646923065;0.719846308231354;0;0;0;0;" & "1"
			xyDiagram3D1.RuntimeRotation = True
			xyDiagram3D1.RuntimeScrolling = True
			xyDiagram3D1.RuntimeZooming = True
			xyDiagram3D1.VerticalScrollPercent = 4R
			xyDiagram3D1.ZoomPercent = 160
			Me.chart.Diagram = xyDiagram3D1
			Me.chart.Dock = System.Windows.Forms.DockStyle.Fill
			Me.chart.Legend.Name = "Default Legend"
			Me.chart.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False
			Me.chart.Location = New System.Drawing.Point(0, 46)
			Me.chart.Name = "chart"
			series1.ArgumentDataMember = "Date"
			series1.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.DateTime
			rangeArea3DSeriesLabel1.ResolveOverlappingMode = DevExpress.XtraCharts.ResolveOverlappingMode.HideOverlapped
			rangeArea3DSeriesLabel1.TextPattern = "{V:F2}"
			series1.Label = rangeArea3DSeriesLabel1
			series1.Name = "OK WTI"
			series1.ValueDataMembersSerializable = "Min;Max"
			series1.View = rangeArea3DSeriesView1
			Me.chart.SeriesSerializable = New DevExpress.XtraCharts.Series() { series1}
			Me.chart.SeriesTemplate.View = overlappedRangeBarSeriesView1
			Me.chart.Size = New System.Drawing.Size(700, 454)
			Me.chart.TabIndex = 1
			chartTitle1.Text = "Crude Oil Prices in 2015"
			chartTitle2.Alignment = System.Drawing.StringAlignment.Far
			chartTitle2.Dock = DevExpress.XtraCharts.ChartTitleDockStyle.Bottom
			chartTitle2.Font = New System.Drawing.Font("Tahoma", 8F)
			chartTitle2.Text = "From www.eia.gov"
			chartTitle2.TextColor = System.Drawing.Color.Gray
			Me.chart.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() { chartTitle1, chartTitle2})
			' 
			' labelLabelKind
			' 
			Me.labelLabelKind.Anchor = (CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.labelLabelKind.Location = New System.Drawing.Point(432, 12)
			Me.labelLabelKind.Margin = New System.Windows.Forms.Padding(0, 10, 3, 10)
			Me.labelLabelKind.Name = "labelLabelKind"
			Me.labelLabelKind.Size = New System.Drawing.Size(52, 13)
			Me.labelLabelKind.TabIndex = 65
			Me.labelLabelKind.Text = "Label Kind:"
			' 
			' comboBoxLabelKind
			' 
			Me.comboBoxLabelKind.Anchor = (CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.comboBoxLabelKind.EditValue = "Two Labels"
			Me.comboBoxLabelKind.Location = New System.Drawing.Point(487, 9)
			Me.comboBoxLabelKind.Margin = New System.Windows.Forms.Padding(0, 0, 10, 10)
			Me.comboBoxLabelKind.Name = "comboBoxLabelKind"
			Me.comboBoxLabelKind.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.comboBoxLabelKind.Properties.Items.AddRange(New Object() { "One Label", "Two Labels", "Max Value Label", "Min Value Label"})
			Me.comboBoxLabelKind.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
			Me.comboBoxLabelKind.Size = New System.Drawing.Size(100, 20)
			Me.comboBoxLabelKind.TabIndex = 66
'			Me.comboBoxLabelKind.SelectedIndexChanged += New System.EventHandler(Me.comboBoxLabelKind_SelectedIndexChanged);
			' 
			' RangeArea3dDemo
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.chart)
			Me.Name = "RangeArea3dDemo"
			Me.Controls.SetChildIndex(Me.panelRoot, 0)
			Me.Controls.SetChildIndex(Me.chart, 0)
			CType(Me.panel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panel.ResumeLayout(False)
			Me.panel.PerformLayout()
			CType(Me.checkEditShowLabels.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panelRoot.ResumeLayout(False)
			CType(xyDiagram3D1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(rangeArea3DSeriesLabel1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(rangeArea3DSeriesView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(series1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(overlappedRangeBarSeriesView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.chart, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.comboBoxLabelKind.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region
		Private components As System.ComponentModel.IContainer = Nothing
		Protected labelLabelKind As DevExpress.XtraEditors.LabelControl
		Protected WithEvents comboBoxLabelKind As DevExpress.XtraEditors.ComboBoxEdit

	End Class
End Namespace
