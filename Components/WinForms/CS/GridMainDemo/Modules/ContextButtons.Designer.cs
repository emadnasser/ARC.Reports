namespace DevExpress.XtraGrid.Demos {
    partial class ContextButtons {
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            DevExpress.Utils.ContextButton contextButton1 = new DevExpress.Utils.ContextButton();
            DevExpress.Utils.ContextButton contextButton2 = new DevExpress.Utils.ContextButton();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ContextButtons));
            DevExpress.Utils.ContextButton contextButton3 = new DevExpress.Utils.ContextButton();
            DevExpress.Utils.ContextButton contextButton4 = new DevExpress.Utils.ContextButton();
            DevExpress.Utils.CheckContextButton checkContextButton1 = new DevExpress.Utils.CheckContextButton();
            DevExpress.Utils.RatingContextButton ratingContextButton1 = new DevExpress.Utils.RatingContextButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.winExplorerView1 = new DevExpress.XtraGrid.Views.WinExplorer.WinExplorerView();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.barEditItem1 = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemImageComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.barEditItem2 = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemZoomTrackBar2 = new DevExpress.XtraEditors.Repository.RepositoryItemZoomTrackBar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.winExplorerView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemZoomTrackBar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 38);
            this.gridControl1.MainView = this.winExplorerView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(711, 420);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.winExplorerView1});
            // 
            // winExplorerView1
            // 
            this.winExplorerView1.ContextButtonOptions.BottomPanelColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.winExplorerView1.ContextButtonOptions.BottomPanelPadding = new System.Windows.Forms.Padding(5);
            this.winExplorerView1.ContextButtonOptions.Indent = 3;
            this.winExplorerView1.ContextButtonOptions.TopPanelColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.winExplorerView1.ContextButtonOptions.TopPanelPadding = new System.Windows.Forms.Padding(5);
            contextButton1.Alignment = DevExpress.Utils.ContextItemAlignment.MiddleTop;
            contextButton1.AppearanceHover.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            contextButton1.AppearanceHover.ForeColor = System.Drawing.Color.White;
            contextButton1.AppearanceHover.Options.UseFont = true;
            contextButton1.AppearanceHover.Options.UseForeColor = true;
            contextButton1.AppearanceNormal.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            contextButton1.AppearanceNormal.ForeColor = System.Drawing.Color.White;
            contextButton1.AppearanceNormal.Options.UseFont = true;
            contextButton1.AppearanceNormal.Options.UseForeColor = true;
            contextButton1.Id = new System.Guid("62095aba-f30f-4377-b233-14b1eab8c0db");
            contextButton1.Name = "itemText";
            contextButton2.Alignment = DevExpress.Utils.ContextItemAlignment.TopFar;
            contextButton2.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            contextButton2.AppearanceHover.ForeColor = System.Drawing.Color.White;
            contextButton2.AppearanceHover.Options.UseForeColor = true;
            contextButton2.AppearanceNormal.ForeColor = System.Drawing.Color.White;
            contextButton2.AppearanceNormal.Options.UseForeColor = true;
            contextButton2.Glyph = ((System.Drawing.Image)(resources.GetObject("contextButton2.Glyph")));
            contextButton2.Id = new System.Guid("aff114b4-1a64-4e9b-ae04-098d9ddc4ec4");
            contextButton2.Name = "itemRemove";
            contextButton3.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            contextButton3.AppearanceHover.ForeColor = System.Drawing.Color.White;
            contextButton3.AppearanceHover.Options.UseForeColor = true;
            contextButton3.AppearanceNormal.ForeColor = System.Drawing.Color.White;
            contextButton3.AppearanceNormal.Options.UseForeColor = true;
            contextButton3.Glyph = ((System.Drawing.Image)(resources.GetObject("contextButton3.Glyph")));
            contextButton3.Id = new System.Guid("8919a814-c5ac-42a5-96fe-71a6f31d1f7e");
            contextButton3.Name = "itemDownload";
            contextButton4.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            contextButton4.AppearanceHover.ForeColor = System.Drawing.Color.White;
            contextButton4.AppearanceHover.Options.UseForeColor = true;
            contextButton4.AppearanceNormal.ForeColor = System.Drawing.Color.White;
            contextButton4.AppearanceNormal.Options.UseForeColor = true;
            contextButton4.Glyph = ((System.Drawing.Image)(resources.GetObject("contextButton4.Glyph")));
            contextButton4.Id = new System.Guid("52064e3b-1c98-4a1f-9296-07465624a0d5");
            contextButton4.Name = "itemInfo";
            checkContextButton1.Alignment = DevExpress.Utils.ContextItemAlignment.BottomNear;
            checkContextButton1.Id = new System.Guid("d5e27663-722f-40c8-8363-cc4eded0e782");
            checkContextButton1.Name = "itemCheck";
            ratingContextButton1.Alignment = DevExpress.Utils.ContextItemAlignment.MiddleBottom;
            ratingContextButton1.Id = new System.Guid("93da3997-ef55-4c87-8eef-d2881dc0e6dd");
            ratingContextButton1.Name = "itemRating";
            ratingContextButton1.Rating = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.winExplorerView1.ContextButtons.Add(contextButton1);
            this.winExplorerView1.ContextButtons.Add(contextButton2);
            this.winExplorerView1.ContextButtons.Add(contextButton3);
            this.winExplorerView1.ContextButtons.Add(contextButton4);
            this.winExplorerView1.ContextButtons.Add(checkContextButton1);
            this.winExplorerView1.ContextButtons.Add(ratingContextButton1);
            this.winExplorerView1.GridControl = this.gridControl1;
            this.winExplorerView1.Name = "winExplorerView1";
            this.winExplorerView1.OptionsView.Style = DevExpress.XtraGrid.Views.WinExplorer.WinExplorerViewStyle.ExtraLarge;
            this.winExplorerView1.ContextButtonCustomize += new DevExpress.XtraGrid.Views.WinExplorer.WinExplorerViewContextButtonCustomizeEventHandler(this.winExplorerView1_ContextButtonCustomize);
            this.winExplorerView1.ContextButtonClick += new DevExpress.Utils.ContextItemClickEventHandler(this.winExplorerView1_ContextButtonClick);
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barEditItem2,
            this.barEditItem1});
            this.barManager1.MaxItemId = 3;
            this.barManager1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemZoomTrackBar2,
            this.repositoryItemImageComboBox1});
            this.barManager1.TransparentEditors = true;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barEditItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.barEditItem2)});
            this.bar2.OptionsBar.AllowQuickCustomization = false;
            this.bar2.OptionsBar.DrawBorder = false;
            this.bar2.OptionsBar.DrawDragBorder = false;
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // barEditItem1
            // 
            this.barEditItem1.Caption = "Animation Type";
            this.barEditItem1.Edit = this.repositoryItemImageComboBox1;
            this.barEditItem1.Id = 2;
            this.barEditItem1.Name = "barEditItem1";
            this.barEditItem1.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barEditItem1.Width = 182;
            // 
            // repositoryItemImageComboBox1
            // 
            this.repositoryItemImageComboBox1.AutoHeight = false;
            this.repositoryItemImageComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemImageComboBox1.Name = "repositoryItemImageComboBox1";
            this.repositoryItemImageComboBox1.SelectedValueChanged += new System.EventHandler(this.repositoryItemImageComboBox1_SelectedValueChanged);
            // 
            // barEditItem2
            // 
            this.barEditItem2.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.barEditItem2.Caption = "Thumbnails";
            this.barEditItem2.Edit = this.repositoryItemZoomTrackBar2;
            this.barEditItem2.EditValue = 300;
            this.barEditItem2.Id = 1;
            this.barEditItem2.Name = "barEditItem2";
            this.barEditItem2.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barEditItem2.Width = 150;
            // 
            // repositoryItemZoomTrackBar2
            // 
            this.repositoryItemZoomTrackBar2.AllowFocused = false;
            this.repositoryItemZoomTrackBar2.AllowUseMiddleValue = true;
            this.repositoryItemZoomTrackBar2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.repositoryItemZoomTrackBar2.Maximum = 392;
            this.repositoryItemZoomTrackBar2.Middle = 300;
            this.repositoryItemZoomTrackBar2.Minimum = 192;
            this.repositoryItemZoomTrackBar2.Name = "repositoryItemZoomTrackBar2";
            this.repositoryItemZoomTrackBar2.ScrollThumbStyle = DevExpress.XtraEditors.Repository.ScrollThumbStyle.ArrowDownRight;
            this.repositoryItemZoomTrackBar2.EditValueChanged += new System.EventHandler(this.repositoryItemZoomTrackBar1_EditValueChanged);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(711, 30);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 458);
            this.barDockControlBottom.Size = new System.Drawing.Size(711, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 30);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 428);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(711, 30);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 428);
            // 
            // panelControl1
            // 
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 30);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(711, 8);
            this.panelControl1.TabIndex = 5;
            // 
            // ContextButtons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "ContextButtons";
            this.Size = new System.Drawing.Size(711, 458);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.winExplorerView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemZoomTrackBar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GridControl gridControl1;
        private Views.WinExplorer.WinExplorerView winExplorerView1;
        private XtraBars.BarManager barManager1;
        private XtraBars.Bar bar2;
        private XtraBars.BarDockControl barDockControlTop;
        private XtraBars.BarDockControl barDockControlBottom;
        private XtraBars.BarDockControl barDockControlLeft;
        private XtraBars.BarDockControl barDockControlRight;
        private XtraBars.BarEditItem barEditItem2;
        private XtraEditors.Repository.RepositoryItemZoomTrackBar repositoryItemZoomTrackBar2;
        private XtraBars.BarEditItem barEditItem1;
        private XtraEditors.Repository.RepositoryItemImageComboBox repositoryItemImageComboBox1;
        private XtraEditors.PanelControl panelControl1;
    }
}
