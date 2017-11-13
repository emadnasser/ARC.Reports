using System.Collections.Generic;
using System.Data;
using System;
using DevExpress.Utils;
using System.IO;
using System.Web.Hosting;
using System.Configuration;
using DevExpress.DashboardWeb;

namespace DashboardMainDemo {
    public static class DataLoader {
        static string GetRelativePath(string name) {
            return Path.Combine(HostingEnvironment.MapPath("~"), "App_Data", "Data", name);
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
            return GetRelativePath("ProductDetailsImages");
        }

        public static void LoadData(DataLoadingWebEventArgs e) {
            switch(e.DashboardId) {
                case "WebsiteStatistics":
                    WebsiteStatisticsDataGenerator data = new WebsiteStatisticsDataGenerator();
                    e.Data = data.WebsiteStatistics;
                    break;
                case "SalesPerformance":
                    SalesPerformanceDataGenerator dataGenerator = new SalesPerformanceDataGenerator(LoadSales());
                    dataGenerator.Generate();
                    if(e.DataSourceComponentName == "dsMonthlySales")
                        e.Data = dataGenerator.MonthlySales;
                    else if(e.DataSourceComponentName == "dsTotalSales")
                        e.Data = dataGenerator.TotalSales;
                    else if(e.DataSourceComponentName == "dsKeyMetrics")
                        e.Data = dataGenerator.KeyMetrics;
                    break;
                case "HumanResources":
                    HumanResourcesData humanResourcesData = new HumanResourcesData(LoadEmployees());
                    if(e.DataSourceComponentName == "dsEmployees")
                        e.Data = humanResourcesData.EmployeeData;
                    else if(e.DataSourceComponentName == "dsDepartments")
                        e.Data = humanResourcesData.DepartmentData;
                    break;
                case "EnergyStatistics":
                    e.Data = EnergyStaticticsDataHelper.Generate(LoadEuroEnergyStatistics());
                    break;
                case "SalesOverview":
                    SalesOverviewDataGenerator salesOverviewDataGenerator = new SalesOverviewDataGenerator(LoadSales());
                    salesOverviewDataGenerator.Generate();
                    e.Data = salesOverviewDataGenerator.Data;
                    break;
                case "SalesDetails":
                    SalesDetailsDataGenerator salesDetailsDataGenerator = new SalesDetailsDataGenerator(LoadSales());
                    salesDetailsDataGenerator.Generate();
                    e.Data = salesDetailsDataGenerator.Data;
                    break;
                case "RevenueByIndustry":
                    e.Data = RevenueByIndustryDataHelper.Generate(LoadRevenueByIndustry());
                    break;
                case "ChampionsLeagueStatistics":
                    e.Data = ChampionsLeagueStatisticsDataHelper.Generate(LoadChampionsLeagueStatistics());
                    break;
                case "RevenueAnalysis":
                    RevenueAnalysisDataGenerator revenueAnalysisDataGenerator = new RevenueAnalysisDataGenerator(LoadSales());
                    revenueAnalysisDataGenerator.Generate();
                    e.Data = revenueAnalysisDataGenerator.Data;
                    break;
                case "CustomerSupport":
                    CustomerSupportData customerSupportData = new CustomerSupportData(LoadCustomerSupport(), LoadEmployees());
                    e.Data = customerSupportData.CustomerSupport;
                    break;
                case "EnergyConsumption":
                    if(e.DataSourceComponentName == "dsConsumptionTotal")
                        e.Data = EnergyConsumptionDataHelper.GenerateTotal(LoadEnergyConsumptionTotal());
                    else if(e.DataSourceComponentName == "dsConsumptionBySector")
                        e.Data = EnergyConsumptionDataHelper.GenerateBySector(LoadEnergyConsumptionBySector());
                    break;
            }
        }
    }
}
