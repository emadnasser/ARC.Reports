Imports System
Imports System.Globalization
Imports System.Windows
Imports System.Windows.Data
Imports DevExpress.Xpf.NavBar
Imports DevExpress.Xpf.Editors

Namespace NavBarDemo
 Partial Public Class ScrollingOptions
     Inherits NavBarDemoModule

  Shared Sub New()
  End Sub
  Public Sub New()
   InitializeComponent()

   GenerateContent(8, 10)
  End Sub

  Private Sub GenerateContent(ByVal groupsCount As Integer, ByVal itemsCount As Integer)
   navBar.Groups.Clear()
   For i As Integer = 0 To groupsCount - 1
    Dim group As New NavBarGroup()
    group.Header = "Group " & (i + 1).ToString()
    For j As Integer = 0 To itemsCount - 1
     Dim item As New NavBarItem()
     item.Content = "Item " & (j + 1).ToString()
     group.Items.Add(item)
    Next j
    navBar.Groups.Add(group)
   Next i
  End Sub
  Protected Overrides Function GetExplorerBarView() As ExplorerBarView
   GenerateContent(8, 10)
   Return MyBase.GetExplorerBarView()
  End Function
  Protected Overrides Function GetNavigationPaneView() As NavigationPaneView
   GenerateContent(5, 30)
   Return MyBase.GetNavigationPaneView()
  End Function
  Protected Overrides Function GetSideBarView() As SideBarView
   GenerateContent(5, 30)
   Return MyBase.GetSideBarView()
  End Function
        Protected Overrides Sub SelectView(ByVal sender As Object, ByVal e As RoutedEventArgs)
            MyBase.SelectView(sender, e)
            lbScrollMode.SelectedIndex = 0
        End Sub
        Private Sub lbScrollMode_SelectedIndexChanged(ByVal sender As Object, ByVal e As RoutedEventArgs)
            Dim lbScrollMode As ListBoxEdit = DirectCast(sender, ListBoxEdit)
            Dim scrollMode As ScrollMode = CType(CType(lbScrollMode.SelectedItem, ListBoxEditItem).Content, ScrollMode)
            ScrollingSettings.SetScrollMode(navBar.View, scrollMode)
        End Sub
 End Class
    Public Class ScrollModeToVisibilityConverter
        Implements IValueConverter

        #Region "IValueConverter Members"
        Public Function Convert(ByVal value As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal culture As CultureInfo) As Object Implements IValueConverter.Convert
            Return If((DirectCast(value, ScrollMode)) = ScrollMode.Buttons, Visibility.Visible, Visibility.Collapsed)
        End Function
        Public Function ConvertBack(ByVal value As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal culture As CultureInfo) As Object Implements IValueConverter.ConvertBack
            Throw New NotImplementedException()
        End Function
        #End Region
    End Class
    Public Class ViewToEnabledConverter
        Implements IValueConverter

        Public Function Convert(ByVal value As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal culture As CultureInfo) As Object Implements IValueConverter.Convert
            Return Not(TypeOf value Is ExplorerBarView)
        End Function
        Public Function ConvertBack(ByVal value As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal culture As CultureInfo) As Object Implements IValueConverter.ConvertBack
            Throw New NotImplementedException()
        End Function
    End Class
End Namespace
