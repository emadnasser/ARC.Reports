Imports System
Imports System.Collections.Generic
Imports System.Globalization
Imports System.Windows.Data
Imports DevExpress.Xpf.Grid

Namespace GridDemo
    Public Class NavigationStyleList
        Inherits List(Of GridViewNavigationStyle)

    End Class
    #Region "Converters"
    Public Class NavigationStyleToIsEnabledConverter
        Implements IValueConverter

        Private Function IValueConverter_Convert(ByVal value As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal culture As CultureInfo) As Object Implements IValueConverter.Convert
            If value Is Nothing Then
                Return True
            End If
            Return Not Object.Equals(value, GridViewNavigationStyle.Row)
        End Function
        Private Function IValueConverter_ConvertBack(ByVal value As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal culture As CultureInfo) As Object Implements IValueConverter.ConvertBack
            Throw New NotImplementedException()
        End Function
    End Class
    Public Class ShowTreeListLinesConverter
        Implements IValueConverter

        #Region "IValueConverter Members"
        Private Function IValueConverter_Convert(ByVal value As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal culture As CultureInfo) As Object Implements IValueConverter.Convert
            Return Not Object.Equals(value, TreeListLineStyle.None)
        End Function
        Private Function IValueConverter_ConvertBack(ByVal value As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal culture As CultureInfo) As Object Implements IValueConverter.ConvertBack
            Return If(DirectCast(value, Boolean), TreeListLineStyle.Solid, TreeListLineStyle.None)
        End Function
        #End Region
    End Class
    #End Region
End Namespace
