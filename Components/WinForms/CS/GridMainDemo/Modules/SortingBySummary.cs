using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using DevExpress.XtraGrid;
using DevExpress.Data;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraGrid.Drawing;
using DevExpress.Utils;
using DevExpress.Utils.Paint;

namespace DevExpress.XtraGrid.Demos {
    /// <summary>
    /// Summary description for SortingBySummary.
    /// </summary>
    public partial class SortingBySummary : TutorialControl {
        public SortingBySummary() {
            // This call is required by the Windows.Forms Form Designer.
            InitializeComponent();
            TutorialInfo.WhatsThisCodeFile = "CS\\GridMainDemo\\Modules\\SortingBySummary.cs";
            TutorialInfo.WhatsThisXMLFile = "DevExpress.XtraGrid.Demos.CodeInfo.SortingBySummary.xml";
            InitNWindData();
            // TODO: Add any initialization after the InitForm call

            //<gridControl1>
            /*
            ~Note: the following properties are set at design time and listed here only for demonstration purposes.
            gridView1.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "Product Name", null, "(Product: Count {0})"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Order Sum", null, "(Orders: Sum {0:c})"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Average, "Unit Price", null, "(Price: Avg {0:c})")});
            */
            //</gridControl1>
            

        }
        public override DevExpress.XtraGrid.Views.Base.BaseView ExportView { get { return gridView1; } }
        private void SortingBySummary_Load(object sender, System.EventArgs e) {
            gridControl1.DataSource = GroupIntervalData.CreateDataTable(500, false);
            cbeSorting.SelectedIndex = 4;
        }
        protected override void InitMDBData(string connectionString) {
            DemoHelper.AddCategoryImagesToEdit(connectionString, repositoryItemImageComboBox1);
        }
        //<cbeSorting>
        GridColumn GroupColumn { get { return gridColumn5; } }
        int CurrentSummaryItemIndex { get { return (int)cbeSorting.SelectedIndex / 2 - 1; } }
        ColumnSortOrder CurrentSortOrder { get { return cbeSorting.SelectedIndex % 2 == 0 ? ColumnSortOrder.Ascending : ColumnSortOrder.Descending; } }

        private void cbeSorting_SelectedIndexChanged(object sender, System.EventArgs e) {
            gridView1.BeginSort();
            try {
                gridView1.GroupSummarySortInfo.Clear();
                GroupColumn.SortOrder = CurrentSortOrder;
                if(CurrentSummaryItemIndex >= 0)
                    gridView1.GroupSummarySortInfo.Add(
                        gridView1.GroupSummary[CurrentSummaryItemIndex], CurrentSortOrder, GroupColumn);
            }
            finally {
                gridView1.EndSort();
            }
        }
        //</cbeSorting>
        
        private void gridView1_GridMenuItemClick(object sender, DevExpress.XtraGrid.Views.Grid.GridMenuItemClickEventArgs e) {
            if(e.MenuType != DevExpress.XtraGrid.Views.Grid.GridMenuType.Column) return;
            if(e.SummaryItem == null) return;
            int index = -1;
            if(e.DXMenuItem.Caption.IndexOf("Product") > -1) index = 2;
            if(e.DXMenuItem.Caption.IndexOf("Order Sum") > -1) index = 4;
            if(e.DXMenuItem.Caption.IndexOf("Price") > -1) index = 6;
            if(SortOrder.Descending.ToString() == e.SummaryFormat) index += 1;
            cbeSorting.SelectedIndex = -1;
            cbeSorting.SelectedIndex = index;
            e.Handled = true;
        }
        #region GenerateReport

        public override bool AllowGenerateReport { get { return false; } }

        #endregion
    }
}
