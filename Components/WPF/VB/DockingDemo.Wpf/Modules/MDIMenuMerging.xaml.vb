Imports DevExpress.Xpf.Bars
Imports DevExpress.Xpf.Docking

Namespace DockingDemo
    Partial Public Class MDIMenuMerging
        Inherits DockingDemoModule

        Public Sub New()
            InitializeComponent()
            AddHandler dockManager.Merge, AddressOf dockManager_Merge
            AddHandler dockManager.UnMerge, AddressOf dockManager_UnMerge
            dockManager.ActiveMDIItem = mdiContainer
        End Sub
        Private Sub dockManager_Merge(ByVal sender As Object, ByVal e As BarMergeEventArgs)
            Dim childBar As Bar = e.ChildBarManager.Bars("childBar")
            Dim commonBar As Bar = e.BarManager.Bars("Common")
            If commonBar IsNot Nothing Then
                commonBar.Merge(childBar)
            End If
        End Sub
        Private Sub dockManager_UnMerge(ByVal sender As Object, ByVal e As BarMergeEventArgs)
            Dim commonBar As Bar = e.BarManager.Bars("Common")
            If commonBar IsNot Nothing Then
                commonBar.UnMerge()
            End If
        End Sub
    End Class
End Namespace
