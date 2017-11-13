Imports Microsoft.VisualBasic
Imports System
Namespace DashboardMainDemo.Dashboards
	Partial Public Class ProductDetails
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
			Dim dimension1 As New DevExpress.DashboardCommon.Dimension()
			Dim calculatedField1 As New DevExpress.DashboardCommon.CalculatedField()
			Dim calculatedField2 As New DevExpress.DashboardCommon.CalculatedField()
			Dim calculatedField3 As New DevExpress.DashboardCommon.CalculatedField()
			Dim calculatedField4 As New DevExpress.DashboardCommon.CalculatedField()
			Dim calculatedField5 As New DevExpress.DashboardCommon.CalculatedField()
			Dim calculatedField6 As New DevExpress.DashboardCommon.CalculatedField()
			Dim xmlFileConnectionParameters1 As New DevExpress.DataAccess.ConnectionParameters.XmlFileConnectionParameters()
			Dim selectQuery1 As New DevExpress.DataAccess.Sql.SelectQuery()
			Dim column1 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression1 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim table1 As New DevExpress.DataAccess.Sql.Table()
			Dim column2 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression2 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim column3 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression3 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim column4 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression4 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim column5 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression5 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim column6 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression6 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim column7 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression7 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim table2 As New DevExpress.DataAccess.Sql.Table()
			Dim column8 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression8 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim table3 As New DevExpress.DataAccess.Sql.Table()
			Dim column9 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression9 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim column10 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression10 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim table4 As New DevExpress.DataAccess.Sql.Table()
			Dim column11 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression11 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim column12 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression12 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim column13 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression13 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim column14 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression14 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim join1 As New DevExpress.DataAccess.Sql.Join()
			Dim relationColumnInfo1 As New DevExpress.DataAccess.Sql.RelationColumnInfo()
			Dim join2 As New DevExpress.DataAccess.Sql.Join()
			Dim relationColumnInfo2 As New DevExpress.DataAccess.Sql.RelationColumnInfo()
			Dim join3 As New DevExpress.DataAccess.Sql.Join()
			Dim relationColumnInfo3 As New DevExpress.DataAccess.Sql.RelationColumnInfo()
			Dim table5 As New DevExpress.DataAccess.Sql.Table()
			Dim join4 As New DevExpress.DataAccess.Sql.Join()
			Dim relationColumnInfo4 As New DevExpress.DataAccess.Sql.RelationColumnInfo()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(ProductDetails))
			Dim measure1 As New DevExpress.DashboardCommon.Measure()
			Dim measure2 As New DevExpress.DashboardCommon.Measure()
			Dim measure3 As New DevExpress.DashboardCommon.Measure()
			Dim measure4 As New DevExpress.DashboardCommon.Measure()
			Dim measure5 As New DevExpress.DashboardCommon.Measure()
			Dim measure6 As New DevExpress.DashboardCommon.Measure()
			Dim measure7 As New DevExpress.DashboardCommon.Measure()
			Dim dimension2 As New DevExpress.DashboardCommon.Dimension()
			Dim dimension3 As New DevExpress.DashboardCommon.Dimension()
			Dim dimension4 As New DevExpress.DashboardCommon.Dimension()
			Dim dimension5 As New DevExpress.DashboardCommon.Dimension()
			Dim dimension6 As New DevExpress.DashboardCommon.Dimension()
			Dim measure8 As New DevExpress.DashboardCommon.Measure()
			Dim measure9 As New DevExpress.DashboardCommon.Measure()
			Dim runningTotalCalculation1 As New DevExpress.DashboardCommon.RunningTotalCalculation()
			Dim chartWindowDefinition1 As New DevExpress.DashboardCommon.ChartWindowDefinition()
			Dim chartPane1 As New DevExpress.DashboardCommon.ChartPane()
			Dim simpleSeries1 As New DevExpress.DashboardCommon.SimpleSeries()
			Dim simpleSeries2 As New DevExpress.DashboardCommon.SimpleSeries()
			Dim dashboardLayoutGroup1 As New DevExpress.DashboardCommon.DashboardLayoutGroup()
			Dim dashboardLayoutGroup2 As New DevExpress.DashboardCommon.DashboardLayoutGroup()
			Dim dashboardLayoutItem1 As New DevExpress.DashboardCommon.DashboardLayoutItem()
			Dim dashboardLayoutItem2 As New DevExpress.DashboardCommon.DashboardLayoutItem()
			Dim dashboardLayoutGroup3 As New DevExpress.DashboardCommon.DashboardLayoutGroup()
			Dim dashboardLayoutItem3 As New DevExpress.DashboardCommon.DashboardLayoutItem()
			Dim dashboardLayoutItem4 As New DevExpress.DashboardCommon.DashboardLayoutItem()
			Dim dashboardLayoutGroup4 As New DevExpress.DashboardCommon.DashboardLayoutGroup()
			Dim dashboardLayoutItem5 As New DevExpress.DashboardCommon.DashboardLayoutItem()
			Dim dashboardLayoutItem6 As New DevExpress.DashboardCommon.DashboardLayoutItem()
			Me.comboBoxDashboardItem1 = New DevExpress.DashboardCommon.ComboBoxDashboardItem()
			Me.dashboardSqlDataSource1 = New DevExpress.DashboardCommon.DashboardSqlDataSource()
			Me.dashboardItemGroup1 = New DevExpress.DashboardCommon.DashboardItemGroup()
			Me.textBoxDashboardItem1 = New DevExpress.DashboardCommon.TextBoxDashboardItem()
			Me.boundImageDashboardItem1 = New DevExpress.DashboardCommon.BoundImageDashboardItem()
			Me.boundImageDashboardItem2 = New DevExpress.DashboardCommon.BoundImageDashboardItem()
			Me.comboBoxDashboardItem2 = New DevExpress.DashboardCommon.ComboBoxDashboardItem()
			Me.dashboardItemGroup2 = New DevExpress.DashboardCommon.DashboardItemGroup()
			Me.chartDashboardItem1 = New DevExpress.DashboardCommon.ChartDashboardItem()
			CType(Me.comboBoxDashboardItem1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(dimension1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.dashboardSqlDataSource1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.dashboardItemGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.textBoxDashboardItem1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(measure1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(measure2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(measure3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(measure4, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(measure5, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(measure6, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(measure7, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.boundImageDashboardItem1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(dimension2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.boundImageDashboardItem2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(dimension3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.comboBoxDashboardItem2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(dimension4, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.dashboardItemGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.chartDashboardItem1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(dimension5, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(dimension6, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(measure8, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(measure9, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
			' 
			' comboBoxDashboardItem1
			' 
			Me.comboBoxDashboardItem1.ComponentName = "comboBoxDashboardItem1"
			dimension1.DataMember = "Products_Name"
			dimension1.Name = "Product Name"
			Me.comboBoxDashboardItem1.DataItemRepository.Clear()
			Me.comboBoxDashboardItem1.DataItemRepository.Add(dimension1, "DataItem0")
			Me.comboBoxDashboardItem1.DataMember = "Customers"
			Me.comboBoxDashboardItem1.DataSource = Me.dashboardSqlDataSource1
			Me.comboBoxDashboardItem1.FilterDimensions.AddRange(New DevExpress.DashboardCommon.Dimension() { dimension1})
			Me.comboBoxDashboardItem1.Group = Me.dashboardItemGroup1
			Me.comboBoxDashboardItem1.InteractivityOptions.IgnoreMasterFilters = True
			Me.comboBoxDashboardItem1.Name = "Product"
			Me.comboBoxDashboardItem1.ShowAllValue = False
			Me.comboBoxDashboardItem1.ShowCaption = False
			' 
			' dashboardSqlDataSource1
			' 
			calculatedField1.DataMember = "Customers"
			calculatedField1.Expression = "Aggr(Sum([SalesAmount]), GetYear([OrderDate]))"
			calculatedField1.Name = "ProductSalesByYear"
			calculatedField2.DataMember = "Customers"
			calculatedField2.Expression = "Aggr(Max([ProductSalesByYear]))"
			calculatedField2.Name = "MaxProductSalesYear"
			calculatedField3.DataMember = "Customers"
			calculatedField3.Expression = "Iif([MaxProductSalesYear] = [ProductSalesByYear], GetYear([OrderDate]), null)"
			calculatedField3.Name = "BestSalesYear"
			calculatedField4.DataMember = "Customers"
			calculatedField4.Expression = "Aggr(Sum([SalesAmount]), [Name])"
			calculatedField4.Name = "ProductSalesByCustomer"
			calculatedField5.DataMember = "Customers"
			calculatedField5.Expression = "Aggr(Max([ProductSalesByCustomer]))"
			calculatedField5.Name = "MaxProductSalesCustomer"
			calculatedField6.DataMember = "Customers"
			calculatedField6.Expression = "Iif([MaxProductSalesCustomer] = [ProductSalesByCustomer], [Name], null)"
			calculatedField6.Name = "TopSeller"
			Me.dashboardSqlDataSource1.CalculatedFields.AddRange(New DevExpress.DashboardCommon.CalculatedField() { calculatedField1, calculatedField2, calculatedField3, calculatedField4, calculatedField5, calculatedField6})
			Me.dashboardSqlDataSource1.ComponentName = "dashboardSqlDataSource1"
			Me.dashboardSqlDataSource1.ConnectionName = "Source"
			xmlFileConnectionParameters1.FileName = "Data\DashboardProductDetails.xml"
			Me.dashboardSqlDataSource1.ConnectionParameters = xmlFileConnectionParameters1
			Me.dashboardSqlDataSource1.Name = "ProductDetailsData"
			columnExpression1.ColumnName = "Name"
			table1.MetaSerializable = "180|30|125|200"
			table1.Name = "Customers"
			columnExpression1.Table = table1
			column1.Expression = columnExpression1
			columnExpression2.ColumnName = "Street"
			columnExpression2.Table = table1
			column2.Expression = columnExpression2
			columnExpression3.ColumnName = "City"
			columnExpression3.Table = table1
			column3.Expression = columnExpression3
			columnExpression4.ColumnName = "Latitude"
			columnExpression4.Table = table1
			column4.Expression = columnExpression4
			columnExpression5.ColumnName = "Longitude"
			columnExpression5.Table = table1
			column5.Expression = columnExpression5
			columnExpression6.ColumnName = "Phone"
			columnExpression6.Table = table1
			column6.Expression = columnExpression6
			column7.Alias = "States_Name"
			columnExpression7.ColumnName = "Name"
			table2.MetaSerializable = "30|30|125|80"
			table2.Name = "States"
			columnExpression7.Table = table2
			column7.Expression = columnExpression7
			columnExpression8.ColumnName = "OrderDate"
			table3.MetaSerializable = "330|30|125|120"
			table3.Name = "Orders"
			columnExpression8.Table = table3
			column8.Expression = columnExpression8
			columnExpression9.ColumnName = "SalesAmount"
			columnExpression9.Table = table3
			column9.Expression = columnExpression9
			column10.Alias = "Products_Name"
			columnExpression10.ColumnName = "Name"
			table4.MetaSerializable = "630|30|125|160"
			table4.Name = "Products"
			columnExpression10.Table = table4
			column10.Expression = columnExpression10
			columnExpression11.ColumnName = "Description"
			columnExpression11.Table = table4
			column11.Expression = columnExpression11
			columnExpression12.ColumnName = "ProductionStart"
			columnExpression12.Table = table4
			column12.Expression = columnExpression12
			columnExpression13.ColumnName = "RetailPrice"
			columnExpression13.Table = table4
			column13.Expression = columnExpression13
			columnExpression14.ColumnName = "ConsumerRating"
			columnExpression14.Table = table4
			column14.Expression = columnExpression14
			selectQuery1.Columns.Add(column1)
			selectQuery1.Columns.Add(column2)
			selectQuery1.Columns.Add(column3)
			selectQuery1.Columns.Add(column4)
			selectQuery1.Columns.Add(column5)
			selectQuery1.Columns.Add(column6)
			selectQuery1.Columns.Add(column7)
			selectQuery1.Columns.Add(column8)
			selectQuery1.Columns.Add(column9)
			selectQuery1.Columns.Add(column10)
			selectQuery1.Columns.Add(column11)
			selectQuery1.Columns.Add(column12)
			selectQuery1.Columns.Add(column13)
			selectQuery1.Columns.Add(column14)
			selectQuery1.Name = "Customers"
			relationColumnInfo1.NestedKeyColumn = "Id"
			relationColumnInfo1.ParentKeyColumn = "StateId"
			join1.KeyColumns.Add(relationColumnInfo1)
			join1.Nested = table2
			join1.Parent = table1
			relationColumnInfo2.NestedKeyColumn = "CustomerId"
			relationColumnInfo2.ParentKeyColumn = "Id"
			join2.KeyColumns.Add(relationColumnInfo2)
			join2.Nested = table3
			join2.Parent = table1
			relationColumnInfo3.NestedKeyColumn = "OrderId"
			relationColumnInfo3.ParentKeyColumn = "Id"
			join3.KeyColumns.Add(relationColumnInfo3)
			table5.MetaSerializable = "480|30|125|100"
			table5.Name = "OrderItems"
			join3.Nested = table5
			join3.Parent = table3
			relationColumnInfo4.NestedKeyColumn = "Id"
			relationColumnInfo4.ParentKeyColumn = "ProductId"
			join4.KeyColumns.Add(relationColumnInfo4)
			join4.Nested = table4
			join4.Parent = table5
			selectQuery1.Relations.Add(join1)
			selectQuery1.Relations.Add(join2)
			selectQuery1.Relations.Add(join3)
			selectQuery1.Relations.Add(join4)
			selectQuery1.Tables.Add(table1)
			selectQuery1.Tables.Add(table2)
			selectQuery1.Tables.Add(table3)
			selectQuery1.Tables.Add(table5)
			selectQuery1.Tables.Add(table4)
			Me.dashboardSqlDataSource1.Queries.AddRange(New DevExpress.DataAccess.Sql.SqlQuery() { selectQuery1})
			Me.dashboardSqlDataSource1.ResultSchemaSerializable = resources.GetString("dashboardSqlDataSource1.ResultSchemaSerializable")
			' 
			' dashboardItemGroup1
			' 
			Me.dashboardItemGroup1.ComponentName = "dashboardItemGroup1"
			Me.dashboardItemGroup1.InteractivityOptions.IgnoreMasterFilters = False
			Me.dashboardItemGroup1.InteractivityOptions.IsMasterFilter = True
			Me.dashboardItemGroup1.Name = "Product Details"
			Me.dashboardItemGroup1.ShowCaption = False
			' 
			' textBoxDashboardItem1
			' 
			Me.textBoxDashboardItem1.ComponentName = "textBoxDashboardItem1"
			measure1.DataMember = "Products_Name"
			measure1.Name = "Product Name"
			measure1.SummaryType = DevExpress.DashboardCommon.SummaryType.Min
			measure2.DataMember = "Description"
			measure2.Name = "Description"
			measure2.SummaryType = DevExpress.DashboardCommon.SummaryType.Min
			measure3.DataMember = "ProductionStart"
			measure3.Name = "Production Start"
			measure3.SummaryType = DevExpress.DashboardCommon.SummaryType.Min
			measure4.DataMember = "ConsumerRating"
			measure4.Name = "Consumer Rating"
			measure4.SummaryType = DevExpress.DashboardCommon.SummaryType.Min
			measure5.DataMember = "RetailPrice"
			measure5.Name = "Retail Price"
			measure5.SummaryType = DevExpress.DashboardCommon.SummaryType.Min
			measure6.DataMember = "BestSalesYear"
			measure6.Name = "Best Sales Year"
			measure6.NumericFormat.FormatType = DevExpress.DashboardCommon.DataItemNumericFormatType.General
			measure6.SummaryType = DevExpress.DashboardCommon.SummaryType.Min
			measure7.DataMember = "TopSeller"
			measure7.Name = "Best Sales Company"
			measure7.SummaryType = DevExpress.DashboardCommon.SummaryType.Min
			Me.textBoxDashboardItem1.DataItemRepository.Clear()
			Me.textBoxDashboardItem1.DataItemRepository.Add(measure1, "DataItem0")
			Me.textBoxDashboardItem1.DataItemRepository.Add(measure2, "DataItem2")
			Me.textBoxDashboardItem1.DataItemRepository.Add(measure3, "DataItem3")
			Me.textBoxDashboardItem1.DataItemRepository.Add(measure4, "DataItem4")
			Me.textBoxDashboardItem1.DataItemRepository.Add(measure5, "DataItem6")
			Me.textBoxDashboardItem1.DataItemRepository.Add(measure6, "DataItem5")
			Me.textBoxDashboardItem1.DataItemRepository.Add(measure7, "DataItem7")
			Me.textBoxDashboardItem1.DataMember = "Customers"
			Me.textBoxDashboardItem1.DataSource = Me.dashboardSqlDataSource1
			Me.textBoxDashboardItem1.Group = Me.dashboardItemGroup1
			Me.textBoxDashboardItem1.InnerRtf = resources.GetString("textBoxDashboardItem1.InnerRtf")
			Me.textBoxDashboardItem1.InteractivityOptions.IgnoreMasterFilters = False
			Me.textBoxDashboardItem1.Name = "Product Description"
			Me.textBoxDashboardItem1.ShowCaption = False
			Me.textBoxDashboardItem1.Values.AddRange(New DevExpress.DashboardCommon.Measure() { measure1, measure2, measure3, measure4, measure5, measure6, measure7})
			' 
			' boundImageDashboardItem1
			' 
			Me.boundImageDashboardItem1.ComponentName = "primaryImage"
			Me.boundImageDashboardItem1.DataBindingMode = DevExpress.DashboardCommon.ImageDataBindingMode.Uri
			dimension2.DataMember = "Products_Name"
			dimension2.Name = "Product Name"
			Me.boundImageDashboardItem1.DataItemRepository.Clear()
			Me.boundImageDashboardItem1.DataItemRepository.Add(dimension2, "DataItem0")
			Me.boundImageDashboardItem1.DataMember = "Customers"
			Me.boundImageDashboardItem1.DataSource = Me.dashboardSqlDataSource1
			Me.boundImageDashboardItem1.Group = Me.dashboardItemGroup1
			Me.boundImageDashboardItem1.ImageDimension = dimension2
			Me.boundImageDashboardItem1.InteractivityOptions.IgnoreMasterFilters = False
			Me.boundImageDashboardItem1.Name = "Product Image"
			Me.boundImageDashboardItem1.ShowCaption = False
			Me.boundImageDashboardItem1.SizeMode = DevExpress.DashboardCommon.ImageSizeMode.Squeeze
			Me.boundImageDashboardItem1.UriPattern = "Data\ProductDetailsImages\{0}.jpg"
			' 
			' boundImageDashboardItem2
			' 
			Me.boundImageDashboardItem2.ComponentName = "secondaryImage"
			Me.boundImageDashboardItem2.DataBindingMode = DevExpress.DashboardCommon.ImageDataBindingMode.Uri
			dimension3.DataMember = "Products_Name"
			dimension3.Name = "Product Name"
			Me.boundImageDashboardItem2.DataItemRepository.Clear()
			Me.boundImageDashboardItem2.DataItemRepository.Add(dimension3, "DataItem0")
			Me.boundImageDashboardItem2.DataMember = "Customers"
			Me.boundImageDashboardItem2.DataSource = Me.dashboardSqlDataSource1
			Me.boundImageDashboardItem2.Group = Me.dashboardItemGroup1
			Me.boundImageDashboardItem2.ImageDimension = dimension3
			Me.boundImageDashboardItem2.InteractivityOptions.IgnoreMasterFilters = False
			Me.boundImageDashboardItem2.Name = "Product Image"
			Me.boundImageDashboardItem2.ShowCaption = False
			Me.boundImageDashboardItem2.SizeMode = DevExpress.DashboardCommon.ImageSizeMode.Squeeze
			Me.boundImageDashboardItem2.UriPattern = "Data\ProductDetailsImages\{0} Secondary.jpg"
			' 
			' comboBoxDashboardItem2
			' 
			Me.comboBoxDashboardItem2.ComponentName = "comboBoxDashboardItem2"
			dimension4.DataMember = "Name"
			dimension4.Name = "Company Name"
			Me.comboBoxDashboardItem2.DataItemRepository.Clear()
			Me.comboBoxDashboardItem2.DataItemRepository.Add(dimension4, "DataItem0")
			Me.comboBoxDashboardItem2.DataMember = "Customers"
			Me.comboBoxDashboardItem2.DataSource = Me.dashboardSqlDataSource1
			Me.comboBoxDashboardItem2.FilterDimensions.AddRange(New DevExpress.DashboardCommon.Dimension() { dimension4})
			Me.comboBoxDashboardItem2.Group = Me.dashboardItemGroup2
			Me.comboBoxDashboardItem2.InteractivityOptions.IgnoreMasterFilters = True
			Me.comboBoxDashboardItem2.Name = "Customer"
			Me.comboBoxDashboardItem2.ShowAllValue = False
			Me.comboBoxDashboardItem2.ShowCaption = False
			' 
			' dashboardItemGroup2
			' 
			Me.dashboardItemGroup2.ComponentName = "dashboardItemGroup2"
			Me.dashboardItemGroup2.InteractivityOptions.IgnoreMasterFilters = False
			Me.dashboardItemGroup2.Name = "Sales by Company"
			Me.dashboardItemGroup2.ShowCaption = False
			' 
			' chartDashboardItem1
			' 
			dimension5.ColoringMode = DevExpress.DashboardCommon.ColoringMode.Hue
			dimension5.DataMember = "OrderDate"
			dimension5.Name = "Order Year"
			dimension6.DataMember = "OrderDate"
			dimension6.DateTimeGroupInterval = DevExpress.DashboardCommon.DateTimeGroupInterval.Quarter
			dimension6.Name = "Order Quarter"
			Me.chartDashboardItem1.Arguments.AddRange(New DevExpress.DashboardCommon.Dimension() { dimension5, dimension6})
			Me.chartDashboardItem1.AxisX.TitleVisible = False
			Me.chartDashboardItem1.ColoringOptions.MeasuresColoringMode = DevExpress.DashboardCommon.ColoringMode.None
			Me.chartDashboardItem1.ComponentName = "chartDashboardItem1"
			measure8.DataMember = "SalesAmount"
			measure8.Name = "Sales Amount"
			measure9.Calculation = runningTotalCalculation1
			measure9.DataMember = "SalesAmount"
			measure9.Name = "Running total of Sales Amount"
			measure9.WindowDefinition = chartWindowDefinition1
			Me.chartDashboardItem1.DataItemRepository.Clear()
			Me.chartDashboardItem1.DataItemRepository.Add(dimension5, "DataItem0")
			Me.chartDashboardItem1.DataItemRepository.Add(measure8, "DataItem2")
			Me.chartDashboardItem1.DataItemRepository.Add(measure9, "DataItem3")
			Me.chartDashboardItem1.DataItemRepository.Add(dimension6, "DataItem5")
			Me.chartDashboardItem1.DataMember = "Customers"
			Me.chartDashboardItem1.DataSource = Me.dashboardSqlDataSource1
			Me.chartDashboardItem1.Group = Me.dashboardItemGroup2
			Me.chartDashboardItem1.InteractivityOptions.IgnoreMasterFilters = False
			Me.chartDashboardItem1.Name = "Running Total by Year"
			chartPane1.Name = "Pane 1"
			chartPane1.PrimaryAxisY.AlwaysShowZeroLevel = True
			chartPane1.PrimaryAxisY.ShowGridLines = True
			chartPane1.PrimaryAxisY.Title = "Sales by Company"
			chartPane1.PrimaryAxisY.TitleVisible = True
			chartPane1.SecondaryAxisY.AlwaysShowZeroLevel = True
			chartPane1.SecondaryAxisY.ShowGridLines = False
			chartPane1.SecondaryAxisY.TitleVisible = True
			simpleSeries1.AddDataItem("Value", measure8)
			simpleSeries2.SeriesType = DevExpress.DashboardCommon.SimpleSeriesType.Line
			simpleSeries2.AddDataItem("Value", measure9)
			chartPane1.Series.AddRange(New DevExpress.DashboardCommon.ChartSeries() { simpleSeries1, simpleSeries2})
			Me.chartDashboardItem1.Panes.AddRange(New DevExpress.DashboardCommon.ChartPane() { chartPane1})
			Me.chartDashboardItem1.ShowCaption = False
			' 
			' ProductDetails
			' 
			Me.DataSources.AddRange(New DevExpress.DashboardCommon.IDashboardDataSource() { Me.dashboardSqlDataSource1})
			Me.Groups.AddRange(New DevExpress.DashboardCommon.DashboardItemGroup() { Me.dashboardItemGroup1, Me.dashboardItemGroup2})
			Me.Items.AddRange(New DevExpress.DashboardCommon.DashboardItem() { Me.comboBoxDashboardItem1, Me.textBoxDashboardItem1, Me.boundImageDashboardItem1, Me.chartDashboardItem1, Me.comboBoxDashboardItem2, Me.boundImageDashboardItem2})
			dashboardLayoutItem1.DashboardItem = Me.comboBoxDashboardItem1
			dashboardLayoutItem1.Weight = 6.1052631578947372R
			dashboardLayoutItem2.DashboardItem = Me.textBoxDashboardItem1
			dashboardLayoutItem2.Weight = 68R
			dashboardLayoutItem3.DashboardItem = Me.boundImageDashboardItem1
			dashboardLayoutItem3.Weight = 65.843621399176953R
			dashboardLayoutItem4.DashboardItem = Me.boundImageDashboardItem2
			dashboardLayoutItem4.Weight = 34.156378600823047R
			dashboardLayoutGroup3.ChildNodes.AddRange(New DevExpress.DashboardCommon.DashboardLayoutNode() { dashboardLayoutItem3, dashboardLayoutItem4})
			dashboardLayoutGroup3.DashboardItem = Nothing
			dashboardLayoutGroup3.Weight = 25.894736842105264R
			dashboardLayoutGroup2.ChildNodes.AddRange(New DevExpress.DashboardCommon.DashboardLayoutNode() { dashboardLayoutItem1, dashboardLayoutItem2, dashboardLayoutGroup3})
			dashboardLayoutGroup2.DashboardItem = Me.dashboardItemGroup1
			dashboardLayoutGroup2.Orientation = DevExpress.DashboardCommon.DashboardLayoutGroupOrientation.Vertical
			dashboardLayoutGroup2.Weight = 49.041372351160447R
			dashboardLayoutItem5.DashboardItem = Me.comboBoxDashboardItem2
			dashboardLayoutItem5.Weight = 7.4245939675174011R
			dashboardLayoutItem6.DashboardItem = Me.chartDashboardItem1
			dashboardLayoutItem6.Weight = 92.5754060324826R
			dashboardLayoutGroup4.ChildNodes.AddRange(New DevExpress.DashboardCommon.DashboardLayoutNode() { dashboardLayoutItem5, dashboardLayoutItem6})
			dashboardLayoutGroup4.DashboardItem = Me.dashboardItemGroup2
			dashboardLayoutGroup4.Orientation = DevExpress.DashboardCommon.DashboardLayoutGroupOrientation.Vertical
			dashboardLayoutGroup4.Weight = 50.958627648839553R
			dashboardLayoutGroup1.ChildNodes.AddRange(New DevExpress.DashboardCommon.DashboardLayoutNode() { dashboardLayoutGroup2, dashboardLayoutGroup4})
			dashboardLayoutGroup1.DashboardItem = Nothing
			Me.LayoutRoot = dashboardLayoutGroup1
			Me.Title.Text = "Product Details"
'			Me.DashboardLoading += New System.EventHandler(Me.ProductDetails_DashboardLoading);
'			Me.ConfigureDataConnection += New DevExpress.DashboardCommon.DashboardConfigureDataConnectionEventHandler(Me.ProductDetails_ConfigureDataConnection);
			CType(dimension1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.comboBoxDashboardItem1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.dashboardSqlDataSource1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.dashboardItemGroup1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(measure1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(measure2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(measure3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(measure4, System.ComponentModel.ISupportInitialize).EndInit()
			CType(measure5, System.ComponentModel.ISupportInitialize).EndInit()
			CType(measure6, System.ComponentModel.ISupportInitialize).EndInit()
			CType(measure7, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.textBoxDashboardItem1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(dimension2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.boundImageDashboardItem1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(dimension3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.boundImageDashboardItem2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(dimension4, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.comboBoxDashboardItem2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.dashboardItemGroup2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(dimension5, System.ComponentModel.ISupportInitialize).EndInit()
			CType(dimension6, System.ComponentModel.ISupportInitialize).EndInit()
			CType(measure8, System.ComponentModel.ISupportInitialize).EndInit()
			CType(measure9, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.chartDashboardItem1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

		End Sub

		#End Region

		Private comboBoxDashboardItem1 As DevExpress.DashboardCommon.ComboBoxDashboardItem
		Private dashboardSqlDataSource1 As DevExpress.DashboardCommon.DashboardSqlDataSource
		Private textBoxDashboardItem1 As DevExpress.DashboardCommon.TextBoxDashboardItem
		Private dashboardItemGroup1 As DevExpress.DashboardCommon.DashboardItemGroup
		Private boundImageDashboardItem1 As DevExpress.DashboardCommon.BoundImageDashboardItem
		Private chartDashboardItem1 As DevExpress.DashboardCommon.ChartDashboardItem
		Private dashboardItemGroup2 As DevExpress.DashboardCommon.DashboardItemGroup
		Private comboBoxDashboardItem2 As DevExpress.DashboardCommon.ComboBoxDashboardItem
		Private boundImageDashboardItem2 As DevExpress.DashboardCommon.BoundImageDashboardItem
	End Class
End Namespace
