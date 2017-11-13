using System;
using DevExpress.XtraEditors;
using DevExpress.XtraPrinting.Control;

namespace DevExpress.Docs.Demos {
    public partial class SpreadsheetCustomViewModule {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code
        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        /// 
        void InitializeComponent() {
            this.zoomLabel = new DevExpress.XtraEditors.LabelControl();
            this.showGridCheckEdit = new DevExpress.XtraEditors.CheckEdit();
            this.showHeadingsCheckEdit = new DevExpress.XtraEditors.CheckEdit();
            this.useR1C1StyleCheckEdit = new DevExpress.XtraEditors.CheckEdit();
            this.saveButton = new DevExpress.XtraEditors.SimpleButton();
            this.tabColorLabel = new DevExpress.XtraEditors.LabelControl();
            this.tabColodEdit = new DevExpress.XtraEditors.ColorEdit();
            this.pageOrientationGroup = new DevExpress.XtraEditors.RadioGroup();
            this.viewTypeGroup = new DevExpress.XtraEditors.RadioGroup();
            this.zoomTrackBar = new DevExpress.XtraEditors.ZoomTrackBarControl();
            this.marginsPanel = new DevExpress.XtraEditors.GroupControl();
            this.footerMarginEdit = new DevExpress.XtraEditors.SpinEdit();
            this.footerMarginLabel = new DevExpress.XtraEditors.LabelControl();
            this.headerMarginEdit = new DevExpress.XtraEditors.SpinEdit();
            this.headerMarginLabel = new DevExpress.XtraEditors.LabelControl();
            this.topMarginLabel = new DevExpress.XtraEditors.LabelControl();
            this.topMarginEdit = new DevExpress.XtraEditors.SpinEdit();
            this.bottomMarginLabel = new DevExpress.XtraEditors.LabelControl();
            this.bottomMarginEdit = new DevExpress.XtraEditors.SpinEdit();
            this.rightMarginLabel = new DevExpress.XtraEditors.LabelControl();
            this.rightMarginEdit = new DevExpress.XtraEditors.SpinEdit();
            this.leftMarginLabel = new DevExpress.XtraEditors.LabelControl();
            this.leftMarginEdit = new DevExpress.XtraEditors.SpinEdit();
            this.pageOrientationPanel = new DevExpress.XtraEditors.GroupControl();
            this.paperKindBox = new DevExpress.XtraEditors.ComboBoxEdit();
            this.paperKindLabel = new DevExpress.XtraEditors.LabelControl();
            this.viewTypePanel = new DevExpress.XtraEditors.GroupControl();
            this.viewOptionsPanel = new DevExpress.XtraEditors.GroupControl();
            this.previewControl = new DevExpress.XtraPrinting.Control.PrintControl();
            ((System.ComponentModel.ISupportInitialize)(this.showGridCheckEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.showHeadingsCheckEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.useR1C1StyleCheckEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabColodEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pageOrientationGroup.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewTypeGroup.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zoomTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zoomTrackBar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marginsPanel)).BeginInit();
            this.marginsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.footerMarginEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.headerMarginEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.topMarginEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bottomMarginEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightMarginEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftMarginEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pageOrientationPanel)).BeginInit();
            this.pageOrientationPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paperKindBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewTypePanel)).BeginInit();
            this.viewTypePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewOptionsPanel)).BeginInit();
            this.viewOptionsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // zoomLabel
            // 
            this.zoomLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.zoomLabel.Location = new System.Drawing.Point(9, 137);
            this.zoomLabel.Name = "zoomLabel";
            this.zoomLabel.Size = new System.Drawing.Size(62, 13);
            this.zoomLabel.TabIndex = 1;
            this.zoomLabel.Text = "Zoom 100%:";
            // 
            // showGridCheckEdit
            // 
            this.showGridCheckEdit.EditValue = true;
            this.showGridCheckEdit.Location = new System.Drawing.Point(7, 28);
            this.showGridCheckEdit.Name = "showGridCheckEdit";
            this.showGridCheckEdit.Properties.AutoWidth = true;
            this.showGridCheckEdit.Properties.Caption = "Show Gridlines";
            this.showGridCheckEdit.Size = new System.Drawing.Size(92, 19);
            this.showGridCheckEdit.TabIndex = 2;
            // 
            // showHeadingsCheckEdit
            // 
            this.showHeadingsCheckEdit.EditValue = true;
            this.showHeadingsCheckEdit.Location = new System.Drawing.Point(7, 54);
            this.showHeadingsCheckEdit.Name = "showHeadingsCheckEdit";
            this.showHeadingsCheckEdit.Properties.AutoWidth = true;
            this.showHeadingsCheckEdit.Properties.Caption = "Show Headings";
            this.showHeadingsCheckEdit.Size = new System.Drawing.Size(96, 19);
            this.showHeadingsCheckEdit.TabIndex = 3;
            // 
            // useR1C1StyleCheckEdit
            // 
            this.useR1C1StyleCheckEdit.Location = new System.Drawing.Point(7, 80);
            this.useR1C1StyleCheckEdit.Name = "useR1C1StyleCheckEdit";
            this.useR1C1StyleCheckEdit.Properties.AutoWidth = true;
            this.useR1C1StyleCheckEdit.Properties.Caption = "Use R1C1 Style";
            this.useR1C1StyleCheckEdit.Size = new System.Drawing.Size(97, 19);
            this.useR1C1StyleCheckEdit.TabIndex = 4;
            // 
            // saveButton
            // 
            this.saveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.saveButton.Location = new System.Drawing.Point(586, 526);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 15;
            this.saveButton.Text = "Save As...";
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // tabColorLabel
            // 
            this.tabColorLabel.Location = new System.Drawing.Point(9, 109);
            this.tabColorLabel.Name = "tabColorLabel";
            this.tabColorLabel.Size = new System.Drawing.Size(50, 13);
            this.tabColorLabel.TabIndex = 4;
            this.tabColorLabel.Text = "Tab Color:";
            // 
            // tabColodEdit
            // 
            this.tabColodEdit.EditValue = System.Drawing.Color.Empty;
            this.tabColodEdit.Location = new System.Drawing.Point(66, 106);
            this.tabColodEdit.Name = "tabColodEdit";
            this.tabColodEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tabColodEdit.Size = new System.Drawing.Size(140, 20);
            this.tabColodEdit.TabIndex = 5;
            // 
            // pageOrientationGroup
            // 
            this.pageOrientationGroup.Location = new System.Drawing.Point(6, 26);
            this.pageOrientationGroup.Name = "pageOrientationGroup";
            this.pageOrientationGroup.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pageOrientationGroup.Properties.Appearance.Options.UseBackColor = true;
            this.pageOrientationGroup.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pageOrientationGroup.Size = new System.Drawing.Size(190, 70);
            this.pageOrientationGroup.TabIndex = 14;
            this.pageOrientationGroup.SelectedIndexChanged += new System.EventHandler(this.pageOrientationGroup_SelectedIndexChanged);
            // 
            // viewTypeGroup
            // 
            this.viewTypeGroup.Location = new System.Drawing.Point(6, 26);
            this.viewTypeGroup.Name = "viewTypeGroup";
            this.viewTypeGroup.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.viewTypeGroup.Properties.Appearance.Options.UseBackColor = true;
            this.viewTypeGroup.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.viewTypeGroup.Size = new System.Drawing.Size(190, 70);
            this.viewTypeGroup.TabIndex = 7;
            // 
            // zoomTrackBar
            // 
            this.zoomTrackBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.zoomTrackBar.EditValue = 100;
            this.zoomTrackBar.Location = new System.Drawing.Point(76, 133);
            this.zoomTrackBar.Name = "zoomTrackBar";
            this.zoomTrackBar.Properties.AllowUseMiddleValue = true;
            this.zoomTrackBar.Properties.LargeChange = 10;
            this.zoomTrackBar.Properties.Maximum = 400;
            this.zoomTrackBar.Properties.Middle = 100;
            this.zoomTrackBar.Properties.Minimum = 10;
            this.zoomTrackBar.Properties.ScrollThumbStyle = DevExpress.XtraEditors.Repository.ScrollThumbStyle.ArrowDownRight;
            this.zoomTrackBar.ShowToolTips = false;
            this.zoomTrackBar.Size = new System.Drawing.Size(128, 23);
            this.zoomTrackBar.TabIndex = 6;
            this.zoomTrackBar.Value = 100;
            this.zoomTrackBar.EditValueChanged += new System.EventHandler(this.zoomTrackBar_EditValueChanged);
            // 
            // marginsPanel
            // 
            this.marginsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.marginsPanel.Controls.Add(this.footerMarginEdit);
            this.marginsPanel.Controls.Add(this.footerMarginLabel);
            this.marginsPanel.Controls.Add(this.headerMarginEdit);
            this.marginsPanel.Controls.Add(this.headerMarginLabel);
            this.marginsPanel.Controls.Add(this.topMarginLabel);
            this.marginsPanel.Controls.Add(this.topMarginEdit);
            this.marginsPanel.Controls.Add(this.bottomMarginLabel);
            this.marginsPanel.Controls.Add(this.bottomMarginEdit);
            this.marginsPanel.Controls.Add(this.rightMarginLabel);
            this.marginsPanel.Controls.Add(this.rightMarginEdit);
            this.marginsPanel.Controls.Add(this.leftMarginLabel);
            this.marginsPanel.Controls.Add(this.leftMarginEdit);
            this.marginsPanel.Location = new System.Drawing.Point(449, 292);
            this.marginsPanel.Name = "marginsPanel";
            this.marginsPanel.Size = new System.Drawing.Size(212, 100);
            this.marginsPanel.TabIndex = 10;
            this.marginsPanel.Text = "Margins";
            // 
            // footerMarginEdit
            // 
            this.footerMarginEdit.EditValue = new decimal(new int[] {
            3,
            0,
            0,
            65536});
            this.footerMarginEdit.Location = new System.Drawing.Point(151, 75);
            this.footerMarginEdit.Name = "footerMarginEdit";
            this.footerMarginEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.footerMarginEdit.Properties.Increment = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            this.footerMarginEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.footerMarginEdit.Properties.MaxValue = new decimal(new int[] {
            1125,
            0,
            0,
            131072});
            this.footerMarginEdit.Size = new System.Drawing.Size(50, 20);
            this.footerMarginEdit.TabIndex = 13;
            this.footerMarginEdit.EditValueChanged += new System.EventHandler(this.footerMarginEdit_EditValueChanged);
            // 
            // footerMarginLabel
            // 
            this.footerMarginLabel.Location = new System.Drawing.Point(111, 78);
            this.footerMarginLabel.Name = "footerMarginLabel";
            this.footerMarginLabel.Size = new System.Drawing.Size(36, 13);
            this.footerMarginLabel.TabIndex = 1;
            this.footerMarginLabel.Text = "Footer:";
            // 
            // headerMarginEdit
            // 
            this.headerMarginEdit.EditValue = new decimal(new int[] {
            3,
            0,
            0,
            65536});
            this.headerMarginEdit.Location = new System.Drawing.Point(51, 75);
            this.headerMarginEdit.Name = "headerMarginEdit";
            this.headerMarginEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.headerMarginEdit.Properties.Increment = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            this.headerMarginEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.headerMarginEdit.Properties.MaxValue = new decimal(new int[] {
            1125,
            0,
            0,
            131072});
            this.headerMarginEdit.Size = new System.Drawing.Size(50, 20);
            this.headerMarginEdit.TabIndex = 12;
            this.headerMarginEdit.EditValueChanged += new System.EventHandler(this.headerMarginEdit_EditValueChanged);
            // 
            // headerMarginLabel
            // 
            this.headerMarginLabel.Location = new System.Drawing.Point(10, 78);
            this.headerMarginLabel.Name = "headerMarginLabel";
            this.headerMarginLabel.Size = new System.Drawing.Size(39, 13);
            this.headerMarginLabel.TabIndex = 3;
            this.headerMarginLabel.Text = "Header:";
            // 
            // topMarginLabel
            // 
            this.topMarginLabel.Location = new System.Drawing.Point(10, 28);
            this.topMarginLabel.Name = "topMarginLabel";
            this.topMarginLabel.Size = new System.Drawing.Size(22, 13);
            this.topMarginLabel.TabIndex = 4;
            this.topMarginLabel.Text = "Top:";
            // 
            // topMarginEdit
            // 
            this.topMarginEdit.EditValue = new decimal(new int[] {
            75,
            0,
            0,
            131072});
            this.topMarginEdit.Location = new System.Drawing.Point(51, 25);
            this.topMarginEdit.Name = "topMarginEdit";
            this.topMarginEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.topMarginEdit.Properties.Increment = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            this.topMarginEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.topMarginEdit.Properties.MaxValue = new decimal(new int[] {
            115,
            0,
            0,
            65536});
            this.topMarginEdit.Size = new System.Drawing.Size(50, 20);
            this.topMarginEdit.TabIndex = 8;
            this.topMarginEdit.EditValueChanged += new System.EventHandler(this.topMarginEdit_EditValueChanged);
            // 
            // bottomMarginLabel
            // 
            this.bottomMarginLabel.Location = new System.Drawing.Point(111, 28);
            this.bottomMarginLabel.Name = "bottomMarginLabel";
            this.bottomMarginLabel.Size = new System.Drawing.Size(38, 13);
            this.bottomMarginLabel.TabIndex = 6;
            this.bottomMarginLabel.Text = "Bottom:";
            // 
            // bottomMarginEdit
            // 
            this.bottomMarginEdit.EditValue = new decimal(new int[] {
            75,
            0,
            0,
            131072});
            this.bottomMarginEdit.Location = new System.Drawing.Point(151, 25);
            this.bottomMarginEdit.Name = "bottomMarginEdit";
            this.bottomMarginEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.bottomMarginEdit.Properties.Increment = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            this.bottomMarginEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.bottomMarginEdit.Properties.MaxValue = new decimal(new int[] {
            115,
            0,
            0,
            65536});
            this.bottomMarginEdit.Size = new System.Drawing.Size(50, 20);
            this.bottomMarginEdit.TabIndex = 9;
            this.bottomMarginEdit.EditValueChanged += new System.EventHandler(this.bottomMarginEdit_EditValueChanged);
            // 
            // rightMarginLabel
            // 
            this.rightMarginLabel.Location = new System.Drawing.Point(111, 53);
            this.rightMarginLabel.Name = "rightMarginLabel";
            this.rightMarginLabel.Size = new System.Drawing.Size(29, 13);
            this.rightMarginLabel.TabIndex = 8;
            this.rightMarginLabel.Text = "Right:";
            // 
            // rightMarginEdit
            // 
            this.rightMarginEdit.EditValue = new decimal(new int[] {
            7,
            0,
            0,
            65536});
            this.rightMarginEdit.Location = new System.Drawing.Point(151, 50);
            this.rightMarginEdit.Name = "rightMarginEdit";
            this.rightMarginEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.rightMarginEdit.Properties.Increment = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            this.rightMarginEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.rightMarginEdit.Properties.MaxValue = new decimal(new int[] {
            825,
            0,
            0,
            131072});
            this.rightMarginEdit.Size = new System.Drawing.Size(50, 20);
            this.rightMarginEdit.TabIndex = 11;
            this.rightMarginEdit.EditValueChanged += new System.EventHandler(this.rightMarginEdit_EditValueChanged);
            // 
            // leftMarginLabel
            // 
            this.leftMarginLabel.Location = new System.Drawing.Point(10, 53);
            this.leftMarginLabel.Name = "leftMarginLabel";
            this.leftMarginLabel.Size = new System.Drawing.Size(23, 13);
            this.leftMarginLabel.TabIndex = 10;
            this.leftMarginLabel.Text = "Left:";
            // 
            // leftMarginEdit
            // 
            this.leftMarginEdit.EditValue = new decimal(new int[] {
            7,
            0,
            0,
            65536});
            this.leftMarginEdit.Location = new System.Drawing.Point(51, 50);
            this.leftMarginEdit.Name = "leftMarginEdit";
            this.leftMarginEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.leftMarginEdit.Properties.Increment = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            this.leftMarginEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.leftMarginEdit.Properties.MaxValue = new decimal(new int[] {
            825,
            0,
            0,
            131072});
            this.leftMarginEdit.Size = new System.Drawing.Size(50, 20);
            this.leftMarginEdit.TabIndex = 10;
            this.leftMarginEdit.EditValueChanged += new System.EventHandler(this.leftMarginEdit_EditValueChanged);
            // 
            // pageOrientationPanel
            // 
            this.pageOrientationPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pageOrientationPanel.Controls.Add(this.pageOrientationGroup);
            this.pageOrientationPanel.Location = new System.Drawing.Point(449, 398);
            this.pageOrientationPanel.Name = "pageOrientationPanel";
            this.pageOrientationPanel.Size = new System.Drawing.Size(212, 100);
            this.pageOrientationPanel.TabIndex = 11;
            this.pageOrientationPanel.Text = "Page Orientation";
            // 
            // paperKindBox
            // 
            this.paperKindBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.paperKindBox.Location = new System.Drawing.Point(508, 266);
            this.paperKindBox.Name = "paperKindBox";
            this.paperKindBox.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.paperKindBox.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.paperKindBox.Size = new System.Drawing.Size(153, 20);
            this.paperKindBox.TabIndex = 7;
            this.paperKindBox.SelectedIndexChanged += new System.EventHandler(this.paperKindBox_SelectedIndexChanged);
            // 
            // paperKindLabel
            // 
            this.paperKindLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.paperKindLabel.Location = new System.Drawing.Point(449, 269);
            this.paperKindLabel.Name = "paperKindLabel";
            this.paperKindLabel.Size = new System.Drawing.Size(54, 13);
            this.paperKindLabel.TabIndex = 8;
            this.paperKindLabel.Text = "Paper Size:";
            // 
            // viewTypePanel
            // 
            this.viewTypePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.viewTypePanel.Controls.Add(this.viewTypeGroup);
            this.viewTypePanel.Location = new System.Drawing.Point(449, 0);
            this.viewTypePanel.Name = "viewTypePanel";
            this.viewTypePanel.Size = new System.Drawing.Size(212, 94);
            this.viewTypePanel.TabIndex = 0;
            this.viewTypePanel.Text = "View Type";
            // 
            // viewOptionsPanel
            // 
            this.viewOptionsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.viewOptionsPanel.Controls.Add(this.showGridCheckEdit);
            this.viewOptionsPanel.Controls.Add(this.showHeadingsCheckEdit);
            this.viewOptionsPanel.Controls.Add(this.zoomTrackBar);
            this.viewOptionsPanel.Controls.Add(this.useR1C1StyleCheckEdit);
            this.viewOptionsPanel.Controls.Add(this.zoomLabel);
            this.viewOptionsPanel.Controls.Add(this.tabColorLabel);
            this.viewOptionsPanel.Controls.Add(this.tabColodEdit);
            this.viewOptionsPanel.Location = new System.Drawing.Point(449, 100);
            this.viewOptionsPanel.Name = "viewOptionsPanel";
            this.viewOptionsPanel.Size = new System.Drawing.Size(212, 160);
            this.viewOptionsPanel.TabIndex = 1;
            this.viewOptionsPanel.Text = "View Options";
            // 
            // previewControl
            // 
            this.previewControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.previewControl.IsMetric = false;
            this.previewControl.Location = new System.Drawing.Point(0, 0);
            this.previewControl.Name = "previewControl";
            this.previewControl.Size = new System.Drawing.Size(443, 549);
            this.previewControl.TabIndex = 12;
            this.previewControl.TooltipFont = new System.Drawing.Font("Tahoma", 8.25F);
            // 
            // SpreadsheetCustomViewModule
            // 
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.paperKindLabel);
            this.Controls.Add(this.marginsPanel);
            this.Controls.Add(this.viewOptionsPanel);
            this.Controls.Add(this.viewTypePanel);
            this.Controls.Add(this.pageOrientationPanel);
            this.Controls.Add(this.paperKindBox);
            this.Controls.Add(this.previewControl);
            this.Name = "SpreadsheetCustomViewModule";
            this.Size = new System.Drawing.Size(667, 549);
            ((System.ComponentModel.ISupportInitialize)(this.showGridCheckEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.showHeadingsCheckEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.useR1C1StyleCheckEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabColodEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pageOrientationGroup.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewTypeGroup.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zoomTrackBar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zoomTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marginsPanel)).EndInit();
            this.marginsPanel.ResumeLayout(false);
            this.marginsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.footerMarginEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.headerMarginEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.topMarginEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bottomMarginEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightMarginEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftMarginEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pageOrientationPanel)).EndInit();
            this.pageOrientationPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.paperKindBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewTypePanel)).EndInit();
            this.viewTypePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.viewOptionsPanel)).EndInit();
            this.viewOptionsPanel.ResumeLayout(false);
            this.viewOptionsPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        LabelControl zoomLabel;
        CheckEdit showGridCheckEdit;
        CheckEdit showHeadingsCheckEdit;
        CheckEdit useR1C1StyleCheckEdit;
        SimpleButton saveButton;
        LabelControl tabColorLabel;
        ColorEdit tabColodEdit;
        RadioGroup pageOrientationGroup;
        RadioGroup viewTypeGroup;
        ZoomTrackBarControl zoomTrackBar;
        GroupControl marginsPanel;
        GroupControl pageOrientationPanel;
        LabelControl footerMarginLabel;
        SpinEdit footerMarginEdit;
        LabelControl headerMarginLabel;
        SpinEdit headerMarginEdit;
        LabelControl topMarginLabel;
        SpinEdit topMarginEdit;
        LabelControl bottomMarginLabel;
        SpinEdit bottomMarginEdit;
        LabelControl rightMarginLabel;
        SpinEdit rightMarginEdit;
        LabelControl leftMarginLabel;
        SpinEdit leftMarginEdit;
        LabelControl paperKindLabel;
        ComboBoxEdit paperKindBox;
        GroupControl viewTypePanel;
        GroupControl viewOptionsPanel;
        PrintControl previewControl;
    }
}
