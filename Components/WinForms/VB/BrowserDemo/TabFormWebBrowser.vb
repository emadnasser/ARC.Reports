Imports System.Drawing
Imports System.Windows.Forms

Namespace DevExpress.XtraBars.Demos.BrowserDemo
    Public Class TabFormWebBrowser
        Inherits WebBrowser
        Private m_page As TabFormPage

        Public Sub New(page As TabFormPage)
            MyBase.New()
            Me.m_page = page
        End Sub
        Public ReadOnly Property Page() As TabFormPage
            Get
                Return m_page
            End Get
        End Property

        Protected Overrides Sub OnDocumentCompleted(e As WebBrowserDocumentCompletedEventArgs)
            MyBase.OnDocumentCompleted(e)
            OnDocumentCompletedCore(e)
        End Sub

        Protected Sub OnDocumentCompletedCore(e As WebBrowserDocumentCompletedEventArgs)
            If Page Is Nothing OrElse e.Url Is Nothing OrElse String.IsNullOrEmpty(e.Url.Host) OrElse Url Is Nothing OrElse Not Object.Equals(Url.Host, e.Url.Host) Then
                Return
            End If
            Try
                Dim iconURL As String = "http://" & e.Url.Host & "/favicon.ico"
                Dim request As System.Net.WebRequest = System.Net.HttpWebRequest.Create(iconURL)
                Dim response As System.Net.WebResponse = request.GetResponse()
                Dim stream As System.IO.Stream = response.GetResponseStream()
                Page.Image = Image.FromStream(stream)
            Catch
            End Try
        End Sub

        Protected Overrides Sub OnDocumentTitleChanged(e As System.EventArgs)
            MyBase.OnDocumentTitleChanged(e)
            OnDocumentTitleChangedCore()
        End Sub

        Protected Sub OnDocumentTitleChangedCore()
            If Page Is Nothing Then
                Return
            End If
            Page.Text = DocumentTitle
        End Sub
    End Class
End Namespace
