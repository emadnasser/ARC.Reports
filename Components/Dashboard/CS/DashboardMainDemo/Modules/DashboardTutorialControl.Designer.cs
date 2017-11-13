namespace DashboardMainDemo.Modules {
    partial class DashboardTutorialControl {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing) {
                if(components != null)
                    components.Dispose();
            }
            base.Dispose(disposing);
            if(disposing)
                DisposeDashboard();
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.panelHeader = new DevExpress.XtraEditors.PanelControl();
            this.btnEditDashboard = new DevExpress.XtraEditors.SimpleButton();
            this.dashboardViewer = new DevExpress.DashboardWin.DashboardViewer(this.components);
            this.panelFooter = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelHeader)).BeginInit();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dashboardViewer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelFooter)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelHeader.Controls.Add(this.btnEditDashboard);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(724, 32);
            this.panelHeader.TabIndex = 0;
            // 
            // btnEditDashboard
            // 
            this.btnEditDashboard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditDashboard.Location = new System.Drawing.Point(644, 0);
            this.btnEditDashboard.Name = "btnEditDashboard";
            this.btnEditDashboard.Size = new System.Drawing.Size(75, 23);
            this.btnEditDashboard.TabIndex = 0;
            this.btnEditDashboard.Text = "Edit";
            this.btnEditDashboard.Click += new System.EventHandler(this.btnEditDashboard_Click);
            // 
            // dashboardViewer
            // 
            this.dashboardViewer.AllowPrintDashboardItems = true;
            this.dashboardViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dashboardViewer.Location = new System.Drawing.Point(0, 32);
            this.dashboardViewer.Name = "dashboardViewer";
            this.dashboardViewer.Size = new System.Drawing.Size(724, 382);
            this.dashboardViewer.TabIndex = 0;
            // 
            // panelFooter
            // 
            this.panelFooter.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFooter.Location = new System.Drawing.Point(0, 414);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Size = new System.Drawing.Size(724, 45);
            this.panelFooter.TabIndex = 2;
            this.panelFooter.Visible = false;
            // 
            // DashboardTutorialControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dashboardViewer);
            this.Controls.Add(this.panelFooter);
            this.Controls.Add(this.panelHeader);
            this.Name = "DashboardTutorialControl";
            this.Size = new System.Drawing.Size(724, 459);
            ((System.ComponentModel.ISupportInitialize)(this.panelHeader)).EndInit();
            this.panelHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dashboardViewer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelFooter)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelHeader;
        private DevExpress.XtraEditors.SimpleButton btnEditDashboard;
        private DevExpress.DashboardWin.DashboardViewer dashboardViewer;
        protected DevExpress.XtraEditors.PanelControl panelFooter;

    }
}
