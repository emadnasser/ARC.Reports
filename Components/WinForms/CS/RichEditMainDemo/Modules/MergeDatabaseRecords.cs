using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using DevExpress.XtraRichEdit.Demos.Forms;
using DevExpress.XtraRichEdit.API.Native;
using DevExpress.Office.Services;

namespace DevExpress.XtraRichEdit.Demos {
    public partial class MergeDatabaseRecordsModule : MergeModuleBase {
        System.Data.OleDb.OleDbConnection connection;
        public MergeDatabaseRecordsModule() {
            InitializeComponent();
            RtfLoadHelper.Load("MailMerge.rtf", sourceRichEditControl);
            new RichEditDemoExceptionsHandler(sourceRichEditControl).Install();
            this.connection = new System.Data.OleDb.OleDbConnection();
            SourceRichEditControl.Options.MailMerge.ViewMergedData = true;
        }


        protected override RichEditControl SourceRichEditControl { get { return sourceRichEditControl; } }

        private void MailMergeModule_Load(object sender, EventArgs e) {
            string path = DemoUtils.GetRelativePath("nwind.mdb");
            if (path.Length <= 0)
                return;
            IUriStreamService uriService = (IUriStreamService)SourceRichEditControl.GetService(typeof(IUriStreamService));
            uriService.RegisterProvider(new DBUriStreamProvider(nwindDataSet.Employees, "Photo"));
            DemoUtils.SetConnectionString(employeesTableAdapter.Connection, path);
            DemoUtils.SetConnectionString(this.connection, path);
            this.employeesTableAdapter.Fill(this.nwindDataSet.Employees);
            FillData();
        }
        protected override MergeFieldsFormBase CreateMergeFieldForm() {
            return new MergeDatabaseRecordsForm();
        }
        protected override void CalculateMailMergeOptions(MergeFieldsFormBase form, MailMergeOptions options) {
            if (form.MergeRecords == MergeRecords.Selected) {
                int[] selectedRowIndexes = gridView1.GetSelectedRows();
                int count = selectedRowIndexes.Length;
                List<object> selectedRows = new List<object>();
                for (int i = 0; i < count; i++) {
                    selectedRows.Add(gridView1.GetRow(selectedRowIndexes[i]));
                }
                options.DataSource = selectedRows;
            }
        }
        void FillData() {
            string cmd = @"SELECT Employees.*, Customers.* FROM (Employees INNER JOIN EmployeeCustomers ON Employees.EmployeeID = EmployeeCustomers.EmployeeId) INNER JOIN Customers ON EmployeeCustomers.CustomerId = Customers.CustomerID;";
            System.Data.OleDb.OleDbCommand selectCommand = new System.Data.OleDb.OleDbCommand(cmd, connection);

            System.Data.OleDb.OleDbDataAdapter adapter = new System.Data.OleDb.OleDbDataAdapter(selectCommand);
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet);
            SourceRichEditControl.Options.MailMerge.DataSource = dataSet.Tables[0];
            this.gridControl1.DataSource = dataSet.Tables[0];
        }

        private void mergeToNewDocumentClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            MergeToNewDocument();
        }
    }
    public class DBUriStreamProvider : IUriStreamProvider {
        static readonly string prefix = "dbimg://";
        DataTable table;
        string columnName;

        public DBUriStreamProvider(DataTable table, string columnName) {
            this.table = table;
            this.columnName = columnName;
        }

        #region IUriStreamProvider Members
        public Stream GetStream(string uri) {
            uri = uri.Trim();
            if (!uri.StartsWith(prefix))
                return null;
            string strId = uri.Substring(prefix.Length).Trim();
            int id;
            if (!int.TryParse(strId, out id))
                return null;
            DataRow row = table.Rows.Find(id);
            if (row == null)
                return null;
            byte[] bytes = row[columnName] as byte[];
            if (bytes == null)
                return null;
            return new MemoryStream(bytes);
        }
        #endregion
    }
}
