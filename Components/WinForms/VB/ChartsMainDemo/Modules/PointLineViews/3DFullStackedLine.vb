Imports Microsoft.VisualBasic
Imports System

Namespace DevExpress.XtraCharts.Demos.PointLineViews
	Partial Public Class FullStackedLine3dDemo
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

		Private Sub checkEditValueAsPercent_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkValueAsPercent.CheckedChanged
			ChartControl.SeriesTemplate.Label.TextPattern = If(Me.checkValueAsPercent.Checked, "{VP:P0}", "${V}M")
		End Sub

		Protected Overrides Sub InitControls()
			MyBase.InitControls()
			checkValueAsPercent.Checked = True
			ShowLabels = False
		End Sub
		Protected Overrides Sub InitDataSource()
			ChartControl.DataSource = DevAV.GetBranchesSales()
		End Sub
		Public Overrides Sub UpdateControls()
			MyBase.UpdateControls()
			Me.checkValueAsPercent.Enabled = ShowLabels
		End Sub
	End Class
End Namespace
