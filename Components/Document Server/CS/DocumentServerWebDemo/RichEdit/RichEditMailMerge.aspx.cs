using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Net;
using DevExpress.Office.Services;
using DevExpress.Web.Demos;
using DevExpress.XtraRichEdit;
using DevExpress.XtraRichEdit.API.Native;

public partial class RichEdit_MailMerge : System.Web.UI.Page {
    #region Fields
    const string defaultFileName = "RichEditMailMerge";
    const string ServerFilePath = "~/App_Data/MailMerge.rtf";
    const int TargetIsPreview = 10;

    DataTable mailMergeDataTable = null;
    RichEditDocumentServer docServer = null;
    InMemoryNWindData data;
    #endregion

    public RichEdit_MailMerge()
        : base() {
        data = new InMemoryNWindData(); 
        InitializeData();
    }

    protected void Page_Load(object sender, EventArgs e) {
        if(Request.QueryString.Count > 0 && Request.QueryString[0].StartsWith("preview")) {
            string strEmployeeId = Request.Params["employee"];
            int employeeId = string.IsNullOrEmpty(strEmployeeId) ? Convert.ToInt32(cbEmployee.Value) : Convert.ToInt32(strEmployeeId);
            string customerId = Request.Params["customer"];
            if(string.IsNullOrEmpty(customerId))
                customerId = Convert.ToString(cbCustomer.Value);
            RefreshPreview(employeeId, customerId);
        }
    }

    void RefreshPreview(int employeeId, string customerId) {
        Response.StatusCode = (int)HttpStatusCode.OK;
        Response.ContentType = "text/html";
        if(EnforceDocServer()) {
            using (Stream outputStream = ExecuteMerge(TargetIsPreview, employeeId, customerId)) {
                if (outputStream != null) {
                    outputStream.Seek(0, SeekOrigin.Begin);
                    outputStream.CopyTo(Response.OutputStream);
                }
            }
        }
        Response.End();
    }

    void InitializeData() {
        mailMergeDataTable = new DataTable();
        AddDataColumns();
    }

    void AddDataColumns() {
        mailMergeDataTable.Columns.Add("EmployeeID", typeof(int));
        mailMergeDataTable.Columns.Add("FirstName", typeof(string));
        mailMergeDataTable.Columns.Add("LastName", typeof(string));
        mailMergeDataTable.Columns.Add("ContactName", typeof(string));
        mailMergeDataTable.Columns.Add("Employees.Address", typeof(string));
        mailMergeDataTable.Columns.Add("Employees.City", typeof(string));
        mailMergeDataTable.Columns.Add("Employees.PostalCode", typeof(string));
        mailMergeDataTable.Columns.Add("ContactTitle", typeof(string));
        mailMergeDataTable.Columns.Add("CompanyName", typeof(string));
        mailMergeDataTable.Columns.Add("Customers.Address", typeof(string));
        mailMergeDataTable.Columns.Add("Customers.City", typeof(string));
        mailMergeDataTable.Columns.Add("Customers.PostalCode", typeof(string));
        mailMergeDataTable.Columns.Add("Title", typeof(string));
        mailMergeDataTable.Columns.Add("Photo", typeof(object));
    }

    bool PutMergeData(int employeeId, string customerId) {
        Employee currentEmployee = data.GetEmployee(employeeId);
        Customer currentCustomer = data.GetCustomer(customerId);
        if(currentEmployee == null || currentCustomer == null)
            return false;
        mailMergeDataTable.Rows.Clear();
        mailMergeDataTable.Rows.Add(currentEmployee.EmployeeID,
                                    currentEmployee.FirstName,
                                    currentEmployee.LastName,
                                    currentCustomer.ContactName,
                                    currentEmployee.Address,
                                    currentEmployee.City,
                                    currentEmployee.PostalCode,
                                    currentCustomer.ContactTitle,
                                    currentCustomer.CompanyName,
                                    currentCustomer.Address,
                                    currentCustomer.City,
                                    currentCustomer.PostalCode,
                                    currentEmployee.Title,
                                    null);
        return true;
    }

    Stream ExecuteMerge(int downloadType, int employeeId, string customerId) {
        Stream result = null;
        if(!PutMergeData(employeeId, customerId)) {
            return null;
        }
        docServer.LoadDocument(Page.MapPath(ServerFilePath));
        docServer.Options.MailMerge.DataSource = mailMergeDataTable;
        docServer.Options.MailMerge.ViewMergedData = true;
        docServer.Options.Export.Html.EmbedImages = true;
        result = new MemoryStream();
        if (EnforceDocServer()) {
            if (downloadType == 4) {
                docServer.Options.MailMerge.ActiveRecord = 0;
                docServer.ExportToPdf(result);
            }
            else {
                DocumentFormat format = ConvertIndexToFormat(downloadType);
                MergeToDoc(result, format);
            }
        }
        return result;
    }

    bool EnforceDocServer() {
        if(docServer == null)
            docServer = new RichEditDocumentServer();
        if(docServer == null) {
            return false;
        }
        IUriStreamService uriService = (IUriStreamService)docServer.GetService(typeof(IUriStreamService));
        uriService.RegisterProvider(new DevExpress.Docs.Demos.RichEditMailMergeDBUriStreamProvider(mailMergeDataTable, "Photo", this));
        return true;
    }

    protected void btnDownload_Click(object sender, EventArgs e) {
        if(!EnforceDocServer())
            return;
        int downloadType = (int)cbDownloadType.Value;
        using (Stream outputStream = ExecuteMerge(downloadType, Convert.ToInt32(cbEmployee.Value), Convert.ToString(cbCustomer.Value))) {
            if (outputStream == null)
                return;
            outputStream.Seek(0, SeekOrigin.Begin);
            outputStream.CopyTo(Response.OutputStream);
        }
        Response.StatusCode = (int)HttpStatusCode.OK;
        Response.ContentType = ConvertIndexToContentType(downloadType);
        Response.AddHeader("Content-Disposition", String.Format("attachment; filename={0}.{1}", defaultFileName, ConvertIndexToFileExtension(downloadType)));
        Response.End();
    }

    void MergeToDoc(Stream stream, DocumentFormat docFormat) {
        MailMergeOptions options = docServer.CreateMailMergeOptions();
        options.DataSource = mailMergeDataTable;
        options.FirstRecordIndex = 0;
        options.LastRecordIndex = 0;
        docServer.MailMerge(options, stream, docFormat);
    }

    DocumentFormat ConvertIndexToFormat(int value) {
        switch (value) {
            case 1:
                return DocumentFormat.Rtf;
            case 2:
                return DocumentFormat.Doc;
            case 3:
                return DocumentFormat.OpenXml;
            case 5:
                return DocumentFormat.PlainText;
            case 6:
                return DocumentFormat.Mht;
            case 7:
                return DocumentFormat.OpenDocument;
            case 8:
                return DocumentFormat.WordML;
            case 9:
                return DocumentFormat.ePub;
            case 10:
                return DocumentFormat.Html;
        }
        return DocumentFormat.Undefined;
    }
    string ConvertIndexToContentType(int value) {
        switch (value) {
            case 1:
                return "application/msword";
            case 2:
                return "application/msword";
            case 3:
                return "application/msword";
            case 4:
                return "application/msword";
            case 5:
                return "text/plain";
            case 6:
                return "message/rfc822";
            case 7:
                return "application/msword";
            case 8:
                return "text/xml";
            case 9:
                return "application/msword";
        }
        return String.Empty;
    }
    string ConvertIndexToFileExtension(int value) {
        switch (value) {
            case 1:
                return "rtf";
            case 2:
                return "doc";
            case 3:
                return "docx";
            case 4:
                return "pdf";
            case 5:
                return "txt";
            case 6:
                return "mht";
            case 7:
                return "odt";
            case 8:
                return "xml";
            case 9:
                return "epub";
        }
        return String.Empty;
    }


    void FillEmployeeCombo() {
        DevExpress.Web.ListEditItemCollection comboItems = new DevExpress.Web.ListEditItemCollection();
        foreach(Employee item in data.Employees)
            comboItems.Add(item.FirstName + " " + item.LastName, item.EmployeeID);
        cbEmployee.Items.Assign(comboItems);
    }

    void ApplyEmployee(int employeeId) {
        if(employeeId < 0)
            return;
        List<Customer> customersList = data.GetCustomersList(employeeId);
        DevExpress.Web.ListEditItemCollection comboItems = new DevExpress.Web.ListEditItemCollection();
        foreach(Customer item in customersList) {
            comboItems.Add(item.ContactName, item.CustomerID);
        }
        cbCustomer.Items.Assign(comboItems);
        if(cbCustomer.Items.Count > 0)
            cbCustomer.SelectedIndex = 0;
    }

    protected void cbCustomer_Callback(object sender, DevExpress.Web.CallbackEventArgsBase e) {
        if(!string.IsNullOrEmpty(e.Parameter))
            ApplyEmployee(Convert.ToInt32(e.Parameter));
    }

    protected void cbEmployee_Callback(object sender, DevExpress.Web.CallbackEventArgsBase e) {
        if(e.Parameter == "init") {
            FillEmployeeCombo();
            if(cbEmployee.Items.Count > 0)
                cbEmployee.SelectedIndex = 0;
        }
    }
    protected void cbCustomer_ValueChanged(object sender, EventArgs e) {

    }
}

namespace DevExpress.Docs.Demos {
    public class RichEditMailMergeDBUriStreamProvider : IUriStreamProvider {
        static readonly string prefix = "dbimg://";
        DataTable table;
        string columnName;
        System.Web.UI.Page page;

        public RichEditMailMergeDBUriStreamProvider(DataTable table, string columnName, System.Web.UI.Page page) {
            this.table = table;
            this.columnName = columnName;
            this.page = page;
        }

        Stream IUriStreamProvider.GetStream(string uri) {
            uri = uri.Trim();
            if(!uri.StartsWith(prefix))
                return null;
            string strId = uri.Substring(prefix.Length).Trim();
            int id;
            if(!int.TryParse(strId, out id))
                return null;
            string pictureRoot = page.MapPath("~/App_Data/");
            string fileName = string.Format("{0}Photo{1}.jpeg", pictureRoot, id);
            byte[] bytes = null;
            using(FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read)) {
                int length = (int)fs.Length;
                bytes = new byte[length];
                fs.Read(bytes, 0, length);
            }
            return new MemoryStream(bytes);
        }
    }
}
