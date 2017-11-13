using DevExpress.Data.Filtering;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Dashboards;
using DevExpress.ExpressApp.EF;
using DevExpress.ExpressApp.Localization;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl.EF;
using DevExpress.Persistent.BaseImpl.EF.Kpi;
using System;
using System.ComponentModel;
using System.Data.Common;
using System.Data.Entity.Core.EntityClient;
using System.IO;
using System.Reflection;
using XCRM.Module.Data;

namespace XCRM.Module {
    public class DatabaseDataGenerator {
        public const string DatabaseScriptFileName = "DataScript.sql";
        public const string DisableTableContraintTemplate = @"ALTER TABLE {0} NOCHECK CONSTRAINT ALL;";
        public const string EnableTableContraintTemplate = @"ALTER TABLE {0} CHECK CONSTRAINT ALL;";

        private IObjectSpace objectSpace;
        private DbConnection connection;
        private string[] DbTables = new string[]{
                "[dbo].[Addresses]",
                "[dbo].[People]",
                "[dbo].[MediaResourceObjects]",
                "[dbo].[MediaDataObjects]",
                "[dbo].[Users]",
                "[dbo].[Leads]",
                "[dbo].[Customers]",
                "[dbo].[DashboardDatas]",
                "[dbo].[SaleBases]",
                "[dbo].[Events]",
                "[dbo].[Roles]",
                "[dbo].[HCategories]",
                "[dbo].[Products]",
                "[dbo].[SaleItems]",
                "[dbo].[LeadHistoryRecords]",
                "[dbo].[KpiDefinitions]",
                "[dbo].[KpiInstances]",
                "[dbo].[KpiScorecards]",
                "[dbo].[ReportDataV2]",
                "[dbo].[KpiHistoryItems]",
                "[dbo].[KpiInstanceKpiScorecards]",
                "[dbo].[Invoices]",
                "[dbo].[Opportunities]",
                "[dbo].[Orders]",
                "[dbo].[Quotes]",
                "[dbo].[UserRoles]"
        };

        private void Init() {
            EFObjectSpace efObjectSpace = this.objectSpace as EFObjectSpace;
            if(objectSpace != null) {
                connection = efObjectSpace.ObjectContext.Connection;
                if(connection is EntityConnection) {
                    connection = ((EntityConnection)connection).StoreConnection;
                }
            }
        }
        private void ExecuteCommand(string command) {
            connection.Open();
            try {
                DbCommand cmd = connection.CreateCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = command;
                cmd.ExecuteNonQuery();
            }
            finally {
                connection.Close();
            }
        }
        private void EnableConstraints() {
            UpdateConstraintState(true);
        }
        private void DisableConstraints() {
            UpdateConstraintState(false);
        }
        private void UpdateConstraintState(bool enable) {
            string sqlQuery = string.Empty;
            foreach(string tableName in DbTables) {
                sqlQuery += string.Format(enable ? EnableTableContraintTemplate : DisableTableContraintTemplate, tableName);
            }
            ExecuteCommand(sqlQuery);
        }
        private void ProcessScript(StreamReader reader) {
            string sqlQuery = string.Empty;
            string identityInsertCmd = string.Empty;
            string salesOverview = GetDashboardXml("XCRM.Module.Dashboards.SalesOverview.xml");
            string shippingCountries = GetDashboardXml("XCRM.Module.Dashboards.ShippingCountries.xml");

            while(!reader.EndOfStream) {
                string sqlCmd = reader.ReadLine().Trim();
                if(sqlCmd == "GO") {
                    ExecuteCommand(sqlQuery);
                    sqlQuery = identityInsertCmd;
                }
                else {
                    if(!string.IsNullOrEmpty(sqlCmd)) {
                        if(sqlCmd.StartsWith("SET IDENTITY_INSERT")) {
                            if(sqlCmd.EndsWith(" ON")) {
                                identityInsertCmd = sqlCmd;
                            }
                            if(sqlCmd.EndsWith(" OFF")) {
                                identityInsertCmd = string.Empty;
                            }
                        }
                        if(sqlCmd.StartsWith("INSERT [dbo].[DashboardDatas]")) {
                            sqlCmd = sqlCmd.Replace("dashboardSalesOverview", salesOverview);
                            sqlCmd = sqlCmd.Replace("dashboardShippingCountries", shippingCountries);
                        }
                        sqlQuery += ";" + sqlCmd;
                    }
                }
            }
            if(sqlQuery.Length > 0) {
                ExecuteCommand(sqlQuery);
            }
        }
        private static string GetDashboardXml(string resourceName) {
            string xml = null;
            Assembly assembly = Assembly.GetExecutingAssembly();
            using(Stream stream = assembly.GetManifestResourceStream(resourceName)) {
                if(stream != null) {
                    using(StreamReader reader = new StreamReader(stream)) {
                        xml = reader.ReadToEnd();
                        xml = xml.Replace("'", "''");
                    }
                }
                else {
                    throw new Exception(SystemExceptionLocalizer.GetExceptionMessage(ExceptionId.ResourceItemWithNameIsNotFound, resourceName));
                }
            }
            return xml;
        }
        public void Populate() {
            if(objectSpace.FindObject<MyAppUser>(new BinaryOperator("UserName", XCRM.Module.Updater.AdministratorUserName)) == null) {
                DisableConstraints();
                try {
                    string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, DatabaseScriptFileName);
                    using(FileStream stream = new FileStream(filePath, FileMode.Open, FileAccess.Read)) {
                        using(StreamReader reader = new StreamReader(stream, System.Text.Encoding.Unicode)) {
                            try {
                                ProcessScript(reader);
                            }
                            catch (Exception e) {
                                Tracing.Tracer.LogError(e);
                            }
                        }
                    }
                }
                finally {
                    EnableConstraints();
                }
            }
        }

        public DatabaseDataGenerator(IObjectSpace objectSpace) {
            this.objectSpace = objectSpace;
            Init();
        }
    }

    public class TestingDataGenerator {
        private IObjectSpace objectSpace;

        private void CreateUsersAndRoles() {
            PersistentRole adminRole = objectSpace.FindObject<PersistentRole>(new BinaryOperator("Name", "Administrators"));
            if(adminRole == null) {
                adminRole = objectSpace.CreateObject<PersistentRole>();
                adminRole.Name = "Administrators";
                adminRole.IsAdministrative = true;
            }
            if(objectSpace.FindObject<MyAppUser>(new BinaryOperator("UserName", XCRM.Module.Updater.AdministratorUserName)) == null) {
                MyAppUser administrator = objectSpace.CreateObject<MyAppUser>();
                administrator.FirstName = XCRM.Module.Updater.AdministratorUserName;
                administrator.LastName = XCRM.Module.Updater.AdministratorUserName;
                ((DCUser)administrator).UserName = XCRM.Module.Updater.AdministratorUserName;
                administrator.IsActive = true;
                administrator.Roles.Add(adminRole);
            }
            if(objectSpace.FindObject<MyAppUser>(new BinaryOperator("UserName", "User1")) == null) {
                MyAppUser user = objectSpace.CreateObject<MyAppUser>();
                user.FirstName = "User1";
                user.LastName = "User1";
                ((DCUser)user).UserName = "User1";
                user.IsActive = true;
                user.Roles.Add(adminRole);
            }
            objectSpace.CommitChanges();
        }
        private void CreateKpiObjects() {
            KpiScorecard obj2 = objectSpace.FindObject<KpiScorecard>(CriteriaOperator.Parse("Name='Sales'"));
            if(obj2 == null) {
                obj2 = objectSpace.CreateObject<KpiScorecard>();
                obj2.Name = "Sales";
            }
            KpiDefinition obj1 = objectSpace.FindObject<KpiDefinition>(CriteriaOperator.Parse("Name='New Leads'"));
            if(obj1 == null) {
                obj1 = objectSpace.CreateObject<KpiDefinition>();
                obj1.Name = "New Leads";
                obj1.TargetObjectType = typeof(CRMLead);
                obj1.Criteria = "CreatedOn >= '@RangeStart' And CreatedOn <= '@RangeEnd'";
                obj1.Expression = "Count";
                obj1.Range = DevExpress.ExpressApp.Kpi.DateRangeRepository.FindRange("ThisMonthToDate");
                obj1.Compare = true;
                obj1.RangeToCompare = DevExpress.ExpressApp.Kpi.DateRangeRepository.FindRange("LastMonthToDate");
                obj1.MeasurementFrequency = DevExpress.ExpressApp.Kpi.TimeIntervalType.Day;
                obj2.Indicators.Add(obj1.KpiInstance);
            }
            KpiDefinition obj11 = objectSpace.FindObject<KpiDefinition>(CriteriaOperator.Parse("Name='New Opportunities'"));
            if(obj11 == null) {
                obj11 = objectSpace.CreateObject<KpiDefinition>();
                obj11.Name = "New Opportunities";
                obj11.TargetObjectType = typeof(CRMOpportunity);
                obj11.Criteria = "CreatedOn >= '@RangeStart' And CreatedOn <= '@RangeEnd'";
                obj11.Expression = "Count";
                obj11.Range = DevExpress.ExpressApp.Kpi.DateRangeRepository.FindRange("ThisMonthToDate");
                obj11.Compare = true;
                obj11.RangeToCompare = DevExpress.ExpressApp.Kpi.DateRangeRepository.FindRange("LastMonthToDate");
                obj11.MeasurementFrequency = DevExpress.ExpressApp.Kpi.TimeIntervalType.Day;
                obj2.Indicators.Add(obj11.KpiInstance);
            }
            KpiDefinition obj12 = objectSpace.FindObject<KpiDefinition>(CriteriaOperator.Parse("Name='New Quotes'"));
            if(obj12 == null) {
                obj12 = objectSpace.CreateObject<KpiDefinition>();
                obj12.Name = "New Quotes";
                obj12.TargetObjectType = typeof(CRMQuote);
                obj12.Criteria = "CreatedOn >= '@RangeStart' And CreatedOn <= '@RangeEnd'";
                obj12.Expression = "Count";
                obj12.Range = DevExpress.ExpressApp.Kpi.DateRangeRepository.FindRange("ThisMonthToDate");
                obj12.Compare = true;
                obj12.RangeToCompare = DevExpress.ExpressApp.Kpi.DateRangeRepository.FindRange("LastMonthToDate");
                obj12.MeasurementFrequency = DevExpress.ExpressApp.Kpi.TimeIntervalType.Day;
                obj2.Indicators.Add(obj12.KpiInstance);
            }
            KpiDefinition obj13 = objectSpace.FindObject<KpiDefinition>(CriteriaOperator.Parse("Name='New Orders'"));
            if(obj13 == null) {
                obj13 = objectSpace.CreateObject<KpiDefinition>();
                obj13.Name = "New Orders";
                obj13.TargetObjectType = typeof(CRMOrder);
                obj13.Criteria = "CreatedOn >= '@RangeStart' And CreatedOn <= '@RangeEnd'";
                obj13.Expression = "Count";
                obj13.Range = DevExpress.ExpressApp.Kpi.DateRangeRepository.FindRange("ThisMonthToDate");
                obj13.Compare = true;
                obj13.RangeToCompare = DevExpress.ExpressApp.Kpi.DateRangeRepository.FindRange("LastMonthToDate");
                obj13.MeasurementFrequency = DevExpress.ExpressApp.Kpi.TimeIntervalType.Day;
                obj2.Indicators.Add(obj13.KpiInstance);
            }
            KpiDefinition obj14 = objectSpace.FindObject<KpiDefinition>(CriteriaOperator.Parse("Name='New Invoices'"));
            if(obj14 == null) {
                obj14 = objectSpace.CreateObject<KpiDefinition>();
                obj14.Name = "New Invoices";
                obj14.TargetObjectType = typeof(CRMInvoice);
                obj14.Criteria = "CreatedOn >= '@RangeStart' And CreatedOn <= '@RangeEnd'";
                obj14.Expression = "Count";
                obj14.Range = DevExpress.ExpressApp.Kpi.DateRangeRepository.FindRange("ThisMonthToDate");
                obj14.Compare = true;
                obj14.RangeToCompare = DevExpress.ExpressApp.Kpi.DateRangeRepository.FindRange("LastMonthToDate");
                obj14.MeasurementFrequency = DevExpress.ExpressApp.Kpi.TimeIntervalType.Day;
                obj2.Indicators.Add(obj14.KpiInstance);
            }
            objectSpace.CommitChanges();
        }
        private void InitializeDashboards() {
            Assembly assembly = Assembly.GetExecutingAssembly();
            DashboardsModule.AddDashboardDataFromResources<DashboardData>(objectSpace, "Sales Overview", assembly, "XCRM.Module.Dashboards.SalesOverview.xml");
            DashboardsModule.AddDashboardDataFromResources<DashboardData>(objectSpace, "Shipping Countries", assembly, "XCRM.Module.Dashboards.ShippingCountries.xml");
        }

        public void Populate() {
            CreateUsersAndRoles();
            CreateKpiObjects();
            InitializeDashboards();
        }

        public TestingDataGenerator(IObjectSpace objectSpace) {
            this.objectSpace = objectSpace;
        }
    }


    public class Updater : DevExpress.ExpressApp.Updating.ModuleUpdater {
        public const string AdministratorUserName = "Administrator";
        public Updater(IObjectSpace os, Version currentDBVersion)
            : base(os, currentDBVersion) {
        }

        public override void UpdateDatabaseAfterUpdateSchema() {
            base.UpdateDatabaseAfterUpdateSchema();
            HandledEventArgs args = new HandledEventArgs();
            if(CreateTestGenerator != null) {
                CreateTestGenerator(this, args);
            }
            if(args.Handled) {
                new TestingDataGenerator(ObjectSpace).Populate();
            }
            else {
                new DatabaseDataGenerator(ObjectSpace).Populate();
            }
        }
        public event EventHandler<HandledEventArgs> CreateTestGenerator;
    }
}
