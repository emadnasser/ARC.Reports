using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.BandedGrid;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraNavBar.Demos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DevExpress.XtraNavBar.Demos {
    public partial class AccordionControlBusinessModule : TutorialControl {
        public AccordionControlBusinessModule() {
            InitializeComponent();
            InitVehiclesData();
            InitGrid();
            InitAccordion();
        }
        DataSet dataSet;
        protected string GetDataDir() {
            string path = AppDomain.CurrentDomain.BaseDirectory;
            for(int i = 0; i < 10; i++) {
                path += "..\\";
                if(Directory.Exists(path + "Data"))
                    return path + "Data";
            }
            return string.Empty;
        }
        protected string DataPath {
            get {
                string dataPath = GetDataDir() + "\\AccordionControlData";
                if(Directory.Exists(dataPath))
                    return dataPath;
                return string.Empty;
            }
        }
        protected virtual void InitVehiclesData() {
            string DBFileName = string.Empty;
            DBFileName = DevExpress.Utils.FilesHelper.FindingFileName(DataPath, "\\Vehicles.mdb");
            if(DBFileName != string.Empty) {
                InitMDBData("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + DBFileName);
            }
        }
        protected void InitMDBData(string connectionString) {
            string tblModel = "Model", tblCategory = "Category", tblTrademark = "Trademark", tblBodyStyle = "BodyStyle", tblTransmissionType = "TransmissionType";
            DataSet ds = new DataSet();

            FillTable(tblModel,
                string.Format("SELECT model.ID, model.Name, model.Price, category.Name, model.[MPG City], model.[MPG Highway], model.Doors, trademark.Name, transmission.Name, bodyStyle.Name, model.Photo, model.Image, model.Description FROM {0} model, {1} category, {2} trademark, {3} transmission, {4} bodyStyle WHERE model.TrademarkID=trademark.ID AND model.CategoryID=category.ID AND model.[Transmission Type]=transmission.ID AND model.BodyStyleID=bodyStyle.ID ", tblModel, tblCategory, tblTrademark, tblTransmissionType, tblBodyStyle), connectionString, ds);

            SetGridDataSource(tblModel, ds, this.gridControl1);
            dataSet = ds;
        }

        void SetGridDataSource(string table, DataSet ds, GridControl grid) {
            grid.DataMember = "Model";
            grid.DataSource = ds;
        }
        void FillTable(string table, string query, string connectionString, DataSet ds) {
            if(query == null) query = string.Format("SELECT * FROM {0}", table);
            System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter = new System.Data.OleDb.OleDbDataAdapter(query, connectionString);
            oleDbDataAdapter.Fill(ds, table);
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
            this.winExplorerView1.Columns.Add(new GridColumn() { FieldName = "Price" });
            this.winExplorerView1.Columns.Add(new GridColumn() { FieldName = "Doors" });
            this.winExplorerView1.Columns.Add(new GridColumn() { FieldName = "MPG City" });
            this.winExplorerView1.Columns.Add(new GridColumn() { FieldName = "MPG Highway" });

            RepositoryItemTextEdit item = new RepositoryItemTextEdit();
            this.winExplorerView1.Columns["model.Name"].ColumnEdit = item;
            this.gridControl1.RepositoryItems.Add(item);

            this.winExplorerView1.ColumnSet.TextColumn = this.winExplorerView1.Columns["model.Name"];
            this.winExplorerView1.ColumnSet.DescriptionColumn = this.winExplorerView1.Columns["Price"];
            this.winExplorerView1.Columns["Price"].DisplayFormat.FormatType = Utils.FormatType.Numeric;
            this.winExplorerView1.Columns["Price"].DisplayFormat.FormatString = "c";
            this.winExplorerView1.ColumnSet.ExtraLargeImageColumn = this.winExplorerView1.Columns["Photo"];
            this.winExplorerView1.ColumnSet.MediumImageColumn = this.winExplorerView1.Columns["Image"];
            this.winExplorerView1.ColumnSet.CheckBoxColumn = this.winExplorerView1.Columns["InStock"];
        }

        private void InitAccordion() {
            InitMain();
            InitBody();
            InitEngine();
        }

        private void InitEngine() {
            InitMPGCity();
            InitMPGHighway();
        }

        private void InitMPGHighway() {
            rtbMPGHighway.Properties.Minimum = Convert.ToInt32(FindMinMax(true, "MPG Highway"));
            rtbMPGHighway.Properties.Maximum = Convert.ToInt32(FindMinMax(false, "MPG Highway"));

            int c = ((rtbMPGHighway.Properties.Maximum - rtbMPGHighway.Properties.Minimum) / rtbMPGHighway.Properties.TickFrequency) * rtbMPGHighway.Properties.TickFrequency + rtbMPGHighway.Properties.Minimum;
            rtbMPGHighway.Properties.Labels[0].Value = rtbMPGHighway.Properties.Minimum;
            rtbMPGHighway.Properties.Labels[1].Value = c;

            rtbMPGHighway.Properties.Labels[1].Label = rtbMPGHighway.Properties.Maximum.ToString();
            rtbMPGHighway.Properties.Labels[0].Label = rtbMPGHighway.Properties.Minimum.ToString();
        }

        private void InitMPGCity() {
            rtbMPGCity.Properties.Minimum = Convert.ToInt32(FindMinMax(true, "MPG City"));
            rtbMPGCity.Properties.Maximum = Convert.ToInt32(FindMinMax(false, "MPG City"));
            
            int c = ((rtbMPGCity.Properties.Maximum - rtbMPGCity.Properties.Minimum) / rtbMPGCity.Properties.TickFrequency) * rtbMPGCity.Properties.TickFrequency + rtbMPGCity.Properties.Minimum;
            rtbMPGCity.Properties.Labels[0].Value = rtbMPGCity.Properties.Minimum;
            rtbMPGCity.Properties.Labels[1].Value = c;

            rtbMPGCity.Properties.Labels[1].Label = rtbMPGCity.Properties.Maximum.ToString();
            rtbMPGCity.Properties.Labels[0].Label = rtbMPGCity.Properties.Minimum.ToString();
        }
        private void InitBody() {
            InitBodyStyle();
            InitDoorsCount();
        }
        private void InitDoorsCount() {
            rgDoorsCount.Properties.Items.Add(new RadioGroupItem("2", "2"));
            rgDoorsCount.Properties.Items.Add(new RadioGroupItem("3", "3"));
            rgDoorsCount.Properties.Items.Add(new RadioGroupItem("4", "4"));
            rgDoorsCount.Properties.Items.Add(new RadioGroupItem("All", "All"));
            rgDoorsCount.SelectedIndex = 3;
        }
        private void InitBodyStyle() {
            List<string> bodyStyles = GetListFromDB("bodyStyle.Name");
            foreach(string str in bodyStyles) {
                clbBodyStyle.Items.Add(str);
            }
        }

        private void InitMain() {
            if(dataSet == null || dataSet.Tables["Model"] == null)
                return;
            InitPrice();
            InitTrademarks();
            InitTransmissionType();
        }
        private void InitTransmissionType() {
           List<string> transmissions = GetListFromDB("transmission.Name");
           foreach(string str in transmissions) {
               rgTransmissionType.Properties.Items.Add(new RadioGroupItem(str, str));
           }
           rgTransmissionType.Properties.Items.Add(new RadioGroupItem("All", "All"));
           rgTransmissionType.SelectedIndex = 2;
        }
        private void InitPrice() {
            rTBPrice.Properties.Minimum = Convert.ToInt32(FindMinMax(true, "Price"));
            rTBPrice.Properties.Maximum = Convert.ToInt32(FindMinMax(false, "Price"));
            
            int c = ((rTBPrice.Properties.Maximum - rTBPrice.Properties.Minimum) / rTBPrice.Properties.TickFrequency) * rTBPrice.Properties.TickFrequency + rTBPrice.Properties.Minimum;
            rTBPrice.Properties.Labels[1].Value = rTBPrice.Properties.Minimum; 
            rTBPrice.Properties.Labels[0].Value = c;

            rTBPrice.Properties.Labels[0].Label = string.Format("{0:N0}", rTBPrice.Properties.Maximum);
            rTBPrice.Properties.Labels[1].Label = string.Format("{0:N0}", rTBPrice.Properties.Minimum);
        }
        private void InitTrademarks() {
            List<string> trademarks = GetListFromDB("trademark.Name");
            foreach(string str in trademarks) {
                chLBMark.Items.Add(str);
            }
        }
        
        private int FindMinMax(bool isMin, string column) {
            if(dataSet == null || dataSet.Tables["Model"] == null)
                return 0;
            int min = 0;
            int max = 0;
            foreach(DataRow row in dataSet.Tables["Model"].Rows) {
                string val = row[column].ToString();
                int cur;
                if(Int32.TryParse(val, out cur)) {
                    min = (min== 0) ? cur : Math.Min(min, cur);
                    max = Math.Max(max, cur);
                }
            }
            if(isMin) return min;
                return max;
        }
        private List<string> GetListFromDB(string column) {
            List<string> list = new List<string>();
            if(dataSet == null || dataSet.Tables["Model"] == null)
                return list;
            foreach(DataRow row in dataSet.Tables["Model"].Rows) {
                string str = row[column].ToString();
                if(!list.Contains(str)) list.Add(str);
            }
            list.Sort();
            return list;
        }
        
        private void rTBPrice_EditValueChanged(object sender, EventArgs e) {
            string str = "[Price] >= " + rTBPrice.Value.Minimum.ToString() + " AND [Price] <= " + rTBPrice.Value.Maximum.ToString();
            winExplorerView1.Columns["Price"].FilterInfo = new ColumnFilterInfo(str);
        }
        private string GetFilterString(string column, CheckedListBoxItemCollection checkedListBoxItemCollection) {
            string str = string.Empty;
            foreach(CheckedListBoxItem item in checkedListBoxItemCollection) {
                if(item.CheckState != CheckState.Checked) continue;
                if(str != string.Empty) str = str + "OR";
                str = str + "[" + column + "] = '" + item.Value.ToString() + "' ";
            }
            return str;
        }

        private void rgTransmissionType_SelectedIndexChanged(object sender, EventArgs e) {
            if(rgTransmissionType.SelectedIndex == 2) {
                winExplorerView1.Columns["transmission.Name"].FilterInfo = ColumnFilterInfo.Empty;
                return;
            }
            string str = rgTransmissionType.Properties.Items[rgTransmissionType.SelectedIndex].Value.ToString();
            str = "[transmission.Name] = '" +str + "'";
            winExplorerView1.Columns["transmission.Name"].FilterInfo = new ColumnFilterInfo(str);
        }
        private void rgDoorsCount_SelectedIndexChanged(object sender, EventArgs e) {
            if(rgDoorsCount.SelectedIndex == 3) {
                winExplorerView1.Columns["Doors"].FilterInfo = ColumnFilterInfo.Empty;
                return;
            }
            string str = rgDoorsCount.Properties.Items[rgDoorsCount.SelectedIndex].Value.ToString();
            str = "[Doors] = '" + str + "'";
            winExplorerView1.Columns["Doors"].FilterInfo = new ColumnFilterInfo(str);
        }
        private void chLBMark_ItemCheck(object sender, DevExpress.XtraEditors.Controls.ItemCheckEventArgs e) {
            string str = GetFilterString("trademark.Name", chLBMark.Items);
            winExplorerView1.Columns["trademark.Name"].FilterInfo = new ColumnFilterInfo(str);
        }
        private void clbBodyStyle_ItemCheck(object sender, DevExpress.XtraEditors.Controls.ItemCheckEventArgs e) {
            string str = GetFilterString("bodyStyle.Name", clbBodyStyle.Items);
            winExplorerView1.Columns["bodyStyle.Name"].FilterInfo = new ColumnFilterInfo(str);
        }
        private void rtbMPGCity_EditValueChanged(object sender, EventArgs e) {
            string str = "[MPG City] >= " + rtbMPGCity.Value.Minimum.ToString() + " AND [MPG City] <= " + rtbMPGCity.Value.Maximum.ToString();
            winExplorerView1.Columns["MPG City"].FilterInfo = new ColumnFilterInfo(str);
        }
        private void rtbMPGHighway_EditValueChanged(object sender, EventArgs e) {
            string str = "[MPG Highway] >= " + rtbMPGHighway.Value.Minimum.ToString() + " AND [MPG Highway] <= " + rtbMPGHighway.Value.Maximum.ToString();
            winExplorerView1.Columns["MPG Highway"].FilterInfo = new ColumnFilterInfo(str);
        }

        private void rTBPrice_BeforeShowValueToolTip(object sender, XtraEditors.TrackBarValueToolTipEventArgs e) {
            e.ShowArgs.ToolTip = string.Format("{0:C} - {1:C}", rTBPrice.Value.Minimum, rTBPrice.Value.Maximum);
        }

        private void rtbMPGCity_BeforeShowValueToolTip(object sender, XtraEditors.TrackBarValueToolTipEventArgs e) {
            e.ShowArgs.ToolTip = string.Format("{0} - {1}", rtbMPGCity.Value.Minimum, rtbMPGCity.Value.Maximum);
        }

        private void rtbMPGHighway_BeforeShowValueToolTip(object sender, XtraEditors.TrackBarValueToolTipEventArgs e) {
            e.ShowArgs.ToolTip = string.Format("{0} - {1}", rtbMPGHighway.Value.Minimum, rtbMPGHighway.Value.Maximum);
        }
     }
}
