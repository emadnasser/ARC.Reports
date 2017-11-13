Imports System

Namespace RichEditDemo
    Partial Public Class Tables
        Inherits RichEditDemoModule

        Public Sub New()
            InitializeComponent()
            OpenXmlLoadHelper.Load("ActiveCustomers.docx", richEdit)
        End Sub
    End Class
End Namespace
