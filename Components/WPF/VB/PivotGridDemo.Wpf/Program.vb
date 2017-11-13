Imports System
Imports System.Windows
Imports DevExpress.DemoData
Imports DevExpress.Xpf.DemoBase
Imports DevExpress.Xpf.DemoBase.Helpers
Imports DevExpress.DemoData.Helpers
Imports System.Globalization
Imports System.Threading
Imports DevExpress.DemoData.Models

Namespace PivotGridDemo
    Public Class Program
        <STAThread>
        Shared Sub Main(ByVal args() As String)
            StartupBase.Run(Of Startup)(Nothing)
        End Sub
    End Class
    Public Class Startup
        Inherits DemoStartup

        Public Shared Sub InitDemo()
            NWindContext.Preload()
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

        Protected Overrides Function CreateApplication(ByVal app As Application) As Application
            SetCultureInfo()
            Return MyBase.CreateApplication(app)
        End Function

        Private Sub SetCultureInfo()
            Dim demoCI As CultureInfo = DirectCast(Thread.CurrentThread.CurrentCulture.Clone(), CultureInfo)
            demoCI.NumberFormat.CurrencyDecimalDigits = 2
            demoCI.NumberFormat.CurrencyDecimalSeparator = "."
            demoCI.NumberFormat.CurrencyGroupSeparator = ","
            demoCI.NumberFormat.CurrencyGroupSizes = New Integer() { 3 }
            demoCI.NumberFormat.CurrencyNegativePattern = 0
            demoCI.NumberFormat.CurrencyPositivePattern = 0
            demoCI.NumberFormat.CurrencySymbol = "$"
            Thread.CurrentThread.CurrentCulture = demoCI
        End Sub
    End Class
End Namespace
