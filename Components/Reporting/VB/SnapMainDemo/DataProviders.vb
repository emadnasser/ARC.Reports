Imports Microsoft.VisualBasic
Imports System
Imports System.Data.OleDb
Imports System.Windows.Forms
Imports DevExpress.Utils
Imports DevExpress.Demos.DataSources
Imports SnapDemos.nwindDataSetTableAdapters
Imports SnapDemos.temperatureStatisticsDataSetTableAdapters

Namespace SnapDemos.Modules
	Public Interface ISnapDataProvider
		Function GetDataSource() As Object
	End Interface
	Public MustInherit Class NorthwindDataProvider
		Implements ISnapDataProvider
		Protected Overridable ReadOnly Property DataMember() As String
			Get
				Return String.Empty
			End Get
		End Property
		Public Function GetDataSource() As Object Implements ISnapDataProvider.GetDataSource
			Dim path As String = FilesHelper.FindingFileName(AppDomain.CurrentDomain.BaseDirectory, "Data\nwind.mdb", False)
			Dim dataSource = New nwindDataSet()
			Dim connection = New OleDbConnection()
			connection.ConnectionString = String.Format("Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0}", path)

			FillDataSource(connection, dataSource)

			Dim bindingSource = New BindingSource()
			bindingSource.DataSource = dataSource
			bindingSource.DataMember = DataMember
			Return bindingSource
		End Function
		Protected MustOverride Sub FillDataSource(ByVal connection As OleDbConnection, ByVal dataSource As nwindDataSet)
	End Class
	Public Class APIDataProvider
		Inherits NorthwindDataProvider
		Protected Overrides ReadOnly Property DataMember() As String
			Get
				Return "Categories"
			End Get
		End Property
		Protected Overrides Sub FillDataSource(ByVal connection As OleDbConnection, ByVal dataSource As nwindDataSet)
			Dim categories As New CategoriesTableAdapter()
			categories.Connection = connection
			categories.Fill(dataSource.Categories)

			Dim products As New ProductsTableAdapter()
			products.Connection = connection
			products.Fill(dataSource.Products)

			Dim orderDetails As New Order_DetailsTableAdapter()
			orderDetails.Connection = connection
			orderDetails.Fill(dataSource.Order_Details)
		End Sub
	End Class
	Public Class CalculatedFieldsDataProvider
		Inherits NorthwindDataProvider
		Protected Overrides ReadOnly Property DataMember() As String
			Get
				Return "OrderReports"
			End Get
		End Property
		Protected Overrides Sub FillDataSource(ByVal connection As OleDbConnection, ByVal dataSource As nwindDataSet)
			Dim orderReportsTableAdapter = New OrderReportsTableAdapter()
			orderReportsTableAdapter.Connection = connection
			orderReportsTableAdapter.Fill(dataSource.OrderReports)
		End Sub
	End Class
	Public Class ChartsDataProvider
		Inherits NorthwindDataProvider
		Protected Overrides ReadOnly Property DataMember() As String
			Get
				Return "Suppliers"
			End Get
		End Property
		Protected Overrides Sub FillDataSource(ByVal connection As OleDbConnection, ByVal dataSource As nwindDataSet)
			Dim suppliersTableAdapter = New SuppliersTableAdapter()
			suppliersTableAdapter.Connection = connection
			suppliersTableAdapter.Fill(dataSource.Suppliers)

			Dim products = New ProductsTableAdapter()
			products.Connection = connection
			products.Fill(dataSource.Products)

			Dim orderDetails = New Order_DetailsTableAdapter()
			orderDetails.Connection = connection
			orderDetails.Fill(dataSource.Order_Details)
		End Sub
	End Class
	Public Class EventsDataProvider
		Inherits NorthwindDataProvider
		Protected Overrides ReadOnly Property DataMember() As String
			Get
				Return "Categories"
			End Get
		End Property
		Protected Overrides Sub FillDataSource(ByVal connection As OleDbConnection, ByVal dataSource As nwindDataSet)
			Dim categories As New CategoriesTableAdapter()
			categories.Connection = connection
			categories.Fill(dataSource.Categories)

			Dim products As New ProductsTableAdapter()
			products.Connection = connection
			products.Fill(dataSource.Products)

			Dim orderDetails As New Order_DetailsTableAdapter()
			orderDetails.Connection = connection
			orderDetails.Fill(dataSource.Order_Details)
		End Sub
	End Class
	Public Class MultiColumnReportDataProvider
		Inherits NorthwindDataProvider
		Protected Overrides ReadOnly Property DataMember() As String
			Get
				Return "Customers"
			End Get
		End Property
		Protected Overrides Sub FillDataSource(ByVal connection As OleDbConnection, ByVal dataSource As nwindDataSet)
			Dim customersTableAdapter = New CustomersTableAdapter()
			customersTableAdapter.Connection = connection
			customersTableAdapter.Fill(dataSource.Customers)
		End Sub
	End Class
	Public Class MailMergeReportsDataProvider
		Inherits NorthwindDataProvider
		Protected Overrides ReadOnly Property DataMember() As String
			Get
				Return "CustomerOrders"
			End Get
		End Property
		Protected Overrides Sub FillDataSource(ByVal connection As OleDbConnection, ByVal dataSource As nwindDataSet)
			Dim customerOrdersTableAdapter = New CustomerOrdersTableAdapter()
			customerOrdersTableAdapter.Connection = connection
			customerOrdersTableAdapter.Fill(dataSource.CustomerOrders)

			Dim orderReportsTableAdapter = New OrderReportsTableAdapter()
			orderReportsTableAdapter.Connection = connection
			orderReportsTableAdapter.Fill(dataSource.OrderReports)
		End Sub
	End Class
	Public Class FormattedFieldsDataProvider
		Implements ISnapDataProvider
		Public Function GetDataSource() As Object Implements ISnapDataProvider.GetDataSource
			Return DataSourceHelper.GetDataSouresFromXml(Of HtmlTag)("HtmlTags.xml", "HtmlTags")
		End Function
	End Class
	Public Class SparklineDataProvider
		Implements ISnapDataProvider
		Public Function GetDataSource() As Object Implements ISnapDataProvider.GetDataSource
			Dim path As String = FilesHelper.FindingFileName(AppDomain.CurrentDomain.BaseDirectory, "Data\temperatureStatistics.mdb", False)
			Dim dataSource = New temperatureStatisticsDataSet()
			Dim connection = New OleDbConnection()
			connection.ConnectionString = String.Format("Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0}", path)

			Dim cityTableAdapter = New CityTableAdapter()
			cityTableAdapter.Connection = connection
			cityTableAdapter.Fill(dataSource.City)

			Dim yearInfoTableAdapter = New YearInfoTableAdapter()
			yearInfoTableAdapter.Connection = connection
			yearInfoTableAdapter.Fill(dataSource.YearInfo)

			Dim temperatureTableAdapter = New TemperatureTableAdapter()
			temperatureTableAdapter.Connection = connection
			temperatureTableAdapter.Fill(dataSource.Temperature)

			Dim monthInfoTableAdapter = New MonthInfoTableAdapter()
			monthInfoTableAdapter.Connection = connection
			monthInfoTableAdapter.Fill(dataSource.MonthInfo)

			Dim bindingSource = New BindingSource()
			bindingSource.DataSource = dataSource
			bindingSource.DataMember = "City"
			Return bindingSource
		End Function
	End Class
	Public Class IListDatasourceProvider
		Implements ISnapDataProvider
		Public Function GetDataSource() As Object Implements ISnapDataProvider.GetDataSource
			Return FishesSource.Data
		End Function
	End Class
End Namespace
