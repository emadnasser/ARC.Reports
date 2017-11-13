Imports System
Imports System.Collections.Generic

Namespace DevExpress.DemoData.Models
    Partial Public Class Category
        Public Property CategoryID() As Long
        Public Property CategoryName() As String
        Public Property Description() As String
        Public Property Picture() As Byte()
        Public Overridable Property Products() As ICollection(Of Product)
    End Class
End Namespace
