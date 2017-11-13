using DevExpress.Spreadsheet;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace DevExpress.XtraSpreadsheet.Demos {
    public partial class CustomInplaceEditors : SpreadsheetRibbonTutorialControlBase {
        public CustomInplaceEditors() {
            InitializeComponent();
            spreadsheetControl1.LoadDocument(DemoUtils.GetRelativePath("CustomInplaceEditors_template.xlsx"), DocumentFormat.Xlsx);
        }

        protected internal override void SubscribeEvents() {
            base.SubscribeEvents();
            spreadsheetControl1.DocumentLoaded += spreadsheetControl1_DocumentLoaded;
            spreadsheetControl1.CustomCellEdit += spreadsheetControl1_CustomCellEdit;
        }
        void spreadsheetControl1_DocumentLoaded(object sender, EventArgs e) {
            BindCustomEditors();
        }
        void BindCustomEditors() {
            Worksheet sheet = spreadsheetControl1.Document.Worksheets["Sales report"];

            Range dateEditRange = sheet["Table[Order Date]"];
            sheet.CustomCellInplaceEditors.Add(dateEditRange, CustomCellInplaceEditorType.DateEdit);

            Range comboBoxRange = sheet["Table[Category]"];
            sheet.CustomCellInplaceEditors.Add(comboBoxRange, CustomCellInplaceEditorType.ComboBox, ValueObject.FromRange(sheet["J3:J9"]));

            Range checkBoxRange = sheet["Table[Discount]"];
            sheet.CustomCellInplaceEditors.Add(checkBoxRange, CustomCellInplaceEditorType.CheckBox);

            Range customRange = sheet["Table[Qty]"];
            sheet.CustomCellInplaceEditors.Add(customRange, CustomCellInplaceEditorType.Custom, "MySpinEdit");
        }

        void spreadsheetControl1_CustomCellEdit(object sender, SpreadsheetCustomCellEditEventArgs e) {
            if (e.ValueObject.IsText && e.ValueObject.TextValue == "MySpinEdit") {
                RepositoryItemSpinEdit editor = new RepositoryItemSpinEdit();
                editor.AutoHeight = false;
                editor.BorderStyle = XtraEditors.Controls.BorderStyles.NoBorder;
                editor.MinValue = 1;
                editor.MaxValue = 1000;
                editor.IsFloatValue = false;
                e.RepositoryItem = editor;
            }
        }
    }
}
