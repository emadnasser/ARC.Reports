Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports DevExpress.Web
Imports DevExpress.Web.ASPxSpreadsheet
Imports DevExpress.Web.Office

Partial Public Class SpreadsheetEdit
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

    Protected Sub Spreadsheet_Init(ByVal sender As Object, ByVal e As EventArgs)
        If Not IsPostBack Then
            Spreadsheet.ReadOnly = DocumentService.CurrentDocumentReadOnly
            Dim currentDocumentId As String = DocumentService.GetDocumentIdForEditor(CurrentDocument)
            Dim openedDocument As IDocumentInfo = DocumentManager.FindDocument(currentDocumentId)
            If openedDocument Is Nothing Then
                If CurrentDocument.Content Is Nothing Then
                    Spreadsheet.[New]()
                    Spreadsheet.DocumentId = currentDocumentId
                    CurrentDocument.Content = DocumentsApp.Data.CreateBinaryContent(Spreadsheet.SaveCopy(DocumentService.GetSpreadsheetDocumentFormat(CurrentDocument)))
                    DocumentsApp.Data.SaveChanges()
                Else
                    Spreadsheet.Open(currentDocumentId, DocumentService.CurrentSpreadsheetDocumentFormat, Function() CurrentDocument.Content.Data)
                End If
            Else
                Spreadsheet.Open(DirectCast(openedDocument, SpreadsheetDocumentInfo))
            End If
        End If
    End Sub
End Class
