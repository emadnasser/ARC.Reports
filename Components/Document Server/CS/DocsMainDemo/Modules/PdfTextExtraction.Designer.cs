namespace DevExpress.Docs.Demos
{
	partial class PdfTextExtraction
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
            DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, null, true, true, typeof(System.Windows.Forms.UserControl));
            this.buttonOpen = new DevExpress.XtraEditors.SimpleButton();
            this.buttonExtractText = new DevExpress.XtraEditors.SimpleButton();
            this.pdfViewer = new DevExpress.XtraPdfViewer.PdfViewer();
            this.viewerPanel = new DevExpress.XtraEditors.PanelControl();
            this.headerPanel = new DevExpress.XtraEditors.PanelControl();
            this.labelSeparationLine = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.viewerPanel)).BeginInit();
            this.viewerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.headerPanel)).BeginInit();
            this.headerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonOpen
            // 
            this.buttonOpen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOpen.Location = new System.Drawing.Point(543, 15);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(110, 23);
            this.buttonOpen.TabIndex = 0;
            this.buttonOpen.Text = "Open...";
            this.buttonOpen.Click += new System.EventHandler(this.OnButtonOpenClick);
            // 
            // buttonExtractText
            // 
            this.buttonExtractText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonExtractText.Location = new System.Drawing.Point(659, 15);
            this.buttonExtractText.Name = "buttonExtractText";
            this.buttonExtractText.Size = new System.Drawing.Size(110, 23);
            this.buttonExtractText.TabIndex = 1;
            this.buttonExtractText.Text = "Extract text...";
            this.buttonExtractText.Click += new System.EventHandler(this.OnButtonExtractClick);
            // 
            // pdfViewer
            // 
            this.pdfViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pdfViewer.Location = new System.Drawing.Point(0, 0);
            this.pdfViewer.Name = "pdfViewer";
            this.pdfViewer.NavigationPaneInitialVisibility = DevExpress.XtraPdfViewer.PdfNavigationPaneVisibility.Hidden;
            this.pdfViewer.Size = new System.Drawing.Size(784, 485);
            this.pdfViewer.TabIndex = 2;
            this.pdfViewer.TabStop = false;
            this.pdfViewer.ZoomMode = DevExpress.XtraPdfViewer.PdfZoomMode.FitToWidth;
            this.pdfViewer.DocumentChanged += new DevExpress.XtraPdfViewer.PdfDocumentChangedEventHandler(this.OnDocumentChanged);
            // 
            // viewerPanel
            // 
            this.viewerPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.viewerPanel.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.viewerPanel.Controls.Add(this.pdfViewer);
            this.viewerPanel.Location = new System.Drawing.Point(0, 53);
            this.viewerPanel.Name = "viewerPanel";
            this.viewerPanel.Size = new System.Drawing.Size(784, 485);
            this.viewerPanel.TabIndex = 2;
            // 
            // headerPanel
            // 
            this.headerPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.headerPanel.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.headerPanel.Controls.Add(this.labelSeparationLine);
            this.headerPanel.Controls.Add(this.buttonOpen);
            this.headerPanel.Controls.Add(this.buttonExtractText);
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(784, 53);
            this.headerPanel.TabIndex = 0;
            // 
            // labelSeparationLine
            // 
            this.labelSeparationLine.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelSeparationLine.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.labelSeparationLine.LineVisible = true;
            this.labelSeparationLine.Location = new System.Drawing.Point(0, 50);
            this.labelSeparationLine.Name = "labelSeparationLine";
            this.labelSeparationLine.Size = new System.Drawing.Size(784, 3);
            this.labelSeparationLine.TabIndex = 3;
            // 
            // PdfTextExtraction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.headerPanel);
            this.Controls.Add(this.viewerPanel);
            this.Name = "PdfTextExtraction";
            this.Size = new System.Drawing.Size(784, 538);
            ((System.ComponentModel.ISupportInitialize)(this.viewerPanel)).EndInit();
            this.viewerPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.headerPanel)).EndInit();
            this.headerPanel.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		#endregion

        private XtraEditors.SimpleButton buttonOpen;
        private XtraEditors.SimpleButton buttonExtractText;
        private XtraPdfViewer.PdfViewer pdfViewer;
        private XtraEditors.PanelControl viewerPanel;
        private XtraEditors.PanelControl headerPanel;
        private XtraEditors.LabelControl labelSeparationLine;
	}
}
