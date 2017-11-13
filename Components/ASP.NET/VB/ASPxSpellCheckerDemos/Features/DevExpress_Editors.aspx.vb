Imports Microsoft.VisualBasic
Imports System.Web.UI
Imports DevExpress.Web

Partial Public Class Modules_DevExpress
	Inherits Page

	Protected Sub ASPxSpellChecker1_CheckedElementResolve(ByVal sender As Object, ByVal e As ControlResolveEventArgs)
		e.ResolvedControl = ASPxMemo1
	End Sub
End Class
