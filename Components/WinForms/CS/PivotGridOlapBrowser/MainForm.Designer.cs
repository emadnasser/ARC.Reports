namespace PivotGridOlapBrowser {
    partial class MainForm {
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barToolbar = new DevExpress.XtraBars.Bar();
            this.barMenu = new DevExpress.XtraBars.Bar();
            this.barStatusBar = new DevExpress.XtraBars.Bar();
            this.bsiStatus = new DevExpress.XtraBars.BarStaticItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.pivotGridBrowser1 = new PivotGridOlapBrowser.PivotGridBrowser();
            this.notePanel = new DevExpress.Utils.Frames.NotePanel8_1();
            this.panelError = new DevExpress.XtraEditors.PanelControl();
            this.hyperLinkEdit1 = new DevExpress.XtraEditors.HyperLinkEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelError)).BeginInit();
            this.panelError.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hyperLinkEdit1.Properties)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.barToolbar,
            this.barMenu,
            this.barStatusBar});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] { this.bsiStatus });
            this.barManager1.MainMenu = this.barMenu;
            this.barManager1.MaxItemId = 3;
            this.barManager1.StatusBar = this.barStatusBar;
            // 
            // barToolbar
            // 
            this.barToolbar.BarName = "Tools";
            this.barToolbar.DockCol = 0;
            this.barToolbar.DockRow = 1;
            this.barToolbar.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.barToolbar.OptionsBar.AllowQuickCustomization = false;
            this.barToolbar.OptionsBar.DrawDragBorder = false;
            this.barToolbar.OptionsBar.UseWholeRow = true;
            this.barToolbar.Text = "Tools";
            // 
            // barMenu
            // 
            this.barMenu.BarName = "Main menu";
            this.barMenu.DockCol = 0;
            this.barMenu.DockRow = 0;
            this.barMenu.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.barMenu.OptionsBar.MultiLine = true;
            this.barMenu.OptionsBar.UseWholeRow = true;
            this.barMenu.Text = "Main menu";
            this.barMenu.Visible = false;
            // 
            // barStatusBar
            // 
            this.barStatusBar.BarName = "Status bar";
            this.barStatusBar.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.barStatusBar.DockCol = 0;
            this.barStatusBar.DockRow = 0;
            this.barStatusBar.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.barStatusBar.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.bsiStatus)});
            this.barStatusBar.OptionsBar.AllowQuickCustomization = false;
            this.barStatusBar.OptionsBar.DrawDragBorder = false;
            this.barStatusBar.OptionsBar.UseWholeRow = true;
            this.barStatusBar.Text = "Status bar";
            // 
            // bsiStatus
            // 
            this.bsiStatus.Caption = "Ready";
            this.bsiStatus.Id = 1;
            this.bsiStatus.Name = "bsiStatus";
            this.bsiStatus.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(786, 51);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 548);
            this.barDockControlBottom.Size = new System.Drawing.Size(786, 25);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 51);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 497);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(786, 51);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 497);
            // 
            // pivotGridBrowser1
            // 
            this.pivotGridBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pivotGridBrowser1.Location = new System.Drawing.Point(0, 43);
            this.pivotGridBrowser1.Name = "pivotGridBrowser1";
            this.pivotGridBrowser1.Padding = new System.Windows.Forms.Padding(8);
            this.pivotGridBrowser1.Size = new System.Drawing.Size(786, 392);
            this.pivotGridBrowser1.TabIndex = 4;
            this.pivotGridBrowser1.IsBusyChanged += new System.EventHandler(this.pivotGridBrowser1_IsBusyChanged);
            // 
            // notePanel
            // 
            this.notePanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.notePanel.Location = new System.Drawing.Point(0, 486);
            this.notePanel.MaxRows = 15;
            this.notePanel.Name = "notePanel";
            this.notePanel.Size = new System.Drawing.Size(786, 62);
            this.notePanel.TabIndex = 5;
            this.notePanel.TabStop = false;
            this.notePanel.Text = resources.GetString("notePanel.Text");
            // 
            // panelError
            // 
            this.panelError.Controls.Add(this.hyperLinkEdit1);
            this.panelError.Controls.Add(this.labelControl1);
            this.panelError.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelError.Location = new System.Drawing.Point(0, 0);
            this.panelError.Name = "panelError";
            this.panelError.Size = new System.Drawing.Size(786, 43);
            this.panelError.TabIndex = 16;
            // 
            // hyperLinkEdit1
            // 
            this.hyperLinkEdit1.EditValue = "http://www.microsoft.com/en-us/download/details.aspx?id=16978#ADOMD.NET";
            this.hyperLinkEdit1.Location = new System.Drawing.Point(469, 19);
            this.hyperLinkEdit1.Name = "hyperLinkEdit1";
            this.hyperLinkEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.hyperLinkEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.hyperLinkEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.hyperLinkEdit1.Properties.Caption = "www.microsoft.com";
            this.hyperLinkEdit1.Properties.UseParentBackground = true;
            this.hyperLinkEdit1.Size = new System.Drawing.Size(118, 18);
            this.hyperLinkEdit1.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl1.AutoEllipsis = true;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.Location = new System.Drawing.Point(12, 7);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(759, 28);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "To run this demo, you should have Microsoft SQL Server Analysis Services ADOMD.NET" +
                " 9.0 and OLE DB 8.0 (or later)\r\n installed on your system. You can get the latest" +
                " version of these providers here:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pivotGridBrowser1);
            this.panel1.Controls.Add(this.panelError);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(786, 435);
            this.panel1.TabIndex = 21;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 573);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.notePanel);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "MainForm";
            this.Text = "XtraPivotGrid Olap Browser Demo";
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelError)).EndInit();
            this.panelError.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.hyperLinkEdit1.Properties)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar barToolbar;
        private DevExpress.XtraBars.Bar barMenu;
        private DevExpress.XtraBars.Bar barStatusBar;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private PivotGridBrowser pivotGridBrowser1;
        private DevExpress.XtraBars.BarStaticItem bsiStatus;
        DevExpress.Utils.Frames.NotePanel8_1 notePanel;
        private DevExpress.XtraEditors.PanelControl panelError;
        private DevExpress.XtraEditors.HyperLinkEdit hyperLinkEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.Panel panel1;
    }
}

