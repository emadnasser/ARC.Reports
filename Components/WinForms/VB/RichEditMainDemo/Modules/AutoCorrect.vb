Imports Microsoft.VisualBasic
Imports System
Imports System.Globalization
Imports DevExpress.XtraRichEdit
Imports DevExpress.XtraRichEdit.Model
Imports DevExpress.XtraRichEdit.Utils
Imports DevExpress.Office.NumberConverters
Imports DevExpress.XtraRichEdit.Services
Imports DevExpress.Utils

Namespace DevExpress.XtraRichEdit.Demos
#Region "AutoCorrectModule"
    Partial Public Class AutoCorrectModule
        Inherits DevExpress.XtraRichEdit.Demos.TutorialControl

        Public Sub New()
            InitializeComponent()
            SpellCheckerHelper.AddDictionaries(sharedDictionaryStorage1)
            OpenXmlLoadHelper.Load("AutoCorrect.docx", richEditControl)
            CType(New RichEditDemoExceptionsHandler(richEditControl), RichEditDemoExceptionsHandler).Install()

            richEditControl.Options.AutoCorrect.CorrectTwoInitialCapitals = True
            richEditControl.Options.AutoCorrect.UseSpellCheckerSuggestions = True

            Dim service As IAutoCorrectService = richEditControl.GetService(Of IAutoCorrectService)()
            If service IsNot Nothing Then
                Dim replaceTable As New AutoCorrectReplaceInfoCollection()
                replaceTable.Add("(C)", "©")
                replaceTable.Add(New AutoCorrectReplaceInfo(":)", ResourceImageHelper.CreateBitmapFromResources("smile.png", Me.GetType().Assembly)))
                replaceTable.Add("pctus", "Please do not hesitate to contact us again in case of any further questions.")
                replaceTable.Add("wnwd", "well-nourished, well-developed")
                service.SetReplaceTable(replaceTable)
            End If

            richEditControl.Focus()
        End Sub

#Region "Properties"
        Public Overrides ReadOnly Property PrintingRichEditControl() As RichEditControl
            Get
                Return richEditControl
            End Get
        End Property
#End Region

        Protected Overrides Sub DoShow()
            MyBase.DoShow()
            richEditControl.Focus()
        End Sub

        Private Sub edtReplaceAsYouType_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            richEditControl.Options.AutoCorrect.ReplaceTextAsYouType = edtReplaceAsYouType.Checked
            richEditControl.Focus()
        End Sub

        Private Sub edtDetectUrls_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            richEditControl.Options.AutoCorrect.DetectUrls = edtDetectUrls.Checked
            richEditControl.Focus()
        End Sub
        Private Sub edtCorrectTwoInitialCapitals_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            richEditControl.Options.AutoCorrect.CorrectTwoInitialCapitals = edtCorrectTwoInitialCapitals.Checked
            richEditControl.Focus()
        End Sub
        Private Sub edtUseSpellCheckerSuggestions_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            richEditControl.Options.AutoCorrect.UseSpellCheckerSuggestions = edtUseSpellCheckerSuggestions.Checked
            richEditControl.Focus()
        End Sub

        Private Sub richEditControl_AutoCorrect(ByVal sender As Object, ByVal e As AutoCorrectEventArgs)
            Dim info As AutoCorrectInfo = e.AutoCorrectInfo
            e.AutoCorrectInfo = Nothing

            If (Not edtCustomAutoCorrect.Checked) Then
                Return
            End If

            If info.Text.Length <= 0 OrElse info.Text(0) <> "%"c Then
                Return
            End If
            Do
                If (Not info.DecrementStartPosition()) Then
                    Return
                End If

                If IsSeparator(info.Text(0)) Then
                    Return
                End If

                If info.Text(0) = "%"c Then
                    Dim replaceString As String = CalculateFunction(info.Text)
                    If (Not String.IsNullOrEmpty(replaceString)) Then
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
                Dim value As Integer
                If Int32.TryParse(name.Substring(1, name.Length - 2), value) Then
                    Dim converter As OrdinalBasedNumberConverter = OrdinalBasedNumberConverter.CreateConverter(NumberingFormat.CardinalText, LanguageId.English)
                    Return converter.ConvertNumber(value)
                End If
            End If

            Select Case name
                Case "%date%"
                    Return DateTime.Now.ToString(CultureInfo.CurrentCulture.DateTimeFormat.ShortDatePattern)
                Case "%time%"
                    Return DateTime.Now.ToString(CultureInfo.CurrentCulture.DateTimeFormat.ShortTimePattern)
                Case "%bye%"
                    Return "Yours sincerely," & Constants.vbCrLf & "David B. Smith"
                Case Else
                    Return String.Empty
            End Select
        End Function
        Private Function IsSeparator(ByVal ch As Char) As Boolean
            Return ch <> "%"c AndAlso (ch = ControlChars.Cr OrElse ch = ControlChars.Lf OrElse Char.IsPunctuation(ch) OrElse Char.IsSeparator(ch) OrElse Char.IsWhiteSpace(ch))
        End Function
    End Class
#End Region
End Namespace
