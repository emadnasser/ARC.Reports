Imports Microsoft.VisualBasic
Imports DevExpress.Web.Demos
Imports System
Imports System.Collections.Generic
Imports System.IO
Imports System.Linq
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls

Partial Public Class API_CommandsAPI
	Inherits System.Web.UI.Page
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		RichEditDemoUtils.HideFileTab(DemoRichEdit)
	End Sub
End Class
