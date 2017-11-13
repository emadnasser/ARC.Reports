using System.IO;
using DevExpress.Utils;
using DevExpress.Snap.Core.API;

namespace SnapDemos.Modules {
    public class BarCode : BaseTutorial{
        public BarCode() {
            using (WaitDialogForm dlg = new WaitDialogForm("Please wait", "Loading...")) {
                LoadDocument();
            }
        }
        void LoadDocument() {
            string path = FindFilePathByName("BarCode");
            if (File.Exists(path))
                this.snapControl1.LoadDocument(path, SnapDocumentFormat.Snap);
        }
    }
}
