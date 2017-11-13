Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.XtraCharts.Demos.PieDoughnutViews
	Partial Public Class Doughnut3dDemo
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
			Dim simpleDiagram3D1 As New DevExpress.XtraCharts.SimpleDiagram3D()
			Dim series1 As New DevExpress.XtraCharts.Series()
			Dim doughnut3DSeriesLabel1 As New DevExpress.XtraCharts.Doughnut3DSeriesLabel()
			Dim seriesPoint1 As New DevExpress.XtraCharts.SeriesPoint("Russia", New Object() { (CObj(17.0752R))}, 0)
			Dim seriesPoint2 As New DevExpress.XtraCharts.SeriesPoint("Canada", New Object() { (CObj(9.98467R))}, 1)
			Dim seriesPoint3 As New DevExpress.XtraCharts.SeriesPoint("USA", New Object() { (CObj(9.63142R))}, 2)
			Dim seriesPoint4 As New DevExpress.XtraCharts.SeriesPoint("China", New Object() { (CObj(9.59696R))}, 3)
			Dim seriesPoint5 As New DevExpress.XtraCharts.SeriesPoint("Brazil", New Object() { (CObj(8.511965R))}, 4)
			Dim seriesPoint6 As New DevExpress.XtraCharts.SeriesPoint("Australia", New Object() { (CObj(7.68685R))}, 5)
			Dim seriesPoint7 As New DevExpress.XtraCharts.SeriesPoint("India", New Object() { (CObj(3.28759R))}, 6)
			Dim seriesPoint8 As New DevExpress.XtraCharts.SeriesPoint("Others", New Object() { (CObj(81.2R))}, 7)
			Dim doughnut3DSeriesView1 As New DevExpress.XtraCharts.Doughnut3DSeriesView()
			Dim chartTitle1 As New DevExpress.XtraCharts.ChartTitle()
			Dim chartTitle2 As New DevExpress.XtraCharts.ChartTitle()
			Me.chart = New DevExpress.XtraCharts.ChartControl()
			Me.checkEditValueAsPercent = New DevExpress.XtraEditors.CheckEdit()
			Me.cbExplodeMode = New DevExpress.XtraEditors.ComboBoxEdit()
			Me.cbLabelPosition = New DevExpress.XtraEditors.ComboBoxEdit()
			Me.labelPosition = New DevExpress.XtraEditors.LabelControl()
			Me.label1 = New DevExpress.XtraEditors.LabelControl()
			Me.labelHoleRadius = New DevExpress.XtraEditors.LabelControl()
			Me.txtHoleRadius = New DevExpress.XtraEditors.SpinEdit()
			CType(Me.panel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panel.SuspendLayout()
			CType(Me.checkEditShowLabels.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panelRoot.SuspendLayout()
			CType(Me.chart, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(simpleDiagram3D1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(series1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(doughnut3DSeriesLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(doughnut3DSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.checkEditValueAsPercent.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.cbExplodeMode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.cbLabelPosition.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.txtHoleRadius.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' btnDefaultAngles
			' 
			Me.btnDefaultAngles.Location = New System.Drawing.Point(271, 36)
			Me.btnDefaultAngles.TabIndex = 3
			' 
			' panel
			' 
			Me.panel.Controls.Add(Me.labelHoleRadius)
			Me.panel.Controls.Add(Me.txtHoleRadius)
			Me.panel.Controls.Add(Me.label1)
			Me.panel.Controls.Add(Me.labelPosition)
			Me.panel.Controls.Add(Me.cbExplodeMode)
			Me.panel.Controls.Add(Me.cbLabelPosition)
			Me.panel.Controls.Add(Me.checkEditValueAsPercent)
			Me.panel.Margin = New System.Windows.Forms.Padding(7)
			Me.panel.Controls.SetChildIndex(Me.btnDefaultAngles, 0)
			Me.panel.Controls.SetChildIndex(Me.checkEditShowLabels, 0)
			Me.panel.Controls.SetChildIndex(Me.checkEditValueAsPercent, 0)
			Me.panel.Controls.SetChildIndex(Me.cbLabelPosition, 0)
			Me.panel.Controls.SetChildIndex(Me.cbExplodeMode, 0)
			Me.panel.Controls.SetChildIndex(Me.labelPosition, 0)
			Me.panel.Controls.SetChildIndex(Me.label1, 0)
			Me.panel.Controls.SetChildIndex(Me.txtHoleRadius, 0)
			Me.panel.Controls.SetChildIndex(Me.labelHoleRadius, 0)
			' 
			' checkEditShowLabels
			' 
			Me.checkEditShowLabels.Location = New System.Drawing.Point(584, 37)
			Me.checkEditShowLabels.TabIndex = 5
			' 
			' chart
			' 
			Me.chart.DataBindings = Nothing
			simpleDiagram3D1.LabelsResolveOverlappingMinIndent = 3
			simpleDiagram3D1.RotationMatrixSerializable = "0.965925826289068;0.258819045102521;0;0;-0.212012149896655;0.791240115236224;-0.5" & "73576436351046;0;-0.148452505549685;0.554032293222323;0.819152044288992;0;0;0;0;" & "1"
			simpleDiagram3D1.RuntimeRotation = True
			simpleDiagram3D1.RuntimeScrolling = True
			simpleDiagram3D1.RuntimeZooming = True
			Me.chart.Diagram = simpleDiagram3D1
			Me.chart.Dock = System.Windows.Forms.DockStyle.Fill
			Me.chart.Legend.Name = "Default Legend"
			Me.chart.Location = New System.Drawing.Point(0, 74)
			Me.chart.Name = "chart"
			doughnut3DSeriesLabel1.Font = New System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold)
			doughnut3DSeriesLabel1.TextPattern = "{A}: {VP:P2}"
			series1.Label = doughnut3DSeriesLabel1
			series1.LegendTextPattern = "{A}"
			series1.Name = "Series 1"
			series1.Points.AddRange(New DevExpress.XtraCharts.SeriesPoint() { seriesPoint1, seriesPoint2, seriesPoint3, seriesPoint4, seriesPoint5, seriesPoint6, seriesPoint7, seriesPoint8})
			series1.View = doughnut3DSeriesView1
			Me.chart.SeriesSerializable = New DevExpress.XtraCharts.Series() { series1}
			Me.chart.Size = New System.Drawing.Size(700, 426)
			Me.chart.TabIndex = 1
			chartTitle1.Indent = 10
			chartTitle1.Text = "Area of Countries"
			chartTitle2.Alignment = System.Drawing.StringAlignment.Far
			chartTitle2.Dock = DevExpress.XtraCharts.ChartTitleDockStyle.Bottom
			chartTitle2.Font = New System.Drawing.Font("Tahoma", 8F)
			chartTitle2.Text = "From www.nationmaster.com"
			chartTitle2.TextColor = System.Drawing.Color.Gray
			Me.chart.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() { chartTitle1, chartTitle2})
			' 
			' checkEditValueAsPercent
			' 
			Me.checkEditValueAsPercent.Anchor = (CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.checkEditValueAsPercent.Location = New System.Drawing.Point(584, 9)
			Me.checkEditValueAsPercent.Margin = New System.Windows.Forms.Padding(0)
			Me.checkEditValueAsPercent.Name = "checkEditValueAsPercent"
			Me.checkEditValueAsPercent.Properties.Caption = "Value As Percent"
			Me.checkEditValueAsPercent.Size = New System.Drawing.Size(104, 19)
			Me.checkEditValueAsPercent.TabIndex = 4
'			Me.checkEditValueAsPercent.CheckedChanged += New System.EventHandler(Me.checkEditValueAsPercent_CheckedChanged);
			' 
			' cbExplodeMode
			' 
			Me.cbExplodeMode.Location = New System.Drawing.Point(95, 37)
			Me.cbExplodeMode.Margin = New System.Windows.Forms.Padding(0, 10, 10, 0)
			Me.cbExplodeMode.Name = "cbExplodeMode"
			Me.cbExplodeMode.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.cbExplodeMode.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
			Me.cbExplodeMode.Size = New System.Drawing.Size(104, 20)
			Me.cbExplodeMode.TabIndex = 1
'			Me.cbExplodeMode.SelectedIndexChanged += New System.EventHandler(Me.cbExplodeMode_SelectedIndexChanged);
			' 
			' cbLabelPosition
			' 
			Me.cbLabelPosition.Location = New System.Drawing.Point(95, 9)
			Me.cbLabelPosition.Margin = New System.Windows.Forms.Padding(10, 0, 10, 10)
			Me.cbLabelPosition.Name = "cbLabelPosition"
			Me.cbLabelPosition.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.cbLabelPosition.Properties.Items.AddRange(New Object() { "Inside", "Outside", "Two Columns", "Radial"})
			Me.cbLabelPosition.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
			Me.cbLabelPosition.Size = New System.Drawing.Size(104, 20)
			Me.cbLabelPosition.TabIndex = 0
'			Me.cbLabelPosition.SelectedIndexChanged += New System.EventHandler(Me.SelectedIndexChanged);
			' 
			' labelPosition
			' 
			Me.labelPosition.Location = New System.Drawing.Point(12, 12)
			Me.labelPosition.Margin = New System.Windows.Forms.Padding(0, 10, 3, 10)
			Me.labelPosition.Name = "labelPosition"
			Me.labelPosition.Size = New System.Drawing.Size(69, 13)
			Me.labelPosition.TabIndex = 13
			Me.labelPosition.Text = "Label Position:"
			' 
			' label1
			' 
			Me.label1.Location = New System.Drawing.Point(12, 40)
			Me.label1.Margin = New System.Windows.Forms.Padding(0, 10, 3, 10)
			Me.label1.Name = "label1"
			Me.label1.Size = New System.Drawing.Size(80, 13)
			Me.label1.TabIndex = 14
			Me.label1.Text = "Exploded Points:"
			' 
			' labelHoleRadius
			' 
			Me.labelHoleRadius.Location = New System.Drawing.Point(220, 12)
			Me.labelHoleRadius.Margin = New System.Windows.Forms.Padding(10, 10, 3, 10)
			Me.labelHoleRadius.Name = "labelHoleRadius"
			Me.labelHoleRadius.Size = New System.Drawing.Size(82, 13)
			Me.labelHoleRadius.TabIndex = 19
			Me.labelHoleRadius.Text = "Hole Radius (%):"
			' 
			' txtHoleRadius
			' 
			Me.txtHoleRadius.EditValue = New Decimal(New Integer() { 60, 0, 0, 0})
			Me.txtHoleRadius.Location = New System.Drawing.Point(305, 9)
			Me.txtHoleRadius.Margin = New System.Windows.Forms.Padding(0, 0, 10, 10)
			Me.txtHoleRadius.Name = "txtHoleRadius"
			Me.txtHoleRadius.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
			Me.txtHoleRadius.Properties.IsFloatValue = False
			Me.txtHoleRadius.Properties.Mask.EditMask = "N00"
			Me.txtHoleRadius.Properties.MaxValue = New Decimal(New Integer() { 100, 0, 0, 0})
			Me.txtHoleRadius.Properties.ValidateOnEnterKey = True
			Me.txtHoleRadius.Size = New System.Drawing.Size(94, 20)
			Me.txtHoleRadius.TabIndex = 2
'			Me.txtHoleRadius.EditValueChanged += New System.EventHandler(Me.txtHoleRadius_EditValueChanged);
			' 
			' Doughnut3dDemo
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.chart)
			Me.Name = "Doughnut3dDemo"
			Me.Controls.SetChildIndex(Me.panelRoot, 0)
			Me.Controls.SetChildIndex(Me.chart, 0)
			CType(Me.panel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panel.ResumeLayout(False)
			Me.panel.PerformLayout()
			CType(Me.checkEditShowLabels.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panelRoot.ResumeLayout(False)
			CType(simpleDiagram3D1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(doughnut3DSeriesLabel1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(doughnut3DSeriesView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(series1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.chart, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.checkEditValueAsPercent.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.cbExplodeMode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.cbLabelPosition.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.txtHoleRadius.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region
		Private components As System.ComponentModel.IContainer = Nothing
		Private WithEvents cbExplodeMode As DevExpress.XtraEditors.ComboBoxEdit
		Private WithEvents cbLabelPosition As DevExpress.XtraEditors.ComboBoxEdit
		Private label1 As DevExpress.XtraEditors.LabelControl
		Private labelPosition As DevExpress.XtraEditors.LabelControl
		Private labelHoleRadius As DevExpress.XtraEditors.LabelControl
		Private WithEvents txtHoleRadius As DevExpress.XtraEditors.SpinEdit

	End Class
End Namespace
