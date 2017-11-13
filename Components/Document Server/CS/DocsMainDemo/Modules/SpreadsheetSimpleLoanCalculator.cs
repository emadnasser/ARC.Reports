using System;
using System.Drawing;
using DevExpress.Spreadsheet;
using System.Globalization;
using DevExpress.Spreadsheet.Demos;

namespace DevExpress.Docs.Demos {
    public partial class SpreadsheetSimpleLoanCalculatorModule : SpreadsheetTutorialControl {
        public SpreadsheetSimpleLoanCalculatorModule() {
            InitializeComponent();
            //SuppressRefreshPreview();
            this.FitToPageCheckEdit.CheckState = System.Windows.Forms.CheckState.Checked;
            //ResumeRefreshPreview();
            //RefreshPreview(); // not needed
        }

        protected override string DefaultFileName { get { return "Simple_Loan_Calculator"; } }

        public override IWorkbook CreateBook() {
            LoanAmortizationScheduleDocumentGenerator generator = new LoanAmortizationScheduleDocumentGenerator(DefaultCulture);
            generator.LoanAmount = (double)this.loanAmountSE.Value;
            generator.InterestRate = (double)annualInterestRateSE.Value;
            generator.PeriodInYears = (int)loanPeriodinYearsSE.Value;
            generator.StartDateOfLoan = startDateofLoanDE.DateTime;
            generator.FitToPage = FitToPageCheckEdit.Checked;
            return generator.Generate();
        }

        void loanAmountSE_EditValueChanged(object sender, System.EventArgs e) {
            RefreshPreview();
        }
        void annualInterestRateSE_ValueChanged(object sender, System.EventArgs e) {
            RefreshPreview();
        }
        void loanPeriodinYearsSE_ValueChanged(object sender, System.EventArgs e) {
            RefreshPreview();
        }
        void startDateofLoanTE_EditValueChanged(object sender, System.EventArgs e) {
            RefreshPreview();
        }
    }
}
