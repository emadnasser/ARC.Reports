using System.IO;
using DevExpress.Utils;
using DevExpress.Snap.Core.API;

namespace SnapDemos.Modules {
    public class IListDatasource : BaseTutorial {
        public IListDatasource() {
            using (WaitDialogForm dlg = new WaitDialogForm("Please wait", "Loading...")) {
                LoadDocument();
                SetDataSource();
            }
        }
        void LoadDocument() {
            string path = FindFilePathByName("IListDatasource");
            if (File.Exists(path))
                this.snapControl1.LoadDocument(path, SnapDocumentFormat.Snap);
        }
        void SetDataSource() {
            object dataSource = new IListDatasourceProvider().GetDataSource();
            this.snapControl1.DataSources.Add(new DataSourceInfo("Fishes", dataSource));
        }
    }
}
