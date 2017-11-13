namespace DevExpress.Docs.Demos {
    partial class Decompression {

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
        private void InitializeComponent() {
            this.tlZipContent = new DevExpress.XtraTreeList.TreeList();
            this.colName = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colUncompressedSize = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colType = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colCompressedSize = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.buttonEdit1 = new DevExpress.XtraEditors.ButtonEdit();
            this.textPreview = new DevExpress.XtraRichEdit.RichEditControl();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.tlZipContent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tlZipContent
            // 
            this.tlZipContent.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.colName,
            this.colUncompressedSize,
            this.colType,
            this.colCompressedSize});
            this.tlZipContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlZipContent.Location = new System.Drawing.Point(0, 0);
            this.tlZipContent.Name = "tlZipContent";
            this.tlZipContent.OptionsBehavior.Editable = false;
            this.tlZipContent.Size = new System.Drawing.Size(778, 272);
            this.tlZipContent.TabIndex = 0;
            // 
            // colName
            // 
            this.colName.Caption = "Name";
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 0;
            // 
            // colUncompressedSize
            // 
            this.colUncompressedSize.Caption = "Uncompressed size";
            this.colUncompressedSize.FieldName = "UncompressedSize";
            this.colUncompressedSize.Name = "colUncompressedSize";
            this.colUncompressedSize.Visible = true;
            this.colUncompressedSize.VisibleIndex = 1;
            // 
            // colType
            // 
            this.colType.Name = "colType";
            // 
            // colCompressedSize
            // 
            this.colCompressedSize.Caption = "Compressed size";
            this.colCompressedSize.FieldName = "CompressedSize";
            this.colCompressedSize.Name = "colCompressedSize";
            this.colCompressedSize.Visible = true;
            this.colCompressedSize.VisibleIndex = 2;
            // 
            // buttonEdit1
            // 
            this.buttonEdit1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonEdit1.Location = new System.Drawing.Point(3, 6);
            this.buttonEdit1.Name = "buttonEdit1";
            this.buttonEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.buttonEdit1.Size = new System.Drawing.Size(778, 20);
            this.buttonEdit1.TabIndex = 2;
            this.buttonEdit1.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.buttonEdit1_ButtonClick);
            this.buttonEdit1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.buttonEdit1_KeyUp);
            // 
            // textPreview
            // 
            this.textPreview.ActiveViewType = DevExpress.XtraRichEdit.RichEditViewType.Simple;
            this.textPreview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textPreview.Location = new System.Drawing.Point(0, 0);
            this.textPreview.Name = "textPreview";
            this.textPreview.Options.Fields.UseCurrentCultureDateTimeFormat = false;
            this.textPreview.Options.MailMerge.KeepLastParagraph = false;
            this.textPreview.ReadOnly = true;
            this.textPreview.Size = new System.Drawing.Size(778, 120);
            this.textPreview.TabIndex = 7;
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainerControl1.Horizontal = false;
            this.splitContainerControl1.Location = new System.Drawing.Point(3, 32);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.tlZipContent);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.pictureBox1);
            this.splitContainerControl1.Panel2.Controls.Add(this.textPreview);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(778, 397);
            this.splitContainerControl1.SplitterPosition = 272;
            this.splitContainerControl1.TabIndex = 8;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(778, 120);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // Decompression
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainerControl1);
            this.Controls.Add(this.buttonEdit1);
            this.Name = "Decompression";
            ((System.ComponentModel.ISupportInitialize)(this.tlZipContent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private XtraTreeList.TreeList tlZipContent;
        private XtraTreeList.Columns.TreeListColumn colName;
        private XtraTreeList.Columns.TreeListColumn colType;
        private XtraTreeList.Columns.TreeListColumn colUncompressedSize;
        private XtraTreeList.Columns.TreeListColumn colCompressedSize;
        private XtraEditors.ButtonEdit buttonEdit1;
        private XtraRichEdit.RichEditControl textPreview;
        private XtraEditors.SplitContainerControl splitContainerControl1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
