using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors;
using DevExpress.Utils;
using DevExpress.XtraBars;
using DevExpress.XtraEditors.Controls;

namespace DevExpress.XtraGrid.Demos {
    public partial class ContextButtons : TutorialControl {
        public ContextButtons() {
            InitializeComponent();
            SetGalleryImageSize(300);
            InitializeAnimationTypeCombo();
        }

        private void InitializeAnimationTypeCombo() {
            this.repositoryItemImageComboBox1.Items.BeginUpdate();
            foreach(ContextAnimationType animation in Enum.GetValues(typeof(ContextAnimationType))) {
                ImageComboBoxItem item = new ImageComboBoxItem(animation.ToString(), animation);
                this.repositoryItemImageComboBox1.Items.Add(item);
            }
            this.repositoryItemImageComboBox1.Items.EndUpdate();
            this.barEditItem1.EditValue = ContextAnimationType.Default;
        }

        void item_CheckedChanged(object sender, ItemClickEventArgs e) {
            BarCheckItem item = (BarCheckItem)e.Item;
            if(item.Checked)
                this.winExplorerView1.ContextButtonOptions.AnimationType = (ContextAnimationType)item.Tag;
        }

        private void SetGalleryImageSize(int width) {
            this.winExplorerView1.OptionsViewStyles.ExtraLarge.ImageSize = new Size(width, (int)(width * 0.6));
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

            //this.winExplorerView1.ColumnSet.TextColumn = this.winExplorerView1.Columns["model.Name"];
            this.winExplorerView1.ColumnSet.DescriptionColumn = this.winExplorerView1.Columns["Description"];
            this.winExplorerView1.ColumnSet.ExtraLargeImageColumn = this.winExplorerView1.Columns["Photo"];
            this.winExplorerView1.ColumnSet.MediumImageColumn = this.winExplorerView1.Columns["Image"];
            this.winExplorerView1.ColumnSet.CheckBoxColumn = this.winExplorerView1.Columns["InStock"];
            this.winExplorerView1.ColumnSet.GroupColumn = this.winExplorerView1.Columns["category.Name"];
        }

        private void repositoryItemZoomTrackBar1_EditValueChanged(object sender, EventArgs e) {
            int value = ((ZoomTrackBarControl)sender).Value;
            SetGalleryImageSize(value);
        }

        Dictionary<int, bool> checkedValues;
        protected Dictionary<int, bool> CheckedValues {
            get {
                if(checkedValues == null)
                    checkedValues = new Dictionary<int, bool>();
                return checkedValues;
            }
        }
        Dictionary<int, int> ratingValues;
        protected Dictionary<int, int> RatingValues {
            get {
                if(ratingValues == null)
                    ratingValues = new Dictionary<int, int>();
                return ratingValues;
            }
        }
        private void winExplorerView1_ContextButtonCustomize(object sender, Views.WinExplorer.WinExplorerViewContextButtonCustomizeEventArgs e) {
            if(e.Item.Name == "itemText") {
                ((ContextButton)e.Item).Caption = GetContextButtonCaption(e.RowHandle, this.winExplorerView1.Columns["model.Name"], this.winExplorerView1.Columns["trademark.Name"]);
            }
            else if(e.Item.Name == "itemCheck") {
                if(!CheckedValues.ContainsKey(e.RowHandle))
                    CheckedValues.Add(e.RowHandle, e.RowHandle % 2 == 0);
                ((CheckContextButton)e.Item).Checked = CheckedValues[e.RowHandle];
            }
            else if(e.Item.Name == "itemRating") {
                if(!RatingValues.ContainsKey(e.RowHandle))
                    RatingValues.Add(e.RowHandle, e.RowHandle % 6);
                ((RatingContextButton)e.Item).Rating = RatingValues[e.RowHandle];
            }
        }
        string GetContextButtonCaption(int rowHandle, GridColumn model, GridColumn trademark) {
            string caption = string.Empty;
            if(model != null) 
                caption = (string)this.winExplorerView1.GetRowCellValue(rowHandle, model);
            if(caption != null && trademark != null && caption.Length < 20)
                caption = string.Format("{0} {1}", this.winExplorerView1.GetRowCellValue(rowHandle, trademark), caption); ;
            return caption;
        }

        private void winExplorerView1_ContextButtonClick(object sender, ContextItemClickEventArgs e) {
            if(e.Item.Name == "itemCheck") {
                CheckedValues[(int)e.DataItem] = ((CheckContextButton)e.Item).Checked;
            }
            else if(e.Item.Name == "itemRating") {
                RatingValues[(int)e.DataItem] = (int)((RatingContextButton)e.Item).Rating;
            }
            else if(e.Item.Name == "itemDownload"){
                MessageBox.Show("'Download' item clicked");
            }
            else if(e.Item.Name == "itemRemove") {
                MessageBox.Show("'Remove' item clicked");
            }
            else if(e.Item.Name == "itemInfo") {
                MessageBox.Show("'Info' item clicked");
            }
        }

        private void repositoryItemImageComboBox1_SelectedValueChanged(object sender, EventArgs e) {
            this.winExplorerView1.ContextButtonOptions.AnimationType = (ContextAnimationType)((ImageComboBoxItem)((ImageComboBoxEdit)sender).SelectedItem).Value;
        }
    }
}
