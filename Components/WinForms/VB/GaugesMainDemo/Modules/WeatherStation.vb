Imports Microsoft.VisualBasic
Imports System
Imports System.ComponentModel
Imports System.Reflection
Imports System.Windows.Forms
Imports System.Xml.Serialization
Imports DevExpress.Utils

Namespace DevExpress.XtraGauges.Demos
    Partial Public Class WeatherStation
        Inherits TutorialControl

        Private data As BindingList(Of DemoWetherData)

        Public Sub New()
            InitializeComponent()
            UpdateWeather("London(Offline data)")
        End Sub
        Sub simpleButton1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles simpleButton1.Click
            UpdateWeather(comboBoxEdit1.EditValue.ToString())
        End Sub
        Protected Sub UpdateWeather(ByVal place As String)
            Dim wfc As net.webservicex.www.WeatherForecasts = GetWeatherByPlaceNameSafe(place)
            If wfc Is Nothing Then
                Return
            End If
            InitDataSource(wfc)
            InitCharts()
            InitGauge()
        End Sub
        Protected Sub InitDataSource(ByVal wfc As net.webservicex.www.WeatherForecasts)
            Try
                Try
                    If data Is Nothing Then
                        data = New BindingList(Of DemoWetherData)()
                    Else
                        data.Clear()
                    End If
                Catch
                End Try
                Dim counter As Integer = 0
                For Each wd As net.webservicex.www.WeatherData In wfc.Details
                    Dim minT As String
                    If comboBoxEdit2.Text.StartsWith("C") Then
                        minT = wd.MinTemperatureC
                    Else
                        minT = wd.MinTemperatureF
                    End If
                    Dim maxT As String
                    If comboBoxEdit2.Text.StartsWith("C") Then
                        maxT = wd.MaxTemperatureC
                    Else
                        maxT = wd.MaxTemperatureF
                    End If
                    Dim min As Integer = Integer.Parse(minT)
                    Dim max As Integer = Integer.Parse(maxT)

                    data.Add(New DemoWetherData(min, max, (min + max) \ 2, counter))
                    counter += 1
                Next wd
            Catch
            End Try
        End Sub
        Protected Sub InitGauge()
            If linearScaleComponent1.DataBindings.Count = 0 Then
                linearScaleComponent1.DataBindings.Add("Value", data, "CurrentTemperature")
            End If
        End Sub
        Protected Sub InitCharts()
            If chartControl1.DataSource IsNot data Then
                chartControl1.DataSource = data
                chartControl1.Series(0).ArgumentDataMember = "Day"
                chartControl1.Series(0).ValueDataMembers(0) = "MinTemperature"

                chartControl1.Series(1).ArgumentDataMember = "Day"
                chartControl1.Series(1).ValueDataMembers(0) = "MaxTemperature"
            Else
                chartControl1.Invalidate()
            End If

        End Sub
        Protected Function GetWeatherByPlaceNameSafe(ByVal place As String) As net.webservicex.www.WeatherForecasts
            Cursor = Cursors.WaitCursor
            Dim wfc As net.webservicex.www.WeatherForecasts = Nothing
            Try
                Using dlg As WaitDialogForm = New WaitDialogForm("Loading weather at " & place)
                    If place.Contains("Offline") Then
                        Dim serializer As XmlSerializer = New XmlSerializer(GetType(net.webservicex.www.WeatherForecasts))
                        wfc = CType(serializer.Deserialize(System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceStream("weather.xml")), net.webservicex.www.WeatherForecasts)
                    Else
                        Dim service As net.webservicex.www.WeatherForecast = New net.webservicex.www.WeatherForecast()
                        wfc = service.GetWeatherByPlaceName(place)
                    End If
                End Using
            Catch
                MessageBox.Show("could not retrive weather data for " & place)
                Cursor = Cursors.Arrow
                Return Nothing
            End Try
            If wfc.Details Is Nothing Then
                MessageBox.Show("could not retrive weather data for " & place)
                Cursor = Cursors.Arrow
                Return Nothing
            End If
            Cursor = Cursors.Arrow
            Return wfc
        End Function
    End Class

    Public Class DemoWetherData
        Private minTemperatureCore As Integer
        Private maxTemperatureCore As Integer
        Private dayCore As Integer
        Private currentTemperature_Renamed As Integer

        Public Property MinTemperature() As Integer
            Get
                Return minTemperatureCore
            End Get
            Set(ByVal value As Integer)
                minTemperatureCore = value
            End Set
        End Property
        Public Property MaxTemperature() As Integer
            Get
                Return maxTemperatureCore
            End Get
            Set(ByVal value As Integer)
                maxTemperatureCore = value
            End Set
        End Property
        Public Property Day() As Integer
            Get
                Return dayCore
            End Get
            Set(ByVal value As Integer)
                dayCore = value
            End Set
        End Property
        Public Property CurrentTemperature() As Integer
            Get
                Return currentTemperature_Renamed
            End Get
            Set(ByVal value As Integer)
                currentTemperature_Renamed = value
            End Set
        End Property

        Public Sub New(ByVal minT As Integer, ByVal maxT As Integer, ByVal currentTemperature As Integer, ByVal day As Integer)
            Me.Day = day
            MinTemperature = minT
            MaxTemperature = maxT
            Me.CurrentTemperature = currentTemperature
        End Sub
    End Class
End Namespace
