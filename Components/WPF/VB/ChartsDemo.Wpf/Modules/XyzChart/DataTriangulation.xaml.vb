Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Windows.Media.Media3D
Imports DevExpress.Xpf.Charts
Imports DevExpress.Xpf.DemoBase

Namespace ChartsDemo
    <CodeFile("Modules/XyzChart/DataTriangulation(.SL).xaml"), CodeFile("Modules/XyzChart/DataTriangulation.xaml.(cs)")>
    Partial Public Class DataTriangulation
        Inherits ChartsDemoModule

        Private model As DataTriangulationViewModel

        Public Overrides ReadOnly Property ActualChart() As ChartControlBase
            Get
                Return chart
            End Get
        End Property

        Public Sub New()
            InitializeComponent()
            Me.model = New DataTriangulationViewModel()
            Me.DataContext = model
        End Sub
    End Class

    Public Class DataTriangulationViewModel
        Implements INotifyPropertyChanged


        Private points_Renamed As List(Of Point3D)
        Private onPropertyChanged As PropertyChangedEventHandler

        Public Property Points() As List(Of Point3D)
            Get
                Return points_Renamed
            End Get
            Set(ByVal value As List(Of Point3D))
                points_Renamed = value
                NotifyPropertyChanged("Points")
            End Set
        End Property
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

        Public Sub New()
            Points = CreatePoints()
        End Sub

        Private Function CreatePoints() As List(Of Point3D)

            Dim points_Renamed As New List(Of Point3D)()
            For j As Double = -25.0 To 24 Step 0.75
                For i As Double = -15.0 To 14 Step 0.75
                    Dim x As Double = 2 + i + Math.Sin(j / 4.0) * 2
                    Dim y As Double = 1 + j + Math.Cos(i / 4.0)
                    Dim z As Double = 5.5 * Math.Sin(i / 3.0) * Math.Sin(j / 3.0)
                    points_Renamed.Add(New Point3D(x, y, z))
                Next i
            Next j
            Return points_Renamed
        End Function

        Private Sub NotifyPropertyChanged(ByVal propertyName As String)
            If Me.onPropertyChanged IsNot Nothing Then
                Me.onPropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
            End If
        End Sub
    End Class
End Namespace
