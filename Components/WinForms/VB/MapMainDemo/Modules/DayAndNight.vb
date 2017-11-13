Imports Microsoft.VisualBasic
Imports DevExpress.Demos.DayAndNightLineCalculator
Imports DevExpress.XtraBars
Imports DevExpress.XtraBars.Ribbon
Imports System
Imports System.Collections.Generic
Imports System.Windows.Forms

Namespace DevExpress.XtraMap.Demos
	Partial Public Class DayAndNight
		Inherits MapTutorialControl
		Private Const DiscreteHoursStep As Double = 0.5
		Private Const SteadilyHoursStep As Double = 24.5

		Private isDataLoaded As Boolean = False

		Private ReadOnly Property Sun() As MapCustomElement
			Get
				Return CType(Data.Items(0), MapCustomElement)
			End Get
		End Property
		Private ReadOnly Property Moon() As MapCustomElement
			Get
				Return CType(Data.Items(2), MapCustomElement)
			End Get
		End Property
		Private ReadOnly Property DayAndNightLine() As MapPolygon
			Get
				Return CType(Data.Items(1), MapPolygon)
			End Get
		End Property
		Private Property ActualDateTime() As DateTime
			Get
				Return If(barEditCalendar.EditValue IsNot Nothing, CDate(barEditCalendar.EditValue), DateTime.UtcNow)
			End Get
			Set(ByVal value As DateTime)
				barEditCalendar.EditValue = value
			End Set
		End Property

		Public Overrides ReadOnly Property MapControl() As MapControl
			Get
				Return mapControl1
			End Get
		End Property

		Public Sub New()
			AutoMergeRibbon = True
			InitializeComponent()
			listBoxControl1.SelectedIndex = 8
			ShapefileDataAdapter.FileUri = New Uri("file:\\" & DemoUtils.GetRelativePath("Countries.shp"), UriKind.RelativeOrAbsolute)
			UpdateCurrentDayAndNightLine()
		End Sub
		Private Sub UpdateCurrentDayAndNightLine()
			Dim dt As DateTime = DateTime.UtcNow
			ActualDateTime = dt
			UpdateDayAndNightLine(dt)
		End Sub
		Private Sub UpdateDayAndNightLine(ByVal dt As DateTime)
			Dim sun3DPosition() As Double = DayAndNightLineCalculator.CalculateSunPosition(dt)
			Dim sunLocation As New GeoPoint(sun3DPosition(1), sun3DPosition(0))
			Dim moonLocation As GeoPoint = GetOppositePoint(sunLocation)
			Dim dayAndNightLineVertices As CoordPointCollection = GetdayAndNightLineVertices(sunLocation, 0.1)
			Dim isNorthNight As Boolean = DayAndNightLineCalculator.CalculateIsNorthNight(sun3DPosition)
			If isNorthNight Then
				AddNorthContour(dayAndNightLineVertices)
			Else
				AddSouthContour(dayAndNightLineVertices)
			End If
			Sun.Location = sunLocation
			Moon.Location = moonLocation
			DayAndNightLine.Points = dayAndNightLineVertices
		End Sub
		Private Function GetdayAndNightLineVertices(ByVal sunLocation As GeoPoint, ByVal [step] As Double) As CoordPointCollection
			Dim result As New CoordPointCollection()
			Dim latitudes As IList(Of Double) = DayAndNightLineCalculator.GetDayAndNightLineLatitudes(sunLocation.Latitude, sunLocation.Longitude, [step])
			Dim lon As Double = -180
			For Each lat As Double In latitudes
				result.Add(New GeoPoint(lat, lon))
				lon += [step]
			Next lat
			Return result
		End Function
		Private Function GetOppositePoint(ByVal sunLocation As GeoPoint) As GeoPoint
			Dim lat As Double = -sunLocation.Latitude
			Dim lon As Double = sunLocation.Longitude + 180
			If lon > 180 Then
				lon -= 360
			End If
			Return New GeoPoint(lat, lon)
		End Function
		Private Sub AddNorthContour(ByVal dayAndNightLineVertices As CoordPointCollection)
			Dim initLat As Double = Math.Ceiling((CType(dayAndNightLineVertices(dayAndNightLineVertices.Count - 1), GeoPoint)).Latitude)
			For latForward As Double = initLat To 90.0
				dayAndNightLineVertices.Add(New GeoPoint(latForward, 180))
			Next latForward
			For lon As Double = 180 To -180 Step -1
				dayAndNightLineVertices.Add(New GeoPoint(90, lon))
			Next lon
			initLat = Math.Ceiling((CType(dayAndNightLineVertices(0), GeoPoint)).Latitude)
			Dim latBackward As Double = 90
			Do While latBackward >= initLat
				dayAndNightLineVertices.Add(New GeoPoint(latBackward, -180))
				latBackward -= 1
			Loop
		End Sub
		Private Sub AddSouthContour(ByVal dayAndNightLineVertices As CoordPointCollection)
			Dim initLat As Double = Math.Ceiling((CType(dayAndNightLineVertices(dayAndNightLineVertices.Count - 1), GeoPoint)).Latitude)
			For lat As Double = initLat To -90.0 Step -1
				dayAndNightLineVertices.Add(New GeoPoint(lat, 180))
			Next lat
			For lon As Double = 180 To -180 Step -1
				dayAndNightLineVertices.Add(New GeoPoint(-90, lon))
			Next lon
			initLat = Math.Ceiling((CType(dayAndNightLineVertices(0), GeoPoint)).Latitude)
			For lat As Double = -90 To initLat
				dayAndNightLineVertices.Add(New GeoPoint(lat, -180))
			Next lat
		End Sub
		Private Sub UpdateTimerEnabled(ByVal enabled As Boolean)
			Me.timer.Enabled = enabled
			Me.chkSteadily.Checked = enabled
		End Sub

		Private Function IsDateOverFlow(ByVal currentDate As DateTime, ByVal stepHours As Double) As Boolean
			Dim hoursTicks As Long = CLng(Fix(stepHours * TimeSpan.TicksPerHour + currentDate.Ticks))
			Return hoursTicks >= DateTime.MaxValue.Ticks Or hoursTicks <= DateTime.MinValue.Ticks
		End Function

		Private Function GetNextDateTime(ByVal dt As DateTime) As DateTime
			Dim [step] As Double = If(chkSteadily.Checked, SteadilyHoursStep, DiscreteHoursStep)
			Return If(IsDateOverFlow(dt, [step]), DateTime.MaxValue, dt.AddHours([step]))
		End Function
		Private Function GetPreviousDateTime(ByVal dt As DateTime) As DateTime
			Return If(IsDateOverFlow(dt, -DiscreteHoursStep), DateTime.MinValue, dt.AddHours(-DiscreteHoursStep))
		End Function
		Private Sub timer_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles timer.Tick
			ActualDateTime = GetNextDateTime(ActualDateTime)
		End Sub
		Private Sub DayAndNight_DataLoaded(ByVal sender As Object, ByVal e As DataLoadedEventArgs) Handles FileLayer.DataLoaded
			isDataLoaded = True
		End Sub
		Private Sub barEditItem2_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles barEditCalendar.EditValueChanged
			UpdateDayAndNightLine(ActualDateTime)
		End Sub
		Private Sub btnCurrent_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles btnCurrent.ItemClick
			UpdateTimerEnabled(False)
			UpdateCurrentDayAndNightLine()
		End Sub
		Private Sub chkSteadily_CheckedChanged(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles chkSteadily.CheckedChanged
			UpdateTimerEnabled(chkSteadily.Checked)
		End Sub
		Private Sub btnPlus_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles btnPlus.ItemClick
			UpdateTimerEnabled(False)
			ActualDateTime = GetNextDateTime(ActualDateTime)
		End Sub
		Private Sub btnMinus_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles btnMinus.ItemClick
			UpdateTimerEnabled(False)
			ActualDateTime = GetPreviousDateTime(ActualDateTime)
		End Sub
		Private Sub listBoxControl1_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles listBoxControl1.SelectedIndexChanged
			Dim cs = CType(mapControl1.CoordinateSystem, GeoMapCoordinateSystem)
			Select Case listBoxControl1.SelectedIndex
				Case 0
					cs.Projection = New SphericalMercatorProjection()
				Case 1
					cs.Projection = New EqualAreaProjection()
				Case 2
					cs.Projection = New EquirectangularProjection()
				Case 3
					cs.Projection = New EllipticalMercatorProjection()
				Case 4
					cs.Projection = New MillerProjection()
				Case 5
					cs.Projection = New EquidistantProjection()
				Case 6
					cs.Projection = New LambertCylindricalEqualAreaProjection()
				Case 7
					cs.Projection = New BraunStereographicProjection()
				Case 8
					cs.Projection = New KavrayskiyProjection()
				Case 9
					cs.Projection = New SinusoidalProjection()
				Case 10
					cs.Projection = New EPSG4326Projection()
			End Select
			If isDataLoaded Then
				ZoomLayersToFit()
			End If
		End Sub
		Private Sub ZoomLayersToFit()
			MapControl.EnableZooming = True
			MapControl.ZoomToFitLayerItems(0.3)
			MapControl.EnableZooming = False
		End Sub
		Protected Overrides Sub InitRibbon()
			MyBase.InitRibbon()
			DisableZoomOptions()
			ChkShowMinimap.Enabled = False
			OptionsPage.Groups.AddRange(New RibbonPageGroup() { rpgInteractivity, rpgDateTime })
			OptionsPage.Ribbon.Items.Add(barEditCalendar)
		End Sub
		Protected Overrides Sub ChangeEnableNavigation(ByVal enable As Boolean)
			MapControl.EnableScrolling = enable
		End Sub
		Protected Overrides Sub RestoreInitialView()
			MapControl.CenterPoint = New GeoPoint()
		End Sub
		Protected Overrides Sub DoHide()
			MyBase.DoHide()
			UpdateTimerEnabled(False)
		End Sub
		Protected Overrides Sub DoShow()
			MyBase.DoShow()
			UpdateTimerEnabled(True)
		End Sub
	End Class
End Namespace
