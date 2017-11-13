Imports Microsoft.VisualBasic
Imports System
Imports System.Web.UI
Imports DevExpress.Web

Partial Public Class GroupingSorting_Grouping
	Inherits Page
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		If (Not IsPostBack) Then
			ApplyLayout(0)
		End If
	End Sub

	Protected Sub grid_CustomCallback(ByVal sender As Object, ByVal e As ASPxGridViewCustomCallbackEventArgs)
		ApplyLayout(Int32.Parse(e.Parameters))
	End Sub

	Private Sub ApplyLayout(ByVal layoutIndex As Integer)
		grid.BeginUpdate()
		Try
			grid.ClearSort()
			Select Case layoutIndex
				Case 0
					grid.GroupBy(grid.Columns("Country"))
				Case 1
					grid.GroupBy(grid.Columns("Country"))
					grid.GroupBy(grid.Columns("City"))
				Case 2
					grid.GroupBy(grid.Columns("CompanyName"))
			End Select
		Finally
			grid.EndUpdate()
		End Try
		grid.ExpandAll()
	End Sub
End Class
