using DevExpress.XtraEditors.Designer.Utils;
namespace DevExpress.XtraLayout.Demos {
    partial class TechnoLayout {
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
            this.layoutControl3 = new DevExpress.XtraLayout.LayoutControl();
            this.facesUserControl1 = new DevExpress.XtraLayout.Demos.Modules.TechnoLayout.FacesUserControl();
            this.lcgMain = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.navigationPane1 = new DevExpress.XtraBars.Navigation.NavigationPane();
            this.navigationPage1 = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.cheCustomizationMode = new DevExpress.XtraEditors.CheckEdit();
            this.propertyGrid = new DevExpress.XtraVerticalGrid.PropertyGridControl();
            this.ztbcSize = new DevExpress.XtraEditors.ZoomTrackBarControl();
            this.ztbcSpacing = new DevExpress.XtraEditors.ZoomTrackBarControl();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl3)).BeginInit();
            this.layoutControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lcgMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.navigationPane1)).BeginInit();
            this.navigationPane1.SuspendLayout();
            this.navigationPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cheCustomizationMode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.propertyGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ztbcSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ztbcSize.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ztbcSpacing)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ztbcSpacing.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl3
            // 
            this.layoutControl3.AutoScroll = false;
            this.layoutControl3.Controls.Add(this.facesUserControl1);
            this.layoutControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl3.Location = new System.Drawing.Point(0, 0);
            this.layoutControl3.Name = "layoutControl3";
            this.layoutControl3.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(332, 256, 892, 743);
            this.layoutControl3.OptionsView.AlwaysScrollActiveControlIntoView = false;
            this.layoutControl3.Root = this.lcgMain;
            this.layoutControl3.Size = new System.Drawing.Size(618, 650);
            this.layoutControl3.TabIndex = 2;
            this.layoutControl3.Text = "layoutControl3";
            // 
            // facesUserControl1
            // 
            this.facesUserControl1.Location = new System.Drawing.Point(0, 0);
            this.facesUserControl1.Name = "facesUserControl1";
            this.facesUserControl1.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.facesUserControl1.Size = new System.Drawing.Size(618, 650);
            this.facesUserControl1.TabIndex = 26;
            // 
            // lcgMain
            // 
            this.lcgMain.CustomizationFormText = "Root";
            this.lcgMain.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.lcgMain.GroupBordersVisible = false;
            this.lcgMain.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.lcgMain.Location = new System.Drawing.Point(0, 0);
            this.lcgMain.Name = "Root";
            this.lcgMain.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.lcgMain.Size = new System.Drawing.Size(618, 650);
            this.lcgMain.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.facesUserControl1;
            this.layoutControlItem1.CustomizationFormText = "layoutControlItem1";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlItem1.Size = new System.Drawing.Size(618, 650);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // navigationPane1
            // 
            this.navigationPane1.Controls.Add(this.navigationPage1);
            this.navigationPane1.Dock = System.Windows.Forms.DockStyle.Right;
            this.navigationPane1.Location = new System.Drawing.Point(618, 0);
            this.navigationPane1.Name = "navigationPane1";
            this.navigationPane1.PageProperties.ShowExpandButton = false;
            this.navigationPane1.PageProperties.ShowMode = DevExpress.XtraBars.Navigation.ItemShowMode.Image;
            this.navigationPane1.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.navigationPage1});
            this.navigationPane1.RegularSize = new System.Drawing.Size(358, 650);
            this.navigationPane1.SelectedPage = this.navigationPage1;
            this.navigationPane1.Size = new System.Drawing.Size(358, 650);
            this.navigationPane1.TabIndex = 27;
            this.navigationPane1.Text = "navigationPane1";
            // 
            // navigationPage1
            // 
            this.navigationPage1.Caption = "Options";
            this.navigationPage1.Controls.Add(this.layoutControl1);
            this.navigationPage1.ImageUri.Uri = "Properties;Size16x16;Office2013";
            this.navigationPage1.Name = "navigationPage1";
            this.navigationPage1.Size = new System.Drawing.Size(308, 590);
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.cheCustomizationMode);
            this.layoutControl1.Controls.Add(this.propertyGrid);
            this.layoutControl1.Controls.Add(this.ztbcSize);
            this.layoutControl1.Controls.Add(this.ztbcSpacing);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(308, 590);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // cheCustomizationMode
            // 
            this.cheCustomizationMode.EditValue = true;
            this.cheCustomizationMode.Location = new System.Drawing.Point(2, 2);
            this.cheCustomizationMode.Name = "cheCustomizationMode";
            this.cheCustomizationMode.Properties.Caption = "Customization Mode";
            this.cheCustomizationMode.Size = new System.Drawing.Size(304, 19);
            this.cheCustomizationMode.StyleController = this.layoutControl1;
            this.cheCustomizationMode.TabIndex = 25;
            this.cheCustomizationMode.CheckedChanged += new System.EventHandler(this.cheCustomizationMode_CheckedChanged);
            // 
            // propertyGrid
            // 
            this.propertyGrid.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.propertyGrid.Location = new System.Drawing.Point(2, 101);
            this.propertyGrid.Name = "propertyGrid";
            this.propertyGrid.Size = new System.Drawing.Size(304, 487);
            this.propertyGrid.TabIndex = 24;
            // 
            // ztbcSize
            // 
            this.ztbcSize.EditValue = 150;
            this.ztbcSize.Location = new System.Drawing.Point(2, 41);
            this.ztbcSize.Name = "ztbcSize";
            this.ztbcSize.Properties.LargeChange = 10;
            this.ztbcSize.Properties.Maximum = 250;
            this.ztbcSize.Properties.Middle = 150;
            this.ztbcSize.Properties.Minimum = 50;
            this.ztbcSize.Properties.ScrollThumbStyle = DevExpress.XtraEditors.Repository.ScrollThumbStyle.ArrowDownRight;
            this.ztbcSize.Properties.SmallChange = 10;
            this.ztbcSize.Size = new System.Drawing.Size(304, 23);
            this.ztbcSize.StyleController = this.layoutControl1;
            this.ztbcSize.TabIndex = 4;
            this.ztbcSize.Value = 150;
            this.ztbcSize.EditValueChanged += new System.EventHandler(this.zoomTrackBarControl1_EditValueChanged);
            // 
            // ztbcSpacing
            // 
            this.ztbcSpacing.EditValue = 15;
            this.ztbcSpacing.Location = new System.Drawing.Point(2, 79);
            this.ztbcSpacing.Name = "ztbcSpacing";
            this.ztbcSpacing.Properties.Maximum = 30;
            this.ztbcSpacing.Properties.Middle = 15;
            this.ztbcSpacing.Properties.ScrollThumbStyle = DevExpress.XtraEditors.Repository.ScrollThumbStyle.ArrowDownRight;
            this.ztbcSpacing.Size = new System.Drawing.Size(304, 23);
            this.ztbcSpacing.StyleController = this.layoutControl1;
            this.ztbcSpacing.TabIndex = 5;
            this.ztbcSpacing.Value = 15;
            this.ztbcSpacing.EditValueChanged += new System.EventHandler(this.zoomTrackBarControl2_EditValueChanged);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroup1.Size = new System.Drawing.Size(308, 590);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.cheCustomizationMode;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(308, 23);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.ztbcSize;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 23);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(308, 38);
            this.layoutControlItem3.Text = "Size:";
            this.layoutControlItem3.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem3.TextSize = new System.Drawing.Size(37, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.ztbcSpacing;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 61);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(308, 38);
            this.layoutControlItem4.Text = "Spacing";
            this.layoutControlItem4.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem4.TextSize = new System.Drawing.Size(37, 13);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.propertyGrid;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 99);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(308, 491);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // TechnoLayout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl3);
            this.Controls.Add(this.navigationPane1);
            this.Name = "TechnoLayout";
            this.Size = new System.Drawing.Size(976, 650);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl3)).EndInit();
            this.layoutControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lcgMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.navigationPane1)).EndInit();
            this.navigationPane1.ResumeLayout(false);
            this.navigationPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cheCustomizationMode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.propertyGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ztbcSize.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ztbcSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ztbcSpacing.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ztbcSpacing)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private XtraVerticalGrid.PropertyGridControl propertyGrid;
        private LayoutControl layoutControl3;
        private LayoutControlGroup lcgMain;
        private XtraEditors.ZoomTrackBarControl ztbcSpacing;
        private XtraEditors.ZoomTrackBarControl ztbcSize;
        private XtraEditors.CheckEdit cheCustomizationMode;
        private Modules.TechnoLayout.FacesUserControl facesUserControl1;
        private LayoutControlItem layoutControlItem1;
        private XtraBars.Navigation.NavigationPane navigationPane1;
        private XtraBars.Navigation.NavigationPage navigationPage1;
        private LayoutControl layoutControl1;
        private LayoutControlGroup layoutControlGroup1;
        private LayoutControlItem layoutControlItem2;
        private LayoutControlItem layoutControlItem3;
        private LayoutControlItem layoutControlItem4;
        private LayoutControlItem layoutControlItem5;
    }
}
