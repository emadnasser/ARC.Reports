using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using DevExpress.XtraGrid.Views.Base;
//<icbNewItemRow>
using DevExpress.XtraGrid.Views.Grid;
//</icbNewItemRow>
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraBars.Navigation;

namespace DevExpress.XtraGrid.Demos {
    /// <summary>
    /// Summary description for TableView.
    /// </summary>
    public partial class TableView : TutorialControl {
        public TableView() {
            //
            // Required for Windows Form Designer support
            //
            CreateWaitDialog();
            InitializeComponent();
            TutorialInfo.WhatsThisCodeFile = "CS\\GridMainDemo\\Modules\\TableView.cs";
            TutorialInfo.WhatsThisXMLFile = "DevExpress.XtraGrid.Demos.CodeInfo.TableView.xml";
            //
            // TODO: Add any constructor code after InitializeComponent call
            //
        }
        bool updateLayout = false;
        bool firstSearch = true;
        //<sbStart>
        string[] searshString = new string[] { "c", "a", "{BS}", "h", "a", "n", "{BS}", "{BS}", "e", "f", " ", "a", "n", "t", "o", "n", "'", "s", " ", "c", 
            "^{DOWN}", "^{DOWN}", "^{DOWN}", "^{DOWN}", "^{DOWN}", "^{DOWN}", "^{HOME}", "{RIGHT}" };
        int searchKeyIndex = 0;
        //</sbStart>
        #region Init
        public override BaseView ExportView { get { return gridView1; } }
        private void TableView_Load(object sender, System.EventArgs e) {
            InitNWindData();
            InitEditing();
            gridView1_Layout(gridView1, EventArgs.Empty);
        }

        public override bool ShowViewOptions { get { return true; } }

        string tblGrid = "[Order Details]";
        string tblLookUp = "Products";
        protected override void InitMDBData(string connectionString) {
            DataSet ds = new DataSet();
            System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter = new System.Data.OleDb.OleDbDataAdapter("SELECT * FROM " + tblGrid, connectionString);
            SetWaitDialogCaption(Properties.Resources.LoadingOrderDetails);
            oleDbDataAdapter.Fill(ds, tblGrid);
            oleDbDataAdapter = new System.Data.OleDb.OleDbDataAdapter("SELECT * FROM " + tblLookUp, connectionString);
            SetWaitDialogCaption(Properties.Resources.LoadingProducts);
            oleDbDataAdapter.Fill(ds, tblLookUp);

            DataViewManager dvManager = new DataViewManager(ds);
            DataView dv = dvManager.CreateDataView(ds.Tables[tblGrid]);

            gridControl1.DataSource = dv;
            repositoryItemLookUpEdit1.DataSource = ds.Tables[tblLookUp];
        }
        protected override void InitXMLData(string dataFileName) {
            DataSet ds = new DataSet();
            SetWaitDialogCaption(Properties.Resources.LoadingTables);
            ds.ReadXml(dataFileName);
            
            gridControl1.DataSource = ds.Tables[tblGrid];
            repositoryItemLookUpEdit1.DataSource = ds.Tables[tblLookUp];
        }

        private void InitEditing() {
            icbNewItemRow.Properties.Items.Add(new ImageComboBoxItem(Properties.Resources.None, NewItemRowPosition.None, -1));
            icbNewItemRow.Properties.Items.Add(new ImageComboBoxItem(Properties.Resources.Top, NewItemRowPosition.Top, -1));
            icbNewItemRow.Properties.Items.Add(new ImageComboBoxItem(Properties.Resources.Bottom, NewItemRowPosition.Bottom, -1));
            icbButtons.Properties.Items.Add(new ImageComboBoxItem(Properties.Resources.DefaultString, ShowButtonModeEnum.Default, -1));
            icbButtons.Properties.Items.Add(new ImageComboBoxItem(Properties.Resources.ShowAlways, ShowButtonModeEnum.ShowAlways, -1));
            icbButtons.Properties.Items.Add(new ImageComboBoxItem(Properties.Resources.ShowForFocusedCell, ShowButtonModeEnum.ShowForFocusedCell, -1));
            icbButtons.Properties.Items.Add(new ImageComboBoxItem(Properties.Resources.ShowForFocusedRow, ShowButtonModeEnum.ShowForFocusedRow, -1));
            icbButtons.Properties.Items.Add(new ImageComboBoxItem(Properties.Resources.ShowOnlyInEditor, ShowButtonModeEnum.ShowOnlyInEditor, -1));
            icbButtons.EditValue = gridView1.OptionsView.ShowButtonMode;
            icbSelectMode.Properties.Items.Add(new ImageComboBoxItem(Properties.Resources.RowSelect, GridMultiSelectMode.RowSelect, -1));
            icbSelectMode.Properties.Items.Add(new ImageComboBoxItem(Properties.Resources.CellSelect, GridMultiSelectMode.CellSelect, -1));
            icbSelectMode.Properties.Items.Add(new ImageComboBoxItem(Properties.Resources.CheckBoxRowSelect, GridMultiSelectMode.CheckBoxRowSelect, -1));
            icbSelectMode.EditValue = gridView1.OptionsSelection.MultiSelectMode;
            chEdit.Checked = gridView1.OptionsBehavior.Editable;
        }
        #endregion
        #region Editing

        private void gridView1_Layout(object sender, System.EventArgs e) {
            updateLayout = true;
            icbNewItemRow.EditValue = gridView1.OptionsView.NewItemRowPosition;
            ceMultiSelect.Checked = gridView1.OptionsSelection.MultiSelect;
            SetPosition();
            updateLayout = false;
        }
        private void navigationPane1_SelectedPageChanged(object sender, XtraBars.Navigation.SelectedPageChangedEventArgs e) {
            if(e.Page == navigationPage2) {
                gridView1.OptionsBehavior.AllowIncrementalSearch = true;
                if(firstSearch) StartSearch();
                firstSearch = false;
            }
            else {
                gridView1.OptionsBehavior.AllowIncrementalSearch = false;
                if(!firstSearch) StopSearch();
            }
            gridControl1.UseEmbeddedNavigator = e.Page == navigationPage3;
            ceMultiSelect.Checked = e.Page == navigationPage4;
        }
        #endregion
        #region NewItemRow
        //<icbNewItemRow>
        private void icbNewItemRow_SelectedIndexChanged(object sender, System.EventArgs e) {
            //<skip>
            if(updateLayout) return;
            //</skip>
            gridView1.OptionsView.NewItemRowPosition = (NewItemRowPosition)icbNewItemRow.EditValue;
            SetPosition();
            //<skip>
            GridRibbonMenuManager.RefreshOptionsMenu(gridView1);
            //</skip>
        }
        void SetPosition() {
            if(gridView1.OptionsView.NewItemRowPosition == NewItemRowPosition.Bottom && gridView1.SortInfo.GroupCount == 0) {
                gridView1.FocusedRowHandle = gridView1.RowCount - 2;
                gridView1.MakeRowVisible(gridView1.FocusedRowHandle, false);
            }
        }
        //</icbNewItemRow>
        private void gridView1_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e) {
            DataRow row = gridView1.GetDataRow(e.RowHandle);
            row["Quantity"] = 1;
            row["UnitPrice"] = 0;
            row["Discount"] = 0;
            row["OrderID"] = 99999;
        }
        #endregion
        #region Incremental Search
        //<sbStart>
        void StartSearch() {
            sbStart.Enabled = false;
            searchKeyIndex = 0;
            lbEvent.Text = Properties.Resources.TableView_AutoSearch;
            gridView1.FocusedColumn = gridColumn2;
            timer1.Start();
        }

        void StopSearch() {
            sbStart.Enabled = true;
            timer1.Stop();
            lbEvent.Text = Properties.Resources.TableView_IncrementalSearch;
        }
        
        private void timer1_Tick(object sender, System.EventArgs e) {
            if(Form.ActiveForm == null || !this.Visible) return;
            gridControl1.Focus();
            if(searchKeyIndex > searshString.Length - 1)
                searchKeyIndex = 0;
            else {
                SendKeys.Send(searshString[searchKeyIndex]);
                searchKeyIndex++;
            }
        }

        private void gridControl1_ProcessGridKey(object sender, System.Windows.Forms.KeyEventArgs e) {
            if(e.KeyCode == Keys.Escape) StopSearch();
        }

        private void gridControl1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e) {
            StopSearch();
        }

        private void sbStart_Click(object sender, System.EventArgs e) {
            StartSearch();
        }
        //</sbStart>
        #endregion
        #region Editing And Navigation
        //<icbButtons>
        private void icbButtons_SelectedIndexChanged(object sender, System.EventArgs e) {
            gridView1.OptionsView.ShowButtonMode = (ShowButtonModeEnum)icbButtons.EditValue;
        }
        //</icbButtons>
        //<chEdit>
        private void chEdit_CheckedChanged(object sender, System.EventArgs e) {
            gridView1.OptionsBehavior.Editable = chEdit.Checked;
        }
        //</chEdit>
        private bool EditRecord() {
            DataRow row = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if(row == null) return false;
            PopupForm frm = new PopupForm();
            frm.InitData(this.FindForm(), gridControl1, gridView1, row);
            bool ret = frm.ShowDialog() == DialogResult.OK;
            if(ret) {
                row.ItemArray = frm.Row.ItemArray;
                row.EndEdit();
            }
            return ret;
        }

        private void gridControl1_EmbeddedNavigator_ButtonClick(object sender, DevExpress.XtraEditors.NavigatorButtonClickEventArgs e) {
            if(e.Button.ButtonType == DevExpress.XtraEditors.NavigatorButtonType.Edit) {
                EditRecord();
                e.Handled = true;
            }
            if(e.Button.ButtonType == DevExpress.XtraEditors.NavigatorButtonType.Append) {
                gridView1.AddNewRow();
                if(EditRecord())
                    gridView1.UpdateCurrentRow();
                else gridView1.CancelUpdateCurrentRow();
                e.Handled = true;
            }
        }
        #endregion
        #region MultiSelect
        void UpdateSelection() {
            bool updateCells = gridView1.OptionsSelection.MultiSelectMode == GridMultiSelectMode.CellSelect;
            if(ceMultiSelect.Checked) {
                if(!updateCells) {
                    gridView1.SelectRange(4, 20);
                    sbRecords.Text = Properties.Resources.ShowSelectedRecords;
                }
                else {
                    gridView1.ClearSelection();
                    gridView1.SelectCells(5, gridView1.Columns["ProductID"], 15, gridView1.Columns["Quantity"]);
                    sbRecords.Text = Properties.Resources.ShowSelectedValues;
                }
            }
        }
        //<ceMultiSelect>
        private void ceMultiSelect_CheckedChanged(object sender, System.EventArgs e) {
            //<skip>
            SetButtonEnabled();
            if(updateLayout) return;
            //</skip>
            gridView1.OptionsSelection.MultiSelect = ceMultiSelect.Checked;
            UpdateSelection();
            //<skip>
            GridRibbonMenuManager.RefreshOptionsMenu(gridView1);
            //</skip>
        }
        //</ceMultiSelect>
        void SetButtonEnabled() {
            sbRecords.Enabled = gridView1.SelectedRowsCount > 0 && ceMultiSelect.Checked;
            icbSelectMode.Enabled = ceMultiSelect.Checked;
        }

        private void gridView1_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e) {
            SetButtonEnabled();
        }
        //<sbRecords>
        private void sbRecords_Click(object sender, System.EventArgs e) {
            DemosHelper.ShowDescriptionForm(Control.MousePosition, GetSelectedRows(gridView1), gridView1.OptionsSelection.MultiSelectMode == 
                GridMultiSelectMode.CellSelect ? Properties.Resources.SelectedCells : Properties.Resources.SelectedRows);
        }
        
        string GetSelectedRows(GridView view) {
            string ret = "";
            int rowIndex = -1;
            if(view.OptionsSelection.MultiSelectMode != GridMultiSelectMode.CellSelect) {
                foreach(int i in gridView1.GetSelectedRows()) {
                    DataRow row = gridView1.GetDataRow(i);
                    if(ret != "") ret += "\r\n";
                    ret += string.Format("{2}: #{0} {1}", row["OrderID"], gridView1.GetRowCellDisplayText(i, gridColumn2), Properties.Resources.Order);
                }
            }
            else {
                foreach(GridCell cell in view.GetSelectedCells()) {
                    if(rowIndex != cell.RowHandle) {
                        if(ret != "") ret += "\r\n";
                        ret += string.Format("{1}: #{0}", cell.RowHandle, Properties.Resources.Row);
                    }
                    ret += "\r\n    " + view.GetRowCellDisplayText(cell.RowHandle, cell.Column);
                    rowIndex = cell.RowHandle;
                }
            }
            return ret;
        }
        //</sbRecords>
        //<icbSelectMode>
        private void icbSelectMode_SelectedIndexChanged(object sender, System.EventArgs e) {
            gridView1.OptionsSelection.MultiSelectMode = (GridMultiSelectMode)icbSelectMode.EditValue;
            UpdateSelection();
        }
        //</icbSelectMode>
        #endregion
    }

}
