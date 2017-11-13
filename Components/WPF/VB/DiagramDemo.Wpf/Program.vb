Imports System
Imports System.Windows
Imports DevExpress.DemoData
Imports DevExpress.Xpf.DemoBase
Imports DevExpress.Xpf.DemoBase.Helpers
Imports DevExpress.DemoData.Helpers

Namespace DiagramDemo
    Public Class Program
        <STAThread>
        Shared Sub Main(ByVal args() As String)
            StartupBase.Run(Of Startup)(Nothing)
        End Sub
    End Class
    Public Class Startup
        Inherits DemoStartup

        Public Shared Sub InitDemo()
        End Sub
        Protected Overrides Function GetDebug() As Boolean
#If DEBUG Then
            Return True
#Else
            Return False
#End If
        End Function
        Protected Overrides Function GetFixtureTypeForXBAPOrSLTesting() As Type
            Return Nothing
        End Function
    End Class
End Namespace
