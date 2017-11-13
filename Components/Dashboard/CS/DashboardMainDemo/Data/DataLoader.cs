using System.Collections.Generic;
using System.Data;
using System;
using DevExpress.Utils;

namespace DashboardMainDemo {
    public static class DataLoader {
        static string GetRelativePath(string name) {
            name = "Data\\" + name;
            string path = System.Windows.Forms.Application.StartupPath;
            string s = "\\";
            for(int i = 0; i <= 10; i++) {
                if(System.IO.File.Exists(path + s + name))
                    return (path + s + name);
                else
                    s += "..\\";
            }
            path = Environment.CurrentDirectory;
            s = "\\";
            for(int i = 0; i <= 10; i++) {
                if(System.IO.File.Exists(path + s + name))
                    return (path + s + name);
                else
                    s += "..\\";
            }
            return "";
        }
        static string GetDirectoryRelativePath(string directoryName) {
            directoryName = "Data\\" + directoryName;
            string path = System.Windows.Forms.Application.StartupPath;
            string s = "\\";
            for(int i = 0; i <= 10; i++) {
                if(System.IO.Directory.Exists(path + s + directoryName))
                    return (path + s + directoryName);
                else
                    s += "..\\";
            }
            path = Environment.CurrentDirectory;
            s = "\\";
            for(int i = 0; i <= 10; i++) {
                if(System.IO.Directory.Exists(path + s + directoryName))
                    return (path + s + directoryName);
                else
                    s += "..\\";
            }
            return "";
        }
        static DataSet LoadData(string fileName) {
            string path = GetRelativePath(string.Format("{0}.xml", fileName));
            DataSet ds = new DataSet();
            ds.ReadXml(path, XmlReadMode.ReadSchema);
            return ds;
        }
        public static DataSet LoadSales() {
            return LoadData("DashboardSales");
        }
        public static DataSet LoadEmployees() {
            return LoadData("DashboardEmployeesAndDepartments");
        }
        public static DataSet LoadCustomerSupport() {
            return LoadData("DashboardCustomerSupport");
        }
        public static DataSet LoadRevenueByIndustry() {
            return LoadData("DashboardRevenueByIndustry");
        }
        public static DataSet LoadEuroEnergyStatistics() {
            return LoadData("DashboardEnergyStatictics");
        }
        public static DataSet LoadEnergyConsumptionTotal() {
            return LoadData("DashboardEnergyConsumptionTotal");
        }
        public static DataSet LoadEnergyConsumptionBySector() {
            return LoadData("DashboardEnergyConsumptionBySector");
        }
        public static DataSet LoadChampionsLeagueStatistics() {
            return LoadData("DashboardChampionsLeagueStatistics");
        }
        public static string GetProductDetailsXmlDataSource() {
            return GetRelativePath(String.Format("{0}.xml", "DashboardProductDetails"));
        }
        public static string GetImagesFolder() {
            return GetDirectoryRelativePath("ProductDetailsImages");
        }
        public static string GetEUTradeOverviewDataExtractPath() {
            return GetRelativePath(String.Format("{0}.dat", "EUTradeOverview"));
        }
    }
}
