using DevExpress.Data.PivotGrid;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using System;
using System.Windows.Forms;
using System.Collections;

namespace DevExpress.XtraPivotGrid.Demos.Modules {
    /// <summary>
    /// Summary description for ProductReports.
    /// </summary>
    public partial class ProductReports : TutorialControl {
        public ProductReports() {
            //
            // Required for Windows Form Designer support
            //
            CreateWaitDialog();
            InitializeComponent();

            TutorialInfo.WhatsThisCodeFile = "CS\\PivotGridMainDemo\\Modules\\ProductReports.cs";
            TutorialInfo.WhatsThisXMLFile = "DevExpress.XtraPivotGrid.Demos.CodeInfo.ProductReports.xml";
            //
            // TODO: Add any constructor code after InitializeComponent call
            //
        }

        public override PivotGridControl ViewOptionsControl { get { return pivotGridControl1; } }
        public override PivotGridControl ExportControl { get { return pivotGridControl1; } }

        private void ProductReports_Load(object sender, System.EventArgs e) {
            pivotGridControl1.DataSource = GetNWindData("ProductReports");
            cbeDate.SelectedIndex = 1;
            rgReport.SelectedIndex = 0;
            pivotGridControl1.ValueImages = CategoryImageList;
            pivotGridControl1.HeaderImages = HeadersImageList;
            fieldProductSales.ImageIndex = 3;
        }

        private void pivotGridControl1_FieldValueDisplayText(object sender, DevExpress.XtraPivotGrid.PivotFieldDisplayTextEventArgs e) {
            if(e.Field == fieldShippedMonth && e.Value != null) {
                e.DisplayText = System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.MonthNames[Convert.ToInt32(e.Value) - 1];
                if(e.ValueType == PivotGridValueType.Total) e.DisplayText += " Total";
            }
        }

        protected override void DoShow() {
            SetCaption();
            OnSetDescription(ReportsDescriptions.ProductReportsDescriptions[rgReport.SelectedIndex]);
            base.DoShow();
        }

        //<rgReport>
        void SetReport() {
            DoShow();
            pivotGridControl1.BeginUpdate();
            try {
                pcCategories.Visible = rgReport.SelectedIndex == 1;
                pcDate.Visible = rgReport.SelectedIndex == 2;
                fieldShippedMonth.Visible = rgReport.SelectedIndex == 2;
                foreach(PivotGridField field in pivotGridControl1.Fields)
                    field.Area = PivotArea.FilterArea;
                fieldProductSales.Area = PivotArea.DataArea;
                fieldCategoryName.CustomTotals.Clear();
                fieldCategoryName.TotalsVisibility = PivotTotalsVisibility.AutomaticTotals;
                fieldCategoryName.Area = 0;
                fieldProductName.SortBySummaryInfo.Field = null;
                fieldProductName.SortOrder = PivotSortOrder.Ascending;
                fieldProductName.TopValueCount = 0;
                fieldAverageSale.Visible = fieldMinimumSale.Visible = false;
                pivotGridControl1.Groups[0].Clear();
                switch(rgReport.SelectedIndex) {
                    case 0:
                        fieldCategoryName.Area = PivotArea.RowArea;
                        break;
                    case 1:
                        fieldProductName.Area = PivotArea.RowArea;
                        if(ceCategories.Checked) {
                            fieldCategoryName.Area = PivotArea.RowArea;
                            fieldCategoryName.AreaIndex = 0;
                        }
                        else fieldCategoryName.Area = PivotArea.FilterArea;
                        break;
                    case 2:
                        fieldCategoryName.Area = PivotArea.RowArea;
                        fieldProductName.Area = PivotArea.RowArea;
                        SetDateInterval();
                        break;
                    case 3:
                        fieldCategoryName.TotalsVisibility = PivotTotalsVisibility.CustomTotals;
                        fieldCategoryName.Area = PivotArea.RowArea;
                        fieldProductName.Area = PivotArea.RowArea;
                        SetDateInterval(true);
                        fieldCategoryName.CustomTotals.Add(PivotSummaryType.Average);
                        fieldCategoryName.CustomTotals.Add(PivotSummaryType.Sum);
                        fieldCategoryName.CustomTotals.Add(PivotSummaryType.Max);
                        fieldCategoryName.CustomTotals.Add(PivotSummaryType.Min);
                        break;
                    case 4:
                        fieldShippedQuarter.SetAreaPosition(PivotArea.RowArea, 0);
                        fieldCategoryName.Area = PivotArea.RowArea;
                        fieldAverageSale.SetAreaPosition(PivotArea.DataArea, 1);
                        fieldMinimumSale.SetAreaPosition(PivotArea.DataArea, 2);
                        fieldAverageSale.Visible = fieldMinimumSale.Visible = true;
                        break;
                    case 5:
                        fieldProductName.Area = PivotArea.RowArea;
                        fieldCategoryName.Area = PivotArea.RowArea;
                        fieldProductName.SortBySummaryInfo.Field = fieldProductSales;
                        fieldProductName.SortOrder = PivotSortOrder.Descending;
                        fieldProductName.TopValueCount = 3;
                        break;
                }
            }
            finally {
                pivotGridControl1.EndUpdate();
            }
        }
        //</rgReport>
        //<cbeDate>
        void SetDateInterval() { SetDateInterval(false); }
        void SetDateInterval(bool showYearAndQuarter) {
            if(cbeDate.SelectedIndex == 3 && !showYearAndQuarter)
                pivotGridControl1.Groups[0].AddRange(new PivotGridFieldBase[] { fieldShippedYear, fieldShippedQuarter, fieldShippedMonth });
            else pivotGridControl1.Groups[0].Clear();
            fieldShippedYear.Area = (cbeDate.SelectedIndex == 0 || cbeDate.SelectedIndex == 3 || showYearAndQuarter) ? PivotArea.ColumnArea : PivotArea.FilterArea;
            fieldShippedQuarter.Area = (cbeDate.SelectedIndex == 1 || cbeDate.SelectedIndex == 3 || showYearAndQuarter) ? PivotArea.ColumnArea : PivotArea.FilterArea;
            fieldShippedMonth.Area = (cbeDate.SelectedIndex == 2 || cbeDate.SelectedIndex == 3) ? PivotArea.ColumnArea : PivotArea.FilterArea;
            if(showYearAndQuarter) fieldShippedMonth.Area = PivotArea.FilterArea;
            fieldShippedYear.AreaIndex = 0;
            fieldShippedQuarter.AreaIndex = 1;
            fieldShippedMonth.AreaIndex = 2;
        }
        //</cbeDate>
        
        private void rgReport_SelectedIndexChanged(object sender, System.EventArgs e) {
            SetReport();
        }        

        private void ceCategories_CheckedChanged(object sender, System.EventArgs e) {
            SetReport();
        }
        
        private void cbeDate_SelectedIndexChanged(object sender, System.EventArgs e) {
            pivotGridControl1.BeginUpdate();
            try {
                SetDateInterval();
            }
            finally {
                pivotGridControl1.EndUpdate();
            }
        }        

        void SetCaption() {
            if(rgReport.SelectedIndex > -1)
                OnSetCaption(rgReport.Properties.Items[rgReport.SelectedIndex].Description);
        }
        //<ceDrillDown>
        private void pivotGridControl1_CellDoubleClick(object sender, DevExpress.XtraPivotGrid.PivotCellEventArgs e) {
            if(!ceDrillDown.Checked) return;
            XtraForm form = new XtraForm();
            form.Text = "Drill Down Form";
            form.StartPosition = FormStartPosition.CenterParent;
            DataGridView grid = new DataGridView();
            grid.Parent = form;
            grid.Dock = DockStyle.Fill;
            grid.DataSource = e.CreateDrillDownDataSource();
            form.Icon = ResourceImageHelper.CreateIconFromResourcesEx("DevExpress.XtraPivotGrid.Demos.AppIcon.ico", typeof(ProductReports).Assembly);
            form.Width = 520;
            form.Height = 300;
            form.ShowDialog();
            form.Dispose();
        }
        //</ceDrillDown>
        private void pivotGridControl1_FieldValueImageIndex(object sender, DevExpress.XtraPivotGrid.PivotFieldImageIndexEventArgs e) {
            if(e.Field == fieldCategoryName && Comparer.Equals(e.ValueType, PivotGridValueType.Value))
                e.ImageIndex = GetCategoryIndexByName(e.Value);
        }

        protected override void OnSetCaption(string fCaption) {
            Caption.Text = string.Format("{0}: {1}", TutorialName, fCaption);
        }
        
        private void ceDrillDown_CheckedChanged(object sender, EventArgs e) {

        }        
    }
}
