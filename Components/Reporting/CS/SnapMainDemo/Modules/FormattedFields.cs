using System.ComponentModel;
using System.IO;
using DevExpress.Utils;
using DevExpress.Snap.Core.API;

namespace SnapDemos.Modules {
    public partial class FormattedFields : BaseTutorial {
        public FormattedFields() {
            using (WaitDialogForm dlg = new WaitDialogForm("Please wait", "Loading...")) {
                SetDataSource();
                LoadDocument();
            }
        }
        void LoadDocument() {
            string path = FindFilePathByName("FormattedFields");
            if (File.Exists(path))
                this.snapControl1.LoadDocument(path, SnapDocumentFormat.Snap);
        }
        void SetDataSource() {
            object dataSource = new FormattedFieldsDataProvider().GetDataSource();
            this.snapControl1.DataSources.Add(new DataSourceInfo("HtmlTags", dataSource));
        }
    }

    public class HtmlTag {
        public string Tag { get; set; }
        [DisplayName("Markup Example")]
        public string MarkupExample { get; set; }
        public string Description { get; set; }
    }
}
