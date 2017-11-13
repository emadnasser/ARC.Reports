Imports System
Imports System.Collections.Generic
Imports System.Globalization
Imports System.Xml.Linq
Imports DevExpress.Xpf.Charts
Imports DevExpress.Xpf.DemoBase

Namespace ChartsDemo
    <CodeFile("Modules/DataBinding/TagPropertyControl(.SL).xaml"), CodeFile("Modules/DataBinding/TagPropertyControl.xaml.(cs)")>
    Partial Public Class TagPropertyControl
        Inherits ChartsDemoModule

        Public Overrides ReadOnly Property ActualChart() As ChartControlBase
            Get
                Return chart
            End Get
        End Property

        Public Sub New()
            InitializeComponent()
            chart.Diagram.Series(0).DataSource = CreateDataSource()
        End Sub
        Private Sub ChartsDemoModule_ModuleAppear(ByVal sender As Object, ByVal e As System.Windows.RoutedEventArgs)
            chart.Animate()
        End Sub
        Private Sub chart_CustomDrawSeriesPoint(ByVal sender As Object, ByVal e As CustomDrawSeriesPointEventArgs)
            e.LegendText = CType(e.SeriesPoint.Tag, Country).OfficialName
        End Sub
        Private Function CreateDataSource() As List(Of Country)
            Dim document As XDocument = DataLoader.LoadXmlFromResources("/Data/Countries.xml")
            Dim countries As New List(Of Country)()
            If document IsNot Nothing Then
                For Each element As XElement In document.Element("Countries").Elements()
                    Dim area As Double = Convert.ToDouble(element.Element("Area").Value, CultureInfo.InvariantCulture)
                    Dim name As String = element.Element("Name").Value
                    Dim officialName As String = element.Element("OfficialName").Value
                    countries.Add(New Country(name, officialName, area))
                Next element
            End If
            Return countries
        End Function
    End Class

    Public Class Country

        Private ReadOnly area_Renamed As Double

        Private ReadOnly name_Renamed As String

        Private ReadOnly officialName_Renamed As String

        Public ReadOnly Property Area() As Double
            Get
                Return area_Renamed
            End Get
        End Property
        Public ReadOnly Property Name() As String
            Get
                Return name_Renamed
            End Get
        End Property
        Public ReadOnly Property OfficialName() As String
            Get
                Return officialName_Renamed
            End Get
        End Property

        Public Sub New(ByVal name As String, ByVal officialName As String, ByVal area As Double)
            Me.name_Renamed = name
            Me.area_Renamed = area
            Me.officialName_Renamed = officialName
        End Sub
    End Class
End Namespace
