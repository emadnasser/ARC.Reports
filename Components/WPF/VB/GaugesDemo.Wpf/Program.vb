Imports System
Imports System.Runtime.InteropServices
Imports DevExpress.DemoData
Imports DevExpress.DemoData.Helpers
Imports DevExpress.Xpf.DemoBase

Namespace GaugesDemo
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
    Public NotInheritable Class WinFormsMessageBoxHelper

        Private Sub New()
        End Sub
        <DllImport("user32.dll", CharSet := CharSet.Auto)>
        Friend Shared Function MessageBox(ByVal hWnd As IntPtr, ByVal lpText As String, ByVal lpCaption As String, ByVal uType As UInteger) As Integer
        End Function

        Public Shared Sub Show(ByVal message As String)
            Dim uType As UInteger = &H10000 Or &H10
            WinFormsMessageBoxHelper.MessageBox(IntPtr.Zero, message, "", uType)
        End Sub
    End Class
End Namespace
