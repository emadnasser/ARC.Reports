Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Globalization
Imports System.Windows.Data
Imports System.Windows.Media
Imports System.Xml.Linq
Imports DevExpress.Xpf.Charts
Imports DevExpress.Xpf.DemoBase
Imports DevExpress.Xpf.Map

Namespace ChartsDemo
    <CodeFile("Modules/Interactivity/SelectionControl(.SL).xaml"), CodeFile("Modules/Interactivity/SelectionControl.xaml.(cs)")>
    Partial Public Class SelectionControl
        Inherits ChartsDemoModule

        Private viewModel As New DashboardViewModel()

        Public Overrides ReadOnly Property ActualChart() As ChartControlBase
            Get
                Return pieChart
            End Get
        End Property

        Public Sub New()
            InitializeComponent()
            DataContext = viewModel
        End Sub

        Private Sub ShapefileLoader_ShapesLoaded(ByVal sender As Object, ByVal e As ShapesLoadedEventArgs)
            viewModel.SetMapItems(e.Shapes)
        End Sub
    End Class

    Public Class CountryStatisticInfo

        Private ReadOnly name_Renamed As String
        Private ReadOnly area As Double
        Private ReadOnly statistic As List(Of PopulationStatisticByYear)

        Private shape_Renamed As WeakReference

        Public ReadOnly Property Name() As String
            Get
                Return name_Renamed
            End Get
        End Property
        Public ReadOnly Property AreaMSqrKilometers() As Double
            Get
                Return area
            End Get
        End Property
        Public ReadOnly Property PopulationDynamic() As List(Of PopulationStatisticByYear)
            Get
                Return statistic
            End Get
        End Property
        Public Property Shape() As MapItem
            Get
                Return If(shape_Renamed IsNot Nothing, DirectCast(shape_Renamed.Target, MapItem), Nothing)
            End Get
            Set(ByVal value As MapItem)
                If value Is Nothing Then
                    shape_Renamed = Nothing
                Else
                    If shape_Renamed Is Nothing OrElse shape_Renamed.Target IsNot value Then
                        shape_Renamed = New WeakReference(value)
                    End If
                End If
            End Set
        End Property

        Public Sub New(ByVal name As String, ByVal areaMSqrKilometers As Double, ByVal statistic As List(Of PopulationStatisticByYear))
            Me.name_Renamed = name
            Me.area = areaMSqrKilometers
            Me.statistic = statistic
        End Sub
    End Class

    Public Class PopulationStatisticByYear

        Private year_Renamed As Integer

        Private populationMillionsOfPeople_Renamed As Double

        Private urbanPercent_Renamed As Double

        Public ReadOnly Property Year() As Integer
            Get
                Return year_Renamed
            End Get
        End Property
        Public ReadOnly Property PopulationMillionsOfPeople() As Double
            Get
                Return populationMillionsOfPeople_Renamed
            End Get
        End Property
        Public ReadOnly Property UrbanPercent() As Double
            Get
                Return urbanPercent_Renamed
            End Get
        End Property
        Public ReadOnly Property RuralPercent() As Double
            Get
                Return 100 - urbanPercent_Renamed
            End Get
        End Property

        Public Sub New(ByVal year As Integer, ByVal populationMillionsOfPeople As Double, ByVal urbanPercent As Double)
            Me.year_Renamed = year
            Me.populationMillionsOfPeople_Renamed = populationMillionsOfPeople
            Me.urbanPercent_Renamed = urbanPercent
        End Sub
    End Class

    Friend Class CountriesInfoDataReader
        Private Const UriToXmlFile As String = "/Data/Top10LargestCountriesInfo.xml"

        Private Shared Function LoadStatistic(ByVal populationDynamic As XElement) As List(Of PopulationStatisticByYear)
            Dim statistic As New List(Of PopulationStatisticByYear)()
            For Each populationDynamicItem As XElement In populationDynamic.Elements("PopulationStatisticByYear")
                Dim year As Integer = Integer.Parse(populationDynamicItem.Element("Year").Value)
                Dim population As Long = Long.Parse(populationDynamicItem.Element("Population").Value)
                Dim urbanPercent As Double = Double.Parse(populationDynamicItem.Element("UrbanPercent").Value, CultureInfo.InvariantCulture)
                Dim popDynamicItem As New PopulationStatisticByYear(year, CDbl(population) / 1000000.0, urbanPercent)
                statistic.Add(popDynamicItem)
            Next populationDynamicItem
            Return statistic
        End Function

        Public Shared Function Load() As List(Of CountryStatisticInfo)
            Dim data As New List(Of CountryStatisticInfo)()
            Try
                Dim Top10LargestCountriesInfo_xml As XDocument = DataLoader.LoadXmlFromResources(UriToXmlFile)
                For Each countryInfo As XElement In Top10LargestCountriesInfo_xml.Root.Elements("CountryInfo")
                    Dim name As String = countryInfo.Element("Name").Value
                    Dim areaSqKm As Double = UInteger.Parse(countryInfo.Element("AreaSqrKilometers").Value)
                    Dim statistic As List(Of PopulationStatisticByYear) = LoadStatistic(countryInfo.Element("Statistic"))
                    Dim countryInfoInstance As New CountryStatisticInfo(name, areaSqKm / 1000000, statistic)
                    data.Add(countryInfoInstance)
                Next countryInfo
            Catch
            End Try
            Return data
        End Function
    End Class

    Public Class DashboardViewModel
        Implements INotifyPropertyChanged


        Private ReadOnly countriesData_Renamed As List(Of CountryStatisticInfo)

        Private selectedCountry_Renamed As CountryStatisticInfo

        Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged

        Public ReadOnly Property CountriesData() As List(Of CountryStatisticInfo)
            Get
                Return countriesData_Renamed
            End Get
        End Property
        Public Property SelectedCountry() As CountryStatisticInfo
            Get
                Return selectedCountry_Renamed
            End Get
            Set(ByVal value As CountryStatisticInfo)
                If selectedCountry_Renamed IsNot value Then
                    selectedCountry_Renamed = value
                    OnPropertyChanged("SelectedCountry")
                End If
            End Set
        End Property

        Public Sub New()
            countriesData_Renamed = CountriesInfoDataReader.Load()
            SelectedCountry = countriesData_Renamed(0)
        End Sub

        Private Sub OnPropertyChanged(ByVal propertyName As String)
            Dim propertyChangedEventHendler As PropertyChangedEventHandler = PropertyChangedEvent
            If propertyChangedEventHendler IsNot Nothing Then
                propertyChangedEventHendler(Me, New PropertyChangedEventArgs(propertyName))
            End If
        End Sub

        Public Sub SetMapItems(ByVal layerMapItemCollection As IList(Of MapItem))
            For Each item As MapItem In layerMapItemCollection
                Dim shapeName As String = If(item.Attributes("NAME") IsNot Nothing, CStr(item.Attributes("NAME").Value), String.Empty)
                Dim countryInfo As CountryStatisticInfo = countriesData_Renamed.Find(Function(info) info.Name = shapeName)
                If countryInfo IsNot Nothing Then
                    countryInfo.Shape = item
                End If
                item.Attributes.Add(New MapItemAttribute() With {.Name = "CountryInfo", .Type = GetType(CountryStatisticInfo), .Value = countryInfo})
            Next item
        End Sub
    End Class

    Public Class SelectedMapItemConverter
        Implements IValueConverter

        Private Function IValueConverter_Convert(ByVal value As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal culture As CultureInfo) As Object Implements IValueConverter.Convert
            If value Is Nothing Then
                Return Nothing
            End If
            Dim country As CountryStatisticInfo = DirectCast(value, CountryStatisticInfo)
            Return country.Shape
        End Function
        Private Function IValueConverter_ConvertBack(ByVal value As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal culture As CultureInfo) As Object Implements IValueConverter.ConvertBack
            Dim selectedShape As MapItem = DirectCast(value, MapItem)
            Return selectedShape.Attributes("CountryInfo").Value
        End Function
    End Class

    Public Class ChartPaletteToMapColorsConverter
        Implements IValueConverter

        Private Function IValueConverter_Convert(ByVal value As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal culture As CultureInfo) As Object Implements IValueConverter.Convert
            Dim chartColors As Palette = DirectCast(value, Palette)
            Dim rangeStops As DoubleCollection = DirectCast(parameter, DoubleCollection)
            Dim colorsCount As Integer = CInt((rangeStops(rangeStops.Count - 1) - rangeStops(0))) + 1
            Dim mapColors As New DevExpress.Xpf.Map.ColorCollection()
            For i As Integer = 0 To colorsCount - 1
                mapColors.Add(chartColors(i))
            Next i
            Return mapColors
        End Function
        Private Function IValueConverter_ConvertBack(ByVal value As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal culture As CultureInfo) As Object Implements IValueConverter.ConvertBack
            Return Nothing
        End Function
    End Class
End Namespace
