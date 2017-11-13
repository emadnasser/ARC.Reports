Imports System.Reflection
Imports System.Collections
Imports System.ComponentModel
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Blending
Imports DevExpress.XtraNavBar
Imports DevExpress.DXperience.Demos

Namespace DevExpress.XtraGrid.Demos
	Public Class DemosInfo
		Inherits ModulesInfo

		Private Shared Function GetBaseViewByControl(ByVal control As Control) As BaseView
			If control Is Nothing Then
				Return Nothing
			End If
			For Each cntl As Control In control.Controls
				If TypeOf cntl Is GridControl Then
					Return CType(cntl, GridControl).MainView
				End If
			Next cntl
			Return Nothing
		End Function

		Private Shared Sub CloseCustomizationForm(ByVal control As Control)
			If control Is Nothing Then
				Return
			End If
			For Each ctrl As Control In control.Controls
				CloseCustomizationForm(ctrl)
			Next ctrl
			Dim view As BaseView = GetBaseViewByControl(control)
			If view Is Nothing Then
				Return
			End If
			For Each bView As BaseView In view.GridControl.Views
				If TypeOf bView Is GridView Then
					CType(bView, GridView).DestroyCustomization()
				End If
			Next bView
		End Sub

        Public Overloads Shared Sub ShowModule(ByVal name As String, ByVal group As DevExpress.XtraEditors.GroupControl, ByVal caption As DevExpress.Utils.Frames.ApplicationCaption, ByVal manager As GridRibbonMenuManager)
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
                CloseCustomizationForm(oldTutorial)
                If tc IsNot Nothing Then
                    manager.AllowExport(tc.ExportView)
                    manager.RefreshOptionsMenu(If(tc.ShowViewOptions, GetBaseViewByControl(tutorial), Nothing))
                Else
                    manager.AllowExport(Nothing)
                    manager.RefreshOptionsMenu(Nothing)
                End If
                manager.InitBlendingMenu(Nothing)
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
