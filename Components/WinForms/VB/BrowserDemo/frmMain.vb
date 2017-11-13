Imports System.Drawing
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Xml
Imports System

Namespace DevExpress.XtraBars.Demos.BrowserDemo
    Partial Public Class frmMain
        Inherits TabForm
        Public Sub New()
            Me.New(True)
        End Sub
        Public Sub New(hasPage As Boolean)
            DevExpress.Utils.About.UAlgo.[Default].DoEventObject(DevExpress.Utils.About.UAlgo.kDemo, DevExpress.Utils.About.UAlgo.pWinForms, Me)
            'DEMO_REMOVE
            InitializeComponent()
            Initialize(hasPage)
        End Sub
        Protected Sub Initialize(shouldCreateWebBrowser As Boolean)
            Me.shouldInitHomePage = shouldCreateWebBrowser
            If shouldCreateWebBrowser Then
                CreatePageWebBrowser(TabFormControl.SelectedPage)
                SubscribeOnPageEvents()
            Else
                TabFormControl.Pages.Clear()
                TabFormControl.SelectedPage = Nothing
            End If
            AddHandler TabFormControl.SelectedPageChanged, AddressOf OnSelectedPageChanged
            AddHandler TabFormControl.SelectedPageChanging, AddressOf OnSelectedPageChanging
            AddHandler TabFormControl.PageCreated, AddressOf OnPageCreated
            Icon = DevExpress.Utils.ResourceImageHelper.CreateIconFromResourcesEx("BrowserDemo.AppIcon.ico", GetType(frmMain).Assembly)
            barManager1.ForceLinkCreate()
            AddHandler barManager1.GetController().Changed, New EventHandler(AddressOf ChangedController)
            InitSkins()
            Me.Focus()
        End Sub

        Private Sub OnPageCreated(sender As Object, e As PageCreatedEventArgs)
            CreatePageWebBrowser(e.Page)
        End Sub

        Private Sub CreatePageWebBrowser(page As TabFormPage)
            Dim browser As New TabFormWebBrowser(page)
            page.ContentContainer.Controls.Add(browser)
            browser.Dock = DockStyle.Fill
            browser.ScriptErrorsSuppressed = True
            page.ContentContainer.Controls.Add(New BrowserNavigationControl())
        End Sub

        Private Sub OnSelectedPageChanging(sender As Object, e As TabFormSelectedPageChangingEventArgs)
            UnsubscribeOnPageEvents()
        End Sub
        Private Sub OnSelectedPageChanged(sender As Object, e As TabFormSelectedPageChangedEventArgs)
            SubscribeOnPageEvents()
            If NavigationPanel Is Nothing Then
                Return
            End If
            If WebBrowser Is Nothing OrElse WebBrowser.Url Is Nothing Then
                NavigationPanel.SearchItem.EditValue = String.Empty
            Else
                NavigationPanel.SearchItem.EditValue = WebBrowser.Url.AbsoluteUri
            End If
            CheckButtons()
        End Sub
        Private Sub CheckButtons()
            NavigationPanel.ForwardButton.Enabled = WebBrowser.CanGoForward
            NavigationPanel.BackButton.Enabled = WebBrowser.CanGoBack
        End Sub
        Private Sub SubscribeOnPageEvents()
            If WebBrowser IsNot Nothing Then
                AddHandler WebBrowser.Navigated, New System.Windows.Forms.WebBrowserNavigatedEventHandler(AddressOf Me.webBrowser1_Navigated)
                AddHandler WebBrowser.CanGoBackChanged, New EventHandler(AddressOf OnWebBrowserCanGoBackChanged)
                AddHandler WebBrowser.CanGoForwardChanged, New EventHandler(AddressOf OnWebBrowserCanGoForwardChanged)
                AddHandler NavigationPanel.SearchPanel.CloseUp, New DevExpress.XtraEditors.Controls.CloseUpEventHandler(AddressOf Me.repositoryItemComboBox1_CloseUp)
                AddHandler NavigationPanel.SearchPanel.KeyDown, New System.Windows.Forms.KeyEventHandler(AddressOf Me.repositoryItemComboBox1_KeyDown)
                AddHandler NavigationPanel.SearchPanel.Validating, New System.ComponentModel.CancelEventHandler(AddressOf Me.repositoryItemComboBox1_Validating)
                AddHandler NavigationPanel.BackButton.ItemClick, AddressOf OnBackButtonItemClick
                AddHandler NavigationPanel.ForwardButton.ItemClick, AddressOf OnForwardButtonItemClick
                AddHandler NavigationPanel.RefreshButton.ItemClick, AddressOf OnRefreshButtonItemClick
            End If
        End Sub
        Private Sub UnsubscribeOnPageEvents()
            If WebBrowser IsNot Nothing Then
                RemoveHandler WebBrowser.Navigated, New System.Windows.Forms.WebBrowserNavigatedEventHandler(AddressOf Me.webBrowser1_Navigated)
                RemoveHandler WebBrowser.CanGoBackChanged, New EventHandler(AddressOf OnWebBrowserCanGoBackChanged)
                RemoveHandler WebBrowser.CanGoForwardChanged, New EventHandler(AddressOf OnWebBrowserCanGoForwardChanged)
                RemoveHandler NavigationPanel.SearchPanel.CloseUp, New DevExpress.XtraEditors.Controls.CloseUpEventHandler(AddressOf Me.repositoryItemComboBox1_CloseUp)
                RemoveHandler NavigationPanel.SearchPanel.KeyDown, New System.Windows.Forms.KeyEventHandler(AddressOf Me.repositoryItemComboBox1_KeyDown)
                RemoveHandler NavigationPanel.SearchPanel.Validating, New System.ComponentModel.CancelEventHandler(AddressOf Me.repositoryItemComboBox1_Validating)
                RemoveHandler NavigationPanel.BackButton.ItemClick, AddressOf OnBackButtonItemClick
                RemoveHandler NavigationPanel.ForwardButton.ItemClick, AddressOf OnForwardButtonItemClick
                RemoveHandler NavigationPanel.RefreshButton.ItemClick, AddressOf OnRefreshButtonItemClick
            End If
        End Sub

        Public ReadOnly Property WebBrowser() As WebBrowser
            Get
                If TabFormControl.SelectedPage Is Nothing Then
                    Return Nothing
                End If
                For Each ctrl As Control In TabFormControl.SelectedPage.ContentContainer.Controls
                    If TypeOf ctrl Is WebBrowser Then
                        Return TryCast(ctrl, WebBrowser)
                    End If
                Next
                Return Nothing
            End Get
        End Property
        Public ReadOnly Property NavigationPanel() As BrowserNavigationControl
            Get
                If TabFormControl.SelectedPage Is Nothing Then
                    Return Nothing
                End If
                For Each ctrl As Control In TabFormControl.SelectedPage.ContentContainer.Controls
                    If TypeOf ctrl Is BrowserNavigationControl Then
                        Return TryCast(ctrl, BrowserNavigationControl)
                    End If
                Next
                Return Nothing
            End Get
        End Property


        Private skinProcessing As Boolean = False
        Private currentAddress As String = ""

#Region "Skins"

        Private Sub InitSkins()
            barManager1.ForceInitialize()
        End Sub

        Private Sub ChangedController(sender As Object, e As EventArgs)
            If skinProcessing Then
                Return
            End If
            Dim paintStyleName As String = barManager1.GetController().PaintStyleName
            If "DefaultSkin".IndexOf(paintStyleName) >= 0 Then
                DevExpress.Skins.SkinManager.EnableFormSkins()
            Else
                DevExpress.Skins.SkinManager.DisableFormSkins()
            End If
            skinProcessing = True
            DevExpress.LookAndFeel.LookAndFeelHelper.ForceDefaultLookAndFeelChanged()
            skinProcessing = False
        End Sub
#End Region

        Private Sub AddNewItem(s As String)
            If NavigationPanel Is Nothing Then
                Return
            End If
            If s <> "" Then
                Dim isAdded As Boolean = False
                For i As Integer = 0 To NavigationPanel.SearchPanel.Items.Count - 1
                    If NavigationPanel.SearchPanel.Items(i).ToString() = s Then
                        isAdded = True
                        Exit For
                    End If
                Next
                If Not isAdded Then
                    NavigationPanel.SearchPanel.Items.Add(s)
                End If
            End If
        End Sub

        Private Sub GoToItem(address As String)
            If address Is Nothing Then
                Return
            End If
            If currentAddress <> address Then
                NavigationPanel.SearchItem.EditValue = address
                Try
                    If WebBrowser IsNot Nothing AndAlso Not WebBrowser.IsBusy Then
                        WebBrowser.Navigate(address)
                    End If
                Catch
                End Try
            End If
        End Sub

        Private ReadOnly Property Address() As String
            Get
                If barManager1.ActiveEditor IsNot Nothing AndAlso barManager1.ActiveEditor.EditValue IsNot Nothing Then
                    Return barManager1.ActiveEditor.EditValue.ToString()
                End If
                Return Nothing
            End Get
        End Property

        Private Sub repositoryItemComboBox1_CloseUp(sender As Object, e As DevExpress.XtraEditors.Controls.CloseUpEventArgs)
            GoToItem(Address)
        End Sub

        Private Sub repositoryItemComboBox1_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs)
            Dim edit As DevExpress.XtraEditors.ComboBoxEdit = TryCast(sender, DevExpress.XtraEditors.ComboBoxEdit)
            If e.KeyData = Keys.Escape Then
                e.Handled = True
                edit.SelectAll()
            End If
            If e.KeyData = Keys.Enter AndAlso Not edit.IsPopupOpen Then
                NavigationPanel.Manager.ActiveEditItemLink.PostEditor()
                edit.SelectAll()
                e.Handled = True
                GoToItem(NavigationPanel.SearchItem.EditValue.ToString())
            End If
        End Sub
        Private Sub repositoryItemComboBox1_Validating(sender As Object, e As CancelEventArgs)
            GoToItem(Address)
        End Sub

        Private blankString As String = "about:blank"
        Private Sub webBrowser1_Navigated(sender As Object, e As WebBrowserNavigatedEventArgs)
            If Not Object.Equals(sender, WebBrowser) Then
                Return
            End If
            Dim documentUri As String = WebBrowser.Url.AbsoluteUri
            Dim eventUri As String = e.Url.AbsoluteUri
            If eventUri = blankString Then
                Return
            End If
            If documentUri <> eventUri Then
                Return
            End If
            If barManager1.ActiveEditor IsNot Nothing Then
                barManager1.ActiveEditItemLink.CloseEditor()
            End If
            If CorrectAddress(eventUri) Then
                NavigationPanel.SearchItem.EditValue = eventUri
                currentAddress = eventUri
                AddNewItem(eventUri)
            End If
        End Sub
        Private Sub OnWebBrowserCanGoForwardChanged(sender As Object, e As EventArgs)
            NavigationPanel.ForwardButton.Enabled = WebBrowser.CanGoForward
        End Sub
        Private Sub OnWebBrowserCanGoBackChanged(sender As Object, e As EventArgs)
            NavigationPanel.BackButton.Enabled = WebBrowser.CanGoBack
        End Sub

        Private Function CorrectAddress(name As String) As Boolean
            Dim names As String() = New String() {"javascript:"}
            For Each s As String In names
                If name.IndexOf(s) = 0 Then
                    Return False
                End If
            Next
            Return True
        End Function

        Private Sub OnRefreshButtonItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs)
            If WebBrowser Is Nothing OrElse WebBrowser.Url Is Nothing Then
                Return
            End If
            WebBrowser.Navigate(WebBrowser.Url.AbsoluteUri)
        End Sub

        Private Sub OnBackButtonItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs)
            Try
                If WebBrowser IsNot Nothing Then
                    WebBrowser.GoBack()
                End If
            Catch
            End Try
        End Sub

        Private Sub OnForwardButtonItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs)
            Try
                If WebBrowser IsNot Nothing Then
                    WebBrowser.GoForward()
                End If
            Catch
            End Try
        End Sub

        Private shouldInitHomePage As Boolean = True
        Private Sub InitHomePage()
            GoToItem("www.devexpress.com/Subscriptions/Universal.xml")
        End Sub

        Private Sub frmMain_Load(sender As Object, e As System.EventArgs) Handles MyBase.Load
            If Me.shouldInitHomePage Then
                BeginInvoke(New MethodInvoker(AddressOf InitHomePage))
            End If
        End Sub

        Private Sub OnOuterFormCreating(sender As Object, e As OuterFormCreatingEventArgs) Handles tabFormControl1.OuterFormCreating
            e.Form = New frmMain(False)
        End Sub
    End Class
End Namespace
