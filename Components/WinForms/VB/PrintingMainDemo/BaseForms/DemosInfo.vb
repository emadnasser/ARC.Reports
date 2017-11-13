Imports System
Imports System.Reflection
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.XtraNavBar
Imports DevExpress.DXperience.Demos
Imports DevExpress.XtraBars
Imports DevExpress.LookAndFeel

Namespace XtraPrintingDemos
    Public Class DemosInfo
        Inherits ModulesInfo

        Public Shared Sub ActivateModule(ByVal name As String, ByVal caption As DevExpress.Utils.Frames.ApplicationCaption, ByVal callBack As Action(Of Control))
            If Instance.CurrentModuleBase IsNot Nothing AndAlso Instance.CurrentModuleBase.Name = name Then
                Return
            End If

            Dim item As ModuleInfo = DemosInfo.GetItem(name)
            Dim currentCursor As Cursor = Cursor.Current
            Cursor.Current = Cursors.WaitCursor
            Try
                If Instance.CurrentModuleBase IsNot Nothing Then
                    Instance.CurrentModuleBase.TModule.Visible = False
                End If

                Dim tutorial As TutorialControlBase = TryCast(item.TModule, TutorialControlBase)
                tutorial.TutorialName = name
                tutorial.Caption = caption
                Instance.CurrentModuleBase = item
                callBack(tutorial)

                If (Not item.WasShown) AndAlso Not(TypeOf tutorial Is MainFeaturesControl) Then
                    item.WasShown = True
                End If
            Finally
                Cursor.Current = currentCursor
            End Try
            RaiseModuleChanged()
        End Sub
    End Class
End Namespace

