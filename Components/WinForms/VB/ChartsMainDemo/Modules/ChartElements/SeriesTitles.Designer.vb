Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.XtraCharts.Demos.ChartElements
	Partial Public Class SeriesTitlesDemo
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
			Dim pieSeriesLabel1 As New DevExpress.XtraCharts.PieSeriesLabel()
			Dim pieSeriesView1 As New DevExpress.XtraCharts.PieSeriesView()
			Dim seriesTitle1 As New DevExpress.XtraCharts.SeriesTitle()
			Dim chartTitle1 As New DevExpress.XtraCharts.ChartTitle()
			Me.chart = New DevExpress.XtraCharts.ChartControl()
			Me.comboBoxViewType = New DevExpress.XtraEditors.ComboBoxEdit()
			Me.labelViewType = New DevExpress.XtraEditors.LabelControl()
			CType(Me.panel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panel.SuspendLayout()
			CType(Me.checkEditShowLabels.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panelRoot.SuspendLayout()
			CType(Me.chart, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(pieSeriesLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(pieSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.comboBoxViewType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' panel
			' 
			Me.panel.Controls.Add(Me.labelViewType)
			Me.panel.Controls.Add(Me.comboBoxViewType)
			Me.panel.Margin = New System.Windows.Forms.Padding(10, 9, 10, 9)
			Me.panel.Size = New System.Drawing.Size(700, 38)
			Me.panel.Controls.SetChildIndex(Me.checkEditShowLabels, 0)
			Me.panel.Controls.SetChildIndex(Me.comboBoxViewType, 0)
			Me.panel.Controls.SetChildIndex(Me.labelViewType, 0)
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
			Me.chart.AnimationStartMode = DevExpress.XtraCharts.ChartAnimationMode.OnDataChanged
			Me.chart.AutoLayout = False
			Me.chart.Cursor = System.Windows.Forms.Cursors.Default
			Me.chart.DataBindings = Nothing
			Me.chart.Dock = System.Windows.Forms.DockStyle.Fill
			Me.chart.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Center
			Me.chart.Legend.AlignmentVertical = DevExpress.XtraCharts.LegendAlignmentVertical.BottomOutside
			Me.chart.Legend.Direction = DevExpress.XtraCharts.LegendDirection.LeftToRight
			Me.chart.Legend.MaxHorizontalPercentage = 60R
			Me.chart.Legend.Name = "Default Legend"
			Me.chart.Location = New System.Drawing.Point(0, 46)
			Me.chart.Name = "chart"
			Me.chart.SeriesDataMember = "Region"
			Me.chart.SeriesSerializable = New DevExpress.XtraCharts.Series(){}
			Me.chart.SeriesTemplate.ArgumentDataMember = "ProductCategory"
			pieSeriesLabel1.TextPattern = "${V:F1}M"
			Me.chart.SeriesTemplate.Label = pieSeriesLabel1
			Me.chart.SeriesTemplate.LabelsVisibility = DevExpress.Utils.DefaultBoolean.False
			Me.chart.SeriesTemplate.LegendTextPattern = "{A}"
			Me.chart.SeriesTemplate.ToolTipPointPattern = "{A}: {V}K ({VP:0.0%})"
			Me.chart.SeriesTemplate.ValueDataMembersSerializable = "Sales"
			seriesTitle1.Font = New System.Drawing.Font("Tahoma", 16F)
			pieSeriesView1.Titles.AddRange(New DevExpress.XtraCharts.SeriesTitle() { seriesTitle1})
			Me.chart.SeriesTemplate.View = pieSeriesView1
			Me.chart.Size = New System.Drawing.Size(700, 454)
			Me.chart.TabIndex = 1
			chartTitle1.Text = "DevAV Sales Mix by Region"
			Me.chart.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() { chartTitle1})
			Me.chart.ToolTipEnabled = DevExpress.Utils.DefaultBoolean.True
'			Me.chart.CustomDrawSeriesPoint += New DevExpress.XtraCharts.CustomDrawSeriesPointEventHandler(Me.chart_CustomDrawSeriesPoint);
			' 
			' comboBoxViewType
			' 
			Me.comboBoxViewType.EditValue = "Pie"
			Me.comboBoxViewType.Location = New System.Drawing.Point(71, 9)
			Me.comboBoxViewType.Margin = New System.Windows.Forms.Padding(3, 0, 10, 0)
			Me.comboBoxViewType.Name = "comboBoxViewType"
			Me.comboBoxViewType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.comboBoxViewType.Properties.Items.AddRange(New Object() { "Pie", "Pie 3D", "Doughnut", "Doughnut 3D"})
			Me.comboBoxViewType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
			Me.comboBoxViewType.Size = New System.Drawing.Size(90, 20)
			Me.comboBoxViewType.TabIndex = 2
'			Me.comboBoxViewType.SelectedIndexChanged += New System.EventHandler(Me.comboBoxEditSeriesDataMember_SelectedIndexChanged);
			' 
			' labelViewType
			' 
			Me.labelViewType.Location = New System.Drawing.Point(12, 12)
			Me.labelViewType.Margin = New System.Windows.Forms.Padding(0, 10, 3, 10)
			Me.labelViewType.Name = "labelViewType"
			Me.labelViewType.Size = New System.Drawing.Size(53, 13)
			Me.labelViewType.TabIndex = 59
			Me.labelViewType.Text = "View Type:"
			' 
			' SeriesTitlesDemo
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.chart)
			Me.Name = "SeriesTitlesDemo"
			Me.Controls.SetChildIndex(Me.panelRoot, 0)
			Me.Controls.SetChildIndex(Me.chart, 0)
			CType(Me.panel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panel.ResumeLayout(False)
			Me.panel.PerformLayout()
			CType(Me.checkEditShowLabels.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panelRoot.ResumeLayout(False)
			CType(pieSeriesLabel1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(pieSeriesView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.chart, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.comboBoxViewType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region
		Private components As System.ComponentModel.IContainer = Nothing
		Private WithEvents chart As ChartControl
		Private WithEvents comboBoxViewType As DevExpress.XtraEditors.ComboBoxEdit
		Private labelViewType As DevExpress.XtraEditors.LabelControl

	End Class
End Namespace
