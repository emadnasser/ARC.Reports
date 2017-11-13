Imports System
Imports System.Globalization
Imports System.Windows.Data

Namespace GridDemo
    Public Class XmlIntegerConverter
        Implements IValueConverter

        Private Function IValueConverter_Convert(ByVal value As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal culture As CultureInfo) As Object Implements IValueConverter.Convert
            Dim InvariantCulture As New CultureInfo("")
            Dim i As Integer = Integer.Parse(DirectCast(value, String), InvariantCulture)
            Return i
        End Function
        Private Function IValueConverter_ConvertBack(ByVal value As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal culture As CultureInfo) As Object Implements IValueConverter.ConvertBack
            Return DirectCast(value, Integer).ToString()
        End Function
    End Class
    Public Class XmlDateTimeConverter
        Implements IValueConverter

        Private Function IValueConverter_Convert(ByVal value As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal culture As CultureInfo) As Object Implements IValueConverter.Convert
            If String.IsNullOrEmpty(DirectCast(value, String)) Then
                Return Nothing
            End If
            Dim dt As Date = Date.Parse(DirectCast(value, String), CultureInfo.InvariantCulture)
            Return dt
        End Function
        Private Function IValueConverter_ConvertBack(ByVal value As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal culture As CultureInfo) As Object Implements IValueConverter.ConvertBack
            Return If(value IsNot Nothing, DirectCast(value, Date).ToString(CultureInfo.InvariantCulture), Nothing)
        End Function
    End Class
End Namespace
