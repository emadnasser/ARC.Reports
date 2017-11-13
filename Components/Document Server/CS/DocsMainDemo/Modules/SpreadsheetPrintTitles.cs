using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DevExpress.Spreadsheet;

namespace DevExpress.Docs.Demos {
    public partial class PrintTitles : SpreadsheetTutorialControl  {
        public PrintTitles() {
            InitializeComponent();
            FitToPageCheckEdit.Visible = false;
            FitToPageCheckEdit.Checked = false;
            RefreshPreview();
            SpreadsheetTutorialPanel.Dock = DockStyle.Fill;
        }
        protected override string DefaultFileName { get { return "PrintTitles"; } }
                
        void InitializePreviewControl() {
            SpreadsheetTutorialPanel.Location = Point.Empty;
        }
        public override IWorkbook CreateBook() {
            InitializePreviewControl();
            IWorkbook book = new Workbook();
            book.LoadDocument(DemoUtils.GetRelativePath("PrintTitles_template.xlsx"));
            return book;
        }
        //protected override void RefreshPreview() {
            //base.RefreshPreview();
            //this.spreadsheetPreview1.ExecCommand(DevExpress.XtraPrinting.PrintingSystemCommand.ZoomToTwoPages);
        //}
    }
}
