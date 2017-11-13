Imports Microsoft.VisualBasic
Imports System
Imports System.Web.UI
Imports DevExpress.Web
Imports System.Xml

Partial Public Class Menu_ScrollingPage
	Inherits Page
	Private Const sessionKey As String = "DXEnableScrolling"

	Private ReadOnly Property EnableSubMenuScrolling() As Boolean
		Get
			If Session(sessionKey) Is Nothing Then
				Session(sessionKey) = True
			End If
			Return CBool(Session(sessionKey))
		End Get
	End Property

	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		menu.EnableSubMenuScrolling = EnableSubMenuScrolling
	End Sub

	Protected Sub menu_ItemDataBound(ByVal sender As Object, ByVal e As MenuItemEventArgs)
		Dim itemHierarchyData As IHierarchyData = CType(e.Item.DataItem, IHierarchyData)
		Dim element As XmlElement = CType(itemHierarchyData.Item, XmlElement)
		If element.Attributes("Index") Is Nothing Then
			Return
		End If
		Dim imgIndex As Integer = Integer.Parse(element.Attributes("Index").Value)
		e.Item.Image.SpriteProperties.CssClass = String.Format("componentImage_{0}", imgIndex)
	End Sub
End Class
