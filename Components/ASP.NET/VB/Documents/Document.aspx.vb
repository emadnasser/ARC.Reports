Imports System
Imports System.Web
Imports System.Web.UI

Partial Public Class Document
    Inherits Page

    Protected Sub Page_PreInit(ByVal sender As Object, ByVal e As EventArgs)
        DocumentsApp.Instance.Document.ProcessDocumentRequest(Me)
    End Sub
End Class
