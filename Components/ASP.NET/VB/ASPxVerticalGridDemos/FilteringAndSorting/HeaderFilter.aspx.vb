Imports Microsoft.VisualBasic
Imports System
Imports System.Web.UI
Imports System.Linq
Imports DevExpress.Web

Partial Public Class Filtering_HeaderFilter
	Inherits Page
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		Dim headerFilterMode As GridHeaderFilterMode = If(hFModeCheckBox.Checked, GridHeaderFilterMode.CheckedList, GridHeaderFilterMode.List)
		For Each row As VerticalGridDataRow In VerticalGrid.DataRows
			row.SettingsHeaderFilter.Mode = headerFilterMode
		Next row
	End Sub
	Protected Sub VerticalGrid_HeaderFilterFillItems(ByVal sender As Object, ByVal e As ASPxVerticalGridHeaderFilterEventArgs)
		If e.Row.FieldName = "Price" Then
			PreparePriceFilterItems(e)
		End If
		If e.Row.FieldName = "HouseSize" Then
			PrepareHouseSizeFilterItems(e)
		End If
	End Sub
	Protected Sub PreparePriceFilterItems(ByVal e As ASPxVerticalGridHeaderFilterEventArgs)
		e.Values.Clear()
		If e.Row.SettingsHeaderFilter.Mode = GridHeaderFilterMode.List Then
			e.AddShowAll()
		End If
		Dim [step] As Integer = 500000
		For i As Integer = 0 To 3
			Dim start As Double = [step] * i
			Dim [end] As Double = start + [step] - 1
			e.AddValue(String.Format("from {0:c0} to {1:c0}", start, [end]), "", String.Format("[Price] >= {0} and [Price] <= {1}", start, [end]))
		Next i
		e.AddValue(String.Format("> {0:c}", 2000000), "", "[Price] > 2000000")
	End Sub
	Protected Sub PrepareHouseSizeFilterItems(ByVal e As ASPxVerticalGridHeaderFilterEventArgs)
		e.Values.Clear()
		If e.Row.SettingsHeaderFilter.Mode = GridHeaderFilterMode.List Then
			e.AddShowAll()
		End If
		Dim [step] As Integer = 5000
		For i As Integer = 0 To 1
			Dim start As Double = [step] * i
			Dim [end] As Double = start + [step] - 1
			e.AddValue(String.Format("from {0} to {1}", start, [end]), "", String.Format("[HouseSize] >= {0} and [HouseSize] <= {1}", start, [end]))
		Next i
		e.AddValue("> 10000", "", "[HouseSize] > 10000")
	End Sub
End Class
