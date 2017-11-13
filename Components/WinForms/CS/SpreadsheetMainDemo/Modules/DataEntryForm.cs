﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.DXperience.Demos;
using DevExpress.Spreadsheet;
using DevExpress.Spreadsheet.Demos;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraSpreadsheet;

namespace DevExpress.XtraSpreadsheet.Demos {
    public partial class DataEntryFormModule : SpreadSheetTutorialControlBase {
        public DataEntryFormModule() {
            InitializeComponent();
            spreadsheetControl1.Options.Culture = CultureInfo.CurrentCulture;
            LoadInvoiceTemplate();
        }

        protected override void DoShow() {
            base.DoShow();
            spreadsheetControl1.Focus();
            Worksheet invoice = spreadsheetControl1.Document.Worksheets["Invoice"];
            spreadsheetControl1.SelectedCell = invoice["B10"];
        }

        void LoadInvoiceTemplate() {
            spreadsheetControl1.LoadDocument(DemoUtils.GetRelativePath("DevAVInvoicing.xltx"));
            InitializeDateFields();
            BindCustomEditors();
        }

        void InitializeDateFields() {
            IWorkbook workbook = spreadsheetControl1.Document;
            Worksheet invoice = workbook.Worksheets["Invoice"];
            invoice["B4"].Value = DateTime.Today;
            invoice["F18"].Value = DateTime.Today.AddDays(14);
        }

        void BindCustomEditors() {
            IWorkbook workbook = spreadsheetControl1.Document;
            Worksheet invoice = workbook.Worksheets["Invoice"];

            // Customer (billing address)
            Worksheet customers = workbook.Worksheets["Customers"];
            invoice.CustomCellInplaceEditors.Add(invoice["B10:C10"], CustomCellInplaceEditorType.ComboBox, ValueObject.FromRange(customers["A2:A21"]));

            // Customer store (shipping address)
            Worksheet stores = workbook.Worksheets["Stores"];
            invoice.CustomCellInplaceEditors.Add(invoice["G12:I12"], CustomCellInplaceEditorType.ComboBox, ValueObject.FromRange(stores["D5:D204"]), true);

            // Sales Rep
            Worksheet employees = workbook.Worksheets["Employees"];
            invoice.CustomCellInplaceEditors.Add(invoice["B18:C18"], CustomCellInplaceEditorType.ComboBox, ValueObject.FromRange(employees["I2:I52"]), true);
            // Ship date
            invoice.CustomCellInplaceEditors.Add(invoice["F18:G18"], CustomCellInplaceEditorType.DateEdit);
            // Ship Via
            CellValue[] shipVia = { "Air", "Ground", "Ship" };
            invoice.CustomCellInplaceEditors.Add(invoice["H18:I18"], CustomCellInplaceEditorType.ComboBox, ValueObject.CreateListSource(shipVia));
            // FOB
            invoice.CustomCellInplaceEditors.Add(invoice["J18:K18"], CustomCellInplaceEditorType.Custom, "FOBSpinEdit");
            // Terms
            invoice.CustomCellInplaceEditors.Add(invoice["L18:M18"], CustomCellInplaceEditorType.Custom, "TermsSpinEdit");

            // Quantity
            invoice.CustomCellInplaceEditors.Add(invoice["B22:B25"], CustomCellInplaceEditorType.Custom, "QtySpinEdit");
            // Invoice positions
            Worksheet products = workbook.Worksheets["Products"];
            invoice.CustomCellInplaceEditors.Add(invoice["C22:F25"], CustomCellInplaceEditorType.ComboBox, ValueObject.FromRange(products["B2:B20"]));
            // Discont
            invoice.CustomCellInplaceEditors.Add(invoice["I22:J25"], CustomCellInplaceEditorType.Custom, "DiscountSpinEdit");

            // Shipping
            invoice.CustomCellInplaceEditors.Add(invoice["K27:M27"], CustomCellInplaceEditorType.Custom, "ShippingSpinEdit");
        }

        void spreadsheetControl1_CustomCellEdit(object sender, SpreadsheetCustomCellEditEventArgs e) {
            if (!e.ValueObject.IsText)
                return;
            if (e.ValueObject.TextValue == "FOBSpinEdit")
                e.RepositoryItem = CreateSpinEdit(0, 500, 5);
            else if (e.ValueObject.TextValue == "TermsSpinEdit")
                e.RepositoryItem = CreateSpinEdit(5, 30, 1);
            else if (e.ValueObject.TextValue == "QtySpinEdit")
                e.RepositoryItem = CreateSpinEdit(1, 100, 1);
            else if (e.ValueObject.TextValue == "DiscountSpinEdit")
                e.RepositoryItem = CreateSpinEdit(0, 1000, 10);
            else if (e.ValueObject.TextValue == "ShippingSpinEdit")
                e.RepositoryItem = CreateSpinEdit(10, 1000, 5);
        }

        RepositoryItemSpinEdit CreateSpinEdit(int minValue, int maxValue, int increment) {
            RepositoryItemSpinEdit editor = new RepositoryItemSpinEdit();
            editor.AutoHeight = false;
            editor.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            editor.MinValue = minValue;
            editor.MaxValue = maxValue;
            editor.Increment = increment;
            editor.IsFloatValue = false;
            return editor;
        }

        void spreadsheetControl1_SelectionChanged(object sender, EventArgs e) {
            EnableControls();
            ActivateEditor();
        }

        void EnableControls() {
            Worksheet sheet = spreadsheetControl1.ActiveWorksheet;
            if (sheet.Name == "Invoice") {
                DefinedName invoiceItems = sheet.DefinedNames.GetDefinedName("InvoiceItems");
                btnRemoveRecord.Enabled = invoiceItems != null && invoiceItems.Range.RowCount > 1 && invoiceItems.Range.IsIntersecting(sheet.SelectedCell);
            }
            else
                btnRemoveRecord.Enabled = false;
        }

        void ActivateEditor() {
            Worksheet sheet = spreadsheetControl1.ActiveWorksheet;
            if (sheet.Name == "Invoice") {
                IList<CustomCellInplaceEditor> editors = sheet.CustomCellInplaceEditors.GetCustomCellInplaceEditors(sheet.Selection);
                if (editors.Count == 1)
                    spreadsheetControl1.OpenCellEditor(DevExpress.XtraSpreadsheet.CellEditorMode.Edit);
            }
        }

        void spreadsheetControl1_CellValueChanged(object sender, SpreadsheetCellEventArgs e) {
            if (e.Action == CellValueChangedAction.UndoRedo || e.OldValue == e.Cell.Value ||
                e.Cell.GetReferenceA1(ReferenceElement.IncludeSheetName) != "Invoice!B10")
                return;
            Worksheet invoice = e.Worksheet;
            Worksheet customerStores = spreadsheetControl1.Document.Worksheets["Stores"];
            // Apply filter to customer's stores
            string customerId = invoice["B11"].Value.TextValue;
            Table storesTable = customerStores.Tables[0];
            storesTable.AutoFilter.Clear();
            storesTable.AutoFilter.Columns[1].ApplyFilterCriteria(customerId);
            // Select default store
            Range range = storesTable.DataRange;
            for (int rowOffset = 0; rowOffset < range.RowCount; rowOffset++) {
                if (range[rowOffset, 1].Value.TextValue == customerId) {
                    invoice["G12"].Value = range[rowOffset, 3].Value.TextValue;
                    return;
                }
            }
            invoice["G12"].Value = CellValue.Empty;
        }

        void btnRemoveRecord_ItemClick(object sender, ItemClickEventArgs e) {
            Worksheet sheet = spreadsheetControl1.ActiveWorksheet;
            if (sheet.Name == "Invoice") {
                if (spreadsheetControl1.IsCellEditorActive)
                    spreadsheetControl1.CloseCellEditor(CellEditorEnterValueMode.Cancel);
                sheet.Rows.Remove(sheet.SelectedCell.TopRowIndex, 1);
                EnableControls();
                ActivateEditor();
            }
        }

        void btnAddRecord_ItemClick(object sender, ItemClickEventArgs e) {
            Worksheet sheet = spreadsheetControl1.ActiveWorksheet;
            if (sheet.Name == "Invoice") {
                if (spreadsheetControl1.IsCellEditorActive)
                    spreadsheetControl1.CloseCellEditor(CellEditorEnterValueMode.Cancel);
                AddRecord(sheet);
                EnableControls();
                ActivateEditor();
            }
        }

        // Add record to invoice
        void AddRecord(Worksheet sheet) {
            spreadsheetControl1.BeginUpdate();
            try {
                DefinedName invoiceItems = sheet.DefinedNames.GetDefinedName("InvoiceItems");
                int rowIndex = invoiceItems.Range.BottomRowIndex;
                sheet.Rows.Insert(rowIndex);
                sheet.Rows[rowIndex].Height = sheet.Rows[rowIndex + 1].Height;
                Range range = invoiceItems.Range;
                Range itemRange = sheet.Range.FromLTRB(range.LeftColumnIndex, range.BottomRowIndex, range.RightColumnIndex, range.BottomRowIndex);
                if (range.RowCount == 1) {
                    sheet["K24"].FormulaInvariant = "=SUM(K22:K23)";
                    invoiceItems.Range = sheet.Range.FromLTRB(range.LeftColumnIndex, range.TopRowIndex - 1, range.RightColumnIndex, range.BottomRowIndex).GetRangeWithAbsoluteReference();
                    RecreateCustomEditors();
                }
                MoveUpLastRecord(itemRange);
                InitializeRecord(itemRange);
                spreadsheetControl1.SelectedCell = itemRange[1];
            }
            finally {
                spreadsheetControl1.EndUpdate();
            }
        }

        void RecreateCustomEditors() {
            IWorkbook workbook = spreadsheetControl1.Document;
            Worksheet invoice = workbook.Worksheets["Invoice"];
            Worksheet products = workbook.Worksheets["Products"];

            // Remove custom editors
            invoice.CustomCellInplaceEditors.Remove(invoice["B23:M23"]);

            // Quantity
            invoice.CustomCellInplaceEditors.Add(invoice["B22:B23"], CustomCellInplaceEditorType.Custom, "QtySpinEdit");
            // Invoice positions
            invoice.CustomCellInplaceEditors.Add(invoice["C22:F23"], CustomCellInplaceEditorType.ComboBox, ValueObject.FromRange(products["B2:B20"]));
            // Discont
            invoice.CustomCellInplaceEditors.Add(invoice["I22:J23"], CustomCellInplaceEditorType.Custom, "DiscountSpinEdit");
        }

        // Move last record one row up
        void MoveUpLastRecord(Range itemRange) {
            Range range = itemRange.Offset(-1, 0);
            range.CopyFrom(itemRange, PasteSpecial.All, true);
        }

        // Setup new record values 
        void InitializeRecord(Range itemRange) {
            itemRange[0].Value = 1; // Qty
            itemRange[1].Value = CellValue.Empty; // Product
            itemRange[7].Value = 0; // Discount
        }

        // Suppress protection warning
        void spreadsheetControl1_ProtectionWarning(object sender, HandledEventArgs e) {
            e.Handled = true;
        }

        // Load invoice template on empty document created
        void spreadsheetControl1_EmptyDocumentCreated(object sender, EventArgs e) {
            LoadInvoiceTemplate();
        }

        // Mark data entry fields
        void spreadsheetControl1_CustomDrawCell(object sender, CustomDrawCellEventArgs e) {
            string cellReference = e.Cell.GetReferenceA1();
            if (e.Cell.Worksheet.Name != "Invoice" || (cellReference != "A10" && cellReference != "F12"))
                return;
            e.Handled = true;
            e.DrawDefault();
            using (Font font = new Font(e.Font.Name, 14f, FontStyle.Bold)) {
                string text = "*";
                SizeF size = e.Graphics.MeasureString(text, font, Int32.MaxValue, StringFormat.GenericDefault);
                RectangleF textBounds = new RectangleF(e.Bounds.Right - size.Width - 2, e.Bounds.Bottom - size.Height * 0.7f, size.Width + 2, size.Height);
                e.Graphics.DrawString(text, font, e.Cache.GetSolidBrush(Color.Red), textBounds, StringFormat.GenericDefault);
            }
        }
    }
}
