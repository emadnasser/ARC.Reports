namespace DevExpress.MVVM.Demos.DataBase {
    using System.Data.Common;
    using System.Data.Entity;
    using System.Data.SQLite;
    using System.IO;
    using DevExpress.Internal;
    using DevExpress.MVVM.Demos.Model;

    public class ExpensesDbContext : DbContext {
        public ExpensesDbContext() : base(CreateConnection(), true) { }
        public ExpensesDbContext(string connectionString) : base(connectionString) { }
        public ExpensesDbContext(DbConnection connection) : base(connection, true) { }
        static ExpensesDbContext() {
            Database.SetInitializer<ExpensesDbContext>(null);
        }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        //
        static string filePath;
        static DbConnection CreateConnection() {
            filePath = filePath ?? DataDirectoryHelper.GetFile("expenses.sqlite3", DataDirectoryHelper.DataFolderName);
            try { File.SetAttributes(filePath, File.GetAttributes(filePath) & ~FileAttributes.ReadOnly); }
            catch { }
            var connection = DbProviderFactories.GetFactory("System.Data.SQLite.EF6").CreateConnection();
            connection.ConnectionString = new SQLiteConnectionStringBuilder { DataSource = filePath }.ConnectionString;
            return connection;
        }
    }
}
