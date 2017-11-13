using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors.Controls;

namespace DevExpress.XtraRichEdit.Demos.Forms {
    public partial class SelectAmountForm : PopupFormBase {
        public SelectAmountForm() {
            InitializeComponent();
            this.calcEdit1.Value = 0M;
        }

        protected override void SetEditValue() {
            if (this.calcEdit1.Value > 0M) {
                SetEditValueCore(this.calcEdit1.Value);
                return;
            }
            decimal value;
            if (Decimal.TryParse(this.calcEdit1.Text, out value))
                SetEditValueCore(value);
        }
        void calcEdit1_Properties_ButtonClick(object sender, ButtonPressedEventArgs e) {
            if (e.Button == this.calcEdit1.Properties.Buttons[1])
                OnCommit();
        }
        void calcEdit1_ValueChanged(object sender, EventArgs e) {
            SetEditValue();
        }
    }
}
