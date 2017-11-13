Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Data

Namespace DashboardMainDemo
	Public NotInheritable Class EnergyConsumptionDataHelper
		Private Sub New()
		End Sub
		Public Shared Function GenerateTotal(ByVal dataSet As DataSet) As IList(Of EnergyConsumptionTotalDataRow)
			Dim res As IList(Of EnergyConsumptionTotalDataRow) = New List(Of EnergyConsumptionTotalDataRow)()
			Dim data As DataRowCollection = dataSet.Tables("CountriesTotal").Rows
			For Each row As DataRow In data
				res.Add(New EnergyConsumptionTotalDataRow With {.Country = CStr(row("Country")), .Year = CDate(row("Year")), .Consumption = CDbl(row("Consumption")), .Latitude = CDbl(row("Latitude")), .Longitude = CDbl(row("Longitude")), .Production = CDbl(row("Production"))})
			Next row
			Return res
		End Function
		Public Shared Function GenerateBySector(ByVal dataSet As DataSet) As IList(Of EnergyConsumptionBySectorDataRow)
			Dim res As IList(Of EnergyConsumptionBySectorDataRow) = New List(Of EnergyConsumptionBySectorDataRow)()
			Dim data As DataRowCollection = dataSet.Tables("CountriesBySector").Rows
			For Each row As DataRow In data
				res.Add(New EnergyConsumptionBySectorDataRow With {.Country = CStr(row("Country")), .Sector = CStr(row("Sector")), .Year = CDate(row("Year")), .Consumption = If(row("Consumption") IsNot DBNull.Value, CDbl(row("Consumption")), 0), .Latitude = CDbl(row("Latitude")), .Longitude = CDbl(row("Longitude"))})
			Next row
			Return res
		End Function
	End Class

	Public Class EnergyConsumptionTotalDataRow
		Public Property Country() As String
		Public Property Year() As DateTime
		Public Property Consumption() As Double
		Public Property Latitude() As Double
		Public Property Longitude() As Double
		Public Property Production() As Double
	End Class

	Public Class EnergyConsumptionBySectorDataRow
		Public Property Country() As String
		Public Property Sector() As String
		Public Property Year() As DateTime
		Public Property Consumption() As Double
		Public Property Latitude() As Double
		Public Property Longitude() As Double
	End Class
End Namespace
