Imports System
Imports System.Configuration
Imports DevExpress.DemoData
Imports DevExpress.DemoData.Helpers
Imports DevExpress.DemoReports
Imports DevExpress.Xpf.DemoBase
Imports DevExpress.Xpf.Reports.UserDesigner

Namespace ReportWpfDemo
    Public Class Program
        <STAThread>
        Shared Sub Main(ByVal args() As String)
            StartupBase.Run(Of Startup)(Nothing)
        End Sub
    End Class

    Public Class Startup
        Inherits DemoStartup

        Shared Sub New()
            ParameterTypeRegistrator.Register(Of UInteger)("Unsigned Integer")
        End Sub

        Public Shared Sub InitDemo()
            DevExpress.Xpf.Reports.UserDesigner.Extensions.ReportDesignerRibbonDemoButtonHelper.Load()
            PatchDemoReportsConnectionStrings()
        End Sub

        Public Shared Sub PatchDemoReportsConnectionStrings()
            Dim path As String = DataFilesHelper.FindFile("nwind.db", DataFilesHelper.DataPath)
            Dim directory As String = System.IO.Path.GetDirectoryName(path)
            XtraReportsDemos.ConnectionHelper.SetDataDirectory(directory)
            XtraReportsDemos.ConnectionHelper.ApplyDataDirectory(directory)

            Dim findDataFile As Func(Of String, String) = Function(fileName As String) DataFilesHelper.FindFile(fileName, DataFilesHelper.DataPath)
            CType(New ConnectionStringConfigurator(ConfigurationManager.ConnectionStrings), ConnectionStringConfigurator).SelectDbEngine().ExpandDataDirectory(findDataFile)
        End Sub

        Protected Overrides Function DoStartup() As Boolean
            PatchDemoReportsConnectionStrings()
            Return MyBase.DoStartup()
        End Function

        Protected Overrides Function GetDebug() As Boolean
#If DEBUG Then
            Return True
#Else
            Return False
#End If
        End Function
    End Class
End Namespace
