Imports System

Namespace RichEditDemo
    Partial Public Class CharacterFormatting
        Inherits RichEditDemoModule

        Public Sub New()
            InitializeComponent()
            RtfLoadHelper.Load("CharacterFormatting.rtf", richEdit)
            ribbonControl1.SelectedPage = pageHome
        End Sub
    End Class
End Namespace
