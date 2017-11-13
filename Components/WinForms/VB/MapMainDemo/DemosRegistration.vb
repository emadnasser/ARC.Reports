Imports Microsoft.VisualBasic
Imports System
Imports System.Windows.Forms
Imports DevExpress.DXperience.Demos
Imports System.Reflection
Imports DevExpress.XtraMap.Native

Namespace DevExpress.XtraMap.Demos
	Public Class DemosInfo
		Inherits ModulesInfo
		Private Shared Sub UpdateModuleInfo(ByVal item As ModuleInfo)
			item.RecreateModuleIfNecessary(System.Reflection.Assembly.GetCallingAssembly())
		End Sub
		Public Shared Sub DoShowModule(ByVal name As String, ByVal groupControl As DevExpress.XtraEditors.GroupControl, ByVal caption As DevExpress.Utils.Frames.ApplicationCaption, ByVal manager As MapRibbonMenuManager)
			Dim currentCursor As Cursor = Cursor.Current
			Try
				Dim item As ModuleInfo = DemosInfo.GetItem(name)
				Dim tutorial As TutorialControlBase = CType(item.TModule, TutorialControlBase)
				Cursor.Current = Cursors.WaitCursor
				If Instance.CurrentModuleBase IsNot Nothing Then
					If Instance.CurrentModuleBase.Name = name Then
						Return
					End If
					Dim oldTutorial As TutorialControlBase = MapModulesPool.GetPreviousModule()
					If oldTutorial Is Nothing Then
						oldTutorial = CType(Instance.CurrentModuleBase.TModule, TutorialControlBase)
					End If
					If oldTutorial IsNot Nothing Then
						oldTutorial.Visible = False
						Dim mapTutorialControl As MapTutorialControl = TryCast(oldTutorial, MapTutorialControl)
						If mapTutorialControl IsNot Nothing Then
							MapUtils.ReleaseMapHandle(mapTutorialControl.MapControl)
						End If
					End If
				End If
				tutorial.Bounds = groupControl.DisplayRectangle
				Instance.CurrentModuleBase = item
				tutorial.Visible = False
				groupControl.Controls.Add(tutorial)
				tutorial.Dock = DockStyle.Fill
				Dim tc As MapTutorialControl = TryCast(tutorial, MapTutorialControl)
				If tc IsNot Nothing Then
					MapModulesPool.RegisterModule(tc)
					UpdateModuleInfo(item)
					tc.AppendOverlays()
				End If
				manager.AllowExport(If(tc IsNot Nothing, tc.MapControl, Nothing))

				'-----Set----
				tutorial.RibbonMenuManager = manager
				tutorial.TutorialName = name
				tutorial.Caption = caption
				'------------

				tutorial.Visible = True
				item.WasShown = True
				'manager.RichEditControl = tutorial.PrintingRichEditControl;
			Finally
				Cursor.Current = currentCursor
			End Try
			RaiseModuleChanged()
		End Sub
	End Class
End Namespace
