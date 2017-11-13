namespace DevExpress.ApplicationUI.Demos {
    partial class AlertInfoProperties {
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlertInfoProperties));
            this.icbImage = new DevExpress.XtraEditors.ImageComboBoxEdit();
            this.imageCollection1 = new DevExpress.Utils.ImageCollection(this.components);
            this.imageCollection2 = new DevExpress.Utils.ImageCollection(this.components);
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtCaption = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtText = new DevExpress.XtraEditors.MemoEdit();
            this.txtHotTrackedText = new DevExpress.XtraEditors.MemoEdit();
            this.lcHotTrackedText = new DevExpress.XtraEditors.LabelControl();
            this.ceShowAnimatedImage = new DevExpress.XtraEditors.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.icbImage.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCaption.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtText.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHotTrackedText.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceShowAnimatedImage.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // icbImage
            // 
            this.icbImage.EditValue = 0;
            this.icbImage.Location = new System.Drawing.Point(107, 11);
            this.icbImage.Name = "icbImage";
            this.icbImage.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.icbImage.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Scheduler", 0, 0),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Note", 1, 1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Address", 2, 2),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Department", 3, 3),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Products", 4, 4),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("<None>", 5, -1)});
            this.icbImage.Properties.LargeImages = this.imageCollection1;
            this.icbImage.Properties.SmallImages = this.imageCollection2;
            this.icbImage.ShowToolTips = false;
            this.icbImage.Size = new System.Drawing.Size(175, 20);
            this.icbImage.TabIndex = 0;
            // 
            // imageCollection1
            // 
            this.imageCollection1.ImageSize = new System.Drawing.Size(32, 32);
            this.imageCollection1.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection1.ImageStream")));
            // 
            // imageCollection2
            // 
            this.imageCollection2.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection2.ImageStream")));
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(14, 14);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(34, 13);
            this.labelControl2.TabIndex = 8;
            this.labelControl2.Text = "Image:";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(14, 64);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(41, 13);
            this.labelControl1.TabIndex = 10;
            this.labelControl1.Text = "Caption:";
            // 
            // txtCaption
            // 
            this.txtCaption.Location = new System.Drawing.Point(107, 61);
            this.txtCaption.Name = "txtCaption";
            this.txtCaption.Size = new System.Drawing.Size(175, 20);
            this.txtCaption.TabIndex = 2;
            this.txtCaption.EditValueChanged += new System.EventHandler(this.txtCaption_EditValueChanged);
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(14, 92);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(26, 13);
            this.labelControl3.TabIndex = 12;
            this.labelControl3.Text = "Text:";
            // 
            // txtText
            // 
            this.txtText.Location = new System.Drawing.Point(107, 90);
            this.txtText.Name = "txtText";
            this.txtText.Size = new System.Drawing.Size(175, 94);
            this.txtText.TabIndex = 3;
            this.txtText.EditValueChanged += new System.EventHandler(this.txtText_EditValueChanged);
            // 
            // txtHotTrackedText
            // 
            this.txtHotTrackedText.Location = new System.Drawing.Point(107, 196);
            this.txtHotTrackedText.Name = "txtHotTrackedText";
            this.txtHotTrackedText.Size = new System.Drawing.Size(175, 89);
            this.txtHotTrackedText.TabIndex = 4;
            this.txtHotTrackedText.EditValueChanged += new System.EventHandler(this.txtSelectedText_EditValueChanged);
            // 
            // lcHotTrackedText
            // 
            this.lcHotTrackedText.Location = new System.Drawing.Point(14, 198);
            this.lcHotTrackedText.Name = "lcHotTrackedText";
            this.lcHotTrackedText.Size = new System.Drawing.Size(87, 13);
            this.lcHotTrackedText.TabIndex = 14;
            this.lcHotTrackedText.Text = "Hot Tracked Text:";
            // 
            // ceShowAnimatedImage
            // 
            this.ceShowAnimatedImage.Location = new System.Drawing.Point(105, 36);
            this.ceShowAnimatedImage.Name = "ceShowAnimatedImage";
            this.ceShowAnimatedImage.Properties.Caption = "Show Animated Image";
            this.ceShowAnimatedImage.Size = new System.Drawing.Size(177, 19);
            this.ceShowAnimatedImage.TabIndex = 1;
            this.ceShowAnimatedImage.CheckedChanged += new System.EventHandler(this.ceShowAnimatedImage_CheckedChanged);
            // 
            // AlertInfoProperties
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ceShowAnimatedImage);
            this.Controls.Add(this.txtHotTrackedText);
            this.Controls.Add(this.lcHotTrackedText);
            this.Controls.Add(this.txtText);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.txtCaption);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.icbImage);
            this.Controls.Add(this.labelControl2);
            this.Name = "AlertInfoProperties";
            this.Size = new System.Drawing.Size(336, 298);
            ((System.ComponentModel.ISupportInitialize)(this.icbImage.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCaption.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtText.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHotTrackedText.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceShowAnimatedImage.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.ImageComboBoxEdit icbImage;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtCaption;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.MemoEdit txtText;
        private DevExpress.XtraEditors.MemoEdit txtHotTrackedText;
        private DevExpress.XtraEditors.LabelControl lcHotTrackedText;
        private DevExpress.Utils.ImageCollection imageCollection1;
        private DevExpress.Utils.ImageCollection imageCollection2;
        private DevExpress.XtraEditors.CheckEdit ceShowAnimatedImage;
    }
}
