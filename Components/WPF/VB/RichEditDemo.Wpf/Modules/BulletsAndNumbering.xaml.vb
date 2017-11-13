Imports System

Namespace RichEditDemo
    Partial Public Class BulletsAndNumbering
        Inherits RichEditDemoModule

        Public Sub New()
            InitializeComponent()
            RtfLoadHelper.Load("BulletsAndNumbering.rtf", richEdit)
            ribbonControl1.SelectedPage = pageHome
        End Sub
    End Class
End Namespace
