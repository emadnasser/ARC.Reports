using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraEditors.Controls;
using DevExpress.Data.PivotGrid;

namespace DevExpress.XtraPivotGrid.Demos.Modules {
	public partial class SortBySummary : DevExpress.XtraPivotGrid.Demos.TutorialControl {
		public SortBySummary() {
			// This call is required by the Windows Form Designer.
			CreateWaitDialog();
			InitializeComponent();

            TutorialInfo.WhatsThisCodeFile = "CS\\PivotGridMainDemo\\Modules\\SortBySummary.cs";
            TutorialInfo.WhatsThisXMLFile = "DevExpress.XtraPivotGrid.Demos.CodeInfo.SortBySummary.xml";

			// TODO: Add any initialization after the InitializeComponent call
		}
		public override PivotGridControl ViewOptionsControl { get { return pivotGridControl1; } }
		public override PivotGridControl ExportControl { get { return pivotGridControl1; } }
        //<icbField>
		private void SortBySummary_Load(object sender, System.EventArgs e) {
			pivotGridControl1.DataSource = GetNWindData("SalesPerson");
			fieldYear.FilterValues.FilterType = PivotFilterType.Included;
			fieldYear.FilterValues.Add(2015);
			InitComboBoxes();
			pivotGridControl1.HeaderImages = HeadersImageList;
			fieldSalesPerson.ImageIndex = 0;
		}

		void InitComboBoxes() {
			foreach(PivotGridField field in pivotGridControl1.Fields) 
				if(field.Area == PivotArea.DataArea) 
					icbField.Properties.Items.Add(new ImageComboBoxItem(field.Caption.ToString(), field, -1));
			icbField.EditValue = fieldSalesPerson.SortBySummaryInfo.Field;
		}

		private void icbField_SelectedIndexChanged(object sender, System.EventArgs e) {
			fieldSalesPerson.SortBySummaryInfo.Field = (PivotGridField)icbField.EditValue;
		}
        //</icbField>
		private void pivotGridControl1_CustomDrawCell(object sender, DevExpress.XtraPivotGrid.PivotCustomDrawCellEventArgs e) {
			if(Comparer.ReferenceEquals(e.DataField, (PivotGridField)icbField.EditValue)) {
				e.Appearance.Font = new Font(e.Appearance.Font, FontStyle.Bold);
			}
		}
	}
}

