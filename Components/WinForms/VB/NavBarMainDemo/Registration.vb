Imports System.Reflection
Imports System.Collections
Imports System.ComponentModel
Imports DevExpress.DXperience.Demos
Imports DevExpress.XtraBars

Namespace DevExpress.XtraNavBar.Demos
	Public Class TutorialsInfo
		Inherits DevExpress.DXperience.Demos.ModulesInfo
		Private Const languageDir As String = "CS\"
		Private Shared Sub SetBarManager(ByVal ctrl As Control, ByVal manager As BarManager)
			For Each element As Control In ctrl.Controls
				Dim nc As NavBarControl = TryCast(element, NavBarControl)
				If nc IsNot Nothing Then
					nc.MenuManager = manager
				End If
				SetBarManager(element, manager)
			Next element
		End Sub
		Public Shared Overloads Function ShowModule(ByVal name As String, ByVal group As DevExpress.XtraEditors.GroupControl, ByVal menu As DevExpress.DXperience.Demos.LookAndFeelMenu, ByVal lookAndFeel As DevExpress.LookAndFeel.DefaultLookAndFeel) As DevExpress.Tutorials.ModuleBase
			Dim item As ModuleInfo = TutorialsInfo.GetItem(name)
			Dim currentCursor As Cursor = Cursor.Current
			Cursor.Current = Cursors.WaitCursor
			group.Parent.SuspendLayout()
			group.SuspendLayout()
			Try
				Dim oldTutorial As Control = Nothing
				If Instance.CurrentModuleBase IsNot Nothing Then
					oldTutorial = Instance.CurrentModuleBase.TModule
				End If

				Dim tutorial As TutorialControl = TryCast(item.TModule, TutorialControl)
				tutorial.Bounds = group.DisplayRectangle
				Instance.CurrentModuleBase = item
				tutorial.Visible = False
				group.Controls.Add(tutorial)
				tutorial.Dock = DockStyle.Fill
				SetBarManager(tutorial, menu.MainMenu.Manager)
				tutorial.Visible = True
				If oldTutorial IsNot Nothing Then
					oldTutorial.Visible = False
				End If
			Finally
				group.ResumeLayout(True)
				group.Parent.ResumeLayout(True)
				Cursor.Current = currentCursor
			End Try
			RaiseModuleChanged()
			Dim [module] As DevExpress.Tutorials.ModuleBase = TryCast(Instance.CurrentModuleBase.TModule, DevExpress.Tutorials.ModuleBase)
			If [module] IsNot Nothing Then
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

End Namespace
