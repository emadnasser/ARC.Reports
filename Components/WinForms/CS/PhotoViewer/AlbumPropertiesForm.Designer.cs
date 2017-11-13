namespace PhotoViewer {
    partial class AlbumPropertiesForm {
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
            this.albumNameEdit = new DevExpress.XtraEditors.TextEdit();
            this.albumDate = new DevExpress.XtraEditors.DateEdit();
            this.albumDescription = new DevExpress.XtraEditors.MemoEdit();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.layoutConverter1 = new DevExpress.XtraLayout.Converter.LayoutConverter(this.components);
            this.AlbumPropertiesFormConvertedLayout = new DevExpress.XtraLayout.LayoutControl();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)(this.albumNameEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.albumDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.albumDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.albumDescription.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AlbumPropertiesFormConvertedLayout)).BeginInit();
            this.AlbumPropertiesFormConvertedLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // albumNameEdit
            // 
            this.albumNameEdit.Location = new System.Drawing.Point(78, 12);
            this.albumNameEdit.Name = "albumNameEdit";
            this.albumNameEdit.Size = new System.Drawing.Size(309, 20);
            this.albumNameEdit.StyleController = this.AlbumPropertiesFormConvertedLayout;
            this.albumNameEdit.TabIndex = 1;
            // 
            // albumDate
            // 
            this.albumDate.EditValue = null;
            this.albumDate.Location = new System.Drawing.Point(78, 36);
            this.albumDate.Name = "albumDate";
            this.albumDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.albumDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.albumDate.Size = new System.Drawing.Size(309, 20);
            this.albumDate.StyleController = this.AlbumPropertiesFormConvertedLayout;
            this.albumDate.TabIndex = 3;
            // 
            // albumDescription
            // 
            this.albumDescription.Location = new System.Drawing.Point(78, 60);
            this.albumDescription.Name = "albumDescription";
            this.albumDescription.Size = new System.Drawing.Size(309, 109);
            this.albumDescription.StyleController = this.AlbumPropertiesFormConvertedLayout;
            this.albumDescription.TabIndex = 5;
            // 
            // simpleButton1
            // 
            this.simpleButton1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.simpleButton1.Location = new System.Drawing.Point(312, 173);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 22);
            this.simpleButton1.StyleController = this.AlbumPropertiesFormConvertedLayout;
            this.simpleButton1.TabIndex = 6;
            this.simpleButton1.Text = "Cancel";
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(231, 173);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(75, 22);
            this.simpleButton2.StyleController = this.AlbumPropertiesFormConvertedLayout;
            this.simpleButton2.TabIndex = 7;
            this.simpleButton2.Text = "OK";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // AlbumPropertiesFormConvertedLayout
            // 
            this.AlbumPropertiesFormConvertedLayout.Controls.Add(this.albumDescription);
            this.AlbumPropertiesFormConvertedLayout.Controls.Add(this.albumDate);
            this.AlbumPropertiesFormConvertedLayout.Controls.Add(this.albumNameEdit);
            this.AlbumPropertiesFormConvertedLayout.Controls.Add(this.simpleButton2);
            this.AlbumPropertiesFormConvertedLayout.Controls.Add(this.simpleButton1);
            this.AlbumPropertiesFormConvertedLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AlbumPropertiesFormConvertedLayout.Location = new System.Drawing.Point(0, 0);
            this.AlbumPropertiesFormConvertedLayout.Name = "AlbumPropertiesFormConvertedLayout";
            this.AlbumPropertiesFormConvertedLayout.Root = this.layoutControlGroup1;
            this.AlbumPropertiesFormConvertedLayout.Size = new System.Drawing.Size(399, 207);
            this.AlbumPropertiesFormConvertedLayout.TabIndex = 8;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.emptySpaceItem1});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(399, 207);
            this.layoutControlGroup1.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroup1.Text = "layoutControlGroup1";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.albumDescription;
            this.layoutControlItem1.CustomizationFormText = "Description:";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem1.Name = "albumDescriptionitem";
            this.layoutControlItem1.Size = new System.Drawing.Size(379, 113);
            this.layoutControlItem1.Text = "Description:";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(62, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.albumDate;
            this.layoutControlItem2.CustomizationFormText = "Date:";
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem2.Name = "albumDateitem";
            this.layoutControlItem2.Size = new System.Drawing.Size(379, 24);
            this.layoutControlItem2.Text = "Date:";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(62, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.albumNameEdit;
            this.layoutControlItem3.CustomizationFormText = "Album name:";
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem3.Name = "albumNameEdititem";
            this.layoutControlItem3.Size = new System.Drawing.Size(379, 24);
            this.layoutControlItem3.Text = "Album name:";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(62, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.simpleButton2;
            this.layoutControlItem4.CustomizationFormText = "simpleButton2item";
            this.layoutControlItem4.Location = new System.Drawing.Point(219, 161);
            this.layoutControlItem4.MaxSize = new System.Drawing.Size(80, 26);
            this.layoutControlItem4.MinSize = new System.Drawing.Size(29, 26);
            this.layoutControlItem4.Name = "simpleButton2item";
            this.layoutControlItem4.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 3, 2, 2);
            this.layoutControlItem4.Size = new System.Drawing.Size(80, 26);
            this.layoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem4.Text = "simpleButton2item";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextToControlDistance = 0;
            this.layoutControlItem4.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.simpleButton1;
            this.layoutControlItem5.CustomizationFormText = "simpleButton1item";
            this.layoutControlItem5.Location = new System.Drawing.Point(299, 161);
            this.layoutControlItem5.MaxSize = new System.Drawing.Size(80, 26);
            this.layoutControlItem5.MinSize = new System.Drawing.Size(47, 26);
            this.layoutControlItem5.Name = "simpleButton1item";
            this.layoutControlItem5.Padding = new DevExpress.XtraLayout.Utils.Padding(3, 2, 2, 2);
            this.layoutControlItem5.Size = new System.Drawing.Size(80, 26);
            this.layoutControlItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem5.Text = "simpleButton1item";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextToControlDistance = 0;
            this.layoutControlItem5.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.CustomizationFormText = "emptySpaceItem1";
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 161);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(219, 26);
            this.emptySpaceItem1.Text = "emptySpaceItem1";
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // AlbumPropertiesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 207);
            this.Controls.Add(this.AlbumPropertiesFormConvertedLayout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "AlbumPropertiesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "NewAlbumForm";
            this.Load += new System.EventHandler(this.NewAlbumForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.albumNameEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.albumDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.albumDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.albumDescription.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AlbumPropertiesFormConvertedLayout)).EndInit();
            this.AlbumPropertiesFormConvertedLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit albumNameEdit;
        private DevExpress.XtraEditors.DateEdit albumDate;
        private DevExpress.XtraEditors.MemoEdit albumDescription;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraLayout.LayoutControl AlbumPropertiesFormConvertedLayout;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.Converter.LayoutConverter layoutConverter1;
    }
}
