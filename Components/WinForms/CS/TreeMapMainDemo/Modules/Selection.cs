using System;
using System.Collections.Generic;
using System.Drawing;
using System.Xml.Linq;
using System.Globalization;
using DevExpress.XtraMap;
using DevExpress.XtraCharts;

namespace DevExpress.XtraTreeMap.Demos {
    public partial class Selection : TreeMapTutorialControl {
        const double InitialMapSizeCoefficient = 1.2;
        const byte AlphaColor = 128;
        const string ChartTitle = "GDP Dynamic";
        bool isSelectionLocked = false;
        List<CountryStatisticInfo> countries;

        VectorItemsLayer BackgroundLayer { get { return (VectorItemsLayer)mapControl.Layers["BackgroundLayer"]; } }
        VectorItemsLayer DataLayer { get { return (VectorItemsLayer)mapControl.Layers["FileLayer"]; } }
        TreeMapFlatDataAdapter DataAdapter { get { return (TreeMapFlatDataAdapter)treeMapControl1.DataAdapter; } }
        ChoroplethColorizer MapColorizer { get { return (ChoroplethColorizer)DataLayer.Colorizer; } }
        TreeMapPaletteColorizer TreeMapColorizer { get { return (TreeMapPaletteColorizer)treeMapControl1.Colorizer; } }
        Series ChartSeries { get { return chartControl1.Series[0]; } }


        public Selection() {
            InitializeComponent();
            countries = CountriesInfoDataReader.Load();
            BackgroundLayer.Data = CreateShapefileDataAdapter();
            DataLayer.Data = CreateShapefileDataAdapter();
            DataLayer.DataLoaded += FileLayer_DataLoaded;
            DataAdapter.DataSource = countries;
            InitializeColorizers();
        }

        void InitializeColorizers() {
            TreeMapColorizer.Palette = Palette.CreatePalette(Utils.SelectionPalette);
            foreach (Color color in Utils.SelectionPalette)
                MapColorizer.ColorItems.Add(new ColorizerColorItem(color));
        }
        ShapefileDataAdapter CreateShapefileDataAdapter() {
            ShapefileDataAdapter adapter = new ShapefileDataAdapter();
            adapter.FileUri = new Uri("file:\\\\" + Utils.GetRelativePath("CountriesGDP.shp"), UriKind.RelativeOrAbsolute);
            return adapter;
        }
        void SetMapItems(IEnumerable<MapItem> layerMapItemCollection) {
            foreach (MapItem item in layerMapItemCollection) {
                string shapeName = (string)item.Attributes["NAME"].Value;
                if (shapeName == "Others")
                    item.Visible = false;
                CountryStatisticInfo countryInfo = countries.Find(info => info.Name == shapeName);
                if (countryInfo != null) {
                    countryInfo.Shape = item;
                    item.Attributes.Add(new MapItemAttribute() { Name = "CountryInfo", Type = typeof(CountryStatisticInfo), Value = countryInfo });
                    if (countryInfo.Name == "United States")
                        DataLayer.SelectedItem = item;
                }
            }
        }
        void UpdateChart(CountryStatisticInfo countryInfo) {
            if (countryInfo != null) {
                ChartSeries.DataSource = countryInfo.GDPDynamic;
                ChartSeries.View.Color = Color.FromArgb(AlphaColor, Utils.SelectionPalette[countryInfo.ColorIndex]);
                chartControl1.Titles[0].Text = countryInfo.Name + " " + ChartTitle;
            }
            else {
                ChartSeries.DataSource = null;
                chartControl1.Titles[0].Text = String.Empty;
            }
        }
        void FileLayer_DataLoaded(object sender, DataLoadedEventArgs e) {
            SetMapItems(((MapItemsLoadedEventArgs)e).Items);
        }
        void mapControl_SelectionChanged(object sender, MapSelectionChangedEventArgs e) {
            CountryStatisticInfo countryInfo = GetMapSelectedCountryInfo();
            UpdateSelection(countryInfo, (country) => {
                treeMapControl1.SelectedItems.Clear();
                if (country != null)
                    treeMapControl1.SelectedItems.Add(country);
            });
        }
        void treeMapControl_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            CountryStatisticInfo countryInfo = GetTreeMapSelectedCountryInfo();
            UpdateSelection(countryInfo, (country) => {
                DataLayer.SelectedItems.Clear();
                if (country != null)
                    DataLayer.SelectedItems.Add(((CountryStatisticInfo)country).Shape);
            });
        }
        void layoutControl_ClientSizeChanged(object sender, EventArgs e) {
            mapControl.EnableZooming = true;
            mapControl.ZoomToFitLayerItems();
            mapControl.EnableZooming = false;
        }
        CountryStatisticInfo GetTreeMapSelectedCountryInfo() {
            if (treeMapControl1.SelectedItems.Count > 0)
                return (CountryStatisticInfo)treeMapControl1.SelectedItems[0];
            return null;
        }
        CountryStatisticInfo GetMapSelectedCountryInfo() {
            if (DataLayer.SelectedItems.Count > 0) {
                MapItem mapItem = (MapItem)DataLayer.SelectedItems[0];
                return (CountryStatisticInfo)mapItem.Attributes["CountryInfo"].Value;
            }
            return null;
        }
        void UpdateSelection(CountryStatisticInfo countryInfo, Action<CountryStatisticInfo> action) {
            if (!isSelectionLocked) {
                isSelectionLocked = true;
                try {
                    action(countryInfo);
                    UpdateChart(countryInfo);
                }
                finally {
                    isSelectionLocked = false;
                }
            }
        }
    }

    public class CountryStatisticInfo {
        readonly string name;
        readonly string continent;
        readonly List<GDPStatisticByYear> statistic;
        readonly double gdp;
        readonly int colorIndex;
        MapItem shape;

        public string Name { get { return name; } }
        public string Continent { get { return continent; } }
        public List<GDPStatisticByYear> GDPDynamic { get { return statistic; } }
        public double GDP { get { return gdp; } }
        public int ColorIndex { get { return colorIndex; } }
        public MapItem Shape { get { return shape; } set { shape = value; } }

        public CountryStatisticInfo(string name, string continent, double gdp, int colorIndex, List<GDPStatisticByYear> statistic) {
            this.name = name;
            this.continent = continent;
            this.gdp = gdp;
            this.colorIndex = colorIndex;
            this.statistic = statistic;
        }
    }

    public class GDPStatisticByYear {
        int year;
        double gdp;

        public int Year { get { return year; } }
        public double GDP { get { return gdp; } }

        public GDPStatisticByYear(int year, double gdp) {
            this.year = year;
            this.gdp = gdp;
        }
    }

    class CountriesInfoDataReader {
        static List<GDPStatisticByYear> LoadStatistic(XElement exportOfGoodsDynamic) {
            List<GDPStatisticByYear> statistic = new List<GDPStatisticByYear>();
            foreach (XElement exportOfGoodsDynamicItem in exportOfGoodsDynamic.Elements("GDPByYear")) {
                int year = int.Parse(exportOfGoodsDynamicItem.Element("Year").Value);
                double exportOfGoodsPercent = double.Parse(exportOfGoodsDynamicItem.Element("GDP").Value, CultureInfo.InvariantCulture);
                GDPStatisticByYear popDynamicItem = new GDPStatisticByYear(year, exportOfGoodsPercent);
                statistic.Add(popDynamicItem);
            }
            return statistic;
        }
        public static List<CountryStatisticInfo> Load() {
            List<CountryStatisticInfo> data = new List<CountryStatisticInfo>();
            try {
                XDocument Top10LargestCountries_xml = XDocument.Load(Utils.GetRelativePath("CountriesGDPByYears.xml"));
                foreach (XElement countryInfo in Top10LargestCountries_xml.Root.Elements("CountryInfo")) {
                    string name = countryInfo.Element("Name").Value;
                    string gdp = countryInfo.Element("GDP").Value;
                    string continent = countryInfo.Element("Continent").Value;
                    string colorIndex = countryInfo.Element("ColorIndex").Value;
                    List<GDPStatisticByYear> statistic = LoadStatistic(countryInfo.Element("Statistic"));
                    CountryStatisticInfo countryInfoInstance = new CountryStatisticInfo(name, continent, Convert.ToDouble(gdp), Convert.ToInt32(colorIndex), statistic);
                    data.Add(countryInfoInstance);
                }
            }
            catch {
            }
            return data;
        }
    }
}
