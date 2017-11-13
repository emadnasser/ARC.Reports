Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Data
Imports System
Imports System.Globalization
Imports DevExpress.Xpf.Editors
Imports DevExpress.XtraSpellChecker
Imports DevExpress.XtraRichEdit

Namespace SpellCheckerDemo
    Partial Public Class DXRichEdit
        Inherits SpellCheckerDemoModule

        Public Sub New()
            InitializeComponent()
            DocumentLoadHelper.Load("SpellChecker.rtf", DocumentFormat.Rtf, richEdit)
        End Sub

        Private Sub richEdit_Loaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
            SpellChecker.SpellingFormType = SpellingFormType.Word
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
