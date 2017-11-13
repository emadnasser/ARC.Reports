using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.DXperience.Demos;

namespace DevExpress.XtraGrid.Demos {
    /// <summary>
    /// Summary description for CellSelection.
    /// </summary>
    public partial class CellSelection : TutorialControl {
        public CellSelection() {
            //
            // Required for Windows Form Designer support
            //
            CreateWaitDialog();
            InitializeComponent();
            TutorialInfo.WhatsThisCodeFile = "CS\\GridMainDemo\\Modules\\CellSelection.cs";
            TutorialInfo.WhatsThisXMLFile = "DevExpress.XtraGrid.Demos.CodeInfo.CellSelection.xml";
            InitNWindData();
            InitEditors();
            InitSelection();
            //
            // TODO: Add any constructor code after InitializeComponent call
            //
        }
        bool updateValues = false;
        #region Init
        private GridView CurrentGridView { get { return gridView1; } }
        protected override void InitMDBData(string connectionString) {
            DataSet dataSet = new DataSet();
            System.Data.OleDb.OleDbDataAdapter oleDBAdapter = new System.Data.OleDb.OleDbDataAdapter("SELECT * FROM Customers", connectionString);

            SetWaitDialogCaption(Properties.Resources.LoadingCustomers);
            oleDBAdapter.Fill(dataSet, "Customers");
            gridControl1.DataSource = dataSet.Tables["Customers"];
        }
        protected override void InitXMLData(string dataFileName) {
            DataSet dataSet = new DataSet();
            SetWaitDialogCaption(Properties.Resources.LoadingTables);
            dataSet.ReadXml(dataFileName);
            gridControl1.DataSource = dataSet.Tables["Customers"];
        }
        void InitEditors() {
            foreach(GridMultiSelectMode mode in Enum.GetValues(typeof(GridMultiSelectMode)))
                icbSelectMode.Properties.Items.Add(new ImageComboBoxItem(EnumTitlesKeeper<GridMultiSelectMode>.GetTitle(mode), mode, -1));
            updateValues = true;
            icbSelectMode.EditValue = gridView1.OptionsSelection.MultiSelectMode;
            ceMultiSelect.Checked = gridView1.OptionsSelection.MultiSelect;
            updateValues = false;
        }
        void InitSelection() {
            gridControl1.ForceInitialize();
            gridView1.SelectCellAnchorRange(3, colCompanyName, 12, colPostalCode);
        }
        #endregion
        //<ceMultiSelect>
        private void ceMultiSelect_CheckedChanged(object sender, System.EventArgs e) {
            if(updateValues) return;
            gridView1.OptionsSelection.MultiSelect = ceMultiSelect.Checked;
            SetButtonEnabled();
        }
        //</ceMultiSelect>
        //<icbSelectMode>
        private void icbSelectMode_SelectedIndexChanged(object sender, System.EventArgs e) {
            if(updateValues) return;
            gridView1.OptionsSelection.MultiSelectMode = (GridMultiSelectMode)icbSelectMode.EditValue;
            sbRecords.Text = gridView1.OptionsSelection.MultiSelectMode == 
                GridMultiSelectMode.CellSelect ? Properties.Resources.ShowSelectedValues : Properties.Resources.ShowSelectedRecords;
        }
        //</icbSelectMode>
        void SetButtonEnabled() {
            sbRecords.Enabled = gridView1.SelectedRowsCount > 0 && ceMultiSelect.Checked;
            icbSelectMode.Enabled = ceMultiSelect.Checked;
        }
        //<icbTranslucentColors>
        private void icbTranslucentColors_CheckedChanged(object sender, System.EventArgs e) {
            if(icbTranslucentColors.Checked) {
                gridView1.Appearance.SelectedRow.BackColor = Color.FromArgb(30, 0, 0, 240);
                gridView1.Appearance.FocusedRow.BackColor = Color.FromArgb(60, 0, 0, 240);
            }
            else {
                gridView1.Appearance.SelectedRow.Reset();
                gridView1.Appearance.FocusedRow.Reset();
            }
        }
        //</icbTranslucentColors>
        //<sbRecords>
        private void sbRecords_Click(object sender, System.EventArgs e) {
            DemosHelper.ShowDescriptionForm(Control.MousePosition, GetSelectedRows(gridView1), 
                gridView1.OptionsSelection.MultiSelectMode == 
                GridMultiSelectMode.CellSelect ? Properties.Resources.SelectedCells : Properties.Resources.SelectedRows);
        }
        //</sbRecords>
        private void gridView1_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e) {
            SetButtonEnabled();
        }
        //<sbRecords>
        string GetSelectedRows(GridView view) {
            string ret = "";
            int rowIndex = -1;
            if(view.OptionsSelection.MultiSelectMode != GridMultiSelectMode.CellSelect) {
                foreach(int i in gridView1.GetSelectedRows()) {
                    DataRow row = gridView1.GetDataRow(i);
                    if(ret != "") ret += "\r\n";
                    ret += string.Format("{2}: {0} (#{1})", row["CompanyName"], i, Properties.Resources.CompanyName);
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
    }
}
