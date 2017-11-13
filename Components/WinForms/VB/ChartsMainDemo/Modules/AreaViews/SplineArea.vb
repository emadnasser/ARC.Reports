Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.Utils
Imports DevExpress.XtraEditors

Namespace DevExpress.XtraCharts.Demos.AreaViews
	Partial Public Class SplineAreaDemo
		Inherits ChartDemoBase2D
		Private chart As ChartControl
		Private WithEvents comboBoxEditLabelAngle As ComboBoxEdit
		Private WithEvents comboBoxEditMarkerKind As ComboBoxEdit
		Private WithEvents comboBoxEditMarkerSize As ComboBoxEdit
		Private WithEvents checkEditShowMarkers As CheckEdit

		Protected ReadOnly Property ShowMarkers() As Boolean
			Get
				Return checkEditShowMarkers.Checked
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

		Private Sub checkEditShowMarkers_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkEditShowMarkers.CheckedChanged
			Dim view As SplineAreaSeriesView = TryCast(ChartControl.SeriesTemplate.View, SplineAreaSeriesView)
			If view IsNot Nothing Then
				view.MarkerVisibility = If(checkEditShowMarkers.Checked, DefaultBoolean.True, DefaultBoolean.False)
			End If
			UpdateControls()
		End Sub
		Private Sub comboBoxEditLabelAngle_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles comboBoxEditLabelAngle.SelectedIndexChanged
			If comboBoxEditMarkerKind.SelectedIndex = -1 Then
				Return
			End If
			Dim label As PointSeriesLabel = TryCast(ChartControl.SeriesTemplate.Label, PointSeriesLabel)
			If label IsNot Nothing Then
				label.Angle = Convert.ToInt32(comboBoxEditLabelAngle.Text)
			End If
		End Sub
		Private Sub comboTransparencies_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles comboTransparencies.SelectedIndexChanged
			Dim view As SplineAreaSeriesView = TryCast(ChartControl.SeriesTemplate.View, SplineAreaSeriesView)
			If view IsNot Nothing Then
				view.Transparency = Convert.ToByte(comboTransparencies.Text)
			End If
		End Sub
		Private Sub comboBoxEditMarkerKind_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles comboBoxEditMarkerKind.SelectedIndexChanged
			If comboBoxEditMarkerKind.SelectedIndex = -1 Then
				Return
			End If
			Dim view As SplineAreaSeriesView = TryCast(ChartControl.SeriesTemplate.View, SplineAreaSeriesView)
			If view IsNot Nothing Then
				Dim item As MarkerKindItem = CType(comboBoxEditMarkerKind.SelectedItem, MarkerKindItem)
				view.PointMarkerOptions.Kind = item.MarkerKind
				If item.MarkerKind.Equals(MarkerKind.Star) Then
					view.PointMarkerOptions.StarPointCount = (CType(item, StarMarkerKindItem)).PointCount
				End If
			End If
			UpdateControls()
		End Sub
		Private Sub comboBoxEditMarkerSize_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles comboBoxEditMarkerSize.SelectedIndexChanged
			If comboBoxEditMarkerKind.SelectedIndex = -1 Then
				Return
			End If
			Dim view As SplineAreaSeriesView = TryCast(ChartControl.SeriesTemplate.View, SplineAreaSeriesView)
			If view IsNot Nothing Then
				view.MarkerOptions.Size = Convert.ToInt32(comboBoxEditMarkerSize.Text)
			End If
		End Sub

		Protected Overrides Sub InitControls()
			itemCollection = MarkerKindItemCollection.CreateCollection()
			Dim items(itemCollection.Count - 1) As MarkerKindItem
			itemCollection.CopyTo(items)
			comboBoxEditMarkerKind.Properties.Items.AddRange(items)
			comboBoxEditLabelAngle.Properties.Items.AddRange(New String() { "0", "45", "90", "135", "180", "225", "270", "315" })
			comboBoxEditMarkerSize.Properties.Items.AddRange(MarkerKindItemCollection.GetSizeArray())
			MyBase.InitControls()
			comboTransparencies.Properties.Items.AddRange(New String() { "0", "45", "90", "135", "180", "225", "255" })
			checkEditShowMarkers.Checked = (CType(ChartControl.SeriesTemplate.View, SplineAreaSeriesView)).MarkerVisibility = DefaultBoolean.True
			ChartControl.DataSource = DevAV.GetOutsideVendorCosts()
		End Sub

		Public Overrides Sub UpdateControls()
			MyBase.UpdateControls()
			Dim view As SplineAreaSeriesView = TryCast(ChartControl.SeriesTemplate.View, SplineAreaSeriesView)
			comboTransparencies.Text = view.Transparency.ToString()
			comboBoxEditMarkerKind.Enabled = ShowMarkers
			labelMarkerKind.Enabled = ShowMarkers
			labelAngle.Enabled = ShowLabels
			comboBoxEditLabelAngle.Enabled = ShowLabels
			comboBoxEditLabelAngle.Text = (CType(ChartControl.SeriesTemplate.Label, PointSeriesLabel)).Angle.ToString()
			comboBoxEditMarkerSize.Enabled = ShowMarkers
			comboBoxEditMarkerSize.Text = view.PointMarkerOptions.Size.ToString()
			labelMarkerSize.Enabled = ShowMarkers
			If view.PointMarkerOptions.Kind <> MarkerKind.Star Then
				comboBoxEditMarkerKind.SelectedItem = itemCollection.GetItemByKind(view.PointMarkerOptions.Kind)
			Else
				comboBoxEditMarkerKind.SelectedItem = itemCollection.GetItemByStarPointCount(view.PointMarkerOptions.StarPointCount)
			End If
		End Sub
	End Class
End Namespace
