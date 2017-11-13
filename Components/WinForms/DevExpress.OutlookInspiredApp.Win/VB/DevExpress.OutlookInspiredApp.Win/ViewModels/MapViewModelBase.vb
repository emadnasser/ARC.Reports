Namespace DevExpress.DevAV.ViewModels
    Public MustInherit Partial Class MapViewModelBase
        Public Const WinBingKey As String = DevExpress.Map.Native.DXBingKeyVerifier.BingKeyWinOutlookInspiredApp
        Public Const WpfBingKey As String = DevExpress.Map.Native.DXBingKeyVerifier.BingKeyWpfOutlookInspiredApp
        Public Overridable Property Address() As Address
        Public Shared ReadOnly DevAVHomeOffice As Address = New Address With {.City = "Glendale", .Line = "505 N. Brand Blvd", .State = StateEnum.CA, .ZipCode = "91203", .Latitude = 34.1532866, .Longitude = -118.2555815}
    End Class
End Namespace
