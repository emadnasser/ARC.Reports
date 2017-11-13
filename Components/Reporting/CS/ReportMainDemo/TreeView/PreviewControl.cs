using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using DevExpress.XtraReports.UI;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace XtraReportsDemos.TreeView
{
	public class PreviewControl : XtraReportsDemos.PreviewControl
	{
        private SplitterControl splitter1;
        private DevExpress.XtraEditors.PanelControl panelTreeView;
        TreeViewHolder holder = new TreeViewHolder();

        public PreviewControl() {
            InitializeComponent();
            holder.Dock = DockStyle.Fill;
            this.panelTreeView.Controls.Add(holder);
        }
		protected override XtraReport CreateReport() {
			Report report = new Report();
            report.BeforePrint += (s, e) => {
                report.WinControlContainer.PrintableComponent = holder.TreeView;
            };
			return report;
		}
        private void InitializeComponent() {
            this.panelTreeView = new DevExpress.XtraEditors.PanelControl();
            this.splitter1 = new SplitterControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // printControl
            // 
            this.printControl.Size = new System.Drawing.Size(696, 261);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.splitter1);
            this.panelControl1.Controls.Add(this.panelTreeView);
            this.panelControl1.Controls.SetChildIndex(this.panelTreeView, 0);
            this.panelControl1.Controls.SetChildIndex(this.splitter1, 0);
            this.panelControl1.Controls.SetChildIndex(this.printControl, 0);
            // 
            // panelTreeView
            // 
            this.panelTreeView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelTreeView.Location = new System.Drawing.Point(2, 266);
            this.panelTreeView.Name = "panelTreeView";
            this.panelTreeView.Size = new System.Drawing.Size(696, 92);
            this.panelTreeView.TabIndex = 2;
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitter1.Location = new System.Drawing.Point(2, 263);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(696, 3);
            this.splitter1.TabIndex = 3;
            this.splitter1.TabStop = false;
            // 
            // PreviewControl
            // 
            this.Name = "PreviewControl";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }
	}
}

