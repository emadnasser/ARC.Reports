Imports System

Namespace PropertyGridDemo
    Public Class PropertyAttributesViewModel
        Private privateData As AttributesSupportData
        Public Overridable Property Data() As AttributesSupportData
            Get
                Return privateData
            End Get
            Protected Set(ByVal value As AttributesSupportData)
                privateData = value
            End Set
        End Property
        Public Sub New()
            Data = New AttributesSupportData() With {.ID = 123456, .FirstName = "Nancy", .LastName = "Davolio", .Age = 36, .Gender = Gender.Female, .HireDate = New Date(2002, 2, 2), .SSN = "123-45-6789"}
        End Sub
    End Class
End Namespace
