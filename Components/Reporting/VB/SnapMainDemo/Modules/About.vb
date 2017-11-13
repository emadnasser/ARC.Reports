Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports DevExpress.Tutorials
Imports System.Drawing

Namespace SnapDemos.Modules
	Partial Public Class About
		Inherits ucOverviewPage

		Public Sub New()
			' This call is required by the Windows Form Designer.
			InitializeComponent()

			' TODO: Add any initialization after the InitializeComponent call
		End Sub

		Protected Overrides ReadOnly Property Line1Text() As String
			Get
				Return "Snap Reports Suite"
			End Get
		End Property
		Protected Overrides ReadOnly Property Line2Text() As String
			Get
				Return "Word® inspired WYSIWYG reporting for the WinForms platform."
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

		Protected Overrides ReadOnly Property ProductKind() As DevExpress.Utils.About.ProductKind
			Get
				Return DevExpress.Utils.About.ProductKind.Snap
			End Get
		End Property
	End Class
End Namespace
