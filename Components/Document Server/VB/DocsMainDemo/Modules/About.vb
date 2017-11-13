Imports Microsoft.VisualBasic
Imports System.Drawing
Imports DevExpress.Tutorials
Imports DevExpress.Utils.About

Namespace DevExpress.Docs.Demos
	Partial Public Class About
		Inherits ucOverviewPage
		Public Sub New()
			InitializeComponent()
		End Sub

		Protected Overrides ReadOnly Property Line1Text() As String
			Get
				Return ".NET Document Server"
			End Get
		End Property
		Protected Overrides ReadOnly Property Line2Text() As String
			Get
				Return "Read and Write XLSx, XLS, DOCx, DOC and PDF files"
			End Get
		End Property
		Protected Overrides ReadOnly Property Line3Text() As String
			Get
				Return "Create Snap Reports, Generate Barcodes and Compressed Archives"
			End Get
		End Property
		Protected Overrides ReadOnly Property Line4Text() As String
			Get
				Return votedVSM
			End Get
		End Property
	End Class
End Namespace

