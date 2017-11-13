namespace DevExpress.Docs.Demos
{
    partial class PdfFileAttachmentDemo
	{
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            this.viewerPanel = new DevExpress.XtraEditors.PanelControl();
            this.panelDocument = new System.Windows.Forms.Panel();
            this.pdfViewer = new DevExpress.XtraPdfViewer.PdfViewer();
            this.panelOptions = new System.Windows.Forms.Panel();
            this.deleteButton = new DevExpress.XtraEditors.SimpleButton();
            this.buttonAttachFile = new DevExpress.XtraEditors.SimpleButton();
            this.lbFileAttachments = new DevExpress.XtraEditors.ListBoxControl();
            this.labelFileAttachments = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.viewerPanel)).BeginInit();
            this.viewerPanel.SuspendLayout();
            this.panelDocument.SuspendLayout();
            this.panelOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lbFileAttachments)).BeginInit();
            this.SuspendLayout();
            // 
            // viewerPanel
            // 
            this.viewerPanel.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.viewerPanel.Controls.Add(this.panelDocument);
            this.viewerPanel.Controls.Add(this.panelOptions);
            this.viewerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewerPanel.Location = new System.Drawing.Point(0, 0);
            this.viewerPanel.Name = "viewerPanel";
            this.viewerPanel.Size = new System.Drawing.Size(737, 564);
            this.viewerPanel.TabIndex = 7;
            // 
            // panelDocument
            // 
            this.panelDocument.Controls.Add(this.pdfViewer);
            this.panelDocument.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDocument.Location = new System.Drawing.Point(0, 0);
            this.panelDocument.Name = "panelDocument";
            this.panelDocument.Size = new System.Drawing.Size(529, 564);
            this.panelDocument.TabIndex = 6;
            // 
            // pdfViewer
            // 
            this.pdfViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pdfViewer.Location = new System.Drawing.Point(0, 0);
            this.pdfViewer.Name = "pdfViewer";
            this.pdfViewer.NavigationPaneInitialVisibility = DevExpress.XtraPdfViewer.PdfNavigationPaneVisibility.Collapsed;
            this.pdfViewer.NavigationPaneWidth = 300;
            this.pdfViewer.ReadOnly = true;
            this.pdfViewer.Size = new System.Drawing.Size(529, 564);
            this.pdfViewer.TabIndex = 6;
            this.pdfViewer.TabStop = false;
            this.pdfViewer.ZoomMode = DevExpress.XtraPdfViewer.PdfZoomMode.FitToWidth;
            // 
            // panelOptions
            // 
            this.panelOptions.Controls.Add(this.deleteButton);
            this.panelOptions.Controls.Add(this.buttonAttachFile);
            this.panelOptions.Controls.Add(this.lbFileAttachments);
            this.panelOptions.Controls.Add(this.labelFileAttachments);
            this.panelOptions.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelOptions.Location = new System.Drawing.Point(529, 0);
            this.panelOptions.Name = "panelOptions";
            this.panelOptions.Size = new System.Drawing.Size(208, 564);
            this.panelOptions.TabIndex = 6;
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(18, 289);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(30);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(172, 23);
            this.deleteButton.TabIndex = 26;
            this.deleteButton.Text = "Delete Selected File";
            this.deleteButton.Click += new System.EventHandler(this.OnDeleteFile);
            // 
            // buttonAttachFile
            // 
            this.buttonAttachFile.Location = new System.Drawing.Point(18, 18);
            this.buttonAttachFile.Margin = new System.Windows.Forms.Padding(30);
            this.buttonAttachFile.Name = "buttonAttachFile";
            this.buttonAttachFile.Size = new System.Drawing.Size(172, 23);
            this.buttonAttachFile.TabIndex = 1;
            this.buttonAttachFile.Text = "Attach File...";
            this.buttonAttachFile.Click += new System.EventHandler(this.OnAttachFile);
            // 
            // lbFileAttachments
            // 
            this.lbFileAttachments.DisplayMember = "FileName";
            this.lbFileAttachments.ItemAutoHeight = true;
            this.lbFileAttachments.Location = new System.Drawing.Point(18, 84);
            this.lbFileAttachments.Name = "lbFileAttachments";
            this.lbFileAttachments.Size = new System.Drawing.Size(172, 195);
            this.lbFileAttachments.TabIndex = 0;
            // 
            // labelFileAttachments
            // 
            this.labelFileAttachments.Location = new System.Drawing.Point(18, 61);
            this.labelFileAttachments.Name = "labelFileAttachments";
            this.labelFileAttachments.Size = new System.Drawing.Size(84, 13);
            this.labelFileAttachments.TabIndex = 25;
            this.labelFileAttachments.Text = "File Attachments:";
            // 
            // PdfFileAttachmentDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.viewerPanel);
            this.Name = "PdfFileAttachmentDemo";
            this.Size = new System.Drawing.Size(737, 564);
            ((System.ComponentModel.ISupportInitialize)(this.viewerPanel)).EndInit();
            this.viewerPanel.ResumeLayout(false);
            this.panelDocument.ResumeLayout(false);
            this.panelOptions.ResumeLayout(false);
            this.panelOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lbFileAttachments)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

        private XtraEditors.PanelControl viewerPanel;
        private System.Windows.Forms.Panel panelOptions;
        private System.Windows.Forms.Panel panelDocument;
        private XtraPdfViewer.PdfViewer pdfViewer;
        private XtraEditors.LabelControl labelFileAttachments;
        private XtraEditors.ListBoxControl lbFileAttachments;
        private XtraEditors.SimpleButton buttonAttachFile;
        private XtraEditors.SimpleButton deleteButton;

    }
}
