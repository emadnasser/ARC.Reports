using System;
using DevExpress.Spreadsheet;
using System.Globalization;

namespace DevExpress.Docs.Demos {
    public class MailMergeDocumentGenerator {
        CultureInfo culture;
        public MailMergeDocumentGenerator(CultureInfo culture) {
            this.culture = culture;
            FitToPage = true;
        }

        public string StatementNumber {get; set;}
        public string CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZIP { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Path { get; set; }
        public bool FitToPage { get; set; }

        public IWorkbook Generate() {
            return CreateBook();
        }

        IWorkbook CreateBook() {
            IWorkbook book = new Workbook();
            book.Options.Culture = culture;
            book.LoadDocument(Path);
            FillData(book);
            book.Worksheets[0].PrintOptions.FitToPage = FitToPage;
            foreach (Cell cell in book.Worksheets[0].GetExistingCells()) {
                if (cell.DisplayText.Contains("[Statement]"))
                    cell.Value = cell.DisplayText.Replace("[Statement]", StatementNumber);
                if (cell.DisplayText.Contains("[ABC12345]"))
                    cell.Value = cell.DisplayText.Replace("[ABC12345]", CustomerId);
                if (cell.DisplayText.Contains("[Name]"))
                    cell.Value = cell.DisplayText.Replace("[Name]", CustomerName);
                if (cell.DisplayText.Contains("[Street Address]"))
                    cell.Value = cell.DisplayText.Replace("[Street Address]", Street);
                if (cell.DisplayText.Contains("[City]"))
                    cell.Value = cell.DisplayText.Replace("[City]", City);
                if (cell.DisplayText.Contains("[ST]"))
                    cell.Value = cell.DisplayText.Replace("[ST]", State);
                if (cell.DisplayText.Contains("[ZIP Code]"))
                    cell.Value = cell.DisplayText.Replace("[ZIP Code]", ZIP);
                if (cell.DisplayText.Contains("[Phone]"))
                    cell.Value = cell.DisplayText.Replace("[Phone]", Phone);
                if (cell.DisplayText.Contains("[E-mail]"))
                    cell.Value = cell.DisplayText.Replace("[E-mail]", Email);
            }
            return book;
        }

        void FillData(IWorkbook book) {
            for (int i = 14; i < 22; i++) {
                book.Worksheets[0].Cells[i, 0].Value = DateTime.Today;
            }
            book.Worksheets[0].Cells["B15"].Value = "Konbu";
            book.Worksheets[0].Cells["B16"].Value = "Genen Shouyu";
            book.Worksheets[0].Cells["B17"].Value = "Alice Mutton";
            book.Worksheets[0].Cells["B18"].Value = "Sasquatch Ale";
            book.Worksheets[0].Cells["B19"].Value = "Singaporean Hokkien Fried Mee";
            book.Worksheets[0].Cells["B20"].Value = "Manjimup Dried Apples";
            book.Worksheets[0].Cells["B21"].Value = "Perth Pasties";
            book.Worksheets[0].Cells["B22"].Value = "Laughing Lumberjack Lager";

            book.Worksheets[0].Cells["F15"].Value = 102;
            book.Worksheets[0].Cells["F16"].Value = 124;
            book.Worksheets[0].Cells["F17"].Value = 624;
            book.Worksheets[0].Cells["F18"].Value = 238;
            book.Worksheets[0].Cells["F19"].Value = 28;
            book.Worksheets[0].Cells["F20"].Value = 530;
            book.Worksheets[0].Cells["F21"].Value = 459.2;
            book.Worksheets[0].Cells["F22"].Value = 140;
        }
    }
}
