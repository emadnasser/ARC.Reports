using System;
using DevExpress.XtraPrinting;
using DevExpress.XtraReports.UI;

namespace XtraReportsDemos.ReportMerging {
    public class MergedReport : NorthwindTraders.CatalogReport {
        Charts.Report fChartsReport = new XtraReportsDemos.Charts.Report();
        Page categoryStartPage;

        public Charts.Report ChartsReport {
            get { return fChartsReport; }
        }
        protected override bool EnableGroupsSorting {
            get { return false; }
        }

        public MergedReport() {
            AfterPrint += ReportAfterPrint;
            GroupHeader.PageBreak = PageBreak.BeforeBand;

            fChartsReport.RemoveReportHeader();

            lbCategoryName.PrintOnPage += lbCategoryName_PrintOnPage;
        }

        void lbCategoryName_PrintOnPage(object sender, PrintOnPageEventArgs e) {
            if(IsDisposed || categoryStartPage != null)
                return;
            categoryStartPage = Pages[e.PageIndex];
        }
        void ReportAfterPrint(object sender, EventArgs e) {
            if(IsDisposed || categoryStartPage == null)
                return;
            fChartsReport.CreateDocument();
            int categoryStartPageIndex = categoryStartPage.Index;
            categoryStartPage = null;
            for(int i = 0; i < fChartsReport.Pages.Count; i++) {
                int insertIndex = categoryStartPageIndex + 1 + i * 2;
                if(insertIndex >= Pages.Count)
                    break;
                Pages.Insert(insertIndex, fChartsReport.Pages[i]);
            }
        }
        protected override void Dispose(bool disposing) {

            if(disposing) {
                AfterPrint -= ReportAfterPrint;
                lbCategoryName.PrintOnPage -= lbCategoryName_PrintOnPage;
                if(fChartsReport != null) {
                    fChartsReport.Dispose();
                    fChartsReport = null;
                }
            }
            base.Dispose(disposing);
        }
    }
}
