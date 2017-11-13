Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Web.UI
Imports DevExpress.Web

Partial Public Class GridEditing_Validation
	Inherits Page
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)

	End Sub
	Protected Sub grid_RowValidating(ByVal sender As Object, ByVal e As DevExpress.Web.Data.ASPxDataValidationEventArgs)
		For Each column As GridViewColumn In grid.Columns
			Dim dataColumn As GridViewDataColumn = TryCast(column, GridViewDataColumn)
			If dataColumn Is Nothing Then
				Continue For
			End If
			If e.NewValues(dataColumn.FieldName) Is Nothing Then
				e.Errors(dataColumn) = "Value can't be null."
			End If
		Next column
		If e.Errors.Count > 0 Then
			e.RowError = "Please, fill all fields."
		End If
		If e.NewValues("FirstName") IsNot Nothing AndAlso e.NewValues("FirstName").ToString().Length < 2 Then
			AddError(e.Errors, grid.Columns("FirstName"), "First Name must be at least two characters long.")
		End If
		If e.NewValues("LastName") IsNot Nothing AndAlso e.NewValues("LastName").ToString().Length < 2 Then
			AddError(e.Errors, grid.Columns("LastName"), "Last Name must be at least two characters long.")
		End If
		If e.NewValues("Email") IsNot Nothing AndAlso (Not e.NewValues("Email").ToString().Contains("@")) Then
			AddError(e.Errors, grid.Columns("Email"), "Invalid e-mail.")
		End If

		Dim age As Integer = If(e.NewValues("Age") IsNot Nothing, CInt(Fix(e.NewValues("Age"))), 0)
		If age < 18 Then
			AddError(e.Errors, grid.Columns("Age"), "Age must be greater than or equal 18.")
		End If
		Dim arrival As DateTime = DateTime.MinValue
		DateTime.TryParse(If(e.NewValues("ArrivalDate") Is Nothing, String.Empty, e.NewValues("ArrivalDate").ToString()), arrival)
		If DateTime.Today.Year <> arrival.Year OrElse DateTime.Today.Month <> arrival.Month Then
			AddError(e.Errors, grid.Columns("ArrivalDate"), "Arrival date is required and must belong to the current month.")
		End If

		If String.IsNullOrEmpty(e.RowError) AndAlso e.Errors.Count > 0 Then
			e.RowError = "Please, correct all errors."
		End If
	End Sub
	Private Sub AddError(ByVal errors As Dictionary(Of GridViewColumn, String), ByVal column As GridViewColumn, ByVal errorText As String)
		If errors.ContainsKey(column) Then
			Return
		End If
		errors(column) = errorText
	End Sub
	Protected Sub grid_HtmlRowPrepared(ByVal sender As Object, ByVal e As ASPxGridViewTableRowEventArgs)
		If (Not Object.Equals(e.RowType, GridViewRowType.Data)) Then
			Return
		End If

		Dim hasError As Boolean = String.IsNullOrEmpty(e.GetValue("FirstName").ToString())
		hasError = hasError OrElse String.IsNullOrEmpty(e.GetValue("LastName").ToString())
		hasError = hasError OrElse Not e.GetValue("Email").ToString().Contains("@")
		hasError = hasError OrElse CInt(Fix(e.GetValue("Age"))) < 18
		Dim arrival As DateTime = CDate(e.GetValue("ArrivalDate"))
		hasError = hasError OrElse DateTime.Today.Year <> arrival.Year OrElse DateTime.Today.Month <> arrival.Month
		If hasError Then
			e.Row.ForeColor = System.Drawing.Color.Red
		End If
	End Sub
	Protected Sub grid_StartRowEditing(ByVal sender As Object, ByVal e As DevExpress.Web.Data.ASPxStartRowEditingEventArgs)
		If (Not grid.IsNewRowEditing) Then
			grid.DoRowValidation()
		End If
	End Sub
End Class
