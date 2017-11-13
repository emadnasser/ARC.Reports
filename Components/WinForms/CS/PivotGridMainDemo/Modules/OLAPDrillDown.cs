using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraPivotGrid.Demos.Helpers;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace DevExpress.XtraPivotGrid.Demos.Modules {
	public partial class OLAPDrillDown : TutorialControl {
		public OLAPDrillDown() {
			CreateWaitDialog();
			InitializeComponent();

            TutorialInfo.WhatsThisCodeFile = "CS\\PivotGridMainDemo\\Modules\\OLAPDrillDown.cs";
            TutorialInfo.WhatsThisXMLFile = "DevExpress.XtraPivotGrid.Demos.CodeInfo.OLAPDrillDown.xml";

			bool success = OLAPConfigurator.CreateSampleOLAPConfiguration(pivotGridControl);

			controlPanel.Visible = !success;
			paddingPanel.Visible = !success;

			PivotGridField fieldCountry = pivotGridControl.Fields[OLAPConfigurator.CountryFieldName];
			if(fieldCountry != null) {
				fieldCountry.Visible = true;
				fieldCountry.Area = PivotArea.ColumnArea;
			}
		}
		public override PivotGridControl ViewOptionsControl { get { return pivotGridControl; } }
		public override PivotGridControl ExportControl { get { return pivotGridControl; } }
		protected override void OnLoad(EventArgs e) {
			base.OnLoad(e);
			pivotGridControl.ExpandAll();
			pivotGridControl.Cells.FocusedCell = new Point(1, 12);
		}
        //<pivotGridControl>
		private void pivotGridControl_CellDoubleClick(object sender, PivotCellEventArgs e) {
            try {
			ShowDrilldown(e.CreateDrillDownDataSource());
            } catch(Exception ex) {
                XtraMessageBox.Show(ex.Message);
            }
		}
		
		void ShowDrilldown(PivotDrillDownDataSource ds) {
			XtraForm form = new XtraForm();
			form.Text = "Drill Down Form";
			form.StartPosition = FormStartPosition.CenterParent;
			DataGridView grid = new DataGridView();
			grid.Parent = form;
			grid.Dock = DockStyle.Fill;
			grid.DataSource = ds;
            form.Icon = ResourceImageHelper.CreateIconFromResourcesEx("DevExpress.XtraPivotGrid.Demos.AppIcon.ico", typeof(OLAPDrillDown).Assembly);
			form.Width = 520;
			form.Height = 300;
			form.ShowDialog();
			form.Dispose();
		}
        //</pivotGridControl>

	}
}
