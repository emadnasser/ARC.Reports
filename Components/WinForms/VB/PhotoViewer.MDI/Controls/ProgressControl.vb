Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.XtraEditors

Namespace PhotoViewer
	Partial Public Class ProgressControl
		Inherits XtraUserControl
		Public Sub New()
			InitializeComponent()
		End Sub
		Public Property Maximum() As Integer
			Get
				Return progressBar.Properties.Maximum
			End Get
			Set(ByVal value As Integer)
				progressBar.Properties.Maximum = value
			End Set
		End Property
		Public Property Value() As Integer
			Get
				Return CInt(Fix(progressBar.EditValue))
			End Get
			Set(ByVal value As Integer)
				progressBar.EditValue = value
			End Set
		End Property
		Public Property ProgressText() As String
			Get
				Return label.Text
			End Get
			Set(ByVal value As String)
				label.Text = value
			End Set
		End Property
	End Class
End Namespace
