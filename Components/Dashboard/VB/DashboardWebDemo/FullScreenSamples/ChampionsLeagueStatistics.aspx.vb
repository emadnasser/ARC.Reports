Imports Microsoft.VisualBasic
Imports System.Linq
Imports System.Web.UI
Imports DevExpress.DashboardCommon
Imports DevExpress.DashboardWeb

Partial Public Class ChampionsLeagueStatistics
	Inherits Page
	Protected Sub OnMasterFilterDefaultValues(ByVal sender As Object, ByVal e As MasterFilterDefaultValuesWebEventArgs)
		If e.ItemComponentName = "scatterChartLeagueStatistics" Then
			Dim selRow As DashboardDataRow = e.AvailableFilterValues.FirstOrDefault(Function(row) Object.Equals(row(0), "Spain"))
			If selRow IsNot Nothing Then
				e.FilterValues = { selRow }
			End If
		End If
	End Sub
End Class
