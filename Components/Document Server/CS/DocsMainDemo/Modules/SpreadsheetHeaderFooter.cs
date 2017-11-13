using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DevExpress.Spreadsheet;

namespace DevExpress.Docs.Demos {
    public partial class HeaderFooter : SpreadsheetTutorialControl  {
        public HeaderFooter() {
            InitializeComponent();
            FitToPageCheckEdit.Checked = true;
            RefreshPreview();
            SpreadsheetTutorialPanel.Dock = DockStyle.Fill;
        }
        protected override string DefaultFileName { get { return "HeaderFooter"; } }
                
        void InitializePreviewControl() {
            SpreadsheetTutorialPanel.Location = Point.Empty;
        }
        public override IWorkbook CreateBook() {
            InitializePreviewControl();
            IWorkbook book = new Workbook();
            book.LoadDocument(DemoUtils.GetRelativePath("HeaderFooter_template.xlsx"));
            return book;
        }
    }
}
