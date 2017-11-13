Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Data
Imports System
Imports System.Globalization
Imports DevExpress.Xpf.Editors
Imports DevExpress.XtraSpellChecker
Imports DevExpress.XtraRichEdit
Imports DevExpress.Xpf.SpellChecker

Namespace SpellCheckerDemo
    Partial Public Class HunspellDictionaries
        Inherits SpellCheckerDemoModule

        Public Sub New()
            InitializeComponent()

            DocumentLoadHelper.Load("HunspellDictionaries.docx", DocumentFormat.OpenXml, richEdit)
        End Sub

        Protected Overrides Function CreateSpellCheckerControl() As SpellChecker
            Dim result As New SpellChecker()
            SpellCheckerHelper.RegisterHunspellDictionaries(result)
            result.Culture = CultureInfo.InvariantCulture
            Return result
        End Function

        Private Sub richEdit_Loaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
            richEdit.SpellChecker = SpellChecker
            ApplySpellCheckMode()
        End Sub
        Private Sub Button_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
            SpellChecker.Check(richEdit)
        End Sub
        Private Sub edtCheckAsYouType_EditValueChanged(ByVal sender As Object, ByVal e As EditValueChangedEventArgs)
            ApplySpellCheckMode()
        End Sub
        Private Overloads Sub ApplySpellCheckMode()
            If edtCheckAsYouType.IsChecked = True Then
                SpellChecker.SpellCheckMode = SpellCheckMode.AsYouType
            Else
                SpellChecker.SpellCheckMode = SpellCheckMode.OnDemand
            End If
        End Sub
    End Class
End Namespace
