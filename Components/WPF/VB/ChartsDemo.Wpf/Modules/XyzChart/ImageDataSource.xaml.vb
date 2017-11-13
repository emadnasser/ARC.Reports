Imports System
Imports System.ComponentModel
Imports System.Windows.Media
Imports DevExpress.DemoData.Utils
Imports DevExpress.Xpf.Charts
Imports DevExpress.Xpf.DemoBase

Namespace ChartsDemo
    <CodeFile("Modules/XyzChart/ImageDataSource(.SL).xaml"), CodeFile("Modules/XyzChart/ImageDataSource.xaml.(cs)")>
    Partial Public Class ImageDataSource
        Inherits ChartsDemoModule

        Public Overrides ReadOnly Property ActualChart() As ChartControlBase
            Get
                Return chart
            End Get
        End Property

        Public Sub New()
            InitializeComponent()
            DataContext = New HeightViewModel()
        End Sub
        Public Overrides Function SupportSidebarContent() As Boolean
            Return False
        End Function
    End Class
    Public Class FillStyleItem
        Implements INotifyPropertyChanged


        Private title_Renamed As String

        Private fillStyle_Renamed As FillStyleBase

        Public Property Title() As String
            Get
                Return title_Renamed
            End Get
            Set(ByVal value As String)
                If title_Renamed <> value Then
                    title_Renamed = value
                    NotifyPropertyChanged("Title")
                End If
            End Set
        End Property
        Public Property FillStyle() As FillStyleBase
            Get
                Return fillStyle_Renamed
            End Get
            Set(ByVal value As FillStyleBase)
                If fillStyle_Renamed IsNot value Then
                    fillStyle_Renamed = value
                    NotifyPropertyChanged("FillStyle")
                End If
            End Set
        End Property

        #Region "INotifyPropertyChanged Members"
        Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged

        Private Sub NotifyPropertyChanged(ByVal propertyName As String)
            RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
        End Sub
        #End Region
    End Class
    Public Class HeightViewModel
        Implements INotifyPropertyChanged


        Private mapValues_Renamed As DoubleCollection

        Private mapX_Renamed As DoubleCollection

        Private mapY_Renamed As DoubleCollection

        Public Property MapValues() As DoubleCollection
            Get
                Return mapValues_Renamed
            End Get
            Set(ByVal value As DoubleCollection)
                mapValues_Renamed = value
                NotifyPropertyChanged("MapValues")
            End Set
        End Property
        Public Property MapX() As DoubleCollection
            Get
                Return mapX_Renamed
            End Get
            Set(ByVal value As DoubleCollection)
                mapX_Renamed = value
                NotifyPropertyChanged("MapX")
            End Set
        End Property
        Public Property MapY() As DoubleCollection
            Get
                Return mapY_Renamed
            End Get
            Set(ByVal value As DoubleCollection)
                mapY_Renamed = value
                NotifyPropertyChanged("MapY")
            End Set
        End Property

        Public Shared ReadOnly Property HeightMapUri() As Uri
            Get
                Return AssemblyHelper.GetResourceUri(GetType(ImageDataSource).Assembly, "/Data/Heightmap.jpg")
            End Get
        End Property

        #Region "INotifyPropertyChanged"
        Private onPropertyChanged As PropertyChangedEventHandler
        Public Custom Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged
            AddHandler(ByVal value As PropertyChangedEventHandler)
                onPropertyChanged = DirectCast(System.Delegate.Combine(onPropertyChanged, value), PropertyChangedEventHandler)
            End AddHandler
            RemoveHandler(ByVal value As PropertyChangedEventHandler)
                onPropertyChanged = DirectCast(System.Delegate.Remove(onPropertyChanged, value), PropertyChangedEventHandler)
            End RemoveHandler
            RaiseEvent(ByVal sender As System.Object, ByVal e As System.ComponentModel.PropertyChangedEventArgs)
                If onPropertyChanged IsNot Nothing Then
                    For Each d As PropertyChangedEventHandler In onPropertyChanged.GetInvocationList()
                        d.Invoke(sender, e)
                    Next d
                End If
            End RaiseEvent
        End Event
        Private Sub NotifyPropertyChanged(ByVal propertyName As String)
            If Me.onPropertyChanged IsNot Nothing Then
                Me.onPropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
            End If
        End Sub
        #End Region

        Public Sub New()
            GenerateMap(HeightMapUri)
        End Sub

        Private Sub GenerateMap(ByVal uri As Uri)
            Dim ImageData As New ImageData(uri)
            Dim pixels(,) As PixelColor = ImageData.GetPixels()

            Dim countX As Integer = pixels.GetLength(0)
            Dim countY As Integer = pixels.GetLength(1)

            Dim startX As Integer = 0
            Dim startY As Integer = 0
            Dim gridStep As Integer = 100
            Dim minY As Double = -300
            Dim maxY As Double = 3000


            Dim mapX_Renamed As New DoubleCollection(countX)

            Dim mapY_Renamed As New DoubleCollection(countY)
            Dim values As New DoubleCollection(countX * countY)
            Dim fullY As Boolean = False
            For i As Integer = 0 To countX - 1
                mapX_Renamed.Add(startX + i * gridStep)
                For j As Integer = 0 To countY - 1
                    If Not fullY Then
                        mapY_Renamed.Add(startY + j * gridStep)
                    End If
                    Dim value As Double = GetValue(pixels(i, j), minY, maxY)
                    values.Add(value)

                Next j
                fullY = True
            Next i
            MapY = mapY_Renamed
            MapX = mapX_Renamed
            MapValues = values
        End Sub

        Private Function GetValue(ByVal color As PixelColor, ByVal min As Double, ByVal max As Double) As Double
            Dim normalizedValue As Double = CDbl(color.Gray) / 255.0
            Return min + normalizedValue * (max - min)
        End Function
    End Class
End Namespace
