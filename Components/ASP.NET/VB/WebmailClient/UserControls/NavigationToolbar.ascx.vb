Imports Microsoft.VisualBasic
Imports System
Imports System.Linq
Imports DevExpress.Utils
Imports DevExpress.Web

Partial Public Class UserControls_NavigationToolbar
	Inherits System.Web.UI.UserControl
	Protected Sub NavigationMenu_Init(ByVal sender As Object, ByVal e As EventArgs)
		Dim menu = CType(sender, ASPxMenu)
		Dim rootItem = Utils.NavigationItems.First(Function(i) i.Text.ToLower() = Utils.CurrentPageName.ToLower())

		Dim rootMenuItem = New DevExpress.Web.MenuItem()
		menu.Items.Add(rootMenuItem)
		rootMenuItem.Text = rootItem.Text
		rootMenuItem.Image.SpriteProperties.CssClass = rootItem.SpriteClassName
		rootMenuItem.PopOutImage.SpriteProperties.CssClass = "Sprite_Arrow"

		For Each item In Utils.NavigationItems
			Dim menuItem = New DevExpress.Web.MenuItem()
			rootMenuItem.Items.Add(menuItem)
			menuItem.Text = item.Text
			menuItem.NavigateUrl = item.NavigationUrl
			menuItem.Selected = item Is rootItem
		Next item
		menu.ShowPopOutImages = DefaultBoolean.True
	End Sub
End Class
