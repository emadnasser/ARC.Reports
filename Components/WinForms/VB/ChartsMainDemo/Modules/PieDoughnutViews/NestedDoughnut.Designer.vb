Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.XtraCharts.Demos.PieDoughnutViews
	Partial Public Class NestedDoughnutDemo
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
			Dim nestedDoughnutSeriesLabel1 As New DevExpress.XtraCharts.NestedDoughnutSeriesLabel()
			Dim nestedDoughnutSeriesView1 As New DevExpress.XtraCharts.NestedDoughnutSeriesView()
			Dim pieWidenAnimation1 As New DevExpress.XtraCharts.PieWidenAnimation()
			Dim chartTitle1 As New DevExpress.XtraCharts.ChartTitle()
			Dim chartTitle2 As New DevExpress.XtraCharts.ChartTitle()
			Dim chartTitle3 As New DevExpress.XtraCharts.ChartTitle()
			Me.chart = New DevExpress.XtraCharts.ChartControl()
			Me.labelHoleRadius = New DevExpress.XtraEditors.LabelControl()
			Me.labelIndent = New DevExpress.XtraEditors.LabelControl()
			Me.cbInnerIndent = New DevExpress.XtraEditors.ComboBoxEdit()
			Me.lblGroup = New DevExpress.XtraEditors.LabelControl()
			Me.radioGroup = New DevExpress.XtraEditors.RadioGroup()
			Me.spinHoleRadius = New DevExpress.XtraEditors.SpinEdit()
			CType(Me.panel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panel.SuspendLayout()
			CType(Me.checkEditShowLabels.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panelRoot.SuspendLayout()
			CType(Me.chart, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(nestedDoughnutSeriesLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(nestedDoughnutSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.cbInnerIndent.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radioGroup.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.spinHoleRadius.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' panel
			' 
			Me.panel.Controls.Add(Me.lblGroup)
			Me.panel.Controls.Add(Me.radioGroup)
			Me.panel.Controls.Add(Me.cbInnerIndent)
			Me.panel.Controls.Add(Me.labelIndent)
			Me.panel.Controls.Add(Me.labelHoleRadius)
			Me.panel.Controls.Add(Me.spinHoleRadius)
			Me.panel.Controls.SetChildIndex(Me.spinHoleRadius, 0)
			Me.panel.Controls.SetChildIndex(Me.labelHoleRadius, 0)
			Me.panel.Controls.SetChildIndex(Me.labelIndent, 0)
			Me.panel.Controls.SetChildIndex(Me.cbInnerIndent, 0)
			Me.panel.Controls.SetChildIndex(Me.radioGroup, 0)
			Me.panel.Controls.SetChildIndex(Me.lblGroup, 0)
			Me.panel.Controls.SetChildIndex(Me.checkEditShowLabels, 0)
			' 
			' checkEditShowLabels
			' 
			Me.checkEditShowLabels.Size = New System.Drawing.Size(82, 19)
			Me.checkEditShowLabels.TabIndex = 5
			Me.checkEditShowLabels.Visible = False
			' 
			' chart
			' 
			Me.chart.AutoLayout = False
			Me.chart.DataBindings = Nothing
			Me.chart.Dock = System.Windows.Forms.DockStyle.Fill
			Me.chart.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Center
			Me.chart.Legend.AlignmentVertical = DevExpress.XtraCharts.LegendAlignmentVertical.Bottom
			Me.chart.Legend.Direction = DevExpress.XtraCharts.LegendDirection.LeftToRight
			Me.chart.Legend.EnableAntialiasing = DevExpress.Utils.DefaultBoolean.True
			Me.chart.Legend.Name = "Default Legend"
			Me.chart.Location = New System.Drawing.Point(0, 74)
			Me.chart.Name = "chart"
			Me.chart.SeriesDataMember = "CountryGenderKey"
			Me.chart.SeriesSerializable = New DevExpress.XtraCharts.Series(){}
			Me.chart.SeriesTemplate.ArgumentDataMember = "Age"
			Me.chart.SeriesTemplate.DataFilters.ClearAndAddRange(New DevExpress.XtraCharts.DataFilter() { New DevExpress.XtraCharts.DataFilter("Name", "System.String", DevExpress.XtraCharts.DataFilterCondition.Equal, "United States"), New DevExpress.XtraCharts.DataFilter("Name", "System.String", DevExpress.XtraCharts.DataFilterCondition.Equal, "Brazil"), New DevExpress.XtraCharts.DataFilter("Name", "System.String", DevExpress.XtraCharts.DataFilterCondition.Equal, "Russia")})
			Me.chart.SeriesTemplate.DataFiltersConjunctionMode = DevExpress.XtraCharts.ConjunctionTypes.Or
			nestedDoughnutSeriesLabel1.TextPattern = "{V:G2}"
			Me.chart.SeriesTemplate.Label = nestedDoughnutSeriesLabel1
			Me.chart.SeriesTemplate.LabelsVisibility = DevExpress.Utils.DefaultBoolean.False
			Me.chart.SeriesTemplate.LegendTextPattern = "{A}"
			Me.chart.SeriesTemplate.ShowInLegend = False
			Me.chart.SeriesTemplate.ToolTipHintDataMember = "Gender"
			Me.chart.SeriesTemplate.ToolTipPointPattern = "{HINT} : {VP:##.##%}"
			Me.chart.SeriesTemplate.ValueDataMembersSerializable = "Population"
			pieWidenAnimation1.PointDelay = System.TimeSpan.Parse("00:00:00.3000000")
			nestedDoughnutSeriesView1.Animation = pieWidenAnimation1
			Me.chart.SeriesTemplate.View = nestedDoughnutSeriesView1
			Me.chart.Size = New System.Drawing.Size(700, 426)
			Me.chart.TabIndex = 1
			Me.chart.TabStop = False
			chartTitle1.Text = "Population: Age Structure"
			chartTitle2.Alignment = System.Drawing.StringAlignment.Far
			chartTitle2.Dock = DevExpress.XtraCharts.ChartTitleDockStyle.Bottom
			chartTitle2.Font = New System.Drawing.Font("Tahoma", 8F)
			chartTitle2.Text = "From www.cia.gov"
			chartTitle2.TextColor = System.Drawing.Color.Gray
			chartTitle3.Font = New System.Drawing.Font("Tahoma", 12F)
			chartTitle3.Text = "Data estimate for end-2016"
			Me.chart.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() { chartTitle1, chartTitle2, chartTitle3})
			Me.chart.ToolTipEnabled = DevExpress.Utils.DefaultBoolean.True
'			Me.chart.BoundDataChanged += New DevExpress.XtraCharts.BoundDataChangedEventHandler(Me.chart_BoundDataChanged);
			' 
			' labelHoleRadius
			' 
			Me.labelHoleRadius.Location = New System.Drawing.Point(12, 12)
			Me.labelHoleRadius.Margin = New System.Windows.Forms.Padding(10, 10, 3, 10)
			Me.labelHoleRadius.Name = "labelHoleRadius"
			Me.labelHoleRadius.Size = New System.Drawing.Size(82, 13)
			Me.labelHoleRadius.TabIndex = 17
			Me.labelHoleRadius.Text = "Hole Radius (%):"
			' 
			' labelIndent
			' 
			Me.labelIndent.Location = New System.Drawing.Point(214, 12)
			Me.labelIndent.Margin = New System.Windows.Forms.Padding(10, 10, 3, 10)
			Me.labelIndent.Name = "labelIndent"
			Me.labelIndent.Size = New System.Drawing.Size(65, 13)
			Me.labelIndent.TabIndex = 17
			Me.labelIndent.Text = "Inner Indent:"
			' 
			' cbInnerIndent
			' 
			Me.cbInnerIndent.Location = New System.Drawing.Point(282, 9)
			Me.cbInnerIndent.Margin = New System.Windows.Forms.Padding(0, 10, 10, 0)
			Me.cbInnerIndent.Name = "cbInnerIndent"
			Me.cbInnerIndent.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.cbInnerIndent.Properties.Items.AddRange(New Object() { "5", "10", "20", "30"})
			Me.cbInnerIndent.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
			Me.cbInnerIndent.Size = New System.Drawing.Size(94, 20)
			Me.cbInnerIndent.TabIndex = 18
'			Me.cbInnerIndent.EditValueChanged += New System.EventHandler(Me.comboInnerIndent_EditValueChanged);
			' 
			' lblGroup
			' 
			Me.lblGroup.Location = New System.Drawing.Point(12, 40)
			Me.lblGroup.Name = "lblGroup"
			Me.lblGroup.Size = New System.Drawing.Size(80, 13)
			Me.lblGroup.TabIndex = 19
			Me.lblGroup.Text = "Group Series by:"
			' 
			' radioGroup
			' 
			Me.radioGroup.Location = New System.Drawing.Point(100, 36)
			Me.radioGroup.Name = "radioGroup"
			Me.radioGroup.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
			Me.radioGroup.Properties.Appearance.Options.UseBackColor = True
			Me.radioGroup.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.radioGroup.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() { New DevExpress.XtraEditors.Controls.RadioGroupItem(Nothing, "Gender"), New DevExpress.XtraEditors.Controls.RadioGroupItem(Nothing, "Age")})
			Me.radioGroup.RightToLeft = System.Windows.Forms.RightToLeft.No
			Me.radioGroup.Size = New System.Drawing.Size(123, 22)
			Me.radioGroup.TabIndex = 20
'			Me.radioGroup.SelectedIndexChanged += New System.EventHandler(Me.radioGroup_SelectedIndexChanged);
			' 
			' spinHoleRadius
			' 
			Me.spinHoleRadius.EditValue = New Decimal(New Integer() { 40, 0, 0, 0})
			Me.spinHoleRadius.Location = New System.Drawing.Point(100, 9)
			Me.spinHoleRadius.Margin = New System.Windows.Forms.Padding(0, 0, 10, 10)
			Me.spinHoleRadius.Name = "spinHoleRadius"
			Me.spinHoleRadius.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
			Me.spinHoleRadius.Properties.IsFloatValue = False
			Me.spinHoleRadius.Properties.Mask.EditMask = "N00"
			Me.spinHoleRadius.Properties.MaxValue = New Decimal(New Integer() { 100, 0, 0, 0})
			Me.spinHoleRadius.Properties.ValidateOnEnterKey = True
			Me.spinHoleRadius.Size = New System.Drawing.Size(94, 20)
			Me.spinHoleRadius.TabIndex = 2
'			Me.spinHoleRadius.EditValueChanged += New System.EventHandler(Me.spinHoleRadius_EditValueChanged);
			' 
			' NestedDoughnutDemo
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.chart)
			Me.Name = "NestedDoughnutDemo"
			Me.Controls.SetChildIndex(Me.panelRoot, 0)
			Me.Controls.SetChildIndex(Me.chart, 0)
			CType(Me.panel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panel.ResumeLayout(False)
			Me.panel.PerformLayout()
			CType(Me.checkEditShowLabels.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panelRoot.ResumeLayout(False)
			CType(nestedDoughnutSeriesLabel1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(nestedDoughnutSeriesView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.chart, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.cbInnerIndent.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radioGroup.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.spinHoleRadius.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region
		Private components As System.ComponentModel.IContainer = Nothing
		Private labelHoleRadius As DevExpress.XtraEditors.LabelControl
		Private labelIndent As XtraEditors.LabelControl
		Private WithEvents cbInnerIndent As XtraEditors.ComboBoxEdit
		Private lblGroup As XtraEditors.LabelControl
		Private WithEvents radioGroup As XtraEditors.RadioGroup
		Private WithEvents spinHoleRadius As XtraEditors.SpinEdit
	End Class
End Namespace
