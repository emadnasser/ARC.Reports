namespace DevExpress.ApplicationUI.Demos {
    partial class AlertControlProperties {
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.seAutoFormDelay = new DevExpress.XtraEditors.SpinEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.icbControlBoxPosition = new DevExpress.XtraEditors.ImageComboBoxEdit();
            this.icbFormDisplaySpeed = new DevExpress.XtraEditors.ImageComboBoxEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.icbFormLocation = new DevExpress.XtraEditors.ImageComboBoxEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.ceAllowHtmlText = new DevExpress.XtraEditors.CheckEdit();
            this.ceShowCloseButton = new DevExpress.XtraEditors.CheckEdit();
            this.ceShowPinButton = new DevExpress.XtraEditors.CheckEdit();
            this.ceShowPopupMenu = new DevExpress.XtraEditors.CheckEdit();
            this.ceShowTooltips = new DevExpress.XtraEditors.CheckEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.ccbeButtons = new DevExpress.XtraEditors.CheckedComboBoxEdit();
            this.ceAutoHeight = new DevExpress.XtraEditors.CheckEdit();
            this.icbShowingEffect = new DevExpress.XtraEditors.ImageComboBoxEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.seFormMaxCount = new DevExpress.XtraEditors.SpinEdit();
            this.ceAutoClose = new DevExpress.XtraEditors.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.seAutoFormDelay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icbControlBoxPosition.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icbFormDisplaySpeed.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icbFormLocation.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceAllowHtmlText.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceShowCloseButton.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceShowPinButton.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceShowPopupMenu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceShowTooltips.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ccbeButtons.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceAutoHeight.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icbShowingEffect.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seFormMaxCount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceAutoClose.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(14, 14);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(84, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Auto Form Delay:";
            // 
            // seAutoFormDelay
            // 
            this.seAutoFormDelay.EditValue = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.seAutoFormDelay.Location = new System.Drawing.Point(136, 11);
            this.seAutoFormDelay.Name = "seAutoFormDelay";
            this.seAutoFormDelay.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.seAutoFormDelay.Properties.IsFloatValue = false;
            this.seAutoFormDelay.Properties.Mask.EditMask = "N00";
            this.seAutoFormDelay.Properties.MaxValue = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.seAutoFormDelay.Properties.MinValue = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.seAutoFormDelay.Size = new System.Drawing.Size(172, 20);
            this.seAutoFormDelay.TabIndex = 0;
            this.seAutoFormDelay.EditValueChanged += new System.EventHandler(this.seAutoFormDelay_EditValueChanged);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(14, 40);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(100, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Control Box Position:";
            // 
            // icbControlBoxPosition
            // 
            this.icbControlBoxPosition.Location = new System.Drawing.Point(136, 37);
            this.icbControlBoxPosition.Name = "icbControlBoxPosition";
            this.icbControlBoxPosition.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.icbControlBoxPosition.Size = new System.Drawing.Size(172, 20);
            this.icbControlBoxPosition.TabIndex = 1;
            this.icbControlBoxPosition.SelectedIndexChanged += new System.EventHandler(this.icbControlBoxPosition_SelectedIndexChanged);
            // 
            // icbFormDisplaySpeed
            // 
            this.icbFormDisplaySpeed.Location = new System.Drawing.Point(136, 63);
            this.icbFormDisplaySpeed.Name = "icbFormDisplaySpeed";
            this.icbFormDisplaySpeed.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.icbFormDisplaySpeed.Size = new System.Drawing.Size(172, 20);
            this.icbFormDisplaySpeed.TabIndex = 2;
            this.icbFormDisplaySpeed.SelectedIndexChanged += new System.EventHandler(this.icbFormDisplaySpeed_SelectedIndexChanged);
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(14, 66);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(98, 13);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Form Display Speed:";
            // 
            // icbFormLocation
            // 
            this.icbFormLocation.Location = new System.Drawing.Point(136, 89);
            this.icbFormLocation.Name = "icbFormLocation";
            this.icbFormLocation.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.icbFormLocation.Size = new System.Drawing.Size(172, 20);
            this.icbFormLocation.TabIndex = 3;
            this.icbFormLocation.SelectedIndexChanged += new System.EventHandler(this.icbFormLocation_SelectedIndexChanged);
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(14, 92);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(71, 13);
            this.labelControl4.TabIndex = 3;
            this.labelControl4.Text = "Form Location:";
            // 
            // ceAllowHtmlText
            // 
            this.ceAllowHtmlText.Location = new System.Drawing.Point(134, 196);
            this.ceAllowHtmlText.Name = "ceAllowHtmlText";
            this.ceAllowHtmlText.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ceAllowHtmlText.Properties.Appearance.Options.UseFont = true;
            this.ceAllowHtmlText.Properties.Caption = "Allow Html Text";
            this.ceAllowHtmlText.Size = new System.Drawing.Size(174, 19);
            this.ceAllowHtmlText.TabIndex = 7;
            this.ceAllowHtmlText.CheckedChanged += new System.EventHandler(this.ceAllowHtmlText_CheckedChanged);
            // 
            // ceShowCloseButton
            // 
            this.ceShowCloseButton.Location = new System.Drawing.Point(134, 221);
            this.ceShowCloseButton.Name = "ceShowCloseButton";
            this.ceShowCloseButton.Properties.Caption = "Show Close Button";
            this.ceShowCloseButton.Size = new System.Drawing.Size(174, 19);
            this.ceShowCloseButton.TabIndex = 8;
            this.ceShowCloseButton.CheckedChanged += new System.EventHandler(this.ceShowCloseButton_CheckedChanged);
            // 
            // ceShowPinButton
            // 
            this.ceShowPinButton.Location = new System.Drawing.Point(134, 246);
            this.ceShowPinButton.Name = "ceShowPinButton";
            this.ceShowPinButton.Properties.Caption = "Show Pin Button";
            this.ceShowPinButton.Size = new System.Drawing.Size(174, 19);
            this.ceShowPinButton.TabIndex = 9;
            this.ceShowPinButton.CheckedChanged += new System.EventHandler(this.ceShowPinButton_CheckedChanged);
            // 
            // ceShowPopupMenu
            // 
            this.ceShowPopupMenu.Location = new System.Drawing.Point(134, 271);
            this.ceShowPopupMenu.Name = "ceShowPopupMenu";
            this.ceShowPopupMenu.Properties.Caption = "Show Popup Menu";
            this.ceShowPopupMenu.Size = new System.Drawing.Size(174, 19);
            this.ceShowPopupMenu.TabIndex = 10;
            this.ceShowPopupMenu.CheckedChanged += new System.EventHandler(this.ceShowPopupMenu_CheckedChanged);
            // 
            // ceShowTooltips
            // 
            this.ceShowTooltips.Location = new System.Drawing.Point(134, 296);
            this.ceShowTooltips.Name = "ceShowTooltips";
            this.ceShowTooltips.Properties.Caption = "Show Tooltips";
            this.ceShowTooltips.Size = new System.Drawing.Size(174, 19);
            this.ceShowTooltips.TabIndex = 11;
            this.ceShowTooltips.CheckedChanged += new System.EventHandler(this.ceShowTooltips_CheckedChanged);
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(14, 144);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(41, 13);
            this.labelControl6.TabIndex = 5;
            this.labelControl6.Text = "Buttons:";
            // 
            // ccbeButtons
            // 
            this.ccbeButtons.Location = new System.Drawing.Point(136, 141);
            this.ccbeButtons.Name = "ccbeButtons";
            this.ccbeButtons.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ccbeButtons.Size = new System.Drawing.Size(172, 20);
            this.ccbeButtons.TabIndex = 5;
            this.ccbeButtons.EditValueChanged += new System.EventHandler(this.ccbeButtons_EditValueChanged);
            // 
            // ceAutoHeight
            // 
            this.ceAutoHeight.Location = new System.Drawing.Point(134, 320);
            this.ceAutoHeight.Name = "ceAutoHeight";
            this.ceAutoHeight.Properties.AllowHtmlDraw = DevExpress.Utils.DefaultBoolean.True;
            this.ceAutoHeight.Properties.Caption = "<b>Auto</b> Height";
            this.ceAutoHeight.Size = new System.Drawing.Size(174, 19);
            this.ceAutoHeight.TabIndex = 12;
            this.ceAutoHeight.CheckedChanged += new System.EventHandler(this.ceAutoHeight_CheckedChanged);
            // 
            // icbShowingEffect
            // 
            this.icbShowingEffect.Location = new System.Drawing.Point(136, 115);
            this.icbShowingEffect.Name = "icbShowingEffect";
            this.icbShowingEffect.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.icbShowingEffect.Size = new System.Drawing.Size(172, 20);
            this.icbShowingEffect.TabIndex = 4;
            this.icbShowingEffect.SelectedIndexChanged += new System.EventHandler(this.icbShowingEffect_SelectedIndexChanged);
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(14, 118);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(103, 13);
            this.labelControl5.TabIndex = 18;
            this.labelControl5.Text = "Form Showing Effect:";
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(14, 170);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(83, 13);
            this.labelControl7.TabIndex = 19;
            this.labelControl7.Text = "Form Max Count:";
            // 
            // seFormMaxCount
            // 
            this.seFormMaxCount.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.seFormMaxCount.Location = new System.Drawing.Point(136, 167);
            this.seFormMaxCount.Name = "seFormMaxCount";
            this.seFormMaxCount.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.seFormMaxCount.Properties.IsFloatValue = false;
            this.seFormMaxCount.Properties.Mask.EditMask = "N00";
            this.seFormMaxCount.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.seFormMaxCount.Properties.MaxValue = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.seFormMaxCount.Size = new System.Drawing.Size(172, 20);
            this.seFormMaxCount.TabIndex = 6;
            this.seFormMaxCount.EditValueChanged += new System.EventHandler(this.seFormMaxCount_EditValueChanged);
            // 
            // ceAutoClose
            // 
            this.ceAutoClose.Location = new System.Drawing.Point(134, 345);
            this.ceAutoClose.Name = "ceAutoClose";
            this.ceAutoClose.Properties.AllowHtmlDraw = DevExpress.Utils.DefaultBoolean.True;
            this.ceAutoClose.Properties.Caption = "Auto Close Form On Click ";
            this.ceAutoClose.Size = new System.Drawing.Size(175, 19);
            this.ceAutoClose.TabIndex = 20;
            // 
            // AlertControlProperties
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ceAutoClose);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.icbShowingEffect);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.ceAutoHeight);
            this.Controls.Add(this.ccbeButtons);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.ceShowTooltips);
            this.Controls.Add(this.ceShowPopupMenu);
            this.Controls.Add(this.ceShowPinButton);
            this.Controls.Add(this.ceShowCloseButton);
            this.Controls.Add(this.ceAllowHtmlText);
            this.Controls.Add(this.icbFormLocation);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.icbFormDisplaySpeed);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.icbControlBoxPosition);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.seAutoFormDelay);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.seFormMaxCount);
            this.Name = "AlertControlProperties";
            this.Size = new System.Drawing.Size(321, 379);
            ((System.ComponentModel.ISupportInitialize)(this.seAutoFormDelay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icbControlBoxPosition.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icbFormDisplaySpeed.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icbFormLocation.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceAllowHtmlText.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceShowCloseButton.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceShowPinButton.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceShowPopupMenu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceShowTooltips.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ccbeButtons.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceAutoHeight.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icbShowingEffect.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seFormMaxCount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceAutoClose.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SpinEdit seAutoFormDelay;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.ImageComboBoxEdit icbControlBoxPosition;
        private DevExpress.XtraEditors.ImageComboBoxEdit icbFormDisplaySpeed;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.ImageComboBoxEdit icbFormLocation;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.CheckEdit ceAllowHtmlText;
        private DevExpress.XtraEditors.CheckEdit ceShowCloseButton;
        private DevExpress.XtraEditors.CheckEdit ceShowPinButton;
        private DevExpress.XtraEditors.CheckEdit ceShowPopupMenu;
        private DevExpress.XtraEditors.CheckEdit ceShowTooltips;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.CheckedComboBoxEdit ccbeButtons;
        private DevExpress.XtraEditors.CheckEdit ceAutoHeight;
        private DevExpress.XtraEditors.ImageComboBoxEdit icbShowingEffect;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.SpinEdit seFormMaxCount;
        private XtraEditors.CheckEdit ceAutoClose;
    }
}
