using System;
using DevExpress.Web.Demos;

public partial class ApplicationScenarios_DynamicSheetGeneration : OfficeDemoPage {
    protected void Page_Load(object sender, EventArgs e) {
        bool isDocumentLoaded = !Page.IsPostBack;
        if(isDocumentLoaded)
            InitializeReportParameters();

        LoanAmortizationScheduleDemoHelper demoHelper = new LoanAmortizationScheduleDemoHelper{
            LoanAmount = (double)LoanAmount.Number,
            AnnualInterestRate = AnnualInterestRate.Number,
            LoanPeriodInYears = (int)LoanPeriodInYears.Number,
            NumberOfPayments = (int)NumberOfPayments.Number,
            StartDate = (DateTime)StartDate.Value,
            OptionalExtraPayments = (double)OptionalExtraPayments.Number
        };
        demoHelper.PrepareSpreadsheetDocument(Spreadsheet.Document);
        SpreadsheetDemoUtils.HideFileTab(Spreadsheet);
    }
    void InitializeReportParameters() {
        LoanAmount.Value = 19900;
        AnnualInterestRate.Value = 0.055;
        LoanPeriodInYears.Value = 2;
        NumberOfPayments.Value = 12;
        StartDate.Value = DateTime.Now;
        OptionalExtraPayments.Value = 200;
    }
}
