Imports Microsoft.VisualBasic
Imports System
Imports System.Windows.Forms
Imports DevExpress.DXperience.Demos

Namespace DevExpress.XtraScheduler.Demos
	Public Class DemosInfo
		Inherits ModulesInfo
		Public Shared Sub DoShowModule(ByVal name As String, ByVal groupControl As DevExpress.XtraEditors.GroupControl, ByVal caption As DevExpress.Utils.Frames.ApplicationCaption, ByVal manager As SchedulerRibbonMenuManager)
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
				tutorial.Bounds = groupControl.DisplayRectangle
				Instance.CurrentModuleBase = item
				tutorial.Visible = False
				groupControl.Controls.Add(tutorial)
				tutorial.Dock = DockStyle.Fill

				Dim tc As TutorialControl = TryCast(item.TModule, TutorialControl)
				If tc IsNot Nothing Then
					Dim printingSchedulerControl As SchedulerControl = tc.PrintingSchedulerControl
					manager.AllowExport(printingSchedulerControl)
					manager.SchedulerControl = printingSchedulerControl
				Else
					manager.AllowExport(Nothing)
				End If

				'-----Set----
				tutorial.RibbonMenuManager = manager
				tutorial.TutorialName = name
				tutorial.Caption = caption
				'------------

				tutorial.Visible = True
				item.WasShown = True
				manager.SchedulerReport = TryCast(tc, IDemoSchedulerReport)

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
