Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.Skins
Imports DevExpress.XtraGauges.Core.Drawing
Imports DevExpress.XtraGauges.Core.Model
Imports DevExpress.XtraGauges.Win.Base
Imports DevExpress.XtraGauges.Win.Gauges.Circular
Imports System.Linq
Imports System.Net
Imports System.IO
Imports System.Runtime.Serialization
Imports System.Runtime.Serialization.Json
Imports DevExpress.Utils
Imports DevExpress.XtraSplashScreen

Namespace DevExpress.XtraGauges.Demos
    Partial Public Class StateImageIndicatorWeatherStation
        Inherits TutorialControl

        Private Const OpenWeatherUrl As String = "http://api.openweathermap.org/data/2.5/box/city?bbox=-180,-90,180,90&cluster=yes&APPID="
        Private Const OpenWeatherIconPathPrefix As String = "http://openweathermap.org/img/w/"
        Private Const OpenWeatherKey As String = "06ab6900f3546d4b19d5cfd369a232ed"
        Private [date] As New Date(1900, 1, 1)
        Private seasons() As String = {"Winter", "Spring", "Summer", "Autumn"}
        Private updateTimer As New Timer()
        Public Sub New()
            InitializeComponent()
            scHumidityLA.EnableAnimation = True
            scHumidityLA.EasingMode = Core.Model.EasingMode.EaseInOut
            scHumidityLA.EasingFunction = New CubicEase()
            scTempLA.EnableAnimation = True
            scTempLA.EasingMode = Core.Model.EasingMode.EaseInOut
            scTempLA.EasingFunction = New CubicEase()
            scHumidityLn.EnableAnimation = True
            scHumidityLn.EasingMode = Core.Model.EasingMode.EaseInOut
            scHumidityLn.EasingFunction = New CubicEase()
            scTempLn.EnableAnimation = True
            scTempLn.EasingMode = Core.Model.EasingMode.EaseInOut
            scTempLn.EasingFunction = New CubicEase()
            scHumidityMs.EnableAnimation = True
            scHumidityMs.EasingMode = Core.Model.EasingMode.EaseInOut
            scHumidityMs.EasingFunction = New CubicEase()
            scTempMs.EnableAnimation = True
            scTempMs.EasingMode = Core.Model.EasingMode.EaseInOut
            scTempMs.EasingFunction = New CubicEase()
            AddHandler LookAndFeel.StyleChanged, AddressOf OnStyleChanged
            updateTimer.Interval = 2000
            AddHandler updateTimer.Tick, AddressOf OnTimerTick
            UpdateColor()
            SplashScreenManager.ShowDefaultWaitForm(ParentForm, True, True, "", "Connecting...")
            LoadWeather()
            If SplashScreenManager.Default IsNot Nothing AndAlso SplashScreenManager.Default.IsSplashFormVisible Then
                SplashScreenManager.CloseDefaultWaitForm()
            End If
            If CityCurrentWeatherInfos Is Nothing Then
                UpdateWeatherLA()
                UpdateWeatherLN()
                UpdateWeatherMS()
            Else
                [date] = Date.Now
                UpdateDate()
                UpdateWeatherLA(GetNextCityWeatherInfo())
                UpdateWeatherMS(GetNextCityWeatherInfo())
                UpdateWeatherLN(GetNextCityWeatherInfo())
            End If
            updateTimer.Start()
        End Sub
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            updateTimer.Stop()
            MyBase.Dispose(disposing)
        End Sub
#Region "StateImageIndicator"
        Private r As New Random()
        Public ReadOnly Property HotColor() As Color
            Get
                Return SkinColorHelper.GetColor(LookAndFeel, "Critical")
            End Get
        End Property
        Public ReadOnly Property ColdColor() As Color
            Get
                Return SkinColorHelper.GetColor(LookAndFeel, "Question")
            End Get
        End Property
        Public ReadOnly Property RangeColor() As Color
            Get
                Return SkinColorHelper.GetColor(LookAndFeel, "DisabledText")
            End Get
        End Property
        Public ReadOnly Property TextColor() As Color
            Get
                Return SkinColorHelper.GetColor(LookAndFeel, "DisabledText")
            End Get
        End Property
        Private Sub OnStyleChanged(ByVal sender As Object, ByVal e As EventArgs)
            updateTimer.Stop()
            UpdateColor()
            If CityCurrentWeatherInfos Is Nothing Then
                UpdateWeatherLA()
                UpdateWeatherLN()
                UpdateWeatherMS()
            Else
                UpdateWeatherLA(GetNextCityWeatherInfo())
                UpdateWeatherMS(GetNextCityWeatherInfo())
                UpdateWeatherLN(GetNextCityWeatherInfo())
            End If
            updateTimer.Start()
        End Sub
        Private Sub UpdateColor()
            rbLnHumidity.AppearanceRangeBar.ContentBrush = New SolidBrushObject(RangeColor)
            rbLAHumidity.AppearanceRangeBar.ContentBrush = New SolidBrushObject(RangeColor)
            rbMsHumidity.AppearanceRangeBar.ContentBrush = New SolidBrushObject(RangeColor)
            gaugeControl4.ColorScheme.Color = HotColor
            gaugeControl3.ColorScheme.Color = HotColor
            gaugeControl5.ColorScheme.Color = HotColor
            scTempLA.AppearanceTickmarkText.TextBrush = New SolidBrushObject(TextColor)
            scTempLn.AppearanceTickmarkText.TextBrush = New SolidBrushObject(TextColor)
            scTempMs.AppearanceTickmarkText.TextBrush = New SolidBrushObject(TextColor)
        End Sub
        Private Sub OnTimerTick(ByVal sender As Object, ByVal e As EventArgs)
            If CityCurrentWeatherInfos Is Nothing Then
                [date] = [date].AddDays(r.Next(0, 30))
                UpdateDate()
                UpdateWeatherLA()
                UpdateWeatherLN()
                UpdateWeatherMS()
            Else
                [date] = Date.Now
                UpdateDate()
                UpdateWeatherLA(GetNextCityWeatherInfo())
                UpdateWeatherMS(GetNextCityWeatherInfo())
                UpdateWeatherLN(GetNextCityWeatherInfo())
            End If

        End Sub
        Private Sub UpdateDate()
            Dim s() As String = [date].ToString("dd MMMM").Split(" "c)
            lcDay.Text = s(0)
            lcMonth.Text = s(1).ToUpper()
            If [date].Month = 12 OrElse ([date].Month >= 1 AndAlso [date].Month <= 2) Then
                lcSeason.Text = seasons(0).ToUpper()
            End If
            If [date].Month >= 3 AndAlso [date].Month <= 5 Then
                lcSeason.Text = seasons(1).ToUpper()
            End If
            If [date].Month >= 6 AndAlso [date].Month <= 8 Then
                lcSeason.Text = seasons(2).ToUpper()
            End If
            If [date].Month >= 9 AndAlso [date].Month <= 11 Then
                lcSeason.Text = seasons(3).ToUpper()
            End If
        End Sub
        Private Sub UpdateWeatherLN()
            Dim temp As Double = 10 * Math.Sin((([date].DayOfYear * Math.PI) / 90) / 2 - ((91 * Math.PI) / 180)) + r.Next(-5, 2) + 13
            Dim humidity As Integer = r.Next(65, 100)
            UpdateSityWeather(scTempLn, scHumidityLn, siiLn, lcLn, rbLnTemp, temp, humidity)
        End Sub
        Private Sub UpdateWeatherLA()
            Dim temp As Double = 7.5 * Math.Sin((([date].DayOfYear * Math.PI) / 90) / 2 - ((91 * Math.PI) / 180)) + r.Next(-2, 2) + 20.5
            Dim humidity As Integer = r.Next(40, 92)
            UpdateSityWeather(scTempLA, scHumidityLA, siiLA, lcLA, rbLATemp, temp, humidity)
        End Sub
        Private Sub UpdateWeatherMS()
            Dim temp As Double = 28 * Math.Sin((([date].DayOfYear * Math.PI) / 90) / 2 - ((91 * Math.PI) / 180)) + r.Next(0, 2)
            Dim humidity As Integer = r.Next(60, 100)
            UpdateSityWeather(scTempMs, scHumidityMs, siiMs, lcMs, rbMsTemp, temp, humidity)
        End Sub
        Private Sub UpdateWeatherLN(ByVal cityInfo As CityCurrentWeatherInfo)
            If cityInfo Is Nothing OrElse cityInfo.Main Is Nothing Then
                Return
            End If
            Dim temp As Double = cityInfo.Main.Temp
            Dim humidity As Integer = CInt((cityInfo.Main.Humidity))
            Dim weather As String = If(cityInfo.Weather.Count > 0, cityInfo.Weather(0).Main, String.Empty)
            labelControl5.Text = cityInfo.Name
            UpdateSityWeather(scTempLn, scHumidityLn, siiLn, lcLn, rbLnTemp, temp, humidity, weather)
        End Sub
        Private Sub UpdateWeatherLA(ByVal cityInfo As CityCurrentWeatherInfo)
            If cityInfo Is Nothing OrElse cityInfo.Main Is Nothing Then
                Return
            End If
            Dim temp As Double = cityInfo.Main.Temp
            Dim humidity As Integer = CInt((cityInfo.Main.Humidity))
            Dim weather As String = If(cityInfo.Weather.Count > 0, cityInfo.Weather(0).Main, String.Empty)
            labelControl1.Text = cityInfo.Name
            UpdateSityWeather(scTempLA, scHumidityLA, siiLA, lcLA, rbLATemp, temp, humidity, weather)
        End Sub
        Private Sub UpdateWeatherMS(ByVal cityInfo As CityCurrentWeatherInfo)
            If cityInfo Is Nothing OrElse cityInfo.Main Is Nothing Then
                Return
            End If
            Dim temp As Double = cityInfo.Main.Temp
            Dim humidity As Integer = CInt((cityInfo.Main.Humidity))
            Dim weather As String = If(cityInfo.Weather.Count > 0, cityInfo.Weather(0).Main, String.Empty)
            labelControl6.Text = cityInfo.Name
            UpdateSityWeather(scTempMs, scHumidityMs, siiMs, lcMs, rbMsTemp, temp, humidity, weather)
        End Sub
        Private Sub UpdateSityWeather(ByVal tempScale As ArcScaleComponent, ByVal humidityScale As ArcScaleComponent, ByVal imageIndicator As StateImageIndicatorComponent, ByVal label As LabelComponent, ByVal rangeBar As ArcScaleRangeBar, ByVal temp As Double, ByVal humidity As Integer, Optional ByVal weather As String = "")
            If tempScale Is Nothing OrElse humidityScale Is Nothing OrElse imageIndicator Is Nothing OrElse label Is Nothing OrElse rangeBar Is Nothing Then
                Return
            End If
            tempScale.Value = CSng(temp)
            If temp < 0 Then
                rangeBar.Appearance.ContentBrush = New SolidBrushObject(ColdColor)
                imageIndicator.Color = ColdColor
            Else
                rangeBar.Appearance.ContentBrush = New SolidBrushObject(HotColor)
                imageIndicator.Color = HotColor
            End If
            humidityScale.Value = humidity
            Dim color As String = String.Format("{0},{1},{2}", RangeColor.R, RangeColor.G, RangeColor.B)
            Dim color2 As String = If(temp < 0, String.Format("{0},{1},{2}", ColdColor.R, ColdColor.G, ColdColor.B), String.Format("{0},{1},{2}", HotColor.R, HotColor.G, HotColor.B))
            Dim temperature As String = If(temp <= 0, CInt((temp)).ToString(), "+" & CInt((temp)).ToString())
            label.Text = String.Format("<color={0}>t: {1}C    <br><color={2}>h: {3}%   ", color2, temperature, color, humidity)
            If String.IsNullOrEmpty(weather) Then
                If humidity > 85 Then
                    If temp >= 0 Then
                        imageIndicator.StateIndex = 2
                    Else
                        imageIndicator.StateIndex = 3
                    End If
                ElseIf humidity > 70 Then
                    imageIndicator.StateIndex = 1
                Else
                    imageIndicator.StateIndex = 0
                End If
            Else
                Select Case weather
                    Case "Rain"
                        imageIndicator.StateIndex = 2
                    Case "Clear"
                        imageIndicator.StateIndex = 0
                    Case "Snow"
                        imageIndicator.StateIndex = 3
                    Case Else
                        imageIndicator.StateIndex = 1
                End Select
            End If
        End Sub
#End Region
        Private counterCore As Integer = 0
        Private Function GetNextCityWeatherInfo() As CityCurrentWeatherInfo
            If CityCurrentWeatherInfos IsNot Nothing AndAlso CityCurrentWeatherInfos.Count <> 0 Then
                Return CityCurrentWeatherInfos(GetNextIndex())
            End If
            Return Nothing
        End Function
        Private Function GetNextIndex() As Integer
            If counterCore >= CityCurrentWeatherInfos.Count Then
                counterCore = 0
            End If
            Dim tempVar As Integer = counterCore
            counterCore += 1
            Return tempVar
        End Function
        Private ReadOnly Property CityCurrentWeatherInfos() As List(Of CityCurrentWeatherInfo)
            Get
                Return cityCurrentWeatherInfosCore
            End Get
        End Property
        Private cityCurrentWeatherInfosCore As List(Of CityCurrentWeatherInfo)
        Public Sub LoadWeather()
            Dim weatherClient As New WebClient()
            AddHandler weatherClient.OpenReadCompleted, AddressOf OnOpenReadCompleted
            Try
                weatherClient.OpenReadAsync(New Uri(OpenWeatherUrl + OpenWeatherKey))
            Catch
            End Try
        End Sub
        Private Sub OnOpenReadCompleted(ByVal sender As Object, ByVal e As OpenReadCompletedEventArgs)
            Dim weatherClient As WebClient = TryCast(sender, WebClient)
            RemoveHandler weatherClient.OpenReadCompleted, AddressOf OnOpenReadCompleted
            If e.Cancelled OrElse e.Error IsNot Nothing Then
                Return
            End If
            Dim stream As Stream = e.Result
            Dim dc As New DataContractJsonSerializer(GetType(WorldWeatherInfo))
            Try
                Dim worldWeatherInfo As WorldWeatherInfo = CType(dc.ReadObject(stream), WorldWeatherInfo)
                cityCurrentWeatherInfosCore = worldWeatherInfo.List.Where(Function(p) p.Name.Length <= 20).ToList()
            Catch
            End Try
        End Sub
        <DataContract>
        Public Class WorldWeatherInfo
            Public Sub New()
                List = New List(Of CityCurrentWeatherInfo)()
            End Sub
            <DataMember(Name:="list")>
            Public Property List() As List(Of CityCurrentWeatherInfo)
        End Class
        <DataContract>
        Public Class CityCurrentWeatherInfo
            Public Sub New()
                Weather = New List(Of WeatherDescriptionInfo)()
            End Sub
            <DataMember(Name:="name")>
            Public Property Name() As String
            <DataMember(Name:="main")>
            Public Property Main() As WeatherInfo
            <DataMember(Name:="weather")>
            Public Property Weather() As List(Of WeatherDescriptionInfo)
        End Class
        <DataContract>
        Public Class WeatherDescriptionInfo
            <DataMember(Name:="main")>
            Friend Property Main() As String
        End Class
        <DataContract>
        Public Class WeatherInfo
            <DataMember(Name:="temp")>
            Friend Property Temp() As Double
            <DataMember(Name:="humidity")>
            Friend Property Humidity() As Double
        End Class
    End Class
    Friend NotInheritable Class SkinColorHelper

        Private Sub New()
        End Sub

        Public Shared Function GetColor(ByVal provider As ISkinProvider, ByVal name As String) As Color
            Return CommonSkins.GetSkin(provider).Colors.GetColor(name)
        End Function
    End Class
End Namespace
