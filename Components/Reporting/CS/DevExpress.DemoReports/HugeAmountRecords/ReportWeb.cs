using System;
using System.Collections.Generic;
using System.Text;

namespace XtraReportsDemos.HugeAmountRecords {
    public class ReportWeb : Report {
        public ReportWeb() {
            Parameters["RowCountParameter"].Value = 10000u;
        }
        protected override string ReportName {
            get {
                return ReportNames.HugeAmountRecordsWeb;
            }
        }
    }
}
