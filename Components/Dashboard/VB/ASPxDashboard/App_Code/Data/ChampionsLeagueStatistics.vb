Imports Microsoft.VisualBasic
Imports System.Collections.Generic
Imports System.Data

Namespace DashboardMainDemo
	Public NotInheritable Class ChampionsLeagueStatisticsDataHelper
		Private Sub New()
		End Sub
		Public Shared Function Generate(ByVal dataSet As DataSet) As IList(Of ChampionsLeagueStatisticsDataRow)
			Dim res As IList(Of ChampionsLeagueStatisticsDataRow) = New List(Of ChampionsLeagueStatisticsDataRow)()
			Dim data As DataRowCollection = dataSet.Tables("Data").Rows
			For Each row As DataRow In data
				res.Add(New ChampionsLeagueStatisticsDataRow With {.Country = CStr(row("Country")), .Club = CStr(row("Club")), .Season = CStr(row("Season")), .Won = CInt(Fix(row("Won"))), .Drawn = CInt(Fix(row("Drawn"))), .Lost = CInt(Fix(row("Lost"))), .Goals_for = CInt(Fix(row("Goals_for"))), .Goals_against = CInt(Fix(row("Goals_against")))})
			Next row
			Return res
		End Function
	End Class

	Public Class ChampionsLeagueStatisticsDataRow
		Public Property Country() As String
		Public Property Club() As String
		Public Property Season() As String
		Public Property Won() As Integer
		Public Property Drawn() As Integer
		Public Property Lost() As Integer
		Public Property Goals_for() As Integer
		Public Property Goals_against() As Integer
	End Class
End Namespace
