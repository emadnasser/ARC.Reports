Imports DevExpress.XtraBars.Ribbon

Namespace DevExpress.DevAV.Modules

    Public Interface IRibbonModule
        ReadOnly Property Ribbon() As RibbonControl
    End Interface
    Public Interface ISupportViewModel
        ReadOnly Property ViewModel() As Object
        Sub ParentViewModelAttached()
    End Interface
End Namespace
