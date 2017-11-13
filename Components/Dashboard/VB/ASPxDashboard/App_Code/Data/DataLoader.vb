Imports Microsoft.VisualBasic
Imports System.Collections.Generic
Imports System.Data
Imports System
Imports DevExpress.Utils
Imports System.IO
Imports System.Web.Hosting
Imports System.Configuration
Imports DevExpress.DashboardWeb

Namespace DashboardMainDemo
	Public NotInheritable Class DataLoader
		Private Sub New()
		End Sub
		Private Shared Function GetRelativePath(ByVal name As String) As String
			Return Path.Combine(HostingEnvironment.MapPath("~"), "App_Data", "Data", name)
		End Function
		Private Shared Function LoadData(ByVal fileName As String) As DataSet
			Dim path As String = GetRelativePath(String.Format("{0}.xml", fileName))
			Dim ds As New DataSet()
			ds.ReadXml(path, XmlReadMode.ReadSchema)
			Return ds
		End Function
		Public Shared Function LoadSales() As DataSet
			Return LoadData("DashboardSales")
		End Function
		Public Shared Function LoadEmployees() As DataSet
			Return LoadData("DashboardEmployeesAndDepartments")
		End Function
		Public Shared Function LoadCustomerSupport() As DataSet
			Return LoadData("DashboardCustomerSupport")
		End Function
		Public Shared Function LoadRevenueByIndustry() As DataSet
			Return LoadData("DashboardRevenueByIndustry")
		End Function
		Public Shared Function LoadEuroEnergyStatistics() As DataSet
			Return LoadData("DashboardEnergyStatictics")
		End Function
		Public Shared Function LoadEnergyConsumptionTotal() As DataSet
			Return LoadData("DashboardEnergyConsumptionTotal")
		End Function
		Public Shared Function LoadEnergyConsumptionBySector() As DataSet
			Return LoadData("DashboardEnergyConsumptionBySector")
		End Function
		Public Shared Function LoadChampionsLeagueStatistics() As DataSet
			Return LoadData("DashboardChampionsLeagueStatistics")
		End Function
		Public Shared Function GetProductDetailsXmlDataSource() As String
			Return GetRelativePath(String.Format("{0}.xml", "DashboardProductDetails"))
		End Function
		Public Shared Function GetImagesFolder() As String
			Return GetRelativePath("ProductDetailsImages")
		End Function

		Public Shared Sub LoadData(ByVal e As DataLoadingWebEventArgs)
			Select Case e.DashboardId
				Case "WebsiteStatistics"
					Dim data As New WebsiteStatisticsDataGenerator()
					e.Data = data.WebsiteStatistics
				Case "SalesPerformance"
					Dim dataGenerator As New SalesPerformanceDataGenerator(LoadSales())
					dataGenerator.Generate()
					If e.DataSourceComponentName = "dsMonthlySales" Then
						e.Data = dataGenerator.MonthlySales
					ElseIf e.DataSourceComponentName = "dsTotalSales" Then
						e.Data = dataGenerator.TotalSales
					ElseIf e.DataSourceComponentName = "dsKeyMetrics" Then
						e.Data = dataGenerator.KeyMetrics
					End If
				Case "HumanResources"
					Dim humanResourcesData As New HumanResourcesData(LoadEmployees())
					If e.DataSourceComponentName = "dsEmployees" Then
						e.Data = humanResourcesData.EmployeeData
					ElseIf e.DataSourceComponentName = "dsDepartments" Then
						e.Data = humanResourcesData.DepartmentData
					End If
				Case "EnergyStatistics"
					e.Data = EnergyStaticticsDataHelper.Generate(LoadEuroEnergyStatistics())
				Case "SalesOverview"
					Dim salesOverviewDataGenerator As New SalesOverviewDataGenerator(LoadSales())
					salesOverviewDataGenerator.Generate()
					e.Data = salesOverviewDataGenerator.Data
				Case "SalesDetails"
					Dim salesDetailsDataGenerator As New SalesDetailsDataGenerator(LoadSales())
					salesDetailsDataGenerator.Generate()
					e.Data = salesDetailsDataGenerator.Data
				Case "RevenueByIndustry"
					e.Data = RevenueByIndustryDataHelper.Generate(LoadRevenueByIndustry())
				Case "ChampionsLeagueStatistics"
					e.Data = ChampionsLeagueStatisticsDataHelper.Generate(LoadChampionsLeagueStatistics())
				Case "RevenueAnalysis"
					Dim revenueAnalysisDataGenerator As New RevenueAnalysisDataGenerator(LoadSales())
					revenueAnalysisDataGenerator.Generate()
					e.Data = revenueAnalysisDataGenerator.Data
				Case "CustomerSupport"
					Dim customerSupportData As New CustomerSupportData(LoadCustomerSupport(), LoadEmployees())
					e.Data = customerSupportData.CustomerSupport
				Case "EnergyConsumption"
					If e.DataSourceComponentName = "dsConsumptionTotal" Then
						e.Data = EnergyConsumptionDataHelper.GenerateTotal(LoadEnergyConsumptionTotal())
					ElseIf e.DataSourceComponentName = "dsConsumptionBySector" Then
						e.Data = EnergyConsumptionDataHelper.GenerateBySector(LoadEnergyConsumptionBySector())
					End If
			End Select
		End Sub
	End Class
End Namespace
