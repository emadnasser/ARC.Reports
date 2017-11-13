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

Namespace NavBarDemo
 Partial Public Class NavigationPaneOptions
     Inherits NavBarDemoModule

  Public Sub New()
   InitializeComponent()
   calendar.DateTime = Date.Today
  End Sub
  Private Sub ListBox_SelectionChanged(ByVal sender As Object, ByVal e As SelectionChangedEventArgs)
   navBar.HorizontalAlignment = If(Object.Equals(DirectCast(sender, ListBox).SelectedItem, ExpandButtonMode.Normal), HorizontalAlignment.Left, HorizontalAlignment.Right)
  End Sub
 End Class

    Public Class ImageTreeViewItem
        Public Property Header() As String
        Public Property ImageSource() As String
    End Class
End Namespace
