Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.IO
Imports System.Linq
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls

Partial Public Class BarsAndUI_CustomToolbar
	Inherits System.Web.UI.Page
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		DemoToolbar.AutoSeparators = DevExpress.Web.AutoSeparatorMode.None
		DemoRichEdit.Open(Path.Combine(DirectoryManagmentUtils.CurrentDataDirectory, "Example.rtf"))
	End Sub
End Class
