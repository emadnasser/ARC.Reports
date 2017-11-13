using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DevExpress.Web.Demos {
    public class LoanAmortizationScheduleModel : SpreadsheetModelBase {
        public LoanAmortizationScheduleModel() {
            LoanAmount = 19900;
            PeriodInYears = 2;
            InterestRate = 0.055;
            StartDateOfLoan = DateTime.Now;
            PreviewModel.CanShowOnlyFirstWorksheet = true;
            PreviewModel.PreviewDocumentAction = "PreviewLoanAmortizationSchedule";
        }

        public double LoanAmount { get; set; }
        public double InterestRate { get; set; }
        public int PeriodInYears { get; set; }
        public DateTime StartDateOfLoan { get; set; }
        public bool AnnuityPayments { get; set; }        
    }
}
