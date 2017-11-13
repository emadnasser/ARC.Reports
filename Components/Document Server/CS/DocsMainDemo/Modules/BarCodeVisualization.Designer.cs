using DevExpress.XtraEditors;
using DevExpress.BarCodes;
using System.Drawing;
using System.Text;
using System;
namespace DevExpress.Docs.Demos {
    partial class BarCodeVisualization {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        PictureEdit pictureEdit;
        BarCode barCode;
        ComboBoxEdit symbologySelectCB;
        MemoEdit descriptionME;
        CheckEdit showTextCE;
        TextEdit barCodeText;
        ColorEdit backColorE;
        ColorEdit foreColorE;
        SpinEdit angleSE;
        GroupControl topCaptionGC;
        TextEdit topCaptionTE;
        TextEdit bottomCaptionTE;
        CheckEdit topCaptionCE;
        CheckEdit bottomCaptionCE;
        GroupControl barCogeGC;
        FontEdit codeTextFE;
        LabelControl codeTextLC;

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
        private void InitializeComponent() {
            this.pictureEdit = new DevExpress.XtraEditors.PictureEdit();
            this.symbologySelectCB = new DevExpress.XtraEditors.ComboBoxEdit();
            this.descriptionME = new DevExpress.XtraEditors.MemoEdit();
            this.showTextCE = new DevExpress.XtraEditors.CheckEdit();
            this.barCodeText = new DevExpress.XtraEditors.TextEdit();
            this.backColorE = new DevExpress.XtraEditors.ColorEdit();
            this.foreColorE = new DevExpress.XtraEditors.ColorEdit();
            this.angleSE = new DevExpress.XtraEditors.SpinEdit();
            this.topCaptionGC = new DevExpress.XtraEditors.GroupControl();
            this.topCaptionAligmentCB = new DevExpress.XtraEditors.ComboBoxEdit();
            this.topCaptionTE = new DevExpress.XtraEditors.TextEdit();
            this.topCaptionCE = new DevExpress.XtraEditors.CheckEdit();
            this.topCaptionForeCE = new DevExpress.XtraEditors.ColorEdit();
            this.topCaptionFE = new DevExpress.XtraEditors.FontEdit();
            this.TopCaptionTextLC = new DevExpress.XtraEditors.LabelControl();
            this.topCaptionAlignmentLC = new DevExpress.XtraEditors.LabelControl();
            this.topCaptionForeColorLC = new DevExpress.XtraEditors.LabelControl();
            this.topCaptionFontNameLC = new DevExpress.XtraEditors.LabelControl();
            this.bottomCaptionTE = new DevExpress.XtraEditors.TextEdit();
            this.bottomCaptionAligmentCB = new DevExpress.XtraEditors.ComboBoxEdit();
            this.bottomCaptionCE = new DevExpress.XtraEditors.CheckEdit();
            this.codeTextHorzAlignmentCB = new DevExpress.XtraEditors.ComboBoxEdit();
            this.codeTextVertAlignmentCB = new DevExpress.XtraEditors.ComboBoxEdit();
            this.barCogeGC = new DevExpress.XtraEditors.GroupControl();
            this.backcolorLC = new DevExpress.XtraEditors.LabelControl();
            this.foreColorLC = new DevExpress.XtraEditors.LabelControl();
            this.angleLC = new DevExpress.XtraEditors.LabelControl();
            this.codeTextFontLC = new DevExpress.XtraEditors.LabelControl();
            this.codeTextHorzAlignmentLC = new DevExpress.XtraEditors.LabelControl();
            this.codeTextVertAlignmentLC = new DevExpress.XtraEditors.LabelControl();
            this.codeTextLC = new DevExpress.XtraEditors.LabelControl();
            this.codeTextFE = new DevExpress.XtraEditors.FontEdit();
            this.bottomCaptionGC = new DevExpress.XtraEditors.GroupControl();
            this.bottomCaptionForeCE = new DevExpress.XtraEditors.ColorEdit();
            this.bottomCaptionFE = new DevExpress.XtraEditors.FontEdit();
            this.bottomCaptionTextLC = new DevExpress.XtraEditors.LabelControl();
            this.bottomCaptionAlignmentLC = new DevExpress.XtraEditors.LabelControl();
            this.bottomCaptionFontNameLC = new DevExpress.XtraEditors.LabelControl();
            this.bottomCaptionForeColorLC = new DevExpress.XtraEditors.LabelControl();
            this.errorText = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.symbologySelectCB.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.descriptionME.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.showTextCE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barCodeText.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backColorE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.foreColorE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.angleSE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.topCaptionGC)).BeginInit();
            this.topCaptionGC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.topCaptionAligmentCB.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.topCaptionTE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.topCaptionCE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.topCaptionForeCE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.topCaptionFE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bottomCaptionTE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bottomCaptionAligmentCB.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bottomCaptionCE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.codeTextHorzAlignmentCB.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.codeTextVertAlignmentCB.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barCogeGC)).BeginInit();
            this.barCogeGC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.codeTextFE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bottomCaptionGC)).BeginInit();
            this.bottomCaptionGC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bottomCaptionForeCE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bottomCaptionFE.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureEdit
            // 
            this.pictureEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureEdit.Location = new System.Drawing.Point(3, 29);
            this.pictureEdit.Name = "pictureEdit";
            this.pictureEdit.Properties.ShowMenu = false;
            this.pictureEdit.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.pictureEdit.Size = new System.Drawing.Size(377, 368);
            this.pictureEdit.TabIndex = 1;
            // 
            // symbologySelectCB
            // 
            this.symbologySelectCB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.symbologySelectCB.Location = new System.Drawing.Point(3, 3);
            this.symbologySelectCB.Name = "symbologySelectCB";
            this.symbologySelectCB.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.symbologySelectCB.Properties.DropDownRows = 20;
            this.symbologySelectCB.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.symbologySelectCB.Size = new System.Drawing.Size(377, 20);
            this.symbologySelectCB.TabIndex = 0;
            this.symbologySelectCB.SelectedIndexChanged += new System.EventHandler(this.editValueChanged);
            // 
            // descriptionME
            // 
            this.descriptionME.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.descriptionME.Location = new System.Drawing.Point(2, 403);
            this.descriptionME.Name = "descriptionME";
            this.descriptionME.Properties.ReadOnly = true;
            this.descriptionME.Properties.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.descriptionME.Size = new System.Drawing.Size(377, 156);
            this.descriptionME.TabIndex = 2;
            // 
            // showTextCE
            // 
            this.showTextCE.Location = new System.Drawing.Point(10, 24);
            this.showTextCE.Name = "showTextCE";
            this.showTextCE.Properties.Caption = "Show text";
            this.showTextCE.Size = new System.Drawing.Size(107, 19);
            this.showTextCE.TabIndex = 3;
            this.showTextCE.CheckStateChanged += new System.EventHandler(this.editValueChanged);
            // 
            // barCodeText
            // 
            this.barCodeText.Location = new System.Drawing.Point(75, 47);
            this.barCodeText.Name = "barCodeText";
            this.barCodeText.Size = new System.Drawing.Size(240, 20);
            this.barCodeText.TabIndex = 4;
            this.barCodeText.EditValueChanged += new System.EventHandler(this.editValueChanged);
            // 
            // backColorE
            // 
            this.backColorE.EditValue = System.Drawing.Color.White;
            this.backColorE.Location = new System.Drawing.Point(75, 205);
            this.backColorE.Name = "backColorE";
            this.backColorE.Size = new System.Drawing.Size(240, 20);
            this.backColorE.TabIndex = 10;
            this.backColorE.EditValueChanged += new System.EventHandler(this.editValueChanged);
            // 
            // foreColorE
            // 
            this.foreColorE.EditValue = System.Drawing.Color.Black;
            this.foreColorE.Location = new System.Drawing.Point(75, 179);
            this.foreColorE.Name = "foreColorE";
            this.foreColorE.Size = new System.Drawing.Size(240, 20);
            this.foreColorE.TabIndex = 9;
            this.foreColorE.EditValueChanged += new System.EventHandler(this.editValueChanged);
            // 
            // angleSE
            // 
            this.angleSE.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.angleSE.Location = new System.Drawing.Point(75, 153);
            this.angleSE.Name = "angleSE";
            this.angleSE.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.angleSE.Size = new System.Drawing.Size(240, 20);
            this.angleSE.TabIndex = 8;
            this.angleSE.EditValueChanged += new System.EventHandler(this.editValueChanged);
            // 
            // topCaptionGC
            // 
            this.topCaptionGC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.topCaptionGC.Controls.Add(this.topCaptionAligmentCB);
            this.topCaptionGC.Controls.Add(this.topCaptionTE);
            this.topCaptionGC.Controls.Add(this.topCaptionCE);
            this.topCaptionGC.Controls.Add(this.topCaptionForeCE);
            this.topCaptionGC.Controls.Add(this.topCaptionFE);
            this.topCaptionGC.Controls.Add(this.TopCaptionTextLC);
            this.topCaptionGC.Controls.Add(this.topCaptionAlignmentLC);
            this.topCaptionGC.Controls.Add(this.topCaptionForeColorLC);
            this.topCaptionGC.Controls.Add(this.topCaptionFontNameLC);
            this.topCaptionGC.Location = new System.Drawing.Point(385, 241);
            this.topCaptionGC.Name = "topCaptionGC";
            this.topCaptionGC.Size = new System.Drawing.Size(319, 156);
            this.topCaptionGC.TabIndex = 11;
            this.topCaptionGC.Text = "Top Caption";
            // 
            // topCaptionAligmentCB
            // 
            this.topCaptionAligmentCB.Location = new System.Drawing.Point(75, 76);
            this.topCaptionAligmentCB.Name = "topCaptionAligmentCB";
            this.topCaptionAligmentCB.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.topCaptionAligmentCB.Properties.DropDownRows = 20;
            this.topCaptionAligmentCB.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.topCaptionAligmentCB.Size = new System.Drawing.Size(239, 20);
            this.topCaptionAligmentCB.TabIndex = 13;
            this.topCaptionAligmentCB.SelectedIndexChanged += new System.EventHandler(this.editValueChanged);
            // 
            // topCaptionTE
            // 
            this.topCaptionTE.EditValue = "top caption";
            this.topCaptionTE.Location = new System.Drawing.Point(75, 50);
            this.topCaptionTE.Name = "topCaptionTE";
            this.topCaptionTE.Size = new System.Drawing.Size(239, 20);
            this.topCaptionTE.TabIndex = 12;
            this.topCaptionTE.EditValueChanged += new System.EventHandler(this.editValueChanged);
            // 
            // topCaptionCE
            // 
            this.topCaptionCE.Location = new System.Drawing.Point(10, 24);
            this.topCaptionCE.Name = "topCaptionCE";
            this.topCaptionCE.Properties.Caption = "Show Caption";
            this.topCaptionCE.Size = new System.Drawing.Size(109, 19);
            this.topCaptionCE.TabIndex = 11;
            this.topCaptionCE.EditValueChanged += new System.EventHandler(this.editValueChanged);
            // 
            // topCaptionForeCE
            // 
            this.topCaptionForeCE.EditValue = System.Drawing.Color.Black;
            this.topCaptionForeCE.Location = new System.Drawing.Point(75, 102);
            this.topCaptionForeCE.Name = "topCaptionForeCE";
            this.topCaptionForeCE.Size = new System.Drawing.Size(239, 20);
            this.topCaptionForeCE.TabIndex = 14;
            this.topCaptionForeCE.EditValueChanged += new System.EventHandler(this.editValueChanged);
            // 
            // topCaptionFE
            // 
            this.topCaptionFE.Location = new System.Drawing.Point(75, 128);
            this.topCaptionFE.Name = "topCaptionFE";
            this.topCaptionFE.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.topCaptionFE.Size = new System.Drawing.Size(239, 20);
            this.topCaptionFE.TabIndex = 15;
            this.topCaptionFE.EditValueChanged += new System.EventHandler(this.editValueChanged);
            // 
            // TopCaptionTextLC
            // 
            this.TopCaptionTextLC.Location = new System.Drawing.Point(12, 53);
            this.TopCaptionTextLC.Name = "TopCaptionTextLC";
            this.TopCaptionTextLC.Size = new System.Drawing.Size(26, 13);
            this.TopCaptionTextLC.TabIndex = 10;
            this.TopCaptionTextLC.Text = "Text:";
            // 
            // topCaptionAlignmentLC
            // 
            this.topCaptionAlignmentLC.Location = new System.Drawing.Point(12, 79);
            this.topCaptionAlignmentLC.Name = "topCaptionAlignmentLC";
            this.topCaptionAlignmentLC.Size = new System.Drawing.Size(51, 13);
            this.topCaptionAlignmentLC.TabIndex = 10;
            this.topCaptionAlignmentLC.Text = "Alignment:";
            // 
            // topCaptionForeColorLC
            // 
            this.topCaptionForeColorLC.Location = new System.Drawing.Point(12, 105);
            this.topCaptionForeColorLC.Name = "topCaptionForeColorLC";
            this.topCaptionForeColorLC.Size = new System.Drawing.Size(54, 13);
            this.topCaptionForeColorLC.TabIndex = 10;
            this.topCaptionForeColorLC.Text = "Fore Color:";
            // 
            // topCaptionFontNameLC
            // 
            this.topCaptionFontNameLC.Location = new System.Drawing.Point(13, 131);
            this.topCaptionFontNameLC.Name = "topCaptionFontNameLC";
            this.topCaptionFontNameLC.Size = new System.Drawing.Size(56, 13);
            this.topCaptionFontNameLC.TabIndex = 10;
            this.topCaptionFontNameLC.Text = "Font Name:";
            // 
            // bottomCaptionTE
            // 
            this.bottomCaptionTE.EditValue = "bottom caption";
            this.bottomCaptionTE.Location = new System.Drawing.Point(74, 50);
            this.bottomCaptionTE.Name = "bottomCaptionTE";
            this.bottomCaptionTE.Size = new System.Drawing.Size(239, 20);
            this.bottomCaptionTE.TabIndex = 17;
            this.bottomCaptionTE.EditValueChanged += new System.EventHandler(this.editValueChanged);
            // 
            // bottomCaptionAligmentCB
            // 
            this.bottomCaptionAligmentCB.Location = new System.Drawing.Point(74, 76);
            this.bottomCaptionAligmentCB.Name = "bottomCaptionAligmentCB";
            this.bottomCaptionAligmentCB.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.bottomCaptionAligmentCB.Properties.DropDownRows = 20;
            this.bottomCaptionAligmentCB.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.bottomCaptionAligmentCB.Size = new System.Drawing.Size(239, 20);
            this.bottomCaptionAligmentCB.TabIndex = 18;
            this.bottomCaptionAligmentCB.SelectedIndexChanged += new System.EventHandler(this.editValueChanged);
            // 
            // bottomCaptionCE
            // 
            this.bottomCaptionCE.Location = new System.Drawing.Point(10, 24);
            this.bottomCaptionCE.Name = "bottomCaptionCE";
            this.bottomCaptionCE.Properties.AutoWidth = true;
            this.bottomCaptionCE.Properties.Caption = "Show Caption";
            this.bottomCaptionCE.Size = new System.Drawing.Size(89, 19);
            this.bottomCaptionCE.TabIndex = 16;
            this.bottomCaptionCE.EditValueChanged += new System.EventHandler(this.editValueChanged);
            // 
            // codeTextHorzAlignmentCB
            // 
            this.codeTextHorzAlignmentCB.Location = new System.Drawing.Point(75, 101);
            this.codeTextHorzAlignmentCB.Name = "codeTextHorzAlignmentCB";
            this.codeTextHorzAlignmentCB.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.codeTextHorzAlignmentCB.Properties.DropDownRows = 20;
            this.codeTextHorzAlignmentCB.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.codeTextHorzAlignmentCB.Size = new System.Drawing.Size(240, 20);
            this.codeTextHorzAlignmentCB.TabIndex = 6;
            this.codeTextHorzAlignmentCB.SelectedIndexChanged += new System.EventHandler(this.editValueChanged);
            // 
            // codeTextVertAlignmentCB
            // 
            this.codeTextVertAlignmentCB.Location = new System.Drawing.Point(75, 75);
            this.codeTextVertAlignmentCB.Name = "codeTextVertAlignmentCB";
            this.codeTextVertAlignmentCB.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.codeTextVertAlignmentCB.Properties.DropDownRows = 20;
            this.codeTextVertAlignmentCB.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.codeTextVertAlignmentCB.Size = new System.Drawing.Size(240, 20);
            this.codeTextVertAlignmentCB.TabIndex = 5;
            this.codeTextVertAlignmentCB.SelectedIndexChanged += new System.EventHandler(this.editValueChanged);
            // 
            // barCogeGC
            // 
            this.barCogeGC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.barCogeGC.Controls.Add(this.showTextCE);
            this.barCogeGC.Controls.Add(this.barCodeText);
            this.barCogeGC.Controls.Add(this.codeTextVertAlignmentCB);
            this.barCogeGC.Controls.Add(this.backColorE);
            this.barCogeGC.Controls.Add(this.codeTextHorzAlignmentCB);
            this.barCogeGC.Controls.Add(this.foreColorE);
            this.barCogeGC.Controls.Add(this.backcolorLC);
            this.barCogeGC.Controls.Add(this.foreColorLC);
            this.barCogeGC.Controls.Add(this.angleLC);
            this.barCogeGC.Controls.Add(this.codeTextFontLC);
            this.barCogeGC.Controls.Add(this.codeTextHorzAlignmentLC);
            this.barCogeGC.Controls.Add(this.codeTextVertAlignmentLC);
            this.barCogeGC.Controls.Add(this.codeTextLC);
            this.barCogeGC.Controls.Add(this.codeTextFE);
            this.barCogeGC.Controls.Add(this.angleSE);
            this.barCogeGC.Location = new System.Drawing.Point(385, 3);
            this.barCogeGC.Name = "barCogeGC";
            this.barCogeGC.Size = new System.Drawing.Size(319, 232);
            this.barCogeGC.TabIndex = 3;
            this.barCogeGC.Text = "BarCode Properties";
            // 
            // backcolorLC
            // 
            this.backcolorLC.Location = new System.Drawing.Point(12, 207);
            this.backcolorLC.Name = "backcolorLC";
            this.backcolorLC.Size = new System.Drawing.Size(54, 13);
            this.backcolorLC.TabIndex = 10;
            this.backcolorLC.Text = "Back Color:";
            // 
            // foreColorLC
            // 
            this.foreColorLC.Location = new System.Drawing.Point(12, 181);
            this.foreColorLC.Name = "foreColorLC";
            this.foreColorLC.Size = new System.Drawing.Size(54, 13);
            this.foreColorLC.TabIndex = 10;
            this.foreColorLC.Text = "Fore Color:";
            // 
            // angleLC
            // 
            this.angleLC.Location = new System.Drawing.Point(12, 155);
            this.angleLC.Name = "angleLC";
            this.angleLC.Size = new System.Drawing.Size(31, 13);
            this.angleLC.TabIndex = 10;
            this.angleLC.Text = "Angle:";
            // 
            // codeTextFontLC
            // 
            this.codeTextFontLC.Location = new System.Drawing.Point(12, 129);
            this.codeTextFontLC.Name = "codeTextFontLC";
            this.codeTextFontLC.Size = new System.Drawing.Size(56, 13);
            this.codeTextFontLC.TabIndex = 10;
            this.codeTextFontLC.Text = "Font Name:";
            // 
            // codeTextHorzAlignmentLC
            // 
            this.codeTextHorzAlignmentLC.Location = new System.Drawing.Point(12, 103);
            this.codeTextHorzAlignmentLC.Name = "codeTextHorzAlignmentLC";
            this.codeTextHorzAlignmentLC.Size = new System.Drawing.Size(52, 13);
            this.codeTextHorzAlignmentLC.TabIndex = 10;
            this.codeTextHorzAlignmentLC.Text = "Horz Align:";
            // 
            // codeTextVertAlignmentLC
            // 
            this.codeTextVertAlignmentLC.Location = new System.Drawing.Point(12, 77);
            this.codeTextVertAlignmentLC.Name = "codeTextVertAlignmentLC";
            this.codeTextVertAlignmentLC.Size = new System.Drawing.Size(50, 13);
            this.codeTextVertAlignmentLC.TabIndex = 10;
            this.codeTextVertAlignmentLC.Text = "Vert Align:";
            // 
            // codeTextLC
            // 
            this.codeTextLC.Location = new System.Drawing.Point(12, 49);
            this.codeTextLC.Name = "codeTextLC";
            this.codeTextLC.Size = new System.Drawing.Size(26, 13);
            this.codeTextLC.TabIndex = 10;
            this.codeTextLC.Text = "Text:";
            // 
            // codeTextFE
            // 
            this.codeTextFE.Location = new System.Drawing.Point(75, 127);
            this.codeTextFE.Name = "codeTextFE";
            this.codeTextFE.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.codeTextFE.Size = new System.Drawing.Size(240, 20);
            this.codeTextFE.TabIndex = 7;
            this.codeTextFE.EditValueChanged += new System.EventHandler(this.editValueChanged);
            // 
            // bottomCaptionGC
            // 
            this.bottomCaptionGC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bottomCaptionGC.Controls.Add(this.bottomCaptionTE);
            this.bottomCaptionGC.Controls.Add(this.bottomCaptionCE);
            this.bottomCaptionGC.Controls.Add(this.bottomCaptionAligmentCB);
            this.bottomCaptionGC.Controls.Add(this.bottomCaptionForeCE);
            this.bottomCaptionGC.Controls.Add(this.bottomCaptionFE);
            this.bottomCaptionGC.Controls.Add(this.bottomCaptionTextLC);
            this.bottomCaptionGC.Controls.Add(this.bottomCaptionAlignmentLC);
            this.bottomCaptionGC.Controls.Add(this.bottomCaptionFontNameLC);
            this.bottomCaptionGC.Controls.Add(this.bottomCaptionForeColorLC);
            this.bottomCaptionGC.Location = new System.Drawing.Point(385, 403);
            this.bottomCaptionGC.Name = "bottomCaptionGC";
            this.bottomCaptionGC.Size = new System.Drawing.Size(318, 156);
            this.bottomCaptionGC.TabIndex = 16;
            this.bottomCaptionGC.Text = "Bottom Caption";
            // 
            // bottomCaptionForeCE
            // 
            this.bottomCaptionForeCE.EditValue = System.Drawing.Color.Black;
            this.bottomCaptionForeCE.Location = new System.Drawing.Point(74, 102);
            this.bottomCaptionForeCE.Name = "bottomCaptionForeCE";
            this.bottomCaptionForeCE.Size = new System.Drawing.Size(239, 20);
            this.bottomCaptionForeCE.TabIndex = 19;
            this.bottomCaptionForeCE.EditValueChanged += new System.EventHandler(this.editValueChanged);
            // 
            // bottomCaptionFE
            // 
            this.bottomCaptionFE.Location = new System.Drawing.Point(74, 128);
            this.bottomCaptionFE.Name = "bottomCaptionFE";
            this.bottomCaptionFE.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.bottomCaptionFE.Size = new System.Drawing.Size(239, 20);
            this.bottomCaptionFE.TabIndex = 20;
            this.bottomCaptionFE.EditValueChanged += new System.EventHandler(this.editValueChanged);
            // 
            // bottomCaptionTextLC
            // 
            this.bottomCaptionTextLC.Location = new System.Drawing.Point(11, 52);
            this.bottomCaptionTextLC.Name = "bottomCaptionTextLC";
            this.bottomCaptionTextLC.Size = new System.Drawing.Size(26, 13);
            this.bottomCaptionTextLC.TabIndex = 10;
            this.bottomCaptionTextLC.Text = "Text:";
            // 
            // bottomCaptionAlignmentLC
            // 
            this.bottomCaptionAlignmentLC.Location = new System.Drawing.Point(11, 78);
            this.bottomCaptionAlignmentLC.Name = "bottomCaptionAlignmentLC";
            this.bottomCaptionAlignmentLC.Size = new System.Drawing.Size(51, 13);
            this.bottomCaptionAlignmentLC.TabIndex = 10;
            this.bottomCaptionAlignmentLC.Text = "Alignment:";
            // 
            // bottomCaptionFontNameLC
            // 
            this.bottomCaptionFontNameLC.Location = new System.Drawing.Point(11, 130);
            this.bottomCaptionFontNameLC.Name = "bottomCaptionFontNameLC";
            this.bottomCaptionFontNameLC.Size = new System.Drawing.Size(56, 13);
            this.bottomCaptionFontNameLC.TabIndex = 10;
            this.bottomCaptionFontNameLC.Text = "Font Name:";
            // 
            // bottomCaptionForeColorLC
            // 
            this.bottomCaptionForeColorLC.Location = new System.Drawing.Point(11, 104);
            this.bottomCaptionForeColorLC.Name = "bottomCaptionForeColorLC";
            this.bottomCaptionForeColorLC.Size = new System.Drawing.Size(54, 13);
            this.bottomCaptionForeColorLC.TabIndex = 10;
            this.bottomCaptionForeColorLC.Text = "Fore Color:";
            // 
            // errorText
            // 
            this.errorText.Appearance.BackColor = System.Drawing.Color.White;
            this.errorText.Appearance.ForeColor = System.Drawing.Color.Red;
            this.errorText.LineColor = System.Drawing.Color.White;
            this.errorText.Location = new System.Drawing.Point(12, 376);
            this.errorText.Name = "errorText";
            this.errorText.Size = new System.Drawing.Size(189, 13);
            this.errorText.TabIndex = 17;
            this.errorText.Text = "BarCode text contains invalid symbol(s)";
            this.errorText.Visible = false;
            // 
            // BarCodeVisualization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.errorText);
            this.Controls.Add(this.pictureEdit);
            this.Controls.Add(this.symbologySelectCB);
            this.Controls.Add(this.descriptionME);
            this.Controls.Add(this.bottomCaptionGC);
            this.Controls.Add(this.topCaptionGC);
            this.Controls.Add(this.barCogeGC);
            this.Name = "BarCodeVisualization";
            this.Size = new System.Drawing.Size(712, 569);
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.symbologySelectCB.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.descriptionME.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.showTextCE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barCodeText.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backColorE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.foreColorE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.angleSE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.topCaptionGC)).EndInit();
            this.topCaptionGC.ResumeLayout(false);
            this.topCaptionGC.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.topCaptionAligmentCB.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.topCaptionTE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.topCaptionCE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.topCaptionForeCE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.topCaptionFE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bottomCaptionTE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bottomCaptionAligmentCB.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bottomCaptionCE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.codeTextHorzAlignmentCB.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.codeTextVertAlignmentCB.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barCogeGC)).EndInit();
            this.barCogeGC.ResumeLayout(false);
            this.barCogeGC.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.codeTextFE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bottomCaptionGC)).EndInit();
            this.bottomCaptionGC.ResumeLayout(false);
            this.bottomCaptionGC.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bottomCaptionForeCE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bottomCaptionFE.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private ComboBoxEdit bottomCaptionAligmentCB;
        private ComboBoxEdit topCaptionAligmentCB;
        private ComboBoxEdit codeTextHorzAlignmentCB;
        private ComboBoxEdit codeTextVertAlignmentCB;
        private GroupControl bottomCaptionGC;
        private ColorEdit topCaptionForeCE;
        private ColorEdit bottomCaptionForeCE;
        private FontEdit topCaptionFE;
        private FontEdit bottomCaptionFE;
        private LabelControl codeTextVertAlignmentLC;
        private LabelControl codeTextHorzAlignmentLC;
        private LabelControl TopCaptionTextLC;
        private LabelControl topCaptionAlignmentLC;
        private LabelControl topCaptionForeColorLC;
        private LabelControl topCaptionFontNameLC;
        private LabelControl backcolorLC;
        private LabelControl foreColorLC;
        private LabelControl angleLC;
        private LabelControl codeTextFontLC;
        private LabelControl bottomCaptionTextLC;
        private LabelControl bottomCaptionAlignmentLC;
        private LabelControl bottomCaptionFontNameLC;
        private LabelControl bottomCaptionForeColorLC;
        private LabelControl errorText;
    }
}
