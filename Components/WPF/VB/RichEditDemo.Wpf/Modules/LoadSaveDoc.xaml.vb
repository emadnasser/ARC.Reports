Imports System

Namespace RichEditDemo
    Partial Public Class LoadSaveDoc
        Inherits RichEditDemoModule

        Public Sub New()
            InitializeComponent()
            DocLoadHelper.Load("DocLoading.doc", richEdit)
        End Sub
    End Class
End Namespace
