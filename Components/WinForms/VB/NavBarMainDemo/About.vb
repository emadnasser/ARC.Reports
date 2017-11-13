Imports System.Collections
Imports System.ComponentModel
Imports DevExpress.Tutorials

Namespace DevExpress.XtraNavBar.Demos
	Partial Public Class About
		Inherits ucOverviewPage
		Protected Overrides ReadOnly Property Line1Text() As String
			Get
				Return "The XtraNavBar Suite"
			End Get
		End Property
		'protected override string Line2Text { get { return "The most comprehensive collection of editors for the WinForms platform."; } }
		Protected Overrides ReadOnly Property Line2Text() As String
			Get
				Return String.Empty
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
