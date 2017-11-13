Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Linq
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports DevExpress.Web

Partial Public Class ASPxComboBox_ItemAppearanceCustomization
	Inherits System.Web.UI.Page
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)

	End Sub
	Private Function GetItemTooltip(ByVal item As ListEditItem) As String
		Return String.Format("Country: {0}" & Constants.vbCrLf & "City: {1} " & Constants.vbCrLf & "Address: {2}", item.GetFieldValue("Country"), item.GetFieldValue("City"), item.GetFieldValue("Address"))
	End Function
	Protected Sub customersComboBox_ItemTextCellPrepared(ByVal sender As Object, ByVal e As ListBoxItemTextCellPreparedEventArgs)
		If e.Column.FieldName = "ContactName" Then
			Dim contactTitle As String = e.Item.GetFieldValue("ContactTitle").ToString()
			If contactTitle = "Owner" Then
				e.TextCell.CssClass &= " owner"
				e.TextCell.ToolTip = "Owner"
			End If
		End If
		If e.Column.FieldName = "Phone" Then
			e.TextCell.CssClass &= " phone"
		End If

	End Sub
	Protected Sub customersComboBox_ItemRowPrepared(ByVal sender As Object, ByVal e As ListBoxItemRowPreparedEventArgs)
		e.Row.ToolTip = GetItemTooltip(e.Item)
	End Sub
End Class
