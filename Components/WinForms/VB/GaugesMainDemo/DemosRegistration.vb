Imports System.Windows.Forms
Imports DevExpress.DXperience.Demos
Imports DevExpress.Utils.Frames
Imports DevExpress.XtraEditors

Namespace DevExpress.XtraGauges.Demos
    Public Class DemosInfo
        Inherits ModulesInfo
        Public Overloads Shared Sub ShowModule(ByVal name As String, ByVal group As GroupControl, ByVal caption As ApplicationCaption, ByVal manager As RibbonMenuManager)
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

                tutorial.RibbonMenuManager = manager
                tutorial.TutorialName = name
                tutorial.Caption = caption

                Dim gaugeTutorial As TutorialControl = TryCast(item.TModule, TutorialControl)
                If gaugeTutorial IsNot Nothing Then
                    If gaugeTutorial.ShowExportMenu Then
                        manager.AllowExport(gaugeTutorial.ExportControl)
                    Else
                        manager.AllowExport(Nothing)
                    End If
                End If
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
