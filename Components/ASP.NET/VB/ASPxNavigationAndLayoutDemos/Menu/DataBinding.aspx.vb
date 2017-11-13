Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.Web
Imports System.Web
Imports System.Web.UI
Imports DevExpress.Web.Demos

Partial Public Class Menu_DataBinding
	Inherits Page
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		Utils.RegisterCssLink(Me, "~/Menu/CSS/WorldCupImages.css")
	End Sub

	Protected Sub ASPxMenu1_ItemDataBound(ByVal sender As Object, ByVal e As MenuItemEventArgs)
		Dim node As SiteMapNode = TryCast(e.Item.DataItem, SiteMapNode)
		If node IsNot Nothing Then
			If (Not String.IsNullOrEmpty(node("SpriteImage"))) Then
				e.Item.Image.SpriteProperties.CssClass = node("SpriteImage")
			End If
			If (Not String.IsNullOrEmpty(node("result"))) Then
				e.Item.Text = "<b>" & node("result") & "</b> " & e.Item.Text
			End If
		End If
	End Sub
End Class
