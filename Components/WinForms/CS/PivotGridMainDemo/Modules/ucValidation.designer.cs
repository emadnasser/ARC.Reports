namespace DevExpress.XtraPivotGrid.Demos.Modules {
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
            this.label1 = new DevExpress.XtraEditors.LabelControl();
            this.imageComboBoxEdit1 = new DevExpress.XtraEditors.ImageComboBoxEdit();
            this.spinEdit1 = new DevExpress.XtraEditors.SpinEdit();
            this.spinEdit2 = new DevExpress.XtraEditors.SpinEdit();
            this.label2 = new DevExpress.XtraEditors.LabelControl();
            this.imageComboBoxEdit2 = new DevExpress.XtraEditors.ImageComboBoxEdit();
            ((System.ComponentModel.ISupportInitialize)(this.imageComboBoxEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageComboBoxEdit2.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.label1.Appearance.Font = new System.Drawing.Font("Tahoma", 8F);
            this.label1.Location = new System.Drawing.Point(10, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // imageComboBoxEdit1
            // 
            this.imageComboBoxEdit1.EditValue = 0;
            this.imageComboBoxEdit1.Location = new System.Drawing.Point(173, 10);
            this.imageComboBoxEdit1.Name = "imageComboBoxEdit1";
            this.imageComboBoxEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.imageComboBoxEdit1.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("is greater than", 0, -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("is greater than or equal to", 1, -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("is less than", 2, -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("is less than or equal to", 3, -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("does not equal", 4, -1)});
            this.imageComboBoxEdit1.Size = new System.Drawing.Size(167, 20);
            this.imageComboBoxEdit1.TabIndex = 1;
            this.imageComboBoxEdit1.SelectedIndexChanged += new System.EventHandler(this.imageComboBoxEdit1_SelectedIndexChanged);
            // 
            // spinEdit1
            // 
            this.spinEdit1.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinEdit1.Location = new System.Drawing.Point(348, 10);
            this.spinEdit1.Name = "spinEdit1";
            this.spinEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.spinEdit1.Properties.ValidateOnEnterKey = true;
            this.spinEdit1.Size = new System.Drawing.Size(64, 20);
            this.spinEdit1.TabIndex = 2;
            this.spinEdit1.EditValueChanged += new System.EventHandler(this.spinEdit_EditValueChanged);
            // 
            // spinEdit2
            // 
            this.spinEdit2.EditValue = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.spinEdit2.Location = new System.Drawing.Point(585, 10);
            this.spinEdit2.Name = "spinEdit2";
            this.spinEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.spinEdit2.Properties.ValidateOnEnterKey = true;
            this.spinEdit2.Size = new System.Drawing.Size(64, 20);
            this.spinEdit2.TabIndex = 6;
            this.spinEdit2.EditValueChanged += new System.EventHandler(this.spinEdit_EditValueChanged);
            // 
            // label2
            // 
            this.label2.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(420, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "and:";
            // 
            // imageComboBoxEdit2
            // 
            this.imageComboBoxEdit2.EditValue = 2;
            this.imageComboBoxEdit2.Location = new System.Drawing.Point(447, 10);
            this.imageComboBoxEdit2.Name = "imageComboBoxEdit2";
            this.imageComboBoxEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.imageComboBoxEdit2.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("", 0, -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("is less than", 2, -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("is less than or equal to", 3, -1)});
            this.imageComboBoxEdit2.Size = new System.Drawing.Size(132, 20);
            this.imageComboBoxEdit2.TabIndex = 4;
            this.imageComboBoxEdit2.SelectedIndexChanged += new System.EventHandler(this.imageComboBoxEdit2_SelectedIndexChanged);
            // 
            // ValidationControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.imageComboBoxEdit2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.spinEdit2);
            this.Controls.Add(this.spinEdit1);
            this.Controls.Add(this.imageComboBoxEdit1);
            this.Controls.Add(this.label1);
            this.Name = "ValidationControl";
            this.Size = new System.Drawing.Size(723, 30);
            ((System.ComponentModel.ISupportInitialize)(this.imageComboBoxEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageComboBoxEdit2.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.LabelControl label1;
        public DevExpress.XtraEditors.ImageComboBoxEdit imageComboBoxEdit1;
		public DevExpress.XtraEditors.SpinEdit spinEdit1;
        public DevExpress.XtraEditors.SpinEdit spinEdit2;
        private DevExpress.XtraEditors.LabelControl label2;
        private System.ComponentModel.Container components = null;
		public DevExpress.XtraEditors.ImageComboBoxEdit imageComboBoxEdit2;
    }
}
