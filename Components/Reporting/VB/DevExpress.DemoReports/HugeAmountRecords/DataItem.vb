Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text

Namespace XtraReportsDemos.HugeAmountRecords
    Public Class DataItem
        Public Shared Function CreateItems(ByVal rowCount As Integer) As IList(Of DataItem)
            Dim items(rowCount - 1) As DataItem
            Dim random As New Random()
            Dim time As Date = Date.Now
            For i As Integer = 0 To rowCount - 1
                items(i) = New DataItem() With {.ColumnID = i + 1, .ColumnText = "Text " & (i Mod 100 + 1), .ColumnBool = (random.Next(1000) Mod 2 = 1), .ColumnDate = time.AddDays(random.Next(100)), .ColumnCurrency = Math.Round(random.NextDouble() * 10000000.0) / 1000}
            Next i
            Return items
        End Function
        Public Property ColumnID() As Integer
        Public Property ColumnText() As String
        Public Property ColumnBool() As Boolean
        Public Property ColumnDate() As Date
        Public Property ColumnCurrency() As Double
    End Class
End Namespace
