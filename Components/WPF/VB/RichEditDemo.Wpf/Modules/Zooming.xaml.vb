Imports System

Namespace RichEditDemo
    Partial Public Class Zooming
        Inherits RichEditDemoModule

        Public Sub New()
            InitializeComponent()
            RtfLoadHelper.Load("Zoom.rtf", richEdit)
            ribbonControl1.SelectedPage = pageView
        End Sub
    End Class
End Namespace
