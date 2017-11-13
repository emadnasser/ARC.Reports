using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraEditors.Controls;
using DevExpress.Data.PivotGrid;
using DevExpress.XtraPivotGrid.Customization;
using System.Collections.Generic;

namespace DevExpress.XtraPivotGrid.Demos.Modules {
    public partial class FieldsCustomization : DevExpress.XtraPivotGrid.Demos.TutorialControl {
        public FieldsCustomization() {
            // This call is required by the Windows Form Designer.
            CreateWaitDialog();
            InitializeComponent();

            TutorialInfo.WhatsThisCodeFile = "CS\\PivotGridMainDemo\\Modules\\FieldsCustomization.cs";
            TutorialInfo.WhatsThisXMLFile = "DevExpress.XtraPivotGrid.Demos.CodeInfo.FieldsCustomization.xml";

            // TODO: Add any initialization after the InitializeComponent call
        }
		public override PivotGridControl ViewOptionsControl { get { return pivotGridControl1; } }
		public override PivotGridControl ExportControl { get { return pivotGridControl1; } }

        bool showCustomization = false;
        private void FieldsCustomization_Load(object sender, System.EventArgs e) {
            pivotGridControl1.DataSource = GetNWindData("SalesPerson");
            InitComboBoxes();
            pivotGridControl1.ValueImages = CategoryImageList;
            pivotGridControl1.HeaderImages = HeadersImageList;
            fieldSalesPerson.ImageIndex = 0;
            fieldOrderID.ImageIndex = 1;
        }

        void InitComboBoxes() {
            icbHideFields.Properties.Items.AddEnum(typeof(AllowHideFieldsType));
            icbHideFields.EditValue = pivotGridControl1.OptionsCustomization.AllowHideFields;

            icbCustomizationStyle.Properties.Items.AddEnum(typeof(CustomizationFormStyle));
            icbCustomizationStyle.EditValue = pivotGridControl1.OptionsCustomization.CustomizationFormStyle;
        }

        protected override void DoShow() {
            pivotGridControl1.FieldsCustomization(pivotGridControl1.PointToScreen(new Point(Width - 100, 0)));
        }


        void InitCustomization(bool show) {
            showCustomization = show;
            sbCustomizationForm.Text = showCustomization ? "Hide Customization Form" : "Show Customization Form";
        }

        private void pivotGridControl1_ShowCustomizationForm(object sender, System.EventArgs e) {
            InitCustomization(true);
        }

        private void pivotGridControl1_HideCustomizationForm(object sender, System.EventArgs e) {
            InitCustomization(false);
        }

        //<sbCustomizationForm>
        private void sbCustomizationForm_Click(object sender, System.EventArgs e) {
            if(showCustomization)
                pivotGridControl1.DestroyCustomization();
            else
                pivotGridControl1.FieldsCustomization();
        }
        //</sbCustomizationForm>

        private void pivotGridControl1_FieldValueImageIndex(object sender, DevExpress.XtraPivotGrid.PivotFieldImageIndexEventArgs e) {
            if(e.Field == fieldCategoryName && Comparer.Equals(e.ValueType, PivotGridValueType.Value))
                e.ImageIndex = GetCategoryIndexByName(e.Value);
        }

        //<icbHideFields>
        private void icbHideFields_SelectedIndexChanged(object sender, System.EventArgs e) {
            pivotGridControl1.OptionsCustomization.AllowHideFields = (AllowHideFieldsType)icbHideFields.EditValue;
        }
        //</icbHideFields>

        //<icbCustomizationStyle>
        private void icbCustomizationStyle_SelectedIndexChanged(object sender, EventArgs e) {
            pivotGridControl1.OptionsCustomization.CustomizationFormStyle = (CustomizationFormStyle)icbCustomizationStyle.EditValue;
            if(showCustomization) {
                pivotGridControl1.DestroyCustomization();
                Point showPoint = pivotGridControl1.CustomizationFormBounds.Location;
                pivotGridControl1.FieldsCustomization(showPoint);
            }
        }
        //</icbCustomizationStyle>
    }
}

