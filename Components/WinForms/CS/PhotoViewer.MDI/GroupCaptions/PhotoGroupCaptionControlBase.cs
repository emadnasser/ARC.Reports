using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace PhotoViewer {
    public partial class PhotoGroupCaptionControlBase : UserControl {
        public PhotoGroupCaptionControlBase() {
            SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint, true);
            InitializeComponent();
        }
        GalleryForm galleryFormCore;
        public GalleryForm GalleryForm {
            get { return galleryFormCore; }
            set { galleryFormCore = value; }
        }
        protected virtual void OnGroupIconClick(object sender, EventArgs e) { }
        protected virtual void OnEditButtonClick(object sender, EventArgs e) { }
        protected virtual void OnRemoveButtonClick(object sender, EventArgs e) { }
        protected virtual void OnCollageButtonClick(object sender, EventArgs e) {
            XtraMessageBox.Show(this, "Here you can show your own collage settings dialog.", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        protected virtual void OnSlideShowButtonClick(object sender, EventArgs e) {
            XtraMessageBox.Show(this, "Here you can show your own slideshow settings dialog.", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        protected virtual void OnFilmButtonClick(object sender, EventArgs e) {
            XtraMessageBox.Show(this, "Here you can show your own film settings dialog.", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
