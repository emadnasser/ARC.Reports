Imports Microsoft.VisualBasic
Imports System.Collections.Generic
Imports System.Data
Imports System
Imports DevExpress.Utils

Namespace DashboardMainDemo
	Public NotInheritable Class DataLoader
		Private Sub New()
		End Sub
		Private Shared Function GetRelativePath(ByVal name As String) As String
			name = "Data\" & name
			Dim path As String = System.Windows.Forms.Application.StartupPath
			Dim s As String = "\"
			For i As Integer = 0 To 10
				If System.IO.File.Exists(path & s & name) Then
					Return (path & s & name)
				Else
					s &= "..\"
				End If
			Next i
			path = Environment.CurrentDirectory
			s = "\"
			For i As Integer = 0 To 10
				If System.IO.File.Exists(path & s & name) Then
					Return (path & s & name)
				Else
					s &= "..\"
				End If
			Next i
			Return ""
		End Function
		Private Shared Function GetDirectoryRelativePath(ByVal directoryName As String) As String
			directoryName = "Data\" & directoryName
			Dim path As String = System.Windows.Forms.Application.StartupPath
			Dim s As String = "\"
			For i As Integer = 0 To 10
				If System.IO.Directory.Exists(path & s & directoryName) Then
					Return (path & s & directoryName)
				Else
					s &= "..\"
				End If
			Next i
			path = Environment.CurrentDirectory
			s = "\"
			For i As Integer = 0 To 10
				If System.IO.Directory.Exists(path & s & directoryName) Then
					Return (path & s & directoryName)
				Else
					s &= "..\"
				End If
			Next i
			Return ""
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
			Return GetDirectoryRelativePath("ProductDetailsImages")
		End Function
		Public Shared Function GetEUTradeOverviewDataExtractPath() As String
			Return GetRelativePath(String.Format("{0}.dat", "EUTradeOverview"))
		End Function
	End Class
End Namespace
