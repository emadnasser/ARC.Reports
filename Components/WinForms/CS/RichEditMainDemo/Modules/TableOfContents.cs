using System;
using System.Collections.Generic;
using DevExpress.XtraRichEdit.API.Native;
using DevExpress.Office.Services;
using System.IO;
using System.Data;

namespace DevExpress.XtraRichEdit.Demos {
    #region TableOfContentsModule
    public partial class TableOfContentsModule : MergeModuleBase {
        System.Data.DataTable employees;

        public TableOfContentsModule() {
            InitializeComponent();
            this.employees = GetEmployeeDataFromXml();
            this.dataNavigator.DataSource = employees;
            this.sourceRichEditControl.Options.MailMerge.DataSource = employees;
            OpenXmlLoadHelper.Load("TableOfContents.docx", sourceRichEditControl);
            new RichEditDemoExceptionsHandler(SourceRichEditControl).Install();
            IUriStreamService uriService = (IUriStreamService)sourceRichEditControl.GetService(typeof(IUriStreamService));
            uriService.RegisterProvider(new PhotoUriStreamProvider(employees, "Photo"));
        }

        public override RichEditControl PrintingRichEditControl { get { return targetRichEditControl; } }

        private void sourceRichEditControl_DocumentLoaded(object sender, EventArgs e) {
            this.sourceRichEditControl.Document.Fields.Update();
            MergeToNewDocument();
        }

        private void mergeToNewDocument_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            MergeToNewDocument();
        }

        protected override void MergeToNewDocument() {
            MailMergeOptions options = sourceRichEditControl.CreateMailMergeOptions();
            options.MergeMode = MergeMode.NewSection;
            options.LastRecordIndex = 5;
            sourceRichEditControl.MailMerge(options, targetRichEditControl.Document);
            Document targetDocument = targetRichEditControl.Document;

            InsertContentHeading(targetDocument);

            Field field = targetDocument.Fields.Create(targetDocument.Paragraphs[1].Range.Start, "TOC \\h");
            targetDocument.InsertSection(field.Range.End);
            field.Update();

            ParagraphStyle paragraphStyle = targetDocument.ParagraphStyles["TOC 1"];
            if (paragraphStyle != null)
                paragraphStyle.Bold = true;

            resultingDocumentTabPage.PageEnabled = true;
            tabControl.SelectedTabPage = resultingDocumentTabPage;
        }
        private void tabControl_SelectedPageChanged(object sender, DevExpress.XtraTab.TabPageChangedEventArgs e) {
            RichEditControl richEditControl = (RichEditControl)tabControl.SelectedTabPage.Tag;
            richEditBarController1.RichEditControl = richEditControl;
            bool isSelectedSourceControl = object.ReferenceEquals(richEditControl, sourceRichEditControl);
            insertMergeFieldItem1.Enabled = isSelectedSourceControl;
            toggleViewMergedDataItem1.Enabled = isSelectedSourceControl;
            mergeToNewDocumentPageGroup1.Visible = isSelectedSourceControl;
            tableOfContentsRibbonPageGroup1.Visible = !isSelectedSourceControl;
        }
        private void InsertContentHeading(Document targetDocument) {
            DocumentRange hRange = targetDocument.InsertText(targetDocument.Range.Start, "Contents\r\n");
            CharacterProperties charProperties = targetDocument.BeginUpdateCharacters(hRange);
            charProperties.FontSize = 16;
            charProperties.ForeColor = System.Drawing.Color.SteelBlue;
            targetDocument.EndUpdateCharacters(charProperties);
            targetDocument.Paragraphs[0].Style = targetDocument.ParagraphStyles[0];
            targetDocument.Paragraphs[0].Alignment = ParagraphAlignment.Center;
        }
    }
    #endregion
    public class PhotoUriStreamProvider : IUriStreamProvider {
        static readonly string prefix = "dbimg://";

        object ds;
        string columnName;

        public PhotoUriStreamProvider(object ds, string columnName) {
            this.ds = ds;
            this.columnName = columnName;
        }

        public object Ds { get { return ds; } }

        #region IUriStreamProvider Members
        Stream IUriStreamProvider.GetStream(string uri) {
            uri = uri.Trim();
            if (!uri.StartsWith(prefix))
                return null;
            string strId = uri.Substring(prefix.Length).Trim();
            int id;
            if (!int.TryParse(strId, out id))
                return null;
            byte[] bytes = GetImageBytes(id);
            if (bytes == null)
                return null;
            return new MemoryStream(bytes);
        }
        #endregion
        byte[] GetImageBytes(int id) {
            DataTable table = (DataTable)this.ds;
            DataRow row = table.Rows.Find(id);
            if (row == null)
                return null;
            return row[columnName] as byte[];
        }
    }
}
