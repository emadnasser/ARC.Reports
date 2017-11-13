Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.XtraEditors

Namespace DevExpress.XtraCharts.Demos.ResolveLabelsOverlapping
	Partial Public Class ResolveOverlappingForLineDemo
		Inherits ChartDemoBase2D
		Private ReadOnly Property Label() As PointSeriesLabel
			Get
				If chart.Series.Count <> 0 Then
					Return TryCast(chart.Series(0).Label, PointSeriesLabel)
				Else
					Return Nothing
				End If
			End Get
		End Property

		Public Overrides ReadOnly Property ChartControl() As ChartControl
			Get
				Return chart
			End Get
		End Property

		Public Sub New()
			InitializeComponent()
			CheckEditShowLabelsVisible = False
		End Sub

		Private Sub spinLineLength_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles spinLineLength.EditValueChanged
			If Label IsNot Nothing Then
				Label.LineLength = Convert.ToInt32(spinLineLength.EditValue)
			End If
		End Sub
		Private Sub spinAngle_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles spinAngle.EditValueChanged
			If Label IsNot Nothing Then
				Label.Angle = Convert.ToInt32(spinAngle.EditValue)
			End If
		End Sub
		Private Sub cbMode_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbMode.SelectedIndexChanged
			If Label IsNot Nothing Then
				Try
					Label.ResolveOverlappingMode = CType(cbMode.SelectedIndex, ResolveOverlappingMode)
				Catch exception As Exception
					XtraMessageBox.Show(LookAndFeel.ActiveLookAndFeel, exception.Message, "Resolve Overlapping Mode")
				End Try
				UpdateControls()
			End If
		End Sub
		Private Sub spinIndent_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles spinIndent.EditValueChanged
			If Label IsNot Nothing Then
				Label.ResolveOverlappingMinIndent = Convert.ToInt32(spinIndent.EditValue)
			End If
		End Sub

		Public Overrides Sub UpdateControls()
			MyBase.UpdateControls()
			If Label IsNot Nothing Then
				labelIndent.Enabled = Label.ResolveOverlappingMode <> ResolveOverlappingMode.None
				spinIndent.Enabled = labelIndent.Enabled
				spinIndent.EditValue = Label.ResolveOverlappingMinIndent
				cbMode.SelectedIndex = CInt(Fix(Label.ResolveOverlappingMode))
				spinLineLength.Value = Label.LineLength
				spinAngle.Value = Label.Angle
				Dim angleDisabled As Boolean = Label.ResolveOverlappingMode = ResolveOverlappingMode.JustifyAllAroundPoint
				spinAngle.Enabled = Not angleDisabled
				labelControlAngle.Enabled = Not angleDisabled
			End If
		End Sub
	End Class
End Namespace
