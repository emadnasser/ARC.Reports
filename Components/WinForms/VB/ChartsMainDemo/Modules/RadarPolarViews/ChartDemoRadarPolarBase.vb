Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.XtraEditors

Namespace DevExpress.XtraCharts.Demos.RadarPolarViews
	Partial Public Class RadarPolarDemoBase
		Inherits ChartDemoBase2D
		Private labelMarkerKind As LabelControl
		Private labelMarkerSize As LabelControl
		Private itemCollection As MarkerKindItemCollection

		Protected Overridable Property ShowMarkers() As Boolean
			Get
				Return True
			End Get
			Set(ByVal value As Boolean)
			End Set
		End Property
		Protected Overridable ReadOnly Property ShowDiagramStyle() As Boolean
			Get
				Return True
			End Get
		End Property
		Protected Overrides ReadOnly Property SeriesSelection() As Boolean
			Get
				Return True
			End Get
		End Property

		Public Sub New()
			InitializeComponent()
			labelDiagramStyle.Visible = ShowDiagramStyle
			comboBoxEditDiagramStyle.Visible = ShowDiagramStyle
		End Sub

		Private Sub comboBoxEditMarkerKind_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles comboBoxEditMarkerKind.SelectedIndexChanged
			If Me.comboBoxEditMarkerKind.SelectedIndex = -1 OrElse seriesSelected Is Nothing Then
				Return
			End If
			Dim view As RadarPointSeriesView = TryCast(seriesSelected.View, RadarPointSeriesView)
			If view IsNot Nothing Then
				Dim item As MarkerKindItem = CType(Me.comboBoxEditMarkerKind.SelectedItem, MarkerKindItem)
				view.PointMarkerOptions.Kind = item.MarkerKind
				If item.MarkerKind.Equals(MarkerKind.Star) Then
					view.PointMarkerOptions.StarPointCount = (CType(item, StarMarkerKindItem)).PointCount
				End If
			End If
		End Sub
		Private Sub comboBoxEditMarkerSize_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles comboBoxEditMarkerSize.SelectedIndexChanged
			If Me.comboBoxEditMarkerKind.SelectedIndex = -1 OrElse Me.seriesSelected Is Nothing Then
				Return
			End If
			Dim view As RadarPointSeriesView = TryCast(seriesSelected.View, RadarPointSeriesView)
			If view IsNot Nothing Then
				view.PointMarkerOptions.Size = Int32.Parse(Me.comboBoxEditMarkerSize.Text)
			End If
		End Sub
		Private Sub comboBoxEditDiagramStyle_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles comboBoxEditDiagramStyle.SelectedIndexChanged
			Dim diagram As RadarDiagram = TryCast(ChartControl.Diagram, RadarDiagram)
			If diagram IsNot Nothing Then
				diagram.DrawingStyle = CType(comboBoxEditDiagramStyle.SelectedIndex, RadarDiagramDrawingStyle)
			End If
		End Sub

		Protected Overrides Sub InitControls()
			MyBase.InitControls()
			Me.itemCollection = MarkerKindItemCollection.CreateCollection()
			Dim items(Me.itemCollection.Count - 1) As MarkerKindItem
			Me.itemCollection.CopyTo(items)
			Me.comboBoxEditMarkerKind.Properties.Items.AddRange(items)
			If ChartControl.Series.Count > 0 Then
				ShowLabels = ChartControl.Series(0).LabelsVisibility = DevExpress.Utils.DefaultBoolean.True
			End If
			Dim diagram As RadarDiagram = TryCast(ChartControl.Diagram, RadarDiagram)
			If diagram IsNot Nothing Then
				comboBoxEditDiagramStyle.SelectedIndex = CInt(Fix(diagram.DrawingStyle))
			End If
			Me.comboBoxEditMarkerSize.Properties.Items.AddRange(MarkerKindItemCollection.GetSizeArray())
		End Sub
		Protected Sub EnableMarkerControls(ByVal enable As Boolean)
			Me.labelMarkerKind.Enabled = enable
			Me.comboBoxEditMarkerKind.Enabled = enable
			Me.labelMarkerSize.Enabled = enable
			Me.comboBoxEditMarkerSize.Enabled = enable
		End Sub

		Public Overrides Sub UpdateControls()
			MyBase.UpdateControls()
			If Me.seriesSelected Is Nothing Then
				Me.comboBoxEditMarkerKind.SelectedIndex = -1
				Me.comboBoxEditMarkerKind.Enabled = False
				Me.labelMarkerKind.Enabled = False
				Me.comboBoxEditMarkerSize.SelectedIndex = -1
				Me.comboBoxEditMarkerSize.Enabled = False
				Me.labelMarkerSize.Enabled = False
			Else
				Dim view As RadarPointSeriesView = TryCast(seriesSelected.View, RadarPointSeriesView)
				If view IsNot Nothing Then
					If view.PointMarkerOptions.Kind <> MarkerKind.Star Then
						Me.comboBoxEditMarkerKind.SelectedItem = Me.itemCollection.GetItemByKind(view.PointMarkerOptions.Kind)
					Else
						Me.comboBoxEditMarkerKind.SelectedItem = Me.itemCollection.GetItemByStarPointCount(view.PointMarkerOptions.StarPointCount)
					End If
					Me.comboBoxEditMarkerKind.Enabled = ShowMarkers
					Me.labelMarkerKind.Enabled = ShowMarkers
					Me.comboBoxEditMarkerSize.Enabled = ShowMarkers
					Me.labelMarkerSize.Enabled = ShowMarkers
					Me.comboBoxEditMarkerSize.Text = view.PointMarkerOptions.Size.ToString()
				End If
			End If
		End Sub
	End Class
End Namespace
