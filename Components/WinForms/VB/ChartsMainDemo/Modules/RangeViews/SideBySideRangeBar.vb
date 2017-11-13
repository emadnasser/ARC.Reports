Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.Utils

Namespace DevExpress.XtraCharts.Demos.RangeViews
	Partial Public Class SideBySideRangeBarDemo
		Inherits ChartDemoBase2D
		Private chart As ChartControl

		Public Overrides ReadOnly Property ChartControl() As ChartControl
			Get
				Return chart
			End Get
		End Property
		Protected Overrides ReadOnly Property CrosshairEnabled() As DefaultBoolean
			Get
				Return DefaultBoolean.False
			End Get
		End Property
		Protected Overrides ReadOnly Property ToolTipEnabled() As DefaultBoolean
			Get
				Return DefaultBoolean.True
			End Get
		End Property

		Public Sub New()
			InitializeComponent()
		End Sub

		Protected Overrides Sub InitControls()
			MyBase.InitControls()
			ShowLabels = False
			ChartControl.Series(0).DataSource = SourceOfEnergy.GetEuropeBrentPrices()
			ChartControl.Series(1).DataSource = SourceOfEnergy.GetOkWtiPrices()
		End Sub

	End Class
End Namespace
