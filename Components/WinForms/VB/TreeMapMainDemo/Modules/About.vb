Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.Tutorials

Namespace DevExpress.XtraTreeMap.Demos
	Partial Public Class About
		Inherits ucOverviewPage
		Public Sub New()
			InitializeComponent()
		End Sub
		Protected Overrides ReadOnly Property Line1Text() As String
			Get
				Return "The XtraTreeMap Suite"
			End Get
		End Property
		Protected Overrides ReadOnly Property Line2Text() As String
			Get
				Return "Take your users where they want to go."
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
