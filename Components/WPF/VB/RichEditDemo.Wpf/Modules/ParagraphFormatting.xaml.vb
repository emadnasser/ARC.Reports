Imports System

Namespace RichEditDemo
    Partial Public Class ParagraphFormatting
        Inherits RichEditDemoModule

        Public Sub New()
            InitializeComponent()
            RtfLoadHelper.Load("ParagraphFormatting.rtf", richEdit)
            ribbonControl1.SelectedPage = pageHome
        End Sub
    End Class
End Namespace
