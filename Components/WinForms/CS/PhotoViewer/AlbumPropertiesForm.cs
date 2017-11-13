using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace PhotoViewer {
    public partial class AlbumPropertiesForm : XtraForm {
        public AlbumPropertiesForm() {
            InitializeComponent();
        }
        public AlbumPropertiesForm(PhotoViewerData viewData) : this() {
            this.viewData = viewData;
        }

        PhotoViewerData viewData;
        public PhotoViewerData ViewData { get { return viewData; } set { viewData = value; } }

        bool isEditExistingAlbumMode;
        public bool IsEditExistingAlbumMode { get { return isEditExistingAlbumMode; } set { isEditExistingAlbumMode = value; } }

        private void simpleButton2_Click(object sender, EventArgs e) {
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
            foreach(AlbumData album in ViewData.Albums) {
                if(album.Name == albumName && !IsEditExistingAlbumMode) {
                    XtraMessageBox.Show(this, "Error: album with the name '" + albumNameEdit.Text + "' already exists in albums collection. Please type another name.", messageCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            return true;
        }

        private void NewAlbumForm_Load(object sender, EventArgs e) {
            albumDate.DateTime = DateTime.Now;
        }

        public string AlbumName { get { return albumNameEdit.Text; } set { albumNameEdit.Text = value; } }
        public DateTime AlbumDate { get { return albumDate.DateTime; } set { albumDate.DateTime = value; } }
        public string AlbumDescription { get { return albumDescription.Text; } set { albumDescription.Text = value; } }
    }
}
