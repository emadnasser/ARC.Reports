Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.XtraCharts.Demos.ChartElements
	Partial Public Class HorizontalPanesDemo
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
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(HorizontalPanesDemo))
			Dim xyDiagram1 As New DevExpress.XtraCharts.XYDiagram()
			Dim xyDiagramPane1 As New DevExpress.XtraCharts.XYDiagramPane()
			Dim secondaryAxisX1 As New DevExpress.XtraCharts.SecondaryAxisX()
			Dim series1 As New DevExpress.XtraCharts.Series()
			Dim series2 As New DevExpress.XtraCharts.Series()
			Dim sideBySideBarSeriesView1 As New DevExpress.XtraCharts.SideBySideBarSeriesView()
			Dim chartTitle1 As New DevExpress.XtraCharts.ChartTitle()
			Me.oleDbDataAdapterProducts = New System.Data.OleDb.OleDbDataAdapter()
			Me.oleDbSelectCommand2 = New System.Data.OleDb.OleDbCommand()
			Me.oleDbConnection1 = New System.Data.OleDb.OleDbConnection()
			Me.oleDbDataAdapterCategories = New System.Data.OleDb.OleDbDataAdapter()
			Me.oleDbSelectCommand1 = New System.Data.OleDb.OleDbCommand()
			Me.chart = New DevExpress.XtraCharts.ChartControl()
			Me.dS31 = New DevExpress.XtraCharts.Demos.DS3()
			Me.lbLeftCategory = New DevExpress.XtraEditors.LabelControl()
			Me.cbLeftCategory = New DevExpress.XtraEditors.ComboBoxEdit()
			Me.lbRightCategory = New DevExpress.XtraEditors.LabelControl()
			Me.cbRightCategory = New DevExpress.XtraEditors.ComboBoxEdit()
			CType(Me.panel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panel.SuspendLayout()
			CType(Me.checkEditShowLabels.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panelRoot.SuspendLayout()
			CType(Me.chart, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(xyDiagram1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(xyDiagramPane1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(secondaryAxisX1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(series1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(series2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(sideBySideBarSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.dS31, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.cbLeftCategory.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.cbRightCategory.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' panel
			' 
			Me.panel.Controls.Add(Me.lbRightCategory)
			Me.panel.Controls.Add(Me.cbRightCategory)
			Me.panel.Controls.Add(Me.lbLeftCategory)
			Me.panel.Controls.Add(Me.cbLeftCategory)
			Me.panel.Size = New System.Drawing.Size(700, 38)
			Me.panel.Controls.SetChildIndex(Me.checkEditShowLabels, 0)
			Me.panel.Controls.SetChildIndex(Me.cbLeftCategory, 0)
			Me.panel.Controls.SetChildIndex(Me.lbLeftCategory, 0)
			Me.panel.Controls.SetChildIndex(Me.cbRightCategory, 0)
			Me.panel.Controls.SetChildIndex(Me.lbRightCategory, 0)
			' 
			' checkEditShowLabels
			' 
			Me.checkEditShowLabels.Location = New System.Drawing.Point(606, 9)
			Me.checkEditShowLabels.Size = New System.Drawing.Size(82, 19)
			Me.checkEditShowLabels.TabIndex = 2
			' 
			' panelRoot
			' 
			Me.panelRoot.Size = New System.Drawing.Size(700, 46)
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
			' chart
			' 
			Me.chart.CrosshairOptions.ShowArgumentLine = False
			Me.chart.CrosshairOptions.ShowValueLine = True
			Me.chart.CrosshairOptions.SnapMode = DevExpress.XtraCharts.CrosshairSnapMode.NearestValue
			Me.chart.DataAdapter = Me.oleDbDataAdapterProducts
			Me.chart.DataBindings = Nothing
			Me.chart.DataSource = Me.dS31
			xyDiagram1.AxisX.Label.Angle = -90
			xyDiagram1.AxisX.Title.Visibility = DevExpress.Utils.DefaultBoolean.True
			xyDiagram1.AxisX.VisibleInPanesSerializable = "-1"
			xyDiagram1.AxisY.Interlaced = True
			xyDiagram1.AxisY.Title.Text = "Price, USD"
			xyDiagram1.AxisY.Title.Visibility = DevExpress.Utils.DefaultBoolean.True
			xyDiagram1.AxisY.VisibleInPanesSerializable = "-1;0"
			xyDiagram1.PaneLayoutDirection = DevExpress.XtraCharts.PaneLayoutDirection.Horizontal
			xyDiagramPane1.Name = "Pane 1"
			xyDiagramPane1.PaneID = 0
			xyDiagram1.Panes.AddRange(New DevExpress.XtraCharts.XYDiagramPane() { xyDiagramPane1})
			secondaryAxisX1.Alignment = DevExpress.XtraCharts.AxisAlignment.Near
			secondaryAxisX1.AxisID = 0
			secondaryAxisX1.Label.Angle = -90
			secondaryAxisX1.Name = "secondaryAxisX1"
			secondaryAxisX1.Title.Visibility = DevExpress.Utils.DefaultBoolean.True
			secondaryAxisX1.VisibleInPanesSerializable = "0"
			xyDiagram1.SecondaryAxesX.AddRange(New DevExpress.XtraCharts.SecondaryAxisX() { secondaryAxisX1})
			Me.chart.Diagram = xyDiagram1
			Me.chart.Dock = System.Windows.Forms.DockStyle.Fill
			Me.chart.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Right
			Me.chart.Legend.AlignmentVertical = DevExpress.XtraCharts.LegendAlignmentVertical.TopOutside
			Me.chart.Legend.Direction = DevExpress.XtraCharts.LegendDirection.LeftToRight
			Me.chart.Legend.Name = "Default Legend"
			Me.chart.Location = New System.Drawing.Point(0, 46)
			Me.chart.Name = "chart"
			series1.ArgumentDataMember = "Products.ProductName"
			series1.Name = "Series 1"
			series1.SeriesPointsSorting = DevExpress.XtraCharts.SortingMode.Ascending
			series1.SeriesPointsSortingKey = DevExpress.XtraCharts.SeriesPointKey.Value_1
			series1.ValueDataMembersSerializable = "Products.UnitPrice"
			series2.ArgumentDataMember = "Products.ProductName"
			series2.Name = "Series 2"
			series2.SeriesPointsSorting = DevExpress.XtraCharts.SortingMode.Ascending
			series2.SeriesPointsSortingKey = DevExpress.XtraCharts.SeriesPointKey.Value_1
			series2.ValueDataMembersSerializable = "Products.UnitPrice"
			sideBySideBarSeriesView1.AxisXName = "secondaryAxisX1"
			sideBySideBarSeriesView1.PaneName = "Pane 1"
			series2.View = sideBySideBarSeriesView1
			Me.chart.SeriesSerializable = New DevExpress.XtraCharts.Series() { series1, series2}
			Me.chart.Size = New System.Drawing.Size(700, 454)
			Me.chart.TabIndex = 2
			Me.chart.TabStop = False
			chartTitle1.Text = "Northwind Traders: Comparative Categories Chart"
			Me.chart.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() { chartTitle1})
			' 
			' dS31
			' 
			Me.dS31.DataSetName = "DS3"
			Me.dS31.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
			' 
			' lbLeftCategory
			' 
			Me.lbLeftCategory.Location = New System.Drawing.Point(12, 12)
			Me.lbLeftCategory.Margin = New System.Windows.Forms.Padding(0, 10, 3, 10)
			Me.lbLeftCategory.Name = "lbLeftCategory"
			Me.lbLeftCategory.Size = New System.Drawing.Size(69, 13)
			Me.lbLeftCategory.TabIndex = 17
			Me.lbLeftCategory.Text = "Left category:"
			' 
			' cbLeftCategory
			' 
			Me.cbLeftCategory.EditValue = ""
			Me.cbLeftCategory.Location = New System.Drawing.Point(84, 9)
			Me.cbLeftCategory.Margin = New System.Windows.Forms.Padding(0, 0, 10, 10)
			Me.cbLeftCategory.Name = "cbLeftCategory"
			Me.cbLeftCategory.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.cbLeftCategory.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
			Me.cbLeftCategory.Size = New System.Drawing.Size(100, 20)
			Me.cbLeftCategory.TabIndex = 0
'			Me.cbLeftCategory.SelectedIndexChanged += New System.EventHandler(Me.cbLeftCategory_SelectedIndexChanged);
			' 
			' lbRightCategory
			' 
			Me.lbRightCategory.Location = New System.Drawing.Point(204, 12)
			Me.lbRightCategory.Margin = New System.Windows.Forms.Padding(10, 10, 0, 10)
			Me.lbRightCategory.Name = "lbRightCategory"
			Me.lbRightCategory.Size = New System.Drawing.Size(75, 13)
			Me.lbRightCategory.TabIndex = 19
			Me.lbRightCategory.Text = "Right category:"
			' 
			' cbRightCategory
			' 
			Me.cbRightCategory.EditValue = ""
			Me.cbRightCategory.Location = New System.Drawing.Point(282, 9)
			Me.cbRightCategory.Margin = New System.Windows.Forms.Padding(3, 0, 10, 10)
			Me.cbRightCategory.Name = "cbRightCategory"
			Me.cbRightCategory.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.cbRightCategory.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
			Me.cbRightCategory.Size = New System.Drawing.Size(100, 20)
			Me.cbRightCategory.TabIndex = 1
'			Me.cbRightCategory.SelectedIndexChanged += New System.EventHandler(Me.cbRightCategory_SelectedIndexChanged);
			' 
			' HorizontalPanesDemo
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.chart)
			Me.Name = "HorizontalPanesDemo"
			Me.Controls.SetChildIndex(Me.panelRoot, 0)
			Me.Controls.SetChildIndex(Me.chart, 0)
			CType(Me.panel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panel.ResumeLayout(False)
			Me.panel.PerformLayout()
			CType(Me.checkEditShowLabels.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panelRoot.ResumeLayout(False)
			CType(xyDiagramPane1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(secondaryAxisX1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(xyDiagram1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(series1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(sideBySideBarSeriesView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(series2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.chart, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.dS31, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.cbLeftCategory.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.cbRightCategory.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private chart As ChartControl
		Private oleDbDataAdapterProducts As System.Data.OleDb.OleDbDataAdapter
		Private oleDbSelectCommand2 As System.Data.OleDb.OleDbCommand
		Private oleDbConnection1 As System.Data.OleDb.OleDbConnection
		Private oleDbDataAdapterCategories As System.Data.OleDb.OleDbDataAdapter
		Private oleDbSelectCommand1 As System.Data.OleDb.OleDbCommand
		Private dS31 As DS3
		Private lbRightCategory As DevExpress.XtraEditors.LabelControl
		Private WithEvents cbRightCategory As DevExpress.XtraEditors.ComboBoxEdit
		Private lbLeftCategory As DevExpress.XtraEditors.LabelControl
		Private WithEvents cbLeftCategory As DevExpress.XtraEditors.ComboBoxEdit
	End Class
End Namespace
