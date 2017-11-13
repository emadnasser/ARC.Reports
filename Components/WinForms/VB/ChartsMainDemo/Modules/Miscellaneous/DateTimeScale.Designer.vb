Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.XtraCharts.Demos.Miscellaneous
	Partial Public Class DateTimeScaleDemo
		''' <summary> 
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary> 
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Component Designer generated code"

		''' <summary> 
		''' Required method for Designer support - do not modify 
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Dim xyDiagram1 As New DevExpress.XtraCharts.XYDiagram()
			Dim series1 As New DevExpress.XtraCharts.Series()
			Dim chartTitle1 As New DevExpress.XtraCharts.ChartTitle()
			Me.chart = New DevExpress.XtraCharts.ChartControl()
			Me.labelControl1 = New DevExpress.XtraEditors.LabelControl()
			Me.cbAggregateFunction = New DevExpress.XtraEditors.ComboBoxEdit()
			Me.labelControl2 = New DevExpress.XtraEditors.LabelControl()
			Me.cbMeasureUnit = New DevExpress.XtraEditors.ComboBoxEdit()
			Me.cbGridAlignment = New DevExpress.XtraEditors.ComboBoxEdit()
			Me.labelControl3 = New DevExpress.XtraEditors.LabelControl()
			Me.labelControl4 = New DevExpress.XtraEditors.LabelControl()
			Me.cbScaleMode = New DevExpress.XtraEditors.ComboBoxEdit()
			Me.chbAutoGrid = New DevExpress.XtraEditors.CheckEdit()
			CType(Me.panel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panel.SuspendLayout()
			CType(Me.checkEditShowLabels.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panelRoot.SuspendLayout()
			CType(Me.chart, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(xyDiagram1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(series1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.cbAggregateFunction.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.cbMeasureUnit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.cbGridAlignment.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.cbScaleMode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.chbAutoGrid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' panel
			' 
			Me.panel.Controls.Add(Me.chbAutoGrid)
			Me.panel.Controls.Add(Me.cbScaleMode)
			Me.panel.Controls.Add(Me.cbGridAlignment)
			Me.panel.Controls.Add(Me.labelControl3)
			Me.panel.Controls.Add(Me.cbMeasureUnit)
			Me.panel.Controls.Add(Me.labelControl2)
			Me.panel.Controls.Add(Me.cbAggregateFunction)
			Me.panel.Controls.Add(Me.labelControl4)
			Me.panel.Controls.Add(Me.labelControl1)
			Me.panel.Size = New System.Drawing.Size(700, 64)
			Me.panel.Controls.SetChildIndex(Me.labelControl1, 0)
			Me.panel.Controls.SetChildIndex(Me.labelControl4, 0)
			Me.panel.Controls.SetChildIndex(Me.cbAggregateFunction, 0)
			Me.panel.Controls.SetChildIndex(Me.labelControl2, 0)
			Me.panel.Controls.SetChildIndex(Me.cbMeasureUnit, 0)
			Me.panel.Controls.SetChildIndex(Me.labelControl3, 0)
			Me.panel.Controls.SetChildIndex(Me.cbGridAlignment, 0)
			Me.panel.Controls.SetChildIndex(Me.cbScaleMode, 0)
			Me.panel.Controls.SetChildIndex(Me.checkEditShowLabels, 0)
			Me.panel.Controls.SetChildIndex(Me.chbAutoGrid, 0)
			' 
			' checkEditShowLabels
			' 
			Me.checkEditShowLabels.Size = New System.Drawing.Size(82, 19)
			' 
			' panelRoot
			' 
			Me.panelRoot.Size = New System.Drawing.Size(700, 72)
			' 
			' chart
			' 
			Me.chart.CrosshairEnabled = DevExpress.Utils.DefaultBoolean.False
			Me.chart.DataBindings = Nothing
			xyDiagram1.AxisX.GridLines.Visible = True
			xyDiagram1.AxisX.MinorCount = 3
			xyDiagram1.AxisX.Title.Text = "Date"
			xyDiagram1.AxisX.VisibleInPanesSerializable = "-1"
			xyDiagram1.AxisY.GridLines.MinorVisible = True
			xyDiagram1.AxisY.Title.Text = "Thousands of Dollars"
			xyDiagram1.AxisY.Title.Visibility = DevExpress.Utils.DefaultBoolean.True
			xyDiagram1.AxisY.VisibleInPanesSerializable = "-1"
			Me.chart.Diagram = xyDiagram1
			Me.chart.Dock = System.Windows.Forms.DockStyle.Fill
			Me.chart.Legend.Name = "Default Legend"
			Me.chart.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False
			Me.chart.Location = New System.Drawing.Point(0, 72)
			Me.chart.Name = "chart"
			series1.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.DateTime
			series1.LabelsVisibility = DevExpress.Utils.DefaultBoolean.False
			series1.Name = "Orders"
			Me.chart.SeriesSerializable = New DevExpress.XtraCharts.Series() { series1}
			Me.chart.Size = New System.Drawing.Size(700, 428)
			Me.chart.TabIndex = 1
			Me.chart.TabStop = False
			chartTitle1.Text = "Orders"
			Me.chart.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() { chartTitle1})
			' 
			' labelControl1
			' 
			Me.labelControl1.Location = New System.Drawing.Point(12, 40)
			Me.labelControl1.Name = "labelControl1"
			Me.labelControl1.Size = New System.Drawing.Size(67, 13)
			Me.labelControl1.TabIndex = 3
			Me.labelControl1.Text = "Measure Unit:"
			' 
			' cbAggregateFunction
			' 
			Me.cbAggregateFunction.Location = New System.Drawing.Point(326, 37)
			Me.cbAggregateFunction.Name = "cbAggregateFunction"
			Me.cbAggregateFunction.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.cbAggregateFunction.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
			Me.cbAggregateFunction.Size = New System.Drawing.Size(108, 20)
			Me.cbAggregateFunction.TabIndex = 4
'			Me.cbAggregateFunction.SelectedIndexChanged += New System.EventHandler(Me.ComboBoxSelectedValueChanged);
			' 
			' labelControl2
			' 
			Me.labelControl2.Location = New System.Drawing.Point(221, 40)
			Me.labelControl2.Name = "labelControl2"
			Me.labelControl2.Size = New System.Drawing.Size(99, 13)
			Me.labelControl2.TabIndex = 5
			Me.labelControl2.Text = "Aggregate Function:"
			' 
			' cbMeasureUnit
			' 
			Me.cbMeasureUnit.Location = New System.Drawing.Point(85, 37)
			Me.cbMeasureUnit.Name = "cbMeasureUnit"
			Me.cbMeasureUnit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.cbMeasureUnit.Properties.DropDownRows = 11
			Me.cbMeasureUnit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
			Me.cbMeasureUnit.Size = New System.Drawing.Size(108, 20)
			Me.cbMeasureUnit.TabIndex = 6
'			Me.cbMeasureUnit.SelectedValueChanged += New System.EventHandler(Me.ComboBoxSelectedValueChanged);
			' 
			' cbGridAlignment
			' 
			Me.cbGridAlignment.Location = New System.Drawing.Point(326, 9)
			Me.cbGridAlignment.Name = "cbGridAlignment"
			Me.cbGridAlignment.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.cbGridAlignment.Properties.DropDownRows = 11
			Me.cbGridAlignment.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
			Me.cbGridAlignment.Size = New System.Drawing.Size(108, 20)
			Me.cbGridAlignment.TabIndex = 8
'			Me.cbGridAlignment.SelectedValueChanged += New System.EventHandler(Me.ComboBoxSelectedValueChanged);
			' 
			' labelControl3
			' 
			Me.labelControl3.Location = New System.Drawing.Point(221, 12)
			Me.labelControl3.Name = "labelControl3"
			Me.labelControl3.Size = New System.Drawing.Size(73, 13)
			Me.labelControl3.TabIndex = 7
			Me.labelControl3.Text = "Grid Alignment:"
			' 
			' labelControl4
			' 
			Me.labelControl4.Location = New System.Drawing.Point(12, 12)
			Me.labelControl4.Name = "labelControl4"
			Me.labelControl4.Size = New System.Drawing.Size(58, 13)
			Me.labelControl4.TabIndex = 3
			Me.labelControl4.Text = "Scale Mode:"
			' 
			' cbScaleMode
			' 
			Me.cbScaleMode.Location = New System.Drawing.Point(85, 9)
			Me.cbScaleMode.Name = "cbScaleMode"
			Me.cbScaleMode.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.cbScaleMode.Properties.DropDownRows = 11
			Me.cbScaleMode.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
			Me.cbScaleMode.Size = New System.Drawing.Size(108, 20)
			Me.cbScaleMode.TabIndex = 10
'			Me.cbScaleMode.SelectedValueChanged += New System.EventHandler(Me.ComboBoxSelectedValueChanged);
			' 
			' chbAutoGrid
			' 
			Me.chbAutoGrid.Location = New System.Drawing.Point(457, 9)
			Me.chbAutoGrid.Margin = New System.Windows.Forms.Padding(10, 3, 3, 3)
			Me.chbAutoGrid.Name = "chbAutoGrid"
			Me.chbAutoGrid.Properties.Caption = "Auto Grid"
			Me.chbAutoGrid.Size = New System.Drawing.Size(99, 19)
			Me.chbAutoGrid.TabIndex = 11
'			Me.chbAutoGrid.CheckedChanged += New System.EventHandler(Me.chbAutoGrid_CheckedChanged);
			' 
			' DateTimeScaleDemo
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.chart)
			Me.Name = "DateTimeScaleDemo"
			Me.Controls.SetChildIndex(Me.panelRoot, 0)
			Me.Controls.SetChildIndex(Me.chart, 0)
			CType(Me.panel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panel.ResumeLayout(False)
			Me.panel.PerformLayout()
			CType(Me.checkEditShowLabels.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panelRoot.ResumeLayout(False)
			CType(xyDiagram1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(series1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.chart, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.cbAggregateFunction.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.cbMeasureUnit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.cbGridAlignment.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.cbScaleMode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.chbAutoGrid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private chart As ChartControl
		Private labelControl1 As DevExpress.XtraEditors.LabelControl
		Private labelControl2 As XtraEditors.LabelControl
		Private WithEvents cbAggregateFunction As XtraEditors.ComboBoxEdit
		Private WithEvents cbMeasureUnit As XtraEditors.ComboBoxEdit
		Private WithEvents cbGridAlignment As XtraEditors.ComboBoxEdit
		Private labelControl3 As XtraEditors.LabelControl
		Private WithEvents cbScaleMode As XtraEditors.ComboBoxEdit
		Private labelControl4 As XtraEditors.LabelControl
		Private WithEvents chbAutoGrid As XtraEditors.CheckEdit
	End Class
End Namespace
