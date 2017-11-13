using System;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.IO;
using System.Web.UI;
using DevExpress.Internal;
using DevExpress.Spreadsheet;
using DevExpress.Web.Demos;
using DevExpress.XtraSpreadsheet.API.Native.Implementation;

public partial class Features_Images: OfficeDemoPage {
    protected string ConnectionString {
        get {
            string sqlExpressString = ConfigurationManager.ConnectionStrings["NorthwindConnectionString"].ConnectionString;
            return DbEngineDetector.PatchConnectionString(sqlExpressString);                    
        }
    }

    protected void Page_Load(object sender, EventArgs e) {
        SpreadsheetDemoUtils.HideFileTab(Spreadsheet);

        if(Page.IsPostBack)
            return;

        string filePath = Path.Combine(DirectoryManagmentUtils.CurrentDataDirectory, "AddressBook.xlsx");
        Spreadsheet.Open(filePath);

        DataTable employees = GetEmployees();
        AddEmployesToSpreadsheet(employees);

        Spreadsheet.Document.History.Clear();
    }
    DataTable GetEmployees() {
        string query = @"SELECT [LastName], [FirstName], [BirthDate], [Country], [City], [Address], [HomePhone], [Photo] FROM [Employees]";

        DataTable employees = new DataTable();

        using(var connection = new SqlConnection(ConnectionString)) 
        using(var dataAdapter = new SqlDataAdapter(query, connection)) {
            connection.Open();
            
            dataAdapter.Fill(employees);
            
            connection.Close();
        }

        return employees;
    }
    void AddEmployesToSpreadsheet(DataTable employees) {
        Worksheet worksheet = Spreadsheet.Document.Worksheets.ActiveWorksheet;
        if(worksheet.Shapes.Count > 0)
            return;

        const int StartAddressRowOffset = 4;
        int employeesCount = employees.Rows.Count;
        CreateRequiredRows(worksheet, employeesCount, StartAddressRowOffset);
        for(var i = 0; i < employeesCount; i++) {
            var rowOffset = StartAddressRowOffset + i;
            DataRow employee = employees.Rows[i];
            worksheet["C" + rowOffset].Value = string.Format("{0} {1}", employee["FirstName"], employee["LastName"]);
            worksheet["D" + rowOffset].Value = employee.Field<DateTime>("BirthDate");
            worksheet["E" + rowOffset].Value = employee.Field<string>("Country");
            worksheet["F" + rowOffset].Value = employee.Field<string>("City");
            worksheet["G" + rowOffset].Value = employee.Field<string>("Address");
            worksheet["H" + rowOffset].Value = employee.Field<string>("HomePhone");
            MemoryStream photoMemoryStream = new MemoryStream(employee.Field<byte[]>("Photo"));
            worksheet.Pictures.AddPicture(new StreamDocumentImageSource(photoMemoryStream), worksheet["B" + rowOffset]);
        }
    }
    void CreateRequiredRows(Worksheet worksheet, int rowsCount, int startAddressRowOffset) {
        var sourceStyleRow = worksheet.Rows[startAddressRowOffset - 1];
        for(var i = 0; i < rowsCount; i++) {
            var rowOffset = startAddressRowOffset + i;
            if(rowOffset > startAddressRowOffset)
                worksheet.Rows[rowOffset - 1].CopyFrom(sourceStyleRow);
        }
    }
}
