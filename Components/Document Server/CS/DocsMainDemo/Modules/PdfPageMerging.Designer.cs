namespace DevExpress.Docs.Demos
{
    partial class PdfPageMerging
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
            this.pdfViewer = new DevExpress.XtraPdfViewer.PdfViewer();
            this.buttonAppend = new DevExpress.XtraEditors.SimpleButton();
            this.buttonOpen = new DevExpress.XtraEditors.SimpleButton();
            this.saveButton = new DevExpress.XtraEditors.SimpleButton();
            this.newButton = new DevExpress.XtraEditors.SimpleButton();
            this.headerPanel = new DevExpress.XtraEditors.PanelControl();
            this.labelSeparationLine = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.viewerPanel)).BeginInit();
            this.viewerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.headerPanel)).BeginInit();
            this.headerPanel.SuspendLayout();
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
            this.viewerPanel.Name = "viewerPanel";
            this.viewerPanel.Size = new System.Drawing.Size(737, 511);
            this.viewerPanel.TabIndex = 5;
            // 
            // pdfViewer
            // 
            this.pdfViewer.DetachStreamAfterLoadComplete = true;
            this.pdfViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pdfViewer.Location = new System.Drawing.Point(0, 0);
            this.pdfViewer.Name = "pdfViewer";
            this.pdfViewer.NavigationPaneInitialVisibility = DevExpress.XtraPdfViewer.PdfNavigationPaneVisibility.Hidden;
            this.pdfViewer.ReadOnly = true;
            this.pdfViewer.Size = new System.Drawing.Size(737, 511);
            this.pdfViewer.TabIndex = 5;
            this.pdfViewer.TabStop = false;
            this.pdfViewer.ZoomMode = DevExpress.XtraPdfViewer.PdfZoomMode.FitToWidth;
            // 
            // buttonAppend
            // 
            this.buttonAppend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAppend.Location = new System.Drawing.Point(496, 15);
            this.buttonAppend.Name = "buttonAppend";
            this.buttonAppend.Size = new System.Drawing.Size(110, 23);
            this.buttonAppend.TabIndex = 2;
            this.buttonAppend.Text = "Append...";
            this.buttonAppend.Click += new System.EventHandler(this.OnButtonAppendClick);
            // 
            // buttonOpen
            // 
            this.buttonOpen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOpen.Location = new System.Drawing.Point(380, 15);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(110, 23);
            this.buttonOpen.TabIndex = 1;
            this.buttonOpen.Text = "Open...";
            this.buttonOpen.Click += new System.EventHandler(this.OnButtonOpenClick);
            // 
            // saveButton
            // 
            this.saveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.saveButton.Location = new System.Drawing.Point(612, 15);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(110, 23);
            this.saveButton.TabIndex = 3;
            this.saveButton.Text = "Save...";
            this.saveButton.Click += new System.EventHandler(this.OnSaveButtonClick);
            // 
            // newButton
            // 
            this.newButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.newButton.Location = new System.Drawing.Point(264, 15);
            this.newButton.Name = "newButton";
            this.newButton.Size = new System.Drawing.Size(110, 23);
            this.newButton.TabIndex = 0;
            this.newButton.Text = "New";
            this.newButton.Click += new System.EventHandler(this.OnNewButtonClick);
            // 
            // headerPanel
            // 
            this.headerPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.headerPanel.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.headerPanel.Controls.Add(this.labelSeparationLine);
            this.headerPanel.Controls.Add(this.buttonAppend);
            this.headerPanel.Controls.Add(this.buttonOpen);
            this.headerPanel.Controls.Add(this.saveButton);
            this.headerPanel.Controls.Add(this.newButton);
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(737, 53);
            this.headerPanel.TabIndex = 0;
            // 
            // labelSeparationLine
            // 
            this.labelSeparationLine.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelSeparationLine.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.labelSeparationLine.LineVisible = true;
            this.labelSeparationLine.Location = new System.Drawing.Point(0, 50);
            this.labelSeparationLine.Name = "labelSeparationLine";
            this.labelSeparationLine.Size = new System.Drawing.Size(737, 3);
            this.labelSeparationLine.TabIndex = 4;
            // 
            // PdfPageMerging
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.headerPanel);
            this.Controls.Add(this.viewerPanel);
            this.Name = "PdfPageMerging";
            this.Size = new System.Drawing.Size(737, 564);
            ((System.ComponentModel.ISupportInitialize)(this.viewerPanel)).EndInit();
            this.viewerPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.headerPanel)).EndInit();
            this.headerPanel.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		#endregion

        private XtraEditors.PanelControl viewerPanel;
        private XtraPdfViewer.PdfViewer pdfViewer;
        private XtraEditors.SimpleButton buttonAppend;
        private XtraEditors.SimpleButton buttonOpen;
        private XtraEditors.SimpleButton saveButton;
        private XtraEditors.SimpleButton newButton;
        private XtraEditors.PanelControl headerPanel;
        private XtraEditors.LabelControl labelSeparationLine;

    }
}
