namespace DevExpress.Docs.Demos
{
    partial class PdfFormFlattening
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
			if (disposing) {
                fileHelper.Dispose();
                documentProcessor.Dispose();
                if (components != null)
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
            this.panelDocument = new System.Windows.Forms.Panel();
            this.pdfViewer = new DevExpress.XtraPdfViewer.PdfViewer();
            this.panelOptions = new System.Windows.Forms.Panel();
            this.buttonLoadDemoDocument = new DevExpress.XtraEditors.SimpleButton();
            this.docOperationsPanel = new DevExpress.XtraEditors.PanelControl();
            this.buttonOpen = new DevExpress.XtraEditors.SimpleButton();
            this.buttonSave = new DevExpress.XtraEditors.SimpleButton();
            this.buttonFlattenFormFields = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.viewerPanel)).BeginInit();
            this.viewerPanel.SuspendLayout();
            this.panelDocument.SuspendLayout();
            this.panelOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.docOperationsPanel)).BeginInit();
            this.docOperationsPanel.SuspendLayout();
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
            this.panelDocument.Location = new System.Drawing.Point(0, 53);
            this.panelDocument.Name = "panelDocument";
            this.panelDocument.Size = new System.Drawing.Size(737, 511);
            this.panelDocument.TabIndex = 8;
            // 
            // pdfViewer
            // 
            this.pdfViewer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pdfViewer.DetachStreamAfterLoadComplete = true;
            this.pdfViewer.Location = new System.Drawing.Point(0, 0);
            this.pdfViewer.Name = "pdfViewer";
            this.pdfViewer.NavigationPaneInitialVisibility = DevExpress.XtraPdfViewer.PdfNavigationPaneVisibility.Hidden;
            this.pdfViewer.Size = new System.Drawing.Size(737, 511);
            this.pdfViewer.TabIndex = 6;
            this.pdfViewer.TabStop = false;
            this.pdfViewer.ZoomMode = DevExpress.XtraPdfViewer.PdfZoomMode.FitToWidth;
            this.pdfViewer.DocumentClosing += new DevExpress.XtraPdfViewer.PdfDocumentClosingEventHandler(this.DocumentClosing);
            // 
            // panelOptions
            // 
            this.panelOptions.Controls.Add(this.buttonLoadDemoDocument);
            this.panelOptions.Controls.Add(this.docOperationsPanel);
            this.panelOptions.Controls.Add(this.buttonFlattenFormFields);
            this.panelOptions.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelOptions.Location = new System.Drawing.Point(0, 0);
            this.panelOptions.Name = "panelOptions";
            this.panelOptions.Size = new System.Drawing.Size(737, 53);
            this.panelOptions.TabIndex = 6;
            // 
            // buttonLoadDemoDocument
            // 
            this.buttonLoadDemoDocument.Location = new System.Drawing.Point(187, 14);
            this.buttonLoadDemoDocument.Margin = new System.Windows.Forms.Padding(30);
            this.buttonLoadDemoDocument.Name = "buttonLoadDemoDocument";
            this.buttonLoadDemoDocument.Size = new System.Drawing.Size(162, 23);
            this.buttonLoadDemoDocument.TabIndex = 46;
            this.buttonLoadDemoDocument.Text = "Load Demo Document";
            this.buttonLoadDemoDocument.Click += new System.EventHandler(this.LoadDemoDocumentClick);
            // 
            // docOperationsPanel
            // 
            this.docOperationsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.docOperationsPanel.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.docOperationsPanel.Controls.Add(this.buttonOpen);
            this.docOperationsPanel.Controls.Add(this.buttonSave);
            this.docOperationsPanel.Location = new System.Drawing.Point(498, 14);
            this.docOperationsPanel.Name = "docOperationsPanel";
            this.docOperationsPanel.Size = new System.Drawing.Size(226, 23);
            this.docOperationsPanel.TabIndex = 45;
            // 
            // buttonOpen
            // 
            this.buttonOpen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOpen.Location = new System.Drawing.Point(0, 0);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(110, 23);
            this.buttonOpen.TabIndex = 3;
            this.buttonOpen.Text = "Open...";
            this.buttonOpen.Click += new System.EventHandler(this.OpenClick);
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSave.Location = new System.Drawing.Point(116, 0);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(110, 23);
            this.buttonSave.TabIndex = 4;
            this.buttonSave.Text = "Save...";
            this.buttonSave.Click += new System.EventHandler(this.SaveClick);
            // 
            // buttonFlattenFormFields
            // 
            this.buttonFlattenFormFields.Location = new System.Drawing.Point(15, 14);
            this.buttonFlattenFormFields.Margin = new System.Windows.Forms.Padding(30);
            this.buttonFlattenFormFields.Name = "buttonFlattenFormFields";
            this.buttonFlattenFormFields.Size = new System.Drawing.Size(162, 23);
            this.buttonFlattenFormFields.TabIndex = 44;
            this.buttonFlattenFormFields.Text = "Flatten Form Fields";
            this.buttonFlattenFormFields.Click += new System.EventHandler(this.FlattenFormFieldsClick);
            // 
            // PdfFormFlattening
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.viewerPanel);
            this.Name = "PdfFormFlattening";
            this.Size = new System.Drawing.Size(737, 564);
            ((System.ComponentModel.ISupportInitialize)(this.viewerPanel)).EndInit();
            this.viewerPanel.ResumeLayout(false);
            this.panelDocument.ResumeLayout(false);
            this.panelOptions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.docOperationsPanel)).EndInit();
            this.docOperationsPanel.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		#endregion

        private XtraEditors.PanelControl viewerPanel;
        private System.Windows.Forms.Panel panelOptions;
        private System.Windows.Forms.Panel panelDocument;
        private XtraPdfViewer.PdfViewer pdfViewer;
        private XtraEditors.SimpleButton buttonFlattenFormFields;
        private XtraEditors.PanelControl docOperationsPanel;
        private XtraEditors.SimpleButton buttonOpen;
        private XtraEditors.SimpleButton buttonSave;
        private XtraEditors.SimpleButton buttonLoadDemoDocument;

    }
}
