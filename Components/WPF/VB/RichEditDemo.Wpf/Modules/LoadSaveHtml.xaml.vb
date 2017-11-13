Imports System
Imports System.IO
Imports System.Reflection
Imports DevExpress.XtraRichEdit.Internal
Imports DevExpress.XtraRichEdit
Imports DevExpress.XtraRichEdit.Services
Imports DevExpress.Office.Services

Namespace RichEditDemo
    Partial Public Class LoadSaveHtml
        Inherits RichEditDemoModule

        Public Sub New()
            InitializeComponent()
            Dim service As IDocumentImportManagerService = richEdit.GetService(Of IDocumentImportManagerService)()
            If service IsNot Nothing Then
                service.UnregisterImporter(service.GetImporter(DocumentFormat.PlainText))
                service.UnregisterImporter(service.GetImporter(DocumentFormat.Rtf))
                service.UnregisterImporter(service.GetImporter(DocumentFormat.Mht))
                service.UnregisterImporter(service.GetImporter(DocumentFormat.OpenXml))
                service.UnregisterImporter(service.GetImporter(DocumentFormat.WordML))
                service.UnregisterImporter(service.GetImporter(DocumentFormat.OpenDocument))
            End If


            HtmlLoadHelper.Load("html_sample.htm", richEdit)
        End Sub

        Private Sub richEdit_DocumentLoaded(ByVal sender As Object, ByVal e As EventArgs)
            richEdit.HorizontalScrollBarVisibility = System.Windows.Visibility.Collapsed
            Try
                Dim fileName As String = richEdit.Options.DocumentSaveOptions.CurrentFileName
                If Not String.IsNullOrEmpty(fileName) Then
                    webBrowser.Source = New Uri("file://" & fileName)
                    Using reader As New StreamReader(fileName)
                        edtPlainHtml.Text = reader.ReadToEnd()
                    End Using
                End If
            Catch
            End Try
        End Sub

        Private Sub richEdit_EmptyDocumentCreated(ByVal sender As Object, ByVal e As EventArgs)
            webBrowser.Source = Nothing
            edtPlainHtml.Text = String.Empty
        End Sub
        Protected Overrides Sub RaiseModuleAppear()
            MyBase.RaiseModuleAppear()
            richEdit_DocumentLoaded(Me, EventArgs.Empty)
        End Sub
        Protected Overrides Function CanLeave() As Boolean
            webBrowser.Source = Nothing
            Return True
        End Function

        Protected Overrides Sub RaiseBeforeModuleAppear()
            MyBase.RaiseBeforeModuleAppear()
            Dim fileName As String = richEdit.Options.DocumentSaveOptions.CurrentFileName
            If Not String.IsNullOrEmpty(fileName) Then
                webBrowser.Source = New Uri("file://" & fileName)
            End If
        End Sub

    End Class

End Namespace
