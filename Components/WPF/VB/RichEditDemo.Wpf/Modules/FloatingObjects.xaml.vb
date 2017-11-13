Imports System
Imports DevExpress.XtraRichEdit
Imports DevExpress.XtraSpellChecker
Imports DevExpress.Xpf.Ribbon
Imports DevExpress.Xpf.SpellChecker

Namespace RichEditDemo
    Partial Public Class FloatingObjects
        Inherits RichEditDemoModule

        Public Sub New()
            InitializeComponent()
            OpenXmlLoadHelper.Load("FloatingObjects.docx", richEdit)
        End Sub
    End Class
End Namespace
