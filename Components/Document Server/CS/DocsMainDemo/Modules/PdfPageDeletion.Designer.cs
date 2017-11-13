namespace DevExpress.Docs.Demos
{
    partial class PdfPageDeletion
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
            this.buttonDeletePage = new DevExpress.XtraEditors.SimpleButton();
            this.spinEditPageNumber = new DevExpress.XtraEditors.SpinEdit();
            this.labelPageNumber = new DevExpress.XtraEditors.LabelControl();
            this.buttonOpen = new DevExpress.XtraEditors.SimpleButton();
            this.buttonSave = new DevExpress.XtraEditors.SimpleButton();
            this.deletePagePanel = new DevExpress.XtraEditors.PanelControl();
            this.docOperationsPanel = new DevExpress.XtraEditors.PanelControl();
            this.headerPanel = new DevExpress.XtraEditors.PanelControl();
            this.labelSeparationLine = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.viewerPanel)).BeginInit();
            this.viewerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditPageNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deletePagePanel)).BeginInit();
            this.deletePagePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.docOperationsPanel)).BeginInit();
            this.docOperationsPanel.SuspendLayout();
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
            this.viewerPanel.TabIndex = 6;
            // 
            // pdfViewer
            // 
            this.pdfViewer.DetachStreamAfterLoadComplete = true;
            this.pdfViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pdfViewer.Location = new System.Drawing.Point(0, 0);
            this.pdfViewer.Name = "pdfViewer";
            this.pdfViewer.NavigationPaneInitialVisibility = DevExpress.XtraPdfViewer.PdfNavigationPaneVisibility.Hidden;
            this.pdfViewer.Size = new System.Drawing.Size(737, 511);
            this.pdfViewer.TabIndex = 6;
            this.pdfViewer.TabStop = false;
            this.pdfViewer.ZoomMode = DevExpress.XtraPdfViewer.PdfZoomMode.FitToWidth;
            this.pdfViewer.CurrentPageChanged += new DevExpress.XtraPdfViewer.PdfCurrentPageChangedEventHandler(this.PdfViewerCurrentPageChanged);
            // 
            // buttonDeletePage
            // 
            this.buttonDeletePage.Location = new System.Drawing.Point(0, 0);
            this.buttonDeletePage.Name = "buttonDeletePage";
            this.buttonDeletePage.Size = new System.Drawing.Size(110, 23);
            this.buttonDeletePage.TabIndex = 2;
            this.buttonDeletePage.Text = "Delete Page";
            this.buttonDeletePage.Click += new System.EventHandler(this.OnButtonDeletePageClick);
            // 
            // spinEditPageNumber
            // 
            this.spinEditPageNumber.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spinEditPageNumber.Location = new System.Drawing.Point(89, 17);
            this.spinEditPageNumber.Name = "spinEditPageNumber";
            this.spinEditPageNumber.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinEditPageNumber.Properties.IsFloatValue = false;
            this.spinEditPageNumber.Properties.Mask.EditMask = "N00";
            this.spinEditPageNumber.Properties.MaxValue = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.spinEditPageNumber.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spinEditPageNumber.Size = new System.Drawing.Size(65, 20);
            this.spinEditPageNumber.TabIndex = 1;
            // 
            // labelPageNumber
            // 
            this.labelPageNumber.Location = new System.Drawing.Point(15, 20);
            this.labelPageNumber.Margin = new System.Windows.Forms.Padding(32, 3, 3, 3);
            this.labelPageNumber.Name = "labelPageNumber";
            this.labelPageNumber.Size = new System.Drawing.Size(67, 13);
            this.labelPageNumber.TabIndex = 0;
            this.labelPageNumber.Text = "Page number:";
            // 
            // buttonOpen
            // 
            this.buttonOpen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOpen.Location = new System.Drawing.Point(0, 0);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(110, 23);
            this.buttonOpen.TabIndex = 3;
            this.buttonOpen.Text = "Open...";
            this.buttonOpen.Click += new System.EventHandler(this.OnButtonOpenClick);
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSave.Location = new System.Drawing.Point(116, 0);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(110, 23);
            this.buttonSave.TabIndex = 4;
            this.buttonSave.Text = "Save...";
            this.buttonSave.Click += new System.EventHandler(this.OnButtonSaveClick);
            // 
            // deletePagePanel
            // 
            this.deletePagePanel.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.deletePagePanel.Controls.Add(this.buttonDeletePage);
            this.deletePagePanel.Location = new System.Drawing.Point(160, 15);
            this.deletePagePanel.Name = "deletePagePanel";
            this.deletePagePanel.Size = new System.Drawing.Size(110, 23);
            this.deletePagePanel.TabIndex = 2;
            // 
            // docOperationsPanel
            // 
            this.docOperationsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.docOperationsPanel.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.docOperationsPanel.Controls.Add(this.buttonOpen);
            this.docOperationsPanel.Controls.Add(this.buttonSave);
            this.docOperationsPanel.Location = new System.Drawing.Point(496, 15);
            this.docOperationsPanel.Name = "docOperationsPanel";
            this.docOperationsPanel.Size = new System.Drawing.Size(226, 23);
            this.docOperationsPanel.TabIndex = 3;
            // 
            // headerPanel
            // 
            this.headerPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.headerPanel.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.headerPanel.Controls.Add(this.labelSeparationLine);
            this.headerPanel.Controls.Add(this.spinEditPageNumber);
            this.headerPanel.Controls.Add(this.labelPageNumber);
            this.headerPanel.Controls.Add(this.deletePagePanel);
            this.headerPanel.Controls.Add(this.docOperationsPanel);
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(737, 53);
            this.headerPanel.TabIndex = 11;
            // 
            // labelSeparationLine
            // 
            this.labelSeparationLine.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelSeparationLine.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.labelSeparationLine.LineVisible = true;
            this.labelSeparationLine.Location = new System.Drawing.Point(0, 50);
            this.labelSeparationLine.Name = "labelSeparationLine";
            this.labelSeparationLine.Size = new System.Drawing.Size(737, 3);
            this.labelSeparationLine.TabIndex = 5;
            // 
            // PdfPageDeletion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.headerPanel);
            this.Controls.Add(this.viewerPanel);
            this.Name = "PdfPageDeletion";
            this.Size = new System.Drawing.Size(737, 564);
            ((System.ComponentModel.ISupportInitialize)(this.viewerPanel)).EndInit();
            this.viewerPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spinEditPageNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deletePagePanel)).EndInit();
            this.deletePagePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.docOperationsPanel)).EndInit();
            this.docOperationsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.headerPanel)).EndInit();
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

        private XtraEditors.PanelControl viewerPanel;
        private XtraPdfViewer.PdfViewer pdfViewer;
        private XtraEditors.SimpleButton buttonDeletePage;
        private XtraEditors.SpinEdit spinEditPageNumber;
        private XtraEditors.LabelControl labelPageNumber;
        private XtraEditors.SimpleButton buttonOpen;
        private XtraEditors.SimpleButton buttonSave;
        private XtraEditors.PanelControl deletePagePanel;
        private XtraEditors.PanelControl docOperationsPanel;
        private XtraEditors.PanelControl headerPanel;
        private XtraEditors.LabelControl labelSeparationLine;

    }
}
