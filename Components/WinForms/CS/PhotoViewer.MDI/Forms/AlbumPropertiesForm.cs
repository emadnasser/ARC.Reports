using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using PhotoViewer.Data;

namespace PhotoViewer {
    public partial class AlbumPropertiesForm : XtraForm {
        public AlbumPropertiesForm() {
            InitializeComponent();
        }
        PhotoViewerDataController controller;
        public AlbumPropertiesForm(PhotoViewerDataController controller) : this() {
            this.controller = controller;
        }
        bool isEditExistingAlbumMode;
        public bool IsEditExistingAlbumMode {
            get { return isEditExistingAlbumMode; }
            set { isEditExistingAlbumMode = value; }
        }
        void NewAlbumForm_Load(object sender, EventArgs e) {
            albumDate.DateTime = DateTime.Now;
        }
        void okBtn_Click(object sender, EventArgs e) {
            if(CheckAlbumProperties()) {
                DialogResult = DialogResult.OK;
                Close();
            }
        }
        protected virtual bool CheckAlbumProperties() {
            string albumName = albumNameEdit.Text.Trim();
            string messageCaption = IsEditExistingAlbumMode ? "Edit Album" : "New Album";
            if(string.IsNullOrEmpty(albumName)) {
                XtraMessageBox.Show(this, "Error: please type album name.", messageCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            foreach(AlbumData album in controller.GetAlbums()) {
                if(album.Name == albumName && !IsEditExistingAlbumMode) {
                    XtraMessageBox.Show(this, "Error: album with the name '" + albumNameEdit.Text + "' already exists in albums collection. Please type another name.", messageCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            return true;
        }
        public string AlbumName { get { return albumNameEdit.Text; } set { albumNameEdit.Text = value; } }
        public DateTime AlbumDate { get { return albumDate.DateTime; } set { albumDate.DateTime = value; } }
        public string AlbumDescription { get { return albumDescription.Text; } set { albumDescription.Text = value; } }

        public static void EditAlbum(PhotoViewerDataController controller, AlbumData album, Form owner) {
            if(album == null || controller == null) return;
            AlbumPropertiesForm form = new AlbumPropertiesForm(controller);
            form.Text = "Edit album properties";
            form.Owner = owner;
            form.AlbumName = album.Name;
            form.AlbumDate = album.Date;
            form.AlbumDescription = album.Description;
            form.IsEditExistingAlbumMode = true;
            if(form.ShowDialog() == DialogResult.OK) {
                album.Name = form.AlbumName;
                album.Date = form.AlbumDate;
                album.Description = form.AlbumDescription;
                controller.RaiseDataChanged(album);
            }
        }
    }
}
