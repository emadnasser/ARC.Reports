using System.ComponentModel;

namespace DevExpress.XtraCharts.Demos.Miscellaneous {
    partial class AnimationDemo {

        IContainer components = null;

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
            this.components = new System.ComponentModel.Container();
            this.chartControl1 = new DevExpress.XtraCharts.ChartControl();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.bbiRotateDiagram = new DevExpress.XtraBars.BarButtonItem();
            this.bbiChangeAxisXDirection = new DevExpress.XtraBars.BarButtonItem();
            this.bbiChangeAxisYDirection = new DevExpress.XtraBars.BarButtonItem();
            this.cbeSeriesAnimation = new DevExpress.XtraEditors.ComboBoxEdit();
            this.lcSeriesAnimation = new DevExpress.XtraEditors.LabelControl();
            this.cbePointAnimation = new DevExpress.XtraEditors.ComboBoxEdit();
            this.lcPointAnimation = new DevExpress.XtraEditors.LabelControl();
            this.cheShowSeriesLabels = new DevExpress.XtraEditors.CheckEdit();
            this.sbAnimateChart = new DevExpress.XtraEditors.SimpleButton();
            this.pmContextMenu = new DevExpress.XtraBars.PopupMenu(this.components);
            this.cbSeriesView = new DevExpress.XtraEditors.ComboBoxEdit();
            this.lbSeriesView = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panel)).BeginInit();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditShowLabels.Properties)).BeginInit();
            this.panelRoot.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbeSeriesAnimation.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbePointAnimation.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cheShowSeriesLabels.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pmContextMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbSeriesView.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Controls.Add(this.lbSeriesView);
            this.panel.Controls.Add(this.cbSeriesView);
            this.panel.Controls.Add(this.cbePointAnimation);
            this.panel.Controls.Add(this.cbeSeriesAnimation);
            this.panel.Controls.Add(this.lcPointAnimation);
            this.panel.Controls.Add(this.lcSeriesAnimation);
            this.panel.Controls.Add(this.sbAnimateChart);
            this.panel.Controls.Add(this.cheShowSeriesLabels);
            this.panel.Controls.SetChildIndex(this.checkEditShowLabels, 0);
            this.panel.Controls.SetChildIndex(this.cheShowSeriesLabels, 0);
            this.panel.Controls.SetChildIndex(this.sbAnimateChart, 0);
            this.panel.Controls.SetChildIndex(this.lcSeriesAnimation, 0);
            this.panel.Controls.SetChildIndex(this.lcPointAnimation, 0);
            this.panel.Controls.SetChildIndex(this.cbeSeriesAnimation, 0);
            this.panel.Controls.SetChildIndex(this.cbePointAnimation, 0);
            this.panel.Controls.SetChildIndex(this.cbSeriesView, 0);
            this.panel.Controls.SetChildIndex(this.lbSeriesView, 0);
            // 
            // checkEditShowLabels
            // 
            this.checkEditShowLabels.Location = new System.Drawing.Point(13545, 37);
            this.checkEditShowLabels.Size = new System.Drawing.Size(82, 19);
            this.checkEditShowLabels.Visible = false;
            // 
            // chartControl1
            // 
            this.chartControl1.DataBindings = null;
            this.chartControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartControl1.Legend.Name = "Default Legend";
            this.chartControl1.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False;
            this.chartControl1.Location = new System.Drawing.Point(0, 74);
            this.chartControl1.Name = "chartControl1";
            this.chartControl1.SeriesSerializable = new DevExpress.XtraCharts.Series[0];
            this.chartControl1.Size = new System.Drawing.Size(700, 426);
            this.chartControl1.TabIndex = 2;
            this.chartControl1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.chartControl_MouseDown);
            // 
            // barManager1
            // 
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.bbiRotateDiagram,
            this.bbiChangeAxisXDirection,
            this.bbiChangeAxisYDirection});
            this.barManager1.MaxItemId = 3;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(700, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 500);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(700, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 500);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(700, 0);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 500);
            // 
            // bbiRotateDiagram
            // 
            this.bbiRotateDiagram.Caption = "Rotate Diagram";
            this.bbiRotateDiagram.Id = 0;
            this.bbiRotateDiagram.Name = "bbiRotateDiagram";
            this.bbiRotateDiagram.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiRotateDiagram_ItemClick);
            // 
            // bbiChangeAxisXDirection
            // 
            this.bbiChangeAxisXDirection.Caption = "Change Axis X Direction";
            this.bbiChangeAxisXDirection.Id = 1;
            this.bbiChangeAxisXDirection.Name = "bbiChangeAxisXDirection";
            this.bbiChangeAxisXDirection.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiChangeAxisXDirection_ItemClick);
            // 
            // bbiChangeAxisYDirection
            // 
            this.bbiChangeAxisYDirection.Caption = "Change Axis Y Direction";
            this.bbiChangeAxisYDirection.Id = 2;
            this.bbiChangeAxisYDirection.Name = "bbiChangeAxisYDirection";
            this.bbiChangeAxisYDirection.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiChangeAxisYDirection_ItemClick);
            // 
            // cbeSeriesAnimation
            // 
            this.cbeSeriesAnimation.Location = new System.Drawing.Point(288, 32);
            this.cbeSeriesAnimation.MenuManager = this.barManager1;
            this.cbeSeriesAnimation.Name = "cbeSeriesAnimation";
            this.cbeSeriesAnimation.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbeSeriesAnimation.Properties.DropDownRows = 8;
            this.cbeSeriesAnimation.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbeSeriesAnimation.Size = new System.Drawing.Size(120, 20);
            this.cbeSeriesAnimation.TabIndex = 8;
            this.cbeSeriesAnimation.SelectedValueChanged += new System.EventHandler(this.cbeSeriesAnimation_SelectedValueChanged);
            // 
            // lcSeriesAnimation
            // 
            this.lcSeriesAnimation.Location = new System.Drawing.Point(288, 12);
            this.lcSeriesAnimation.Name = "lcSeriesAnimation";
            this.lcSeriesAnimation.Size = new System.Drawing.Size(83, 13);
            this.lcSeriesAnimation.TabIndex = 7;
            this.lcSeriesAnimation.Text = "Series Animation:";
            // 
            // cbePointAnimation
            // 
            this.cbePointAnimation.Location = new System.Drawing.Point(150, 32);
            this.cbePointAnimation.MenuManager = this.barManager1;
            this.cbePointAnimation.Name = "cbePointAnimation";
            this.cbePointAnimation.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbePointAnimation.Properties.DropDownRows = 8;
            this.cbePointAnimation.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbePointAnimation.Size = new System.Drawing.Size(120, 20);
            this.cbePointAnimation.TabIndex = 8;
            this.cbePointAnimation.SelectedIndexChanged += new System.EventHandler(this.cbePointAnimation_SelectedIndexChanged);
            // 
            // lcPointAnimation
            // 
            this.lcPointAnimation.Location = new System.Drawing.Point(150, 12);
            this.lcPointAnimation.Name = "lcPointAnimation";
            this.lcPointAnimation.Size = new System.Drawing.Size(78, 13);
            this.lcPointAnimation.TabIndex = 7;
            this.lcPointAnimation.Text = "Point Animation:";
            // 
            // cheShowSeriesLabels
            // 
            this.cheShowSeriesLabels.Location = new System.Drawing.Point(430, 32);
            this.cheShowSeriesLabels.MenuManager = this.barManager1;
            this.cheShowSeriesLabels.Name = "cheShowSeriesLabels";
            this.cheShowSeriesLabels.Properties.Caption = "Show Series Labels";
            this.cheShowSeriesLabels.Size = new System.Drawing.Size(115, 19);
            this.cheShowSeriesLabels.TabIndex = 16;
            this.cheShowSeriesLabels.CheckedChanged += new System.EventHandler(this.cheShowSeriesLabels_CheckedChanged);
            // 
            // sbAnimateChart
            // 
            this.sbAnimateChart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sbAnimateChart.Location = new System.Drawing.Point(575, 14);
            this.sbAnimateChart.Name = "sbAnimateChart";
            this.sbAnimateChart.Size = new System.Drawing.Size(110, 38);
            this.sbAnimateChart.TabIndex = 17;
            this.sbAnimateChart.Text = "Animate";
            this.sbAnimateChart.Click += new System.EventHandler(this.sbAnimateChart_Click);
            // 
            // pmContextMenu
            // 
            this.pmContextMenu.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiRotateDiagram),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiChangeAxisXDirection),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiChangeAxisYDirection)});
            this.pmContextMenu.Manager = this.barManager1;
            this.pmContextMenu.MultiColumn = DevExpress.Utils.DefaultBoolean.False;
            this.pmContextMenu.Name = "pmContextMenu";
            this.pmContextMenu.ShowNavigationHeader = DevExpress.Utils.DefaultBoolean.False;
            // 
            // cbSeriesView
            // 
            this.cbSeriesView.Location = new System.Drawing.Point(12, 32);
            this.cbSeriesView.MenuManager = this.barManager1;
            this.cbSeriesView.Name = "cbSeriesView";
            this.cbSeriesView.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbSeriesView.Properties.DropDownRows = 16;
            this.cbSeriesView.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbSeriesView.Size = new System.Drawing.Size(120, 20);
            this.cbSeriesView.TabIndex = 18;
            this.cbSeriesView.SelectedIndexChanged += new System.EventHandler(this.cbSeriesView_SelectedIndexChanged);
            // 
            // lbSeriesView
            // 
            this.lbSeriesView.Location = new System.Drawing.Point(12, 12);
            this.lbSeriesView.Name = "lbSeriesView";
            this.lbSeriesView.Size = new System.Drawing.Size(58, 13);
            this.lbSeriesView.TabIndex = 19;
            this.lbSeriesView.Text = "Series View:";
            // 
            // AnimationDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chartControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "AnimationDemo";
            this.Controls.SetChildIndex(this.barDockControlTop, 0);
            this.Controls.SetChildIndex(this.barDockControlBottom, 0);
            this.Controls.SetChildIndex(this.barDockControlRight, 0);
            this.Controls.SetChildIndex(this.barDockControlLeft, 0);
            this.Controls.SetChildIndex(this.panelRoot, 0);
            this.Controls.SetChildIndex(this.chartControl1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.panel)).EndInit();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditShowLabels.Properties)).EndInit();
            this.panelRoot.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbeSeriesAnimation.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbePointAnimation.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cheShowSeriesLabels.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pmContextMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbSeriesView.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ChartControl chartControl1;
        private XtraBars.BarManager barManager1;
        private XtraBars.BarDockControl barDockControlTop;
        private XtraBars.BarDockControl barDockControlBottom;
        private XtraBars.BarDockControl barDockControlLeft;
        private XtraBars.BarDockControl barDockControlRight;
        private XtraEditors.ComboBoxEdit cbePointAnimation;
        private XtraEditors.LabelControl lcPointAnimation;
        private XtraEditors.LabelControl lcSeriesAnimation;
        private XtraEditors.ComboBoxEdit cbeSeriesAnimation;
        private XtraEditors.CheckEdit cheShowSeriesLabels;
        private XtraEditors.SimpleButton sbAnimateChart;
        private XtraBars.BarButtonItem bbiRotateDiagram;
        private XtraBars.BarButtonItem bbiChangeAxisXDirection;
        private XtraBars.BarButtonItem bbiChangeAxisYDirection;
        private XtraBars.PopupMenu pmContextMenu;
        private XtraEditors.LabelControl lbSeriesView;
        private XtraEditors.ComboBoxEdit cbSeriesView;
    }
}
