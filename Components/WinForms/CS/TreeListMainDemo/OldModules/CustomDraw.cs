using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using DevExpress.Utils;
using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.Columns;
using DevExpress.XtraBars;
using DevExpress.DXperience.Demos;

namespace DevExpress.XtraTreeList.Demos {
    public partial class TreeListCustomDraw : TutorialControl {
        public override TreeList ExportControl { get { return treeList1; } }
        public override TreeList ViewOptionsControl { get { return treeList1; } }
        protected override string BarName { get { return "CustomDraw"; } }
        protected override BarManager Manager { get { return barManager1; } }
        protected override void InitBarInfo() {
            this.BarInfos.Add(new BarInfo("CustomDraw Column Header", new ItemClickEventHandler(MenuItemClick), imageList1.Images[0], true, true, false));
            this.BarInfos.Add(new BarInfo("CustomDraw NodeIndicator", new ItemClickEventHandler(MenuItemClick), imageList1.Images[1], true, true, false));
            this.BarInfos.Add(new BarInfo("CustomDraw Cell", new ItemClickEventHandler(MenuItemClick), imageList1.Images[2], true, true, false));
            this.BarInfos.Add(new BarInfo("CustomDraw Footer", new ItemClickEventHandler(MenuItemClick), imageList1.Images[3], true, true, false));
            this.BarInfos.Add(new BarInfo("CustomDraw Footer Cell", new ItemClickEventHandler(MenuItemClick), imageList1.Images[4], true, true, false));
            this.BarInfos.Add(new BarInfo("CustomDraw NodeButtons", new ItemClickEventHandler(MenuItemClick), imageList1.Images[6], true, true, false));
            this.BarInfos.Add(new BarInfo("CustomDraw NodeImages", new ItemClickEventHandler(MenuItemClick), imageList1.Images[7], true, true, false));
        }

        private DataView dataView;
        ImageList imgIndicator = null;

        public TreeListCustomDraw() {
            InitializeComponent();
            InitData();
            InitEditors();
        }

        void MenuItemClick(object sender, ItemClickEventArgs e) {
            treeList1.Invalidate();
        }


        private void InitData() {
            string DBFileName = DevExpress.Utils.FilesHelper.FindingFileName(Application.StartupPath, "Data\\Departments.xml");
            if(DBFileName != "") {
                DataSet dataSet = new DataSet();
                dataSet.ReadXml(DBFileName);
                treeList1.DataSource = dataView = dataSet.Tables[0].DefaultView;
                treeList1.PopulateColumns();
                treeList1.ExpandAll();
            }
        }

        private void InitEditors() {
            DevExpress.XtraEditors.Repository.RepositoryItemComboBox cb = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            treeList1.RepositoryItems.Add(cb);
            DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit se = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            treeList1.RepositoryItems.Add(se);

            string s, oldLocation = "";
            DataView dv = new DataView(dataView.Table);
            dv.Sort = "[Location] ASC";
            for(int i = 0; i < dv.Count; i++) {
                s = dv[i].Row.ItemArray.GetValue(5) as string;
                if(s != oldLocation)
                    cb.Items.Add(s);
                oldLocation = s;
            }
            cb.DropDownRows = 10;

            DevExpress.XtraTreeList.Columns.TreeListColumn col;

            treeList1.Columns["Location"].ColumnEdit = cb;
            col = treeList1.Columns["Department"];
            col.SummaryFooter = SummaryItemType.Count;
            col.AllNodesSummary = true;
            col = treeList1.Columns["Budget"];
            col.ColumnEdit = se;
            col.Format.FormatString = "c";
            col.RowFooterSummary = col.SummaryFooter = SummaryItemType.Sum;
            col.RowFooterSummaryStrFormat = col.SummaryFooterStrFormat = "Sum={0:c}";
            col.AllNodesSummary = true;
            treeList1.BestFitColumns();
            col.Width = 110;
        }

        private void treeList1_CustomDrawColumnHeader(object sender, DevExpress.XtraTreeList.CustomDrawColumnHeaderEventArgs e) {
            if(!GetBarItemPushed(0)) return;
            try {
                int dx = e.Bounds.Height;
                bool focused = (e.Column != null && treeList1.FocusedColumn != null && e.Column.AbsoluteIndex == treeList1.FocusedColumn.AbsoluteIndex);
                Brush brush;
                if(focused)
                    brush = new System.Drawing.Drawing2D.LinearGradientBrush(e.Bounds, Color.White, Color.LightGreen, 90);
                else
                    brush = new System.Drawing.Drawing2D.LinearGradientBrush(e.Bounds, Color.Cyan, Color.DeepSkyBlue, 90);
                Brush brushPressed = new System.Drawing.Drawing2D.LinearGradientBrush(e.Bounds, Color.WhiteSmoke, Color.Gray, focused ? 180 : 90);

                Rectangle r = e.Bounds;
                ControlPaint.DrawBorder3D(e.Graphics, r, (e.Pressed ? Border3DStyle.SunkenOuter : Border3DStyle.RaisedInner));
                r.Inflate(-1, -1);
                e.Graphics.FillRectangle((e.Pressed ? brushPressed : brush), r);
                r.Inflate(-2, 0);

                if(e.Column != null) {
                    int imageIndex = -1;
                    if(e.Column.SortOrder == SortOrder.Ascending) imageIndex = 2;
                    if(e.Column.SortOrder == SortOrder.Descending) imageIndex = 3;
                    if(imageIndex != -1) {
                        int x = r.X + r.Width - imglCustom.ImageSize.Width;
                        int y = r.Y + (r.Height - imglCustom.ImageSize.Height) / 2;
                        e.Graphics.DrawImageUnscaled(imglCustom.Images[imageIndex], x, y);
                        r.Width -= imglCustom.ImageSize.Width;
                    }
                    e.Appearance.DrawString(e.Cache, e.Column.Caption, r);
                }
                e.Handled = true;
            }
            catch { }
        }


        ImageList ImgIndicator {
            get {
                if(imgIndicator == null)
                    imgIndicator = DevExpress.Utils.ResourceImageHelper.CreateImageListFromResources("DevExpress.Utils.Indicator.bmp", typeof(DevExpress.Utils.ResourceImageHelper).Assembly, new Size(7, 9));
                return imgIndicator;
            }
        }

        private void treeList1_CustomDrawNodeIndicator(object sender, DevExpress.XtraTreeList.CustomDrawNodeIndicatorEventArgs e) {
            if(!GetBarItemPushed(1)) return;
            Brush brush = new System.Drawing.Drawing2D.LinearGradientBrush(e.Bounds, Color.Cyan, Color.DeepSkyBlue, 90);
            Rectangle r = e.Bounds;
            r.Inflate(-1, -1);
            e.Graphics.FillRectangle(brush, r);
            if(e.ImageIndex > -1) {
                int x = r.X + (r.Width - ImgIndicator.ImageSize.Width) / 2;
                int y = r.Y + (r.Height - ImgIndicator.ImageSize.Height) / 2;
                e.Graphics.DrawImageUnscaled(ImgIndicator.Images[e.ImageIndex], x, y);
            }
            r = e.Bounds;
            ControlPaint.DrawBorder3D(e.Graphics, r, Border3DStyle.RaisedInner);
            e.Handled = true;
        }

        private void treeList1_CustomDrawNodeCell(object sender, DevExpress.XtraTreeList.CustomDrawNodeCellEventArgs e) {
            if(!GetBarItemPushed(2)) return;
            if((e.Node == treeList1.FocusedNode && e.Column != treeList1.FocusedColumn) || e.Node == null || e.Column == null) return;
            if(e.Node[5].Equals(false)) {
                e.Appearance.Font = new Font(AppearanceObject.DefaultFont, FontStyle.Strikeout);
                e.Appearance.ForeColor = SystemColors.ControlDark;
            }
            bool isFocusedCell = (e.Column == treeList1.FocusedColumn && e.Node == treeList1.FocusedNode);
            Brush brush = null;
            Rectangle r = e.Bounds;
            bool ellipse = false;
            if(e.Column.FieldName == "Budget" && e.CellValue != null) {
                if((Decimal)e.CellValue > 500000)
                    brush = new System.Drawing.Drawing2D.LinearGradientBrush(e.Bounds, Color.Cyan, Color.DeepSkyBlue, 180);
                if((Decimal)e.CellValue < 100000)
                    brush = new System.Drawing.Drawing2D.LinearGradientBrush(e.Bounds, Color.LightGreen, Color.White, 180);
            }
            if(e.Column.FieldName == "Phone" && e.CellValue != null) {
                brush = (Brush)e.Appearance.GetBackBrush(e.Cache);
                if(isFocusedCell) brush = SystemBrushes.Highlight;
                ellipse = true;
            }
            if(brush != null) {
                e.Graphics.FillRectangle(brush, r);
                r.Inflate(-2, 0);
                if(ellipse) {
                    bool check = e.Node[5].Equals(true);
                    Brush ellipseBrush = check ? Brushes.LightGreen : Brushes.LightSkyBlue;
                    if(isFocusedCell) ellipseBrush = Brushes.Yellow;
                    e.Graphics.FillEllipse(ellipseBrush, r);
                }
                e.Appearance.DrawString(e.Cache, e.CellText, r);
                if(isFocusedCell)
                    DevExpress.Utils.Paint.XPaint.Graphics.DrawFocusRectangle(e.Graphics, e.Bounds, SystemColors.WindowText, e.Appearance.BackColor);
                e.Handled = true;
            }
        }

        private void treeList1_CustomDrawFooter(object sender, DevExpress.XtraTreeList.CustomDrawEventArgs e) {
            if(!GetBarItemPushed(3)) return;
            Brush brush = new System.Drawing.Drawing2D.LinearGradientBrush(e.Bounds, Color.Cyan, Color.DeepSkyBlue, 90);
            e.Graphics.FillRectangle(brush, e.Bounds);
            e.Handled = true;
        }

        private void DrawFooterCell(DevExpress.Utils.Drawing.GraphicsCache cache, Rectangle r, string s, AppearanceObject appObject) {
            if(s == "") return;
            Brush brush = new System.Drawing.Drawing2D.LinearGradientBrush(r, Color.LightSkyBlue, Color.Cyan, 90);
            ControlPaint.DrawBorder3D(cache.Graphics, r, Border3DStyle.SunkenOuter);

            r.Inflate(-1, -1);
            cache.Graphics.FillRectangle(brush, r);

            r.Inflate(-2, 0);
            appObject.DrawString(cache, s, r);
        }

        private void treeList1_CustomDrawFooterCell(object sender, DevExpress.XtraTreeList.CustomDrawFooterCellEventArgs e) {
            if(!GetBarItemPushed(4)) return;
            DrawFooterCell(e.Cache, e.Bounds, e.Text, e.Appearance);
            e.Handled = true;
        }

        private void treeList1_CustomDrawRowFooter(object sender, DevExpress.XtraTreeList.CustomDrawRowFooterEventArgs e) {
            if(!GetBarItemPushed(3)) return;
            Brush brush = new System.Drawing.Drawing2D.LinearGradientBrush(e.Bounds, Color.Cyan, Color.DeepSkyBlue, 90);
            e.Graphics.FillRectangle(brush, e.Bounds);
            e.Handled = true;
        }

        private void treeList1_CustomDrawRowFooterCell(object sender, DevExpress.XtraTreeList.CustomDrawRowFooterCellEventArgs e) {
            if(!GetBarItemPushed(4)) return;
            DrawFooterCell(e.Cache, e.Bounds, e.Text, e.Appearance);
            e.Handled = true;
        }

        private void treeList1_CustomDrawNodeButton(object sender, DevExpress.XtraTreeList.CustomDrawNodeButtonEventArgs e) {
            if(!GetBarItemPushed(5)) return;
            e.Graphics.DrawImageUnscaled(imglCustom.Images[e.Expanded ? 5 : 4], e.Bounds);
            e.Handled = true;
        }

        private void treeList1_FocusedColumnChanged(object sender, DevExpress.XtraTreeList.FocusedColumnChangedEventArgs e) {
            treeList1.Invalidate();
        }

        private void treeList1_CustomDrawNodeImages(object sender, DevExpress.XtraTreeList.CustomDrawNodeImagesEventArgs e) {
            if(!GetBarItemPushed(6)) return;
            if(!e.Node.Equals(treeList1.FocusedNode)) {
                try {
                    int Y = e.SelectRect.Top + (e.SelectRect.Height - ImageCollection.GetImageListImage(treeList1.SelectImageList, e.SelectImageIndex).Height) / 2;
                    ControlPaint.DrawImageDisabled(e.Graphics, ImageCollection.GetImageListImage(treeList1.SelectImageList, e.SelectImageIndex), e.SelectRect.X, Y, Color.Black);
                    e.Handled = true;
                }
                catch { }
            }
        }

        private void treeList1_TreeListMenuItemClick(object sender, DevExpress.XtraTreeList.TreeListMenuItemClickEventArgs e) {
            if(e.Column != null && e.Column.FieldName == "Budget"
                && e.MenuType == DevExpress.XtraTreeList.Menu.TreeListMenuType.Summary
                && e.SummaryType != SummaryItemType.Count) {
                string s = e.SummaryFormat;
                int i = s.IndexOf("0");
                if(i > 0) s = s.Substring(0, i) + "0:c}";
                e.SummaryFormat = s;
            }
        }
    }
}
