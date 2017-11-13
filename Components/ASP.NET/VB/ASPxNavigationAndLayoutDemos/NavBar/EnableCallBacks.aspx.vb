Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.Web
Imports System.Threading
Imports System.Web.UI
Imports System.Xml

Partial Public Class NavBar_EnableCallBacks
	Inherits Page
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		If IsCallback Then
			' Intentionally pauses server-side processing, 
			' to demonstrate the Loading Panel functionality.
			Thread.Sleep(1000)
		End If
		If (Not IsPostBack) Then
			ASPxNavBar1.DataBind()
			ASPxNavBar1.Groups.CollapseAll()
			ASPxNavBar1.Groups(0).Expanded = True
		End If
	End Sub

	Protected Sub ASPxNavBar1_GroupDataBound(ByVal sender As Object, ByVal e As NavBarGroupEventArgs)
		Dim hierarchyData As IHierarchyData = (TryCast(e.Group.DataItem, IHierarchyData))
		Dim xmlElement As XmlElement = TryCast(hierarchyData.Item, XmlElement)
		Dim attributes As XmlAttributeCollection = xmlElement.Attributes

		If xmlElement.Attributes("View") IsNot Nothing Then
			e.Group.Text = xmlElement.Attributes("View").Value
		End If
	End Sub
End Class
