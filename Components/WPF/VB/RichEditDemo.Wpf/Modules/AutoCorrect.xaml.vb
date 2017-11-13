Imports System
Imports System.Globalization
Imports System.Windows
Imports DevExpress.Xpf.Editors
Imports DevExpress.XtraRichEdit
Imports DevExpress.XtraRichEdit.Model
Imports DevExpress.XtraRichEdit.Utils
Imports DevExpress.Office.NumberConverters
Imports DevExpress.Xpf.SpellChecker
Imports DevExpress.XtraRichEdit.Services
Imports DevExpress.Utils
Imports DevExpress.Office.Utils

Namespace RichEditDemo
    Partial Public Class AutoCorrect
        Inherits RichEditDemoModule

        Private spellChecker As SpellChecker

        Public Sub New()
            InitializeComponent()
            Me.spellChecker = SpellChecking.InitializeSpellChecker()
            OpenXmlLoadHelper.Load("AutoCorrect.docx", richEdit)
        End Sub

        Private Sub richEdit_Loaded(ByVal sender As Object, ByVal e As System.Windows.RoutedEventArgs)
            richEdit.SpellChecker = spellChecker

            richEdit.Options.AutoCorrect.CorrectTwoInitialCapitals = True
            richEdit.Options.AutoCorrect.UseSpellCheckerSuggestions = True

            Dim service As IAutoCorrectService = richEdit.GetService(Of IAutoCorrectService)()
            If service IsNot Nothing Then
                Dim replaceTable As New AutoCorrectReplaceInfoCollection()
                replaceTable.Add("(C)", "©")
                replaceTable.Add(New AutoCorrectReplaceInfo(":)", OfficeImage.CreateImage(Me.GetType().Assembly.GetManifestResourceStream("smile.png"))))
                replaceTable.Add("pctus", "Please do not hesitate to contact us again in case of any further questions.")
                replaceTable.Add("wnwd", "well-nourished, well-developed")
                service.SetReplaceTable(replaceTable)
            End If
        End Sub

        Private Sub edtReplaceAsYouType_CheckedChanged(ByVal sender As Object, ByVal e As RoutedEventArgs)
            richEdit.Options.AutoCorrect.ReplaceTextAsYouType = edtReplaceAsYouType.IsChecked.Value
        End Sub
        Private Sub edtDetectUrls_CheckedChanged(ByVal sender As Object, ByVal e As RoutedEventArgs)
            richEdit.Options.AutoCorrect.DetectUrls = edtDetectUrls.IsChecked.Value
        End Sub
        Private Sub edtCorrectTwoInitialCapitals_CheckedChanged(ByVal sender As Object, ByVal e As RoutedEventArgs)
            richEdit.Options.AutoCorrect.CorrectTwoInitialCapitals = edtCorrectTwoInitialCapitals.IsChecked.Value
        End Sub
        Private Sub edtUseSpellCheckerSuggestions_CheckedChanged(ByVal sender As Object, ByVal e As RoutedEventArgs)
            richEdit.Options.AutoCorrect.UseSpellCheckerSuggestions = edtUseSpellCheckerSuggestions.IsChecked.Value
        End Sub
        Private Sub richEdit_AutoCorrect(ByVal sender As Object, ByVal e As AutoCorrectEventArgs)
            Dim info As AutoCorrectInfo = e.AutoCorrectInfo
            e.AutoCorrectInfo = Nothing

            If Not edtCustomAutoCorrect.IsChecked.Value Then
                Return
            End If

            If info.Text.Length <= 0 OrElse (Not info.Text.Contains("%")) Then
                Return
            End If
            Dim characterPosition As Integer = info.Text.IndexOf("%")
            Dim decrementCount As Integer = info.Text.Length - characterPosition - 1
            For i As Integer = 0 To decrementCount - 1
                info.DecrementEndPosition()
            Next i

            Do
                If Not info.DecrementStartPosition() Then
                    Return
                End If

                If IsSeparator(info.Text(0)) Then
                    Return
                End If

                If info.Text(0) = "%"c Then
                    Dim replaceString As String = CalculateFunction(info.Text)
                    If Not String.IsNullOrEmpty(replaceString) Then
                        info.ReplaceWith = replaceString
                        e.AutoCorrectInfo = info
                    End If
                    Return
                End If
            Loop
        End Sub

        Private Function CalculateFunction(ByVal name As String) As String
            name = name.ToLower()

            If name.Length > 2 AndAlso name.Chars(0) = "%"c AndAlso name.EndsWith("%") Then
                Dim value As Integer = Nothing
                If Int32.TryParse(name.Substring(1, name.Length - 2), value) Then
                    Dim converter As OrdinalBasedNumberConverter = OrdinalBasedNumberConverter.CreateConverter(NumberingFormat.CardinalText, LanguageId.English)
                    Return converter.ConvertNumber(value)
                End If
            End If

            Select Case name
                Case "%date%"
                    Return Date.Now.ToString(CultureInfo.CurrentCulture.DateTimeFormat.ShortDatePattern)
                Case "%time%"
                    Return Date.Now.ToString(CultureInfo.CurrentCulture.DateTimeFormat.ShortTimePattern)
                Case "%bye%"
                    Return "Yours sincerely," & ControlChars.CrLf & "David B. Smith"
                Case Else
                    Return String.Empty
            End Select
        End Function
        Private Function IsSeparator(ByVal ch As Char) As Boolean
            Return ch <> "%"c AndAlso (ch = ControlChars.Cr OrElse ch = ControlChars.Lf OrElse Char.IsPunctuation(ch) OrElse Char.IsSeparator(ch) OrElse Char.IsWhiteSpace(ch))
        End Function
    End Class
End Namespace
