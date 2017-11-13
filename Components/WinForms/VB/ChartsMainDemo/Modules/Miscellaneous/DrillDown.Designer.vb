Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.XtraCharts.Demos.Miscellaneous
	Partial Public Class DrillDownDemo
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

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(DrillDownDemo))
			Dim series1 As New DevExpress.XtraCharts.Series()
			Dim pieSeriesLabel1 As New DevExpress.XtraCharts.PieSeriesLabel()
			Dim pieSeriesView1 As New DevExpress.XtraCharts.PieSeriesView()
			Dim pieFlyInAnimation1 As New DevExpress.XtraCharts.PieFlyInAnimation()
			Dim series2 As New DevExpress.XtraCharts.Series()
			Dim sideBySideBarSeriesView1 As New DevExpress.XtraCharts.SideBySideBarSeriesView()
			Dim barGrowUpAnimation1 As New DevExpress.XtraCharts.BarGrowUpAnimation()
			Dim chartTitle1 As New DevExpress.XtraCharts.ChartTitle()
			Dim chartTitle2 As New DevExpress.XtraCharts.ChartTitle()
			Me.dS31 = New DevExpress.XtraCharts.Demos.DS3()
			Me.oleDbDataAdapterCategories = New System.Data.OleDb.OleDbDataAdapter()
			Me.oleDbSelectCommand1 = New System.Data.OleDb.OleDbCommand()
			Me.oleDbConnection1 = New System.Data.OleDb.OleDbConnection()
			Me.oleDbDataAdapterProducts = New System.Data.OleDb.OleDbDataAdapter()
			Me.oleDbSelectCommand2 = New System.Data.OleDb.OleDbCommand()
			Me.chart = New DevExpress.XtraCharts.ChartControl()
			Me.labelSummary1 = New DevExpress.XtraEditors.LabelControl()
			Me.comboBoxSummary = New DevExpress.XtraEditors.ComboBoxEdit()
			Me.labelSummary2 = New DevExpress.XtraEditors.LabelControl()
			CType(Me.panel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panel.SuspendLayout()
			CType(Me.checkEditShowLabels.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panelRoot.SuspendLayout()
			CType(Me.dS31, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.chart, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(series1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(pieSeriesLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(pieSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(series2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(sideBySideBarSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.comboBoxSummary.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' panel
			' 
			Me.panel.Controls.Add(Me.labelSummary2)
			Me.panel.Controls.Add(Me.labelSummary1)
			Me.panel.Controls.Add(Me.comboBoxSummary)
			Me.panel.Size = New System.Drawing.Size(700, 38)
			Me.panel.Controls.SetChildIndex(Me.checkEditShowLabels, 0)
			Me.panel.Controls.SetChildIndex(Me.comboBoxSummary, 0)
			Me.panel.Controls.SetChildIndex(Me.labelSummary1, 0)
			Me.panel.Controls.SetChildIndex(Me.labelSummary2, 0)
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
			' dS31
			' 
			Me.dS31.DataSetName = "DS3"
			Me.dS31.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
			' 
			' oleDbDataAdapterCategories
			' 
			Me.oleDbDataAdapterCategories.SelectCommand = Me.oleDbSelectCommand1
			Me.oleDbDataAdapterCategories.TableMappings.AddRange(New System.Data.Common.DataTableMapping() { New System.Data.Common.DataTableMapping("Table", "Categories", New System.Data.Common.DataColumnMapping() { New System.Data.Common.DataColumnMapping("CategoryID", "CategoryID"), New System.Data.Common.DataColumnMapping("CategoryName", "CategoryName"), New System.Data.Common.DataColumnMapping("Description", "Description"), New System.Data.Common.DataColumnMapping("Picture", "Picture")})})
			' 
			' oleDbSelectCommand1
			' 
			Me.oleDbSelectCommand1.CommandText = resources.GetString("oleDbSelectCommand1.CommandText")
			Me.oleDbSelectCommand1.Connection = Me.oleDbConnection1
			' 
			' oleDbDataAdapterProducts
			' 
			Me.oleDbDataAdapterProducts.SelectCommand = Me.oleDbSelectCommand2
			Me.oleDbDataAdapterProducts.TableMappings.AddRange(New System.Data.Common.DataTableMapping() { New System.Data.Common.DataTableMapping("Table", "Products", New System.Data.Common.DataColumnMapping() { New System.Data.Common.DataColumnMapping("ProductID", "ProductID"), New System.Data.Common.DataColumnMapping("ProductName", "ProductName"), New System.Data.Common.DataColumnMapping("SupplierID", "SupplierID"), New System.Data.Common.DataColumnMapping("CategoryID", "CategoryID"), New System.Data.Common.DataColumnMapping("QuantityPerUnit", "QuantityPerUnit"), New System.Data.Common.DataColumnMapping("UnitPrice", "UnitPrice"), New System.Data.Common.DataColumnMapping("UnitsInStock", "UnitsInStock"), New System.Data.Common.DataColumnMapping("UnitsOnOrder", "UnitsOnOrder"), New System.Data.Common.DataColumnMapping("ReorderLevel", "ReorderLevel"), New System.Data.Common.DataColumnMapping("Discontinued", "Discontinued"), New System.Data.Common.DataColumnMapping("EAN13", "EAN13")})})
			' 
			' oleDbSelectCommand2
			' 
			Me.oleDbSelectCommand2.CommandText = "SELECT CategoryID, Discontinued, EAN13, ProductID, ProductName, QuantityPerUnit, " & "ReorderLevel, SupplierID, UnitPrice, UnitsInStock, UnitsOnOrder FROM Products"
			Me.oleDbSelectCommand2.Connection = Me.oleDbConnection1
			' 
			' chart
			' 
			Me.chart.Cursor = System.Windows.Forms.Cursors.Default
			Me.chart.DataAdapter = Me.oleDbDataAdapterProducts
			Me.chart.DataBindings = Nothing
			Me.chart.DataSource = Me.dS31.Products
			Me.chart.Dock = System.Windows.Forms.DockStyle.Fill
			Me.chart.Legend.AlignmentVertical = DevExpress.XtraCharts.LegendAlignmentVertical.Center
			Me.chart.Legend.Name = "Default Legend"
			Me.chart.Location = New System.Drawing.Point(0, 46)
			Me.chart.Name = "chart"
			Me.chart.RefreshDataOnRepaint = True
			Me.chart.SeriesSelectionMode = DevExpress.XtraCharts.SeriesSelectionMode.Point
			series1.ArgumentDataMember = "CategoryName"
			series1.DataSource = Me.dS31.Categories
			pieSeriesLabel1.BackColor = System.Drawing.Color.Transparent
			pieSeriesLabel1.Border.Visibility = DevExpress.Utils.DefaultBoolean.False
			pieSeriesLabel1.Font = New System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold)
			pieSeriesLabel1.Position = DevExpress.XtraCharts.PieSeriesLabelPosition.Inside
			pieSeriesLabel1.TextColor = System.Drawing.Color.Black
			pieSeriesLabel1.TextPattern = "${V:F1}"
			series1.Label = pieSeriesLabel1
			series1.LegendTextPattern = "{A}"
			series1.Name = "Categories"
			series1.SeriesPointsSorting = DevExpress.XtraCharts.SortingMode.Ascending
			series1.ToolTipSeriesPattern = ""
			series1.ValueDataMembersSerializable = "MinPrice"
			pieSeriesView1.Animation = pieFlyInAnimation1
			pieSeriesView1.ExplodeMode = DevExpress.XtraCharts.PieExplodeMode.All
			pieSeriesView1.HeightToWidthRatio = 0.7R
			series1.View = pieSeriesView1
			series2.ArgumentDataMember = "ProductName"
			series2.DataFilters.ClearAndAddRange(New DevExpress.XtraCharts.DataFilter() { New DevExpress.XtraCharts.DataFilter("CategoryID", "System.Int32", DevExpress.XtraCharts.DataFilterCondition.Equal, Nothing)})
			series2.DataSource = Me.dS31.Products
			series2.LabelsVisibility = DevExpress.Utils.DefaultBoolean.False
			series2.Name = "Products"
			series2.SeriesPointsSorting = DevExpress.XtraCharts.SortingMode.Ascending
			series2.SeriesPointsSortingKey = DevExpress.XtraCharts.SeriesPointKey.Value_1
			series2.ValueDataMembersSerializable = "UnitPrice"
			barGrowUpAnimation1.PointDelay = System.TimeSpan.Parse("00:00:00.1000000")
			sideBySideBarSeriesView1.Animation = barGrowUpAnimation1
			series2.View = sideBySideBarSeriesView1
			Me.chart.SeriesSerializable = New DevExpress.XtraCharts.Series() { series1, series2}
			Me.chart.Size = New System.Drawing.Size(700, 454)
			Me.chart.TabIndex = 1
			Me.chart.TabStop = False
			chartTitle2.Alignment = System.Drawing.StringAlignment.Near
			chartTitle2.EnableAntialiasing = DevExpress.Utils.DefaultBoolean.False
			chartTitle2.Font = New System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Underline)
			chartTitle2.Text = "Back to the main view..."
			chartTitle2.TextColor = System.Drawing.Color.Blue
			chartTitle2.Visibility = DevExpress.Utils.DefaultBoolean.False
			Me.chart.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() { chartTitle1, chartTitle2})
			Me.chart.ToolTipOptions.ShowForPoints = False
			' 
			' labelSummary1
			' 
			Me.labelSummary1.Location = New System.Drawing.Point(12, 12)
			Me.labelSummary1.Margin = New System.Windows.Forms.Padding(0, 10, 0, 10)
			Me.labelSummary1.Name = "labelSummary1"
			Me.labelSummary1.Size = New System.Drawing.Size(26, 13)
			Me.labelSummary1.TabIndex = 17
			Me.labelSummary1.Text = "Show"
			' 
			' comboBoxSummary
			' 
			Me.comboBoxSummary.Location = New System.Drawing.Point(41, 9)
			Me.comboBoxSummary.Margin = New System.Windows.Forms.Padding(3, 0, 10, 0)
			Me.comboBoxSummary.Name = "comboBoxSummary"
			Me.comboBoxSummary.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.comboBoxSummary.Properties.Items.AddRange(New Object() { "Min", "Max", "Average"})
			Me.comboBoxSummary.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
			Me.comboBoxSummary.Size = New System.Drawing.Size(90, 20)
			Me.comboBoxSummary.TabIndex = 0
'			Me.comboBoxSummary.SelectedIndexChanged += New System.EventHandler(Me.comboBoxSummary_SelectedIndexChanged);
			' 
			' labelSummary2
			' 
			Me.labelSummary2.Location = New System.Drawing.Point(137, 12)
			Me.labelSummary2.Margin = New System.Windows.Forms.Padding(0, 10, 0, 10)
			Me.labelSummary2.Name = "labelSummary2"
			Me.labelSummary2.Size = New System.Drawing.Size(151, 13)
			Me.labelSummary2.TabIndex = 1
			Me.labelSummary2.Text = "product price in every category"
			' 
			' DrillDownDemo
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.chart)
			Me.Name = "DrillDownDemo"
			Me.Controls.SetChildIndex(Me.panelRoot, 0)
			Me.Controls.SetChildIndex(Me.chart, 0)
			CType(Me.panel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panel.ResumeLayout(False)
			Me.panel.PerformLayout()
			CType(Me.checkEditShowLabels.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panelRoot.ResumeLayout(False)
			CType(Me.dS31, System.ComponentModel.ISupportInitialize).EndInit()
			CType(pieSeriesLabel1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(pieSeriesView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(series1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(sideBySideBarSeriesView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(series2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.chart, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.comboBoxSummary.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private chart As ChartControl
		Private dS31 As DS3
		Private oleDbDataAdapterCategories As System.Data.OleDb.OleDbDataAdapter
		Private oleDbSelectCommand1 As System.Data.OleDb.OleDbCommand
		Private oleDbConnection1 As System.Data.OleDb.OleDbConnection
		Private oleDbDataAdapterProducts As System.Data.OleDb.OleDbDataAdapter
		Private oleDbSelectCommand2 As System.Data.OleDb.OleDbCommand
		Private labelSummary1 As DevExpress.XtraEditors.LabelControl
		Private WithEvents comboBoxSummary As DevExpress.XtraEditors.ComboBoxEdit
		Private labelSummary2 As DevExpress.XtraEditors.LabelControl
	End Class
End Namespace
