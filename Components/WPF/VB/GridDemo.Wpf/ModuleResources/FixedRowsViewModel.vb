Imports DevExpress.Xpf.DemoBase.Helpers
Imports DevExpress.Mvvm
Imports DevExpress.DemoData.Models
Imports System.Collections.Generic
Imports System.Data.Entity
Imports System.Linq
Imports DevExpress.Mvvm.DataAnnotations
Imports System.Xml.Serialization
Imports System.Reflection
Imports System.Collections.ObjectModel
Imports System
Imports System.Windows.Threading
Imports DevExpress.Xpf.Core

Namespace GridDemo
    <POCOViewModel>
    Public Class FixedRowsViewModel
        Private Const HistoryLength As Integer = 20
        Private Const UpdateInterval As Integer = 1000
        Private random As New Random()
        Public Property Data() As ObservableCollectionCore(Of StockItem)

        Private fixedTopRows_Renamed() As String = { "MSFT", "AAPL", "ORCL" }
        Public Property FixedTopRows() As List(Of StockItem)

        Private fixedBottomRows_Renamed() As String = { "IBM", "CSCO", "MSI", "DELL", "XRX" }
        Public Property FixedBottomRows() As List(Of StockItem)
        Public Property CurrentItem() As StockItem

        Public Sub New()

            Dim data_Renamed As ObservableCollectionCore(Of StockItem) = StockItems.GetData()
            For Each stockItem As StockItem In data_Renamed
                For i As Integer = 0 To HistoryLength - 1
                    UpdatePrice(stockItem)
                Next i
            Next stockItem
            FixedTopRows = data_Renamed.Where(Function(x) fixedTopRows_Renamed.Contains(x.CompanyName)).ToList()
            FixedBottomRows = data_Renamed.Where(Function(x) fixedBottomRows_Renamed.Contains(x.CompanyName)).ToList()
            CurrentItem = data_Renamed.FirstOrDefault(Function(x) x.CompanyName = "EBAY")
            Data = data_Renamed
        End Sub

        Private timer As DispatcherTimer
        Public Sub StartUpdate()
            timer = New DispatcherTimer() With {.Interval = TimeSpan.FromMilliseconds(UpdateInterval)}
            AddHandler timer.Tick, AddressOf timer_Tick
            timer.Start()
        End Sub
        Public Sub StopUpdate()
            timer.Stop()
            RemoveHandler timer.Tick, AddressOf timer_Tick
            timer = Nothing
        End Sub
        Private Sub timer_Tick(ByVal sender As Object, ByVal e As EventArgs)
            Data.BeginUpdate()
            For Each stockItem As StockItem In Data
                UpdatePrice(stockItem)
            Next stockItem
            Data.EndUpdate()
        End Sub

        Private Sub UpdatePrice(ByVal stockItem As StockItem)
            Dim newDelta As Double = random.NextDouble() * 0.5 - 0.25
            If Math.Sign(stockItem.DeltaPrice) = Math.Sign(newDelta) Then
                stockItem.DeltaChange = 0
            Else
                stockItem.DeltaChange = Math.Sign(newDelta)
            End If
            stockItem.DeltaPrice = newDelta
            stockItem.Price += stockItem.DeltaPrice
            If stockItem.Price < stockItem.LowPrice Then
                stockItem.LowPrice = stockItem.Price
            End If
            If stockItem.Price > stockItem.HighPrice Then
                stockItem.HighPrice = stockItem.Price
            End If
            stockItem.DeltaPricePercent = stockItem.DeltaPrice / stockItem.Price
            stockItem.Volume += Convert.ToInt32(random.NextDouble() * stockItem.Volume * 0.005 - 0.0025)
            UpdatePriceHistory(stockItem)
        End Sub
        Private Sub UpdatePriceHistory(ByVal stockItem As StockItem)
            Dim newPriceHistory As New List(Of Double)(New Double(HistoryLength - 1){})
            For i As Integer = 1 To HistoryLength - 1
                newPriceHistory(i - 1) = If(i < stockItem.PriceHistory.Count, stockItem.PriceHistory(i), 0)
            Next i
            newPriceHistory(HistoryLength - 1) = stockItem.Price
            stockItem.PriceHistory = newPriceHistory
        End Sub
    End Class

    <XmlRoot("StockItems")>
    Public Class StockItems
        Inherits ObservableCollectionCore(Of StockItem)

        Public Shared Function GetData() As ObservableCollectionCore(Of StockItem)
            Dim s As New XmlSerializer(GetType(StockItems))
            Dim assembly As System.Reflection.Assembly = GetType(MultiView).Assembly
            Return DirectCast(s.Deserialize(assembly.GetManifestResourceStream(DemoHelper.GetPath("GridDemo.Data.", assembly) & "StockSource.xml")), ObservableCollectionCore(Of StockItem))
        End Function
    End Class

    Public Class StockItem
        Public Property CompanyName() As String
        Public Property Price() As Double
        Public Property Volume() As Integer
        Public Property LowPrice() As Double
        Public Property HighPrice() As Double
        Public Property DeltaPrice() As Double
        Public Property DeltaPricePercent() As Double
        Public Property DeltaChange() As Integer

        Public Sub New()
            PriceHistory = New List(Of Double)()
        End Sub
        Public Property PriceHistory() As List(Of Double)
    End Class
End Namespace
