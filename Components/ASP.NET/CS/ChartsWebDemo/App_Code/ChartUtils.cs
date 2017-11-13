using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Data;
using DevExpress.Web;
using DevExpress.XtraCharts;
using System.IO;
using System.Web;
using System.Xml;

public static class XMLUtils {
    public static DataTable LoadDataTableFromXml(string fileName, string tableName) {
        DataSet xmlDataSet = new DataSet();
        using (Stream xmlStream = File.OpenRead(HttpContext.Current.Server.MapPath("~/App_Data/" + fileName))) {
            xmlDataSet.ReadXml(xmlStream);
            xmlStream.Close();
        }
        return xmlDataSet.Tables[tableName];
    }
}

public static class CsvReader {
    public static List<FinancialPoint> ReadFinancialData(string fileName) {
        string longFileName = string.Empty;
        StreamReader reader;
        var dataSource = new List<FinancialPoint>();
        using (Stream stream = File.OpenRead(HttpContext.Current.Server.MapPath("~/App_Data/" + fileName))) {
            try {
                reader = new StreamReader(stream);
                while (!reader.EndOfStream) {
                    string line = reader.ReadLine();
                    var values = line.Split(',');
                    var point = new FinancialPoint();
                    point.DateTimeArgument = DateTime.ParseExact(values[0], "yyyy.MM.dd", null);
                    point.OpenValue = double.Parse(values[1], CultureInfo.InvariantCulture);
                    point.HighValue = double.Parse(values[2], CultureInfo.InvariantCulture);
                    point.LowValue = double.Parse(values[3], CultureInfo.InvariantCulture);
                    point.CloseValue = double.Parse(values[4], CultureInfo.InvariantCulture);
                    dataSource.Add(point);
                }
            }
            catch {
                throw new Exception("It's impossible to load " + fileName);
            }
        }
        return dataSource;
    }
}

public static class ComboBoxHelper {
    const string defaultMarker = "Default";
    const string percentMarker = "%";
    const int defaultDoughnutHole = 60;
    static readonly MarkerKindItemCollection markerKinds = MarkerKindItemCollection.CreateCollection();

    static string[] AppendPercentMarker(string[] items) {
        return AppendPercentMarker(items, 0);
    }
    static string[] AppendPercentMarker(string[] items, int startIndex) {
        string[] result = new string[items.Length];
        for(int i = 0; i < startIndex; i++)
            result[i] = items[i];
        for(int i = startIndex; i < items.Length; i++)
            result[i] = items[i] + percentMarker;
        return result;
    }
    static string DeletePercentMarker(string item) {
        return item.TrimEnd(new char[] { percentMarker[0] });
    }
    public static void PrepareComboBox(ASPxComboBox comboBox, string[] items) {
        PrepareComboBox(comboBox, items, null);
    }
    public static void PrepareComboBox(ASPxComboBox comboBox, string[] items, object defaultItem) {
        comboBox.Items.AddRange(items);
        comboBox.SelectedIndex = defaultItem != null ? comboBox.Items.IndexOfText(defaultItem.ToString()) : 0;
    }
    public static void PrepareComboBox(ASPxComboBox comboBox, double[] items, double defaultItem) {
        comboBox.Items.AddRange(items);
        comboBox.SelectedIndex = comboBox.Items.IndexOfText(defaultItem.ToString());
    }
    public static void PrepareComboBox(ASPxComboBox comboBox, Enum defaultValue) {
        PrepareComboBox(comboBox, Enum.GetNames(defaultValue.GetType()), defaultValue);
    }
    public static void PrepareComboBox(ASPxComboBox comboBox, IDictionary dictionary) {
        PrepareComboBox(comboBox, dictionary, 0);
    }
    public static void PrepareComboBox(ASPxComboBox comboBox, IDictionary dictionary, int selectedIndex) {
        foreach(DictionaryEntry entry in dictionary)
            comboBox.Items.Add((string)entry.Key, entry.Value);
        comboBox.SelectedIndex = selectedIndex;
    }
    public static void PrepareLabelAngleComboBox(ASPxComboBox comboBox, int defaultAngle) {
        string[] items = new string[] { "0", "45", "90", "135", "180", "225", "270", "315" };
        PrepareComboBox(comboBox, items, defaultAngle);
    }
    public static void PrepareTransparencyComboBox(ASPxComboBox comboBox, int defaultTransparency) {
        string[] items = new string[] { "0", "45", "90", "135", "180", "225", "255" };
        PrepareComboBox(comboBox, items, defaultTransparency);
    }
    public static void PrepareZoomPercentComboBox(ASPxComboBox comboBox, int defaultZoomPercent) {
        string[] items = new string[] { "50", "75", "100", "120", "140", "170", "200", "250", "300" };
        PrepareComboBox(comboBox, items, defaultZoomPercent);
    }
    public static void PreparePerspectiveAngleComboBox(ASPxComboBox comboBox) {
        string[] items = new string[] { defaultMarker, "0", "30", "45", "60", "90", "120", "135", "150" };
        PrepareComboBox(comboBox, items);
    }
    public static void PrepareBar3DModelComboBox(ASPxComboBox comboBox) {
        string[] items = new string[] { "Box", "Cylinder", "Cone", "Pyramid" };
        PrepareComboBox(comboBox, items);
    }
    public static void PrepareNestedDoughnutHolePercentComboBox(ASPxComboBox comboBox) {
        const int minRadius = 30;
        const int step = 5;
        const int itemsCount = 8;
        const int defaultHole = 40;
        List<double> items = new List<double>();
        for (int itemIndex = 0; itemIndex < itemsCount; itemIndex++) {
            int radius = minRadius + step * itemIndex;
            items.Add(radius);
        }
        PrepareComboBox(comboBox, items.ToArray(), defaultHole);
    }
    public static void PrepareNestedDoughnutSeriesArgumentComboBox(ASPxComboBox comboBox) {
        string[] items = new string[] { "Age", "Gender" };
        PrepareComboBox(comboBox, items);
    }
    public static void PrepareInnerIndentComboBox(ASPxComboBox comboBox) {
        const int itemsCount = 11;
        const int defaultInnerIndent = 5;
        List<double> items = new List<double>();
        for (int itemIndex = 0; itemIndex < itemsCount; itemIndex++) {
            items.Add(itemIndex);
        }
        PrepareComboBox(comboBox, items.ToArray(), defaultInnerIndent);
    }
    public static void PrepareRegressionLineColorComboBox(ASPxComboBox comboBox) {
        comboBox.Items.Add("Default");
        Color[] colors = new Color[] { Color.Black, Color.Red, Color.Green, Color.Blue, Color.Yellow };
        foreach(Color color in colors)
            comboBox.Items.Add(color.Name);
        comboBox.SelectedIndex = 0;
    }
    public static void PrepareDashStyleCombobox(ASPxComboBox comboBox, DashStyle defaultDashStyle) {
        foreach(DashStyle dashStyle in Enum.GetValues(defaultDashStyle.GetType()))
            if(dashStyle != DashStyle.Empty)
                comboBox.Items.Add(dashStyle.ToString());
        comboBox.SelectedIndex = comboBox.Items.IndexOfText(defaultDashStyle.ToString());
    }
    public static void PrepareLogarithmicBaseComboBox(ASPxComboBox comboBox, double defaultLogarithmicBase) {
        string[] items = new string[] { "2", "5", "10", "20", "50", "100" };
        PrepareComboBox(comboBox, items, defaultLogarithmicBase);
    }
    public static void PrepareFunctionTypeComboBox(ASPxComboBox comboBox) {
        const string lemniscate = "Lemniscate";
        string[] items = new string[] { "Circles", "Cardioid", lemniscate };
        PrepareComboBox(comboBox, items, lemniscate);
    }
    public static void PrepareFunctionTypeScatterLineComboBox(ASPxComboBox comboBox) {
        const string archimedeanSpiral = "Archimedean Spiral";
        string[] items = new string[] { archimedeanSpiral, "Cardioid", "Cartesian Folium", };
        PrepareComboBox(comboBox, items, archimedeanSpiral);
    }
    public static void PrepareChartTypeComboBox(ASPxComboBox comboBox) {
        const string line = "Line";
        string[] items = new string[] { line, "Bar" };
        PrepareComboBox(comboBox, items, line);
    }
    public static void PrepareSeriesAxisXComboBox(ASPxComboBox comboBox) {
        const string primaryAxis = "Primary Axis X";
        string[] items = new string[] { primaryAxis, "Secondary Axis X" };
        PrepareComboBox(comboBox, items, primaryAxis);
    }
    public static void PrepareSeriesAxisYComboBox(ASPxComboBox comboBox) {
        const string secondaryAxisY = "Secondary Axis Y";
        string[] items = new string[] { "Primary Axis Y", secondaryAxisY };
        PrepareComboBox(comboBox, items, secondaryAxisY);
    }
    public static void PrepareViewTypeComboBox(ASPxComboBox comboBox) {
        string[] items = new string[] { 
            "Lines", 
            "Stacked Lines",
            "Full-Stacked Lines",
            "Step Lines", 
            "Areas", 
            "Step Areas",
            "Stacked Areas",
            "Full-Stacked Areas",
            "3D Lines",
            "3D Stacked Lines",
            "3D Full-Stacked Lines",
            "3D Step Lines",
            "3D Areas",
            "3D Stacked Areas",
            "3D Full-Stacked Areas",
            "3D Step Areas",
            "Spline",
            "Spline Area",
            "Stacked Spline",
            "Full-Stacked Spline",
            "Spline 3D",
            "Spline Area 3D",
            "Stacked Spline 3D",
            "Full-Stacked Spline 3D" };
        PrepareComboBox(comboBox, items);
    }
    public static void PreparePieViewTypeComboBox(ASPxComboBox comboBox) {
        string[] items = new string[] { "Pie", "Pie 3D", "Doughnut", "Doughnut 3D" };
        PrepareComboBox(comboBox, items);
    }
    public static void PrepareMarkerKindComboBox(ASPxComboBox comboBox, MarkerKind defaultKind, int defaultStarPointCount) {
        PrepareComboBox(comboBox, markerKinds.GetNames(), markerKinds.FindName(defaultKind, defaultStarPointCount));
    }
    public static void PrepareMarkerSizeComboBox(ASPxComboBox comboBox, int defaultSize) {
        PrepareComboBox(comboBox, MarkerKindItemCollection.GetSizeArray(), defaultSize);
    }
    public static void PrepareLegendPercentComboBox(ASPxComboBox comboBox, double defaultPercent) {
        string[] items = AppendPercentMarker(new string[] { "25", "50", "75", "100" });
        PrepareComboBox(comboBox, items, defaultPercent.ToString() + percentMarker);
    }
    public static void PrepareLineTensionComboBox(ASPxComboBox comboBox, int defaultLineTension) {
        string[] items = AppendPercentMarker(new string[] { "0", "10", "20", "30", "40", "50", "60", "70", "80", "90", "100" });
        PrepareComboBox(comboBox, items, defaultLineTension.ToString() + percentMarker);
    }
    public static void PreparePieLabelsComboBox(ASPxComboBox comboBox) {
        string[] items = new string[] { "Inside", "Outside", "TwoColumns", "Radial" };
        PrepareComboBox(comboBox, items);
    }
    public static void PrepareDoughnutHolePercentComboBox(ASPxComboBox comboBox) {
        string defaultHoleString = defaultMarker + " (" + defaultDoughnutHole.ToString() + "%)";
        string[] items = AppendPercentMarker(new string[] { defaultHoleString, "0", "15", "30", "50", "75", "90", "100" }, 1);
        PrepareComboBox(comboBox, items);
    }
    public static void PrepareExplodedPointsComboBox(ASPxComboBox comboBox, SeriesPointCollection points, bool supportCustom) {
        string[] items = PieExplodingHelper.GetNames(points, supportCustom);
        PrepareComboBox(comboBox, items);
    }
    public static void PrepareSummaryFunctionsComboBox(ASPxComboBox comboBox) {
        string[] items = new string[] { "SUM", "MIN", "MAX", "AVERAGE", "COUNT", "STDDEV (Custom)" };
        PrepareComboBox(comboBox, items);
    }
    public static void PrepareFunctionTypeScatterRadarLineComboBox(ASPxComboBox comboBox) {
        const string archimedeanSpiral = "Archimedean Spiral";
        string[] items = new string[] { archimedeanSpiral, "Polar Rose", "Polar Folium", };
        PrepareComboBox(comboBox, items, archimedeanSpiral);
    }
    public static void PrepareResolveOverlappingModeComboBox(ASPxComboBox comboBox, ResolveOverlappingMode defaultMode) {
        PrepareComboBox(comboBox, defaultMode);
    }
    public static Enum GetSelectedItem(ASPxComboBox comboBox, Type enumType) {
        if(!enumType.IsEnum)
            throw new ArgumentException();
        try {
            return (Enum)Enum.Parse(enumType, comboBox.SelectedItem.Text);
        }
        catch {
        }
        return (Enum)Enum.Parse(enumType, (string)comboBox.SelectedItem.Value);
    }
    public static ResolveOverlappingMode GetSelectedResolveOverlappingMode(ASPxComboBox comboBox) {
        return (ResolveOverlappingMode)GetSelectedItem(comboBox, typeof(ResolveOverlappingMode));
    }
    public static int GetSelectedPerspectiveAngle(ASPxComboBox comboBox) {
        return comboBox.SelectedItem.Text == defaultMarker ? 50 : Int32.Parse(comboBox.SelectedItem.Text);
    }
    public static MarkerKindItem GetSelectedMarkerKindItem(ASPxComboBox comboBox) {
        return markerKinds.Find(comboBox.SelectedItem.Text);
    }
    public static double GetSelectedLegendPercent(ASPxComboBox comboBox) {
        return double.Parse(DeletePercentMarker(comboBox.SelectedItem.Text));
    }
    public static int GetSelectedLineTension(ASPxComboBox comboBox) {
        return Convert.ToInt32(DeletePercentMarker(comboBox.SelectedItem.Text));
    }
    public static int GetSelectedDoughnutHolePercent(ASPxComboBox comboBox) {
        string selectedText = comboBox.SelectedItem.Text;
        return 
            selectedText.StartsWith(defaultMarker) ? 
            defaultDoughnutHole : 
            Convert.ToInt32(DeletePercentMarker(selectedText));
    }
    public static int GetSelectedNestedDoughnutHolePercent(ASPxComboBox comboBox) {
        return Convert.ToInt32(comboBox.SelectedItem.Text);
    }
    public static int GetSelectedInnerIndent(ASPxComboBox comboBox) {
        return Convert.ToInt32(comboBox.SelectedItem.Text);
    }
    public static void ApplySelectedExplodingMode(ASPxComboBox comboBox, PieSeriesViewBase view) {
        PieExplodingHelper.ApplyMode(view, comboBox.SelectedItem.Text);
    }
    public static Color GetSelectedRegressionLineColor(ASPxComboBox comboBox) {
        return comboBox.SelectedItem.Text == "Default" ? Color.Empty : Color.FromName(comboBox.SelectedItem.Text);
    }
}

public static class DataHelper {
    static DateTime StringToDateTime(string str) {
        return DateTime.Parse(str, CultureInfo.InvariantCulture);
    }
    public static void AddPoint(Series series, string argument, double value) {
        DateTime argumentDT = StringToDateTime(argument);
        series.Points.Add(new SeriesPoint(argumentDT, new double[] { value }));
    }
    public static void AddPoint(Series series, string argument, double value1, double value2) {
        DateTime argumentDT = StringToDateTime(argument);
        series.Points.Add(new SeriesPoint(argumentDT, new double[] { value1, value2 }));
    }
}

public static class PieExplodingHelper {
    public const string None = "None";
    public const string All = "All";
    public const string MinValue = "Min Value";
    public const string MaxValue = "Max Value";
    public const string Custom = "Custom";
    public static void ApplyMode(PieSeriesViewBase view, string mode) {
        switch (mode) {
            case Custom:
                view.ExplodeMode = PieExplodeMode.UsePoints;
                break;
            case None:
                view.ExplodeMode = PieExplodeMode.None;
                break;
            case All:
                view.ExplodeMode = PieExplodeMode.All;
                break;
            case MinValue:
                view.ExplodeMode = PieExplodeMode.MinValue;
                break;
            case MaxValue:
                view.ExplodeMode = PieExplodeMode.MaxValue;
                break;
            default:
                view.ExplodedPointsFilters.Clear();
                view.ExplodedPointsFilters.Add(new SeriesPointFilter(SeriesPointKey.Argument, DataFilterCondition.Equal, mode));
                view.ExplodeMode = PieExplodeMode.UseFilters;
                break;
        }
    }
    public static string[] GetNames(SeriesPointCollection points, bool supportCustom) {
        int itemsCount = points.Count + 4;
        if(supportCustom)
            itemsCount++;
        string[] items = new string[itemsCount];
        items[0] = None;
        items[1] = All;
        items[2] = MinValue;
        items[3] = MaxValue;
        for(int i = 0; i < points.Count; i++)
            items[i + 4] = points[i].Argument;
        if(supportCustom)
            items[points.Count + 4] = Custom;
        return items;
    }
}

public static class PolarFunctionCalculator {
	static double GetLineFactor(int index) {
		switch (index) {
			case 0:
				return 1;
			case 1:
				return 0.5;
			case 2:
				return 2;
			default:
				return 2;
		}
	}
	static double ToRadian(double angle) {
		return angle * Math.PI / 180.0;
	}
	static double Function(double m, double angle) {
		double cos = Math.Cos(m * ToRadian(90.0 + angle));
		return Math.Pow(Math.Abs(cos), m);
	}
	public static SeriesPoint[] GenerateFunctionPoints(int index, int pointCount, int seriesViewValusCount = 1) {
		double m = GetLineFactor(index);
		int step = 360 / pointCount;
		SeriesPoint[] points = new SeriesPoint[pointCount];
		for (int i = 0; i < pointCount; i++)
			points[i] = GenerateSeriesPoint(m, i * step, seriesViewValusCount);//new SeriesPoint(step * i, new double[] { Function(m, step * i) });
        return points;
	}
    static SeriesPoint GenerateSeriesPoint(double m, double value, int seriesViewValusCount) {
        double[] values = new double[seriesViewValusCount];
        for (int i = 0; i < seriesViewValusCount; i++) {
            double factor = (i == 0) ? m : 0;
            values[i] = Function(factor, value);
        }
        return new SeriesPoint(value, values);
    }
    static SeriesPoint[] GenerateScatterFunctionPoints(ScatterFunctionCalculatorBase calculator, int functionIndex) {
        return calculator.GenerateScatterFunctionPoints(functionIndex);
    }
    public static SeriesPoint[] GenerateDegreeScatterFunctionPoints(int functionIndex) {
        return GenerateScatterFunctionPoints(new DegreesScatterFunctionCalculator(), functionIndex);
        
    }
    public static SeriesPoint[] GenerateRadianScatterFunctionPoints(int functionIndex) {
        return GenerateScatterFunctionPoints(new RadianScatterFunctionCalculator(), functionIndex);
    }
}

public abstract class ScatterFunctionCalculatorBase {
    const int archimedeanSpiralIndex = 0;
    const int polarRoseIndex = 1;
    const int polarFoliumIndex = 2;
    const int spiralIntervalsCount = 72;
    const int roseIntervalsCount = 288;
    const int foliumSegmentIntervalsCount = 30;

    const double roseParameter = 7.0 / 4.0;
    const double foliumDistanceLimit = 3.0;

    protected abstract double NormalizeAngle(double angle);
    protected abstract double ToRadian(double angle);
    protected abstract double FromDegrees(double angle);

    List<SeriesPoint> FilterPointsByRange(List<SeriesPoint> points, double min, double max) {
        List<SeriesPoint> resultPoints = new List<SeriesPoint>();
        foreach (SeriesPoint point in points) {
            double pointValue = point.Values[0];
            if (pointValue <= max && pointValue >= min)
                resultPoints.Add(point);
        }
        return resultPoints;
    }
    void CreatePolarFunctionPoints(double minAngleDegree, double maxAngleDegree, int intervalsCount, Func<double, double> function, List<SeriesPoint> points) {
        double minAngle = FromDegrees(minAngleDegree);
        double maxAngle = FromDegrees(maxAngleDegree);
        double angleStep = (maxAngle - minAngle) / (double)intervalsCount;
        for (int pointIndex = 0; pointIndex <= intervalsCount; pointIndex++) {
            double angle = minAngle + pointIndex * angleStep;
            double angleRadians = ToRadian(angle);
            double distance = function(angleRadians);
            double normalAngle = NormalizeAngle(angle);
            points.Add(new SeriesPoint(normalAngle, distance));
        }
    }
    double ArchimedeanSpiralFunction(double angleRadians) {
        return angleRadians;
    }
    double PolarRoseFunction(double angleRadians) {
        return Math.Max(0.0, Math.Sin(roseParameter * angleRadians));
    }
    double PolarFoliumFunction(double angleRadians) {
        double sin = Math.Sin(angleRadians);
        double cos = Math.Cos(angleRadians);
        return (3.0 * sin * cos)/ (Math.Pow(sin, 3.0) + Math.Pow(cos, 3.0));
    }

    public SeriesPoint[] GenerateScatterFunctionPoints(int index) {
        List<SeriesPoint> points = new List<SeriesPoint>();
        switch (index) {
            case archimedeanSpiralIndex:
                CreatePolarFunctionPoints(0.0, 720.0, spiralIntervalsCount, ArchimedeanSpiralFunction, points);
                break;
            case polarRoseIndex:
                CreatePolarFunctionPoints(0.0, 1440.0, roseIntervalsCount, PolarRoseFunction, points);
                break;
            case polarFoliumIndex:
                CreatePolarFunctionPoints(120.0, 180.0, foliumSegmentIntervalsCount, PolarFoliumFunction, points);
                CreatePolarFunctionPoints(0.0, 90.0, foliumSegmentIntervalsCount, PolarFoliumFunction, points);
                CreatePolarFunctionPoints(270.0, 330.0, foliumSegmentIntervalsCount, PolarFoliumFunction, points);
                points = FilterPointsByRange(points, 0.0, foliumDistanceLimit);
                break;
        }
        return points.ToArray();
    }
}

public class RadianScatterFunctionCalculator : ScatterFunctionCalculatorBase {
    protected override double NormalizeAngle(double angle) {
        return angle % (Math.PI * 2.0);
    }
    protected override double ToRadian(double angle) {
        return angle;
    }
    protected override double FromDegrees(double angle) {
        return angle * Math.PI / 180.0;
    }
}

public class DegreesScatterFunctionCalculator : ScatterFunctionCalculatorBase {
    protected override double NormalizeAngle(double angle) {
        return angle % 360;
    }
    protected override double ToRadian(double angle) {
        return angle * Math.PI / 180.0;
    }
    protected override double FromDegrees(double angle) {
        return angle;
    }
}


public class BubbleDataItem {
    DateTime year;
    double budget;
    double grosses;
    string title;

    public DateTime Year { get { return year; } }
    public double Budget { get { return budget; } }
    public double Grosses { get { return grosses; } }
    public string Title { get { return title; } }

    public BubbleDataItem(DateTime year, double budget, double grosses, string title) {
        this.year = year;
        this.budget = budget;
        this.grosses = grosses;
        this.title = title;
    }
}

public static class BubbleData {
    public static List<BubbleDataItem> GetData() {
        return new List<BubbleDataItem>() {
                new BubbleDataItem(new DateTime(2007, 1, 1), 300, 0.963, "Pirates of the Caribbean: At World's End"),
                new BubbleDataItem(new DateTime(2008, 1, 1), 185, 1.004, "The Dark Knight"),
                new BubbleDataItem(new DateTime(2009, 1, 1), 237, 2.788, "Avatar"),
                new BubbleDataItem(new DateTime(2010, 1, 1), 200, 1.067, "Toy Story 3"),
                new BubbleDataItem(new DateTime(2011, 1, 1), 250, 1.341, "Harry Potter and the Deathly Hallows Part 2"),
                new BubbleDataItem(new DateTime(2012, 1, 1), 220, 1.519, "Marvel's The Avengers"),
                new BubbleDataItem(new DateTime(2013, 1, 1), 150, 1.276, "Frozen"),
                new BubbleDataItem(new DateTime(2014, 1, 1), 210, 1.104, "Transformers: Age of Extinction"),
                new BubbleDataItem(new DateTime(2015, 1, 1), 245, 2.068, "Star Wars: The Force Awakens"),
                new BubbleDataItem(new DateTime(2016, 1, 1), 250, 1.153, "Captain America: Civil War"),
            };
    }
}

public class GDPofG7 {
    public static IList GetData() {
        DataTable data = XMLUtils.LoadDataTableFromXml("GDPofG7.xml", "GDP");
        return data.AsEnumerable()
            .Where(row => row.Field<int>("Year") >= 2010)
            .Select(row => new
            {
                Country = row.Field<string>("Country"),
                Year = row.Field<int>("Year"),
                Product = row.Field<double>("Product")
            }).ToList();
    }
}

public class DevAV {
    public static DataTable GetSales() {
        int prevYear = DateTime.Now.Year - 1;
        DataTable table = new DataTable();
        table.Columns.AddRange(new DataColumn[] { new DataColumn("Year", typeof(int)), new DataColumn("Region", typeof(string)), new DataColumn("Sales", typeof(decimal)) });

        table.Rows.Add(prevYear - 2, "Asia", 4.2372D);
        table.Rows.Add(prevYear - 2, "Australia", 1.7871D);
        table.Rows.Add(prevYear - 2, "Europe", 3.0884D);
        table.Rows.Add(prevYear - 2, "North America", 3.4855D);
        table.Rows.Add(prevYear - 2, "South America", 1.6027D);

        table.Rows.Add(prevYear - 1, "Asia", 4.7685D);
        table.Rows.Add(prevYear - 1, "Australia", 1.9576D);
        table.Rows.Add(prevYear - 1, "Europe", 3.3579D);
        table.Rows.Add(prevYear - 1, "North America", 3.7477D);
        table.Rows.Add(prevYear - 1, "South America", 1.8237D);

        table.Rows.Add(prevYear, "Asia", 5.2890D);
        table.Rows.Add(prevYear, "Australia", 2.2727D);
        table.Rows.Add(prevYear, "Europe", 3.7257D);
        table.Rows.Add(prevYear, "North America", 4.1825D);
        table.Rows.Add(prevYear, "South America", 2.1172D);

        return table;
    }
    public static DataTable GetSalesMixByRegion() {
        DataTable table = new DataTable();
        table.Columns.AddRange(new DataColumn[] { new DataColumn("ProductCategory", typeof(string)), new DataColumn("Region", typeof(string)), new DataColumn("Sales", typeof(decimal)) });

        table.Rows.Add("Video players", "Asia", 853D);
        table.Rows.Add("Video players", "Australia", 321D);
        table.Rows.Add("Video players", "Europe", 655D);
        table.Rows.Add("Video players", "North America", 1325D);
        table.Rows.Add("Video players", "South America", 653D);

        table.Rows.Add("Automation", "Asia", 172D);
        table.Rows.Add("Automation", "Australia", 255D);
        table.Rows.Add("Automation", "Europe", 981D);
        table.Rows.Add("Automation", "North America", 963D);
        table.Rows.Add("Automation", "South America", 123D);

        table.Rows.Add("Monitors", "Asia", 1011D);
        table.Rows.Add("Monitors", "Australia", 359D);
        table.Rows.Add("Monitors", "Europe", 721D);
        table.Rows.Add("Monitors", "North America", 565D);
        table.Rows.Add("Monitors", "South America", 532D);

        table.Rows.Add("Projectors", "Asia", 998D);
        table.Rows.Add("Projectors", "Australia", 222D);
        table.Rows.Add("Projectors", "Europe", 865D);
        table.Rows.Add("Projectors", "North America", 787D);
        table.Rows.Add("Projectors", "South America", 332D);

        table.Rows.Add("Televisions", "Asia", 1356D);
        table.Rows.Add("Televisions", "Australia", 232D);
        table.Rows.Add("Televisions", "Europe", 1323D);
        table.Rows.Add("Televisions", "North America", 1125D);
        table.Rows.Add("Televisions", "South America", 865D);

        return table;
    }
    public static DataTable GetBranchesSales() {
        int lastYear = DateTime.Now.Year - 1;
        DataTable table = new DataTable();
        table.Columns.AddRange(new DataColumn[] { new DataColumn("Year", typeof(DateTime)), new DataColumn("Company", typeof(string)), new DataColumn("Sales", typeof(decimal)) });

        table.Rows.Add(new DateTime(lastYear - 10, 12, 31), "DevAV North", 1.010);
        table.Rows.Add(new DateTime(lastYear - 10, 12, 31), "DevAV Center", 3.032);
        table.Rows.Add(new DateTime(lastYear - 10, 12, 31), "DevAV South", 1.31);

        table.Rows.Add(new DateTime(lastYear - 9, 12, 31), "DevAV North", 1.512);
        table.Rows.Add(new DateTime(lastYear - 9, 12, 31), "DevAV Center", 3.050);
        table.Rows.Add(new DateTime(lastYear - 9, 12, 31), "DevAV South", 1.34);

        table.Rows.Add(new DateTime(lastYear - 8, 12, 31), "DevAV North", 1.723);
        table.Rows.Add(new DateTime(lastYear - 8, 12, 31), "DevAV West", 0.005);
        table.Rows.Add(new DateTime(lastYear - 8, 12, 31), "DevAV Center", 3.054);
        table.Rows.Add(new DateTime(lastYear - 8, 12, 31), "DevAV South", 1.30);

        table.Rows.Add(new DateTime(lastYear - 7, 12, 31), "DevAV West", 0.31);
        table.Rows.Add(new DateTime(lastYear - 7, 12, 31), "DevAV North", 2.001);
        table.Rows.Add(new DateTime(lastYear - 7, 12, 31), "DevAV Center", 2.975);
        table.Rows.Add(new DateTime(lastYear - 7, 12, 31), "DevAV South", 1.283);

        table.Rows.Add(new DateTime(lastYear - 6, 12, 31), "DevAV West", 0.41);
        table.Rows.Add(new DateTime(lastYear - 6, 12, 31), "DevAV North", 2.612);
        table.Rows.Add(new DateTime(lastYear - 6, 12, 31), "DevAV Center", 2.066);
        table.Rows.Add(new DateTime(lastYear - 6, 12, 31), "DevAV South", 0.88);

        table.Rows.Add(new DateTime(lastYear - 5, 12, 31), "DevAV West", 0.95);
        table.Rows.Add(new DateTime(lastYear - 5, 12, 31), "DevAV North", 2.666);
        table.Rows.Add(new DateTime(lastYear - 5, 12, 31), "DevAV Center", 2.078);
        table.Rows.Add(new DateTime(lastYear - 5, 12, 31), "DevAV South", 1.09);

        table.Rows.Add(new DateTime(lastYear - 4, 12, 31), "DevAV West", 1.53);
        table.Rows.Add(new DateTime(lastYear - 4, 12, 31), "DevAV North", 3.665);
        table.Rows.Add(new DateTime(lastYear - 4, 12, 31), "DevAV Center", 3.888);
        table.Rows.Add(new DateTime(lastYear - 4, 12, 31), "DevAV South", 1.01);

        table.Rows.Add(new DateTime(lastYear - 3, 12, 31), "DevAV East", 0.003);
        table.Rows.Add(new DateTime(lastYear - 3, 12, 31), "DevAV West", 1.75);
        table.Rows.Add(new DateTime(lastYear - 3, 12, 31), "DevAV North", 3.555);
        table.Rows.Add(new DateTime(lastYear - 3, 12, 31), "DevAV Center", 3.008);
        table.Rows.Add(new DateTime(lastYear - 3, 12, 31), "DevAV South", 1.11);

        table.Rows.Add(new DateTime(lastYear - 2, 12, 31), "DevAV East", 0.32);
        table.Rows.Add(new DateTime(lastYear - 2, 12, 31), "DevAV West", 1.31);
        table.Rows.Add(new DateTime(lastYear - 2, 12, 31), "DevAV North", 3.485);
        table.Rows.Add(new DateTime(lastYear - 2, 12, 31), "DevAV Center", 3.088);
        table.Rows.Add(new DateTime(lastYear - 2, 12, 31), "DevAV South", 1.12);

        table.Rows.Add(new DateTime(lastYear - 1, 12, 31), "DevAV East", 0.51);
        table.Rows.Add(new DateTime(lastYear - 1, 12, 31), "DevAV West", 1.31);
        table.Rows.Add(new DateTime(lastYear - 1, 12, 31), "DevAV North", 3.747);
        table.Rows.Add(new DateTime(lastYear - 1, 12, 31), "DevAV Center", 3.357);
        table.Rows.Add(new DateTime(lastYear - 1, 12, 31), "DevAV South", 1.12);

        table.Rows.Add(new DateTime(lastYear, 12, 31), "DevAV East", 1.71);
        table.Rows.Add(new DateTime(lastYear, 12, 31), "DevAV West", 1.22);
        table.Rows.Add(new DateTime(lastYear, 12, 31), "DevAV North", 4.182);
        table.Rows.Add(new DateTime(lastYear, 12, 31), "DevAV Center", 3.725);
        table.Rows.Add(new DateTime(lastYear, 12, 31), "DevAV South", 1.111);

        return table;
    }
    public static DataTable GetSalesByLast10Years() {
        int lastYear = DateTime.Now.Year - 1;
        DataTable table = new DataTable();
        table.Columns.AddRange(new DataColumn[] { new DataColumn("Year", typeof(DateTime)), new DataColumn("Region", typeof(string)), new DataColumn("Sales", typeof(decimal)) });

        table.Rows.Add(new DateTime(lastYear - 10, 12, 31), "North America", 3.010M);
        table.Rows.Add(new DateTime(lastYear - 10, 12, 31), "Europe", 3.032M);
        table.Rows.Add(new DateTime(lastYear - 10, 12, 31), "Australia", 1.31M);

        table.Rows.Add(new DateTime(lastYear - 9, 12, 31), "North America", 3.212M);
        table.Rows.Add(new DateTime(lastYear - 9, 12, 31), "Europe", 3.050M);
        table.Rows.Add(new DateTime(lastYear - 9, 12, 31), "Australia", 1.64M);

        table.Rows.Add(new DateTime(lastYear - 8, 12, 31), "North America", 3.223M);
        table.Rows.Add(new DateTime(lastYear - 8, 12, 31), "Europe", 3.054M);
        table.Rows.Add(new DateTime(lastYear - 8, 12, 31), "Australia", 1.70M);

        table.Rows.Add(new DateTime(lastYear - 7, 12, 31), "North America", 3.001M);
        table.Rows.Add(new DateTime(lastYear - 7, 12, 31), "Europe", 2.775M);
        table.Rows.Add(new DateTime(lastYear - 7, 12, 31), "Australia", 1.083M);

        table.Rows.Add(new DateTime(lastYear - 6, 12, 31), "North America", 2.612M);
        table.Rows.Add(new DateTime(lastYear - 6, 12, 31), "Europe", 2.066M);
        table.Rows.Add(new DateTime(lastYear - 6, 12, 31), "Australia", 0.88M);

        table.Rows.Add(new DateTime(lastYear - 5, 12, 31), "North America", 2.666M);
        table.Rows.Add(new DateTime(lastYear - 5, 12, 31), "Europe", 2.078M);
        table.Rows.Add(new DateTime(lastYear - 5, 12, 31), "Australia", 1.09M);

        table.Rows.Add(new DateTime(lastYear - 4, 12, 31), "North America", 3.665M);
        table.Rows.Add(new DateTime(lastYear - 4, 12, 31), "Europe", 3.888M);
        table.Rows.Add(new DateTime(lastYear - 4, 12, 31), "Australia", 2.01M);

        table.Rows.Add(new DateTime(lastYear - 3, 12, 31), "North America", 3.555M);
        table.Rows.Add(new DateTime(lastYear - 3, 12, 31), "Europe", 3.008M);
        table.Rows.Add(new DateTime(lastYear - 3, 12, 31), "Australia", 1.85M);

        table.Rows.Add(new DateTime(lastYear - 2, 12, 31), "North America", 3.485M);
        table.Rows.Add(new DateTime(lastYear - 2, 12, 31), "Europe", 3.088M);
        table.Rows.Add(new DateTime(lastYear - 2, 12, 31), "Australia", 1.78M);

        table.Rows.Add(new DateTime(lastYear - 1, 12, 31), "North America", 3.747M);
        table.Rows.Add(new DateTime(lastYear - 1, 12, 31), "Europe", 3.357M);
        table.Rows.Add(new DateTime(lastYear - 1, 12, 31), "Australia", 1.957M);

        table.Rows.Add(new DateTime(lastYear, 12, 31), "North America", 4.182M);
        table.Rows.Add(new DateTime(lastYear, 12, 31), "Europe", 3.725M);
        table.Rows.Add(new DateTime(lastYear, 12, 31), "Australia", 2.272M);

        return table;
    }
    public static DataTable GetOutsideVendorCosts() {
        int lastYear = DateTime.Now.Year - 1;
        DataTable table = new DataTable();
        table.Columns.AddRange(new DataColumn[] { new DataColumn("Year", typeof(DateTime)), new DataColumn("Company", typeof(string)), new DataColumn("Costs", typeof(decimal)) });

        table.Rows.Add(new DateTime(lastYear - 6, 1, 1), "DevAV North", 362.5M);
        table.Rows.Add(new DateTime(lastYear - 5, 1, 1), "DevAV North", 348.4M);
        table.Rows.Add(new DateTime(lastYear - 4, 1, 1), "DevAV North", 279.0M);
        table.Rows.Add(new DateTime(lastYear - 3, 1, 1), "DevAV North", 230.9M);
        table.Rows.Add(new DateTime(lastYear - 2, 1, 1), "DevAV North", 203.5M);
        table.Rows.Add(new DateTime(lastYear - 1, 1, 1), "DevAV North", 197.1M);

        table.Rows.Add(new DateTime(lastYear - 6, 1, 1), "DevAV South", 277.0M);
        table.Rows.Add(new DateTime(lastYear - 5, 1, 1), "DevAV South", 328.5M);
        table.Rows.Add(new DateTime(lastYear - 4, 1, 1), "DevAV South", 297.0M);
        table.Rows.Add(new DateTime(lastYear - 3, 1, 1), "DevAV South", 255.3M);
        table.Rows.Add(new DateTime(lastYear - 2, 1, 1), "DevAV South", 173.5M);
        table.Rows.Add(new DateTime(lastYear - 1, 1, 1), "DevAV South", 131.8M);

        return table;
    }
}

public class AgeStructure {
    static DataTable ageStructureTable;
    static DataTable AgeStructureTable {
        get {
            if (ageStructureTable == null)
                ageStructureTable = LoadPopulationAgeStructure();
            return ageStructureTable;
        }
    }

    static DataTable LoadPopulationAgeStructure() {  // data for end of 2016
        return XMLUtils.LoadDataTableFromXml("Population.xml", "Population");
    }
    public static IList GetDataByAgeAndGender() {
        return AgeStructureTable.AsEnumerable()
            .Select(row => new
            {
                GenderAge = new GenderAgeInfo(row.Field<string>("Gender"), row.Field<string>("Age")),
                Country = row.Field<string>("Country"),
                Population = row.Field<long>("Population")
            }).ToList();
    }
    public static IList GetDataByMaleAge() {
        return AgeStructureTable.AsEnumerable()
            .Where(row => row.Field<string>("Gender") == "Male")
            .Select(row => new
            {
                Age = row.Field<string>("Age"),
                Country = row.Field<string>("Country"),
                Population = row.Field<long>("Population")
            }).ToList();
    }
    public static IList GetDataByFemaleAge() {
        return AgeStructureTable.AsEnumerable()
            .Where(row => row.Field<string>("Gender") == "Female")
            .Select(row => new
            {
                Age = row.Field<string>("Age"),
                Country = row.Field<string>("Country"),
                Population = row.Field<long>("Population")
            }).ToList();
    }
    public static IList GetPopulationAgeStructure() {
        return AgeStructureTable.AsEnumerable()
            .Select(row => new AgePopulation(row.Field<string>("Country"), row.Field<string>("Age"), row.Field<string>("Gender"), row.Field<long>("Population"))).ToList();
    }
}
public struct GenderAgeInfo {
    string gender;
    string age;

    public string Gender { get { return gender; } }
    public string Age { get { return age; } }

    public GenderAgeInfo(string gender, string age) {
        this.gender = gender;
        this.age = age;
    }
    public override string ToString() {
        return gender + ": " + age;
    }
}
public class AgePopulation {
    string name;
    string age;
    string gender;
    double population;

    public string Name { get { return name; } }
    public string Age { get { return age; } }
    public string Gender { get { return gender; } }
    public string GenderAgeKey { get { return gender.ToString() + ": " + age; } }
    public string CountryAgeKey { get { return name + ": " + age; } }
    public string CountryGenderKey { get { return name + ": " + gender.ToString(); } }
    public double Population { get { return population; } }

    public AgePopulation(string name, string age, string gender, double population) {
        this.name = name;
        this.age = age;
        this.gender = gender;
        this.population = population;
    }
}

public class MarketPrices {
    public static DataTable GetGoogleStockPrices() {
        return XMLUtils.LoadDataTableFromXml("GoogleStock.xml", "StockPrice");
    }
    public static DataTable GetAppleStockPrices() {
        return XMLUtils.LoadDataTableFromXml("AppleStock.xml", "StockPrice");
    }
    public static IList GetPartialAppleStockPrices() {
        return GetAppleStockPrices().AsEnumerable()
            .Where(row => row.Field<DateTime>("Date") >= new DateTime(2016, 09, 1))
            .Select(row => new
            {
                Date = row.Field<DateTime>("Date"),
                Low = row.Field<double>("Low"),
                High = row.Field<double>("High"),
                Open = row.Field<double>("Open"),
                Close = row.Field<double>("Close")
            }).ToList();
    }
}

public class SourceOfEnergy {
    public static DataTable GetEuropeBrentPrices() {
        DataTable table = new DataTable("Europe Brent");
        table.Columns.AddRange(new DataColumn[] { new DataColumn("Date", typeof(DateTime)), new DataColumn("Min", typeof(float)), new DataColumn("Max", typeof(float)) });
        table.Rows.Add(new DateTime(2015, 01, 1), 45.13, 55.38);
        table.Rows.Add(new DateTime(2015, 02, 1), 51.74, 61.89);
        table.Rows.Add(new DateTime(2015, 03, 1), 52.00, 61.18);
        table.Rows.Add(new DateTime(2015, 04, 1), 55.73, 63.97);
        table.Rows.Add(new DateTime(2015, 05, 1), 60.12, 66.33);
        table.Rows.Add(new DateTime(2015, 06, 1), 59.03, 64.68);
        table.Rows.Add(new DateTime(2015, 07, 1), 53.29, 61.73);
        table.Rows.Add(new DateTime(2015, 08, 1), 41.59, 49.49);
        table.Rows.Add(new DateTime(2015, 09, 1), 45.87, 50.41);
        table.Rows.Add(new DateTime(2015, 10, 1), 45.54, 52.13);
        table.Rows.Add(new DateTime(2015, 11, 1), 40.28, 48.00);
        table.Rows.Add(new DateTime(2015, 12, 1), 35.26, 42.97);
        return table;
    }
    public static DataTable GetOkWtiPrices() {
        DataTable table = new DataTable("OK WTI");
        table.Columns.AddRange(new DataColumn[] { new DataColumn("Date", typeof(DateTime)), new DataColumn("Min", typeof(float)), new DataColumn("Max", typeof(float)) });
        table.Rows.Add(new DateTime(2015, 01, 1), 44.08, 52.72);
        table.Rows.Add(new DateTime(2015, 02, 1), 47.65, 49.84);
        table.Rows.Add(new DateTime(2015, 03, 1), 43.39, 51.53);
        table.Rows.Add(new DateTime(2015, 04, 1), 49.13, 59.62);
        table.Rows.Add(new DateTime(2015, 05, 1), 57.29, 60.93);
        table.Rows.Add(new DateTime(2015, 06, 1), 58.00, 61.36);
        table.Rows.Add(new DateTime(2015, 07, 1), 47.11, 56.94);
        table.Rows.Add(new DateTime(2015, 08, 1), 38.22, 49.20);
        table.Rows.Add(new DateTime(2015, 09, 1), 44.07, 47.12);
        table.Rows.Add(new DateTime(2015, 10, 1), 43.19, 49.67);
        table.Rows.Add(new DateTime(2015, 11, 1), 39.27, 47.88);
        table.Rows.Add(new DateTime(2015, 12, 1), 34.55, 41.08);
        return table;
    }
    public static DataTable GetGasolinePrices() {
        DataTable table = new DataTable("Gasoline");
        table.Columns.AddRange(new DataColumn[] { new DataColumn("Date", typeof(DateTime)), new DataColumn("Price", typeof(float)) });
        table.Rows.Add(new DateTime(2015, 01, 1), 2.208);
        table.Rows.Add(new DateTime(2015, 02, 1), 2.301);
        table.Rows.Add(new DateTime(2015, 03, 1), 2.546);
        table.Rows.Add(new DateTime(2015, 04, 1), 2.555);
        table.Rows.Add(new DateTime(2015, 05, 1), 2.802);
        table.Rows.Add(new DateTime(2015, 06, 1), 2.885);
        table.Rows.Add(new DateTime(2015, 07, 1), 2.880);
        table.Rows.Add(new DateTime(2015, 08, 1), 2.726);
        table.Rows.Add(new DateTime(2015, 09, 1), 2.462);
        table.Rows.Add(new DateTime(2015, 10, 1), 2.387);
        table.Rows.Add(new DateTime(2015, 11, 1), 2.260);
        table.Rows.Add(new DateTime(2015, 12, 1), 2.144);
        return table;
    }
    public static DataTable GetFuelPrices() {
        DataTable table = new DataTable();
        int lastYear = DateTime.Now.Year - 1;
        table.Columns.AddRange(new DataColumn[] { new DataColumn("Date", typeof(DateTime)), new DataColumn("Price", typeof(decimal)) });
        table.Rows.Add(new DateTime(lastYear, 1, 1, 0, 0, 0), 1.05M);
        table.Rows.Add(new DateTime(lastYear, 3, 3, 0, 0, 0), 1.07M);
        table.Rows.Add(new DateTime(lastYear, 3, 20, 0, 0, 0), 1.12M);
        table.Rows.Add(new DateTime(lastYear, 4, 15, 0, 0, 0), 1.15M);
        table.Rows.Add(new DateTime(lastYear, 5, 12, 0, 0, 0), 1.30M);
        table.Rows.Add(new DateTime(lastYear, 7, 15, 0, 0, 0), 1.25M);
        table.Rows.Add(new DateTime(lastYear, 7, 20, 0, 0, 0), 1.21M);
        table.Rows.Add(new DateTime(lastYear, 9, 15, 0, 0, 0), 1.20M);
        table.Rows.Add(new DateTime(lastYear, 10, 10, 0, 0, 0), 1.18M);
        table.Rows.Add(new DateTime(lastYear, 12, 30, 0, 0, 0), 1.12M);
        return table;
    }
    public static DataTable GetCoalProduction() {
        DataTable table = new DataTable();
        table.Columns.AddRange(new DataColumn[] { new DataColumn("Date", typeof(DateTime)), new DataColumn("South Africa", typeof(decimal)), new DataColumn("Poland", typeof(decimal)), new DataColumn("Russia", typeof(decimal)) });
        table.Rows.Add(new DateTime(2015, 12, 31, 0, 0, 0), 252.099, 135.523, 373.300);
        table.Rows.Add(new DateTime(2014, 12, 31, 0, 0, 0), 261.523, 137.148, 357.396);
        table.Rows.Add(new DateTime(2013, 12, 31, 0, 0, 0), 256.562, 142.906, 355.231);
        table.Rows.Add(new DateTime(2012, 12, 31, 0, 0, 0), 258.575, 144.093, 358.300);
        table.Rows.Add(new DateTime(2011, 12, 31, 0, 0, 0), 252.756, 139.289, 337.400);
        table.Rows.Add(new DateTime(2010, 12, 31, 0, 0, 0), 254.521, 133.238, 322.920);
        table.Rows.Add(new DateTime(2009, 12, 31, 0, 0, 0), 247.820, 135.172, 302.382);
        table.Rows.Add(new DateTime(2008, 12, 31, 0, 0, 0), 252.213, 144.013, 330.182);
        table.Rows.Add(new DateTime(2007, 12, 31, 0, 0, 0), 247.666, 145.850, 315.570);
        table.Rows.Add(new DateTime(2006, 12, 31, 0, 0, 0), 244.774, 156.065, 311.370);
        table.Rows.Add(new DateTime(2005, 12, 31, 0, 0, 0), 244.985, 159.540, 299.970);
        table.Rows.Add(new DateTime(2004, 12, 31, 0, 0, 0), 242.821, 161.284, 284.398);
        table.Rows.Add(new DateTime(2003, 12, 31, 0, 0, 0), 238.751, 163.790, 278.746);
        table.Rows.Add(new DateTime(2002, 12, 31, 0, 0, 0), 220.212, 161.920, 258.912);
        table.Rows.Add(new DateTime(2001, 12, 31, 0, 0, 0), 223.560, 163.540, 274.001);
        table.Rows.Add(new DateTime(2000, 12, 31, 0, 0, 0), 224.199, 162.820, 262.081);
        table.Rows.Add(new DateTime(1999, 12, 31, 0, 0, 0), 223.514, 172.730, 255.050);
        table.Rows.Add(new DateTime(1998, 12, 31, 0, 0, 0), 222.976, 178.550, 235.383);
        table.Rows.Add(new DateTime(1997, 12, 31, 0, 0, 0), 220.072, 200.930, 250.617);
        table.Rows.Add(new DateTime(1996, 12, 31, 0, 0, 0), 206.362, 201.720, 262.052);
        table.Rows.Add(new DateTime(1995, 12, 31, 0, 0, 0), 206.210, 200.720, 269.574);
        table.Rows.Add(new DateTime(1994, 12, 31, 0, 0, 0), 195.805, 200.700, 278.304);
        table.Rows.Add(new DateTime(1993, 12, 31, 0, 0, 0), 188.214, 198.580, 311.862);
        table.Rows.Add(new DateTime(1992, 12, 31, 0, 0, 0), 184.045, 198.380, 349.004);
        table.Rows.Add(new DateTime(1991, 12, 31, 0, 0, 0), 178.390, 209.790, 362.235);
        table.Rows.Add(new DateTime(1990, 12, 31, 0, 0, 0), 174.780, 215.320, 405.194);
        return table;
    }
}

public class FinancialPoint {
        string argument;
        DateTime dateTimeArgument;
        double highValue;
        double lowValue;
        double openValue;
        double closeValue;

        public string Argument { get { return argument; } set { argument = value; } }
        public DateTime DateTimeArgument { get { return dateTimeArgument; } set { dateTimeArgument = value; } }
        public double HighValue { get { return highValue; } set { highValue = value; } }
        public double LowValue { get { return lowValue; } set { lowValue = value; } }
        public double OpenValue { get { return openValue; } set { openValue = value; } }
        public double CloseValue { get { return closeValue; } set { closeValue = value; } }
    }

public class FinancialData {
    public static List<FinancialPoint> GetUSDJPYData() {
        return CsvReader.ReadFinancialData("USDJPYDaily.csv");
    }
    public static List<FinancialPoint> GetAUDUSDData() {
        return CsvReader.ReadFinancialData("AUDUSDDaily.csv");
    }
}

public class PowerConsumption {
    public static DataTable GetData() {
        DataTable table = new DataTable();
        table.Columns.AddRange(new DataColumn[] { new DataColumn("Branch", typeof(string)), new DataColumn("Time", typeof(DateTime)), new DataColumn("Power", typeof(double)) });

        table.Rows.Add("Branch \"Center\"", new DateTime(1, 1, 1, 7, 0, 0), 429);
        table.Rows.Add("Branch \"Center\"", new DateTime(1, 1, 1, 8, 0, 0), 432);
        table.Rows.Add("Branch \"Center\"", new DateTime(1, 1, 1, 9, 0, 0), 301);
        table.Rows.Add("Branch \"Center\"", new DateTime(1, 1, 1, 10, 0, 0), 307);
        table.Rows.Add("Branch \"Center\"", new DateTime(1, 1, 1, 11, 0, 0), 310);
        table.Rows.Add("Branch \"Center\"", new DateTime(1, 1, 1, 12, 0, 0), 380);
        table.Rows.Add("Branch \"Center\"", new DateTime(1, 1, 1, 13, 0, 0), 384);
        table.Rows.Add("Branch \"Center\"", new DateTime(1, 1, 1, 14, 0, 0), 398);
        table.Rows.Add("Branch \"Center\"", new DateTime(1, 1, 1, 15, 0, 0), 379);
        table.Rows.Add("Branch \"Center\"", new DateTime(1, 1, 1, 16, 0, 0), 220);
        table.Rows.Add("Branch \"Center\"", new DateTime(1, 1, 1, 17, 0, 0), 321);
        table.Rows.Add("Branch \"Center\"", new DateTime(1, 1, 1, 18, 0, 0), 341);
        table.Rows.Add("Branch \"Center\"", new DateTime(1, 1, 1, 19, 0, 0), 368);
        table.Rows.Add("Branch \"Center\"", new DateTime(1, 1, 1, 20, 0, 0), 557);
        table.Rows.Add("Branch \"Center\"", new DateTime(1, 1, 1, 21, 0, 0), 523);
        table.Rows.Add("Branch \"Center\"", new DateTime(1, 1, 1, 22, 0, 0), 501);
        table.Rows.Add("Branch \"Center\"", new DateTime(1, 1, 1, 23, 0, 0), 443);

        table.Rows.Add("Branch \"East\"", new DateTime(1, 1, 1, 7, 0, 0), 260);
        table.Rows.Add("Branch \"East\"", new DateTime(1, 1, 1, 8, 0, 0), 287);
        table.Rows.Add("Branch \"East\"", new DateTime(1, 1, 1, 9, 0, 0), 285);
        table.Rows.Add("Branch \"East\"", new DateTime(1, 1, 1, 10, 0, 0), 281);
        table.Rows.Add("Branch \"East\"", new DateTime(1, 1, 1, 11, 0, 0), 294);
        table.Rows.Add("Branch \"East\"", new DateTime(1, 1, 1, 12, 0, 0), 303);
        table.Rows.Add("Branch \"East\"", new DateTime(1, 1, 1, 13, 0, 0), 325);
        table.Rows.Add("Branch \"East\"", new DateTime(1, 1, 1, 14, 0, 0), 336);
        table.Rows.Add("Branch \"East\"", new DateTime(1, 1, 1, 15, 0, 0), 325);
        table.Rows.Add("Branch \"East\"", new DateTime(1, 1, 1, 16, 0, 0), 186);
        table.Rows.Add("Branch \"East\"", new DateTime(1, 1, 1, 17, 0, 0), 420);
        table.Rows.Add("Branch \"East\"", new DateTime(1, 1, 1, 18, 0, 0), 455);
        table.Rows.Add("Branch \"East\"", new DateTime(1, 1, 1, 19, 0, 0), 481);
        table.Rows.Add("Branch \"East\"", new DateTime(1, 1, 1, 20, 0, 0), 487);
        table.Rows.Add("Branch \"East\"", new DateTime(1, 1, 1, 21, 0, 0), 490);
        table.Rows.Add("Branch \"East\"", new DateTime(1, 1, 1, 22, 0, 0), 467);
        table.Rows.Add("Branch \"East\"", new DateTime(1, 1, 1, 23, 0, 0), 409);

        return table;
    }
}
