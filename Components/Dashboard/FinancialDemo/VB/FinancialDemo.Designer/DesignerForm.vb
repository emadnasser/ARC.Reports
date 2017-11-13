Imports Microsoft.VisualBasic
Imports System
Imports System.IO
Imports System.Windows.Forms
Imports DashboardDemos.Core
Imports DevExpress.DashboardCommon
Imports DevExpress.DashboardWin
Imports DevExpress.DataAccess.Sql
Imports DevExpress.DataAccess.ConnectionParameters
Imports DevExpress.XtraBars.Ribbon
Imports DevExpress.XtraEditors

Namespace FinancialDemo.Designer
	Partial Public Class DesignerForm
		Inherits RibbonForm
		Private Const dashboardId As Integer = 1
		Private dashboardStorageConnectionString, financialDemoConnectionString, corporateDemoConnectionString As String

		Public Property Dashboard() As Dashboard
			Get
				Return dashboardDesigner1.Dashboard
			End Get
			Set(ByVal value As Dashboard)
				dashboardDesigner1.Dashboard = value
			End Set
		End Property
		Public Sub New()
			InitializeComponent()
			AddHandler dashboardDesigner1.ConfigureDataConnection, AddressOf dashboardDesigner1_ConfigureDataConnection
			AddHandler dashboardDesigner1.DashboardSaving, AddressOf dashboardDesigner1_DashboardSaving


		End Sub
		Private Sub dashboardDesigner1_ConfigureDataConnection(ByVal sender As Object, ByVal e As DashboardConfigureDataConnectionEventArgs)
			If e.ConnectionName = "FinanceDemoConnection" Then
				Dim connectionParameters As New CustomStringConnectionParameters(financialDemoConnectionString)
				e.ConnectionParameters = connectionParameters
			End If
		End Sub
		Private Sub dashboardDesigner1_DashboardSaving(ByVal sender As Object, ByVal e As DashboardSavingEventArgs)
			If e.Command = DashboardSaveCommand.Save Then
				Try
					Using saveStream As New MemoryStream()
						Dashboard.SaveToXml(saveStream)
						DashboardDemosUtils.SaveDashboardStream(dashboardStorageConnectionString, saveStream, dashboardId)
					End Using
					e.Handled = True
				Catch ex As Exception
					XtraMessageBox.Show(ex.Message, "Finance Demo Dashboard Designer", MessageBoxButtons.OK, MessageBoxIcon.Error)
				End Try
			End If
		End Sub
		Private Sub DesignerForm_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			dashboardDesigner1.CreateRibbon()
			dashboardStorageConnectionString = DashboardDemosUtils.DashboardStorageConnectionString
			financialDemoConnectionString = DashboardDemosUtils.FinancialDemoConnectionString
			corporateDemoConnectionString = DashboardDemosUtils.CorporateDemoConnectionString
			If (Not String.IsNullOrEmpty(dashboardStorageConnectionString)) Then
				If DashboardDemosUtils.CreateDatabasesWin(dashboardStorageConnectionString, financialDemoConnectionString,corporateDemoConnectionString) Then
					Dim dashboard As New Dashboard()
					Using ms As MemoryStream = DashboardDemosUtils.GetDashboardStream(dashboardStorageConnectionString, dashboardId)
						dashboard.LoadFromXml(ms)
					End Using
					Me.Dashboard = dashboard
				End If
			Else
				XtraMessageBox.Show("This demo requires SQL Server Express or LocalDB installed to automatically create a sample database. Alternatively, you can manually specify a connection string to the server where the database should be created. You can do this in the connections.config file.")
			End If

		End Sub
	End Class
End Namespace
