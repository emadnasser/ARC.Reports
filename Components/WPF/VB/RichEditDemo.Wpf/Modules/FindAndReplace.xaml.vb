Imports System

Namespace RichEditDemo
    Partial Public Class FindAndReplace
        Inherits RichEditDemoModule

        Public Sub New()
            InitializeComponent()
            RtfLoadHelper.Load("Search.rtf", richEdit)
            ribbonControl1.SelectedPage = pageHome
        End Sub
    End Class
End Namespace
