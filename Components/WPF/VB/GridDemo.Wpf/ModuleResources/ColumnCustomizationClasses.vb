Imports System
Imports System.Globalization
Imports System.Windows
Imports System.Windows.Data

Namespace GridDemo
    Public Enum ColumnChooserType
        [Default]
        Custom
    End Enum
    Public Class GridColumnChooserToExpanderVisible
        Implements IValueConverter

        #Region "IValueConverter Members"
        Private Function IValueConverter_Convert(ByVal value As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal culture As CultureInfo) As Object Implements IValueConverter.Convert
            Return If(value IsNot Nothing AndAlso DirectCast(value, ColumnChooserType) = ColumnChooserType.Custom, Visibility.Visible, Visibility.Collapsed)
        End Function
        Private Function IValueConverter_ConvertBack(ByVal value As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal culture As CultureInfo) As Object Implements IValueConverter.ConvertBack
            Throw New NotImplementedException()
        End Function
        #End Region
    End Class
End Namespace
