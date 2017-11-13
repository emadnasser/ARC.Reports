namespace DevExpress.ApplicationUI.Demos {
    partial class DockPanels {
        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing) {
            if(disposing) {
                if(components != null) {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        #region Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Simple Dock Panel", 1, 1);
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Dock Panels", new System.Windows.Forms.TreeNode[] {
            treeNode7});
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Tab Container", 2, 2);
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Horizontal Container", 3, 3);
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Vertical Container", 4, 4);
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Dock Containers", new System.Windows.Forms.TreeNode[] {
            treeNode9,
            treeNode10,
            treeNode11});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DockPanels));
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.splitter1 = new DevExpress.XtraEditors.SplitterControl();
            this.pnlContainer = new DevExpress.XtraEditors.PanelControl();
            this.pnlLeft = new DevExpress.XtraEditors.PanelControl();
            this.splitter2 = new DevExpress.XtraEditors.SplitterControl();
            this.pnlControls = new DevExpress.XtraEditors.PanelControl();
            this.AutoHideMouseClick = new DevExpress.XtraEditors.CheckEdit();
            this.icbDock = new DevExpress.XtraEditors.ImageComboBoxEdit();
            this.sbAutoHide = new DevExpress.XtraEditors.SimpleButton();
            this.sbAddPanel = new DevExpress.XtraEditors.SimpleButton();
            this.lbCaption = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pnlContainer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlLeft)).BeginInit();
            this.pnlLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlControls)).BeginInit();
            this.pnlControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AutoHideMouseClick.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icbDock.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.HideSelection = false;
            this.treeView1.ImageIndex = 0;
            this.treeView1.ImageList = this.imageList1;
            this.treeView1.Location = new System.Drawing.Point(2, 2);
            this.treeView1.Name = "treeView1";
            treeNode7.ImageIndex = 1;
            treeNode7.Name = "";
            treeNode7.SelectedImageIndex = 1;
            treeNode7.Text = "Simple Dock Panel";
            treeNode8.Name = "";
            treeNode8.Text = "Dock Panels";
            treeNode9.ImageIndex = 2;
            treeNode9.Name = "";
            treeNode9.SelectedImageIndex = 2;
            treeNode9.Text = "Tab Container";
            treeNode10.ImageIndex = 3;
            treeNode10.Name = "";
            treeNode10.SelectedImageIndex = 3;
            treeNode10.Text = "Horizontal Container";
            treeNode11.ImageIndex = 4;
            treeNode11.Name = "";
            treeNode11.SelectedImageIndex = 4;
            treeNode11.Text = "Vertical Container";
            treeNode12.Name = "";
            treeNode12.Text = "Dock Containers";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode8,
            treeNode12});
            this.treeView1.SelectedImageIndex = 0;
            this.treeView1.ShowRootLines = false;
            this.treeView1.Size = new System.Drawing.Size(72, 229);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Magenta;
            this.imageList1.Images.SetKeyName(0, "");
            this.imageList1.Images.SetKeyName(1, "");
            this.imageList1.Images.SetKeyName(2, "");
            this.imageList1.Images.SetKeyName(3, "");
            this.imageList1.Images.SetKeyName(4, "");
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(76, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(12, 356);
            this.splitter1.TabIndex = 1;
            this.splitter1.TabStop = false;
            // 
            // pnlContainer
            // 
            this.pnlContainer.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pnlContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContainer.Location = new System.Drawing.Point(88, 28);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(568, 328);
            this.pnlContainer.TabIndex = 2;
            // 
            // pnlLeft
            // 
            this.pnlLeft.Controls.Add(this.treeView1);
            this.pnlLeft.Controls.Add(this.splitter2);
            this.pnlLeft.Controls.Add(this.pnlControls);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(76, 356);
            this.pnlLeft.TabIndex = 3;
            // 
            // splitter2
            // 
            this.splitter2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitter2.Enabled = false;
            this.splitter2.Location = new System.Drawing.Point(2, 231);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(72, 12);
            this.splitter2.TabIndex = 2;
            this.splitter2.TabStop = false;
            // 
            // pnlControls
            // 
            this.pnlControls.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pnlControls.Controls.Add(this.AutoHideMouseClick);
            this.pnlControls.Controls.Add(this.icbDock);
            this.pnlControls.Controls.Add(this.sbAutoHide);
            this.pnlControls.Controls.Add(this.sbAddPanel);
            this.pnlControls.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlControls.Location = new System.Drawing.Point(2, 243);
            this.pnlControls.Name = "pnlControls";
            this.pnlControls.Size = new System.Drawing.Size(72, 111);
            this.pnlControls.TabIndex = 1;
            // 
            // AutoHideMouseClick
            // 
            this.AutoHideMouseClick.Location = new System.Drawing.Point(6, 90);
            this.AutoHideMouseClick.Name = "AutoHideMouseClick";
            this.AutoHideMouseClick.Properties.Caption = "AutoHide by Mouse Click";
            this.AutoHideMouseClick.Size = new System.Drawing.Size(138, 19);
            this.AutoHideMouseClick.TabIndex = 0;
            this.AutoHideMouseClick.CheckedChanged += new System.EventHandler(this.checkAutoHideMouseClick_CheckedChanged);
            // 
            // icbDock
            // 
            this.icbDock.EditValue = "imageComboBoxEdit1";
            this.icbDock.Location = new System.Drawing.Point(28, 36);
            this.icbDock.Name = "icbDock";
            this.icbDock.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.icbDock.Size = new System.Drawing.Size(116, 20);
            this.icbDock.TabIndex = 1;
            // 
            // sbAutoHide
            // 
            this.sbAutoHide.Location = new System.Drawing.Point(8, 60);
            this.sbAutoHide.Name = "sbAutoHide";
            this.sbAutoHide.Size = new System.Drawing.Size(140, 24);
            this.sbAutoHide.TabIndex = 2;
            this.sbAutoHide.Text = "AutoHide Root Panels";
            this.sbAutoHide.Click += new System.EventHandler(this.sbAutoHide_Click);
            // 
            // sbAddPanel
            // 
            this.sbAddPanel.Location = new System.Drawing.Point(8, 8);
            this.sbAddPanel.Name = "sbAddPanel";
            this.sbAddPanel.Size = new System.Drawing.Size(96, 24);
            this.sbAddPanel.TabIndex = 0;
            this.sbAddPanel.Text = "Add Panel To:";
            this.sbAddPanel.Click += new System.EventHandler(this.sbAddPanel_Click);
            // 
            // lbCaption
            // 
            this.lbCaption.BackColor = System.Drawing.SystemColors.Highlight;
            this.lbCaption.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbCaption.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.lbCaption.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lbCaption.Location = new System.Drawing.Point(88, 0);
            this.lbCaption.Name = "lbCaption";
            this.lbCaption.Size = new System.Drawing.Size(568, 28);
            this.lbCaption.TabIndex = 4;
            this.lbCaption.Text = "label1";
            this.lbCaption.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // DockPanels
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlContainer);
            this.Controls.Add(this.lbCaption);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.pnlLeft);
            this.Name = "DockPanels";
            this.Size = new System.Drawing.Size(656, 356);
            this.Load += new System.EventHandler(this.DockPanels_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pnlContainer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlLeft)).EndInit();
            this.pnlLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnlControls)).EndInit();
            this.pnlControls.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AutoHideMouseClick.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icbDock.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TreeView treeView1;
        private DevExpress.XtraEditors.SplitterControl splitter1;
        private System.Windows.Forms.ImageList imageList1;
        private DevExpress.XtraEditors.PanelControl pnlContainer;
        private DevExpress.XtraEditors.PanelControl pnlLeft;
        private DevExpress.XtraEditors.PanelControl pnlControls;
        private DevExpress.XtraEditors.SplitterControl splitter2;
        private System.Windows.Forms.Label lbCaption;
        private DevExpress.XtraEditors.SimpleButton sbAddPanel;
        private DevExpress.XtraEditors.SimpleButton sbAutoHide;
        private DevExpress.XtraEditors.ImageComboBoxEdit icbDock;
        private System.ComponentModel.IContainer components;
        private DevExpress.XtraEditors.CheckEdit AutoHideMouseClick;

    }
}
