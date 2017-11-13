Imports System
Imports System.Collections.Generic
Imports System.Windows
Imports DevExpress.XtraRichEdit.Services
Imports DevExpress.XtraRichEdit.API.Native
Imports DevExpress.Xpf.Editors

Namespace RichEditDemo
    Partial Public Class DocumentProtection
        Inherits RichEditDemoModule

        Private ReadOnly userService As UserService

        Public Sub New()
            InitializeComponent()
            richEdit.RemoveService(GetType(IUserListService))
            Me.userService = New UserService()
            richEdit.AddService(GetType(IUserListService), Me.userService)
        End Sub

        Private Sub richEdit_Loaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
            AddHandler richEdit.DocumentLoaded, AddressOf OnRichEditControlDocumentLoaded
            AddHandler richEdit.DocumentProtectionChanged, AddressOf OnRichEditControlDocumentProtectionChanged
            OpenXmlLoadHelper.Load("DocumentProtection.docx", richEdit)
        End Sub

        Private Sub OnRichEditControlDocumentProtectionChanged(ByVal sender As Object, ByVal e As EventArgs)
            ShowAlert(richEdit.Document.IsDocumentProtected)
        End Sub
        Private Sub OnRichEditControlDocumentLoaded(ByVal sender As Object, ByVal e As EventArgs)
            Dim rangePermissions As RangePermissionCollection = richEdit.Document.BeginUpdateRangePermissions()
            richEdit.Document.CancelUpdateRangePermissions(rangePermissions)
            Dim users As List(Of String) = FetchUsers(rangePermissions)
            userService.Update(users)
            cbUserName.Items.Clear()
            cbUserName.Items.AddRange(users.ToArray())
            If users.Count > 0 Then
                cbUserName.EditValue = users(0)
            End If
            ShowAlert(richEdit.Document.IsDocumentProtected)
        End Sub
        Private Function FetchUsers(ByVal rangePermissions As RangePermissionCollection) As List(Of String)
            Dim users As New List(Of String)()
            For Each rangePermission As RangePermission In rangePermissions
                Dim userName As String = rangePermission.UserName
                If users.Contains(userName) Then
                    Continue For
                End If
                If Not String.IsNullOrEmpty(userName) Then
                    users.Add(userName)
                End If
            Next rangePermission
            Return users
        End Function
        Private Sub SetActiveUser()
            richEdit.Options.Authentication.EMail = cbUserName.Text
        End Sub
        Private Sub ShowAlert(ByVal show As Boolean)
            pnlAlert.Visibility = If(show, Visibility.Visible, Visibility.Collapsed)
        End Sub

        Private Sub cbUserName_EditValueChanged(ByVal sender As Object, ByVal e As EditValueChangedEventArgs)
            SetActiveUser()
        End Sub
    End Class
    Public Class UserService
        Implements IUserListService


        Private ReadOnly users_Renamed As New List(Of String)()

        Public ReadOnly Property Users() As List(Of String)
            Get
                Return users_Renamed
            End Get
        End Property

        #Region "IUserListService Members"
        Private Function IUserListService_GetUsers() As IList(Of String) Implements IUserListService.GetUsers
            Return Users
        End Function
        #End Region
        Public Sub Update(ByVal userList As List(Of String))
            Me.users_Renamed.Clear()
            Me.users_Renamed.AddRange(userList)
        End Sub
    End Class
End Namespace
