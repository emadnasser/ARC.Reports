using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraEditors.Design;
using DevExpress.XtraBars;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraEditors.Controls;

namespace DevExpress.XtraGrid.Demos {
    public partial class ExpressionConditionsEditor : XtraUserControl {
        public GridView currentView = null;
        bool init = false;
        public ExpressionConditionsEditor() {
            InitializeComponent();
            propertyGrid1.ShowButtons = propertyGrid1.ShowCategories = propertyGrid1.ShowDescription = false;
        }

        public void Init(GridView view) {
            currentView = view;
            InitConditions();
            InitColumns();
            if(FormatItemList.Items.Count > 0)
                FormatItemList.SelectedIndex = 0;
        }

        void InitColumns() {
            if(currentView == null) return;
            foreach(GridColumn col in currentView.Columns)
                imageComboBoxEdit1.Properties.Items.Add(new ImageComboBoxItem(col.GetTextCaption(), col, -1));
        }

        void InitConditions() {
            if(currentView == null) return;
            FormatItemList.BeginUpdate();
            try {
                FormatItemList.Items.Clear();
                foreach(GridFormatRule condition in currentView.FormatRules) {
                    ItemExpressionFormatRule eCondition = new ItemExpressionFormatRule(condition);
                    if(eCondition.IsExpressionCondition) {
                        FormatItemList.Items.Add(eCondition);
                    }
                }
            }
            finally {
                FormatItemList.EndUpdate();
            }
        }

        GridFormatRule CurrentCondition {
            get {
                if(FormatItemList.SelectedItem != null)
                    return ((ItemExpressionFormatRule)FormatItemList.SelectedItem).GridFormatRule;
                return null;
            }
        }

        void ShowEditor(GridFormatRule condition) {
            FormatConditionRuleExpression rule = condition.Rule as FormatConditionRuleExpression;
            if(rule == null) return;
            using(ExpressionEditorForm form = new FormatRuleExpressionEditorForm(rule, null, rule.Expression)) {
                form.StartPosition = FormStartPosition.CenterParent;
                if(form.ShowDialog(this) == DialogResult.OK) {
                    rule.Expression = form.Expression;
                }
            }
        }

        void ShowEditor() {
            if(CurrentCondition == null) return;
            ShowEditor(CurrentCondition);
            FormatItemList.Refresh();
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            ShowEditor();
        }

        private void FormatItemList_MouseDoubleClick(object sender, MouseEventArgs e) {
            ShowEditor();
        }

        void SelectObjectUpdate() {
            if(update) return;
            EnableButtons();
            init = true;
            if(CurrentCondition == null) {
                propertyGrid1.Enabled = false;
                propertyGrid1.PropertyGrid.SelectedObject = null;
                panelControl1.Visible = false;

            }
            else {
                propertyGrid1.Enabled = true;
                propertyGrid1.PropertyGrid.SelectedObject = ((FormatConditionRuleExpression)CurrentCondition.Rule).Appearance;
                panelControl1.Visible = true;
                checkEdit1.Checked = CurrentCondition.ApplyToRow;
                imageComboBoxEdit1.EditValue = CurrentCondition.Column;
            }
            init = false;
        }

        private void FormatItemList_SelectedIndexChanged(object sender, EventArgs e) {
            SelectObjectUpdate();
        }

        private void EnableButtons() {
            barButtonItem2.Enabled = CurrentCondition != null;
            barButtonItem3.Visibility = CurrentCondition == null ? BarItemVisibility.Never : BarItemVisibility.Always;
        }

        bool update = false;

        //<FormatItemList>
        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e) {
            update = true;
            if(CurrentCondition == null) return;
            currentView.FormatRules.Remove(CurrentCondition);
            FormatItemList.Items.RemoveAt(FormatItemList.SelectedIndex);
            update = false;
            SelectObjectUpdate();
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e) {
            GridFormatRule condition = new GridFormatRule();
            condition.Rule = new FormatConditionRuleExpression();
            currentView.FormatRules.Add(condition);
            int index = FormatItemList.Items.Count;
            InitConditions();
            FormatItemList.SelectedIndex = index;
            ShowEditor();
        }
        //</FormatItemList>
        //<checkEdit1>
        private void checkEdit1_CheckedChanged(object sender, EventArgs e) {
            if(CurrentCondition == null || init) return;
            CurrentCondition.ApplyToRow = checkEdit1.Checked;
        }
        //</checkEdit1>
        private void imageComboBoxEdit1_SelectedIndexChanged(object sender, EventArgs e) {
            if(CurrentCondition == null || init) return;
            GridColumn col = imageComboBoxEdit1.EditValue as GridColumn;
            CurrentCondition.Column = col;
        }
    }
}
