using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace DevExpress.XtraGrid.Demos.Tutorials {
    /// <summary>
    /// Summary description for GridVirtualDataDynamic.
    /// </summary>
    public partial class GridVirtualDataDynamic : TutorialControl {
        public GridVirtualDataDynamic() {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();

            //
            // TODO: Add any constructor code after InitializeComponent call
            //
        }

        private void GridVirtualDataDynamic_Load(object sender, System.EventArgs e) {
            InitData();
            vList.ListChanged += new ListChangedEventHandler(ListChanged);
            ShowVirtualListDimension();
        }

        //<gridControl1>
        private VirtualListDynamic vList = new VirtualListDynamic();
        //</gridControl1>
        private void InitData() {
            //<gridControl1>
            gridControl1.DataSource = vList;
            //</gridControl1>
            gridControl1.MainView.PopulateColumns();
        }

        private void ListChanged(object sender, ListChangedEventArgs e) {
            ShowVirtualListDimension();
        }

        private void ShowVirtualListDimension() {
            lbListDimension.Text = string.Format("RowCount = {0}; ColumnCount = {1}", vList.RecordCount, vList.ColumnCount);
        }

        //<gridControl1>
        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e) {
            if(checkEditAddRows.Checked) {
                gridView1.BeginUpdate();
                int index = e.FocusedRowHandle;
                if(index == vList.RecordCount - 1) vList.AddNew();
                gridView1.EndUpdate();
            }
        }

        private void gridView1_FocusedColumnChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedColumnChangedEventArgs e) {
            if(checkEditAddColumns.Checked) {
                if(e.FocusedColumn != null && e.FocusedColumn.VisibleIndex == gridView1.VisibleColumns.Count - 1) {
                    gridView1.BeginUpdate();
                    int index = gridView1.FocusedRowHandle;
                    vList.AddColumn();
                    gridView1.Columns.AddField(vList.GetColumnName(vList.ColumnCount - 1)).VisibleIndex = gridView1.VisibleColumns.Count;
                    gridView1.FocusedRowHandle = index;
                    gridView1.EndUpdate();
                }
            }
        }
        //</gridControl1>

        private void gridView1_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e) {
            if(e.Info.IsRowIndicator && e.RowHandle == vList.RecordCount - 1 && checkEditAddRows.Checked) e.Info.ImageIndex = 2;
        }

        private void checkEditAddRows_CheckedChanged(object sender, System.EventArgs e) {
            gridView1.InvalidateRowIndicator(vList.RecordCount - 1);
        }
        public override bool SetNewWhatsThisPadding { get { return true; } }
    }
}
