Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports EditorsDemo.SCService

Namespace EditorsDemo.ViewModels
    Public Class WCFInstantFeedbackViewModel
        Public Sub New()
            WcfSCService = New SCEntities(New Uri("http://demos.devexpress.com/Services/WcfLinqSC/WcfSCService.svc/"))
        End Sub
        Public Overridable Property WcfSCService() As SCEntities
    End Class

End Namespace
