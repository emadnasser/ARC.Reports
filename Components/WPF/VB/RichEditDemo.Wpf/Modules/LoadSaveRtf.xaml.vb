Imports System

Namespace RichEditDemo
    Partial Public Class LoadSaveRtf
        Inherits RichEditDemoModule

        Public Sub New()
            InitializeComponent()
            RtfLoadHelper.Load("CharacterFormatting.rtf", richEdit)
        End Sub
    End Class
End Namespace
