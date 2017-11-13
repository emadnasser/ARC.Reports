Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.Web
Imports System.Web.UI
Imports System.Xml

Partial Public Class NavBar_Templates
	Inherits Page
	Private Const ClickHandlerScript As String = "return DXDemo.ShowScreenshotWindow(event, this);"

	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)

	End Sub

	Protected Sub ASPxNavBar1_GroupDataBound(ByVal sender As Object, ByVal e As NavBarGroupEventArgs)
		Dim xmlElement As XmlElement = TryCast((TryCast(e.Group.DataItem, IHierarchyData)).Item, XmlElement)
		Dim ucContentTemplate As Control = LoadControl("ContentTemplate.ascx")
		e.Group.ContentTemplate = TryCast(ucContentTemplate, ITemplate)
		DataBindContentUserControl(xmlElement, ucContentTemplate)
	End Sub

	Protected Sub Watch_OnPreRender(ByVal sender As Object, ByVal e As EventArgs)
		Dim lWatch As ASPxHyperLink = TryCast(sender, ASPxHyperLink)
		If lWatch IsNot Nothing Then
			lWatch.Attributes.Add("onclick", ClickHandlerScript)
		End If
	End Sub

	Private Sub DataBindContentUserControl(ByVal xmlElement As XmlElement, ByVal userControl As Control)
		Dim htText As ASPxLabel = TryCast(userControl.FindControl("htText"), ASPxLabel)
		If htText IsNot Nothing Then
			htText.Text = xmlElement.InnerXml
		End If
		Dim htImage As ASPxHyperLink = TryCast(userControl.FindControl("htImage"), ASPxHyperLink)
		If htImage Is Nothing OrElse xmlElement.Attributes("ImageUrl") Is Nothing OrElse xmlElement.Attributes("NavigateUrl") Is Nothing Then
			Return
		End If
		htImage.NavigateUrl = xmlElement.Attributes("NavigateUrl").Value
		htImage.Target = "_blank"
		htImage.Attributes.Add("onclick", ClickHandlerScript)
		htImage.ImageUrl = xmlElement.Attributes("ImageUrl").Value
	End Sub

End Class
