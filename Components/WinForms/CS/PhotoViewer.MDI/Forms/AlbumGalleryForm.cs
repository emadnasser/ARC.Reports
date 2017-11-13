using System.Collections.Generic;
using System.Windows.Forms;
using DevExpress.XtraBars.Ribbon;
using PhotoViewer.Data;

namespace PhotoViewer {
    public class AlbumGalleryForm : GalleryForm {
        public AlbumGalleryForm(PhotoViewerDataController controller, AlbumData album)
            : base(controller) {
            this.albumCore = album;
            Text = album.Name;
            UpdateGalleryContent(true);
        }
        AlbumData albumCore;
        public AlbumData Album {
            get { return albumCore; }
        }
        protected override void UpdateGalleryContent(bool forceProcess) {
            if(Album == null) {
                ClearGalleryAndImages();
                return;
            }
            if(forceProcess)
                ProcessAlbum();
            ScrollToAlbum(Album, !forceProcess);
            UpdateItemsEnabledState();
        }
        protected override void RemoveImagesCore(List<GalleryItem> images) {
            controller.RemoveImagesFromAlbum(GetSelectedItems(images), Album, this);
        }
        void ProcessAlbum() {
            gallery.Gallery.BeginUpdate();
            try {
                ClearGalleryAndImages();
                ProcessAlbum(Album);
            }
            finally { gallery.Gallery.EndUpdate(); }
        }
        void ProcessAlbum(AlbumData albumData, bool showEditButtons) {
            GalleryItemGroup group = CreateAlbumGroup(albumData);
            AlbumGroupCaptionControl control = (AlbumGroupCaptionControl)group.CaptionControl;
            if(!showEditButtons)
                control.HideEditButtons();
            gallery.Gallery.Groups.Add(group);
            foreach(PathData pData in albumData.Files) {
                group.Items.Add(CreatePhotoGalleryItem(pData.Path));
            }
        }
        void ProcessAlbum(AlbumData albumData) {
            ProcessAlbum(albumData, controller.CanEditAlbum(albumData));
        }
        internal void RemoveAlbum() {
            controller.RemoveAlbum(Album, this);
        }
        internal void EditAlbum() {
            AlbumPropertiesForm.EditAlbum(controller, Album, this);
        }
        GalleryItemGroup CreateAlbumGroup(AlbumData albumData) {
            GalleryItemGroup group = new GalleryItemGroup();
            group.Tag = albumData;
            group.Caption = albumData.Name;
            group.CaptionAlignment = GalleryItemGroupCaptionAlignment.Stretch;
            group.CaptionControl = CreateAlbumGroupCaptionControl(albumData);
            return group;
        }
        Control CreateAlbumGroupCaptionControl(AlbumData albumData) {
            AlbumGroupCaptionControl control = new AlbumGroupCaptionControl();
            control.Album = albumData;
            control.GalleryForm = this;
            return control;
        }
    }
}
