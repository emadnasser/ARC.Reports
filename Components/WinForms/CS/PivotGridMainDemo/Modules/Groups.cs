using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraEditors.Controls;
using DevExpress.Data.PivotGrid;

namespace DevExpress.XtraPivotGrid.Demos.Modules {
	public partial class Groups : DevExpress.XtraPivotGrid.Demos.TutorialControl {
		public Groups() {
			// This call is required by the Windows Form Designer.
			CreateWaitDialog();
			InitializeComponent();

            TutorialInfo.WhatsThisCodeFile = "CS\\PivotGridMainDemo\\Modules\\Groups.cs";
            TutorialInfo.WhatsThisXMLFile = "DevExpress.XtraPivotGrid.Demos.CodeInfo.Groups.xml";

			// TODO: Add any initialization after the InitializeComponent call
		}
		public override PivotGridControl ViewOptionsControl { get { return pivotGridControl1; } }
		public override PivotGridControl ExportControl { get { return pivotGridControl1; } }
		Color[] groupColors;

        //<pivotGridControl1>
		private void Groups_Load(object sender, System.EventArgs e) {
            UpdateGroupColors();
			pivotGridControl1.DataSource = GetNWindData("SalesPerson");
			pivotGridControl1.HeaderImages = HeadersImageList;
			pivotGridControl1.ValueImages = CategoryImageList;
			fieldExtendedPrice.ImageIndex = 3;
			fieldOrderDate1.ExpandedInFieldsGroup = false;
			fieldExtendedPrice.ExpandedInFieldsGroup = false;
			SetText(!isExpanded);
		}

        private void UpdateGroupColors() {
            this.groupColors = new Color[] { Green, Blue, Red };
        }

		private void pivotGridControl1_FieldValueImageIndex(object sender, DevExpress.XtraPivotGrid.PivotFieldImageIndexEventArgs e) {
			if(e.Field == fieldCategoryName && Comparer.Equals(e.ValueType, PivotGridValueType.Value))
				e.ImageIndex = GetCategoryIndexByName(e.Value);
		}
        //</pivotGridControl1>

        //<sbExpandCollapse>
		void GroupsExpandCollapse(bool expand) {
			pivotGridControl1.BeginUpdate();
			try {
				foreach(PivotGridGroup group in pivotGridControl1.Groups)
					foreach(PivotGridField field in group)
						field.ExpandedInFieldsGroup = expand;
			} finally {
				pivotGridControl1.EndUpdate();
			}
		}

		bool isExpanded = true;        
		private void sbExpand_Click(object sender, System.EventArgs e) {
			isExpanded = !isExpanded;
			SetText(!isExpanded);
			GroupsExpandCollapse(isExpanded);
		}        

		void SetText(bool expand) {
			if(expand) {
				sbExpandCollapse.Text = "Expand All Groups";
			} else {
				sbExpandCollapse.Text = "Collapse All Groups";
			}
		}
        //</sbExpandCollapse>
		
		private void pivotGridControl1_CustomDrawFieldHeader(object sender, DevExpress.XtraPivotGrid.PivotCustomDrawFieldHeaderEventArgs e) {
			e.Appearance.ForeColor = groupColors[e.Field.Group.Index];
		}

        protected override void OnStyleChanged() {
            base.OnStyleChanged();
            UpdateGroupColors();
        }
	}
}

