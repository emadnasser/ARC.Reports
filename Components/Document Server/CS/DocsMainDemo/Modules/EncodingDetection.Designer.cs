using System;
using DevExpress.XtraEditors;

namespace DevExpress.Docs.Demos {
	partial class EncodingDetection {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)	{
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.txtNoDetection = new DevExpress.XtraEditors.MemoEdit();
            this.txtDetection = new DevExpress.XtraEditors.MemoEdit();
            this.cbLanguage = new DevExpress.XtraEditors.ComboBoxEdit();
            this.lblAutoDetect = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.lblEncoding = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtNoDetection.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDetection.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbLanguage.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNoDetection
            // 
            this.txtNoDetection.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNoDetection.Location = new System.Drawing.Point(3, 65);
            this.txtNoDetection.Name = "txtNoDetection";
            this.txtNoDetection.Size = new System.Drawing.Size(689, 250);
            this.txtNoDetection.TabIndex = 1;
            // 
            // txtDetection
            // 
            this.txtDetection.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDetection.Location = new System.Drawing.Point(3, 351);
            this.txtDetection.Name = "txtDetection";
            this.txtDetection.Size = new System.Drawing.Size(689, 250);
            this.txtDetection.TabIndex = 1;
            // 
            // cbLanguage
            // 
            this.cbLanguage.Location = new System.Drawing.Point(83, 9);
            this.cbLanguage.Name = "cbLanguage";
            this.cbLanguage.Properties.AutoHeight = false;
            this.cbLanguage.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbLanguage.Properties.DropDownRows = 8;
            this.cbLanguage.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbLanguage.Size = new System.Drawing.Size(113, 20);
            this.cbLanguage.TabIndex = 2;
            this.cbLanguage.SelectedIndexChanged += new System.EventHandler(this.comboBoxEdit1_SelectedIndexChanged);
            this.cbLanguage.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(this.cbLanguage_EditValueChanging);
            // 
            // lblAutoDetect
            // 
            this.lblAutoDetect.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAutoDetect.Location = new System.Drawing.Point(3, 332);
            this.lblAutoDetect.Name = "lblAutoDetect";
            this.lblAutoDetect.Size = new System.Drawing.Size(103, 13);
            this.lblAutoDetect.TabIndex = 3;
            this.lblAutoDetect.Text = "Encoding Detector";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(3, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(74, 13);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "Load text from ";
            // 
            // lblEncoding
            // 
            this.lblEncoding.Location = new System.Drawing.Point(224, 332);
            this.lblEncoding.Name = "lblEncoding";
            this.lblEncoding.Size = new System.Drawing.Size(0, 13);
            this.lblEncoding.TabIndex = 8;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl2.Location = new System.Drawing.Point(165, 332);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(53, 13);
            this.labelControl2.TabIndex = 10;
            this.labelControl2.Text = "Encoding:";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl3.Location = new System.Drawing.Point(4, 45);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(125, 13);
            this.labelControl3.TabIndex = 11;
            this.labelControl3.Text = "No Encoding Detection";
            // 
            // EncodingDetection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.lblEncoding);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.lblAutoDetect);
            this.Controls.Add(this.cbLanguage);
            this.Controls.Add(this.txtDetection);
            this.Controls.Add(this.txtNoDetection);
            this.Name = "EncodingDetection";
            this.Size = new System.Drawing.Size(719, 624);
            ((System.ComponentModel.ISupportInitialize)(this.txtNoDetection.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDetection.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbLanguage.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

        private MemoEdit txtNoDetection;
        private MemoEdit txtDetection;
        private ComboBoxEdit cbLanguage;
        private LabelControl lblAutoDetect;
        private LabelControl labelControl1;
        private LabelControl lblEncoding;
        private LabelControl labelControl2;
        private LabelControl labelControl3;


    }
}
