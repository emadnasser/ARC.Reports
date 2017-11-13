using System.Collections.Generic;
using System.Windows.Forms;
using DevExpress.XtraBars.Ribbon;
using PhotoViewer.Data;

namespace PhotoViewer {
    public class FolderGalleryForm : GalleryForm {
        public FolderGalleryForm (PhotoViewerDataController controller, PathData folder)
            : base(controller) {
            this.folderCore = folder;
            Text = folder.Name;
            UpdateGalleryContent(true);
        }
        PathData folderCore;
        public PathData Folder {
            get { return folderCore; }
        }
        protected override void UpdateGalleryContent(bool forceProcess) {
            if(Folder == null) {
                ClearGalleryAndImages();
                return;
            }
            if(forceProcess)
                ProcessFolder();
            ScrollToFolder(Folder, !forceProcess);
            UpdateItemsEnabledState();
        }
        protected override void RemoveImagesCore(List<GalleryItem> images) {
            
        }
        void ProcessFolder(PathData folder) {
            GalleryItemGroup group = CreateFolderGroup(folder);
            gallery.Gallery.Groups.Add(group);
            List<string> files = controller.GetImagesInFolder(folder);
            foreach(string fileName in files) {
                group.Items.Add(CreatePhotoGalleryItem(fileName));
            }
        }
        void ProcessFolder() {
            gallery.Gallery.BeginUpdate();
            try {
                ClearGalleryAndImages();
                ProcessFolder(Folder);
            }
            finally { gallery.Gallery.EndUpdate(); }
        }
        internal void RemoveFolder() {
            controller.RemoveFolder(Folder, this);
        }
        GalleryItemGroup CreateFolderGroup(PathData folder) {
            GalleryItemGroup group = new GalleryItemGroup();
            group.Tag = folder;
            group.Caption = folder.Name;
            group.CaptionAlignment = GalleryItemGroupCaptionAlignment.Stretch;
            group.CaptionControl = CreateFolderGroupCaptionControl(folder);
            return group;
        }
        Control CreateFolderGroupCaptionControl(PathData folder) {
            FolderGroupCaptionControl control = new FolderGroupCaptionControl();
            control.Folder = folder;
            control.GalleryForm = this;
            return control;
        }
    }
}
