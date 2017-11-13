Imports System
Imports System.Collections.ObjectModel
Imports DevExpress.Xpf.Charts
Imports DevExpress.Xpf.DemoBase

Namespace ChartsDemo
    <CodeFile("Modules/XyzChart/Point3DSeriesView(.SL).xaml"), CodeFile("Modules/XyzChart/Point3DSeriesView.xaml.(cs)")>
    Partial Public Class Point3DSeriesView
        Inherits ChartsDemoModule

        Public Overrides ReadOnly Property ActualChart() As ChartControlBase
            Get
                Return chart
            End Get
        End Property

        Public Property Source() As ObservableCollection(Of StarData)

        Public Sub New()
            InitializeComponent()
            Source = Chart3DUtils.ReadStarsData()
            DataContext = Me
        End Sub
        Public Overrides Function SupportSidebarContent() As Boolean
            Return False
        End Function
    End Class
    Public Structure StarData
        Public Property HipID() As Integer
        Public Property Spectr() As String
        Public Property Lum() As Double
        Public Property CI() As Double
        Public Property X() As Double
        Public Property Y() As Double
        Public Property Z() As Double
    End Structure
End Namespace
