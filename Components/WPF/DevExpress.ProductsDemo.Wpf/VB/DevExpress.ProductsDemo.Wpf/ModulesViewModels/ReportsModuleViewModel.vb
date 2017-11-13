Imports System
Imports System.Configuration
Imports DevExpress.DemoData.Helpers
Imports DevExpress.DemoReports
Imports DevExpress.XtraReports

Namespace ProductsDemo.Modules
    Public Class ReportsModuleViewModel
        Shared Sub New()
            PatchDemoReportsConnectionStrings()
        End Sub
        Public Overridable Property DocumentSource() As IReport

        Public Sub OnLoaded()
            UpdateReport()
        End Sub
        Public Sub OnUnloaded()
            DocumentSource.StopPageBuilding()
        End Sub
        Private Sub UpdateReport()
            DocumentSource = New XtraReportsDemos.MasterDetailReport.Report()
            DocumentSource.CreateDocument(True)
        End Sub
        Private Shared Sub PatchDemoReportsConnectionStrings()
            Dim findDataFile As Func(Of String, String) = Function(fileName As String) DataFilesHelper.FindFile(fileName, DataFilesHelper.DataPath)
            CType(New ConnectionStringConfigurator(ConfigurationManager.ConnectionStrings), ConnectionStringConfigurator).SelectDbEngine().ExpandDataDirectory(findDataFile)
        End Sub
    End Class
End Namespace
