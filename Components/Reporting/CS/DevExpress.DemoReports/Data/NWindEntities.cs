using System.Data.Common;
using System.Data.Entity;
using System.Data.SQLite;
using System.IO;
using DevExpress.DemoData.Models.Mapping;
using DevExpress.Internal;

namespace DevExpress.DemoData.Models {
    public partial class NWindEntities : DbContext {
        static NWindEntities() {
            Database.SetInitializer<NWindEntities>(null);
        }
        public NWindEntities()
            : base(CreateConnection(GenerateConnectionString()), contextOwnsConnection: true) {
        }
        public NWindEntities(string connectionString)
            : base(CreateConnection(connectionString), contextOwnsConnection: true) {
        }
        static string filePath;
        static string GenerateConnectionString() {
            if(filePath == null)
                filePath = DataDirectoryHelper.GetFile("nwind.db", DataDirectoryHelper.DataFolderName);
            try {
                var attributes = File.GetAttributes(filePath);
                if(attributes.HasFlag(FileAttributes.ReadOnly)) {
                    File.SetAttributes(filePath, attributes & ~FileAttributes.ReadOnly);
                }
            } catch { }
            return new SQLiteConnectionStringBuilder { DataSource = filePath }.ConnectionString;
        }
        static DbConnection CreateConnection(string connectionString) {
            DbConnection connection = DbProviderFactories.GetFactory("System.Data.SQLite.EF6").CreateConnection();
            connection.ConnectionString = connectionString;
            return connection;
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder) {
            modelBuilder.Configurations.Add(new CategoryMap());
            modelBuilder.Configurations.Add(new EmployeeMap());
            modelBuilder.Configurations.Add(new ProductMap());
            modelBuilder.Configurations.Add(new SalesPersonMap());
        }
        public DbSet<SalesPerson> SalesPersons { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Employee> Employees { get; set; }
    }
}
