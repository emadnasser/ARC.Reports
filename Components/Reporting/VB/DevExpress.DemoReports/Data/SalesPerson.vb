Imports System
Imports System.Collections.Generic

Namespace DevExpress.DemoData.Models
    Partial Public Class SalesPerson
        Public Property OrderID() As Long
        Public Property Country() As String
        Public Property FirstName() As String
        Public Property LastName() As String
        Public Property ProductName() As String
        Public Property CategoryName() As String
        Public Property OrderDate() As Date?
        Public Property UnitPrice() As Decimal
        Public Property Quantity() As Short
        Public Property Discount() As Double
        Public Property ExtendedPrice() As Decimal
        Public Property FullName() As String
    End Class
End Namespace
