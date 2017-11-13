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
Imports System.Collections

Namespace NavBarDemo
 Partial Public Class GroupsAndItems
     Inherits NavBarDemoModule

  Private images As ArrayList
        Private newItem As NavBarItem = Nothing
  Public Sub New()
   InitializeComponent()
   images = CType(FindResource("Images"), ArrayList)
  End Sub

        Private Sub Add_Item(ByVal sender As Object, ByVal e As RoutedEventArgs)
   Dim group As NavBarGroup = CType(navBar.ActiveGroup, NavBarGroup)
            If newItem IsNot Nothing Then
                newItem.IsEnabled = True
                newItem = Nothing
                AddPreviewItem()
                Return
            End If
   group.Items.Add(New NavBarItem() With {.Content = "Item " & (group.Items.Count + 1).ToString(), .ImageSource=DirectCast(images(newItemImageList.SelectedIndex), Image).Source})
        End Sub
  Private Sub Add_Group(ByVal sender As Object, ByVal e As RoutedEventArgs)
   Dim group As New NavBarGroup() With {.Header = "Group " & (navBar.Groups.Count + 1).ToString(), .ImageSource = DirectCast(images(newItemImageList.SelectedIndex), Image).Source}
   If newGroupImageStyleList.SelectedItem.ToString() = "Large Images" Then
                group.ItemLayoutSettings = New LayoutSettings With {.ImageHorizontalAlignment = System.Windows.HorizontalAlignment.Center, .TextHorizontalAlignment = System.Windows.HorizontalAlignment.Center, .ImageDocking = Dock.Top}
                group.ItemImageSettings = New ImageSettings With {.Height = 32, .Width = 32}
   Else
                group.ItemImageSettings = New ImageSettings With {.Height = 16, .Width = 16}
   End If
   navBar.Groups.Add(group)
  End Sub
  Private Sub Delete_Group(ByVal sender As Object, ByVal e As RoutedEventArgs)
   If navBar.Groups.Count <> 0 Then
       navBar.Groups.RemoveAt(navBar.Groups.Count - 1)
   End If
  End Sub
  Private Sub Delete_Item(ByVal sender As Object, ByVal e As RoutedEventArgs)
   Dim group As NavBarGroup = CType(navBar.ActiveGroup, NavBarGroup)
   group.Items.Remove(group.SelectedItem)
  End Sub

        Private Sub Add_MouseEnter(ByVal sender As Object, ByVal e As MouseEventArgs)
            AddPreviewItem()
        End Sub

        Private Sub AddPreviewItem()
            Dim group As NavBarGroup = CType(navBar.ActiveGroup, NavBarGroup)
            If group Is Nothing Then
                Return
            End If
            newItem = New NavBarItem() With {.Content = "Item " & (group.Items.Count + 1).ToString(), .ImageSource = DirectCast(images(newItemImageList.SelectedIndex), Image).Source, .IsEnabled = False}
            group.Items.Add(newItem)
        End Sub
        Private Sub Add_MouseLeave(ByVal sender As Object, ByVal e As MouseEventArgs)
            Dim group As NavBarGroup = CType(navBar.ActiveGroup, NavBarGroup)
            If group Is Nothing OrElse newItem Is Nothing Then
                Return
            End If
            group.Items.Remove(newItem)
        End Sub

 End Class
End Namespace
