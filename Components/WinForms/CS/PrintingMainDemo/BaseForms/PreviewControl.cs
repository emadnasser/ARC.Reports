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
using System.ComponentModel;
using DevExpress.DXperience.Demos;
using DevExpress.Tutorials.Controls;

namespace XtraPrintingDemos {
	/// <summary>
	/// Summary description for ModuleControl.
	/// </summary>
	public class PreviewControl : TutorialControlBase, IPreviewControl { 
		protected DevExpress.XtraPrinting.Preview.DocumentViewer pControl;
        protected DevExpress.XtraBars.Navigation.NavigationPane navigationPane1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        bool wasActivated = false;

        DocumentViewer IPreviewControl.Viewer { get { return Viewer; }
		}
        protected DocumentViewer Viewer {
            get { return pControl; }
        }

        public PreviewControl() {
			InitializeComponent();
        }
        public override bool AutoMergeRibbon {
            get {
                return false;
            }
            set { }
        }
        void IPreviewControl.Activate(DocumentViewerRibbonController controller) {
            if(pControl.DockManager != null) {
                DevExpress.XtraBars.Docking.DockPanel navigationDockPanel = pControl.DockManager.Panels[new System.Guid("6b2e64eb-afd0-4676-bc3d-eca7e99946aa")];
                if(navigationDockPanel != null)
                    navigationDockPanel.SavedDock = DevExpress.XtraBars.Docking.DockingStyle.Right;
            }
            if(controller != null)
                controller.DocumentViewer = pControl;
            if(!wasActivated) {
                CreateDocument();
                wasActivated = true;
            }
        }
        protected override void DoHide() {
        }
		public void CreateDocument() {
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
            this.pControl = new DevExpress.XtraPrinting.Preview.DocumentViewer();
            this.navigationPane1 = new DevExpress.XtraBars.Navigation.NavigationPane();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.navigationPane1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pControl
            // 
            this.pControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pControl.IsMetric = false;
            this.pControl.Location = new System.Drawing.Point(2, 2);
            this.pControl.Name = "pControl";
            this.pControl.RequestDocumentCreation = false;
            this.pControl.Size = new System.Drawing.Size(1207, 497);
            this.pControl.TabIndex = 1;
            this.pControl.TabStop = false;
            // 
            // navigationPane1
            // 
            this.navigationPane1.Dock = System.Windows.Forms.DockStyle.Right;
            this.navigationPane1.ItemOrientation = System.Windows.Forms.Orientation.Vertical;
            this.navigationPane1.Location = new System.Drawing.Point(1211, 0);
            this.navigationPane1.Name = "navigationPane1";
            this.navigationPane1.PageProperties.ShowExpandButton = false;
            this.navigationPane1.RegularSize = new System.Drawing.Size(300, 333);
            this.navigationPane1.SelectedPage = null;
            this.navigationPane1.Size = new System.Drawing.Size(0, 501);
            this.navigationPane1.State = DevExpress.XtraBars.Navigation.NavigationPaneState.Collapsed;
            this.navigationPane1.TabIndex = 7;
            this.navigationPane1.Text = "navigationPane1";
            this.navigationPane1.Visible = false;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.pControl);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1211, 501);
            this.panelControl1.TabIndex = 8;
            // 
            // PreviewControl
            // 
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.navigationPane1);
            this.Name = "PreviewControl";
            this.Size = new System.Drawing.Size(1211, 501);
            ((System.ComponentModel.ISupportInitialize)(this.navigationPane1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.ResumeLayout(false);
		}
		#endregion
    }
}
