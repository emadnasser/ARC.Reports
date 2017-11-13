using System;
using System.Configuration;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using DevExpress.DemoData.Helpers;
using DevExpress.DemoReports;
using DevExpress.DXperience.Demos;
using DevExpress.Tutorials;
using DevExpress.Utils;
using DevExpress.XtraReports.UI;

namespace XtraReportsDemos {
    public class frmMain : DevExpress.DXperience.Demos.RibbonMainForm {
        public frmMain() {
        }
        protected override void SetFormParam() {
            this.ribbonControl1.AutoHideEmptyItems = true;
            this.ribbonControl1.TransparentEditors = true;
            this.Icon = XtraReportsDemos.Properties.Resources.AppIcon;
        }
        protected override string ProductName { get { return "XtraReportsForWin"; } }
        protected override bool IsAllowAboutModule { get { return false; } }
        protected override int DefaultModuleIndex {
            get {
                DevExpress.DXperience.Demos.ModuleInfo item = ModulesInfo.GetItemByType(typeof(XtraReportsDemos.MasterDetailReport.PreviewControl).FullName);
                if(item != null) {
                    int index = ModulesInfo.GetItemIndex(item);
                    if(index >= 0) return index;
                }
                return Math.Max(0, ModulesInfo.Count - 1);
            }
        }
        protected override string DemoName { get { return "DevExpress Reports Demo (C# code)"; } }
        protected override void ShowModule(string name, DevExpress.XtraEditors.GroupControl group, DevExpress.LookAndFeel.DefaultLookAndFeel lookAndFeel, DevExpress.Utils.Frames.ApplicationCaption caption) {
            try {
                ModuleControl control = DemosInfo.ShowModuleEx(name, group, caption, RibbonMenuManager) as ModuleControl;
                if(control != null) control.Activate();

                if(name.StartsWith("DevExpress XtraReports") || ribbonStatusBar.Visible == true) return;
                ribbonStatusBar.Visible = true;
            } catch(Exception ex) {
                throw new Exception("Module failed: " + name, ex);
            }
        }
		[STAThread]
		static void Main() {
            string path = FilesHelper.FindingFileName(AppDomain.CurrentDomain.BaseDirectory, @"Data\NWind.mdf", false);

            new ConnectionStringConfigurator(ConfigurationManager.ConnectionStrings)
                .SelectDbEngine()
                .ExpandDataDirectory(fileName => DataFilesHelper.FindFile(fileName, DataFilesHelper.DataPath));

            string directory = Path.GetDirectoryName(path);
            ConnectionHelper.SetDataDirectory(directory);

            ConnectionHelper.ApplyDataDirectory(directory);
			DevExpress.UserSkins.BonusSkins.Register();
            Application.Run(new frmMain());
        }
        protected override bool AllowMergeStatusBar {
            get {
                return true;
            }
        }
        protected override void ShowAbout() {
            DevExpress.XtraReports.Extensions.ReportsAboutHelper.About();
        }
	}
	public class DemosInfo : ModulesInfo {
        public static TutorialControlBase ShowModuleEx(string name, DevExpress.XtraEditors.GroupControl group, DevExpress.Utils.Frames.ApplicationCaption caption, RibbonMenuManager manager) {
            if(Instance.CurrentModuleBase != null) {
                if(Instance.CurrentModuleBase.Name == name)
                    return null;
                Instance.CurrentModuleBase.TModule.Visible = false;
            }

            DevExpress.DXperience.Demos.ModuleInfo item = DemosInfo.GetItem(name);
            TutorialControlBase tutorial = item.TModule as TutorialControlBase;
            if(tutorial.IsDisposed) return null;
            tutorial.Bounds = group.DisplayRectangle;
            Instance.CurrentModuleBase = item;
            tutorial.Visible = false;
            group.Controls.Add(tutorial);
            tutorial.Dock = DockStyle.Fill;
            tutorial.RibbonMenuManager = manager;
            tutorial.TutorialName = name;
            tutorial.Caption = caption;
            tutorial.Visible = true;
            tutorial.BringToFront();
            tutorial.Focus();
            RaiseModuleChanged();
            return tutorial;
        }
	}
    public class About : ucOverviewPage {
        public About() {
            InitializeComponent();
        }
        protected override Image Awards {
            get {
                return DevExpress.Tutorials.Properties.Resources.Awards_main;
            }
        }
        protected override string Line1Text {
            get {
                return "The XtraReports Suite";
            }
        }
        protected override string Line2Text {
            get {
                return "A banded report designer and viewer for the WinForms platform.";
            }
        }
        protected override string Line3Text {
            get {
                return "DevExpress Desktop Controls";
            }
        }
        protected override string Line4Text {
            get {
                return votedVSM;
            }
        }
        protected override DevExpress.Utils.About.ProductKind ProductKind {
            get {
                return DevExpress.Utils.About.ProductKind.XtraReports;
            }
        }
        private void InitializeComponent() {
            this.SuspendLayout();
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "About";
            this.Size = new System.Drawing.Size(439, 260);
            this.ResumeLayout(false);

        }
        protected override void Dispose(bool disposing) {
            if(disposing) {
                if(components != null) {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }
        private System.ComponentModel.IContainer components = null;
    }
}
