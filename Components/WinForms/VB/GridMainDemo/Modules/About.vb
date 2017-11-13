Imports System.Collections
Imports System.ComponentModel

Imports DevExpress.Tutorials


Namespace DevExpress.XtraGrid.Demos
	Partial Public Class About
        Inherits ucOverviewPage

		Public Sub New()
			' This call is required by the Windows Form Designer.
			InitializeComponent()

			' TODO: Add any initialization after the InitializeComponent call
        End Sub
        Protected Overrides ReadOnly Property Awards As Image
            Get
                Return DevExpress.Tutorials.Properties.Resources.Awards
            End Get
        End Property

        Protected Overrides ReadOnly Property Line1Text As String
            Get
                Return "When only the best grid will do."
            End Get
        End Property

        Protected Overrides ReadOnly Property Line2Text As String
            Get
                Return "Voted #1 six times by readers of Visual Studio Magazine."
            End Get
        End Property

        Protected Overrides ReadOnly Property Line3Text As String
            Get
                Return "Your peers say the XtraGrid is #1."
            End Get
        End Property

        Protected Overrides ReadOnly Property Line4Text As String
            Get
                Return "Try it yourself and see why."
            End Get
        End Property

    End Class
End Namespace

