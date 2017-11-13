Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Web.UI
Imports DevExpress.Data.PivotGrid
Imports DevExpress.Web.ASPxPivotGrid

Partial Public Class MultipleTotalsDemo
	Inherits Page

	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		If (Not IsPostBack) AndAlso (Not IsCallback) Then
			SetYearFilter()
			pivotGrid.Fields("CategoryName").ExpandValue("Beverages")
		End If
		SetCustomTotals(pivotGrid.Fields("CategoryName").CustomTotals)
	End Sub
	Private Sub SetYearFilter()
		pivotGrid.Fields("Year").FilterValues.FilterType = DevExpress.XtraPivotGrid.PivotFilterType.Included
		pivotGrid.Fields("Year").FilterValues.Add(1996)
	End Sub
	Private Sub SetCustomTotals(ByVal totals As DevExpress.Web.ASPxPivotGrid.PivotGridCustomTotalCollection)
		Dim newTotals As List(Of PivotSummaryType) = GetCustomTotals()
		If CustomTotalsEqual(totals, newTotals) Then
			Return
		End If
		totals.Clear()
		For i As Integer = 0 To newTotals.Count - 1
			totals.Add(newTotals(i))
		Next i
	End Sub
	Private Function CustomTotalsEqual(ByVal totals As PivotGridCustomTotalCollection, ByVal newTotals As List(Of PivotSummaryType)) As Boolean
		If totals.Count <> newTotals.Count Then
			Return False
		End If
		For i As Integer = 0 To newTotals.Count - 1
			If (Not totals.Contains(newTotals(i))) Then
				Return False
			End If
		Next i
		Return True
	End Function
	Private Function GetCustomTotals() As List(Of PivotSummaryType)
		Dim res As New List(Of PivotSummaryType)()
		If average.Checked Then
			res.Add(PivotSummaryType.Average)
		End If
		If count.Checked Then
			res.Add(PivotSummaryType.Count)
		End If
		If max.Checked Then
			res.Add(PivotSummaryType.Max)
		End If
		If min.Checked Then
			res.Add(PivotSummaryType.Min)
		End If
		If stdev.Checked Then
			res.Add(PivotSummaryType.StdDev)
		End If
		If stdevp.Checked Then
			res.Add(PivotSummaryType.StdDevp)
		End If
		If sum.Checked Then
			res.Add(PivotSummaryType.Sum)
		End If
		If var.Checked Then
			res.Add(PivotSummaryType.Var)
		End If
		If varp.Checked Then
			res.Add(PivotSummaryType.Varp)
		End If
		Return res
	End Function
End Class
