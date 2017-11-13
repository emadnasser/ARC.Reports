<%@ Application Language="vb" %>

<script RunAt="server">
	Sub Application_Start(ByVal sender As Object, ByVal e As EventArgs)
		DevExpress.XtraReports.Web.ReportDesigner.Native.ReportDesignerBootstrapper.SessionState = SessionStateBehavior.Required
		DevExpress.XtraReports.Web.WebDocumentViewer.Native.WebDocumentViewerBootstrapper.SessionState = SessionStateBehavior.Required
		DevExpress.Internal.DataDirectoryHelper.DataFolderName = "App_Data"
		ReportWebDemo.ReportCaching.CacheReportHelper.StartCreatingReports()
		DevExpress.XtraReports.Web.Extensions.ReportStorageWebExtension.RegisterExtensionGlobal(New DemoReportStorageExtension())
		Utils.EnsureRequestValidationMode()
		AddHandler DevExpress.Web.ASPxWebControl.CallbackError, AddressOf CallbackError
		DevExpress.XtraReports.Web.WebDocumentViewer.DefaultWebDocumentViewerContainer.UseFileDocumentStorage(Server.MapPath("~/App_Data/WebDocumentViewerCache"))
		DevExpress.XtraReports.Web.Native.ClientControls.Services.DefaultLoggingService.SetInstance(New DevExpress.Web.Demos.DemoLoggingService())
		DevExpress.XtraReports.Web.WebDocumentViewer.DefaultWebDocumentViewerContainer.RegisterWebDocumentViewerDrillThroughProcessor(Of WebDocumentViewerDrillThroughProcessor)()
		DevExpress.XtraReports.Web.ReportDesigner.DefaultReportDesignerContainer.RegisterDataSourceWizardConnectionStringsProvider(Of DataSourceWizardConnectionStringsProvider)()
		DevExpress.XtraReports.Web.ASPxReportDesigner.ShouldClearReportScripts = True
	End Sub

	Sub CallbackError(ByVal sender As Object, ByVal e As EventArgs)
		' Logging exceptions occur on callback events of DevExpress ASP.NET controls.
		' To learn more, see http://www.devexpress.com/Support/Center/Example/Details/E2398
	End Sub

	Sub Application_PreRequestHandlerExecute(ByVal sender As Object, ByVal e As EventArgs)
		DevExpress.Web.ASPxWebControl.GlobalTheme = Utils.CurrentTheme
		If CurrentPage IsNot Nothing Then
			AddHandler CurrentPage.PreInit, AddressOf Page_PreInit
		End If
	End Sub

	Sub Application_End(ByVal sender As Object, ByVal e As EventArgs)
		ReportWebDemo.ReportCaching.CacheReportHelper.EndCreatingReports()
	End Sub

	Protected Sub Session_Start(ByVal sender As Object, ByVal e As EventArgs)
		Session("urls") = New Dictionary(Of String, String)() From {{"XtraReportsDemos.PivotGrid.Report", "Pivot Grid"}, {"XtraReportsDemos.MailMerge.Report", "Mail Merge"}, {"XtraReportsDemos.OddEvenStyles.Report", "Products by Categories"}, {"XtraReportsDemos.CrossBandControls.Report", "Cross Band Controls"}, {"XtraReportsDemos.AnchorVertical.Report", "Anchoring"}, {"XtraReportsDemos.NorthwindTraders.ProductListReport", "Products List"}, {"XtraReportsDemos.NorthwindTraders.CatalogReport", "Fall Catalog"}, {"XtraReportsDemos.NorthwindTraders.InvoiceReport", "Invoice"}, {"XtraReportsDemos.MasterDetailReport.Report", "Suppliers"}, {"XtraReportsDemos.MultiColumnReport.Report", "Customers"}, {"XtraReportsDemos.IListDatasource.Report", "Fishes"}, {"XtraReportsDemos.CustomDraw.Report", "Population"}, {"XtraReportsDemos.ShrinkGrow.Report", "Employees"}, {"XtraReportsDemos.BarCodes.ProductLabelsReport", "Product Labels"}, {"XtraReportsDemos.BarCodes.BarCodeTypesReport", "Barcode Types"}, {"XtraReportsDemos.RichText.Report", "Cars"}, {"XtraReportsDemos.Subreports.MasterReport", "Customers List"}, {"XtraReportsDemos.Subreports.DetailReport", "Customers List Detail"}, {"XtraReportsDemos.TableReport.Report", "Customer Order"}, {"XtraReportsDemos.TreeView.Report", "Countries"}, {"XtraReportsDemos.Charts.Report", "Prices"}, {"XtraReportsDemos.Shape.Report", "Shapes"}, {"XtraReportsDemos.SideBySideReports.EmployeeComparisonReport", "Employee Comparison"}, {"XtraReportsDemos.SideBySideReports.EmployeeOrdersReport", "Employee Orders"}, {"XtraReportsDemos.CalculatedFieldsReport.Report", "Calculated Fields"}, {"XtraReportsDemos.FormattingRules.Report", "Conditional Formatting"}, {"XtraReportsDemos.HugeAmountRecords.Report", "100000 Records"}, {"XtraReportsDemos.PivotGridAndChart.Report", "Pivot Grid and Chart"}, {"XtraReportsDemos.DrillDownReport.DrillDownReport", "Drill-Down"}, {"XtraReportsDemos.PollingReport.PollingReport", "Polling Report"}, {"XtraReportsDemos.CharacterComb.Report", "Character Comb"}}
	End Sub

	Shared ReadOnly Property CurrentPage() As Page
		Get
			Return TryCast(HttpContext.Current.CurrentHandler, Page)
		End Get
	End Property

	Shared Sub Page_PreInit(ByVal sender As Object, ByVal e As EventArgs)
		Utils.RegisterCurrentWebFormsDemo(CurrentPage)
	End Sub
</script>