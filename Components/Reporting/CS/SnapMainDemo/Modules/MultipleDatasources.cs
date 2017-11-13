using System.IO;
using DevExpress.Utils;
using DevExpress.Office;
using DevExpress.XtraRichEdit.API.Native;
using DevExpress.Snap.Core.API;

namespace SnapDemos.Modules {
    public class MultipleDatasources : BaseTutorial {
        public MultipleDatasources() {
            using (WaitDialogForm dlg = new WaitDialogForm("Please wait", "Loading...")) {
                SetDataSource();
                SetDocumentContent();
            }
        }
        void SetDataSource() {
            object orders = new CalculatedFieldsDataProvider().GetDataSource();
            this.snapControl1.DataSources.Add(new DataSourceInfo("Orders", orders));
            object fishes = new IListDatasourceProvider().GetDataSource();
            this.snapControl1.DataSources.Add(new DataSourceInfo("Fishes", fishes));
        }
        void SetDocumentContent() {
            string path = FindFilePathByName("IListDataSource");
            if (File.Exists(path))
                this.snapControl1.LoadDocument(path, SnapDocumentFormat.Snap);
            SnapDocument snapDocument = this.snapControl1.Document;
            Field field = snapDocument.Fields.Create(snapDocument.Range.Start, "TOC \\o \\f tocID \\h");
            snapDocument.InsertText(field.Range.End, Characters.PageBreak.ToString());

            snapDocument.InsertText(snapDocument.Range.End, Characters.PageBreak.ToString());
            path = FindFilePathByName("CalculatedFields");
            if (File.Exists(path))
                snapDocument.InsertDocumentContent(snapDocument.Range.End, path, SnapDocumentFormat.Snap);
            snapDocument.Fields.Update();
            field.Update();
        }
    }
}
