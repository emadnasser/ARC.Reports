Imports System

Namespace RichEditDemo
    Partial Public Class HeadersAndFooters
        Inherits RichEditDemoModule

        Public Sub New()
            InitializeComponent()
            OpenXmlLoadHelper.Load("HeadersFooters.docx", richEdit)
            ribbonControl1.SelectedPage = pageInsert
        End Sub
    End Class
End Namespace
