using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Data.OleDb;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.BandedGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Card;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.Utils;
using DevExpress.Utils.Drawing;
using DevExpress.Data;
using DevExpress.Utils.Frames;

namespace DevExpress.XtraGrid.Demos {
    public partial class CustomDraw : TutorialControl {
        public CustomDraw() {
            //
            // Required for Windows Form Designer support
            //
            CreateWaitDialog();
            InitializeComponent();
            InitAppearances();
            InitMenu();
            InitNWindData();
            //
            // TODO: Add any constructor code after InitializeComponent call
            //
        }
        Bitmap groupPanelImage;
        AppearanceDefault appCustomFocusedColumn, appCustomFilterPanel, appCustomPrice;

        #region Init
        private GridControl CurrentGrid { get { return gridControl1; } }
        private GridView CurrentView { get { return advBandedGridView1; } }
        private GridControl ProductGrid { get { return gridControl2; } }
        private GridView ProductView { get { return gridView1; } }

        private void InitMenu() {
            gridView1.PaintStyleName = "MixedXP";
        }
        protected override void InitMDBData(string connectionString) {
            DataSet ds = new DataSet();
            OleDbDataAdapter oleDBAdapter = new OleDbDataAdapter("SELECT * FROM Products", connectionString);
            SetWaitDialogCaption(Properties.Resources.LoadingProducts);
            oleDBAdapter.Fill(dsNWindProducts1.Products);

            oleDBAdapter = new OleDbDataAdapter("SELECT * FROM [Order Details]", connectionString);
            SetWaitDialogCaption(Properties.Resources.LoadingOrderDetails);
            oleDBAdapter.Fill(dsNWindProducts1.Order_Details);

            oleDBAdapter = new OleDbDataAdapter("SELECT * FROM Suppliers", connectionString);
            SetWaitDialogCaption(Properties.Resources.LoadingSuppliers);
            oleDBAdapter.Fill(dsNWindProducts1.Suppliers);
        }
        protected override void InitXMLData(string dataFileName) {
            DataSet ds = new DataSet();
            SetWaitDialogCaption(Properties.Resources.LoadingTables);
            ds.ReadXml(dataFileName);
            this.gridControl1.LevelTree.Nodes[0].RelationName = "ProductsOrderDetails";
            this.gridControl1.DataSource = ds.Tables["Products"];
            this.repositoryItemLookUpEdit1.DataSource = ds.Tables["Suppliers"];
            this.colSubTotal.Visible = false;
        }
        protected override void InitNWindData() {
            base.InitNWindData();
            string DBFileName = DevExpress.Utils.FilesHelper.FindingFileName(Application.StartupPath, "Data\\DXProducts.xml");
            if(DBFileName != "") {
                DataSet ds = new DataSet();
                SetWaitDialogCaption(Properties.Resources.LoadingDXProducts);
                ds.ReadXml(DBFileName);
                gridControl2.DataSource = ds.Tables[0].DefaultView;
            }
        }
        private void InitMasterDetailAppearance() {
            gridControl2.ForceInitialize();
            CurrentView.BeginUpdate();
            colUnitsOnOrder.FilterInfo = new ColumnFilterInfo(ColumnFilterType.Custom, null, "[UnitsOnOrder] < 50");
            colPlatform.FilterInfo = new ColumnFilterInfo(ColumnFilterType.Custom, null, "[Platform] <> 1");
            ProductView.SetRowExpanded(-2, true);
            CurrentView.ExpandAllGroups();
            CurrentView.FocusedRowHandle = 0;
            CurrentView.SetMasterRowExpanded(CurrentView.FocusedRowHandle, true);
            CurrentView.EndUpdate();
        }

        private void CustomDraw_Load(object sender, System.EventArgs e) {
            InitMasterDetailAppearance();
            SetBackGround(toolBarButton16.Pushed);
            groupPanelImage = (Bitmap)DevExpress.Utils.ResourceImageHelper.CreateImageFromResources("DevExpress.Utils.XtraFrames.dx-logo.png", typeof(ApplicationCaption).Assembly);
            groupPanelImage.MakeTransparent();
            panel1.Height = toolBar1.Height;
        }
        #endregion
        #region Custom draw stuff
        void UpdateInnerElements(DevExpress.XtraGrid.Views.Grid.ColumnHeaderCustomDrawEventArgs e, bool restore, ref Rectangle sortBounds, ref Rectangle filterBounds, ref ObjectInfoArgs filterInfo) {
            foreach(DevExpress.Utils.Drawing.DrawElementInfo item in e.Info.InnerElements) {
                if(item.ElementPainter is DevExpress.Utils.Drawing.SortedShapeObjectPainter) {
                    if(restore) {
                        item.ElementInfo.Bounds = sortBounds;
                    }
                    else {
                        sortBounds = item.ElementInfo.Bounds;
                        item.ElementInfo.Bounds = Rectangle.Empty;
                    }
                }
                if(item.ElementInfo is DevExpress.XtraEditors.Drawing.GridFilterButtonInfoArgs) {
                    if(restore) {
                        item.ElementInfo.Bounds = filterBounds;
                    }
                    else {
                        filterInfo = item.ElementInfo;
                        filterBounds = item.ElementInfo.Bounds;
                        item.ElementInfo.Bounds = Rectangle.Empty;
                    }
                }
            }
        }
        private static void DrawCustomSortedShape(Graphics g, Rectangle r, ColumnSortOrder so, ImageList iml) {
            if(so == ColumnSortOrder.None || iml == null) return;
            int i = 0;
            if(so == ColumnSortOrder.Descending) i = 1;
            g.DrawImageUnscaled(
                iml.Images[i],
                r.X + (r.Width - iml.ImageSize.Width) / 2,
                r.Y + (r.Height - iml.ImageSize.Height) / 2);
        }

        private static void DrawCustomFilterButton(Graphics g, GridColumn column, DevExpress.Utils.Drawing.ObjectInfoArgs filterInfo, ImageList iml) {
            if(iml == null) return;
            int i = 0;
            if((filterInfo.State & DevExpress.Utils.Drawing.ObjectState.Hot) != 0) i = 1;
            if((filterInfo.State & DevExpress.Utils.Drawing.ObjectState.Pressed) != 0) i = 2;
            if(column.FilterInfo.Type != ColumnFilterType.None) i += 3;
            g.DrawImageUnscaled(
                iml.Images[i],
                filterInfo.Bounds.X + (filterInfo.Bounds.Width - iml.ImageSize.Width) / 2,
                filterInfo.Bounds.Y + (filterInfo.Bounds.Height - iml.ImageSize.Height) / 2);
        }
        private ImageList FilterButtonImageList {
            get { return toolBarButton4.Pushed ? imlFilterShapes : null; }
        }

        private ImageList SortingGlyphsImageList {
            get { return toolBarButton4.Pushed ? imlSortShapes : null; }
        }
        private void advBandedGridView1_FocusedColumnChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedColumnChangedEventArgs e) {
            CurrentView.InvalidateColumnHeader(null);
            CurrentView.InvalidateGroupPanel();
        }
        private void toolBar1_ButtonClick(object sender, System.Windows.Forms.ToolBarButtonClickEventArgs e) {
            if(e.Button.ToolTipText == "Draw BackGround") SetBackGround(e.Button.Pushed);
            CurrentView.LayoutChanged();
        }
        private void SetBackGround(bool check) {
            CurrentView.Appearance.Empty.BackColor = check ? Color.Transparent : SystemColors.Window;
        }
        #endregion
        #region GridView custom draw events
        private void advBandedGridView1_CustomDrawGroupPanel(object sender, DevExpress.XtraGrid.Views.Base.CustomDrawEventArgs e) {
            if(!toolBarButton1.Pushed) return;
            Brush brush = new LinearGradientBrush(e.Bounds, Color.Sienna, Color.BurlyWood, 0.0);
            e.Graphics.FillRectangle(brush, e.Bounds);
            Image img = groupPanelImage;
            Rectangle r = new Rectangle(e.Bounds.X + e.Bounds.Width - img.Size.Width - 5, e.Bounds.Y + (e.Bounds.Height - img.Size.Height) / 2, img.Width, img.Height);
            e.Graphics.DrawImageUnscaled(img, r);
            e.Handled = true;
        }
        private void advBandedGridView1_CustomDrawBandHeader(object sender, DevExpress.XtraGrid.Views.BandedGrid.BandHeaderCustomDrawEventArgs e) {
            if(!toolBarButton2.Pushed || e.Band == null) return;
            Brush brush = new System.Drawing.Drawing2D.LinearGradientBrush(e.Bounds, Color.Wheat, Color.Chocolate, 70);
            Brush brushPressed = new System.Drawing.Drawing2D.LinearGradientBrush(e.Bounds, Color.WhiteSmoke, Color.Gray, 70);
            Rectangle r = e.Bounds;

            ControlPaint.DrawBorder3D(e.Graphics, r, (e.Info.State == DevExpress.Utils.Drawing.ObjectState.Pressed ? Border3DStyle.SunkenOuter : Border3DStyle.RaisedInner));
            r.Inflate(-1, -1);
            e.Graphics.FillRectangle((e.Info.State == DevExpress.Utils.Drawing.ObjectState.Pressed ? brushPressed : brush), r);

            r.Inflate(-2, 0);
            e.Graphics.DrawString(e.Band.Caption, e.Appearance.Font, Brushes.White, new RectangleF(r.X + 1, r.Y + 1, r.Width, r.Height), e.Appearance.GetStringFormat());
            e.Graphics.DrawString(e.Band.Caption, e.Appearance.Font, Brushes.Black, r, e.Appearance.GetStringFormat());
            e.Handled = true;
        }

        void InitAppearances() {
            appCustomFocusedColumn = new AppearanceDefault(Color.SaddleBrown, Color.Empty, new Font("Arial", 8.25F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline));
            appCustomFilterPanel = new AppearanceDefault(Color.White, Color.SteelBlue, Color.Empty, Color.SkyBlue, LinearGradientMode.ForwardDiagonal, HorzAlignment.Default, VertAlignment.Default, new Font("Arial", 8.25F, FontStyle.Bold));
            appCustomPrice = new AppearanceDefault(Color.Black, Color.Aquamarine, Color.Empty, Color.PaleGreen, LinearGradientMode.Vertical, HorzAlignment.Default, VertAlignment.Default, new Font("Arial", 8.25F, FontStyle.Italic));
        }
        private void advBandedGridView1_CustomDrawColumnHeader(object sender, DevExpress.XtraGrid.Views.Grid.ColumnHeaderCustomDrawEventArgs e) {
            Brush brush = new System.Drawing.Drawing2D.LinearGradientBrush(Rectangle.Inflate(e.Bounds, 1, 1), Color.Cornsilk, Color.DarkKhaki, 90);
            Brush brushPressed = new System.Drawing.Drawing2D.LinearGradientBrush(Rectangle.Inflate(e.Bounds, 1, 1), Color.WhiteSmoke, Color.Gray, 90);
            Rectangle r = e.Bounds;

            DevExpress.Utils.Drawing.ObjectInfoArgs filterInfo = null;
            Rectangle filterBounds, sortBounds;
            filterBounds = sortBounds = Rectangle.Empty;
            try {
                UpdateInnerElements(e, false, ref sortBounds, ref filterBounds, ref filterInfo);
                e.Painter.DrawObject(e.Info);
            }
            finally {
                UpdateInnerElements(e, true, ref sortBounds, ref filterBounds, ref filterInfo);
            }

            if(toolBarButton3.Pushed) {
                //paint Border & Rect
                BorderObjectInfoArgs border = new BorderObjectInfoArgs(null, r, null);
                BorderPainter borderPainter = (e.Info.State == DevExpress.Utils.Drawing.ObjectState.Pressed ? (BorderPainter)new Border3DSunkenPainter() : (BorderPainter)new Border3DRaisedPainter());
                ObjectPainter.DrawObject(e.Cache, borderPainter, border);
                r.Inflate(-1, -1);
                e.Graphics.FillRectangle((e.Info.State == DevExpress.Utils.Drawing.ObjectState.Pressed ? brushPressed : brush), r);
                r.Inflate(-2, 0);
                //paint Caption
                e.Appearance.ForeColor = Color.Black;
                if(e.Column != null) {
                    if(e.Column.AbsoluteIndex == CurrentView.FocusedColumn.AbsoluteIndex) {
                        AppearanceObject app = new AppearanceObject(appCustomFocusedColumn);
                        app.DrawString(e.Cache, e.Column.GetTextCaption(), r);
                    }
                    else
                        e.Appearance.DrawString(e.Cache, e.Column.GetTextCaption(), r);
                }
            }
            //paint Custom objects
            if(!sortBounds.IsEmpty)
                DrawCustomSortedShape(e.Graphics, sortBounds, e.Column.SortOrder, SortingGlyphsImageList);
            if(!filterBounds.IsEmpty && filterInfo != null)
                DrawCustomFilterButton(e.Graphics, e.Column, filterInfo, FilterButtonImageList);
            if(SortingGlyphsImageList == null)
                e.Info.InnerElements.DrawObjects(e.Info, e.Info.Cache, Point.Empty);
            e.Handled = true;
        }
        private void advBandedGridView1_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e) {
            if(!toolBarButton5.Pushed) return;
            Brush brush = new System.Drawing.Drawing2D.LinearGradientBrush(e.Bounds, Color.Cornsilk, Color.DarkKhaki, 90);
            Rectangle r = e.Bounds;
            r.Inflate(-1, -1);
            e.Graphics.FillRectangle(brush, r);
            if(e.Info.ImageIndex > -1) {
                int x = r.X + (r.Width - this.imlIndicator.ImageSize.Width) / 2;
                int y = r.Y + (r.Height - this.imlIndicator.ImageSize.Height) / 2;
                e.Graphics.DrawImageUnscaled(this.imlIndicator.Images[e.Info.ImageIndex], x, y);
            }
            r = e.Bounds;
            ControlPaint.DrawBorder3D(e.Graphics, r, Border3DStyle.RaisedInner);
            e.Handled = true;
        }
        private void advBandedGridView1_CustomDrawGroupRow(object sender, DevExpress.XtraGrid.Views.Base.RowObjectCustomDrawEventArgs e) {
            if(!toolBarButton6.Pushed) return;
            DevExpress.XtraGrid.Views.Grid.ViewInfo.GridGroupRowInfo group = e.Info as DevExpress.XtraGrid.Views.Grid.ViewInfo.GridGroupRowInfo;
            Rectangle button = group.ButtonBounds, textBounds = group.Bounds;

            Brush brush = new LinearGradientBrush(textBounds, Color.LemonChiffon, Color.Tan, 0.0);
            Brush brushImage = Brushes.LemonChiffon;
            Brush brushText = Brushes.Black, brushTextShadow = Brushes.White;
            if(e.RowHandle == CurrentView.FocusedRowHandle) {
                brush = brushTextShadow = brushImage = Brushes.DarkBlue;
                brushText = Brushes.White;
            }
            e.Graphics.FillRectangle(brush, textBounds);
            e.Appearance.Font = new Font("Arial", 8.25F, FontStyle.Bold);
            if(!button.IsEmpty) {
                textBounds.Width = textBounds.Right - (button.Right + 4);
                textBounds.X = button.Right + 4;
                int x = button.X;
                int y = textBounds.Y + (textBounds.Height - this.imlCustomDrawImages.ImageSize.Height) / 2;
                e.Graphics.DrawImageUnscaled(this.imlCustomDrawImages.Images[(CurrentView.GetRowExpanded(e.RowHandle) ? 1 : 0)], x, y);
            }
            string s = CurrentView.GetGroupRowDisplayText(e.RowHandle);
            e.Appearance.DrawString(e.Cache, s, new Rectangle(textBounds.X + 1, textBounds.Y + 1, textBounds.Width, textBounds.Height), brushTextShadow);
            e.Appearance.DrawString(e.Cache, s, textBounds, brushText);

            e.Handled = true;
        }
        private void advBandedGridView1_GroupLevelStyle(object sender, DevExpress.XtraGrid.Views.Grid.GroupLevelStyleEventArgs e) {
            if(!toolBarButton6.Pushed) return;
            e.LevelAppearance.BackColor = System.Drawing.Color.LemonChiffon;
        }
        private void advBandedGridView1_CustomDrawFooter(object sender, DevExpress.XtraGrid.Views.Base.RowObjectCustomDrawEventArgs e) {
            if(!toolBarButton7.Pushed) return;
            Brush brush = new System.Drawing.Drawing2D.LinearGradientBrush(e.Bounds, Color.Cornsilk, Color.DarkKhaki, 90);
            e.Graphics.FillRectangle(brush, e.Bounds);
            ControlPaint.DrawBorder3D(e.Graphics, e.Bounds, Border3DStyle.RaisedInner);
            e.Handled = true;
        }
        private void advBandedGridView1_CustomDrawFooterCell(object sender, DevExpress.XtraGrid.Views.Grid.FooterCellCustomDrawEventArgs e) {
            if(!toolBarButton8.Pushed) return;
            if(e.Bounds.Width == 0) return;
            int dx = e.Bounds.Height;
            Brush brush = new System.Drawing.Drawing2D.LinearGradientBrush(e.Bounds, Color.Wheat, Color.FloralWhite, 90);

            Rectangle r = e.Bounds;
            ControlPaint.DrawBorder3D(e.Graphics, r,
                ((BandedGridColumn)e.Column).OwnerBand.Index == 0 ? Border3DStyle.RaisedInner : Border3DStyle.SunkenOuter);

            r.Inflate(-1, -1);
            e.Graphics.FillRectangle(brush, r);

            r.Inflate(-2, 0);
            e.Appearance.ForeColor = Color.Black;
            e.Appearance.DrawString(e.Cache, e.Info.DisplayText, r);

            int x = r.X + 2;
            int y = r.Y + (r.Height - this.imlCustomDrawImages.ImageSize.Height) / 2;
            if(e.Column.SummaryItem.SummaryType == SummaryItemType.Count)
                e.Graphics.DrawImageUnscaled(this.imlCustomDrawImages.Images[2], x, y);
            if(e.Column.SummaryItem.SummaryType == SummaryItemType.Average)
                e.Graphics.DrawImageUnscaled(this.imlCustomDrawImages.Images[3], x, y);
            e.Handled = true;
        }
        private void advBandedGridView1_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e) {
            if(!toolBarButton9.Pushed) return;
            if((e.RowHandle == CurrentView.FocusedRowHandle && e.Column != CurrentView.FocusedColumn) && CurrentView == CurrentGrid.FocusedView) return;
            Rectangle r = e.Bounds;
            if(e.Column.FieldName == "UnitsInStock") {
                bool check = (bool)CurrentView.GetRowCellValue(e.RowHandle, colDiscontinued);
                Brush ellipseBrush = check ? Brushes.Silver : Brushes.LightSkyBlue;
                if(!check && Convert.ToInt16(e.CellValue) > 50) ellipseBrush = Brushes.LightGreen;
                e.Graphics.FillEllipse(ellipseBrush, r);
                r.Width -= 12;
                e.Appearance.DrawString(e.Cache, e.DisplayText, r);
                e.Handled = true;
            }
        }
        private void advBandedGridView1_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e) {
            if(!toolBarButton9.Pushed) return;
            if(e.Column == null) return;
            if(e.RowHandle != CurrentView.FocusedRowHandle || CurrentView != CurrentGrid.FocusedView || e.Column == CurrentView.FocusedColumn) {
                if(e.Column.FieldName == "UnitPrice" && (Decimal)CurrentView.GetRowCellValue(e.RowHandle, e.Column) < 20)
                    e.CombineAppearance(new AppearanceObject(appCustomPrice));
            }
        }
        private void advBandedGridView1_CustomDrawFilterPanel(object sender, DevExpress.XtraGrid.Views.Base.CustomDrawObjectEventArgs e) {
            if(!toolBarButton10.Pushed) return;
            e.Appearance.Assign(appCustomFilterPanel);
            e.Appearance.DrawBackground(e.Cache, e.Bounds);
            ControlPaint.DrawBorder3D(e.Graphics, e.Bounds, Border3DStyle.RaisedInner);
            DevExpress.XtraGrid.Drawing.GridFilterPanelInfoArgs info = e.Info as DevExpress.XtraGrid.Drawing.GridFilterPanelInfoArgs;
            DevExpress.XtraGrid.Drawing.GridFilterPanelPainter painter = e.Painter as DevExpress.XtraGrid.Drawing.GridFilterPanelPainter;
            info.Cache = e.Cache;
            painter.DrawForeground(info);
            info.Cache = null;
            e.Handled = true;
        }
        #endregion
        #region CardView custom draw events
        private void cardView1_CustomDrawCardCaption(object sender, DevExpress.XtraGrid.Views.Card.CardCaptionCustomDrawEventArgs e) {
            if(!toolBarButton12.Pushed) return;
            Brush brush = new System.Drawing.Drawing2D.LinearGradientBrush(e.Bounds, Color.Cornsilk, Color.DarkKhaki, 90);
            Brush brushFocused = new System.Drawing.Drawing2D.LinearGradientBrush(e.Bounds, Color.LavenderBlush, Color.Navy, 90);
            CardView cv = sender as CardView;
            bool isFocused = e.RowHandle == cv.FocusedRowHandle;

            Rectangle r = e.Bounds;
            ControlPaint.DrawBorder3D(e.Graphics, r, Border3DStyle.RaisedInner);
            r.Inflate(-1, -1);
            e.Graphics.FillRectangle((isFocused ? brushFocused : brush), r);
            r.Inflate(-2, 0);

            e.Appearance.DrawString(e.Cache, cv.GetCardCaption(e.RowHandle), r);
            //Draw Caption Border
            e.Graphics.FillRectangle(e.Appearance.GetBorderBrush(e.Cache), e.Bounds.X - 1, e.Bounds.Y - 1, 1, e.Bounds.Height);
            e.Graphics.FillRectangle(e.Appearance.GetBorderBrush(e.Cache), e.Bounds.X - 1, e.Bounds.Y - 1, e.Bounds.Width + 1, 1);
            e.Graphics.FillRectangle(e.Appearance.GetBorderBrush(e.Cache), e.Bounds.X + e.Bounds.Width, e.Bounds.Y - 1, 1, e.Bounds.Height);
            e.Handled = true;
        }
        private void cardView1_CustomDrawCardFieldCaption(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e) {
            if(!toolBarButton13.Pushed) return;
            Brush brush = new System.Drawing.Drawing2D.LinearGradientBrush(e.Bounds, Color.Aquamarine, Color.DarkSeaGreen, 90);
            Brush brushFocused = new System.Drawing.Drawing2D.LinearGradientBrush(e.Bounds, Color.LavenderBlush, Color.Navy, 90);
            CardView cv = sender as CardView;
            bool isFocused = false;
            if(cv.FocusedColumn != null)
                isFocused = e.Column.AbsoluteIndex == cv.FocusedColumn.AbsoluteIndex && e.RowHandle == cv.FocusedRowHandle;

            Rectangle r = e.Bounds;
            ControlPaint.DrawBorder3D(e.Graphics, r, Border3DStyle.RaisedInner);
            r.Inflate(-1, -1);
            e.Graphics.FillRectangle((isFocused ? brushFocused : brush), r);
            r.Y--;

            if(isFocused) e.Appearance.Assign(cardView1.PaintAppearance.FocusedCardCaption);
            e.Graphics.DrawString(e.Column.GetTextCaption(), new Font(e.Appearance.Font, isFocused ? FontStyle.Bold : FontStyle.Regular), e.Appearance.GetForeBrush(e.Cache), r, e.Appearance.GetStringFormat());
            e.Handled = true;
        }
        private void cardView1_CustomDrawCardFieldValue(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e) {
            if(!toolBarButton14.Pushed) return;
            Brush brush = new System.Drawing.Drawing2D.LinearGradientBrush(e.Bounds, Color.Aquamarine, Color.DarkSeaGreen, 0.0);
            if(e.Column.FieldName == "SubTotal") {
                brush = new System.Drawing.Drawing2D.LinearGradientBrush(e.Bounds, Color.White, Color.SkyBlue, 0.0);
                e.Appearance.Font = new Font(AppearanceObject.DefaultFont, FontStyle.Bold);
                e.Appearance.ForeColor = Color.Indigo;
            }

            e.Graphics.FillRectangle(brush, e.Bounds);
            e.Appearance.DrawString(e.Cache, e.DisplayText, e.Bounds);
            e.Handled = true;
        }
        #endregion
        #region Product Grid custom draw
        private void FillRectangle(Rectangle r, Graphics g) {
            Brush brush = new System.Drawing.Drawing2D.LinearGradientBrush(r, Color.FromArgb(209, 227, 241), Color.FromArgb(68, 121, 191), 90);
            g.FillRectangle(brush, r);
        }
        private void gridView1_CustomDrawColumnHeader(object sender, DevExpress.XtraGrid.Views.Grid.ColumnHeaderCustomDrawEventArgs e) {
            if(e.Info.State != DevExpress.Utils.Drawing.ObjectState.Pressed)
                FillRectangle(e.Bounds, e.Graphics);
        }

        private void gridView1_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e) {
            FillRectangle(e.Bounds, e.Graphics);
        }

        private void gridView1_CustomDrawRowPreview(object sender, DevExpress.XtraGrid.Views.Base.RowObjectCustomDrawEventArgs e) {
            Brush brush = new System.Drawing.Drawing2D.LinearGradientBrush(e.Bounds, Color.FromArgb(90, Color.White), Color.FromArgb(70, 68, 121, 191), 90);
            e.Graphics.FillRectangle(brush, e.Bounds);
            ControlPaint.DrawBorder3D(e.Graphics, e.Bounds, Border3DStyle.RaisedInner);
        }
        private void gridView1_CustomDrawRowFooter(object sender, DevExpress.XtraGrid.Views.Base.RowObjectCustomDrawEventArgs e) {
            FillRectangle(e.Bounds, e.Graphics);
            ControlPaint.DrawBorder3D(e.Graphics, e.Bounds, Border3DStyle.RaisedInner);
        }

        private void gridView1_CustomDrawRowFooterCell(object sender, DevExpress.XtraGrid.Views.Grid.FooterCellCustomDrawEventArgs e) {
            e.Graphics.FillRectangle(Brushes.Lavender, e.Bounds);
        }

        private void gridView1_CustomDrawFilterPanel(object sender, DevExpress.XtraGrid.Views.Base.CustomDrawObjectEventArgs e) {
            FillRectangle(e.Bounds, e.Graphics);
        }
        #endregion
        #region Selected grid
        private void xtraTabControl1_SelectedPageChanged(object sender, DevExpress.XtraTab.TabPageChangedEventArgs e) {
            InitBlendingMenu();
        }
        void InitBlendingMenu() {
            if(xtraTabControl1.SelectedTabPageIndex > 0)
                GridRibbonMenuManager.InitBlendingMenu(xtraGridBlending1);
            else GridRibbonMenuManager.InitBlendingMenu(null);
        }
        protected override void OnSetCaption(string caption) {
            base.OnSetCaption(caption);
            InitBlendingMenu();
        }
        #endregion
    }
}
