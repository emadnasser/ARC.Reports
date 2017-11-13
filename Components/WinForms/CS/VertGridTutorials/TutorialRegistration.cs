using System;
using System.Reflection;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.DXperience.Demos;

namespace DevExpress.XtraVerticalGrid.Demos.Tutorials {
	public class TutorialsInfo : DevExpress.DXperience.Demos.ModulesInfo {
		const string languageDir = "CS\\";
		
		static VGridControlBase GetVerticalGridByControl(Control control) {
			if(control == null) return null;
			foreach(Control cntl in control.Controls) 
				if(cntl is VGridControlBase)
					return (VGridControlBase)cntl;
			return null;
		}

		public static void CloseCustomizationForm(Control control) {
			VGridControlBase vGrid = GetVerticalGridByControl(control);
			if(vGrid == null) return;
			vGrid.DestroyCustomization();
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
        internal static string NewFeaturesString = "DevExpress XtraVerticalGrid " + AssemblyInfo.MarketingVersion;
		public static void Register() {
			TutorialsInfo.Add(RegisterTutorials.NewFeaturesString, "DevExpress.XtraVerticalGrid.Demos.Tutorials.About");
			TutorialsInfo.Add("Category Row Buttons", "DevExpress.XtraVerticalGrid.Demos.Tutorials.CategoryRowButtons", 
				"This sample demonstrates how to switch the Category Rows style at runtime.", null, 
				"VertGridTutorials\\CategoryRowButtons\\CategoryRowButtons.cs", "Data\\Tutorials\\XtraVerticalGrid\\CategoryRowButtons.xml");
			TutorialsInfo.Add("Data Mode", "DevExpress.XtraVerticalGrid.Demos.Tutorials.DataMode", 
				"In this example the data source is represented by the Cars.xml file loaded to the VerticalGrid via the System.Data.DataSet component.", null, 
				"VertGridTutorials\\DataMode\\DataMode.cs", "Data\\Tutorials\\XtraVerticalGrid\\DataMode.xml");
			TutorialsInfo.Add("Drag And Drop", "DevExpress.XtraVerticalGrid.Demos.Tutorials.DragDrop", 
				"This example demonstrates how to use DragDrop capabilities of the XtraVerticalGrid within the control and when working with any other control.", null, 
				"VertGridTutorials\\DragDrop\\DragDrop.cs", "Data\\Tutorials\\XtraVerticalGrid\\DragDrop.xml");
			TutorialsInfo.Add("Editors", "DevExpress.XtraVerticalGrid.Demos.Tutorials.Editors", 
				"This example demonstrates how to use various editors (from the XtraEditors Library) within the XtraVerticalGrid (all editors are adjusted at design time).", null, 
				"VertGridTutorials\\Editors\\Editors.cs", "Data\\Tutorials\\XtraVerticalGrid\\Editors.xml");
			TutorialsInfo.Add("Hit Info", "DevExpress.XtraVerticalGrid.Demos.Tutorials.HitInfo", 
				"This example demonstrates how to obtain information on VerticalGrid elements (such as HitInfoType, Row, CellValue) based on the point coordinates.", null, 
				"VertGridTutorials\\HitInfo\\HitInfo.cs", "Data\\Tutorials\\XtraVerticalGrid\\HitInfo.xml");
			TutorialsInfo.Add("Layout And Paint Styles", "DevExpress.XtraVerticalGrid.Demos.Tutorials.LayoutAndPaintStyles", 
				"This sample illustrates how to use the XtraVertGrid layout styles.", null, 
				"VertGridTutorials\\LayoutAndPaintStyles\\LayoutAndPaintStyles.cs", "Data\\Tutorials\\XtraVerticalGrid\\LayoutAndPaintStyles.xml");
			TutorialsInfo.Add("Multi Editors Row", "DevExpress.XtraVerticalGrid.Demos.Tutorials.MultiEditorsRow", 
				"This sample illustrates how to adjust a separator for MultiEditors Rows.", null, 
				"VertGridTutorials\\MultiEditorsRow\\MultiEditorsRow.cs", "Data\\Tutorials\\XtraVerticalGrid\\MultiEditorsRow.xml");
			TutorialsInfo.Add("Options", "DevExpress.XtraVerticalGrid.Demos.Tutorials.Options", 
				"This example demonstrates how to manage XtraVerticalGrid settings via the View Options and Behaviour Options.", null, 
				"VertGridTutorials\\Options\\Options.cs", "Data\\Tutorials\\XtraVerticalGrid\\Options.xml");
			TutorialsInfo.Add("Resizing", "DevExpress.XtraVerticalGrid.Demos.Tutorials.Resizing", 
				"This sample shows which behavior options and properties control different element resizing features.", null, 
				"VertGridTutorials\\Resizing\\Resizing.cs", "Data\\Tutorials\\XtraVerticalGrid\\Resizing.xml");
			TutorialsInfo.Add("Row Alignment", "DevExpress.XtraVerticalGrid.Demos.Tutorials.RowAlignment", 
				"This example demonstrates how to change row cell alignment (via DevExpress.Utils.AppearanceObject).", null, 
				"VertGridTutorials\\RowAlignment\\RowAlignment.cs", "Data\\Tutorials\\XtraVerticalGrid\\RowAlignment.xml");
			TutorialsInfo.Add("Row Customization", "DevExpress.XtraVerticalGrid.Demos.Tutorials.RowCustomization", 
				"This example demonstrates the capabilities of using the Row Customization Form. You have the ability to customize individual rows and categories. The Customize form contains two tabs - Rows and Categories. You can add new categories using the New... button within the Categories tab.", null, 
				"VertGridTutorials\\RowCustomization\\RowCustomization.cs", "Data\\Tutorials\\XtraVerticalGrid\\RowCustomization.xml");
			TutorialsInfo.Add("Row Format", "DevExpress.XtraVerticalGrid.Demos.Tutorials.RowFormat", 
				"This example illustrates how to format data within a row.", null, 
				"VertGridTutorials\\RowFormat\\RowFormat.cs", "Data\\Tutorials\\XtraVerticalGrid\\RowFormat.xml");
			TutorialsInfo.Add("Rows Navigation", "DevExpress.XtraVerticalGrid.Demos.Tutorials.RowsNavigation", 
				"This example demonstrates how to navigate through XtraVerticalGrid rows with the help of existing methods.", null, 
				"VertGridTutorials\\RowsNavigation\\RowsNavigation.cs", "Data\\Tutorials\\XtraVerticalGrid\\RowsNavigation.xml");
			TutorialsInfo.Add("Scroll Visibility", "DevExpress.XtraVerticalGrid.Demos.Tutorials.ScrollVisibilitySample", 
				"This sample illustrates how to work with the ScrollVisibility property (Note, in Bands or Single View modes, setting ScrollVisibility to Never or Vertical will disable records navigation.  It is best to use a DBNavigator in such an instance to navigate data records).", null, 
				"VertGridTutorials\\ScrollVisibility\\ScrollVisibility.cs", "Data\\Tutorials\\XtraVerticalGrid\\ScrollVisibility.xml");
			TutorialsInfo.Add("Simple Alpha Blending", "DevExpress.XtraVerticalGrid.Demos.Tutorials.SimpleAlphaBlending", 
				"This example demonstrates how to adjust the Alpha Blending feature of the XtraVerticalGrid using the XtraVertGridBlending component.", null, 
				"VertGridTutorials\\SimpleAlphaBlending\\SimpleAlphaBlending.cs", "Data\\Tutorials\\XtraVerticalGrid\\SimpleAlphaBlending.xml");
			TutorialsInfo.Add("Simple Mode", "DevExpress.XtraVerticalGrid.Demos.Tutorials.SimpleMode", 
				"In this example the data source is represented by the Contacts class which is inherited from the System.Collections.ArrayList class.", null, 
				"VertGridTutorials\\SimpleMode\\SimpleModeClass.cs", "Data\\Tutorials\\XtraVerticalGrid\\SimpleMode.xml");
			TutorialsInfo.Add("Style Conditions", "DevExpress.XtraVerticalGrid.Demos.Tutorials.StyleConditions", 
				"This example demonstrates how to use different styles of XtraVerticalGrid cells based on custom conditions (the CustomDrawRowValueCell and CustomDrawRowHeaderCell events are used).", null, 
				"VertGridTutorials\\StyleConditions\\StyleConditions.cs", "Data\\Tutorials\\XtraVerticalGrid\\StyleConditions.xml");
			TutorialsInfo.Add("Style Formats", "DevExpress.XtraVerticalGrid.Demos.Tutorials.StyleFormats", 
				"This sample illustrates how to customize used styles at runtime with the help of the XStyles class (the DevExpress.XtraVerticalGrid.Styles.xml file contains definitions for used formats).", null, 
				"VertGridTutorials\\StyleFormats\\StyleFormats.cs", "Data\\Tutorials\\XtraVerticalGrid\\StyleFormats.xml");
			TutorialsInfo.Add("Unbound Mode", "DevExpress.XtraVerticalGrid.Demos.Tutorials.UnboundMode", 
				"This VerticalGrid creates rows at runtime and does not have any data source (unbound mode).", null, 
				"VertGridTutorials\\UnboundMode\\UnboundMode.cs", "Data\\Tutorials\\XtraVerticalGrid\\UnboundMode.xml");
		}
	}
}
