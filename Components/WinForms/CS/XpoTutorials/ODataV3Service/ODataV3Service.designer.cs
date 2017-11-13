namespace DevExpress.Xpo.Demos {
    partial class ODataV3Service {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing) {
                if(components != null) {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.gclODataV3ServiceMain = new DevExpress.XtraGrid.GridControl();
            this.gvlODataV3Service = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.sbViewMetadata = new DevExpress.XtraEditors.SimpleButton();
            this.sbStartService = new DevExpress.XtraEditors.SimpleButton();
            this.sbEmployees = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gclODataV3ServiceMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvlODataV3Service)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gclODataV3ServiceMain
            // 
            this.gclODataV3ServiceMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gclODataV3ServiceMain.Location = new System.Drawing.Point(0, 59);
            this.gclODataV3ServiceMain.MainView = this.gvlODataV3Service;
            this.gclODataV3ServiceMain.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gclODataV3ServiceMain.Name = "gclODataV3ServiceMain";
            this.gclODataV3ServiceMain.Size = new System.Drawing.Size(915, 586);
            this.gclODataV3ServiceMain.TabIndex = 2;
            this.gclODataV3ServiceMain.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvlODataV3Service});
            // 
            // gvlODataV3Service
            // 
            this.gvlODataV3Service.GridControl = this.gclODataV3ServiceMain;
            this.gvlODataV3Service.Name = "gvlODataV3Service";
            this.gvlODataV3Service.OptionsBehavior.Editable = false;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.sbViewMetadata);
            this.panelControl1.Controls.Add(this.sbStartService);
            this.panelControl1.Controls.Add(this.sbEmployees);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(915, 59);
            this.panelControl1.TabIndex = 3;
            // 
            // sbViewMetadata
            // 
            this.sbViewMetadata.Enabled = false;
            this.sbViewMetadata.Location = new System.Drawing.Point(288, 15);
            this.sbViewMetadata.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.sbViewMetadata.Name = "sbViewMetadata";
            this.sbViewMetadata.Size = new System.Drawing.Size(259, 26);
            this.sbViewMetadata.TabIndex = 8;
            this.sbViewMetadata.Text = "View the Service Metadata in browser";
            this.sbViewMetadata.Click += new System.EventHandler(this.sbViewMetadata_Click);
            // 
            // sbStartService
            // 
            this.sbStartService.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sbStartService.Location = new System.Drawing.Point(681, 15);
            this.sbStartService.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.sbStartService.Name = "sbStartService";
            this.sbStartService.Size = new System.Drawing.Size(215, 26);
            this.sbStartService.TabIndex = 7;
            this.sbStartService.Text = "Start the XPO OData V3 Service";
            this.sbStartService.Click += new System.EventHandler(this.sbStartService_Click);
            // 
            // sbEmployees
            // 
            this.sbEmployees.Enabled = false;
            this.sbEmployees.Location = new System.Drawing.Point(20, 15);
            this.sbEmployees.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.sbEmployees.Name = "sbEmployees";
            this.sbEmployees.Size = new System.Drawing.Size(262, 26);
            this.sbEmployees.TabIndex = 6;
            this.sbEmployees.Text = "Load Customers via the OData Service";
            this.sbEmployees.Click += new System.EventHandler(this.sbEmployees_Click);
            // 
            // ODataV3Service
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gclODataV3ServiceMain);
            this.Controls.Add(this.panelControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ODataV3Service";
            this.Size = new System.Drawing.Size(915, 645);
            ((System.ComponentModel.ISupportInitialize)(this.gclODataV3ServiceMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvlODataV3Service)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gclODataV3ServiceMain;
        private DevExpress.XtraGrid.Views.Grid.GridView gvlODataV3Service;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton sbEmployees;
        private DevExpress.XtraEditors.SimpleButton sbStartService;
        private XtraEditors.SimpleButton sbViewMetadata;
    }
}
