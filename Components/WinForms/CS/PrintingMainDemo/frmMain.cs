using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.Utils;
using DevExpress.XtraBars;
using DevExpress.LookAndFeel;
using DevExpress.DXperience.Demos;
using DevExpress.Tutorials;
using DevExpress.XtraPrinting;
using DevExpress.Tutorials.Controls;

namespace XtraPrintingDemos 
{
    public class frmMain : DevExpress.DXperience.Demos.RibbonMainForm {
        bool isDemoCenter = false;
        ModuleContainer moduleContainer;

        protected override void SetFormParam() {
            this.ribbonControl1.AutoHideEmptyItems = true;
            this.Icon = ResourceImageHelper.CreateIconFromResourcesEx("XtraPrintingDemos.AppIcon.ico", typeof(frmMain).Assembly);
        }
        protected override string DemoName { get { return "XtraPrinting Features Demo (C# code)"; } }
        protected override string ProductName { get { return "XtraPrinting"; } }
        protected override void ShowModule(string name, DevExpress.XtraEditors.GroupControl group, DevExpress.LookAndFeel.DefaultLookAndFeel lookAndFeel, DevExpress.Utils.Frames.ApplicationCaption caption) {
            if(moduleContainer == null) {
                moduleContainer = new ModuleContainer() { Bounds = group.DisplayRectangle, Dock = DockStyle.Fill };
                group.Controls.Add(moduleContainer);
                MergeRibbon(moduleContainer.RibbonControl);
            }
            DemosInfo.ActivateModule(name, caption, module => {
                moduleContainer.ModuleControl = module;
                if(module is IPreviewControl)
                    ((IPreviewControl)module).Activate(moduleContainer.PrintRibbonController);
            });
        }
        protected override void ShowAbout() {
            PrintingSystem.About();
        }
        [STAThread]
        static void Main(string[] args) {
            string path = FilesHelper.FindingFileName(AppDomain.CurrentDomain.BaseDirectory, @"Data\nwind.mdb", false);
            string directory = System.IO.Path.GetDirectoryName(path);
            AppDomain.CurrentDomain.SetData("DataDirectory", directory);

            DevExpress.UserSkins.BonusSkins.Register();
            Application.Run(new frmMain());
        }
        public frmMain() : this(new string[] { }) { }

        public frmMain(string[] args) {
            InitializeComponent();
            bciFilter.Checked = false;

            if(args.Length > 0)
                foreach(string arg in args)
                    isDemoCenter = !string.IsNullOrEmpty(arg) && arg.Equals("-demo");
        }
       
        private void InitializeComponent() {
            this.SuspendLayout();
            this.ribbonStatusBar.Visible = true;
            this.ribbonControl1.TransparentEditors = true;
            this.ResumeLayout(false);
        }
        protected override bool AllowMergeStatusBar {
            get {
                return true;
            }
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
                return "The XtraPrinting Library";
            }
        }
        protected override string Line2Text {
            get {
                return "Print or export the contents of DevExpress WinForms controls.";
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
                return DevExpress.Utils.About.ProductKind.DXperienceWin;
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
