using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DevExpress.XtraPivotGrid.Demos.Modules {
	public partial class CustomGroupInterval : TutorialControl {
		public CustomGroupInterval() {
			CreateWaitDialog();
			InitializeComponent();

            TutorialInfo.WhatsThisCodeFile = "CS\\PivotGridMainDemo\\Modules\\CustomGroupInterval.cs";
            TutorialInfo.WhatsThisXMLFile = "DevExpress.XtraPivotGrid.Demos.CodeInfo.CustomGroupInterval.xml";
		}
		public override PivotGridControl ViewOptionsControl { get { return pivotGridControl; } }
		public override PivotGridControl ExportControl { get { return pivotGridControl; } }
		protected override void OnLoad(EventArgs e) {
			base.OnLoad(e);
			pivotGridControl.DataSource = GetNWindData("ProductReports");
			cbGroup.Properties.Items.Add(new cbItem("Group Products by First Characters", 0));
			cbGroup.Properties.Items.Add(new cbItem("Group Sales by Year and Quarter", 1));
			cbGroup.SelectedIndex = 0;
		}
		int SelectedDemo { get { return ((cbItem)cbGroup.SelectedItem).Value; } }
        //<cbGroup>
		protected void PivotGridControl_CustomGroupInterval(object sender, PivotCustomGroupIntervalEventArgs e) {
			switch(SelectedDemo) {
				case 0:
					if(!object.Equals(e.Field, pivotGridControl.Fields[0])) return;
					if(Convert.ToChar(e.Value.ToString()[0]) < 'F') {
						e.GroupValue = "A-E";
						return;
					}
					if(Convert.ToChar(e.Value.ToString()[0]) > 'E' && Convert.ToChar(e.Value.ToString()[0]) < 'T') {
						e.GroupValue = "F-S";
						return;
					}
					if(Convert.ToChar(e.Value.ToString()[0]) > 'S')
						e.GroupValue = "T-Z";

					break;
				case 1:
					if(!object.Equals(e.Field, pivotGridControl.Fields[3])) return;
					e.GroupValue = ((DateTime)e.Value).Year + " - " + ((((DateTime)e.Value).Month - 1) / 3 + 1).ToString();
					break;
			}
		}
        //</cbGroup>
		protected void cbGroup_SelectedIndexChanged(object sender, EventArgs e) {
			pivotGridControl.BeginUpdate();
			switch(SelectedDemo) {
				case 0:
					pivotGridControl.Fields[0].Visible = true;
					pivotGridControl.Fields[0].Caption = "Product Group";
					pivotGridControl.Fields[0].GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.Custom;
					pivotGridControl.Fields[4].Caption = "Year";
					pivotGridControl.Fields[4].GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateYear;

					pivotGridControl.Fields[3].Visible = false;
					pivotGridControl.Fields[3].GroupInterval = PivotGroupInterval.Default;
					break;
				case 1:
					pivotGridControl.Fields[3].Visible = true;
					pivotGridControl.Fields[3].Caption = "Year - Quarter";
					pivotGridControl.Fields[3].GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.Custom;
					pivotGridControl.Fields[3].AreaIndex = 0;
					pivotGridControl.Fields[4].Caption = "Shipped Date";
					pivotGridControl.Fields[4].GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.Default;

					pivotGridControl.Fields[0].Visible = false;
					pivotGridControl.Fields[0].GroupInterval = PivotGroupInterval.Default;
					break;
			}
			pivotGridControl.EndUpdate();
			pivotGridControl.CollapseAll();
		}
		class cbItem {
			public string Name;
			public int Value;
			public cbItem(string name, int value) {
				Name = name;
				Value = value;
			}
			public override string ToString() {
				return Name;
			}
		}
	}
}
