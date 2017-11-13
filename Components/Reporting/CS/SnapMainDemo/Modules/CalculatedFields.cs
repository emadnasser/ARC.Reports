using System.IO;
using DevExpress.Utils;
using DevExpress.Snap.Core.API;

namespace SnapDemos.Modules {
    public class CalculatedFields : BaseTutorial {
        public CalculatedFields() {
            using (WaitDialogForm dlg = new WaitDialogForm("Please wait", "Loading...")) {
                LoadDocument();
                SetDataSource();
            }
        }
        void LoadDocument() {
            string path = FindFilePathByName("CalculatedFields");
            if (File.Exists(path))
                this.snapControl1.LoadDocument(path, SnapDocumentFormat.Snap);
        }
        void SetDataSource() {
            object dataSource = new CalculatedFieldsDataProvider().GetDataSource();
            this.snapControl1.DataSources.Add(new DataSourceInfo("Orders", dataSource));
        }
    }
}
