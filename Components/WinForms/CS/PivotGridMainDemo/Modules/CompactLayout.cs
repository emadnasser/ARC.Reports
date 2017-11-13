using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using DevExpress.Utils;

namespace DevExpress.XtraPivotGrid.Demos.Modules {
    public partial class CompactLayout : TutorialControl {
        protected override bool HideCustFormWhenSwitchDemo {
            get { return false; }
        }
        public CompactLayout() {
            CreateWaitDialog();
            InitializeComponent();

            TutorialInfo.WhatsThisCodeFile = "CS\\PivotGridMainDemo\\Modules\\CompactLayout.cs";
            TutorialInfo.WhatsThisXMLFile = "DevExpress.XtraPivotGrid.Demos.CodeInfo.CompactLayout.xml";
        }

        public override PivotGridControl ViewOptionsControl { get { return pivotGridControl1; } }
        public override PivotGridControl ExportControl { get { return pivotGridControl1; } }
        protected bool IsCompactLayout { get { return (bool)groupLayout.EditValue; } }

        private void CompactLayout_Load(object sender, System.EventArgs e) {
            pivotGridControl1.DataSource = GetNWindData("SalesPerson");
            pivotGridControl1.ValueImages = CategoryImageList;
            pivotGridControl1.BestFit();
            pivotGridControl1.CollapseAll();
            pivotGridControl1.FieldsCustomization(splitContainerControl1.Panel1);
            pivotGridControl1.ExpandValue(false, new object[] { "Andrew Fuller" });
            pivotGridControl1.OptionsCustomization.AllowFilterInCustomizationForm = true;
            pivotGridControl1.OptionsCustomization.AllowSortInCustomizationForm = true;
        }

        private void pivotGridControl1_FieldValueImageIndex(object sender, PivotFieldImageIndexEventArgs e) {
            if(e.Field == fieldCategoryName && (IsCompactLayout || Comparer.Equals(e.ValueType, PivotGridValueType.Value)))
                e.ImageIndex = GetCategoryIndexByName(e.Value);
        }

        //<groupLayout>
        private void radioGroup1_SelectedIndexChanged(object sender, EventArgs e) {
            if(IsCompactLayout) {
                pivotGridControl1.OptionsView.RowTotalsLocation = PivotRowTotalsLocation.Tree;
                pivotGridControl1.OptionsBehavior.HorizontalScrolling = PivotGridScrolling.CellsArea;
            } else {
                pivotGridControl1.OptionsView.RowTotalsLocation = PivotRowTotalsLocation.Far;
                pivotGridControl1.OptionsBehavior.HorizontalScrolling = PivotGridScrolling.Control;
            }
        }
        //</groupLayout>
    }
}
