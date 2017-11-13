Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.XtraCharts.Demos.PointLineViews
	Partial Public Class StackedLine3dDemo
		Inherits Line3dDemo
		Private chart As ChartControl

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
			ChartControl.DataSource = DevAV.GetSalesByLast10Years()
		End Sub
	End Class
End Namespace
