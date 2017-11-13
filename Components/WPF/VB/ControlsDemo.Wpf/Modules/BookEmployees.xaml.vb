Imports System
Imports System.Globalization
Imports System.IO
Imports System.Linq
Imports System.Windows.Data
Imports System.Windows.Media.Imaging
Imports DevExpress.DemoData.Models
Imports DevExpress.Xpf.Controls

Namespace ControlsDemo
    Public Enum ImageSourceKind
        Data
        Uri
    End Enum

    Partial Public Class BookEmployees
        Inherits ControlsDemoModule

        Public Sub New()
            InitializeComponent()
            book.DataSource = NWindContext.Create().Employees.ToList()
            book.FirstPage = PageType.Even
        End Sub
    End Class
    Public Class ImageContentConverter
        Implements IValueConverter

        Public Property SourceKind() As ImageSourceKind

        Public Sub New()
        End Sub
        Public Sub New(ByVal sourceKind As ImageSourceKind)
            Me.SourceKind = sourceKind
        End Sub

        Private Function IValueConverter_Convert(ByVal value As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal culture As CultureInfo) As Object Implements IValueConverter.Convert
            If SourceKind = ImageSourceKind.Data AndAlso TypeOf value Is Byte() Then
                Dim bi As New BitmapImage()
                bi.BeginInit()
                bi.StreamSource = New MemoryStream(DirectCast(value, Byte()))
                bi.EndInit()
                Return bi
            Else
                If SourceKind = ImageSourceKind.Uri AndAlso TypeOf value Is String Then
                    Return New BitmapImage(New Uri(TryCast(value, String)))
                Else
                    Return Nothing
                End If
            End If
        End Function
        Private Function IValueConverter_ConvertBack(ByVal value As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal culture As CultureInfo) As Object Implements IValueConverter.ConvertBack
            Throw New NotImplementedException()
        End Function
    End Class
End Namespace
