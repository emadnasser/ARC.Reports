Imports DevExpress.Utils
Imports DevExpress.Utils.About
Imports DevExpress.Tutorials


Namespace DevExpress.XtraEditors.Demos
	Partial Public Class About
		Inherits ucOverviewPage

		Protected Overrides ReadOnly Property Line1Text() As String
			Get
				Return "The XtraEditors Suite"
			End Get
		End Property
		Protected Overrides ReadOnly Property Line2Text() As String
			Get
				Return "The most comprehensive collection of editors for the WinForms platform."
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
