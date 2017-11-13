Imports DevExpress.DemoData.Models
Imports DevExpress.Mvvm
Imports DevExpress.Mvvm.DataAnnotations
Imports DevExpress.Xpf.Core.DataSources
Imports DevExpress.Xpf.Core.ServerMode
Imports System.Collections.Generic
Imports System.Linq

Namespace GridDemo
    <POCOViewModel>
    Public Class ServerModeLookUpEditViewModel
        Public Overridable Property Orders() As List(Of OrderData)
        Public Overridable Property DataSource() As ListSourceDataSourceBase
        Public Overridable Property IsInstantfeedback() As Boolean

        Protected Sub New()
            Orders = (New OrderDataGenerator(200)).GetOrders()
        End Sub

        Public Sub OnLoaded()
            If Not ServerModeRecordsGeneratorProviderBase.IsDatabaseExists(ServerModeOptions.SQLConnectionString, ServerModeOptions.PersonTableName) Then
                ShowConnectionWizard("Start Demo")
            End If
            UpdateDataSource()
        End Sub
        Public Sub Configure()
            ShowConnectionWizard("Return")
            UpdateDataSource()
        End Sub
        Private Sub ShowConnectionWizard(ByVal demoString As String)
            If DevExpress.Xpf.DemoBase.DemoTesting.DemoTestingHelper.IsTesting Then
                Return
            End If
            Dim window As New SQLConnectionWindow(demoString, New PeopleGeneratorProvider()) With {.Description = ServerModeOptions.GetLookUpDescription()}
            If System.Windows.Application.Current IsNot Nothing Then
                window.Owner = System.Windows.Application.Current.MainWindow
            End If
            window.ShowDialog()
            ServerModeOptions.SQLConnectionString = window.GetDataBaseConnectionString()
        End Sub

        Private Sub UpdateDataSource()
            Dim count As Integer = (New PeopleGeneratorProvider()).CalcRecordCount(ServerModeOptions.SQLConnectionString)
            If count > 0 AndAlso Orders IsNot Nothing AndAlso count < Orders.Count Then
                Orders = (New OrderDataGenerator(count)).GetOrders()
            End If
            Dispose()
            Dim queryable As IQueryable = If(ServerModeOptions.IsCorrectConnection, (New Controls.PersonDataContext(ServerModeOptions.SQLConnectionString)).Person, Nothing)

            Dim dataSource_Renamed As ListSourceDataSourceBase
            If IsInstantfeedback Then
                dataSource_Renamed = New LinqInstantFeedbackDataSource() With {.KeyExpression = "PersonID", .QueryableSource = queryable}
            Else
                dataSource_Renamed = New LinqServerModeDataSource() With {.KeyExpression = "PersonID", .QueryableSource = queryable}
            End If
            DataSource = dataSource_Renamed
        End Sub
        Protected Overridable Sub OnIsInstantfeedbackChanged()
            UpdateDataSource()
        End Sub

        Public Sub Dispose()
            If TypeOf DataSource Is LinqInstantFeedbackDataSource Then
                CType(DataSource, LinqInstantFeedbackDataSource).Dispose()
            End If
        End Sub
    End Class
End Namespace
