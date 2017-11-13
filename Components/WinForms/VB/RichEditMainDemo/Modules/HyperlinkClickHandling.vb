Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.Office.Utils
Imports DevExpress.XtraRichEdit.Demos.Forms
Imports DevExpress.XtraRichEdit.Utils
Imports DevExpress.XtraRichEdit.API.Native

Namespace DevExpress.XtraRichEdit.Demos
    Partial Public Class HyperlinkClickHandlingModule
        Inherits DevExpress.XtraRichEdit.Demos.TutorialControl
        Private Shared products As List(Of String) = CreateProducts()
        Private Shared managers As List(Of String) = CreateManagers()
        Private Shared contactInfos As List(Of String) = CreateContactInfos()
        Private Shared Function CreateProducts() As List(Of String)
            Dim result As New List(Of String)()
            result.Add("XtraScheduler™ Suite")
            result.Add("XtraRichEdit™ Suite")
            result.Add("XtraSpellChecker™")
            result.Add("XtraReports™ Suite")
            result.Add("XtraGrid™ Suite")
            result.Add("XtraPivotGrid™ Suite")
            result.Add("XtraTreeList™ Suite")
            result.Add("XtraGauges™ Suite")
            result.Add("XtraWizard™ Control")
            result.Add("XtraVerticalGrid™ Suite")
            result.Add("XtraCharts™ Suite")
            result.Add("XtraLayoutControl™ Suite")
            result.Add("XtraNavBar™")
            result.Add("XtraEditors™ Library")
            result.Add("XtraPrinting™ Library")
            Return result
        End Function
        Private Shared Function CreateManagers() As List(Of String)
            Dim result As New List(Of String)()
            result.Add("Mark M Leininger")
            result.Add("Caroline R Geraghty")
            result.Add("Dorothy M Salas")
            result.Add("Pete M Smith")
            result.Add("Lena D Carroll")
            result.Add("Shauna T Tuggle")
            result.Add("Mary R Spencer")
            result.Add("David G Rucker")
            result.Add("Barry D Phillips")
            result.Add("Ronald R Ross")
            result.Add("Nellie J Burdette")
            Return result
        End Function
        Private Shared Function CreateContactInfos() As List(Of String)
            Dim result As New List(Of String)()
            result.Add("Mark.M.Leininger@dodgit.com, 773-384-2677")
            result.Add("Caroline.R.Geraghty@mailinator.com, 703-968-3712")
            result.Add("Dorothy.M.Salas@trashymail.com, 541-995-3154")
            result.Add("Pete.M.Smith@spambob.com, 954-568-0573")
            result.Add("Lena.D.Carroll@spambob.com, 772-663-2034")
            result.Add("Shauna.T.Tuggle@mailinator.com, 812-463-8021")
            result.Add("Mary.R.Spencer@dodgit.com, 510-819-1801")
            result.Add("David.G.Rucker@spambob.com, 423-550-7308")
            result.Add("Barry.D.Phillips@mailinator.com, 831-308-3866")
            result.Add("Ronald.R.Ross@dodgit.com, 847-242-3792")
            result.Add("Nellie.J.Burdette@pookmail.com, 937-777-5277")
            Return result
        End Function

        Private Delegate Function CreateFormDelegate() As PopupFormBase
        Private hyperlinkMappings As Dictionary(Of String, CreateFormDelegate)
        Public Sub New()
            InitializeComponent()
            RtfLoadHelper.Load("HyperlinkClickHandling.rtf", richEditControl)
            CType(New RichEditDemoExceptionsHandler(richEditControl), RichEditDemoExceptionsHandler).Install()
            Me.hyperlinkMappings = CreateHyperlinkMappings()
            SubscribeRichEditEvents()
        End Sub
        Private Function CreateHyperlinkMappings() As Dictionary(Of String, CreateFormDelegate)
            Dim result As Dictionary(Of String, CreateFormDelegate) = New Dictionary(Of String, CreateFormDelegate)()
            Dim hyperlinks As HyperlinkCollection = Me.richEditControl.Document.Hyperlinks
            result.Add("OpenSelectProductForm", AddressOf CreateSelectProductForm)
            result.Add("OpenSelectAmountForm", AddressOf CreateSelectAmountForm)
            result.Add("OpenSelectDateForm", AddressOf CreateSelectDateForm)
            result.Add("OpenSelectManagerForm", AddressOf CreateSelectManagerForm)
            Return result
        End Function
        Private Function CreateSelectProductForm() As PopupFormBase
            Dim result As SelectProductForm = New SelectProductForm(products)
            AddHandler result.Commit, AddressOf OnProductFormCommit
            Return result
        End Function
        Private Sub OnProductFormCommit(ByVal sender As Object, ByVal e As EventArgs)
            Dim form As SelectProductForm = CType(sender, SelectProductForm)
            Dim value As String = CStr(form.EditValue)
            ReplaceRange(value, form.Range)
        End Sub
        Private Function CreateSelectDateForm() As PopupFormBase
            Dim result As SelectDateForm = New SelectDateForm()
            AddHandler result.Commit, AddressOf OnSelectDateFormCommit
            Return result
        End Function
        Private Sub OnSelectDateFormCommit(ByVal sender As Object, ByVal e As EventArgs)
            Dim form As SelectDateForm = CType(sender, SelectDateForm)
            Dim value As String = (CDate(form.EditValue)).ToString("MMMM, dd yyyy")
            ReplaceRange(value, form.Range)
        End Sub
        Private Function CreateSelectAmountForm() As PopupFormBase
            Dim result As SelectAmountForm = New SelectAmountForm()
            AddHandler result.Commit, AddressOf OnSelectAmountFormCommit
            Return result
        End Function
        Private Sub OnSelectAmountFormCommit(ByVal sender As Object, ByVal e As EventArgs)
            Dim form As SelectAmountForm = CType(sender, SelectAmountForm)
            Dim value As String = (CDec(form.EditValue)).ToString("$0.00")
            ReplaceRange(value, form.Range)
        End Sub
        Private Function CreateSelectManagerForm() As PopupFormBase
            Dim result As SelectManagerForm = New SelectManagerForm(managers, contactInfos)
            AddHandler result.Commit, AddressOf OnSelectManagerForm
            Return result
        End Function
        Private Sub OnSelectManagerForm(ByVal sender As Object, ByVal e As EventArgs)
            Dim form As SelectManagerForm = CType(sender, SelectManagerForm)
            Dim value As String = CStr(form.EditValue)
            ReplaceRange(value, form.Range)
        End Sub
        Private Sub SubscribeRichEditEvents()
            AddHandler richEditControl.HyperlinkClick, AddressOf OnHyperlinkClick
        End Sub
        Private Sub OnHyperlinkClick(ByVal sender As Object, ByVal e As HyperlinkClickEventArgs)
            If e.ModifierKeys <> Me.richEditControl.Options.Hyperlinks.ModifierKeys Then
                Return
            End If
            Dim createForm As CreateFormDelegate = Nothing
            If (Not hyperlinkMappings.TryGetValue(e.Hyperlink.NavigateUri, createForm)) Then
                Return
            End If
            Dim form As PopupFormBase = createForm()
            form.Range = e.Hyperlink.Range
            form.Location = GetFormLocation()
            form.Show()
            e.Handled = True
        End Sub
        Private Function GetFormLocation() As Point
            Dim position As DocumentPosition = Me.richEditControl.Document.CaretPosition
            Dim rect As Rectangle = Me.richEditControl.GetBoundsFromPosition(position)
            Dim location As New Point(rect.Right, rect.Bottom)
            Dim localPoint As Point = Units.DocumentsToPixels(location, Me.richEditControl.DpiX, Me.richEditControl.DpiY)
            Return Me.richEditControl.PointToScreen(localPoint)
        End Function
        Private Function GetHyperlinkIndex(ByVal hyperlink As Hyperlink) As Integer
            Dim hyperlinks As HyperlinkCollection = Me.richEditControl.Document.Hyperlinks
            Dim count As Integer = hyperlinks.Count
            For i As Integer = 0 To count - 1
                If hyperlinks(i) Is hyperlink Then
                    Return i
                End If
            Next i
            Return -1
        End Function
        Private Sub ReplaceRange(ByVal value As String, ByVal range As DocumentRange)
            Dim document As Document = Me.richEditControl.Document
            document.BeginUpdate()
            Try
                document.Replace(range, value)
            Finally
                document.EndUpdate()
            End Try
        End Sub
    End Class
End Namespace
