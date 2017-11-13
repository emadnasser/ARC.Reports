namespace DevExpress.Docs.Demos
{
	partial class PdfTextSearch
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
            this.labelTextToFind = new DevExpress.XtraEditors.LabelControl();
            this.textEditTextToFind = new DevExpress.XtraEditors.TextEdit();
            this.labelWordCount = new DevExpress.XtraEditors.LabelControl();
            this.spinEditWordCount = new DevExpress.XtraEditors.SpinEdit();
            this.viewerPanel = new DevExpress.XtraEditors.PanelControl();
            this.pdfViewer = new DevExpress.XtraPdfViewer.PdfViewer();
            this.buttonSearch = new DevExpress.XtraEditors.SimpleButton();
            this.buttonOpen = new DevExpress.XtraEditors.SimpleButton();
            this.headerPanel = new DevExpress.XtraEditors.PanelControl();
            this.labelSeparationLine = new DevExpress.XtraEditors.LabelControl();
            this.docOperationsPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.textEditTextToFind.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditWordCount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewerPanel)).BeginInit();
            this.viewerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.headerPanel)).BeginInit();
            this.headerPanel.SuspendLayout();
            this.docOperationsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTextToFind
            // 
            this.labelTextToFind.Location = new System.Drawing.Point(13, 18);
            this.labelTextToFind.Name = "labelTextToFind";
            this.labelTextToFind.Size = new System.Drawing.Size(60, 13);
            this.labelTextToFind.TabIndex = 0;
            this.labelTextToFind.Text = "Text to find:";
            // 
            // textEditTextToFind
            // 
            this.textEditTextToFind.EditValue = "Customer:";
            this.textEditTextToFind.Location = new System.Drawing.Point(83, 17);
            this.textEditTextToFind.Name = "textEditTextToFind";
            this.textEditTextToFind.Size = new System.Drawing.Size(93, 20);
            this.textEditTextToFind.TabIndex = 1;
            // 
            // labelWordCount
            // 
            this.labelWordCount.Location = new System.Drawing.Point(193, 18);
            this.labelWordCount.Margin = new System.Windows.Forms.Padding(32, 3, 3, 3);
            this.labelWordCount.Name = "labelWordCount";
            this.labelWordCount.Size = new System.Drawing.Size(60, 13);
            this.labelWordCount.TabIndex = 2;
            this.labelWordCount.Text = "Word count:";
            // 
            // spinEditWordCount
            // 
            this.spinEditWordCount.EditValue = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.spinEditWordCount.Location = new System.Drawing.Point(263, 17);
            this.spinEditWordCount.Name = "spinEditWordCount";
            this.spinEditWordCount.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinEditWordCount.Properties.IsFloatValue = false;
            this.spinEditWordCount.Properties.Mask.EditMask = "N00";
            this.spinEditWordCount.Properties.MaxValue = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.spinEditWordCount.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spinEditWordCount.Size = new System.Drawing.Size(65, 20);
            this.spinEditWordCount.TabIndex = 3;
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
            this.viewerPanel.TabIndex = 7;
            // 
            // pdfViewer
            // 
            this.pdfViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pdfViewer.Location = new System.Drawing.Point(0, 0);
            this.pdfViewer.Name = "pdfViewer";
            this.pdfViewer.NavigationPaneInitialVisibility = DevExpress.XtraPdfViewer.PdfNavigationPaneVisibility.Hidden;
            this.pdfViewer.Size = new System.Drawing.Size(737, 511);
            this.pdfViewer.TabIndex = 7;
            this.pdfViewer.TabStop = false;
            this.pdfViewer.ZoomMode = DevExpress.XtraPdfViewer.PdfZoomMode.FitToWidth;
            this.pdfViewer.DocumentChanged += new DevExpress.XtraPdfViewer.PdfDocumentChangedEventHandler(this.OnDocumentChanged);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSearch.Location = new System.Drawing.Point(116, 0);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(110, 23);
            this.buttonSearch.TabIndex = 5;
            this.buttonSearch.Text = "Search...";
            this.buttonSearch.Click += new System.EventHandler(this.OnButtonSearchClick);
            // 
            // buttonOpen
            // 
            this.buttonOpen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOpen.Location = new System.Drawing.Point(0, 0);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(110, 23);
            this.buttonOpen.TabIndex = 4;
            this.buttonOpen.Text = "Open...";
            this.buttonOpen.Click += new System.EventHandler(this.OnButtonOpenClick);
            // 
            // headerPanel
            // 
            this.headerPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.headerPanel.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.headerPanel.Controls.Add(this.labelSeparationLine);
            this.headerPanel.Controls.Add(this.docOperationsPanel);
            this.headerPanel.Controls.Add(this.labelTextToFind);
            this.headerPanel.Controls.Add(this.textEditTextToFind);
            this.headerPanel.Controls.Add(this.labelWordCount);
            this.headerPanel.Controls.Add(this.spinEditWordCount);
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(737, 53);
            this.headerPanel.TabIndex = 6;
            // 
            // labelSeparationLine
            // 
            this.labelSeparationLine.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelSeparationLine.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.labelSeparationLine.LineVisible = true;
            this.labelSeparationLine.Location = new System.Drawing.Point(0, 50);
            this.labelSeparationLine.Name = "labelSeparationLine";
            this.labelSeparationLine.Size = new System.Drawing.Size(737, 3);
            this.labelSeparationLine.TabIndex = 6;
            // 
            // docOperationsPanel
            // 
            this.docOperationsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.docOperationsPanel.Controls.Add(this.buttonSearch);
            this.docOperationsPanel.Controls.Add(this.buttonOpen);
            this.docOperationsPanel.Location = new System.Drawing.Point(496, 15);
            this.docOperationsPanel.Name = "docOperationsPanel";
            this.docOperationsPanel.Size = new System.Drawing.Size(226, 23);
            this.docOperationsPanel.TabIndex = 4;
            // 
            // PdfTextSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.headerPanel);
            this.Controls.Add(this.viewerPanel);
            this.Name = "PdfTextSearch";
            this.Size = new System.Drawing.Size(737, 564);
            ((System.ComponentModel.ISupportInitialize)(this.textEditTextToFind.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditWordCount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewerPanel)).EndInit();
            this.viewerPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.headerPanel)).EndInit();
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            this.docOperationsPanel.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		#endregion

        private XtraEditors.LabelControl labelTextToFind;
        private XtraEditors.TextEdit textEditTextToFind;
        private XtraEditors.LabelControl labelWordCount;
        private XtraEditors.SpinEdit spinEditWordCount;
        private XtraEditors.PanelControl viewerPanel;
        private XtraPdfViewer.PdfViewer pdfViewer;
        private XtraEditors.SimpleButton buttonSearch;
        private XtraEditors.SimpleButton buttonOpen;
        private XtraEditors.PanelControl headerPanel;
        private System.Windows.Forms.Panel docOperationsPanel;
        private XtraEditors.LabelControl labelSeparationLine;

    }
}
