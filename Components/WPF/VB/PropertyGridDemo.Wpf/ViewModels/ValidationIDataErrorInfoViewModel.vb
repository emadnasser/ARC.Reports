Namespace PropertyGridDemo
    Public Class ValidationIDataErrorInfoViewModel
        Private privateData As DataErrorInfoValidationData
        Public Overridable Property Data() As DataErrorInfoValidationData
            Get
                Return privateData
            End Get
            Protected Set(ByVal value As DataErrorInfoValidationData)
                privateData = value
            End Set
        End Property
        Public Sub New()
            Data = New DataErrorInfoValidationData()
        End Sub
    End Class
End Namespace
