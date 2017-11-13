using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

using System.Windows.Forms;


namespace DevExpress.XtraVerticalGrid.Demos {
	public partial class Options : DevExpress.XtraVerticalGrid.Demos.PropertiesBase {
		public Options() {
			// This call is required by the Windows Form Designer.
			InitializeComponent();
            TutorialInfo.WhatsThisCodeFile = "CS\\VertGridMainDemo\\Modules\\Options.cs;";
            TutorialInfo.WhatsThisXMLFile = "DevExpress.XtraVerticalGrid.Demos.CodeInfo.Options.xml";
			panel1.BringToFront();
			// TODO: Add any initialization after the InitializeComponent call
		}

        //<propertyGridControl1>
        /*
        ~Note: the following code is set at design time and listed here for demonstration purposes.
         
        this.propertyGridControl1.DefaultEditors.AddRange(new DevExpress.XtraVerticalGrid.Rows.DefaultEditor[] {
            new DevExpress.XtraVerticalGrid.Rows.DefaultEditor(typeof(bool), this.repositoryItemCheckEdit1)});
            this.propertyGridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.propertyGridControl1.Location = new System.Drawing.Point(8, 4);
            this.propertyGridControl1.Name = "propertyGridControl1";
            this.propertyGridControl1.OptionsMenu.EnableContextMenu = true;
            this.propertyGridControl1.RecordWidth = 72;
            this.propertyGridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1});
            this.propertyGridControl1.RowHeaderWidth = 128;
            this.propertyGridControl1.Rows.AddRange(new DevExpress.XtraVerticalGrid.Rows.BaseRow[] {
            this.categoryAppearance,
            this.categoryBehavior,
            this.categoryLayout,
            this.categoryOptions});
            this.propertyGridControl1.Size = new System.Drawing.Size(280, 384);
            this.propertyGridControl1.TabIndex = 0;
        */
        //</propertyGridControl1>

		protected override void AdjustmentGrid() {
			base.AdjustmentGrid();
            this.propertyGridControl1.SelectedObject = CurrentGrid;
		}
	}
}

