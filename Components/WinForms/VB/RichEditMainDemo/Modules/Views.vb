Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Text
Imports System.Windows.Forms

Namespace DevExpress.XtraRichEdit.Demos
	Partial Public Class ViewsModule
		Inherits DevExpress.XtraRichEdit.Demos.TutorialControl
		Public Sub New()
			InitializeComponent()
            RtfLoadHelper.Load("TextWithImages.rtf", richEditControl)
            CType(New RichEditDemoExceptionsHandler(richEditControl), RichEditDemoExceptionsHandler).Install()
		End Sub

		Public Overrides ReadOnly Property PrintingRichEditControl() As RichEditControl
			Get
				Return richEditControl
			End Get
		End Property

		Private Sub ViewsModule_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			rgrpViewType.EditValue = RichEditViewType.PrintLayout
		End Sub
		Private Sub rgrpViewType_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles rgrpViewType.SelectedIndexChanged
			richEditControl.ActiveViewType = CType(rgrpViewType.EditValue, RichEditViewType)
		End Sub
		Protected Overrides Sub DoShow()
			MyBase.DoShow()
			richEditControl.Focus()
		End Sub
		Private Sub richEditControl_ActiveViewChanged(ByVal sender As Object, ByVal e As EventArgs) Handles richEditControl.ActiveViewChanged
			rgrpViewType.EditValue = richEditControl.ActiveViewType
		End Sub
	End Class
End Namespace
