using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Xml.Linq;

namespace ChartsDemo {

    public class DevAVSalesMixByRegion {
        public DataTable Data {
            get { return GetData(); }
        }

        public DataTable GetData() {
            DataTable table = new DataTable();
            table.Columns.AddRange(new DataColumn[] { new DataColumn("ProductCategory", typeof(string)), new DataColumn("Region", typeof(string)), new DataColumn("Sales", typeof(decimal)) });

            table.Rows.Add("Video players", "Asia", 853M);
            table.Rows.Add("Video players", "Australia", 321M);
            table.Rows.Add("Video players", "Europe", 655M);
            table.Rows.Add("Video players", "North America", 1325M);
            table.Rows.Add("Video players", "South America", 653M);

            table.Rows.Add("Automation", "Asia", 172M);
            table.Rows.Add("Automation", "Australia", 255M);
            table.Rows.Add("Automation", "Europe", 981M);
            table.Rows.Add("Automation", "North America", 963M);
            table.Rows.Add("Automation", "South America", 123M);

            table.Rows.Add("Monitors", "Asia", 1011M);
            table.Rows.Add("Monitors", "Australia", 359M);
            table.Rows.Add("Monitors", "Europe", 721M);
            table.Rows.Add("Monitors", "North America", 565M);
            table.Rows.Add("Monitors", "South America", 532M);

            table.Rows.Add("Projectors", "Asia", 998M);
            table.Rows.Add("Projectors", "Australia", 222M);
            table.Rows.Add("Projectors", "Europe", 865M);
            table.Rows.Add("Projectors", "North America", 787M);
            table.Rows.Add("Projectors", "South America", 332M);

            table.Rows.Add("Televisions", "Asia", 1356M);
            table.Rows.Add("Televisions", "Australia", 232M);
            table.Rows.Add("Televisions", "Europe", 1323M);
            table.Rows.Add("Televisions", "North America", 1125M);
            table.Rows.Add("Televisions", "South America", 865M);

            return table;
        }
    }

    public class DevAVSalesInNorthAmerica {
        public DataTable Data {
            get { return GetData(); }
        }

        public DataTable GetData() {
            DataTable table = new DataTable();
            table.Columns.AddRange(new DataColumn[] { new DataColumn("ProductCategory", typeof(string)), new DataColumn("Sales", typeof(decimal)) });
            table.Rows.Add("Video players", 1325M);
            table.Rows.Add("Automation", 963M);
            table.Rows.Add("Monitors", 565M);
            table.Rows.Add("Projectors", 787M);
            table.Rows.Add("Televisions", 1125M);
            return table;
        }
    }


    public class DevAVSalesInSouthAmerica {
        public DataTable Data {
            get { return GetData(); }
        }

        public DataTable GetData() {
            DataTable table = new DataTable();
            table.Columns.AddRange(new DataColumn[] { new DataColumn("ProductCategory", typeof(string)), new DataColumn("Sales", typeof(decimal)) });
            table.Rows.Add("Video players",  653M);
            table.Rows.Add("Automation", 123M);
            table.Rows.Add("Monitors", 532M);
            table.Rows.Add("Projectors", 332M);
            table.Rows.Add("Televisions", 865M);
            return table;
        }
    }


    public class DevAVSalesByYear {
        public DataTable Data {
            get { return GetData(); }
        }

        public DataTable GetData() {
            int lastYear = DateTime.Now.Year - 1;
            DataTable table = new DataTable();
            table.Columns.AddRange(new DataColumn[] { new DataColumn("Year", typeof(int)), new DataColumn("Region", typeof(string)), new DataColumn("Sales", typeof(decimal)) });

            table.Rows.Add(lastYear - 2, "Asia", 4.23M);
            table.Rows.Add(lastYear - 2, "North America", 3.485M);
            table.Rows.Add(lastYear - 2, "Europe", 3.088M);
            table.Rows.Add(lastYear - 2, "Australia", 1.78M);
            table.Rows.Add(lastYear - 2, "South America", 1.602M);

            table.Rows.Add(lastYear - 1, "Asia", 4.768M);
            table.Rows.Add(lastYear - 1, "North America", 3.747M);
            table.Rows.Add(lastYear - 1, "Europe", 3.357M);
            table.Rows.Add(lastYear - 1, "Australia", 1.957M);
            table.Rows.Add(lastYear - 1, "South America", 1.823M);

            table.Rows.Add(lastYear, "Asia", 5.289M);
            table.Rows.Add(lastYear, "North America", 4.182M);
            table.Rows.Add(lastYear, "Europe", 3.725M);
            table.Rows.Add(lastYear, "Australia", 2.272M);
            table.Rows.Add(lastYear, "South America", 2.117M);

            return table;
        }
    }


    public class DevAVSalesByLast10Years {
        public DataTable Data {
            get { return GetData(); }
        }

        public DataTable GetData() {
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

        static DataTable LoadPopulationAgeStructure() {
            Uri uri = new Uri(@"pack://application:,,,/ChartsDemo;component/Data/Population.xml");
            Stream xmlStream = Application.GetResourceStream(uri).Stream;
            DataSet xmlDataSet = new DataSet();
            xmlDataSet.ReadXml(xmlStream);
            xmlStream.Close();
            return xmlDataSet.Tables["Population"];
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


    public class PowerConsumption {
        public DataTable Data {
            get { return GetData(); }
        }

        public DataTable GetData() {
            DataTable table = new DataTable();
            table.Columns.AddRange(new DataColumn[] { new DataColumn("Branch", typeof(string)), new DataColumn("Time", typeof(DateTime)), new DataColumn("Power", typeof(double)) });

            table.Rows.Add("\"Center\" Branch", new DateTime(1, 1, 1, 7, 0, 0), 429);
            table.Rows.Add("\"Center\" Branch", new DateTime(1, 1, 1, 8, 0, 0), 432);
            table.Rows.Add("\"Center\" Branch", new DateTime(1, 1, 1, 9, 0, 0), 301);
            table.Rows.Add("\"Center\" Branch", new DateTime(1, 1, 1, 10, 0, 0), 307);
            table.Rows.Add("\"Center\" Branch", new DateTime(1, 1, 1, 11, 0, 0), 310);
            table.Rows.Add("\"Center\" Branch", new DateTime(1, 1, 1, 12, 0, 0), 380);
            table.Rows.Add("\"Center\" Branch", new DateTime(1, 1, 1, 13, 0, 0), 384);
            table.Rows.Add("\"Center\" Branch", new DateTime(1, 1, 1, 14, 0, 0), 398);
            table.Rows.Add("\"Center\" Branch", new DateTime(1, 1, 1, 15, 0, 0), 379);
            table.Rows.Add("\"Center\" Branch", new DateTime(1, 1, 1, 16, 0, 0), 220);
            table.Rows.Add("\"Center\" Branch", new DateTime(1, 1, 1, 17, 0, 0), 321);
            table.Rows.Add("\"Center\" Branch", new DateTime(1, 1, 1, 18, 0, 0), 341);
            table.Rows.Add("\"Center\" Branch", new DateTime(1, 1, 1, 19, 0, 0), 368);
            table.Rows.Add("\"Center\" Branch", new DateTime(1, 1, 1, 20, 0, 0), 557);
            table.Rows.Add("\"Center\" Branch", new DateTime(1, 1, 1, 21, 0, 0), 523);
            table.Rows.Add("\"Center\" Branch", new DateTime(1, 1, 1, 22, 0, 0), 501);
            table.Rows.Add("\"Center\" Branch", new DateTime(1, 1, 1, 23, 0, 0), 443);

            table.Rows.Add("\"East\" Branch", new DateTime(1, 1, 1, 7, 0, 0), 260);
            table.Rows.Add("\"East\" Branch", new DateTime(1, 1, 1, 8, 0, 0), 287);
            table.Rows.Add("\"East\" Branch", new DateTime(1, 1, 1, 9, 0, 0), 285);
            table.Rows.Add("\"East\" Branch", new DateTime(1, 1, 1, 10, 0, 0), 281);
            table.Rows.Add("\"East\" Branch", new DateTime(1, 1, 1, 11, 0, 0), 294);
            table.Rows.Add("\"East\" Branch", new DateTime(1, 1, 1, 12, 0, 0), 303);
            table.Rows.Add("\"East\" Branch", new DateTime(1, 1, 1, 13, 0, 0), 325);
            table.Rows.Add("\"East\" Branch", new DateTime(1, 1, 1, 14, 0, 0), 336);
            table.Rows.Add("\"East\" Branch", new DateTime(1, 1, 1, 15, 0, 0), 325);
            table.Rows.Add("\"East\" Branch", new DateTime(1, 1, 1, 16, 0, 0), 186);
            table.Rows.Add("\"East\" Branch", new DateTime(1, 1, 1, 17, 0, 0), 420);
            table.Rows.Add("\"East\" Branch", new DateTime(1, 1, 1, 18, 0, 0), 455);
            table.Rows.Add("\"East\" Branch", new DateTime(1, 1, 1, 19, 0, 0), 481);
            table.Rows.Add("\"East\" Branch", new DateTime(1, 1, 1, 20, 0, 0), 487);
            table.Rows.Add("\"East\" Branch", new DateTime(1, 1, 1, 21, 0, 0), 490);
            table.Rows.Add("\"East\" Branch", new DateTime(1, 1, 1, 22, 0, 0), 467);
            table.Rows.Add("\"East\" Branch", new DateTime(1, 1, 1, 23, 0, 0), 409);
            return table;
        }
    }


    public class DevAVBranchesSales {
        public DataTable Data {
            get { return GetData(); }
        }

        public DataTable GetData() {
            int lastYear = DateTime.Now.Year - 1;
            DataTable table = new DataTable();
            table.Columns.AddRange(new DataColumn[] { new DataColumn("Year", typeof(DateTime)), new DataColumn("Company", typeof(string)), new DataColumn("Sales", typeof(decimal)) });

            table.Rows.Add(new DateTime(lastYear - 10, 12, 31), "DevAV North", 1.010M);
            table.Rows.Add(new DateTime(lastYear - 10, 12, 31), "DevAV Center", 3.032M);
            table.Rows.Add(new DateTime(lastYear - 10, 12, 31), "DevAV South", 1.31M);

            table.Rows.Add(new DateTime(lastYear - 9, 12, 31), "DevAV North", 1.512M);
            table.Rows.Add(new DateTime(lastYear - 9, 12, 31), "DevAV Center", 3.050M);
            table.Rows.Add(new DateTime(lastYear - 9, 12, 31), "DevAV South", 1.34M);

            table.Rows.Add(new DateTime(lastYear - 8, 12, 31), "DevAV North", 1.723M);
            table.Rows.Add(new DateTime(lastYear - 8, 12, 31), "DevAV West", 0.005M);
            table.Rows.Add(new DateTime(lastYear - 8, 12, 31), "DevAV Center", 3.054M);
            table.Rows.Add(new DateTime(lastYear - 8, 12, 31), "DevAV South", 1.30M);

            table.Rows.Add(new DateTime(lastYear - 7, 12, 31), "DevAV West", 0.31M);
            table.Rows.Add(new DateTime(lastYear - 7, 12, 31), "DevAV North", 2.001M);
            table.Rows.Add(new DateTime(lastYear - 7, 12, 31), "DevAV Center", 2.975M);
            table.Rows.Add(new DateTime(lastYear - 7, 12, 31), "DevAV South", 1.283M);

            table.Rows.Add(new DateTime(lastYear - 6, 12, 31), "DevAV West", 0.41M);
            table.Rows.Add(new DateTime(lastYear - 6, 12, 31), "DevAV North", 2.612M);
            table.Rows.Add(new DateTime(lastYear - 6, 12, 31), "DevAV Center", 2.066M);
            table.Rows.Add(new DateTime(lastYear - 6, 12, 31), "DevAV South", 0.88M);

            table.Rows.Add(new DateTime(lastYear - 5, 12, 31), "DevAV West", 0.95M);
            table.Rows.Add(new DateTime(lastYear - 5, 12, 31), "DevAV North", 2.666M);
            table.Rows.Add(new DateTime(lastYear - 5, 12, 31), "DevAV Center", 2.078M);
            table.Rows.Add(new DateTime(lastYear - 5, 12, 31), "DevAV South", 1.09M);

            table.Rows.Add(new DateTime(lastYear - 4, 12, 31), "DevAV West", 1.53M);
            table.Rows.Add(new DateTime(lastYear - 4, 12, 31), "DevAV North", 3.665M);
            table.Rows.Add(new DateTime(lastYear - 4, 12, 31), "DevAV Center", 3.888M);
            table.Rows.Add(new DateTime(lastYear - 4, 12, 31), "DevAV South", 1.01M);

            table.Rows.Add(new DateTime(lastYear - 3, 12, 31), "DevAV East", 0.004M);
            table.Rows.Add(new DateTime(lastYear - 3, 12, 31), "DevAV West", 1.75M);
            table.Rows.Add(new DateTime(lastYear - 3, 12, 31), "DevAV North", 3.555M);
            table.Rows.Add(new DateTime(lastYear - 3, 12, 31), "DevAV Center", 3.008M);
            table.Rows.Add(new DateTime(lastYear - 3, 12, 31), "DevAV South", 1.11M);

            table.Rows.Add(new DateTime(lastYear - 2, 12, 31), "DevAV East", 0.32M);
            table.Rows.Add(new DateTime(lastYear - 2, 12, 31), "DevAV West", 1.31M);
            table.Rows.Add(new DateTime(lastYear - 2, 12, 31), "DevAV North", 3.485M);
            table.Rows.Add(new DateTime(lastYear - 2, 12, 31), "DevAV Center", 3.088M);
            table.Rows.Add(new DateTime(lastYear - 2, 12, 31), "DevAV South", 1.12M);

            table.Rows.Add(new DateTime(lastYear - 1, 12, 31), "DevAV East", 0.51M);
            table.Rows.Add(new DateTime(lastYear - 1, 12, 31), "DevAV West", 1.31M);
            table.Rows.Add(new DateTime(lastYear - 1, 12, 31), "DevAV North", 3.747M);
            table.Rows.Add(new DateTime(lastYear - 1, 12, 31), "DevAV Center", 3.357M);
            table.Rows.Add(new DateTime(lastYear - 1, 12, 31), "DevAV South", 1.12M);

            table.Rows.Add(new DateTime(lastYear, 12, 31), "DevAV East", 1.71M);
            table.Rows.Add(new DateTime(lastYear, 12, 31), "DevAV West", 1.22M);
            table.Rows.Add(new DateTime(lastYear, 12, 31), "DevAV North", 4.182M);
            table.Rows.Add(new DateTime(lastYear, 12, 31), "DevAV Center", 3.725M);
            table.Rows.Add(new DateTime(lastYear, 12, 31), "DevAV South", 1.111M);

            return table;
        }
    }
    public class FuelPrices {
        public DataTable Data {
            get { return GetData(); }
        }

        public DataTable GetData() {
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
            table.Rows.Add(new DateTime(2016, 10,1, 0, 0, 0), 2.454M);
            table.Rows.Add(new DateTime(2016, 11,1, 0, 0, 0), 2.439M);
            table.Rows.Add(new DateTime(2016, 12,1, 0, 0, 0), 2.510M);
            return table;
        }
    }


    public class HighestGrossingFilmsByYear {
        public DataTable Data {
            get { return GetData(); }
        }

        public DataTable GetData() {
            DataTable table = new DataTable();
            table.Columns.AddRange(new DataColumn[] { new DataColumn("Year", typeof(DateTime)), new DataColumn("Budget", typeof(decimal)), new DataColumn("Grosses", typeof(decimal)), new DataColumn("Title", typeof(string)) });
            table.Rows.Add(new DateTime(2007, 1, 1), 300, 0.963, "Pirates of the Caribbean:\nAt World's End");
            table.Rows.Add(new DateTime(2008, 1, 1), 185, 1.004, "The Dark Knight");
            table.Rows.Add(new DateTime(2009, 1, 1), 237, 2.788, "Avatar");
            table.Rows.Add(new DateTime(2010, 1, 1), 200, 1.067, "Toy Story 3");
            table.Rows.Add(new DateTime(2011, 1, 1), 250, 1.341, "Harry Potter and the Deathly Hallows\nPart 2");
            table.Rows.Add(new DateTime(2012, 1, 1), 220, 1.519, "Marvel's The Avengers");
            table.Rows.Add(new DateTime(2013, 1, 1), 150, 1.276, "Frozen");
            table.Rows.Add(new DateTime(2014, 1, 1), 210, 1.104, "Transformers:\nAge of Extinction");
            table.Rows.Add(new DateTime(2015, 1, 1), 245, 2.068, "Star Wars:\nThe Force Awakens");
            table.Rows.Add(new DateTime(2016, 1, 1), 250, 1.153, "Captain America:\nCivil War");
            return table;
        }
    }


    public class OutsideVendorCosts {
        public DataTable Data {
            get { return GetData(); }
        }

        public DataTable GetData() {
            int lastYear = DateTime.Now.Year - 1;
            DataTable table = new DataTable();
            table.Columns.AddRange(new DataColumn[] { new DataColumn("Year", typeof(DateTime)), new DataColumn("Company", typeof(string)), new DataColumn("Costs", typeof(decimal)) });

            table.Rows.Add(new DateTime(lastYear - 6, 12, 31), "DevAV North", 362.5M);
            table.Rows.Add(new DateTime(lastYear - 5, 12, 31), "DevAV North", 348.4M);
            table.Rows.Add(new DateTime(lastYear - 4, 12, 31), "DevAV North", 279.0M);
            table.Rows.Add(new DateTime(lastYear - 3, 12, 31), "DevAV North", 230.9M);
            table.Rows.Add(new DateTime(lastYear - 2, 12, 31), "DevAV North", 203.5M);
            table.Rows.Add(new DateTime(lastYear - 1, 12, 31), "DevAV North", 197.1M);

            table.Rows.Add(new DateTime(lastYear - 6, 12, 31), "DevAV South", 277.0M);
            table.Rows.Add(new DateTime(lastYear - 5, 12, 31), "DevAV South", 328.5M);
            table.Rows.Add(new DateTime(lastYear - 4, 12, 31), "DevAV South", 297.0M);
            table.Rows.Add(new DateTime(lastYear - 3, 12, 31), "DevAV South", 255.3M);
            table.Rows.Add(new DateTime(lastYear - 2, 12, 31), "DevAV South", 173.5M);
            table.Rows.Add(new DateTime(lastYear - 1, 12, 31), "DevAV South", 131.8M);

            return table;
        }
    }


    public class GoogleStockData {
        public DataTable Data {
            get { return GetData(); }
        }
        public DataTable ShortData {
            get { return Data.AsEnumerable().Reverse().Take(30).Reverse().CopyToDataTable(); }
        }

        public DataTable GetData() {
            return DataUtils.LoadDataTableFromXml("GoogleStockData.xml", "StockPrice");
        }
    }

    public static class FinancialDataLoader {
        static ImageSource positiveDynamic = new BitmapImage(new Uri("/ChartsDemo;component/Images/ArrowUp.png", UriKind.Relative));
        static ImageSource negativeDynamic = new BitmapImage(new Uri("/ChartsDemo;component/Images/ArrowDown.png", UriKind.Relative));
        static ImageSource zeroDynamic = new BitmapImage(new Uri("/ChartsDemo;component/Images/ZeroDynamic.png", UriKind.Relative));

        static StockDynamic GetStockDynamic(decimal previousPointValue, decimal currentPointValue) {
            if (previousPointValue < currentPointValue)
                return new StockDynamic(new SolidColorBrush(Color.FromArgb(255, 63, 171, 0)), positiveDynamic);
            else if (previousPointValue > currentPointValue)
                return new StockDynamic(new SolidColorBrush(Color.FromArgb(255, 213, 50, 35)), negativeDynamic);
            else
                return new StockDynamic(new SolidColorBrush(Color.FromArgb(255, 161, 161, 161)), zeroDynamic);
        }
        static StockDataPoint ReadDataPointFromXML(XElement element) {
            StockDataPoint point = new StockDataPoint();
            point.TradeDate = DateTime.ParseExact(element.Element("Date").Value, "yyyy-MM-dd", CultureInfo.InvariantCulture);
            point.Open = Convert.ToDecimal(element.Element("Open").Value, CultureInfo.InvariantCulture);
            point.Close = Convert.ToDecimal(element.Element("Close").Value, CultureInfo.InvariantCulture);
            point.Low = Convert.ToDecimal(element.Element("Low").Value, CultureInfo.InvariantCulture);
            point.High = Convert.ToDecimal(element.Element("High").Value, CultureInfo.InvariantCulture);
            point.ToolTipData = new ToolTipStockData();
            point.ToolTipData.Owner = point;
            return point;
        }
        public static List<StockDataPoint> GetGoogleStockData() {
            XDocument document = DataLoader.LoadXmlFromResources("/Data/GoogleStockData.xml");
            List<StockDataPoint> result = new List<StockDataPoint>();
            if (document != null) {
                IEnumerable<XElement> elements = document.Element("StockPrices").Elements("StockPrice").Reverse();
                StockDataPoint previousPoint = ReadDataPointFromXML(elements.ElementAt(0));
                foreach (XElement element in elements) {
                    StockDataPoint point = ReadDataPointFromXML(element);
                    point.ToolTipData.OpenDynamic = GetStockDynamic(previousPoint.Open, point.Open).ImageSource;
                    point.ToolTipData.CloseDynamic = GetStockDynamic(previousPoint.Close, point.Close).ImageSource;
                    point.ToolTipData.HighDynamic = GetStockDynamic(previousPoint.High, point.High).ImageSource;
                    point.ToolTipData.LowDynamic = GetStockDynamic(previousPoint.Low, point.Low).ImageSource;
                    point.ToolTipData.OpenFontBrush = GetStockDynamic(previousPoint.Open, point.Open).Brush;
                    point.ToolTipData.CloseFontBrush = GetStockDynamic(previousPoint.Close, point.Close).Brush;
                    point.ToolTipData.HighFontBrush = GetStockDynamic(previousPoint.High, point.High).Brush;
                    point.ToolTipData.LowFontBrush = GetStockDynamic(previousPoint.Low, point.Low).Brush;
                    result.Add(point);
                    previousPoint = point;
                }
            }
            return result;
        }
    }

    public class StockDataPoint {
        public ToolTipStockData ToolTipData { get; set; }
        public DateTime TradeDate { get; set; }
        public decimal High { get; set; }
        public decimal Low { get; set; }
        public decimal Open { get; set; }
        public decimal Close { get; set; }
    }

    public class ToolTipStockData {
        public StockDataPoint Owner { get; set; }
        public ImageSource HighDynamic { get; set; }
        public ImageSource LowDynamic { get; set; }
        public ImageSource OpenDynamic { get; set; }
        public ImageSource CloseDynamic { get; set; }
        public Brush HighFontBrush { get; set; }
        public Brush LowFontBrush { get; set; }
        public Brush OpenFontBrush { get; set; }
        public Brush CloseFontBrush { get; set; }
    }

    public class StockDynamic {
        public Brush Brush { get; private set; }
        public ImageSource ImageSource { get; private set; }

        public StockDynamic(Brush brush, ImageSource imageSource) {
            Brush = brush;
            ImageSource = imageSource;
        }
    }

    public static class DataUtils {
        public static DataTable LoadDataTableFromXml(string fileName, string tableName) {
            Uri uri = new Uri(@"pack://application:,,,/ChartsDemo;component/Data/" + fileName);
            Stream xmlStream = Application.GetResourceStream(uri).Stream;
            DataSet xmlDataSet = new DataSet();
            xmlDataSet.ReadXml(xmlStream);
            xmlStream.Close();
            return xmlDataSet.Tables[tableName];
        }
    }


    public class GoldPrices {
        public List<GoldPrice> Data {
            get { return GetData(); }
        }

        List<GoldPrice> GetData() {
            XDocument document = DataLoader.LoadXmlFromResources("/Data/GoldPrices.xml");
            List<GoldPrice> goldPrices = new List<GoldPrice>();
            if (document != null) {
                foreach (XElement element in document.Element("GoldPrices").Elements()) {
                    DateTime date = DateTime.ParseExact(element.Element("Date").Value, "dd MMM yyyy", CultureInfo.InvariantCulture);
                    double price = Convert.ToDouble(element.Element("Price").Value, CultureInfo.InvariantCulture);
                    goldPrices.Add(new GoldPrice(date, price));
                }
            }
            return goldPrices;
        }
    }


    public class GoldPrice {
        readonly DateTime date;
        readonly double price;

        public DateTime Date { get { return date; } }
        public double Price { get { return price; } }

        public GoldPrice(DateTime date, double price) {
            this.date = date;
            this.price = price;
        }
    }
}
