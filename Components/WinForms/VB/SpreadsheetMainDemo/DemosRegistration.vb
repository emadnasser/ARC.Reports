Imports Microsoft.VisualBasic
Imports System
Imports System.Windows.Forms
Imports DevExpress.DXperience.Demos

Namespace DevExpress.XtraSpreadsheet.Demos
	Public Class DemosInfo
		Inherits ModulesInfo
		Public Shared Sub DoShowModule(ByVal name As String, ByVal groupControl As DevExpress.XtraEditors.GroupControl, ByVal caption As DevExpress.Utils.Frames.ApplicationCaption, ByVal manager As SpreadsheetRibbonMenuManager)
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

				'TutorialControl tc = item.TModule as TutorialControl;
				'if(tc != null) {
				'    manager.AllowExport(tc..PrintingRichEditControl);
				'}
				'else {
				'    manager.AllowExport(null);
				'}

				'-----Set----
				tutorial.RibbonMenuManager = manager
				tutorial.TutorialName = name
				tutorial.Caption = caption
				'------------

				tutorial.Visible = True
				item.WasShown = True
				'manager.RichEditControl = tutorial.PrintingRichEditControl;
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
