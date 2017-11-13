Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.XtraCharts.Demos.BarViews
	Partial Public Class StackedBarDemo
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
			Dim stackedBarSeriesLabel1 As New DevExpress.XtraCharts.StackedBarSeriesLabel()
			Dim stackedBarSeriesView1 As New DevExpress.XtraCharts.StackedBarSeriesView()
			Dim chartTitle1 As New DevExpress.XtraCharts.ChartTitle()
			Dim chartTitle2 As New DevExpress.XtraCharts.ChartTitle()
			Me.chart = New DevExpress.XtraCharts.ChartControl()
			Me.cbLabelPosition = New DevExpress.XtraEditors.ComboBoxEdit()
			Me.cbTextOrientation = New DevExpress.XtraEditors.ComboBoxEdit()
			Me.labelTextOrientation = New DevExpress.XtraEditors.LabelControl()
			Me.labelPosition = New DevExpress.XtraEditors.LabelControl()
			Me.labelIndent = New DevExpress.XtraEditors.LabelControl()
			Me.spnLabelIndent = New DevExpress.XtraEditors.SpinEdit()
			CType(Me.panel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panel.SuspendLayout()
			CType(Me.checkEditShowLabels.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panelRoot.SuspendLayout()
			CType(Me.chart, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(xyDiagram1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(stackedBarSeriesLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(stackedBarSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.cbLabelPosition.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.cbTextOrientation.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.spnLabelIndent.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' panel
			' 
			Me.panel.Controls.Add(Me.labelIndent)
			Me.panel.Controls.Add(Me.spnLabelIndent)
			Me.panel.Controls.Add(Me.cbLabelPosition)
			Me.panel.Controls.Add(Me.cbTextOrientation)
			Me.panel.Controls.Add(Me.labelTextOrientation)
			Me.panel.Controls.Add(Me.labelPosition)
			Me.panel.Controls.SetChildIndex(Me.checkEditShowLabels, 0)
			Me.panel.Controls.SetChildIndex(Me.labelPosition, 0)
			Me.panel.Controls.SetChildIndex(Me.labelTextOrientation, 0)
			Me.panel.Controls.SetChildIndex(Me.cbTextOrientation, 0)
			Me.panel.Controls.SetChildIndex(Me.cbLabelPosition, 0)
			Me.panel.Controls.SetChildIndex(Me.spnLabelIndent, 0)
			Me.panel.Controls.SetChildIndex(Me.labelIndent, 0)
			' 
			' checkEditShowLabels
			' 
			Me.checkEditShowLabels.Size = New System.Drawing.Size(82, 19)
			Me.checkEditShowLabels.TabIndex = 3
			' 
			' chart
			' 
			Me.chart.AnimationStartMode = DevExpress.XtraCharts.ChartAnimationMode.OnDataChanged
			Me.chart.CrosshairOptions.GroupHeaderPattern = "Country: {A}"
			Me.chart.DataBindings = Nothing
			xyDiagram1.AxisX.Tickmarks.MinorVisible = False
			xyDiagram1.AxisX.Title.Text = "Countries"
			xyDiagram1.AxisX.VisibleInPanesSerializable = "-1"
			xyDiagram1.AxisX.WholeRange.AutoSideMargins = False
			xyDiagram1.AxisX.WholeRange.SideMarginsValue = 0.65R
			xyDiagram1.AxisY.GridLines.MinorVisible = True
			xyDiagram1.AxisY.Label.TextPattern = "{V:0,,}"
			xyDiagram1.AxisY.Title.Text = "Millions"
			xyDiagram1.AxisY.Title.Visibility = DevExpress.Utils.DefaultBoolean.True
			xyDiagram1.AxisY.VisibleInPanesSerializable = "-1"
			xyDiagram1.Rotated = True
			Me.chart.Diagram = xyDiagram1
			Me.chart.Dock = System.Windows.Forms.DockStyle.Fill
			Me.chart.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Right
			Me.chart.Legend.Direction = DevExpress.XtraCharts.LegendDirection.BottomToTop
			Me.chart.Legend.Name = "Default Legend"
			Me.chart.Location = New System.Drawing.Point(0, 74)
			Me.chart.Name = "chart"
			Me.chart.SeriesDataMember = "Age"
			Me.chart.SeriesSerializable = New DevExpress.XtraCharts.Series(){}
			Me.chart.SeriesTemplate.ArgumentDataMember = "Country"
			Me.chart.SeriesTemplate.CrosshairLabelPattern = "Age: {S}" & Constants.vbLf & "Population: {V:0,,.0}M"
			stackedBarSeriesLabel1.TextPattern = "{V:0,,.0}"
			Me.chart.SeriesTemplate.Label = stackedBarSeriesLabel1
			Me.chart.SeriesTemplate.LabelsVisibility = DevExpress.Utils.DefaultBoolean.True
			Me.chart.SeriesTemplate.ValueDataMembersSerializable = "Population"
			stackedBarSeriesView1.BarWidth = 0.7R
			Me.chart.SeriesTemplate.View = stackedBarSeriesView1
			Me.chart.Size = New System.Drawing.Size(700, 426)
			Me.chart.TabIndex = 1
			Me.chart.TabStop = False
			chartTitle1.Text = "Male Age Structure"
			chartTitle2.Alignment = System.Drawing.StringAlignment.Far
			chartTitle2.Dock = DevExpress.XtraCharts.ChartTitleDockStyle.Bottom
			chartTitle2.Font = New System.Drawing.Font("Tahoma", 8F)
			chartTitle2.Text = "From www.cia.gov"
			chartTitle2.TextColor = System.Drawing.Color.Gray
			Me.chart.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() { chartTitle1, chartTitle2})
			' 
			' cbLabelPosition
			' 
			Me.cbLabelPosition.EditValue = "Center"
			Me.cbLabelPosition.Location = New System.Drawing.Point(84, 9)
			Me.cbLabelPosition.Name = "cbLabelPosition"
			Me.cbLabelPosition.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.cbLabelPosition.Properties.Items.AddRange(New Object() { "Top Inside", "Center", "Bottom Inside"})
			Me.cbLabelPosition.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
			Me.cbLabelPosition.Size = New System.Drawing.Size(100, 20)
			Me.cbLabelPosition.TabIndex = 0
'			Me.cbLabelPosition.SelectedIndexChanged += New System.EventHandler(Me.cbLabelPosition_SelectedIndexChanged);
			' 
			' cbTextOrientation
			' 
			Me.cbTextOrientation.EditValue = "Horizontal"
			Me.cbTextOrientation.Location = New System.Drawing.Point(84, 37)
			Me.cbTextOrientation.Name = "cbTextOrientation"
			Me.cbTextOrientation.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.cbTextOrientation.Properties.Items.AddRange(New Object() { "Horizontal", "Top To Bottom", "Bottom To Top"})
			Me.cbTextOrientation.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
			Me.cbTextOrientation.Size = New System.Drawing.Size(100, 20)
			Me.cbTextOrientation.TabIndex = 2
'			Me.cbTextOrientation.SelectedIndexChanged += New System.EventHandler(Me.cbTextOrientation_SelectedIndexChanged);
			' 
			' labelTextOrientation
			' 
			Me.labelTextOrientation.Location = New System.Drawing.Point(12, 40)
			Me.labelTextOrientation.Name = "labelTextOrientation"
			Me.labelTextOrientation.Size = New System.Drawing.Size(58, 13)
			Me.labelTextOrientation.TabIndex = 16
			Me.labelTextOrientation.Text = "Orientation:"
			' 
			' labelPosition
			' 
			Me.labelPosition.Location = New System.Drawing.Point(12, 12)
			Me.labelPosition.Margin = New System.Windows.Forms.Padding(0)
			Me.labelPosition.Name = "labelPosition"
			Me.labelPosition.Size = New System.Drawing.Size(69, 13)
			Me.labelPosition.TabIndex = 15
			Me.labelPosition.Text = "Label Position:"
			' 
			' labelIndent
			' 
			Me.labelIndent.Location = New System.Drawing.Point(200, 12)
			Me.labelIndent.Margin = New System.Windows.Forms.Padding(0)
			Me.labelIndent.Name = "labelIndent"
			Me.labelIndent.Size = New System.Drawing.Size(64, 13)
			Me.labelIndent.TabIndex = 26
			Me.labelIndent.Text = "Label Indent:"
			' 
			' spnLabelIndent
			' 
			Me.spnLabelIndent.EditValue = New Decimal(New Integer() { 2, 0, 0, 0})
			Me.spnLabelIndent.Location = New System.Drawing.Point(267, 9)
			Me.spnLabelIndent.Name = "spnLabelIndent"
			Me.spnLabelIndent.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
			Me.spnLabelIndent.Properties.IsFloatValue = False
			Me.spnLabelIndent.Properties.Mask.EditMask = "N00"
			Me.spnLabelIndent.Properties.MaxValue = New Decimal(New Integer() { 500, 0, 0, 0})
			Me.spnLabelIndent.Properties.ValidateOnEnterKey = True
			Me.spnLabelIndent.Size = New System.Drawing.Size(60, 20)
			Me.spnLabelIndent.TabIndex = 1
'			Me.spnLabelIndent.EditValueChanged += New System.EventHandler(Me.spnLabelIndent_EditValueChanged);
			' 
			' StackedBarDemo
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.chart)
			Me.Name = "StackedBarDemo"
			Me.Controls.SetChildIndex(Me.panelRoot, 0)
			Me.Controls.SetChildIndex(Me.chart, 0)
			CType(Me.panel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panel.ResumeLayout(False)
			Me.panel.PerformLayout()
			CType(Me.checkEditShowLabels.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panelRoot.ResumeLayout(False)
			CType(xyDiagram1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(stackedBarSeriesLabel1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(stackedBarSeriesView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.chart, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.cbLabelPosition.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.cbTextOrientation.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.spnLabelIndent.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region
		Private components As System.ComponentModel.IContainer = Nothing
		Private WithEvents cbLabelPosition As DevExpress.XtraEditors.ComboBoxEdit
		Private WithEvents cbTextOrientation As DevExpress.XtraEditors.ComboBoxEdit
		Private labelTextOrientation As DevExpress.XtraEditors.LabelControl
		Private labelPosition As DevExpress.XtraEditors.LabelControl
		Private labelIndent As DevExpress.XtraEditors.LabelControl
		Private WithEvents spnLabelIndent As DevExpress.XtraEditors.SpinEdit

	End Class
End Namespace
