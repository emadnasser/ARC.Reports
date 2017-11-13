using System.Globalization;
using DevExpress.Spreadsheet;
using DevExpress.XtraEditors;
using DevExpress.XtraPrinting;
using System.Drawing.Printing;
using DevExpress.DXperience.Demos;
using DevExpress.XtraPrintingLinks;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraPrinting.Control;

namespace DevExpress.Docs.Demos {
    public partial class SpreadsheetCustomViewModule : TutorialControlBase {
        #region fields
        IWorkbook book;
        PrintableComponentLinkBase link;
        #endregion

        public SpreadsheetCustomViewModule() {
            InitializeComponent();
            InitPreviewControl();
            InitRadiogroups();
            InitPaperKindBox();
            RefreshPreview();
        }

        void InitPreviewControl() {
            book = new Workbook();
            book.Options.Culture = CultureInfo.InvariantCulture;
            book.LoadDocument(DemoUtils.GetRelativePath("CustomView_template.xlsx"));
            previewControl.PrintingSystem = new PrintingSystem();
            link = new PrintableComponentLinkBase(this.previewControl.PrintingSystem);
            link.Component = book;
            book.Unit = DevExpress.Office.DocumentUnit.Inch;
            previewControl.PrintingSystem.Graph.PageUnit = System.Drawing.GraphicsUnit.Document;
            book.Worksheets[0].Cells[0, 0].Value = string.Empty;
            previewControl.ExecCommand(PrintingSystemCommand.ZoomToWholePage);
        }
        void InitRadiogroups() {
            foreach(PageOrientation currentValue in EnumHelper.GetValues<PageOrientation>())
                pageOrientationGroup.Properties.Items.Add(new RadioGroupItem(currentValue, currentValue.ToString()));
            pageOrientationGroup.SelectedIndex = 2;
            viewTypeGroup.Properties.Items.Add(new RadioGroupItem(WorksheetViewType.Normal, "Normal"));
            viewTypeGroup.Properties.Items.Add(new RadioGroupItem(WorksheetViewType.PageBreakPreview, "Page Break Preview"));
            viewTypeGroup.Properties.Items.Add(new RadioGroupItem(WorksheetViewType.PageLayout, "Page Layout"));
            viewTypeGroup.SelectedIndex = 0;
        }
        void InitPaperKindBox() {
            foreach(PaperKind currentValue in EnumHelper.GetValues<PaperKind>())
                if(currentValue != PaperKind.Custom)
                    paperKindBox.Properties.Items.Add(currentValue);
            paperKindBox.SelectedItem = book.Worksheets[0].ActiveView.PaperKind;
        }
        void RefreshPreview() {
            if(previewControl != null)
                link.CreateDocument();
        }

        void zoomTrackBar_EditValueChanged(object sender, System.EventArgs e) {
            zoomLabel.Text = string.Format("Zoom {0}" + (zoomTrackBar.Value > 99 ? "" : "  ") + "%:", zoomTrackBar.Value);
        }
        void paperKindBox_SelectedIndexChanged(object sender, System.EventArgs e) {
            PaperKind paperKind = (PaperKind)paperKindBox.SelectedItem;
            previewControl.PrintingSystem.PageSettings.PaperKind = paperKind;
            book.Worksheets[0].ActiveView.PaperKind = paperKind;
            RefreshPreview();
        }
        void pageOrientationGroup_SelectedIndexChanged(object sender, System.EventArgs e) {
            PageOrientation orientation = (PageOrientation)pageOrientationGroup.Properties.Items[pageOrientationGroup.SelectedIndex].Value;
            previewControl.PrintingSystem.PageSettings.Landscape = PageOrientation.Landscape.Equals(orientation);
            book.Worksheets[0].ActiveView.Orientation = orientation;
            RefreshPreview();
        }
        void topMarginEdit_EditValueChanged(object sender, System.EventArgs e) {
            book.Worksheets[0].ActiveView.Margins.Top = (float)topMarginEdit.Value;
            previewControl.PrintingSystem.PageMargins.Top = (int)(topMarginEdit.Value * 300);
            RefreshPreview();
        }
        void bottomMarginEdit_EditValueChanged(object sender, System.EventArgs e) {
            book.Worksheets[0].ActiveView.Margins.Bottom = (float)bottomMarginEdit.Value;
            previewControl.PrintingSystem.PageMargins.Bottom = (int)(bottomMarginEdit.Value * 300);
            RefreshPreview();
        }
        void leftMarginEdit_EditValueChanged(object sender, System.EventArgs e) {
            book.Worksheets[0].ActiveView.Margins.Left = (float)leftMarginEdit.Value;
            previewControl.PrintingSystem.PageMargins.Left = (int)(leftMarginEdit.Value * 300);
            RefreshPreview();
        }
        void rightMarginEdit_EditValueChanged(object sender, System.EventArgs e) {
            book.Worksheets[0].ActiveView.Margins.Right = (float)rightMarginEdit.Value;
            previewControl.PrintingSystem.PageMargins.Right = (int)(rightMarginEdit.Value * 300);
            RefreshPreview();
        }
        void headerMarginEdit_EditValueChanged(object sender, System.EventArgs e) {
            book.Worksheets[0].ActiveView.Margins.Header = (float)headerMarginEdit.Value;
        }
        void footerMarginEdit_EditValueChanged(object sender, System.EventArgs e) {
            book.Worksheets[0].ActiveView.Margins.Footer = (float)footerMarginEdit.Value;
        }
        void saveButton_Click(object sender, System.EventArgs e) {
            string fileName = SpreadsheetTutorialControl.GetSaveFileName("Xlsx files(*.xlsx)|*.xlsx|All files (*.*)|*.*", "Custom_View");
            if (!string.IsNullOrEmpty(fileName)) {
                book.DocumentSettings.R1C1ReferenceStyle = useR1C1StyleCheckEdit.Checked;
                Worksheet sheet = book.Worksheets[0];
                sheet.ActiveView.Zoom = zoomTrackBar.Value;
                sheet.ActiveView.ShowGridlines = showGridCheckEdit.Checked;
                sheet.ActiveView.ShowHeadings = showHeadingsCheckEdit.Checked;
                sheet.ActiveView.TabColor = tabColodEdit.Color;
                sheet.ActiveView.ViewType = (WorksheetViewType)viewTypeGroup.Properties.Items[viewTypeGroup.SelectedIndex].Value;

                book.SaveDocument(fileName, DocumentFormat.OpenXml);
            }
            SpreadsheetTutorialControl.ShowFile(fileName, this);
        }
    }
}
