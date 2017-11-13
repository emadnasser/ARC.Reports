﻿using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using DevExpress.DXperience.Demos;
using DevExpress.XtraEditors.Designer.Utils;
using DevExpress.XtraNavBar;

namespace DevExpress.ApplicationUI.Demos {
    public partial class IDEWorkspaces : TutorialControlBase {
        List<Stream> fileStreams;
        public IDEWorkspaces() {
            InitializeComponent();
            FillNavBar();
            InitPropertyGrid();
            AddPerformanceReport();
            LoadWorkspaces();
            tabbedView1.QueryControl += tabbedView1_QueryControl;
        }
        void LoadWorkspaces() {
            workspaceManager1.LoadWorkspace("Default Workspace", Program.GetStream("Workspace 1.xml"));
            workspaceManager1.LoadWorkspace("Perfomance Analyze", Program.GetStream("Workspace 2.xml"));
            workspaceManager1.LoadWorkspace("Compare Documents", Program.GetStream("Workspace 3.xml"));
        }
        void AddPerformanceReport() {
            this.fileStreams = Program.CreateResourceStreams();
            var document = tabbedView1.AddDocument(new ucPerfomanceGrid());
            document.Caption = "Analyzed Report";
        }
        void InitPropertyGrid() {
            DXPropertyGridEx propertyGrid = new DXPropertyGridEx();
            dockPanel3_Container.Controls.Add(propertyGrid);
            propertyGrid.Dock = DockStyle.Fill;
            propertyGrid.SelectedObject = workspaceManager1;
        }
        int fileIndex = 0;
        void tabbedView1_QueryControl(object sender, XtraBars.Docking2010.Views.QueryControlEventArgs e) {
            var control = new ucCodeEditor();
            control.LoadCode(fileStreams[fileIndex % 3]);
            fileIndex++;
            e.Control = control;
        }
        void FillNavBar() {
            NavBarGroup standardGroup = navBarControl1.Groups.Add();
            standardGroup.Caption = "Standard";
            standardGroup.Name = "standardGroup";
            NavBarGroup devexpressGroup = navBarControl1.Groups.Add();
            devexpressGroup.Caption = "DevExpress";
            devexpressGroup.Name = "devexpressGroup";
            devexpressGroup.Expanded = true;
            foreach(string key in toolboxImages.Images.Keys) {
                NavBarItem item = new NavBarItem();
                item.Caption = GetCaption(key);
                item.Name = item.Caption;
                item.SmallImageIndex = toolboxImages.Images.IndexOfKey(key);
                navBarControl1.Items.Add(item);
                if(!key.Contains("DX"))
                    standardGroup.ItemLinks.Add(item);
                else
                    devexpressGroup.ItemLinks.Add(item);
            }
        }
        string GetCaption(string key) {
            return key.Substring(0, key.IndexOf('_'));
        }
    }
}
