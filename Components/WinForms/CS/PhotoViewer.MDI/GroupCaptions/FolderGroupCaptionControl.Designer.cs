namespace PhotoViewer {
    partial class FolderGroupCaptionControl {
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
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.Appearance.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameLabel.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.nameLabel.Size = new System.Drawing.Size(117, 27);
            this.nameLabel.Text = "FolderName";
            // 
            // dataLabel
            // 
            this.dataLabel.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataLabel.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.dataLabel.Size = new System.Drawing.Size(72, 17);
            // 
            // groupIcon
            // 
            this.groupIcon.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupIcon.Appearance.Image = global::PhotoViewer.Properties.Resources.Folder_32x32;
            this.groupIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            // 
            // editLabel
            // 
            this.editLabel.Appearance.Image = global::PhotoViewer.Properties.Resources.Edit_16x16;
            this.editLabel.Location = new System.Drawing.Point(213, 22);
            this.editLabel.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.editLabel.Size = new System.Drawing.Size(21, 20);
            this.editLabel.Visible = false;
            // 
            // removeLabel
            // 
            this.removeLabel.Appearance.Image = global::PhotoViewer.Properties.Resources.RemoveAlbum_16x16;
            this.removeLabel.Location = new System.Drawing.Point(249, 22);
            this.removeLabel.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.removeLabel.Size = new System.Drawing.Size(21, 20);
            this.removeLabel.ToolTip = "Remove folder from list";
            // 
            // collageLabel
            // 
            this.collageLabel.Appearance.Image = global::PhotoViewer.Properties.Resources.Collage_16x16;
            this.collageLabel.Location = new System.Drawing.Point(298, 22);
            this.collageLabel.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.collageLabel.Size = new System.Drawing.Size(21, 20);
            this.collageLabel.ToolTip = "Make collage";
            // 
            // slideshowLabel
            // 
            this.slideshowLabel.Appearance.Image = global::PhotoViewer.Properties.Resources.Slideshow_16x16;
            this.slideshowLabel.Location = new System.Drawing.Point(334, 22);
            this.slideshowLabel.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.slideshowLabel.Size = new System.Drawing.Size(21, 20);
            this.slideshowLabel.ToolTip = "Make slideshow";
            // 
            // filmLabel
            // 
            this.filmLabel.Appearance.Image = global::PhotoViewer.Properties.Resources.Film_16x16;
            this.filmLabel.Location = new System.Drawing.Point(370, 22);
            this.filmLabel.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.filmLabel.Size = new System.Drawing.Size(21, 20);
            this.filmLabel.ToolTip = "Make film";
            // 
            // separatorLabel
            // 
            this.separatorLabel.Location = new System.Drawing.Point(285, 27);
            this.separatorLabel.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.separatorLabel.Size = new System.Drawing.Size(4, 16);
            // 
            // FolderGroupCaptionControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "FolderGroupCaptionControl";
            this.Size = new System.Drawing.Size(410, 69);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}
