using DevExpress.Data.ChartDataSources;
using DevExpress.XtraPivotGrid;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;

namespace PivotGridOlapBrowser {
    static class PivotDataExtractor {
        public const string ColumnNameIsSelected = "IsSelected";
        public const string ColumnNameIsRowTotal = "IsRowTotal";
        public const string ColumnNameIsColumnTotal = "IsColumnTotal";
        public const string ColumnNameIsRowGrandTotal = "IsRowGrandTotal";
        public const string ColumnNameIsColumnGrandTotal = "IsColumnGrandTotal";

        public static DataTable GetDataTable(PivotGridControl pivot) {
            DataTable dataTable = new DataTable();
            IPivotGrid pivotGrid = (IPivotGrid) pivot;
            bool selectionOnly = pivotGrid.SelectionOnly;
            pivotGrid.SelectionOnly = false;
            try {
                PropertyDescriptorCollection properties = ((ITypedList)pivot).GetItemProperties(null);
                FillDataTableColumns(pivot, properties, dataTable, false);
                FillDataTableRows(pivot, properties, dataTable, false);
            } finally {
                pivotGrid.SelectionOnly = selectionOnly;
            }
            return dataTable;
        }
        static void FillDataTableColumns(PivotGridControl pivot, PropertyDescriptorCollection properties, 
                            DataTable dataTable, bool isDateTimeArguments) {
            foreach(PropertyDescriptor d in properties) {
                if(isDateTimeArguments && d.Name == "Arguments") {
                    dataTable.Columns.Add(d.Name, typeof(DateTime));
                } else {
                    dataTable.Columns.Add(d.Name, d.PropertyType);
                }
            }
            dataTable.Columns.Add(ColumnNameIsColumnTotal, typeof(bool));
            dataTable.Columns.Add(ColumnNameIsRowTotal, typeof(bool));
            dataTable.Columns.Add(ColumnNameIsColumnGrandTotal, typeof(bool));
            dataTable.Columns.Add(ColumnNameIsRowGrandTotal, typeof(bool));
            if(GetHasSelection(pivot)) {
                dataTable.Columns.Add(ColumnNameIsSelected, typeof(bool));
            }
        }
        static void FillDataTableRows(PivotGridControl pivot, PropertyDescriptorCollection properties,
                            DataTable dataTable, bool isDateTimeArguments) {
            dataTable.Rows.Clear();
            IList list = (IList)pivot;
            for(int i = 0; i < list.Count; i++) {
                DataRow row = dataTable.Rows.Add(new object[] { });
                foreach(PropertyDescriptor d in properties) {
                    object value = d.GetValue(list[i]);
                    if(isDateTimeArguments && d.Name == "Arguments") {
                        DateTime dt;
                        try {
                            dt = Convert.ToDateTime(value);
                        } catch {
                            dt = DateTime.MinValue;
                        }
                        if(dt != DateTime.MinValue)
                            row[d.Name] = dt;
                    } else
                        row[d.Name] = value;
                }
                PivotChartDataSourceRowItem chartDataSourceRow = (PivotChartDataSourceRowItem)list[i];
                PivotCellEventArgs cellInfo = pivot.Cells.GetCellInfo(chartDataSourceRow.CellX, chartDataSourceRow.CellY);
                PivotGridValueType columnType = cellInfo.ColumnValueType,
                    rowType = cellInfo.RowValueType;
                row[ColumnNameIsColumnTotal] = object.Equals(columnType, PivotGridValueType.Total) || object.Equals(columnType, PivotGridValueType.CustomTotal);
                row[ColumnNameIsRowTotal] = object.Equals(rowType, PivotGridValueType.Total) || object.Equals(rowType, PivotGridValueType.CustomTotal);
                row[ColumnNameIsColumnGrandTotal] = object.Equals(columnType, PivotGridValueType.GrandTotal);
                row[ColumnNameIsRowGrandTotal] = object.Equals(rowType, PivotGridValueType.GrandTotal);
                if(GetHasSelection(pivot))
                    row[ColumnNameIsSelected] = pivot.Cells.MultiSelection.SelectedCells.Contains(new System.Drawing.Point(chartDataSourceRow.CellX, chartDataSourceRow.CellY));
            }
        }
        static bool GetHasSelection(PivotGridControl pivot) {
            return pivot.Cells.MultiSelection.SelectedCells.Count > 1;
        }
    }
}
