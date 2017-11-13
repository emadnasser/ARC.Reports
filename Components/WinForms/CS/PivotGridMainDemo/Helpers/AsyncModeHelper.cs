using DevExpress.Data;
using DevExpress.Data.PivotGrid;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraPivotGrid;
using DevExpress.XtraPivotGrid.Data;
using System;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace DevExpress.XtraPivotGrid.Demos.Helpers {
    public enum InitializerDataSource {
        OlapCube,
        TableDataSource,
    }
    public abstract class AsynchronousPivotInitializer {
        public const string OlapError = "A connection error occurred. Please make sure that you have provided proper connection settings.To connect to OLAP cubes,\nyou should have Microsoft SQL Server 2005 Analysis Services 9.0 OLE DB provider installed on your system.";
        public const string TableError = "A connection error occurred. Please make sure that you have generated a data source and provided proper connection settings.";
        static string adventureWorksFileName;
        protected const int DefaultFieldWidth = 90;

        public static void Initialize(PivotGridControl pivot, AsyncCompletedHandler initCompletedCallback, InitializerDataSource dataSource) {
            AsynchronousPivotInitializer initializer;
            switch(dataSource) {
                case InitializerDataSource.OlapCube:
                    initializer = new AsynchronousPivotInitializerSampleOlapDB(pivot, initCompletedCallback);
                    initializer.Initialize();
                    break;
                case InitializerDataSource.TableDataSource:
                    initializer = new AsynchronousPivotInitializerGeneratedDB(pivot, initCompletedCallback);
                    initializer.Initialize();
                    break;
                default:
                    throw new ArgumentException("Incorrect InitializerDataSource enum value.", "dataSource");
            }
        }
        protected AsynchronousPivotInitializer(PivotGridControl pivot, AsyncCompletedHandler initCompletedCallback) {
            PivotGrid = pivot;
            ResetPivotGrid(PivotGrid);
            InitializationCompletedCallback = initCompletedCallback;
        }
        protected PivotGridControl PivotGrid { get; set; }
        protected AsyncCompletedHandler InitializationCompletedCallback { get; set; }
        static string AdventureWorksSampleFileName {
            get {
                if(string.IsNullOrEmpty(adventureWorksFileName)) {
                    adventureWorksFileName = Path.GetFullPath(FilesHelper.FindingFileName(Application.StartupPath, GetAdventureWorksSampleFileName()));
                    if(File.Exists(adventureWorksFileName))
						try {
							File.SetAttributes(adventureWorksFileName, FileAttributes.Normal);
						} catch { }
                }
                return adventureWorksFileName;
            }
        }
        static string GetAdventureWorksSampleFileName() {
            return "Data\\AdventureWorks.cub";
        }
        protected static string OLAPSampleConnectionString {
            get {
                if(string.IsNullOrEmpty(AdventureWorksSampleFileName)) return null;
                return "Provider=msolap;Data Source=" + AdventureWorksSampleFileName + ";Initial Catalog=Adventure Works;Cube Name=Adventure Works";
            }
        }
        static void ResetPivotGrid(PivotGridControl pivot) {
            if(string.IsNullOrEmpty(pivot.OLAPConnectionString))
                pivot.Groups.Clear();
            pivot.Fields.Clear();
            pivot.DataSource = null;
        }
        protected abstract void Initialize();
    }

    class AsynchronousPivotInitializerGeneratedDB : AsynchronousPivotInitializer {
        public AsynchronousPivotInitializerGeneratedDB(PivotGridControl pivot, AsyncCompletedHandler initCompletedCallback)
            : base(pivot, initCompletedCallback) {
        }
        protected override void Initialize() {
            DatabaseHelper.GetDataSetAsync(DatabaseHelper.AsyncDataSetSql, SetDataSourceGeneratedDatabase);
        }
        void SetDataSourceGeneratedDatabase(DataSet dataSet) {
            if(dataSet == null) {
                PivotGrid.Enabled = false;
                InitializationCompletedCallback.Invoke(null);
                return;
            }
            PivotGrid.SetDataSourceAsync(dataSet.Tables[0], InitPivotLayoutGeneratedDB);
        }
        void InitPivotLayoutGeneratedDB(object obj) {
            PivotGrid.BeginUpdate();
            PivotGridField fieldSalesPerson = CreatePivotGridField("SalesPersonName", "Sales Person", PivotArea.RowArea);
            PivotGridField fieldCustomer = CreatePivotGridField("CustomerName", "Customer", PivotArea.FilterArea);
            PivotGridField fieldQuantity = CreatePivotGridField("Quantity", "Quantity", PivotArea.DataArea);
            PivotGridField fieldUnitPrice = CreatePivotGridField("UnitPrice", "Unit Price", PivotArea.DataArea);
            fieldUnitPrice.SummaryType = PivotSummaryType.Average;
            fieldUnitPrice.Options.ShowSummaryTypeName = true;
            PivotGridField fieldOrderID = CreatePivotGridField("OrderID", "Order ID", PivotArea.FilterArea);
            PivotGridField fieldCategory = CreatePivotGridField("CategoryName", "Category", PivotArea.RowArea);
            PivotGridField fieldProduct = CreatePivotGridField("ProductName", "Product", PivotArea.RowArea);
            PivotGridField fieldOrderDateYear = CreatePivotGridField("OrderDate", "Year", PivotArea.ColumnArea);
            fieldOrderDateYear.GroupInterval = PivotGroupInterval.DateYear;
            PivotGridField fieldOrderDateMonth = CreatePivotGridField("OrderDate", "Month", PivotArea.ColumnArea);
            fieldOrderDateMonth.GroupInterval = PivotGroupInterval.DateMonth;
            PivotGridField fieldPrice = new PivotGridField();
            fieldPrice.Area = PivotArea.DataArea;
            fieldPrice.Caption = "Price";
            fieldPrice.UnboundType = UnboundColumnType.Decimal;

            fieldQuantity.Width = DefaultFieldWidth;
            fieldUnitPrice.Width = DefaultFieldWidth;
            fieldPrice.Width = DefaultFieldWidth;

            PivotGrid.Fields.AddRange(new PivotGridField[] { fieldSalesPerson, fieldCustomer, fieldQuantity, fieldUnitPrice,
            				                fieldOrderID, fieldCategory, fieldProduct, fieldOrderDateYear, fieldOrderDateMonth, fieldPrice });
            PivotGrid.Groups.Add(fieldOrderDateYear, fieldOrderDateMonth);

            fieldPrice.UnboundExpression = "[" + fieldQuantity.ExpressionFieldName + "] * [" + fieldUnitPrice.ExpressionFieldName + "]";
            PivotGrid.EndUpdateAsync(InitializationCompletedCallback);
        }
        PivotGridField CreatePivotGridField(string fieldName, string caption, PivotArea area) {
            PivotGridField field = new PivotGridField(fieldName, area);
            field.Caption = caption;
            return field;
        }
    }

    class AsynchronousPivotInitializerSampleOlapDB : AsynchronousPivotInitializer {
        const string YearFieldName = "[Date].[Calendar].[Calendar Year]";
        const string CategoryFieldName = "[Product].[Product Categories].[Category]";
        const string TotalCostFieldName = "[Measures].[Total Product Cost]";
        const string FreightFieldName = "[Measures].[Freight Cost]";
        const string QuantityOrderFieldName = "[Measures].[Order Quantity]";

        public AsynchronousPivotInitializerSampleOlapDB(PivotGridControl pivot, AsyncCompletedHandler initCompletedCallback)
            : base(pivot, initCompletedCallback) {
        }
        protected override void Initialize() {
            try {
                PivotGrid.SetOLAPConnectionStringAsync(OLAPSampleConnectionString, InitPivotLayoutSampleOlapDB);
            } catch(OLAPConnectionException) {
                PivotGrid.OLAPConnectionString = null;
                PivotGrid.Enabled = false;
                InitializationCompletedCallback.Invoke(null);
            }
        }
        void InitPivotLayoutSampleOlapDB(object obj) {
            PivotGrid.RetrieveFields(PivotArea.FilterArea, false);
            if(PivotGrid.Fields.Count == 0) {
                InitializationCompletedCallback.Invoke(null);
                return;
            }
            PivotGrid.BeginUpdate();
            PivotGridField fieldProduct = PivotGrid.Fields[CategoryFieldName],
                fieldYear = PivotGrid.Fields[YearFieldName],
                fieldTotalCost = PivotGrid.Fields[TotalCostFieldName],
                fieldFreightCost = PivotGrid.Fields[FreightFieldName],
                fieldOrderQuantity = PivotGrid.Fields[QuantityOrderFieldName];
            PivotGrid.Groups[1].Caption = "Calendar";
            PivotGrid.Groups[2].Caption = "Products";

            fieldProduct.Area = PivotArea.RowArea;
            fieldYear.Area = PivotArea.ColumnArea;
            fieldYear.SortOrder = PivotSortOrder.Descending;
            fieldTotalCost.Width = DefaultFieldWidth;
            fieldTotalCost.CellFormat.FormatType = FormatType.Numeric;
            fieldTotalCost.CellFormat.FormatString = "c2";
            fieldFreightCost.Width = DefaultFieldWidth;
            fieldFreightCost.CellFormat.FormatType = FormatType.Numeric;
            fieldFreightCost.CellFormat.FormatString = "c2";
            fieldOrderQuantity.Width = DefaultFieldWidth;

            fieldProduct.Visible = true;
            fieldYear.Visible = true;
            fieldTotalCost.Visible = true;
            fieldFreightCost.Visible = true;
            fieldOrderQuantity.Visible = true;

            PivotGrid.EndUpdateAsync(ExpandAll);
        }
        void ExpandAll(object obj) {
            PivotGrid.ExpandAllAsync(InitializationCompletedCallback);
        }
    }
}
