using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using DevExpress.XtraEditors.Controls;

namespace DevExpress.XtraPivotGrid.Demos.Modules {
	public partial class UnboundColumns : DevExpress.XtraPivotGrid.Demos.TutorialControl {
		public UnboundColumns() {
			// This call is required by the Windows Form Designer.
			CreateWaitDialog();
			InitializeComponent();

            TutorialInfo.WhatsThisCodeFile = "CS\\PivotGridMainDemo\\Modules\\UnboundColumns.cs";
            TutorialInfo.WhatsThisXMLFile = "DevExpress.XtraPivotGrid.Demos.CodeInfo.UnboundColumns.xml";

			// TODO: Add any initialization after the InitializeComponent call
		}
		public override PivotGridControl ViewOptionsControl { get { return pivotGridControl1; } }
		public override PivotGridControl ExportControl { get { return pivotGridControl1; } }

		private void UnboundColumns_Load(object sender, System.EventArgs e) {
			pivotGridControl1.DataSource = GetNWindData("SalesPerson");
			pivotGridControl1.HeaderImages = HeadersImageList;
			fieldSalesPerson.ImageIndex = 0;
			fieldOrderAmount.ImageIndex = 3;
			fieldBonusAmount.ImageIndex = 4;
		}
        //<icbOrderAmount>
        //<icbSalesPerson>
		private void pivotGridControl1_CustomUnboundFieldData(object sender, DevExpress.XtraPivotGrid.CustomFieldDataEventArgs e) {
			DataRowView row = GetDataRowByIndex(e.ListSourceRowIndex);
			if(row == null) return;
			if(e.Field == fieldSalesPerson) 
				e.Value = string.Format(icbSalesPerson.EditValue.ToString(), row["FirstName"], row["LastName"]);
			if(e.Field == fieldOrderAmount) {
				double discount = icbOrderAmount.EditValue.Equals(0) ? Convert.ToDouble(row["Discount"]) : 0;
				e.Value = Convert.ToDouble(row["UnitPrice"]) * Convert.ToDouble(row["Quantity"]) * (1 - discount);
			}
		}
        //</icbSalesPerson>        
        //<skip>
		private void icb_SelectedIndexChanged(object sender, System.EventArgs e) {
			pivotGridControl1.RefreshData();
		}

		private void pivotGridControl1_FieldAreaChanged(object sender, DevExpress.XtraPivotGrid.PivotFieldEventArgs e) {
			if(e.Field == fieldOrderAmount) {
				fieldBonusAmount.Visible = e.Field.Area == PivotArea.DataArea;
				fieldBonusAmount.Visible = e.Field.Area == PivotArea.DataArea;
			}
		}
        //</skip>
		private void pivotGridControl1_CustomCellDisplayText(object sender, DevExpress.XtraPivotGrid.PivotCellDisplayTextEventArgs e) {
			if(Comparer.ReferenceEquals(e.DataField, fieldPercent)) {
				object orderAmount = e.GetCellValue(fieldOrderAmount);
				if(orderAmount == null) return;
				decimal grandTotalOrderAmount = (decimal)e.GetRowGrandTotal(fieldOrderAmount);
				decimal perc = grandTotalOrderAmount != 0 ? (decimal)orderAmount / grandTotalOrderAmount : 0;
				e.DisplayText = string.Format("{0:p}", perc);
			}
			//The Bonus Amount field displays 15% if the order amount is greater than $50,000, or 10% of the amount is less.
			if(Comparer.ReferenceEquals(e.DataField, fieldBonusAmount)) {
				object orderAmount = e.GetCellValue(fieldOrderAmount);
				if(orderAmount == null) return;
				double perc = (decimal)orderAmount > 50000 ? 0.15 : 0.1; 
				e.DisplayText = Comparer.Equals(e.RowValueType, PivotGridValueType.Value) ? string.Format("{0:p}", perc) : "";
			}
		}
        //</icbOrderAmount>
	}
}

