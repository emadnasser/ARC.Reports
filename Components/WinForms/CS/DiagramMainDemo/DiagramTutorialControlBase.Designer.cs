namespace DevExpress.XtraDiagram.Demos {
    partial class DiagramTutorialControlBase {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.navigationPane1 = new DevExpress.XtraBars.Navigation.NavigationPane();
            this.optionsPanel = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.containerControl = new System.Windows.Forms.ContainerControl();
            this.diagramControl = new DevExpress.XtraDiagram.DiagramControl();
            ((System.ComponentModel.ISupportInitialize)(this.navigationPane1)).BeginInit();
            this.navigationPane1.SuspendLayout();
            this.containerControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.diagramControl)).BeginInit();
            this.SuspendLayout();
            // 
            // navigationPane1
            // 
            this.navigationPane1.AllowResize = false;
            this.navigationPane1.AllowTransitionAnimation = DevExpress.Utils.DefaultBoolean.False;
            this.navigationPane1.Controls.Add(this.optionsPanel);
            this.navigationPane1.Dock = System.Windows.Forms.DockStyle.Right;
            this.navigationPane1.Location = new System.Drawing.Point(515, 0);
            this.navigationPane1.Name = "navigationPane1";
            this.navigationPane1.PageProperties.ShowExpandButton = false;
            this.navigationPane1.PageProperties.ShowMode = DevExpress.XtraBars.Navigation.ItemShowMode.Image;
            this.navigationPane1.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.optionsPanel});
            this.navigationPane1.RegularSize = new System.Drawing.Size(279, 441);
            this.navigationPane1.SelectedPage = this.optionsPanel;
            this.navigationPane1.Size = new System.Drawing.Size(279, 441);
            this.navigationPane1.TabIndex = 5;
            this.navigationPane1.Text = "navigationPane1";
            // 
            // optionsPanel
            // 
            this.optionsPanel.Caption = "Options";
            this.optionsPanel.ImageUri.Uri = "Properties;Size16x16;Office2013";
            this.optionsPanel.Name = "optionsPanel";
            this.optionsPanel.Size = new System.Drawing.Size(229, 381);
            // 
            // containerControl
            // 
            this.containerControl.Controls.Add(this.diagramControl);
            this.containerControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.containerControl.Location = new System.Drawing.Point(0, 0);
            this.containerControl.Margin = new System.Windows.Forms.Padding(0);
            this.containerControl.Name = "containerControl";
            this.containerControl.Size = new System.Drawing.Size(515, 441);
            this.containerControl.TabIndex = 6;
            // 
            // diagramControl
            // 
            this.diagramControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.diagramControl.Location = new System.Drawing.Point(0, 0);
            this.diagramControl.Name = "diagramControl";
            this.diagramControl.OptionsBehavior.SelectedStencils = new DevExpress.Diagram.Core.StencilCollection(new string[0]);
            this.diagramControl.OptionsView.PropertiesPanelVisibility = DevExpress.Diagram.Core.PropertiesPanelVisibility.Closed;
            this.diagramControl.Size = new System.Drawing.Size(515, 441);
            this.diagramControl.TabIndex = 0;
            // 
            // DiagramTutorialControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.containerControl);
            this.Controls.Add(this.navigationPane1);
            this.Name = "DiagramTutorialControl";
            this.Size = new System.Drawing.Size(794, 441);
            ((System.ComponentModel.ISupportInitialize)(this.navigationPane1)).EndInit();
            this.navigationPane1.ResumeLayout(false);
            this.containerControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.diagramControl)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        protected XtraBars.Navigation.NavigationPane navigationPane1;
        protected XtraBars.Navigation.NavigationPage optionsPanel;
        protected System.Windows.Forms.ContainerControl containerControl;
        protected DiagramControl diagramControl;
        //private DiagramTutorialControlBase diagramTutorialControlBase;
    }
}
