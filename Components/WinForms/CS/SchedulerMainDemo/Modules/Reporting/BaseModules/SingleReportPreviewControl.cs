using System;
using DevExpress.XtraScheduler.Reporting;
using DevExpress.XtraReports.UserDesigner;

namespace DevExpress.XtraScheduler.Demos.Reporting {

    public partial class SingleReportPreviewControl : ReportPreviewControlBase {
        XtraSchedulerReport report;
        public virtual XtraSchedulerReport Report { get { return report; } }

        protected virtual XtraSchedulerReport CreateReportInstance() {
            return null;
        }
        protected override void CreateReports() {
            System.ComponentModel.DXDisplayNameAttribute.UseResourceManager = true;
            if (this.report != null) {
                this.report.Dispose();
            }
            this.report = CreateReportInstance();
        }
        protected override XtraSchedulerReport GetActiveReport() {
            return Report;
        }
        
	}

}

