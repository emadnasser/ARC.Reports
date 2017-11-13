Imports Microsoft.VisualBasic
Imports System
Imports System.Web.UI
Imports DevExpress.Web

Partial Public Class CloudControl_Appearance
	Inherits Page
	Private ReadOnly Property UserControlName() As String
		Get
			Dim name As String = Request.QueryString("Name")
			Return If(name Is Nothing, String.Empty, name)
		End Get
	End Property

	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		DataBind()
		Dim itemName As String = "Appearances/" & UserControlName & ".ascx"
		Dim selectedItem As MenuItem = mSelector.Items.FindByName(itemName)
		If selectedItem Is Nothing Then
			selectedItem = mSelector.Items(0)
		End If
		phAppearances.Controls.Add(LoadControl(selectedItem.Name))
	End Sub
End Class
