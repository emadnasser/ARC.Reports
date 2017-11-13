Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors
Imports DevExpress.XtraRichEdit.Services
Imports DevExpress.XtraRichEdit.API.Native
Imports DevExpress.XtraRichEdit.Demos.Forms

Namespace DevExpress.XtraRichEdit.Demos
	Partial Public Class DocumentProtectionModule
		Inherits DevExpress.XtraRichEdit.Demos.TutorialControl
		Private userService As UserService
        Private activeUser As String = String.Empty

		Public Sub New()
			InitializeComponent()
			richEditControl.RemoveService(GetType(IUserListService))
			Me.userService = New UserService()
			richEditControl.AddService(GetType(IUserListService), Me.userService)
			AddHandler richEditControl.DocumentLoaded, AddressOf OnRichEditControl1DocumentLoaded
			AddHandler richEditControl.DocumentProtectionChanged, AddressOf OnRichEditControlDocumentProtectionChanged
            OpenXmlLoadHelper.Load("DocumentProtection.docx", richEditControl)
            CType(New RichEditDemoExceptionsHandler(richEditControl), RichEditDemoExceptionsHandler).Install()
		End Sub

		Private Sub OnRichEditControlDocumentProtectionChanged(ByVal sender As Object, ByVal e As EventArgs)
			ShowAlert(richEditControl.Document.IsDocumentProtected)
			richEditControl.ClearUndo()
		End Sub
		Private Sub ShowAlert(ByVal show As Boolean)
			pnlAlert.Visible = show
		End Sub
		Private Sub OnRichEditControl1DocumentLoaded(ByVal sender As Object, ByVal e As EventArgs)
			Dim rangePermissions As RangePermissionCollection = richEditControl.Document.BeginUpdateRangePermissions()
			cbUsers.Properties.Items.Clear()
			richEditControl.Document.CancelUpdateRangePermissions(rangePermissions)
			Dim users As List(Of String) = FetchUsers(rangePermissions)
			For Each user As String In users
				cbUsers.Properties.Items.Add(user)
			Next user

			userService.Update(users)
			If users.Count > 0 Then
				SetActiveUser(users(0))
				Me.cbUsers.Visible = True
			Else
				SetActiveUser("guest")
				Me.cbUsers.Properties.Items.Add("guest")
				Me.cbUsers.Visible = False
			End If
			cbUsers.SelectedIndex = 0
			ShowAlert(richEditControl.Document.IsDocumentProtected)
		End Sub
		Private Function FetchUsers(ByVal rangePermissions As RangePermissionCollection) As List(Of String)
			Dim users As New List(Of String)()
			For Each rangePermission As RangePermission In rangePermissions
				Dim userName As String = rangePermission.UserName
				If users.Contains(userName) Then
					Continue For
				End If
				If (Not String.IsNullOrEmpty(userName)) Then
					users.Add(userName)
				End If
			Next rangePermission
			Return users
		End Function
		Private Sub SetActiveUser(ByVal user As String)
			richEditControl.Options.Authentication.EMail = user
			Me.activeUser = user
		End Sub

		Private Sub cbUsers_SelectedValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbUsers.SelectedValueChanged
			SetActiveUser(cbUsers.SelectedItem.ToString())
		End Sub
	End Class
	Public Class UserService
		Implements IUserListService
		Private users_Renamed As New List(Of String)()

		Public ReadOnly Property Users() As List(Of String)
			Get
				Return users_Renamed
			End Get
		End Property

		#Region "IUserListService Members"
		Public Function GetUsers() As IList(Of String) Implements IUserListService.GetUsers
			Return Users
		End Function
		#End Region
		Public Sub Update(ByVal userList As List(Of String))
			Me.users_Renamed.Clear()
			Me.users_Renamed.AddRange(userList)
		End Sub
	End Class
End Namespace
