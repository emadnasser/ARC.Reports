Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.XtraCharts.Demos.DataAnalysis

	Partial Public Class ErrorBarsDemo
		Private components As System.ComponentModel.IContainer = Nothing
		Private WithEvents cbeSeriesView As XtraEditors.ComboBoxEdit
		Private chartControl_Renamed As ChartControl
		Private lblSeriesView As XtraEditors.LabelControl

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
			Me.dataSet = New System.Data.DataSet()
			Me.dataTable1 = New System.Data.DataTable()
			Me.dataColumn1 = New System.Data.DataColumn()
			Me.dataColumn2 = New System.Data.DataColumn()
			Me.dataColumn3 = New System.Data.DataColumn()
			Me.dataColumn4 = New System.Data.DataColumn()
			Me.chartControl_Renamed = New DevExpress.XtraCharts.ChartControl()
			Me.cbeSeriesView = New DevExpress.XtraEditors.ComboBoxEdit()
			Me.lblSeriesView = New DevExpress.XtraEditors.LabelControl()
			Me.lblErrorBarKind = New DevExpress.XtraEditors.LabelControl()
			Me.cbeErrorBarsKind = New DevExpress.XtraEditors.ComboBoxEdit()
			Me.lblEndStyle = New DevExpress.XtraEditors.LabelControl()
			Me.cbeEndStyle = New DevExpress.XtraEditors.ComboBoxEdit()
			Me.lblDirection = New DevExpress.XtraEditors.LabelControl()
			Me.cbeDirection = New DevExpress.XtraEditors.ComboBoxEdit()
			CType(Me.panel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panel.SuspendLayout()
			CType(Me.checkEditShowLabels.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panelRoot.SuspendLayout()
			CType(Me.dataSet, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.dataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.chartControl_Renamed, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(xyDiagram1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(series1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.cbeSeriesView.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.cbeErrorBarsKind.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.cbeEndStyle.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.cbeDirection.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' panel
			' 
			Me.panel.Controls.Add(Me.cbeDirection)
			Me.panel.Controls.Add(Me.lblDirection)
			Me.panel.Controls.Add(Me.cbeEndStyle)
			Me.panel.Controls.Add(Me.lblEndStyle)
			Me.panel.Controls.Add(Me.cbeErrorBarsKind)
			Me.panel.Controls.Add(Me.lblErrorBarKind)
			Me.panel.Controls.Add(Me.lblSeriesView)
			Me.panel.Controls.Add(Me.cbeSeriesView)
			Me.panel.Controls.SetChildIndex(Me.checkEditShowLabels, 0)
			Me.panel.Controls.SetChildIndex(Me.cbeSeriesView, 0)
			Me.panel.Controls.SetChildIndex(Me.lblSeriesView, 0)
			Me.panel.Controls.SetChildIndex(Me.lblErrorBarKind, 0)
			Me.panel.Controls.SetChildIndex(Me.cbeErrorBarsKind, 0)
			Me.panel.Controls.SetChildIndex(Me.lblEndStyle, 0)
			Me.panel.Controls.SetChildIndex(Me.cbeEndStyle, 0)
			Me.panel.Controls.SetChildIndex(Me.lblDirection, 0)
			Me.panel.Controls.SetChildIndex(Me.cbeDirection, 0)
			' 
			' checkEditShowLabels
			' 
			Me.checkEditShowLabels.Location = New System.Drawing.Point(10000, 1)
			Me.checkEditShowLabels.Size = New System.Drawing.Size(82, 19)
			Me.checkEditShowLabels.Visible = False
			' 
			' dataSet
			' 
			Me.dataSet.DataSetName = "ChartDataSource"
			Me.dataSet.Tables.AddRange(New System.Data.DataTable() { Me.dataTable1})
			' 
			' dataTable1
			' 
			Me.dataTable1.Columns.AddRange(New System.Data.DataColumn() { Me.dataColumn1, Me.dataColumn2, Me.dataColumn3, Me.dataColumn4})
			Me.dataTable1.TableName = "Table1"
			' 
			' dataColumn1
			' 
			Me.dataColumn1.Caption = "Argument"
			Me.dataColumn1.ColumnName = "Argument"
			' 
			' dataColumn2
			' 
			Me.dataColumn2.ColumnName = "Value"
			Me.dataColumn2.DataType = GetType(Double)
			' 
			' dataColumn3
			' 
			Me.dataColumn3.ColumnName = "PositiveError"
			Me.dataColumn3.DataType = GetType(Double)
			' 
			' dataColumn4
			' 
			Me.dataColumn4.ColumnName = "NegativeError"
			Me.dataColumn4.DataType = GetType(Double)
			' 
			' chartControl
			' 
			Me.chartControl_Renamed.CrosshairEnabled = DevExpress.Utils.DefaultBoolean.False
			Me.chartControl_Renamed.DataBindings = Nothing
			xyDiagram1.AxisX.Tickmarks.MinorVisible = False
			xyDiagram1.AxisX.VisibleInPanesSerializable = "-1"
			xyDiagram1.AxisY.VisibleInPanesSerializable = "-1"
			xyDiagram1.AxisY.WholeRange.Auto = False
			xyDiagram1.AxisY.WholeRange.AutoSideMargins = False
			xyDiagram1.AxisY.WholeRange.MaxValueSerializable = "65"
			xyDiagram1.AxisY.WholeRange.MinValueSerializable = "0"
			xyDiagram1.AxisY.WholeRange.SideMarginsValue = 0R
			Me.chartControl_Renamed.Diagram = xyDiagram1
			Me.chartControl_Renamed.Dock = System.Windows.Forms.DockStyle.Fill
			Me.chartControl_Renamed.Legend.Name = "Default Legend"
			Me.chartControl_Renamed.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False
			Me.chartControl_Renamed.Location = New System.Drawing.Point(0, 74)
			Me.chartControl_Renamed.Name = "chartControl"
			series1.ArgumentDataMember = "Table1.Argument"
			series1.DataSource = Me.dataSet
			series1.LegendName = "Default Legend"
			series1.Name = "Series 1"
			series1.ValueDataMembersSerializable = "Table1.Value"
			Me.chartControl_Renamed.SeriesSerializable = New DevExpress.XtraCharts.Series() { series1}
			Me.chartControl_Renamed.SeriesTemplate.LegendName = "Default Legend"
			Me.chartControl_Renamed.Size = New System.Drawing.Size(700, 426)
			Me.chartControl_Renamed.TabIndex = 2
			' 
			' cbeSeriesView
			' 
			Me.cbeSeriesView.EditValue = ""
			Me.cbeSeriesView.Location = New System.Drawing.Point(88, 9)
			Me.cbeSeriesView.Name = "cbeSeriesView"
			Me.cbeSeriesView.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.cbeSeriesView.Properties.DropDownRows = 2
			Me.cbeSeriesView.Properties.Items.AddRange(New Object() { "Bar", "Point"})
			Me.cbeSeriesView.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
			Me.cbeSeriesView.Size = New System.Drawing.Size(100, 20)
			Me.cbeSeriesView.TabIndex = 2
'			Me.cbeSeriesView.SelectedIndexChanged += New System.EventHandler(Me.cbeSeriesView_SelectedIndexChanged);
			' 
			' lblSeriesView
			' 
			Me.lblSeriesView.Location = New System.Drawing.Point(12, 12)
			Me.lblSeriesView.Name = "lblSeriesView"
			Me.lblSeriesView.Size = New System.Drawing.Size(58, 13)
			Me.lblSeriesView.TabIndex = 8
			Me.lblSeriesView.Text = "Series View:"
			' 
			' lblErrorBarKind
			' 
			Me.lblErrorBarKind.Location = New System.Drawing.Point(12, 40)
			Me.lblErrorBarKind.Name = "lblErrorBarKind"
			Me.lblErrorBarKind.Size = New System.Drawing.Size(70, 13)
			Me.lblErrorBarKind.TabIndex = 9
			Me.lblErrorBarKind.Text = "Error Bar Kind:"
			' 
			' cbeErrorBarsKind
			' 
			Me.cbeErrorBarsKind.Location = New System.Drawing.Point(88, 37)
			Me.cbeErrorBarsKind.Name = "cbeErrorBarsKind"
			Me.cbeErrorBarsKind.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.cbeErrorBarsKind.Properties.DropDownRows = 5
			Me.cbeErrorBarsKind.Properties.Items.AddRange(New Object() { "Fixed Values", "Percentage", "Standard Deviation(s)", "Standard Error", "Data Source"})
			Me.cbeErrorBarsKind.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
			Me.cbeErrorBarsKind.Size = New System.Drawing.Size(100, 20)
			Me.cbeErrorBarsKind.TabIndex = 10
'			Me.cbeErrorBarsKind.SelectedIndexChanged += New System.EventHandler(Me.cbeErrorBarsKind_SelectedIndexChanged);
			' 
			' lblEndStyle
			' 
			Me.lblEndStyle.Location = New System.Drawing.Point(211, 12)
			Me.lblEndStyle.Name = "lblEndStyle"
			Me.lblEndStyle.Size = New System.Drawing.Size(49, 13)
			Me.lblEndStyle.TabIndex = 11
			Me.lblEndStyle.Text = "End Style:"
			' 
			' cbeEndStyle
			' 
			Me.cbeEndStyle.EditValue = ""
			Me.cbeEndStyle.Location = New System.Drawing.Point(266, 9)
			Me.cbeEndStyle.Name = "cbeEndStyle"
			Me.cbeEndStyle.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.cbeEndStyle.Properties.DropDownRows = 2
			Me.cbeEndStyle.Properties.Items.AddRange(New Object() { "Cap", "No Cap"})
			Me.cbeEndStyle.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
			Me.cbeEndStyle.Size = New System.Drawing.Size(100, 20)
			Me.cbeEndStyle.TabIndex = 12
'			Me.cbeEndStyle.SelectedIndexChanged += New System.EventHandler(Me.cbeEndStyle_SelectedIndexChanged);
			' 
			' lblDirection
			' 
			Me.lblDirection.Location = New System.Drawing.Point(211, 40)
			Me.lblDirection.Name = "lblDirection"
			Me.lblDirection.Size = New System.Drawing.Size(46, 13)
			Me.lblDirection.TabIndex = 13
			Me.lblDirection.Text = "Direction:"
			' 
			' cbeDirection
			' 
			Me.cbeDirection.EditValue = ""
			Me.cbeDirection.Location = New System.Drawing.Point(266, 37)
			Me.cbeDirection.Name = "cbeDirection"
			Me.cbeDirection.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.cbeDirection.Properties.DropDownRows = 3
			Me.cbeDirection.Properties.Items.AddRange(New Object() { "Both", "Minus", "Plus"})
			Me.cbeDirection.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
			Me.cbeDirection.Size = New System.Drawing.Size(100, 20)
			Me.cbeDirection.TabIndex = 14
'			Me.cbeDirection.SelectedIndexChanged += New System.EventHandler(Me.cbeDirection_SelectedIndexChanged);
			' 
			' ErrorBarsDemo
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.chartControl_Renamed)
			Me.Name = "ErrorBarsDemo"
			Me.Controls.SetChildIndex(Me.panelRoot, 0)
			Me.Controls.SetChildIndex(Me.chartControl_Renamed, 0)
			CType(Me.panel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panel.ResumeLayout(False)
			Me.panel.PerformLayout()
			CType(Me.checkEditShowLabels.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panelRoot.ResumeLayout(False)
			CType(Me.dataSet, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.dataTable1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(xyDiagram1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(series1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.chartControl_Renamed, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.cbeSeriesView.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.cbeErrorBarsKind.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.cbeEndStyle.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.cbeDirection.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private dataSet As System.Data.DataSet
		Private dataTable1 As System.Data.DataTable
		Private dataColumn1 As System.Data.DataColumn
		Private dataColumn2 As System.Data.DataColumn
		Private dataColumn3 As System.Data.DataColumn
		Private dataColumn4 As System.Data.DataColumn
		Private WithEvents cbeErrorBarsKind As XtraEditors.ComboBoxEdit
		Private lblErrorBarKind As XtraEditors.LabelControl
		Private WithEvents cbeDirection As XtraEditors.ComboBoxEdit
		Private lblDirection As XtraEditors.LabelControl
		Private WithEvents cbeEndStyle As XtraEditors.ComboBoxEdit
		Private lblEndStyle As XtraEditors.LabelControl
	End Class

End Namespace
