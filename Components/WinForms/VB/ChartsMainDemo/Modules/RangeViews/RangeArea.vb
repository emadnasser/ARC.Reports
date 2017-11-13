Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.Utils
Imports DevExpress.XtraEditors

Namespace DevExpress.XtraCharts.Demos.RangeViews
	Partial Public Class RangeAreaDemo
		Inherits ChartDemoBase2D

		Private ReadOnly Property Series() As Series
			Get
				Return If(chart.Series.Count > 0, chart.Series(0), Nothing)
			End Get
		End Property
		Private ReadOnly Property View() As RangeAreaSeriesView
			Get
				Return If(Series IsNot Nothing, TryCast(Series.View, RangeAreaSeriesView), Nothing)
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

		Private Sub InitializeMarkerKindControls(ByVal comboBoxEditMarkerKind As ComboBoxEdit, ByVal marker As Marker)
			Dim itemCollection As MarkerKindItemCollection = MarkerKindItemCollection.CreateCollection()
			Dim items(itemCollection.Count - 1) As MarkerKindItem
			itemCollection.CopyTo(items)
			comboBoxEditMarkerKind.Properties.Items.AddRange(items)
			If marker.Kind <> MarkerKind.Star Then
				comboBoxEditMarkerKind.SelectedItem = itemCollection.GetItemByKind(marker.Kind)
			Else
				comboBoxEditMarkerKind.SelectedItem = itemCollection.GetItemByStarPointCount(marker.StarPointCount)
			End If
		End Sub
		Private Sub InitializeMarkerSizeControls(ByVal comboBoxEditMarkerSize As ComboBoxEdit, ByVal marker As Marker)
			comboBoxEditMarkerSize.Properties.Items.AddRange(MarkerKindItemCollection.GetSizeArray())
			comboBoxEditMarkerSize.Text = marker.Size.ToString()
		End Sub
		Private Sub checkEditShowMinMarkers_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkEditShowMinMarkers.CheckedChanged
			If View IsNot Nothing Then
				View.Marker1Visibility = If(checkEditShowMinMarkers.Checked, DefaultBoolean.True, DefaultBoolean.False)
			End If
			UpdateControls()
		End Sub
		Private Sub checkEditShowMaxMarkers_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkEditShowMaxMarkers.CheckedChanged
			If View IsNot Nothing Then
				View.Marker2Visibility = If(checkEditShowMaxMarkers.Checked, DefaultBoolean.True, DefaultBoolean.False)
			End If
			UpdateControls()
		End Sub
		Private Sub comboBoxEditMinMarkerKind_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles comboBoxEditMinMarkerKind.SelectedIndexChanged
			If comboBoxEditMinMarkerKind.SelectedIndex = -1 Then
				Return
			End If
			Dim item As MarkerKindItem = TryCast(comboBoxEditMinMarkerKind.SelectedItem, MarkerKindItem)
			If View IsNot Nothing AndAlso item IsNot Nothing Then
				View.Marker1.Kind = item.MarkerKind
				If item.MarkerKind.Equals(MarkerKind.Star) Then
					View.Marker1.StarPointCount = (CType(item, StarMarkerKindItem)).PointCount
				End If
			End If
		End Sub
		Private Sub comboBoxEditMaxMarkerKind_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles comboBoxEditMaxMarkerKind.SelectedIndexChanged
			If comboBoxEditMaxMarkerKind.SelectedIndex = -1 Then
				Return
			End If
			Dim item As MarkerKindItem = TryCast(comboBoxEditMaxMarkerKind.SelectedItem, MarkerKindItem)
			If View IsNot Nothing AndAlso item IsNot Nothing Then
				View.Marker2.Kind = item.MarkerKind
				If item.MarkerKind.Equals(MarkerKind.Star) Then
					View.Marker2.StarPointCount = (CType(item, StarMarkerKindItem)).PointCount
				End If
			End If
		End Sub
		Private Sub comboBoxEditMinMarkerSize_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles comboBoxEditMinMarkerSize.SelectedIndexChanged
			If comboBoxEditMinMarkerSize.SelectedIndex = -1 Then
				Return
			End If
			If View IsNot Nothing Then
				View.Marker1.Size = Int32.Parse(comboBoxEditMinMarkerSize.Text)
			End If
		End Sub
		Private Sub comboBoxEditMaxMarkerSize_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles comboBoxEditMaxMarkerSize.SelectedIndexChanged
			If comboBoxEditMaxMarkerSize.SelectedIndex = -1 Then
				Return
			End If
			If View IsNot Nothing Then
				View.Marker2.Size = Int32.Parse(comboBoxEditMaxMarkerSize.Text)
			End If
		End Sub
		Private Sub comboBoxLabelKind_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles comboBoxLabelKind.SelectedIndexChanged
			If Series Is Nothing Then
				Return
			End If
			Dim label As RangeAreaSeriesLabel = TryCast(Series.Label, RangeAreaSeriesLabel)
			If label Is Nothing Then
				Return
			End If
			Select Case CStr(comboBoxLabelKind.SelectedItem)
				Case "One Label"
					label.Kind = RangeAreaLabelKind.OneLabel
				Case "Two Labels"
					label.Kind = RangeAreaLabelKind.TwoLabels
				Case "Min Value Label"
					label.Kind = RangeAreaLabelKind.MinValueLabel
				Case "Max Value Label"
					label.Kind = RangeAreaLabelKind.MaxValueLabel
				Case "Value 1 Label"
					label.Kind = RangeAreaLabelKind.Value1Label
				Case "Value 2 Label"
					label.Kind = RangeAreaLabelKind.Value2Label
				Case Else
					label.Kind = RangeAreaLabelKind.TwoLabels
			End Select
			If label.Kind = RangeAreaLabelKind.OneLabel Then
				label.TextPattern = "{VD:G2}"
			Else
				label.TextPattern = "{V:G2}"
			End If
		End Sub

		Protected Overrides Sub InitControls()
			MyBase.InitControls()
			InitializeMarkerSizeControls(comboBoxEditMinMarkerSize, View.Marker1)
			InitializeMarkerSizeControls(comboBoxEditMaxMarkerSize, View.Marker2)
			InitializeMarkerKindControls(comboBoxEditMinMarkerKind, View.Marker1)
			InitializeMarkerKindControls(comboBoxEditMaxMarkerKind, View.Marker2)
			Series.DataSource = SourceOfEnergy.GetEuropeBrentPrices()
		End Sub

		Public Overrides Sub UpdateControls()
			MyBase.UpdateControls()
			comboBoxLabelKind.Enabled = ShowLabels
			labelLabelKind.Enabled = ShowLabels
			comboBoxEditMinMarkerSize.Enabled = checkEditShowMinMarkers.Checked
			labelMinMarkerSize.Enabled = checkEditShowMinMarkers.Checked
			comboBoxEditMinMarkerKind.Enabled = checkEditShowMinMarkers.Checked
			labelMinMarkerKind.Enabled = checkEditShowMinMarkers.Checked
			comboBoxEditMaxMarkerSize.Enabled = checkEditShowMaxMarkers.Checked
			labelMaxMarkerSize.Enabled = checkEditShowMaxMarkers.Checked
			comboBoxEditMaxMarkerKind.Enabled = checkEditShowMaxMarkers.Checked
			labelMaxMarkerKind.Enabled = checkEditShowMaxMarkers.Checked
		End Sub
	End Class
End Namespace
