using System.Drawing.Printing;
using DevExpress.XtraReports.UI;

namespace XtraReportsDemos.FormattingRules {
    public partial class Report : XtraReport {
        public Report() {
            InitializeComponent();
            Name = ReportNames.FormattingRulesReport;
            DisplayName = ReportNames.FormattingRulesReport;
        }

        void Report_BeforePrint(object sender, PrintEventArgs e) {
            UpdateFormattingRule();
        }

        void UpdateFormattingRule() {
            formattingRule1.Condition = (string)ConditionParameter.Value;
            formattingRule1.ApplyStyle(StyleSheet[(string)StyleParameter.Value]);
        }
    }
}
