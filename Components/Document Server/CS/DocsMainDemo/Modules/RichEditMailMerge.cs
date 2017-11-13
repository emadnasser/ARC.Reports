using System;
using System.IO;
using System.Data;
using DevExpress.XtraRichEdit;
using System.Collections.Generic;
using DevExpress.Office.Services;
using DevExpress.DXperience.Demos;
using DevExpress.XtraPrintingLinks;

namespace DevExpress.Docs.Demos {
    public partial class RichEditMailMerge : TutorialControlBase {
        PrintableComponentLinkBase link;
        RichEditDocumentServer documentServer;
        System.Data.OleDb.OleDbConnection connection = new System.Data.OleDb.OleDbConnection();
        public RichEditMailMerge() {
            InitializeComponent();
            
            this.documentServer = new RichEditDocumentServer();
            string path = DemoUtils.GetRelativePath("MailMerge.rtf");
            this.documentServer.LoadDocument(path, DocumentFormat.Rtf);

            this.printPreviewControl.PrintingSystem = new DevExpress.XtraPrinting.PrintingSystem();
            this.link = new DevExpress.XtraPrintingLinks.PrintableComponentLinkBase(this.printPreviewControl.PrintingSystem);
            LoadData();
            this.documentServer.Options.MailMerge.ViewMergedData = true;
            this.gridView1.FocusedRowChanged += gridView1_FocusedRowChanged;
            Load += MailMerge_Load;
        }

        void MailMerge_Load(object sender, EventArgs e) {
            ProcessSelectedRows();
        }
        void ProcessSelectedRows() {
            UpdateMailMergeOptions();
            link.Component = this.documentServer;
            link.CreateDocument();
        }
        protected void UpdateMailMergeOptions() {
            int[] selectedRowIndexes = gridView1.GetSelectedRows();
            int count = selectedRowIndexes.Length;
            List<object> selectedRows = new List<object>();
            for (int i = 0; i < count; i++)
                selectedRows.Add(gridView1.GetRow(selectedRowIndexes[i]));
            this.documentServer.Options.MailMerge.DataSource = selectedRows;
        }
        void gridView1_FocusedRowChanged(object sender, XtraGrid.Views.Base.FocusedRowChangedEventArgs e) {
            ProcessSelectedRows();
        }
        void LoadData() {
            string path = DemoUtils.GetRelativePath("nwind.mdb");
            if (path.Length <= 0)
                return;
            IUriStreamService uriService = (IUriStreamService)this.documentServer.GetService(typeof(IUriStreamService));
            uriService.RegisterProvider(new DBUriStreamProvider(nwindDataSet.Employees, "Photo"));
            employeesTableAdapter.Connection = new System.Data.OleDb.OleDbConnection();
            DemoUtils.SetConnectionString(employeesTableAdapter.Connection, path);
            DemoUtils.SetConnectionString(this.connection, path);
            this.employeesTableAdapter.Fill(this.nwindDataSet.Employees);
            FillData();
        }
        void FillData() {
            string cmd = @"SELECT Employees.*, Customers.* FROM (Employees INNER JOIN EmployeeCustomers ON Employees.EmployeeID = EmployeeCustomers.EmployeeId) INNER JOIN Customers ON EmployeeCustomers.CustomerId = Customers.CustomerID;";
            System.Data.OleDb.OleDbCommand selectCommand = new System.Data.OleDb.OleDbCommand(cmd, connection);
            System.Data.OleDb.OleDbDataAdapter adapter = new System.Data.OleDb.OleDbDataAdapter(selectCommand);
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet);
            this.gridControl1.DataSource = dataSet.Tables[0];
            this.documentServer.Options.MailMerge.DataSource = dataSet.Tables[0];
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
        Stream IUriStreamProvider.GetStream(string uri) {
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
