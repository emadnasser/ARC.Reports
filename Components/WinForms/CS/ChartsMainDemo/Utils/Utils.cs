using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Xml;
using DevExpress.Utils;

namespace DevExpress.XtraCharts.Demos {
    public static class Utils {
        const string path = "DevExpress.XtraCharts.Demos.Images.";

        static IEnumerable<Type> GetNonAbstractSubclasses(Type baseType) {
            Assembly xtraChartsAssembly = Assembly.GetAssembly(typeof(Legend));
            return xtraChartsAssembly.GetTypes().Where(type => !type.IsAbstract && type.IsSubclassOf(baseType) && type.IsPublic);
        }
        static bool IsCircularLine(Type seriesViewType) {
            return (seriesViewType.IsSubclassOf(typeof(RadarLineSeriesView)) || seriesViewType == typeof(RadarLineSeriesView)) &&
                   (!seriesViewType.IsSubclassOf(typeof(RadarAreaSeriesView)) && seriesViewType != typeof(RadarAreaSeriesView));
        }
        static bool IsCircularArea(Type seriesViewType) {
            return seriesViewType.IsSubclassOf(typeof(RadarAreaSeriesView)) || seriesViewType == typeof(RadarAreaSeriesView);
        }

        public static string GetRelativePath(string name) {
            name = "Data\\" + name;
            string path = System.Windows.Forms.Application.StartupPath;
            string s = "\\";
            for (int i = 0; i <= 10; i++) {
                if (System.IO.File.Exists(path + s + name))
                    return (path + s + name);
                else
                    s += "..\\";
            }
            path = Environment.CurrentDirectory;
            s = "\\";
            for (int i = 0; i <= 10; i++) {
                if (System.IO.File.Exists(path + s + name))
                    return (path + s + name);
                else
                    s += "..\\";
            }
            return "";
        }
        public static void SetConnectionString(System.Data.OleDb.OleDbConnection oleDbConnection, string path) {
            oleDbConnection.ConnectionString = String.Format(@"Provider=Microsoft.Jet.OLEDB.4.0;User ID=Admin;Data Source={0};Mode=Share Deny None;Extended Properties="""";Jet OLEDB:System database="""";Jet OLEDB:Registry Path="""";Jet OLEDB:Database Password="""";Jet OLEDB:Engine Type=5;Jet OLEDB:Database Locking Mode=1;Jet OLEDB:Global Partial Bulk Ops=2;Jet OLEDB:Global Bulk Transactions=1;Jet OLEDB:New Database Password="""";Jet OLEDB:Create System Database=False;Jet OLEDB:Encrypt Database=False;Jet OLEDB:Don't Copy Locale on Compact=False;Jet OLEDB:Compact Without Replica Repair=False;Jet OLEDB:SFP=False", path);
        }
        public static List<Type> GetSeriesAnimationTypes(ViewType viewType) {
            var fakeSeries = new Series("Fake Series", viewType);
            Type seriesViewType = fakeSeries.View.GetType();
            IEnumerable<PropertyInfo> seriesAnimationProperties = seriesViewType.GetProperties().Where(propertyInfo => propertyInfo.Name == "SeriesAnimation"); //"property" is a keyword in VB 
            if (seriesAnimationProperties != null && seriesAnimationProperties.Count() == 1) {
                Type baseSeriesAnimationType = seriesAnimationProperties.First().PropertyType;
                return new List<Type>(GetNonAbstractSubclasses(baseSeriesAnimationType));
            }
            return new List<Type>();
        }
        public static List<Type> GetPointAnimationTypes(ViewType viewType) {
            var fakeSeries = new Series("Fake Series", viewType);
            Type seriesViewType = fakeSeries.View.GetType();
            PropertyInfo pointAnimationProperty = seriesViewType.GetProperty("SeriesPointAnimation");
            if (pointAnimationProperty == null)
                pointAnimationProperty = seriesViewType.GetProperty("Animation");
            if (pointAnimationProperty != null && pointAnimationProperty.GetCustomAttribute(typeof(BrowsableAttribute)) == null) {
                Type basePointAnimationType = pointAnimationProperty.PropertyType;
                return new List<Type>(GetNonAbstractSubclasses(basePointAnimationType));
            }
            return new List<Type>();
        }
        public static DataTable LoadDataTableFromXml(string fileName, string tableName) {
            Stream xmlStream = AssemblyHelper.GetEmbeddedResourceStream(typeof(ChartDemoBase).Assembly, fileName, false);
            DataSet xmlDataSet = new DataSet();
            xmlDataSet.ReadXml(xmlStream);
            xmlStream.Close();
            return xmlDataSet.Tables[tableName];
        }
    }


    public static class PieExplodingHelper {
        static SeriesPointFilter CreateFilter(string mode) {
            return new SeriesPointFilter(SeriesPointKey.Argument, DataFilterCondition.Equal, mode);
        }
        static void ApplyFilterMode(PieSeriesViewBase view, string mode) {
            view.ExplodedPointsFilters.Clear();
            view.ExplodedPointsFilters.Add(CreateFilter(mode));
            view.ExplodeMode = PieExplodeMode.UseFilters;
        }

        public const string None = "None";
        public const string All = "All";
        public const string MinValue = "Min Value";
        public const string MaxValue = "Max Value";
        public const string Custom = "Custom";

        public static List<string> CreateModeList(SeriesPointCollection points, bool supportCustom) {
            List<string> list = new List<string>();
            list.Add(None);
            list.Add(All);
            list.Add(MinValue);
            list.Add(MaxValue);
            foreach (SeriesPoint point in points)
                list.Add(point.Argument);
            if (supportCustom)
                list.Add(Custom);
            return list;
        }
        public static void ApplyMode(PieSeriesViewBase view, string mode) {
            switch (mode) {
                case Custom:
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
                    ApplyFilterMode(view, mode);
                    break;
            }
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
            return (3.0 * sin * cos) / (Math.Pow(sin, 3.0) + Math.Pow(cos, 3.0));
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


    public class DegreeScatterFunctionCalculator : ScatterFunctionCalculatorBase {
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

    public static class CsvReader {
        public static List<FinancialPoint> ReadFinancialData(string fileName) {
            string longFileName = string.Empty;
            StreamReader reader;
            var dataSource = new List<FinancialPoint>();
            Stream stream = AssemblyHelper.GetEmbeddedResourceStream(typeof(ChartDemoBase).Assembly, fileName, false);
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
            return dataSource;
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


    public class GDP {
        public int Year { get; private set; }
        public decimal Product { get; private set; }

        public GDP(int year, decimal product) {
            this.Year = year;
            this.Product = product;
        }
    }

    public class G7Member {
        public decimal GDPin2015 { get { return GDPs.First((gdp) => gdp.Year == 2015).Product; } }
        public string CountryName { get; private set; }
        public List<GDP> GDPs { get; private set; }
        public int ColorNumberInPalette { get; private set; }

        public G7Member(string country, int colorNumberInPalette) {
            this.CountryName = country;
            this.GDPs = new List<GDP>();
            this.ColorNumberInPalette = colorNumberInPalette;
        }
    }

    public class GDPofG7 {
        public static IList GetData() {
            DataTable data = Utils.LoadDataTableFromXml("GDPofG7.xml", "GDP");
            return data.AsEnumerable()
                .Where(row => row.Field<int>("Year") >= 2010)
                .Select(row => new {
                    Country = row.Field<string>("Country"),
                    Year = row.Field<int>("Year"),
                    Product = row.Field<double>("Product")
                }).ToList();
        }
        public static List<G7Member> GetDataByMember() {
            List<G7Member> countries = new List<G7Member>();
            Stream xmlStream = AssemblyHelper.GetEmbeddedResourceStream(typeof(ChartDemoBase).Assembly, "GDPofG7.xml", false);
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

    public class HPI {
        public static DataTable GetData() {
            return Utils.LoadDataTableFromXml("HPI.xml", "CountryStatistics");
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
            return Utils.LoadDataTableFromXml("Population.xml", "Population");
        }
        public static IList GetDataByAgeAndGender() {
            return AgeStructureTable.AsEnumerable()
                .Select(row => new {
                    GenderAge = new GenderAgeInfo(row.Field<string>("Gender"), row.Field<string>("Age")),
                    Country = row.Field<string>("Country"),
                    Population = row.Field<long>("Population")
                }).ToList();
        }
        public static IList GetDataByMaleAge() {
            return AgeStructureTable.AsEnumerable()
                .Where(row => row.Field<string>("Gender") == "Male")
                .Select(row => new {
                    Age = row.Field<string>("Age"),
                    Country = row.Field<string>("Country"),
                    Population = row.Field<long>("Population")
                }).ToList();
        }
        public static IList GetDataByFemaleAge() {
            return AgeStructureTable.AsEnumerable()
                .Where(row => row.Field<string>("Gender") == "Female")
                .Select(row => new {
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
            return Utils.LoadDataTableFromXml("GoogleStock.xml", "StockPrice");
        }
        public static DataTable GetAppleStockPrices() {
            return Utils.LoadDataTableFromXml("AppleStock.xml", "StockPrice");
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
            table.Columns.AddRange(new DataColumn[] { new DataColumn("Date", typeof(DateTime)), new DataColumn("Price", typeof(decimal)) });
            table.Rows.Add(new DateTime(2016, 1, 1, 0, 0, 0), 2.143M);
            table.Rows.Add(new DateTime(2016, 2, 1, 0, 0, 0), 1.998M);
            table.Rows.Add(new DateTime(2016, 3, 1, 0, 0, 0), 2.090M);
            table.Rows.Add(new DateTime(2016, 4, 1, 0, 0, 0), 2.152M);
            table.Rows.Add(new DateTime(2016, 5, 1, 0, 0, 0), 2.315M);
            table.Rows.Add(new DateTime(2016, 6, 1, 0, 0, 0), 2.423M);
            table.Rows.Add(new DateTime(2016, 7, 1, 0, 0, 0), 2.405M);
            table.Rows.Add(new DateTime(2016, 8, 1, 0, 0, 0), 2.351M);
            table.Rows.Add(new DateTime(2016, 9, 1, 0, 0, 0), 2.394M);
            table.Rows.Add(new DateTime(2016, 10, 1, 0, 0, 0), 2.454M);
            table.Rows.Add(new DateTime(2016, 11, 1, 0, 0, 0), 2.439M);
            table.Rows.Add(new DateTime(2016, 12, 1, 0, 0, 0), 2.510M);
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
        public static DataTable GetGasPrices() {
            return Utils.LoadDataTableFromXml("GasPrices.xml", "GasPrice");
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
}
