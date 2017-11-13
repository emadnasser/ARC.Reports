using System.Drawing;
using DevExpress.Spreadsheet;
using System.Globalization;
using System.Windows.Forms;

namespace DevExpress.Docs.Demos {
    public class SpreadsheetPictureGalleryModule : SpreadsheetTutorialControl {
        public SpreadsheetPictureGalleryModule() {
            FitToPageCheckEdit.Checked = true;
            RefreshPreview();
            SpreadsheetTutorialPanel.Dock = DockStyle.Fill;
        }
            
        protected override string DefaultFileName {
            get {
                return "Picture_Gallery";
            }
        }
        protected override string DefaultSaveFileFilter {
            get {
                return "Excel Workbook(*.xlsx)|*.xlsx|PDF(*.pdf)|*.pdf";
            }
        }

        public override IWorkbook CreateBook() {
            IWorkbook book = new Workbook();
            book.Options.Culture = DefaultCulture;
            book.Worksheets[0].ActiveView.Orientation = DevExpress.Spreadsheet.PageOrientation.Landscape;
            book.Worksheets[0].ActiveView.PaperKind = System.Drawing.Printing.PaperKind.A4;
            book.Worksheets[0].ActiveView.Margins.Left = 300;
            book.Worksheets[0].ActiveView.Margins.Top = 300;
            book.Worksheets[0].PrintOptions.FitToPage = FitToPageCheckEdit.Checked;

            InitializePreviewControl();
            LoadPictures(book);
            return book;
        }
        void LoadPictures(IWorkbook book) {
            Style style = book.Styles["Normal"];
            style.Fill.BackgroundColor = System.Drawing.Color.FromArgb(128, 128, 128);
            Worksheet sheet = book.Worksheets[0];
            sheet.Pictures.AddPicture(DemoUtils.GetRelativePath("Images\\image1.jpg"), sheet.Range["A3:E13"]);
            sheet.Pictures.AddPicture(DemoUtils.GetRelativePath("Images\\image4.jpg"), sheet.Range["G3:K13"]);
            sheet.Pictures.AddPicture(DemoUtils.GetRelativePath("Images\\image5.jpg"), sheet.Range["M3:Q13"]);
            sheet.Pictures.AddPicture(DemoUtils.GetRelativePath("Images\\image6.jpg"), sheet.Range["A20:E30"]);
            sheet.Pictures.AddPicture(DemoUtils.GetRelativePath("Images\\image3.jpg"), sheet.Range["G20:K30"]);
            sheet.Pictures.AddPicture(DemoUtils.GetRelativePath("Images\\image2.jpg"), sheet.Range["M20:Q30"]);
        }

        void InitializePreviewControl() {
            CanShowBorders = false;
            SpreadsheetTutorialPanel.Location = Point.Empty;
        }
    }
}
