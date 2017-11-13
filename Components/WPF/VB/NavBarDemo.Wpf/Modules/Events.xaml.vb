Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Data
Imports System.Windows.Documents
Imports System.Windows.Input
Imports System.Windows.Media
Imports System.Windows.Media.Imaging
Imports System.Windows.Navigation
Imports System.Windows.Shapes
Imports DevExpress.Xpf.NavBar
Imports DevExpress.Xpf.DemoBase
Imports DevExpress.Xpf.Core.Native
Imports DevExpress.Xpf.Editors

Namespace NavBarDemo
 Partial Public Class Events
     Inherits NavBarDemoModule

  Public Sub New()
   InitializeComponent()
            AddHandler navBar.PreviewMouseDown, AddressOf navBar_MouseDown
            AddHandler navBar.PreviewMouseUp, AddressOf navBar_MouseUp
            AddHandler navBar.MouseMove, AddressOf navBar_MouseMove
            UpdateControlAvailability()
  End Sub
        Public Overrides Sub OnApplyTemplate()
            MyBase.OnApplyTemplate()
            navBarControl = navBar
        End Sub
  Protected Overrides Sub SelectView(ByVal sender As Object, ByVal e As RoutedEventArgs)
   MyBase.SelectView(sender, e)
            UpdateControlAvailability()
  End Sub

        Protected Overrides Function GetExplorerBarView() As ExplorerBarView
            Return CType(FindResource("explorerBar"), ExplorerBarView)
        End Function
        Protected Overrides Function GetNavigationPaneView() As NavigationPaneView
            Return CType(FindResource("navigationPane"), NavigationPaneView)
        End Function
        Protected Overrides Function GetSideBarView() As SideBarView
            Return CType(FindResource("sideBar"), SideBarView)
        End Function

  Private Sub navBar_MouseDown(ByVal sender As Object, ByVal e As RoutedEventArgs)
   Dim group As NavBarGroup = navBar.View.GetNavBarGroup(e)
   Dim item As NavBarItem = navBar.View.GetNavBarItem(e)
   If group IsNot Nothing OrElse item IsNot Nothing Then
    AddToStack("MouseDown: " & (If(item IsNot Nothing, GetItemContent(item), GetGroupHeader(group))), mouseDownCheckbox)
   End If
  End Sub
  Private Sub navBar_MouseMove(ByVal sender As Object, ByVal e As RoutedEventArgs)
   Dim group As NavBarGroup = navBar.View.GetNavBarGroup(e)
   Dim item As NavBarItem = navBar.View.GetNavBarItem(e)
   If group IsNot Nothing OrElse item IsNot Nothing Then
    AddToStack("MouseMove: " & (If(item IsNot Nothing, GetItemContent(item), GetGroupHeader(group))), mouseMoveCheckbox)
   End If
  End Sub
  Private Sub navBar_MouseUp(ByVal sender As Object, ByVal e As RoutedEventArgs)
   Dim group As NavBarGroup = navBar.View.GetNavBarGroup(e)
   Dim item As NavBarItem = navBar.View.GetNavBarItem(e)
   If group IsNot Nothing OrElse item IsNot Nothing Then
    AddToStack("MouseUp: " & (If(item IsNot Nothing, GetItemContent(item), GetGroupHeader(group))), mouseUpCheckbox)
   End If
  End Sub
  Private Sub View_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
   Dim group As NavBarGroup = navBar.View.GetNavBarGroup(e)
   Dim item As NavBarItem = navBar.View.GetNavBarItem(e)
   If group IsNot Nothing OrElse item IsNot Nothing Then
    AddToStack("Click: " & (If(item IsNot Nothing, GetItemContent(item), GetGroupHeader(group))), clickCheckbox)
   End If
  End Sub

  Private Sub Selection_Changing(ByVal sender As Object, ByVal e As NavBarItemSelectingEventArgs)
   AddToStack("ItemSelecting: " & "PrevGroup '" & GetGroupHeader(e.PrevGroup) & "', PrevItem '" & GetItemContent(e.PrevItem) & "'; " & "NewGroup '" & GetGroupHeader(e.NewGroup) & "', NewItem '" & GetItemContent(e.NewItem) & "'", selectionChangingCheckbox)
  End Sub
  Private Sub Selection_Changed(ByVal sender As Object, ByVal e As NavBarItemSelectedEventArgs)
   AddToStack("ItemSelected: Group '" & e.Group.Header.ToString() & "', Item '" & e.Item.Content.ToString() & "'", selectionChangedCheckbox)
  End Sub

        Private Sub UpdateControlAvailability()
            groupExpandedChangedCheckbox.IsEnabled = TypeOf navBar.View Is ExplorerBarView
            groupExpandedChangingCheckbox.IsEnabled = TypeOf navBar.View Is ExplorerBarView

            navPaneExpandedChangedCheckbox.IsEnabled = TypeOf navBar.View Is NavigationPaneView
            navPaneExpandedChangingCheckbox.IsEnabled = TypeOf navBar.View Is NavigationPaneView
        End Sub
  Private Sub View_ActiveGroupChanging(ByVal sender As Object, ByVal e As NavBarActiveGroupChangingEventArgs)
   AddToStack("ActiveGroupChanging: " & "PrevGroup '" & GetGroupHeader(e.PrevGroup) & "'; " & "NewGroup '" & GetGroupHeader(e.NewGroup) & "'", activeGroupChangingCheckbox)
  End Sub
  Private Sub View_ActiveGroupChanged(ByVal sender As Object, ByVal e As NavBarActiveGroupChangedEventArgs)
   AddToStack("ActiveGroupChanged: " & GetGroupHeader(e.Group), activeGroupChangedCheckbox)
  End Sub

  Private Sub view_GroupExpandedChanging(ByVal sender As Object, ByVal e As NavBarGroupExpandedChangingEventArgs)
   AddToStack("GroupExpandedChanging: Group '" & GetGroupHeader(e.Group) & "', IsExpanded=" & e.IsExpanded.ToString(), groupExpandedChangingCheckbox)
  End Sub
  Private Sub view_GroupExpandedChanged(ByVal sender As Object, ByVal e As NavBarGroupExpandedChangedEventArgs)
   AddToStack("GroupExpandedChanged: Group '" & GetGroupHeader(e.Group) & "', IsExpanded=" & e.IsExpanded.ToString(), groupExpandedChangedCheckbox)
  End Sub

  Private Sub navPane_NavPaneExpandedChanging(ByVal sender As Object, ByVal e As NavPaneExpandedChangingEventArgs)
   AddToStack("NavPaneExpandedChanging: IsExpanded=" & e.IsExpanded, navPaneExpandedChangingCheckbox)
  End Sub
  Private Sub navPane_NavPaneExpandingChanged(ByVal sender As Object, ByVal e As NavPaneExpandedChangedEventArgs)
   AddToStack("NavPaneExpandedChanged: IsExpanded=" & e.IsExpanded, navPaneExpandedChangedCheckbox)
  End Sub

  Private Function GetGroupHeader(ByVal group As NavBarGroup) As String
   Return If(group IsNot Nothing, group.Header.ToString(), "null")
  End Function
  Private Function GetItemContent(ByVal item As NavBarItem) As String
   Return If(item IsNot Nothing, item.Content.ToString(), "null")
  End Function

  Private logQueue As New Queue(Of String)()
  Private Const logEntriesCount As Integer = 100

  Private Sub AddToStack(ByVal str As String, ByVal checkEdit As CheckEdit)
            If (Not IsLoaded) OrElse (Not CBool(checkEdit.IsChecked)) Then
                Return
            End If
   logQueue.Enqueue(str)
   If logQueue.Count > logEntriesCount Then
    logQueue.Dequeue()
   End If
   textBox.Text = String.Empty
   Dim builder As New StringBuilder()
   For Each text As String In logQueue
    builder.Append((If(builder.Length <> 0, Environment.NewLine, String.Empty)) & text)
   Next text
   textBox.Text = builder.ToString()
            Dim textBoxCore As TextBox = CType(LayoutHelper.FindElement(textBox, Function(element) (TypeOf element Is TextBox)), TextBox)
            textBoxCore.ScrollToEnd()
  End Sub

  Private Sub Button_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
   logQueue.Clear()
   textBox.Text = String.Empty
  End Sub
 End Class
End Namespace
