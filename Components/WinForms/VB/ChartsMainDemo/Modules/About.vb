Imports Microsoft.VisualBasic
Imports System.Drawing
Imports DevExpress.Utils
Imports DevExpress.Utils.About
Imports DevExpress.Tutorials

Namespace DevExpress.XtraCharts.Demos
	Partial Public Class About
		Inherits ucOverviewPage
		Public Sub New()
			InitializeComponent()
		End Sub
		Protected Overrides ReadOnly Property Line1Text() As String
			Get
				Return "The XtraCharts Suite"
			End Get
		End Property
		Protected Overrides ReadOnly Property Line2Text() As String
			Get
				Return "Elegant and fully customizable 2D/3D charting for the WinForms platform."
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
