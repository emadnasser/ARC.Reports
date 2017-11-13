using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Web;
using DevExpress.Web.Demos.Code.Designer;
using DevExpress.XtraReports.UI;

namespace DevExpress.Web.Demos {
    public static class ReportDemoHelper {
        public static readonly Dictionary<string, Func<XtraReport>> Reports = new Dictionary<string, Func<XtraReport>> {
            { "Table", () => new XtraReportsDemos.TableReport.Report() },
            { "PollingReport", () => new XtraReportsDemos.PollingReport.PollingReport() },
            { "MasterDetail", () => new XtraReportsDemos.MasterDetailReport.Report() },
            { "Subreports", () => new XtraReportsDemos.Subreports.MasterReport() },
            { "MultiColumn", () => new XtraReportsDemos.MultiColumnReport.Report() },
            { "Label", () => new XtraReportsDemos.BarCodes.ProductLabelsReport() },
            { "ReportMerging", () => new XtraReportsDemos.ReportMerging.MergedReport() },
            { "SideBySide", () => new XtraReportsDemos.SideBySideReports.EmployeeComparisonReport() },
            { "PivotGridAndChart", () => new XtraReportsDemos.PivotGridAndChart.Report() },
            { "IListDataSource", () => new XtraReportsDemos.IListDatasource.Report() },
            { "CalculatedFields", () => new XtraReportsDemos.CalculatedFieldsReport.Report() },
            { "CrossBandControls", () => new XtraReportsDemos.CrossBandControls.Report() },
            { "MailMerge", () => new XtraReportsDemos.MailMerge.Report() },
            { "ShrinkGrow", () => new XtraReportsDemos.ShrinkGrow.Report() },
            { "VerticalAnchoring", () => new XtraReportsDemos.AnchorVertical.Report() },
            { "Sparkline", () => new XtraReportsDemos.Sparkline.Report() },
            { "RichText", () => new XtraReportsDemos.RichText.Report() },
            { "BarCode", () => new XtraReportsDemos.BarCodes.BarCodeTypesReport() },
            { "Shapes", () => new XtraReportsDemos.Shape.Report() },
            { "Chart", () => new XtraReportsDemos.Charts.Report() },
            { "XRPivotGrid", () => new XtraReportsDemos.PivotGrid.Report() },
            { "CrossBand", () => new XtraReportsDemos.CrossBandControls.Report() },
            { "CustomControl", () => new XtraReportsDemos.CustomDraw.Report() },
            { "FormattingRules", () => new XtraReportsDemos.FormattingRules.Report { FilterString = "[OrderDate] Between(#1996-01-01#, #1997-01-01#)" } },
            { "OddEvenStyles", () => new XtraReportsDemos.OddEvenStyles.Report() },
            { "FallCatalog", () => new XtraReportsDemos.NorthwindTraders.CatalogReport() },
            { "Invoice", () => new XtraReportsDemos.NorthwindTraders.InvoiceReport() },
            { "ProductList", () => new XtraReportsDemos.NorthwindTraders.ProductListReport() },
            { "Thumbnails", () => ApplyThumbnails(new XtraReportsDemos.ShrinkGrow.Report()) },
            { "DrillDown", () => new XtraReportsDemos.DrillDownReport.DrillDownReport() },
            { "CharacterComb", () => new XtraReportsDemos.CharacterComb.Report() }
        };

        public static ReportsDemoModel CreateModel(string reportID, HttpSessionStateBase session, HttpRequestBase request) {
            return new ReportsDemoModel {
                ReportID = reportID,
                Report = ReportStorageHelper.LoadReport(reportID, session),
                CurrentViewer = request.Params[ViewerSelectorState.Key],
                EmulatorModel = new MobileEmulatorModel(reportID, request)
            };
        }

        internal static XtraReport GetReport(string reportID) {
            if(reportID == "Overview") {
                return new XtraReportsDemos.Overview.Report();
            }
            return Reports[reportID]();
        }

        static XtraReport ApplyThumbnails(XtraReportsDemos.ShrinkGrow.Report report) {
            report.PaperKind = PaperKind.A5;
            report.Landscape = true;
            report.Margins.Left = 90;
            report.Margins.Right = 85;
            report.xrPictureBox1.BeforePrint += (s, e) => {
                var bookmark = string.Format("{0} {1}", report.GetCurrentColumnValue("FirstName"), report.GetCurrentColumnValue("LastName"));
                report.xrPictureBox1.Bookmark = bookmark;
            };
            return report;
        }
    }
}
