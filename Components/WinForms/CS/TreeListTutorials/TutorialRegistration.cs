using System;
using System.Reflection;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.DXperience.Demos;

namespace DevExpress.XtraTreeList.Demos.Tutorials {
	public class TutorialsInfo : DevExpress.DXperience.Demos.ModulesInfo {
		const string languageDir = "CS\\";
		
		static TreeList GetTreeListByControl(Control control) {
			if(control == null) return null;
			foreach(Control cntl in control.Controls) 
				if(cntl is TreeList)
					return (TreeList)cntl;
			return null;
		}

		public static void CloseCustomizationForm(Control control) {
			TreeList treeList = GetTreeListByControl(control);
			if(treeList == null) return;
			treeList.DestroyCustomization();
		}

		public static DevExpress.Tutorials.ModuleBase ShowModule(string name, DevExpress.XtraEditors.GroupControl group, DevExpress.DXperience.Demos.LookAndFeelMenu menu, DevExpress.LookAndFeel.DefaultLookAndFeel lookAndFeel) {
            ModuleInfo item = TutorialsInfo.GetItem(name);
			Cursor currentCursor = Cursor.Current;
			Cursor.Current = Cursors.WaitCursor;
			group.Parent.SuspendLayout();
			group.SuspendLayout();
			try {
				Control oldTutorial = null;
				if(Instance.CurrentModuleBase != null) 
					oldTutorial = Instance.CurrentModuleBase.TModule;
								
				TutorialControl tutorial = item.TModule as TutorialControl;
				tutorial.Bounds = group.DisplayRectangle;
				Instance.CurrentModuleBase = item;
				tutorial.Visible = false;
				group.Controls.Add(tutorial);
				tutorial.Dock = DockStyle.Fill;

				CloseCustomizationForm(oldTutorial);
				
				if(tutorial.ShowLookAndFeel) 
					menu.InitLookAndFeelMenu(lookAndFeel);
				else menu.InitLookAndFeelMenu(null);
				
				tutorial.AddMenuManager(menu.MainMenu.Manager);
				tutorial.Visible = true;
				if(oldTutorial != null) oldTutorial.Visible = false;
			}
			finally {
				group.ResumeLayout(true);
				group.Parent.ResumeLayout(true);
				Cursor.Current = currentCursor;
			}
			RaiseModuleChanged();
			DevExpress.Tutorials.ModuleBase module = Instance.CurrentModuleBase.TModule as DevExpress.Tutorials.ModuleBase;
			if(module != null) {
				module.TutorialInfo.Description = Instance.CurrentModuleBase.Description;
				module.TutorialInfo.TutorialName = Instance.CurrentModuleBase.Name;
				module.TutorialInfo.WhatsThisCodeFile = Instance.CurrentModuleBase.CodeFile;
				module.TutorialInfo.WhatsThisXMLFile = Instance.CurrentModuleBase.XMLFile;
				string xmlFile = DevExpress.Utils.FilesHelper.FindingFileName(Application.StartupPath, module.TutorialInfo.WhatsThisXMLFile, false);
				string codeFile = DevExpress.Utils.FilesHelper.FindingFileName(Application.StartupPath, module.TutorialInfo.WhatsThisCodeFile, false);
				if(xmlFile == "") module.TutorialInfo.WhatsThisXMLFile = languageDir + module.TutorialInfo.WhatsThisXMLFile;
				if(codeFile == "") module.TutorialInfo.WhatsThisCodeFile = languageDir + module.TutorialInfo.WhatsThisCodeFile;
			}
			return module;
		}
	}
	class RegisterTutorials {
        internal static string NewFeaturesString = "DevExpress XtraTreeList " + AssemblyInfo.MarketingVersion;
		public static void Register() {
			TutorialsInfo.Add(RegisterTutorials.NewFeaturesString, "DevExpress.XtraTreeList.Demos.Tutorials.About");
			TutorialsInfo.Add("Alpha Blending", "DevExpress.XtraTreeList.Demos.Tutorials.AlphaBlending", 
				"This example demonstrates how to adjust the Alpha Blending feature of the XtarTreeList using the XtraTreeListBlending component.", null,  
				"TreeListTutorials\\AlphaBlending\\AlphaBlending.cs", "Data\\Tutorials\\XtraTreeList\\AlphaBlending.xml");
			TutorialsInfo.Add("Column Alignment", "DevExpress.XtraTreeList.Demos.Tutorials.ColumnAlignment", 
				"This example demonstrates how to change column alignment (via DevExpress.Utils.AppearanceObject).", null,  
				"TreeListTutorials\\ColumnAlignment\\ColumnAlignment.cs", "Data\\Tutorials\\XtraTreeList\\ColumnAlignment.xml");
			TutorialsInfo.Add("Column Customization", "DevExpress.XtraTreeList.Demos.Tutorials.ColumnCustomization", 
				"This example demonstrates capabilities of Column Customization Form using.", null,  
				"TreeListTutorials\\ColumnCustomization\\ColumnCustomization.cs", "Data\\Tutorials\\XtraTreeList\\ColumnCustomization.xml");
			TutorialsInfo.Add("Column Format", "DevExpress.XtraTreeList.Demos.Tutorials.ColumnFormat", 
				"This example illustrates how to format data within a column.", null,  
				"TreeListTutorials\\ColumnFormat\\ColumnFormat.cs", "Data\\Tutorials\\XtraTreeList\\ColumnFormat.xml");
			TutorialsInfo.Add("Custom TreeList Node", "DevExpress.XtraTreeList.Demos.Tutorials.CustomTreeListNode", 
				"This example demonstrates how to use custom nodes inherited from the TreeListNode class.", null,  
				"TreeListTutorials\\CustomTreeListNode\\CustomTreeListNodeClass.cs", "Data\\Tutorials\\XtraTreeList\\CustomTreeListNode.xml");
			TutorialsInfo.Add("Data Mode", "DevExpress.XtraTreeList.Demos.Tutorials.DataMode", 
				"In this example the data source is represented by the Departments.xml file which is loaded to the treelist via the System.Data.DataSet component.", null,  
				"TreeListTutorials\\DataMode\\DataMode.cs", "Data\\Tutorials\\XtraTreeList\\DataMode.xml");
			TutorialsInfo.Add("Data Store", "DevExpress.XtraTreeList.Demos.Tutorials.DataStore", 
				"In this example the internal data source is used, data is adjusted and saved at design time.", null,  
				"TreeListTutorials\\DataStore\\DataStore.cs", "Data\\Tutorials\\XtraTreeList\\DataStore.xml");
			TutorialsInfo.Add("Drag And Drop", "DevExpress.XtraTreeList.Demos.Tutorials.DragDrop", 
				"This example demonstrates how to use DragDrop capabilities of the XtraTreeList within the control and when working with another control.", null,  
				"TreeListTutorials\\DragDrop\\DragDrop.cs", "Data\\Tutorials\\XtraTreeList\\DragDrop.xml");
			TutorialsInfo.Add("Editors", "DevExpress.XtraTreeList.Demos.Tutorials.Editors", 
				"This example demonstrates how to use various editors (from the XtraEditors Library) within the XtraTreeList (all editors are adjusted at design time).", null,  
				"TreeListTutorials\\Editors\\Editors.cs", "Data\\Tutorials\\XtraTreeList\\Editors.xml");
			TutorialsInfo.Add("Hit Info", "DevExpress.XtraTreeList.Demos.Tutorials.HitInfo", 
				"This example demonstrates how to obtain information on treelist elements (such as HitInfoType, Column, Node, CellValue) based on the point coordinates.", null,  
				"TreeListTutorials\\HitInfo\\HitInfo.cs", "Data\\Tutorials\\XtraTreeList\\HitInfo.xml");
			TutorialsInfo.Add("Multi Select", "DevExpress.XtraTreeList.Demos.Tutorials.MultiSelect", 
				"This example illustrates how to work with the MultiSelect feature (press shift or ctrl).", null,  
				"TreeListTutorials\\MultiSelect\\MultiSelect.cs", "Data\\Tutorials\\XtraTreeList\\MultiSelect.xml");
			TutorialsInfo.Add("Node Checking", "DevExpress.XtraTreeList.Demos.Tutorials.NodeChecking",
                "This tutorial demonstrates the built-in node checking feature. With the ShowCheckBoxes option enabled, tree list nodes display check boxes that allow an end-user to select/unselect nodes. Three check states can be enabled for nodes, if needed. When node checking is enabled, you can use the SPACE character to toggle a tree list node's check state, provided that no cell editor is active.", null,  
				"TreeListTutorials\\NodeChecking\\NodeChecking.cs", "Data\\Tutorials\\XtraTreeList\\NodeChecking.xml");
			TutorialsInfo.Add("Nodes Navigation", "DevExpress.XtraTreeList.Demos.Tutorials.NodesNavigation", 
				"This example demonstrates how to navigate through the XtraTreeList nodes with the help of existing methods.", null,  
				"TreeListTutorials\\NodesNavigation\\NodesNavigation.cs", "Data\\Tutorials\\XtraTreeList\\NodesNavigation.xml");
			TutorialsInfo.Add("Options", "DevExpress.XtraTreeList.Demos.Tutorials.Options", 
				"This example demonstrates how to manage XtraTreeList settings via OptionsView and OptionsBehaviour.", null,  
				"TreeListTutorials\\Options\\Options.cs", "Data\\Tutorials\\XtraTreeList\\Options.xml");
			TutorialsInfo.Add("Preview", "DevExpress.XtraTreeList.Demos.Tutorials.Preview", 
				"This example demonstrates how to use the Preview feature.", null,  
				"TreeListTutorials\\Preview\\Preview.cs", "Data\\Tutorials\\XtraTreeList\\Preview.xml");
			TutorialsInfo.Add("Printing", "DevExpress.XtraTreeList.Demos.Tutorials.Printing", 
				"This example demonstrates how to print the XtraTreeList using the XtraPrinting Library and printing options setup at runtime.", null,  
				"TreeListTutorials\\Printing\\Printing.cs", "Data\\Tutorials\\XtraTreeList\\Printing.xml");
			TutorialsInfo.Add("Simple Mode", "DevExpress.XtraTreeList.Demos.Tutorials.SimpleMode", 
				"In this example the data source is represented by the Records class which is inherited from the System.Collections.ArrayList class.", null,  
				"TreeListTutorials\\SimpleMode\\SimpleMode.cs", "Data\\Tutorials\\XtraTreeList\\SimpleMode.xml");
			TutorialsInfo.Add("Style Conditions", "DevExpress.XtraTreeList.Demos.Tutorials.StyleConditions", 
				"This example demonstrates the Style Conditions feature that allows you to customize the appearance of particular nodes. The Custom Draw feature (demonstrated on the second tab) emulates the Style Conditions, this however, allows more complex customization.", null,  
				"TreeListTutorials\\StyleConditions\\StyleConditions.cs", "Data\\Tutorials\\XtraTreeList\\StyleConditions.xml");
			TutorialsInfo.Add("Summaries", "DevExpress.XtraTreeList.Demos.Tutorials.Summaries", 
				"This example demonstrates how to work with summaries (footer summary, grouprow summary) in an XtraTreeList.", null,  
				"TreeListTutorials\\Summaries\\Summaries.cs", "Data\\Tutorials\\XtraTreeList\\Summaries.xml");
			TutorialsInfo.Add("Unbound Mode", "DevExpress.XtraTreeList.Demos.Tutorials.UnboundMode", 
				"In this example the internal data source is used, nodes are added to the treelist at runtime.", null,  
				"TreeListTutorials\\UnboundMode\\UnboundMode.cs", "Data\\Tutorials\\XtraTreeList\\UnboundMode.xml");
			TutorialsInfo.Add("Vertical Headers", "DevExpress.XtraTreeList.Demos.Tutorials.VerticalHeaders", 
				"This example demonstrates how to draw vertical captions within the header panel.", null,  
				"TreeListTutorials\\VerticalHeaders\\VerticalHeaders.cs", "Data\\Tutorials\\XtraTreeList\\VerticalHeaders.xml");
		}
	}
}
