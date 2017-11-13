Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Reflection
Imports DevExpress.Utils.About
Imports DevExpress.Tutorials
Imports DevExpress.Utils

Namespace DashboardMainDemo.Modules
	Partial Public Class About
		Inherits ucOverviewPage
		Public Sub New()
			InitializeComponent()
		End Sub

		Protected Overrides ReadOnly Property Awards() As Image
			Get
				Return DevExpress.Tutorials.Properties.Resources.Awards_universal
			End Get
		End Property
		Protected Overrides ReadOnly Property Line1Text() As String
			Get
				Return "DevExpress Dashboard"
			End Get
		End Property
		Protected Overrides ReadOnly Property Line2Text() As String
			Get
				Return "Create elegant WinForms decision support systems with absolute ease."
			End Get
		End Property
		Protected Overrides ReadOnly Property Line3Text() As String
			Get
				Return "DevExpress Dashboard ships as part of the Universal Subscription."
			End Get
		End Property
		Protected Overrides ReadOnly Property Line4Text() As String
			Get
				Return "Voted best Component Set by readers of DevPro Magazine in 2013."
			End Get
		End Property
		Protected Overrides ReadOnly Property ProductKind() As ProductKind
			Get
				Return ProductKind.Dashboard
			End Get
		End Property
	End Class
End Namespace
