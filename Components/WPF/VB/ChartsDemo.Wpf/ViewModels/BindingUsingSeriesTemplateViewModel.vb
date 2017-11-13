Imports DevExpress.Mvvm.Native
Imports System
Imports System.Collections.Generic
Imports System.Globalization
Imports System.Linq

Namespace ChartsDemo
    Public Class BindingUsingSeriesTemplateViewModel

        Private dataSource_Renamed As IEnumerable(Of GDPItem)

        Private series_Renamed As IEnumerable(Of ChartDataBindingControlSeriesViewModel)

        Public Sub New()
            ShowLabels = True
            SelectedSeries = Me.Series.First()
        End Sub
        Public ReadOnly Property DataSource() As IEnumerable(Of GDPItem)
            Get
                If dataSource_Renamed Is Nothing Then
                    dataSource_Renamed = DataLoader.LoadXmlFromResources("/Data/GDPofG7.xml").Element("G7GDPs").Elements().Where(Function(e) Integer.Parse(e.Element("Year").Value) > 2010).Select(Function(e) New GDPItem(e.Element("Country").Value, e.Element("Year").Value, Convert.ToDouble(e.Element("Product").Value, CultureInfo.InvariantCulture))).OrderBy(Function(gdpItem) gdpItem.Year).ToList()
                End If
                Return dataSource_Renamed
            End Get
        End Property
        Public ReadOnly Property Series() As IEnumerable(Of ChartDataBindingControlSeriesViewModel)
            Get
                If series_Renamed Is Nothing Then
                    Dim series2 = New ChartDataBindingControlSeriesViewModel("Year", "Country", True)
                    Dim series1 = New ChartDataBindingControlSeriesViewModel("Country", "Year", False)
                    series_Renamed = New ChartDataBindingControlSeriesViewModel() { series1, series2 }
                End If
                Return series_Renamed
            End Get
        End Property
        Public Overridable Property ShowLabels() As Boolean
        Public Overridable Property SelectedSeries() As ChartDataBindingControlSeriesViewModel
        Public Overridable ReadOnly Property ChartAnimationService() As IChartAnimationService
            Get
                Return Nothing
            End Get
        End Property
        Public Sub OnModuleAppear()
            If ChartAnimationService IsNot Nothing Then
                ChartAnimationService.Animate()
            End If
        End Sub
        Protected Sub OnSelectedSeriesChanged(ByVal oldValue As ChartDataBindingControlSeriesViewModel)
            If ChartAnimationService IsNot Nothing Then
                ChartAnimationService.Animate()
            End If
        End Sub
    End Class


    Public Class ChartDataBindingControlSeriesViewModel
        Public Sub New(ByVal dataMember As String, ByVal argumentDataMember As String, ByVal staggered As Boolean)
            Me.DataMember = dataMember
            Me.ArgumentDataMember = argumentDataMember
            Me.Staggered = staggered
        End Sub
        Private privateDataMember As String
        Public Property DataMember() As String
            Get
                Return privateDataMember
            End Get
            Private Set(ByVal value As String)
                privateDataMember = value
            End Set
        End Property
        Private privateArgumentDataMember As String
        Public Property ArgumentDataMember() As String
            Get
                Return privateArgumentDataMember
            End Get
            Private Set(ByVal value As String)
                privateArgumentDataMember = value
            End Set
        End Property
        Private privateStaggered As Boolean
        Public Property Staggered() As Boolean
            Get
                Return privateStaggered
            End Get
            Private Set(ByVal value As Boolean)
                privateStaggered = value
            End Set
        End Property
    End Class

    Public Class GDPItem
        Public Sub New(ByVal region As String, ByVal year As String, ByVal product As Double)
            Country = region
            Me.Year = year
            Me.Product = product
        End Sub
        Private privateProduct As Double
        Public Property Product() As Double
            Get
                Return privateProduct
            End Get
            Private Set(ByVal value As Double)
                privateProduct = value
            End Set
        End Property
        Private privateCountry As String
        Public Property Country() As String
            Get
                Return privateCountry
            End Get
            Private Set(ByVal value As String)
                privateCountry = value
            End Set
        End Property
        Private privateYear As String
        Public Property Year() As String
            Get
                Return privateYear
            End Get
            Private Set(ByVal value As String)
                privateYear = value
            End Set
        End Property
    End Class
End Namespace
