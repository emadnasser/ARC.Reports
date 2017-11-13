Imports System
Imports DevExpress.Xpf.DemoBase.Helpers
Imports System.Windows.Input
Imports DevExpress.Xpf.Core.Commands
Imports System.Diagnostics
Imports DevExpress.Mvvm

Namespace GridDemo
    Public Class WCFInstantFeedbackViewModel
        Inherits BindableBase


        Private isUseExtendedDataQuery_Renamed As Boolean

        Private wcfSCService_Renamed As WcfSCService.SCEntities

        Public Property IsUseExtendedDataQuery() As Boolean
            Get
                Return isUseExtendedDataQuery_Renamed
            End Get
            Set(ByVal value As Boolean)
                SetProperty(isUseExtendedDataQuery_Renamed, value, Function() IsUseExtendedDataQuery)
            End Set
        End Property
        Public Property WcfSCService() As WcfSCService.SCEntities
            Get
                Return wcfSCService_Renamed
            End Get
            Set(ByVal value As WcfSCService.SCEntities)
                SetProperty(wcfSCService_Renamed, value, Function() WcfSCService)
            End Set
        End Property
        Public Sub New()
            IsUseExtendedDataQuery = True
            WcfSCService = New WcfSCService.SCEntities(New Uri("http://demos.devexpress.com/Services/WcfLinqSC/WcfSCService.svc/"))
        End Sub
    End Class
End Namespace
