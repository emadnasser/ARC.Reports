namespace DevExpress.XtraVerticalGrid.Demos {
    partial class FixedRows {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FixedRows));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.cheAllowFixingNestedRows = new DevExpress.XtraEditors.CheckEdit();
            this.numFixedLineWidth1 = new DevExpress.XtraEditors.SpinEdit();
            this.label5 = new System.Windows.Forms.Label();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.menuItemImageList = new System.Windows.Forms.ImageList(this.components);
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.splitterControl1 = new DevExpress.XtraEditors.SplitterControl();
            this.propertyGridControl1 = new DevExpress.XtraVerticalGrid.PropertyGridControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cheAllowFixingNestedRows.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFixedLineWidth1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.propertyGridControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.cheAllowFixingNestedRows);
            this.panelControl1.Controls.Add(this.numFixedLineWidth1);
            this.panelControl1.Controls.Add(this.label5);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(650, 42);
            this.panelControl1.TabIndex = 5;
            // 
            // cheAllowFixingNestedRows
            // 
            this.cheAllowFixingNestedRows.Location = new System.Drawing.Point(212, 11);
            this.cheAllowFixingNestedRows.Name = "cheAllowFixingNestedRows";
            this.cheAllowFixingNestedRows.Properties.AutoWidth = true;
            this.cheAllowFixingNestedRows.Properties.Caption = "Allow Fixing Nested Rows";
            this.cheAllowFixingNestedRows.Size = new System.Drawing.Size(144, 19);
            this.cheAllowFixingNestedRows.TabIndex = 4;
            // 
            // numFixedLineWidth1
            // 
            this.numFixedLineWidth1.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numFixedLineWidth1.Location = new System.Drawing.Point(113, 10);
            this.numFixedLineWidth1.Name = "numFixedLineWidth1";
            this.numFixedLineWidth1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.numFixedLineWidth1.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default;
            this.numFixedLineWidth1.Properties.IsFloatValue = false;
            this.numFixedLineWidth1.Properties.Mask.EditMask = "N00";
            this.numFixedLineWidth1.Properties.MaxValue = 20m;
            this.numFixedLineWidth1.Properties.MinValue = 0m;
            this.numFixedLineWidth1.Size = new System.Drawing.Size(72, 20);
            this.numFixedLineWidth1.TabIndex = 3;
            this.numFixedLineWidth1.EditValueChanged += new System.EventHandler(this.numFixedLineWidth1_EditValueChanged);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(11, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "Fixed Line Width:";
            // 
            // panelControl2
            // 
            this.panelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(0, 42);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(650, 8);
            this.panelControl2.TabIndex = 6;
            // 
            // menuItemImageList
            // 
            this.menuItemImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("menuItemImageList.ImageStream")));
            this.menuItemImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.menuItemImageList.Images.SetKeyName(0, "ShowCustomizationWinow.png");
            this.menuItemImageList.Images.SetKeyName(1, "NotFixed.png");
            this.menuItemImageList.Images.SetKeyName(2, "FixedTop.png");
            this.menuItemImageList.Images.SetKeyName(3, "FixedBottom.png");
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureEdit1.EditValue = ((object)(resources.GetObject("pictureEdit1.EditValue")));
            this.pictureEdit1.Location = new System.Drawing.Point(0, 50);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Size = new System.Drawing.Size(200, 430);
            this.pictureEdit1.TabIndex = 8;
            // 
            // splitterControl1
            // 
            this.splitterControl1.Location = new System.Drawing.Point(200, 50);
            this.splitterControl1.Name = "splitterControl1";
            this.splitterControl1.Size = new System.Drawing.Size(5, 430);
            this.splitterControl1.TabIndex = 9;
            this.splitterControl1.TabStop = false;
            // 
            // propertyGridControl1
            // 
            this.propertyGridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.propertyGridControl1.FindPanelVisible = true;
            this.propertyGridControl1.Location = new System.Drawing.Point(205, 50);
            this.propertyGridControl1.Name = "propertyGridControl1";
            this.propertyGridControl1.OptionsMenu.EnableContextMenu = true;
            this.propertyGridControl1.OptionsView.MinRowAutoHeight = 20;
            this.propertyGridControl1.Size = new System.Drawing.Size(445, 430);
            this.propertyGridControl1.TabIndex = 11;
            this.propertyGridControl1.PopupMenuShowing += new DevExpress.XtraVerticalGrid.Events.PopupMenuShowingEventHandler(this.propertyGridControl1_PopupMenuShowing);
            // 
            // FixedRows
            // 
            this.Controls.Add(this.propertyGridControl1);
            this.Controls.Add(this.splitterControl1);
            this.Controls.Add(this.pictureEdit1);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Name = "FixedRows";
            this.Size = new System.Drawing.Size(650, 480);
            this.Load += new System.EventHandler(this.FixedRows_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cheAllowFixingNestedRows.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFixedLineWidth1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.propertyGridControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.SpinEdit numFixedLineWidth1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ImageList menuItemImageList;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.SplitterControl splitterControl1;
        private PropertyGridControl propertyGridControl1;
        private DevExpress.XtraEditors.CheckEdit cheAllowFixingNestedRows;
    }
}
