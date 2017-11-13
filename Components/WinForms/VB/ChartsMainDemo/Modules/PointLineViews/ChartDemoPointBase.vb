Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing

Namespace DevExpress.XtraCharts.Demos.PointLineViews
	Partial Public Class PointDemoBase
		Inherits ChartDemoBase2D
		Private itemCollection As MarkerKindItemCollection
		Private markerControlsEnabled As Boolean = True

		Protected Overridable ReadOnly Property ProcessedSeries() As Series()
			Get
				Return New Series() { seriesSelected }
			End Get
		End Property

		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub comboBoxEditMarkerKind_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles comboBoxEditMarkerKind.SelectedIndexChanged
			If comboBoxEditMarkerKind.SelectedIndex = -1 Then
				Return
			End If
			For Each series As Series In ProcessedSeries
				If series IsNot Nothing Then
					Dim view As PointSeriesView = TryCast(series.View, PointSeriesView)
					Dim item As MarkerKindItem = TryCast(comboBoxEditMarkerKind.SelectedItem, MarkerKindItem)
					If view IsNot Nothing AndAlso item IsNot Nothing Then
						view.PointMarkerOptions.Kind = item.MarkerKind
						If item.MarkerKind.Equals(MarkerKind.Star) Then
							view.PointMarkerOptions.StarPointCount = (CType(item, StarMarkerKindItem)).PointCount
						End If
					End If
				End If
			Next series
		End Sub
		Private Sub comboBoxEditLabelAngle_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles comboBoxEditLabelAngle.SelectedIndexChanged
			If Me.comboBoxEditMarkerKind.SelectedIndex = -1 OrElse Me.seriesSelected Is Nothing OrElse seriesSelected.View Is Nothing Then
				Return
			End If
			CType(seriesSelected.Label, PointSeriesLabel).Angle = Int32.Parse(Me.comboBoxEditLabelAngle.Text)
		End Sub
		Private Sub comboBoxEditMarkerSize_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles comboBoxEditMarkerSize.SelectedIndexChanged
			If comboBoxEditMarkerKind.SelectedIndex = -1 Then
				Return
			End If
			For Each series As Series In ProcessedSeries
				If series IsNot Nothing Then
					Dim view As PointSeriesView = TryCast(series.View, PointSeriesView)
					If view IsNot Nothing Then
						view.PointMarkerOptions.Size = Int32.Parse(comboBoxEditMarkerSize.Text)
					End If
				End If
			Next series
		End Sub
		Private Sub DisableControls()
			comboBoxEditMarkerKind.SelectedIndex = -1
			comboBoxEditMarkerKind.Enabled = False
			labelMarkerKind.Enabled = False
			comboBoxEditLabelAngle.SelectedIndex = -1
			comboBoxEditLabelAngle.Enabled = False
			labelAngle.Enabled = False
			comboBoxEditMarkerSize.SelectedIndex = -1
			comboBoxEditMarkerSize.Enabled = False
			labelMarkerSize.Enabled = False
		End Sub

		Protected Overrides Sub InitControls()
			MyBase.InitControls()

			Me.itemCollection = MarkerKindItemCollection.CreateCollection()
			Dim items(itemCollection.Count - 1) As MarkerKindItem
			Me.itemCollection.CopyTo(items)
			Me.comboBoxEditMarkerKind.Properties.Items.AddRange(items)

			Me.comboBoxEditLabelAngle.Properties.Items.AddRange(New String() { "0", "45", "90", "135", "180", "225", "270", "315" })
			Me.comboBoxEditMarkerSize.Properties.Items.AddRange(MarkerKindItemCollection.GetSizeArray())
		End Sub
		Protected Sub EnableMarkerControls(ByVal enable As Boolean)
			Me.markerControlsEnabled = enable
			Me.labelMarkerKind.Enabled = enable
			Me.comboBoxEditMarkerKind.Enabled = enable
			Me.labelMarkerSize.Enabled = enable
			Me.comboBoxEditMarkerSize.Enabled = enable
		End Sub

		Public Overrides Sub UpdateControls()
			MyBase.UpdateControls()
			If seriesSelected Is Nothing Then
				DisableControls()
			Else
				Dim view As PointSeriesView = TryCast(seriesSelected.View, PointSeriesView)
				If view Is Nothing Then
					DisableControls()
					Return
				End If
				If view.PointMarkerOptions.Kind <> MarkerKind.Star Then
					comboBoxEditMarkerKind.SelectedItem = itemCollection.GetItemByKind(view.PointMarkerOptions.Kind)
				Else
					comboBoxEditMarkerKind.SelectedItem = itemCollection.GetItemByStarPointCount(view.PointMarkerOptions.StarPointCount)
				End If
				Dim pointLabel As PointSeriesLabel = TryCast(seriesSelected.Label, PointSeriesLabel)
				If pointLabel IsNot Nothing Then
					comboBoxEditLabelAngle.Enabled = ShowLabels
					comboBoxEditLabelAngle.Text = pointLabel.Angle.ToString()
				End If
				labelAngle.Enabled = ShowLabels
				comboBoxEditMarkerSize.Text = view.PointMarkerOptions.Size.ToString()
				EnableMarkerControls(markerControlsEnabled)
			End If
		End Sub
	End Class


	Friend NotInheritable Class RandomPointCalculator
		Private Sub New()
		End Sub
		Private Shared Function CalcRandomPoints(ByVal random As Random, ByVal count As Integer, ByVal xMin As Integer, ByVal xMax As Integer, ByVal yMin As Integer, ByVal yMax As Integer) As Point()
			If count > Math.Abs(xMax - xMin) * Math.Abs(yMax - yMin) Then
				Throw New ArgumentException("Parameter ""count"" very large. Can't calculate unique random points.")
			End If
			Dim points(count - 1) As Point
			For i As Integer = 0 To points.Length - 1
				Dim repeat As Boolean
				Do
					repeat = False
					points(i).X = random.Next(xMin, xMax)
					points(i).Y = random.Next(yMin, yMax)
					For k As Integer = 0 To i - 1
						If points(k) = points(i) Then
							repeat = True
							Exit For
						End If
					Next k
				Loop While repeat
			Next i
			Return points
		End Function

		Public Shared Function Calculate(ByVal random As Random, ByVal count As Integer, ByVal xMin As Integer, ByVal xMax As Integer, ByVal yMin As Integer, ByVal yMax As Integer) As SeriesPoint()
			Dim points() As Point = CalcRandomPoints(random, count, xMin, xMax, yMin, yMax)
			Dim seriesPoints(points.Length - 1) As SeriesPoint
			For i As Integer = 0 To points.Length - 1
				seriesPoints(i) = New SeriesPoint(points(i).X.ToString(), New Double() { points(i).Y })
			Next i
			Return seriesPoints
		End Function
	End Class
End Namespace
