using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.WinExplorer;
using DevExpress.XtraBars;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraEditors.Repository;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using System.Diagnostics;

namespace DevExpress.XtraGrid.Demos {
    public partial class WinExplorerViewDatabaseBinding : TutorialControl {
        public WinExplorerViewDatabaseBinding() {
            AutoMergeRibbon = true;
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e) {
            base.OnLoad(e);
            InitVehiclesData();
            InitGrid();
        }

        protected override void InitMDBData(string connectionString) {
            string tblModel = "Model", tblCategory = "Category", tblTrademark = "Trademark", tblBodyStyle = "BodyStyle", tblTransmissionType = "TransmissionType";
            DataSet ds = new DataSet();

            FillTable(tblModel, string.Format("SELECT model.ID, model.Name, category.Name, trademark.Name, transmission.Name, bodyStyle.Name, model.InStock, model.Photo, model.Image, model.Description FROM {0} model, {1} category, {2} trademark, {3} transmission, {4} bodyStyle WHERE model.TrademarkID=trademark.ID AND model.CategoryID=category.ID AND model.[Transmission Type]=transmission.ID AND model.BodyStyleID=bodyStyle.ID AND model.Photo Is Not Null", tblModel, tblCategory, tblTrademark, tblTransmissionType, tblBodyStyle), connectionString, ds);

            SetGridDataSource(tblModel, ds, this.gridControl1);
        }

        void FillTable(string table, string query, string connectionString, DataSet ds) {
            if(query == null) query = string.Format("SELECT * FROM {0}", table);
            System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter = new System.Data.OleDb.OleDbDataAdapter(query, connectionString);
            SetWaitDialogCaption(string.Format("Loading {0}...", table));
            oleDbDataAdapter.Fill(ds, table);
        }

        void SetGridDataSource(string table, DataSet ds, GridControl grid) {
            DataViewManager dvManager = new DataViewManager(ds);
            DataView dv = dvManager.CreateDataView(ds.Tables[table]);
            grid.DataMember = null;
            grid.DataSource = dv;
        }

        private void InitGrid() {
            this.winExplorerView1.Columns.Clear();
            this.winExplorerView1.Columns.Add(new GridColumn() { FieldName = "model.ID" });
            this.winExplorerView1.Columns.Add(new GridColumn() { FieldName = "model.Name" });
            this.winExplorerView1.Columns.Add(new GridColumn() { FieldName = "Description" });
            this.winExplorerView1.Columns.Add(new GridColumn() { FieldName = "Photo" });
            this.winExplorerView1.Columns.Add(new GridColumn() { FieldName = "Image" });
            this.winExplorerView1.Columns.Add(new GridColumn() { FieldName = "InStock" });
            this.winExplorerView1.Columns.Add(new GridColumn() { FieldName = "category.Name" });
            this.winExplorerView1.Columns.Add(new GridColumn() { FieldName = "trademark.Name" });
            this.winExplorerView1.Columns.Add(new GridColumn() { FieldName = "transmission.Name" });
            this.winExplorerView1.Columns.Add(new GridColumn() { FieldName = "bodyStyle.Name" });

            RepositoryItemTextEdit item = new RepositoryItemTextEdit();
            this.winExplorerView1.Columns["model.Name"].ColumnEdit = item;
            this.gridControl1.RepositoryItems.Add(item);

            this.winExplorerView1.ColumnSet.TextColumn = this.winExplorerView1.Columns["model.Name"];
            this.winExplorerView1.ColumnSet.DescriptionColumn = this.winExplorerView1.Columns["Description"];
            this.winExplorerView1.ColumnSet.ExtraLargeImageColumn = this.winExplorerView1.Columns["Photo"];
            this.winExplorerView1.ColumnSet.MediumImageColumn = this.winExplorerView1.Columns["Image"];
            this.winExplorerView1.ColumnSet.CheckBoxColumn = this.winExplorerView1.Columns["InStock"];
            this.winExplorerView1.ColumnSet.GroupColumn = this.winExplorerView1.Columns["category.Name"];
        }

        private void ribbonGalleryBarItem1_Gallery_ItemCheckedChanged(object sender, XtraBars.Ribbon.GalleryItemEventArgs e) {
            bool allowAsyncLoad = false;
            if(!e.Item.Checked)
                return;
            switch(e.Item.Caption) {
                case "Extra large icons":
                    allowAsyncLoad = true;
                    this.winExplorerView1.OptionsView.Style = WinExplorerViewStyle.ExtraLarge;
                    break;
                case "Large icons":
                    allowAsyncLoad = true;
                    this.winExplorerView1.OptionsView.Style = WinExplorerViewStyle.Large;
                    break;
                case "Medium icons":
                    allowAsyncLoad = true;
                    this.winExplorerView1.OptionsView.Style = WinExplorerViewStyle.Medium;
                    break;
                case "Small icons":
                    this.winExplorerView1.OptionsView.Style = WinExplorerViewStyle.Small;
                    break;
                case "List":
                    this.winExplorerView1.OptionsView.Style = WinExplorerViewStyle.List;
                    break;
                case "Tiles":
                    this.winExplorerView1.OptionsView.Style = WinExplorerViewStyle.Tiles;
                    break;
                case "Content":
                    this.winExplorerView1.OptionsView.Style = WinExplorerViewStyle.Content;
                    break;
            }
            UpdateGridOptionsImageLoad(allowAsyncLoad);
        }

        private void UpdateGridOptionsImageLoad(bool allowAsyncLoad) {
            if(winExplorerView1.OptionsImageLoad.AsyncLoad == allowAsyncLoad) return;
            winExplorerView1.OptionsImageLoad.AsyncLoad = allowAsyncLoad;
            winExplorerView1.RefreshData();
        }

        private void bcItemCheckBoxes_CheckedChanged(object sender, XtraBars.ItemClickEventArgs e) {
            this.winExplorerView1.OptionsView.ShowCheckBoxes = this.bcItemCheckBoxes.Checked;
        }

        private void bcGroupCaptionButton_CheckedChanged(object sender, XtraBars.ItemClickEventArgs e) {
            this.winExplorerView1.OptionsView.ShowExpandCollapseButtons = this.bcGroupCaptionButton.Checked;
        }
        
        private void bcGroupCheckBoxes_CheckedChanged(object sender, ItemClickEventArgs e) {
            this.winExplorerView1.OptionsView.ShowCheckBoxInGroupCaption = this.bcGroupCheckBoxes.Checked;
        }

        private void OnSortingCheckedChanged(object sender, XtraBars.ItemClickEventArgs e) {
            if(!((BarCheckItem)e.Item).Checked)
                return;
            if(e.Item == bcAscending) {
                this.winExplorerView1.ColumnSet.GroupColumn.SortOrder = DevExpress.Data.ColumnSortOrder.Ascending;
                this.winExplorerView1.ColumnSet.TextColumn.SortOrder = DevExpress.Data.ColumnSortOrder.Ascending;
            }
            if(e.Item == bcDescending) {
                this.winExplorerView1.ColumnSet.GroupColumn.SortOrder = DevExpress.Data.ColumnSortOrder.Descending;
                this.winExplorerView1.ColumnSet.TextColumn.SortOrder = DevExpress.Data.ColumnSortOrder.Descending;
            }
            if(e.Item == bcSortNone) {
                this.winExplorerView1.ColumnSet.GroupColumn.SortOrder = DevExpress.Data.ColumnSortOrder.None;
                this.winExplorerView1.ColumnSet.TextColumn.SortOrder = DevExpress.Data.ColumnSortOrder.None;
            }
        }

        private void OnGroupByCheckedChanged(object sender, ItemClickEventArgs e) {
            this.winExplorerView1.GroupCount = e.Item == this.bcGroupNone ? 0 : 1;
            if(e.Item == this.bcTrademark)
                this.winExplorerView1.ColumnSet.GroupColumn = this.winExplorerView1.Columns["trademark.Name"];
            else if(e.Item == this.bcTransmissionType)
                this.winExplorerView1.ColumnSet.GroupColumn = this.winExplorerView1.Columns["transmission.Name"];
            else if(e.Item == this.bcCategory)
                this.winExplorerView1.ColumnSet.GroupColumn = this.winExplorerView1.Columns["category.Name"];
            else if(e.Item == this.bcBodyStyle)
                this.winExplorerView1.ColumnSet.GroupColumn = this.winExplorerView1.Columns["bodyStyle.Name"];
        }
        private void OnAnimationTypeChanged(object sender, ItemClickEventArgs e) {
            if(e.Item == this.bcAnimationNone)
                this.winExplorerView1.OptionsImageLoad.AnimationType = ImageContentAnimationType.None;
            else if(e.Item == this.bcExpandAnimation)
                this.winExplorerView1.OptionsImageLoad.AnimationType = ImageContentAnimationType.Expand;
            else if(e.Item == this.bcPushAnimation)
                this.winExplorerView1.OptionsImageLoad.AnimationType = ImageContentAnimationType.Push;
            else if(e.Item == this.bcSlideAnimation)
                this.winExplorerView1.OptionsImageLoad.AnimationType = ImageContentAnimationType.Slide;
            else if(e.Item == this.bcSegmentedAnimation)
                this.winExplorerView1.OptionsImageLoad.AnimationType = ImageContentAnimationType.SegmentedFade;
            var dataSource = this.gridControl1.DataSource;
            this.gridControl1.DataSource = null;
            this.gridControl1.DataSource = dataSource;
        }

        private void barCheckItem1_ItemClick(object sender, ItemClickEventArgs e) {
            this.winExplorerView1.OptionsImageLoad.RandomShow = barCheckItem1.Checked;
        }

        private void winExplorerView1_GetThumbnailImage(object sender, ThumbnailImageEventArgs e) {
            Stopwatch w = new Stopwatch();
            w.Start();
            while(w.ElapsedMilliseconds < 20) { }
            w.Stop();
        }
    }
}
