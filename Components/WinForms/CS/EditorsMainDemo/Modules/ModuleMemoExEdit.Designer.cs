namespace DevExpress.XtraEditors.Demos {
    partial class ModuleMemoExEdit {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModuleMemoExEdit));
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.ceWordWrap = new DevExpress.XtraEditors.CheckEdit();
            this.ceCustomIcons = new DevExpress.XtraEditors.CheckEdit();
            this.ceIcon = new DevExpress.XtraEditors.CheckEdit();
            this.icbScrollBars = new DevExpress.XtraEditors.ImageComboBoxEdit();
            this.cePopupSizeable = new DevExpress.XtraEditors.CheckEdit();
            this.memoExEditSample = new DevExpress.XtraEditors.MemoExEdit();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ceWordWrap.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceCustomIcons.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceIcon.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icbScrollBars.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cePopupSizeable.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoExEditSample.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(5, 0);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.ShowTabHeader = DevExpress.Utils.DefaultBoolean.False;
            this.xtraTabControl1.Size = new System.Drawing.Size(750, 475);
            this.xtraTabControl1.TabIndex = 1;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1});
            this.xtraTabControl1.TabStop = false;
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.layoutControl1);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(744, 469);
            this.xtraTabPage1.Text = "xtraTabPage1";
            // 
            // ceWordWrap
            // 
            this.ceWordWrap.Location = new System.Drawing.Point(290, 78);
            this.ceWordWrap.Name = "ceWordWrap";
            this.ceWordWrap.Properties.Caption = "Word wrap";
            this.ceWordWrap.Size = new System.Drawing.Size(186, 19);
            this.ceWordWrap.StyleController = this.layoutControl1;
            this.ceWordWrap.TabIndex = 1;
            this.ceWordWrap.CheckedChanged += new System.EventHandler(this.ceWordWrap_CheckedChanged);
            // 
            // ceCustomIcons
            // 
            this.ceCustomIcons.Location = new System.Drawing.Point(290, 159);
            this.ceCustomIcons.Name = "ceCustomIcons";
            this.ceCustomIcons.Properties.Caption = "Use custom icons";
            this.ceCustomIcons.Size = new System.Drawing.Size(186, 19);
            this.ceCustomIcons.StyleController = this.layoutControl1;
            this.ceCustomIcons.TabIndex = 6;
            this.ceCustomIcons.CheckedChanged += new System.EventHandler(this.ceCustomIcons_CheckedChanged);
            // 
            // ceIcon
            // 
            this.ceIcon.Location = new System.Drawing.Point(290, 105);
            this.ceIcon.Name = "ceIcon";
            this.ceIcon.Properties.Caption = "Show icon";
            this.ceIcon.Size = new System.Drawing.Size(186, 19);
            this.ceIcon.StyleController = this.layoutControl1;
            this.ceIcon.TabIndex = 4;
            this.ceIcon.CheckedChanged += new System.EventHandler(this.ceIcon_CheckedChanged);
            // 
            // icbScrollBars
            // 
            this.icbScrollBars.EditValue = "imageComboBoxEdit1";
            this.icbScrollBars.Location = new System.Drawing.Point(347, 50);
            this.icbScrollBars.Name = "icbScrollBars";
            this.icbScrollBars.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.icbScrollBars.Size = new System.Drawing.Size(129, 20);
            this.icbScrollBars.StyleController = this.layoutControl1;
            this.icbScrollBars.TabIndex = 0;
            this.icbScrollBars.SelectedIndexChanged += new System.EventHandler(this.icbScrollBars_SelectedIndexChanged);
            // 
            // cePopupSizeable
            // 
            this.cePopupSizeable.Location = new System.Drawing.Point(290, 132);
            this.cePopupSizeable.Name = "cePopupSizeable";
            this.cePopupSizeable.Properties.Caption = "Popup sizeable";
            this.cePopupSizeable.Size = new System.Drawing.Size(186, 19);
            this.cePopupSizeable.StyleController = this.layoutControl1;
            this.cePopupSizeable.TabIndex = 5;
            this.cePopupSizeable.CheckedChanged += new System.EventHandler(this.cePopupSizeable_CheckedChanged);
            // 
            // memoExEditSample
            // 
            this.memoExEditSample.Location = new System.Drawing.Point(32, 104);
            this.memoExEditSample.Name = "memoExEditSample";
            this.memoExEditSample.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.memoExEditSample.Size = new System.Drawing.Size(186, 20);
            this.memoExEditSample.StyleController = this.layoutControl1;
            this.memoExEditSample.TabIndex = 0;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Magenta;
            this.imageList1.Images.SetKeyName(0, "");
            this.imageList1.Images.SetKeyName(1, "");
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.ceCustomIcons);
            this.layoutControl1.Controls.Add(this.ceWordWrap);
            this.layoutControl1.Controls.Add(this.ceIcon);
            this.layoutControl1.Controls.Add(this.cePopupSizeable);
            this.layoutControl1.Controls.Add(this.memoExEditSample);
            this.layoutControl1.Controls.Add(this.icbScrollBars);
            this.layoutControl1.Location = new System.Drawing.Point(41, 49);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(986, 45, 650, 400);
            this.layoutControl1.OptionsView.UseParentAutoScaleFactor = true;
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(499, 204);
            this.layoutControl1.TabIndex = 4;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2,
            this.layoutControlGroup3});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(508, 211);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.memoExEditSample;
            this.layoutControlItem1.ControlAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.layoutControlItem1.FillControlToClientArea = false;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.MinSize = new System.Drawing.Size(190, 24);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(190, 133);
            this.layoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            this.layoutControlItem1.TrimClientAreaToControl = false;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.Padding = new DevExpress.XtraLayout.Utils.Padding(17, 17, 17, 17);
            this.layoutControlGroup2.Size = new System.Drawing.Size(258, 191);
            this.layoutControlGroup2.Spacing = new DevExpress.XtraLayout.Utils.Padding(2, 30, 2, 2);
            this.layoutControlGroup2.Text = "Sample";
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.icbScrollBars;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 4);
            this.layoutControlItem2.Size = new System.Drawing.Size(190, 26);
            this.layoutControlItem2.Text = "Scroll bars:";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(53, 13);
            // 
            // layoutControlGroup3
            // 
            this.layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.layoutControlItem6,
            this.emptySpaceItem1});
            this.layoutControlGroup3.Location = new System.Drawing.Point(258, 0);
            this.layoutControlGroup3.Name = "layoutControlGroup3";
            this.layoutControlGroup3.Padding = new DevExpress.XtraLayout.Utils.Padding(17, 17, 17, 17);
            this.layoutControlGroup3.Size = new System.Drawing.Size(230, 191);
            this.layoutControlGroup3.Text = "Properties";
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.ceWordWrap;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 26);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 4, 4);
            this.layoutControlItem3.Size = new System.Drawing.Size(190, 27);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.ceIcon;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 53);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 4, 4);
            this.layoutControlItem4.Size = new System.Drawing.Size(190, 27);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.cePopupSizeable;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 80);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 4, 4);
            this.layoutControlItem5.Size = new System.Drawing.Size(190, 27);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.ceCustomIcons;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 107);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 4, 2);
            this.layoutControlItem6.Size = new System.Drawing.Size(190, 25);
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 132);
            this.emptySpaceItem1.MaxSize = new System.Drawing.Size(0, 1);
            this.emptySpaceItem1.MinSize = new System.Drawing.Size(190, 1);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(190, 1);
            this.emptySpaceItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // ModuleMemoExEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.xtraTabControl1);
            this.Name = "ModuleMemoExEdit";
            this.Size = new System.Drawing.Size(755, 480);
            this.Load += new System.EventHandler(this.ModuleMemoExEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ceWordWrap.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceCustomIcons.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceIcon.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icbScrollBars.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cePopupSizeable.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoExEditSample.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraEditors.MemoExEdit memoExEditSample;
        private DevExpress.XtraEditors.CheckEdit ceCustomIcons;
        private DevExpress.XtraEditors.CheckEdit ceIcon;
        private DevExpress.XtraEditors.ImageComboBoxEdit icbScrollBars;
        private DevExpress.XtraEditors.CheckEdit cePopupSizeable;
        private DevExpress.XtraEditors.CheckEdit ceWordWrap;
        private System.Windows.Forms.ImageList imageList1;
        private System.ComponentModel.IContainer components = null;
        private XtraLayout.LayoutControl layoutControl1;
        private XtraLayout.LayoutControlGroup layoutControlGroup1;
        private XtraLayout.LayoutControlGroup layoutControlGroup2;
        private XtraLayout.LayoutControlItem layoutControlItem1;
        private XtraLayout.LayoutControlGroup layoutControlGroup3;
        private XtraLayout.LayoutControlItem layoutControlItem2;
        private XtraLayout.LayoutControlItem layoutControlItem3;
        private XtraLayout.LayoutControlItem layoutControlItem4;
        private XtraLayout.LayoutControlItem layoutControlItem5;
        private XtraLayout.LayoutControlItem layoutControlItem6;
        private XtraLayout.EmptySpaceItem emptySpaceItem1;

    }
}
