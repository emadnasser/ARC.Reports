using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraEditors.Controls;
using DevExpress.Data.PivotGrid;

namespace DevExpress.XtraPivotGrid.Demos.Modules {
	public partial class HitInfo : DevExpress.XtraPivotGrid.Demos.TutorialControl {
		public HitInfo() {
			// This call is required by the Windows Form Designer.
			CreateWaitDialog();
			InitializeComponent();

            TutorialInfo.WhatsThisCodeFile = "CS\\PivotGridMainDemo\\Modules\\HitInfo.cs";
            TutorialInfo.WhatsThisXMLFile = "DevExpress.XtraPivotGrid.Demos.CodeInfo.HitInfo.xml";

			// TODO: Add any initialization after the InitializeComponent call
		}

		public override PivotGridControl ViewOptionsControl { get { return pivotGridControl1; }}
		public override PivotGridControl ExportControl { get { return pivotGridControl1; }}

		private void HitInfo_Load(object sender, System.EventArgs e) {
			pivotGridControl1.DataSource = GetNWindData("SalesPerson");
			pivotGridControl1.HeaderImages = HeadersImageList;
			pivotGridControl1.ValueImages = CategoryImageList;
			fieldSalesPerson.ImageIndex = 0;
			fieldCountry.CollapseValue("UK");
			cellInfo1.Dock = DockStyle.Fill;
			valueInfo1.Dock = DockStyle.Fill;
			headersAreaInfo1.Dock = DockStyle.Fill;
			ShowHitInfo(null);
		}


		private void pivotGridControl1_FieldValueImageIndex(object sender, DevExpress.XtraPivotGrid.PivotFieldImageIndexEventArgs e) {
			if(e.Field == fieldCategoryName && Comparer.Equals(e.ValueType, PivotGridValueType.Value))
				e.ImageIndex = GetCategoryIndexByName(e.Value);
		}

        //<pivotGridControl1>
		private void pivotGridControl1_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e) {
			ShowHitInfo(pivotGridControl1.CalcHitInfo(new Point(e.X, e.Y)));
		}

		private void pivotGridControl1_MouseLeave(object sender, System.EventArgs e) {
			ShowHitInfo(pivotGridControl1.CalcHitInfo(new Point(-1, -1)));
		}

        //<panelControl1>
		void ShowHitInfo(PivotGridHitInfo info) {
			cellInfo1.Init(info);
			valueInfo1.Init(info);
			headersAreaInfo1.Init(info);
			if(info == null) return;
			lbHitTest.Text = info.HitTest.ToString();
		}
        //</panelControl1>
        //</pivotGridControl1>

        private void paddingPanel_Paint(object sender, PaintEventArgs e) {

        }
	}
}

