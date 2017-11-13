Imports Microsoft.VisualBasic
Imports System
Imports System.Web.UI
Imports DevExpress.Web

Partial Public Class Filtering_HeaderFilter
	Inherits Page
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		Dim headerFilterMode As GridHeaderFilterMode = If(hFModeCheckBox.Checked, GridHeaderFilterMode.CheckedList, GridHeaderFilterMode.List)
		For Each column As CardViewColumn In CardView.Columns
			column.SettingsHeaderFilter.Mode = headerFilterMode
		Next column
	End Sub
	Protected Sub CardView_HeaderFilterFillItems(ByVal sender As Object, ByVal e As ASPxCardViewHeaderFilterEventArgs)
		If e.Column.FieldName = "Total" Then
			PrepareTotalFilterItems(e)
		End If
		If e.Column.FieldName = "Quantity" Then
			PrepareQuantityFilterItems(e)
		End If
	End Sub
	Protected Overridable Sub PrepareTotalFilterItems(ByVal e As ASPxCardViewHeaderFilterEventArgs)
		e.Values.Clear()
		If e.Column.SettingsHeaderFilter.Mode = GridHeaderFilterMode.List Then
			e.AddShowAll()
		End If
		Dim [step] As Integer = 100
		For i As Integer = 0 To 9
			Dim start As Double = [step] * i
			Dim [end] As Double = start + [step] - 0.01
			e.AddValue(String.Format("from {0:c} to {1:c}", start, [end]), "", String.Format("[Total] >= {0} and [Total] <= {1}", start, [end]))
		Next i
		e.AddValue(String.Format("> {0:c}", 1000), "", "[Total] > 1000")
	End Sub
	Protected Overridable Sub PrepareQuantityFilterItems(ByVal e As ASPxCardViewHeaderFilterEventArgs)
		Dim max As Integer = 0
		For i As Integer = 0 To e.Values.Count - 1
			Dim value As Integer
			If (Not Integer.TryParse(e.Values(i).Value, value)) Then
				Continue For
			End If
			If value > max Then
				max = value
			End If
		Next i
		e.Values.Clear()
		If e.Column.SettingsHeaderFilter.Mode = GridHeaderFilterMode.List Then
		e.AddShowAll()
		End If
		Dim [step] As Integer = 10
		For i As Integer = 0 To max / [step]
			Dim start As Integer = [step] * i
			Dim [end] As Integer = start + [step] - 1
			e.AddValue(String.Format("from {0} to {1}", start, [end]), "", String.Format("[Quantity] >= {0} and [Quantity] <= {1}", start, [end]))
		Next i
	End Sub
End Class
