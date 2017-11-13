using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Web;
using System.Xml;
using DevExpress.XtraCharts;
using DevExpress.XtraCharts.Web;

public partial class ColorizerControl : ChartBasePage {
    List<HPIStatistics> GetHPIs() {
        XmlDocument document = new XmlDocument();
        using (Stream xmlStream = File.OpenRead(HttpContext.Current.Server.MapPath("~/App_Data/HPI.xml")))
            document.Load(xmlStream);
        List<HPIStatistics> result = new List<HPIStatistics>();
        if (document != null) {
            XmlNodeList elements = document.DocumentElement.GetElementsByTagName("CountryStatistics");
            foreach (XmlNode element in elements) {
                string country = element.ChildNodes[0].InnerText;
                double population = int.Parse(element.ChildNodes[1].InnerText) / 1000000.0;
                double hpi = Convert.ToDouble(element.ChildNodes[2].InnerText, CultureInfo.InvariantCulture);
                decimal product = Convert.ToDecimal(element.ChildNodes[3].InnerText, CultureInfo.InvariantCulture);
                result.Add(new HPIStatistics(country, population, hpi, product));
            }
        }
        return result;
    }
    
    protected void Page_Load(object sender, EventArgs e) {
        var paletteEntries = new PaletteEntry[] {
                new PaletteEntry(Color.FromArgb(255, 90, 25), Color.FromArgb(255, 90, 25)),
                new PaletteEntry(Color.FromArgb(254, 173, 45), Color.FromArgb(254, 173, 45)),
                new PaletteEntry(Color.FromArgb(229, 227, 53), Color.FromArgb(229, 227, 53)),
                new PaletteEntry(Color.FromArgb(172, 228, 92), Color.FromArgb(172, 228, 92)),
                new PaletteEntry(Color.FromArgb(110, 201, 92), Color.FromArgb(110, 201, 92))};
        var palette = new Palette("ColorizerPalette", PaletteScaleMode.Repeat, paletteEntries);
        chart.PaletteRepository.Add("ColorizerPalette", palette);
        Series series = chart.Series[0];
        RangeColorizer rangeColorizer = new RangeColorizer();
        rangeColorizer.RangeStops.Add(22);
        rangeColorizer.RangeStops.Add(30);
        rangeColorizer.RangeStops.Add(38);
        rangeColorizer.RangeStops.Add(46);
        rangeColorizer.RangeStops.Add(54);
        rangeColorizer.RangeStops.Add(64);
        rangeColorizer.LegendItemPattern = "{V1} - {V2} HPI";
        rangeColorizer.PaletteName = "ColorizerPalette";
        series.Colorizer = rangeColorizer;
        series.ArgumentScaleType = ScaleType.Qualitative;
        series.ArgumentDataMember = "Country";
        series.ValueDataMembers.AddRange(new string[] { "Product", "Population" });
        series.ColorDataMember = "HPI";
        series.ToolTipHintDataMember = "HPIHint";
        series.DataSource = GetHPIs();
        chart.DataBind();
    }

    public override WebChartControl FindWebChartControl() {
        return chart;
    }
    public override bool ShowPaletteComboBox() {
        return false;
    }

}

public class HPIStatistics { //HPI - Happy Planet Index
    public string Country { get; private set; }
    public double Population { get; private set; }
    public double HPI { get; private set; }
    public string HPIHint { get; private set; }
    public decimal Product { get; private set; }

    public HPIStatistics(string country, double population, double hpi, decimal product) {
        this.Country = country;
        this.Population = population;
        this.HPI = hpi;
        this.Product = product;
        this.HPIHint = string.Format("{0:n2}", hpi);
    }
}
