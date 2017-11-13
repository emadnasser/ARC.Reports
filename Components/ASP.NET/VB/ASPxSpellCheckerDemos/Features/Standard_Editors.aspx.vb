Imports Microsoft.VisualBasic
Imports System.Web.UI
Imports DevExpress.Web

Partial Public Class Modules_Standard_Editors
	Inherits Page
	Protected Sub ASPxSpellChecker1_CheckedElementResolve(ByVal sender As Object, ByVal e As ControlResolveEventArgs)
		e.ResolvedControl = TextBox1
	End Sub
End Class
