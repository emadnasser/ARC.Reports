using System.IO;
using DevExpress.Utils;
using DevExpress.Snap.Core.API;

namespace SnapDemos.Modules {
    public partial class Sparklines : BaseTutorial {
        public Sparklines() {
            using (WaitDialogForm dlg = new WaitDialogForm("Please wait", "Loading...")) {
                LoadDocument();
                SetDataSource();
            }
        }
        void LoadDocument() {
            string path = FindFilePathByName("Sparkline");
            if (File.Exists(path))
                this.snapControl1.LoadDocument(path, SnapDocumentFormat.Snap);
        }
        void SetDataSource() {
            object dataSource = new SparklineDataProvider().GetDataSource();
            this.snapControl1.DataSource = dataSource;
        }
    }
}
