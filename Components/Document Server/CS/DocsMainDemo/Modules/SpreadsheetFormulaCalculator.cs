using System;
using System.IO;
using System.Windows.Forms;
using DevExpress.Spreadsheet;
using DevExpress.XtraEditors;
using DevExpress.DXperience.Demos;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;

namespace DevExpress.Docs.Demos {
    public partial class SpreadsheetFormulaCalculatorModule : TutorialControlBase {
        #region Fields
        GridData data = new GridData();
        bool formulaSetting;
        #endregion

        public SpreadsheetFormulaCalculatorModule() {
            InitializeComponent();
            this.data.CreateGridDataSource(gridView1, this.repositoryItemTextEdit);
            InitializeGridView();
            grid.DataSource = data;
        }

        void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e) {
            Cell cell = GetSelectedCell();
            if(formulaSetting) {
                formulaSetting = false;
                formulaEdit.Text = cell.Formula;
                return;
            }
            this.data.SetCellValue(cell, e.Value);
        }
        void gridView1_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e) {
            string value = (string)e.Value;
            if(!string.IsNullOrEmpty(value) && value[0] == '=') {
                SetFormula(value);
                formulaSetting = true;
                return;
            }
            if(e.IsGetData) {
                Cell cell = this.data.GetCell((int)e.Row, e.Column.VisibleIndex);
                e.Value = cell.Value.IsEmpty ? null : cell.DisplayText;
            }
            else
                this.data.SetCellValue((int)e.Row, e.Column.VisibleIndex, e.Value);
        }
        void gridView1_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e) {
            int rowIndex = gridView1.GetVisibleIndex(e.RowHandle);
            if(rowIndex >= 0) {
                rowIndex++;
                e.Info.DisplayText = rowIndex.ToString();
            }
            e.Info.ImageIndex = -1;
        }
        void gridView1_FocusedColumnChanged(object sender, FocusedColumnChangedEventArgs e) {
            ShowFormula();
        }
        void gridView1_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e) {
            ShowFormula();
        }
        void formulaEdit_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e) {
            if (e.KeyValue != 13)
                return;
            SetFormula(formulaEdit.Text);
            gridView1.RefreshData();
        }
        void repositoryItemTextEdit_Enter(object sender, EventArgs e) {
            Cell cell = GetSelectedCell();
            formulaEdit.Text = cell.Formula;
            if (!string.IsNullOrEmpty(cell.Formula))
                ((TextEdit)sender).Text = cell.Formula;
        }
        void repositoryItemTextEdit_Leave(object sender, EventArgs e) {
            Cell cell = GetSelectedCell();
            if(cell.Formula.Length > 0 && cell.Formula[0] == '=')
                return;
            BeginInvoke(new MethodInvoker(gridView1.RefreshData));
        }

        Cell GetSelectedCell() {
            int selectedRow = gridView1.GetVisibleIndex(gridView1.FocusedRowHandle);
            int selectedColumn = gridView1.FocusedColumn.VisibleIndex;
            if(selectedRow < 0 || selectedColumn < 0)
                return null;

            return this.data.GetCell(selectedRow, selectedColumn);
        }
        void SetFormula(string formula) {
            Cell cell = GetSelectedCell();
            if(!string.IsNullOrEmpty(formula) && formula[0] == '=')
                cell.Formula = formula;
            else
                data.SetCellValue(cell, formula);
        }
        void ShowFormula() {
            Cell cell = GetSelectedCell();
            if(cell != null)
                formulaEdit.Text = cell.Formula;
        }

        void saveButton_Click(object sender, EventArgs e) {
            string fileName = SpreadsheetTutorialControl.GetSaveFileName("Excel Workbook(*.xlsx)|*.xlsx|Excel 97-2003 Workbook(*.xls)|*.xls|CSV (Comma delimited)(*.csv)|*.csv|PDF(*.pdf)|*.pdf", "Formula_Calculator");

            if(!string.IsNullOrEmpty(fileName)) {
                string ext = Path.GetExtension(fileName);
                if(ext == ".xlsx")
                    this.data.Book.SaveDocument(fileName, DocumentFormat.OpenXml);
                else if(ext == ".xls")
                    this.data.Book.SaveDocument(fileName, DocumentFormat.Xls);
                else if(ext == ".csv")
                    this.data.Book.SaveDocument(fileName, DocumentFormat.Csv);
                else if(ext == ".pdf")
                    this.data.Book.ExportToPdf(fileName);
            }
            SpreadsheetTutorialControl.ShowFile(fileName, this);
        }
        void InitializeGridView() {
            this.gridView1.Columns[1].Width = 230;
        }

        private void gridView1_CustomDrawCell(object sender, RowCellCustomDrawEventArgs e) {
            GridView gridView = sender as GridView;
            if(!gridView.IsEditing && !gridView.GridControl.Focused && gridView.FocusedRowHandle == e.RowHandle && gridView.FocusedColumn.Equals(e.Column)) 
                e.Appearance.BackColor = gridView.PaintAppearance.HideSelectionRow.BackColor;
        }
    }
}
