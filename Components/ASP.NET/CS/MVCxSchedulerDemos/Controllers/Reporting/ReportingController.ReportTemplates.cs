﻿using System;
using System.Web.Mvc;
using DevExpress.Web.Mvc;
using DevExpress.XtraReports.UI;
using DevExpress.XtraScheduler;
using DevExpress.XtraScheduler.Reporting;

namespace DevExpress.Web.Demos {
    public partial class ReportingController: DemoController {
        public ActionResult ReportTemplates() {
            return DemoView("ReportTemplates", SchedulerDataHelper.DataObject);
        }
        public ActionResult ReportTemplatesPartial() {
            return PartialView("ReportTemplatesPartial", SchedulerDataHelper.DataObject);
        }
        public ActionResult ReportTemplatesViewerPartial() {
            XtraSchedulerReport report = CreateSchedulerReport(SchedulerDemoHelper.ReportTemplatesOptions);
            return PartialView("ReportTemplatesViewerPartial", report);
        }
        public ActionResult ReportTemplatesViewerExportTo() {
            XtraSchedulerReport report = CreateSchedulerReport(SchedulerDemoHelper.ReportTemplatesOptions);
            return ReportViewerExtension.ExportTo((XtraReport)report.Report);
        }
        public ActionResult ReportTemplatesUpdateOptions(string reportTemplateFileName, DateTime startDate, DateTime endDate) {
            SchedulerDemoHelper.ReportTemplatesOptions.ReportTemplateFileName = reportTemplateFileName;
            SchedulerDemoHelper.ReportTemplatesOptions.StartDate = startDate;
            SchedulerDemoHelper.ReportTemplatesOptions.EndDate = endDate;
            return new EmptyResult();
        }

        XtraSchedulerReport CreateSchedulerReport(SchedulerReportTemplatesDemoOptions options) {
            if(string.IsNullOrEmpty(options.ReportTemplateFileName))
                return null;

            XtraSchedulerReport report = new XtraSchedulerReport();
            var printAdapter = SchedulerExtension.GetPrintAdapter(SchedulerDemoHelper.ReportTemplatesSchedulerSettings,
                SchedulerDataHelper.DataObject.Appointments, SchedulerDataHelper.DataObject.Resources);
            printAdapter.TimeInterval = GetPrintTimeInterval(options.StartDate, options.EndDate);
            printAdapter.EnableSmartSync = options.ReportTemplateFileName.ToLower().Contains("trifold");
            report.SchedulerAdapter = printAdapter.SchedulerAdapter;
            report.LoadLayout(System.Web.HttpContext.Current.Server.MapPath("~/App_Data/SchedulerReportTemplates/" + options.ReportTemplateFileName));
            return report;
        }
        static TimeInterval GetPrintTimeInterval(DateTime startDate, DateTime endDate) {
            return (startDate <= endDate) ? new TimeInterval(startDate, endDate) : new TimeInterval(endDate, startDate);
        }
    }
}
