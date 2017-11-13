Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.XtraRichEdit.Services

Namespace DevExpress.XtraRichEdit.Demos
	Partial Public Class LineNumberingModule
		Inherits DevExpress.XtraRichEdit.Demos.TutorialControl
		Public Sub New()
			InitializeComponent()
			OpenXmlLoadHelper.Load("LineNumbering.docx", richEditControl)
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
            ribbonControl1.SelectedPage = pageLayoutRibbonPage1
        End Sub
	End Class
End Namespace
