Imports Microsoft.VisualBasic
Imports System
Imports System.Windows.Forms
Imports System.Drawing
Imports DevExpress.Tutorials
Imports DevExpress.Utils.About

Namespace DevExpress.XtraScheduler.Demos
	Partial Public Class About
		Inherits ucOverviewPage
		Public Sub New()
			InitializeComponent()
		End Sub

		Protected Overrides ReadOnly Property Line1Text() As String
			Get
				Return "The XtraScheduler Suite"
			End Get
		End Property
		Protected Overrides ReadOnly Property Line2Text() As String
			Get
				Return "Outlook® inspired scheduler and calendar control for the WinForms platform."
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

