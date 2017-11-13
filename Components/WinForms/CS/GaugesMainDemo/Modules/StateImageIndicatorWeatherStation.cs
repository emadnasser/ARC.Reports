using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.Skins;
using DevExpress.XtraGauges.Core.Drawing;
using DevExpress.XtraGauges.Core.Model;
using DevExpress.XtraGauges.Win.Base;
using DevExpress.XtraGauges.Win.Gauges.Circular;
using System.Linq;
using System.Net;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using DevExpress.Utils;
using DevExpress.XtraSplashScreen;

namespace DevExpress.XtraGauges.Demos {
    public partial class StateImageIndicatorWeatherStation : TutorialControl {
        const string OpenWeatherUrl = "http://api.openweathermap.org/data/2.5/box/city?bbox=-180,-90,180,90&cluster=yes&APPID=";
        const string OpenWeatherIconPathPrefix = "http://openweathermap.org/img/w/";
        const string OpenWeatherKey = "06ab6900f3546d4b19d5cfd369a232ed";
        DateTime date = new DateTime(1900, 1, 1);
        string[] seasons = new string[] { "Winter", "Spring", "Summer", "Autumn" };
        Timer updateTimer = new Timer();
        public StateImageIndicatorWeatherStation() {
            InitializeComponent();
            scHumidityLA.EnableAnimation = true;
            scHumidityLA.EasingMode = Core.Model.EasingMode.EaseInOut;
            scHumidityLA.EasingFunction = new CubicEase();
            scTempLA.EnableAnimation = true;
            scTempLA.EasingMode = Core.Model.EasingMode.EaseInOut;
            scTempLA.EasingFunction = new CubicEase();
            scHumidityLn.EnableAnimation = true;
            scHumidityLn.EasingMode = Core.Model.EasingMode.EaseInOut;
            scHumidityLn.EasingFunction = new CubicEase();
            scTempLn.EnableAnimation = true;
            scTempLn.EasingMode = Core.Model.EasingMode.EaseInOut;
            scTempLn.EasingFunction = new CubicEase();
            scHumidityMs.EnableAnimation = true;
            scHumidityMs.EasingMode = Core.Model.EasingMode.EaseInOut;
            scHumidityMs.EasingFunction = new CubicEase();
            scTempMs.EnableAnimation = true;
            scTempMs.EasingMode = Core.Model.EasingMode.EaseInOut;
            scTempMs.EasingFunction = new CubicEase();
            LookAndFeel.StyleChanged += OnStyleChanged;
            updateTimer.Interval = 2000;
            updateTimer.Tick += OnTimerTick;
            UpdateColor();
            SplashScreenManager.ShowDefaultWaitForm(ParentForm, true, true, "", "Connecting...");
            LoadWeather();
            if(SplashScreenManager.Default != null && SplashScreenManager.Default.IsSplashFormVisible)
                SplashScreenManager.CloseDefaultWaitForm();
            if(CityCurrentWeatherInfos == null) {
                UpdateWeatherLA();
                UpdateWeatherLN();
                UpdateWeatherMS();
            }
            else {
                date = DateTime.Now;
                UpdateDate();
                UpdateWeatherLA(GetNextCityWeatherInfo());
                UpdateWeatherMS(GetNextCityWeatherInfo());
                UpdateWeatherLN(GetNextCityWeatherInfo());
            }
            updateTimer.Start();
        }
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            updateTimer.Stop();
            base.Dispose(disposing);
        }
        #region StateImageIndicator
        Random r = new Random();
        public Color HotColor { get { return SkinColorHelper.GetColor(LookAndFeel, "Critical"); } }
        public Color ColdColor { get { return SkinColorHelper.GetColor(LookAndFeel, "Question"); } }
        public Color RangeColor { get { return SkinColorHelper.GetColor(LookAndFeel, "DisabledText"); } }
        public Color TextColor { get { return SkinColorHelper.GetColor(LookAndFeel, "DisabledText"); } }
        void OnStyleChanged(object sender, EventArgs e) {
            updateTimer.Stop();
            UpdateColor();
            if(CityCurrentWeatherInfos == null) {
                UpdateWeatherLA();
                UpdateWeatherLN();
                UpdateWeatherMS();
            }
            else {
                UpdateWeatherLA(GetNextCityWeatherInfo());
                UpdateWeatherMS(GetNextCityWeatherInfo());
                UpdateWeatherLN(GetNextCityWeatherInfo());
            }
            updateTimer.Start();
        }
        void UpdateColor() {
            rbLnHumidity.AppearanceRangeBar.ContentBrush = new SolidBrushObject(RangeColor);
            rbLAHumidity.AppearanceRangeBar.ContentBrush = new SolidBrushObject(RangeColor);
            rbMsHumidity.AppearanceRangeBar.ContentBrush = new SolidBrushObject(RangeColor);
            gaugeControl4.ColorScheme.Color = HotColor;
            gaugeControl3.ColorScheme.Color = HotColor;
            gaugeControl5.ColorScheme.Color = HotColor;
            scTempLA.AppearanceTickmarkText.TextBrush = new SolidBrushObject(TextColor);
            scTempLn.AppearanceTickmarkText.TextBrush = new SolidBrushObject(TextColor);
            scTempMs.AppearanceTickmarkText.TextBrush = new SolidBrushObject(TextColor);
        }
        void OnTimerTick(object sender, EventArgs e) {
            if(CityCurrentWeatherInfos == null) {
                date = date.AddDays(r.Next(0, 30));
                UpdateDate();
                UpdateWeatherLA();
                UpdateWeatherLN();
                UpdateWeatherMS();
            }
            else {
                date = DateTime.Now;
                UpdateDate();
                UpdateWeatherLA(GetNextCityWeatherInfo());
                UpdateWeatherMS(GetNextCityWeatherInfo());
                UpdateWeatherLN(GetNextCityWeatherInfo());
            }

        }
        void UpdateDate() {
            string[] s = date.ToString("dd MMMM").Split(' ');
            lcDay.Text = s[0];
            lcMonth.Text = s[1].ToUpper();
            if(date.Month == 12 || (date.Month >= 1 && date.Month <= 2)) {
                lcSeason.Text = seasons[0].ToUpper();
            }
            if(date.Month >= 3 && date.Month <= 5) {
                lcSeason.Text = seasons[1].ToUpper();
            }
            if(date.Month >= 6 && date.Month <= 8) {
                lcSeason.Text = seasons[2].ToUpper();
            }
            if(date.Month >= 9 && date.Month <= 11) {
                lcSeason.Text = seasons[3].ToUpper();
            }
        }
        void UpdateWeatherLN() {
            double temp = 10 * Math.Sin(((date.DayOfYear * Math.PI) / 90) / 2 - ((91 * Math.PI) / 180)) + r.Next(-5, 2) + 13;
            int humidity = r.Next(65, 100);
            UpdateSityWeather(scTempLn, scHumidityLn, siiLn, lcLn, rbLnTemp, temp, humidity);
        }
        void UpdateWeatherLA() {
            double temp = 7.5 * Math.Sin(((date.DayOfYear * Math.PI) / 90) / 2 - ((91 * Math.PI) / 180)) + r.Next(-2, 2) + 20.5;
            int humidity = r.Next(40, 92);
            UpdateSityWeather(scTempLA, scHumidityLA, siiLA, lcLA, rbLATemp, temp, humidity);
        }
        void UpdateWeatherMS() {
            double temp = 28 * Math.Sin(((date.DayOfYear * Math.PI) / 90) / 2 - ((91 * Math.PI) / 180)) + r.Next(0, 2);
            int humidity = r.Next(60, 100);
            UpdateSityWeather(scTempMs, scHumidityMs, siiMs, lcMs, rbMsTemp, temp, humidity);
        }
        void UpdateWeatherLN(CityCurrentWeatherInfo cityInfo) {
            if(cityInfo == null || cityInfo.Main == null) return;
            double temp = cityInfo.Main.Temp;
            int humidity = (int)cityInfo.Main.Humidity;
            string weather =  cityInfo.Weather.Count > 0 ? cityInfo.Weather[0].Main : string.Empty;
            labelControl5.Text = cityInfo.Name;
            UpdateSityWeather(scTempLn, scHumidityLn, siiLn, lcLn, rbLnTemp, temp, humidity, weather);
        }
        void UpdateWeatherLA(CityCurrentWeatherInfo cityInfo) {
            if(cityInfo == null || cityInfo.Main == null) return;
            double temp = cityInfo.Main.Temp;
            int humidity = (int)cityInfo.Main.Humidity;
            string weather = cityInfo.Weather.Count > 0 ? cityInfo.Weather[0].Main : string.Empty;
            labelControl1.Text = cityInfo.Name;
            UpdateSityWeather(scTempLA, scHumidityLA, siiLA, lcLA, rbLATemp, temp, humidity, weather);
        }
        void UpdateWeatherMS(CityCurrentWeatherInfo cityInfo) {
            if(cityInfo == null || cityInfo.Main == null) return;
            double temp = cityInfo.Main.Temp;
            int humidity = (int)cityInfo.Main.Humidity;
            string weather = cityInfo.Weather.Count > 0 ? cityInfo.Weather[0].Main : string.Empty;
            labelControl6.Text = cityInfo.Name;
            UpdateSityWeather(scTempMs, scHumidityMs, siiMs, lcMs, rbMsTemp, temp, humidity, weather);
        }
        void UpdateSityWeather(ArcScaleComponent tempScale, ArcScaleComponent humidityScale, StateImageIndicatorComponent imageIndicator, LabelComponent label, ArcScaleRangeBar rangeBar, double temp, int humidity, string weather = "") {
            if(tempScale == null || humidityScale == null || imageIndicator == null || label == null || rangeBar == null) return;
            tempScale.Value = (float)temp;
            if(temp < 0) {
                rangeBar.Appearance.ContentBrush = new SolidBrushObject(ColdColor);
                imageIndicator.Color = ColdColor;
            }
            else {
                rangeBar.Appearance.ContentBrush = new SolidBrushObject(HotColor);
                imageIndicator.Color = HotColor;
            }
            humidityScale.Value = humidity;
            string color = string.Format("{0},{1},{2}", RangeColor.R, RangeColor.G, RangeColor.B);
            string color2 = temp < 0 ? string.Format("{0},{1},{2}", ColdColor.R, ColdColor.G, ColdColor.B) : string.Format("{0},{1},{2}", HotColor.R, HotColor.G, HotColor.B);
            string temperature = temp <= 0 ? ((int)temp).ToString() : "+" + ((int)temp).ToString();
            label.Text = string.Format("<color={0}>t: {1}C    <br><color={2}>h: {3}%   ", color2, temperature, color, humidity);
            if(string.IsNullOrEmpty(weather)) {
                if(humidity > 85) {
                    if(temp >= 0)
                        imageIndicator.StateIndex = 2;
                    else
                        imageIndicator.StateIndex = 3;
                }
                else if(humidity > 70) {
                    imageIndicator.StateIndex = 1;
                }
                else {
                    imageIndicator.StateIndex = 0;
                }
            }
            else {
                switch(weather) {
                    case "Rain":
                        imageIndicator.StateIndex = 2;
                        break;
                    case "Clear":
                        imageIndicator.StateIndex = 0;
                        break;
                    case "Snow":
                        imageIndicator.StateIndex = 3;
                        break;
                    default:
                        imageIndicator.StateIndex = 1;
                        break;
                }
            }
        }
        #endregion
        int counterCore = 0;
        CityCurrentWeatherInfo GetNextCityWeatherInfo() {
            if(CityCurrentWeatherInfos != null && CityCurrentWeatherInfos.Count != 0)
                return CityCurrentWeatherInfos[GetNextIndex()];
            return null;
        }
        int GetNextIndex() {
            if(counterCore >= CityCurrentWeatherInfos.Count)
                counterCore = 0;
            return counterCore++;
        }
        List<CityCurrentWeatherInfo> CityCurrentWeatherInfos {
            get { return cityCurrentWeatherInfosCore; }
        }
        List<CityCurrentWeatherInfo> cityCurrentWeatherInfosCore;
        public void LoadWeather() {
            WebClient weatherClient = new WebClient();
            weatherClient.OpenReadCompleted += OnOpenReadCompleted;
            try {
                weatherClient.OpenReadAsync(new Uri(OpenWeatherUrl + OpenWeatherKey));
            }
            catch { }
        }
        void OnOpenReadCompleted(object sender, OpenReadCompletedEventArgs e) {
            WebClient weatherClient = sender as WebClient;
            weatherClient.OpenReadCompleted -= OnOpenReadCompleted;
            if(e.Cancelled || e.Error != null)
                return;
            Stream stream = e.Result;
            DataContractJsonSerializer dc = new DataContractJsonSerializer(typeof(WorldWeatherInfo));
            try {
                var worldWeatherInfo = (WorldWeatherInfo)dc.ReadObject(stream);
                cityCurrentWeatherInfosCore = worldWeatherInfo.List.Where(p => p.Name.Length <= 20).ToList();
            }
            catch { }
        }
        [DataContract]
        public class WorldWeatherInfo {
            public WorldWeatherInfo() {
                List = new List<CityCurrentWeatherInfo>();
            }
            [DataMember(Name = "list")]
            public List<CityCurrentWeatherInfo> List { get; set; }
        }
        [DataContract]
        public class CityCurrentWeatherInfo {
            public CityCurrentWeatherInfo() {
                Weather = new List<WeatherDescriptionInfo>();
            }
            [DataMember(Name = "name")]
            public string Name { get; set; }
            [DataMember(Name = "main")]
            public WeatherInfo Main { get; set; }
            [DataMember(Name = "weather")]
            public List<WeatherDescriptionInfo> Weather { get; set; }
        }
        [DataContract]
        public class WeatherDescriptionInfo {
            [DataMember(Name = "main")]
            internal string Main { get; set; }
        }
        [DataContract]
        public class WeatherInfo {
            [DataMember(Name = "temp")]
            internal double Temp { get; set; }
            [DataMember(Name = "humidity")]
            internal double Humidity { get; set; }
        }
    }
    internal static class SkinColorHelper {
        public static Color GetColor(ISkinProvider provider, string name) {
            return CommonSkins.GetSkin(provider).Colors.GetColor(name);
        }
    }
}
