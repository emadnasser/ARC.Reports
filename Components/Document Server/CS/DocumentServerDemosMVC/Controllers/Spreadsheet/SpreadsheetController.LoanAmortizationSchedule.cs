using DevExpress.Web;
using DevExpress.Web.Internal;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;
using System.Net;
using System.IO;
using DevExpress.Docs.Demos;
using DevExpress.Spreadsheet;
using System;
using DevExpress.Web.ASPxTreeList;
using System.Collections.Generic;
using System.Web.Script.Serialization;
using DevExpress.Spreadsheet.Demos;
using System.Globalization;

namespace DevExpress.Web.Demos {
    public partial class SpreadsheetController : DemoController {
        public ActionResult LoanAmortizationSchedule() {
            LoanAmortizationScheduleModel model = new LoanAmortizationScheduleModel();
            model.PreviewModel.Workbook = CreateLoanAmortizationScheduleWorkbook(model);
            return DemoView("LoanAmortizationSchedule", model);
        }
        public ActionResult LoanAmortizationScheduleExportTo(LoanAmortizationScheduleModel model) {
            IWorkbook workbook = CreateLoanAmortizationScheduleWorkbook(model);
            return GenerateFile(workbook, model);
        }        
        public ActionResult PreviewLoanAmortizationSchedule(LoanAmortizationScheduleModel model) {
            SpreadsheetPreviewModel previewModel = new SpreadsheetPreviewModel();
            previewModel.Workbook = CreateLoanAmortizationScheduleWorkbook(model);
            return GenerateHtmlPreview(previewModel);
        }
        IWorkbook CreateLoanAmortizationScheduleWorkbook(LoanAmortizationScheduleModel model) {
            LoanAmortizationScheduleDocumentGenerator generator = new LoanAmortizationScheduleDocumentGenerator(new CultureInfo("en-US"));
            generator.LoanAmount = model.LoanAmount;
            generator.InterestRate = model.InterestRate;
            generator.PeriodInYears = model.PeriodInYears;
            generator.StartDateOfLoan = model.StartDateOfLoan;
            generator.FitToPage = true;
            return generator.Generate();
        }
    }    
}
