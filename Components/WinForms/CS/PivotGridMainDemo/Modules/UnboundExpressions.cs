using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using DevExpress.XtraEditors.Controls;
using System.Collections.Generic;
using DevExpress.Utils.Menu;
using DevExpress.Data;

namespace DevExpress.XtraPivotGrid.Demos.Modules {
	public partial class UnboundExpressions : DevExpress.XtraPivotGrid.Demos.TutorialControl {
        public UnboundExpressions() {
			// This call is required by the Windows Form Designer.
			CreateWaitDialog();
			InitializeComponent();

            TutorialInfo.WhatsThisCodeFile = "CS\\PivotGridMainDemo\\Modules\\UnboundExpressions.cs";
            TutorialInfo.WhatsThisXMLFile = "DevExpress.XtraPivotGrid.Demos.CodeInfo.UnboundExpressions.xml";
			// TODO: Add any initialization after the InitializeComponent call
		}
		public override PivotGridControl ViewOptionsControl { get { return pivotGridControl1; } }
		public override PivotGridControl ExportControl { get { return pivotGridControl1; } }

		private void UnboundColumns_Load(object sender, System.EventArgs e) {
			pivotGridControl1.DataSource = GetNWindData("SalesPerson");
            icbSalesPerson.SelectedIndex = 0;
			pivotGridControl1.HeaderImages = HeadersImageList;
            fieldSalesPerson.ImageIndex = 0;
            ResetFieldHeadersFont();
            pivotGridControl1.BestFit();
		}

        void ResetFieldHeadersFont() {
            foreach(PivotGridField field in pivotGridControl1.Fields) {
                if(IsFieldUnboundExpression(field))
                    field.Appearance.Header.Font = new Font(field.Appearance.Header.Font, FontStyle.Bold);
                else
                    field.Appearance.Header.Font = new Font(field.Appearance.Header.Font, FontStyle.Regular);
            }
        }

        private bool IsFieldValueExpression(PivotGridField field) {
            if(IsFieldUnboundExpression(field) && field.Area != PivotArea.DataArea)
                return true;
            return false;
        }

        private bool IsFieldUnboundExpression(PivotGridField field) {
            if(field != null && field.UnboundType != UnboundColumnType.Bound)
                return true;
            return false;
        }

        private bool IsFieldSummaryExpression(PivotGridField field) {
            if(IsFieldUnboundExpression(field) && field.Area == PivotArea.DataArea)
                return true;
            return false;
        }

        private PivotGridField hoverField;
        private PivotGridField HoverField {
            get { return hoverField; }
            set {
                if(hoverField == value)
                    return;
                hoverField = value;
                if(hoverField == null || hoverField.Area == PivotArea.DataArea)
                    pivotGridControl1.Invalidate();
            }
        }
        private object hoverFieldValue;
        private object HoverFieldValue {
            get { return hoverFieldValue; }
            set {
                if(hoverFieldValue == value)
                    return;
                hoverFieldValue = value;
                pivotGridControl1.Invalidate();
            }
        }

        private PivotGridField removeField;
        private void RemoveField(object sender, EventArgs e) {
            if(removeField != null)
                pivotGridControl1.Fields.Remove(removeField);
        }
        //<icbSalesPerson>
        private void icb_SelectedIndexChanged(object sender, System.EventArgs e) {
            fieldSalesPerson.UnboundExpression = icbSalesPerson.EditValue.ToString();
        }
        //</icbSalesPerson>

        private void pivotGridControl1_CustomDrawFieldValue(object sender, PivotCustomDrawFieldValueEventArgs e) {
            if(HoverField != null && e.Field == HoverField && (e.Field.Area == PivotArea.DataArea || e.Value == HoverFieldValue)) {
                e.Appearance.Font = new Font(e.Appearance.Font, FontStyle.Underline);
                e.Appearance.ForeColor = Color.Red;
            }
            else {
                if(IsFieldUnboundExpression(e.Field)) {
                    e.Appearance.Font = new Font(e.Appearance.Font, FontStyle.Underline);
                    e.Appearance.ForeColor = Color.Blue;
                } else {
					e.DefaultDraw();
                }
            }
        }

        private void pivotGridControl1_MouseMove(object sender, MouseEventArgs e) {
            PivotGridHitInfo info = pivotGridControl1.CalcHitInfo(new Point(e.X, e.Y));
            if(info.ValueInfo != null && IsFieldUnboundExpression(info.ValueInfo.Field)) {
                HoverField = info.ValueInfo.Field;
                if(HoverField.Area == PivotArea.RowArea)
                    HoverFieldValue = info.ValueInfo.Value;
                else
                    HoverFieldValue = null;
                pivotGridControl1.Cursor = Cursors.Hand;
            } else {
                HoverField = null;
                HoverFieldValue = null;
                pivotGridControl1.Cursor = Cursors.Default;
            }
        }

        private void pivotGridControl1_MouseClick(object sender, MouseEventArgs e) {
            if(e.Button != MouseButtons.Left) 
                return;
            PivotGridHitInfo info = pivotGridControl1.CalcHitInfo(new Point(e.X, e.Y));
            if(info.ValueInfo != null && IsFieldUnboundExpression(info.ValueInfo.Field))
                pivotGridControl1.ShowUnboundExpressionEditor(info.ValueInfo.Field);
        }

        private void pivotGridControl1_PopupMenuShowing(object sender, PopupMenuShowingEventArgs e) {
            if(e.HitInfo.ValueInfo != null && IsFieldSummaryExpression(e.HitInfo.ValueInfo.Field)) {
                removeField = e.HitInfo.ValueInfo.Field;
                DXMenuItem item = new DXMenuItem("Remove this bonus", RemoveField);
                item.BeginGroup = true;
                e.Menu.Items.Add(item);
            }
        }

        private void pivotGridControl1_FieldUnboundExpressionChanged(object sender, PivotFieldEventArgs e) {
            e.Field.BestFit();
        }
        //<btnAddBonus>
        private void btnAddBonus_Click(object sender, EventArgs e) {
            using(AddNewBonus addNewBonus = new AddNewBonus()) {
                addNewBonus.PivotGrid = pivotGridControl1;
                if(addNewBonus.ShowDialog() == DialogResult.OK) {

                }
            }
        }
        //</btnAddBonus>
    }
}

