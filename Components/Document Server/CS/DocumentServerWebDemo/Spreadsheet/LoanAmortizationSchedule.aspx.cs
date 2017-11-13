using System;
using DevExpress.Spreadsheet;
using System.Globalization;
using DevExpress.Spreadsheet.Demos;

public partial class Spreadsheet_LoanAmortizationSchedule : System.Web.UI.Page {
    protected void Page_Load(object sender, EventArgs e) {
        if(this.previewControl.CanShowPreview()) {
            LoanAmortizationSchedulePreviewParams previewParams = ParsePreview(Request.Params);
            RefreshPreview(previewParams);
            return;
        }
        this.previewControl.Workbook = CreateWorkbook();
    }
    IWorkbook CreateWorkbook() {
        LoanAmortizationScheduleDocumentGenerator generator = new LoanAmortizationScheduleDocumentGenerator(new CultureInfo("en-US"));
        int loanAmount = (int)spnLoanAmount.Number;
        double interestRate = (double)spnInterestRate.Number;
        int periodInYears = (int)spnLoanPeriod.Number;
        DateTime startDateOfLoan = edStartDate.Date;
        return CreateWorkbook(loanAmount, periodInYears, interestRate, startDateOfLoan, true);
    }
    IWorkbook CreateWorkbook(int loanAmount, int loanPeriod, double interestRate, DateTime startDate, bool fitToPage) {
        LoanAmortizationScheduleDocumentGenerator generator = new LoanAmortizationScheduleDocumentGenerator(new CultureInfo("en-US"));
        generator.LoanAmount = loanAmount;
        generator.InterestRate = interestRate;
        generator.PeriodInYears = loanPeriod;
        generator.StartDateOfLoan = startDate;
        generator.FitToPage = fitToPage;
        return generator.Generate();
    }
    protected void OnDocumentDownloaderRequestWorkbook(object sender, RequestWorkbookEventArgs args) {
        args.Workbook = CreateWorkbook();
    }
    void RefreshPreview(LoanAmortizationSchedulePreviewParams previewParams) {
        IWorkbook book = CreateWorkbook(previewParams.LoanAmount, previewParams.LoanPeriod, previewParams.InterestRate, previewParams.StartDate, previewParams.FitToPage);
        this.previewControl.Workbook = book;
        this.previewControl.RenderSpreadsheetPreview();    
    }
    LoanAmortizationSchedulePreviewParams ParsePreview(System.Collections.Specialized.NameValueCollection nameValueCollection) {
        string spnLoanAmountStringValue = Request.Params["spnLoanAmount"];
        string spnLoanPeriodStringValue = Request.Params["spnLoanPeriod"];
        string spnInterestRateStringValue = Request.Params["spnInterestRate"];
        string edStartDateStringValue = Request.Params["edStartDate"];
        LoanAmortizationSchedulePreviewParams previewParams = new LoanAmortizationSchedulePreviewParams();
        previewParams.LoanAmount = (String.IsNullOrEmpty(spnLoanAmountStringValue)) ? (int)this.spnLoanAmount.Number : Convert.ToInt32(spnLoanAmountStringValue);
        previewParams.LoanPeriod = (String.IsNullOrEmpty(spnLoanPeriodStringValue)) ? (int)this.spnLoanPeriod.Number : Convert.ToInt32(spnLoanPeriodStringValue);
        previewParams.InterestRate = (String.IsNullOrEmpty(spnInterestRateStringValue)) ? (double)this.spnInterestRate.Number : Convert.ToDouble(spnInterestRateStringValue);
        previewParams.StartDate = (String.IsNullOrEmpty(edStartDateStringValue)) ? DateTime.Now.Date : DateTime.ParseExact(edStartDateStringValue, "dd/MM/yyyy", CultureInfo.InvariantCulture);
        previewParams.FitToPage = true;
        return previewParams;
    }
}
public class LoanAmortizationSchedulePreviewParams {
    public int LoanAmount { get; set; }
    public int LoanPeriod { get; set; }
    public double InterestRate { get; set; }
    public DateTime StartDate { get; set; }
    public bool FitToPage { get; set; }
}

