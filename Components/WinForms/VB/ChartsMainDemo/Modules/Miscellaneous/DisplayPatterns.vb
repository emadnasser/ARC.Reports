Imports Microsoft.VisualBasic
Imports System
Imports System.Data.OleDb
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.XtraEditors

Namespace DevExpress.XtraCharts.Demos.Miscellaneous
	Partial Public Class DisplayPatternsDemo
		Inherits ChartDemoBase2D
		Private chart As ChartControl

		Private ReadOnly Property Series() As Series
			Get
				Return chart.Series(0)
			End Get
		End Property
		Private ReadOnly Property Diagram() As XYDiagram
			Get
				Return TryCast(chart.Diagram, XYDiagram)
			End Get
		End Property
		Private ReadOnly Property AxisX() As AxisX
			Get
				Return If(Diagram IsNot Nothing, Diagram.AxisX, Nothing)
			End Get
		End Property
		Private ReadOnly Property AxisY() As AxisY
			Get
				Return If(Diagram IsNot Nothing, Diagram.AxisY, Nothing)
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

		Private Sub comboBoxSeriesLabels_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbSeriesLabels.EditValueChanged
			If Series IsNot Nothing Then
				Series.Label.TextPattern = cbSeriesLabels.Text
			End If
		End Sub
		Private Sub cbLegendTextPattern_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbLegendTextPattern.EditValueChanged
			If Series IsNot Nothing Then
				Series.LegendTextPattern = cbLegendTextPattern.Text
			End If
		End Sub
		Private Sub cbAxisXLabelsPattern_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbAxisXLabelsPattern.EditValueChanged
			If AxisX IsNot Nothing Then
				AxisX.Label.TextPattern = cbAxisXLabelsPattern.Text
			End If
		End Sub
		Private Sub cbAxisYLabelsPattern_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbAxisYLabelsPattern.EditValueChanged
			If AxisY IsNot Nothing Then
				AxisY.Label.TextPattern = cbAxisYLabelsPattern.Text
			End If
		End Sub
		Private Sub UpdatePatternControls()
			If Series IsNot Nothing Then
				cbSeriesLabels.Text = Series.Label.TextPattern
				cbLegendTextPattern.Text = Series.LegendTextPattern
			End If
			If AxisX IsNot Nothing Then
				cbAxisXLabelsPattern.Text = AxisX.Label.TextPattern
			End If
			If AxisY IsNot Nothing Then
				cbAxisYLabelsPattern.Text = AxisY.Label.TextPattern
			End If
		End Sub

		Protected Overrides Sub InitControls()
			MyBase.InitControls()
			chart.DataSource = dS21.Countries
			Dim path As String = Utils.GetRelativePath("countriesDB.mdb")
			If path.Length > 0 Then
				Utils.SetConnectionString(Me.oleDbConnection1, path)
			Else
				XtraMessageBox.Show("The ""countriesDB.mdb"" file not found.", "Error occurred", MessageBoxButtons.OK, MessageBoxIcon.Error)
				Return
			End If
			Try
				Me.oleDbDataAdapter1.Fill(Me.dS21)
			Catch e As OleDbException
				XtraMessageBox.Show(e.Message, "Error occurred", MessageBoxButtons.OK, MessageBoxIcon.Error)
				Return
			End Try
		End Sub
		Protected Overrides Sub SetAppearanceName(ByVal appearanceName As String)
			MyBase.SetAppearanceName(appearanceName)
			If chart.Series.Count = 0 Then
				Return
			End If
			If appearanceName = "Dark" OrElse appearanceName = "Dark Flat" Then
				chart.Series(0).Label.TextColor = Color.Black
			Else
				chart.Series(0).Label.TextColor = Color.Empty
			End If
		End Sub

		Public Overrides Sub UpdateControls()
			MyBase.UpdateControls()
			UpdatePatternControls()
		End Sub
	End Class
End Namespace
