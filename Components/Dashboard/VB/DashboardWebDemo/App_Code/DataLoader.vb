Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Web

Namespace DashboardMainDemo
	Public NotInheritable Class DataLoader
		Private Shared customerSupportData_Renamed As Object
		Private Shared humanResourcesData_Renamed As HumanResourcesData
		Private Shared revenueAnalysisData_Renamed As Object
		Private Shared salesDetailsData_Renamed As Object
		Private Shared salesOverviewData_Renamed As Object
		Private Shared salesPerformanceData_Renamed As SalesPerformanceDataGenerator
		Private Shared websiteStatisticsData As WebsiteStatisticsDataGenerator
		Private Shared revenueByIndustry_Renamed As DataSet
		Private Shared energyConsumptionTotal_Renamed As DataSet
		Private Shared energyConsumptionBySector_Renamed As DataSet
		Private Shared energyStatistics_Renamed As DataSet
		Private Shared championsLeagueStatistics_Renamed As DataSet

		Private Sub New()
		End Sub
		Private Shared ReadOnly Property Server() As HttpServerUtility
			Get
				Return HttpContext.Current.Server
			End Get
		End Property

		Public Shared ReadOnly Property CustomerSupportData() As Object
			Get
				If customerSupportData_Renamed Is Nothing Then
					Dim customerSupport As DataSet = DataLoader.LoadCustomerSupport(Server)
					Dim employees As DataSet = DataLoader.LoadEmployees(Server)
					customerSupportData_Renamed = New CustomerSupportData(customerSupport, employees).CustomerSupport
				End If
				Return customerSupportData_Renamed
			End Get
		End Property
		Public Shared ReadOnly Property HumanResourcesData() As HumanResourcesData
			Get
				If humanResourcesData_Renamed Is Nothing Then
					Dim employees As DataSet = DataLoader.LoadEmployees(Server)
					humanResourcesData_Renamed = New HumanResourcesData(employees)
				End If
				Return humanResourcesData_Renamed
			End Get
		End Property
		Public Shared ReadOnly Property RevenueAnalysisData() As Object
			Get
				If revenueAnalysisData_Renamed Is Nothing Then
					Dim dataGenerator As New RevenueAnalysisDataGenerator(DataLoader.LoadSales(Server))
					dataGenerator.Generate()
					revenueAnalysisData_Renamed = dataGenerator.Data
				End If
				Return revenueAnalysisData_Renamed
			End Get
		End Property
		Public Shared ReadOnly Property SalesDetailsData() As Object
			Get
				If salesDetailsData_Renamed Is Nothing Then
					Dim sales As DataSet = DataLoader.LoadSales(Server)
					Dim generator As New SalesDetailsDataGenerator(sales)
					generator.Generate()
					salesDetailsData_Renamed = generator.Data
				End If
				Return salesDetailsData_Renamed
			End Get
		End Property
		Public Shared ReadOnly Property SalesOverviewData() As Object
			Get
				If salesOverviewData_Renamed Is Nothing Then
					Dim sales As DataSet = DataLoader.LoadSales(Server)
					Dim generator As New SalesOverviewDataGenerator(sales)
					generator.Generate()
					salesOverviewData_Renamed = generator.Data
				End If
				Return salesOverviewData_Renamed
			End Get
		End Property
		Public Shared ReadOnly Property SalesPerformanceData() As SalesPerformanceDataGenerator
			Get
				If salesPerformanceData_Renamed Is Nothing Then
					salesPerformanceData_Renamed = New SalesPerformanceDataGenerator(DataLoader.LoadSales(Server))
					salesPerformanceData_Renamed.Generate()
				End If
				Return salesPerformanceData_Renamed
			End Get
		End Property
		Public Shared ReadOnly Property RevenueByIndustry() As DataSet
			Get
				If revenueByIndustry_Renamed Is Nothing Then
					revenueByIndustry_Renamed = LoadRevenueByIndustry(Server)
				End If
				Return revenueByIndustry_Renamed
			End Get
		End Property
		Public Shared ReadOnly Property EnergyConsumptionTotal() As DataSet
			Get
				If energyConsumptionTotal_Renamed Is Nothing Then
					energyConsumptionTotal_Renamed = LoadData(Server, "DashboardEnergyConsumptionTotal")
				End If
				Return energyConsumptionTotal_Renamed
			End Get
		End Property
		Public Shared ReadOnly Property EnergyConsumptionBySector() As DataSet
			Get
				If energyConsumptionBySector_Renamed Is Nothing Then
					energyConsumptionBySector_Renamed = LoadData(Server, "DashboardEnergyConsumptionBySector")
				End If
				Return energyConsumptionBySector_Renamed
			End Get
		End Property
		Public Shared ReadOnly Property EnergyStatistics() As DataSet
			Get
				If energyStatistics_Renamed Is Nothing Then
					energyStatistics_Renamed = LoadData(Server, "DashboardEnergyStatictics")
				End If
				Return energyStatistics_Renamed
			End Get
		End Property
		Public Shared ReadOnly Property ChampionsLeagueStatistics() As DataSet
			Get
				If championsLeagueStatistics_Renamed Is Nothing Then
					championsLeagueStatistics_Renamed = LoadData(Server, "DashboardChampionsLeagueStatistics")
				End If
				Return championsLeagueStatistics_Renamed
			End Get
		End Property
		Public Shared ReadOnly Property WebsiteStatistics() As Object
			Get
				If websiteStatisticsData Is Nothing Then
					websiteStatisticsData = New WebsiteStatisticsDataGenerator()
				End If
				Return websiteStatisticsData.WebsiteStatistics
			End Get
		End Property
		Private Shared Function BuildDataFileNameBase(ByVal server As HttpServerUtility, ByVal dataSetName As String, ByVal extension As String) As String
			Return server.MapPath(String.Format("~/App_Data/{0}", dataSetName & extension))
		End Function
		Private Shared Function BuildDataFileName(ByVal server As HttpServerUtility, ByVal dataSetName As String) As String
			Return BuildDataFileNameBase(server, dataSetName, ".xml")
		End Function
		Private Shared Function BuildExtractDataFile(ByVal server As HttpServerUtility, ByVal dataSetName As String) As String
			Return BuildDataFileNameBase(server, dataSetName, ".dat")
		End Function
		Private Shared Function LoadData(ByVal server As HttpServerUtility, ByVal dataSetName As String) As DataSet
			Dim path As String = BuildDataFileName(server, dataSetName)
			Dim dataSet As New DataSet()
			dataSet.ReadXml(path, XmlReadMode.ReadSchema)
			Return dataSet
		End Function
		Public Shared Function LoadSales(ByVal server As HttpServerUtility) As DataSet
			Return LoadData(server, "DashboardSales")
		End Function
		Public Shared Function LoadCustomerSupport(ByVal server As HttpServerUtility) As DataSet
			Return LoadData(server, "DashboardCustomerSupport")
		End Function
		Public Shared Function LoadEmployees(ByVal server As HttpServerUtility) As DataSet
			Return LoadData(server, "DashboardEmployeesAndDepartments")
		End Function
		Public Shared Function LoadRevenueByIndustry(ByVal server As HttpServerUtility) As DataSet
			Return LoadData(server, "DashboardRevenueByIndustry")
		End Function
		Public Shared Function GetProductDetailsXmlData() As String
			Return BuildDataFileName(Server, "DashboardProductDetails")
		End Function
		Public Shared Function GetEUTradeOverviewDataPath() As String
			Return BuildExtractDataFile(Server, "EUTradeOverview")
		End Function
		Public Shared Function GetProductDetailsImagePattern() As String
			Dim applicationPath As String = HttpContext.Current.Request.ApplicationPath.TrimEnd("/"c) & "/"
			Return applicationPath & "Content/ProductDetailsImages/{0} Secondary.jpg"
		End Function
	End Class
End Namespace
