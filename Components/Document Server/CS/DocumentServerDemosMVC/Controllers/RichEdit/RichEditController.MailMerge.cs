using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DevExpress.Office.Services;
using DevExpress.XtraRichEdit;

namespace DevExpress.Web.Demos {
    public partial class RichEditController : DemoController {
        const string MailMergeTemplateFilePath = "~/App_Data/MailMerge.rtf";

        public ActionResult MailMerge() {
            RichEditMailMergeModel model = new RichEditMailMergeModel();
            return DemoView("MailMerge", model);
        }
        public ActionResult PreviewMailMerge(RichEditMailMergeModel model) {
            Stream stream = ExecuteMerge(DocumentFormat.Html, model.Data, model.Employee, model.Customer);
            return CreatePreviewResult(stream);
        }        
        public ActionResult MailMergeExportTo(RichEditMailMergeModel model) {
            DocumentFormat documentFormat = ConvertIndexToFormat(model.ExportToDocumentType);
            Stream stream = ExecuteMerge(documentFormat, model.Data, model.Employee, model.Customer);
            if (stream == null)
                return new EmptyResult();
            return CreateFileStreamResult(stream, model.ExportToDocumentType);
        }
        Stream ExecuteMerge(DocumentFormat documentFormat, InMemoryNWindData data, Employee employee, Customer customer) {
            DataTable mailMergeDataTable = new DataTable();
            AddDataColumns(mailMergeDataTable);

            RichEditDocumentServer documentServer = CreateDocumentServer();
            IUriStreamService uriService = (IUriStreamService)documentServer.GetService(typeof(IUriStreamService));
            uriService.RegisterProvider(new RichEditMailMergeDBUriStreamProvider(mailMergeDataTable, "Photo", this));

            Stream result = null;
            if (!PutMergeData(mailMergeDataTable, employee, customer))
                return null;
            documentServer.LoadDocument(MapPath(MailMergeTemplateFilePath));
            documentServer.Options.MailMerge.DataSource = mailMergeDataTable;
            documentServer.Options.MailMerge.ViewMergedData = true;
            documentServer.Options.Export.Html.EmbedImages = true;
            result = new MemoryStream();
            if (documentFormat == DocumentFormat.Undefined) {
                documentServer.Options.MailMerge.ActiveRecord = 0;
                documentServer.ExportToPdf(result);
            }
            else {
                DevExpress.XtraRichEdit.API.Native.MailMergeOptions options = documentServer.CreateMailMergeOptions();
                options.DataSource = mailMergeDataTable;
                options.FirstRecordIndex = 0;
                options.LastRecordIndex = 0;
                documentServer.MailMerge(options, result, documentFormat);
            }
            result.Seek(0, SeekOrigin.Begin);
            return result;
        }
        void AddDataColumns(DataTable mailMergeDataTable) {
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
        bool PutMergeData(DataTable mailMergeDataTable, Employee employee, Customer customer) {
            mailMergeDataTable.Rows.Clear();
            mailMergeDataTable.Rows.Add(employee.EmployeeID,
                                        employee.FirstName,
                                        employee.LastName,
                                        customer.ContactName,
                                        employee.Address,
                                        employee.City,
                                        employee.PostalCode,
                                        customer.ContactTitle,
                                        customer.CompanyName,
                                        customer.Address,
                                        customer.City,
                                        customer.PostalCode,
                                        employee.Title,
                                        null);
            return true;
        }
    }

    public class RichEditMailMergeDBUriStreamProvider : IUriStreamProvider {
        static readonly string prefix = "dbimg://";
        DataTable table;
        string columnName;
        RichEditController pathMapper;

        public RichEditMailMergeDBUriStreamProvider(DataTable table, string columnName, RichEditController controller) {
            this.table = table;
            this.columnName = columnName;
            this.pathMapper = controller;
        }

        Stream IUriStreamProvider.GetStream(string uri) {
            uri = uri.Trim();
            if (!uri.StartsWith(prefix))
                return null;
            string strId = uri.Substring(prefix.Length).Trim();
            int id;
            if (!int.TryParse(strId, out id))
                return null;
            string pictureRoot = pathMapper.MapPath("~/App_Data/");
            string fileName = string.Format("{0}Photo{1}.jpeg", pictureRoot, id);
            byte[] bytes = null;
            using (FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read)) {
                int length = (int)fs.Length;
                bytes = new byte[length];
                fs.Read(bytes, 0, length);
            }
            return new MemoryStream(bytes);
        }
    }
}
