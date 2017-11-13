Imports System
Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Controls.Primitives
Imports DevExpress.Utils
Imports DevExpress.Xpf.Core
Imports DevExpress.Xpf.DemoBase
Imports DevExpress.Xpf.Grid
Imports DevExpress.Xpf.Printing
Imports DevExpress.Xpf.Utils.Themes
Imports DevExpress.Xpf.Editors
Imports DevExpress.Xpf.Core.Native
Imports System.Windows.Media.Imaging
Imports System.Windows.Input
Imports DevExpress.XtraExport.Helpers
Imports DevExpress.Xpf.Grid.Printing

Namespace GridDemo
    Public Class GridDemoModule
        Inherits DemoModule

        Public Shared ReadOnly GridControlProperty As DependencyProperty

        Shared Sub New()
            GridControlProperty = DependencyProperty.Register("GridControl", GetType(GridControl), GetType(GridDemoModule), New PropertyMetadata(Nothing))
        End Sub

        Private privateSetItemsSourceCommand As ICommand
        Public Property SetItemsSourceCommand() As ICommand
            Get
                Return privateSetItemsSourceCommand
            End Get
            Private Set(ByVal value As ICommand)
                privateSetItemsSourceCommand = value
            End Set
        End Property

        Public Sub New()
            SetItemsSourceCommand = DevExpress.Mvvm.Native.DelegateCommandFactory.Create(Of Object)(New Action(Of Object)(Sub(parameter) SetItemsSource(parameter)), New Func(Of Object, Boolean)(Function(parameter) GridControl IsNot Nothing), False)
        End Sub
        Private Sub SetItemsSource(ByVal source As Object)
            GridControl.ItemsSource = source
        End Sub

        Protected Overridable ReadOnly Property IsGridBorderVisible() As Boolean
            Get
                Return False
            End Get
        End Property
        Public Property UseGridControlWrapperAsDataContext() As Boolean
        Public Property GridControl() As GridControl
            Get
                Return CType(GetValue(GridControlProperty), GridControl)
            End Get
            Set(ByVal value As GridControl)
                SetValue(GridControlProperty, value)
            End Set
        End Property
        Public Overrides Sub OnApplyTemplate()
            MyBase.OnApplyTemplate()
            If GridControl Is Nothing Then
                GridControl = FindGrid()
                If GridControl IsNot Nothing Then
                    GridControl.ShowBorder = IsGridBorderVisible
                End If
            End If
        End Sub
        Protected Overrides Function GetModuleDataContext() As Object
            If UseGridControlWrapperAsDataContext Then
                Return New GridControlWrapper(GridControl)
            End If
            Return GridControl
        End Function
        Public Overridable Function FindGrid() As GridControl
            Return CType(DemoModuleControl.FindDemoContent(GetType(GridControl), CType(DemoModuleControl.Content, DependencyObject)), GridControl)
        End Function
        Protected Overrides Sub RaiseIsPopupContentInvisibleChanged(ByVal e As DependencyPropertyChangedEventArgs)
            MyBase.RaiseIsPopupContentInvisibleChanged(e)
            If IsPopupContentInvisible AndAlso GridControl IsNot Nothing Then
                GridControl.View.HideColumnChooser()
            End If
        End Sub
        Protected Overrides Function CanLeave() As Boolean
            If GridControl Is Nothing Then
                Return True
            End If
            GridControl.View.CommitEditing()
            Return True
        End Function
        #Region "Printing And Exporting"

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

        Public NotOverridable Overrides Function SupportSidebarContent() As Boolean
            Return True
        End Function
        Public NotOverridable Overrides Function SupportSidebar2Content() As Boolean
            Return True
        End Function
        Public NotOverridable Overrides Function IsSidebarButtonEnabled() As Boolean
            Return GetExportView() IsNot Nothing
        End Function
        Protected Overridable Function GetExportView() As DataViewBase
            Dim grid As GridControl = FindGrid()
            If grid IsNot Nothing AndAlso TypeOf grid.View Is IPrintableControl Then
                Return grid.View
            End If
            Return Nothing
        End Function
        Public Overrides Function GetSidebarContent() As Object
            Dim exportView As DataViewBase = GetExportView()
            Return New DemoModuleExportControl(exportView, AllowDataAwareExport AndAlso TypeOf exportView Is TableView, AllowWYSIWYGExport, GetReportView() IsNot Nothing)
        End Function
        Public Overrides Function GetSidebarIcon() As System.Windows.Media.ImageSource
            Return New BitmapImage(New Uri("/GridDemo;component/Images/PrintIcon.png", UriKind.Relative))
        End Function
        Public Overrides Function GetSidebarIconSelected() As System.Windows.Media.ImageSource
            Return New BitmapImage(New Uri("/GridDemo;component/Images/PrintIconSelected.png", UriKind.Relative))
        End Function
        Public Overrides Function GetSidebarTag() As String
            Return "Export"
        End Function
        #End Region
        #Region "Reports"
        Protected Overridable Function GetReportView() As IGridViewFactory(Of ColumnWrapper, RowBaseWrapper)
            Dim grid As GridControl = FindGrid()
            If grid IsNot Nothing AndAlso TypeOf grid.View Is IGridViewFactory(Of ColumnWrapper, RowBaseWrapper) Then
                Return TryCast(grid.View, IGridViewFactory(Of ColumnWrapper, RowBaseWrapper))
            End If
            Return Nothing
        End Function
        Public Overrides Function IsSidebar2ButtonEnabled() As Boolean
            Return GetReportView() IsNot Nothing
        End Function
        Public Overrides Function GetSidebar2Content() As Object
            Dim reportView = GetReportView()
            If reportView IsNot Nothing Then
                Return New ReportsSideBarControl(Me.GetType().Name, reportView)
            End If
            Return Nothing
        End Function
        Public Overrides Function GetSidebar2Icon() As System.Windows.Media.ImageSource
            Return New BitmapImage(New Uri("/GridDemo;component/Images/ReportIcon.png", UriKind.Relative))
        End Function
        Public Overrides Function GetSidebar2IconSelected() As System.Windows.Media.ImageSource
            Return New BitmapImage(New Uri("/GridDemo;component/Images/ReportIconSelected.png", UriKind.Relative))
        End Function
        Public Overrides Function GetSidebar2Tag() As String
            Return "Reports"
        End Function
        #End Region
    End Class
    Public Class GridControlWrapper
        Implements System.ComponentModel.INotifyPropertyChanged

        Private grid As GridControl
        Public Property GridControl() As GridControl
            Get
                Return grid
            End Get
            Set(ByVal value As GridControl)
                If grid Is value Then
                    Return
                End If
                grid = value
                OnPropertyChanged("GridControl")
            End Set
        End Property
        Public Sub New(ByVal gridControl As GridControl)
            Me.GridControl = gridControl
        End Sub

        Public Event PropertyChanged As System.ComponentModel.PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
        Private Sub OnPropertyChanged(ByVal propertyName As String)
            RaiseEvent PropertyChanged(Me, New System.ComponentModel.PropertyChangedEventArgs(propertyName))
        End Sub
    End Class
    Public Class PrintViewGridDemoModule
        Inherits GridDemoModule

        Protected Overridable ReadOnly Property DXTabControl() As DXTabControl
            Get
                Return Nothing
            End Get
        End Property
        Public Overrides Function FindGrid() As GridControl
            Return If(DXTabControl IsNot Nothing, CType(CType(DXTabControl.Items(0), DXTabItem).Content, GridControl), Nothing)
        End Function
        Public Sub ShowPrintPreview()
            Dim owner As Window = LayoutHelper.FindParentObject(Of Window)(Me)
            DevExpress.Xpf.Grid.Printing.PrintHelper.ShowPrintPreviewDialog(owner, DirectCast(GridControl.View, IPrintableControl), "Grid Document")
        End Sub
        Public Sub ShowPrintPreviewInNewTab(ByVal grid As GridControl, ByVal tabControl As DXTabControl, ByVal tabName As String)
            Dim link As New PrintableControlLink(DirectCast(grid.View, IPrintableControl))
            Dim preview As New DocumentPreviewControl() With {.DocumentSource = link}

            Dim tabItem As New DXTabItem() With {.AllowHide = DefaultBoolean.True, .Content = preview, .Header = tabName}
            tabItem.Tag = link
            tabControl.Items.Add(tabItem)
            tabControl.SelectedItem = tabItem

            link.CreateDocument(True)
        End Sub
        Protected Sub DisposePrintPreviewTabContent(ByVal tabItem As DXTabItem)
            If tabItem.Tag IsNot Nothing Then
                CType(tabItem.Tag, PrintableControlLink).Dispose()
            End If
            DXTabControl.Items.Remove(tabItem)
        End Sub
        Protected Overrides Sub Clear()
            MyBase.Clear()
            For i As Integer = DXTabControl.Items.Count - 1 To 1 Step -1
                DisposePrintPreviewTabContent(CType(DXTabControl.Items(i), DXTabItem))
            Next i
        End Sub
        Protected Sub newWindowButton_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
            ShowPrintPreview()
        End Sub
        Protected Overridable Sub ShowPreviewInNewTab()
        End Sub
    End Class
    Public Class CountryToFlagImageConverter
        Inherits BytesToImageSourceConverter

        Public Overrides Function Convert(ByVal value As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal culture As System.Globalization.CultureInfo) As Object
            For Each item As Country In CountriesData.DataSource
                If (item.Name = DirectCast(value, String) OrElse item.NWindName = DirectCast(value, String)) Then
                    Return MyBase.Convert(item.Flag, targetType, parameter, culture)
                End If
            Next item
            Return Nothing
        End Function
    End Class
End Namespace
Namespace CommonDemo
    Public Class CommonDemoModule
        Inherits GridDemo.GridDemoModule

    End Class
End Namespace
