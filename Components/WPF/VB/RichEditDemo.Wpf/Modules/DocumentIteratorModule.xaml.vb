Imports System
Imports DevExpress.XtraRichEdit.API.Native
Imports RichEditDemo.Controls
Imports DevExpress.Xpf.Core

Namespace RichEditDemo
    Partial Public Class DocumentIteratorModule
        Inherits RichEditDemoModule


        Private contentChanged_Renamed As Boolean
        Private includeTextboxes As Boolean
        Private exportTimer As System.Timers.Timer

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Property ContentChanged() As Boolean
            Get
                SyncLock Me
                    Return contentChanged_Renamed
                End SyncLock
            End Get
            Set(ByVal value As Boolean)
                SyncLock Me
                    Me.contentChanged_Renamed = value
                End SyncLock
            End Set
        End Property

        Private Sub ExportTimerElapsed(ByVal sender As Object, ByVal e As System.Timers.ElapsedEventArgs)
            If Not ContentChanged Then
                Return
            End If
            ContentChanged = False
            exportTimer.Stop()
            Dispatcher.BeginInvoke(New Action(Sub() ExportToMarkdown()))
        End Sub
        Private Sub ExportToMarkdown()
            Dim visitor As New MarkdownVisitor()
            Iterate(visitor)
            markdown.Text = visitor.Text
        End Sub
        Private Sub Iterate(ByVal visitor As IDocumentVisitor)
            Dim [iterator] As New DocumentIterator(richEdit.Document, True)
            Do While [iterator].MoveNext()
                [iterator].Current.Accept(visitor)
            Loop
        End Sub
        Private Sub OnRichEditLoaded(ByVal sender As Object, ByVal e As System.Windows.RoutedEventArgs)
            exportTimer = New System.Timers.Timer()
            AddHandler exportTimer.Elapsed, AddressOf ExportTimerElapsed
            OpenXmlLoadHelper.Load("Markdown.docx", richEdit)
        End Sub
        Private Sub OnRichEditContentChanged(ByVal sender As Object, ByVal e As EventArgs)
            StartTimer()
        End Sub
        Private Sub StartTimer()
            ContentChanged = True
            exportTimer.Start()
        End Sub
        Private Sub OnDocumentStatistics(ByVal sender As Object, ByVal e As DevExpress.Xpf.Bars.ItemClickEventArgs)
            ShowDocumentStatistics()
        End Sub
        Private Sub ShowDocumentStatistics()
            Dim control As New DocumentStatisticsControl(richEdit.Document, Me.includeTextboxes)
            Dim parameters As New FloatingContainerParameters()
            parameters.Title = "Document Statistics"
            parameters.CloseOnEscape = True
            parameters.AllowSizing = False
            FloatingContainer.ShowDialogContent(control, Me, System.Windows.Size.Empty, parameters, True)
            Me.includeTextboxes = control.IncludeTextboxes
        End Sub
    End Class
    Public Class MarkdownVisitor
        Inherits BufferedDocumentVisitor

        Public ReadOnly Property Text() As String
            Get
                Return Buffer.ToString()
            End Get
        End Property

        Public Overrides Sub Visit(ByVal text As DocumentText)
            Dim prefix As String = GetPrefix(text.TextProperties)
            Buffer.Append(prefix)
            Buffer.Append(text.Text)
            Buffer.Append(prefix)
        End Sub
        Public Overrides Sub Visit(ByVal paragraphStart As DocumentParagraphStart)
            If paragraphStart.ParagraphProperties.ParagraphStyle.Name = "heading 1" Then
                Buffer.Append("#")
            End If
        End Sub

        Public Overrides Sub Visit(ByVal paragraphEnd As DocumentParagraphEnd)
            AppendLineOnNonEmptyContent()
        End Sub
        Public Overrides Sub Visit(ByVal sectionEnd As DocumentSectionEnd)
            AppendLineOnNonEmptyContent()
        End Sub
        Public Overrides Sub Visit(ByVal inlinePicture As DocumentInlinePicture)
            InsertImageUri(inlinePicture.Uri)
        End Sub
        Public Overrides Sub Visit(ByVal picture As DocumentPicture)
            InsertImageUri(picture.Uri)
        End Sub
        Public Overrides Sub Visit(ByVal hyperlinkStart As DocumentHyperlinkStart)
            If Not String.IsNullOrEmpty(hyperlinkStart.NavigateUri) Then
                Buffer.Append("[")
            End If
        End Sub
        Public Overrides Sub Visit(ByVal hyperlinkEnd As DocumentHyperlinkEnd)
            If Not String.IsNullOrEmpty(hyperlinkEnd.NavigateUri) Then
                Buffer.Append(String.Format("]({0})", hyperlinkEnd.NavigateUri))
            End If
        End Sub
        Private Sub InsertImageUri(ByVal uri As String)
            If Not String.IsNullOrEmpty(uri) Then
                Buffer.Append(String.Format("![]({0})", uri))
            Else
                Buffer.Append("[[img src=attached-image.jpg alt=foobar]]")
            End If
        End Sub
        Private Function GetPrefix(ByVal properties As ReadOnlyTextProperties) As String
            Dim prefix As String = String.Empty
            If properties.FontBold Then
                prefix = "**"
            End If
            If properties.FontItalic Then
                prefix &= "*"
            End If
            If properties.StrikeoutType = StrikeoutType.Single Then
                prefix &= "~~"
            End If
            Return prefix
        End Function
        Private Sub AppendLineOnNonEmptyContent()
            If Buffer.Length > 0 Then
                Buffer.AppendLine()
            End If
        End Sub
    End Class
End Namespace
