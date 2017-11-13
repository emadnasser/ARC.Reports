using DevExpress.Mvvm.Native;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace ChartsDemo {
    public class BindingUsingSeriesTemplateViewModel {
        IEnumerable<GDPItem> dataSource;
        IEnumerable<ChartDataBindingControlSeriesViewModel> series;

        public BindingUsingSeriesTemplateViewModel() {
            ShowLabels = true;
            SelectedSeries = this.Series.First();
        }
        public IEnumerable<GDPItem> DataSource {
            get {
                if(dataSource == null) {
                    dataSource = DataLoader.LoadXmlFromResources("/Data/GDPofG7.xml")
                        .Element("G7GDPs").Elements().Where(e => int.Parse(e.Element("Year").Value) > 2010)
                        .Select(e => new GDPItem(e.Element("Country").Value, e.Element("Year").Value, Convert.ToDouble(e.Element("Product").Value, CultureInfo.InvariantCulture)))
                        .OrderBy(gdpItem => gdpItem.Year)
                        .ToList();
                }
                return dataSource;
            }
        }
        public IEnumerable<ChartDataBindingControlSeriesViewModel> Series {
            get {
                if(series == null) {
                    var series2 = new ChartDataBindingControlSeriesViewModel("Year", "Country", true);
                    var series1 = new ChartDataBindingControlSeriesViewModel("Country", "Year", false);
                    series = new ChartDataBindingControlSeriesViewModel[] { series1, series2 };
                }
                return series;
            }
        }
        public virtual bool ShowLabels { get; set; }
        public virtual ChartDataBindingControlSeriesViewModel SelectedSeries { get; set; }
        public virtual IChartAnimationService ChartAnimationService { get { return null; } }
        public void OnModuleAppear() {
            if(ChartAnimationService != null)
                ChartAnimationService.Animate();
        }
        protected void OnSelectedSeriesChanged(ChartDataBindingControlSeriesViewModel oldValue) {
            if(ChartAnimationService != null)
                ChartAnimationService.Animate();
        }
    }


    public class ChartDataBindingControlSeriesViewModel {
        public ChartDataBindingControlSeriesViewModel(string dataMember, string argumentDataMember, bool staggered) {
            DataMember = dataMember;
            ArgumentDataMember = argumentDataMember;
            Staggered = staggered;
        }
        public string DataMember { get; private set; }
        public string ArgumentDataMember { get; private set; }
        public bool Staggered { get; private set; }
    }

    public class GDPItem {
        public GDPItem(string region, string year, double product) {
            Country = region;
            Year = year;
            Product = product;
        }
        public double Product { get; private set; }
        public string Country { get; private set; }
        public string Year { get; private set; }
    }
}
