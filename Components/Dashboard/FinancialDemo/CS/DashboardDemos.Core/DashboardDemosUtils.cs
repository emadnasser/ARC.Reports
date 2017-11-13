using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Linq;
using System.Data.SqlClient;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using DevExpress.DemoData.Helpers;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
using Microsoft.Win32;

namespace DashboardDemos.Core {
    public class SqlServerNotFoundException : Exception {
        public SqlServerNotFoundException(Exception ex)
            : base(ex.Message, ex) {
        }
    }
    public class DatabaseCreatingException : Exception {
        public DatabaseCreatingException(Exception ex)
            : base(ex.Message, ex) {
        }
    }
    public class DashboardInfo{
        public int Id { get; set; }
        public string Name { get; set; }
        public string XmlFileName { get; set; }        
        public override string ToString() {
            return Name;
        }
    }
    public class DatabaseInfo {
        public int Id { get; set; }
        public int RequiredVersion { get; set; }
        public string Name { get; set; }
        public string ConnectionString { get; set; }
        public string SqlScriptFile { get; set; }
        public Action<string,string, IDbConnection> FillAction { get; set; }
        
        public DatabaseInfo(Action<string, string, IDbConnection> action) {
            FillAction = action;
        }

        public override string ToString() {
            return Name;
        }
    }
    public static class DashboardDemosUtils {
        static DatabaseInfo[] AllDatabases(params string[] connectionStrings) {
            return new DatabaseInfo[] {
                new DatabaseInfo (FillDashboardDatabase) {
                    Id = 1,
                    Name = "DashboardStorage",
                    ConnectionString = connectionStrings[0],
                    SqlScriptFile ="DashboardDemo.sql",
                    
                    RequiredVersion =  3 },
                new DatabaseInfo(FillFinanceDatabase) {
                    Id = 2,
                    Name  = "FinancialDemo",
                    ConnectionString = connectionStrings[1],
                    SqlScriptFile= "FinancialDemo.sql",                    
                    RequiredVersion =  1}
                };
        }

        readonly static object lockObj = new object();
        static int databaseCreationCurrentStep;        
        static int databaseCreationMaxStep;

        public static int DatabaseCreationMaxStep { get { return databaseCreationMaxStep; } set { databaseCreationMaxStep = value; } }
        public static int DatabaseCreationCurrentStep {
            get {
                lock(lockObj)
                    return databaseCreationCurrentStep;
            }
            private set {
                lock(lockObj)
                    databaseCreationCurrentStep = value;
            }
        }
        public static string DashboardStorageConnectionString {
            get {
                string connectionString = ConfigurationManager.ConnectionStrings["DashboardStorageConnectionString"].ToString();
                return CheckAndApplyDefaultServerName(connectionString);
            }
        }
        public static string FinancialDemoConnectionString {
            get {
                string connectionString = ConfigurationManager.ConnectionStrings["FinanceDemoConnectionString"].ToString();
                return CheckAndApplyDefaultServerName(connectionString);
            }
        }
        public static string CorporateDemoConnectionString {
            get {
                string connectionString = ConfigurationManager.ConnectionStrings["CorporateDemoConnectionString"].ToString();
                return CheckAndApplyDefaultServerName(connectionString);
            }
        }
        public static void IncrementDatabaseCreationState() {
            lock(lockObj){
                databaseCreationCurrentStep++;
            }
        }

        public static MemoryStream GetDashboardStream(string connectionString, int dashboardId) {
            using(DashboardDemosDataContext db = new DashboardDemosDataContext(connectionString)) {
                var stream = (from t in db.Dashboards
                                       where t.ID == dashboardId
                                       select t.DashboardStream).First();
                byte[] dashboardArray = stream.ToArray();
                MemoryStream ms = new MemoryStream(dashboardArray);
                ms.Seek(0, SeekOrigin.Begin);
                return ms;
            }
        }
        public static void SaveDashboardStream(string connectionString, MemoryStream ms, int dashboardId) {
            using(DashboardDemosDataContext db = new DashboardDemosDataContext(connectionString)) {
                Dashboards storedDashboard = (from t in db.Dashboards
                                                   where t.ID == dashboardId
                                                   select t).First();
                ms.Seek(0, SeekOrigin.Begin);
                storedDashboard.DashboardStream = new Binary(ms.ToArray());
                db.SubmitChanges();
            }
        }
        public static bool ShouldRecreateDatabases(List<DatabaseInfo> databasesToCreate) {
            List<DatabaseInfo> databases = new List<DatabaseInfo>();
            foreach(DatabaseInfo info in AllDatabases(DashboardStorageConnectionString, FinancialDemoConnectionString))
                if(ShouldRecreateDatabase(info))
                    databases.Add(info);

            if (databasesToCreate != null) {
                databasesToCreate.Clear();
                databasesToCreate.AddRange(databases);
            }
            DatabaseCreationMaxStep = databases.Count * 3;
            return databases.Count > 0;
        }
        public static bool ShouldRecreateDatabase(DatabaseInfo databaseInfo) {
            SqlConnectionStringBuilder sb = new SqlConnectionStringBuilder(databaseInfo.ConnectionString);
            string databaseName = sb.InitialCatalog;
            sb.InitialCatalog = "";
            using (SqlConnection cn = new SqlConnection(sb.ConnectionString)) {
                try {
                    cn.Open();
                    bool databaseExists = CheckIsDatabaseExist(cn, databaseName);
                    int dataBaseVersion = GetDatabaseVersion(cn, databaseName);
                    if (!databaseExists || dataBaseVersion < databaseInfo.RequiredVersion)
                        return true;
                }
                catch (SqlException ex) {
                    throw new SqlServerNotFoundException(ex);
                }
                finally {
                    cn.Close();
                }
            }
            return false;
        }
        public static bool CreateDatabasesWin(params string[] connectionStrings) {
            string dashboardStorageConnectionString = connectionStrings[0];
            List<DatabaseInfo> databasesToCreate = new List<DatabaseInfo>();
            string serverName = GetServerName(dashboardStorageConnectionString);
            try {
                if (ShouldRecreateDatabases(databasesToCreate)) {                    
                    if (XtraMessageBox.Show(string.Format("Do you wish to create sample databases?\r\nThey will be created on the {0} server. To change the server, answer 'No', specify the server name within connection strings in the connections.config file, and run the demo again.", serverName),
                                               "Financial Dashboard", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
                        SplashScreenManager.ShowForm(typeof(CreateDatabaseWaitForm));
                        try {
                            DashboardDemosUtils.CreateDatabases(AppDomain.CurrentDomain.BaseDirectory, "Data", databasesToCreate);
                        }
                        finally {
                            SplashScreenManager.CloseForm();
                        }
                        return true;
                    }
                    return false;
                }
                return true;
            }
            catch (Exception ex) {         
                using (ErrorForm form = new ErrorForm(serverName, ex)) {
                    form.ShowDialog();
                    return false;
                }
            }
        }

        public static void CreateDatabasesWeb(string dataFolder, params string[] connectionStrings) {
            List<DatabaseInfo> databasesToCreate = AllDatabases(connectionStrings).Where(db => ShouldRecreateDatabase(db)).ToList();
            if (databasesToCreate.Count > 0) {
                DashboardDemosUtils.CreateDatabases(dataFolder, "App_Data", databasesToCreate);
            }
        }
        public static void CreateDatabases(string rootFolder, string dataFolder, List<DatabaseInfo> databasesToCreate) {                        
            foreach (var databaseInfo in databasesToCreate) {
                SqlConnectionStringBuilder dashboardStorageStringBuilder = new SqlConnectionStringBuilder(databaseInfo.ConnectionString);
                string databaseName = dashboardStorageStringBuilder.InitialCatalog;
                dashboardStorageStringBuilder.InitialCatalog = "";                
                using (SqlConnection cn = new SqlConnection(dashboardStorageStringBuilder.ConnectionString)) {
                    try {
                        cn.Open();
                        IncrementDatabaseCreationState();
                        if (CheckIsDatabaseExist(cn, databaseName))
                            DropDatabase(cn, databaseName);
                        ExecuteCommand(cn, string.Format("create database [{0}]", databaseName));
                        ExecuteCommand(cn, string.Format("Use [{0}]", databaseName));                        
                        ExecuteScript(cn, FilesHelper.FindingFileName(rootFolder, string.Format(@"{0}\{1}", dataFolder, databaseInfo.SqlScriptFile), false));
                        ExecuteCommand(cn, string.Format("insert into [dbo].[Info]  values( {0})", databaseInfo.RequiredVersion));
                        IncrementDatabaseCreationState();
                        var action = databaseInfo.FillAction;
                        action(rootFolder, dataFolder, cn);
                        IncrementDatabaseCreationState();
                    }
                    catch (SqlException ex) {
                        throw new DatabaseCreatingException(ex);
                    }
                    finally {
                        cn.Close();
                    }
                }
            }

        }
        public static string CreateConnectionString(string serverName, string userName, string password, bool useWindowsAuth) {
            string connectionString;
            if(useWindowsAuth)                
                connectionString = string.Format("Data Source={0};Integrated Security=True", serverName);
            else
                connectionString = string.Format("Data Source={0};User ID={1};Password={2}", serverName, userName, password);
            return connectionString;
        }
        static string CheckAndApplyDefaultServerName(string connectionString) {
            SqlConnectionStringBuilder sb = new SqlConnectionStringBuilder(connectionString);
            string serverName = sb.DataSource;            
            if(string.IsNullOrEmpty(serverName)) {
                serverName = DbEngineDetector.GetSqlServerInstanceName();
                if(!string.IsNullOrEmpty(serverName)) {
                    sb.DataSource = serverName;
                    return sb.ConnectionString;
                }
                return string.Empty;
            }
            return connectionString;
        }        
        static string GetServerName(string connectionString) {
            SqlConnectionStringBuilder sb = new SqlConnectionStringBuilder(connectionString);
            return sb.DataSource;            
        }
        static void FillDashboardDatabase(string rootFolder, string dataFolder, IDbConnection connection) {
            DashboardInfo[] dashboardInfos = {
                new DashboardInfo() {
                    Id = 1,
                    Name ="Finance Dashboard",
                    XmlFileName ="FinancialDashboard.xml" }
            };
            using(DashboardDemosDataContext db = new DashboardDemosDataContext(connection)) {
                foreach (var dashboardInfo in dashboardInfos) {
                    byte[] dashboardData = File.ReadAllBytes(FilesHelper.FindingFileName(rootFolder, string.Format(@"{0}\{1}", dataFolder, dashboardInfo.XmlFileName), false));
                    db.Dashboards.InsertOnSubmit(new Dashboards() { ID = dashboardInfo.Id, Name = dashboardInfo.Name, DashboardStream = dashboardData });
                }
                db.SubmitChanges();
            }
        }
        static void FillFinanceDatabase(string rootFolder, string dataFolder, IDbConnection connection) {            
            using(FinancialDemoDataContext dc = new FinancialDemoDataContext(connection)) {
                dc.CommandTimeout = 0;
                using(StreamReader sr = new StreamReader(FilesHelper.FindingFileName(rootFolder, string.Format(@"{0}\FinancialDemoDailyData.csv", dataFolder), false))) {
                    NumberFormatInfo fi = new NumberFormatInfo();
                    fi.NumberDecimalSeparator = ".";
                    string line = sr.ReadLine();
                    while(line != null) {
                        string[] columns = line.Split('\t');
                        DateTime dateTime = DateTime.ParseExact(columns[0], "yyyy-MM-dd", CultureInfo.InvariantCulture);
                        double open = Double.Parse(columns[1], fi);
                        double high = Double.Parse(columns[2], fi);
                        double low = Double.Parse(columns[3], fi);
                        double close = Double.Parse(columns[4], fi);
                        int volume = Int32.Parse(columns[5]);
                        string ticker = columns[6];
                        dc.DailyDatas.InsertOnSubmit(new DailyData() { Date = dateTime, Open = open, High = high, Low = low, Close = close, Volume = volume, Ticker = ticker });
                        line = sr.ReadLine();
                    }
                    dc.SubmitChanges();
                    dc.UpdateHistoricalData();
                    dc.CalculateProfitLoss();
                }
            }
        }
        static void DropDatabase(SqlConnection cn, string databaseName) {            
            ExecuteCommand(cn, "USE [master]");
            string sql = string.Format("ALTER DATABASE [{0}] SET SINGLE_USER WITH ROLLBACK IMMEDIATE", databaseName);
            ExecuteCommand(cn, sql);
            sql = string.Format("drop database [{0}]", databaseName);
            ExecuteCommand(cn, sql);
        }
        static int GetDatabaseVersion(SqlConnection cn, string databaseName) {
            string sql = string.Format("select DataVersion from {0}.dbo.Info", databaseName);
            using (SqlCommand cmd = new SqlCommand(sql, cn) { CommandType = CommandType.Text }) {
                try {
                    using (SqlDataReader dataReader = cmd.ExecuteReader()) {
                        try {
                            if (dataReader.Read())
                                return (int)dataReader[0];
                        }
                        finally {
                            dataReader.Close();
                        }
                    }
                }
                catch {
                }
            }
            return 0;
        }
        static bool CheckIsDatabaseExist(SqlConnection cn, string databaseName) {
            string sql = "SELECT name FROM master.sys.databases WHERE name NOT IN ('master', 'tempdb', 'model', 'msdb')";
            using (SqlCommand cmd = new SqlCommand(sql, cn) { CommandType = CommandType.Text }) {
                using (SqlDataReader dataReader = cmd.ExecuteReader()) {
                    try {
                        while (dataReader.Read()) {
                            if (dataReader[0].ToString() == databaseName)
                                return true;
                        }
                    }
                    catch (SqlException) {
                        return false;
                    }
                    finally {
                        dataReader.Close();
                    }
                }
            }
            return false;
        }
        static void ExecuteScript(SqlConnection cn, string fileName) {
            string sql = null;
            using(StreamReader sr = new StreamReader(fileName)) {
                sql = sr.ReadToEnd();
            }
            string[] batches = sql.Split(new string[] { "GO\r\n\r\n" }, StringSplitOptions.None);
            foreach(string batch in batches)
                ExecuteCommand(cn, batch);
        }
        static void ExecuteCommand(SqlConnection cn, string sql) {
            if(!string.IsNullOrEmpty(sql))
                using(SqlCommand command = new SqlCommand(sql, cn)) {
                    command.CommandType = CommandType.Text;
                    command.ExecuteNonQuery();
                }
        }
    }
}
