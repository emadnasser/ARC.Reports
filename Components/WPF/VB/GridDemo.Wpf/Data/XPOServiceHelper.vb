Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports DevExpress.Xpo
Imports DevExpress.Xpo.DB
Imports System.ServiceModel

Namespace GridDemo

    Public NotInheritable Class XPOServiceHelper

        Private Sub New()
        End Sub


        Public Shared Sub SetupXpoLayer()
            Dim address As New EndpointAddress("http://demos.devexpress.com/Services/WcfXpoSCNew/XPOService.svc")
            Dim binding As New BasicHttpBinding()
            binding.MaxReceivedMessageSize = Int32.MaxValue
            Dim dataStore As New DataStoreClient(binding, address)
            XpoDefault.DataLayer = New SimpleDataLayer(dataStore)
            XpoDefault.Session = Nothing

        End Sub
    End Class
End Namespace
