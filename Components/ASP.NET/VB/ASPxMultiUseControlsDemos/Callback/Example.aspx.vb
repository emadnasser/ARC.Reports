Imports Microsoft.VisualBasic
Imports System
Imports System.Xml
Imports System.Threading
Imports DevExpress.Web
Imports System.Web.UI

Partial Public Class Callback_Example
	Inherits Page
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		If IsCallback Then
			' Intentionally pauses server-side processing,
			' to demonstrate the Loading Panel functionality.    
			Thread.Sleep(500)
		End If
	End Sub

	Protected Sub ASPxCallback1_Callback(ByVal sender As Object, ByVal e As CallbackEventArgs)
		Dim xpath As String = String.Format("//items/item[@newsID='{0}']", e.Parameter)
		Dim node As XmlNode = XmlDataSource1.GetXmlDocument().SelectSingleNode(xpath)
		If node IsNot Nothing Then
			e.Result = node.Attributes("Description").Value
		End If
	End Sub
End Class
