using System;
using System.Windows.Forms;
using System.Drawing;
using System.Collections.Generic;
using DevExpress.Utils;
using System.Xml.Linq;
using DevExpress.Demos.OpenWeatherService;
using DevExpress.XtraBars;

namespace DevExpress.XtraMap.Demos {

    public partial class WorldWeather : MapTutorialControl {
        OpenWeatherMapService openWeatherMapService;
        CityWeather actualWeatherInfo;
        TemperatureMeasureUnits actualMeasureUnits = TemperatureMeasureUnits.Celsius;

        protected override MapOverlay[] Overlays { get { return OverlayUtils.GetBingOverlays(); } }
        protected OpenWeatherMapService OpenWeatherMapService { get { return openWeatherMapService; } }
        protected override MiniMapAlignment MiniMapAlignment { get { return MiniMapAlignment.TopRight; } }
        public override MapControl MapControl { get { return mapControl1; } }

        public WorldWeather() {
            AutoMergeRibbon = true;
            InitializeComponent();
            DemoUtils.SetBingMapDataProviderKey(BingDataProvider);
            mapControl1.SetMapItemFactory(new DemoWeatherItemFactory());

            this.openWeatherMapService = new OpenWeatherMapService(LoadCapitalsFromXML());
            this.OpenWeatherMapService.ReadCompleted += OpenWeatherMapService_ReadCompleted;
            openWeatherMapService.GetWeatherAsync();
        }
        List<string> LoadCapitalsFromXML() {
            List<string> capitals = new List<string>();
            XDocument document = DemoUtils.LoadXml("Capitals.xml");
            if (document != null) {
                foreach (XElement element in document.Element("Capitals").Elements()) {
                    capitals.Add(element.Value);
                }
            }
            return capitals;
        }
        void OpenWeatherMapService_ReadCompleted(object sender, EventArgs e) {
            ListSourceDataAdapter.DataSource = this.OpenWeatherMapService.WeatherInCities;
            ItemsLayer.SelectedItem = this.OpenWeatherMapService.LosAngelesWeather;
            this.OpenWeatherMapService.ReadCompleted -= OpenWeatherMapService_ReadCompleted;
        }
        void OnDispose(bool disposing) {
            if(this.openWeatherMapService != null) {
                openWeatherMapService.ReadCompleted -= OpenWeatherMapService_ReadCompleted;
                openWeatherMapService.Dispose();
                openWeatherMapService = null;
            }            
        }
        void mapControl1_SelectionChanged(object sender, MapSelectionChangedEventArgs e) {
            IList<object> selection = e.Selection;
            if (selection == null || selection.Count != 1)  
                return;
            CityWeather cityWeatherInfo = selection[0] as CityWeather;
            this.actualWeatherInfo = cityWeatherInfo;
            if(cityWeatherInfo != null) {
                if(cityWeatherInfo.Forecast == null) {
                    this.OpenWeatherMapService.GetForecastForCityAsync(cityWeatherInfo);
                    cityWeatherInfo.ForecastUpdated += cityWeatherInfo_ForecastUpdated;
                }
                else
                    cityWeatherInfo_ForecastUpdated(cityWeatherInfo, null);
            }
        }
        void cityWeatherInfo_ForecastUpdated(object sender, EventArgs e) {
            if(IsDisposed) return;
            CityWeather cityWeatherInfo = sender as CityWeather;
            Action<CityWeather> del = LoadWeatherPicture;
            BeginInvoke(del, cityWeatherInfo);
        }
        void LoadWeatherPicture(CityWeather cityWeatherInfo) {
            this.chartControl1.Series[0].DataSource = cityWeatherInfo.Forecast;
            lbCity.Text = cityWeatherInfo.City;
            lbTemperature.Text = cityWeatherInfo.Weather.GetTemperatureString(actualMeasureUnits);
            peWeatherIcon.LoadAsync(cityWeatherInfo.WeatherIconPath);
        }
        void mapControl1_SelectionChanging(object sender, MapSelectionChangingEventArgs e) {
            e.Cancel = e.Selection.Count == 0;
        }
        void chkFahrenheit_CheckedChanged(object sender, XtraBars.ItemClickEventArgs e) {
            if(actualWeatherInfo != null) {
                if(chkFahrenheit.Checked == true) {
                    actualMeasureUnits = TemperatureMeasureUnits.Fahrenheit;
                    this.chartControl1.Series[0].ValueDataMembers[0] = "Weather.FahrenheitTemperature";
                }
                if(chkCelsius.Checked == true) {
                    actualMeasureUnits = TemperatureMeasureUnits.Celsius;
                    this.chartControl1.Series[0].ValueDataMembers[0] = "Weather.CelsiusTemperature";
                }
                lbTemperature.Text = actualWeatherInfo.Weather.GetTemperatureString(actualMeasureUnits);
                ListSourceDataAdapter.Mappings.Text = actualWeatherInfo.GetTemperatureDataMember(actualMeasureUnits);
            }
        }
        void chkMiniMap_ItemClick(object sender, XtraBars.ItemClickEventArgs e) {
            MapControl.MiniMap.Visible = ((BarCheckItem)e.Item).Checked;
        }
        void chkShowChart_ItemClick(object sender, ItemClickEventArgs e) {
            chartPanel.Visible = ((BarCheckItem)e.Item).Checked;
        }
        protected override void InitRibbon() {
            base.InitRibbon();
            OptionsPage.Groups.Add(rpgTemperatureUnits);
            OptionsPage.Ribbon.Items.AddRange(new BarItem[] { chkFahrenheit, chkCelsius });
        }
        protected override void RestoreInitialView() {
            MapControl.CenterPoint = new GeoPoint();
            MapControl.ZoomLevel = 3;
        }
    }
}
