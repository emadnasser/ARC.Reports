Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.XtraRichEdit.Services

Namespace DevExpress.XtraRichEdit.Demos
	Partial Public Class FloatingObjectsModule
		Inherits DevExpress.XtraRichEdit.Demos.TutorialControl
		Public Sub New()
			InitializeComponent()
			OpenXmlLoadHelper.Load("FloatingObjects.docx", richEditControl)
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
            ribbonControl1.SelectedPage = homeRibbonPage1
		End Sub

		Private Sub richEditControl_SelectionChanged(ByVal sender As Object, ByVal e As EventArgs) Handles richEditControl.SelectionChanged
            floatingPictureToolsRibbonPageCategory1.Visible = richEditControl.IsFloatingObjectSelected
		End Sub
	End Class
End Namespace
