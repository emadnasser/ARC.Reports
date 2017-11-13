Imports System
Imports System.Collections.Generic
Imports System.Collections.Concurrent
Imports System.Linq
Imports System.Web
Imports System.Web.Security
Imports DevExpress.Web

Public Class UserService
    Inherits ServiceBase

    Private Const CurrentUserSessionKey As String = "CurrentUser_246CFE91-544D-49A9-BA9D-BCDC4503B4BA"
    Private Const CurrentViewModeCookieKey As String = "CurrentViewMode"
    Public Const DefaultUserAccountName As String = "Ben"

    Private Shared ReadOnly Property Context() As HttpContext
        Get
            Return HttpContext.Current
        End Get
    End Property
    Private Shared ReadOnly ActivityWatchingInterval As TimeSpan = TimeSpan.FromMinutes(1)

    Private ReadOnly Property DataService() As DataService
        Get
            Return DocumentsApp.Data
        End Get
    End Property
    Private ReadOnly Property DocumentService() As DocumentService
        Get
            Return DocumentsApp.Document
        End Get
    End Property

    Private Property ActivityRegistry() As ConcurrentDictionary(Of String, DateTime)

    Public Property CurrentUser() As User
        Get
            Dim accountName As String = GetCurrentUserAccountName()
            If accountName Is Nothing Then
                Context.Session(CurrentUserSessionKey) = Nothing
                Return Nothing
            End If

            Dim user As User = TryCast(Context.Session(CurrentUserSessionKey), User)
            If user Is Nothing OrElse user.AccountName <> accountName Then
                user = GetCurrentUser()
                Context.Session(CurrentUserSessionKey) = user
            End If

            Return user
        End Get
        Private Set(ByVal value As User)
            Context.Session(CurrentUserSessionKey) = value
        End Set
    End Property
    Public ReadOnly Property CurrentViewModeName() As String
        Get
            Dim cookie As HttpCookie = Context.Request.Cookies(CurrentViewModeCookieKey)
            If cookie Is Nothing Then
                Return Nothing
            End If
            Return HttpUtility.UrlDecode(cookie.Value)
        End Get
    End Property

    Public Sub New(ByVal app As DocumentsApp)
        MyBase.New(app)
        ActivityRegistry = New ConcurrentDictionary(Of String, DateTime)()
    End Sub

    Public Function SignIn(ByVal userAccountName As String, ByVal userPassword As String) As Boolean
        If String.IsNullOrEmpty(userPassword) Then
            userPassword = Nothing
        End If
        If Membership.ValidateUser(userAccountName, userPassword) Then
            FormsAuthentication.SetAuthCookie(userAccountName, False)
            FormsAuthentication.RedirectFromLoginPage(userAccountName, False)
            Return True
        End If
        Return False
    End Function
    Public Sub SignOut()
        DocumentService.RemoveAllLocksForUser(CurrentUser)
        FormsAuthentication.SignOut()
        CurrentUser = Nothing
        FormsAuthentication.RedirectToLoginPage()
    End Sub
    Public Function ValidateUser(ByVal accountName As String, ByVal password As String) As User
        Return DataService.Users.FirstOrDefault(Function(user) user.AccountName = accountName AndAlso user.Password = password)
    End Function
    Public Sub LogUserActivity()
        Dim accountName As String = GetCurrentUserAccountName()
        If accountName IsNot Nothing Then
            ActivityRegistry.AddOrUpdate(accountName, Date.Now, Function(name, oldDate) Date.Now)
        End If
    End Sub
    Public Sub CheckActivityWithDelay()
        CommonUtils.ExecuteActionWithDelay(Sub() OnDelayedActivityChecking(), ActivityWatchingInterval)
    End Sub

    Private Function GetCurrentUser() As User
        Dim accountName As String = GetCurrentUserAccountName()
        If accountName Is Nothing Then
            Return Nothing
        End If
        Return DataService.FindUserByAccountName(accountName)
    End Function
    Private Function GetCurrentUserAccountName() As String
        If Context.User IsNot Nothing AndAlso Context.User.Identity.IsAuthenticated Then
            Return Context.User.Identity.Name
        End If
        Return Nothing
    End Function
    Private Sub OnDelayedActivityChecking()
        Try
            CheckActivity()
        Finally
            CheckActivityWithDelay()
            DataService.CloseUnitOfWork()
        End Try
    End Sub
    Private Sub CheckActivity()
        Dim userInfoList = ActivityRegistry.Select(Function(entry) New With {Key .AccountName = entry.Key, Key .LastActivityDate = entry.Value}).ToList()

        Dim timeLowerBoundary As Date = Date.UtcNow.Subtract(FormsAuthentication.Timeout)
        For Each userInfo In userInfoList
            Dim activityDate As Date = Nothing
            If userInfo.LastActivityDate.ToUniversalTime() < timeLowerBoundary Then
                ActivityRegistry.TryRemove(userInfo.AccountName, activityDate)
                Dim user As User = DataService.FindUserByAccountName(userInfo.AccountName)
                DocumentService.RemoveAllLocksForUser(user)
            End If
        Next userInfo
    End Sub
End Class
