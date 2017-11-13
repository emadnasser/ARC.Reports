namespace DevExpress.Docs.Demos
{
    partial class PdfDocumentCreationAPI
	{
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            this.viewerPanel = new DevExpress.XtraEditors.PanelControl();
            this.pdfViewer = new DevExpress.XtraPdfViewer.PdfViewer();
            this.buttonCreateDocument = new DevExpress.XtraEditors.SimpleButton();
            this.buttonSave = new DevExpress.XtraEditors.SimpleButton();
            this.panelHeader = new DevExpress.XtraEditors.PanelControl();
            this.labelSeparationLine = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.viewerPanel)).BeginInit();
            this.viewerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelHeader)).BeginInit();
            this.panelHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // viewerPanel
            // 
            this.viewerPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.viewerPanel.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.viewerPanel.Controls.Add(this.pdfViewer);
            this.viewerPanel.Location = new System.Drawing.Point(0, 53);
            this.viewerPanel.Margin = new System.Windows.Forms.Padding(0);
            this.viewerPanel.Name = "viewerPanel";
            this.viewerPanel.Size = new System.Drawing.Size(737, 514);
            this.viewerPanel.TabIndex = 3;
            // 
            // pdfViewer
            // 
            this.pdfViewer.DetachStreamAfterLoadComplete = true;
            this.pdfViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pdfViewer.Location = new System.Drawing.Point(0, 0);
            this.pdfViewer.Margin = new System.Windows.Forms.Padding(0);
            this.pdfViewer.Name = "pdfViewer";
            this.pdfViewer.NavigationPaneInitialVisibility = DevExpress.XtraPdfViewer.PdfNavigationPaneVisibility.Collapsed;
            this.pdfViewer.ReadOnly = true;
            this.pdfViewer.Size = new System.Drawing.Size(737, 514);
            this.pdfViewer.TabIndex = 3;
            this.pdfViewer.TabStop = false;
            this.pdfViewer.ZoomMode = DevExpress.XtraPdfViewer.PdfZoomMode.FitToWidth;
            // 
            // buttonCreateDocument
            // 
            this.buttonCreateDocument.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCreateDocument.Location = new System.Drawing.Point(496, 15);
            this.buttonCreateDocument.Name = "buttonCreateDocument";
            this.buttonCreateDocument.Size = new System.Drawing.Size(110, 23);
            this.buttonCreateDocument.TabIndex = 0;
            this.buttonCreateDocument.Text = "Create Document";
            this.buttonCreateDocument.Click += new System.EventHandler(this.OnButtonCreateDocumentClick);
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSave.Enabled = false;
            this.buttonSave.Location = new System.Drawing.Point(612, 15);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(110, 23);
            this.buttonSave.TabIndex = 1;
            this.buttonSave.Text = "Save...";
            this.buttonSave.Click += new System.EventHandler(this.OnSaveButtonClick);
            // 
            // panelHeader
            // 
            this.panelHeader.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelHeader.Controls.Add(this.labelSeparationLine);
            this.panelHeader.Controls.Add(this.buttonCreateDocument);
            this.panelHeader.Controls.Add(this.buttonSave);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(737, 53);
            this.panelHeader.TabIndex = 0;
            // 
            // labelSeparationLine
            // 
            this.labelSeparationLine.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelSeparationLine.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.labelSeparationLine.LineVisible = true;
            this.labelSeparationLine.Location = new System.Drawing.Point(0, 50);
            this.labelSeparationLine.Name = "labelSeparationLine";
            this.labelSeparationLine.Size = new System.Drawing.Size(737, 3);
            this.labelSeparationLine.TabIndex = 2;
            // 
            // PdfDocumentCreationAPI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.viewerPanel);
            this.Name = "PdfDocumentCreationAPI";
            this.Size = new System.Drawing.Size(737, 564);
            ((System.ComponentModel.ISupportInitialize)(this.viewerPanel)).EndInit();
            this.viewerPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelHeader)).EndInit();
            this.panelHeader.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		#endregion

        private XtraEditors.PanelControl viewerPanel;
        private XtraPdfViewer.PdfViewer pdfViewer;
        private XtraEditors.SimpleButton buttonCreateDocument;
        private XtraEditors.SimpleButton buttonSave;
        private XtraEditors.PanelControl panelHeader;
        private XtraEditors.LabelControl labelSeparationLine;

    }
}
