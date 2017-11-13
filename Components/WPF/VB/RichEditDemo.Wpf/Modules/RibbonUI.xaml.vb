Imports System
Imports DevExpress.XtraRichEdit
Imports DevExpress.XtraSpellChecker
Imports DevExpress.Xpf.Ribbon
Imports DevExpress.Xpf.SpellChecker

Namespace RichEditDemo
    Partial Public Class RibbonUI
        Inherits RichEditDemoModule

        Private spellChecker As SpellChecker

        Public Sub New()
            InitializeComponent()
            Me.spellChecker = SpellChecking.InitializeSpellChecker()
            OpenXmlLoadHelper.Load("MovieRentals.docx", richEdit)
        End Sub
        Private Sub richEdit_Loaded(ByVal sender As Object, ByVal e As System.Windows.RoutedEventArgs)
            richEdit.SpellChecker = spellChecker
            spellChecker.SpellCheckMode = SpellCheckMode.AsYouType
        End Sub
    End Class
End Namespace
