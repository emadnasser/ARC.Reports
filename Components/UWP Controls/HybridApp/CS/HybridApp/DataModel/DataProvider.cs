using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Serialization;
using HybridApp.Common;
using HybridApp.DataModel;
using HybridApp.HybridAppService;

namespace HybridApp {
    public class DataProvider {
        static DataProvider() {
            client = new DataProvider();
        }
        static DataProvider client;
        Dictionary<long, string> dict = new Dictionary<long, string>() {
                { 1, "DX-RX809.pdf" },
                { 2, "DX-RX800.pdf" },
                { 3, "DX-H5500.pdf" },
                { 4, "DX-H8800.pdf" },
                { 5, "DX-H7700.pdf" },
                { 6, "DX-H4500.pdf" },
                { 7, "DX-H4600.pdf" },
                { 8, "DX-B6000.pdf" },
                { 9, "DX-B5000.pdf" },
                { 10, "DX-A6000.pdf" },
                { 11, "DX-A5000.pdf" },
                { 12, "DX-H6000.pdf" },
                { 13, "DX-H5000.pdf" },
                { 14, "DX-XR650.pdf" },
                { 15, "DX-XR750.pdf" },
                { 16, "DX-XR650HT.pdf" },
                { 17, "DX-1200.pdf" },
                { 18, "DX-1300.pdf" },
                { 19, "DX-1400.pdf" },
            };
        public static DataProvider Client { get { return client; } }
        public IList<SummaryItem> GetSummaryOpportunitites() {
            return new SummaryItem[] {
                new SummaryItem() { StageName = "High", Summary = 46858576M},
                new SummaryItem() { StageName = "Medium", Summary = 33319172M},
                new SummaryItem() { StageName = "Low", Summary = 19247772M},
                new SummaryItem() { StageName = "Unlikely", Summary = 11774301M},
            };
        }
        public List<IEnumerable<CostAverageItem>> GetCostAverageItems() {
            List<IEnumerable<CostAverageItem>> costAverageItems = new List<IEnumerable<CostAverageItem>>();
            costAverageItems.Add(new CostAverageItem[] {
                new CostAverageItem() { Category = "VideoPlayers", Cost = 251.428571M },
                new CostAverageItem() { Category = "Projectors", Cost = 608.247422M },
                new CostAverageItem() { Category = "Televisions", Cost = 1645.261096M},
                new CostAverageItem() { Category = "Automation", Cost = 132.1875M },
                new CostAverageItem() { Category = "Monitors", Cost = 118.72093M },
            });
            costAverageItems.Add(new CostAverageItem[] {
                new CostAverageItem() { Category = "VideoPlayers", Cost = 247.5M },
                new CostAverageItem() { Category = "Projectors", Cost = 633.333333M },
                new CostAverageItem() { Category = "Televisions", Cost = 1525.819277M },
                new CostAverageItem() { Category = "Automation", Cost = 131M },
                new CostAverageItem() { Category = "Monitors", Cost = 115M },
            });
            costAverageItems.Add(new CostAverageItem[] {
                new CostAverageItem() { Category = "Televisions", Cost = 3050M },
                new CostAverageItem() { Category = "Automation", Cost = 105M },
            });
            return costAverageItems;
        }
        public List<IEnumerable<SalesSummaryItem>> GetSalesSummaryItems() {
            List<IEnumerable<SalesSummaryItem>> salesSummaryItems = new List<IEnumerable<SalesSummaryItem>>();
            salesSummaryItems.Add(new SalesSummaryItem[] {
                new SalesSummaryItem() { Category = "VideoPlayers", Sales = 1197825M },
                new SalesSummaryItem() { Category = "Projectors", Sales = 3577600M },
                new SalesSummaryItem() { Category = "Televisions", Sales = 9398869M },
                new SalesSummaryItem() { Category = "Automation", Sales = 845060M },
                new SalesSummaryItem() { Category = "Monitors", Sales = 803865M },
            });
            salesSummaryItems.Add(new SalesSummaryItem[] {
                new SalesSummaryItem() { Category = "VideoPlayers", Sales = 94340M },
                new SalesSummaryItem() { Category = "Projectors", Sales = 155200M },
                new SalesSummaryItem() { Category = "Televisions", Sales = 1051191M },
                new SalesSummaryItem() { Category = "Automation", Sales = 68820M },
                new SalesSummaryItem() { Category = "Monitors", Sales = 40230M },
            });
            salesSummaryItems.Add(new SalesSummaryItem[] {
                new SalesSummaryItem() { Category = "Televisions", Sales = 33100M },
                new SalesSummaryItem() { Category = "Automation", Sales = 4000M },
            });
            return salesSummaryItems;
        }
        public List<SalesInfo> GetSalesStatistics() {
            var salesInfoList = new SalesInfo[] {
                new SalesInfo() { Caption = "Sales (FY2011)", time = new DateTime(2011, 12, 11),
                    ListProductInfo = new List<SalesProductInfo>(new SalesProductInfo[] {
                        new SalesProductInfo() { Name = "Video Players", Value=231775 },
                        new SalesProductInfo() { Name = "Televisions",   Value=2276817 },
                        new SalesProductInfo() { Name = "Monitors",      Value=184655 },
                        new SalesProductInfo() { Name = "Projectors",    Value=694400 },
                        new SalesProductInfo() { Name = "Automation",    Value=183805 },
                    }),
                },
                new SalesInfo() { Caption = "Sales (FY2012)", time = new DateTime(2012, 12, 11),
                    ListProductInfo = new List<SalesProductInfo>(new SalesProductInfo[] {
                        new SalesProductInfo() { Name = "Video Players", Value=1069005 },
                        new SalesProductInfo() { Name = "Televisions",   Value=8532478 },
                        new SalesProductInfo() { Name = "Monitors",      Value=682875 },
                        new SalesProductInfo() { Name = "Projectors",    Value=3373100 },
                        new SalesProductInfo() { Name = "Automation",    Value=771180 },
                    }),
                },
                new SalesInfo() { Caption = "Sales (FY2013)", time = new DateTime(2013, 12, 11),
                    ListProductInfo = new List<SalesProductInfo>(new SalesProductInfo[] {
                        new SalesProductInfo() { Name = "Video Players", Value=1032375 },
                        new SalesProductInfo() { Name = "Televisions",   Value=10638070 },
                        new SalesProductInfo() { Name = "Monitors",      Value=837255 },
                        new SalesProductInfo() { Name = "Projectors",    Value=3299200 },
                        new SalesProductInfo() { Name = "Automation",    Value=965960 },
                    }),
                },
                new SalesInfo() { Caption = "Sales (FY2014)", time = new DateTime(2014, 12, 11),
                    ListProductInfo = new List<SalesProductInfo>(new SalesProductInfo[] {
                        new SalesProductInfo() { Name = "Video Players", Value=1197825 },
                        new SalesProductInfo() { Name = "Televisions",   Value=9398869 },
                        new SalesProductInfo() { Name = "Monitors",      Value=803865 },
                        new SalesProductInfo() { Name = "Projectors",    Value=3577600 },
                        new SalesProductInfo() { Name = "Automation",    Value=845060 },
                    }),
                },
            };
            return new List<SalesInfo>(salesInfoList);
        }
        public async Task<T> GetEntity<T>(long id) where T : class, new() {
            if(Windows.ApplicationModel.DesignMode.DesignModeEnabled)
                return DesignTimeEntityGenerator.CreateEntity<T>();
            await Task.Delay(1);
            object result = null;
            Type currentType = typeof(T);
            if(currentType == typeof(ProductCatalog))
                result = await GetProductCatalogsByProductIdAsync(id);
            return result as T;
        }
        async public Task<ProductCatalog> GetProductCatalogsByProductIdAsync(long productId) {
            string name = dict[productId];
            var folder = await Windows.ApplicationModel.Package.Current.InstalledLocation.GetFolderAsync("Resources");
            folder = await folder.GetFolderAsync("PDF");
            var file = await folder.GetFileAsync(name);
            var bytes = (await Windows.Storage.FileIO.ReadBufferAsync(file)).ToArray();
            return new ProductCatalog() { PDF = bytes };
        }

        Dictionary<Type, object> collectionCache = new Dictionary<Type, object>();

        public class DevAVDb {
            public ObservableCollection<Employee> Employees { get; set; }
            public ObservableCollection<Customer> Customers { get; set; }
            public ObservableCollection<Product> Products { get; set; }
            public ObservableCollection<Order> Orders { get; set; }
            public ObservableCollection<Quote> Quotes { get; set; }
            public ObservableCollection<EmployeeTask> EmployeeTasks { get; set; }

            public ObservableCollection<Evaluation> Evaluations { get; set; }
            public ObservableCollection<CustomerEmployee> CustomerEmployees { get; set; }
            public ObservableCollection<Crest> Crests { get; set; }
            public ObservableCollection<CustomerStore> CustomerStores { get; set; }
        }

        static DevAVDb LoadedDataBase = new DevAVDb();

        public void Delete<TEntity>(TEntity entity) where TEntity : class, new() {
            if(typeof(TEntity) == typeof(Employee)) {
                LoadedDataBase.Employees.Remove(entity as Employee);
            } else if(typeof(TEntity) == typeof(Customer)) {
                LoadedDataBase.Customers.Remove(entity as Customer);
            } else if(typeof(TEntity) == typeof(Product)) {
                LoadedDataBase.Products.Remove(entity as Product);
            } else if(typeof(TEntity) == typeof(Order)) {
                LoadedDataBase.Orders.Remove(entity as Order);
            } else if(typeof(TEntity) == typeof(Quote)) {
                LoadedDataBase.Quotes.Remove(entity as Quote);
            } else if(typeof(TEntity) == typeof(EmployeeTask)) {
                LoadedDataBase.EmployeeTasks.Remove(entity as EmployeeTask);
            } else if(typeof(TEntity) == typeof(Evaluation)) {
                LoadedDataBase.Evaluations.Remove(entity as Evaluation);
            } else if(typeof(TEntity) == typeof(CustomerEmployee)) {
                LoadedDataBase.CustomerEmployees.Remove(entity as CustomerEmployee);
            } else if(typeof(TEntity) == typeof(Crest)) {
                LoadedDataBase.Crests.Remove(entity as Crest);
            } else if(typeof(TEntity) == typeof(CustomerStore)) {
                LoadedDataBase.CustomerStores.Remove(entity as CustomerStore);
            }
        }
        public void Add<TEntity>(TEntity entity) where TEntity : class, new() {
            if(typeof(TEntity) == typeof(Employee)) {
                LoadedDataBase.Employees.Add(entity as Employee);
            } else if(typeof(TEntity) == typeof(Customer)) {
                LoadedDataBase.Customers.Add(entity as Customer);
            } else if(typeof(TEntity) == typeof(Product)) {
                LoadedDataBase.Products.Add(entity as Product);
            } else if(typeof(TEntity) == typeof(Order)) {
                LoadedDataBase.Orders.Add(entity as Order);
            } else if(typeof(TEntity) == typeof(Quote)) {
                LoadedDataBase.Quotes.Add(entity as Quote);
            } else if(typeof(TEntity) == typeof(EmployeeTask)) {
                LoadedDataBase.EmployeeTasks.Add(entity as EmployeeTask);
            } else if(typeof(TEntity) == typeof(Evaluation)) {
                LoadedDataBase.Evaluations.Add(entity as Evaluation);
            } else if(typeof(TEntity) == typeof(CustomerEmployee)) {
                LoadedDataBase.CustomerEmployees.Add(entity as CustomerEmployee);
            } else if(typeof(TEntity) == typeof(Crest)) {
                LoadedDataBase.Crests.Add(entity as Crest);
            } else if(typeof(TEntity) == typeof(CustomerStore)) {
                LoadedDataBase.CustomerStores.Add(entity as CustomerStore);
            }
        }
        public void Replace<TEntity>(TEntity oldValue, TEntity newValue) {
            int index = 0;
            if(typeof(TEntity) == typeof(Employee)) {
                index = LoadedDataBase.Employees.IndexOf(oldValue as Employee);
                if(index != -1)
                    LoadedDataBase.Employees[index] = newValue as Employee;
            } else if(typeof(TEntity) == typeof(Customer)) {
                index = LoadedDataBase.Customers.IndexOf(oldValue as Customer);
                if(index != -1)
                    LoadedDataBase.Customers[index] = newValue as Customer;
            } else if(typeof(TEntity) == typeof(Product)) {
                index = LoadedDataBase.Products.IndexOf(oldValue as Product);
                if(index != -1)
                    LoadedDataBase.Products[index] = newValue as Product;
            } else if(typeof(TEntity) == typeof(Order)) {
                index = LoadedDataBase.Orders.IndexOf(oldValue as Order);
                if(index != -1)
                    LoadedDataBase.Orders[index] = newValue as Order;
            } else if(typeof(TEntity) == typeof(Quote)) {
                index = LoadedDataBase.Quotes.IndexOf(oldValue as Quote);
                if(index != -1)
                    LoadedDataBase.Quotes[index] = newValue as Quote;
            } else if(typeof(TEntity) == typeof(EmployeeTask)) {
                index = LoadedDataBase.EmployeeTasks.IndexOf(oldValue as EmployeeTask);
                if(index != -1)
                    LoadedDataBase.EmployeeTasks[index] = newValue as EmployeeTask;
            } else if(typeof(TEntity) == typeof(Evaluation)) {
                index = LoadedDataBase.Evaluations.IndexOf(oldValue as Evaluation);
                if(index != -1)
                    LoadedDataBase.Evaluations[index] = newValue as Evaluation;
            } else if(typeof(TEntity) == typeof(CustomerEmployee)) {
                index = LoadedDataBase.CustomerEmployees.IndexOf(oldValue as CustomerEmployee);
                if(index != -1)
                    LoadedDataBase.CustomerEmployees[index] = newValue as CustomerEmployee;
            } else if(typeof(TEntity) == typeof(Crest)) {
                index = LoadedDataBase.Crests.IndexOf(oldValue as Crest);
                if(index != -1)
                    LoadedDataBase.Crests[index] = newValue as Crest;
            } else if(typeof(TEntity) == typeof(CustomerStore)) {
                index = LoadedDataBase.CustomerStores.IndexOf(oldValue as CustomerStore);
                if(index != -1)
                    LoadedDataBase.CustomerStores[index] = newValue as CustomerStore;
            }
        }
        public async Task DeserializeAllData() {
            if(Windows.ApplicationModel.DesignMode.DesignModeEnabled) return;
            var serializer = new XmlSerializer(typeof(DevAVDb));
            var folder = await Windows.ApplicationModel.Package.Current.InstalledLocation.GetFolderAsync("Resources");
            var file = await folder.GetFileAsync("DevAVDb.xml");
            Stream stream = await file.OpenStreamForReadAsync();
            LoadedDataBase = (DevAVDb)serializer.Deserialize(stream);
            stream.Dispose();
            CombineDataBase();
        }
        async void CombineDataBase() {
            SetPicturesAsync(LoadedDataBase.Employees, e => e.PictureId, (e, p) => { e.Picture = p; });
            foreach(var crest in LoadedDataBase.Crests) {
                crest.LargeImage = await GetPicture(crest.Id, "Crests");
            }
            foreach(var product in LoadedDataBase.Products) {
                product.Image = await GetPicture(product.PrimaryImageId, "Products");
            }
            foreach(var customerStore in LoadedDataBase.CustomerStores) {
                customerStore.Crest = LoadedDataBase.Crests.FirstOrDefault(c => c.Id == customerStore.CrestId);
            }
            foreach(var order in LoadedDataBase.Orders) {
                order.Store = LoadedDataBase.CustomerStores.FirstOrDefault(s => s.Id == order.StoreId);
                order.Customer = LoadedDataBase.Customers.FirstOrDefault(c => c.Id == order.CustomerId);
            }
            foreach(var evaluation in LoadedDataBase.Evaluations) {
                evaluation.Employee = LoadedDataBase.Employees.FirstOrDefault(e => e.Id == evaluation.EmployeeId);
                evaluation.CreatedBy = LoadedDataBase.Employees.FirstOrDefault(e => e.Id == evaluation.CreatedById);
            }
            SetPicturesAsync(LoadedDataBase.CustomerEmployees, cu => cu.PictureId, (cu, p) => { cu.Picture = p; });
            foreach(var customerEmployee in LoadedDataBase.CustomerEmployees) {
                customerEmployee.CustomerStore = LoadedDataBase.CustomerStores.FirstOrDefault(cs => cs.Id == customerEmployee.CustomerStoreId);
            }
            foreach(var task in LoadedDataBase.EmployeeTasks) {
                task.AssignedEmployee = LoadedDataBase.Employees.FirstOrDefault(e => e.Id == task.AssignedEmployeeId);
                task.Owner = LoadedDataBase.Employees.FirstOrDefault(e => e.Id == task.OwnerId);
                task.CustomerEmployee = LoadedDataBase.CustomerEmployees.FirstOrDefault(e => e.Id == task.CustomerEmployeeId);
            }
            foreach(var quote in LoadedDataBase.Quotes) {
                quote.CustomerStore = LoadedDataBase.CustomerStores.FirstOrDefault(cs => cs.Id == quote.CustomerStoreId);
            }
        }
        Task deserializeAllDataTask;
        public async Task<ObservableCollection<T>> GetCollection<T>(CancellationToken? cancellationToken = null) where T : class, new() {
            if(deserializeAllDataTask == null)
                deserializeAllDataTask = DeserializeAllData();
            await deserializeAllDataTask;
            if(typeof(T) == typeof(Employee)) {
                return LoadedDataBase.Employees as ObservableCollection<T>;
            }
            if(typeof(T) == typeof(Customer)) {
                return LoadedDataBase.Customers as ObservableCollection<T>;
            }
            if(typeof(T) == typeof(Product)) {
                return LoadedDataBase.Products as ObservableCollection<T>;
            }
            if(typeof(T) == typeof(Crest)) {
                return LoadedDataBase.Crests as ObservableCollection<T>;
            }
            if(typeof(T) == typeof(CustomerStore)) {
                return LoadedDataBase.CustomerStores as ObservableCollection<T>;
            }
            if(typeof(T) == typeof(Order)) {
                return LoadedDataBase.Orders as ObservableCollection<T>;
            }
            if(typeof(T) == typeof(Evaluation)) {
                return LoadedDataBase.Evaluations as ObservableCollection<T>;
            }
            if(typeof(T) == typeof(CustomerEmployee)) {
                return LoadedDataBase.CustomerEmployees as ObservableCollection<T>;
            }
            if(typeof(T) == typeof(EmployeeTask)) {
                return LoadedDataBase.EmployeeTasks as ObservableCollection<T>;
            }
            if(typeof(T) == typeof(Quote)) {
                return LoadedDataBase.Quotes as ObservableCollection<T>;
            }
            return new ObservableCollection<T>();
        }
        async void SetPicturesAsync<T>(ObservableCollection<T> source, Func<T, long?> getPictureId, Action<T, byte[]> setPicture, string subDirectory = "") {
            foreach(var entity in source) {
                if(getPictureId(entity) == null) {
                    setPicture(entity, new byte[0]);
                    continue;
                }
                var bytes = await GetPicture(getPictureId(entity), subDirectory);
                setPicture(entity, bytes);
            }
        }
        static async Task<byte[]> GetPicture(long? id, string subDirectory = "") {
            string uri2 = @"{0}.jpg";
            var folder = await Windows.ApplicationModel.Package.Current.InstalledLocation.GetFolderAsync("Resources");
            folder = await folder.GetFolderAsync("ImageCache");
            if(!string.IsNullOrEmpty(subDirectory))
                folder = await folder.GetFolderAsync(subDirectory);
            if(subDirectory == "Products")
                uri2 = @"{0}.png";
            var file = await folder.GetFileAsync(string.Format(uri2, id));
            var bytes = (await Windows.Storage.FileIO.ReadBufferAsync(file)).ToArray();
            return bytes;
        }
    }
}
