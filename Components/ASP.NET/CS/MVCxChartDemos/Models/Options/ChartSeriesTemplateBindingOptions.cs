namespace DevExpress.Web.Demos {
    public class ChartSeriesTemplateBindingDemoOptions {
        public const string Country = "Country";
        public const string Year = "Year";

        bool showLabels;
        string seriesDataMember = Year;

        public bool ShowLabels {
            get { return showLabels; }
            set { showLabels = value; }
        }
        public string SeriesDataMember {
            get { return seriesDataMember; }
            set { seriesDataMember = string.IsNullOrEmpty(value) ? Year : value; }
        }
        public string ArgumentDataMember { get { return seriesDataMember == Country ? Year : Country; } }

        public ChartSeriesTemplateBindingDemoOptions() { }
    }
}
