namespace DevExpress.XtraSpreadsheet.Demos {
    partial class CustomDrawModule {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomDrawModule));
            this.panel1 = new DevExpress.XtraEditors.PanelControl();
            this.ceDisplayFCallouts = new DevExpress.XtraEditors.CheckEdit();
            this.cуHighlightErrors = new DevExpress.XtraEditors.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.panel1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ceDisplayFCallouts.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cуHighlightErrors.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panel1.Controls.Add(this.ceDisplayFCallouts);
            this.panel1.Controls.Add(this.cуHighlightErrors);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // ceDisplayFCallouts
            // 
            resources.ApplyResources(this.ceDisplayFCallouts, "ceDisplayFCallouts");
            this.ceDisplayFCallouts.Name = "ceDisplayFCallouts";
            this.ceDisplayFCallouts.Properties.Caption = resources.GetString("ceDisplayFCallouts.Properties.Caption");
            this.ceDisplayFCallouts.CheckedChanged += new System.EventHandler(this.checkEdit_CheckedChanged);
            // 
            // cуHighlightErrors
            // 
            resources.ApplyResources(this.cуHighlightErrors, "cуHighlightErrors");
            this.cуHighlightErrors.Name = "cуHighlightErrors";
            this.cуHighlightErrors.Properties.Caption = resources.GetString("cуHighlightErrors.Properties.Caption");
            this.cуHighlightErrors.CheckedChanged += new System.EventHandler(this.checkEdit_CheckedChanged);
            // 
            // CustomDrawModule
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "CustomDrawModule";
            ((System.ComponentModel.ISupportInitialize)(this.panel1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ceDisplayFCallouts.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cуHighlightErrors.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private XtraEditors.PanelControl panel1;
        private XtraEditors.CheckEdit ceDisplayFCallouts;
        private XtraEditors.CheckEdit cуHighlightErrors;
    }
}
