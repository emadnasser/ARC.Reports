Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.Utils
Imports DevExpress.Utils.Menu

Namespace DevExpress.XtraCharts.Demos.AdvancedViews
	Partial Public Class GanttSideBySideDemo
		Inherits ChartDemoBase2D
		Private chart As ChartControl
		Protected Overrides ReadOnly Property CrosshairEnabled() As DefaultBoolean
			Get
				Return DefaultBoolean.False
			End Get
		End Property
		Public Overrides ReadOnly Property ChartControl() As ChartControl
			Get
				Return chart
			End Get
		End Property

		Public Sub New()
			InitializeComponent()
		End Sub

		Protected Overrides Sub InitControls()
			MyBase.InitControls()
			ShowLabels = False
		End Sub
		Protected Overrides Function ConstructPopupMenu(ByVal obj As Object, ByVal chartControl As ChartControl) As DXPopupMenu
			Return DXMenuHelper.ConstructSideBySideGanttMenu(obj, chartControl)
		End Function
	End Class
End Namespace

