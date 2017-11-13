Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Linq
Imports DevExpress.DemoData.Models
Imports DevExpress.Xpf.DemoBase

Namespace GridDemo
    #Region "GroupIntervalData"

    Public Class GroupIntervalData
        Public Shared rnd As New Random()
        Public Shared ReadOnly Property Invoices() As DataView
            Get
                Return CreateInvoicesDataTable().DefaultView
            End Get
        End Property
        Public Shared ReadOnly Property Products() As DataView
            Get
                Return CreateProductsDataTable().DefaultView
            End Get
        End Property
        Private Shared Function GetDate(ByVal range As Boolean) As Date
            Dim ret As Date = Date.Now
            Dim r As Integer = rnd.Next(20)
            If range Then
                If r > 1 Then
                    ret = ret.AddDays(rnd.Next(80) - 40)
                End If
                If r > 18 Then
                    ret = ret.AddMonths(rnd.Next(18))
                End If
            Else
                ret = ret.AddDays(rnd.Next(r * 30) - r * 15)
            End If
            Return ret
        End Function
        Private Shared Function GetCount() As Decimal
            Return rnd.Next(50) + 10
        End Function
        Private Shared Function CreateInvoicesDataTable() As DataTable

            Dim invoices_Renamed = NWindContext.Create().Invoices.ToList()
            Dim tbl As New DataTable("GroupInterval")
            tbl.Columns.Add("Country", GetType(String))
            tbl.Columns.Add("City", GetType(String))
            tbl.Columns.Add("OrderDate", GetType(Date))
            tbl.Columns.Add("UnitPrice", GetType(Decimal))
            tbl.Columns.Add("Region", GetType(String))
            For Each invoice In invoices_Renamed
                tbl.Rows.Add(New Object() { invoice.Country, invoice.City, GetDate(True), invoice.UnitPrice, invoice.Region })
            Next invoice
            Return tbl
        End Function
        Private Shared Function CreateProductsDataTable() As DataTable
            Const rowCount As Integer = 1000

            Dim products_Renamed = NWindContext.Create().Products.ToList()
            Dim tbl As New DataTable("GroupInterval")
            tbl.Columns.Add("ProductName", GetType(String))
            tbl.Columns.Add("UnitPrice", GetType(Decimal))
            tbl.Columns.Add("Count", GetType(Integer))
            tbl.Columns.Add("OrderDate", GetType(Date))
            tbl.Columns.Add("OrderSum", GetType(Decimal), "[UnitPrice] * [Count]")
            For i As Integer = 0 To rowCount - 1
                Dim product As Product = products_Renamed(rnd.Next(products_Renamed.Count - 1))
                tbl.Rows.Add(New Object() { product.ProductName, product.UnitPrice, GetCount(), GetDate(False) })
            Next i
            Return tbl
        End Function
    End Class


    #End Region
End Namespace
