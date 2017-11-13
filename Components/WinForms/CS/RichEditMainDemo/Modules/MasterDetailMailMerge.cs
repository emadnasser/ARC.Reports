using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Globalization;
using DevExpress.Office.Services;
using DevExpress.Utils;
using DevExpress.XtraBars;
using DevExpress.XtraRichEdit;
using DevExpress.XtraRichEdit.API.Native;
using DevExpress.XtraRichEdit.Commands;
using DevExpress.XtraTab;

namespace DevExpress.XtraRichEdit.Demos {
    #region MasterDetailMailMergeModule
    public partial class MasterDetailMailMergeModule : DevExpress.XtraRichEdit.Demos.TutorialControl {
        #region Fields
        OleDbConnection connection;
        DataTable dataTable;
        CultureInfo cultureInfo;
        DataTable dataTableProducts;
        int categoryID = -1;
        #endregion

        public MasterDetailMailMergeModule() {
            InitializeComponent();

            RtfLoadHelper.Load("MasterDetailMailMergeTemplate.rtf", templateRichEditControl);
            new RichEditDemoExceptionsHandler(templateRichEditControl).Install();
            RtfLoadHelper.Load("MasterDetailMailMergeMaster.rtf", masterRichEditControl);
            new RichEditDemoExceptionsHandler(masterRichEditControl).Install();
            RtfLoadHelper.Load("MasterDetailMailMergeDetail.rtf", detailRichEditControl);
            new RichEditDemoExceptionsHandler(detailRichEditControl).Install();

            cultureInfo = CultureInfo.CreateSpecificCulture("en-US");
        }

        #region Properties
        public override RichEditControl PrintingRichEditControl { get { return templateRichEditControl; } }
        #endregion

        void resultingRichEditControl_CalculateDocumentVariable(object sender, CalculateDocumentVariableEventArgs e) {
            if (e.VariableName == "Categories") {
                masterRichEditControl.Options.MailMerge.DataSource = dataTable;

                IRichEditDocumentServer result = masterRichEditControl.CreateDocumentServer();
                result.CalculateDocumentVariable += result_CalculateDocumentVariable;
                masterRichEditControl.MailMerge(result.Document);
                result.CalculateDocumentVariable -= result_CalculateDocumentVariable;

                e.Value = result;
                e.Handled = true;
            }
        }
        void result_CalculateDocumentVariable(object sender, CalculateDocumentVariableEventArgs e) {
            int currentCategoryID = GetID(e.Arguments[0].Value);
            if (currentCategoryID == -1)
                return;

            if (categoryID != currentCategoryID) {
                dataTableProducts = GetDataTable(currentCategoryID);
                categoryID = currentCategoryID;
            }

            if (e.VariableName == "Products") {
                detailRichEditControl.Options.MailMerge.DataSource = dataTableProducts;

                IRichEditDocumentServer result = detailRichEditControl.CreateDocumentServer();

                MailMergeOptions options = detailRichEditControl.CreateMailMergeOptions();
                options.MergeMode = MergeMode.JoinTables;
                result.CalculateDocumentVariable += detail_CalculateDocumentVariable;
                detailRichEditControl.MailMerge(options, result.Document);
                result.CalculateDocumentVariable -= detail_CalculateDocumentVariable;

                e.Value = result;
                e.Handled = true;
            }
            if (e.VariableName == "LowestPrice") {
                e.Value = String.Format(cultureInfo, "{0:C2}", dataTableProducts.Compute("Min(UnitPrice)", String.Empty));
                e.Handled = true;
            }
            if (e.VariableName == "HighestPrice") {
                e.Value = String.Format(cultureInfo, "{0:C2}", dataTableProducts.Compute("Max(UnitPrice)", String.Empty));
                e.Handled = true;
            }
            if (e.VariableName == "ItemsCount") {
                e.Value = dataTableProducts.Rows.Count;
                e.Handled = true;
            }
            if (e.VariableName == "TotalSales") {
                string expression = String.Format("CategoryID = {0}", e.Arguments[0].Value);
                e.Value = String.Format(cultureInfo, "{0:C2}", dataTable.Select(expression)[0]["TotalSales"]);
                e.Handled = true;
            }
        }
        void detail_CalculateDocumentVariable(object sender, CalculateDocumentVariableEventArgs e) {
            int productId = GetID(e.Arguments[0].Value);
            if (productId == -1)
                return;
            if (e.VariableName == "UnitPrice") {
                string expression = String.Format("ProductID = {0}", productId);
                e.Value = String.Format(cultureInfo, "{0:C2}", dataTableProducts.Select(expression)[0]["UnitPrice"]);
                e.Handled = true;
            }
        }
        protected internal virtual int GetID(string value) {
            int result;
            if (Int32.TryParse(value, out result))
                return result;
            return -1;
        }
        protected internal virtual DataTable GetDataTable(int categoryID) {
            string cmd = String.Format(@"SELECT * FROM Products WHERE CategoryID = {0}", categoryID);
            OleDbCommand selectCommand = new OleDbCommand(cmd, connection);
            OleDbDataAdapter adapter = new OleDbDataAdapter(selectCommand);
            DataSet result = new DataSet();
            adapter.Fill(result);
            return result.Tables[0];
        }
        void tabControl_SelectedPageChanged(object sender, TabPageChangedEventArgs e) {
            RichEditControl richEditControl = (RichEditControl)tabControl.SelectedTabPage.Tag;
            mergeToNewDocumentPageGroup1.Visible = !object.ReferenceEquals(richEditControl, resultingRichEditControl);
            richEditBarController1.RichEditControl = richEditControl;
        }
        void MasterDetailMailMergeModule_Load(object sender, EventArgs e) {
            FillData();
            IUriStreamService uriService = (IUriStreamService)masterRichEditControl.GetService(typeof(IUriStreamService));
            uriService.RegisterProvider(new DBUriStreamProvider(dataTable, "FirstOfPicture"));

            MergeToNewDocument();

            ShowAllFieldCodes(templateRichEditControl);
            ShowAllFieldCodes(masterRichEditControl);
            ShowAllFieldCodes(detailRichEditControl);
        }
        void mergeToNewDocument_ItemClick(object sender, ItemClickEventArgs e) {
            MergeToNewDocument();
        }
        static List<int> fakeDataSource = CreateFakeDataSource();
        static List<int> CreateFakeDataSource() {
            List<int> result = new List<int>();
            result.Add(0);
            return result;
        }
        protected internal virtual void MergeToNewDocument() {
            using (WaitDialogForm dlg = new WaitDialogForm("Please Wait", "Loading ...")) {
                templateRichEditControl.Options.MailMerge.DataSource = fakeDataSource;
                templateRichEditControl.MailMerge(resultingRichEditControl.Document);

                tabControl.SelectedTabPage = resultingDocumentTabPage;
            }
        }
        protected internal virtual void ShowAllFieldCodes(IRichEditControl control) {
            ShowAllFieldCodesCommand command = new ShowAllFieldCodesCommand(control);
            command.Execute();
        }
        void FillData() {
            this.connection = new OleDbConnection();
            string path = DemoUtils.GetRelativePath("nwind.mdb");
            if (path.Length <= 0) {
                return;
            }
            DemoUtils.SetConnectionString(this.connection, path);
            string cmd = @"SELECT DISTINCTROW Categories.CategoryName, Sum(CCur([Order Details].[UnitPrice]*[Quantity]*(1-[Discount])/100)*100) AS TotalSales, Categories.CategoryID, Categories.Description, First(Categories.Picture) AS FirstOfPicture FROM (Categories INNER JOIN Products ON Categories.CategoryID = Products.CategoryID) INNER JOIN (Orders INNER JOIN [Order Details] ON Orders.OrderID = [Order Details].OrderID) ON Products.ProductID = [Order Details].ProductID GROUP BY Categories.CategoryName, Categories.CategoryID, Categories.Description";
            OleDbCommand selectCommand = new OleDbCommand(cmd, connection);

            OleDbDataAdapter adapter = new OleDbDataAdapter(selectCommand);
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet);

            dataTable = dataSet.Tables[0];
            dataTable.PrimaryKey = new DataColumn[] { dataTable.Columns["CategoryID"] };
        }
    }
    #endregion
}
