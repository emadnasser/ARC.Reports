Imports System

Namespace RichEditDemo
    Partial Public Class Sections
        Inherits RichEditDemoModule

        Public Sub New()
            InitializeComponent()
            RtfLoadHelper.Load("Sections.rtf", richEdit)
            ribbonControl1.SelectedPage = pagePageLayout
        End Sub
    End Class
End Namespace
