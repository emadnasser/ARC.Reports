Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.Utils
Imports DevExpress.LookAndFeel

Namespace DevExpress.XtraLayout.Demos
	Public Partial Class Browser
		Inherits DevExpress.XtraLayout.Demos.TutorialControl
		Private needDecreaseSelectedPageIndex As Boolean = False
		Private defaultUrl As String = ""
		Private dxUrl As String = "http://www.devexpress.com/"
		Public Sub New()
            InitializeComponent()
            DisabledVerticalStyle()
		End Sub
        Protected Overrides Sub OnStyleChanged()
            MyBase.OnStyleChanged()
            DisabledVerticalStyle()
        End Sub
        Sub DisabledVerticalStyle()
            checkEdit2.Enabled = UserLookAndFeel.Default.ActiveStyle <> ActiveLookAndFeelStyle.Flat _
                And UserLookAndFeel.Default.ActiveStyle <> ActiveLookAndFeelStyle.Office2003 _
                And UserLookAndFeel.Default.ActiveStyle <> ActiveLookAndFeelStyle.UltraFlat
        End Sub
        Protected Sub SetUrlInSelectedTabPage(ByVal url As String)
            If url = "" OrElse url Is Nothing Then
                CType((CType(tabbedControlGroup1.SelectedTabPage(0), LayoutControlItem)).Control, WebBrowser).GoHome()
            Else
                CType((CType(tabbedControlGroup1.SelectedTabPage(0), LayoutControlItem)).Control, WebBrowser).Url = New Uri(url)
            End If
        End Sub
        Protected Sub UpdateUrl()
            Dim wasError As Boolean = False
            Try
                SetUrlInSelectedTabPage(CStr(urlEdit.EditValue))
            Catch
                Try
                    SetUrlInSelectedTabPage("http://" & CStr(urlEdit.EditValue))
                Catch
                    wasError = True
                End Try
            End Try
            If (Not wasError) Then
                tabbedControlGroup1.SelectedTabPage.Text = CStr(urlEdit.EditValue)
            End If
        End Sub
        Private Sub urlEdit_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles urlEdit.ButtonClick
            UpdateUrl()
        End Sub
        Private Sub layoutControl1_TabPageCloseButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraLayout.Utils.LayoutGroupEventArgs) Handles layoutControl1.TabPageCloseButtonClick
            If tabbedControlGroup1.TabPages.Count = 2 Then
                Return
            End If
            DestroyTab(e.Group)
        End Sub
        Protected Sub CheckCloseButtonStatus()
            If tabbedControlGroup1.TabPages.Count = 2 Then
                tabbedControlGroup1.TabPages(0).ShowTabPageCloseButton = False
            End If
            If tabbedControlGroup1.TabPages.Count > 2 Then
                tabbedControlGroup1.TabPages(0).ShowTabPageCloseButton = True
            End If
        End Sub
        Public Sub DestroyTab(ByVal group As LayoutGroup)
            tabbedControlGroup1.BeginUpdate()
            CType((CType(group(0), LayoutControlItem)).Control, WebBrowser).Dispose()
            group.Dispose()
            CheckCloseButtonStatus()
            tabbedControlGroup1.EndUpdate()
        End Sub
        Private tabIndexToSelect As Integer = -1
        Private Sub tabbedControlGroup1_SelectedPageChanging(ByVal sender As Object, ByVal e As DevExpress.XtraLayout.LayoutTabPageChangingEventArgs) Handles tabbedControlGroup1.SelectedPageChanging
            If e.Page Is tabbedControlGroup1.TabPages(tabbedControlGroup1.TabPages.Count - 1) Then
                If (Not tabbedControlGroup1.IsUpdateLocked) Then
                    CreateBrowserTab(defaultUrl)
                    e.Cancel = True
                Else
                    needDecreaseSelectedPageIndex = True
                End If
            End If
        End Sub
        Protected Sub AsyncSelectTab()
            tabbedControlGroup1.SelectedTabPageIndex = tabIndexToSelect
        End Sub
        Private Sub tabbedControlGroup1_SelectedPageChanged(ByVal sender As Object, ByVal e As LayoutTabPageChangedEventArgs) Handles tabbedControlGroup1.SelectedPageChanged
            If needDecreaseSelectedPageIndex Then
                needDecreaseSelectedPageIndex = False
                tabbedControlGroup1.SelectedTabPageIndex -= 1
            End If
        End Sub
        Protected Sub CreateBrowserTab(ByVal url As String)
            layoutControl1.BeginUpdate()
            Dim newPage As LayoutControlGroup = New LayoutControlGroup()
            tabbedControlGroup1.InsertTabPage(tabbedControlGroup1.TabPages.Count - 1, newPage)
            newPage.ShowTabPageCloseButton = True
            Dim lci As LayoutControlItem = newPage.AddItem()
            lci.Padding = New XtraLayout.Utils.Padding(0)
            lci.TextVisible = False
            lci.BeginInit()
            Dim browser As WebBrowser = New WebBrowser()
            browser.Bounds = Rectangle.Empty 'antiflicker :)
            browser.Name = Guid.NewGuid().ToString()
            browser.ScriptErrorsSuppressed = True
            lci.Control = browser
            lci.EndInit()
            SetUrlInSelectedTabPage(url)
            If url <> "" Then
                newPage.Text = url
            Else
                newPage.Text = "New Page"
            End If
            CheckCloseButtonStatus()
            tabIndexToSelect = tabbedControlGroup1.TabPages.IndexOf(newPage)
            BeginInvoke(New MethodInvoker(AddressOf AsyncSelectTab))
            layoutControl1.EndUpdate()
        End Sub
        Private Sub UserControl1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
            CreateBrowserTab(dxUrl)
            FillComboBoxValues()
        End Sub
        Protected Sub FillComboBoxValues()
            Dim names As String() = System.Enum.GetNames(tabbedControlGroup1.TextLocation.GetType())
            For Each name As String In names
                comboBoxEdit1.Properties.Items.Add(name)
            Next name
            comboBoxEdit1.SelectedIndex = 0
        End Sub
        Private Sub simpleButton1_Click(ByVal sender As Object, ByVal e As EventArgs)
            tabbedControlGroup1.BeginUpdate()
            tabbedControlGroup1.SelectedTabPage.HideToCustomization()
            tabbedControlGroup1.EndUpdate()
        End Sub

        Private Sub urlEdit_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles urlEdit.KeyDown
            If e.KeyCode = Keys.Enter Then
                UpdateUrl()
            End If
        End Sub

        Private Sub checkEdit1_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkEdit1.CheckedChanged
            If checkEdit1.Checked Then
                tabbedControlGroup1.MultiLine = DefaultBoolean.True
            Else
                tabbedControlGroup1.MultiLine = DefaultBoolean.False
            End If
        End Sub

        Private Sub checkEdit2_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkEdit2.CheckedChanged
            If checkEdit2.Checked Then
                tabbedControlGroup1.HeaderOrientation = DevExpress.XtraTab.TabOrientation.Vertical
            Else
                tabbedControlGroup1.HeaderOrientation = DevExpress.XtraTab.TabOrientation.Horizontal
            End If
        End Sub

        Private Sub comboBoxEdit1_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles comboBoxEdit1.SelectedIndexChanged
            tabbedControlGroup1.TextLocation = CType(System.Enum.Parse(GetType(Locations), CStr(comboBoxEdit1.Properties.Items(comboBoxEdit1.SelectedIndex))), Locations)
            checkEdit2_CheckedChanged(sender, e)
        End Sub
    End Class
End Namespace
