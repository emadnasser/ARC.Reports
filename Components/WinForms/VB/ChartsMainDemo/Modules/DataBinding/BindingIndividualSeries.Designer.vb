Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.XtraCharts.Demos.DataBinding
	Partial Public Class BindingIndividualSeriesDemo
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
			Dim barSlideAnimation1 As New DevExpress.XtraCharts.BarSlideAnimation()
			Dim bounceEasingFunction1 As New DevExpress.XtraCharts.BounceEasingFunction()
			Dim sideBySideBarSeriesLabel2 As New DevExpress.XtraCharts.SideBySideBarSeriesLabel()
			Dim chartTitle1 As New DevExpress.XtraCharts.ChartTitle()
			Dim chartTitle2 As New DevExpress.XtraCharts.ChartTitle()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(BindingIndividualSeriesDemo))
			Me.ds1 = New DevExpress.XtraCharts.Demos.DS()
			Me.chart = New DevExpress.XtraCharts.ChartControl()
			Me.oleDbDataAdapterProducts = New System.Data.OleDb.OleDbDataAdapter()
			Me.oleDbDeleteCommand2 = New System.Data.OleDb.OleDbCommand()
			Me.oleDbConnection1 = New System.Data.OleDb.OleDbConnection()
			Me.oleDbInsertCommand2 = New System.Data.OleDb.OleDbCommand()
			Me.oleDbSelectCommand2 = New System.Data.OleDb.OleDbCommand()
			Me.oleDbUpdateCommand2 = New System.Data.OleDb.OleDbCommand()
			Me.oleDbDataAdapterCategories = New System.Data.OleDb.OleDbDataAdapter()
			Me.oleDbDeleteCommand1 = New System.Data.OleDb.OleDbCommand()
			Me.oleDbInsertCommand1 = New System.Data.OleDb.OleDbCommand()
			Me.oleDbSelectCommand1 = New System.Data.OleDb.OleDbCommand()
			Me.oleDbUpdateCommand1 = New System.Data.OleDb.OleDbCommand()
			Me.comboBoxEditFilter = New DevExpress.XtraEditors.ComboBoxEdit()
			Me.comboBoxEditSortOrder = New DevExpress.XtraEditors.ComboBoxEdit()
			Me.comboBoxEditSortBy = New DevExpress.XtraEditors.ComboBoxEdit()
			Me.labelSortOrder = New DevExpress.XtraEditors.LabelControl()
			Me.labelSortBy = New DevExpress.XtraEditors.LabelControl()
			Me.labelFilter = New DevExpress.XtraEditors.LabelControl()
			CType(Me.panel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panel.SuspendLayout()
			CType(Me.checkEditShowLabels.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panelRoot.SuspendLayout()
			CType(Me.ds1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.chart, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(xyDiagram1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(series1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(sideBySideBarSeriesLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(sideBySideBarSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(sideBySideBarSeriesLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.comboBoxEditFilter.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.comboBoxEditSortOrder.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.comboBoxEditSortBy.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' panel
			' 
			Me.panel.Controls.Add(Me.labelFilter)
			Me.panel.Controls.Add(Me.labelSortBy)
			Me.panel.Controls.Add(Me.labelSortOrder)
			Me.panel.Controls.Add(Me.comboBoxEditSortBy)
			Me.panel.Controls.Add(Me.comboBoxEditSortOrder)
			Me.panel.Controls.Add(Me.comboBoxEditFilter)
			Me.panel.Controls.SetChildIndex(Me.checkEditShowLabels, 0)
			Me.panel.Controls.SetChildIndex(Me.comboBoxEditFilter, 0)
			Me.panel.Controls.SetChildIndex(Me.comboBoxEditSortOrder, 0)
			Me.panel.Controls.SetChildIndex(Me.comboBoxEditSortBy, 0)
			Me.panel.Controls.SetChildIndex(Me.labelSortOrder, 0)
			Me.panel.Controls.SetChildIndex(Me.labelSortBy, 0)
			Me.panel.Controls.SetChildIndex(Me.labelFilter, 0)
			' 
			' checkEditShowLabels
			' 
			Me.checkEditShowLabels.Size = New System.Drawing.Size(82, 19)
			Me.checkEditShowLabels.TabIndex = 4
			' 
			' ds1
			' 
			Me.ds1.DataSetName = "DS"
			Me.ds1.EnforceConstraints = False
			Me.ds1.Locale = New System.Globalization.CultureInfo("en-US")
			Me.ds1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
			' 
			' chart
			' 
			Me.chart.DataAdapter = Me.oleDbDataAdapterProducts
			Me.chart.DataBindings = Nothing
			xyDiagram1.AxisX.Label.Angle = -30
			xyDiagram1.AxisX.Title.Text = "Products"
			xyDiagram1.AxisX.VisibleInPanesSerializable = "-1"
			xyDiagram1.AxisY.Interlaced = True
			xyDiagram1.AxisY.Title.Text = "Price, Millions of Dollars"
			xyDiagram1.AxisY.Title.Visibility = DevExpress.Utils.DefaultBoolean.True
			xyDiagram1.AxisY.VisibleInPanesSerializable = "-1"
			Me.chart.Diagram = xyDiagram1
			Me.chart.Dock = System.Windows.Forms.DockStyle.Fill
			Me.chart.Legend.Name = "Default Legend"
			Me.chart.Location = New System.Drawing.Point(0, 74)
			Me.chart.Name = "chart"
			series1.ArgumentDataMember = "ProductName"
			series1.DataSource = Me.ds1.Products
			sideBySideBarSeriesLabel1.LineVisibility = DevExpress.Utils.DefaultBoolean.True
			series1.Label = sideBySideBarSeriesLabel1
			series1.Name = "Products"
			series1.SeriesPointsSorting = DevExpress.XtraCharts.SortingMode.Ascending
			series1.SeriesPointsSortingKey = DevExpress.XtraCharts.SeriesPointKey.Value_1
			series1.ValueDataMembersSerializable = "UnitPrice"
			barSlideAnimation1.Direction = DevExpress.XtraCharts.AnimationDirection.FromTop
			bounceEasingFunction1.EasingMode = DevExpress.XtraCharts.EasingMode.Out
			barSlideAnimation1.EasingFunction = bounceEasingFunction1
			barSlideAnimation1.PointDelay = System.TimeSpan.Parse("00:00:00.1000000")
			sideBySideBarSeriesView1.Animation = barSlideAnimation1
			series1.View = sideBySideBarSeriesView1
			Me.chart.SeriesSerializable = New DevExpress.XtraCharts.Series() { series1}
			sideBySideBarSeriesLabel2.LineVisibility = DevExpress.Utils.DefaultBoolean.True
			Me.chart.SeriesTemplate.Label = sideBySideBarSeriesLabel2
			Me.chart.Size = New System.Drawing.Size(700, 426)
			Me.chart.TabIndex = 1
			Me.chart.TabStop = False
			chartTitle1.Alignment = System.Drawing.StringAlignment.Near
			chartTitle1.Font = New System.Drawing.Font("Tahoma", 10F)
			chartTitle1.Text = ""
			chartTitle2.Text = "Northwind Traders"
			Me.chart.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() { chartTitle1, chartTitle2})
'			Me.chart.BoundDataChanged += New DevExpress.XtraCharts.BoundDataChangedEventHandler(Me.chart_BoundDataChanged);
			' 
			' oleDbDataAdapterProducts
			' 
			Me.oleDbDataAdapterProducts.DeleteCommand = Me.oleDbDeleteCommand2
			Me.oleDbDataAdapterProducts.InsertCommand = Me.oleDbInsertCommand2
			Me.oleDbDataAdapterProducts.SelectCommand = Me.oleDbSelectCommand2
			Me.oleDbDataAdapterProducts.TableMappings.AddRange(New System.Data.Common.DataTableMapping() { New System.Data.Common.DataTableMapping("Table", "Products", New System.Data.Common.DataColumnMapping() { New System.Data.Common.DataColumnMapping("ProductID", "ProductID"), New System.Data.Common.DataColumnMapping("ProductName", "ProductName"), New System.Data.Common.DataColumnMapping("SupplierID", "SupplierID"), New System.Data.Common.DataColumnMapping("CategoryID", "CategoryID"), New System.Data.Common.DataColumnMapping("QuantityPerUnit", "QuantityPerUnit"), New System.Data.Common.DataColumnMapping("UnitPrice", "UnitPrice"), New System.Data.Common.DataColumnMapping("UnitsInStock", "UnitsInStock"), New System.Data.Common.DataColumnMapping("UnitsOnOrder", "UnitsOnOrder"), New System.Data.Common.DataColumnMapping("ReorderLevel", "ReorderLevel"), New System.Data.Common.DataColumnMapping("Discontinued", "Discontinued"), New System.Data.Common.DataColumnMapping("EAN13", "EAN13")})})
			Me.oleDbDataAdapterProducts.UpdateCommand = Me.oleDbUpdateCommand2
			' 
			' oleDbDeleteCommand2
			' 
			Me.oleDbDeleteCommand2.CommandText = resources.GetString("oleDbDeleteCommand2.CommandText")
			Me.oleDbDeleteCommand2.Connection = Me.oleDbConnection1
			Me.oleDbDeleteCommand2.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() { New System.Data.OleDb.OleDbParameter("Original_ProductID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, (CByte(10)), (CByte(0)), "ProductID", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_Discontinued", System.Data.OleDb.OleDbType.Boolean, 2, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "Discontinued", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_EAN13", System.Data.OleDb.OleDbType.VarWChar, 12, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "EAN13", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_EAN131", System.Data.OleDb.OleDbType.VarWChar, 12, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "EAN13", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_ProductName", System.Data.OleDb.OleDbType.VarWChar, 40, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "ProductName", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_QuantityPerUnit", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "QuantityPerUnit", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_QuantityPerUnit1", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "QuantityPerUnit", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_ReorderLevel", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, False, (CByte(5)), (CByte(0)), "ReorderLevel", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_ReorderLevel1", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, False, (CByte(5)), (CByte(0)), "ReorderLevel", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_UnitPrice", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, False, (CByte(19)), (CByte(0)), "UnitPrice", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_UnitPrice1", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, False, (CByte(19)), (CByte(0)), "UnitPrice", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_UnitsInStock", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, False, (CByte(5)), (CByte(0)), "UnitsInStock", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_UnitsInStock1", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, False, (CByte(5)), (CByte(0)), "UnitsInStock", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_UnitsOnOrder", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, False, (CByte(5)), (CByte(0)), "UnitsOnOrder", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_UnitsOnOrder1", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, False, (CByte(5)), (CByte(0)), "UnitsOnOrder", System.Data.DataRowVersion.Original, Nothing)})
			' 
			' oleDbInsertCommand2
			' 
			Me.oleDbInsertCommand2.CommandText = "INSERT INTO Products(CategoryID, Discontinued, EAN13, ProductName, QuantityPerUni" & "t, ReorderLevel, SupplierID, UnitPrice, UnitsInStock, UnitsOnOrder) VALUES (?, ?" & ", ?, ?, ?, ?, ?, ?, ?, ?)"
			Me.oleDbInsertCommand2.Connection = Me.oleDbConnection1
			Me.oleDbInsertCommand2.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() { New System.Data.OleDb.OleDbParameter("CategoryID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, (CByte(10)), (CByte(0)), "CategoryID", System.Data.DataRowVersion.Current, Nothing), New System.Data.OleDb.OleDbParameter("Discontinued", System.Data.OleDb.OleDbType.Boolean, 2, "Discontinued"), New System.Data.OleDb.OleDbParameter("EAN13", System.Data.OleDb.OleDbType.VarWChar, 12, "EAN13"), New System.Data.OleDb.OleDbParameter("ProductName", System.Data.OleDb.OleDbType.VarWChar, 40, "ProductName"), New System.Data.OleDb.OleDbParameter("QuantityPerUnit", System.Data.OleDb.OleDbType.VarWChar, 20, "QuantityPerUnit"), New System.Data.OleDb.OleDbParameter("ReorderLevel", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, False, (CByte(5)), (CByte(0)), "ReorderLevel", System.Data.DataRowVersion.Current, Nothing), New System.Data.OleDb.OleDbParameter("SupplierID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, (CByte(10)), (CByte(0)), "SupplierID", System.Data.DataRowVersion.Current, Nothing), New System.Data.OleDb.OleDbParameter("UnitPrice", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, False, (CByte(19)), (CByte(0)), "UnitPrice", System.Data.DataRowVersion.Current, Nothing), New System.Data.OleDb.OleDbParameter("UnitsInStock", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, False, (CByte(5)), (CByte(0)), "UnitsInStock", System.Data.DataRowVersion.Current, Nothing), New System.Data.OleDb.OleDbParameter("UnitsOnOrder", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, False, (CByte(5)), (CByte(0)), "UnitsOnOrder", System.Data.DataRowVersion.Current, Nothing)})
			' 
			' oleDbSelectCommand2
			' 
			Me.oleDbSelectCommand2.CommandText = "SELECT CategoryID, Discontinued, EAN13, ProductID, ProductName, QuantityPerUnit, " & "ReorderLevel, SupplierID, UnitPrice, UnitsInStock, UnitsOnOrder FROM Products"
			Me.oleDbSelectCommand2.Connection = Me.oleDbConnection1
			' 
			' oleDbUpdateCommand2
			' 
			Me.oleDbUpdateCommand2.CommandText = resources.GetString("oleDbUpdateCommand2.CommandText")
			Me.oleDbUpdateCommand2.Connection = Me.oleDbConnection1
			Me.oleDbUpdateCommand2.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() { New System.Data.OleDb.OleDbParameter("CategoryID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, (CByte(10)), (CByte(0)), "CategoryID", System.Data.DataRowVersion.Current, Nothing), New System.Data.OleDb.OleDbParameter("Discontinued", System.Data.OleDb.OleDbType.Boolean, 2, "Discontinued"), New System.Data.OleDb.OleDbParameter("EAN13", System.Data.OleDb.OleDbType.VarWChar, 12, "EAN13"), New System.Data.OleDb.OleDbParameter("ProductName", System.Data.OleDb.OleDbType.VarWChar, 40, "ProductName"), New System.Data.OleDb.OleDbParameter("QuantityPerUnit", System.Data.OleDb.OleDbType.VarWChar, 20, "QuantityPerUnit"), New System.Data.OleDb.OleDbParameter("ReorderLevel", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, False, (CByte(5)), (CByte(0)), "ReorderLevel", System.Data.DataRowVersion.Current, Nothing), New System.Data.OleDb.OleDbParameter("SupplierID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, (CByte(10)), (CByte(0)), "SupplierID", System.Data.DataRowVersion.Current, Nothing), New System.Data.OleDb.OleDbParameter("UnitPrice", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, False, (CByte(19)), (CByte(0)), "UnitPrice", System.Data.DataRowVersion.Current, Nothing), New System.Data.OleDb.OleDbParameter("UnitsInStock", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, False, (CByte(5)), (CByte(0)), "UnitsInStock", System.Data.DataRowVersion.Current, Nothing), New System.Data.OleDb.OleDbParameter("UnitsOnOrder", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, False, (CByte(5)), (CByte(0)), "UnitsOnOrder", System.Data.DataRowVersion.Current, Nothing), New System.Data.OleDb.OleDbParameter("Original_ProductID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, (CByte(10)), (CByte(0)), "ProductID", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_Discontinued", System.Data.OleDb.OleDbType.Boolean, 2, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "Discontinued", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_EAN13", System.Data.OleDb.OleDbType.VarWChar, 12, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "EAN13", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_EAN131", System.Data.OleDb.OleDbType.VarWChar, 12, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "EAN13", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_ProductName", System.Data.OleDb.OleDbType.VarWChar, 40, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "ProductName", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_QuantityPerUnit", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "QuantityPerUnit", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_QuantityPerUnit1", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "QuantityPerUnit", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_ReorderLevel", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, False, (CByte(5)), (CByte(0)), "ReorderLevel", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_ReorderLevel1", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, False, (CByte(5)), (CByte(0)), "ReorderLevel", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_UnitPrice", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, False, (CByte(19)), (CByte(0)), "UnitPrice", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_UnitPrice1", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, False, (CByte(19)), (CByte(0)), "UnitPrice", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_UnitsInStock", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, False, (CByte(5)), (CByte(0)), "UnitsInStock", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_UnitsInStock1", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, False, (CByte(5)), (CByte(0)), "UnitsInStock", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_UnitsOnOrder", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, False, (CByte(5)), (CByte(0)), "UnitsOnOrder", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_UnitsOnOrder1", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, False, (CByte(5)), (CByte(0)), "UnitsOnOrder", System.Data.DataRowVersion.Original, Nothing)})
			' 
			' oleDbDataAdapterCategories
			' 
			Me.oleDbDataAdapterCategories.DeleteCommand = Me.oleDbDeleteCommand1
			Me.oleDbDataAdapterCategories.InsertCommand = Me.oleDbInsertCommand1
			Me.oleDbDataAdapterCategories.SelectCommand = Me.oleDbSelectCommand1
			Me.oleDbDataAdapterCategories.TableMappings.AddRange(New System.Data.Common.DataTableMapping() { New System.Data.Common.DataTableMapping("Table", "Categories", New System.Data.Common.DataColumnMapping() { New System.Data.Common.DataColumnMapping("CategoryID", "CategoryID"), New System.Data.Common.DataColumnMapping("CategoryName", "CategoryName"), New System.Data.Common.DataColumnMapping("Description", "Description"), New System.Data.Common.DataColumnMapping("Picture", "Picture")})})
			Me.oleDbDataAdapterCategories.UpdateCommand = Me.oleDbUpdateCommand1
			' 
			' oleDbDeleteCommand1
			' 
			Me.oleDbDeleteCommand1.CommandText = "DELETE FROM Categories WHERE (CategoryID = ?) AND (CategoryName = ?) AND (Descrip" & "tion = ? OR ? IS NULL AND Description IS NULL) AND (Picture = ? OR ? IS NULL AND" & " Picture IS NULL)"
			Me.oleDbDeleteCommand1.Connection = Me.oleDbConnection1
			Me.oleDbDeleteCommand1.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() { New System.Data.OleDb.OleDbParameter("Original_CategoryID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, (CByte(10)), (CByte(0)), "CategoryID", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_CategoryName", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "CategoryName", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_Description", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "Description", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_Description1", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "Description", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_Picture", System.Data.OleDb.OleDbType.VarBinary, 0, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "Picture", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_Picture1", System.Data.OleDb.OleDbType.VarBinary, 0, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "Picture", System.Data.DataRowVersion.Original, Nothing)})
			' 
			' oleDbInsertCommand1
			' 
			Me.oleDbInsertCommand1.CommandText = "INSERT INTO Categories(CategoryName, Description, Picture) VALUES (?, ?, ?)"
			Me.oleDbInsertCommand1.Connection = Me.oleDbConnection1
			Me.oleDbInsertCommand1.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() { New System.Data.OleDb.OleDbParameter("CategoryName", System.Data.OleDb.OleDbType.VarWChar, 15, "CategoryName"), New System.Data.OleDb.OleDbParameter("Description", System.Data.OleDb.OleDbType.VarWChar, 0, "Description"), New System.Data.OleDb.OleDbParameter("Picture", System.Data.OleDb.OleDbType.VarBinary, 0, "Picture")})
			' 
			' oleDbSelectCommand1
			' 
			Me.oleDbSelectCommand1.CommandText = "SELECT CategoryID, CategoryName, Description, Picture FROM Categories"
			Me.oleDbSelectCommand1.Connection = Me.oleDbConnection1
			' 
			' oleDbUpdateCommand1
			' 
			Me.oleDbUpdateCommand1.CommandText = resources.GetString("oleDbUpdateCommand1.CommandText")
			Me.oleDbUpdateCommand1.Connection = Me.oleDbConnection1
			Me.oleDbUpdateCommand1.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() { New System.Data.OleDb.OleDbParameter("CategoryName", System.Data.OleDb.OleDbType.VarWChar, 15, "CategoryName"), New System.Data.OleDb.OleDbParameter("Description", System.Data.OleDb.OleDbType.VarWChar, 0, "Description"), New System.Data.OleDb.OleDbParameter("Picture", System.Data.OleDb.OleDbType.VarBinary, 0, "Picture"), New System.Data.OleDb.OleDbParameter("Original_CategoryID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, (CByte(10)), (CByte(0)), "CategoryID", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_CategoryName", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "CategoryName", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_Description", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "Description", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_Description1", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "Description", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_Picture", System.Data.OleDb.OleDbType.VarBinary, 0, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "Picture", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_Picture1", System.Data.OleDb.OleDbType.VarBinary, 0, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "Picture", System.Data.DataRowVersion.Original, Nothing)})
			' 
			' comboBoxEditFilter
			' 
			Me.comboBoxEditFilter.EditValue = ""
			Me.comboBoxEditFilter.Location = New System.Drawing.Point(282, 9)
			Me.comboBoxEditFilter.Margin = New System.Windows.Forms.Padding(3, 0, 10, 10)
			Me.comboBoxEditFilter.Name = "comboBoxEditFilter"
			Me.comboBoxEditFilter.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.comboBoxEditFilter.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
			Me.comboBoxEditFilter.Size = New System.Drawing.Size(100, 20)
			Me.comboBoxEditFilter.TabIndex = 2
'			Me.comboBoxEditFilter.SelectedIndexChanged += New System.EventHandler(Me.comboBoxEditFilter_SelectedIndexChanged);
			' 
			' comboBoxEditSortOrder
			' 
			Me.comboBoxEditSortOrder.EditValue = ""
			Me.comboBoxEditSortOrder.Location = New System.Drawing.Point(70, 9)
			Me.comboBoxEditSortOrder.Margin = New System.Windows.Forms.Padding(3, 0, 10, 10)
			Me.comboBoxEditSortOrder.Name = "comboBoxEditSortOrder"
			Me.comboBoxEditSortOrder.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.comboBoxEditSortOrder.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
			Me.comboBoxEditSortOrder.Size = New System.Drawing.Size(100, 20)
			Me.comboBoxEditSortOrder.TabIndex = 0
'			Me.comboBoxEditSortOrder.SelectedIndexChanged += New System.EventHandler(Me.comboBoxEditSortOrder_SelectedIndexChanged);
			' 
			' comboBoxEditSortBy
			' 
			Me.comboBoxEditSortBy.EditValue = ""
			Me.comboBoxEditSortBy.Location = New System.Drawing.Point(70, 37)
			Me.comboBoxEditSortBy.Margin = New System.Windows.Forms.Padding(3, 10, 10, 0)
			Me.comboBoxEditSortBy.Name = "comboBoxEditSortBy"
			Me.comboBoxEditSortBy.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.comboBoxEditSortBy.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
			Me.comboBoxEditSortBy.Size = New System.Drawing.Size(100, 20)
			Me.comboBoxEditSortBy.TabIndex = 1
'			Me.comboBoxEditSortBy.SelectedIndexChanged += New System.EventHandler(Me.comboBoxEditSortBy_SelectedIndexChanged);
			' 
			' labelSortOrder
			' 
			Me.labelSortOrder.Location = New System.Drawing.Point(12, 12)
			Me.labelSortOrder.Margin = New System.Windows.Forms.Padding(10, 10, 0, 10)
			Me.labelSortOrder.Name = "labelSortOrder"
			Me.labelSortOrder.Size = New System.Drawing.Size(55, 13)
			Me.labelSortOrder.TabIndex = 13
			Me.labelSortOrder.Text = "Sort Order:"
			' 
			' labelSortBy
			' 
			Me.labelSortBy.Location = New System.Drawing.Point(12, 40)
			Me.labelSortBy.Margin = New System.Windows.Forms.Padding(10, 10, 0, 10)
			Me.labelSortBy.Name = "labelSortBy"
			Me.labelSortBy.Size = New System.Drawing.Size(39, 13)
			Me.labelSortBy.TabIndex = 14
			Me.labelSortBy.Text = "Sort By:"
			' 
			' labelFilter
			' 
			Me.labelFilter.Location = New System.Drawing.Point(188, 12)
			Me.labelFilter.Margin = New System.Windows.Forms.Padding(10, 10, 0, 10)
			Me.labelFilter.Name = "labelFilter"
			Me.labelFilter.Size = New System.Drawing.Size(91, 13)
			Me.labelFilter.TabIndex = 15
			Me.labelFilter.Text = "Filter By Category:"
			' 
			' BindingIndividualSeriesDemo
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.chart)
			Me.Name = "BindingIndividualSeriesDemo"
			Me.Controls.SetChildIndex(Me.panelRoot, 0)
			Me.Controls.SetChildIndex(Me.chart, 0)
			CType(Me.panel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panel.ResumeLayout(False)
			Me.panel.PerformLayout()
			CType(Me.checkEditShowLabels.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panelRoot.ResumeLayout(False)
			CType(Me.ds1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(xyDiagram1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(sideBySideBarSeriesLabel1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(sideBySideBarSeriesView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(series1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(sideBySideBarSeriesLabel2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.chart, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.comboBoxEditFilter.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.comboBoxEditSortOrder.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.comboBoxEditSortBy.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region
		Private components As System.ComponentModel.IContainer = Nothing
		Private labelSortOrder As DevExpress.XtraEditors.LabelControl
		Private labelFilter As DevExpress.XtraEditors.LabelControl
		Private labelSortBy As DevExpress.XtraEditors.LabelControl
	End Class
End Namespace
