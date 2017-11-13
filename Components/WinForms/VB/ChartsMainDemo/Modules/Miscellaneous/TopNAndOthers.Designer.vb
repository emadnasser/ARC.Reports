Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.XtraCharts.Demos.Miscellaneous
	Partial Public Class TopNAndOthersDemo
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
			Dim doughnut3DSeriesView1 As New DevExpress.XtraCharts.Doughnut3DSeriesView()
			Dim sideBySideBarSeriesLabel1 As New DevExpress.XtraCharts.SideBySideBarSeriesLabel()
			Dim chartTitle1 As New DevExpress.XtraCharts.ChartTitle()
			Dim chartTitle2 As New DevExpress.XtraCharts.ChartTitle()
			Me.chart = New DevExpress.XtraCharts.ChartControl()
			Me.oleDbDataAdapter1 = New System.Data.OleDb.OleDbDataAdapter()
			Me.oleDbSelectCommand1 = New System.Data.OleDb.OleDbCommand()
			Me.oleDbConnection1 = New System.Data.OleDb.OleDbConnection()
			Me.dS21 = New DevExpress.XtraCharts.Demos.DS2()
			Me.labelMode = New DevExpress.XtraEditors.LabelControl()
			Me.labelValue = New DevExpress.XtraEditors.LabelControl()
			Me.comboBoxMode = New DevExpress.XtraEditors.ComboBoxEdit()
			Me.txtValue = New DevExpress.XtraEditors.SpinEdit()
			Me.checkEditShowOthers = New DevExpress.XtraEditors.CheckEdit()
			Me.txtOthersArgument = New DevExpress.XtraEditors.TextEdit()
			Me.labelOthersArgument = New DevExpress.XtraEditors.LabelControl()
			CType(Me.panel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panel.SuspendLayout()
			CType(Me.checkEditShowLabels.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panelRoot.SuspendLayout()
			CType(Me.chart, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(simpleDiagram3D1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(series1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(doughnut3DSeriesLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(doughnut3DSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(sideBySideBarSeriesLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.dS21, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.comboBoxMode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.txtValue.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.checkEditShowOthers.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.txtOthersArgument.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' panel
			' 
			Me.panel.Controls.Add(Me.txtOthersArgument)
			Me.panel.Controls.Add(Me.labelOthersArgument)
			Me.panel.Controls.Add(Me.checkEditShowOthers)
			Me.panel.Controls.Add(Me.txtValue)
			Me.panel.Controls.Add(Me.labelMode)
			Me.panel.Controls.Add(Me.labelValue)
			Me.panel.Controls.Add(Me.comboBoxMode)
			Me.panel.Margin = New System.Windows.Forms.Padding(10, 9, 10, 9)
			Me.panel.Controls.SetChildIndex(Me.checkEditShowLabels, 0)
			Me.panel.Controls.SetChildIndex(Me.comboBoxMode, 0)
			Me.panel.Controls.SetChildIndex(Me.labelValue, 0)
			Me.panel.Controls.SetChildIndex(Me.labelMode, 0)
			Me.panel.Controls.SetChildIndex(Me.txtValue, 0)
			Me.panel.Controls.SetChildIndex(Me.checkEditShowOthers, 0)
			Me.panel.Controls.SetChildIndex(Me.labelOthersArgument, 0)
			Me.panel.Controls.SetChildIndex(Me.txtOthersArgument, 0)
			' 
			' checkEditShowLabels
			' 
			Me.checkEditShowLabels.Size = New System.Drawing.Size(82, 19)
			Me.checkEditShowLabels.TabIndex = 4
			' 
			' chart
			' 
			Me.chart.DataAdapter = Me.oleDbDataAdapter1
			Me.chart.DataBindings = Nothing
			Me.chart.DataSource = Me.dS21.Countries
			simpleDiagram3D1.RotationMatrixSerializable = "0.990157351881877;-0.0243454369756547;0.13782495497091;0;0.10562840212504;0.77604" & "3051453063;-0.621771519897728;0;-0.0918207992710787;0.630209871384037;0.77097630" & "237987;0;0;0;0;1"
			simpleDiagram3D1.RuntimeRotation = True
			simpleDiagram3D1.RuntimeScrolling = True
			simpleDiagram3D1.RuntimeZooming = True
			Me.chart.Diagram = simpleDiagram3D1
			Me.chart.Dock = System.Windows.Forms.DockStyle.Fill
			Me.chart.Legend.Name = "Default Legend"
			Me.chart.Location = New System.Drawing.Point(0, 74)
			Me.chart.Name = "chart"
			Me.chart.RefreshDataOnRepaint = True
			series1.ArgumentDataMember = "Country"
			doughnut3DSeriesLabel1.Position = DevExpress.XtraCharts.PieSeriesLabelPosition.Tangent
			doughnut3DSeriesLabel1.TextPattern = "{VP:P2}"
			series1.Label = doughnut3DSeriesLabel1
			series1.LegendTextPattern = "{A:P2}"
			series1.Name = "Series 1"
			series1.SeriesPointsSorting = DevExpress.XtraCharts.SortingMode.Descending
			series1.SeriesPointsSortingKey = DevExpress.XtraCharts.SeriesPointKey.Value_1
			series1.TopNOptions.Enabled = True
			series1.TopNOptions.ThresholdPercent = 2.3R
			series1.TopNOptions.ThresholdValue = 7000R
			series1.ValueDataMembersSerializable = "Area"
			series1.View = doughnut3DSeriesView1
			Me.chart.SeriesSerializable = New DevExpress.XtraCharts.Series() { series1}
			sideBySideBarSeriesLabel1.TextPattern = "{V:F2}"
			Me.chart.SeriesTemplate.Label = sideBySideBarSeriesLabel1
			Me.chart.Size = New System.Drawing.Size(700, 426)
			Me.chart.TabIndex = 1
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
			' labelMode
			' 
			Me.labelMode.Location = New System.Drawing.Point(12, 12)
			Me.labelMode.Margin = New System.Windows.Forms.Padding(0, 10, 3, 10)
			Me.labelMode.Name = "labelMode"
			Me.labelMode.Size = New System.Drawing.Size(30, 13)
			Me.labelMode.TabIndex = 54
			Me.labelMode.Text = "Mode:"
			' 
			' labelValue
			' 
			Me.labelValue.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
			Me.labelValue.Location = New System.Drawing.Point(12, 40)
			Me.labelValue.Margin = New System.Windows.Forms.Padding(10, 10, 3, 10)
			Me.labelValue.Name = "labelValue"
			Me.labelValue.Size = New System.Drawing.Size(89, 13)
			Me.labelValue.TabIndex = 56
			Me.labelValue.Text = "Value:"
			' 
			' comboBoxMode
			' 
			Me.comboBoxMode.Location = New System.Drawing.Point(104, 9)
			Me.comboBoxMode.Margin = New System.Windows.Forms.Padding(0, 0, 10, 10)
			Me.comboBoxMode.Name = "comboBoxMode"
			Me.comboBoxMode.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.comboBoxMode.Properties.Items.AddRange(New Object() { "Count", "Threshold Value", "Threshold Percent"})
			Me.comboBoxMode.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
			Me.comboBoxMode.Size = New System.Drawing.Size(120, 20)
			Me.comboBoxMode.TabIndex = 0
'			Me.comboBoxMode.SelectedIndexChanged += New System.EventHandler(Me.comboBoxMode_SelectedIndexChanged);
			' 
			' txtValue
			' 
			Me.txtValue.EditValue = New Decimal(New Integer() { 2, 0, 0, 0})
			Me.txtValue.Location = New System.Drawing.Point(104, 36)
			Me.txtValue.Margin = New System.Windows.Forms.Padding(0, 0, 10, 10)
			Me.txtValue.Name = "txtValue"
			Me.txtValue.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
			Me.txtValue.Properties.IsFloatValue = False
			Me.txtValue.Properties.Mask.EditMask = "N00"
			Me.txtValue.Properties.Mask.UseMaskAsDisplayFormat = True
			Me.txtValue.Properties.ValidateOnEnterKey = True
			Me.txtValue.Size = New System.Drawing.Size(120, 20)
			Me.txtValue.TabIndex = 1
'			Me.txtValue.EditValueChanged += New System.EventHandler(Me.txtValue_EditValueChanged);
			' 
			' checkEditShowOthers
			' 
			Me.checkEditShowOthers.Location = New System.Drawing.Point(249, 9)
			Me.checkEditShowOthers.Margin = New System.Windows.Forms.Padding(0)
			Me.checkEditShowOthers.Name = "checkEditShowOthers"
			Me.checkEditShowOthers.Properties.Caption = "Show ""Others"""
			Me.checkEditShowOthers.Size = New System.Drawing.Size(92, 19)
			Me.checkEditShowOthers.TabIndex = 2
'			Me.checkEditShowOthers.CheckedChanged += New System.EventHandler(Me.checkEditShowOthers_CheckedChanged);
			' 
			' txtOthersArgument
			' 
			Me.txtOthersArgument.Location = New System.Drawing.Point(350, 36)
			Me.txtOthersArgument.Name = "txtOthersArgument"
			Me.txtOthersArgument.Size = New System.Drawing.Size(115, 20)
			Me.txtOthersArgument.TabIndex = 3
'			Me.txtOthersArgument.EditValueChanged += New System.EventHandler(Me.txtOthersArgument_EditValueChanged);
			' 
			' labelOthersArgument
			' 
			Me.labelOthersArgument.Location = New System.Drawing.Point(249, 40)
			Me.labelOthersArgument.Margin = New System.Windows.Forms.Padding(0, 10, 3, 10)
			Me.labelOthersArgument.Name = "labelOthersArgument"
			Me.labelOthersArgument.Size = New System.Drawing.Size(95, 13)
			Me.labelOthersArgument.TabIndex = 65
			Me.labelOthersArgument.Text = """Others"" Argument:"
			' 
			' TopNAndOthersDemo
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.chart)
			Me.Name = "TopNAndOthersDemo"
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
			CType(sideBySideBarSeriesLabel1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.chart, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.dS21, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.comboBoxMode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.txtValue.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.checkEditShowOthers.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.txtOthersArgument.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region
		Private components As System.ComponentModel.IContainer = Nothing
		Private oleDbDataAdapter1 As System.Data.OleDb.OleDbDataAdapter
		Private oleDbSelectCommand1 As System.Data.OleDb.OleDbCommand
		Private oleDbConnection1 As System.Data.OleDb.OleDbConnection
		Private dS21 As DS2
		Private labelMode As DevExpress.XtraEditors.LabelControl
		Private labelValue As DevExpress.XtraEditors.LabelControl
		Private WithEvents comboBoxMode As DevExpress.XtraEditors.ComboBoxEdit
		Private WithEvents txtValue As DevExpress.XtraEditors.SpinEdit
		Private WithEvents checkEditShowOthers As DevExpress.XtraEditors.CheckEdit
		Private WithEvents txtOthersArgument As DevExpress.XtraEditors.TextEdit
		Private labelOthersArgument As DevExpress.XtraEditors.LabelControl

	End Class
End Namespace
