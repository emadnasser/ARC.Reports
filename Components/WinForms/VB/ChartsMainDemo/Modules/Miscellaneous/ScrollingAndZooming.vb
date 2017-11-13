Imports Microsoft.VisualBasic
Imports System

Namespace DevExpress.XtraCharts.Demos.Miscellaneous
	Partial Public Class ScrollingAndZoomingDemo
		Inherits ChartDemoBase2D
		Private chart As ChartControl
		Private AxisXRangeSpan As TimeSpan
		Private AxisYRangeSpan As Double

		Private ReadOnly Property Diagram() As XYDiagram
			Get
				Return TryCast(chart.Diagram, XYDiagram)
			End Get
		End Property

		Public Overrides ReadOnly Property ChartControl() As ChartControl
			Get
				Return Me.chart
			End Get
		End Property

		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub btnRestoreView_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnRestoreView.Click
			If Diagram IsNot Nothing Then
				Diagram.AxisX.VisualRange.MinValue = Diagram.AxisX.WholeRange.MinValue
				Diagram.AxisX.VisualRange.MaxValue = CDate(Diagram.AxisX.WholeRange.MinValue) + AxisXRangeSpan
				Diagram.AxisY.VisualRange.MinValue = Diagram.AxisY.WholeRange.MinValue
				Diagram.AxisY.VisualRange.MaxValue = CDbl(Diagram.AxisY.WholeRange.MinValue) + AxisYRangeSpan
			End If
		End Sub
		Private Sub cbHorAlign_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbHorAlign.SelectedIndexChanged
			If Diagram IsNot Nothing Then
				Diagram.DefaultPane.ScrollBarOptions.XAxisScrollBarAlignment = CType(cbHorAlign.SelectedIndex, ScrollBarAlignment)
			End If
		End Sub
		Private Sub cbVertAlign_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbVertAlign.SelectedIndexChanged
			If Diagram IsNot Nothing Then
				Diagram.DefaultPane.ScrollBarOptions.YAxisScrollBarAlignment = CType(cbVertAlign.SelectedIndex, ScrollBarAlignment)
			End If
		End Sub
		Private Sub cbEnableAxisXScrolling_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbEnableAxisXScrolling.CheckedChanged
			If Diagram IsNot Nothing Then
				Diagram.EnableAxisXScrolling = cbEnableAxisXScrolling.Checked
				lblHorizontal.Enabled = Diagram.EnableAxisXScrolling
				cbHorAlign.Enabled = Diagram.EnableAxisXScrolling
			End If
		End Sub
		Private Sub cbEnableAxisXZooming_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbEnableAxisXZooming.CheckedChanged
			If Diagram IsNot Nothing Then
				Diagram.EnableAxisXZooming = cbEnableAxisXZooming.Checked
			End If
		End Sub
		Private Sub cbEnableAxisYScrolling_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbEnableAxisYScrolling.CheckedChanged
			If Diagram IsNot Nothing Then
				Diagram.EnableAxisYScrolling = cbEnableAxisYScrolling.Checked
				lblVertical.Enabled = Diagram.EnableAxisYScrolling
				cbVertAlign.Enabled = Diagram.EnableAxisYScrolling
			End If
		End Sub
		Private Sub cbEnableAxisYZooming_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbEnableAxisYZooming.CheckedChanged
			If Diagram IsNot Nothing Then
				Diagram.EnableAxisYZooming = cbEnableAxisYZooming.Checked
			End If
		End Sub
		Protected Overrides Sub InitControls()
			MyBase.InitControls()
			ChartControl.Series(0).DataSource = SourceOfEnergy.GetGasPrices()
			Diagram.AxisX.VisualRange.MaxValue = New DateTime(2009, 6, 10)
			Diagram.AxisY.VisualRange.MaxValue = 10.6
			AxisXRangeSpan = CDate(Diagram.AxisX.VisualRange.MaxValue) - CDate(Diagram.AxisX.VisualRange.MinValue)
			AxisYRangeSpan = CDbl(Diagram.AxisY.VisualRange.MaxValue) - CDbl(Diagram.AxisY.VisualRange.MinValue)
		End Sub

		Public Overrides Sub UpdateControls()
			MyBase.UpdateControls()
			If Diagram IsNot Nothing Then
				cbEnableAxisXScrolling.Checked = Diagram.EnableAxisXScrolling
				cbEnableAxisYScrolling.Checked = Diagram.EnableAxisYScrolling
				cbEnableAxisXZooming.Checked = Diagram.EnableAxisXZooming
				cbEnableAxisYZooming.Checked = Diagram.EnableAxisYZooming
				cbVertAlign.SelectedIndex = CInt(Fix(Diagram.DefaultPane.ScrollBarOptions.YAxisScrollBarAlignment))
				cbHorAlign.SelectedIndex = CInt(Fix(Diagram.DefaultPane.ScrollBarOptions.XAxisScrollBarAlignment))
				lblHorizontal.Enabled = Diagram.EnableAxisXScrolling
				cbHorAlign.Enabled = Diagram.EnableAxisXScrolling
				lblVertical.Enabled = Diagram.EnableAxisYScrolling
				cbVertAlign.Enabled = Diagram.EnableAxisYScrolling
			End If
		End Sub
	End Class
End Namespace
