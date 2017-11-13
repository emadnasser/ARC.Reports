Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text

Namespace ChartsDemo
    Public Class GSP
        Public Sub New(ByVal region As String, ByVal year As String, ByVal product As Double)
            Me.Region = region
            Me.Year = year
            Me.Product = product
        End Sub
        Private privateProduct As Double
        Public Property Product() As Double
            Get
                Return privateProduct
            End Get
            Private Set(ByVal value As Double)
                privateProduct = value
            End Set
        End Property
        Private privateRegion As String
        Public Property Region() As String
            Get
                Return privateRegion
            End Get
            Private Set(ByVal value As String)
                privateRegion = value
            End Set
        End Property
        Private privateYear As String
        Public Property Year() As String
            Get
                Return privateYear
            End Get
            Private Set(ByVal value As String)
                privateYear = value
            End Set
        End Property
    End Class
End Namespace
