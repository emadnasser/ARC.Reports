Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Windows
Imports DevExpress.Xpf.Core.Native
Imports DevExpress.Xpf.DemoBase
Imports DevExpress.Xpf.Docking

Namespace DockingDemo
    Public Class DockingDemoModule
        Inherits DemoModule

        Protected Overrides Function CanLeave() As Boolean
            Dim containerList = DevExpress.Mvvm.UI.LayoutTreeHelper.GetVisualChildren(Me).OfType(Of DockLayoutManager)()
            For Each contianer In containerList
                HideFloatGroups(contianer)
            Next contianer
            Return True
        End Function
        Private DisposeList As List(Of DockLayoutManager)
        Protected Overrides Sub RaiseBeforeModuleDisappear()
            MyBase.RaiseBeforeModuleDisappear()
            DisposeList = New List(Of DockLayoutManager)()
            Dim e As New VisualTreeEnumerator(Me)
            Do While e.MoveNext()
                Dim manager As DockLayoutManager = TryCast(e.Current, DockLayoutManager)
                If manager IsNot Nothing Then
                    DisposeList.Add(manager)
                    manager.Visibility = Visibility.Collapsed
                    For Each fGroup As FloatGroup In manager.FloatGroups
                        fGroup.IsOpen = False
                    Next fGroup
                End If
            Loop
        End Sub
        Protected Overrides Sub RaiseAfterModuleDisappear()
            MyBase.RaiseAfterModuleDisappear()
            If DisposeList IsNot Nothing Then
                For Each manager As DockLayoutManager In DisposeList
                    manager.Dispose()
                Next manager
                DisposeList.Clear()
                DisposeList = Nothing
            End If
        End Sub
        Protected Sub NavigateHomePage()
            System.Diagnostics.Process.Start("http://www.devexpress.com")
        End Sub
        Protected Sub ShowAbout()
        End Sub

        Private container_Renamed As DockLayoutManager
        Protected Overridable ReadOnly Property Container() As DockLayoutManager
            Get
                If container_Renamed Is Nothing Then
                    container_Renamed = FindDockLayoutManager()
                End If
                Return container_Renamed
            End Get
        End Property
        Public Function FindDockLayoutManager() As DockLayoutManager
            Dim e As New VisualTreeEnumerator(Me)
            Do While e.MoveNext()
                Dim manager As DockLayoutManager = TryCast(e.Current, DockLayoutManager)
                If manager IsNot Nothing Then
                    Return manager
                End If
            Loop
            Return Nothing
        End Function
        Protected Overrides Function GetModuleDataContext() As Object
            Return DataContext
        End Function
        Protected Overrides Sub RaiseIsPopupContentInvisibleChanged(ByVal e As DependencyPropertyChangedEventArgs)
            MyBase.RaiseIsPopupContentInvisibleChanged(e)
            OnIsPopupContentInvisibleChanged(DirectCast(e.NewValue, Boolean))
        End Sub
        Private Sub OnIsPopupContentInvisibleChanged(ByVal isInvisible As Boolean)
            Dim containerList = DevExpress.Mvvm.UI.LayoutTreeHelper.GetVisualChildren(Me).OfType(Of DockLayoutManager)()
            For Each contianer In containerList
                If isInvisible Then
                    HideFloatGroups(contianer)
                Else
                    ShowFloatGroups(contianer)
                End If
            Next contianer
        End Sub
        Private Sub ShowFloatGroups(ByVal dockLayoutManager As DockLayoutManager)
            If Not dockLayoutManager.IsVisible Then
                Return
            End If
            For Each floatGroup As FloatGroup In dockLayoutManager.FloatGroups
                If floatGroup.ShouldRestoreOnActivate Then
                    floatGroup.ShouldRestoreOnActivate = False
                    If Not floatGroup.IsOpen Then
                        floatGroup.IsOpen = True
                    End If
                End If
            Next floatGroup
        End Sub
        Private Sub HideFloatGroups(ByVal dockLayoutManager As DockLayoutManager)
            For Each floatGroup As FloatGroup In dockLayoutManager.FloatGroups
                If floatGroup.IsOpen Then
                    floatGroup.ShouldRestoreOnActivate = True
                    If floatGroup.IsOpen Then
                        floatGroup.IsOpen = False
                    End If
                End If
            Next floatGroup
        End Sub
    End Class
End Namespace
