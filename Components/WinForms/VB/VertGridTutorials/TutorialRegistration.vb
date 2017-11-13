Imports Microsoft.VisualBasic
Imports System
Imports System.Reflection
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.DXperience.Demos

Namespace DevExpress.XtraVerticalGrid.Demos.Tutorials
	Public Class TutorialsInfo
		Inherits DevExpress.DXperience.Demos.ModulesInfo
        Private Const languageDir As String = "VB\"

		Private Shared Function GetVerticalGridByControl(ByVal control As Control) As VGridControlBase
			If control Is Nothing Then
			Return Nothing
			End If
			For Each cntl As Control In control.Controls
				If TypeOf cntl Is VGridControlBase Then
					Return CType(cntl, VGridControlBase)
				End If
			Next cntl
			Return Nothing
		End Function

		Public Shared Sub CloseCustomizationForm(ByVal control As Control)
			Dim vGrid As VGridControlBase = GetVerticalGridByControl(control)
			If vGrid Is Nothing Then
			Return
			End If
			vGrid.DestroyCustomization()
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
        Friend Shared NewFeaturesString As String = "DevExpress XtraVerticalGrid " & AssemblyInfo.MarketingVersion
		Public Shared Sub Register()
            TutorialsInfo.Add(RegisterTutorials.NewFeaturesString, "DevExpress.XtraVerticalGrid.Demos.Tutorials.About")
            TutorialsInfo.Add("Category Row Buttons", "DevExpress.XtraVerticalGrid.Demos.Tutorials.CategoryRowButtons", "This sample demonstrates how to switch the Category Rows style at runtime.", Nothing, "VertGridTutorials\CategoryRowButtons\CategoryRowButtons.vb", "Data\Tutorials\XtraVerticalGrid\CategoryRowButtons.xml")
            TutorialsInfo.Add("Data Mode", "DevExpress.XtraVerticalGrid.Demos.Tutorials.DataMode", "In this example the data source is represented by the Cars.xml file loaded to the VerticalGrid via the System.Data.DataSet component.", Nothing, "VertGridTutorials\DataMode\DataMode.vb", "Data\Tutorials\XtraVerticalGrid\DataMode.xml")
            TutorialsInfo.Add("Drag And Drop", "DevExpress.XtraVerticalGrid.Demos.Tutorials.DragDrop", "This example demonstrates how to use DragDrop capabilities of the XtraVerticalGrid within the control and when working with any other control.", Nothing, "VertGridTutorials\DragDrop\DragDrop.vb", "Data\Tutorials\XtraVerticalGrid\DragDrop.xml")
            TutorialsInfo.Add("Editors", "DevExpress.XtraVerticalGrid.Demos.Tutorials.Editors", "This example demonstrates how to use various editors (from the XtraEditors Library) within the XtraVerticalGrid (all editors are adjusted at design time).", Nothing, "VertGridTutorials\Editors\Editors.vb", "Data\Tutorials\XtraVerticalGrid\Editors.xml")
            TutorialsInfo.Add("Hit Info", "DevExpress.XtraVerticalGrid.Demos.Tutorials.HitInfo", "This example demonstrates how to obtain information on VerticalGrid elements (such as HitInfoType, Row, CellValue) based on the point coordinates.", Nothing, "VertGridTutorials\HitInfo\HitInfo.vb", "Data\Tutorials\XtraVerticalGrid\HitInfo.xml")
            TutorialsInfo.Add("Layout And Paint Styles", "DevExpress.XtraVerticalGrid.Demos.Tutorials.LayoutAndPaintStyles", "This sample illustrates how to use the XtraVertGrid layout styles.", Nothing, "VertGridTutorials\LayoutAndPaintStyles\LayoutAndPaintStyles.vb", "Data\Tutorials\XtraVerticalGrid\LayoutAndPaintStyles.xml")
            TutorialsInfo.Add("Multi Editors Row", "DevExpress.XtraVerticalGrid.Demos.Tutorials.MultiEditorsRow", "This sample illustrates how to adjust a separator for MultiEditors Rows.", Nothing, "VertGridTutorials\MultiEditorsRow\MultiEditorsRow.vb", "Data\Tutorials\XtraVerticalGrid\MultiEditorsRow.xml")
            TutorialsInfo.Add("Options", "DevExpress.XtraVerticalGrid.Demos.Tutorials.Options", "This example demonstrates how to manage XtraVerticalGrid settings via the View Options and Behaviour Options.", Nothing, "VertGridTutorials\Options\Options.vb", "Data\Tutorials\XtraVerticalGrid\Options.xml")
            TutorialsInfo.Add("Resizing", "DevExpress.XtraVerticalGrid.Demos.Tutorials.Resizing", "This sample shows which behavior options and properties control different element resizing features.", Nothing, "VertGridTutorials\Resizing\Resizing.vb", "Data\Tutorials\XtraVerticalGrid\Resizing.xml")
            TutorialsInfo.Add("Row Alignment", "DevExpress.XtraVerticalGrid.Demos.Tutorials.RowAlignment", "This example demonstrates how to change row cell alignment (via DevExpress.Utils.AppearanceObject).", Nothing, "VertGridTutorials\RowAlignment\RowAlignment.vb", "Data\Tutorials\XtraVerticalGrid\RowAlignment.xml")
            TutorialsInfo.Add("Row Customization", "DevExpress.XtraVerticalGrid.Demos.Tutorials.RowCustomization", "This example demonstrates the capabilities of using the Row Customization Form. You have the ability to customize individual rows and categories. The Customize form contains two tabs - Rows and Categories. You can add new categories using the New... button within the Categories tab.", Nothing, "VertGridTutorials\RowCustomization\RowCustomization.vb", "Data\Tutorials\XtraVerticalGrid\RowCustomization.xml")
            TutorialsInfo.Add("Row Format", "DevExpress.XtraVerticalGrid.Demos.Tutorials.RowFormat", "This example illustrates how to format data within a row.", Nothing, "VertGridTutorials\RowFormat\RowFormat.vb", "Data\Tutorials\XtraVerticalGrid\RowFormat.xml")
            TutorialsInfo.Add("Rows Navigation", "DevExpress.XtraVerticalGrid.Demos.Tutorials.RowsNavigation", "This example demonstrates how to navigate through XtraVerticalGrid rows with the help of existing methods.", Nothing, "VertGridTutorials\RowsNavigation\RowsNavigation.vb", "Data\Tutorials\XtraVerticalGrid\RowsNavigation.xml")
            TutorialsInfo.Add("Scroll Visibility", "DevExpress.XtraVerticalGrid.Demos.Tutorials.ScrollVisibilitySample", "This sample illustrates how to work with the ScrollVisibility property (Note, in Bands or Single View modes, setting ScrollVisibility to Never or Vertical will disable records navigation.  It is best to use a DBNavigator in such an instance to navigate data records).", Nothing, "VertGridTutorials\ScrollVisibility\ScrollVisibility.vb", "Data\Tutorials\XtraVerticalGrid\ScrollVisibility.xml")
            TutorialsInfo.Add("Simple Alpha Blending", "DevExpress.XtraVerticalGrid.Demos.Tutorials.SimpleAlphaBlending", "This example demonstrates how to adjust the Alpha Blending feature of the XtraVerticalGrid using the XtraVertGridBlending component.", Nothing, "VertGridTutorials\SimpleAlphaBlending\SimpleAlphaBlending.vb", "Data\Tutorials\XtraVerticalGrid\SimpleAlphaBlending.xml")
            TutorialsInfo.Add("Simple Mode", "DevExpress.XtraVerticalGrid.Demos.Tutorials.SimpleMode", "In this example the data source is represented by the Contacts class which is inherited from the System.Collections.ArrayList class.", Nothing, "VertGridTutorials\SimpleMode\SimpleModeClass.vb", "Data\Tutorials\XtraVerticalGrid\SimpleMode.xml")
            TutorialsInfo.Add("Style Conditions", "DevExpress.XtraVerticalGrid.Demos.Tutorials.StyleConditions", "This example demonstrates how to use different styles of XtraVerticalGrid cells based on custom conditions (the CustomDrawRowValueCell and CustomDrawRowHeaderCell events are used).", Nothing, "VertGridTutorials\StyleConditions\StyleConditions.vb", "Data\Tutorials\XtraVerticalGrid\StyleConditions.xml")
            TutorialsInfo.Add("Style Formats", "DevExpress.XtraVerticalGrid.Demos.Tutorials.StyleFormats", "This sample illustrates how to customize used styles at runtime with the help of the XStyles class (the DevExpress.XtraVerticalGrid.Styles.xml file contains definitions for used formats).", Nothing, "VertGridTutorials\StyleFormats\StyleFormats.vb", "Data\Tutorials\XtraVerticalGrid\StyleFormats.xml")
            TutorialsInfo.Add("Unbound Mode", "DevExpress.XtraVerticalGrid.Demos.Tutorials.UnboundMode", "This VerticalGrid creates rows at runtime and does not have any data source (unbound mode).", Nothing, "VertGridTutorials\UnboundMode\UnboundMode.vb", "Data\Tutorials\XtraVerticalGrid\UnboundMode.xml")
		End Sub
	End Class
End Namespace
