using System.Collections;
using DevExpress.XtraCharts;

namespace DevExpress.Web.Demos {
    public class ChartSeriesBindingDemoOptions {
        public const string DefaultCategory = "Confections";

        bool showLabels;
        string category = DefaultCategory;
        SeriesPointKey sortingKey = SeriesPointKey.Value_1;
        SortingMode sortingMode = SortingMode.Ascending;
        IEnumerable categories;

        public bool ShowLabels {
            get { return showLabels; }
            set { showLabels = value; }
        }
        public string Category {
            get { return category; }
            set { category = value; }
        }
        public SeriesPointKey SortingKey {
            get { return sortingKey; }
            set { sortingKey = value; }
        }
        public SortingMode SortingMode {
            get { return sortingMode; }
            set { sortingMode = value; }
        }
        public IEnumerable Categories { get { return categories; } }

        public ChartSeriesBindingDemoOptions() {
            categories = NorthwindDataProvider.GetCategoriesNames();
        }
    }
}
