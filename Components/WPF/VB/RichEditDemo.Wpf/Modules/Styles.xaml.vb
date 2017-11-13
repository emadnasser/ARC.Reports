Imports System

Namespace RichEditDemo
    Partial Public Class Styles
        Inherits RichEditDemoModule

        Public Sub New()
            InitializeComponent()
            RtfLoadHelper.Load("Styles.rtf", richEdit)
        End Sub
    End Class
End Namespace
