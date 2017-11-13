using System;
using System.Drawing;
using DevExpress.Utils;
using System.Windows.Forms;
using DevExpress.Spreadsheet;
using DevExpress.DXperience.Demos;

namespace DevExpress.Docs.Demos {
    public partial class SpreadsheetCellArtModule : TutorialControlBase {
        public SpreadsheetCellArtModule() {
            InitializeComponent();
            pictureEdit.Image = Image.FromFile(DemoUtils.GetRelativePath("DevExpress.png"));
        }
        void loadButton_Click(object sender, EventArgs e) {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "All image files (*.bmp,*.jpg,*.jpeg,*.png,*.gif)|*.bmp;*.jpg;*.jpeg;*.png;*.gif|BMP files(*.bmp)|*.bmp|JPG files(*.jpg, *.jpeg)|*.jpg;*.jpeg|PNG files(*.png)|*.png|GIF files(*.gif)|*.gif|All files (*.*)|*.*";
            if(ofd.ShowDialog() != DialogResult.OK)
                return;
            pictureEdit.Image = Image.FromFile(ofd.FileName);
        }       
        void saveButton_Click(object sender, EventArgs e) {
            string fileName = SpreadsheetTutorialControl.GetSaveFileName("Cell_Art");
            if(pictureEdit.Image == null || string.IsNullOrEmpty(fileName))
                return;
            Bitmap bitmap = pictureEdit.Image as Bitmap;
            if(bitmap == null)
                return;
            CellArtDocumentGenerator documentGenerator = new CellArtDocumentGenerator(bitmap);
            IWorkbook book = documentGenerator.Generate();
            book.SaveDocument(fileName, DocumentFormat.OpenXml);
            SpreadsheetTutorialControl.ShowFile(fileName, this);
        }
    }
}
