using System;
using DevExpress.DXperience.Demos;
using DevExpress.Utils;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraRichEdit.UI;
using DevExpress.Snap.Extensions.UI;

namespace SnapDemos.Modules {
    public class SnapTutorialControlBase : TutorialControlBase {

        public SnapTutorialControlBase() {
            string dbPath = FilesHelper.FindingFileName(AppDomain.CurrentDomain.BaseDirectory, @"Data\temperatureStatistics.mdb", false);
            if (!String.IsNullOrEmpty(dbPath)) {
                string directory = System.IO.Path.GetDirectoryName(dbPath);
                AppDomain.CurrentDomain.SetData("DataDirectory", directory);
            }
        }

        protected virtual RibbonControl RibbonControl { get { return null; } }
        protected virtual GalleryChangeTableStyleItem GalleryChangeTableStyleItem { get { return null; } }
        protected virtual GalleryChangeTableCellStyleItem GalleryChangeTableCellStyleItem { get { return null; } }

        public string FindFilePathByName(string fileName) {
            return FilesHelper.FindingFileName(AppDomain.CurrentDomain.BaseDirectory, string.Format(@"Data\{0}.snx", fileName), false);
        }
        public override bool AutoMergeRibbon {
            get {
                return true;
            }
            set {
            }
        }
    }
}
