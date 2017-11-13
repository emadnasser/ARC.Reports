using System;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.Utils.Menu;
using DevExpress.XtraBars;
using DevExpress.DXperience.Demos;
using DevExpress.XtraRichEdit.Localization;
using DevExpress.XtraBars.Ribbon;

namespace DevExpress.XtraRichEdit.Demos {
    public class TutorialControl : TutorialControlBase, IDXMenuManager {
        private LookAndFeelMenu menu = null;
        IDXMenuManager fMenuManager;

        public TutorialControl() { }

        public override bool AutoMergeRibbon {
            get {
                return true;
            }
        }
        public virtual RichEditControl PrintingRichEditControl { get { return null; } }

        public LookAndFeelMenu DemoMainMenu {
            get { return menu; }
            set {
                if (menu == value) return;
                this.menu = value;
            }
        }

        void IDXMenuManager.ShowPopupMenu(DXPopupMenu menu, Control control, Point pos) {
            MenuManagerHelper.ShowMenu(menu, LookAndFeel, fMenuManager, control, pos);
        }
        IDXMenuManager IDXMenuManager.Clone(Form newForm) { return this; }
        void IDXMenuManager.DisposeManager() { }

        public IDXMenuManager MenuManager {
            get { return fMenuManager; }
            set { fMenuManager = value; }
        }

        public virtual bool ShowOptions { get { return false; } } //TODO

        void OnSwitchStyle(object sender, EventArgs e) {
            OnSwitchStyle();
            //MessageBox.Show("Style Changed: " + AppearanceMenu.NeedPaintAppearance.ToString());
        }
        protected override void SetControlManager(Control ctrl, BarManager manager) {
            DevExpress.XtraRichEdit.RichEditControl richEdit = ctrl as DevExpress.XtraRichEdit.RichEditControl;
            if (richEdit != null) richEdit.MenuManager = manager;
            BaseEdit be = ctrl as BaseEdit;
            if (be != null) be.MenuManager = manager;
        }
        protected override void AllowExport() {
            EnabledPrintExportActions(true, true, ExportFormats.DOC | ExportFormats.DOCX | ExportFormats.EPUB |
                ExportFormats.HTML | ExportFormats.MHT | ExportFormats.ODT | ExportFormats.PDF | ExportFormats.RTF |
                ExportFormats.Text | ExportFormats.XML, false);
        }
        protected override void DoShow() {
            base.DoShow();
            if (PrintingRichEditControl != null)
                PrintingRichEditControl.LayoutUnit = DocumentLayoutUnit.Pixel;
            MergeRibbon();
        }
        void MergeRibbon() {
            if (ParentFormMain == null)
                return;
            RibbonControl parentRibbon = ParentFormMain.Ribbon;
            RibbonPage page = parentRibbon.MergedPages["File"];
            RibbonPageGroup group = ParentFormMain.ReservGroup1.Page.Groups["rpgAbout"];
            if (page == null || group == null)
                return;
            page.Groups.Add((RibbonPageGroup)group.Clone());
        }
        #region Print and Export
        protected override void ExportToCore(String filename, string ext) {
            if (PrintingRichEditControl == null) return;
            Cursor oldCursor = Cursor.Current;
            Cursor.Current = Cursors.WaitCursor;
            if (ext == "pdf") PrintingRichEditControl.ExportToPdf(filename);
            if (ext == "html") PrintingRichEditControl.SaveDocument(filename, DocumentFormat.Html);
            if (ext == "mht") PrintingRichEditControl.SaveDocument(filename, DocumentFormat.Mht);
            if (ext == "doc") PrintingRichEditControl.SaveDocument(filename, DocumentFormat.Doc);
            if (ext == "docx") PrintingRichEditControl.SaveDocument(filename, DocumentFormat.OpenXml);
            if (ext == "rtf") PrintingRichEditControl.SaveDocument(filename, DocumentFormat.Rtf);
            if (ext == "txt") PrintingRichEditControl.SaveDocument(filename, DocumentFormat.PlainText);
            if (ext == "odt") PrintingRichEditControl.SaveDocument(filename, DocumentFormat.OpenDocument);
            if (ext == "epub") PrintingRichEditControl.SaveDocument(filename, DocumentFormat.ePub);
            if (ext == "xml") PrintingRichEditControl.SaveDocument(filename, DocumentFormat.WordML);
            Cursor.Current = oldCursor;
        }
        protected override void ExportToPDF() {
            ExportTo("pdf", XtraRichEditLocalizer.GetString(XtraRichEditStringId.FileFilterDescription_PDFFiles) + " (*.pdf)|*.pdf");
        }
        protected override void ExportToHTML() {
            ExportTo("html", XtraRichEditLocalizer.GetString(XtraRichEditStringId.FileFilterDescription_HtmlFiles) + " (*.html)|*.html");
        }
        protected override void ExportToMHT() {
            ExportTo("mht", XtraRichEditLocalizer.GetString(XtraRichEditStringId.FileFilterDescription_MhtFiles) + " (*.mht)|*.mht");
        }
        protected override void ExportToDOC() {
            ExportTo("doc", XtraRichEditLocalizer.GetString(XtraRichEditStringId.FileFilterDescription_DocFiles) + " (*.doc)|*.doc");
        }
        protected override void ExportToDOCX() {
            ExportTo("docx", XtraRichEditLocalizer.GetString(XtraRichEditStringId.FileFilterDescription_OpenXmlFiles) + " (*.docx)|*.docx");
        }
        protected override void ExportToRTF() {
            ExportTo("rtf", XtraRichEditLocalizer.GetString(XtraRichEditStringId.FileFilterDescription_RtfFiles) + " (*.rtf)|*.rtf");
        }
        protected override void ExportToText() {
            ExportTo("txt", XtraRichEditLocalizer.GetString(XtraRichEditStringId.FileFilterDescription_TextFiles) + " (*.txt)|*.txt");
        }
        protected override void ExportToODT() {
            ExportTo("odt", XtraRichEditLocalizer.GetString(XtraRichEditStringId.FileFilterDescription_OpenDocumentFiles) + " (*.odt)|*.odt");
        }
        protected override void ExportToEPUB() {
            ExportTo("epub", XtraRichEditLocalizer.GetString(XtraRichEditStringId.FileFilterDescription_ePubFiles) + " (*.epub)|*.epub");
        }
        protected override void ExportToXML() {
            ExportTo("xml", XtraRichEditLocalizer.GetString(XtraRichEditStringId.FileFilterDescription_WordMLFiles) + " (*.xml)|*.xml");
        }
        protected override void PrintPreview() {
            if (PrintingRichEditControl != null)
                PrintingRichEditControl.ShowPrintPreview();
        }
        protected override void Print() {
            if (PrintingRichEditControl != null)
                PrintingRichEditControl.Print();
        }
        #endregion
    }
}
