using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using DevExpress.XtraPrinting;
using DevExpress.XtraPrinting.Preview;
using DevExpress.XtraPrinting.Control;
using System.Data;
using System.Collections.Generic;

namespace XtraPrintingDemos {
	/// <summary>
	/// Summary description for ModuleControl.
	/// </summary>
    public abstract class PreviewControl : TutorialModuleControl {
        private DevExpress.XtraPrinting.Preview.DocumentViewer documentViewer;
		protected DevExpress.XtraPrinting.PrintingSystem printingSystem;
		private System.ComponentModel.IContainer components;
		private Cursor saveCursor;
		protected DevExpress.XtraBars.BarManager barManager1;
		private DevExpress.XtraBars.BarDockControl barDockControlTop;
		private DevExpress.XtraBars.BarDockControl barDockControlBottom;
		private DevExpress.XtraBars.BarDockControl barDockControlLeft;
		private DevExpress.XtraBars.BarDockControl barDockControlRight;
		protected DevExpress.XtraBars.Bar fBarSettings;
		private DevExpress.XtraEditors.PanelControl panelControl1;
		protected PrintBarManager fPrintBarManager;

		protected virtual ContainerControl PrintBarManagerForm { get { return documentViewer; }
		}
		protected virtual PrintPreviewFormEx PreviewForm { get { return printingSystem == null ? null : printingSystem.PreviewFormEx; }
		}

		public virtual PrintControl PrintControl { get { return documentViewer; }
		}

		public PreviewControl() {
			InitializeComponent();	
			printingSystem.SetCommandVisibility(PrintingSystemCommand.ClosePreview, CommandVisibility.None);

			if(fPrintBarManager != null) fPrintBarManager.Dispose();
			fPrintBarManager = CreatePrintBarManager(documentViewer);
		}

        public override void Activate() {
			base.Activate();
			ActivateCore();
		}

		protected virtual void ActivateCore() {
            CreateDocument();
		}
		protected void CreateDocument() {
			Cursor currentCursor = Cursor.Current;
			try {
				Cursor.Current = Cursors.WaitCursor;
				CreateDocumentCore();
			} finally {
				Cursor.Current = currentCursor;
			}
		}
		protected virtual void CreateDocumentCore() {
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		/// 
		private void InitializeComponent() {
			this.components = new System.ComponentModel.Container();
            this.documentViewer = new DevExpress.XtraPrinting.Preview.DocumentViewer();
			this.printingSystem = new DevExpress.XtraPrinting.PrintingSystem(this.components);
			this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
			this.fBarSettings = new DevExpress.XtraBars.Bar();
			this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
			this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
			this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
			this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
			this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
			((System.ComponentModel.ISupportInitialize)(this.printingSystem)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
			this.panelControl1.SuspendLayout();
			this.SuspendLayout();
			// 
            // documentViewer
			// 
			this.documentViewer.BackColor = System.Drawing.Color.Empty;
			this.documentViewer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.documentViewer.ForeColor = System.Drawing.Color.Empty;
			this.documentViewer.IsMetric = false;
			this.documentViewer.Location = new System.Drawing.Point(2, 2);
            this.documentViewer.Name = "documentViewer";
			this.documentViewer.DocumentSource = this.printingSystem;
			this.documentViewer.Size = new System.Drawing.Size(696, 368);
			this.documentViewer.TabIndex = 1;
			this.documentViewer.TabStop = false;
			// 
			// barManager1
			// 
			this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.fBarSettings});
			this.barManager1.DockControls.Add(this.barDockControlTop);
			this.barManager1.DockControls.Add(this.barDockControlBottom);
			this.barManager1.DockControls.Add(this.barDockControlLeft);
			this.barManager1.DockControls.Add(this.barDockControlRight);
			this.barManager1.Form = this.panelControl1;
			this.barManager1.MaxItemId = 2;
			// 
			// fBarSettings
			// 
			this.fBarSettings.BarName = "Custom 1";
			this.fBarSettings.DockCol = 0;
			this.fBarSettings.DockRow = 0;
			this.fBarSettings.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
			this.fBarSettings.FloatLocation = new System.Drawing.Point(51, 129);
			this.fBarSettings.FloatSize = new System.Drawing.Size(46, 24);
			this.fBarSettings.Text = "Custom 1";
			this.fBarSettings.Visible = false;
			// 
			// panelControl1
			// 
			this.panelControl1.Controls.Add(this.documentViewer);
			this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelControl1.Location = new System.Drawing.Point(0, 24);
			this.panelControl1.Name = "panelControl1";
			this.panelControl1.Size = new System.Drawing.Size(700, 372);
			this.panelControl1.TabIndex = 5;
			// 
			// PreviewControl
			// 
			this.Controls.Add(this.panelControl1);
			this.Name = "PreviewControl";
			this.Size = new System.Drawing.Size(700, 396);
			((System.ComponentModel.ISupportInitialize)(this.printingSystem)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
			this.panelControl1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion
		
		protected PrintBarManager CreatePrintBarManager(PrintControl pc) {
			PrintBarManager printBarManager = new PrintBarManager();
			printBarManager.Form = PrintBarManagerForm;
			printBarManager.Initialize(pc);
			printBarManager.MainMenu.Visible = false;
			printBarManager.AllowCustomization = false;
			return printBarManager;
		}

		private void RestoreProcess() {
			Cursor.Current = saveCursor;
		}	
		private void SetWaitProcess() {
			saveCursor = Cursor.Current;
			Cursor.Current = Cursors.AppStarting;
		}		
        PrintingSystem GetPrintingSystem() {
            return printingSystem;
        }
	}
}
