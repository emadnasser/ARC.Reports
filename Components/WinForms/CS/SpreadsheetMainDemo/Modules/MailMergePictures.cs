using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using DevExpress.Office.Utils;
using DevExpress.Spreadsheet;
using DevExpress.DataAccess;

namespace DevExpress.XtraSpreadsheet.Demos {
    public partial class MailMergePicturesModule : MailMergeModuleBase {
        protected override void LoadTemplate(SpreadsheetControl spreadsheetControl) {
            spreadsheetControl.Options.DataSourceOptions.ObjectDataSourceLoadingBehavior = DocumentLoadingBehavior.LoadAsIs;
            spreadsheetControl.Document.LoadDocument(DemoUtils.GetRelativePath("MailMergeTemplates\\EmployeesHorizontalTemplate.xlsx"));
            spreadsheetControl.Document.MailMergeParameters["SpreadsheetControl"].Value = spreadsheetControl;
        }
        protected override void LoadData(IWorkbook book) {
            ChangeFilter(book);
        }
        protected override bool ShowHideCommentsItem { get { return false; } }
        protected override void ChangeFilter(IWorkbook book) {
            EmployeePosition filter = EmployeePosition.None;
            if(ShowSalesManagers)
                filter |= EmployeePosition.SalesManager;
            if(ShowInsideSalesCoordinators)
                filter |= EmployeePosition.InsideSalesCoordinators;
            if(ShowSalesRepresentatives)
                filter |= EmployeePosition.SalesRepresentatives;
            book.MailMergeParameters["Position"].Value = filter;
        }
    }
    #region EmployeeInfo
    [Flags]
    public enum EmployeePosition {
        None = 0,
        Unknown = 1,
        SalesManager = 2,
        InsideSalesCoordinators = 4,
        SalesRepresentatives = 8
    }

    public class EmployeesInfo {
        #region StaticMembers
        static readonly Dictionary<string, EmployeePosition> employeePositionsTable = GenerateEmployeePositionsTable();
        static Dictionary<string, EmployeePosition> GenerateEmployeePositionsTable() {
            Dictionary<string, EmployeePosition> result = new Dictionary<string, EmployeePosition>();
            result.Add("Sales Manager", EmployeePosition.SalesManager);
            result.Add("Inside Sales Coordinator", EmployeePosition.InsideSalesCoordinators);
            result.Add("Sales Representative", EmployeePosition.SalesRepresentatives);
            return result;
        }

        #endregion
        readonly ISpreadsheetControl spreadsheetControl;
        public EmployeesInfo(ISpreadsheetControl spreadsheetControl) {
            this.spreadsheetControl = spreadsheetControl;
        }
        public IEnumerable<EmployeeInfo> GenerateReport(EmployeePosition employeePositionFilter) {
            List<EmployeeInfo> result = new List<EmployeeInfo>();
            if (spreadsheetControl == null || !spreadsheetControl.Document.Worksheets.Contains("Employees"))
                return result;
            Worksheet employeesWorksheet = spreadsheetControl.Document.Worksheets["Employees"];
            for (int i = 1; !employeesWorksheet[i, 0].Value.IsEmpty; i++) {
                Range employeeRange = employeesWorksheet.Range.FromLTRB(0, i, 14, i);
                EmployeeInfo employeeInfo = new EmployeeInfo(employeeRange);
                EmployeePosition employeePosition = ExtractEmployeePosition(employeeInfo.Title);
                if ((employeePosition & employeePositionFilter) != 0)
                    result.Add(employeeInfo);
            }
            return result;
        }
        EmployeePosition ExtractEmployeePosition(string textValue) {
            EmployeePosition result;
            if (!employeePositionsTable.TryGetValue(textValue, out result))
                result = EmployeePosition.Unknown;
            return result;
        }
    }

    public class EmployeeInfo {
        #region Properties
        public string LastName { get; private set; }
        public string FirstName { get; private set; }
        public string Title { get; private set; }
        public string TitleOfCourtesy { get; private set; }
        public DateTime BirthDate { get; private set; }
        public DateTime HireDate { get; private set; }
        public string Address { get; private set; }
        public string City { get; private set; }
        public string Region { get; private set; }
        public string PostalCode { get; private set; }
        public string Country { get; private set; }
        public string HomePhone { get; private set; }
        public string Extension { get; private set; }
        public Bitmap Photo { get; private set; }
        public string Notes { get; private set; }
        #endregion
        public EmployeeInfo(Range range) {
            LastName = range[0].Value.TextValue;
            FirstName = range[1].Value.TextValue;
            Title = range[2].Value.TextValue;
            TitleOfCourtesy = range[3].Value.TextValue;
            BirthDate = range[4].Value.DateTimeValue;
            HireDate = range[5].Value.DateTimeValue;
            Address = range[6].Value.TextValue;
            City = range[7].Value.TextValue;
            Region = range[8].Value.TextValue;
            PostalCode = range[9].Value.TextValue;
            Country = range[10].Value.TextValue;
            HomePhone = range[11].Value.TextValue;
            Extension = range[12].Value.TextValue;
            Notes = range[14].Value.TextValue;
            Photo = null;
            IList<Picture> picturesByName = range.Worksheet.Pictures.GetPicturesByName(LastName);
            if (picturesByName.Count != 0) {
                Photo = new Bitmap(new MemoryStream(picturesByName[0].Image.GetImageBytes(OfficeImageFormat.Bmp)));
            }
        }
    }
    #endregion
}
