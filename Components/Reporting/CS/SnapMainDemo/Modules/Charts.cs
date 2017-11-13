using System.IO;
using DevExpress.Utils;
using DevExpress.Snap.Core.API;

namespace SnapDemos.Modules {
    public partial class Charts : BaseTutorial {
        public Charts() {
            using (WaitDialogForm dlg = new WaitDialogForm("Please wait", "Loading...")) {
                LoadDocument();
                SetDataSource();
            }
        }

        void LoadDocument() {
            string path = FindFilePathByName("Charts");
            if (File.Exists(path))
                this.snapControl1.LoadDocument(path, SnapDocumentFormat.Snap);
        }
        void SetDataSource() {
            object dataSource = new ChartsDataProvider().GetDataSource();
            this.snapControl1.DataSource = dataSource;
        }
    }
}
