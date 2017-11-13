Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports DevExpress.Xpf.DemoBase.Helpers
Imports System.ComponentModel
Imports DevExpress.Mvvm

Namespace GridDemo
    Public Class AsyncLookUpEditViewModel
        Inherits BindableBase


        Private countItems_Renamed As CountItemCollection

        Private selectedCountItem_Renamed As CountItem

        Private queryableSource_Renamed As IQueryable
        Private orderDataGenerator As OrderDataGenerator
        Private orderDataListSource As OrderDataListSource
        Private isDesignTime As Boolean = True

        Public Property ListSource() As OrderDataListSource
            Get
                Return orderDataListSource
            End Get
            Set(ByVal value As OrderDataListSource)
                SetProperty(orderDataListSource, value, Function() orderDataListSource)
            End Set
        End Property
        Public Property QueryableSource() As IQueryable
            Get
                Return queryableSource_Renamed
            End Get
            Set(ByVal value As IQueryable)
                SetProperty(queryableSource_Renamed, value, Function() QueryableSource)
            End Set
        End Property
        Public Property CountItems() As CountItemCollection
            Get
                Return countItems_Renamed
            End Get
            Set(ByVal value As CountItemCollection)
                If SetProperty(countItems_Renamed, value, Function() CountItems) Then
                    If (CountItems IsNot Nothing) AndAlso (CountItems.Count > 0) Then
                        SelectedCountItem = CountItems(CountItems.Count \ 2)
                    Else
                        SelectedCountItem = Nothing
                    End If
                End If
            End Set
        End Property
        Public Property SelectedCountItem() As CountItem
            Get
                Return selectedCountItem_Renamed
            End Get
            Set(ByVal value As CountItem)
                SetProperty(selectedCountItem_Renamed, value, Function() SelectedCountItem, AddressOf RecreateItemsSource)
            End Set
        End Property

        Public Sub New()
            orderDataGenerator = New OrderDataGenerator(0)
        End Sub

        Private Sub RecreateItemsSource()
            If SelectedCountItem Is Nothing OrElse isDesignTime Then
                orderDataGenerator.Count = 0
            Else
                orderDataGenerator.Count = SelectedCountItem.Count
            End If
            ListSource = New OrderDataListSource(orderDataGenerator)
            QueryableSource = DirectCast(ListSource, IListSource).GetList().AsQueryable()
        End Sub
        Public Sub SetIsDesignTime(ByVal value As Boolean)
            isDesignTime = value
            RecreateItemsSource()
        End Sub
    End Class
End Namespace
