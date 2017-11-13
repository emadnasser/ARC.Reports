using System;
using DevExpress.XtraEditors;

namespace DevExpress.Docs.Demos {
    partial class SpreadsheetCellArtModule {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code
        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        /// 
        void InitializeComponent() {
            this.loadButton = new DevExpress.XtraEditors.SimpleButton();
            this.saveButton = new DevExpress.XtraEditors.SimpleButton();
            this.pictureEdit = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // loadButton
            // 
            this.loadButton.Location = new System.Drawing.Point(0, 0);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(85, 23);
            this.loadButton.TabIndex = 6;
            this.loadButton.Text = "Load Image...";
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(90, 0);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(90, 23);
            this.saveButton.TabIndex = 6;
            this.saveButton.Text = "Save in XLSX...";
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // pictureEdit
            // 
            this.pictureEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureEdit.Location = new System.Drawing.Point(0, 30);
            this.pictureEdit.Name = "pictureEdit";
            this.pictureEdit.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            this.pictureEdit.Size = new System.Drawing.Size(155, 119);
            this.pictureEdit.TabIndex = 7;
            // 
            // BitmapLoaderModule
            // 
            this.Controls.Add(this.loadButton);
            this.Controls.Add(this.pictureEdit);
            this.Controls.Add(this.saveButton);
            this.Name = "BitmapLoaderModule";
            this.Size = new System.Drawing.Size(158, 150);
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit.Properties)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        SimpleButton loadButton;
        SimpleButton saveButton;
        PictureEdit pictureEdit;
    }
}
