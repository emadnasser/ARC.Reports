Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Web.UI
Imports DevExpress.Web.ASPxTreeList

Partial Public Class Appearance_ConditionalFormatting
	Inherits Page

	Protected Sub treeList_HtmlRowPrepared(ByVal sender As Object, ByVal e As TreeListHtmlRowEventArgs)
		If Object.Equals(e.GetValue("Location"), "Monterey") Then
			e.Row.BackColor = Color.FromArgb(211, 235, 183)
		End If
	End Sub

	Protected Sub treeList_HtmlDataCellPrepared(ByVal sender As Object, ByVal e As TreeListHtmlDataCellEventArgs)
		If e.Column.Name = "budget" Then
			Dim value As Decimal = CDec(e.CellValue)
			e.Cell.BackColor = GetBudgetColor(value)
			If value > 1000000D Then
				e.Cell.Font.Bold = True
			End If
		End If
	End Sub

	Private Function GetBudgetColor(ByVal value As Decimal) As Color
		Dim coeff As Decimal = value / 1000 - 22
		Dim a As Integer = CInt(Fix(0.02165D * coeff))
		Dim b As Integer = CInt(Fix(0.09066D * coeff))
		Return Color.FromArgb(255, 235 - a, 177 - b)
	End Function
End Class
