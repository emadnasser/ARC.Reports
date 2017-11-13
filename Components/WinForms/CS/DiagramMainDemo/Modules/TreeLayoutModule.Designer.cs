using DevExpress.Diagram.Core;
using DevExpress.Diagram.Core.Layout;

namespace DevExpress.XtraDiagram.Demos {
    partial class TreeLayoutModule {
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
            System.Windows.Forms.BindingSource bindingSource;
            this.groupControl4 = new DevExpress.XtraEditors.GroupControl();
            this.directionRadioGroup = new DevExpress.XtraEditors.RadioGroup();
            this.groupControl6 = new DevExpress.XtraEditors.GroupControl();
            this.verticalSpacingTrackBar = new DevExpress.XtraEditors.TrackBarControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.alignmentRadioGroup = new DevExpress.XtraEditors.RadioGroup();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.horizontalSpacingTrackBar = new DevExpress.XtraEditors.TrackBarControl();
            bindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.navigationPane1)).BeginInit();
            this.navigationPane1.SuspendLayout();
            this.optionsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.diagramControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(bindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).BeginInit();
            this.groupControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.directionRadioGroup.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl6)).BeginInit();
            this.groupControl6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.verticalSpacingTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.verticalSpacingTrackBar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.alignmentRadioGroup.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.horizontalSpacingTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.horizontalSpacingTrackBar.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // navigationPane1
            // 
            this.navigationPane1.Location = new System.Drawing.Point(514, 0);
            this.navigationPane1.PageProperties.ShowExpandButton = false;
            this.navigationPane1.PageProperties.ShowMode = DevExpress.XtraBars.Navigation.ItemShowMode.Image;
            // 
            // optionsPanel
            // 
            this.optionsPanel.Controls.Add(this.groupControl2);
            this.optionsPanel.Controls.Add(this.groupControl1);
            this.optionsPanel.Controls.Add(this.groupControl4);
            this.optionsPanel.Controls.Add(this.groupControl6);
            // 
            // containerControl
            // 
            this.containerControl.Size = new System.Drawing.Size(514, 581);
            // 
            // diagramControl
            // 
            this.diagramControl.OptionsBehavior.SelectedStencils = new DevExpress.Diagram.Core.StencilCollection(new string[] {
            "BasicShapes",
            "BasicFlowchartShapes"});
            this.diagramControl.OptionsView.CanvasSizeMode = DevExpress.Diagram.Core.CanvasSizeMode.None;
            this.diagramControl.OptionsView.PageSize = new System.Drawing.SizeF(800F, 600F);
            this.diagramControl.OptionsView.PropertiesPanelVisibility = DevExpress.Diagram.Core.PropertiesPanelVisibility.Closed;
            this.diagramControl.OptionsView.Theme = DevExpress.Diagram.Core.DiagramThemes.Linear;
            this.diagramControl.OptionsView.ToolboxVisibility = DevExpress.Diagram.Core.ToolboxVisibility.Closed;
            this.diagramControl.Size = new System.Drawing.Size(508, 407);
            // 
            // bindingSource
            // 
            bindingSource.DataMember = "OptionsTreeLayout";
            bindingSource.DataSource = this.diagramControl;
            bindingSource.Position = 0;
            // 
            // groupControl4
            // 
            this.groupControl4.AutoSize = true;
            this.groupControl4.CaptionLocation = DevExpress.Utils.Locations.Top;
            this.groupControl4.Controls.Add(this.directionRadioGroup);
            this.groupControl4.Location = new System.Drawing.Point(4, 3);
            this.groupControl4.Name = "groupControl4";
            this.groupControl4.Size = new System.Drawing.Size(214, 120);
            this.groupControl4.TabIndex = 1;
            this.groupControl4.Text = "Direction";
            // 
            // directionRadioGroup
            // 
            this.directionRadioGroup.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", bindingSource, "Direction", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.directionRadioGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.directionRadioGroup.Location = new System.Drawing.Point(2, 20);
            this.directionRadioGroup.Name = "directionRadioGroup";
            this.directionRadioGroup.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.directionRadioGroup.Properties.Appearance.Options.UseBackColor = true;
            this.directionRadioGroup.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.directionRadioGroup.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(DevExpress.Diagram.Core.Layout.LayoutDirection.TopToBottom, "TopToBottom"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(DevExpress.Diagram.Core.Layout.LayoutDirection.BottomToTop, "BottomToTop"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(DevExpress.Diagram.Core.Layout.LayoutDirection.LeftToRight, "LeftToRight"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(DevExpress.Diagram.Core.Layout.LayoutDirection.RightToLeft, "RightToLeft")});
            this.directionRadioGroup.Size = new System.Drawing.Size(210, 98);
            this.directionRadioGroup.TabIndex = 1;
            this.directionRadioGroup.SelectedIndexChanged += new System.EventHandler(this.RadioGroupSelectedItemChanged);
            // 
            // groupControl6
            // 
            this.groupControl6.AutoSize = true;
            this.groupControl6.Controls.Add(this.verticalSpacingTrackBar);
            this.groupControl6.Location = new System.Drawing.Point(4, 275);
            this.groupControl6.Name = "groupControl6";
            this.groupControl6.Size = new System.Drawing.Size(214, 50);
            this.groupControl6.TabIndex = 2;
            this.groupControl6.Text = "Vertical Spacing";
            // 
            // verticalSpacingTrackBar
            // 
            this.verticalSpacingTrackBar.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", bindingSource, "VerticalSpacing", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.verticalSpacingTrackBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.verticalSpacingTrackBar.EditValue = 20;
            this.verticalSpacingTrackBar.Location = new System.Drawing.Point(2, 20);
            this.verticalSpacingTrackBar.Name = "verticalSpacingTrackBar";
            this.verticalSpacingTrackBar.Properties.LabelAppearance.Options.UseTextOptions = true;
            this.verticalSpacingTrackBar.Properties.LabelAppearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.verticalSpacingTrackBar.Properties.Maximum = 150;
            this.verticalSpacingTrackBar.Properties.Minimum = 20;
            this.verticalSpacingTrackBar.Properties.ShowValueToolTip = true;
            this.verticalSpacingTrackBar.Properties.SmallChange = 15;
            this.verticalSpacingTrackBar.Properties.TickStyle = System.Windows.Forms.TickStyle.None;
            this.verticalSpacingTrackBar.Size = new System.Drawing.Size(210, 28);
            this.verticalSpacingTrackBar.TabIndex = 1;
            this.verticalSpacingTrackBar.Value = 20;
            this.verticalSpacingTrackBar.ValueChanged += new System.EventHandler(this.TrackBarValueChanged);
            // 
            // groupControl1
            // 
            this.groupControl1.AutoSize = true;
            this.groupControl1.CaptionLocation = DevExpress.Utils.Locations.Top;
            this.groupControl1.Controls.Add(this.alignmentRadioGroup);
            this.groupControl1.Location = new System.Drawing.Point(4, 127);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(214, 90);
            this.groupControl1.TabIndex = 3;
            this.groupControl1.Text = "Alignment";
            // 
            // alignmentRadioGroup
            // 
            this.alignmentRadioGroup.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", bindingSource, "Alignment", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.alignmentRadioGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.alignmentRadioGroup.Location = new System.Drawing.Point(2, 20);
            this.alignmentRadioGroup.Name = "alignmentRadioGroup";
            this.alignmentRadioGroup.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.alignmentRadioGroup.Properties.Appearance.Options.UseBackColor = true;
            this.alignmentRadioGroup.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.alignmentRadioGroup.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(DevExpress.Diagram.Core.Alignment.Near, "Near"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(DevExpress.Diagram.Core.Alignment.Center, "Center"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(DevExpress.Diagram.Core.Alignment.Far, "Far")});
            this.alignmentRadioGroup.Size = new System.Drawing.Size(210, 68);
            this.alignmentRadioGroup.TabIndex = 2;
            this.alignmentRadioGroup.SelectedIndexChanged += new System.EventHandler(this.RadioGroupSelectedItemChanged);
            // 
            // groupControl2
            // 
            this.groupControl2.AutoSize = true;
            this.groupControl2.CaptionLocation = DevExpress.Utils.Locations.Top;
            this.groupControl2.Controls.Add(this.horizontalSpacingTrackBar);
            this.groupControl2.Location = new System.Drawing.Point(4, 221);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(214, 50);
            this.groupControl2.TabIndex = 4;
            this.groupControl2.Text = " Horizontal Spacing";
            // 
            // horizontalSpacingTrackBar
            // 
            this.horizontalSpacingTrackBar.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", bindingSource, "HorizontalSpacing", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.horizontalSpacingTrackBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.horizontalSpacingTrackBar.EditValue = 20;
            this.horizontalSpacingTrackBar.Location = new System.Drawing.Point(2, 20);
            this.horizontalSpacingTrackBar.Name = "horizontalSpacingTrackBar";
            this.horizontalSpacingTrackBar.Properties.LabelAppearance.Options.UseTextOptions = true;
            this.horizontalSpacingTrackBar.Properties.LabelAppearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.horizontalSpacingTrackBar.Properties.Maximum = 150;
            this.horizontalSpacingTrackBar.Properties.Minimum = 20;
            this.horizontalSpacingTrackBar.Properties.ShowValueToolTip = true;
            this.horizontalSpacingTrackBar.Properties.SmallChange = 15;
            this.horizontalSpacingTrackBar.Properties.TickStyle = System.Windows.Forms.TickStyle.None;
            this.horizontalSpacingTrackBar.Size = new System.Drawing.Size(210, 28);
            this.horizontalSpacingTrackBar.TabIndex = 0;
            this.horizontalSpacingTrackBar.Value = 20;
            this.horizontalSpacingTrackBar.ValueChanged += new System.EventHandler(this.TrackBarValueChanged);
            // 
            // TreeLayoutModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "TreeLayoutModule";
            this.Size = new System.Drawing.Size(793, 581);
            ((System.ComponentModel.ISupportInitialize)(this.navigationPane1)).EndInit();
            this.navigationPane1.ResumeLayout(false);
            this.optionsPanel.ResumeLayout(false);
            this.optionsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.diagramControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(bindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).EndInit();
            this.groupControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.directionRadioGroup.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl6)).EndInit();
            this.groupControl6.ResumeLayout(false);
            this.groupControl6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.verticalSpacingTrackBar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.verticalSpacingTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.alignmentRadioGroup.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.horizontalSpacingTrackBar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.horizontalSpacingTrackBar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private XtraEditors.GroupControl groupControl4;
        private XtraEditors.RadioGroup directionRadioGroup;
        private XtraEditors.GroupControl groupControl6;
        private XtraEditors.TrackBarControl verticalSpacingTrackBar;
        private XtraEditors.GroupControl groupControl1;
        private XtraEditors.RadioGroup alignmentRadioGroup;
        private XtraEditors.TrackBarControl horizontalSpacingTrackBar;
        private XtraEditors.GroupControl groupControl2;
    }
}
