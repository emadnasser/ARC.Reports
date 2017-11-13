using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.IO;
using System.Xml.Serialization;
using DevExpress.Web.Demos;
using DevExpress.Spreadsheet;

public partial class MailMerge_DataMerging: OfficeDemoPage {
    const int StartRowIndex = 10,
              MaxReportRowsCount = 15;

    protected Worksheet Worksheet { get { return Spreadsheet.Document.Worksheets.ActiveWorksheet; } }

    protected void Page_Load(object sender, EventArgs e) {
        SpreadsheetDemoUtils.HideFileTab(Spreadsheet);

        if(Page.IsPostBack)
            return;

        var filePath = Path.Combine(DirectoryManagmentUtils.CurrentDataDirectory, "ExpenseReport.xlsx");
        Spreadsheet.Open(filePath);

        var expenses = LoadExpensesReportData();
        FillGeneralReportInfo(expenses.Info);
        FillReport(expenses.Expenses);
        Spreadsheet.Document.Worksheets.ActiveWorksheet.ActiveView.ShowGridlines = false;
        Spreadsheet.Document.History.Clear();
    }
    ExpensesReport LoadExpensesReportData() {
        using(Stream stream = File.OpenRead(HttpContext.Current.Server.MapPath("~/App_Data/Expenses.xml"))) {
            XmlSerializer serializer = new XmlSerializer(typeof(ExpensesReport));
            return (ExpensesReport)serializer.Deserialize(stream);
        }
    }
    void FillGeneralReportInfo(ExpensesInfo info) {
        Worksheet["D2"].Value = info.Purpose;
        Worksheet["D3"].Value = info.StatementNumber;

        Worksheet["C7"].Value = info.EmployeeName;
        Worksheet["C8"].Value = info.EmployeeDepartment;
        Worksheet["G7"].Value = info.EmployeePosition;
        Worksheet["G8"].Value = info.Manager;
        Worksheet["K7"].Value = info.SSN;
        Worksheet["K8"].Value = info.EmployeeID;
    }
    void FillReport(List<Expense> report) {
        int reportCount = Math.Min(report.Count, MaxReportRowsCount);
        for(int i = 0; i < reportCount; i++) {
            Expense expense = report[i];
            int rowOffset = StartRowIndex + i + 1;
            Worksheet["B" + rowOffset].Value = expense.CreationDate;
            Worksheet["C" + rowOffset].Value = expense.Account;
            Worksheet["D" + rowOffset].Value = expense.Description;
            Worksheet["F" + rowOffset].Value = expense.Hotel;
            Worksheet["H" + rowOffset].Value = expense.Transport;
            Worksheet["I" + rowOffset].Value = expense.Fuel;
            Worksheet["J" + rowOffset].Value = expense.Meals;
            Worksheet["L" + rowOffset].Value = expense.Phone;
            Worksheet["M" + rowOffset].Value = expense.Entertainment;
            Worksheet["N" + rowOffset].Value = expense.Misc;
        }
    }
}
