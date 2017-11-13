Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraRichEdit.Internal

Namespace DevExpress.XtraRichEdit.Demos
	Partial Public Class CharacterFormattingModule
		Inherits DevExpress.XtraRichEdit.Demos.TutorialControl
		Public Sub New()
			InitializeComponent()
            RtfLoadHelper.Load("CharacterFormatting.rtf", richEditControl)
            CType(New RichEditDemoExceptionsHandler(richEditControl), RichEditDemoExceptionsHandler).Install()
			richEditControl.Focus()
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
