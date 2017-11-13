using DevExpress.Diagram.Core.Layout;

namespace DevExpress.XtraDiagram.Demos {
    partial class CircularLayoutModule {
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
            this.startAngleTrackBar = new DevExpress.XtraEditors.TrackBarControl();
            this.circularOrderRadioGroup = new DevExpress.XtraEditors.RadioGroup();
            this.groupControl4 = new DevExpress.XtraEditors.GroupControl();
            this.nodesSpacingTrackBar = new DevExpress.XtraEditors.TrackBarControl();
            this.groupControl5 = new DevExpress.XtraEditors.GroupControl();
            bindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.navigationPane1)).BeginInit();
            this.navigationPane1.SuspendLayout();
            this.optionsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.diagramControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(bindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl6)).BeginInit();
            this.groupControl6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.startAngleTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.startAngleTrackBar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.circularOrderRadioGroup.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).BeginInit();
            this.groupControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nodesSpacingTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nodesSpacingTrackBar.Properties)).BeginInit();
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
            bindingSource.DataMember = "OptionsCircularLayout";
            bindingSource.DataSource = this.diagramControl;
            bindingSource.Position = 0;
            // 
            // groupControl6
            // 
            this.groupControl6.AutoSize = true;
            this.groupControl6.Controls.Add(this.startAngleTrackBar);
            this.groupControl6.Location = new System.Drawing.Point(4, 148);
            this.groupControl6.Name = "groupControl6";
            this.groupControl6.Size = new System.Drawing.Size(214, 50);
            this.groupControl6.TabIndex = 0;
            this.groupControl6.Text = "Start Angle";
            // 
            // startAngleTrackBar
            // 
            this.startAngleTrackBar.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", bindingSource, "StartAngle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.startAngleTrackBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.startAngleTrackBar.EditValue = null;
            this.startAngleTrackBar.Location = new System.Drawing.Point(2, 20);
            this.startAngleTrackBar.Name = "startAngleTrackBar";
            this.startAngleTrackBar.Properties.LabelAppearance.Options.UseTextOptions = true;
            this.startAngleTrackBar.Properties.LabelAppearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.startAngleTrackBar.Properties.Maximum = 360;
            this.startAngleTrackBar.Properties.ShowValueToolTip = true;
            this.startAngleTrackBar.Properties.SmallChange = 15;
            this.startAngleTrackBar.Properties.TickStyle = System.Windows.Forms.TickStyle.None;
            this.startAngleTrackBar.Size = new System.Drawing.Size(210, 28);
            this.startAngleTrackBar.TabIndex = 1;
            this.startAngleTrackBar.ValueChanged += new System.EventHandler(this.TrackBarValueChanged);
            // 
            // circularOrderRadioGroup
            // 
            this.circularOrderRadioGroup.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", bindingSource, "Order", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.circularOrderRadioGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.circularOrderRadioGroup.Location = new System.Drawing.Point(2, 20);
            this.circularOrderRadioGroup.Name = "circularOrderRadioGroup";
            this.circularOrderRadioGroup.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.circularOrderRadioGroup.Properties.Appearance.Options.UseBackColor = true;
            this.circularOrderRadioGroup.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.circularOrderRadioGroup.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(DevExpress.Diagram.Core.Layout.CircularLayoutOrder.Optimal, "Optimal"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(DevExpress.Diagram.Core.Layout.CircularLayoutOrder.Clockwise, "Clockwise"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(DevExpress.Diagram.Core.Layout.CircularLayoutOrder.Counterclockwise, "Counterclockwise")});
            this.circularOrderRadioGroup.Size = new System.Drawing.Size(210, 68);
            this.circularOrderRadioGroup.TabIndex = 2;
            this.circularOrderRadioGroup.SelectedIndexChanged += new System.EventHandler(this.CircularOrderGroupSelectedItemChanged);
            // 
            // groupControl4
            // 
            this.groupControl4.AutoSize = true;
            this.groupControl4.CaptionLocation = DevExpress.Utils.Locations.Top;
            this.groupControl4.Controls.Add(this.circularOrderRadioGroup);
            this.groupControl4.Location = new System.Drawing.Point(4, 0);
            this.groupControl4.Name = "groupControl4";
            this.groupControl4.Size = new System.Drawing.Size(214, 90);
            this.groupControl4.TabIndex = 0;
            this.groupControl4.Text = "Circular Order";
            // 
            // nodesSpacingTrackBar
            // 
            this.nodesSpacingTrackBar.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", bindingSource, "NodesSpacing", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.nodesSpacingTrackBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nodesSpacingTrackBar.EditValue = null;
            this.nodesSpacingTrackBar.Location = new System.Drawing.Point(2, 20);
            this.nodesSpacingTrackBar.Name = "nodesSpacingTrackBar";
            this.nodesSpacingTrackBar.Properties.LabelAppearance.Options.UseTextOptions = true;
            this.nodesSpacingTrackBar.Properties.LabelAppearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.nodesSpacingTrackBar.Properties.Maximum = 150;
            this.nodesSpacingTrackBar.Properties.ShowValueToolTip = true;
            this.nodesSpacingTrackBar.Properties.SmallChange = 15;
            this.nodesSpacingTrackBar.Properties.TickStyle = System.Windows.Forms.TickStyle.None;
            this.nodesSpacingTrackBar.Size = new System.Drawing.Size(210, 28);
            this.nodesSpacingTrackBar.TabIndex = 0;
            this.nodesSpacingTrackBar.ValueChanged += new System.EventHandler(this.TrackBarValueChanged);
            // 
            // groupControl5
            // 
            this.groupControl5.AutoSize = true;
            this.groupControl5.CaptionLocation = DevExpress.Utils.Locations.Top;
            this.groupControl5.Controls.Add(this.nodesSpacingTrackBar);
            this.groupControl5.Location = new System.Drawing.Point(4, 94);
            this.groupControl5.Name = "groupControl5";
            this.groupControl5.Size = new System.Drawing.Size(214, 50);
            this.groupControl5.TabIndex = 0;
            this.groupControl5.Text = "Nodes Spacing";
            // 
            // CircularLayoutModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.Name = "CircularLayoutModule";
            ((System.ComponentModel.ISupportInitialize)(this.navigationPane1)).EndInit();
            this.navigationPane1.ResumeLayout(false);
            this.optionsPanel.ResumeLayout(false);
            this.optionsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.diagramControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(bindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl6)).EndInit();
            this.groupControl6.ResumeLayout(false);
            this.groupControl6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.startAngleTrackBar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.startAngleTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.circularOrderRadioGroup.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).EndInit();
            this.groupControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nodesSpacingTrackBar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nodesSpacingTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl5)).EndInit();
            this.groupControl5.ResumeLayout(false);
            this.groupControl5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private XtraEditors.GroupControl groupControl6;
        private XtraEditors.TrackBarControl startAngleTrackBar;
        private XtraEditors.RadioGroup circularOrderRadioGroup;
        private XtraEditors.GroupControl groupControl4;
        private XtraEditors.TrackBarControl nodesSpacingTrackBar;
        private XtraEditors.GroupControl groupControl5;
    }
}
