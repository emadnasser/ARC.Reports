using System;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.IO;
using DevExpress.Internal;
using DevExpress.Spreadsheet;
using DevExpress.Web.Demos;

public partial class MailMerge_MailMerge : OfficeDemoPage { 
    protected string ConnectionString {
        get {
            string sqlExpressString = ConfigurationManager.ConnectionStrings["NorthwindConnectionString"].ConnectionString;
            return DbEngineDetector.PatchConnectionString(sqlExpressString);                    
        }
    }


    protected void Page_Load(object sender, EventArgs e) {
        if(!IsCallback) {
            IWorkbook resultingWorkbook = GenerateMailMergeDocument();
            if(resultingWorkbook != null)
                OpenResultingDocument(resultingWorkbook);
            SpreadsheetDemoUtils.HideFileTab(Spreadsheet);
        }
    }

    IWorkbook GenerateMailMergeDocument() {
        IWorkbook workbook = Spreadsheet.Document;
        LoadMailMergeTemplate(workbook);
        workbook.MailMergeDataSource = GetMailMergeDataSource();
        SetMailMergeMode(workbook);
        return workbook.GenerateMailMergeDocuments()[0];
    }
    DataTable GetMailMergeDataSource() {
        string query = @"SELECT [LastName], [FirstName], [BirthDate], [Country], [City], [Address], [Title], [Notes], [HomePhone], [Photo] FROM [Employees]";

        DataTable employees = new DataTable();

        using(var connection = new SqlConnection(ConnectionString)) 
        using(var dataAdapter = new SqlDataAdapter(query, connection)) {
            connection.Open();
            
            dataAdapter.Fill(employees);
            
            connection.Close();
        }

        return employees;
    }

    void LoadMailMergeTemplate(IWorkbook workbook) {
        workbook.LoadDocument(Path.Combine(DirectoryManagmentUtils.CurrentDataDirectory, @"EmployeesHorizontalTemplate.xlsx"));
    }
    void SetMailMergeMode(IWorkbook workbook) {
        string mode = rblMailMergeMode.Value.ToString();
        workbook.DefinedNames.GetDefinedName("MAILMERGEMODE").RefersTo = string.Format("\"{0}\"", mode);
        if(mode == "Worksheets")
            workbook.Worksheets[0].Columns[2].Width = 2440;
    }
    void OpenResultingDocument(IWorkbook resultingWorkbook) {
        using(MemoryStream result = new MemoryStream()) {
            foreach(Worksheet worksheet in resultingWorkbook.Worksheets)
                worksheet.Shapes[0].Left = (float)(worksheet.Columns[0].Width + (worksheet.Columns[1].Width - worksheet.Shapes[0].Width) / 2);
            resultingWorkbook.SaveDocument(result, DocumentFormat.OpenXml);
            result.Seek(0, SeekOrigin.Begin);
            Spreadsheet.Open(Guid.NewGuid().ToString(), DocumentFormat.OpenXml, () => { return result; });
        }
    }
}
