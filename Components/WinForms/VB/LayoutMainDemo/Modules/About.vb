Imports Microsoft.VisualBasic
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.Tutorials


Namespace DevExpress.XtraLayout.Demos
	Partial Public Class About
        Inherits ucOverviewPage
		Public Sub New()
			' This call is required by the Windows Form Designer.
			InitializeComponent()

			' TODO: Add any initialization after the InitializeComponent call
        End Sub
        Protected Overrides ReadOnly Property Line1Text As String
            Get
                Return "The XtraLayout Control"
            End Get
        End Property
        Protected Overrides ReadOnly Property Line2Text As String
            Get
                Return "Elegant and fully customizable UI layout tools for the WinForms platform."
            End Get
        End Property
        Protected Overrides ReadOnly Property Line3Text As String
            Get
                Return "DevExpress Desktop Controls"
            End Get
        End Property
        Protected Overrides ReadOnly Property Line4Text As String
            Get
                Return votedVSM
            End Get
        End Property
    End Class
End Namespace

