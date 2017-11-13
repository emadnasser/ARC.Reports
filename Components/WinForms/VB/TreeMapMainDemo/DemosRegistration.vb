Imports Microsoft.VisualBasic
Imports System
Imports System.Reflection
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.DXperience.Demos
Imports DevExpress.XtraEditors
Imports DevExpress.Utils.Frames

Namespace DevExpress.XtraTreeMap.Demos
	Public Class DemosInfo
		Inherits ModulesInfo
		Public Shared Sub DoShowModule(ByVal name As String, ByVal group As GroupControl, ByVal caption As ApplicationCaption, ByVal manager As RibbonMenuManager)
			Dim item As ModuleInfo = DemosInfo.GetItem(name)
			Dim currentCursor As Cursor = Cursor.Current
			Cursor.Current = Cursors.WaitCursor
			Try
				Dim oldTutorial As Control = Nothing
				If Instance.CurrentModuleBase IsNot Nothing Then
					If Instance.CurrentModuleBase.Name = name Then
						Return
					End If
					oldTutorial = Instance.CurrentModuleBase.TModule
				End If
				Instance.CurrentModuleBase = item
				Dim tutorialBase As TutorialControlBase = TryCast(item.TModule, TutorialControlBase)
				tutorialBase.Bounds = group.DisplayRectangle
				tutorialBase.Visible = False
				group.Controls.Add(tutorialBase)
				tutorialBase.Dock = DockStyle.Fill
				tutorialBase.RibbonMenuManager = manager
				tutorialBase.TutorialName = name
				tutorialBase.Caption = caption
				tutorialBase.Visible = True
				item.WasShown = True
				If oldTutorial IsNot Nothing Then
					oldTutorial.Visible = False
				End If
			Catch
			Finally
				Cursor.Current = currentCursor
			End Try
			RaiseModuleChanged()
		End Sub
	End Class
End Namespace
