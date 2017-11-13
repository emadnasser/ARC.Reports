Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports DevExpress.Web
Imports DevExpress.Web.Office

Partial Public Class RichTextEdit
    Inherits System.Web.UI.Page

    Private ReadOnly Property DocumentsApp() As DocumentsApp
        Get
            Return DocumentsApp.Instance
        End Get
    End Property
    Private ReadOnly Property DocumentService() As DocumentService
        Get
            Return DocumentsApp.Document
        End Get
    End Property
    Private ReadOnly Property CurrentDocument() As Item
        Get
            Return DocumentService.CurrentDocument
        End Get
    End Property

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
        If Not IsPostBack Then
            RichEdit.ReadOnly = DocumentService.CurrentDocumentReadOnly
            Dim currentDocumentId As String = DocumentService.GetDocumentIdForEditor(CurrentDocument)
            Dim openedDocument As IDocumentInfo = DocumentManager.FindDocument(currentDocumentId)
            If openedDocument Is Nothing Then
                If CurrentDocument.Content Is Nothing Then
                    RichEdit.[New]()
                    RichEdit.DocumentId = currentDocumentId
                    CurrentDocument.Content = DocumentsApp.Data.CreateBinaryContent(RichEdit.SaveCopy(DocumentService.GetRichEditDocumentFormat(CurrentDocument)))
                    DocumentsApp.Data.SaveChanges()
                Else
                    RichEdit.Open(currentDocumentId, DocumentService.CurrentRichEditDocumentFormat, Function() CurrentDocument.Content.Data)
                End If
            Else
                RichEdit.Open(DirectCast(openedDocument, RichEditDocumentInfo))
            End If
        End If
    End Sub
    Protected Sub RichEdit_PreRender(ByVal sender As Object, ByVal e As EventArgs)
        RichEdit.Focus()
    End Sub
End Class
