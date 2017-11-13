using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DevExpress.Spreadsheet;
using DevExpress.XtraSpreadsheet.Services;
using DevExpress.XtraSpreadsheet.Services.Implementation;

namespace DevExpress.Docs.Demos {
    public partial class BreakevenAnalysis : SpreadsheetTutorialControl  {
        public BreakevenAnalysis() {
            InitializeComponent();
            FitToPageCheckEdit.Checked = true;
            RefreshPreview();
            SpreadsheetTutorialPanel.Dock = DockStyle.Fill;
        }
        protected override string DefaultFileName { get { return "BreakevenAnalysis"; } }
                
        void InitializePreviewControl() {
            SpreadsheetTutorialPanel.Location = Point.Empty;
        }
        public override IWorkbook CreateBook() {
            InitializePreviewControl();
            IWorkbook book = new Workbook();
            book.AddService(typeof(IChartControllerFactoryService), new ChartControllerFactoryService());
            book.AddService(typeof(IChartImageService), new ChartImageService());            
            book.LoadDocument(DemoUtils.GetRelativePath("BreakevenAnalysis.xlsx"));
            return book;
        }
    }
}
