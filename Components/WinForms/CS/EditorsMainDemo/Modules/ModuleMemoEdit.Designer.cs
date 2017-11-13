namespace DevExpress.XtraEditors.Demos {
    partial class ModuleMemoEdit {
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
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.seMaxLength = new DevExpress.XtraEditors.SpinEdit();
            this.ceTab = new DevExpress.XtraEditors.CheckEdit();
            this.ceReturn = new DevExpress.XtraEditors.CheckEdit();
            this.ceWordWrap = new DevExpress.XtraEditors.CheckEdit();
            this.memoEditSample = new DevExpress.XtraEditors.MemoEdit();
            this.icbScrollBars = new DevExpress.XtraEditors.ImageComboBoxEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.seMaxLength.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceTab.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceReturn.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceWordWrap.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoEditSample.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icbScrollBars.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
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
            this.xtraTabControl1.Size = new System.Drawing.Size(649, 419);
            this.xtraTabControl1.TabIndex = 1;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1});
            this.xtraTabControl1.TabStop = false;
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.layoutControl1);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(643, 413);
            this.xtraTabPage1.Text = "xtraTabPage1";
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.seMaxLength);
            this.layoutControl1.Controls.Add(this.ceTab);
            this.layoutControl1.Controls.Add(this.ceReturn);
            this.layoutControl1.Controls.Add(this.ceWordWrap);
            this.layoutControl1.Controls.Add(this.memoEditSample);
            this.layoutControl1.Controls.Add(this.icbScrollBars);
            this.layoutControl1.Location = new System.Drawing.Point(27, 46);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsView.UseParentAutoScaleFactor = true;
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(610, 232);
            this.layoutControl1.TabIndex = 3;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // seMaxLength
            // 
            this.seMaxLength.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.seMaxLength.Location = new System.Drawing.Point(396, 152);
            this.seMaxLength.Name = "seMaxLength";
            this.seMaxLength.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.seMaxLength.Properties.IsFloatValue = false;
            this.seMaxLength.Properties.Mask.EditMask = "N00";
            this.seMaxLength.Properties.MaxValue = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.seMaxLength.Size = new System.Drawing.Size(182, 20);
            this.seMaxLength.StyleController = this.layoutControl1;
            this.seMaxLength.TabIndex = 4;
            this.seMaxLength.EditValueChanged += new System.EventHandler(this.seMaxLength_EditValueChanged);
            // 
            // ceTab
            // 
            this.ceTab.Location = new System.Drawing.Point(336, 125);
            this.ceTab.Name = "ceTab";
            this.ceTab.Properties.Caption = "Accepts Tab";
            this.ceTab.Size = new System.Drawing.Size(242, 19);
            this.ceTab.StyleController = this.layoutControl1;
            this.ceTab.TabIndex = 3;
            this.ceTab.CheckedChanged += new System.EventHandler(this.ceTab_CheckedChanged);
            // 
            // ceReturn
            // 
            this.ceReturn.Location = new System.Drawing.Point(336, 98);
            this.ceReturn.Name = "ceReturn";
            this.ceReturn.Properties.Caption = "Accepts Return";
            this.ceReturn.Size = new System.Drawing.Size(242, 19);
            this.ceReturn.StyleController = this.layoutControl1;
            this.ceReturn.TabIndex = 2;
            this.ceReturn.CheckedChanged += new System.EventHandler(this.ceReturn_CheckedChanged);
            // 
            // ceWordWrap
            // 
            this.ceWordWrap.Location = new System.Drawing.Point(336, 71);
            this.ceWordWrap.Name = "ceWordWrap";
            this.ceWordWrap.Properties.Caption = "Word wrap";
            this.ceWordWrap.Size = new System.Drawing.Size(242, 19);
            this.ceWordWrap.StyleController = this.layoutControl1;
            this.ceWordWrap.TabIndex = 1;
            this.ceWordWrap.CheckedChanged += new System.EventHandler(this.ceWordWrap_CheckedChanged);
            // 
            // memoEditSample
            // 
            this.memoEditSample.EditValue = "";
            this.memoEditSample.Location = new System.Drawing.Point(40, 59);
            this.memoEditSample.Name = "memoEditSample";
            this.memoEditSample.Size = new System.Drawing.Size(216, 132);
            this.memoEditSample.StyleController = this.layoutControl1;
            this.memoEditSample.TabIndex = 0;
            // 
            // icbScrollBars
            // 
            this.icbScrollBars.EditValue = "imageComboBoxEdit1";
            this.icbScrollBars.Location = new System.Drawing.Point(396, 43);
            this.icbScrollBars.Name = "icbScrollBars";
            this.icbScrollBars.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.icbScrollBars.Size = new System.Drawing.Size(182, 20);
            this.icbScrollBars.StyleController = this.layoutControl1;
            this.icbScrollBars.TabIndex = 0;
            this.icbScrollBars.SelectedIndexChanged += new System.EventHandler(this.icbScrollBars_SelectedIndexChanged);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2,
            this.layoutControlGroup3});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(610, 232);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.Padding = new DevExpress.XtraLayout.Utils.Padding(25, 25, 25, 25);
            this.layoutControlGroup2.Size = new System.Drawing.Size(304, 212);
            this.layoutControlGroup2.Spacing = new DevExpress.XtraLayout.Utils.Padding(2, 30, 2, 2);
            this.layoutControlGroup2.Text = "Sample";
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.memoEditSample;
            this.layoutControlItem1.ControlAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.layoutControlItem1.FillControlToClientArea = false;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.MaxSize = new System.Drawing.Size(220, 136);
            this.layoutControlItem1.MinSize = new System.Drawing.Size(220, 136);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(220, 138);
            this.layoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            this.layoutControlItem1.TrimClientAreaToControl = false;
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
            this.layoutControlGroup3.Location = new System.Drawing.Point(304, 0);
            this.layoutControlGroup3.Name = "layoutControlGroup3";
            this.layoutControlGroup3.Padding = new DevExpress.XtraLayout.Utils.Padding(17, 17, 9, 17);
            this.layoutControlGroup3.Size = new System.Drawing.Size(286, 212);
            this.layoutControlGroup3.Text = "Properties";
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.icbScrollBars;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 1);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 4);
            this.layoutControlItem2.Size = new System.Drawing.Size(246, 26);
            this.layoutControlItem2.Text = "Scroll bars:";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(57, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.ceWordWrap;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 27);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 4, 4);
            this.layoutControlItem3.Size = new System.Drawing.Size(246, 27);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.ceReturn;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 54);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 4, 4);
            this.layoutControlItem4.Size = new System.Drawing.Size(246, 27);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.ceTab;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 81);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 4, 4);
            this.layoutControlItem5.Size = new System.Drawing.Size(246, 27);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.seMaxLength;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 108);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 4, 2);
            this.layoutControlItem6.Size = new System.Drawing.Size(246, 54);
            this.layoutControlItem6.Text = "Max length:";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(57, 13);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 0);
            this.emptySpaceItem1.MaxSize = new System.Drawing.Size(0, 1);
            this.emptySpaceItem1.MinSize = new System.Drawing.Size(220, 1);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(246, 1);
            this.emptySpaceItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // ModuleMemoEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.xtraTabControl1);
            this.Name = "ModuleMemoEdit";
            this.Size = new System.Drawing.Size(654, 424);
            this.Load += new System.EventHandler(this.ModuleMemoEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.seMaxLength.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceTab.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceReturn.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceWordWrap.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoEditSample.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icbScrollBars.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
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
        private DevExpress.XtraEditors.MemoEdit memoEditSample;
        private DevExpress.XtraEditors.ImageComboBoxEdit icbScrollBars;
        private DevExpress.XtraEditors.CheckEdit ceWordWrap;
        private DevExpress.XtraEditors.CheckEdit ceReturn;
        private DevExpress.XtraEditors.CheckEdit ceTab;
        private DevExpress.XtraEditors.SpinEdit seMaxLength;
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
