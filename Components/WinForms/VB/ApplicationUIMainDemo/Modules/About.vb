Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.Tutorials

Namespace DevExpress.ApplicationUI.Demos
	Partial Public Class About
		Inherits ucOverviewPage
		Public Sub New()
			InitializeComponent()
		End Sub
		Protected Overrides ReadOnly Property Line1Text() As String
			Get
				Return "DevExpress Application UI Layout Controls"
			End Get
		End Property
		Protected Overrides ReadOnly Property Line2Text() As String
			Get
				Return "Elegant and fully customizable UI layout tools for the WinForms platform."
			End Get
		End Property
		Protected Overrides ReadOnly Property Line3Text() As String
			Get
				Return "DevExpress Desktop Controls"
			End Get
		End Property
		Protected Overrides ReadOnly Property Line4Text() As String
			Get
                Return votedVSM
			End Get
		End Property
	End Class
End Namespace
