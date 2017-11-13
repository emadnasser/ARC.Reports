namespace DevExpress.ApplicationUI.Demos {
    partial class CustomHeaderButtons {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomHeaderButtons));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.rgTemplatesButton = new DevExpress.XtraEditors.RadioGroup();
            this.buttonPropertyGrid = new DevExpress.ApplicationUI.Demos.ButtonPropertyGrid();
            this.actionDockPanel = new DevExpress.ApplicationUI.Demos.ActionDockPanel();
            this.lcCustomButtons = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rgTemplatesButton.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcCustomButtons)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.rgTemplatesButton);
            this.layoutControl1.Controls.Add(this.buttonPropertyGrid);
            this.layoutControl1.Controls.Add(this.actionDockPanel);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(847, 192, 450, 350);
            this.layoutControl1.Root = this.lcCustomButtons;
            this.layoutControl1.Size = new System.Drawing.Size(819, 419);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // rgTemplatesButton
            // 
            this.rgTemplatesButton.AutoSizeInLayoutControl = true;
            this.rgTemplatesButton.EditValue = "";
            this.rgTemplatesButton.Location = new System.Drawing.Point(12, 12);
            this.rgTemplatesButton.Name = "rgTemplatesButton";
            this.rgTemplatesButton.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.rgTemplatesButton.Properties.Appearance.Options.UseBackColor = true;
            this.rgTemplatesButton.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.rgTemplatesButton.Properties.Columns = 1;
            this.rgTemplatesButton.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.rgTemplatesButton.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem("PushButton", "Push button"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("CheckButton", "Check Button"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("ButtonWithImage", "Button with image"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("ButtonWithGlyphs", "Button with glyphs")});
            this.rgTemplatesButton.Size = new System.Drawing.Size(115, 68);
            this.rgTemplatesButton.StyleController = this.layoutControl1;
            this.rgTemplatesButton.TabIndex = 6;
            this.rgTemplatesButton.SelectedIndexChanged += new System.EventHandler(this.TemplatesButtonSelectedIndexChanged);
            // 
            // buttonPropertyGrid
            // 
            this.buttonPropertyGrid.Location = new System.Drawing.Point(396, 12);
            this.buttonPropertyGrid.Margin = new System.Windows.Forms.Padding(4);
            this.buttonPropertyGrid.Name = "buttonPropertyGrid";
            this.buttonPropertyGrid.SelectObject = null;
            this.buttonPropertyGrid.Size = new System.Drawing.Size(411, 395);
            this.buttonPropertyGrid.TabIndex = 5;
            // 
            // actionDockPanel
            // 
            this.actionDockPanel.Location = new System.Drawing.Point(12, 84);
            this.actionDockPanel.Margin = new System.Windows.Forms.Padding(4);
            this.actionDockPanel.Name = "actionDockPanel";
            this.actionDockPanel.Size = new System.Drawing.Size(380, 323);
            this.actionDockPanel.TabIndex = 4;
            this.actionDockPanel.TextActions = "";
            // 
            // lcCustomButtons
            // 
            this.lcCustomButtons.CustomizationFormText = "lcCustomButtons";
            this.lcCustomButtons.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.lcCustomButtons.GroupBordersVisible = false;
            this.lcCustomButtons.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.emptySpaceItem1});
            this.lcCustomButtons.Location = new System.Drawing.Point(0, 0);
            this.lcCustomButtons.Name = "lcCustomButtons";
            this.lcCustomButtons.Size = new System.Drawing.Size(819, 419);
            this.lcCustomButtons.Text = "lcCustomButtons";
            this.lcCustomButtons.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.actionDockPanel;
            this.layoutControlItem1.CustomizationFormText = "layoutControlItem1";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 72);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(384, 327);
            this.layoutControlItem1.Text = "layoutControlItem1";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextToControlDistance = 0;
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.buttonPropertyGrid;
            this.layoutControlItem2.CustomizationFormText = "layoutControlItem2";
            this.layoutControlItem2.Location = new System.Drawing.Point(384, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(415, 399);
            this.layoutControlItem2.Text = "layoutControlItem2";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextToControlDistance = 0;
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.rgTemplatesButton;
            this.layoutControlItem3.CustomizationFormText = "layoutControlItem3";
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(119, 72);
            this.layoutControlItem3.Text = "layoutControlItem3";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextToControlDistance = 0;
            this.layoutControlItem3.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.CustomizationFormText = "emptySpaceItem1";
            this.emptySpaceItem1.Location = new System.Drawing.Point(119, 0);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(265, 72);
            this.emptySpaceItem1.Text = "emptySpaceItem1";
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Backward_16x16.png");
            this.imageList1.Images.SetKeyName(1, "Next_16x16.png");
            this.imageList1.Images.SetKeyName(2, "Apply_16x16.png");
            this.imageList1.Images.SetKeyName(3, "Unmark_16x16.png");
            this.imageList1.Images.SetKeyName(4, "Forward_16x16.png");
            this.imageList1.Images.SetKeyName(5, "Previous_16x16.png");
            // 
            // CustomHeaderButtons
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl1);
            this.Name = "CustomHeaderButtons";
            this.Size = new System.Drawing.Size(819, 419);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rgTemplatesButton.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcCustomButtons)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private ButtonPropertyGrid buttonPropertyGrid;
        private ActionDockPanel actionDockPanel;
        private DevExpress.XtraLayout.LayoutControlGroup lcCustomButtons;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraEditors.RadioGroup rgTemplatesButton;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private System.Windows.Forms.ImageList imageList1;
    }
}
