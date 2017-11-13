Imports DevExpress.XtraMap
Imports DevExpress.Demos.OpenWeatherService

Namespace DevExpress.ProductsDemo.Win.Modules
	Partial Public Class MapsModule
		Inherits BaseModule

		Private openWeatherService As OpenWeatherMapService
		Private actualWeatherInfo As CityWeather
		Private actualMeasureUnits As TemperatureMeasureUnits = TemperatureMeasureUnits.Celsius

		Public ReadOnly Property MapControl() As MapControl
			Get
				Return mapControl1
			End Get
		End Property
		Protected ReadOnly Property OpenWeatherMapService() As OpenWeatherMapService
			Get
				Return openWeatherService
			End Get
		End Property
        Private ReadOnly Property TilesLayer() As ImageLayer
            Get
                Return CType(mapControl1.Layers(0), ImageLayer)
            End Get
        End Property
		Private ReadOnly Property ItemsLayer() As VectorItemsLayer
			Get
				Return CType(mapControl1.Layers(1), VectorItemsLayer)
			End Get
        End Property
        Private ReadOnly Property ListSourceData() As ListSourceDataAdapter
            Get
                Return CType(ItemsLayer.Data, ListSourceDataAdapter)
            End Get
        End Property


		Public Sub New()
			InitializeComponent()

			TilesLayer.DataProvider = MapUtils.CreateBingDataProvider(BingMapKind.Area)
			mapControl1.SetMapItemFactory(New DemoWeatherItemFactory())

            Me.openWeatherService = New OpenWeatherMapService(LoadCapitalsFromXML())
            AddHandler OpenWeatherMapService.ReadCompleted, AddressOf OpenWeatherMapService_ReadCompleted
            OpenWeatherMapService.GetWeatherAsync()
		End Sub
		Protected Overrides Property AutoMergeRibbon() As Boolean
			Get
				Return True
			End Get
			Set(ByVal value As Boolean)
				MyBase.AutoMergeRibbon = value
			End Set
		End Property

		Private Function LoadCapitalsFromXML() As List(Of String)
			Dim capitals As New List(Of String)()
			Dim document As XDocument = MapUtils.LoadXml("Capitals.xml")
			If document IsNot Nothing Then
				For Each element As XElement In document.Element("Capitals").Elements()
					capitals.Add(element.Value)
				Next element
			End If
			Return capitals
		End Function
        Private Sub OpenWeatherMapService_ReadCompleted(ByVal sender As Object, ByVal e As EventArgs)

            ListSourceData.DataSource = OpenWeatherMapService.WeatherInCities
            ItemsLayer.SelectedItem = OpenWeatherMapService.LosAngelesWeather
            RemoveHandler OpenWeatherMapService.ReadCompleted, AddressOf OpenWeatherMapService_ReadCompleted
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
                    OpenWeatherMapService.GetForecastForCityAsync(cityWeatherInfo)
					AddHandler cityWeatherInfo.ForecastUpdated, AddressOf cityWeatherInfo_ForecastUpdated
				Else
					cityWeatherInfo_ForecastUpdated(cityWeatherInfo, Nothing)
				End If
			End If
		End Sub
		Private Sub cityWeatherInfo_ForecastUpdated(ByVal sender As Object, ByVal e As EventArgs)
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

        Private Sub chkCelsius_CheckedChanged(ByVal sender As Object, ByVal e As XtraBars.ItemClickEventArgs) Handles chkFahrenheit.CheckedChanged, chkCelsius.CheckedChanged
            If e.Item.Tag Is Nothing Then Return
            UpdateTemperatureUnit(CInt(Fix(e.Item.Tag)))

        End Sub
		Private Sub UpdateTemperatureUnit(ByVal temperatureType As Integer)
			If actualWeatherInfo IsNot Nothing Then
				Dim member As String = "Weather.CelsiusTemperature"
				actualMeasureUnits = TemperatureMeasureUnits.Celsius

				If temperatureType = 0 Then
					actualMeasureUnits = TemperatureMeasureUnits.Fahrenheit
					member = "Weather.FahrenheitTemperature"
				End If
				Me.chartControl1.Series(0).ValueDataMembers(0) = member
				lbTemperature.Text = actualWeatherInfo.Weather.GetTemperatureString(actualMeasureUnits)
                ListSourceData.Mappings.Text = actualWeatherInfo.GetTemperatureDataMember(actualMeasureUnits)
			End If
		End Sub
        Private Sub chkBingRoad_CheckedChanged(ByVal sender As Object, ByVal e As XtraBars.ItemClickEventArgs) Handles chkBingRoad.CheckedChanged, chkBingArea.CheckedChanged, chkBingHybrid.CheckedChanged
            If e.Item.Tag Is Nothing Then Return
            UpdateBingMapKind(CInt(Fix(e.Item.Tag)))
        End Sub
		Private Sub UpdateBingMapKind(ByVal bingMapKind As Integer)
			Dim provider As BingMapDataProvider = CType(TilesLayer.DataProvider, BingMapDataProvider)
			provider.Kind = CType(bingMapKind, BingMapKind)
		End Sub


	End Class
End Namespace
