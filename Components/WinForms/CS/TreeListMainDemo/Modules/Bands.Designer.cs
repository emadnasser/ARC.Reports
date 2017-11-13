namespace DevExpress.XtraTreeList.Demos {
    partial class Bands {
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
            this.treeList = new DevExpress.XtraTreeList.TreeList();
            this.treeListBand1 = new DevExpress.XtraTreeList.Columns.TreeListBand();
            this.treeListColumn1 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn2 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListBand2 = new DevExpress.XtraTreeList.Columns.TreeListBand();
            this.treeListBand3 = new DevExpress.XtraTreeList.Columns.TreeListBand();
            this.treeListColumn3 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn4 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn9 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListBand4 = new DevExpress.XtraTreeList.Columns.TreeListBand();
            this.treeListColumn5 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn6 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn7 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListBand5 = new DevExpress.XtraTreeList.Columns.TreeListBand();
            this.treeListColumn8 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.ceAllowChangeColumnParent = new DevExpress.XtraEditors.CheckEdit();
            this.ceAllowBandResizing = new DevExpress.XtraEditors.CheckEdit();
            this.ceShowBandInCustomizationForm = new DevExpress.XtraEditors.CheckEdit();
            this.ceAllowBandMoving = new DevExpress.XtraEditors.CheckEdit();
            this.ceAllowChangeBandParent = new DevExpress.XtraEditors.CheckEdit();
            this.ceShowBandPanel = new DevExpress.XtraEditors.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.treeList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ceAllowChangeColumnParent.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceAllowBandResizing.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceShowBandInCustomizationForm.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceAllowBandMoving.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceAllowChangeBandParent.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceShowBandPanel.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // treeList
            // 
            this.treeList.Bands.AddRange(new DevExpress.XtraTreeList.Columns.TreeListBand[] {
            this.treeListBand1,
            this.treeListBand2,
            this.treeListBand5});
            this.treeList.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.treeListColumn1,
            this.treeListColumn2,
            this.treeListColumn3,
            this.treeListColumn4,
            this.treeListColumn5,
            this.treeListColumn9,
            this.treeListColumn6,
            this.treeListColumn7,
            this.treeListColumn8});
            this.treeList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeList.Location = new System.Drawing.Point(0, 67);
            this.treeList.Name = "treeList";
            this.treeList.OptionsBehavior.AllowPixelScrolling = DevExpress.Utils.DefaultBoolean.True;
            this.treeList.OptionsBehavior.AutoNodeHeight = false;
            this.treeList.OptionsBehavior.Editable = false;
            this.treeList.OptionsCustomization.AllowChangeBandParent = true;
            this.treeList.OptionsCustomization.AllowChangeColumnParent = true;
            this.treeList.OptionsCustomization.CustomizationFormSearchBoxVisible = true;
            this.treeList.OptionsCustomization.CustomizationFormSnapMode = ((DevExpress.Utils.Controls.SnapMode)((DevExpress.Utils.Controls.SnapMode.OwnerControl | DevExpress.Utils.Controls.SnapMode.OwnerForm)));
            this.treeList.OptionsView.AllowBandColumnsMultiRow = true;
            this.treeList.OptionsView.AllowHtmlDrawHeaders = true;
            this.treeList.OptionsView.EnableAppearanceEvenRow = true;
            this.treeList.OptionsView.EnableAppearanceOddRow = true;
            this.treeList.OptionsView.ShowBandsMode = DevExpress.Utils.DefaultBoolean.True;
            this.treeList.Size = new System.Drawing.Size(784, 365);
            this.treeList.TabIndex = 16;
            // 
            // treeListBand1
            // 
            this.treeListBand1.Caption = "<b>Main</b>";
            this.treeListBand1.Columns.Add(this.treeListColumn1);
            this.treeListBand1.Columns.Add(this.treeListColumn2);
            this.treeListBand1.Name = "treeListBand1";
            this.treeListBand1.Width = 178;
            // 
            // treeListColumn1
            // 
            this.treeListColumn1.Caption = "Name";
            this.treeListColumn1.FieldName = "Name";
            this.treeListColumn1.Name = "treeListColumn1";
            this.treeListColumn1.Visible = true;
            this.treeListColumn1.VisibleIndex = 0;
            this.treeListColumn1.Width = 90;
            // 
            // treeListColumn2
            // 
            this.treeListColumn2.Caption = "Type of object";
            this.treeListColumn2.FieldName = "TypeOfObject";
            this.treeListColumn2.Name = "treeListColumn2";
            this.treeListColumn2.RowIndex = 1;
            this.treeListColumn2.Visible = true;
            this.treeListColumn2.VisibleIndex = 1;
            this.treeListColumn2.Width = 88;
            // 
            // treeListBand2
            // 
            this.treeListBand2.Bands.AddRange(new DevExpress.XtraTreeList.Columns.TreeListBand[] {
            this.treeListBand3,
            this.treeListBand4});
            this.treeListBand2.Caption = "<b>Details </b>";
            this.treeListBand2.Name = "treeListBand2";
            this.treeListBand2.Width = 536;
            // 
            // treeListBand3
            // 
            this.treeListBand3.Caption = "Absolute Values";
            this.treeListBand3.Columns.Add(this.treeListColumn3);
            this.treeListBand3.Columns.Add(this.treeListColumn4);
            this.treeListBand3.Columns.Add(this.treeListColumn9);
            this.treeListBand3.Name = "treeListBand3";
            this.treeListBand3.Width = 256;
            // 
            // treeListColumn3
            // 
            this.treeListColumn3.Caption = "Mean radius";
            this.treeListColumn3.FieldName = "MeanRadiusInKM";
            this.treeListColumn3.Name = "treeListColumn3";
            this.treeListColumn3.Visible = true;
            this.treeListColumn3.VisibleIndex = 2;
            this.treeListColumn3.Width = 107;
            // 
            // treeListColumn4
            // 
            this.treeListColumn4.Caption = "Volume ";
            this.treeListColumn4.FieldName = "Volume10pow9KM3";
            this.treeListColumn4.Format.FormatString = "f";
            this.treeListColumn4.Format.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.treeListColumn4.Name = "treeListColumn4";
            this.treeListColumn4.Visible = true;
            this.treeListColumn4.VisibleIndex = 3;
            this.treeListColumn4.Width = 88;
            // 
            // treeListColumn9
            // 
            this.treeListColumn9.Caption = "Mass";
            this.treeListColumn9.FieldName = "Mass10pow21kg";
            this.treeListColumn9.Name = "treeListColumn9";
            this.treeListColumn9.RowIndex = 1;
            this.treeListColumn9.Visible = true;
            this.treeListColumn9.VisibleIndex = 4;
            this.treeListColumn9.Width = 61;
            // 
            // treeListBand4
            // 
            this.treeListBand4.Caption = "Related To Earth Values";
            this.treeListBand4.Columns.Add(this.treeListColumn5);
            this.treeListBand4.Columns.Add(this.treeListColumn6);
            this.treeListBand4.Columns.Add(this.treeListColumn7);
            this.treeListBand4.Name = "treeListBand4";
            this.treeListBand4.Width = 280;
            // 
            // treeListColumn5
            // 
            this.treeListColumn5.Caption = "Mean radius";
            this.treeListColumn5.FieldName = "MeanRadiusByEarth";
            this.treeListColumn5.Format.FormatString = "f";
            this.treeListColumn5.Format.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.treeListColumn5.Name = "treeListColumn5";
            this.treeListColumn5.Visible = true;
            this.treeListColumn5.VisibleIndex = 5;
            this.treeListColumn5.Width = 102;
            // 
            // treeListColumn6
            // 
            this.treeListColumn6.Caption = "Volume ";
            this.treeListColumn6.FieldName = "VolumeRByEarth";
            this.treeListColumn6.Name = "treeListColumn6";
            this.treeListColumn6.Visible = true;
            this.treeListColumn6.VisibleIndex = 6;
            this.treeListColumn6.Width = 104;
            // 
            // treeListColumn7
            // 
            this.treeListColumn7.Caption = "Mass";
            this.treeListColumn7.FieldName = "MassByEarth";
            this.treeListColumn7.Name = "treeListColumn7";
            this.treeListColumn7.RowIndex = 1;
            this.treeListColumn7.Visible = true;
            this.treeListColumn7.VisibleIndex = 7;
            this.treeListColumn7.Width = 74;
            // 
            // treeListBand5
            // 
            this.treeListBand5.Caption = "<b>Picture</b>";
            this.treeListBand5.Columns.Add(this.treeListColumn8);
            this.treeListBand5.MinWidth = 68;
            this.treeListBand5.Name = "treeListBand5";
            this.treeListBand5.OptionsBand.FixedWidth = true;
            this.treeListBand5.Width = 68;
            // 
            // treeListColumn8
            // 
            this.treeListColumn8.Caption = "Icon";
            this.treeListColumn8.FieldName = "ImageData";
            this.treeListColumn8.Name = "treeListColumn8";
            this.treeListColumn8.OptionsColumn.FixedWidth = true;
            this.treeListColumn8.Visible = true;
            this.treeListColumn8.VisibleIndex = 8;
            this.treeListColumn8.Width = 68;
            // 
            // panelControl2
            // 
            this.panelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(0, 59);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(784, 8);
            this.panelControl2.TabIndex = 15;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.ceAllowChangeColumnParent);
            this.panelControl1.Controls.Add(this.ceAllowBandResizing);
            this.panelControl1.Controls.Add(this.ceShowBandInCustomizationForm);
            this.panelControl1.Controls.Add(this.ceAllowBandMoving);
            this.panelControl1.Controls.Add(this.ceAllowChangeBandParent);
            this.panelControl1.Controls.Add(this.ceShowBandPanel);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(784, 59);
            this.panelControl1.TabIndex = 14;
            // 
            // ceAllowChangeColumnParent
            // 
            this.ceAllowChangeColumnParent.Location = new System.Drawing.Point(185, 32);
            this.ceAllowChangeColumnParent.Name = "ceAllowChangeColumnParent";
            this.ceAllowChangeColumnParent.Properties.Caption = "Allow Change Column Parent";
            this.ceAllowChangeColumnParent.Size = new System.Drawing.Size(160, 19);
            this.ceAllowChangeColumnParent.TabIndex = 5;
            this.ceAllowChangeColumnParent.CheckedChanged += new System.EventHandler(this.ceAllowChangeColumnParent_CheckedChanged);
            // 
            // ceAllowBandResizing
            // 
            this.ceAllowBandResizing.Location = new System.Drawing.Point(384, 32);
            this.ceAllowBandResizing.Name = "ceAllowBandResizing";
            this.ceAllowBandResizing.Properties.Caption = "Allow Band Resizing";
            this.ceAllowBandResizing.Size = new System.Drawing.Size(126, 19);
            this.ceAllowBandResizing.TabIndex = 5;
            this.ceAllowBandResizing.CheckedChanged += new System.EventHandler(this.ceAllowBandResizing_CheckedChanged);
            // 
            // ceShowBandInCustomizationForm
            // 
            this.ceShowBandInCustomizationForm.Location = new System.Drawing.Point(538, 10);
            this.ceShowBandInCustomizationForm.Name = "ceShowBandInCustomizationForm";
            this.ceShowBandInCustomizationForm.Properties.Caption = "Show Bands In Customization Form";
            this.ceShowBandInCustomizationForm.Size = new System.Drawing.Size(192, 19);
            this.ceShowBandInCustomizationForm.TabIndex = 5;
            this.ceShowBandInCustomizationForm.CheckedChanged += new System.EventHandler(this.ceShowBandInCustomizationForm_CheckedChanged);
            // 
            // ceAllowBandMoving
            // 
            this.ceAllowBandMoving.Location = new System.Drawing.Point(384, 10);
            this.ceAllowBandMoving.Name = "ceAllowBandMoving";
            this.ceAllowBandMoving.Properties.Caption = "Allow Band Moving";
            this.ceAllowBandMoving.Size = new System.Drawing.Size(126, 19);
            this.ceAllowBandMoving.TabIndex = 5;
            this.ceAllowBandMoving.CheckedChanged += new System.EventHandler(this.ceAllowBandMoving_CheckedChanged);
            // 
            // ceAllowChangeBandParent
            // 
            this.ceAllowChangeBandParent.Location = new System.Drawing.Point(185, 10);
            this.ceAllowChangeBandParent.Name = "ceAllowChangeBandParent";
            this.ceAllowChangeBandParent.Properties.Caption = "Allow Change Band Parent";
            this.ceAllowChangeBandParent.Size = new System.Drawing.Size(160, 19);
            this.ceAllowChangeBandParent.TabIndex = 5;
            this.ceAllowChangeBandParent.CheckedChanged += new System.EventHandler(this.ceAllowChangeBandParent_CheckedChanged);
            // 
            // ceShowBandPanel
            // 
            this.ceShowBandPanel.Location = new System.Drawing.Point(15, 10);
            this.ceShowBandPanel.Name = "ceShowBandPanel";
            this.ceShowBandPanel.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.ceShowBandPanel.Properties.Appearance.Options.UseFont = true;
            this.ceShowBandPanel.Properties.Caption = "Show Bands Panel";
            this.ceShowBandPanel.Size = new System.Drawing.Size(137, 19);
            this.ceShowBandPanel.TabIndex = 4;
            this.ceShowBandPanel.CheckedChanged += new System.EventHandler(this.ceShowBandPanel_CheckedChanged);
            // 
            // Bands
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.treeList);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Name = "Bands";
            ((System.ComponentModel.ISupportInitialize)(this.treeList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ceAllowChangeColumnParent.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceAllowBandResizing.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceShowBandInCustomizationForm.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceAllowBandMoving.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceAllowChangeBandParent.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceShowBandPanel.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TreeList treeList;
        private XtraEditors.PanelControl panelControl2;
        private XtraEditors.PanelControl panelControl1;
        private Columns.TreeListColumn treeListColumn1;
        private Columns.TreeListColumn treeListColumn2;
        private Columns.TreeListColumn treeListColumn3;
        private Columns.TreeListColumn treeListColumn4;
        private Columns.TreeListColumn treeListColumn5;
        private Columns.TreeListColumn treeListColumn6;
        private Columns.TreeListColumn treeListColumn7;
        private Columns.TreeListColumn treeListColumn8;
        private Columns.TreeListColumn treeListColumn9;
        private XtraEditors.CheckEdit ceShowBandPanel;
        private XtraEditors.CheckEdit ceAllowChangeColumnParent;
        private XtraEditors.CheckEdit ceAllowChangeBandParent;
        private XtraEditors.CheckEdit ceAllowBandResizing;
        private XtraEditors.CheckEdit ceAllowBandMoving;
        private XtraEditors.CheckEdit ceShowBandInCustomizationForm;
        private Columns.TreeListBand treeListBand1;
        private Columns.TreeListBand treeListBand2;
        private Columns.TreeListBand treeListBand3;
        private Columns.TreeListBand treeListBand4;
        private Columns.TreeListBand treeListBand5;

    }
}
