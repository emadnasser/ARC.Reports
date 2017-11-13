using System;

namespace PhotoViewer {
    public partial class AlbumGroupCaptionControl : PhotoGroupCaptionControlBase {
        public AlbumGroupCaptionControl() {
            InitializeComponent();
        }
        AlbumData albumCore;
        public AlbumData Album {
            get { return albumCore; }
            set {
                if(Album == value)
                    return;
                albumCore = value;
                OnAlbumChanged();
            }
        }
        protected virtual void OnAlbumChanged() {
            nameLabel.Text = Album.Name;
            dataLabel.Text = Album.Date.ToLongDateString();
        }
        protected override void OnRemoveButtonClick(object sender, EventArgs e) {
            AlbumGalleryForm gForm = GalleryForm as AlbumGalleryForm;
            if(gForm != null) {
                gForm.RemoveAlbum();
                gForm.MainForm.UpdateData(true);
                gForm.Close();
            }
        }
        protected override void OnEditButtonClick(object sender, EventArgs e) {
            AlbumGalleryForm gForm = GalleryForm as AlbumGalleryForm;
            if(gForm != null) gForm.EditAlbum();
        }
        public void HideEditButtons() {
            removeLabel.Visible = false;
            editLabel.Visible = false;
            separatorLabel.Visible = false;
        }
    }
}
