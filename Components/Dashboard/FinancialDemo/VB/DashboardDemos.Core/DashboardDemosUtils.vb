Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Configuration
Imports System.Data
Imports System.Data.Linq
Imports System.Data.SqlClient
Imports System.Globalization
Imports System.IO
Imports System.Linq
Imports System.Windows.Forms
Imports DevExpress.DemoData.Helpers
Imports DevExpress.Utils
Imports DevExpress.XtraEditors
Imports DevExpress.XtraSplashScreen
Imports Microsoft.Win32

Namespace DashboardDemos.Core
	Public Class SqlServerNotFoundException
		Inherits Exception
		Public Sub New(ByVal ex As Exception)
			MyBase.New(ex.Message, ex)
		End Sub
	End Class
	Public Class DatabaseCreatingException
		Inherits Exception
		Public Sub New(ByVal ex As Exception)
			MyBase.New(ex.Message, ex)
		End Sub
	End Class
	Public Class DashboardInfo
		Public Property Id() As Integer
		Public Property Name() As String
		Public Property XmlFileName() As String
		Public Overrides Function ToString() As String
			Return Name
		End Function
	End Class
	Public Class DatabaseInfo
		Public Property Id() As Integer
		Public Property RequiredVersion() As Integer
		Public Property Name() As String
		Public Property ConnectionString() As String
		Public Property SqlScriptFile() As String
		Public Property FillAction() As Action(Of String,String, IDbConnection)

		Public Sub New(ByVal action As Action(Of String, String, IDbConnection))
			FillAction = action
		End Sub

		Public Overrides Function ToString() As String
			Return Name
		End Function
	End Class
	Public NotInheritable Class DashboardDemosUtils
		Private Sub New()
		End Sub
		Private Shared Function AllDatabases(ParamArray ByVal connectionStrings() As String) As DatabaseInfo()
			Return New DatabaseInfo() { New DatabaseInfo (AddressOf FillDashboardDatabase) With {.Id = 1, .Name = "DashboardStorage", .ConnectionString = connectionStrings(0), .SqlScriptFile ="DashboardDemo.sql", .RequiredVersion = 3}, New DatabaseInfo(AddressOf FillFinanceDatabase) With {.Id = 2, .Name = "FinancialDemo", .ConnectionString = connectionStrings(1), .SqlScriptFile= "FinancialDemo.sql", .RequiredVersion = 1} }
		End Function

		Private ReadOnly Shared lockObj As Object = New Object()
		Private Shared databaseCreationCurrentStep_Renamed As Integer
		Private Shared databaseCreationMaxStep_Renamed As Integer

		Public Shared Property DatabaseCreationMaxStep() As Integer
			Get
				Return databaseCreationMaxStep_Renamed
			End Get
			Set(ByVal value As Integer)
				databaseCreationMaxStep_Renamed = value
			End Set
		End Property
		Public Shared Property DatabaseCreationCurrentStep() As Integer
			Get
				SyncLock lockObj
					Return databaseCreationCurrentStep_Renamed
				End SyncLock
			End Get
			Private Set(ByVal value As Integer)
				SyncLock lockObj
					databaseCreationCurrentStep_Renamed = value
				End SyncLock
			End Set
		End Property
		Public Shared ReadOnly Property DashboardStorageConnectionString() As String
			Get
				Dim connectionString As String = ConfigurationManager.ConnectionStrings("DashboardStorageConnectionString").ToString()
				Return CheckAndApplyDefaultServerName(connectionString)
			End Get
		End Property
		Public Shared ReadOnly Property FinancialDemoConnectionString() As String
			Get
				Dim connectionString As String = ConfigurationManager.ConnectionStrings("FinanceDemoConnectionString").ToString()
				Return CheckAndApplyDefaultServerName(connectionString)
			End Get
		End Property
		Public Shared ReadOnly Property CorporateDemoConnectionString() As String
			Get
				Dim connectionString As String = ConfigurationManager.ConnectionStrings("CorporateDemoConnectionString").ToString()
				Return CheckAndApplyDefaultServerName(connectionString)
			End Get
		End Property
		Public Shared Sub IncrementDatabaseCreationState()
			SyncLock lockObj
				databaseCreationCurrentStep_Renamed += 1
			End SyncLock
		End Sub

		Public Shared Function GetDashboardStream(ByVal connectionString As String, ByVal dashboardId As Integer) As MemoryStream
			Using db As New DashboardDemosDataContext(connectionString)
				Dim stream = ( _
						From t In db.Dashboards _
						Where t.ID = dashboardId _
						Select t.DashboardStream).First()
				Dim dashboardArray() As Byte = stream.ToArray()
				Dim ms As New MemoryStream(dashboardArray)
				ms.Seek(0, SeekOrigin.Begin)
				Return ms
			End Using
		End Function
		Public Shared Sub SaveDashboardStream(ByVal connectionString As String, ByVal ms As MemoryStream, ByVal dashboardId As Integer)
			Using db As New DashboardDemosDataContext(connectionString)
				Dim storedDashboard As Dashboards = ( _
						From t In db.Dashboards _
						Where t.ID = dashboardId _
						Select t).First()
				ms.Seek(0, SeekOrigin.Begin)
				storedDashboard.DashboardStream = New Binary(ms.ToArray())
				db.SubmitChanges()
			End Using
		End Sub
		Public Shared Function ShouldRecreateDatabases(ByVal databasesToCreate As List(Of DatabaseInfo)) As Boolean
			Dim databases As New List(Of DatabaseInfo)()
			For Each info As DatabaseInfo In AllDatabases(DashboardStorageConnectionString, FinancialDemoConnectionString)
				If ShouldRecreateDatabase(info) Then
					databases.Add(info)
				End If
			Next info

			If databasesToCreate IsNot Nothing Then
				databasesToCreate.Clear()
				databasesToCreate.AddRange(databases)
			End If
			DatabaseCreationMaxStep = databases.Count * 3
			Return databases.Count > 0
		End Function
		Public Shared Function ShouldRecreateDatabase(ByVal databaseInfo As DatabaseInfo) As Boolean
			Dim sb As New SqlConnectionStringBuilder(databaseInfo.ConnectionString)
			Dim databaseName As String = sb.InitialCatalog
			sb.InitialCatalog = ""
			Using cn As New SqlConnection(sb.ConnectionString)
				Try
					cn.Open()
					Dim databaseExists As Boolean = CheckIsDatabaseExist(cn, databaseName)
					Dim dataBaseVersion As Integer = GetDatabaseVersion(cn, databaseName)
					If (Not databaseExists) OrElse dataBaseVersion < databaseInfo.RequiredVersion Then
						Return True
					End If
				Catch ex As SqlException
					Throw New SqlServerNotFoundException(ex)
				Finally
					cn.Close()
				End Try
			End Using
			Return False
		End Function
		Public Shared Function CreateDatabasesWin(ParamArray ByVal connectionStrings() As String) As Boolean
			Dim dashboardStorageConnectionString As String = connectionStrings(0)
			Dim databasesToCreate As New List(Of DatabaseInfo)()
			Dim serverName As String = GetServerName(dashboardStorageConnectionString)
			Try
				If ShouldRecreateDatabases(databasesToCreate) Then
					If XtraMessageBox.Show(String.Format("Do you wish to create sample databases?" & Constants.vbCrLf & "They will be created on the {0} server. To change the server, answer 'No', specify the server name within connection strings in the connections.config file, and run the demo again.", serverName), "Financial Dashboard", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
						SplashScreenManager.ShowForm(GetType(CreateDatabaseWaitForm))
						Try
							DashboardDemosUtils.CreateDatabases(AppDomain.CurrentDomain.BaseDirectory, "Data", databasesToCreate)
						Finally
							SplashScreenManager.CloseForm()
						End Try
						Return True
					End If
					Return False
				End If
				Return True
			Catch ex As Exception
				Using form As New ErrorForm(serverName, ex)
					form.ShowDialog()
					Return False
				End Using
			End Try
		End Function

		Public Shared Sub CreateDatabasesWeb(ByVal dataFolder As String, ParamArray ByVal connectionStrings() As String)
			Dim databasesToCreate As List(Of DatabaseInfo) = AllDatabases(connectionStrings).Where(Function(db) ShouldRecreateDatabase(db)).ToList()
			If databasesToCreate.Count > 0 Then
				DashboardDemosUtils.CreateDatabases(dataFolder, "App_Data", databasesToCreate)
			End If
		End Sub
		Public Shared Sub CreateDatabases(ByVal rootFolder As String, ByVal dataFolder As String, ByVal databasesToCreate As List(Of DatabaseInfo))
			For Each databaseInfo In databasesToCreate
				Dim dashboardStorageStringBuilder As New SqlConnectionStringBuilder(databaseInfo.ConnectionString)
				Dim databaseName As String = dashboardStorageStringBuilder.InitialCatalog
				dashboardStorageStringBuilder.InitialCatalog = ""
				Using cn As New SqlConnection(dashboardStorageStringBuilder.ConnectionString)
					Try
						cn.Open()
						IncrementDatabaseCreationState()
						If CheckIsDatabaseExist(cn, databaseName) Then
							DropDatabase(cn, databaseName)
						End If
						ExecuteCommand(cn, String.Format("create database [{0}]", databaseName))
						ExecuteCommand(cn, String.Format("Use [{0}]", databaseName))
						ExecuteScript(cn, FilesHelper.FindingFileName(rootFolder, String.Format("{0}\{1}", dataFolder, databaseInfo.SqlScriptFile), False))
						ExecuteCommand(cn, String.Format("insert into [dbo].[Info]  values( {0})", databaseInfo.RequiredVersion))
						IncrementDatabaseCreationState()
						Dim action = databaseInfo.FillAction
						action(rootFolder, dataFolder, cn)
						IncrementDatabaseCreationState()
					Catch ex As SqlException
						Throw New DatabaseCreatingException(ex)
					Finally
						cn.Close()
					End Try
				End Using
			Next databaseInfo

		End Sub
		Public Shared Function CreateConnectionString(ByVal serverName As String, ByVal userName As String, ByVal password As String, ByVal useWindowsAuth As Boolean) As String
			Dim connectionString As String
			If useWindowsAuth Then
				connectionString = String.Format("Data Source={0};Integrated Security=True", serverName)
			Else
				connectionString = String.Format("Data Source={0};User ID={1};Password={2}", serverName, userName, password)
			End If
			Return connectionString
		End Function
		Private Shared Function CheckAndApplyDefaultServerName(ByVal connectionString As String) As String
			Dim sb As New SqlConnectionStringBuilder(connectionString)
			Dim serverName As String = sb.DataSource
			If String.IsNullOrEmpty(serverName) Then
				serverName = DbEngineDetector.GetSqlServerInstanceName()
				If (Not String.IsNullOrEmpty(serverName)) Then
					sb.DataSource = serverName
					Return sb.ConnectionString
				End If
				Return String.Empty
			End If
			Return connectionString
		End Function
		Private Shared Function GetServerName(ByVal connectionString As String) As String
			Dim sb As New SqlConnectionStringBuilder(connectionString)
			Return sb.DataSource
		End Function
		Private Shared Sub FillDashboardDatabase(ByVal rootFolder As String, ByVal dataFolder As String, ByVal connection As IDbConnection)
			Dim dashboardInfos() As DashboardInfo = { New DashboardInfo() With {.Id = 1, .Name ="Finance Dashboard", .XmlFileName ="FinancialDashboard.xml"} }
			Using db As New DashboardDemosDataContext(connection)
				For Each dashboardInfo In dashboardInfos
					Dim dashboardData() As Byte = File.ReadAllBytes(FilesHelper.FindingFileName(rootFolder, String.Format("{0}\{1}", dataFolder, dashboardInfo.XmlFileName), False))
					db.Dashboards.InsertOnSubmit(New Dashboards() With {.ID = dashboardInfo.Id, .Name = dashboardInfo.Name, .DashboardStream = dashboardData})
				Next dashboardInfo
				db.SubmitChanges()
			End Using
		End Sub
		Private Shared Sub FillFinanceDatabase(ByVal rootFolder As String, ByVal dataFolder As String, ByVal connection As IDbConnection)
			Using dc As New FinancialDemoDataContext(connection)
				dc.CommandTimeout = 0
				Using sr As New StreamReader(FilesHelper.FindingFileName(rootFolder, String.Format("{0}\FinancialDemoDailyData.csv", dataFolder), False))
					Dim fi As New NumberFormatInfo()
					fi.NumberDecimalSeparator = "."
					Dim line As String = sr.ReadLine()
					Do While line IsNot Nothing
						Dim columns() As String = line.Split(ControlChars.Tab)
						Dim dateTime As DateTime = DateTime.ParseExact(columns(0), "yyyy-MM-dd", CultureInfo.InvariantCulture)
						Dim open As Double = Double.Parse(columns(1), fi)
						Dim high As Double = Double.Parse(columns(2), fi)
						Dim low As Double = Double.Parse(columns(3), fi)
						Dim close As Double = Double.Parse(columns(4), fi)
						Dim volume As Integer = Int32.Parse(columns(5))
						Dim ticker As String = columns(6)
						dc.DailyDatas.InsertOnSubmit(New DailyData() With {.Date = dateTime, .Open = open, .High = high, .Low = low, .Close = close, .Volume = volume, .Ticker = ticker})
						line = sr.ReadLine()
					Loop
					dc.SubmitChanges()
					dc.UpdateHistoricalData()
					dc.CalculateProfitLoss()
				End Using
			End Using
		End Sub
		Private Shared Sub DropDatabase(ByVal cn As SqlConnection, ByVal databaseName As String)
			ExecuteCommand(cn, "USE [master]")
			Dim sql As String = String.Format("ALTER DATABASE [{0}] SET SINGLE_USER WITH ROLLBACK IMMEDIATE", databaseName)
			ExecuteCommand(cn, sql)
			sql = String.Format("drop database [{0}]", databaseName)
			ExecuteCommand(cn, sql)
		End Sub
		Private Shared Function GetDatabaseVersion(ByVal cn As SqlConnection, ByVal databaseName As String) As Integer
			Dim sql As String = String.Format("select DataVersion from {0}.dbo.Info", databaseName)
			Using cmd As New SqlCommand(sql, cn) With {.CommandType = CommandType.Text}
				Try
					Using dataReader As SqlDataReader = cmd.ExecuteReader()
						Try
							If dataReader.Read() Then
								Return CInt(Fix(dataReader(0)))
							End If
						Finally
							dataReader.Close()
						End Try
					End Using
				Catch
				End Try
			End Using
			Return 0
		End Function
		Private Shared Function CheckIsDatabaseExist(ByVal cn As SqlConnection, ByVal databaseName As String) As Boolean
			Dim sql As String = "SELECT name FROM master.sys.databases WHERE name NOT IN ('master', 'tempdb', 'model', 'msdb')"
			Using cmd As New SqlCommand(sql, cn) With {.CommandType = CommandType.Text}
				Using dataReader As SqlDataReader = cmd.ExecuteReader()
					Try
						Do While dataReader.Read()
							If dataReader(0).ToString() = databaseName Then
								Return True
							End If
						Loop
					Catch e1 As SqlException
						Return False
					Finally
						dataReader.Close()
					End Try
				End Using
			End Using
			Return False
		End Function
		Private Shared Sub ExecuteScript(ByVal cn As SqlConnection, ByVal fileName As String)
			Dim sql As String = Nothing
			Using sr As New StreamReader(fileName)
				sql = sr.ReadToEnd()
			End Using
			Dim batches() As String = sql.Split(New String() { "GO" & Constants.vbCrLf & Constants.vbCrLf }, StringSplitOptions.None)
			For Each batch As String In batches
				ExecuteCommand(cn, batch)
			Next batch
		End Sub
		Private Shared Sub ExecuteCommand(ByVal cn As SqlConnection, ByVal sql As String)
			If (Not String.IsNullOrEmpty(sql)) Then
				Using command As New SqlCommand(sql, cn)
					command.CommandType = CommandType.Text
					command.ExecuteNonQuery()
				End Using
			End If
		End Sub
	End Class
End Namespace
