<%@ Application Language="C#" %>

<script RunAt="server">
    void Application_Start(object sender, EventArgs e) {
        DevExpress.XtraReports.Web.ReportDesigner.Native.ReportDesignerBootstrapper.SessionState = SessionStateBehavior.Required;
        DevExpress.XtraReports.Web.WebDocumentViewer.Native.WebDocumentViewerBootstrapper.SessionState = SessionStateBehavior.Required;
        DevExpress.Internal.DataDirectoryHelper.DataFolderName = "App_Data";
        ReportWebDemo.ReportCaching.CacheReportHelper.StartCreatingReports();
        DevExpress.XtraReports.Web.Extensions.ReportStorageWebExtension.RegisterExtensionGlobal(new DemoReportStorageExtension());
        Utils.EnsureRequestValidationMode();
        DevExpress.Web.ASPxWebControl.CallbackError += new EventHandler(CallbackError);
        DevExpress.XtraReports.Web.WebDocumentViewer.DefaultWebDocumentViewerContainer.UseFileDocumentStorage(Server.MapPath("~/App_Data/WebDocumentViewerCache"));
        DevExpress.XtraReports.Web.Native.ClientControls.Services.DefaultLoggingService.SetInstance(new DevExpress.Web.Demos.DemoLoggingService());
        DevExpress.XtraReports.Web.WebDocumentViewer.DefaultWebDocumentViewerContainer.RegisterWebDocumentViewerDrillThroughProcessor<WebDocumentViewerDrillThroughProcessor>();
        DevExpress.XtraReports.Web.ReportDesigner.DefaultReportDesignerContainer.RegisterDataSourceWizardConnectionStringsProvider<DataSourceWizardConnectionStringsProvider>();
        DevExpress.XtraReports.Web.ASPxReportDesigner.ShouldClearReportScripts = true;
    }

    void CallbackError(object sender, EventArgs e) {
        // Logging exceptions occur on callback events of DevExpress ASP.NET controls.
        // To learn more, see http://www.devexpress.com/Support/Center/Example/Details/E2398
    }

    void Application_PreRequestHandlerExecute(object sender, EventArgs e) {
        DevExpress.Web.ASPxWebControl.GlobalTheme = Utils.CurrentTheme;
        if(CurrentPage != null) {
            CurrentPage.PreInit += Page_PreInit;
        }
    }

    void Application_End(object sender, EventArgs e) {
        ReportWebDemo.ReportCaching.CacheReportHelper.EndCreatingReports();
    }

    protected void Session_Start(object sender, EventArgs e) {
        Session["urls"] = new Dictionary<string, string>(){
        {"XtraReportsDemos.PivotGrid.Report", "Pivot Grid"},
        {"XtraReportsDemos.MailMerge.Report", "Mail Merge"},
        {"XtraReportsDemos.OddEvenStyles.Report", "Products by Categories"},
        {"XtraReportsDemos.CrossBandControls.Report", "Cross Band Controls"},
        {"XtraReportsDemos.AnchorVertical.Report", "Anchoring"},
        {"XtraReportsDemos.NorthwindTraders.ProductListReport", "Products List"},
        {"XtraReportsDemos.NorthwindTraders.CatalogReport", "Fall Catalog"},
        {"XtraReportsDemos.NorthwindTraders.InvoiceReport", "Invoice"},
        {"XtraReportsDemos.MasterDetailReport.Report", "Suppliers"},
        {"XtraReportsDemos.MultiColumnReport.Report", "Customers"},
        {"XtraReportsDemos.IListDatasource.Report", "Fishes"},
        {"XtraReportsDemos.CustomDraw.Report", "Population"},
        {"XtraReportsDemos.ShrinkGrow.Report", "Employees"},
        {"XtraReportsDemos.BarCodes.ProductLabelsReport", "Product Labels"},
        {"XtraReportsDemos.BarCodes.BarCodeTypesReport", "Barcode Types"},
        {"XtraReportsDemos.RichText.Report", "Cars"},
        {"XtraReportsDemos.Subreports.MasterReport", "Customers List"},
        {"XtraReportsDemos.Subreports.DetailReport", "Customers List Detail"},
        {"XtraReportsDemos.TableReport.Report", "Customer Order"},
        {"XtraReportsDemos.TreeView.Report", "Countries"},
        {"XtraReportsDemos.Charts.Report", "Prices"},
        {"XtraReportsDemos.Shape.Report", "Shapes"},
        {"XtraReportsDemos.SideBySideReports.EmployeeComparisonReport", "Employee Comparison"},
        {"XtraReportsDemos.SideBySideReports.EmployeeOrdersReport", "Employee Orders"},
        {"XtraReportsDemos.CalculatedFieldsReport.Report", "Calculated Fields"},
        {"XtraReportsDemos.FormattingRules.Report", "Conditional Formatting"},
        {"XtraReportsDemos.HugeAmountRecords.Report", "100000 Records"},
        {"XtraReportsDemos.PivotGridAndChart.Report", "Pivot Grid and Chart"},
        {"XtraReportsDemos.DrillDownReport.DrillDownReport", "Drill-Down"},
        {"XtraReportsDemos.PollingReport.PollingReport", "Polling Report"},
        {"XtraReportsDemos.CharacterComb.Report", "Character Comb"},
        };
    }

    static Page CurrentPage {
        get { return HttpContext.Current.CurrentHandler as Page; }
    }

    static void Page_PreInit(object sender, EventArgs e) {
        Utils.RegisterCurrentWebFormsDemo(CurrentPage);
    }
</script>
