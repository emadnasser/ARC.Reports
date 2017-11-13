using DevExpress.XtraEditors.Controls;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;

namespace DevExpress.XtraPivotGrid.Demos.Modules {
	public partial class Validation : TutorialControl {
		public Validation() {
			CreateWaitDialog();
			InitializeComponent();

            TutorialInfo.WhatsThisCodeFile = "CS\\PivotGridMainDemo\\Modules\\Validation.cs";
            TutorialInfo.WhatsThisXMLFile = "DevExpress.XtraPivotGrid.Demos.CodeInfo.Validation.xml";

			pivotGridControl.DataSource = GetNWindData("SalesPerson");
		}
		public override PivotGridControl ViewOptionsControl { get { return pivotGridControl; } }
		public override PivotGridControl ExportControl { get { return pivotGridControl; } }
		protected override void OnLoad(EventArgs e) {
			base.OnLoad(e);
			InitValidationControls();
			pivotGridControl.HeaderImages = HeadersImageList;
			pivotGridControl.ValueImages = CategoryImageList;
			fieldSalesPerson.ImageIndex = 0;
            pivotGridControl.OptionsCustomization.AllowFilterBySummary = false;
		}

		private void pivotGridControl_EditorValueChanged(object sender, EditValueChangedEventArgs e) {
			if(Comparer.ReferenceEquals(e.DataField, fieldQuantity)) {
				PivotDrillDownDataSource ds = e.CreateDrillDownDataSource();
                int editValue = Convert.ToInt32(e.Editor.EditValue);
                if(ds.RowCount > 0) {                    
                    int newCellValue = (int)Math.Floor((decimal)editValue / ds.RowCount),
                        extra = editValue % ds.RowCount;
                    for(int i = 0; i < ds.RowCount; i++) {
                        if(i == ds.RowCount - 1)
                            ds[i][fieldQuantity] = (short)(newCellValue + extra);
                        else
                            ds[i][fieldQuantity] = (short)newCellValue;
                    }
                } else {
                    DataTable table = ((DataView)pivotGridControl.DataSource).Table;
                    object[] row = new object[table.Columns.Count];
                    SetRowValues(PivotArea.ColumnArea, e, table, row);
                    SetRowValues(PivotArea.RowArea, e, table, row);
                    int columnIndex = table.Columns.IndexOf(fieldQuantity.FieldName);
                    row[columnIndex] = editValue;
                    table.Rows.Add(row);
                    table.AcceptChanges();
                    pivotGridControl.RefreshData();
                }
			}
		}
        private void SetRowValues(PivotArea area, EditValueChangedEventArgs e, DataTable table, object[] row) {
            List<PivotGridField> fields = pivotGridControl.GetFieldsByArea(area);
            for(int i = 0; i < fields.Count; i++) {
                object value = e.GetFieldValue(fields[i]);
                int columnIndex = table.Columns.IndexOf(fields[i].FieldName);
                row[columnIndex] = value;
            }            
        }
        //<totalValidation>
        //<commonValidation>
        private void pivotGridControl_ValidatingEditor(object sender, BaseContainerValidateEditorEventArgs e) {
			PivotCellEventArgs focusedCell = GetFocusedCellInfo(pivotGridControl);
			if(Comparer.ReferenceEquals(focusedCell.DataField, fieldQuantity)) {
				int convertedValue = 0;
				int oldValue = Convert.ToInt32(focusedCell.Value);
				try {
					if(IsTotalOrGrandTotal(focusedCell)) {
						convertedValue = Convert.ToInt32(e.Value);
						double factor = (double)convertedValue / (double)oldValue;
						double newMaxValue = factor * Convert.ToDouble(focusedCell.SummaryValue.Max);
						try {
							Convert.ToInt16(newMaxValue);
						} catch {
							e.Valid = false;
							e.ErrorText = "Value cann't be decomposed to the components of type Int16";
						}
						ApplyValidation(totalValidation, convertedValue, e);
					} else {
						convertedValue = (int)Convert.ToInt16(e.Value);
						ApplyValidation(commonValidation, convertedValue, e);
					}
				} catch(Exception ex) {
					e.Valid = false;
					e.ErrorText = ex.Message;
				}
				e.Value = convertedValue;
			}
		}
        //</commonValidation>
        //</totalValidation>
		private void InitValidationControls() {
			commonValidation.spinEdit1.EditValue = 0;
			commonValidation.imageComboBoxEdit1.SelectedIndex = 1;
			commonValidation.imageComboBoxEdit2.SelectedIndex = 2;
			commonValidation.spinEdit2.EditValue = 150;
			totalValidation.spinEdit1.EditValue = 0;
			totalValidation.imageComboBoxEdit1.SelectedIndex = 1;
			totalValidation.imageComboBoxEdit2.SelectedIndex = 2;
			totalValidation.spinEdit2.EditValue = 1500;
		}
        //<commonValidation>
        //<totalValidation>
		void ApplyValidation(ValidationControl validation, int value, BaseContainerValidateEditorEventArgs e) {
			object[] reply = validation.IsTrueCondition(value);
			if(reply != null && !(bool)reply[0]) {
				e.ErrorText = reply[1].ToString();
				e.Valid = false;
			}
		}
        //</commonValidation>
        //</totalValidation>
		PivotCellEventArgs GetFocusedCellInfo(PivotGridControl pivot) {
			Point focused = pivot.Cells.FocusedCell;
			return pivot.Cells.GetCellInfo(focused.X, focused.Y);
		}

		private void pivotGridControl_CustomAppearance(object sender, PivotCustomAppearanceEventArgs e) {
			if(!Comparer.ReferenceEquals(e.DataField, fieldQuantity))
				return;
			if(IsTotalOrGrandTotal(e)) {
				if(!(bool)totalValidation.IsTrueCondition(e.Value)[0]) {
					e.Appearance.BackColor = Color.Pink;
                    e.Appearance.BackColor2 = Color.Pink;
				}
			} else {
				if(!(bool)commonValidation.IsTrueCondition(e.Value)[0]) {
					e.Appearance.BackColor = Color.Red;
                    e.Appearance.BackColor2 = Color.Red;
				}
			}
		}
		bool IsTotalOrGrandTotal(PivotCellEventArgs e) {
			return e.ColumnValueType == PivotGridValueType.Total || e.RowValueType == PivotGridValueType.Total || e.ColumnValueType == PivotGridValueType.GrandTotal || e.RowValueType == PivotGridValueType.GrandTotal;
		}

		private void validationControl_ValidateCondition(object sender, EventArgs e) {
			pivotGridControl.LayoutChanged();
		}

		private void pivotGridControl_FieldValueImageIndex(object sender, PivotFieldImageIndexEventArgs e) {
			if(e.Field == fieldCategoryName && Comparer.Equals(e.ValueType, PivotGridValueType.Value))
				e.ImageIndex = GetCategoryIndexByName(e.Value);
		}
	}
}
