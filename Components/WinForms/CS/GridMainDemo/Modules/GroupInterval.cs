using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.Utils.Menu;
using DevExpress.XtraGrid.Menu;
using DevExpress.XtraGrid.Localization;
using DevExpress.Utils;
using DevExpress.DXperience.Demos;

namespace DevExpress.XtraGrid.Demos {
    /// <summary>
    /// Summary description for GroupInterval.
    /// </summary>
    public partial class GroupInterval : TutorialControl {
        public GroupInterval() {
            // This call is required by the Windows.Forms Form Designer.
            InitializeComponent();
            TutorialInfo.WhatsThisCodeFile = "CS\\GridMainDemo\\Modules\\GroupInterval.cs";
            TutorialInfo.WhatsThisXMLFile = "DevExpress.XtraGrid.Demos.CodeInfo.GroupInterval.xml";

            // TODO: Add any initialization after the InitForm call

        }
        public override BaseView ExportView { get { return gridView1; } }
        private void GroupInterval_Load(object sender, System.EventArgs e) {
            InitNWindData();
            gridControl1.DataSource = GroupIntervalData.CreateDataTable(350);
            InitDrawMode();
            icbeDrawMode.EditValue = gridView1.OptionsView.GroupDrawMode;
            icbeAllowFixedGroups.EditValue = gridView1.OptionsBehavior.AllowFixedGroups;
            cbeInterval.SelectedIndex = 0;
            gridView1.ExpandGroupRow(-1);
            gridView1.TopRowIndex = 2;
        }

        protected override void InitMDBData(string connectionString) {
            DemoHelper.AddCategoryImagesToEdit(connectionString, repositoryItemImageComboBox1);
        }

        void InitDrawMode() {
            foreach(GroupDrawMode mode in Enum.GetValues(typeof(GroupDrawMode)))
                icbeDrawMode.Properties.Items.Add(new ImageComboBoxItem(EnumTitlesKeeper<GroupDrawMode>.GetTitle(mode), mode, -1));
            foreach(DefaultBoolean mode in Enum.GetValues(typeof(DefaultBoolean)))
                icbeAllowFixedGroups.Properties.Items.Add(new ImageComboBoxItem(EnumTitlesKeeper<DefaultBoolean>.GetTitle(mode), mode, -1));
        }

        //<icbeDrawMode>
        private void icbeDrawMode_SelectedIndexChanged(object sender, System.EventArgs e) {
            gridView1.OptionsView.GroupDrawMode = (GroupDrawMode)icbeDrawMode.EditValue;
        }
        //</icbeDrawMode>

        //<icbeAllowFixedGroups>
        private void icbeAllowFixedGroups_SelectedIndexChanged(object sender, EventArgs e) {
            gridView1.OptionsBehavior.AllowFixedGroups = (DefaultBoolean)icbeAllowFixedGroups.EditValue;
        }
        //</icbeAllowFixedGroups>

        //<cbeInterval>
        private void cbeInterval_SelectedIndexChanged(object sender, System.EventArgs e) {
            if(cbeInterval.EditValue.ToString().IndexOf("----") >= 0)
                cbeInterval.SelectedIndex = cbeInterval.Properties.Items.Count - 1;
            else SetGroupInterval(cbeInterval.SelectedIndex);
        }

        void SetInterval(GridColumn column, ColumnGroupInterval interval) {
            column.GroupInterval = interval;
            column.GroupIndex = 0;
        }

        void SetSortMode(GridColumn column, ColumnSortMode sortMode) {
            column.SortMode = sortMode;
            column.GroupIndex = 0;
        }

        void SetGroupInterval(int index) {
            gridView1.BeginSort();
            try {
                gridView1.ClearGrouping();
                foreach(GridColumn column in gridView1.Columns) {
                    column.GroupInterval = ColumnGroupInterval.Default;
                    column.SortMode = ColumnSortMode.Default;
                }
                switch(index) {
                    case 0:
                        SetInterval(gridColumn1, ColumnGroupInterval.Alphabetical);
                        gridColumn2.GroupInterval = ColumnGroupInterval.Alphabetical;
                        break;
                    case 1:
                        SetInterval(gridColumn5, ColumnGroupInterval.DateMonth);
                        break;
                    case 2:
                        SetInterval(gridColumn5, ColumnGroupInterval.DateYear);
                        break;
                    case 3:
                        SetInterval(gridColumn5, ColumnGroupInterval.DateRange);
                        break;
                    case 4:
                        SetSortMode(gridColumn4, ColumnSortMode.Custom);
                        break;
                    default:
                        SetInterval(gridColumn2, ColumnGroupInterval.Value);
                        break;
                }
            }
            finally {
                gridView1.EndSort();
                gridView1.CollapseAllGroups();
            }
        }

        private void gridView1_CustomColumnGroup(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnSortEventArgs e) {
            double x = Math.Floor(Convert.ToDouble(e.Value1) / 100);
            double y = Math.Floor(Convert.ToDouble(e.Value2) / 100);
            int res = Comparer.Default.Compare(x, y);
            if(x > 14 && y > 14) res = 0;
            e.Result = res;
            e.Handled = true;
        }
        //</cbeInterval>

        string IntervalByValue(object val) {
            double d = Math.Floor(Convert.ToDouble(val) / 100);
            string ret = string.Format("{0:c} - {1:c} ", d * 100, (d + 1) * 100);
            if(d > 14) ret = string.Format(">= {0:c} ", d * 100);
            return ret;
        }

        private void gridView1_CustomDrawGroupRow(object sender, DevExpress.XtraGrid.Views.Base.RowObjectCustomDrawEventArgs e) {
            GridGroupRowInfo info = e.Info as GridGroupRowInfo;
            if(info == null) return;
            if(info.Column.SortMode != ColumnSortMode.Custom) return;
            string interval = IntervalByValue(gridView1.GetGroupRowValue(info.RowHandle));
            string sumText = gridView1.GetGroupSummaryText(info.RowHandle);
            info.GroupText = string.Format("{2}: {0}{1}", interval, sumText, Properties.Resources.OrderSum);
        }

        private void gridView1_CellMerge(object sender, DevExpress.XtraGrid.Views.Grid.CellMergeEventArgs e) {
            if(e.Column.FieldName == "Order Date") {
                GridView view = sender as GridView;
                object val1 = view.GetRowCellValue(e.RowHandle1, e.Column);
                object val2 = view.GetRowCellValue(e.RowHandle2, e.Column);
                DateTime dt1 = val1 != DBNull.Value ? Convert.ToDateTime(val1) : DateTime.MinValue;
                DateTime dt2 = val2 != DBNull.Value ? Convert.ToDateTime(val2) : DateTime.MinValue;
                e.Merge = dt1.Date == dt2.Date;
                e.Handled = true;
            }
        }

        private void gridView1_GridMenuItemClick(object sender, GridMenuItemClickEventArgs e) {
            if(e.MenuType != GridMenuType.Column) return;
            if(gridView1.GroupCount != 1) return;
            switch(e.SummaryFormat) {
                case "DateMonth": cbeInterval.SelectedIndex = 1; break;
                case "DateYear": cbeInterval.SelectedIndex = 2; break;
                case "DateRange": cbeInterval.SelectedIndex = 3; break;
            }
        }
        DXSubMenuItem GetDateIntervalMenu(GridViewMenu columnMenu) {
            foreach(DXMenuItem item in columnMenu.Items)
                if(item.Caption == GridLocalizer.Active.GetLocalizedString(GridStringId.MenuColumnGroupIntervalMenu))
                    return item as DXSubMenuItem;
            return null;
        }
        private void gridView1_PopupMenuShowing(object sender, PopupMenuShowingEventArgs e) {
            if(e.MenuType != GridMenuType.Column) return;
            DXSubMenuItem menu = GetDateIntervalMenu(e.Menu);
            if(menu == null) return;
            for(int i = menu.Items.Count - 1; i >= 0; i--)
                if(menu.Items[i].Caption == GridLocalizer.Active.GetLocalizedString(GridStringId.MenuColumnGroupIntervalNone) ||
                    menu.Items[i].Caption == GridLocalizer.Active.GetLocalizedString(GridStringId.MenuColumnGroupIntervalDay))
                    menu.Items.RemoveAt(i);
        }
        #region ReportGeneration
        public override bool AllowGenerateReport { get { return false; } }
        #endregion
    }
}
