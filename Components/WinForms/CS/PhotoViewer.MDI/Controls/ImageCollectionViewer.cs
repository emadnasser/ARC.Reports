using System;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;

namespace PhotoViewer {
    public partial class ImageCollectionViewer : XtraUserControl {
        string[] filesCore;
        string thumbPathCore;
        public ImageCollectionViewer(string[] files, string thumbPath) {
            this.filesCore = files;
            this.thumbPathCore = thumbPath;
            InitializeComponent();
            InitializeGallery();
        }
        public string[] Files { 
            get { return filesCore; } 
        }
        public string ThumbPath { 
            get { return thumbPathCore; } 
        }
        protected void InitializeGallery() {
            foreach(string file in Files) {
                gallery.Gallery.Groups[0].Items.Add(CreateGalleryItem(file));        
            }
            gallery.Gallery.Groups[0].Items[0].Checked = true;
            if(Files.Length == 1) {
                dockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Float;
                dockManager.RemovePanel(dockPanel1);
            }
        }
        protected virtual GalleryItem CreateGalleryItem(string file) {
            GalleryItem item = new GalleryItem();
            item.Tag = file;
            item.Image = ThumbnailHelper.Default.GetThumbnail(file, 208, ThumbPath);
            return item;
        }
        void gallery_ItemCheckedChanged(object sender, GalleryItemEventArgs e) {
            if(e.Item.Checked) {
                if(Parent == null)
                    UpdateImage();
                else
                    gallery.Gallery.ScrollTo(e.Item, true, DevExpress.Utils.VertAlignment.Center);
            }
        }
        void leftLabel_Click(object sender, EventArgs e) {
            GalleryItem item = GetCheckedItem();
            int itemIndex = item.GalleryGroup.Items.IndexOf(item);
            itemIndex = Math.Max(0, itemIndex - 1);
            item.GalleryGroup.Items[itemIndex].Checked = true;
        }
        void rightLabel_Click(object sender, EventArgs e) {
            GalleryItem item = GetCheckedItem();
            int itemIndex = item.GalleryGroup.Items.IndexOf(item);
            itemIndex = Math.Min(item.GalleryGroup.Items.Count - 1, itemIndex + 1);
            item.GalleryGroup.Items[itemIndex].Checked = true;
        }
        protected virtual GalleryItem GetCheckedItem() {
            foreach(GalleryItem item in gallery.Gallery.Groups[0].Items) {
                if(item.Checked)
                    return item;
            }
            return null;
        }
        void galleryControl1_Gallery_EndScroll(object sender, EventArgs e) {
            BeginInvoke(new MethodInvoker(UpdateImage));
        }
        public void UpdateImage() {
            pictureEdit.LoadAsync((string)GetCheckedItem().Tag);
        }
        void UpdatePreviewImage() {
            if(controlContainer2.Controls.Count > 0) {
                SimpleFilterParams fp = (SimpleFilterParams)controlContainer2.Controls[0];
                fp.ImageToFilter = pictureEdit.Image;
            }
        }
        public void SetFilter(FilterInfo info) {
            if(controlContainer2.Controls.Count > 0) {
                SimpleFilterParams paramsControl = controlContainer2.Controls[0] as SimpleFilterParams;
                if(paramsControl != null) {
                    paramsControl.ApplyFilter -= new EventHandler(OnApplyFilter);
                    controlContainer2.Controls.Remove(paramsControl);
                    paramsControl.Dispose();
                }
                controlContainer2.Controls.Clear();
            }
            if(info != null) {
                SimpleFilterParams pc = info.CreateParamsControl();
                pc.Dock = DockStyle.Fill;
                pc.ApplyFilter += new EventHandler(OnApplyFilter);
                dockPanel2.Text = info.Name;
                controlContainer2.Controls.Add(pc);
                UpdatePreviewImage();
            }
        }
        protected override void OnParentChanged(EventArgs e) {
            base.OnParentChanged(e);
            if(Parent == null && controlContainer2.Controls.Count > 0) { 
                ((SimpleFilterParams)controlContainer2.Controls[0]).ApplyFilter -= new EventHandler(OnApplyFilter);
            }
        }
        void OnApplyFilter(object sender, EventArgs e) {
            SimpleFilterParams paramsControl = controlContainer2.Controls[0] as SimpleFilterParams;
            if(paramsControl == null)
                return;
            Image oldImage = pictureEdit.Tag == null ? null : pictureEdit.Image;
            if(pictureEdit.Tag == null)
                pictureEdit.Tag = pictureEdit.Image;
            pictureEdit.Image = FilterHelper.ApplyFilter(paramsControl.Filter.Name, pictureEdit.Image, paramsControl.GetParams());
            if(oldImage != null)
                oldImage.Dispose();
            GalleryForm form = FindForm() as GalleryForm;
            if(form != null)
                form.UpdateCancelButtonEnabledState();
        }
        public void CancelFilters() {
            Image oldImage = pictureEdit.Image;
            if(pictureEdit.Tag != null) {
                pictureEdit.Image = (Image)pictureEdit.Tag;
                pictureEdit.Tag = null;
            }
        }
        internal bool IsImageFilterd() {
            return pictureEdit.Tag != null;
        }
        void pictureEdit_LoadCompleted(object sender, EventArgs e) {
            UpdatePreviewImage();
        }
        internal void SetMenuManager(RibbonBarManager ribbonBarManager) {
            pictureEdit.MenuManager = ribbonBarManager;
        }
    }
}
