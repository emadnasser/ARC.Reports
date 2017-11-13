using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraEditors.Controls;
using DevExpress.Data.PivotGrid;
using DevExpress.Utils;

namespace DevExpress.XtraPivotGrid.Demos.Modules {
	public partial class TotalsLocation : DevExpress.XtraPivotGrid.Demos.TutorialControl {
		public TotalsLocation() {
			// This call is required by the Windows Form Designer.
			CreateWaitDialog();
			InitializeComponent();

            TutorialInfo.WhatsThisCodeFile = "CS\\PivotGridMainDemo\\Modules\\TotalsLocation.cs";
            TutorialInfo.WhatsThisXMLFile = "DevExpress.XtraPivotGrid.Demos.CodeInfo.TotalsLocation.xml";

			// TODO: Add any initialization after the InitializeComponent call
		}
		public override PivotGridControl ViewOptionsControl { get { return pivotGridControl1; } }
		public override PivotGridControl ExportControl { get { return pivotGridControl1; } }

		private void TotalsLocation_Load(object sender, System.EventArgs e) {
			pivotGridControl1.DataSource = GetNWindData("SalesPerson");
			pivotGridControl1.ValueImages = CategoryImageList;
			InitComboBoxes();
		}

		void InitComboBoxes() {
            columnTotalsLocations.Properties.Items.AddEnum(typeof(PivotTotalsLocation));
			columnTotalsLocations.EditValue = pivotGridControl1.OptionsView.ColumnTotalsLocation;

            rowTotalsLocations.Properties.Items.AddEnum(typeof(PivotRowTotalsLocation));
            rowTotalsLocations.EditValue = pivotGridControl1.OptionsView.RowTotalsLocation;
		}

		private void pivotGridControl1_FieldValueImageIndex(object sender, DevExpress.XtraPivotGrid.PivotFieldImageIndexEventArgs e) {
			if(e.Field == fieldCategoryName && Comparer.Equals(e.ValueType, PivotGridValueType.Value))
				e.ImageIndex = GetCategoryIndexByName(e.Value);
		}
        //<columnTotalsLocations>
		private void icbTotalsLocations_SelectedIndexChanged(object sender, System.EventArgs e) {
            pivotGridControl1.OptionsView.ColumnTotalsLocation = (PivotTotalsLocation)columnTotalsLocations.EditValue;
		}
        //</columnTotalsLocations>
        //<rowTotalsLocations>
        private void rowTotalsLocation_SelectedIndexChanged(object sender, EventArgs e) {
            if(Comparer.Equals((PivotRowTotalsLocation)rowTotalsLocations.EditValue, PivotRowTotalsLocation.Tree) && pivotGridControl1.OptionsView.ShowRowTotals == false)
                pivotGridControl1.OptionsView.ShowRowTotals = true;
            pivotGridControl1.OptionsView.RowTotalsLocation = (PivotRowTotalsLocation)rowTotalsLocations.EditValue;
        }
        //</rowTotalsLocations>
	}
}

