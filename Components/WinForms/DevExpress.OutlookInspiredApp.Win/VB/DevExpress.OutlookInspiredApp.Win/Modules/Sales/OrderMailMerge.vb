Imports DevExpress.XtraRichEdit
Imports DevExpress.Snap.Core.API
Imports DevExpress.DevAV.ViewModels
Imports System.IO
Imports System

Namespace DevExpress.DevAV.Modules

    Partial Public Class OrderMailMerge
        Inherits BaseModuleControl
        Implements IRibbonModule

        Public Sub New()
            MyBase.New(GetType(OrderMailMergeViewModel))
            InitializeComponent()
            BindCommands()
            UpdateUI()
            AddHandler ViewModel.MailTemplateChanged, AddressOf ViewModel_MailTemplateChanged
            AddHandler ViewModel.MailTemplateSelectedChanged, AddressOf ViewModel_MailTemplateSelectedChanged
            AddHandler ViewModel.PeriodChanged, AddressOf ViewModel_PeriodChanged
            AddHandler ViewModel.Save, AddressOf ViewModel_Save
            ViewModel.Modified = snapControl.Modified
            AddHandler snapControl.ModifiedChanged, AddressOf snapControl_ModifiedChanged
        End Sub
        Protected Overrides Sub OnDisposing()
            RemoveHandler ViewModel.Save, AddressOf ViewModel_Save
            RemoveHandler ViewModel.PeriodChanged, AddressOf ViewModel_PeriodChanged
            RemoveHandler ViewModel.MailTemplateChanged, AddressOf ViewModel_MailTemplateChanged
            RemoveHandler ViewModel.MailTemplateSelectedChanged, AddressOf ViewModel_MailTemplateSelectedChanged
            MyBase.OnDisposing()
        End Sub
        Private Sub ViewModel_MailTemplateSelectedChanged(ByVal sender As Object, ByVal e As EventArgs)
            UpdateUI()
        End Sub
        Private Sub ViewModel_MailTemplateChanged(ByVal sender As Object, ByVal e As EventArgs)
            UpdateUI()
            ShowReport()
        End Sub
        Private Sub ViewModel_PeriodChanged(ByVal sender As Object, ByVal e As EventArgs)
            If ViewModel.MailTemplate.GetValueOrDefault() = SalesReportType.SalesReport Then
                ShowReportByMonth(GetSalesReportPeriod())
            End If
        End Sub
        Private Function GetSalesReportPeriod() As Date
            Return If(ViewModel.Period.GetValueOrDefault() = OrderMailMergePeriod.ThisMonth, Date.Now, Date.Now.AddMonths(-1))
        End Function
        Private Sub LoadTemplate(ByVal document As SnapDocument, ByVal mailTemplate As SalesReportType)
            Dim template As String = (mailTemplate.ToFileName() & ".snx")
            Using stream = MailMergeTemplatesHelper.GetTemplateStream(template)
                document.LoadDocument(stream, DevExpress.Snap.Core.API.SnapDocumentFormat.Snap)
            End Using
            ribbonControl.ApplicationDocumentCaption = DevExpress.XtraEditors.EnumDisplayTextHelper.GetDisplayText(mailTemplate)
            ViewModel.Modified = snapControl.Modified
        End Sub
        Private Sub UpdateUI()
            mailMergeRibbonPage1.Visible = Not ViewModel.IsMailTemplateSelected
            rpbReportRange.Visible = ViewModel.IsMailTemplateSelected AndAlso ViewModel.MailTemplate.GetValueOrDefault() = SalesReportType.SalesReport
        End Sub
        Public ReadOnly Overloads Property ViewModel() As OrderMailMergeViewModel
            Get
                Return GetViewModel(Of OrderMailMergeViewModel)()
            End Get
        End Property
        Public ReadOnly Property CollectionViewModel() As OrderCollectionViewModel
            Get
                Return GetParentViewModel(Of OrderCollectionViewModel)()
            End Get
        End Property
        Protected Overrides Sub OnLoad(ByVal ea As EventArgs)
            MyBase.OnLoad(ea)
            bindingSource.DataSource = CollectionViewModel.SelectedEntity
            If snapControl.Document.IsEmpty Then
                ShowReport()
            End If
        End Sub
        Private Sub ShowReport()
            bindingSource.DataSource = CollectionViewModel.SelectedEntity
            Select Case ViewModel.MailTemplate.GetValueOrDefault()
                Case SalesReportType.SalesReport
                    snapControl.DataSource = CollectionViewModel.GetOrderItems()
                    ShowReportByMonth(GetSalesReportPeriod())
                Case SalesReportType.SalesByStore
                    snapControl.DataSource = CollectionViewModel.GetOrderItems(CollectionViewModel.SelectedEntity.StoreId)
                    GenerateReport(Nothing)
                Case SalesReportType.Invoice, SalesReportType.ThankYou
                    LoadTemplate(snapControl.Document, ViewModel.MailTemplate.GetValueOrDefault())
                    snapControl.DataSource = bindingSource
            End Select
        End Sub
        Private Sub ShowReportByMonth(ByVal month As Date)
            Dim start As New Date(month.Year, month.Month, 1)
            Dim [end] As Date = start.AddMonths(1)
            GenerateReport(Sub(document)
                document.Parameters("startDate").Value = start
                document.Parameters("endDate").Value = [end]
            End Sub)
        End Sub
        Private Sub GenerateReport(ByVal initAction As Action(Of SnapDocument))
            snapControl.BeginUpdate()
            LoadTemplate(snapControl.Document, ViewModel.MailTemplate.GetValueOrDefault())
            If initAction IsNot Nothing Then
                initAction(snapControl.Document)
            End If
            snapControl.EndUpdate()
            Using ms As New MemoryStream()
                snapControl.Document.ExportDocument(ms, DocumentFormat.OpenXml)
                ms.Position = 0
                snapControl.Document.LoadDocument(ms, DocumentFormat.OpenXml)
            End Using
            ViewModel.Modified = snapControl.Modified
        End Sub
        Private Sub BindCommands()
            biClose.BindCommand(Sub() ViewModel.Close(), ViewModel)
            bbiThisMonth.BindCommand(Sub() ViewModel.SetThisMonthPeriod(), ViewModel)
            bbiPrevMonth.BindCommand(Sub() ViewModel.SetLastMonthPeriod(), ViewModel)
        End Sub
        Private Sub snapControl_ModifiedChanged(ByVal sender As Object, ByVal e As EventArgs)
            ViewModel.Modified = snapControl.Modified
        End Sub
        Private Sub ViewModel_Save(ByVal sender As Object, ByVal e As EventArgs)
            snapControl.SaveDocumentAs()
        End Sub
        #Region ""
        Private ReadOnly Property IRibbonModule_Ribbon() As XtraBars.Ribbon.RibbonControl Implements IRibbonModule.Ribbon
            Get
                Return ribbonControl
            End Get
        End Property
        #End Region
    End Class
End Namespace
