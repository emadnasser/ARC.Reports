namespace DevExpress.XtraGrid.Demos {
    partial class ValidationControl {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ValidationControl));
            this.label1 = new System.Windows.Forms.Label();
            this.imageComboBoxEdit1 = new DevExpress.XtraEditors.ImageComboBoxEdit();
            this.spinEdit1 = new DevExpress.XtraEditors.SpinEdit();
            this.imageComboBoxEdit2 = new DevExpress.XtraEditors.ImageComboBoxEdit();
            this.spinEdit2 = new DevExpress.XtraEditors.SpinEdit();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imageComboBoxEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageComboBoxEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEdit2.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // imageComboBoxEdit1
            // 
            resources.ApplyResources(this.imageComboBoxEdit1, "imageComboBoxEdit1");
            this.imageComboBoxEdit1.Name = "imageComboBoxEdit1";
            this.imageComboBoxEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("imageComboBoxEdit1.Properties.Buttons"))))});
            this.imageComboBoxEdit1.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem(resources.GetString("imageComboBoxEdit1.Properties.Items"), ((object)(resources.GetObject("imageComboBoxEdit1.Properties.Items1"))), ((int)(resources.GetObject("imageComboBoxEdit1.Properties.Items2")))),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem(resources.GetString("imageComboBoxEdit1.Properties.Items3"), ((object)(resources.GetObject("imageComboBoxEdit1.Properties.Items4"))), ((int)(resources.GetObject("imageComboBoxEdit1.Properties.Items5")))),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem(resources.GetString("imageComboBoxEdit1.Properties.Items6"), ((object)(resources.GetObject("imageComboBoxEdit1.Properties.Items7"))), ((int)(resources.GetObject("imageComboBoxEdit1.Properties.Items8")))),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem(resources.GetString("imageComboBoxEdit1.Properties.Items9"), ((object)(resources.GetObject("imageComboBoxEdit1.Properties.Items10"))), ((int)(resources.GetObject("imageComboBoxEdit1.Properties.Items11")))),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem(resources.GetString("imageComboBoxEdit1.Properties.Items12"), ((object)(resources.GetObject("imageComboBoxEdit1.Properties.Items13"))), ((int)(resources.GetObject("imageComboBoxEdit1.Properties.Items14"))))});
            this.imageComboBoxEdit1.SelectedIndexChanged += new System.EventHandler(this.imageComboBoxEdit1_SelectedIndexChanged);
            // 
            // spinEdit1
            // 
            resources.ApplyResources(this.spinEdit1, "spinEdit1");
            this.spinEdit1.Name = "spinEdit1";
            this.spinEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.spinEdit1.Properties.ValidateOnEnterKey = true;
            this.spinEdit1.EditValueChanged += new System.EventHandler(this.spinEdit_EditValueChanged);
            // 
            // imageComboBoxEdit2
            // 
            resources.ApplyResources(this.imageComboBoxEdit2, "imageComboBoxEdit2");
            this.imageComboBoxEdit2.Name = "imageComboBoxEdit2";
            this.imageComboBoxEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("imageComboBoxEdit2.Properties.Buttons"))))});
            this.imageComboBoxEdit2.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem(resources.GetString("imageComboBoxEdit2.Properties.Items"), ((object)(resources.GetObject("imageComboBoxEdit2.Properties.Items1"))), ((int)(resources.GetObject("imageComboBoxEdit2.Properties.Items2")))),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem(resources.GetString("imageComboBoxEdit2.Properties.Items3"), ((object)(resources.GetObject("imageComboBoxEdit2.Properties.Items4"))), ((int)(resources.GetObject("imageComboBoxEdit2.Properties.Items5")))),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem(resources.GetString("imageComboBoxEdit2.Properties.Items6"), ((object)(resources.GetObject("imageComboBoxEdit2.Properties.Items7"))), ((int)(resources.GetObject("imageComboBoxEdit2.Properties.Items8"))))});
            this.imageComboBoxEdit2.SelectedIndexChanged += new System.EventHandler(this.imageComboBoxEdit2_SelectedIndexChanged);
            // 
            // spinEdit2
            // 
            resources.ApplyResources(this.spinEdit2, "spinEdit2");
            this.spinEdit2.Name = "spinEdit2";
            this.spinEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.spinEdit2.Properties.ValidateOnEnterKey = true;
            this.spinEdit2.EditValueChanged += new System.EventHandler(this.spinEdit_EditValueChanged);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // ValidationControl
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.spinEdit2);
            this.Controls.Add(this.imageComboBoxEdit2);
            this.Controls.Add(this.spinEdit1);
            this.Controls.Add(this.imageComboBoxEdit1);
            this.Controls.Add(this.label1);
            this.Name = "ValidationControl";
            ((System.ComponentModel.ISupportInitialize)(this.imageComboBoxEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageComboBoxEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEdit2.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        public DevExpress.XtraEditors.ImageComboBoxEdit imageComboBoxEdit1;
        public DevExpress.XtraEditors.SpinEdit spinEdit1;
        public DevExpress.XtraEditors.ImageComboBoxEdit imageComboBoxEdit2;
        public DevExpress.XtraEditors.SpinEdit spinEdit2;
        private System.Windows.Forms.Label label2;
        private System.ComponentModel.Container components = null;
    }
}
