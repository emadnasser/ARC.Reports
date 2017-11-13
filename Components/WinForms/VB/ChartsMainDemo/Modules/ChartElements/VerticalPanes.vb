Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.Utils.Menu

Namespace DevExpress.XtraCharts.Demos.ChartElements
	Partial Public Class VerticalPanesDemo
		Inherits ChartDemoBase2D
		Public Overrides ReadOnly Property ChartControl() As ChartControl
			Get
				Return chart
			End Get
		End Property

		Public Sub New()
			InitializeComponent()
		End Sub

		Protected Overrides Function ConstructPopupMenu(ByVal obj As Object, ByVal chartControl As ChartControl) As DXPopupMenu
			Return DXMenuHelper.ConstructPaneMenu(obj, chartControl)
		End Function
	End Class
End Namespace

