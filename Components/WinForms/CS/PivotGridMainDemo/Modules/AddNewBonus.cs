using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraPivotGrid.Data;
using DevExpress.Utils;
using System.IO;

namespace DevExpress.XtraPivotGrid.Demos.Modules {
    public partial class AddNewBonus : DevExpress.XtraEditors.XtraForm {

        public AddNewBonus() {
            InitializeComponent();
        }

        PivotGridControl pivotGrid;
        public PivotGridControl PivotGrid {
            get { return pivotGrid; }
            set { pivotGrid = value; }
        }

        void teBonusName_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e) {
            if(string.IsNullOrEmpty(teBonusName.Text)) {
                buttonOK.Enabled = false;
                beExpression.Enabled = false;
            } else {
                buttonOK.Enabled = true;
                beExpression.Enabled = true;
            }
        }

        PivotGridField GetNewInvisibleBonusField() {
            PivotGridField newBonusField = new PivotGridField(teBonusName.Text, PivotArea.DataArea);
            newBonusField.Name = "field_" + teBonusName.Text;
            newBonusField.Visible = false;
            newBonusField.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            newBonusField.UnboundExpression = beExpression.Text;
            newBonusField.Options.ShowUnboundExpressionMenu = true;
            return newBonusField;
        }

        private void beExpression_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e) {
            PivotGridField newBonus = GetNewInvisibleBonusField();
            PivotGrid.Fields.Add(newBonus);
            PivotGrid.ShowUnboundExpressionEditor(newBonus);
            beExpression.Text = newBonus.UnboundExpression;
            PivotGrid.Fields.Remove(newBonus);
        }

        private void buttonOK_Click(object sender, EventArgs e) {
            PivotGridField newBonus = GetNewInvisibleBonusField();
            newBonus.Visible = true;
            newBonus.AreaIndex = PivotGrid.GetFieldsByArea(PivotArea.DataArea).Count;
            PivotGrid.Fields.Add(newBonus);
            teBonusName.Text = string.Empty;
            buttonOK.Enabled = false;
            beExpression.Text = string.Empty;
            beExpression.Enabled = false;
            PivotGrid.BestFit();
            DialogResult = DialogResult.OK;
        }
    }
}

