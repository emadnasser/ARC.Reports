Imports System
Imports DevExpress.XtraRichEdit
Imports DevExpress.XtraSpellChecker
Imports DevExpress.Xpf.Ribbon
Imports DevExpress.Xpf.SpellChecker

Namespace RichEditDemo
    Partial Public Class LineNumbering
        Inherits RichEditDemoModule

        Public Sub New()
            InitializeComponent()
            OpenXmlLoadHelper.Load("LineNumbering.docx", richEdit)
        End Sub

        Private Sub richEdit_Loaded(ByVal sender As Object, ByVal e As System.Windows.RoutedEventArgs)
            richEdit.Views.DraftView.Padding = New System.Windows.Forms.Padding(60, 4, 0, 0)
            richEdit.Views.SimpleView.Padding = New System.Windows.Forms.Padding(60, 4, 0, 0)

            richEdit.Views.DraftView.AllowDisplayLineNumbers = True
            richEdit.Views.SimpleView.AllowDisplayLineNumbers = True
        End Sub
    End Class
End Namespace
