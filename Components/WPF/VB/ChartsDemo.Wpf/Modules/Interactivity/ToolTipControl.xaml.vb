Imports System
Imports System.Collections.Generic
Imports System.Globalization
Imports System.IO
Imports System.Linq
Imports System.Windows
Imports System.Windows.Media
Imports System.Xml
Imports DevExpress.Xpf.Charts
Imports DevExpress.Xpf.DemoBase

Namespace ChartsDemo
    <CodeFile("Modules/Interactivity/ToolTipControl(.SL).xaml"), CodeFile("Modules/Interactivity/ToolTipControl.xaml.(cs)")>
    Partial Public Class ToolTipControl
        Inherits ChartsDemoModule

        Private ttMousePosition As New ToolTipMousePosition()
        Private ttRelativePosition As New ToolTipRelativePosition()
        Private ttFreePosition As New ToolTipFreePosition() With {.Offset = New Point(16, 16)}

        Public Overrides ReadOnly Property ActualChart() As ChartControlBase
            Get
                Return chart
            End Get
        End Property

        Public Sub New()
            InitializeComponent()
            ttFreePosition.DockTarget = defaultPane
            ToolTipControlHelper.PrepareToolTipPositionComboBox(cbToolTipPosition)
            ToolTipControlHelper.PrepareToolTipLocationComboBox(cbToolTipLocation)
            chart.DataSource = GetDataSource()
        End Sub

        Private Sub cbToolTipPosition_SelectedIndexChanged(ByVal sender As Object, ByVal e As RoutedEventArgs)
            ChangeOptionsView()
            Select Case cbToolTipPosition.SelectedIndex
                Case 0
                    ttMousePosition.Location = ToolTipControlHelper.GetLocationFromComboBox(cbToolTipLocation.SelectedIndex)
                    chart.ToolTipOptions.ToolTipPosition = ttMousePosition
                Case 1
                    ttRelativePosition.Location = ToolTipControlHelper.GetLocationFromComboBox(cbToolTipLocation.SelectedIndex)
                    chart.ToolTipOptions.ToolTipPosition = ttRelativePosition
                Case 2
                    chart.ToolTipOptions.ToolTipPosition = ttFreePosition
            End Select
        End Sub
        Private Sub cbToolTipLocation_SelectedIndexChanged(ByVal sender As Object, ByVal e As RoutedEventArgs)
            ttMousePosition.Location = ToolTipControlHelper.GetLocationFromComboBox(cbToolTipLocation.SelectedIndex)
            ttRelativePosition.Location = ToolTipControlHelper.GetLocationFromComboBox(cbToolTipLocation.SelectedIndex)
        End Sub
        Private Sub ToolTipController_ToolTipOpening(ByVal sender As Object, ByVal e As ChartToolTipEventArgs)
            Dim g7Member As G7Member = TryCast(e.SeriesPoint.Tag, G7Member)
            e.Hint = g7Member
            Dim colorNumber As Integer = e.Series.Points.IndexOf(e.SeriesPoint)
            Dim seriesColor As Color = e.ChartControl.Palette(colorNumber)
            g7Member.SeriesBrush = New SolidColorBrush(seriesColor)
        End Sub
        Private Sub ChangeOptionsView()
            If cbToolTipPosition.SelectedIndex = 2 Then
                cbToolTipLocation.IsEnabled = False
                chbShowBeak.IsEnabled = False
            Else
                cbToolTipLocation.IsEnabled = True
                chbShowBeak.IsEnabled = True
            End If
        End Sub
        Private Function GetDataSource() As List(Of G7Member)
            Dim countries As New List(Of G7Member)()
            Dim xmlStream As Stream = Application.GetResourceStream(New Uri("pack://application:,,,/ChartsDemo;component/Data/GDPofG7.xml")).Stream
            Dim document As New XmlDocument()
            document.Load(xmlStream)
            If document IsNot Nothing Then
                Dim elements As XmlNodeList = document.DocumentElement.GetElementsByTagName("GDP")
                For Each element As XmlNode In elements
                    Dim country As String = element.ChildNodes(0).InnerText
                    Dim year As Integer = Integer.Parse(element.ChildNodes(1).InnerText)
                    Dim product As Decimal = Convert.ToDecimal(element.ChildNodes(2).InnerText, CultureInfo.InvariantCulture)
                    Dim currentG7Member As G7Member = countries.Find(Function(c) c.CountryName = country)
                    If currentG7Member Is Nothing Then
                        currentG7Member = New G7Member(country, countries.Count)
                        countries.Add(currentG7Member)
                    End If
                    currentG7Member.GDPs.Add(New GDP(year, product))
                Next element
            End If
            xmlStream.Close()
            Return countries
        End Function
    End Class


    Public Class G7Member
        Public ReadOnly Property GDPin2015() As Decimal
            Get
                Return GDPs.First(Function(gdp) gdp.Year = 2015).Product
            End Get
        End Property
        Private privateCountryName As String
        Public Property CountryName() As String
            Get
                Return privateCountryName
            End Get
            Private Set(ByVal value As String)
                privateCountryName = value
            End Set
        End Property
        Private privateGDPs As List(Of GDP)
        Public Property GDPs() As List(Of GDP)
            Get
                Return privateGDPs
            End Get
            Private Set(ByVal value As List(Of GDP))
                privateGDPs = value
            End Set
        End Property
        Public Property SeriesBrush() As SolidColorBrush
        Private privateColorNumberInPalette As Integer
        Public Property ColorNumberInPalette() As Integer
            Get
                Return privateColorNumberInPalette
            End Get
            Private Set(ByVal value As Integer)
                privateColorNumberInPalette = value
            End Set
        End Property

        Public Sub New(ByVal country As String, ByVal colorNumberInPalette As Integer)
            Me.CountryName = country
            Me.GDPs = New List(Of GDP)()
            Me.ColorNumberInPalette = colorNumberInPalette
        End Sub
    End Class


    Public Class GDP
        Private privateYear As Integer
        Public Property Year() As Integer
            Get
                Return privateYear
            End Get
            Private Set(ByVal value As Integer)
                privateYear = value
            End Set
        End Property
        Private privateProduct As Decimal
        Public Property Product() As Decimal
            Get
                Return privateProduct
            End Get
            Private Set(ByVal value As Decimal)
                privateProduct = value
            End Set
        End Property

        Public Sub New(ByVal year As Integer, ByVal product As Decimal)
            Me.Year = year
            Me.Product = product
        End Sub
    End Class

End Namespace
