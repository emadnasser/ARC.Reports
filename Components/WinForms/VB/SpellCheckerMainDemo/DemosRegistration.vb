Imports Microsoft.VisualBasic
Imports System
Imports System.Windows.Forms
Imports DevExpress.DXperience.Demos

Namespace DevExpress.XtraSpellChecker.Demos
	Public Class DemosInfo
		Inherits ModulesInfo
		Public Shared Overloads Sub ShowModule(ByVal name As String, ByVal group As DevExpress.XtraEditors.GroupControl, ByVal caption As DevExpress.Utils.Frames.ApplicationCaption, ByVal manager As SpellCheckerRibbonMenuManager)
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

				Dim tutorial As TutorialControlBase = TryCast(item.TModule, TutorialControlBase)
				tutorial.Bounds = group.DisplayRectangle
				Instance.CurrentModuleBase = item
				tutorial.Visible = False
				group.Controls.Add(tutorial)
				tutorial.Dock = DockStyle.Fill

				manager.AllowExport(Nothing)

				'-----Set----
				tutorial.RibbonMenuManager = manager
				tutorial.TutorialName = name
				tutorial.Caption = caption
				'------------

				tutorial.Visible = True
				item.WasShown = True
				If oldTutorial IsNot Nothing Then
					oldTutorial.Visible = False
				End If
			Finally
				Cursor.Current = currentCursor
			End Try
			RaiseModuleChanged()
		End Sub
	End Class
End Namespace