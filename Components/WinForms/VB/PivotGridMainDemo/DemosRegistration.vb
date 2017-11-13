Imports Microsoft.VisualBasic
Imports System
Imports System.Reflection
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.XtraNavBar
Imports DevExpress.DXperience.Demos
Imports DevExpress.XtraBars

Namespace DevExpress.XtraPivotGrid.Demos
	Public Class DemosInfo
		Inherits ModulesInfo
        Public Shared Sub Show(ByVal name As String, ByVal group As DevExpress.XtraEditors.GroupControl, ByVal caption As DevExpress.Utils.Frames.ApplicationCaption, ByVal description As System.Windows.Forms.Control, ByVal manager As PivotGridRibbonMenuManager)
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

                Dim tc As TutorialControl = TryCast(item.TModule, TutorialControl)
                If tc IsNot Nothing Then
                    manager.AllowExport(tc.ExportControl)
                    manager.RefreshOptionsMenu(tc.ViewOptionsControl)
                    tc.Description = description
                Else
                    manager.AllowExport(Nothing)
                    manager.RefreshOptionsMenu(Nothing)
                End If

                tutorial.RibbonMenuManager = manager
                tutorial.TutorialName = name
                tutorial.Caption = caption
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
