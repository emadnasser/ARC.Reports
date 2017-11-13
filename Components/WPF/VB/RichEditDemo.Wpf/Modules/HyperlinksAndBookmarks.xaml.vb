Imports System
Imports System.Windows.Forms
Imports DevExpress.Office.Internal
Imports DevExpress.Utils
Imports DevExpress.XtraRichEdit
Imports DevExpress.XtraRichEdit.API.Native

Namespace RichEditDemo
    Partial Public Class HyperlinksAndBookmarks
        Inherits RichEditDemoModule

        Public Sub New()
            InitializeComponent()
            OpenXmlLoadHelper.Load("Hyperlinks.docx", richEdit)
            ribbonControl1.SelectedPage = pageInsert
            InsertLinksInDocument()
        End Sub

        Private Sub InsertLinksInDocument()
            Dim doc As Document = Me.richEdit.Document
            Dim foundRanges() As DocumentRange = doc.FindAll("DevExpress WinForms Rich Text Editor", SearchOptions.CaseSensitive)
            If foundRanges.Length > 0 Then
                Dim hlink As Hyperlink = doc.Hyperlinks.Create(foundRanges(0))
                hlink.NavigateUri = "https://www.devexpress.com/Products/NET/Controls/WinForms/rich_editor/"
            End If

            Dim bm As Bookmark = doc.Bookmarks.Create(doc.Range.Start, 1, "Top")
            doc.Paragraphs.Append()
            Dim lastRange As DocumentRange = doc.AppendText("To the Top")
            Dim hlinkBookmark As Hyperlink = doc.Hyperlinks.Create(lastRange)
            hlinkBookmark.Anchor = "Top"
        End Sub

        Private Sub edtShowBoomarks_Checked(ByVal sender As Object, ByVal e As System.Windows.RoutedEventArgs)
            richEdit.Options.Bookmarks.Visibility = RichEditBookmarkVisibility.Visible
        End Sub

        Private Sub edtShowBookmarks_Unchecked(ByVal sender As Object, ByVal e As System.Windows.RoutedEventArgs)
            richEdit.Options.Bookmarks.Visibility = RichEditBookmarkVisibility.Hidden
        End Sub

        Private Sub colorEdit1_ColorChanged(ByVal sender As Object, ByVal e As System.Windows.RoutedEventArgs)
            UpdateBookmarkColor()
        End Sub
        Private Sub UpdateBookmarkColor()
            Dim mediacolor As System.Windows.Media.Color = colorEdit1.Color
            richEdit.Options.Bookmarks.Color = System.Drawing.Color.FromArgb(mediacolor.A, mediacolor.R, mediacolor.G, mediacolor.B)
        End Sub

        Private Sub edtShowTooltip_Checked(ByVal sender As Object, ByVal e As System.Windows.RoutedEventArgs)
            richEdit.Options.Hyperlinks.ShowToolTip = True
        End Sub

        Private Sub edtShowTooltip_Unchecked(ByVal sender As Object, ByVal e As System.Windows.RoutedEventArgs)
            richEdit.Options.Hyperlinks.ShowToolTip = False
        End Sub

        Private Sub edtCtrl_Checked(ByVal sender As Object, ByVal e As System.Windows.RoutedEventArgs)
            richEdit.Options.Hyperlinks.ModifierKeys = richEdit.Options.Hyperlinks.ModifierKeys Or Keys.Control
        End Sub

        Private Sub edtCtrl_Unchecked(ByVal sender As Object, ByVal e As System.Windows.RoutedEventArgs)
            richEdit.Options.Hyperlinks.ModifierKeys = richEdit.Options.Hyperlinks.ModifierKeys And Not Keys.Control
        End Sub

        Private Sub edtAlt_Unchecked(ByVal sender As Object, ByVal e As System.Windows.RoutedEventArgs)
            richEdit.Options.Hyperlinks.ModifierKeys = richEdit.Options.Hyperlinks.ModifierKeys And Not Keys.Alt
        End Sub

        Private Sub edtAlt_Checked(ByVal sender As Object, ByVal e As System.Windows.RoutedEventArgs)
            richEdit.Options.Hyperlinks.ModifierKeys = richEdit.Options.Hyperlinks.ModifierKeys Or Keys.Alt
        End Sub

        Private Sub edtShift_Checked(ByVal sender As Object, ByVal e As System.Windows.RoutedEventArgs)
            richEdit.Options.Hyperlinks.ModifierKeys = richEdit.Options.Hyperlinks.ModifierKeys Or Keys.Shift
        End Sub

        Private Sub edtShift_Unchecked(ByVal sender As Object, ByVal e As System.Windows.RoutedEventArgs)
            richEdit.Options.Hyperlinks.ModifierKeys = richEdit.Options.Hyperlinks.ModifierKeys And Not Keys.Shift
        End Sub

        Private Sub richEdit_Loaded(ByVal sender As Object, ByVal e As System.Windows.RoutedEventArgs)
            richEdit.Options.Bookmarks.Visibility = RichEditBookmarkVisibility.Visible
            UpdateBookmarkColor()
        End Sub
    End Class
End Namespace
