using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DevExpress.Docs.Demos;
using DevExpress.Spreadsheet;
using DevExpress.XtraReports.UI;
using System.Globalization;

public partial class Spreadsheet_MailMerge : System.Web.UI.Page {
    protected void Page_Load(object sender, EventArgs e) {
        if(this.previewControl.CanShowPreview()) {
            MailMergePreviewParams previewParams = ParsePreview(Request.Params);
            RefreshPreview(previewParams);
            return;
        }
        this.previewControl.Workbook = CreateWorkbook();
    }
    IWorkbook CreateWorkbook() {
        return CreateWorkbook(teStatementNumber.Text, teCustomerID.Text, teCustomerName.Text, teStreetAddress.Text, teCity.Text, teState.Text, teZipCode.Text, tePhone.Text, teEmail.Text, true);
    }

    IWorkbook CreateWorkbook(string statementNumber, string customerId, string customerName, string streetAddress, string city, string state, string zipCode, string phone, string email, bool fitToPage) {
        MailMergeDocumentGenerator example = new MailMergeDocumentGenerator(new CultureInfo("en-US"));
        example.StatementNumber = statementNumber;
        example.CustomerId = customerId;
        example.CustomerName = customerName;
        example.Street = streetAddress;
        example.City = city;
        example.State = state;
        example.ZIP = zipCode;
        example.Phone = phone;
        example.Email = email;
        example.Path = Page.MapPath("~/App_Data/Billing_statement.xlsx");
        example.FitToPage = fitToPage;
        return example.Generate();
    }
    protected void OnDocumentDownloaderRequestWorkbook(object sender, RequestWorkbookEventArgs args) {
        args.Workbook = CreateWorkbook();
    }
    void RefreshPreview(MailMergePreviewParams previewParams) {
        IWorkbook book = CreateWorkbook(previewParams.StatementNumber, previewParams.CustomerID, previewParams.CustomerName, previewParams.StreetAddress, previewParams.City, previewParams.State, previewParams.ZipCode, previewParams.Phone, previewParams.Email, previewParams.FitToPage);
        this.previewControl.Workbook = book;
        this.previewControl.RenderSpreadsheetPreview();
    }
    MailMergePreviewParams ParsePreview(System.Collections.Specialized.NameValueCollection nameValueCollection) {
        MailMergePreviewParams previewParams = new MailMergePreviewParams();
        string statementNumberStringValue = nameValueCollection["statementNumber"];
        string streetAddressStringValue = nameValueCollection["streetAddress"];
        string zipCodeStringValue = nameValueCollection["zipCode"];
        string customerIDStringValue = nameValueCollection["customerID"];
        string сityStringValue = nameValueCollection["city"];
        string phoneStringValue = nameValueCollection["phone"];
        string customerNameStringValue = nameValueCollection["customerName"];
        string stateStringValue = nameValueCollection["state"];
        string emailStringValue = nameValueCollection["email"];

        previewParams.StatementNumber = (String.IsNullOrEmpty(statementNumberStringValue)) ? this.teStatementNumber.Text : statementNumberStringValue;
        previewParams.StreetAddress = (String.IsNullOrEmpty(streetAddressStringValue)) ? this.teStreetAddress.Text : streetAddressStringValue;
        previewParams.ZipCode = (String.IsNullOrEmpty(zipCodeStringValue)) ? this.teZipCode.Text : zipCodeStringValue;
        previewParams.CustomerID = (String.IsNullOrEmpty(customerIDStringValue)) ? this.teCustomerID.Text : customerIDStringValue;
        previewParams.City = (String.IsNullOrEmpty(сityStringValue)) ? this.teCity.Text : сityStringValue;
        previewParams.Phone = (String.IsNullOrEmpty(phoneStringValue)) ? this.tePhone.Text : phoneStringValue;
        previewParams.CustomerName = (String.IsNullOrEmpty(customerNameStringValue)) ? this.teCustomerName.Text : customerNameStringValue;
        previewParams.State = (String.IsNullOrEmpty(stateStringValue)) ? this.teState.Text : stateStringValue;
        previewParams.Email = (String.IsNullOrEmpty(emailStringValue)) ? this.teEmail.Text : emailStringValue;
        previewParams.FitToPage = true;
        return previewParams;
    }
}
public class MailMergePreviewParams {
    public string StatementNumber { get; set; }
    public string StreetAddress { get; set; }
    public string ZipCode { get; set; }
    public string CustomerID { get; set; }
    public string City { get; set; }
    public string Phone { get; set; }
    public string CustomerName { get; set; }
    public string State { get; set; }
    public string Email { get; set; }
    public bool FitToPage { get; set; }
}
