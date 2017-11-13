using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraTab;
using DevExpress.Spreadsheet;
using DevExpress.XtraPrintingLinks;
using DevExpress.XtraPrinting.Control;
using DevExpress.XtraPrinting;

namespace DevExpress.Docs.Demos {
    public partial class SpreadsheetPreview : UserControl {
        IWorkbook _workbook;
        Dictionary<PrintControl, PrintableComponentLinkBase> pcCache;

        public SpreadsheetPreview() {
            InitializeComponent();
            this.pcCache = new Dictionary<PrintControl, PrintableComponentLinkBase>();
            this.xtraTabControl1.TabPages.Clear();
            UpdatePreview();
        }

        public bool CanShowBorders { get; set; }
        public IWorkbook Workbook {
            get {
                return _workbook;
            }
            set {
                _workbook = value;
            }
        }
        public void UpdatePreview() {
            if(Workbook == null)
                return;
            int count = Workbook.Worksheets.Count;
            this.documentViewerSinglePreview.Visible = false;
            this.xtraTabControl1.Visible = false;
            if(count < 2)
                UpdateWorkbookSinglePreview();
            else
                UpdateMultipleSheetPreview();
        }
        void UpdateWorkbookSinglePreview() {
            this.documentViewerSinglePreview.Visible = true;
            UpdateDocumentViewerProperties(this.documentViewerSinglePreview);
            if(this.documentViewerSinglePreview.PrintingSystem == null)
                this.documentViewerSinglePreview.PrintingSystem = new PrintingSystemBase();
            PrintableComponentLinkBase link = new PrintableComponentLinkBase(this.documentViewerSinglePreview.PrintingSystem);
            link.Component = Workbook;
            link.CreateDocument();
        }        
        void UpdateMultipleSheetPreview() {
            this.xtraTabControl1.Visible = true;
            int count = Workbook.Worksheets.Count;
            List<PrintControl> usedPrintControls = new List<PrintControl>();
            for(int i = 0; i < count; i++) {
                Worksheet sheet = Workbook.Worksheets[i];
                PrintControl pc = EnsurePrintControl(i, sheet.Name);
                PrintableComponentLinkBase link = ObtainLinkFrom(pc);
                UpdateSheetPreview(sheet, link);
                usedPrintControls.Add(pc);
            }
            ClearPrintControlCache(usedPrintControls);
        }
        void ClearPrintControlCache(List<PrintControl> usedPrintControls) {
            List<PrintControl> toClear = new List<PrintControl>();
            foreach(KeyValuePair<PrintControl, PrintableComponentLinkBase> pc in this.pcCache) {
                if(!usedPrintControls.Contains(pc.Key))
                    toClear.Add(pc.Key);
            }
            foreach(PrintControl item in toClear)
                this.pcCache.Remove(item);
        }
        void UpdateSheetPreview(Worksheet sheet, PrintableComponentLinkBase link) {
            IPrintable printable = sheet as IPrintable;
            link.Component = printable;
            link.CreateDocument();
        }
        PrintableComponentLinkBase ObtainLinkFrom(PrintControl pc) {
            if(this.pcCache.ContainsKey(pc))
                return this.pcCache[pc];
            PrintableComponentLinkBase link = new PrintableComponentLinkBase(pc.PrintingSystem);
            this.pcCache.Add(pc, link);
            return link;
        }
        PrintControl EnsurePrintControl(int i, string caption) {
            XtraTabPageCollection tabPages = this.xtraTabControl1.TabPages;
            XtraTabPage page = (i < tabPages.Count) ? tabPages[i] : CreateNewTabPage();
            page.Text = caption;
            if(page.Controls.Count == 1 && page.Controls[0] is PrintControl)
                return page.Controls[0] as PrintControl;
            PrintControl pc = new PrintControl();
            pc.PrintingSystem = new PrintingSystemBase();
            pc.Dock = DockStyle.Fill;
            page.Controls.Clear();
            page.Controls.Add(pc);
            UpdatePrintControlProperties(pc);
            return pc;
        }
        private void UpdateDocumentViewerProperties(XtraPrinting.Preview.DocumentViewer documentViewer) {
            if(documentViewer == null || CanShowBorders)
                return;
            documentViewer.PageBorderVisibility = DevExpress.DocumentView.PageBorderVisibility.None;
            documentViewer.ShowPageMargins = false;
            if(documentViewer.PrintingSystem != null)
                documentViewer.PrintingSystem.Graph.PageBackColor = Color.Gray;
            documentViewer.ExecCommand(DevExpress.XtraPrinting.PrintingSystemCommand.ZoomToWholePage);            
        }
        void UpdatePrintControlProperties(PrintControl pc) {
            if(pc == null || CanShowBorders)
                return;
            pc.PageBorderVisibility = DevExpress.DocumentView.PageBorderVisibility.None;
            pc.ShowPageMargins = false;
            pc.PrintingSystem.Graph.PageBackColor = Color.Gray;
            pc.ExecCommand(DevExpress.XtraPrinting.PrintingSystemCommand.ZoomToWholePage);            
        }
        XtraTabPage CreateNewTabPage() {
            XtraTabPage tabPage = new XtraTabPage();
            this.xtraTabControl1.TabPages.Add(tabPage);
            return tabPage;
        }
    }
}
