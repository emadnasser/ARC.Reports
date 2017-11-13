using System;
using System.Data.OleDb;
using System.Windows.Forms;
using DevExpress.Utils;
using DevExpress.Demos.DataSources;
using SnapDemos.nwindDataSetTableAdapters;
using SnapDemos.temperatureStatisticsDataSetTableAdapters;

namespace SnapDemos.Modules {
    public interface ISnapDataProvider {
        object GetDataSource();
    }
    public abstract class NorthwindDataProvider : ISnapDataProvider {
        protected virtual string DataMember { get { return string.Empty; } }
        public object GetDataSource() {
            string path = FilesHelper.FindingFileName(AppDomain.CurrentDomain.BaseDirectory, @"Data\nwind.mdb", false);
            var dataSource = new nwindDataSet();
            var connection = new OleDbConnection();
            connection.ConnectionString = string.Format(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0}", path);

            FillDataSource(connection, dataSource);

            var bindingSource = new BindingSource();
            bindingSource.DataSource = dataSource;
            bindingSource.DataMember = DataMember;
            return bindingSource;
        }
        protected abstract void FillDataSource(OleDbConnection connection, nwindDataSet dataSource);
    }
    public class APIDataProvider : NorthwindDataProvider {
        protected override string DataMember { get { return "Categories"; } }
        protected override void FillDataSource(OleDbConnection connection, nwindDataSet dataSource) {
            CategoriesTableAdapter categories = new CategoriesTableAdapter();
            categories.Connection = connection;
            categories.Fill(dataSource.Categories);

            ProductsTableAdapter products = new ProductsTableAdapter();
            products.Connection = connection;
            products.Fill(dataSource.Products);

            Order_DetailsTableAdapter orderDetails = new Order_DetailsTableAdapter();
            orderDetails.Connection = connection;
            orderDetails.Fill(dataSource.Order_Details);
        }
    }
    public class CalculatedFieldsDataProvider : NorthwindDataProvider {
        protected override string DataMember { get { return "OrderReports"; } }
        protected override void FillDataSource(OleDbConnection connection, nwindDataSet dataSource) {
            var orderReportsTableAdapter = new OrderReportsTableAdapter();
            orderReportsTableAdapter.Connection = connection;
            orderReportsTableAdapter.Fill(dataSource.OrderReports);
        }
    }
    public class ChartsDataProvider : NorthwindDataProvider {
        protected override string DataMember { get { return "Suppliers"; } }
        protected override void FillDataSource(OleDbConnection connection, nwindDataSet dataSource) {
            var suppliersTableAdapter = new SuppliersTableAdapter();
            suppliersTableAdapter.Connection = connection;
            suppliersTableAdapter.Fill(dataSource.Suppliers);

            var products = new ProductsTableAdapter();
            products.Connection = connection;
            products.Fill(dataSource.Products);

            var orderDetails = new Order_DetailsTableAdapter();
            orderDetails.Connection = connection;
            orderDetails.Fill(dataSource.Order_Details);
        }
    }
    public class EventsDataProvider : NorthwindDataProvider {
        protected override string DataMember { get { return "Categories"; } }
        protected override void FillDataSource(OleDbConnection connection, nwindDataSet dataSource) {
            CategoriesTableAdapter categories = new CategoriesTableAdapter();
            categories.Connection = connection;
            categories.Fill(dataSource.Categories);

            ProductsTableAdapter products = new ProductsTableAdapter();
            products.Connection = connection;
            products.Fill(dataSource.Products);

            Order_DetailsTableAdapter orderDetails = new Order_DetailsTableAdapter();
            orderDetails.Connection = connection;
            orderDetails.Fill(dataSource.Order_Details);
        }
    }
    public class MultiColumnReportDataProvider : NorthwindDataProvider {
        protected override string DataMember { get { return "Customers"; } }
        protected override void FillDataSource(OleDbConnection connection, nwindDataSet dataSource) {
            var customersTableAdapter = new CustomersTableAdapter();
            customersTableAdapter.Connection = connection;
            customersTableAdapter.Fill(dataSource.Customers);
        }
    }
    public class MailMergeReportsDataProvider : NorthwindDataProvider {
        protected override string DataMember { get { return "CustomerOrders"; } }
        protected override void FillDataSource(OleDbConnection connection, nwindDataSet dataSource) {
            var customerOrdersTableAdapter = new CustomerOrdersTableAdapter();
            customerOrdersTableAdapter.Connection = connection;
            customerOrdersTableAdapter.Fill(dataSource.CustomerOrders);

            var orderReportsTableAdapter = new OrderReportsTableAdapter();
            orderReportsTableAdapter.Connection = connection;
            orderReportsTableAdapter.Fill(dataSource.OrderReports);
        }
    }
    public class FormattedFieldsDataProvider : ISnapDataProvider {
        public object GetDataSource() {
            return DataSourceHelper.GetDataSouresFromXml<HtmlTag>("HtmlTags.xml", "HtmlTags");
        }
    }
    public class SparklineDataProvider : ISnapDataProvider {
        public object GetDataSource() {
            string path = FilesHelper.FindingFileName(AppDomain.CurrentDomain.BaseDirectory, @"Data\temperatureStatistics.mdb", false);
            var dataSource = new temperatureStatisticsDataSet();
            var connection = new OleDbConnection();
            connection.ConnectionString = string.Format(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0}", path);

            var cityTableAdapter = new CityTableAdapter();
            cityTableAdapter.Connection = connection;
            cityTableAdapter.Fill(dataSource.City);

            var yearInfoTableAdapter = new YearInfoTableAdapter();
            yearInfoTableAdapter.Connection = connection;
            yearInfoTableAdapter.Fill(dataSource.YearInfo);

            var temperatureTableAdapter = new TemperatureTableAdapter();
            temperatureTableAdapter.Connection = connection;
            temperatureTableAdapter.Fill(dataSource.Temperature);

            var monthInfoTableAdapter = new MonthInfoTableAdapter();
            monthInfoTableAdapter.Connection = connection;
            monthInfoTableAdapter.Fill(dataSource.MonthInfo);

            var bindingSource = new BindingSource();
            bindingSource.DataSource = dataSource;
            bindingSource.DataMember = "City";
            return bindingSource;
        }
    }
    public class IListDatasourceProvider : ISnapDataProvider {
        public object GetDataSource() {
            return FishesSource.Data;
        }
    }
}
