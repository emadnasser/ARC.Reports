Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.Web
Imports System.Web.UI

Partial Public Class CallbackPanel_CustomJavaScriptProperties
	Inherits Page
	Protected Sub CallbackPanel_Callback(ByVal sender As Object, ByVal e As CallbackEventArgsBase)
		Dim parameters() As String = e.Parameter.Split(":"c)
		Dim currentPageIndex As Integer = Integer.Parse(parameters(0))
		If parameters(1) = "next" Then
			currentPageIndex += 1
		Else
			currentPageIndex -= 1
		End If
		MultiView.ActiveViewIndex = currentPageIndex

		' Intentionally pauses server-side processing,
		' to demonstrate the Loading Panel functionality.    
		System.Threading.Thread.Sleep(1000)
	End Sub

	Protected Sub rpFilmCollection_CustomJSProperties(ByVal sender As Object, ByVal e As CustomJSPropertiesEventArgs)
		e.Properties("cpPageIndex") = MultiView.ActiveViewIndex
		e.Properties("cpPageCount") = MultiView.Views.Count
	End Sub
End Class
