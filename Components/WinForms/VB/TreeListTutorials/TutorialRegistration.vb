Imports Microsoft.VisualBasic
Imports System
Imports System.Reflection
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.DXperience.Demos

Namespace DevExpress.XtraTreeList.Demos.Tutorials
	Public Class TutorialsInfo
		Inherits DevExpress.DXperience.Demos.ModulesInfo
        Private Const languageDir As String = "VB\"

		Private Shared Function GetTreeListByControl(ByVal control As Control) As TreeList
			If control Is Nothing Then
			Return Nothing
			End If
			For Each cntl As Control In control.Controls
				If TypeOf cntl Is TreeList Then
					Return CType(cntl, TreeList)
				End If
			Next cntl
			Return Nothing
		End Function

		Public Shared Sub CloseCustomizationForm(ByVal control As Control)
			Dim treeList As TreeList = GetTreeListByControl(control)
			If treeList Is Nothing Then
			Return
			End If
			treeList.DestroyCustomization()
		End Sub

        Public Overloads Shared Function ShowModule(ByVal name As String, ByVal groupControl As DevExpress.XtraEditors.GroupControl, ByVal menu As DevExpress.DXperience.Demos.LookAndFeelMenu, ByVal lookAndFeel As DevExpress.LookAndFeel.DefaultLookAndFeel) As DevExpress.Tutorials.ModuleBase
            Dim item As ModuleInfo = TutorialsInfo.GetItem(name)
            Dim currentCursor As Cursor = Cursor.Current
            Cursor.Current = Cursors.WaitCursor
            groupControl.Parent.SuspendLayout()
            groupControl.SuspendLayout()
            Try
                Dim oldTutorial As Control = Nothing
                If Not Instance.CurrentModuleBase Is Nothing Then
                    oldTutorial = Instance.CurrentModuleBase.TModule
                End If

                Dim tutorial As TutorialControl = TryCast(item.TModule, TutorialControl)
                tutorial.Bounds = groupControl.DisplayRectangle
                Instance.CurrentModuleBase = item
                tutorial.Visible = False
                groupControl.Controls.Add(tutorial)
                tutorial.Dock = DockStyle.Fill

                CloseCustomizationForm(oldTutorial)

                If tutorial.ShowLookAndFeel Then
                    menu.InitLookAndFeelMenu(lookAndFeel)
                Else
                    menu.InitLookAndFeelMenu(Nothing)
                End If

                tutorial.AddMenuManager(menu.MainMenu.Manager)
                tutorial.Visible = True
                If Not oldTutorial Is Nothing Then
                    oldTutorial.Visible = False
                End If
            Finally
                groupControl.ResumeLayout(True)
                groupControl.Parent.ResumeLayout(True)
                Cursor.Current = currentCursor
            End Try
            RaiseModuleChanged()
            Dim [module] As DevExpress.Tutorials.ModuleBase = TryCast(Instance.CurrentModuleBase.TModule, DevExpress.Tutorials.ModuleBase)
            If Not [module] Is Nothing Then
                [module].TutorialInfo.Description = Instance.CurrentModuleBase.Description
                [module].TutorialInfo.TutorialName = Instance.CurrentModuleBase.Name
                [module].TutorialInfo.WhatsThisCodeFile = Instance.CurrentModuleBase.CodeFile
                [module].TutorialInfo.WhatsThisXMLFile = Instance.CurrentModuleBase.XMLFile
                Dim xmlFile As String = DevExpress.Utils.FilesHelper.FindingFileName(Application.StartupPath, [module].TutorialInfo.WhatsThisXMLFile, False)
                Dim codeFile As String = DevExpress.Utils.FilesHelper.FindingFileName(Application.StartupPath, [module].TutorialInfo.WhatsThisCodeFile, False)
                If xmlFile = "" Then
                    [module].TutorialInfo.WhatsThisXMLFile = languageDir & [module].TutorialInfo.WhatsThisXMLFile
                End If
                If codeFile = "" Then
                    [module].TutorialInfo.WhatsThisCodeFile = languageDir & [module].TutorialInfo.WhatsThisCodeFile
                End If
            End If
            Return [module]
        End Function
	End Class
	Friend Class RegisterTutorials
        Friend Shared NewFeaturesString As String = "DevExpress XtraTreeList " & AssemblyInfo.MarketingVersion
		Public Shared Sub Register()
            TutorialsInfo.Add(RegisterTutorials.NewFeaturesString, "DevExpress.XtraTreeList.Demos.Tutorials.About")
            TutorialsInfo.Add("Alpha Blending", "DevExpress.XtraTreeList.Demos.Tutorials.AlphaBlending", "This example demonstrates how to adjust the Alpha Blending feature of the XtarTreeList using the XtraTreeListBlending component.", Nothing, "TreeListTutorials\AlphaBlending\AlphaBlending.vb", "Data\Tutorials\XtraTreeList\AlphaBlending.xml")
            TutorialsInfo.Add("Column Alignment", "DevExpress.XtraTreeList.Demos.Tutorials.ColumnAlignment", "This example demonstrates how to change column alignment (via DevExpress.Utils.AppearanceObject).", Nothing, "TreeListTutorials\ColumnAlignment\ColumnAlignment.vb", "Data\Tutorials\XtraTreeList\ColumnAlignment.xml")
            TutorialsInfo.Add("Column Customization", "DevExpress.XtraTreeList.Demos.Tutorials.ColumnCustomization", "This example demonstrates capabilities of Column Customization Form using.", Nothing, "TreeListTutorials\ColumnCustomization\ColumnCustomization.vb", "Data\Tutorials\XtraTreeList\ColumnCustomization.xml")
            TutorialsInfo.Add("Column Format", "DevExpress.XtraTreeList.Demos.Tutorials.ColumnFormat", "This example illustrates how to format data within a column.", Nothing, "TreeListTutorials\ColumnFormat\ColumnFormat.vb", "Data\Tutorials\XtraTreeList\ColumnFormat.xml")
            TutorialsInfo.Add("Custom TreeList Node", "DevExpress.XtraTreeList.Demos.Tutorials.CustomTreeListNode", "This example demonstrates how to use custom nodes inherited from the TreeListNode class.", Nothing, "TreeListTutorials\CustomTreeListNode\CustomTreeListNodeClass.vb", "Data\Tutorials\XtraTreeList\CustomTreeListNode.xml")
            TutorialsInfo.Add("Data Mode", "DevExpress.XtraTreeList.Demos.Tutorials.DataMode", "In this example the data source is represented by the Departments.xml file which is loaded to the treelist via the System.Data.DataSet component.", Nothing, "TreeListTutorials\DataMode\DataMode.vb", "Data\Tutorials\XtraTreeList\DataMode.xml")
            TutorialsInfo.Add("Data Store", "DevExpress.XtraTreeList.Demos.Tutorials.DataStore", "In this example the internal data source is used, data is adjusted and saved at design time.", Nothing, "TreeListTutorials\DataStore\DataStore.vb", "Data\Tutorials\XtraTreeList\DataStore.xml")
            TutorialsInfo.Add("Drag And Drop", "DevExpress.XtraTreeList.Demos.Tutorials.DragDrop", "This example demonstrates how to use DragDrop capabilities of the XtraTreeList within the control and when working with another control.", Nothing, "TreeListTutorials\DragDrop\DragDrop.vb", "Data\Tutorials\XtraTreeList\DragDrop.xml")
            TutorialsInfo.Add("Editors", "DevExpress.XtraTreeList.Demos.Tutorials.Editors", "This example demonstrates how to use various editors (from the XtraEditors Library) within the XtraTreeList (all editors are adjusted at design time).", Nothing, "TreeListTutorials\Editors\Editors.vb", "Data\Tutorials\XtraTreeList\Editors.xml")
            TutorialsInfo.Add("Hit Info", "DevExpress.XtraTreeList.Demos.Tutorials.HitInfo", "This example demonstrates how to obtain information on treelist elements (such as HitInfoType, Column, Node, CellValue) based on the point coordinates.", Nothing, "TreeListTutorials\HitInfo\HitInfo.vb", "Data\Tutorials\XtraTreeList\HitInfo.xml")
            TutorialsInfo.Add("Multi Select", "DevExpress.XtraTreeList.Demos.Tutorials.MultiSelect", "This example illustrates how to work with the MultiSelect feature (press shift or ctrl).", Nothing, "TreeListTutorials\MultiSelect\MultiSelect.vb", "Data\Tutorials\XtraTreeList\MultiSelect.xml")
            TutorialsInfo.Add("Node Checking", "DevExpress.XtraTreeList.Demos.Tutorials.NodeChecking", "This tutorial demonstrates the built-in node checking feature. With the ShowCheckBoxes option enabled, tree list nodes display check boxes that allow an end-user to select/unselect nodes. Three check states can be enabled for nodes, if needed. When node checking is enabled, you can use the SPACE character to toggle a tree list node's check state, provided that no cell editor is active.", Nothing, "TreeListTutorials\NodeChecking\NodeChecking.vb", "Data\Tutorials\XtraTreeList\NodeChecking.xml")
            TutorialsInfo.Add("Nodes Navigation", "DevExpress.XtraTreeList.Demos.Tutorials.NodesNavigation", "This example demonstrates how to navigate through the XtraTreeList nodes with the help of existing methods.", Nothing, "TreeListTutorials\NodesNavigation\NodesNavigation.vb", "Data\Tutorials\XtraTreeList\NodesNavigation.xml")
            TutorialsInfo.Add("Options", "DevExpress.XtraTreeList.Demos.Tutorials.Options", "This example demonstrates how to manage XtraTreeList settings via OptionsView and OptionsBehaviour.", Nothing, "TreeListTutorials\Options\Options.vb", "Data\Tutorials\XtraTreeList\Options.xml")
            TutorialsInfo.Add("Preview", "DevExpress.XtraTreeList.Demos.Tutorials.Preview", "This example demonstrates how to use the Preview feature.", Nothing, "TreeListTutorials\Preview\Preview.vb", "Data\Tutorials\XtraTreeList\Preview.xml")
            TutorialsInfo.Add("Printing", "DevExpress.XtraTreeList.Demos.Tutorials.Printing", "This example demonstrates how to print the XtraTreeList using the XtraPrinting Library and printing options setup at runtime.", Nothing, "TreeListTutorials\Printing\Printing.vb", "Data\Tutorials\XtraTreeList\Printing.xml")
            TutorialsInfo.Add("Simple Mode", "DevExpress.XtraTreeList.Demos.Tutorials.SimpleMode", "In this example the data source is represented by the Records class which is inherited from the System.Collections.ArrayList class.", Nothing, "TreeListTutorials\SimpleMode\SimpleMode.vb", "Data\Tutorials\XtraTreeList\SimpleMode.xml")
            TutorialsInfo.Add("Style Conditions", "DevExpress.XtraTreeList.Demos.Tutorials.StyleConditions", "This example demonstrates the Style Conditions feature that allows you to customize the appearance of particular nodes. The Custom Draw feature (demonstrated on the second tab) emulates the Style Conditions, this however, allows more complex customization.", Nothing, "TreeListTutorials\StyleConditions\StyleConditions.vb", "Data\Tutorials\XtraTreeList\StyleConditions.xml")
            TutorialsInfo.Add("Summaries", "DevExpress.XtraTreeList.Demos.Tutorials.Summaries", "This example demonstrates how to work with summaries (footer summary, grouprow summary) in an XtraTreeList.", Nothing, "TreeListTutorials\Summaries\Summaries.vb", "Data\Tutorials\XtraTreeList\Summaries.xml")
            TutorialsInfo.Add("Unbound Mode", "DevExpress.XtraTreeList.Demos.Tutorials.UnboundMode", "In this example the internal data source is used, nodes are added to the treelist at runtime.", Nothing, "TreeListTutorials\UnboundMode\UnboundMode.vb", "Data\Tutorials\XtraTreeList\UnboundMode.xml")
            TutorialsInfo.Add("Vertical Headers", "DevExpress.XtraTreeList.Demos.Tutorials.VerticalHeaders", "This example demonstrates how to draw vertical captions within the header panel.", Nothing, "TreeListTutorials\VerticalHeaders\VerticalHeaders.vb", "Data\Tutorials\XtraTreeList\VerticalHeaders.xml")
		End Sub
	End Class
End Namespace
