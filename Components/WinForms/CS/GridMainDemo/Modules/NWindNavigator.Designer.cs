using DevExpress.Export;

namespace DevExpress.XtraGrid.Demos {
    partial class NWindNavigator {
        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing) {
            if(disposing) {
                if(components != null) {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        #region Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.pnlNavigator = new DevExpress.XtraEditors.PanelControl();
            this.controlNavigator1 = new DevExpress.XtraEditors.ControlNavigator();
            this.sbPreview = new DevExpress.XtraEditors.SimpleButton();
            this.sbCollapse = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlNavigator)).BeginInit();
            this.pnlNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 73);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(742, 404);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.ViewRegistered += new DevExpress.XtraGrid.ViewOperationEventHandler(this.gridControl1_ViewRegistered);
            // 
            // gridView1
            // 
            this.gridView1.DetailHeight = 150;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsDetail.EnableDetailToolTip = true;
            this.gridView1.OptionsDetail.ShowDetailTabs = false;
            this.gridView1.OptionsPrint.AutoWidth = false;
            this.gridView1.OptionsPrint.PrintDetails = true;
            this.gridView1.OptionsPrint.UsePrintStyles = true;
            this.gridView1.OptionsSelection.InvertSelection = true;
            this.gridView1.OptionsView.ShowColumnHeaders = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.OptionsView.ShowIndicator = false;
            this.gridView1.OptionsClipboard.ClipboardMode = ClipboardMode.Formatted;
            // 
            // pnlNavigator
            // 
            this.pnlNavigator.Controls.Add(this.controlNavigator1);
            this.pnlNavigator.Controls.Add(this.sbPreview);
            this.pnlNavigator.Controls.Add(this.sbCollapse);
            this.pnlNavigator.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlNavigator.Location = new System.Drawing.Point(0, 0);
            this.pnlNavigator.Name = "pnlNavigator";
            this.pnlNavigator.Size = new System.Drawing.Size(742, 65);
            this.pnlNavigator.TabIndex = 4;
            // 
            // controlNavigator1
            // 
            this.controlNavigator1.Location = new System.Drawing.Point(8, 40);
            this.controlNavigator1.Name = "controlNavigator1";
            this.controlNavigator1.NavigatableControl = this.gridControl1;
            this.controlNavigator1.ShowToolTips = true;
            this.controlNavigator1.Size = new System.Drawing.Size(539, 19);
            this.controlNavigator1.TabIndex = 0;
            this.controlNavigator1.Text = "controlNavigator1";
            this.controlNavigator1.TextLocation = DevExpress.XtraEditors.NavigatorButtonsTextLocation.Center;
            // 
            // sbPreview
            // 
            this.sbPreview.Location = new System.Drawing.Point(160, 8);
            this.sbPreview.Name = "sbPreview";
            this.sbPreview.Size = new System.Drawing.Size(112, 24);
            this.sbPreview.TabIndex = 2;
            this.sbPreview.Text = "Print Preview";
            this.sbPreview.Click += new System.EventHandler(this.sbPreview_Click);
            // 
            // sbCollapse
            // 
            this.sbCollapse.Location = new System.Drawing.Point(8, 8);
            this.sbCollapse.Name = "sbCollapse";
            this.sbCollapse.Size = new System.Drawing.Size(136, 24);
            this.sbCollapse.TabIndex = 1;
            this.sbCollapse.Text = "Collapse All Details";
            this.sbCollapse.Click += new System.EventHandler(this.sbCollapse_Click);
            // 
            // panelControl1
            // 
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 65);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(742, 8);
            this.panelControl1.TabIndex = 5;
            // 
            // NWindNavigator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.pnlNavigator);
            this.Name = "NWindNavigator";
            this.Size = new System.Drawing.Size(742, 477);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlNavigator)).EndInit();
            this.pnlNavigator.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.ComponentModel.IContainer components = null;
        private DevExpress.XtraEditors.PanelControl pnlNavigator;
        private DevExpress.XtraEditors.SimpleButton sbPreview;
        private DevExpress.XtraEditors.SimpleButton sbCollapse;
        private DevExpress.XtraEditors.ControlNavigator controlNavigator1;
        private DevExpress.XtraEditors.PanelControl panelControl1;

    }
}
