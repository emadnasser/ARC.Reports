Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports DataAccess

Public Class BasePage
    Inherits System.Web.UI.Page

    Protected Const CreateDatabasePageUrl As String = "~/" ' i.e. default.aspx
    Protected Const StartPage As String = "~/RevenueBySector.aspx"

    Private Shared fIsDatabasePopulated? As Boolean = Nothing
    Public Shared Property IsDatabasePopulated() As Boolean
        Get
            If Not fIsDatabasePopulated.HasValue Then
                fIsDatabasePopulated = DataContext.SalesDataContext.IsDatabasePopulated()
            End If
            Return fIsDatabasePopulated = True
        End Get
        Set(ByVal value As Boolean)
            fIsDatabasePopulated = value
        End Set
    End Property
    Public Shared Property IsDatabasePopulating() As Boolean

    Protected Overridable ReadOnly Property IsPopulateDatabasePage() As Boolean
        Get
            Return False
        End Get
    End Property

    Private fSalesProvider As SalesProvider
    Protected Friend ReadOnly Property SalesProvider() As SalesProvider
        Get
            If fSalesProvider Is Nothing Then
                fSalesProvider = New SalesProvider()
            End If
            Return fSalesProvider
        End Get
    End Property

    Protected Overrides Sub OnPreInit(ByVal e As EventArgs)
        MyBase.OnPreInit(e)
        ' Populate Database if necessary
        If Not IsCallback Then
            If Not IsDatabasePopulated Then
                If Not IsPopulateDatabasePage Then
                    Response.Redirect(CreateDatabasePageUrl)
                End If
            ElseIf IsPopulateDatabasePage Then
                Response.Redirect(StartPage)
            End If
        End If
    End Sub

    Protected Overrides Sub OnUnload(ByVal e As EventArgs)
        MyBase.OnUnload(e)
        If SalesProvider IsNot Nothing Then
            SalesProvider.Dispose()
        End If
    End Sub

    Public Overridable ReadOnly Property RangeControl() As IRangeControl
        Get
            Return Nothing
        End Get
    End Property

    Public ReadOnly Property SalesStartDate() As Date
        Get
            Return If(RangeControl IsNot Nothing, RangeControl.GetStartDate(), Date.MinValue)
        End Get
    End Property
    Public ReadOnly Property SalesEndDate() As Date
        Get
            Return If(RangeControl IsNot Nothing, RangeControl.GetEndDate(), Date.MaxValue)
        End Get
    End Property
End Class
