Imports Microsoft.VisualBasic
Imports System
Imports System.Web.UI
Imports DevExpress.Web

Partial Public Class Features_EnableOnClient
	Inherits Page
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		If (Not IsCallback) Then
			cbProduct.SelectedIndex = 0
			cbProduct.ClientEnabled = False
			cbVersion.SelectedIndex = 0
			cbVersion.ClientEnabled = False
		End If
	End Sub
	Protected Sub SetNullItem(ByVal control As Object)
		Dim cb As ASPxComboBox = CType(control, ASPxComboBox)
		If cb IsNot Nothing Then
			Dim item As New ListEditItem("(none)", "")
			cb.Items.Insert(0, item)
			cb.SelectedItem = item
		End If
	End Sub
	Protected Sub cbTechnology_DataBound(ByVal sender As Object, ByVal e As EventArgs)
		SetNullItem(sender)
	End Sub
	Protected Sub cbProduct_DataBound(ByVal sender As Object, ByVal e As EventArgs)
		SetNullItem(sender)
	End Sub
	Protected Sub cbProduct_Callback(ByVal source As Object, ByVal e As CallbackEventArgsBase)
		xmlProduct.XPath = String.Format("//Technology[@Name='{0}']/Product", e.Parameter)
		DataBind()
	End Sub
End Class
