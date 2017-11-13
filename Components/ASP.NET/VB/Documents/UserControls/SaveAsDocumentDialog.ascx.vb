Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports DevExpress.Web

Partial Public Class UserControls_SaveAsDocumentDialog
    Inherits System.Web.UI.UserControl

    Public Property DefaultDocumentName() As String

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
        DocumentNameTextBox.Text = DefaultDocumentName
    End Sub
End Class
