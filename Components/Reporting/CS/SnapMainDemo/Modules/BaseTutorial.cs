using DevExpress.XtraBars.Ribbon;
using DevExpress.Snap.Extensions.UI;
using DevExpress.XtraRichEdit.UI;

namespace SnapDemos.Modules {
    public partial class BaseTutorial : SnapTutorialControlBase {
        public BaseTutorial() {
            InitializeComponent();
            new SnapDemoExceptionsHandler(snapControl1).Install();
        }
        protected override RibbonControl RibbonControl { get { return ribbonControl1; } }
        protected override GalleryChangeTableStyleItem GalleryChangeTableStyleItem { get { return galleryChangeTableStyleItem1; } }
        protected override GalleryChangeTableCellStyleItem GalleryChangeTableCellStyleItem { get { return galleryChangeTableCellStyleItem1; } }
        protected override void Dispose(bool disposing) {
            if (this.snapDocumentManager1 != null) {
                this.snapDocumentManager1.Dispose();
                this.snapDocumentManager1 = null;
            }
            base.Dispose(disposing);
        }
    }
}
