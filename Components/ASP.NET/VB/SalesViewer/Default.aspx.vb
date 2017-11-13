Imports System
Imports System.Web.UI.WebControls
Imports DevExpress.Web
Imports DevExpress.Web.Internal

Partial Public Class _Default
    Inherits BasePage

    Protected Overrides ReadOnly Property IsPopulateDatabasePage() As Boolean
        Get
            Return True
        End Get
    End Property

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
        ' The settings are defined in the Page_Load event to override ASPxProgressBar skin's settings specified in the MetropolisBlue theme
        Progress.ShowPosition = True
        Progress.Height = Unit.Pixel(32)
    End Sub

    Protected Sub Callback_Callback(ByVal source As Object, ByVal e As CallbackEventArgs)
        e.Result = HtmlConvertor.ToJSON(GetCallbackResult(e.Parameter))
    End Sub
    Private Function GetCallbackResult(ByVal parameter As String) As Object
        If parameter = "create" Then
            If Not IsDatabasePopulating Then
                IsDatabasePopulating = True
                Try
                    DataContext.SalesDataContext.PopulateDatabaseIfNecessary()
                    IsDatabasePopulated = True
                Catch e As Exception
                    Return e.Message
                Finally
                    IsDatabasePopulating = False
                End Try
                Return True
            Else
                Return False
            End If
        ElseIf parameter = "progress" Then
            Return If((Not IsDatabasePopulated), DataContext.SalesDataContext.DatabasePopulatingProgressPercentValue, -1)
        End If
        Throw New ArgumentException("Wrong parameter")
    End Function
End Class
