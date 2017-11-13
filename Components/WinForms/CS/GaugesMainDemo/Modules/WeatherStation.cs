using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.Reflection;
using DevExpress.Utils;
using DevExpress.XtraGauges.Demos.net.webservicex.www;

namespace DevExpress.XtraGauges.Demos {
    public partial class WeatherStation : TutorialControl {
        BindingList<DemoWetherData> data;

        public WeatherStation() {
            InitializeComponent();
            UpdateWeather("London(Offline data)");
        }
        void simpleButton1_Click(object sender, System.EventArgs e) {
            UpdateWeather(comboBoxEdit1.EditValue.ToString());
        }
        protected void UpdateWeather(string place) {
            WeatherForecasts wfc = GetWeatherByPlaceNameSafe(place);
            if(wfc == null) return;
            InitDataSource(wfc);
            InitCharts();
            InitGauge();
        }
        protected WeatherForecasts GetWeatherByPlaceNameSafe(string place) {
            Cursor = Cursors.WaitCursor;
            WeatherForecasts wfc = null;
            try {
                using(WaitDialogForm dlg = new WaitDialogForm("Loading weather at " + place)) {
                    if(place.Contains("Offline")) {
                        XmlSerializer serializer = new XmlSerializer(typeof(WeatherForecasts));
                        wfc = (WeatherForecasts)serializer.Deserialize(Assembly.GetExecutingAssembly().GetManifestResourceStream("DevExpress.XtraGauges.Demos.Data.weather.xml"));

                    }
                    else {
                        WeatherForecast service = new WeatherForecast();
                        wfc = service.GetWeatherByPlaceName(place);
                    }
                }
            }
            catch {
                MessageBox.Show("could not retrive weather data for " + place);
                Cursor = Cursors.Arrow;
                return null;
            }
            if(wfc.Details == null) {
                MessageBox.Show("could not retrive weather data for " + place);
                Cursor = Cursors.Arrow;
                return null;
            }
            Cursor = Cursors.Arrow;
            return wfc;
        }
        protected void InitDataSource(WeatherForecasts wfc) {
            try {
                try {
                    if(data == null) data = new BindingList<DemoWetherData>();
                    else data.Clear();
                }
                catch { }
                int counter = 0;
                bool isCelsius = comboBoxEdit2.Text.StartsWith("C");

                foreach(WeatherData wd in wfc.Details) {
                    int minF, maxF, minC, maxC, f, c;
                    int.TryParse(wd.MinTemperatureF, out minF);
                    int.TryParse(wd.MaxTemperatureF, out maxF);
                    int.TryParse(wd.MinTemperatureC, out minC);
                    int.TryParse(wd.MaxTemperatureC, out maxC);
                    f = (minF + maxF) / 2; c = (minC + maxC) / 2;
                    data.Add(new DemoWetherData(isCelsius ? minC : minF, isCelsius ? maxC : maxF, c, f, counter++));
                }
            }
            catch { }
        }
        protected void InitGauge() {
            bool isCelsius = comboBoxEdit2.Text.StartsWith("C");
            if(currentTempScale.DataBindings.Count == 0) {
                currentTempScale.DataBindings.Add("Value", data, "CurrentTemperature" + (isCelsius ? "C" : "F"));
            }
        }
        protected void InitCharts() {
            if(chartControl1.DataSource != data) {
                chartControl1.DataSource = data;
                chartControl1.Series[0].ArgumentDataMember = "Day";
                chartControl1.Series[0].ValueDataMembers[0] = "MinTemperature";

                chartControl1.Series[1].ArgumentDataMember = "Day";
                chartControl1.Series[1].ValueDataMembers[0] = "MaxTemperature";
            }
            else {
                chartControl1.Invalidate();
            }

        }
    }

    public class DemoWetherData {
        int minTemperatureCore;
        int maxTemperatureCore;
        int dayCore;
        int currentTemperatureC;
        int currentTemperatureF;

        public int MinTemperature {
            get { return minTemperatureCore; }
            set { minTemperatureCore = value; }
        }
        public int MaxTemperature {
            get { return maxTemperatureCore; }
            set { maxTemperatureCore = value; }
        }
        public int Day {
            get { return dayCore; }
            set { dayCore = value; }
        }
        public int CurrentTemperatureF {
            get { return currentTemperatureC; }
            set { currentTemperatureC = value; }
        }
        public int CurrentTemperatureC {
            get { return currentTemperatureF; }
            set { currentTemperatureF = value; }
        }

        public DemoWetherData(int minT, int maxT, int currentTemperatureC, int currentTemperatureF, int day) {
            Day = day;
            MinTemperature = minT;
            MaxTemperature = maxT;
            CurrentTemperatureC = currentTemperatureC;
            CurrentTemperatureF = currentTemperatureF;
        }
    }
}
