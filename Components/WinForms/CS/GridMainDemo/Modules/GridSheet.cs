using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;
using DevExpress.Utils;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;

namespace DevExpress.XtraGrid.Demos {
    public partial class GridSheet : TutorialControl {

        //<gridControl1>
        SpreadData spread = new SpreadData();
        //</gridControl1>

        public GridSheet() {
            // This call is required by the Windows Form Designer.
            InitializeComponent();
            TutorialInfo.WhatsThisCodeFile = "CS\\GridMainDemo\\Modules\\GridSheet.cs";
            TutorialInfo.WhatsThisXMLFile = "DevExpress.XtraGrid.Demos.CodeInfo.GridSheet.xml";
            CreateUserAppearances();
            //<gridControl1>
            this.spread.CreateGridDataSource(gridView1, this.repositoryItemSpinEdit, this.appHeader);
            gridControl1.DataSource = this.spread;
            //</gridControl1>
            OnStyleChanged();
        }

        AppearanceDefault appStyle1, appStyle2, appHeader;

        protected override void OnSwitchStyle() {
            //gridView1.RowHeight = GridHelper.GetGridViewInfo(gridView1).MinRowHeight + 2;
        }

        void CreateUserAppearances() {
            appStyle1 = new AppearanceDefault(SystemColors.ActiveCaptionText, SystemColors.ActiveCaption, DevExpress.Utils.HorzAlignment.Center, DevExpress.Utils.VertAlignment.Default, AppearanceObject.DefaultFont);
            appStyle2 = new AppearanceDefault(SystemColors.Highlight, SystemColors.Control, DevExpress.Utils.HorzAlignment.Center, DevExpress.Utils.VertAlignment.Default, new Font(AppearanceObject.DefaultFont, FontStyle.Bold));
            appHeader = new AppearanceDefault(SystemColors.WindowText, SystemColors.Control, DevExpress.Utils.HorzAlignment.Center, DevExpress.Utils.VertAlignment.Default, AppearanceObject.DefaultFont);
            appStyle1.BorderColor = appStyle1.BackColor;
            appStyle2.BorderColor = appStyle2.BackColor;
            appHeader.BorderColor = appHeader.BackColor;
        }

        private void gridView1_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e) {
            int rowIndex = e.RowHandle;
            if (rowIndex >= 0) {
                rowIndex++;
                e.Info.DisplayText = rowIndex.ToString();
            }
            UpdateAppearance(e.RowHandle == this.gridView1.FocusedRowHandle, e.Appearance);
            e.Info.ImageIndex = -1;
        }
        bool IsXPStyle { get { return true; } }
        private void gridView1_CustomDrawColumnHeader(object sender, DevExpress.XtraGrid.Views.Grid.ColumnHeaderCustomDrawEventArgs e) {
            UpdateAppearance(e.Column == this.gridView1.FocusedColumn, e.Appearance);
            }
        void UpdateAppearance(bool focused, AppearanceObject appObject) {
            if(focused) {
                AppearanceHelper.Apply(appObject, IsXPStyle ? appStyle2 : appStyle1);
            } else AppearanceHelper.Apply(appObject, appHeader);
        }
        private void gridView1_FocusedColumnChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedColumnChangedEventArgs e) {
            this.gridView1.InvalidateColumnHeader(e.PrevFocusedColumn);
            this.gridView1.InvalidateColumnHeader(e.FocusedColumn);
        }

        //<gridControl1>
        /*
         ~Calculate values for the unbound Total column:
         */
        private void gridView1_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e) {
            if (e.IsGetData)
                e.Value = this.spread.GetCell(e.ListSourceRowIndex, e.Column.ColumnHandle);
            else
                this.spread.SetCell(e.ListSourceRowIndex, e.Column.ColumnHandle, e.Value);
        }
        /*
         ~Update summaries when cell values change:
         */
        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e) {
            this.gridView1.UpdateTotalSummary();
        }

        /*
         ~Calculate summaries via the Spread object and provide summary values to the grid immediately once a summary calculation has been started:
         */
        private void gridView1_CustomSummaryCalculate(object sender, DevExpress.Data.CustomSummaryEventArgs e) {
            if (e.SummaryProcess == DevExpress.Data.CustomSummaryProcess.Start) {
                e.TotalValueReady = true;
                GridSummaryItem item = (GridSummaryItem)e.Item;
                e.TotalValue = this.spread.GetSummary(((GridColumn)item.Tag).ColumnHandle);
            }
        }
        //</gridControl1>

        private void gridView1_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e) {
            if (e.Column.AbsoluteIndex == this.gridView1.Columns.Count - 1) {
                PropertyInfo propertyInfo = typeof(DevExpress.XtraGrid.Views.Base.BaseView).GetProperty("Painter", BindingFlags.Instance | BindingFlags.NonPublic);
                if (propertyInfo != null) {
                    DevExpress.XtraGrid.Views.Grid.Drawing.GridPainter painter =
                        propertyInfo.GetValue(this.gridView1, null) as DevExpress.XtraGrid.Views.Grid.Drawing.GridPainter;
                    if (painter != null) {
                        DevExpress.XtraGrid.Drawing.GridFooterCellInfoArgs ci = new DevExpress.XtraGrid.Drawing.GridFooterCellInfoArgs();
                        if (e.CellValue != null)
                            ci.DisplayText = e.CellValue.ToString();
                        else ci.DisplayText = "0";
                        ci.Bounds = e.Bounds;
                        DevExpress.Utils.Drawing.GraphicsCache cache = new DevExpress.Utils.Drawing.GraphicsCache(e.Graphics);
                        ci.Cache = cache;
                        ci.Appearance.Assign(gridView1.PaintAppearance.FooterPanel);
                        painter.ElementsPainter.FooterCell.CalcObjectBounds(ci);
                        string caption = ci.DisplayText;
                        ci.DisplayText = "";
                        Rectangle r = ci.Bounds;
                        r.Inflate(-2, 0);
                        painter.ElementsPainter.FooterPanel.DrawObject(ci);
                        painter.ElementsPainter.FooterCell.DrawObject(ci);
                        ci.Appearance.DrawString(cache, caption, r);
                        e.Handled = true;
                        cache.Dispose();
                    }
                }
            }
        }

        protected override void OnStyleChanged() {
            base.OnStyleChanged();
            appHeader.ForeColor = ColorHelper.GetHeaderForeColor(gridControl1.LookAndFeel);
        }
    }
    //<gridControl1>
    public class SpreadData : IList, ITypedList {
        Hashtable fData = new Hashtable();
        /*
         ~Row number
         */
        int fCount = 1000000;
        public const int ColumnCount = 257;
        public const int TotalColumn = ColumnCount - 1;
        public SpreadData() {
        }
        PropertyDescriptorCollection ITypedList.GetItemProperties(PropertyDescriptor[] listAccessor) {
            return null;
        }
        string ITypedList.GetListName(PropertyDescriptor[] listAccessor) {
            return "";
        }
        internal void CreateGridDataSource(GridView view, DevExpress.XtraEditors.Repository.RepositoryItem editor, AppearanceDefault totalAppearance) {
            view.BeginDataUpdate();
            view.Columns.Clear();
            try {
                for (int i = 0; i < SpreadData.ColumnCount; i++) {
                    GridColumn col = new GridColumn();
                    view.Columns.Add(col);
                    col.Caption = col.FieldName = GetColumnCaption(i);
                    col.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
                    col.Visible = true;
                    col.SummaryItem.Tag = col;
                    col.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Custom;
                    col.ColumnEdit = editor;
                    if (IsTotalColumn(i)) {
                        col.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Right;
                        col.AppearanceHeader.Assign(totalAppearance);
                        col.OptionsColumn.ReadOnly = true;
                        col.OptionsColumn.AllowEdit = false;
                        col.OptionsColumn.AllowMove = false;
                    }
                }
            }
            finally {
                view.EndDataUpdate();
            }
        }
        bool IsTotalColumn(int col) {
            return col == TotalColumn;
        }
        string GetColumnCaption(int col) {
            if (IsTotalColumn(col)) return Properties.Resources.Total;
            const char bchar = 'A';
            const char echar = 'Z';
            int max = (int)echar - (int)bchar + 1;
            int d = col / max;
            string res = string.Empty;
            if (d > 0)
                res += (char)((int)bchar + d - 1);
            res += (char)((int)bchar + col % max);
            return res;
        }


        public void UpdateRowSummary(int row) {
            decimal res = 0;
            for (int n = 0; n < ColumnCount - 1; n++) {
                res += GetCellDecimal(row, n);
            }
            SetCell(row, TotalColumn, res);
        }
        decimal GetCellDecimal(int row, int col) {
            object val = GetCell(row, col);
            if (val == null) return 0;
            return (decimal)val;
        }

        public decimal GetSummary(int col) {
            Hashtable hash = (Hashtable)this.fData[col];
            if (hash == null) return 0;
            decimal res = 0;
            foreach (object obj in hash.Values) {
                res += (decimal)obj;
            }
            return res;
        }
        public void SetCell(int row, int col, object val) {
            Hashtable hash = (Hashtable)this.fData[col];
            if (hash == null) {
                hash = new Hashtable();
                hash[row] = val;
                this.fData[col] = hash;
            }
            else
                hash[row] = val;
            if (col != TotalColumn) UpdateRowSummary(row);
        }
        public object GetCell(int row, int col) {
            Hashtable hash = (Hashtable)this.fData[col];
            if (hash == null) return null;
            return hash[row];
        }

        public int Count {
            get { return fCount; }
            set {
                fCount = value;
            }
        }
        public object this[int index] {
            get { return index; }
            set { }
        }

        public bool IsReadOnly { get { return false; } }
        public void RemoveAt(int index) { }
        public void Insert(int index, object value) { }
        public void Remove(object value) { }
        public bool Contains(object value) { return true; }
        public void Clear() { }
        public int IndexOf(object value) { return -1; }
        public int Add(object value) { return -1; }
        public bool IsFixedSize { get { return true; } }
        public bool IsSynchronized { get { return true; } }
        public void CopyTo(Array array, int index) { }
        public object SyncRoot { get { return this; } }
        public IEnumerator GetEnumerator() { return null; }
    }
    //</gridControl1>
}

