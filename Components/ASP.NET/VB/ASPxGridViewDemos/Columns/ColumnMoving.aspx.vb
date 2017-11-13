Imports Microsoft.VisualBasic
Imports System
Imports System.Threading
Imports DevExpress.Web

Partial Public Class Columns_ColumnMoving
	Inherits System.Web.UI.Page
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		Grid.SettingsBehavior.ColumnMoveMode = CType(cpColumnMoveMode.Value, GridColumnMoveMode)
		Grid.SettingsBehavior.ProcessColumnMoveOnClient = cbProcessColumnMoveOnClient.Checked
		If IsCallback AndAlso (Not cbProcessColumnMoveOnClient.Checked) Then
			Thread.Sleep(1500) ' Extend the callback delay for demonstration purposes.
		End If
	End Sub
End Class
