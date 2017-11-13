namespace DashboardMainDemo.Dashboards {
    partial class SalesDetails {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) { 
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            DevExpress.DashboardCommon.Dimension dimension1 = new DevExpress.DashboardCommon.Dimension();
            DevExpress.DashboardCommon.CalculatedField calculatedField1 = new DevExpress.DashboardCommon.CalculatedField();
            DevExpress.DashboardCommon.Measure measure1 = new DevExpress.DashboardCommon.Measure();
            DevExpress.DashboardCommon.Measure measure2 = new DevExpress.DashboardCommon.Measure();
            DevExpress.DashboardCommon.Card card1 = new DevExpress.DashboardCommon.Card();
            DevExpress.DashboardCommon.Measure measure3 = new DevExpress.DashboardCommon.Measure();
            DevExpress.DashboardCommon.Measure measure4 = new DevExpress.DashboardCommon.Measure();
            DevExpress.DashboardCommon.Card card2 = new DevExpress.DashboardCommon.Card();
            DevExpress.DashboardCommon.Measure measure5 = new DevExpress.DashboardCommon.Measure();
            DevExpress.DashboardCommon.Measure measure6 = new DevExpress.DashboardCommon.Measure();
            DevExpress.DashboardCommon.Card card3 = new DevExpress.DashboardCommon.Card();
            DevExpress.DashboardCommon.Dimension dimension2 = new DevExpress.DashboardCommon.Dimension();
            DevExpress.DashboardCommon.Dimension dimension3 = new DevExpress.DashboardCommon.Dimension();
            DevExpress.DashboardCommon.Dimension dimension4 = new DevExpress.DashboardCommon.Dimension();
            DevExpress.DashboardCommon.Measure measure7 = new DevExpress.DashboardCommon.Measure();
            DevExpress.DashboardCommon.Dimension dimension5 = new DevExpress.DashboardCommon.Dimension();
            DevExpress.DashboardCommon.DashboardLayoutGroup dashboardLayoutGroup1 = new DevExpress.DashboardCommon.DashboardLayoutGroup();
            DevExpress.DashboardCommon.DashboardLayoutGroup dashboardLayoutGroup2 = new DevExpress.DashboardCommon.DashboardLayoutGroup();
            DevExpress.DashboardCommon.DashboardLayoutItem dashboardLayoutItem1 = new DevExpress.DashboardCommon.DashboardLayoutItem();
            DevExpress.DashboardCommon.DashboardLayoutItem dashboardLayoutItem2 = new DevExpress.DashboardCommon.DashboardLayoutItem();
            DevExpress.DashboardCommon.DashboardLayoutItem dashboardLayoutItem3 = new DevExpress.DashboardCommon.DashboardLayoutItem();
            this.listBoxDashboardItem2 = new DevExpress.DashboardCommon.ListBoxDashboardItem();
            this.dsSales = new DevExpress.DashboardCommon.DashboardObjectDataSource();
            this.cardSalesByProduct = new DevExpress.DashboardCommon.CardDashboardItem();
            this.listBoxDashboardItem1 = new DevExpress.DashboardCommon.ListBoxDashboardItem();
            ((System.ComponentModel.ISupportInitialize)(this.listBoxDashboardItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(dimension1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardSalesByProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(measure1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(measure2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(measure3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(measure4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(measure5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(measure6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(dimension2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(dimension3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(dimension4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(measure7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listBoxDashboardItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(dimension5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // listBoxDashboardItem2
            // 
            this.listBoxDashboardItem2.ComponentName = "listBoxDashboardItem2";
            dimension1.DataMember = "Category";
            this.listBoxDashboardItem2.DataItemRepository.Clear();
            this.listBoxDashboardItem2.DataItemRepository.Add(dimension1, "DataItem0");
            this.listBoxDashboardItem2.DataSource = this.dsSales;
            this.listBoxDashboardItem2.FilterDimensions.AddRange(new DevExpress.DashboardCommon.Dimension[] {
            dimension1});
            this.listBoxDashboardItem2.InteractivityOptions.IgnoreMasterFilters = true;
            this.listBoxDashboardItem2.ListBoxType = DevExpress.DashboardCommon.ListBoxDashboardItemType.Radio;
            this.listBoxDashboardItem2.Name = "Category";
            this.listBoxDashboardItem2.ShowCaption = true;
            // 
            // dsSales
            // 
            calculatedField1.Expression = "ToInt([UnitsReceived] - [UnitsSold] + [Returns])";
            calculatedField1.Name = "UnitsInStock";
            this.dsSales.CalculatedFields.AddRange(new DevExpress.DashboardCommon.CalculatedField[] {
            calculatedField1});
            this.dsSales.ComponentName = "dsSales";
            this.dsSales.DataSource = typeof(DashboardMainDemo.SalesDetailsDataGenerator.DataItem);
            this.dsSales.Name = "Sales";
            // 
            // cardSalesByProduct
            // 
            measure1.DataMember = "Revenue";
            measure2.DataMember = "RevenueTarget";
            card1.Name = "Revenue vs Target";
            card1.AddDataItem("ActualValue", measure1);
            card1.AddDataItem("TargetValue", measure2);
            measure3.DataMember = "UnitsSold";
            measure4.DataMember = "UnitsSoldTarget";
            card2.Name = "Units Sold vs Target";
            card2.AddDataItem("ActualValue", measure3);
            card2.AddDataItem("TargetValue", measure4);
            measure5.DataMember = "Returns";
            measure6.DataMember = "ReturnsTarget";
            card3.DeltaOptions.ResultIndicationMode = DevExpress.DashboardCommon.DeltaIndicationMode.LessIsGood;
            card3.Name = "Returns vs Target";
            card3.AddDataItem("ActualValue", measure5);
            card3.AddDataItem("TargetValue", measure6);
            this.cardSalesByProduct.Cards.AddRange(new DevExpress.DashboardCommon.Card[] {
            card1,
            card2,
            card3});
            this.cardSalesByProduct.ComponentName = "cardSalesByProduct";
            this.cardSalesByProduct.ContentArrangementMode = DevExpress.DashboardCommon.ContentArrangementMode.FixedColumnCount;
            this.cardSalesByProduct.ContentLineCount = 4;
            dimension2.DataMember = "CurrentDate";
            dimension2.DateTimeGroupInterval = DevExpress.DashboardCommon.DateTimeGroupInterval.Month;
            dimension3.DataMember = "Product";
            dimension4.DataMember = "Category";
            measure7.DataMember = "UnitsInStock";
            this.cardSalesByProduct.DataItemRepository.Clear();
            this.cardSalesByProduct.DataItemRepository.Add(dimension2, "DataItem8");
            this.cardSalesByProduct.DataItemRepository.Add(dimension3, "DataItem7");
            this.cardSalesByProduct.DataItemRepository.Add(dimension4, "DataItem6");
            this.cardSalesByProduct.DataItemRepository.Add(measure6, "DataItem5");
            this.cardSalesByProduct.DataItemRepository.Add(measure1, "DataItem0");
            this.cardSalesByProduct.DataItemRepository.Add(measure5, "DataItem4");
            this.cardSalesByProduct.DataItemRepository.Add(measure4, "DataItem3");
            this.cardSalesByProduct.DataItemRepository.Add(measure3, "DataItem2");
            this.cardSalesByProduct.DataItemRepository.Add(measure2, "DataItem1");
            this.cardSalesByProduct.DataItemRepository.Add(measure7, "DataItem9");
            this.cardSalesByProduct.DataSource = this.dsSales;
            this.cardSalesByProduct.HiddenMeasures.AddRange(new DevExpress.DashboardCommon.Measure[] {
            measure7});
            this.cardSalesByProduct.InteractivityOptions.IgnoreMasterFilters = false;
            this.cardSalesByProduct.Name = "Sales by Product";
            this.cardSalesByProduct.SeriesDimensions.AddRange(new DevExpress.DashboardCommon.Dimension[] {
            dimension4,
            dimension3});
            this.cardSalesByProduct.ShowCaption = true;
            this.cardSalesByProduct.SparklineArgument = dimension2;
            // 
            // listBoxDashboardItem1
            // 
            this.listBoxDashboardItem1.ComponentName = "listBoxDashboardItem1";
            dimension5.DataMember = "State";
            this.listBoxDashboardItem1.DataItemRepository.Clear();
            this.listBoxDashboardItem1.DataItemRepository.Add(dimension5, "DataItem0");
            this.listBoxDashboardItem1.DataSource = this.dsSales;
            this.listBoxDashboardItem1.FilterDimensions.AddRange(new DevExpress.DashboardCommon.Dimension[] {
            dimension5});
            this.listBoxDashboardItem1.InteractivityOptions.IgnoreMasterFilters = true;
            this.listBoxDashboardItem1.Name = "State";
            this.listBoxDashboardItem1.ShowCaption = true;
            // 
            // SalesDetails
            // 
            this.DataSources.AddRange(new DevExpress.DashboardCommon.IDashboardDataSource[] {
            this.dsSales});
            this.Items.AddRange(new DevExpress.DashboardCommon.DashboardItem[] {
            this.cardSalesByProduct,
            this.listBoxDashboardItem2,
            this.listBoxDashboardItem1});
            dashboardLayoutItem1.DashboardItem = this.listBoxDashboardItem2;
            dashboardLayoutItem1.Weight = 22.9126213592233D;
            dashboardLayoutItem2.DashboardItem = this.listBoxDashboardItem1;
            dashboardLayoutItem2.Weight = 77.0873786407767D;
            dashboardLayoutGroup2.ChildNodes.AddRange(new DevExpress.DashboardCommon.DashboardLayoutNode[] {
            dashboardLayoutItem1,
            dashboardLayoutItem2});
            dashboardLayoutGroup2.DashboardItem = null;
            dashboardLayoutGroup2.Orientation = DevExpress.DashboardCommon.DashboardLayoutGroupOrientation.Vertical;
            dashboardLayoutGroup2.Weight = 15.971606033717835D;
            dashboardLayoutItem3.DashboardItem = this.cardSalesByProduct;
            dashboardLayoutItem3.Weight = 84.028393966282167D;
            dashboardLayoutGroup1.ChildNodes.AddRange(new DevExpress.DashboardCommon.DashboardLayoutNode[] {
            dashboardLayoutGroup2,
            dashboardLayoutItem3});
            dashboardLayoutGroup1.DashboardItem = null;
            this.LayoutRoot = dashboardLayoutGroup1;
            this.Title.Text = "Sales Details";
            this.DataLoading += new DevExpress.DashboardCommon.DashboardDataLoadingEventHandler(this.SalesDetails_DataLoading);
            ((System.ComponentModel.ISupportInitialize)(dimension1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listBoxDashboardItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(measure1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(measure2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(measure3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(measure4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(measure5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(measure6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(dimension2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(dimension3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(dimension4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(measure7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardSalesByProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(dimension5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listBoxDashboardItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.DashboardCommon.CardDashboardItem cardSalesByProduct;
        private DevExpress.DashboardCommon.ListBoxDashboardItem listBoxDashboardItem2;
        private DevExpress.DashboardCommon.DashboardObjectDataSource dsSales;
        private DevExpress.DashboardCommon.ListBoxDashboardItem listBoxDashboardItem1;
    }
}
