Imports Microsoft.VisualBasic
Imports System
Imports System.Collections
Imports System.Web.UI
Imports DevExpress.Web

Partial Public Class Columns_CommandColumnCustomButtons
	Inherits Page
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)

	End Sub
	Private copiedValues As Hashtable = Nothing
	Private copiedFields() As String = { "FirstName", "Title", "Notes", "LastName", "BirthDate", "HireDate" }
	Protected Sub grid_CustomButtonCallback(ByVal sender As Object, ByVal e As ASPxGridViewCustomButtonCallbackEventArgs)
		If e.ButtonID <> "Clone" Then
			Return
		End If
		copiedValues = New Hashtable()
		For Each fieldName As String In copiedFields
			copiedValues(fieldName) = grid.GetRowValues(e.VisibleIndex, fieldName)
		Next fieldName
		grid.AddNewRow()

	End Sub
	Protected Sub grid_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.Web.Data.ASPxDataInitNewRowEventArgs)
		If copiedValues Is Nothing Then
			Return
		End If
		For Each fieldName As String In copiedFields
			e.NewValues(fieldName) = copiedValues(fieldName)
		Next fieldName
	End Sub
End Class
