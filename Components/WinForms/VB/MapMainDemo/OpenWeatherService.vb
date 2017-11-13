Imports Microsoft.VisualBasic
Imports System
Imports System.IO
Imports System.Collections.Generic
Imports System.Net
Imports System.Threading.Tasks
Imports System.Runtime.Serialization
Imports System.Runtime.Serialization.Json

Namespace DevExpress.Demos.OpenWeatherService
	Public Class CityWeather
		Private cityWeatherInfo As OpenWeatherMapService.CityCurrentWeatherInfo
		Private forecast_Renamed As List(Of CityWeather)
		Private weather_Renamed As Weather
		Private weatherDescriptions_Renamed As List(Of WeatherDescription)

		Public ReadOnly Property CurrentDateTime() As DateTime
			Get
				Return GetTime(cityWeatherInfo.dt)
			End Get
		End Property
		Public ReadOnly Property CityID() As Integer
			Get
				Return cityWeatherInfo.id
			End Get
		End Property
		Public ReadOnly Property City() As String
			Get
				Return cityWeatherInfo.name
			End Get
		End Property
		Public ReadOnly Property Longitude() As Double
			Get
				Return cityWeatherInfo.coord.Lon
			End Get
		End Property
		Public ReadOnly Property Latitude() As Double
			Get
				Return cityWeatherInfo.coord.Lat
			End Get
		End Property
		Public ReadOnly Property Forecast() As List(Of CityWeather)
			Get
				Return forecast_Renamed
			End Get
		End Property
		Public ReadOnly Property Weather() As Weather
			Get
				Return weather_Renamed
			End Get
		End Property
		Public ReadOnly Property CelsiusDisplayText() As String
			Get
				Return City + Constants.vbLf + weather_Renamed.CelsiusTemperatureString
			End Get
		End Property
		Public ReadOnly Property KelvinDisplayText() As String
			Get
				Return City + Constants.vbLf + weather_Renamed.KelvinTemperatureString
			End Get
		End Property
		Public ReadOnly Property FahrenheitDisplayText() As String
			Get
				Return City + Constants.vbLf + weather_Renamed.FahrenheitTemperatureString
			End Get
		End Property
		Public ReadOnly Property WeatherDescriptions() As List(Of WeatherDescription)
			Get
				Return weatherDescriptions_Renamed
			End Get
		End Property
		Public Property WeatherIconPath() As String
		Public Property ForecastTime() As DateTime

		Public Event ForecastUpdated As EventHandler

		Public Sub New(ByVal cityWeatherInfo As OpenWeatherMapService.CityCurrentWeatherInfo)
			Me.cityWeatherInfo = cityWeatherInfo
			Me.weather_Renamed = New Weather(cityWeatherInfo.main)
			Me.weatherDescriptions_Renamed = New List(Of WeatherDescription)()
			For Each weatherDescription As OpenWeatherMapService.WeatherDescriptionInfo In cityWeatherInfo.weather
				weatherDescriptions_Renamed.Add(New WeatherDescription(weatherDescription))
			Next weatherDescription
		End Sub
		Public Sub New(ByVal forecast As OpenWeatherMapService.ForecastInfo, ByVal index As Integer)
			Dim info As OpenWeatherMapService.CityForecastWeatherInfo = forecast.list(index)
			Dim cityInfo As OpenWeatherMapService.CityInfo = forecast.city
			Me.cityWeatherInfo = New OpenWeatherMapService.CityCurrentWeatherInfo() With {.clouds = info.clouds, .dt = info.dt, .main = info.main, .weather = info.weather, .wind = info.wind, .coord = cityInfo.coord, .id = cityInfo.id, .name = cityInfo.name}
			Me.weather_Renamed = New Weather(cityWeatherInfo.main)
			Me.weatherDescriptions_Renamed = New List(Of WeatherDescription)()
			For Each weatherDescription As OpenWeatherMapService.WeatherDescriptionInfo In cityWeatherInfo.weather
				weatherDescriptions_Renamed.Add(New WeatherDescription(weatherDescription))
			Next weatherDescription
		End Sub

		Private Function GetTime(ByVal seconds As Long) As DateTime
			Dim dtDateTime As New DateTime(1970, 1, 1, 0, 0, 0, 0)
			Return dtDateTime.AddSeconds(seconds).ToLocalTime()
		End Function
		Friend Sub SetForecast(ByVal forecast As OpenWeatherMapService.ForecastInfo)
			If forecast Is Nothing Then
				Return
			End If
			Dim cityWeatherList As New List(Of CityWeather)()
			For i As Integer = 0 To forecast.list.Count - 1
				cityWeatherList.Add(New CityWeather(forecast, i))
			Next i

			Me.forecast_Renamed = cityWeatherList
			RaiseEvent ForecastUpdated(Me, EventArgs.Empty)
		End Sub
		Public Function GetTemperatureDataMember(ByVal measureUnits As TemperatureMeasureUnits) As String
			Select Case measureUnits
				Case TemperatureMeasureUnits.Fahrenheit
					Return "FahrenheitDisplayText"
				Case TemperatureMeasureUnits.Kelvin
					Return "KelvinDisplayText"
				Case Else
					Return "CelsiusDisplayText"
			End Select
		End Function
	End Class

	Public Enum TemperatureMeasureUnits
		Celsius
		Fahrenheit
		Kelvin
	End Enum

	Public Class Weather
		Private weatherInfo As OpenWeatherMapService.WeatherInfo

		Public ReadOnly Property CelsiusTemperature() As Integer
			Get
				Return CInt(Fix(weatherInfo.temp))
			End Get
		End Property
		Public ReadOnly Property FahrenheitTemperature() As Integer
			Get
				Return CInt(Fix(weatherInfo.temp)) * 9 \ 5 + 32
			End Get
		End Property
		Public ReadOnly Property KelvinTemperature() As Integer
			Get
				Return CInt(Fix(weatherInfo.temp + 273.15))
			End Get
		End Property
		Public ReadOnly Property CelsiusTemperatureString() As String
			Get
				Return CelsiusTemperature.ToString("+#;-#;0") & " °C"
			End Get
		End Property
		Public ReadOnly Property FahrenheitTemperatureString() As String
			Get
				Return FahrenheitTemperature.ToString("+#;-#;0") & " °F"
			End Get
		End Property
		Public ReadOnly Property KelvinTemperatureString() As String
			Get
				Return KelvinTemperature.ToString("+#;-#;0") & " °K"
			End Get
		End Property

		Public Sub New(ByVal weatherInfo As OpenWeatherMapService.WeatherInfo)
			Me.weatherInfo = weatherInfo
		End Sub
		Public Function GetTemperatureString(ByVal measureUnits As TemperatureMeasureUnits) As String
			Select Case measureUnits
				Case TemperatureMeasureUnits.Fahrenheit
					Return FahrenheitTemperatureString
				Case TemperatureMeasureUnits.Kelvin
					Return KelvinTemperatureString
				Case Else
					Return CelsiusTemperatureString
			End Select
		End Function
	End Class
	Public Class WeatherDescription
		Private weatherDescriptionInfo As OpenWeatherMapService.WeatherDescriptionInfo

		Public ReadOnly Property IconName() As String
			Get
				Return weatherDescriptionInfo.icon
			End Get
		End Property

		Public Sub New(ByVal weatherDescriptionInfo As OpenWeatherMapService.WeatherDescriptionInfo)
			Me.weatherDescriptionInfo = weatherDescriptionInfo
		End Sub
	End Class
	Public Class OpenWeatherMapService
		Implements IDisposable
		#Region "classes for JSON parsing"

		<DataContract> _
		Public Class ForecastInfo
			<DataMember> _
			Public city As CityInfo = Nothing
			<DataMember> _
			Public list As List(Of CityForecastWeatherInfo)
		End Class
		<DataContract> _
		Public Class CityInfo
			<DataMember> _
			Friend id As Integer = 0
			<DataMember> _
			Friend name As String = ""
			<DataMember> _
			Friend coord As Coordinates = Nothing
		End Class
		<DataContract> _
		Public Class CityForecastWeatherInfo
			<DataMember> _
			Friend dt As Long = 0
			<DataMember> _
			Friend main As WeatherInfo = Nothing
			<DataMember> _
			Friend weather As List(Of WeatherDescriptionInfo) = Nothing
			<DataMember> _
			Friend clouds As CloudsInfo = Nothing
			<DataMember> _
			Friend wind As WindInfo = Nothing
		End Class
		<DataContract> _
		Public Class WeatherDescriptionInfo
			<DataMember> _
			Friend main As String = Nothing
			<DataMember> _
			Friend description As String = Nothing
			<DataMember> _
			Friend icon As String = Nothing
		End Class
		<DataContract> _
		Public Class CloudsInfo
			<DataMember> _
			Friend all As Integer = 0
		End Class
		<DataContract> _
		Public Class WindInfo
			<DataMember> _
			Friend speed As Double = 0.0
			<DataMember> _
			Friend deg As Double = 0.0
		End Class
		<DataContract> _
		Public Class WeatherInfo
			<DataMember> _
			Friend temp As Double = 0.0
			<DataMember> _
			Friend pressure As Double = 0.0
			<DataMember> _
			Friend humidity As Double = 0.0
		End Class
		<DataContract> _
		Public Class Coordinates
			<DataMember> _
			Friend Lon As Double = 0.0
			<DataMember> _
			Friend Lat As Double = 0.0
		End Class
		<DataContract> _
		Public Class WorldWeatherInfo
			<DataMember> _
			Public list As List(Of CityCurrentWeatherInfo) = Nothing
		End Class
		<DataContract> _
		Public Class CityCurrentWeatherInfo
			<DataMember> _
			Friend id As Integer = 0
			<DataMember> _
			Friend name As String = ""
			<DataMember> _
			Friend coord As Coordinates = Nothing
			<DataMember> _
			Friend main As WeatherInfo = Nothing
			<DataMember> _
			Friend dt As Long = 0
			<DataMember> _
			Friend wind As WindInfo = Nothing
			<DataMember> _
			Friend clouds As CloudsInfo = Nothing
			<DataMember> _
			Friend weather As List(Of WeatherDescriptionInfo) = Nothing
		End Class

		#End Region

		Private Const OpenWeatherUrl As String = "http://api.openweathermap.org/data/2.5/box/city?bbox=-180,-90,180,90&cluster=yes&APPID="
		Private Const OpenWeatherIconPathPrefix As String = "http://openweathermap.org/img/w/"

		Private Const OpenWeatherKey As String = "fcbff6dbed7bd7f295489daf4ffef3f1"

		Private Shared ReadOnly forecastLocker As Object = New Object()

		Private weatherInCities_Renamed As List(Of CityWeather)
		Private capitalNames As List(Of String)
		Private disposed As Boolean = False

		Public Property LosAngelesWeather() As CityWeather
		Public ReadOnly Property WeatherInCities() As List(Of CityWeather)
			Get
				Return weatherInCities_Renamed
			End Get
		End Property

		Public Event ReadCompleted As EventHandler

		Public Sub New(ByVal capitalNames As List(Of String))
			Me.capitalNames = capitalNames
		End Sub
		Protected Overrides Sub Finalize()
			Dispose(False)
		End Sub

		Private Sub weatherClient_OpenReadCompleted(ByVal sender As Object, ByVal e As OpenReadCompletedEventArgs)
			Dim weatherClient As WebClient = TryCast(sender, WebClient)
			RemoveHandler weatherClient.OpenReadCompleted, AddressOf weatherClient_OpenReadCompleted

			If e.Cancelled OrElse e.Error IsNot Nothing Then
				Return
			End If

			Dim stream As Stream = e.Result
			Task.Factory.StartNew(Function() AnonymousMethod1(stream))
		End Sub
		
		Private Function AnonymousMethod1(ByVal stream As Stream) As Boolean
			Dim dc As New DataContractJsonSerializer(GetType(WorldWeatherInfo))
			Dim worldWeatherInfo As WorldWeatherInfo = CType(dc.ReadObject(stream), WorldWeatherInfo)
			Dim citiesWeather As New List(Of CityWeather)()
			For Each weatherInfo As CityCurrentWeatherInfo In worldWeatherInfo.list
				Dim cityWeather As New CityWeather(weatherInfo)
				If cityWeather.City Is "Los Angeles" Then
					LosAngelesWeather = cityWeather
				End If
					If cityWeather.WeatherDescriptions IsNot Nothing AndAlso cityWeather.WeatherDescriptions.Count > 0 Then
						cityWeather.WeatherIconPath = OpenWeatherIconPathPrefix & cityWeather.WeatherDescriptions(0).IconName & ".png"
					End If
						Dim cityWithId As String = String.Format("{0};{1}", cityWeather.City, cityWeather.CityID)
						If capitalNames.Contains(cityWeather.City) OrElse capitalNames.Contains(cityWithId) Then
							citiesWeather.Add(cityWeather)
						End If
			Next weatherInfo
			weatherInCities_Renamed = citiesWeather
			RaiseReadComplete()
			Return True
		End Function
		Private forecastClient As New WebClient()
		Private Sub forecastClient_OpenReadCompleted(ByVal sender As Object, ByVal e As OpenReadCompletedEventArgs)
			If e.Error Is Nothing Then
				RemoveHandler forecastClient.OpenReadCompleted, AddressOf forecastClient_OpenReadCompleted
				Dim stream As Stream = e.Result
				Dim cityWeatherInfo As CityWeather = CType(e.UserState, CityWeather)
				Task.Factory.StartNew(Function() AnonymousMethod2(stream, cityWeatherInfo))
			End If
		End Sub
		
		Private Function AnonymousMethod2(ByVal stream As Stream, ByVal cityWeatherInfo As CityWeather) As Boolean
			SyncLock forecastLocker
				Dim forecast As ForecastInfo = ReadForecast(stream)
				cityWeatherInfo.SetForecast(forecast)
			End SyncLock
			Return True
		End Function
		Private Function ReadForecast(ByVal stream As Stream) As ForecastInfo
			Dim forecast As ForecastInfo = Nothing
			Try
				Dim dc As New DataContractJsonSerializer(GetType(ForecastInfo))
				forecast = CType(dc.ReadObject(stream), ForecastInfo)
			Catch
				forecast = Nothing
			End Try
			Return forecast
		End Function
		Private Sub RaiseReadComplete()
			RaiseEvent ReadCompleted(Me, EventArgs.Empty)
		End Sub

		Protected Overridable Sub Dispose(ByVal disposing As Boolean)
			If disposed Then
				Return
			End If
			If disposing Then
				If forecastClient IsNot Nothing Then
					RemoveHandler forecastClient.OpenReadCompleted, AddressOf forecastClient_OpenReadCompleted
					forecastClient.Dispose()
					forecastClient = Nothing
				End If
			End If
			disposed = True
		End Sub

		Public Sub GetWeatherAsync()
			Dim weatherClient As New WebClient()
			AddHandler weatherClient.OpenReadCompleted, AddressOf weatherClient_OpenReadCompleted
			weatherClient.OpenReadAsync(New Uri(OpenWeatherUrl & OpenWeatherKey))
		End Sub
		Public Sub GetForecastForCityAsync(ByVal cityWeather As CityWeather)
			Dim link As String = String.Format("http://api.openweathermap.org/data/2.5/forecast?units=metric&id={0}&APPID={1}", cityWeather.CityID.ToString(), OpenWeatherKey)
			If forecastClient.IsBusy Then
				Return
			End If
			AddHandler forecastClient.OpenReadCompleted, AddressOf forecastClient_OpenReadCompleted
			forecastClient.OpenReadAsync(New Uri(link), cityWeather)
		End Sub
		Public Sub Dispose() Implements IDisposable.Dispose
			Dispose(True)
			GC.SuppressFinalize(Me)
		End Sub
	End Class

End Namespace
