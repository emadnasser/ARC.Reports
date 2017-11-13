using System.IO;
using DevExpress.Utils;
using DevExpress.Snap;
using DevExpress.Snap.Core.API;
using DevExpress.Snap.Core.Options;

namespace SnapDemos.Modules {
    public partial class MailMergeReports : BaseTutorial {
        public MailMergeReports() {
            using (WaitDialogForm dlg = new WaitDialogForm("Please wait", "Loading...")) {
                LoadDocument();
                SetDataSource();
                SubscribeEvents();
            }
        }
        void LoadDocument() {
            string path = FindFilePathByName("MailMergeReports");
            if (File.Exists(path))
                this.snapControl1.LoadDocument(path, SnapDocumentFormat.Snap);
        }
        void SetDataSource() {
            object dataSource = new MailMergeReportsDataProvider().GetDataSource();
            this.snapControl1.DataSource = dataSource;
        }
        void SubscribeEvents() {
            this.snapControl1.MailMergeExportFormShowing += OnMailMergeExportFormShowing;
        }

        void OnMailMergeExportFormShowing(object sender, MailMergeExportFormShowingEventArgs e) {
            e.Options.HeaderFooterLinkToPrevious = false;
            e.Options.RecordSeparator = RecordSeparator.SectionNextPage;
        }
    }
}
