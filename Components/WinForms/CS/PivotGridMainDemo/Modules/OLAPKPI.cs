using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.IO;
using DevExpress.Utils;
using DevExpress.XtraPivotGrid.Data;

namespace DevExpress.XtraPivotGrid.Demos.Modules {
	public partial class OLAPKPI : DevExpress.XtraPivotGrid.Demos.TutorialControl {
		public OLAPKPI() {
			InitializeComponent();

            TutorialInfo.WhatsThisCodeFile = "CS\\PivotGridMainDemo\\Modules\\OLAPKPI.cs";
            TutorialInfo.WhatsThisXMLFile = "DevExpress.XtraPivotGrid.Demos.CodeInfo.OLAPKPI.xml";

			ddlStatusGraphics.Properties.Items.Clear();
			ddlStatusGraphics.Properties.Items.Add(PivotKPIGraphic.None);
			ddlStatusGraphics.Properties.Items.Add(PivotKPIGraphic.ServerDefined);
			ddlStatusGraphics.Properties.Items.Add(PivotKPIGraphic.Cylinder);
			ddlStatusGraphics.Properties.Items.Add(PivotKPIGraphic.Faces);
			ddlStatusGraphics.Properties.Items.Add(PivotKPIGraphic.Gauge);
			ddlStatusGraphics.Properties.Items.Add(PivotKPIGraphic.RoadSigns);
			ddlStatusGraphics.Properties.Items.Add(PivotKPIGraphic.Shapes);
			ddlStatusGraphics.Properties.Items.Add(PivotKPIGraphic.Thermometer);
			ddlStatusGraphics.Properties.Items.Add(PivotKPIGraphic.TrafficLights);
			ddlStatusGraphics.Properties.Items.Add(PivotKPIGraphic.VarianceArrow);
			ddlStatusGraphics.Properties.Items.Add(PivotKPIGraphic.ReversedCylinder);
			ddlStatusGraphics.Properties.Items.Add(PivotKPIGraphic.ReversedGauge);
			ddlStatusGraphics.Properties.Items.Add(PivotKPIGraphic.ReversedThermometer);
			ddlStatusGraphics.SelectedIndex = 1;

			ddlTrendGraphics.Properties.Items.Clear();
			ddlTrendGraphics.Properties.Items.Add(PivotKPIGraphic.None);
			ddlTrendGraphics.Properties.Items.Add(PivotKPIGraphic.ServerDefined);
			ddlTrendGraphics.Properties.Items.Add(PivotKPIGraphic.StandardArrow);
			ddlTrendGraphics.Properties.Items.Add(PivotKPIGraphic.StatusArrow);
			ddlTrendGraphics.Properties.Items.Add(PivotKPIGraphic.ReversedStatusArrow);
			ddlTrendGraphics.Properties.Items.Add(PivotKPIGraphic.Faces);
			ddlTrendGraphics.SelectedIndex = 1;

			panelError.Visible = false;            
			string cubeFile = Path.GetFullPath(FilesHelper.FindingFileName(Application.StartupPath, GetAdventureWorksFileName()));
			try {
                File.SetAttributes(cubeFile, FileAttributes.Normal);
				pivotGridControl.OLAPConnectionString = "Provider=msolap;Data Source=" + cubeFile + ";Initial Catalog=Adventure Works;Cube Name=Adventure Works;";
			} catch {
                pivotGridControl.OLAPConnectionString = null;
                panelError.Visible = true;
                pivotGridControl.Enabled = false;
                panelConnection.Enabled = false;
			}
            separator1.Visible = panelError.Visible;
		}
		string GetAdventureWorksFileName() {
			return "Data\\AdventureWorks.cub";
		}
		public override PivotGridControl ViewOptionsControl { get { return pivotGridControl; } }
		public override PivotGridControl ExportControl { get { return pivotGridControl; } }

        //<ddlStatusGraphics>
		void cbStatusGraphic_SelectedIndexChanged(object sender, EventArgs e) {
			if(panelError.Visible)
				return;
			pivotGridControl.Fields["[Measures].[Internet Revenue Status]"].KPIGraphic = (PivotKPIGraphic)ddlStatusGraphics.SelectedItem;
		}
        //</ddlStatusGraphics>

        //<ddlTrendGraphics>
		void cbTrendGraphic_SelectedIndexChanged(object sender, EventArgs e) {
			if(panelError.Visible)
				return;
			pivotGridControl.Fields["[Measures].[Internet Revenue Trend]"].KPIGraphic = (PivotKPIGraphic)ddlTrendGraphics.SelectedItem;
		}
        //</ddlTrendGraphics>
	}
}
