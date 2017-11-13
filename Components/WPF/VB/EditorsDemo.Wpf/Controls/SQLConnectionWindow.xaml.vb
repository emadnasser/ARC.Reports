Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Data
Imports System.Windows.Documents
Imports System.Windows.Input
Imports System.Windows.Media
Imports System.Windows.Media.Imaging
Imports System.Windows.Shapes
Imports System.Xml
Imports DevExpress.Data.Filtering
Imports System.Data.SqlClient
Imports System.Data
Imports System.Windows.Threading
Imports System.Threading
Imports GridDemo.Controls
Imports DevExpress.Xpf.Editors
Imports DevExpress.Xpf.Core
Imports DevExpress.DemoData.Helpers
Imports System.Data.Linq

Namespace GridDemo
    Public NotInheritable Class ServerModeOptions

        Private Sub New()
        End Sub

        Public Shared IsCorrectConnection As Boolean
        Public Shared SQLConnectionString As String = String.Empty
        Public Shared failedConnection As String = "Failed to connect to the server."
        Public Shared failedConnectionCaption As String = "Connection Error"
        Public Shared dataAdding As String = "Adding next portion of data..."
        Public Shared recordCount As String = "Current record count = {0}"
        Private Shared descriptionSQLConnection As String = "This demo illustrates the capabilities of the {0} that are bound to a large amount of data. In this demo the {1} to be connected to a data table on an MS SQL server. Please use this Configuration Window to configure data and connection settings." & ControlChars.CrLf & ControlChars.CrLf & "On the first run:" & ControlChars.CrLf & "1) Specify the name of an existing SQL Server, which will contain the target database;" & ControlChars.CrLf & "2) Specify the amount of records in the target table and click the ""Generate Table and Start Demo"" button. A new table will be generated and the demo will start with the {2} bound to the generated recordset." & ControlChars.CrLf & ControlChars.CrLf & "On subsequent runs, you can add more records to the database or just start the demo without generating additional data."
        Public Shared Function GetGridDescription() As String
            Return String.Format(descriptionSQLConnection, "DXGrid control", "DXGrid control needs", "DXGrid control")
        End Function
        Public Shared Function GetComboBoxDescription() As String
            Return String.Format(descriptionSQLConnection, "ComboBoxEdit, LookUpEdit and ListBoxEdit controls", "editors need", "editors")
        End Function
        Public Shared Function GetLookUpDescription() As String
            Return String.Format(descriptionSQLConnection, "LookUpEdit control", "LookUpEdit control needs", "LookUpEdit control")
        End Function

        Public Shared ReadOnly Property PersonTableName() As String
            Get
                Return GetType(Controls.Person).Name
            End Get
        End Property
        Public Shared ReadOnly Property OutlookTableName() As String
            Get
                Return GetType(WpfServerSideGridTest).Name
            End Get
        End Property
    End Class
    Partial Public Class SQLConnectionWindow
        Inherits DXWindow

        Private defaultDB As String = "DXGridServerModeDB"
        Private serverParameters As String = "SQLParameters.xml"
        Public ReadOnly Property ConnectionStringParameters() As String
            Get
                Return String.Format("{0};{1};{2};{3}", tbServer.Text,If(rbWindowsAuthentication.IsChecked.Value, 0, 1), tbLogin.Text, tbPassword.Text)
            End Get
        End Property
        Public ReadOnly Property RecordCount() As Integer
            Get
                Dim count As Integer = Convert.ToInt32(tbRecords.EditValue)
                Return If(count >= 0, count, 0)
            End Get
        End Property
        Public ReadOnly Property ProgressBar() As ProgressBar
            Get
                Return progressBarCore
            End Get
        End Property
        Public Property Description() As String
            Get
                Return tbDescription.Text
            End Get
            Set(ByVal value As String)
                tbDescription.Text = value
            End Set
        End Property

        Private generatorProvider As ServerModeRecordsGeneratorProviderBase

        Public Sub New(ByVal demoString As String)
            Me.New(demoString, Nothing)
        End Sub
        Public Sub New(ByVal demoString As String, ByVal provider As ServerModeRecordsGeneratorProviderBase)
            InitializeComponent()
            generatorProvider = If(provider, CreateDefaultProvider())
            tbServer.Text = DbEngineDetector.GetSqlServerInstanceName()
            AddHandler rbWindowsAuthentication.Checked, AddressOf radioGroup1_SelectedIndexChanged
            AddHandler rbWindowsAuthentication.Unchecked, AddressOf radioGroup1_SelectedIndexChanged
            AddHandler cbDatabase.EditValueChanged, AddressOf cbDatabase_EditValueChanged
            AddHandler tbServer.EditValueChanged, AddressOf teServer_EditValueChanged
            AddHandler bGenerateDB.Click, AddressOf sbGenerateDB_Click
            AddHandler bAddRecords.Click, AddressOf sbAddRecords_Click
            AddHandler bExit.Click, AddressOf sbExit_Click
            UpdateAuthenticationFields()
            UpdateGenerateDBButton()
            UpdateDatabaseTextEdit()

            cbDatabase.Text = defaultDB
            bAddRecords.Content = CStr(bAddRecords.Content) & demoString
            bGenerateDB.Content = CStr(bGenerateDB.Content) & demoString
            bExit.Content = CStr(bExit.Content) & demoString
            ShowParameters()
        End Sub
        Private Function CreateDefaultProvider() As ServerModeRecordsGeneratorProviderBase
            Return New OutlookGeneratorProvider()
        End Function

        Private Sub cbDatabase_EditValueChanged(ByVal sender As Object, ByVal e As EditValueChangedEventArgs)
            UpdateGenerateDBButton()
        End Sub

        Private Sub ShowParameters()
            If Not System.IO.File.Exists(serverParameters) Then
                Return
            End If
            bExit.IsEnabled = True
            Dim doc As New XmlDocument()
            Try
                doc.Load(serverParameters)
            Catch
            End Try
            If doc.DocumentElement.Name = "Parameters" Then
                Dim prm() As String = doc.DocumentElement.InnerText.Split(New Char() { ";"c })
                tbServer.Text = prm(0)
                rbWindowsAuthentication.IsChecked = Convert.ToInt32(prm(1)) = 0
                rbSQLServerAuthentication.IsChecked = Not rbWindowsAuthentication.IsChecked.Value
                tbLogin.Text = prm(2)
                tbPassword.Text = prm(3)
            End If
            CheckRecords()
        End Sub
        Private Sub CheckRecords()
            Dim num As Integer = generatorProvider.CalcRecordCount(GetDataBaseConnectionString())
            If num > 0 Then
                bAddRecords.IsEnabled = True
                lRecords.Content = String.Format(ServerModeOptions.recordCount, num)
            End If
        End Sub
        Public Function GetDataBaseConnectionString() As String
            Dim connectionString As String = GetServerConnectionString()
            Return connectionString & ";initial catalog=" & cbDatabase.Text
        End Function
        Private Function GetServerConnectionString() As String
            Dim connectionString As String = String.Format("data source={0};integrated security=SSPI", tbServer.Text)
            If Not rbWindowsAuthentication.IsChecked.Value Then
                connectionString = String.Format("data source={0};user id={1};password={2}", tbServer.Text, tbLogin.Text, tbPassword.Text)
            End If
            Return connectionString
        End Function
        Private Sub radioGroup1_SelectedIndexChanged(ByVal sender As Object, ByVal e As RoutedEventArgs)
            UpdateAuthenticationFields()
        End Sub
        Private Sub UpdateAuthenticationFields()
            Dim disable As Boolean = rbWindowsAuthentication.IsChecked.Value
            DisableSQLServerAuthentication(disable)
        End Sub
        Private Sub DisableSQLServerAuthentication(ByVal disable As Boolean)
            tbLogin.IsEnabled = Not disable
            tbPassword.IsEnabled = Not disable
        End Sub
        Private Sub UpdateGenerateDBButton()
            bGenerateDB.IsEnabled = cbDatabase.Text = defaultDB
        End Sub
        Private Sub teServer_EditValueChanged(ByVal sender As Object, ByVal e As EditValueChangedEventArgs)
            UpdateDatabaseTextEdit()
        End Sub
        Private Sub UpdateDatabaseTextEdit()
            cbDatabase.Text = defaultDB
        End Sub
        Private Sub sbGenerateDB_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
            GenerateRecords(True)
        End Sub
        Private Sub sbAddRecords_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
            GenerateRecords(False)
        End Sub
        Private Sub GenerateRecords(ByVal clearRecords As Boolean)
            If Not CorrectConnection(GetServerConnectionString()) Then
                Return
            End If
            generatorProvider.Create(Me, clearRecords).GenerateRecords()
        End Sub
        Private Sub sbExit_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
            CloseForm()
        End Sub
        Friend Sub CloseForm()
            If Not CorrectConnection(GetServerConnectionString()) Then
                Return
            End If
            Try
                Using tw As New XmlTextWriter(serverParameters, System.Text.Encoding.UTF8)
                    tw.WriteElementString("Parameters", ConnectionStringParameters)
                End Using
            Catch
            End Try
            Me.Close()
        End Sub
        Private Function CorrectConnection(ByVal serverConnectionString As String) As Boolean
            Dim cur As Cursor = Me.Cursor
            Me.Cursor = Cursors.Wait
            Using connection As New SqlConnection(serverConnectionString)
                Try
                    connection.Open()
                    connection.Close()
                Catch
                    MessageBox.Show(ServerModeOptions.failedConnection, ServerModeOptions.failedConnectionCaption, MessageBoxButton.OK, MessageBoxImage.Error)
                    ServerModeOptions.IsCorrectConnection = False
                    Return False

                Finally
                    Me.Cursor = cur
                End Try
            End Using
            ServerModeOptions.IsCorrectConnection = True
            Return True
        End Function
    End Class

    Public MustInherit Class ServerModeRecordsGeneratorBase
        Private generatedItemsCount As Integer = 0
        Private parentWindow As SQLConnectionWindow
        Private clearRecords As Boolean
        Public Sub New(ByVal parentWindow As SQLConnectionWindow, ByVal clearRecords As Boolean)
            Me.parentWindow = parentWindow
            Me.clearRecords = clearRecords
        End Sub

        Protected MustOverride ReadOnly Property DataBaseContext() As DataContext

        Public Sub GenerateRecords()
            parentWindow.Cursor = Cursors.Wait
            SetupDataContext(parentWindow.GetDataBaseConnectionString())
            ValidateDatabase()
            parentWindow.Title = ServerModeOptions.dataAdding
            If clearRecords Then
                Try
                    Clear()
                    DataBaseContext.SubmitChanges()
                Catch
                End Try
            End If
            CreateItems()
        End Sub
        Private Sub ValidateDatabase()
            If Not DataBaseContext.DatabaseExists() Then
                DataBaseContext.CreateDatabase()
                CreateIndices()
            Else
                DataBaseContext.Connection.Open()
            End If
            If Not TableExists() Then
                CreateTable()
                CreateIndices()
            End If
        End Sub
        Private Function TableExists() As Boolean
            Dim schema As DataTable = DataBaseContext.Connection.GetSchema("Tables")
            For Each row As DataRowView In schema.DefaultView
                If DirectCast(row("TABLE_NAME"), String) = TableName Then
                    Return True
                End If
            Next row
            Return False
        End Function
        Private Sub CreateItems()
            Dim [step] As Integer = CInt(parentWindow.RecordCount \ 100)
            If [step] = 0 Then
                [step] = parentWindow.RecordCount
            End If
            Dim i As Integer
            i = generatedItemsCount
            Do While i < parentWindow.RecordCount AndAlso i < generatedItemsCount + 100
                AddNewItem()
                If i Mod [step] = 0 Then
                    DataBaseContext.SubmitChanges()
                    parentWindow.ProgressBar.Value = (i * 100 \ parentWindow.RecordCount)
                    parentWindow.ProgressBar.UpdateLayout()
                End If
                i += 1
            Loop
            generatedItemsCount = i
            If i >= parentWindow.RecordCount Then
                DataBaseContext.SubmitChanges()
                DataBaseContext.Dispose()
                parentWindow.CloseForm()
            Else
                parentWindow.Dispatcher.BeginInvoke(DispatcherPriority.Render, New Action(AddressOf CreateItems))
            End If
        End Sub

        Protected MustOverride Sub SetupDataContext(ByVal connection As String)
        Protected MustOverride Sub AddNewItem()
        Protected MustOverride ReadOnly Property TableName() As String
        Protected Overridable Sub CreateIndices()
        End Sub
        Protected MustOverride Sub CreateTable()
        Protected MustOverride Sub Clear()
    End Class
    Public Class ServerModeOutlookDataGenerator
        Inherits ServerModeRecordsGeneratorBase

        Public Sub New(ByVal parentWindow As SQLConnectionWindow, ByVal clearRecords As Boolean)
            MyBase.New(parentWindow, clearRecords)
        End Sub

        Private context As DataGridTestClassesDataContext

        Protected Overrides ReadOnly Property DataBaseContext() As DataContext
            Get
                Return context
            End Get
        End Property

        Protected Overrides Sub SetupDataContext(ByVal connection As String)
            context = CreateContext(connection)
        End Sub
        Private Function CreateContext(ByVal connection As String) As DataGridTestClassesDataContext
            Return New DataGridTestClassesDataContext(connection)
        End Function

        Protected Overrides Sub AddNewItem()
            context.WpfServerSideGridTests.InsertOnSubmit(OutlookDataGenerator.CreateNewServerObject())
        End Sub

        Protected Overrides ReadOnly Property TableName() As String
            Get
                Return ServerModeOptions.OutlookTableName
            End Get
        End Property

        Protected Overrides Sub CreateIndices()
            CreateIndex("Sent")
            CreateIndex("HasAttachment")
            CreateIndex("Size")
            CreateIndex("From")
            CreateIndex("Subject")
            context.SubmitChanges()
        End Sub
        Private Sub CreateIndex(ByVal fieldName As String)
            DataBaseContext.ExecuteCommand(String.Format("CREATE INDEX {1}_idx ON {0} ([{1}]);", TableName, fieldName))
        End Sub
        Protected Overrides Sub CreateTable()
            DataBaseContext.ExecuteCommand(String.Format("" & ControlChars.CrLf & _
"        CREATE TABLE {0}(" & ControlChars.CrLf & _
"        OID Int NOT NULL IDENTITY," & ControlChars.CrLf & _
"        Sent DateTime," & ControlChars.CrLf & _
"        HasAttachment Bit," & ControlChars.CrLf & _
"        Size BigInt," & ControlChars.CrLf & _
"        [From] NVarChar(100)," & ControlChars.CrLf & _
"        Subject NVarChar(100)," & ControlChars.CrLf & _
"        CONSTRAINT {0}_pk PRIMARY KEY (OID)" & ControlChars.CrLf & _
"        );" & ControlChars.CrLf & _
"        ", TableName))
        End Sub

        Protected Overrides Sub Clear()
            DataBaseContext.ExecuteCommand("DELETE FROM " & TableName & " WHERE Oid>=0")
        End Sub
    End Class

    Public MustInherit Class ServerModeRecordsGeneratorProviderBase
        Public MustOverride Function CalcRecordCount(ByVal serverConnectionString As String) As Integer
        Public MustOverride Function Create(ByVal parentWindow As SQLConnectionWindow, ByVal clearRecords As Boolean) As ServerModeRecordsGeneratorBase

        Protected Function CalcRecordCountCore(Of T As DataContext, U)(ByVal dataContextFactory As Func(Of T), ByVal tableSelector As Func(Of T, IQueryable(Of U))) As Integer
            Try
                Using dataContext = dataContextFactory()
                    Return Queryable.Count(tableSelector(dataContext))
                End Using
            Catch
                Return 0
            End Try
        End Function

        Public Shared Function IsDatabaseExists(ByVal connectionString As String, ByVal tableName As String) As Boolean
            If String.IsNullOrEmpty(connectionString) Then
                Return False
            End If
            Try
                Using conn As New SqlConnection(connectionString)
                    conn.Open()
                    Dim dTable As DataTable = conn.GetSchema("Tables", New String() { Nothing, Nothing, tableName })
                    Return dTable IsNot Nothing AndAlso dTable.Rows.Count > 0
                End Using
            Catch
                Return False
            End Try
        End Function
    End Class
    Public Class OutlookGeneratorProvider
        Inherits ServerModeRecordsGeneratorProviderBase

        Public Overrides Function Create(ByVal parentWindow As SQLConnectionWindow, ByVal clearRecords As Boolean) As ServerModeRecordsGeneratorBase
            Return New ServerModeOutlookDataGenerator(parentWindow, clearRecords)
        End Function

        Public Overrides Function CalcRecordCount(ByVal serverConnectionString As String) As Integer
            Return CalcRecordCountCore(Function() New DataGridTestClassesDataContext(serverConnectionString), Function(x) x.WpfServerSideGridTests)
        End Function
    End Class
End Namespace
