namespace DevExpress.XtraEditors.Demos {
    partial class ModuleColorEdit {
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
            this.seClear = new DevExpress.XtraEditors.SimpleButton();
            this.seAdd = new DevExpress.XtraEditors.SimpleButton();
            this.ceAsInteger = new DevExpress.XtraEditors.CheckEdit();
            this.ceShowColorDialog = new DevExpress.XtraEditors.CheckEdit();
            this.icbColorText = new DevExpress.XtraEditors.ImageComboBoxEdit();
            this.icbColorAlignment = new DevExpress.XtraEditors.ImageComboBoxEdit();
            this.colorEditSample = new DevExpress.XtraEditors.ColorEdit();
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
            this.layoutControlGroup4 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ceAsInteger.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceShowColorDialog.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icbColorText.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icbColorAlignment.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorEditSample.Properties)).BeginInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
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
            this.xtraTabControl1.Size = new System.Drawing.Size(859, 510);
            this.xtraTabControl1.TabIndex = 1;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1});
            this.xtraTabControl1.TabStop = false;
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.layoutControl1);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(853, 504);
            this.xtraTabPage1.Text = "xtraTabPage1";
            // 
            // seClear
            // 
            this.seClear.Enabled = false;
            this.seClear.Location = new System.Drawing.Point(395, 233);
            this.seClear.Name = "seClear";
            this.seClear.Size = new System.Drawing.Size(104, 22);
            this.seClear.StyleController = this.layoutControl1;
            this.seClear.TabIndex = 1;
            this.seClear.Text = "Clear";
            this.seClear.Click += new System.EventHandler(this.seClear_Click);
            // 
            // seAdd
            // 
            this.seAdd.Location = new System.Drawing.Point(283, 233);
            this.seAdd.Name = "seAdd";
            this.seAdd.Size = new System.Drawing.Size(108, 22);
            this.seAdd.StyleController = this.layoutControl1;
            this.seAdd.TabIndex = 0;
            this.seAdd.Text = "Create";
            this.seAdd.Click += new System.EventHandler(this.seAdd_Click);
            // 
            // ceAsInteger
            // 
            this.ceAsInteger.Location = new System.Drawing.Point(283, 133);
            this.ceAsInteger.Name = "ceAsInteger";
            this.ceAsInteger.Properties.Caption = "Store Color as Integer";
            this.ceAsInteger.Size = new System.Drawing.Size(216, 19);
            this.ceAsInteger.StyleController = this.layoutControl1;
            this.ceAsInteger.TabIndex = 18;
            this.ceAsInteger.CheckedChanged += new System.EventHandler(this.ceIsInteger_CheckedChanged);
            // 
            // ceShowColorDialog
            // 
            this.ceShowColorDialog.Location = new System.Drawing.Point(283, 106);
            this.ceShowColorDialog.Name = "ceShowColorDialog";
            this.ceShowColorDialog.Properties.Caption = "Show Color Dialog";
            this.ceShowColorDialog.Size = new System.Drawing.Size(216, 19);
            this.ceShowColorDialog.StyleController = this.layoutControl1;
            this.ceShowColorDialog.TabIndex = 17;
            this.ceShowColorDialog.CheckedChanged += new System.EventHandler(this.ceShowColorDialog_CheckedChanged);
            // 
            // icbColorText
            // 
            this.icbColorText.EditValue = "imageComboBoxEdit2";
            this.icbColorText.Location = new System.Drawing.Point(366, 78);
            this.icbColorText.Name = "icbColorText";
            this.icbColorText.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.icbColorText.Size = new System.Drawing.Size(133, 20);
            this.icbColorText.StyleController = this.layoutControl1;
            this.icbColorText.TabIndex = 16;
            this.icbColorText.SelectedIndexChanged += new System.EventHandler(this.icbColorText_SelectedIndexChanged);
            // 
            // icbColorAlignment
            // 
            this.icbColorAlignment.EditValue = "imageComboBoxEdit1";
            this.icbColorAlignment.Location = new System.Drawing.Point(366, 50);
            this.icbColorAlignment.Name = "icbColorAlignment";
            this.icbColorAlignment.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.icbColorAlignment.Size = new System.Drawing.Size(133, 20);
            this.icbColorAlignment.StyleController = this.layoutControl1;
            this.icbColorAlignment.TabIndex = 15;
            this.icbColorAlignment.SelectedIndexChanged += new System.EventHandler(this.icbColorAlignment_SelectedIndexChanged);
            // 
            // colorEditSample
            // 
            this.colorEditSample.EditValue = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.colorEditSample.Location = new System.Drawing.Point(15, 142);
            this.colorEditSample.Name = "colorEditSample";
            this.colorEditSample.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.colorEditSample.Size = new System.Drawing.Size(196, 20);
            this.colorEditSample.StyleController = this.layoutControl1;
            this.colorEditSample.TabIndex = 0;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.seClear);
            this.layoutControl1.Controls.Add(this.ceAsInteger);
            this.layoutControl1.Controls.Add(this.seAdd);
            this.layoutControl1.Controls.Add(this.ceShowColorDialog);
            this.layoutControl1.Controls.Add(this.colorEditSample);
            this.layoutControl1.Controls.Add(this.icbColorText);
            this.layoutControl1.Controls.Add(this.icbColorAlignment);
            this.layoutControl1.Location = new System.Drawing.Point(33, 27);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(1056, 7, 650, 400);
            this.layoutControl1.OptionsView.UseParentAutoScaleFactor = true;
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(548, 285);
            this.layoutControl1.TabIndex = 4;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2,
            this.layoutControlGroup3,
            this.layoutControlGroup4});
            this.layoutControlGroup1.Location = new System.Drawing.Point(-17, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(548, 287);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.colorEditSample;
            this.layoutControlItem1.ControlAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.layoutControlItem1.FillControlToClientArea = false;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.MinSize = new System.Drawing.Size(200, 24);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(200, 209);
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
            this.layoutControlGroup2.Size = new System.Drawing.Size(268, 267);
            this.layoutControlGroup2.Spacing = new DevExpress.XtraLayout.Utils.Padding(2, 30, 2, 2);
            this.layoutControlGroup2.Text = "Sample";
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.icbColorAlignment;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 4);
            this.layoutControlItem2.Size = new System.Drawing.Size(220, 26);
            this.layoutControlItem2.Text = "Color Alignment:";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(79, 13);
            // 
            // layoutControlGroup3
            // 
            this.layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.emptySpaceItem1});
            this.layoutControlGroup3.Location = new System.Drawing.Point(268, 0);
            this.layoutControlGroup3.Name = "layoutControlGroup3";
            this.layoutControlGroup3.Padding = new DevExpress.XtraLayout.Utils.Padding(17, 17, 17, 17);
            this.layoutControlGroup3.Size = new System.Drawing.Size(260, 183);
            this.layoutControlGroup3.Spacing = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 20);
            this.layoutControlGroup3.Text = "Properties";
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.icbColorText;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 26);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 4, 4);
            this.layoutControlItem3.Size = new System.Drawing.Size(220, 28);
            this.layoutControlItem3.Text = "Color Text:";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(79, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.ceShowColorDialog;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 54);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 4, 4);
            this.layoutControlItem4.Size = new System.Drawing.Size(220, 27);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.ceAsInteger;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 81);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 4, 2);
            this.layoutControlItem5.Size = new System.Drawing.Size(220, 25);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.seAdd;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(112, 26);
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextVisible = false;
            // 
            // layoutControlGroup4
            // 
            this.layoutControlGroup4.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem6,
            this.layoutControlItem7});
            this.layoutControlGroup4.Location = new System.Drawing.Point(268, 183);
            this.layoutControlGroup4.Name = "layoutControlGroup4";
            this.layoutControlGroup4.Padding = new DevExpress.XtraLayout.Utils.Padding(17, 17, 17, 17);
            this.layoutControlGroup4.Size = new System.Drawing.Size(260, 84);
            this.layoutControlGroup4.Text = "Custom Colors";
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.seClear;
            this.layoutControlItem7.Location = new System.Drawing.Point(112, 0);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(108, 26);
            this.layoutControlItem7.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem7.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 106);
            this.emptySpaceItem1.MinSize = new System.Drawing.Size(220, 1);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(220, 1);
            this.emptySpaceItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // ModuleColorEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.xtraTabControl1);
            this.Name = "ModuleColorEdit";
            this.Size = new System.Drawing.Size(864, 515);
            this.Load += new System.EventHandler(this.ModuleColorEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ceAsInteger.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceShowColorDialog.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icbColorText.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icbColorAlignment.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorEditSample.Properties)).EndInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraEditors.ColorEdit colorEditSample;
        private DevExpress.XtraEditors.ImageComboBoxEdit icbColorAlignment;
        private DevExpress.XtraEditors.ImageComboBoxEdit icbColorText;
        private DevExpress.XtraEditors.CheckEdit ceShowColorDialog;
        private DevExpress.XtraEditors.SimpleButton seAdd;
        private DevExpress.XtraEditors.SimpleButton seClear;
        private DevExpress.XtraEditors.CheckEdit ceAsInteger;
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
        private XtraLayout.EmptySpaceItem emptySpaceItem1;
        private XtraLayout.LayoutControlGroup layoutControlGroup4;
        private XtraLayout.LayoutControlItem layoutControlItem6;
        private XtraLayout.LayoutControlItem layoutControlItem7;

    }
}
