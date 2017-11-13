Imports Microsoft.VisualBasic
Imports System
Imports System.Windows.Forms

Namespace PhotoViewer
	Partial Public Class ProgressForm
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub
		Public ReadOnly Property ProgressControl() As ProgressControl
			Get
				Return progressControl1
			End Get
		End Property
		Protected Overrides Sub OnLoad(ByVal e As EventArgs)
			MyBase.OnLoad(e)
			CenterToParent()
		End Sub
	End Class
End Namespace
