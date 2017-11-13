using System.IO;
using DevExpress.Utils;
using DevExpress.Snap.Core.API;

namespace SnapDemos.Modules {
    public class MultiColumnReport : BaseTutorial {
        public MultiColumnReport() {
            using (WaitDialogForm dlg = new WaitDialogForm("Please wait", "Loading...")) {
                LoadDocument();
                SetDataSource();
            }
        }
        void LoadDocument() {
            string path = FindFilePathByName("MultiColumnReport");
            if (File.Exists(path))
                this.snapControl1.LoadDocument(path, SnapDocumentFormat.Snap);
        }
        void SetDataSource() {
            object dataSource = new MultiColumnReportDataProvider().GetDataSource();
            this.snapControl1.DataSource = dataSource;
        }
    }
}
