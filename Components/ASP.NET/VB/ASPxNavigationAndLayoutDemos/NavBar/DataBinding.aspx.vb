Imports Microsoft.VisualBasic
Imports System
Imports System.Web.UI

Partial Public Class Menu_DataBinding
	Inherits Page
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		XmlDataSource1.XPath = CStr(ddlXPath.SelectedItem.Value)
		lblXPath.Text = XmlDataSource1.XPath
	End Sub
End Class
