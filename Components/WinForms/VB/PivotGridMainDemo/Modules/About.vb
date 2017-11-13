Imports Microsoft.VisualBasic
Imports DevExpress.Tutorials
Imports DevExpress.Utils
Imports System
Imports System.Drawing

Namespace DevExpress.XtraPivotGrid.Demos.Modules
	Partial Public Class About
        Inherits ucOverviewPage
		Public Sub New()
			' This call is required by the Windows Form Designer.
			InitializeComponent()

			' TODO: Add any initialization after the InitializeComponent call
		End Sub
        Protected Overrides ReadOnly Property Line1Text() As String
            Get
                Return "The XtraPivotGrid Suite"
            End Get
        End Property
        Protected Overrides ReadOnly Property Line2Text() As String
            Get
                Return "Multi-dimensional data analysis and data mining for the WinForms platform."
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
                Return DevExpress.Utils.About.ProductKind.DXperienceWin
            End Get
        End Property
	End Class
End Namespace

