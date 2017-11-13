using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using System.Data.OleDb;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.DXErrorProvider;


namespace DevExpress.XtraLayout.Demos {
    /// <summary>
    /// Summary description for Employees.
    /// </summary>
    public partial class Validating : DevExpress.XtraLayout.Demos.TutorialControl {
        public Validating() {
            // This call is required by the Windows.Forms Form Designer.
            CreateWaitDialog();
            InitializeComponent();
            layoutControl1.SetDefaultLayout();
            InitData();
            // TODO: Add any initialization after the InitForm call
        }
        protected override void OnVisibleChanged(object sender, EventArgs e) {
            if(Visible) {
                InitFields();
                ValidateFields();
            }
            base.OnVisibleChanged(sender, e);
        }
        private void InitData() {
            string DBFileName = DevExpress.Utils.FilesHelper.FindingFileName(Application.StartupPath, "Data\\nwind.mdb");
            if(DBFileName != "") {
                string con = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + DBFileName;
                OleDbDataAdapter oleDBAdapter1 = new OleDbDataAdapter("SELECT * FROM Categories", con);
                OleDbDataAdapter oleDBAdapter2 = new OleDbDataAdapter("SELECT * FROM Products", con);
                OleDbDataAdapter oleDBAdapter3 = new OleDbDataAdapter("SELECT * FROM [Order Details]", con);
                OleDbDataAdapter oleDBAdapter4 = new OleDbDataAdapter("SELECT * FROM Suppliers", con);

                SetWaitDialogCaption("Loading Categories...");
                oleDBAdapter1.Fill(dsCategories1.Categories);

                SetWaitDialogCaption("Loading Products...");
                oleDBAdapter2.Fill(dsCategories1.Products);

                SetWaitDialogCaption("Loading Order Details...");
                oleDBAdapter3.Fill(dsCategories1.Order_Details);

                SetWaitDialogCaption("Loading Suppliers...");
                oleDBAdapter4.Fill(dsCategories1.Suppliers);
            }
        }
        private void InitFields() {
            productNameTextEdit.Text = "";
            unitsInStockSpinEdit.EditValue = -1;
            reorderLevelSpinEdit.EditValue = -1;
            discountSpinEdit.EditValue = 0.60m;
        }
        private void ValidateFields() {
            Validate_EmptyStringRule(productNameTextEdit);
            Validate_LessThanMinRule(productsUnitPriceCalcEdit, Decimal.Zero);
            Validate_LessThanMinRule(orderUnitPriceCalcEdit, Decimal.Zero);
            Validate_LessThanMinRule(quantitySpinEdit, Decimal.Zero);
            Validate_LessThanMinRule(unitsInStockSpinEdit, Decimal.Zero);
            Validate_LessThanMinRule(reorderLevelSpinEdit, Decimal.Zero);
            Validate_LessThanMinRule(unitsOnOrderSpinEdit, Decimal.Zero);
            Validate_BetweenMinAndMaxRule(discountSpinEdit, Decimal.Zero, 0.5m);
        }
        private void checkEdit1_CheckedChanged(object sender, System.EventArgs e) {
            layoutControl1.BeginUpdate();
            productNameTextEdit.Enabled = quantityPerUnitTextEdit.Enabled = supplierLookUpEdit.Enabled = productsUnitPriceCalcEdit.Enabled = unitsInStockSpinEdit.Enabled = reorderLevelSpinEdit.Enabled = unitsOnOrderSpinEdit.Enabled = !checkEdit1.Checked;
            layoutControl1.EndUpdate();
        }
        private void Detail_Validated(object sender, System.EventArgs e) {
            ((CurrencyManager)this.BindingContext[this.dataNavigator3.DataSource, this.dataNavigator3.DataMember]).EndCurrentEdit();
        }
        private void productNameTextEdit_Validating(object sender, System.ComponentModel.CancelEventArgs e) {
            Validate_EmptyStringRule(sender as BaseEdit);
        }
        private void unitPriceCalcEdit_Validating(object sender, System.ComponentModel.CancelEventArgs e) {
            Validate_LessThanMinRule(sender as BaseEdit, Decimal.Zero);
        }
        private void quantitySpinEdit_Validating(object sender, System.ComponentModel.CancelEventArgs e) {
            Validate_LessThanMinRule(sender as BaseEdit, Decimal.Zero);
        }
        private void discountSpinEdit_Validating(object sender, System.ComponentModel.CancelEventArgs e) {
            Validate_BetweenMinAndMaxRule(sender as BaseEdit, Decimal.Zero, 0.50m);
        }
        private void dataNavigator3_PositionChanged(object sender, System.EventArgs e) {
            ValidateFields();
        }
        private void dataNavigator2_ButtonClick_1(object sender, NavigatorButtonClickEventArgs e) {
            e.Handled = dxErrorProvider1.HasErrors;
        }
        private void Validate_EmptyStringRule(BaseEdit control) {
            if(control.Text == null || control.Text.Trim().Length == 0) dxErrorProvider1.SetError(control, "This field can't be empty", ErrorType.Critical);
            else dxErrorProvider1.SetError(control, "");
        }
        private void Validate_LessThanMinRule(BaseEdit control, Decimal min) {
            if(!(control.EditValue is Decimal)) return;
            if((Decimal)control.EditValue < min) dxErrorProvider1.SetError(control, "Please enter a greater value than " + min.ToString(), ErrorType.Warning);
            else dxErrorProvider1.SetError(control, "");
        }
        private void Validate_BetweenMinAndMaxRule(BaseEdit control, Decimal min, Decimal max) {
            if(!(control.EditValue is Decimal)) return;
            Decimal val = (Decimal)control.EditValue;
            if((val < min)) dxErrorProvider1.SetError(control, "Please enter a greater value than " + (min * 100).ToString(), ErrorType.Warning);
            else if(val > max) dxErrorProvider1.SetError(control, "Please enter a value less than " + (max * 100).ToString(), ErrorType.Information);
            else dxErrorProvider1.SetError(control, "");
        }
    }
}
