Imports Microsoft.VisualBasic
Imports System.Windows.Forms
Imports DevExpress.DXperience.Demos
Imports DevExpress.Utils.Frames
Imports DevExpress.XtraEditors

Namespace DashboardMainDemo
	Public Class DemosInfo
		Inherits ModulesInfo
		Public Shared Sub Show(ByVal name As String, ByVal group As GroupControl, ByVal caption As ApplicationCaption, ByVal manager As RibbonMenuManager)
			Dim item As ModuleInfo = DemosInfo.GetItem(name)
			Dim currentCursor As Cursor = Cursor.Current
			Cursor.Current = Cursors.WaitCursor
			Try
				Dim oldTutorial As Control = Nothing
				If Instance.CurrentModuleBase IsNot Nothing Then
					If Instance.CurrentModuleBase.Name = name Then
						Return
					End If
					Instance.CurrentModuleBase.TModule.Visible = False
				End If
				Dim tutorial As TutorialControlBase = CType(item.TModule, TutorialControlBase)
				tutorial.Bounds = group.DisplayRectangle
				Instance.CurrentModuleBase = item
				tutorial.Visible = False
				group.Controls.Add(tutorial)
				tutorial.Dock = DockStyle.Fill
				tutorial.RibbonMenuManager = manager
				tutorial.TutorialName = name
				tutorial.Caption = caption
				tutorial.Visible = True
				tutorial.BringToFront()
				tutorial.Focus()
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