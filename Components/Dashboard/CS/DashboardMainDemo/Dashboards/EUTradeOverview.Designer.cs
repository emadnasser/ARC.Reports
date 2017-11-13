namespace DashboardMainDemo.Dashboards {
    partial class EUTradeOverview {
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
            DevExpress.DashboardCommon.CalculatedField calculatedField2 = new DevExpress.DashboardCommon.CalculatedField();
            DevExpress.DashboardCommon.Dimension dimension2 = new DevExpress.DashboardCommon.Dimension();
            DevExpress.DashboardCommon.Measure measure1 = new DevExpress.DashboardCommon.Measure();
            DevExpress.DashboardCommon.Measure measure2 = new DevExpress.DashboardCommon.Measure();
            DevExpress.DashboardCommon.Dimension dimension3 = new DevExpress.DashboardCommon.Dimension();
            DevExpress.DashboardCommon.Dimension dimension4 = new DevExpress.DashboardCommon.Dimension();
            DevExpress.DashboardCommon.Measure measure3 = new DevExpress.DashboardCommon.Measure();
            DevExpress.DashboardCommon.Measure measure4 = new DevExpress.DashboardCommon.Measure();
            DevExpress.DashboardCommon.DashboardLayoutGroup dashboardLayoutGroup1 = new DevExpress.DashboardCommon.DashboardLayoutGroup();
            DevExpress.DashboardCommon.DashboardLayoutGroup dashboardLayoutGroup2 = new DevExpress.DashboardCommon.DashboardLayoutGroup();
            DevExpress.DashboardCommon.DashboardLayoutGroup dashboardLayoutGroup3 = new DevExpress.DashboardCommon.DashboardLayoutGroup();
            DevExpress.DashboardCommon.DashboardLayoutItem dashboardLayoutItem1 = new DevExpress.DashboardCommon.DashboardLayoutItem();
            DevExpress.DashboardCommon.DashboardLayoutItem dashboardLayoutItem2 = new DevExpress.DashboardCommon.DashboardLayoutItem();
            DevExpress.DashboardCommon.DashboardLayoutItem dashboardLayoutItem3 = new DevExpress.DashboardCommon.DashboardLayoutItem();
            DevExpress.DashboardCommon.DashboardLayoutGroup dashboardLayoutGroup4 = new DevExpress.DashboardCommon.DashboardLayoutGroup();
            DevExpress.DashboardCommon.DashboardLayoutItem dashboardLayoutItem4 = new DevExpress.DashboardCommon.DashboardLayoutItem();
            this.listBoxFilterPartner = new DevExpress.DashboardCommon.ListBoxDashboardItem();
            this.dashboardExtractDataSource1 = new DevExpress.DashboardCommon.DashboardExtractDataSource();
            this.filtersGroup = new DevExpress.DashboardCommon.DashboardItemGroup();
            this.listBoxFilterProductGroup = new DevExpress.DashboardCommon.ListBoxDashboardItem();
            this.pieImportVsExport = new DevExpress.DashboardCommon.PieDashboardItem();
            this.treeMapTradeOverviewDetails = new DevExpress.DashboardCommon.TreemapDashboardItem();
            this.tradeOverviewGroup = new DevExpress.DashboardCommon.DashboardItemGroup();
            ((System.ComponentModel.ISupportInitialize)(this.listBoxFilterPartner)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(dimension1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dashboardExtractDataSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filtersGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listBoxFilterProductGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(dimension2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pieImportVsExport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(measure1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(measure2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeMapTradeOverviewDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(dimension3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(dimension4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(measure3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(measure4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tradeOverviewGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // listBoxFilterPartner
            // 
            this.listBoxFilterPartner.ComponentName = "listBoxFilterPartner";
            dimension1.DataMember = "Partner";
            this.listBoxFilterPartner.DataItemRepository.Clear();
            this.listBoxFilterPartner.DataItemRepository.Add(dimension1, "DataItem0");
            this.listBoxFilterPartner.DataSource = this.dashboardExtractDataSource1;
            this.listBoxFilterPartner.FilterDimensions.AddRange(new DevExpress.DashboardCommon.Dimension[] {
            dimension1});
            this.listBoxFilterPartner.Group = this.filtersGroup;
            this.listBoxFilterPartner.InteractivityOptions.IgnoreMasterFilters = true;
            this.listBoxFilterPartner.ListBoxType = DevExpress.DashboardCommon.ListBoxDashboardItemType.Radio;
            this.listBoxFilterPartner.Name = "Partner";
            this.listBoxFilterPartner.ShowCaption = true;
            // 
            // dashboardExtractDataSource1
            // 
            calculatedField1.Expression = "Iif([FLOW] = \'EXPORT\', [VALUE], 0)";
            calculatedField1.Name = "Export_Value";
            calculatedField2.Expression = "Iif([FLOW] = \'IMPORT\', [VALUE], 0)";
            calculatedField2.Name = "Import_Value";
            this.dashboardExtractDataSource1.CalculatedFields.AddRange(new DevExpress.DashboardCommon.CalculatedField[] {
            calculatedField1,
            calculatedField2});
            this.dashboardExtractDataSource1.ComponentName = "dashboardExtractDataSource1";
            this.dashboardExtractDataSource1.FileName = "|DataDirectory|\\Data\\EUTradeOverview.dat";
            this.dashboardExtractDataSource1.Filter = "";
            this.dashboardExtractDataSource1.Name = "Extract Data Source 1";
            // 
            // filtersGroup
            // 
            this.filtersGroup.ComponentName = "filtersGroup";
            this.filtersGroup.InteractivityOptions.IgnoreMasterFilters = true;
            this.filtersGroup.InteractivityOptions.IsMasterFilter = true;
            this.filtersGroup.Name = "Group 1";
            this.filtersGroup.ShowCaption = false;
            // 
            // listBoxFilterProductGroup
            // 
            this.listBoxFilterProductGroup.ComponentName = "listBoxFilterProductGroup";
            dimension2.DataMember = "Product_Group";
            dimension2.Name = "Product Group";
            this.listBoxFilterProductGroup.DataItemRepository.Clear();
            this.listBoxFilterProductGroup.DataItemRepository.Add(dimension2, "DataItem0");
            this.listBoxFilterProductGroup.DataSource = this.dashboardExtractDataSource1;
            this.listBoxFilterProductGroup.FilterDimensions.AddRange(new DevExpress.DashboardCommon.Dimension[] {
            dimension2});
            this.listBoxFilterProductGroup.Group = this.filtersGroup;
            this.listBoxFilterProductGroup.InteractivityOptions.IgnoreMasterFilters = true;
            this.listBoxFilterProductGroup.Name = "Product Group";
            this.listBoxFilterProductGroup.ShowCaption = true;
            // 
            // pieImportVsExport
            // 
            this.pieImportVsExport.ComponentName = "pieImportVsExport";
            measure1.DataMember = "Import_Value";
            measure1.Name = "Import";
            measure1.NumericFormat.FormatType = DevExpress.DashboardCommon.DataItemNumericFormatType.Currency;
            measure2.DataMember = "Export_Value";
            measure2.Name = "Export";
            measure2.NumericFormat.FormatType = DevExpress.DashboardCommon.DataItemNumericFormatType.Currency;
            this.pieImportVsExport.DataItemRepository.Clear();
            this.pieImportVsExport.DataItemRepository.Add(measure1, "DataItem0");
            this.pieImportVsExport.DataItemRepository.Add(measure2, "DataItem1");
            this.pieImportVsExport.DataSource = this.dashboardExtractDataSource1;
            this.pieImportVsExport.InteractivityOptions.IgnoreMasterFilters = false;
            this.pieImportVsExport.LabelContentType = DevExpress.DashboardCommon.PieValueType.Argument;
            this.pieImportVsExport.Name = "Import vs Export";
            this.pieImportVsExport.ShowCaption = false;
            this.pieImportVsExport.ShowPieCaptions = false;
            this.pieImportVsExport.Values.AddRange(new DevExpress.DashboardCommon.Measure[] {
            measure1,
            measure2});
            // 
            // treeMapTradeOverviewDetails
            // 
            dimension3.DataMember = "Product_Group";
            dimension3.GroupChildValues = true;
            dimension3.Name = "Product Group";
            dimension4.DataMember = "Product";
            this.treeMapTradeOverviewDetails.Arguments.AddRange(new DevExpress.DashboardCommon.Dimension[] {
            dimension3,
            dimension4});
            this.treeMapTradeOverviewDetails.ColoringOptions.MeasuresColoringMode = DevExpress.DashboardCommon.ColoringMode.None;
            this.treeMapTradeOverviewDetails.ComponentName = "treeMapTradeOverviewDetails";
            measure3.DataMember = "Export_Value";
            measure3.Name = "Export";
            measure3.NumericFormat.FormatType = DevExpress.DashboardCommon.DataItemNumericFormatType.Currency;
            measure4.DataMember = "Import_Value";
            measure4.Name = "Import";
            measure4.NumericFormat.FormatType = DevExpress.DashboardCommon.DataItemNumericFormatType.Currency;
            this.treeMapTradeOverviewDetails.DataItemRepository.Clear();
            this.treeMapTradeOverviewDetails.DataItemRepository.Add(measure3, "DataItem3");
            this.treeMapTradeOverviewDetails.DataItemRepository.Add(measure4, "DataItem0");
            this.treeMapTradeOverviewDetails.DataItemRepository.Add(dimension3, "DataItem1");
            this.treeMapTradeOverviewDetails.DataItemRepository.Add(dimension4, "DataItem2");
            this.treeMapTradeOverviewDetails.DataSource = this.dashboardExtractDataSource1;
            this.treeMapTradeOverviewDetails.Group = this.tradeOverviewGroup;
            this.treeMapTradeOverviewDetails.InteractivityOptions.IgnoreMasterFilters = false;
            this.treeMapTradeOverviewDetails.InteractivityOptions.MasterFilterMode = DevExpress.DashboardCommon.DashboardItemMasterFilterMode.Multiple;
            this.treeMapTradeOverviewDetails.Name = "Product";
            this.treeMapTradeOverviewDetails.ShowCaption = true;
            this.treeMapTradeOverviewDetails.Values.AddRange(new DevExpress.DashboardCommon.Measure[] {
            measure3,
            measure4});
            // 
            // tradeOverviewGroup
            // 
            this.tradeOverviewGroup.ComponentName = "tradeOverviewGroup";
            this.tradeOverviewGroup.InteractivityOptions.IgnoreMasterFilters = false;
            this.tradeOverviewGroup.InteractivityOptions.IsMasterFilter = true;
            this.tradeOverviewGroup.Name = "Group 2";
            this.tradeOverviewGroup.ShowCaption = false;
            // 
            // EUTradeOverview
            // 
            this.CurrencyCultureName = "gsw-FR";
            this.DataSources.AddRange(new DevExpress.DashboardCommon.IDashboardDataSource[] {
            this.dashboardExtractDataSource1});
            this.Groups.AddRange(new DevExpress.DashboardCommon.DashboardItemGroup[] {
            this.filtersGroup,
            this.tradeOverviewGroup});
            this.Items.AddRange(new DevExpress.DashboardCommon.DashboardItem[] {
            this.treeMapTradeOverviewDetails,
            this.listBoxFilterPartner,
            this.listBoxFilterProductGroup,
            this.pieImportVsExport});
            dashboardLayoutItem1.DashboardItem = this.listBoxFilterPartner;
            dashboardLayoutItem1.Weight = 54.601226993865033D;
            dashboardLayoutItem2.DashboardItem = this.listBoxFilterProductGroup;
            dashboardLayoutItem2.Weight = 45.398773006134967D;
            dashboardLayoutGroup3.ChildNodes.AddRange(new DevExpress.DashboardCommon.DashboardLayoutNode[] {
            dashboardLayoutItem1,
            dashboardLayoutItem2});
            dashboardLayoutGroup3.DashboardItem = this.filtersGroup;
            dashboardLayoutGroup3.Orientation = DevExpress.DashboardCommon.DashboardLayoutGroupOrientation.Vertical;
            dashboardLayoutGroup3.Weight = 69.957081545064383D;
            dashboardLayoutItem3.DashboardItem = this.pieImportVsExport;
            dashboardLayoutItem3.Weight = 30.042918454935624D;
            dashboardLayoutGroup2.ChildNodes.AddRange(new DevExpress.DashboardCommon.DashboardLayoutNode[] {
            dashboardLayoutGroup3,
            dashboardLayoutItem3});
            dashboardLayoutGroup2.DashboardItem = null;
            dashboardLayoutGroup2.Orientation = DevExpress.DashboardCommon.DashboardLayoutGroupOrientation.Vertical;
            dashboardLayoutGroup2.Weight = 20.692974013474494D;
            dashboardLayoutItem4.DashboardItem = this.treeMapTradeOverviewDetails;
            dashboardLayoutItem4.Weight = 100D;
            dashboardLayoutGroup4.ChildNodes.AddRange(new DevExpress.DashboardCommon.DashboardLayoutNode[] {
            dashboardLayoutItem4});
            dashboardLayoutGroup4.DashboardItem = this.tradeOverviewGroup;
            dashboardLayoutGroup4.Orientation = DevExpress.DashboardCommon.DashboardLayoutGroupOrientation.Vertical;
            dashboardLayoutGroup4.Weight = 79.3070259865255D;
            dashboardLayoutGroup1.ChildNodes.AddRange(new DevExpress.DashboardCommon.DashboardLayoutNode[] {
            dashboardLayoutGroup2,
            dashboardLayoutGroup4});
            dashboardLayoutGroup1.DashboardItem = null;
            this.LayoutRoot = dashboardLayoutGroup1;
            this.Title.Text = "EU Trade Overview 2015";
            ((System.ComponentModel.ISupportInitialize)(dimension1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listBoxFilterPartner)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dashboardExtractDataSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filtersGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(dimension2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listBoxFilterProductGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(measure1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(measure2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pieImportVsExport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(dimension3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(dimension4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(measure3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(measure4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeMapTradeOverviewDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tradeOverviewGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }







        #endregion

        private DevExpress.DashboardCommon.TreemapDashboardItem treeMapTradeOverviewDetails;
        private DevExpress.DashboardCommon.DashboardExtractDataSource dashboardExtractDataSource1;
        private DevExpress.DashboardCommon.DashboardItemGroup tradeOverviewGroup;
        private DevExpress.DashboardCommon.ListBoxDashboardItem listBoxFilterPartner;
        private DevExpress.DashboardCommon.DashboardItemGroup filtersGroup;
        private DevExpress.DashboardCommon.ListBoxDashboardItem listBoxFilterProductGroup;
        private DevExpress.DashboardCommon.PieDashboardItem pieImportVsExport;

    }
}
