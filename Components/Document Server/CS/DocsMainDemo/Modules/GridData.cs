using System;
using System.Collections;
using System.Globalization;
using DevExpress.Spreadsheet;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;

namespace DevExpress.Docs.Demos {
    public class GridData : IList {
        int fCount = 22;
        const int ColumnCount = 10;
        IWorkbook book;
        public GridData() {
            book = new Workbook();
            book.Options.Culture = CultureInfo.InvariantCulture;
            book.LoadDocument(DemoUtils.GetRelativePath("FormulaCalculator_template.xlsx"));
        }

        internal void CreateGridDataSource(GridView view, DevExpress.XtraEditors.Repository.RepositoryItem editor) {
            view.BeginDataUpdate();
            view.Columns.Clear();
            try {
                for(int i = 0; i < GridData.ColumnCount; i++) {
                    GridColumn col = new GridColumn();
                    view.Columns.Add(col);
                    col.Caption = col.FieldName = GetColumnCaption(i);
                    col.UnboundType = DevExpress.Data.UnboundColumnType.Object;
                    col.Visible = true;
                    col.ColumnEdit = editor;
                }
            }
            finally {
                view.EndDataUpdate();
            }
        }
        string GetColumnCaption(int col) {
            return book.Worksheets[0].Columns[col].Heading;
        }
        public void SetCellValue(int row, int col, object val) {
            Cell cell = book.Worksheets[0].Cells[row, col];
            SetCellValue(cell, val);
        }
        public void SetCellValue(Cell cell, object val) {
            try {
                decimal value = decimal.Parse((string)val);
                if((string)val == ((int)value).ToString())
                    cell.Value = (int)(value);
                else cell.Value = (double)(value);
            }
            catch {
                cell.Value = (string)val;
            }
        }
        public Cell GetCell(int row, int col) {
            return book.Worksheets[0].Cells[row, col];
        }

        public IWorkbook Book { get { return book; } }
        public int Count {
            get { return fCount; }
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
}
