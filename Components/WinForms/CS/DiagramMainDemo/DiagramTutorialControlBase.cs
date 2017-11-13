using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using DevExpress.DXperience.Demos;
using DevExpress.Utils;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraDiagram.Utils;

namespace DevExpress.XtraDiagram.Demos {
    public partial class DiagramTutorialControlBase : TutorialControlBase {
        #region Static

        public static string GetDataFileName(string fileName) {
            return FilesHelper.FindingFileName(Application.StartupPath, "Data\\Diagram\\" + fileName);
        }

        static void SubscribeRibbonEvents(RibbonControl ribbon) {
            if(ribbon != null) {
                ribbon.Merge += Ribbon_Merge;
                ribbon.UnMerge += Ribbon_UnMerge;
            }
        }
        static void UnsubscribeRibbonEvents(RibbonControl ribbon) {
            if(ribbon != null) {
                ribbon.Merge -= Ribbon_Merge;
                ribbon.UnMerge -= Ribbon_UnMerge;
            }
        }
        static void Ribbon_Merge(object sender, RibbonMergeEventArgs e) {
            e.MergeOwner.ApplicationButtonDropDownControl = e.MergedChild.ApplicationButtonDropDownControl;
            e.MergeOwner.ToolbarLocation = RibbonQuickAccessToolbarLocation.Default;
            e.MergeOwner.ShowApplicationButton = DefaultBoolean.Default;
        }
        static void Ribbon_UnMerge(object sender, RibbonMergeEventArgs e) {
            e.MergeOwner.ApplicationButtonDropDownControl = null;
            e.MergeOwner.ToolbarLocation = RibbonQuickAccessToolbarLocation.Hidden;
            e.MergeOwner.ShowApplicationButton = DefaultBoolean.False;
        }

        #endregion
        bool showOptionsPanelCore = false;

        [DefaultValue(false)]
        public bool ShowOptionsPanel {
            get { return this.showOptionsPanelCore; }
            set {
                if(showOptionsPanelCore == value) return;
                showOptionsPanelCore = value;
                UpdatePanelOptionsVisibility();
            }
        }

        public override bool AutoMergeRibbon {
            get { return true; }
            set { }
        }
        protected Control OptionsPanel { get { return this.optionsPanel; } }
        protected DiagramControl Diagram { get { return this.diagramControl; } }
        protected virtual RibbonControl Ribbon {
            get { return null; }
        }

        public DiagramTutorialControlBase() {
            InitializeComponent();
        }

        protected override void Dispose(bool disposing) {
            UnsubscribeRibbonEvents(Ribbon);
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        protected override void OnLoad(EventArgs e) {
            base.OnLoad(e);
            UpdatePanelOptionsVisibility();
            if(Ribbon != null)
                BarUtils.ForEachRibbonPageGroup(Ribbon, group => group.Visible = group.ItemLinks.Any(x => x.CanVisible));
            SubscribeRibbonEvents(Ribbon);
        }
        void UpdatePanelOptionsVisibility() {
            this.navigationPane1.Visible = ShowOptionsPanel;
        }
        protected void LoadDocument(string fileName) {
            string filePath = GetDataFileName(fileName);
            Diagram.LoadDocument(filePath);
        }
    }
}
