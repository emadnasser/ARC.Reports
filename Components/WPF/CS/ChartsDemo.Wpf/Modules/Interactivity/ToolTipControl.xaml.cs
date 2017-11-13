using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows;
using System.Windows.Media;
using System.Xml;
using DevExpress.Xpf.Charts;
using DevExpress.Xpf.DemoBase;

namespace ChartsDemo {
    [CodeFile("Modules/Interactivity/ToolTipControl(.SL).xaml"),
     CodeFile("Modules/Interactivity/ToolTipControl.xaml.(cs)")]
    public partial class ToolTipControl : ChartsDemoModule{
        ToolTipMousePosition ttMousePosition = new ToolTipMousePosition();
        ToolTipRelativePosition ttRelativePosition = new ToolTipRelativePosition();
        ToolTipFreePosition ttFreePosition = new ToolTipFreePosition() { Offset=new Point(16, 16) };

        public override ChartControlBase ActualChart { get { return chart; } }

        public ToolTipControl() {
            InitializeComponent();
            ttFreePosition.DockTarget = defaultPane;
            ToolTipControlHelper.PrepareToolTipPositionComboBox(cbToolTipPosition);
            ToolTipControlHelper.PrepareToolTipLocationComboBox(cbToolTipLocation);
            chart.DataSource = GetDataSource();
        }

        void cbToolTipPosition_SelectedIndexChanged(object sender, RoutedEventArgs e) {
            ChangeOptionsView();
            switch(cbToolTipPosition.SelectedIndex){
                case 0:
                    ttMousePosition.Location = ToolTipControlHelper.GetLocationFromComboBox(cbToolTipLocation.SelectedIndex);
                    chart.ToolTipOptions.ToolTipPosition = ttMousePosition;
                    break;
                case 1:
                    ttRelativePosition.Location = ToolTipControlHelper.GetLocationFromComboBox(cbToolTipLocation.SelectedIndex);
                    chart.ToolTipOptions.ToolTipPosition = ttRelativePosition;
                    break;
                case 2:
                    chart.ToolTipOptions.ToolTipPosition = ttFreePosition;
                    break;
            }
        }
        void cbToolTipLocation_SelectedIndexChanged(object sender, RoutedEventArgs e) {
            ttMousePosition.Location = ToolTipControlHelper.GetLocationFromComboBox(cbToolTipLocation.SelectedIndex);
            ttRelativePosition.Location = ToolTipControlHelper.GetLocationFromComboBox(cbToolTipLocation.SelectedIndex);
        }
        void ToolTipController_ToolTipOpening(object sender, ChartToolTipEventArgs e) {
            G7Member g7Member = e.SeriesPoint.Tag as G7Member;
            e.Hint = g7Member;
            int colorNumber = e.Series.Points.IndexOf(e.SeriesPoint);
            Color seriesColor = e.ChartControl.Palette[colorNumber];
            g7Member.SeriesBrush = new SolidColorBrush(seriesColor);
        }
        void ChangeOptionsView() {
            if (cbToolTipPosition.SelectedIndex == 2) {
                cbToolTipLocation.IsEnabled = false;
                chbShowBeak.IsEnabled = false;
            }
            else {
                cbToolTipLocation.IsEnabled = true;
                chbShowBeak.IsEnabled = true;
            }
        }
        List<G7Member> GetDataSource() {
            List<G7Member> countries = new List<G7Member>();
            Stream xmlStream = Application.GetResourceStream(new Uri(@"pack://application:,,,/ChartsDemo;component/Data/GDPofG7.xml")).Stream;
            XmlDocument document = new XmlDocument();
            document.Load(xmlStream);
            if (document != null) {
                XmlNodeList elements = document.DocumentElement.GetElementsByTagName("GDP");
                foreach (XmlNode element in elements) {
                    string country = element.ChildNodes[0].InnerText;
                    int year = int.Parse(element.ChildNodes[1].InnerText);
                    decimal product = Convert.ToDecimal(element.ChildNodes[2].InnerText, CultureInfo.InvariantCulture);
                    G7Member currentG7Member = countries.Find((c) => { return c.CountryName == country; });
                    if (currentG7Member == null) {
                        currentG7Member = new G7Member(country, countries.Count);
                        countries.Add(currentG7Member);
                    }
                    currentG7Member.GDPs.Add(new GDP(year, product));
                }
            }
            xmlStream.Close();
            return countries;
        }
    }


    public class G7Member {
        public decimal GDPin2015 { get { return GDPs.First((gdp) => gdp.Year == 2015).Product; } }
        public string CountryName { get; private set; }
        public List<GDP> GDPs { get; private set; }
        public SolidColorBrush SeriesBrush { get; set; }
        public int ColorNumberInPalette { get; private set; }

        public G7Member(string country, int colorNumberInPalette) {
            this.CountryName = country;
            this.GDPs = new List<GDP>();
            this.ColorNumberInPalette = colorNumberInPalette;
        }
    }


    public class GDP {
        public int Year { get; private set; }
        public decimal Product { get; private set; }

        public GDP(int year, decimal product) {
            this.Year = year;
            this.Product = product;
        }
    }

}
