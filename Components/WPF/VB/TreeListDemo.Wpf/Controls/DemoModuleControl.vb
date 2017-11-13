Imports System
Imports System.Windows
Imports DevExpress.Xpf.Core
Imports DevExpress.Xpf.DemoBase
Imports DevExpress.Xpf.Grid
Imports DevExpress.Utils
Imports DevExpress.Xpf.Printing
Imports DevExpress.Mvvm
Imports System.Windows.Input

Imports DevExpress.Xpf.Core.Native
Imports GridDemo
Imports System.Windows.Media.Imaging

Namespace TreeListDemo
    Public Class TreeListDemoModule
        Inherits DemoModule

        Public Shared ReadOnly TreeListControlProperty As DependencyProperty
        Shared Sub New()
            TreeListControlProperty = DependencyProperty.Register("TreeListControl", GetType(TreeListControl), GetType(TreeListDemoModule), New PropertyMetadata(Nothing))
        End Sub
        Public Sub New()
            ThemeManager.AddThemeChangedHandler(Me, AddressOf ThemeNameChanged)
        End Sub

        Private Sub ThemeNameChanged(ByVal sender As DependencyObject, ByVal e As ThemeChangedRoutedEventArgs)
        End Sub
        Protected Overrides Sub Clear()
            MyBase.Clear()
            ThemeManager.RemoveThemeChangedHandler(Me, AddressOf ThemeNameChanged)
        End Sub
        Public Property TreeListControl() As TreeListControl
            Get
                Return CType(GetValue(TreeListControlProperty), TreeListControl)
            End Get
            Set(ByVal value As TreeListControl)
                SetValue(TreeListControlProperty, value)
            End Set
        End Property
        Protected Overrides Function GetModuleDataContext() As Object
            If TreeListControl Is Nothing Then
                TreeListControl = FindTreeList()
                If TreeListControl IsNot Nothing Then
                    TreeListControl.ShowBorder = ShowBorder
                End If
            End If
            Return TreeListControl
        End Function
        Protected Overridable ReadOnly Property ShowBorder() As Boolean
            Get
                Return False
            End Get
        End Property
        Protected Overridable Function FindTreeList() As TreeListControl
            Return CType(DemoModuleControl.FindDemoContent(GetType(TreeListControl), CType(DemoModuleControl.Content, DependencyObject)), TreeListControl)
        End Function
        Public NotOverridable Overrides Function SupportSidebarContent() As Boolean
            Return True
        End Function
        Protected Overridable ReadOnly Property AllowDataAwareExport() As Boolean
            Get
                Return True
            End Get
        End Property
        Protected Overridable ReadOnly Property AllowWYSIWYGExport() As Boolean
            Get
                Return True
            End Get
        End Property
        Public NotOverridable Overrides Function IsSidebarButtonEnabled() As Boolean
            Return GetExportView() IsNot Nothing
        End Function
        Protected Overridable Function GetExportView() As TreeListView
            Dim treeList = FindTreeList()
            If treeList IsNot Nothing Then
                Return treeList.View
            End If
            Return Nothing
        End Function
        Public Overrides Function GetSidebarContent() As Object
            Return New DemoModuleExportControl(GetExportView(), AllowDataAwareExport, AllowWYSIWYGExport, False)
        End Function
        Public Overrides Function GetSidebarIcon() As System.Windows.Media.ImageSource
            Return New BitmapImage(New Uri("/TreeListDemo;component/Images/PrintIcon.png", UriKind.Relative))
        End Function
        Public Overrides Function GetSidebarIconSelected() As System.Windows.Media.ImageSource
            Return New BitmapImage(New Uri("/TreeListDemo;component/Images/PrintIconSelected.png", UriKind.Relative))
        End Function
        Public Overrides Function GetSidebarTag() As String
            Return "Export"
        End Function
    End Class

    Public Class PrintTreeListDemoModule
        Inherits TreeListDemoModule

        Private dxTabControlCore As DXTabControl
        Public Sub New()
            ShowPrintPreview = New DelegateCommand(Of Object)(Sub(p) OnShowPrintPreview(CStr(p)))
            ShowPrintPreviewInNewTab = New DelegateCommand(Of Object)(Sub(p) OnShowPrintPreviewInNewTab(CStr(p)))
        End Sub
        Private privateShowPrintPreview As ICommand
        Public Property ShowPrintPreview() As ICommand
            Get
                Return privateShowPrintPreview
            End Get
            Private Set(ByVal value As ICommand)
                privateShowPrintPreview = value
            End Set
        End Property
        Private privateShowPrintPreviewInNewTab As ICommand
        Public Property ShowPrintPreviewInNewTab() As ICommand
            Get
                Return privateShowPrintPreviewInNewTab
            End Get
            Private Set(ByVal value As ICommand)
                privateShowPrintPreviewInNewTab = value
            End Set
        End Property
        Public Property DXTabControl() As DXTabControl
            Get
                Return dxTabControlCore
            End Get
            Set(ByVal value As DXTabControl)
                If DXTabControl Is value Then
                    Return
                End If
                If DXTabControl IsNot Nothing Then
                    RemoveHandler DXTabControl.TabHidden, AddressOf OnTabHidden
                End If
                dxTabControlCore = value
                If DXTabControl IsNot Nothing Then
                    AddHandler DXTabControl.TabHidden, AddressOf OnTabHidden
                End If
            End Set
        End Property
        Protected ReadOnly Property View() As TreeListView
            Get
                Return TreeListControl.View
            End Get
        End Property
        Protected Overrides Function FindTreeList() As TreeListControl
            If DXTabControl Is Nothing Then
                Return Nothing
            End If
            Return CType(CType(DXTabControl.Items(0), DXTabItem).Content, TreeListControl)
        End Function
        Protected Overridable Sub OnShowPrintPreview(ByVal documentName As String)
            PrintHelper.ShowPrintPreviewDialog(LayoutHelper.FindParentObject(Of Window)(Me), DirectCast(TreeListControl.View, IPrintableControl), documentName)
        End Sub
        Protected Overridable Sub OnShowPrintPreviewInNewTab(ByVal documentName As String)
            Dim link As New PrintableControlLink(DirectCast(TreeListControl.View, IPrintableControl))
            Dim preview As New DocumentPreviewControl() With {.DocumentSource = link}
            Dim tabItem As DXTabItem = CreateTabItem(preview, documentName)
            tabItem.Tag = link
            DXTabControl.Items.Add(tabItem)
            DXTabControl.SelectedItem = tabItem
            link.CreateDocument(True)
        End Sub
        Protected Overridable Function CreateTabItem(ByVal preview As DocumentPreviewControl, ByVal documentName As String) As DXTabItem
            Return New DXTabItem() With {.AllowHide = DefaultBoolean.True, .Content = preview, .Header = documentName}
        End Function
        Protected Sub RemoveTab(ByVal tabItem As DXTabItem)
            If tabItem.Tag IsNot Nothing Then
                CType(tabItem.Tag, PrintableControlLink).Dispose()
            End If
            tabItem.Content = Nothing
            DXTabControl.Items.Remove(tabItem)
        End Sub
        Protected Overrides Sub Clear()
            MyBase.Clear()
            For i As Integer = DXTabControl.Items.Count - 1 To 0 Step -1
                RemoveTab(CType(DXTabControl.Items(i), DXTabItem))
            Next i
            DXTabControl = Nothing
        End Sub
        Private Sub OnTabHidden(ByVal sender As Object, ByVal e As TabControlTabHiddenEventArgs)
            RemoveTab(CType(DXTabControl.Items(e.TabIndex), DXTabItem))
        End Sub
    End Class
End Namespace
