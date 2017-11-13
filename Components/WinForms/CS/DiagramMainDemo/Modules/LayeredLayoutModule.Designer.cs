using DevExpress.Diagram.Core.Layout;

namespace DevExpress.XtraDiagram.Demos {
    partial class LayeredLayoutModule {
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
            this.groupControl6 = new DevExpress.XtraEditors.GroupControl();
            this.layerSpacingTrackBar = new DevExpress.XtraEditors.TrackBarControl();
            this.directionRadioGroup = new DevExpress.XtraEditors.RadioGroup();
            this.groupControl4 = new DevExpress.XtraEditors.GroupControl();
            this.columnSpacingTrackBar = new DevExpress.XtraEditors.TrackBarControl();
            this.groupControl5 = new DevExpress.XtraEditors.GroupControl();
            bindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.navigationPane1)).BeginInit();
            this.navigationPane1.SuspendLayout();
            this.optionsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.diagramControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(bindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl6)).BeginInit();
            this.groupControl6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layerSpacingTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layerSpacingTrackBar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.directionRadioGroup.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).BeginInit();
            this.groupControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.columnSpacingTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.columnSpacingTrackBar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl5)).BeginInit();
            this.groupControl5.SuspendLayout();
            this.SuspendLayout();
            // 
            // navigationPane1
            // 
            this.navigationPane1.PageProperties.ShowExpandButton = false;
            this.navigationPane1.PageProperties.ShowMode = DevExpress.XtraBars.Navigation.ItemShowMode.Image;
            // 
            // optionsPanel
            // 
            this.optionsPanel.Controls.Add(this.groupControl4);
            this.optionsPanel.Controls.Add(this.groupControl6);
            this.optionsPanel.Controls.Add(this.groupControl5);
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
            bindingSource.DataMember = "OptionsSugiyamaLayout";
            bindingSource.DataSource = this.diagramControl;
            bindingSource.Position = 0;
            // 
            // groupControl6
            // 
            this.groupControl6.AutoSize = true;
            this.groupControl6.Controls.Add(this.layerSpacingTrackBar);
            this.groupControl6.Location = new System.Drawing.Point(4, 178);
            this.groupControl6.Name = "groupControl6";
            this.groupControl6.Size = new System.Drawing.Size(214, 50);
            this.groupControl6.TabIndex = 0;
            this.groupControl6.Text = "Layer Spacing";
            // 
            // layerSpacingTrackBar
            // 
            this.layerSpacingTrackBar.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", bindingSource, "LayerSpacing", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.layerSpacingTrackBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layerSpacingTrackBar.EditValue = 30;
            this.layerSpacingTrackBar.Location = new System.Drawing.Point(2, 20);
            this.layerSpacingTrackBar.Name = "layerSpacingTrackBar";
            this.layerSpacingTrackBar.Properties.LabelAppearance.Options.UseTextOptions = true;
            this.layerSpacingTrackBar.Properties.LabelAppearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.layerSpacingTrackBar.Properties.Maximum = 150;
            this.layerSpacingTrackBar.Properties.Minimum = 30;
            this.layerSpacingTrackBar.Properties.ShowValueToolTip = true;
            this.layerSpacingTrackBar.Properties.SmallChange = 15;
            this.layerSpacingTrackBar.Properties.TickStyle = System.Windows.Forms.TickStyle.None;
            this.layerSpacingTrackBar.Size = new System.Drawing.Size(210, 28);
            this.layerSpacingTrackBar.TabIndex = 1;
            this.layerSpacingTrackBar.Value = 30;
            this.layerSpacingTrackBar.ValueChanged += new System.EventHandler(this.TrackBarValueChanged);
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
            this.directionRadioGroup.TabIndex = 2;
            this.directionRadioGroup.SelectedIndexChanged += new System.EventHandler(this.RadioGroupSelectedItemChanged);
            // 
            // groupControl4
            // 
            this.groupControl4.AutoSize = true;
            this.groupControl4.CaptionLocation = DevExpress.Utils.Locations.Top;
            this.groupControl4.Controls.Add(this.directionRadioGroup);
            this.groupControl4.Location = new System.Drawing.Point(4, 0);
            this.groupControl4.Name = "groupControl4";
            this.groupControl4.Size = new System.Drawing.Size(214, 120);
            this.groupControl4.TabIndex = 0;
            this.groupControl4.Text = "Direction";
            // 
            // columnSpacingTrackBar
            // 
            this.columnSpacingTrackBar.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", bindingSource, "ColumnSpacing", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.columnSpacingTrackBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.columnSpacingTrackBar.EditValue = 20;
            this.columnSpacingTrackBar.Location = new System.Drawing.Point(2, 20);
            this.columnSpacingTrackBar.Name = "columnSpacingTrackBar";
            this.columnSpacingTrackBar.Properties.LabelAppearance.Options.UseTextOptions = true;
            this.columnSpacingTrackBar.Properties.LabelAppearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.columnSpacingTrackBar.Properties.Maximum = 150;
            this.columnSpacingTrackBar.Properties.Minimum = 20;
            this.columnSpacingTrackBar.Properties.ShowValueToolTip = true;
            this.columnSpacingTrackBar.Properties.SmallChange = 15;
            this.columnSpacingTrackBar.Properties.TickStyle = System.Windows.Forms.TickStyle.None;
            this.columnSpacingTrackBar.Size = new System.Drawing.Size(210, 28);
            this.columnSpacingTrackBar.TabIndex = 0;
            this.columnSpacingTrackBar.Value = 20;
            this.columnSpacingTrackBar.ValueChanged += new System.EventHandler(this.TrackBarValueChanged);
            // 
            // groupControl5
            // 
            this.groupControl5.AutoSize = true;
            this.groupControl5.CaptionLocation = DevExpress.Utils.Locations.Top;
            this.groupControl5.Controls.Add(this.columnSpacingTrackBar);
            this.groupControl5.Location = new System.Drawing.Point(4, 124);
            this.groupControl5.Name = "groupControl5";
            this.groupControl5.Size = new System.Drawing.Size(214, 50);
            this.groupControl5.TabIndex = 0;
            this.groupControl5.Text = "Column Spacing";
            // 
            // LayeredLayoutModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.Name = "LayeredLayoutModule";
            ((System.ComponentModel.ISupportInitialize)(this.navigationPane1)).EndInit();
            this.navigationPane1.ResumeLayout(false);
            this.optionsPanel.ResumeLayout(false);
            this.optionsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.diagramControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(bindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl6)).EndInit();
            this.groupControl6.ResumeLayout(false);
            this.groupControl6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layerSpacingTrackBar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layerSpacingTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.directionRadioGroup.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).EndInit();
            this.groupControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.columnSpacingTrackBar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.columnSpacingTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl5)).EndInit();
            this.groupControl5.ResumeLayout(false);
            this.groupControl5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private XtraEditors.GroupControl groupControl6;
        private XtraEditors.TrackBarControl layerSpacingTrackBar;
        private XtraEditors.RadioGroup directionRadioGroup;
        private XtraEditors.GroupControl groupControl4;
        private XtraEditors.TrackBarControl columnSpacingTrackBar;
        private XtraEditors.GroupControl groupControl5;
    }
}
