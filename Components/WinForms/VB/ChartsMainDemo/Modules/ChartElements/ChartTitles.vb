Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports DevExpress.XtraEditors

Namespace DevExpress.XtraCharts.Demos.ChartElements
	Partial Public Class ChartTitlesDemo
		Inherits ChartDemoBase
		Private WithEvents chart As ChartControl
		Private selectedChartTitle As ChartTitle
		Private alignment() As String = { "Near", "Center", "Far" }
		Private dockSyle() As String = { "Top", "Bottom", "Left", "Right" }

		Public Overrides ReadOnly Property ChartControl() As ChartControl
			Get
				Return Me.chart
			End Get
		End Property

		Public Sub New()
			InitializeComponent()
			Dim random As New Random()
			For i As Integer = 0 To 39
				chart.Series(0).Points.Add(New SeriesPoint(i, New Double() { random.NextDouble() + 1 }))
			Next i
		End Sub

		Private Sub PrepareCombobox(ByVal combobox As ComboBoxEdit, ByVal items() As String)
			combobox.Properties.Items.Clear()
			combobox.Properties.Items.AddRange(items)
		End Sub
		Private Sub EnableCombobox(ByVal combobox As ComboBoxEdit, ByVal selectedIndex As Integer)
			combobox.SelectedIndex = selectedIndex
			combobox.Enabled = True
		End Sub
		Private Sub DisableCombobox(ByVal combobox As ComboBoxEdit)
			combobox.SelectedIndex = -1
			combobox.Enabled = False
		End Sub
		Private Sub chart_ObjectSelected(ByVal sender As Object, ByVal e As HotTrackEventArgs) Handles chart.ObjectSelected
			If TypeOf e.Object Is ChartTitle Then
				selectedChartTitle = CType(e.Object, ChartTitle)
			Else
				e.Cancel = True
			End If
			UpdateControls()
		End Sub
		Private Sub meeText_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles meeText.TextChanged
			If meeText.Lines.Length > 0 Then
				selectedChartTitle.Lines = meeText.Lines
			End If
		End Sub
		Private Sub cmbAlignment_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cmbAlignment.SelectedIndexChanged
			If cmbAlignment.SelectedIndex > -1 Then
				selectedChartTitle.Alignment = CType(cmbAlignment.SelectedIndex, StringAlignment)
			End If
		End Sub
		Private Sub cmbDock_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cmbDock.SelectedIndexChanged
			If cmbDock.SelectedIndex > -1 Then
				selectedChartTitle.Dock = CType(cmbDock.SelectedIndex, ChartTitleDockStyle)
			End If
		End Sub
		Private Sub ChartDemoChartTitles_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			PrepareCombobox(cmbAlignment, alignment)
			PrepareCombobox(cmbDock, dockSyle)
			selectedChartTitle = chart.Titles(0)
			chart.SetObjectSelection(selectedChartTitle)
			UpdateControls()
		End Sub
		Private Sub chart_ObjectHotTracked(ByVal sender As Object, ByVal e As HotTrackEventArgs) Handles chart.ObjectHotTracked
			If Not(TypeOf e.Object Is ChartTitle) Then
				e.Cancel = True
			End If
		End Sub
		Private Sub chbWordWrap_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chbWordWrap.CheckedChanged
			selectedChartTitle.WordWrap = chbWordWrap.Checked
		End Sub

		Public Overrides Sub UpdateControls()
			MyBase.UpdateControls()
			If selectedChartTitle IsNot Nothing Then
				EnableCombobox(cmbAlignment, CInt(Fix(selectedChartTitle.Alignment)))
				EnableCombobox(cmbDock, CInt(Fix(selectedChartTitle.Dock)))
				chbWordWrap.Enabled = True
				chbWordWrap.Checked = selectedChartTitle.WordWrap
				meeText.Text = selectedChartTitle.Text
				meeText.Enabled = True
				lblAlignment.Enabled = True
				lblDock.Enabled = True
				lblText.Enabled = True
			Else
				DisableCombobox(cmbAlignment)
				DisableCombobox(cmbDock)
				chbWordWrap.Enabled = False
				meeText.Text = String.Empty
				meeText.Enabled = False
				lblAlignment.Enabled = False
				lblDock.Enabled = False
				lblText.Enabled = False
			End If
		End Sub
	End Class
End Namespace
