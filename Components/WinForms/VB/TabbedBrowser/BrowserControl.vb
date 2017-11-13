Imports DevExpress.XtraBars.Docking
Imports DevExpress.XtraBars.Docking2010
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls

Namespace TabbedBrowser
    Partial Public Class BrowserControl
        Inherits XtraUserControl
        Private thisUrl As String
        Friend ReadOnly Property GetCaption() As String
            Get
                Return webBrowser.Url.Host
            End Get
        End Property
        Private Shared ReadOnly changeHistoryCore As New Object()
        Public Custom Event ChangeHistory As EventHandler
            AddHandler(ByVal value As EventHandler)
                Events.AddHandler(changeHistoryCore, value)
            End AddHandler
            RemoveHandler(ByVal value As EventHandler)
                Events.RemoveHandler(changeHistoryCore, value)
            End RemoveHandler
            RaiseEvent(ByVal sender As Object, ByVal e As EventArgs)
            End RaiseEvent
        End Event
        Public Sub New()
            Initialize("")
        End Sub
        Public Sub New(ByVal url As String)
            Initialize(url)
        End Sub
        Private Sub Initialize(ByVal url As String)
            InitializeComponent()
            CreateBrowser(url)
        End Sub
        Private Sub CreateBrowser(ByVal url As String)
            layoutControl.BeginUpdate()
            Forward.Enabled = False
            Back.Enabled = False
            webBrowser.Navigate(url)
            AddHandler webBrowser.CanGoBackChanged, AddressOf CanGoBackChanged
            AddHandler webBrowser.CanGoForwardChanged, AddressOf CanGoForwardChanged
            AddHandler webBrowser.Navigated, AddressOf Navigated
            layoutControl.EndUpdate()
        End Sub
        Private Sub ActivePanelChanged(ByVal sender As Object, ByVal e As ActivePanelChangedEventArgs)
            If e.OldPanel IsNot Nothing Then
                e.OldPanel.Hide()
            End If
        End Sub
        Private Sub Navigated(ByVal sender As Object, ByVal e As WebBrowserNavigatedEventArgs)
            AddressBar.Text = webBrowser.Url.ToString()
            thisUrl = AddressBar.Text
            Text = thisUrl
            Dim handler As EventHandler = CType(Events(changeHistoryCore), EventHandler)
            If handler IsNot Nothing Then
                handler(webBrowser.Url.ToString(), e)
            End If
        End Sub
        Private Sub CanGoForwardChanged(ByVal sender As Object, ByVal e As EventArgs)
            Forward.Enabled = webBrowser.CanGoForward
        End Sub
        Private Sub CanGoBackChanged(ByVal sender As Object, ByVal e As EventArgs)
            Back.Enabled = webBrowser.CanGoBack
        End Sub
        Private Sub NavigateCore(ByVal url As String)
            webBrowser.Navigate(New Uri(url))
        End Sub
        Public Sub Navigate(ByVal url As String)
            Try
                NavigateCore(url)
            Catch
                Try
                    NavigateCore("http://" & url)
                Catch
                End Try
            End Try
        End Sub
        Private Sub AddressBarKeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles AddressBar.KeyDown
            If e.KeyCode = Keys.Enter Then
                Navigate(AddressBar.EditValue.ToString())
            End If
        End Sub
        Private Sub buttonsPanel_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles Back.ItemClick, Forward.ItemClick, Refresh_button.ItemClick
            If e.Item Is Back Then
                webBrowser.GoBack()
            End If
            If e.Item Is Forward Then
                webBrowser.GoForward()
            End If
            If thisUrl IsNot Nothing And e.Item Is Refresh_button Then
                NavigateCore(thisUrl)
            End If
        End Sub
    End Class
End Namespace
