Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports DevExpress.Utils
Imports DevExpress.XtraEditors

Namespace DevExpress.XtraCharts.Demos.PieDoughnutViews
	Partial Public Class DoughnutDemo
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
				Return chart
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
		Private Sub checkEditValueAsPercent_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkEditValueAsPercent.CheckedChanged
			If ChartControl.Series.Count = 0 Then
				Return
			End If
			chart.Series(0).Label.TextPattern = If(Me.checkEditValueAsPercent.Checked, "{VP:P0}", "{V:F1}")
		End Sub
		Private Sub cbLabelPosition_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbLabelPosition.SelectedIndexChanged
			If ChartControl.Series.Count = 0 OrElse Not(TypeOf ChartControl.Series(0).Label Is DoughnutSeriesLabel) Then
				Return
			End If
			Dim label As DoughnutSeriesLabel = CType(ChartControl.Series(0).Label, DoughnutSeriesLabel)
			label.Position = CType(cbLabelPosition.SelectedIndex, PieSeriesLabelPosition)
			label.TextColor = If((label.Position = PieSeriesLabelPosition.Outside OrElse label.Position = PieSeriesLabelPosition.TwoColumns), Color.Empty, Color.Black)
		End Sub
		Private Sub cbExplodeMode_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbExplodeMode.SelectedIndexChanged
			If ChartControl.Series.Count > 0 Then
				Dim view As DoughnutSeriesView = TryCast(ChartControl.Series(0).View, DoughnutSeriesView)
				If view IsNot Nothing Then
					Dim mode As String = CStr(cbExplodeMode.SelectedItem)
					PieExplodingHelper.ApplyMode(view, mode)
				End If
			End If
		End Sub
		Private Sub txtHoleRadius_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtHoleRadius.EditValueChanged
			If ChartControl.Series.Count > 0 Then
				Dim view As DoughnutSeriesView = TryCast(ChartControl.Series(0).View, DoughnutSeriesView)
				If view IsNot Nothing Then
					view.HoleRadiusPercent = Convert.ToInt32(txtHoleRadius.EditValue)
				End If
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
				series.ToolTipPointPattern = "{A}: {V:0.0} M km" & ChrW(178)
			Next series
		End Sub

		Public Overrides Sub UpdateControls()
			MyBase.UpdateControls()
			If ChartControl.Series.Count > 0 Then
				Dim label As DoughnutSeriesLabel = TryCast(ChartControl.Series(0).Label, DoughnutSeriesLabel)
				If label IsNot Nothing Then
					cbLabelPosition.SelectedIndex = CInt(Fix(label.Position))
					checkEditValueAsPercent.Checked = ChartControl.Series(0).Label.TextPattern.Contains("VP")
					cbLabelPosition.Enabled = ShowLabels
					labelPosition.Enabled = ShowLabels
					checkEditValueAsPercent.Enabled = ShowLabels
					If TypeOf ChartControl.Series(0).View Is DoughnutSeriesView Then
						txtHoleRadius.EditValue = (CType(ChartControl.Series(0).View, DoughnutSeriesView)).HoleRadiusPercent
					End If
				End If
			End If
		End Sub
	End Class
End Namespace
