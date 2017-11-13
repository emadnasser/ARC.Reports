Imports System.Web.Security
Imports System.Linq

Public Class DocumentsMembershipProvider
    Inherits MembershipProvider

    Public Overrides Function ValidateUser(ByVal username As String, ByVal password As String) As Boolean
        Dim user As User = DocumentsApp.Instance.User.ValidateUser(username, password)
        Return user IsNot Nothing
    End Function

    #Region "Methods which are no used in this demo"

    Public Overrides Function CreateUser(ByVal username As String, ByVal password As String, ByVal email As String, ByVal passwordQuestion As String, ByVal passwordAnswer As String, ByVal isApproved As Boolean, ByVal providerUserKey As Object, <System.Runtime.InteropServices.Out()> ByRef status As MembershipCreateStatus) As MembershipUser
        Throw New System.NotImplementedException()
    End Function

    Public Overrides Function ChangePasswordQuestionAndAnswer(ByVal username As String, ByVal password As String, ByVal newPasswordQuestion As String, ByVal newPasswordAnswer As String) As Boolean
        Throw New System.NotImplementedException()
    End Function

    Public Overrides Function GetPassword(ByVal username As String, ByVal answer As String) As String
        Throw New System.NotImplementedException()
    End Function

    Public Overrides Function ChangePassword(ByVal username As String, ByVal oldPassword As String, ByVal newPassword As String) As Boolean
        Throw New System.NotImplementedException()
    End Function

    Public Overrides Function ResetPassword(ByVal username As String, ByVal answer As String) As String
        Throw New System.NotImplementedException()
    End Function

    Public Overrides Sub UpdateUser(ByVal user As MembershipUser)
        Throw New System.NotImplementedException()
    End Sub

    Public Overrides Function UnlockUser(ByVal userName As String) As Boolean
        Throw New System.NotImplementedException()
    End Function

    Public Overrides Function GetUser(ByVal providerUserKey As Object, ByVal userIsOnline As Boolean) As MembershipUser
        Throw New System.NotImplementedException()
    End Function

    Public Overrides Function GetUser(ByVal username As String, ByVal userIsOnline As Boolean) As MembershipUser
        Throw New System.NotImplementedException()
    End Function

    Public Overrides Function GetUserNameByEmail(ByVal email As String) As String
        Throw New System.NotImplementedException()
    End Function

    Public Overrides Function DeleteUser(ByVal username As String, ByVal deleteAllRelatedData As Boolean) As Boolean
        Throw New System.NotImplementedException()
    End Function

    Public Overrides Function GetAllUsers(ByVal pageIndex As Integer, ByVal pageSize As Integer, <System.Runtime.InteropServices.Out()> ByRef totalRecords As Integer) As MembershipUserCollection
        Throw New System.NotImplementedException()
    End Function

    Public Overrides Function GetNumberOfUsersOnline() As Integer
        Throw New System.NotImplementedException()
    End Function

    Public Overrides Function FindUsersByName(ByVal usernameToMatch As String, ByVal pageIndex As Integer, ByVal pageSize As Integer, <System.Runtime.InteropServices.Out()> ByRef totalRecords As Integer) As MembershipUserCollection
        Throw New System.NotImplementedException()
    End Function

    Public Overrides Function FindUsersByEmail(ByVal emailToMatch As String, ByVal pageIndex As Integer, ByVal pageSize As Integer, <System.Runtime.InteropServices.Out()> ByRef totalRecords As Integer) As MembershipUserCollection
        Throw New System.NotImplementedException()
    End Function

    Public Overrides ReadOnly Property EnablePasswordRetrieval() As Boolean
        Get
            Throw New System.NotImplementedException()
        End Get
    End Property

    Public Overrides ReadOnly Property EnablePasswordReset() As Boolean
        Get
            Throw New System.NotImplementedException()
        End Get
    End Property

    Public Overrides ReadOnly Property RequiresQuestionAndAnswer() As Boolean
        Get
            Throw New System.NotImplementedException()
        End Get
    End Property

    Public Overrides Property ApplicationName() As String

    Public Overrides ReadOnly Property MaxInvalidPasswordAttempts() As Integer
        Get
            Throw New System.NotImplementedException()
        End Get
    End Property

    Public Overrides ReadOnly Property PasswordAttemptWindow() As Integer
        Get
            Throw New System.NotImplementedException()
        End Get
    End Property

    Public Overrides ReadOnly Property RequiresUniqueEmail() As Boolean
        Get
            Throw New System.NotImplementedException()
        End Get
    End Property

    Public Overrides ReadOnly Property PasswordFormat() As MembershipPasswordFormat
        Get
            Throw New System.NotImplementedException()
        End Get
    End Property

    Public Overrides ReadOnly Property MinRequiredPasswordLength() As Integer
        Get
            Throw New System.NotImplementedException()
        End Get
    End Property

    Public Overrides ReadOnly Property MinRequiredNonAlphanumericCharacters() As Integer
        Get
            Throw New System.NotImplementedException()
        End Get
    End Property

    Public Overrides ReadOnly Property PasswordStrengthRegularExpression() As String
        Get
            Throw New System.NotImplementedException()
        End Get
    End Property

    #End Region ' Methods which are no used in this demo
End Class

Public Class DocumentsRoleProvider
    Inherits RoleProvider

    Private Const DefaultRole As String = "User"

    Public Overrides Function GetRolesForUser(ByVal username As String) As String()
        Dim user As User = DocumentsApp.Instance.Data.FindUserByAccountName(username)
        Return If(user Is Nothing, New String() { }, New String() { DefaultRole })
    End Function

    Public Overrides Property ApplicationName() As String

    #Region "Not used methods"

    Public Overrides Function IsUserInRole(ByVal username As String, ByVal roleName As String) As Boolean
        Throw New System.NotImplementedException()
    End Function


    Public Overrides Sub CreateRole(ByVal roleName As String)
        Throw New System.NotImplementedException()
    End Sub

    Public Overrides Function DeleteRole(ByVal roleName As String, ByVal throwOnPopulatedRole As Boolean) As Boolean
        Throw New System.NotImplementedException()
    End Function

    Public Overrides Function RoleExists(ByVal roleName As String) As Boolean
        Throw New System.NotImplementedException()
    End Function

    Public Overrides Sub AddUsersToRoles(ByVal usernames() As String, ByVal roleNames() As String)
        Throw New System.NotImplementedException()
    End Sub

    Public Overrides Sub RemoveUsersFromRoles(ByVal usernames() As String, ByVal roleNames() As String)
        Throw New System.NotImplementedException()
    End Sub

    Public Overrides Function GetUsersInRole(ByVal roleName As String) As String()
        Throw New System.NotImplementedException()
    End Function

    Public Overrides Function GetAllRoles() As String()
        Throw New System.NotImplementedException()
    End Function

    Public Overrides Function FindUsersInRole(ByVal roleName As String, ByVal usernameToMatch As String) As String()
        Throw New System.NotImplementedException()
    End Function

    #End Region
End Class
