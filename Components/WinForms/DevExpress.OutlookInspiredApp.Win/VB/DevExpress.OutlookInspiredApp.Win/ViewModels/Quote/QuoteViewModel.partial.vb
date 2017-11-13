Namespace DevExpress.DevAV.ViewModels
    Partial Public Class QuoteViewModel
    End Class
    Partial Public Class SynchronizedQuoteViewModel
        Inherits QuoteViewModel

        Protected Overrides ReadOnly Property EnableSelectedItemSynchronization() As Boolean
            Get
                Return True
            End Get
        End Property
        Protected Overrides ReadOnly Property EnableEntityChangedSynchronization() As Boolean
            Get
                Return True
            End Get
        End Property
    End Class
End Namespace
