Imports System.IO
Imports System.Windows.Input
Imports DevExpress.Mvvm
Imports DevExpress.Mvvm.Native
Imports DevExpress.XtraReports
Imports DevExpress.XtraReports.Native
Imports DevExpress.XtraReports.UI

Namespace ReportWpfDemo
    Public MustInherit Class ReportModuleViewModelBase
        Inherits ViewModelBase

        Public Sub New()
            ShowDesignerCommand = New DelegateCommand(AddressOf DoShowDesigner)
        End Sub

        Private fReport As IReport
        Public Overridable Property Report() As IReport
            Get
                Return fReport
            End Get
            Set(ByVal value As IReport)
                Dim oldValue = fReport
                If SetProperty(fReport, value, Function() Report) Then
                    OnReportChanged(oldValue)
                End If
            End Set
        End Property

        Private privateShowDesignerCommand As ICommand
        Public Property ShowDesignerCommand() As ICommand
            Get
                Return privateShowDesignerCommand
            End Get
            Private Set(ByVal value As ICommand)
                privateShowDesignerCommand = value
            End Set
        End Property

        Protected Overridable ReadOnly Property WindowService() As IWindowService
            Get
                Return Nothing
            End Get
        End Property

        Private Shared Function CloneReport(ByVal report As XtraReport) As XtraReport
            Using stream = New MemoryStream()
                report.SaveLayoutToXml(stream)
                stream.Position = 0
                Return XtraReport.FromStream(stream, True)
            End Using
        End Function

        Private Sub DoShowDesigner()
            Report.StopPageBuilding()
            Dim clonedReport = CloneReport(DirectCast(Report, XtraReport))
            Dim reportDesignerViewModel = New ReportDesignerViewModel(clonedReport)

            WindowService.Show(GetType(ReportDesignerControl).FullName, reportDesignerViewModel)

            If reportDesignerViewModel.Saved Then
                Report = CloneReport(reportDesignerViewModel.Report)
                Report.CreateDocument(True)
            End If
        End Sub

        Private Sub OnReportChanged(ByVal oldValue As IReport)
            If IsInDesignMode Then
                Return
            End If
            UnsusbscrubeReport(oldValue)
            SubscribeReport(Report)
        End Sub

        Public Sub InitializeReport()
            Report = CreateReport()
            Report.CreateDocument(True)
        End Sub

        Private Sub SubscribeReport(ByVal report As IReport)
            report.Do(Sub(x) AddHandler x.PrintingSystemBase.CreateDocumentException, AddressOf OnCreateDocumentException)
        End Sub

        Private Sub UnsusbscrubeReport(ByVal report As IReport)
            report.Do(Sub(x) RemoveHandler x.PrintingSystemBase.CreateDocumentException, AddressOf OnCreateDocumentException)
        End Sub

        Private Sub OnCreateDocumentException(ByVal sender As Object, ByVal args As DevExpress.XtraPrinting.ExceptionEventArgs)
            args.Handled = True
            Report.StopPageBuilding()
        End Sub

        Private Sub ResetDataAdapters(ByVal report As XtraReportBase)
            If report Is Nothing Then
                Return
            End If
            Dim enumerator = New NestedComponentEnumerator(New Object() { report })
            Do While enumerator.MoveNext()
                Dim dataContainer = TryCast(enumerator.Current, IDataContainer)
                If dataContainer IsNot Nothing Then
                    dataContainer.DataAdapter = Nothing
                End If
                Dim subreport As XRSubreport = TryCast(enumerator.Current, XRSubreport)
                If subreport IsNot Nothing Then
                    ResetDataAdapters(TryCast(subreport.ReportSource, XtraReportBase))
                End If
            Loop
        End Sub
        Protected MustOverride Function CreateReport() As IReport
    End Class
End Namespace
