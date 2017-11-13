Imports System

Namespace RichEditDemo
    Partial Public Class Views
        Inherits RichEditDemoModule

        Public Sub New()
            InitializeComponent()
            RtfLoadHelper.Load("TextWithImages.rtf", richEdit)
            ribbonControl1.SelectedPage = pageView
        End Sub
    End Class
End Namespace
