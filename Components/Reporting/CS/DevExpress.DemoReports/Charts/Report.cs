using System.Linq;
using DevExpress.XtraCharts;
using DevExpress.XtraReports.Parameters;

namespace XtraReportsDemos.Charts {
    public partial class Report : DevExpress.XtraReports.UI.XtraReport {
        public Report() {
            InitializeComponent();

            Name = ReportNames.Charts;
            DisplayName = ReportNames.Charts;

            var lookups = xrChart1
                .GetAppearanceNames()
                .Select(x => new LookUpValue { Value = x });

            AppearanceParameter.Value = xrChart1.AppearanceName;
            ((StaticListLookUpSettings)AppearanceParameter.LookUpSettings).LookUpValues.AddRange(lookups);
        }

        void Report_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e) {
            xrChart1.AppearanceName = (string)AppearanceParameter.Value;

            bool colorEach = (bool)ColorEachParameter.Value;
            foreach(Series series in xrChart1.Series) {
                if(series.View is SeriesViewColorEachSupportBase)
                    ((SeriesViewColorEachSupportBase)series.View).ColorEach = colorEach;
                else if(series.View is SeriesView3DColorEachSupportBase)
                    ((SeriesView3DColorEachSupportBase)series.View).ColorEach = colorEach;
            }
        }

        public void RemoveReportHeader() {
            ReportHeader.Visible = false;
        }
    }
}
