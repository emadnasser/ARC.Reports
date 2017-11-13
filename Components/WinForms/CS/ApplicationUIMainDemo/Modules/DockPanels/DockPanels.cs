using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Reflection;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraBars.Docking;
using DevExpress.DXperience.Demos;

namespace DevExpress.ApplicationUI.Demos {
    /// <summary>
    /// Summary description for DockPanels.
    /// </summary>
    public partial class DockPanels : TutorialControlBase {
        public DockPanels() {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();
            //
            // TODO: Add any constructor code after InitializeComponent call
            //
        }

        int activeIndex = 0;
        //<sbAddPanel>
        Type[] modulesTypes = new Type[] { null, typeof(SimpleDockPanel), typeof(TabContainer), typeof(HorizontalContainer), typeof(VerticalContainer) };
        BaseControl[] modules = new BaseControl[] { null, null, null, null, null };
        //</sbAddPanel>
        private void DockPanels_Load(object sender, System.EventArgs e) {
            pnlLeft.Width = sbAutoHide.Width + sbAutoHide.Left * 2;
            treeView1.ExpandAll();
            treeView1.SelectedNode = treeView1.Nodes[0].Nodes[0];
            InitDockingStyles();
        }

        void InitDockingStyles() {
            Array arr = System.Enum.GetValues(typeof(DockingStyle));
            for(int i = 0; i < arr.Length; i++)
                if(!arr.GetValue(i).Equals(DockingStyle.Fill))
                    icbDock.Properties.Items.Add(new ImageComboBoxItem(arr.GetValue(i).ToString(), arr.GetValue(i), -1));
            icbDock.EditValue = DockingStyle.Left;
        }

        //<sbAutoHide>
        void SetRootPanelsVisibility(BaseControl control, DockVisibility visibility) {
            if(control != null)
                for(int i = control.Manager.RootPanels.Count - 1; i >= 0; i--) {
                    DockPanel panel = control.Manager.RootPanels[i];
                    if(panel == null || panel.Dock == DockingStyle.Float) continue;
                    if(panel.Count > 0 && !panel.Tabbed) {
                        DockPanel lastChild = panel[panel.Count - 1];
                        for(int j = 0; j < panel.Count - 1; j++)
                            panel[j].Visibility = DockVisibility.AutoHide;
                        lastChild.Visibility = DockVisibility.AutoHide;
                    }
                    else
                        panel.Visibility = visibility;
                }
        }
        //</sbAutoHide>
                
        private void treeView1_AfterSelect(object sender, System.Windows.Forms.TreeViewEventArgs e) {
            if(e.Node.Nodes.Count > 0) {
                treeView1.SelectedNode = e.Node.Nodes[0];
                return;
            }
            int index = treeView1.SelectedNode.ImageIndex;
            lbCaption.Text = treeView1.SelectedNode.Text;
            if(modules[index] == null) {
                ConstructorInfo constructorInfoObj = modulesTypes[index].GetConstructor(Type.EmptyTypes);
                if(constructorInfoObj != null) {
                    modules[index] = constructorInfoObj.Invoke(null) as BaseControl;
                    pnlContainer.Controls.Add(modules[index]);
                    modules[index].Dock = DockStyle.Fill;
                }
                else return;
            }
            modules[index].BringToFront();
            if(modules[activeIndex] != null && index != activeIndex) {
                modules[activeIndex].Dispose();
                modules[activeIndex] = null;
            }
            activeIndex = index;
            sbAddPanel.Enabled = true;
        }

        //<sbAddPanel>
        int maxPanelCout = 10;
        private void sbAddPanel_Click(object sender, System.EventArgs e) {
            if(modules[activeIndex] != null) {
                if(modules[activeIndex].Manager.Count < maxPanelCout)
                    modules[activeIndex].Manager.AddPanel((DockingStyle)icbDock.EditValue);
                else sbAddPanel.Enabled = false;
            }
        }
        //</sbAddPanel>

        //<sbAutoHide>
        private void sbAutoHide_Click(object sender, System.EventArgs e) {
            SetRootPanelsVisibility(modules[activeIndex], DockVisibility.AutoHide);
        }

        private void checkAutoHideMouseClick_CheckedChanged(object sender, EventArgs e) {
            if(AutoHideMouseClick.Checked) modules[activeIndex].Manager.AutoHiddenPanelShowMode = DevExpress.XtraBars.Docking.AutoHiddenPanelShowMode.MouseClick;
            else modules[activeIndex].Manager.AutoHiddenPanelShowMode = DevExpress.XtraBars.Docking.AutoHiddenPanelShowMode.MouseHover;
        }
        //</sbAutoHide>
    }
}
