Imports System
Imports System.Collections.Generic

Namespace DevExpress.DemoData.Models
    Partial Public Class Product
        Public Property ProductID() As Long
        Public Property ProductName() As String
        Public Property SupplierID() As Long?
        Public Property CategoryID() As Long?
        Public Property QuantityPerUnit() As String
        Public Property UnitPrice() As Decimal?
        Public Property UnitsInStock() As Short?
        Public Property UnitsOnOrder() As Short?
        Public Property ReorderLevel() As Short?
        Public Property Discontinued() As Boolean
        Public Property EAN13() As String

        Public Overridable Property Category() As Category
    End Class
End Namespace
