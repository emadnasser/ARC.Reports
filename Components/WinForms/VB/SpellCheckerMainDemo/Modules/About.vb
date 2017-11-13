Imports Microsoft.VisualBasic
Imports System.Drawing
Imports DevExpress.Utils
Imports DevExpress.Utils.About
Imports DevExpress.Tutorials


Namespace DevExpress.XtraSpellChecker.Demos
	Partial Public Class About
		Inherits ucOverviewPage
		Protected Overrides ReadOnly Property Line1Text() As String
			Get
				Return "The XtraSpellChecker Suite"
			End Get
		End Property
		Protected Overrides ReadOnly Property Line2Text() As String
			Get
				Return "Office Inspired Spell Checking Controls."
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
