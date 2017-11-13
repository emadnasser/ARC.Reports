using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;

namespace DevExpress.XtraPivotGrid.Demos.Modules {
    /// <summary>
    /// Summary description for UserControl1.
    /// </summary>
    public partial class ValidationControl : System.Windows.Forms.UserControl {
        public ValidationControl() {
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            // This call is required by the Windows.Forms Form Designer.
            InitializeComponent();

            // TODO: Add any initialization after the InitForm call

        }

        private string fCaption;
        public event EventHandler ValidateCondition;

        private void imageComboBoxEdit1_SelectedIndexChanged(object sender, System.EventArgs e) {
            bool visibleNextCondition = (int)imageComboBoxEdit1.EditValue < 2;
            label2.Visible = imageComboBoxEdit2.Visible = spinEdit2.Visible = visibleNextCondition;
            RaiseValidateCondition();
        }

        private void imageComboBoxEdit2_SelectedIndexChanged(object sender, System.EventArgs e) {
            spinEdit2.Visible = label2.Enabled = !imageComboBoxEdit2.EditValue.Equals(0);
            RaiseValidateCondition();
        }

        private void spinEdit_EditValueChanged(object sender, System.EventArgs e) {
            RaiseValidateCondition();
        }

        protected void RaiseValidateCondition() {
            if(ValidateCondition != null)
                ValidateCondition(this, new EventArgs());
        }

        public string Caption {
            get { return fCaption; }
            set {
                fCaption = value;
                label1.Text = fCaption;
            }
        }

        public object[] IsTrueCondition(object val) {
            decimal dValue = Convert.ToDecimal(val);
            decimal value1 = Convert.ToDecimal(spinEdit1.EditValue);
            decimal value2 = Convert.ToDecimal(spinEdit2.EditValue);
            int condition1 = imageComboBoxEdit1.SelectedIndex;
            int condition2 = imageComboBoxEdit2.SelectedIndex;
            bool greater = false;
            string reply = "";
            if(condition1 == 2) {
                reply = "The value must be less than " + value1.ToString();
                return new object[] { (dValue < value1), reply };
            }
            if(condition1 == 3) {
                reply = "The value must be less than or equal to " + value1.ToString();
                return new object[] { (dValue <= value1), reply };
            }
            if(condition1 == 4) {
                reply = "The value must not equal " + value1.ToString();
                return new object[] { (dValue != value1), reply };
            }
            if(condition1 == 0) {
                reply = "The value must be greater than " + value1.ToString();
                greater = dValue > value1;
            }
            if(condition1 == 1) {
                reply = "The value must be greater than or equal to " + value1.ToString();
                greater = dValue >= value1;
            }
            if(condition2 == 0) return new object[] { greater, reply };
            if(greater) {
                if(condition2 == 1) {
                    reply = "The value must be less than " + value2.ToString();
                    return new object[] { (greater && dValue < value2), reply };
                }
                if(condition2 == 2) {
                    reply = "The value must be less than or equal to " + value2.ToString();
                    return new object[] { (greater && dValue <= value2), reply };
                }
            }
            return new object[] { false, reply };
        }
    }
}
