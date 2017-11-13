Imports Microsoft.VisualBasic
Imports System

Namespace DevExpress.XtraRichEdit.Demos
    Partial Public Class TablesModule
        Inherits DevExpress.XtraRichEdit.Demos.TutorialControl
        Public Sub New()
            InitializeComponent()
            OpenXmlLoadHelper.Load("ActiveCustomers.docx", richEditControl)
            CType(New RichEditDemoExceptionsHandler(richEditControl), RichEditDemoExceptionsHandler).Install()
        End Sub

        Public Overrides ReadOnly Property PrintingRichEditControl() As RichEditControl
            Get
                Return richEditControl
            End Get
        End Property

        Protected Overrides Sub DoShow()
            MyBase.DoShow()
            richEditControl.Focus()
        End Sub
    End Class
End Namespace
