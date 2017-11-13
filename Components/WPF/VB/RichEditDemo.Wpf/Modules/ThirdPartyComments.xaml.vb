Imports System
Imports System.Collections.Generic
Imports System.Collections.ObjectModel
Imports System.Linq
Imports System.Text
Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Data
Imports System.Windows.Documents
Imports System.Windows.Input
Imports System.Windows.Media
Imports System.Windows.Media.Imaging
Imports System.Windows.Shapes
Imports DevExpress.XtraRichEdit

Namespace RichEditDemo
    Partial Public Class ThirdPartyComments
        Inherits RichEditDemoModule

        Public Sub New()
            InitializeComponent()
            OpenXmlLoadHelper.Load("Comments.docx", richEditControl1)
            ribbonControl1.SelectedPage = pageReview
        End Sub

        Private Sub richEditControl1_Loaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
            richEditControl1.Options.Comments.ShowAllAuthors = True
            richEditControl1.Options.Comments.Visibility = RichEditCommentVisibility.Visible
            FetchUsers()
        End Sub
        Private Sub FetchUsers()
            cbAuthor.Items.Clear()
            Dim authors As ObservableCollection(Of String) = richEditControl1.Options.Comments.VisibleAuthors
            For Each author As String In authors
                cbAuthor.Items.Add(author)
            Next author
            cbAuthor.EditValue = cbAuthor.Items(0)
            UpdateAuthor(Me.cbAuthor.EditValue.ToString())
        End Sub

        Private Sub UpdateAuthor(ByVal author As String)
            richEditControl1.Options.Comments.Author = author
        End Sub

        Private Sub UpdateCommentColor()
            Dim mediacolor As System.Windows.Media.Color = colorEdit1.Color
            richEditControl1.Options.Comments.Color = System.Drawing.Color.FromArgb(mediacolor.A, mediacolor.R, mediacolor.G, mediacolor.B)
        End Sub

        Private Sub cbUserAuthor_EditValueChanged(ByVal sender As Object, ByVal e As DevExpress.Xpf.Editors.EditValueChangedEventArgs)
            UpdateAuthor(Me.cbAuthor.EditValue.ToString())
        End Sub

        Private Sub edtViewComments_Checked(ByVal sender As Object, ByVal e As RoutedEventArgs)
            Me.richEditControl1.Options.Comments.Visibility = RichEditCommentVisibility.Visible
            edtHighlightCommentedRange.IsEnabled = False
        End Sub

        Private Sub edtViewComments_Unchecked(ByVal sender As Object, ByVal e As RoutedEventArgs)
            Me.richEditControl1.Options.Comments.Visibility = RichEditCommentVisibility.Hidden
            edtHighlightCommentedRange.IsEnabled = True
        End Sub

        Private Sub edtHighlightCommentedRange_Checked(ByVal sender As Object, ByVal e As RoutedEventArgs)
            Me.richEditControl1.Options.Comments.HighlightCommentedRange = True
        End Sub

        Private Sub edtHighlightCommentedRange_Unchecked(ByVal sender As Object, ByVal e As RoutedEventArgs)
            Me.richEditControl1.Options.Comments.HighlightCommentedRange = False
        End Sub

        Private Sub colorEdit1_ColorChanged(ByVal sender As Object, ByVal e As RoutedEventArgs)
            UpdateCommentColor()
            edtResetColor.IsChecked = False
        End Sub

        Private Sub edtResetColor_Checked(ByVal sender As Object, ByVal e As RoutedEventArgs)
            Me.richEditControl1.Options.Comments.ResetColor()
        End Sub

        Private Sub edtResetColor_Unchecked(ByVal sender As Object, ByVal e As RoutedEventArgs)
            UpdateCommentColor()
        End Sub

    End Class
End Namespace
