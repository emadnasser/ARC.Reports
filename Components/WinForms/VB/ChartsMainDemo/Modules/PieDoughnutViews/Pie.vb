Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports DevExpress.Utils
Imports DevExpress.XtraEditors

Namespace DevExpress.XtraCharts.Demos.PieDoughnutViews
	Partial Public Class PieDemo
		Inherits ChartDemoBase2D
		Private WithEvents chart As ChartControl
		Private WithEvents checkEditValueAsPercent As CheckEdit

		Protected Overrides ReadOnly Property ToolTipEnabled() As DefaultBoolean
			Get
				Return DefaultBoolean.True
			End Get
		End Property

		Public Overrides ReadOnly Property ChartControl() As ChartControl
			Get
				Return Me.chart
			End Get
		End Property

		Public Sub New()
			InitializeComponent()
			InitExplodeModeComboBox()
			cbLabelPosition.EditValue = "Radial"
		End Sub

		Private Sub InitExplodeModeComboBox()
			If ChartControl.Series.Count > 0 Then
				cbExplodeMode.Properties.Items.AddRange(PieExplodingHelper.CreateModeList(ChartControl.Series(0).Points, True))
			End If
			cbExplodeMode.SelectedIndex = 0
		End Sub
		Private Sub checkEditValueAsPercent_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkEditValueAsPercent.CheckedChanged
			If ChartControl.Series.Count > 0 Then
				chart.Series(0).Label.TextPattern = If(Me.checkEditValueAsPercent.Checked, "{VP:P0}", "{V:F1}")
			End If
		End Sub
		Private Sub cbLabelPosition_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbLabelPosition.SelectedIndexChanged
			If ChartControl.Series.Count = 0 Then
				Return
			End If
			Dim label As PieSeriesLabel = TryCast(chart.Series(0).Label, PieSeriesLabel)
			If label IsNot Nothing Then
				label.Position = CType(cbLabelPosition.SelectedIndex, PieSeriesLabelPosition)
				label.TextColor = If((label.Position = PieSeriesLabelPosition.Outside OrElse label.Position = PieSeriesLabelPosition.TwoColumns), Color.Empty, Color.Black)
			End If
		End Sub
		Private Sub cbExplodeMode_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbExplodeMode.SelectedIndexChanged
			If ChartControl.Series.Count = 0 Then
				Return
			End If
			Dim view As PieSeriesView = TryCast(chart.Series(0).View, PieSeriesView)
			If view IsNot Nothing Then
				Dim mode As String = CStr(cbExplodeMode.SelectedItem)
				PieExplodingHelper.ApplyMode(view, mode)
			End If
		End Sub
		Private Sub chart_PieSeriesPointExploded(ByVal sender As Object, ByVal e As PieSeriesPointExplodedEventArgs) Handles chart.PieSeriesPointExploded
			If e.Dragged Then
				cbExplodeMode.SelectedItem = PieExplodingHelper.Custom
			End If
		End Sub

		Protected Overrides Sub InitControls()
			MyBase.InitControls()
			ShowLabels = True
			For Each series As Series In chart.Series
				series.ToolTipPointPattern = "{A}: {V:0.0}M km" & ChrW(178)
			Next series
		End Sub

		Public Overrides Sub UpdateControls()
			MyBase.UpdateControls()
			If ChartControl.Series.Count = 0 Then
				Return
			End If
			Dim label As PieSeriesLabel = TryCast(chart.Series(0).Label, PieSeriesLabel)
			If label IsNot Nothing Then
				cbLabelPosition.SelectedIndex = CInt(Fix(label.Position))
				If chart.Series(0).Label.TextPattern IsNot Nothing Then
					checkEditValueAsPercent.Checked = chart.Series(0).Label.TextPattern.Contains("VP")
				Else
					checkEditValueAsPercent.Checked = False
				End If
				checkEditValueAsPercent.Enabled = ShowLabels
				cbLabelPosition.Enabled = ShowLabels
				labelPosition.Enabled = ShowLabels
			End If
		End Sub
	End Class
End Namespace
