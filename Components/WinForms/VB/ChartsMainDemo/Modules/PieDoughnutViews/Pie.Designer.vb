Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.XtraCharts.Demos.PieDoughnutViews
	Partial Public Class PieDemo
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
			Dim series1 As New DevExpress.XtraCharts.Series()
			Dim pieSeriesLabel1 As New DevExpress.XtraCharts.PieSeriesLabel()
			Dim seriesPoint1 As New DevExpress.XtraCharts.SeriesPoint("Russia", New Object() { (CObj(17.0752R))}, 0)
			Dim seriesPoint2 As New DevExpress.XtraCharts.SeriesPoint("Canada", New Object() { (CObj(9.98467R))}, 1)
			Dim seriesPoint3 As New DevExpress.XtraCharts.SeriesPoint("USA", New Object() { (CObj(9.63142R))}, 2)
			Dim seriesPoint4 As New DevExpress.XtraCharts.SeriesPoint("China", New Object() { (CObj(9.59696R))}, 3)
			Dim seriesPoint5 As New DevExpress.XtraCharts.SeriesPoint("Brazil", New Object() { (CObj(8.511965R))}, 4)
			Dim seriesPoint6 As New DevExpress.XtraCharts.SeriesPoint("Australia", New Object() { (CObj(7.68685R))}, 5)
			Dim seriesPoint7 As New DevExpress.XtraCharts.SeriesPoint("India", New Object() { (CObj(3.28759R))}, 6)
			Dim seriesPoint8 As New DevExpress.XtraCharts.SeriesPoint("Others", New Object() { (CObj(81.2R))}, 7)
			Dim pieSeriesView1 As New DevExpress.XtraCharts.PieSeriesView()
			Dim pieBurstAnimation1 As New DevExpress.XtraCharts.PieBurstAnimation()
			Dim pieSeriesLabel2 As New DevExpress.XtraCharts.PieSeriesLabel()
			Dim pieSeriesView2 As New DevExpress.XtraCharts.PieSeriesView()
			Dim chartTitle1 As New DevExpress.XtraCharts.ChartTitle()
			Dim chartTitle2 As New DevExpress.XtraCharts.ChartTitle()
			Me.chart = New DevExpress.XtraCharts.ChartControl()
			Me.checkEditValueAsPercent = New DevExpress.XtraEditors.CheckEdit()
			Me.cbLabelPosition = New DevExpress.XtraEditors.ComboBoxEdit()
			Me.cbExplodeMode = New DevExpress.XtraEditors.ComboBoxEdit()
			Me.labelPosition = New DevExpress.XtraEditors.LabelControl()
			Me.label1 = New DevExpress.XtraEditors.LabelControl()
			CType(Me.panel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panel.SuspendLayout()
			CType(Me.checkEditShowLabels.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panelRoot.SuspendLayout()
			CType(Me.chart, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(series1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(pieSeriesLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(pieSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(pieSeriesLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(pieSeriesView2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.checkEditValueAsPercent.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.cbLabelPosition.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.cbExplodeMode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' panel
			' 
			Me.panel.Controls.Add(Me.label1)
			Me.panel.Controls.Add(Me.labelPosition)
			Me.panel.Controls.Add(Me.cbExplodeMode)
			Me.panel.Controls.Add(Me.cbLabelPosition)
			Me.panel.Controls.Add(Me.checkEditValueAsPercent)
			Me.panel.Controls.SetChildIndex(Me.checkEditShowLabels, 0)
			Me.panel.Controls.SetChildIndex(Me.checkEditValueAsPercent, 0)
			Me.panel.Controls.SetChildIndex(Me.cbLabelPosition, 0)
			Me.panel.Controls.SetChildIndex(Me.cbExplodeMode, 0)
			Me.panel.Controls.SetChildIndex(Me.labelPosition, 0)
			Me.panel.Controls.SetChildIndex(Me.label1, 0)
			' 
			' checkEditShowLabels
			' 
			Me.checkEditShowLabels.Location = New System.Drawing.Point(584, 37)
			Me.checkEditShowLabels.Size = New System.Drawing.Size(82, 19)
			Me.checkEditShowLabels.TabIndex = 4
			' 
			' chart
			' 
			Me.chart.DataBindings = Nothing
			Me.chart.Dock = System.Windows.Forms.DockStyle.Fill
			Me.chart.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Right
			Me.chart.Legend.Name = "Default Legend"
			Me.chart.Location = New System.Drawing.Point(0, 74)
			Me.chart.Name = "chart"
			pieSeriesLabel1.BackColor = System.Drawing.Color.Transparent
			pieSeriesLabel1.Border.Visibility = DevExpress.Utils.DefaultBoolean.False
			pieSeriesLabel1.ColumnIndent = 20
			pieSeriesLabel1.Font = New System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold)
			pieSeriesLabel1.LineLength = 30
			pieSeriesLabel1.Position = DevExpress.XtraCharts.PieSeriesLabelPosition.TwoColumns
			pieSeriesLabel1.TextPattern = "{A}: {VP:P2}"
			series1.Label = pieSeriesLabel1
			series1.LegendTextPattern = "{A}"
			series1.Name = "Series 1"
			series1.Points.AddRange(New DevExpress.XtraCharts.SeriesPoint() { seriesPoint1, seriesPoint2, seriesPoint3, seriesPoint4, seriesPoint5, seriesPoint6, seriesPoint7, seriesPoint8})
			pieBurstAnimation1.PointDelay = System.TimeSpan.Parse("00:00:00.1000000")
			pieSeriesView1.Animation = pieBurstAnimation1
			pieSeriesView1.Rotation = 90
			pieSeriesView1.RuntimeExploding = True
			series1.View = pieSeriesView1
			Me.chart.SeriesSerializable = New DevExpress.XtraCharts.Series() { series1}
			pieSeriesLabel2.TextPattern = "{VP:G2}"
			Me.chart.SeriesTemplate.Label = pieSeriesLabel2
			pieSeriesView2.Border.Color = System.Drawing.Color.FromArgb((CInt(Fix((CByte(100))))), (CInt(Fix((CByte(255))))), (CInt(Fix((CByte(255))))), (CInt(Fix((CByte(255))))))
			Me.chart.SeriesTemplate.View = pieSeriesView2
			Me.chart.Size = New System.Drawing.Size(700, 426)
			Me.chart.TabIndex = 1
			Me.chart.TabStop = False
			chartTitle1.Indent = 10
			chartTitle1.Text = "Area of Countries"
			chartTitle2.Alignment = System.Drawing.StringAlignment.Far
			chartTitle2.Dock = DevExpress.XtraCharts.ChartTitleDockStyle.Bottom
			chartTitle2.Font = New System.Drawing.Font("Tahoma", 8F)
			chartTitle2.Text = "From www.nationmaster.com"
			chartTitle2.TextColor = System.Drawing.Color.Gray
			Me.chart.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() { chartTitle1, chartTitle2})
'			Me.chart.PieSeriesPointExploded += New DevExpress.XtraCharts.PieSeriesPointExplodedEventHandler(Me.chart_PieSeriesPointExploded);
			' 
			' checkEditValueAsPercent
			' 
			Me.checkEditValueAsPercent.Anchor = (CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.checkEditValueAsPercent.Location = New System.Drawing.Point(584, 9)
			Me.checkEditValueAsPercent.Margin = New System.Windows.Forms.Padding(10, 10, 0, 10)
			Me.checkEditValueAsPercent.Name = "checkEditValueAsPercent"
			Me.checkEditValueAsPercent.Properties.Caption = "Value As Percent"
			Me.checkEditValueAsPercent.Size = New System.Drawing.Size(105, 19)
			Me.checkEditValueAsPercent.TabIndex = 3
'			Me.checkEditValueAsPercent.CheckedChanged += New System.EventHandler(Me.checkEditValueAsPercent_CheckedChanged);
			' 
			' cbLabelPosition
			' 
			Me.cbLabelPosition.Location = New System.Drawing.Point(95, 9)
			Me.cbLabelPosition.Margin = New System.Windows.Forms.Padding(0, 0, 10, 10)
			Me.cbLabelPosition.Name = "cbLabelPosition"
			Me.cbLabelPosition.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.cbLabelPosition.Properties.Items.AddRange(New Object() { "Inside", "Outside", "Two Columns", "Radial"})
			Me.cbLabelPosition.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
			Me.cbLabelPosition.Size = New System.Drawing.Size(115, 20)
			Me.cbLabelPosition.TabIndex = 0
'			Me.cbLabelPosition.SelectedIndexChanged += New System.EventHandler(Me.cbLabelPosition_SelectedIndexChanged);
			' 
			' cbExplodeMode
			' 
			Me.cbExplodeMode.Location = New System.Drawing.Point(95, 37)
			Me.cbExplodeMode.Margin = New System.Windows.Forms.Padding(0, 10, 10, 0)
			Me.cbExplodeMode.Name = "cbExplodeMode"
			Me.cbExplodeMode.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.cbExplodeMode.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
			Me.cbExplodeMode.Size = New System.Drawing.Size(115, 20)
			Me.cbExplodeMode.TabIndex = 1
'			Me.cbExplodeMode.SelectedIndexChanged += New System.EventHandler(Me.cbExplodeMode_SelectedIndexChanged);
			' 
			' labelPosition
			' 
			Me.labelPosition.Location = New System.Drawing.Point(12, 12)
			Me.labelPosition.Margin = New System.Windows.Forms.Padding(10, 10, 3, 10)
			Me.labelPosition.Name = "labelPosition"
			Me.labelPosition.Size = New System.Drawing.Size(69, 13)
			Me.labelPosition.TabIndex = 12
			Me.labelPosition.Text = "Label Position:"
			' 
			' label1
			' 
			Me.label1.Location = New System.Drawing.Point(12, 40)
			Me.label1.Margin = New System.Windows.Forms.Padding(10, 10, 3, 10)
			Me.label1.Name = "label1"
			Me.label1.Size = New System.Drawing.Size(80, 13)
			Me.label1.TabIndex = 13
			Me.label1.Text = "Exploded Points:"
			' 
			' PieDemo
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.chart)
			Me.Name = "PieDemo"
			Me.Controls.SetChildIndex(Me.panelRoot, 0)
			Me.Controls.SetChildIndex(Me.chart, 0)
			CType(Me.panel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panel.ResumeLayout(False)
			Me.panel.PerformLayout()
			CType(Me.checkEditShowLabels.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panelRoot.ResumeLayout(False)
			CType(pieSeriesLabel1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(pieSeriesView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(series1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(pieSeriesLabel2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(pieSeriesView2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.chart, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.checkEditValueAsPercent.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.cbLabelPosition.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.cbExplodeMode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region
		Private components As System.ComponentModel.IContainer = Nothing
		Private WithEvents cbLabelPosition As DevExpress.XtraEditors.ComboBoxEdit
		Private WithEvents cbExplodeMode As DevExpress.XtraEditors.ComboBoxEdit
		Private label1 As DevExpress.XtraEditors.LabelControl
		Private labelPosition As DevExpress.XtraEditors.LabelControl

	End Class
End Namespace
