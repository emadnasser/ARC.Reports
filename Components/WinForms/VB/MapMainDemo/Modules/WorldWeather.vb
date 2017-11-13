Imports Microsoft.VisualBasic
Imports System
Imports System.Windows.Forms
Imports System.Drawing
Imports System.Collections.Generic
Imports DevExpress.Utils
Imports System.Xml.Linq
Imports DevExpress.Demos.OpenWeatherService
Imports DevExpress.XtraBars

Namespace DevExpress.XtraMap.Demos

	Partial Public Class WorldWeather
		Inherits MapTutorialControl
		Private openWeatherMapService_Renamed As OpenWeatherMapService
		Private actualWeatherInfo As CityWeather
		Private actualMeasureUnits As TemperatureMeasureUnits = TemperatureMeasureUnits.Celsius

		Protected Overrides ReadOnly Property Overlays() As MapOverlay()
			Get
				Return OverlayUtils.GetBingOverlays()
			End Get
		End Property
		Protected ReadOnly Property OpenWeatherMapService() As OpenWeatherMapService
			Get
				Return openWeatherMapService_Renamed
			End Get
		End Property
		Protected Overrides ReadOnly Property MiniMapAlignment() As MiniMapAlignment
			Get
				Return MiniMapAlignment.TopRight
			End Get
		End Property
		Public Overrides ReadOnly Property MapControl() As MapControl
			Get
				Return mapControl1
			End Get
		End Property

		Public Sub New()
			AutoMergeRibbon = True
			InitializeComponent()
			DemoUtils.SetBingMapDataProviderKey(BingDataProvider)
			mapControl1.SetMapItemFactory(New DemoWeatherItemFactory())

			Me.openWeatherMapService_Renamed = New OpenWeatherMapService(LoadCapitalsFromXML())
			AddHandler Me.OpenWeatherMapService.ReadCompleted, AddressOf OpenWeatherMapService_ReadCompleted
			openWeatherMapService_Renamed.GetWeatherAsync()
		End Sub
		Private Function LoadCapitalsFromXML() As List(Of String)
			Dim capitals As New List(Of String)()
			Dim document As XDocument = DemoUtils.LoadXml("Capitals.xml")
			If document IsNot Nothing Then
				For Each element As XElement In document.Element("Capitals").Elements()
					capitals.Add(element.Value)
				Next element
			End If
			Return capitals
		End Function
		Private Sub OpenWeatherMapService_ReadCompleted(ByVal sender As Object, ByVal e As EventArgs)
			ListSourceDataAdapter.DataSource = Me.OpenWeatherMapService.WeatherInCities
			ItemsLayer.SelectedItem = Me.OpenWeatherMapService.LosAngelesWeather
			RemoveHandler Me.OpenWeatherMapService.ReadCompleted, AddressOf OpenWeatherMapService_ReadCompleted
		End Sub
		Private Sub OnDispose(ByVal disposing As Boolean)
			If Me.openWeatherMapService_Renamed IsNot Nothing Then
				RemoveHandler openWeatherMapService_Renamed.ReadCompleted, AddressOf OpenWeatherMapService_ReadCompleted
				openWeatherMapService_Renamed.Dispose()
				openWeatherMapService_Renamed = Nothing
			End If
		End Sub
		Private Sub mapControl1_SelectionChanged(ByVal sender As Object, ByVal e As MapSelectionChangedEventArgs) Handles mapControl1.SelectionChanged
			Dim selection As IList(Of Object) = e.Selection
			If selection Is Nothing OrElse selection.Count <> 1 Then
				Return
			End If
			Dim cityWeatherInfo As CityWeather = TryCast(selection(0), CityWeather)
			Me.actualWeatherInfo = cityWeatherInfo
			If cityWeatherInfo IsNot Nothing Then
				If cityWeatherInfo.Forecast Is Nothing Then
					Me.OpenWeatherMapService.GetForecastForCityAsync(cityWeatherInfo)
					AddHandler cityWeatherInfo.ForecastUpdated, AddressOf cityWeatherInfo_ForecastUpdated
				Else
					cityWeatherInfo_ForecastUpdated(cityWeatherInfo, Nothing)
				End If
			End If
		End Sub
		Private Sub cityWeatherInfo_ForecastUpdated(ByVal sender As Object, ByVal e As EventArgs)
			If IsDisposed Then
				Return
			End If
			Dim cityWeatherInfo As CityWeather = TryCast(sender, CityWeather)
			Dim del As Action(Of CityWeather) = AddressOf LoadWeatherPicture
			BeginInvoke(del, cityWeatherInfo)
		End Sub
		Private Sub LoadWeatherPicture(ByVal cityWeatherInfo As CityWeather)
			Me.chartControl1.Series(0).DataSource = cityWeatherInfo.Forecast
			lbCity.Text = cityWeatherInfo.City
			lbTemperature.Text = cityWeatherInfo.Weather.GetTemperatureString(actualMeasureUnits)
			peWeatherIcon.LoadAsync(cityWeatherInfo.WeatherIconPath)
		End Sub
		Private Sub mapControl1_SelectionChanging(ByVal sender As Object, ByVal e As MapSelectionChangingEventArgs) Handles mapControl1.SelectionChanging
			e.Cancel = e.Selection.Count = 0
		End Sub
		Private Sub chkFahrenheit_CheckedChanged(ByVal sender As Object, ByVal e As XtraBars.ItemClickEventArgs) Handles chkFahrenheit.CheckedChanged, chkCelsius.CheckedChanged
			If actualWeatherInfo IsNot Nothing Then
				If chkFahrenheit.Checked = True Then
					actualMeasureUnits = TemperatureMeasureUnits.Fahrenheit
					Me.chartControl1.Series(0).ValueDataMembers(0) = "Weather.FahrenheitTemperature"
				End If
				If chkCelsius.Checked = True Then
					actualMeasureUnits = TemperatureMeasureUnits.Celsius
					Me.chartControl1.Series(0).ValueDataMembers(0) = "Weather.CelsiusTemperature"
				End If
				lbTemperature.Text = actualWeatherInfo.Weather.GetTemperatureString(actualMeasureUnits)
				ListSourceDataAdapter.Mappings.Text = actualWeatherInfo.GetTemperatureDataMember(actualMeasureUnits)
			End If
		End Sub
		Private Sub chkMiniMap_ItemClick(ByVal sender As Object, ByVal e As XtraBars.ItemClickEventArgs)
			MapControl.MiniMap.Visible = (CType(e.Item, BarCheckItem)).Checked
		End Sub
		Private Sub chkShowChart_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles chkShowChart.ItemClick
			chartPanel.Visible = (CType(e.Item, BarCheckItem)).Checked
		End Sub
		Protected Overrides Sub InitRibbon()
			MyBase.InitRibbon()
			OptionsPage.Groups.Add(rpgTemperatureUnits)
			OptionsPage.Ribbon.Items.AddRange(New BarItem() { chkFahrenheit, chkCelsius })
		End Sub
		Protected Overrides Sub RestoreInitialView()
			MapControl.CenterPoint = New GeoPoint()
			MapControl.ZoomLevel = 3
		End Sub
	End Class
End Namespace
