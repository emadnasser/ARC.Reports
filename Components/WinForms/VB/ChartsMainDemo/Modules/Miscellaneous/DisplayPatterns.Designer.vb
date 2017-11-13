Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.XtraCharts.Demos.Miscellaneous
	Partial Public Class DisplayPatternsDemo
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
			Dim series1 As New DevExpress.XtraCharts.Series()
			Dim sideBySideBarSeriesLabel1 As New DevExpress.XtraCharts.SideBySideBarSeriesLabel()
			Dim sideBySideBarSeriesView1 As New DevExpress.XtraCharts.SideBySideBarSeriesView()
			Dim sideBySideBarSeriesLabel2 As New DevExpress.XtraCharts.SideBySideBarSeriesLabel()
			Dim chartTitle1 As New DevExpress.XtraCharts.ChartTitle()
			Dim chartTitle2 As New DevExpress.XtraCharts.ChartTitle()
			Me.chart = New DevExpress.XtraCharts.ChartControl()
			Me.oleDbDataAdapter1 = New System.Data.OleDb.OleDbDataAdapter()
			Me.oleDbSelectCommand1 = New System.Data.OleDb.OleDbCommand()
			Me.oleDbConnection1 = New System.Data.OleDb.OleDbConnection()
			Me.dS21 = New DevExpress.XtraCharts.Demos.DS2()
			Me.labelSeriesLabels = New DevExpress.XtraEditors.LabelControl()
			Me.cbSeriesLabels = New DevExpress.XtraEditors.ComboBoxEdit()
			Me.labelLegend = New DevExpress.XtraEditors.LabelControl()
			Me.cbLegendTextPattern = New DevExpress.XtraEditors.ComboBoxEdit()
			Me.labelControl1 = New DevExpress.XtraEditors.LabelControl()
			Me.cbAxisYLabelsPattern = New DevExpress.XtraEditors.ComboBoxEdit()
			Me.labelControl2 = New DevExpress.XtraEditors.LabelControl()
			Me.cbAxisXLabelsPattern = New DevExpress.XtraEditors.ComboBoxEdit()
			CType(Me.panel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panel.SuspendLayout()
			CType(Me.checkEditShowLabels.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panelRoot.SuspendLayout()
			CType(Me.chart, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(xyDiagram1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(series1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(sideBySideBarSeriesLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(sideBySideBarSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(sideBySideBarSeriesLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.dS21, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.cbSeriesLabels.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.cbLegendTextPattern.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.cbAxisYLabelsPattern.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.cbAxisXLabelsPattern.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' panel
			' 
			Me.panel.Controls.Add(Me.labelControl1)
			Me.panel.Controls.Add(Me.cbAxisYLabelsPattern)
			Me.panel.Controls.Add(Me.labelControl2)
			Me.panel.Controls.Add(Me.cbAxisXLabelsPattern)
			Me.panel.Controls.Add(Me.labelLegend)
			Me.panel.Controls.Add(Me.cbLegendTextPattern)
			Me.panel.Controls.Add(Me.labelSeriesLabels)
			Me.panel.Controls.Add(Me.cbSeriesLabels)
			Me.panel.Controls.SetChildIndex(Me.checkEditShowLabels, 0)
			Me.panel.Controls.SetChildIndex(Me.cbSeriesLabels, 0)
			Me.panel.Controls.SetChildIndex(Me.labelSeriesLabels, 0)
			Me.panel.Controls.SetChildIndex(Me.cbLegendTextPattern, 0)
			Me.panel.Controls.SetChildIndex(Me.labelLegend, 0)
			Me.panel.Controls.SetChildIndex(Me.cbAxisXLabelsPattern, 0)
			Me.panel.Controls.SetChildIndex(Me.labelControl2, 0)
			Me.panel.Controls.SetChildIndex(Me.cbAxisYLabelsPattern, 0)
			Me.panel.Controls.SetChildIndex(Me.labelControl1, 0)
			' 
			' checkEditShowLabels
			' 
			Me.checkEditShowLabels.Size = New System.Drawing.Size(82, 19)
			Me.checkEditShowLabels.TabIndex = 4
			Me.checkEditShowLabels.Visible = False
			' 
			' chart
			' 
			Me.chart.CrosshairEnabled = DevExpress.Utils.DefaultBoolean.False
			Me.chart.DataAdapter = Me.oleDbDataAdapter1
			Me.chart.DataBindings = Nothing
			Me.chart.DataSource = Me.dS21.Countries
			xyDiagram1.AxisX.Label.TextPattern = "{A}"
			xyDiagram1.AxisX.VisibleInPanesSerializable = "-1"
			xyDiagram1.AxisY.Label.TextPattern = "{V:#,0}"
			xyDiagram1.AxisY.Title.Text = "Millions of Square Kilometers"
			xyDiagram1.AxisY.Title.Visibility = DevExpress.Utils.DefaultBoolean.True
			xyDiagram1.AxisY.VisibleInPanesSerializable = "-1"
			Me.chart.Diagram = xyDiagram1
			Me.chart.Dock = System.Windows.Forms.DockStyle.Fill
			Me.chart.Legend.Name = "Default Legend"
			Me.chart.Location = New System.Drawing.Point(0, 74)
			Me.chart.Name = "chart"
			Me.chart.RefreshDataOnRepaint = True
			series1.ArgumentDataMember = "Country"
			series1.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Qualitative
			series1.DataFilters.ClearAndAddRange(New DevExpress.XtraCharts.DataFilter() { New DevExpress.XtraCharts.DataFilter("Area", "System.Single", DevExpress.XtraCharts.DataFilterCondition.GreaterThan, 5000F)})
			sideBySideBarSeriesLabel1.TextPattern = "{V:## ##0.0}"
			series1.Label = sideBySideBarSeriesLabel1
			series1.LabelsVisibility = DevExpress.Utils.DefaultBoolean.True
			series1.LegendTextPattern = "{A}"
			series1.Name = "Area of Countries"
			series1.SeriesPointsSorting = DevExpress.XtraCharts.SortingMode.Descending
			series1.SeriesPointsSortingKey = DevExpress.XtraCharts.SeriesPointKey.Value_1
			series1.ValueDataMembersSerializable = "Area"
			sideBySideBarSeriesView1.ColorEach = True
			series1.View = sideBySideBarSeriesView1
			Me.chart.SeriesSerializable = New DevExpress.XtraCharts.Series() { series1}
			sideBySideBarSeriesLabel2.TextPattern = "{VP:G2}"
			Me.chart.SeriesTemplate.Label = sideBySideBarSeriesLabel2
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
			' 
			' oleDbDataAdapter1
			' 
			Me.oleDbDataAdapter1.SelectCommand = Me.oleDbSelectCommand1
			Me.oleDbDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() { New System.Data.Common.DataTableMapping("Table", "Countries", New System.Data.Common.DataColumnMapping() { New System.Data.Common.DataColumnMapping("Country", "Country"), New System.Data.Common.DataColumnMapping("OfficialName", "OfficialName"), New System.Data.Common.DataColumnMapping("Area", "Area")})})
			' 
			' oleDbSelectCommand1
			' 
			Me.oleDbSelectCommand1.CommandText = "SELECT Country, OfficialName, Area FROM Countries"
			Me.oleDbSelectCommand1.Connection = Me.oleDbConnection1
			' 
			' dS21
			' 
			Me.dS21.DataSetName = "DS2"
			Me.dS21.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
			' 
			' labelSeriesLabels
			' 
			Me.labelSeriesLabels.Location = New System.Drawing.Point(12, 12)
			Me.labelSeriesLabels.Margin = New System.Windows.Forms.Padding(0, 10, 3, 10)
			Me.labelSeriesLabels.Name = "labelSeriesLabels"
			Me.labelSeriesLabels.Size = New System.Drawing.Size(66, 13)
			Me.labelSeriesLabels.TabIndex = 60
			Me.labelSeriesLabels.Text = "Series Labels:"
			' 
			' cbSeriesLabels
			' 
			Me.cbSeriesLabels.EditValue = "{V:## ##0.0}"
			Me.cbSeriesLabels.Location = New System.Drawing.Point(81, 9)
			Me.cbSeriesLabels.Margin = New System.Windows.Forms.Padding(0, 0, 10, 0)
			Me.cbSeriesLabels.Name = "cbSeriesLabels"
			Me.cbSeriesLabels.Properties.AutoComplete = False
			Me.cbSeriesLabels.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.cbSeriesLabels.Properties.Items.AddRange(New Object() { "{V:## ##0.0}", "{A}", "{V}", "{A}: {V}", "{S}"})
			Me.cbSeriesLabels.Size = New System.Drawing.Size(141, 20)
			Me.cbSeriesLabels.TabIndex = 0
'			Me.cbSeriesLabels.EditValueChanged += New System.EventHandler(Me.comboBoxSeriesLabels_EditValueChanged);
			' 
			' labelLegend
			' 
			Me.labelLegend.Location = New System.Drawing.Point(12, 40)
			Me.labelLegend.Margin = New System.Windows.Forms.Padding(0, 10, 3, 10)
			Me.labelLegend.Name = "labelLegend"
			Me.labelLegend.Size = New System.Drawing.Size(39, 13)
			Me.labelLegend.TabIndex = 62
			Me.labelLegend.Text = "Legend:"
			' 
			' cbLegendTextPattern
			' 
			Me.cbLegendTextPattern.EditValue = "{A}"
			Me.cbLegendTextPattern.Location = New System.Drawing.Point(81, 37)
			Me.cbLegendTextPattern.Margin = New System.Windows.Forms.Padding(0, 0, 10, 0)
			Me.cbLegendTextPattern.Name = "cbLegendTextPattern"
			Me.cbLegendTextPattern.Properties.AutoComplete = False
			Me.cbLegendTextPattern.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.cbLegendTextPattern.Properties.Items.AddRange(New Object() { "{A}", "{V}", "{A}: {V}", "{S}"})
			Me.cbLegendTextPattern.Size = New System.Drawing.Size(141, 20)
			Me.cbLegendTextPattern.TabIndex = 1
'			Me.cbLegendTextPattern.EditValueChanged += New System.EventHandler(Me.cbLegendTextPattern_EditValueChanged);
			' 
			' labelControl1
			' 
			Me.labelControl1.Location = New System.Drawing.Point(245, 40)
			Me.labelControl1.Margin = New System.Windows.Forms.Padding(0, 10, 3, 10)
			Me.labelControl1.Name = "labelControl1"
			Me.labelControl1.Size = New System.Drawing.Size(63, 13)
			Me.labelControl1.TabIndex = 66
			Me.labelControl1.Text = "AxisY Labels:"
			' 
			' cbAxisYLabelsPattern
			' 
			Me.cbAxisYLabelsPattern.EditValue = "{V:#,0}"
			Me.cbAxisYLabelsPattern.Location = New System.Drawing.Point(311, 37)
			Me.cbAxisYLabelsPattern.Margin = New System.Windows.Forms.Padding(0, 0, 10, 0)
			Me.cbAxisYLabelsPattern.Name = "cbAxisYLabelsPattern"
			Me.cbAxisYLabelsPattern.Properties.AutoComplete = False
			Me.cbAxisYLabelsPattern.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.cbAxisYLabelsPattern.Properties.Items.AddRange(New Object() { "{V:#,0}", "{V}", "{V:0,.#} ths"})
			Me.cbAxisYLabelsPattern.Size = New System.Drawing.Size(141, 20)
			Me.cbAxisYLabelsPattern.TabIndex = 64
'			Me.cbAxisYLabelsPattern.EditValueChanged += New System.EventHandler(Me.cbAxisYLabelsPattern_EditValueChanged);
			' 
			' labelControl2
			' 
			Me.labelControl2.Location = New System.Drawing.Point(245, 12)
			Me.labelControl2.Margin = New System.Windows.Forms.Padding(0, 10, 3, 10)
			Me.labelControl2.Name = "labelControl2"
			Me.labelControl2.Size = New System.Drawing.Size(63, 13)
			Me.labelControl2.TabIndex = 65
			Me.labelControl2.Text = "AxisX Labels:"
			' 
			' cbAxisXLabelsPattern
			' 
			Me.cbAxisXLabelsPattern.EditValue = "{A}"
			Me.cbAxisXLabelsPattern.Location = New System.Drawing.Point(311, 9)
			Me.cbAxisXLabelsPattern.Margin = New System.Windows.Forms.Padding(0, 0, 10, 0)
			Me.cbAxisXLabelsPattern.Name = "cbAxisXLabelsPattern"
			Me.cbAxisXLabelsPattern.Properties.AutoComplete = False
			Me.cbAxisXLabelsPattern.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.cbAxisXLabelsPattern.Properties.Items.AddRange(New Object() { "{A}", "Country: {A}"})
			Me.cbAxisXLabelsPattern.Size = New System.Drawing.Size(141, 20)
			Me.cbAxisXLabelsPattern.TabIndex = 63
'			Me.cbAxisXLabelsPattern.EditValueChanged += New System.EventHandler(Me.cbAxisXLabelsPattern_EditValueChanged);
			' 
			' DisplayPatternsDemo
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.chart)
			Me.Name = "DisplayPatternsDemo"
			Me.Controls.SetChildIndex(Me.panelRoot, 0)
			Me.Controls.SetChildIndex(Me.chart, 0)
			CType(Me.panel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panel.ResumeLayout(False)
			Me.panel.PerformLayout()
			CType(Me.checkEditShowLabels.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panelRoot.ResumeLayout(False)
			CType(xyDiagram1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(sideBySideBarSeriesLabel1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(sideBySideBarSeriesView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(series1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(sideBySideBarSeriesLabel2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.chart, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.dS21, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.cbSeriesLabels.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.cbLegendTextPattern.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.cbAxisYLabelsPattern.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.cbAxisXLabelsPattern.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region
		Private components As System.ComponentModel.IContainer = Nothing
		Private labelSeriesLabels As DevExpress.XtraEditors.LabelControl
		Private WithEvents cbSeriesLabels As DevExpress.XtraEditors.ComboBoxEdit
		Private labelLegend As DevExpress.XtraEditors.LabelControl
		Private WithEvents cbLegendTextPattern As DevExpress.XtraEditors.ComboBoxEdit
		Private labelControl1 As XtraEditors.LabelControl
		Private WithEvents cbAxisYLabelsPattern As XtraEditors.ComboBoxEdit
		Private labelControl2 As XtraEditors.LabelControl
		Private WithEvents cbAxisXLabelsPattern As XtraEditors.ComboBoxEdit
		Private oleDbDataAdapter1 As System.Data.OleDb.OleDbDataAdapter
		Private oleDbSelectCommand1 As System.Data.OleDb.OleDbCommand
		Private oleDbConnection1 As System.Data.OleDb.OleDbConnection
		Private dS21 As DS2

	End Class
End Namespace
