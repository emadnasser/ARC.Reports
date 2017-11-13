using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Tile;
using DevExpress.XtraEditors;
using DevExpress.XtraBars;
using DevExpress.XtraEditors.Controls;

namespace DevExpress.XtraGrid.Demos {
    public partial class TileView : TutorialControl {
        public TileView() {
            InitializeComponent();
            InitData();
            SetupView();
            InitOrientationDropDown();
            tileView1.ItemClick += tileView1_ItemClick;
            barCheckItem1.CheckedChanged += barCheckItem1_CheckedChanged;
            repositoryItemZoomTrackBar1.EditValueChanged += repositoryItemZoomTrackBar1_EditValueChanged;
            tileView1.OptionsBehavior.AllowSmoothScrolling = true;
        }

        void InitOrientationDropDown() {
            foreach(Orientation orientation in Enum.GetValues(typeof(Orientation))) {
                ImageComboBoxItem cbItem = new ImageComboBoxItem(orientation.ToString(), orientation);
                repositoryItemImageComboBox1.Items.Add(cbItem);
            }
            barEditItem2.EditValue = Orientation.Horizontal;
            barEditItem2.EditValueChanged += barEditItem2_EditValueChanged;
        }

        void barEditItem2_EditValueChanged(object sender, EventArgs e) {
            var orientation = (Orientation)barEditItem2.EditValue;
            tileView1.OptionsTiles.Orientation = orientation;
        }

        void repositoryItemZoomTrackBar1_EditValueChanged(object sender, EventArgs e) {
            int h = (int)(sender as BaseEdit).EditValue;
            int w = (int)(h * 1.78);
            tileView1.OptionsTiles.ItemSize = new Size(w, h);
        }

        void barCheckItem1_CheckedChanged(object sender, XtraBars.ItemClickEventArgs e) {
            if((sender as BarCheckItem).Checked)
                tileView1.ColumnSet.GroupColumn = tileView1.Columns["YearBuilt"];
            else
                tileView1.ColumnSet.GroupColumn = null;
        } 

        void SetupView() {
            try {
                // Setup tiles options
                tileView1.BeginUpdate();
                tileView1.OptionsTiles.RowCount = 3;
                tileView1.OptionsTiles.Padding = new Padding(20);
                tileView1.OptionsTiles.ItemPadding = new Padding(10);
                tileView1.OptionsTiles.IndentBetweenItems = 20;
                tileView1.OptionsTiles.ItemSize = new Size(340, 190);
                tileView1.Appearance.ItemNormal.ForeColor = Color.White;
                tileView1.Appearance.ItemNormal.BorderColor = Color.Transparent;
                //Setup tiles template
                TileViewItemElement leftPanel = new TileViewItemElement();
                TileViewItemElement splitLine = new TileViewItemElement();
                TileViewItemElement addressCaption = new TileViewItemElement();
                TileViewItemElement addressValue = new TileViewItemElement();
                TileViewItemElement yearBuiltCaption = new TileViewItemElement();
                TileViewItemElement yearBuiltValue = new TileViewItemElement();
                TileViewItemElement price = new TileViewItemElement();
                TileViewItemElement image = new TileViewItemElement();
                tileView1.TileTemplate.Add(leftPanel);
                tileView1.TileTemplate.Add(splitLine);
                tileView1.TileTemplate.Add(addressCaption);
                tileView1.TileTemplate.Add(addressValue);
                tileView1.TileTemplate.Add(yearBuiltCaption);
                tileView1.TileTemplate.Add(yearBuiltValue);
                tileView1.TileTemplate.Add(price);
                tileView1.TileTemplate.Add(image);
                //
                leftPanel.StretchVertical = true;
                leftPanel.Width = 122;
                leftPanel.TextLocation = new Point(-10, 0);
                leftPanel.Appearance.Normal.BackColor = Color.FromArgb(58, 166, 101);
                //
                splitLine.StretchVertical = true;
                splitLine.Width = 3;
                splitLine.TextAlignment = TileItemContentAlignment.Manual;
                splitLine.TextLocation = new Point(110, 0);
                splitLine.Appearance.Normal.BackColor = Color.White;
                //
                addressCaption.Text = "ADDRESS";
                addressCaption.TextAlignment = TileItemContentAlignment.TopLeft;
                addressCaption.Appearance.Normal.FontSizeDelta = -1;
                //
                addressValue.Column = tileView1.Columns["Address"];
                addressValue.AnchorElement = addressCaption;
                addressValue.AnchorIndent = 2;
                addressValue.MaxWidth = 100;
                addressValue.Appearance.Normal.FontStyleDelta = FontStyle.Bold;
                //
                yearBuiltCaption.Text = "YEAR BUILT";
                yearBuiltCaption.AnchorElement = addressValue;
                yearBuiltCaption.AnchorIndent = 14;
                yearBuiltCaption.Appearance.Normal.FontSizeDelta = -1;
                //
                yearBuiltValue.Column = tileView1.Columns["YearBuilt"];
                yearBuiltValue.AnchorElement = yearBuiltCaption;
                yearBuiltValue.AnchorIndent = 2;
                yearBuiltValue.Appearance.Normal.FontStyleDelta = FontStyle.Bold;
                //
                price.Column = tileView1.Columns["PriceShort"];
                price.TextAlignment = TileItemContentAlignment.BottomLeft;
                price.Appearance.Normal.Font = new Font("Segoe UI Semilight", 25.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                //
                image.Column = tileView1.Columns["Image"];
                image.ImageSize = new Size(280, 220);
                image.ImageAlignment = TileItemContentAlignment.MiddleRight;
                image.ImageScaleMode = TileItemImageScaleMode.ZoomOutside;
                image.ImageLocation = new Point(10, 10);

            }
            finally {
                tileView1.EndUpdate();
            }
        }

        protected virtual void InitData() {
            try {
                var homesTable = VideoCatalogDataSet().Tables["Homes"];
                homesTable.Columns.Add("Image", typeof(Image));
                homesTable.Columns.Add("PriceShort", typeof(String));
                foreach(DataRow row in homesTable.Rows) {
                    var img = DevExpress.XtraEditors.Controls.ByteImageConverter.FromByteArray(row["Photo"] as byte[]);
                    row["Image"] = new Bitmap(img, new Size(351, 234));
                    Decimal price = (Decimal)row["Price"];
                    row["PriceShort"] = String.Format("${0}M", (price / 1000000).ToString("0.0"));
                }
                gridControl1.DataSource = homesTable;
            }
            catch { }
        }
        DataSet VideoCatalogDataSet() {
            DataSet ds = new DataSet();
            string DBFileName = DevExpress.Utils.FilesHelper.FindingFileName(Application.StartupPath, "Data\\Homes.xml");
            if(DBFileName != string.Empty) {
                SetWaitDialogCaption(Properties.Resources.LoadingTables);
                ds.ReadXml(DBFileName);
            }
            return ds;
        }

        Color colorPanelReady = Color.FromArgb(58, 166, 101);
        Color colorPanelSold = Color.FromArgb(158, 158, 158);
        Color colorCaptionReady = Color.FromArgb(193, 222, 204);
        Color colorCaptionSold = Color.FromArgb(219, 219, 219);


        private void tileView1_ItemCustomize(object sender, TileViewItemCustomizeEventArgs e) {
            if(e.Item == null || e.Item.Elements.Count == 0)
                return;
            int status = (int)tileView1.GetRowCellValue(e.RowHandle, tileView1.Columns["Status"]);
            Color panelColor = colorPanelReady;
            Color captionColor = colorCaptionReady;
            if(status == 1) {
                panelColor = colorPanelSold;
                captionColor = colorCaptionSold;
                e.Item.Elements[6].Text = "Sold";
            }
            e.Item.Elements[0].Appearance.Normal.BackColor = panelColor;
            e.Item.Elements[2].Appearance.Normal.ForeColor = captionColor;
            e.Item.Elements[4].Appearance.Normal.ForeColor = captionColor;
        }

        void tileView1_ItemClick(object sender, TileViewItemClickEventArgs e) {
            var addressColumn = tileView1.Columns["Address"];
            if(addressColumn == null) return;
            string address = tileView1.GetRowCellDisplayText(e.Item.RowHandle, addressColumn);
            MessageBox.Show(String.Format("'{0}' item clicked", address));
        }
    }
}
