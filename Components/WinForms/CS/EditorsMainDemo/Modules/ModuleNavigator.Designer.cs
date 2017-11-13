namespace DevExpress.XtraEditors.Demos {
    partial class ModuleNavigator {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModuleNavigator));
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.groupControl5 = new DevExpress.XtraEditors.GroupControl();
            this.meFiringEvents = new DevExpress.XtraEditors.MemoEdit();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.ceShowPageButtons = new DevExpress.XtraEditors.CheckEdit();
            this.ceShowAppendRemove = new DevExpress.XtraEditors.CheckEdit();
            this.ceShowEditingButtons = new DevExpress.XtraEditors.CheckEdit();
            this.ceShowCustomButtons = new DevExpress.XtraEditors.CheckEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.ceShowToolTips = new DevExpress.XtraEditors.CheckEdit();
            this.ceEnableAutoRepeat = new DevExpress.XtraEditors.CheckEdit();
            this.icbTextLocations = new DevExpress.XtraEditors.ImageComboBoxEdit();
            this.label3 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl1 = new DevExpress.XtraEditors.GroupControl();
            this.dataNavigatorSample = new DevExpress.XtraEditors.DataNavigator();
            this.imlSmall = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl5)).BeginInit();
            this.groupControl5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.meFiringEvents.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ceShowPageButtons.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceShowAppendRemove.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceShowEditingButtons.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceShowCustomButtons.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ceShowToolTips.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceEnableAutoRepeat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icbTextLocations.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(5, 0);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.ShowTabHeader = DevExpress.Utils.DefaultBoolean.False;
            this.xtraTabControl1.Size = new System.Drawing.Size(935, 611);
            this.xtraTabControl1.TabIndex = 1;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1});
            this.xtraTabControl1.TabStop = false;
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.groupControl5);
            this.xtraTabPage1.Controls.Add(this.groupControl2);
            this.xtraTabPage1.Controls.Add(this.groupControl1);
            this.xtraTabPage1.Controls.Add(this.panelControl1);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(929, 605);
            this.xtraTabPage1.Text = "xtraTabPage1";
            // 
            // groupControl5
            // 
            this.groupControl5.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.groupControl5.Appearance.Options.UseBackColor = true;
            this.groupControl5.Controls.Add(this.meFiringEvents);
            this.groupControl5.Location = new System.Drawing.Point(439, 183);
            this.groupControl5.Name = "groupControl5";
            this.groupControl5.Padding = new System.Windows.Forms.Padding(8);
            this.groupControl5.Size = new System.Drawing.Size(283, 136);
            this.groupControl5.TabIndex = 5;
            this.groupControl5.Text = "Button event log";
            // 
            // meFiringEvents
            // 
            this.meFiringEvents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.meFiringEvents.EditValue = "";
            this.meFiringEvents.Location = new System.Drawing.Point(10, 29);
            this.meFiringEvents.Name = "meFiringEvents";
            this.meFiringEvents.Properties.Appearance.BackColor = System.Drawing.SystemColors.Info;
            this.meFiringEvents.Properties.Appearance.ForeColor = System.Drawing.SystemColors.InfoText;
            this.meFiringEvents.Properties.Appearance.Options.UseBackColor = true;
            this.meFiringEvents.Properties.Appearance.Options.UseForeColor = true;
            this.meFiringEvents.Properties.ReadOnly = true;
            this.meFiringEvents.Size = new System.Drawing.Size(263, 97);
            this.meFiringEvents.TabIndex = 0;
            this.meFiringEvents.TabStop = false;
            this.meFiringEvents.UseOptimizedRendering = true;
            // 
            // groupControl2
            // 
            this.groupControl2.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.groupControl2.Appearance.Options.UseBackColor = true;
            this.groupControl2.Controls.Add(this.ceShowPageButtons);
            this.groupControl2.Controls.Add(this.ceShowAppendRemove);
            this.groupControl2.Controls.Add(this.ceShowEditingButtons);
            this.groupControl2.Controls.Add(this.ceShowCustomButtons);
            this.groupControl2.Location = new System.Drawing.Point(30, 183);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(388, 136);
            this.groupControl2.TabIndex = 3;
            this.groupControl2.Text = "Show buttons";
            // 
            // ceShowPageButtons
            // 
            this.ceShowPageButtons.Location = new System.Drawing.Point(12, 100);
            this.ceShowPageButtons.Name = "ceShowPageButtons";
            this.ceShowPageButtons.Properties.Caption = "Show page buttons";
            this.ceShowPageButtons.Size = new System.Drawing.Size(208, 19);
            this.ceShowPageButtons.TabIndex = 23;
            this.ceShowPageButtons.CheckedChanged += new System.EventHandler(this.ceShowPageButtons_CheckedChanged);
            // 
            // ceShowAppendRemove
            // 
            this.ceShowAppendRemove.Location = new System.Drawing.Point(12, 76);
            this.ceShowAppendRemove.Name = "ceShowAppendRemove";
            this.ceShowAppendRemove.Properties.Caption = "Show Append/Remove buttons";
            this.ceShowAppendRemove.Size = new System.Drawing.Size(208, 19);
            this.ceShowAppendRemove.TabIndex = 22;
            this.ceShowAppendRemove.CheckedChanged += new System.EventHandler(this.ceShowAppendRemove_CheckedChanged);
            // 
            // ceShowEditingButtons
            // 
            this.ceShowEditingButtons.Location = new System.Drawing.Point(12, 52);
            this.ceShowEditingButtons.Name = "ceShowEditingButtons";
            this.ceShowEditingButtons.Properties.Caption = "Show editing buttons";
            this.ceShowEditingButtons.Size = new System.Drawing.Size(208, 19);
            this.ceShowEditingButtons.TabIndex = 21;
            this.ceShowEditingButtons.CheckedChanged += new System.EventHandler(this.ceShowEditingButtons_CheckedChanged);
            // 
            // ceShowCustomButtons
            // 
            this.ceShowCustomButtons.Location = new System.Drawing.Point(12, 28);
            this.ceShowCustomButtons.Name = "ceShowCustomButtons";
            this.ceShowCustomButtons.Properties.Caption = "Show custom buttons";
            this.ceShowCustomButtons.Size = new System.Drawing.Size(208, 19);
            this.ceShowCustomButtons.TabIndex = 20;
            this.ceShowCustomButtons.CheckedChanged += new System.EventHandler(this.ceShowCustomButtons_CheckedChanged);
            // 
            // groupControl1
            // 
            this.groupControl1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.groupControl1.Appearance.Options.UseBackColor = true;
            this.groupControl1.Controls.Add(this.ceShowToolTips);
            this.groupControl1.Controls.Add(this.ceEnableAutoRepeat);
            this.groupControl1.Controls.Add(this.icbTextLocations);
            this.groupControl1.Controls.Add(this.label3);
            this.groupControl1.Location = new System.Drawing.Point(439, 30);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(283, 132);
            this.groupControl1.TabIndex = 2;
            this.groupControl1.Text = "Properties";
            // 
            // ceShowToolTips
            // 
            this.ceShowToolTips.Location = new System.Drawing.Point(18, 86);
            this.ceShowToolTips.Name = "ceShowToolTips";
            this.ceShowToolTips.Properties.Caption = "Show tooltips";
            this.ceShowToolTips.Size = new System.Drawing.Size(140, 19);
            this.ceShowToolTips.TabIndex = 19;
            this.ceShowToolTips.CheckedChanged += new System.EventHandler(this.ceShowToolTips_CheckedChanged);
            // 
            // ceEnableAutoRepeat
            // 
            this.ceEnableAutoRepeat.Location = new System.Drawing.Point(18, 61);
            this.ceEnableAutoRepeat.Name = "ceEnableAutoRepeat";
            this.ceEnableAutoRepeat.Properties.Caption = "Enable auto-repeat";
            this.ceEnableAutoRepeat.Size = new System.Drawing.Size(140, 19);
            this.ceEnableAutoRepeat.TabIndex = 18;
            this.ceEnableAutoRepeat.CheckedChanged += new System.EventHandler(this.ceEnableAutoRepeat_CheckedChanged);
            // 
            // icbTextLocations
            // 
            this.icbTextLocations.EditValue = "imageComboBoxEdit1";
            this.icbTextLocations.Location = new System.Drawing.Point(107, 32);
            this.icbTextLocations.Name = "icbTextLocations";
            this.icbTextLocations.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.icbTextLocations.Size = new System.Drawing.Size(155, 20);
            this.icbTextLocations.TabIndex = 16;
            this.icbTextLocations.SelectedIndexChanged += new System.EventHandler(this.icbTextLocations_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(20, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Text location:";
            // 
            // panelControl1
            // 
            this.panelControl1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.panelControl1.Appearance.Options.UseBackColor = true;
            this.panelControl1.Controls.Add(this.dataNavigatorSample);
            this.panelControl1.Location = new System.Drawing.Point(30, 30);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(388, 132);
            this.panelControl1.TabIndex = 1;
            this.panelControl1.Text = "Sample";
            // 
            // dataNavigatorSample
            // 
            this.dataNavigatorSample.Buttons.ImageList = this.imlSmall;
            this.dataNavigatorSample.CustomButtons.AddRange(new DevExpress.XtraEditors.NavigatorCustomButton[] {
            new DevExpress.XtraEditors.NavigatorCustomButton(-1, 2, true, true, "Search", "Search"),
            new DevExpress.XtraEditors.NavigatorCustomButton(-1, 0, true, true, "Lock", "Lock")});
            this.dataNavigatorSample.Location = new System.Drawing.Point(12, 36);
            this.dataNavigatorSample.Name = "dataNavigatorSample";
            this.dataNavigatorSample.Size = new System.Drawing.Size(282, 24);
            this.dataNavigatorSample.TabIndex = 0;
            this.dataNavigatorSample.Text = "dataNavigator1";
            this.dataNavigatorSample.ButtonClick += new DevExpress.XtraEditors.NavigatorButtonClickEventHandler(this.dataNavigatorSample_ButtonClick);
            // 
            // imlSmall
            // 
            this.imlSmall.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imlSmall.ImageStream")));
            this.imlSmall.TransparentColor = System.Drawing.Color.Magenta;
            this.imlSmall.Images.SetKeyName(0, "");
            this.imlSmall.Images.SetKeyName(1, "");
            this.imlSmall.Images.SetKeyName(2, "");
            this.imlSmall.Images.SetKeyName(3, "");
            // 
            // ModuleNavigator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.xtraTabControl1);
            this.Name = "ModuleNavigator";
            this.Size = new System.Drawing.Size(940, 616);
            this.Load += new System.EventHandler(this.ModuleNavigator_Load);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl5)).EndInit();
            this.groupControl5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.meFiringEvents.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ceShowPageButtons.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceShowAppendRemove.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceShowEditingButtons.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceShowCustomButtons.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ceShowToolTips.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceEnableAutoRepeat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icbTextLocations.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.ComponentModel.IContainer components = null;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraEditors.GroupControl panelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.ImageComboBoxEdit icbTextLocations;
        private DevExpress.XtraEditors.LabelControl label3;
        private DevExpress.XtraEditors.CheckEdit ceEnableAutoRepeat;
        private DevExpress.XtraEditors.CheckEdit ceShowToolTips;
        private System.Windows.Forms.ImageList imlSmall;
        private DevExpress.XtraEditors.CheckEdit ceShowCustomButtons;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.CheckEdit ceShowEditingButtons;
        private DevExpress.XtraEditors.CheckEdit ceShowAppendRemove;
        private DevExpress.XtraEditors.CheckEdit ceShowPageButtons;
        private DevExpress.XtraEditors.GroupControl groupControl5;
        private DevExpress.XtraEditors.MemoEdit meFiringEvents;
        private DevExpress.XtraEditors.DataNavigator dataNavigatorSample;

    }
}
