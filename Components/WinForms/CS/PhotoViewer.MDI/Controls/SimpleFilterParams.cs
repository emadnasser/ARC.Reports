using System;
using System.Drawing;
using DevExpress.XtraEditors;

namespace PhotoViewer {
    public partial class SimpleFilterParams : XtraUserControl {
        FilterInfo filterInfoCore;
        public SimpleFilterParams() {
            InitializeComponent();
        }
        public virtual object[] GetParams() { 
            return new object[] { }; 
        }
        public FilterInfo Filter {
            get { return filterInfoCore; }
            set { filterInfoCore = value; }
        }
        Image imageToFilterCore;
        public Image ImageToFilter {
            get { return imageToFilterCore; }
            set {
                if(ImageToFilter == value)
                    return;
                imageToFilterCore = value;
                OnImageToFilterChanged();
            }
        }
        void OnImageToFilterChanged() {
            Image img = pictureEdit.Tag as Image;
            if(img != null)
                img.Dispose();
            pictureEdit.Tag = null;
            img = pictureEdit.Image;
            pictureEdit.Image = null;
            if(img != null)
                img.Dispose();
            if(ImageToFilter != null) {
                pictureEdit.Image = ThumbnailHelper.Default.CreateThumbnail(ImageToFilter, 128);
                UpdatePreview();
            }
        }
        public event EventHandler ApplyFilter {
            add { applyFilterButton.Click += value; }
            remove { applyFilterButton.Click -= value; }
        }
        public virtual void UpdatePreview() {
            Image oldImage = pictureEdit.Tag == null? null: pictureEdit.Image;
            if(pictureEdit.Tag == null)
                pictureEdit.Tag = pictureEdit.Image;
            if(pictureEdit.Tag == null)
                return;
            pictureEdit.Image = FilterHelper.ApplyFilter(Filter.Name, (Image)pictureEdit.Tag, GetParams());
            if(oldImage != null)
                oldImage.Dispose();
        }
        protected override void OnParentChanged(EventArgs e) {
            base.OnParentChanged(e);
            if(Parent != null && Filter != null)
                UpdatePreview();
            else if(Parent == null) {
                ImageToFilter = null;
            }
        }
    }
}
