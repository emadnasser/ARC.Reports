Imports System
Imports System.Windows.Data
Imports DevExpress.Xpf.Charts
Imports DevExpress.Xpf.DemoBase

Namespace ChartsDemo
    <CodeFile("Modules/FunnelSeries/Funnel2DControl(.SL).xaml"), CodeFile("Modules/FunnelSeries/Funnel2DControl.xaml.(cs)")>
    Partial Public Class Funnel2DControl
        Inherits ChartsDemoModule

        Public Sub New()
            InitializeComponent()
        End Sub
        Public Overrides ReadOnly Property ActualChart() As ChartControlBase
            Get
                Return chart
            End Get
        End Property
    End Class
    Public Class TextPatternConverter
        Implements IValueConverter

        Private Function IValueConverter_Convert(ByVal value As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal culture As System.Globalization.CultureInfo) As Object Implements IValueConverter.Convert
            If value.GetType().Equals(GetType(Boolean)) AndAlso DirectCast(value, Boolean) Then
                Return "{A}: {VP:P0}"
            Else
                Return "{A}: {V:G}"
            End If
        End Function

        Private Function IValueConverter_ConvertBack(ByVal value As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal culture As System.Globalization.CultureInfo) As Object Implements IValueConverter.ConvertBack
            Throw New NotImplementedException()
        End Function
    End Class

    Public Class LabelValueConverter
        Implements IValueConverter

        Private Function IValueConverter_Convert(ByVal value As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal culture As System.Globalization.CultureInfo) As Object Implements IValueConverter.Convert
            Dim position As Funnel2DLabelPosition = DirectCast(value, Funnel2DLabelPosition)
            Return Not position.Equals(Funnel2DLabelPosition.Center)
        End Function

        Private Function IValueConverter_ConvertBack(ByVal value As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal culture As System.Globalization.CultureInfo) As Object Implements IValueConverter.ConvertBack
            Throw New NotImplementedException()
        End Function
    End Class
End Namespace
