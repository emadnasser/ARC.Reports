using System;
using System.Text;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors.ViewInfo;
using DevExpress.XtraEditors.Drawing;
using System.Drawing;
using System.ComponentModel;
using DevExpress.XtraEditors.Registrator;
using DevExpress.XtraEditors.Controls;

namespace DevExpress.XtraGrid.Demos {
    public class RepositoryItemGridLookUpEditWithGlyph : RepositoryItemGridLookUpEdit {
        static RepositoryItemGridLookUpEditWithGlyph() {
            RegisterGridLookUpEditWithGlyph();
        }
        public event ImageByValueEventHandler GetImageByValue;
        public object GetImage(ImageByValueEventArgs e) {
            if(GetImageByValue != null)
                GetImageByValue(this, e);
            return e.Image;
        }
        public override string EditorTypeName { get { return "GridLookUpEditWithGlyph"; } }
        public static void RegisterGridLookUpEditWithGlyph() {
            EditorRegistrationInfo.Default.Editors.Add(new EditorClassInfo("GridLookUpEditWithGlyph", typeof(GridLookUpEditWithGlyph), typeof(RepositoryItemGridLookUpEditWithGlyph),
                typeof(GridLookUpEditWithGlyphBaseViewInfo), new GridEditPainterWithGlyph(), false));
        }
        public override void Assign(RepositoryItem item) {
            RepositoryItemGridLookUpEditWithGlyph li = item as RepositoryItemGridLookUpEditWithGlyph;
            if(li != null) {
                this.GetImageByValue += li.GetImageByValue;
            }
            base.Assign(item);
        }
    }
    public class GridLookUpEditWithGlyph : GridLookUpEdit {
        Image image;
        static GridLookUpEditWithGlyph() {
            RepositoryItemGridLookUpEdit.RegisterGridLookUpEdit();
        }
        public override string EditorTypeName { get { return "GridLookUpEditWithGlyph"; } }
        protected override void Dispose(bool disposing) {
            if(disposing && image != null) image.Dispose();
            this.image = null;
            base.Dispose(disposing);
        }
        [DefaultValue(null)]
        public Image Image {
            get { return image; }
            set {
                image = value;
                LayoutChanged();
            }
        }
    }
    public class GridLookUpEditWithGlyphBaseViewInfo : GridLookUpEditBaseViewInfo {
        Image image;
        public static Size DefaultImageSize = new Size(60, 16);
        public GridLookUpEditWithGlyphBaseViewInfo(RepositoryItem item) : base(item) { }
        public new GridLookUpEditWithGlyph OwnerEdit { get { return base.OwnerEdit as GridLookUpEditWithGlyph; } }
        public new RepositoryItemGridLookUpEditWithGlyph Item { get { return base.Item as RepositoryItemGridLookUpEditWithGlyph; } }
        public override bool IsExistImage { get { return true; } }
        public override Size ImageSize { get { return Image == null ? Size.Empty : DefaultImageSize; } }
        public override DevExpress.Utils.Drawing.TextGlyphDrawModeEnum GlyphDrawMode {
            get {
                if(ImageSize.IsEmpty) return DevExpress.Utils.Drawing.TextGlyphDrawModeEnum.Text;
                return DevExpress.Utils.Drawing.TextGlyphDrawModeEnum.TextGlyph;
            }
        }
        bool requireUpdateImage = false;
        protected override void OnEditValueChanged() {
            base.OnEditValueChanged();
            if(Bounds.IsEmpty) {
                this.requireUpdateImage = true;
                return;
            }
            UpdateImage();
        }
        public override void CalcViewInfo(Graphics g) {
            if(requireUpdateImage || OwnerEdit != null && OwnerEdit.Image != null) UpdateImage();
            base.CalcViewInfo(g);
        }
        public override void Reset() {
            base.Reset();
            this.image = null;
        }

        void UpdateImage() {
            this.requireUpdateImage = false;
            this.image = GetImageCore(EditValue);
        }
        Image GetImageCore(object editValue) {
            object ret = null;
            if(OwnerEdit != null) ret = OwnerEdit.Image;
            if(ret != null) return (Image)ret;

            if(Item != null && editValue != nullValue && editValue != null)
                ret = Item.GetImage(new ImageByValueEventArgs(editValue));
            if(ret == null) return null;
            if(ret is Image) return (Image)ret;
            return ByteImageConverter.FromByteArray(ByteImageConverter.ToByteArray(ret));
        }
        protected override Rectangle CalcGlyphBounds() {
            Rectangle res = base.CalcGlyphBounds();
            if(Image != null && OwnerEdit != null && OwnerEdit.InplaceType == DevExpress.XtraEditors.Controls.InplaceType.Standalone)
                res.Width = (Image.Size.Width * DefaultImageSize.Height) / Image.Size.Height;
            return res;
        }
        public Image Image { get { return image; } }
    }
    public class GridEditPainterWithGlyph : ButtonEditPainter {
        protected override void DrawGlyphCore(ControlGraphicsInfoArgs info, ButtonEditViewInfo be) {
            GridLookUpEditWithGlyphBaseViewInfo vi = be as GridLookUpEditWithGlyphBaseViewInfo;
            if(vi.Image == null) return;
            info.Graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            info.Paint.DrawImage(info.Graphics, vi.Image, CalcImageRect(vi.Image.Size, vi.GlyphBounds), new Rectangle(Point.Empty, vi.Image.Size), vi.State != DevExpress.Utils.Drawing.ObjectState.Disabled);
        }
        Rectangle CalcImageRect(Size imageSize, Rectangle rect) {
            int dh = (imageSize.Height * rect.Width) / imageSize.Width;
            int dw = (imageSize.Width * rect.Height) / imageSize.Height;
            if(dh > rect.Height) {
                rect.X += (rect.Width - dw) / 2;
                rect.Width = dw;
            }
            if(dw > rect.Width) {
                rect.Y += (rect.Height - dh) / 2;
                rect.Height = dh;
            }
            return rect;
        }
    }
 }
