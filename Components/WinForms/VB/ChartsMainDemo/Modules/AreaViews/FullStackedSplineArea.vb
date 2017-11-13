Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.XtraEditors

Namespace DevExpress.XtraCharts.Demos.AreaViews
	Partial Public Class FullStackedSplineAreaDemo
		Inherits ChartDemoBase2D
		Private chart As ChartControl
		Private WithEvents checkValueAsPercent As CheckEdit

		Public Overrides ReadOnly Property ChartControl() As ChartControl
			Get
				Return Me.chart
			End Get
		End Property

		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub checkValueAsPercent_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkValueAsPercent.CheckedChanged
			ChartControl.SeriesTemplate.Label.TextPattern = If(Me.checkValueAsPercent.Checked, "{VP:P0}", "${V}M")
		End Sub

		Protected Overrides Sub InitControls()
			MyBase.InitControls()
			Me.checkValueAsPercent.Checked = True
			ChartControl.DataSource = DevAV.GetBranchesSales()
		End Sub

		Public Overrides Sub UpdateControls()
			MyBase.UpdateControls()
			Me.checkValueAsPercent.Enabled = ShowLabels
		End Sub
	End Class
End Namespace
