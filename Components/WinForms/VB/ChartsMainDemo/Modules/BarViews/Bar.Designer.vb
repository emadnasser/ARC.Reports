Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.XtraCharts.Demos.BarViews
	Partial Public Class BarDemo
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
			Dim chartTitle1 As New DevExpress.XtraCharts.ChartTitle()
			Me.chart = New DevExpress.XtraCharts.ChartControl()
			Me.labelPosition = New DevExpress.XtraEditors.LabelControl()
			Me.labelTextOrientation = New DevExpress.XtraEditors.LabelControl()
			Me.cbTextOrientation = New DevExpress.XtraEditors.ComboBoxEdit()
			Me.cbLabelPosition = New DevExpress.XtraEditors.ComboBoxEdit()
			Me.labelIndent = New DevExpress.XtraEditors.LabelControl()
			Me.spnLabelIndent = New DevExpress.XtraEditors.SpinEdit()
			CType(Me.panel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panel.SuspendLayout()
			CType(Me.checkEditShowLabels.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panelRoot.SuspendLayout()
			CType(Me.chart, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(xyDiagram1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.cbTextOrientation.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.cbLabelPosition.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
			Me.chart.DataBindings = Nothing
			xyDiagram1.AxisX.Tickmarks.MinorVisible = False
			xyDiagram1.AxisX.Title.Text = "States"
			xyDiagram1.AxisX.VisibleInPanesSerializable = "-1"
			xyDiagram1.AxisY.Interlaced = True
			xyDiagram1.AxisY.NumericScaleOptions.AutoGrid = False
			xyDiagram1.AxisY.Title.Text = "Millions of Dollars"
			xyDiagram1.AxisY.Title.Visibility = DevExpress.Utils.DefaultBoolean.True
			xyDiagram1.AxisY.VisibleInPanesSerializable = "-1"
			xyDiagram1.AxisY.VisualRange.Auto = False
			xyDiagram1.AxisY.VisualRange.MaxValueSerializable = "6"
			xyDiagram1.AxisY.VisualRange.MinValueSerializable = "0"
			xyDiagram1.AxisY.WholeRange.Auto = False
			xyDiagram1.AxisY.WholeRange.AutoSideMargins = False
			xyDiagram1.AxisY.WholeRange.MaxValueSerializable = "6"
			xyDiagram1.AxisY.WholeRange.MinValueSerializable = "0"
			xyDiagram1.AxisY.WholeRange.SideMarginsValue = 0R
			Me.chart.Diagram = xyDiagram1
			Me.chart.Dock = System.Windows.Forms.DockStyle.Fill
			Me.chart.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Right
			Me.chart.Legend.Name = "Default Legend"
			Me.chart.Location = New System.Drawing.Point(0, 74)
			Me.chart.Name = "chart"
			Me.chart.SeriesDataMember = "Year"
			Me.chart.SeriesSerializable = New DevExpress.XtraCharts.Series(){}
			Me.chart.SeriesTemplate.ArgumentDataMember = "Region"
			Me.chart.SeriesTemplate.CrosshairLabelPattern = "Year: {S}" & Constants.vbLf & "GSP:   ${V}M"
			Me.chart.SeriesTemplate.LabelsVisibility = DevExpress.Utils.DefaultBoolean.True
			Me.chart.SeriesTemplate.ValueDataMembersSerializable = "Sales"
			Me.chart.Size = New System.Drawing.Size(700, 426)
			Me.chart.TabIndex = 1
			Me.chart.TabStop = False
			chartTitle1.Text = "DevAV Sales by Regions"
			Me.chart.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() { chartTitle1})
			' 
			' labelPosition
			' 
			Me.labelPosition.Location = New System.Drawing.Point(12, 12)
			Me.labelPosition.Margin = New System.Windows.Forms.Padding(0)
			Me.labelPosition.Name = "labelPosition"
			Me.labelPosition.Size = New System.Drawing.Size(69, 13)
			Me.labelPosition.TabIndex = 11
			Me.labelPosition.Text = "Label Position:"
			' 
			' labelTextOrientation
			' 
			Me.labelTextOrientation.Location = New System.Drawing.Point(12, 40)
			Me.labelTextOrientation.Name = "labelTextOrientation"
			Me.labelTextOrientation.Size = New System.Drawing.Size(58, 13)
			Me.labelTextOrientation.TabIndex = 12
			Me.labelTextOrientation.Text = "Orientation:"
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
			' cbLabelPosition
			' 
			Me.cbLabelPosition.EditValue = "Auto"
			Me.cbLabelPosition.Location = New System.Drawing.Point(84, 9)
			Me.cbLabelPosition.Name = "cbLabelPosition"
			Me.cbLabelPosition.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.cbLabelPosition.Properties.Items.AddRange(New Object() { "Auto", "Top", "Top Inside", "Center", "Bottom Inside"})
			Me.cbLabelPosition.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
			Me.cbLabelPosition.Size = New System.Drawing.Size(100, 20)
			Me.cbLabelPosition.TabIndex = 0
'			Me.cbLabelPosition.SelectedIndexChanged += New System.EventHandler(Me.cbLabelPosition_SelectedIndexChanged);
			' 
			' labelIndent
			' 
			Me.labelIndent.Location = New System.Drawing.Point(200, 12)
			Me.labelIndent.Margin = New System.Windows.Forms.Padding(0)
			Me.labelIndent.Name = "labelIndent"
			Me.labelIndent.Size = New System.Drawing.Size(64, 13)
			Me.labelIndent.TabIndex = 28
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
			' BarDemo
			' 
			Me.Appearance.Options.UseFont = True
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.chart)
			Me.Name = "BarDemo"
			Me.Controls.SetChildIndex(Me.panelRoot, 0)
			Me.Controls.SetChildIndex(Me.chart, 0)
			CType(Me.panel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panel.ResumeLayout(False)
			Me.panel.PerformLayout()
			CType(Me.checkEditShowLabels.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panelRoot.ResumeLayout(False)
			CType(xyDiagram1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.chart, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.cbTextOrientation.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.cbLabelPosition.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.spnLabelIndent.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region
		Private components As System.ComponentModel.IContainer = Nothing
		Private labelPosition As DevExpress.XtraEditors.LabelControl
		Private WithEvents cbTextOrientation As DevExpress.XtraEditors.ComboBoxEdit
		Private labelTextOrientation As DevExpress.XtraEditors.LabelControl
		Private WithEvents cbLabelPosition As DevExpress.XtraEditors.ComboBoxEdit
		Private labelIndent As DevExpress.XtraEditors.LabelControl
		Private WithEvents spnLabelIndent As DevExpress.XtraEditors.SpinEdit

	End Class
End Namespace
