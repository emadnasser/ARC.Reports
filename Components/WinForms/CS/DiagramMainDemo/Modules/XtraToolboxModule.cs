using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using DevExpress.Skins;
using System.IO;
using DevExpress.XtraEditors.Controls;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.DXperience.Demos;
using DevExpress.XtraToolbox;

namespace DevExpress.XtraDiagram.Demos {
    public partial class ToolboxModule : TutorialControlBase {
        public ToolboxModule() {
            InitializeComponent();
            cbItemViewMode.Properties.Items.AddRange(Enum.GetValues(typeof(ToolboxItemViewMode)));
            cbItemViewMode.SelectedIndex = 0;

            cbMinimizingScrollMode.Properties.Items.AddRange(Enum.GetValues(typeof(ToolboxMinimizingScrollMode)));
            cbMinimizingScrollMode.SelectedIndex = 0;

            cbeItemSelectMode.Properties.Items.AddRange(Enum.GetValues(typeof(ToolboxItemSelectMode)));
            cbeItemSelectMode.SelectedIndex = 0;

            ceAllowSmoothScrolling.Checked = Toolbox.OptionsBehavior.AllowSmoothScrolling;
            UpdateEditors();
            LoadData();
        }
        public ToolboxControl Toolbox {
            get { return xtraToolboxControl; }
        }
        public SimpleContentPanel ContentPanel {
            get { return gcContent; }
        }
        protected override void OnLoad(EventArgs e) {
            base.OnLoad(e);
            if(Toolbox.Groups.Count <= 0) return;
            Toolbox.SelectedGroup = Toolbox.Groups[0];
        }
        protected void UpdateEditors() {
            seColumnCount.Value = Toolbox.OptionsView.ColumnCount;
            ceShowSearchPanel.Checked = Toolbox.OptionsView.ShowSearchPanel;
            ceGroupsContentAutoSize.Checked = Toolbox.OptionsView.GroupPanelAutoHeight;
        }
        protected bool IsSmallImages {
            get { return cbImageSize.SelectedItem.ToString().Contains("16"); }
        }
        protected bool IsLargeImages {
            get { return cbImageSize.SelectedItem.ToString().Contains("32"); }
        }
        const string idActions = "Actions";
        const string idArrows = "Arrows";
        const string idExport = "Export";
        protected Dictionary<string, ImageCollection> AllSmallGroups {
            get {
                Dictionary<string, ImageCollection> dic = new Dictionary<string, ImageCollection>();
                dic[idActions] = icActionsSmall;
                dic[idArrows] = icArrowsSmall;
                dic[idExport] = icExportSmall;
                return dic;
            }
        }
        protected Dictionary<string, ImageCollection> AllLargeGroups {
            get {
                Dictionary<string, ImageCollection> dic = new Dictionary<string, ImageCollection>();
                dic[idActions] = icActionsLarge;
                dic[idArrows] = icArrowsLarge;
                dic[idExport] = icExportLarge;
                return dic;
            }
        }
        protected void LoadData() {
            Toolbox.Groups.Clear();
            if(IsSmallImages) {
                Toolbox.Groups.Add(LoadContentFrom(AllSmallGroups, idActions));
                Toolbox.Groups.Add(LoadContentFrom(AllSmallGroups, idArrows));
                Toolbox.Groups.Add(LoadContentFrom(AllSmallGroups, idExport));
            }
            if(IsLargeImages) {
                Toolbox.Groups.Add(LoadContentFrom(AllLargeGroups, idActions));
                Toolbox.Groups.Add(LoadContentFrom(AllLargeGroups, idArrows));
                Toolbox.Groups.Add(LoadContentFrom(AllLargeGroups, idExport));
            }
        }
        protected ToolboxGroup LoadContentFrom(Dictionary<string, ImageCollection> data) {
            ToolboxGroup group = new ToolboxGroup("All Items");
            foreach(string key in data.Keys) {
                group.Items.AddRange(LoadContentFrom(data, key, true).Items);
            }
            return group;
        }
        protected ToolboxGroup LoadContentFrom(Dictionary<string, ImageCollection> data, string id, bool beginGroup = false) {
            ToolboxGroup group = new ToolboxGroup(id);
            foreach(DXGalleryImageInfo info in data[id].Images.InnerImages) {
                ToolboxItem item = new ToolboxItem();
                item.Caption = GetImageName(info.Name);
                item.Image = info.Image;
                item.BeginGroup = beginGroup && group.Items.Count == 0;
                item.BeginGroupCaption = id;
                group.Items.Add(item);
            }
            return group;
        }
        protected string GetImageName(string fullName) {
            string[] names = fullName.Split('_');
            if(names.Length <= 0) return fullName;
            return names[0];
        }
        protected void ReloadData() {
            int selectedGroupIndex = -1;
            selectedGroupIndex = Toolbox.Groups.IndexOf(Toolbox.SelectedGroup as ToolboxGroup);
            LoadData();
            if(selectedGroupIndex < 0) return;
            Toolbox.SelectedGroup = Toolbox.Groups[selectedGroupIndex];
        }
        protected void OnImageSizeChanged(object sender, EventArgs e) {
            Size sz = Size.Empty;
            if(IsSmallImages)
                sz = new Size(16, 16);
            if(IsLargeImages)
                sz = new Size(32, 32);
            Toolbox.OptionsView.ItemImageSize = sz;
            UpdateToolboxButtons();
            ReloadData();
        }
        protected void UpdateToolboxButtons() {
            Toolbox.OptionsView.MenuButtonImage = IsSmallImages ? imagesSmall.Images[0] : imagesLarge.Images[0];
            Toolbox.OptionsView.MoreItemsButtonImage = IsSmallImages ? imagesSmall.Images[1] : imagesLarge.Images[1];
        }
        protected void OnColumnCountChanged(object sender, EventArgs e) {
            Toolbox.OptionsView.ColumnCount = (int)seColumnCount.Value;
        }
        protected void OnColumnCountMinimizingChanged(object sender, EventArgs e) {
            Toolbox.OptionsMinimizing.ColumnCount = (int)seColumnCountMinimizing.Value;
        }
        protected void OnItemViewModeChanged(object sender, EventArgs e) {
            Toolbox.OptionsView.ItemViewMode = (ToolboxItemViewMode)cbItemViewMode.EditValue;
        }
        protected void OnShowSearchPanelChanged(object sender, EventArgs e) {
            Toolbox.OptionsView.ShowSearchPanel = ceShowSearchPanel.Checked;
        }
        protected void OnToolboxDragItemDrop(object sender, ToolboxDragItemDropEventArgs e) {
            Point pt = ContentPanel.PointToClient(Cursor.Position);
            if(!ContentPanel.Bounds.Contains(pt)) return;
            Point indent = Point.Empty;
            foreach(ToolboxItem item in e.Items) {
                ImageInfo info = new ImageInfo();
                info.Image = item.Image;
                pt.Offset(-item.Image.Size.Width / 2, -item.Image.Height / 2);
                info.Bounds = new Rectangle(pt, item.Image.Size);
                ContentPanel.Images.Add(info);
            }
        }
        protected void OnGroupsContentAutoSizeChanged(object sender, EventArgs e) {
            Toolbox.OptionsView.GroupPanelAutoHeight = ceGroupsContentAutoSize.Checked;
        }
        protected void OnXtraToolboxSizeChanged(object sender, EventArgs e) {
            splitContainerControl1.SplitterPosition = Toolbox.Width;
        }
        protected void OnToolboxStateChanged(object sender, ToolboxStateChangedEventArgs e) {
            Toolbox.OptionsView.ShowMenuButton = Toolbox.OptionsMinimizing.State == ToolboxState.Minimized;
            UpdateEditors();
        }
        protected void OnToolboxDragItemMove(object sender, ToolboxDragItemMoveEventArgs e) {
            Point p = ContentPanel.PointToClient(e.Location);
            if(ContentPanel.Bounds.Contains(p))
                e.DragDropEffects = DragDropEffects.Copy;
            else
                e.DragDropEffects = DragDropEffects.None;
        }
        protected void OnToolboxDragItemStart(object sender, ToolboxDragItemStartEventArgs e) {
            e.Image = CreateDragImage(e.Items);
            e.Handled = true;
        }
        protected Image CreateDragImage(IEnumerable<IToolboxItem> items) {
            Size sz = Toolbox.OptionsView.ItemImageSize;
            int width = (sz.Width / 2) * items.Count<IToolboxItem>() + sz.Width / 2;
            int height = (sz.Height / 2) * items.Count<IToolboxItem>() + sz.Height / 2;
            Bitmap bmp = new Bitmap(width, height);
            Point loc = Point.Empty;
            using(Graphics g = Graphics.FromImage(bmp)) {
                foreach(ToolboxItem item in items) {
                    g.DrawImage(item.Image, loc);
                    loc.Offset(sz.Width / 2, sz.Height / 2);
                }
            }
            return bmp;
        }
        protected void OnAllowSmoothScrollingChanged(object sender, EventArgs e) {
            Toolbox.OptionsBehavior.AllowSmoothScrolling = ceAllowSmoothScrolling.Checked;
        }
        protected void OnItemSelectModeChanged(object sender, EventArgs e) {
            Toolbox.OptionsBehavior.ItemSelectMode = (ToolboxItemSelectMode)cbeItemSelectMode.SelectedItem;
        }
    }

    public class SimpleContentPanel : GroupControl {
        ImageCollectionCore collection;
        LabelControl hint;
        public SimpleContentPanel() {
            collection = CreateImageCollection();
            hint = CreateHint();
            SubscribeEvent();
        }
        public ImageCollectionCore Images {
            get { return collection; }
        }
        public LabelControl Hint {
            get { return hint; }
        }
        protected ImageCollectionCore CreateImageCollection() {
            return new ImageCollectionCore();
        }
        protected LabelControl CreateHint() {
            LabelControl lbl = new LabelControl();
            lbl.Text = "Drop item here...";
            Controls.Add(lbl);
            lbl.AutoSizeMode = LabelAutoSizeMode.None;
            lbl.Dock = DockStyle.Fill;
            lbl.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            lbl.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            lbl.Appearance.Font = new Font(lbl.Appearance.Font.FontFamily, 15.0f);
            return lbl;
        }
        protected override void OnPaint(PaintEventArgs e) {
            base.OnPaint(e);
            DrawImages(e);
        }
        protected override void OnLoaded() {
            base.OnLoaded();
            Invalidate();
        }
        protected void DrawImages(PaintEventArgs e) {
            foreach(ImageInfo info in Images) {
                e.Graphics.DrawImage(info.Image, info.Bounds);
            }
        }
        protected override void Dispose(bool disposing) {
            if(disposing)
                UnsubscribeEvent();
            base.Dispose(disposing);
        }
        protected void SubscribeEvent() {
            collection.ListChanged += OnCollectionChanged;
        }
        protected void UnsubscribeEvent() {
            collection.ListChanged -= OnCollectionChanged;
        }
        protected void OnCollectionChanged(object sender, ListChangedEventArgs e) {
            Invalidate();
            Hint.Visible = false;
        }
        protected override void OnSizeChanged(EventArgs e) {
            base.OnSizeChanged(e);
            Invalidate();
        }
    }

    public class ImageCollectionCore : CollectionBase, IEnumerable<ImageInfo> {
        public virtual void Add(ImageInfo item) {
            int index = List.Add(item);
            RaiseListChanged(new ListChangedEventArgs(ListChangedType.ItemAdded, index));
        }
        public virtual ImageInfo this[int index] {
            get { return List[index] as ImageInfo; }
            set {
                if(value == null)
                    return;
                List[index] = value;
            }
        }
        public virtual bool Remove(ImageInfo item) {
            if(!Contains(item)) return false;
            List.Remove(item);
            RaiseListChanged(new ListChangedEventArgs(ListChangedType.ItemDeleted, -1));
            return true;
        }
        public virtual void Insert(int position, ImageInfo item) {
            if(Contains(item)) return;
            List.Insert(position, item);
        }
        public virtual bool Contains(ImageInfo item) {
            return List.Contains(item);
        }
        public virtual int IndexOf(ImageInfo item) {
            return List.IndexOf(item);
        }
        int lockUpdate;
        public virtual void BeginUpdate() { lockUpdate++; }
        public virtual void EndUpdate() {
            if(--lockUpdate != 0) return;
            RaiseListChanged(new ListChangedEventArgs(ListChangedType.Reset, -1));
        }
        protected override void OnClear() {
            for(int n = Count - 1; n >= 0; n--)
                RemoveAt(n);
        }
        protected override void OnInsertComplete(int position, object value) {
            base.OnInsertComplete(position, value);
            RaiseListChanged(new ListChangedEventArgs(ListChangedType.ItemAdded, position));
        }
        protected override void OnRemoveComplete(int position, object value) {
            base.OnRemoveComplete(position, value);
            RaiseListChanged(new ListChangedEventArgs(ListChangedType.ItemDeleted, position));
        }
        protected override void OnClearComplete() {
            base.OnClearComplete();
            RaiseListChanged(new ListChangedEventArgs(ListChangedType.Reset, -1));
        }
        protected override void OnSetComplete(int index, object oldValue, object newValue) {
            base.OnSetComplete(index, oldValue, newValue);
            RaiseListChanged(new ListChangedEventArgs(ListChangedType.ItemChanged, index));
        }
        protected virtual void RaiseListChanged(ListChangedEventArgs e) {
            if(ListChanged == null) return;
            ListChanged(this, e);
        }
        public event ListChangedEventHandler ListChanged;
        #region IEnumerator
        IEnumerator<ImageInfo> IEnumerable<ImageInfo>.GetEnumerator() {
            return List.Cast<ImageInfo>().GetEnumerator();
        }
        #endregion
    }

    public class ImageInfo {
        public ImageInfo() { }
        public Image Image { get; set; }
        public Rectangle Bounds { get; set; }
    }
}
