using DevExpress.Diagram.Core.Layout;

namespace DevExpress.XtraDiagram.Demos {
    partial class TipOverTreeLayoutModule {
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
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.offsetTrackBar = new DevExpress.XtraEditors.TrackBarControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.tipOverOffsetModeRadioGroup = new DevExpress.XtraEditors.RadioGroup();
            this.groupControl4 = new DevExpress.XtraEditors.GroupControl();
            this.tipOverDirectionRadioGroup = new DevExpress.XtraEditors.RadioGroup();
            this.groupControl6 = new DevExpress.XtraEditors.GroupControl();
            this.verticalSpacingTrackBar = new DevExpress.XtraEditors.TrackBarControl();
            bindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.navigationPane1)).BeginInit();
            this.navigationPane1.SuspendLayout();
            this.optionsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.diagramControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(bindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.offsetTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.offsetTrackBar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tipOverOffsetModeRadioGroup.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).BeginInit();
            this.groupControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tipOverDirectionRadioGroup.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl6)).BeginInit();
            this.groupControl6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.verticalSpacingTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.verticalSpacingTrackBar.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // navigationPane1
            // 
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
            this.diagramControl.Size = new System.Drawing.Size(504, 407);
            // 
            // bindingSource
            // 
            bindingSource.DataMember = "OptionsTipOverTreeLayout";
            bindingSource.DataSource = this.diagramControl;
            bindingSource.Position = 0;
            // 
            // groupControl2
            // 
            this.groupControl2.AutoSize = true;
            this.groupControl2.CaptionLocation = DevExpress.Utils.Locations.Top;
            this.groupControl2.Controls.Add(this.offsetTrackBar);
            this.groupControl2.Location = new System.Drawing.Point(3, 155);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(214, 50);
            this.groupControl2.TabIndex = 13;
            this.groupControl2.Text = "Offset";
            // 
            // offsetTrackBar
            // 
            this.offsetTrackBar.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", bindingSource, "Offset", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.offsetTrackBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.offsetTrackBar.EditValue = 30;
            this.offsetTrackBar.Location = new System.Drawing.Point(2, 20);
            this.offsetTrackBar.Name = "offsetTrackBar";
            this.offsetTrackBar.Properties.LabelAppearance.Options.UseTextOptions = true;
            this.offsetTrackBar.Properties.LabelAppearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.offsetTrackBar.Properties.Maximum = 150;
            this.offsetTrackBar.Properties.Minimum = 30;
            this.offsetTrackBar.Properties.ShowValueToolTip = true;
            this.offsetTrackBar.Properties.SmallChange = 15;
            this.offsetTrackBar.Properties.TickStyle = System.Windows.Forms.TickStyle.None;
            this.offsetTrackBar.Size = new System.Drawing.Size(210, 28);
            this.offsetTrackBar.TabIndex = 0;
            this.offsetTrackBar.Value = 30;
            this.offsetTrackBar.ValueChanged += new System.EventHandler(this.TrackBarValueChanged);
            // 
            // groupControl1
            // 
            this.groupControl1.AutoSize = true;
            this.groupControl1.CaptionLocation = DevExpress.Utils.Locations.Top;
            this.groupControl1.Controls.Add(this.tipOverOffsetModeRadioGroup);
            this.groupControl1.Location = new System.Drawing.Point(3, 78);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(214, 73);
            this.groupControl1.TabIndex = 12;
            this.groupControl1.Text = "Tip Over Offset Mode";
            // 
            // tipOverOffsetModeRadioGroup
            // 
            this.tipOverOffsetModeRadioGroup.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", bindingSource, "OffsetMode", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tipOverOffsetModeRadioGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tipOverOffsetModeRadioGroup.Location = new System.Drawing.Point(2, 20);
            this.tipOverOffsetModeRadioGroup.Name = "tipOverOffsetModeRadioGroup";
            this.tipOverOffsetModeRadioGroup.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.tipOverOffsetModeRadioGroup.Properties.Appearance.Options.UseBackColor = true;
            this.tipOverOffsetModeRadioGroup.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.tipOverOffsetModeRadioGroup.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(DevExpress.Diagram.Core.Layout.TipOverOffsetMode.Center, "Center"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(DevExpress.Diagram.Core.Layout.TipOverOffsetMode.Edge, "Edge")});
            this.tipOverOffsetModeRadioGroup.Size = new System.Drawing.Size(210, 51);
            this.tipOverOffsetModeRadioGroup.TabIndex = 2;
            this.tipOverOffsetModeRadioGroup.SelectedIndexChanged += new System.EventHandler(this.RadioGroupSelectedItemChanged);
            // 
            // groupControl4
            // 
            this.groupControl4.AutoSize = true;
            this.groupControl4.CaptionLocation = DevExpress.Utils.Locations.Top;
            this.groupControl4.Controls.Add(this.tipOverDirectionRadioGroup);
            this.groupControl4.Location = new System.Drawing.Point(3, 1);
            this.groupControl4.Name = "groupControl4";
            this.groupControl4.Size = new System.Drawing.Size(214, 73);
            this.groupControl4.TabIndex = 10;
            this.groupControl4.Text = "Tip Over Direction";
            // 
            // tipOverDirectionRadioGroup
            // 
            this.tipOverDirectionRadioGroup.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", bindingSource, "Direction", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tipOverDirectionRadioGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tipOverDirectionRadioGroup.Location = new System.Drawing.Point(2, 20);
            this.tipOverDirectionRadioGroup.Name = "tipOverDirectionRadioGroup";
            this.tipOverDirectionRadioGroup.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.tipOverDirectionRadioGroup.Properties.Appearance.Options.UseBackColor = true;
            this.tipOverDirectionRadioGroup.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.tipOverDirectionRadioGroup.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(DevExpress.Diagram.Core.Layout.TipOverDirection.LeftToRight, "LeftToRight"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(DevExpress.Diagram.Core.Layout.TipOverDirection.RightToLeft, "RightToLeft")});
            this.tipOverDirectionRadioGroup.Size = new System.Drawing.Size(210, 51);
            this.tipOverDirectionRadioGroup.TabIndex = 2;
            this.tipOverDirectionRadioGroup.SelectedIndexChanged += new System.EventHandler(this.RadioGroupSelectedItemChanged);
            // 
            // groupControl6
            // 
            this.groupControl6.AutoSize = true;
            this.groupControl6.Controls.Add(this.verticalSpacingTrackBar);
            this.groupControl6.Location = new System.Drawing.Point(3, 209);
            this.groupControl6.Name = "groupControl6";
            this.groupControl6.Size = new System.Drawing.Size(214, 50);
            this.groupControl6.TabIndex = 11;
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
            // TipOverTreeLayoutModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "TipOverTreeLayoutModule";
            ((System.ComponentModel.ISupportInitialize)(this.navigationPane1)).EndInit();
            this.navigationPane1.ResumeLayout(false);
            this.optionsPanel.ResumeLayout(false);
            this.optionsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.diagramControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(bindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.offsetTrackBar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.offsetTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tipOverOffsetModeRadioGroup.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).EndInit();
            this.groupControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tipOverDirectionRadioGroup.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl6)).EndInit();
            this.groupControl6.ResumeLayout(false);
            this.groupControl6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.verticalSpacingTrackBar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.verticalSpacingTrackBar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private XtraEditors.TrackBarControl offsetTrackBar;
        private XtraEditors.RadioGroup tipOverOffsetModeRadioGroup;
        private XtraEditors.RadioGroup tipOverDirectionRadioGroup;
        private XtraEditors.TrackBarControl verticalSpacingTrackBar;
        private XtraEditors.GroupControl groupControl6;
        private XtraEditors.GroupControl groupControl4;
        private XtraEditors.GroupControl groupControl1;
        private XtraEditors.GroupControl groupControl2;
    }
}
