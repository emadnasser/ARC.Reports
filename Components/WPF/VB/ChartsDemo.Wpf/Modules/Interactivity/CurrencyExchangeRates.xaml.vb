Imports System
Imports System.Collections.Generic
Imports System.Globalization
Imports System.Windows
Imports System.Xml.Linq
Imports DevExpress.Xpf.DemoBase
Imports DevExpress.Xpf.Charts

Namespace ChartsDemo
    <CodeFile("Modules/Interactivity/CurrencyExchangeRates(.SL).xaml"), CodeFile("Modules/Interactivity/CurrencyExchangeRates.xaml.(cs)")>
    Partial Public Class CurrencyExchangeRates
        Inherits ChartsDemoModule

        Public Overrides ReadOnly Property ActualChart() As ChartControlBase
            Get
                Return chart
            End Get
        End Property

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub ChartsDemoModule_Loaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
            DataContext = New ExchangeRatesModel()
        End Sub
    End Class

    Public Class ExchangeRatesModel
        Private rate1Name As String
        Private rate2Name As String

        Private ReadOnly _rate1 As New List(Of PriceByDate)()
        Private ReadOnly _rate2 As New List(Of PriceByDate)()

        Public ReadOnly Property Rate1() As List(Of PriceByDate)
            Get
                Return _rate1
            End Get
        End Property
        Public ReadOnly Property Rate2() As List(Of PriceByDate)
            Get
                Return _rate2
            End Get
        End Property
        Public ReadOnly Property Rate1Title() As String
            Get
                Return rate1Name
            End Get
        End Property
        Public ReadOnly Property Rate2Title() As String
            Get
                Return rate2Name
            End Get
        End Property

        Public Sub New()
            rate1Name = "GBPUSD"
            rate2Name = "EURUSD"
            LoadPoints(_rate1, LoadFromFile("/Data/GbpUsdRate.xml"))
            LoadPoints(_rate2, LoadFromFile("/Data/EurUsdRate.xml"))
        End Sub
        Private Function LoadFromFile(ByVal xmlFile As String) As XDocument
            Return DataLoader.LoadXmlFromResources(xmlFile)
        End Function
        Private Sub LoadPoints(ByVal rate As List(Of PriceByDate), ByVal document As XDocument)
            If rate IsNot Nothing AndAlso document IsNot Nothing Then
                For Each element As XElement In document.Descendants("CurrencyRate")
                    Dim [date] As Date = Date.Parse(element.Element("DateTime").Value)
                    Dim price As Double = Double.Parse(element.Element("Rate").Value, CultureInfo.InvariantCulture)
                    rate.Add(New PriceByDate([date], price))
                Next element
            End If
        End Sub
    End Class
End Namespace
