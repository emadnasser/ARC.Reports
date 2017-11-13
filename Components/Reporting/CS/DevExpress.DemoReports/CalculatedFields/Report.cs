using System.Drawing.Printing;
using System.Linq;
using DevExpress.XtraReports.Parameters;

namespace XtraReportsDemos.CalculatedFieldsReport {
    public partial class Report : DevExpress.XtraReports.UI.XtraReport {
        public Report() {
            InitializeComponent();
            Name = ReportNames.CalculatedFieldsReport;
            DisplayName = ReportNames.CalculatedFieldsReport;
        }

        void Report_BeforePrint(object sender, PrintEventArgs e) {
            UpdateReportCalculatedField();
        }

        void UpdateReportCalculatedField() {
            string columnName = GetDescription((StaticListLookUpSettings)ExpressionParameter.LookUpSettings, (string)ExpressionParameter.Value);
            string expressionValue = (string)ExpressionParameter.Value;
            SetReportParameters(columnName, expressionValue);
        }

        void SetReportParameters(string columnName, string expression) {
            calculatedField1.Expression = expression;
            xrTableCell12.Text = columnName;
            xrLabel3.Summary.FormatString = "Total " + columnName + @" - {0:c}";
            xrLabel3.XlsxFormatString = @"""Total " + columnName + @" - ""$0.00";
        }

        static string GetDescription(StaticListLookUpSettings lookupSettings, string value) {
            var lookup = lookupSettings.LookUpValues.FirstOrDefault(x => (string)x.Value == value);
            return lookup != null ? lookup.Description : "";
        }
    }
}
