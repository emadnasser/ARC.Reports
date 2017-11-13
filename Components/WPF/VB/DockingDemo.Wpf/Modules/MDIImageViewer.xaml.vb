Imports System
Imports System.IO
Imports System.Windows.Controls
Imports System.Windows.Media
Imports System.Windows.Media.Imaging
Imports DevExpress.Xpf.Docking
Imports DevExpress.Xpf.Docking.Base
Imports Microsoft.Win32
Imports System.Windows.Data

Namespace DockingDemo
    Partial Public Class MDIImageViewer
        Inherits DockingDemoModule

        Public Sub New()
            InitializeComponent()
            Dim pane1 As DocumentPanel = OpenImage(New Uri("/DockingDemo;component/Images/Audi_TT_Roadster.jpg", UriKind.Relative))
            Dim pane2 As DocumentPanel = OpenImage(New Uri("/DockingDemo;component/Images/BMW_760i_Sedan.jpg", UriKind.Relative))
            DocumentPanel.SetMDILocation(pane1, New System.Windows.Point(50, 50))
            DocumentPanel.SetMDILocation(pane2, New System.Windows.Point(250, 150))
            AddHandler dockManager.DockItemActivated, AddressOf OnDockItemActivated
            DataContext = New CommandsModel() With {.Target = dockManager.GetItem("mdiContainer")}

        End Sub
        Protected Overrides Sub RaiseAfterModuleDisappear()
            MyBase.RaiseAfterModuleDisappear()
            ClearValue(DataContextProperty)
        End Sub
        Private Sub OnDockItemActivated(ByVal sender As Object, ByVal ea As DockItemActivatedEventArgs)
            Dim panel As DocumentPanel = TryCast(ea.Item, DocumentPanel)
            If panel IsNot Nothing Then
                bFileName.Content = Path.GetFileName(TryCast(panel.Caption, String))
            Else
                bFileName.Content = Nothing
            End If
        End Sub
        Private Function OpenImage(ByVal uri As Uri) As DocumentPanel
            Dim img As BitmapImage = Nothing
            Try
                img = New BitmapImage(uri)
            Catch
                System.Windows.MessageBox.Show("Wrong picture format")
            End Try
            Return If(img IsNot Nothing, CreateImageWindow(uri.OriginalString, img), Nothing)
        End Function
        Private Function CreateImageWindow(ByVal caption As String, ByVal source As ImageSource) As DocumentPanel
            Dim panel As DocumentPanel = dockManager.DockController.AddDocumentPanel(mdiContainer)
            panel.Content = New Image() With {.Source = source, .Margin = New System.Windows.Thickness(5)}
            panel.Caption = caption
            Return panel
        End Function
        Private Sub bOpen_ItemClick(ByVal sender As Object, ByVal e As DevExpress.Xpf.Bars.ItemClickEventArgs)
            Dim ofd As New OpenFileDialog()
            ofd.Filter = "All Picture Files |*.bmp;*.gif;*.jpg;*.jpeg;*.ico;*.png"
            Dim result? As Boolean = ofd.ShowDialog()
            If result.HasValue AndAlso result.Value Then
                OpenImage(New Uri(ofd.FileName, UriKind.Absolute))
            End If
        End Sub
        Private Sub bHome_ItemClick(ByVal sender As Object, ByVal e As DevExpress.Xpf.Bars.ItemClickEventArgs)
            NavigateHomePage()
        End Sub
        Private Sub bAbout_ItemClick(ByVal sender As Object, ByVal e As DevExpress.Xpf.Bars.ItemClickEventArgs)
            ShowAbout()
        End Sub
    End Class
End Namespace
