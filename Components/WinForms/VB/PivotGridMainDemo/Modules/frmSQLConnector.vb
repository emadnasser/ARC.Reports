Imports Microsoft.VisualBasic
Imports DevExpress.Utils
Imports DevExpress.Xpo
Imports DevExpress.Xpo.DB
Imports DevExpress.XtraEditors
Imports DevExpress.XtraPivotGrid.Demos.Helpers
Imports System
Imports System.Windows.Forms

Namespace DevExpress.XtraPivotGrid.Demos.Modules
	Partial Public Class frmSQLConnector
		Inherits XtraForm
		Private oldCursor As Cursor

		Public Sub New()
			Me.New("Start Demo")
		End Sub
		Public Sub New(ByVal demoString As String)
			InitializeComponent()
			Icon = ResourceImageHelper.CreateIconFromResourcesEx("DevExpress.XtraPivotGrid.Demos.AppIcon.ico", GetType(frmSQLConnector).Assembly)
			ShowInTaskbar = False
			Owner = Form.ActiveForm
			StartPosition = FormStartPosition.CenterParent
			DemoString = demoString
			sbGenerateDB.Text += DemoString
			ServerParameters.LoadParameters()
			lblDBName.Text = ServerParameters.DBName
			teServer.Text = ServerParameters.Server
			radioGroup1.SelectedIndex = If(ServerParameters.UseWindowsAuthentication, 0, 1)
			teLogin.Text = ServerParameters.Login
			tePassword.Text = ServerParameters.Password
			AddHandler teLogin.TextChanged, Function(s, e) AnonymousMethod1(s, e)
			AddHandler tePassword.TextChanged, Function(s, e) AnonymousMethod2(s, e)
			AddHandler teServer.TextChanged, Function(s, e) AnonymousMethod3(s, e)
			AddHandler radioGroup1.SelectedIndexChanged, Function(s, e) AnonymousMethod4(s, e)
			AddHandler FormClosed, Function(s, e) AnonymousMethod5(s, e)
		End Sub
		
		Private Function AnonymousMethod1(ByVal s As Object, ByVal e As Object) As Boolean
			ServerParameters.Login = teLogin.Text
			Return True
		End Function
		
		Private Function AnonymousMethod2(ByVal s As Object, ByVal e As Object) As Boolean
			ServerParameters.Password = tePassword.Text
			Return True
		End Function
		
		Private Function AnonymousMethod3(ByVal s As Object, ByVal e As Object) As Boolean
			ServerParameters.Server = teServer.Text
			Return True
		End Function
		
		Private Function AnonymousMethod4(ByVal s As Object, ByVal e As Object) As Boolean
			ServerParameters.UseWindowsAuthentication = radioGroup1.SelectedIndex = 0
			Return True
		End Function
		
		Private Function AnonymousMethod5(ByVal s As Object, ByVal e As Object) As Boolean
			If DatabaseHelper.IsGenerating Then
				DatabaseHelper.CancelDatabaseGenerationAsync()
			End If
			ServerParameters.SaveParameters()
			Cursor.Current = oldCursor
			Return True
		End Function
		Private privateDemoString As String
		Protected Property DemoString() As String
			Get
				Return privateDemoString
			End Get
			Set(ByVal value As String)
				privateDemoString = value
			End Set
		End Property
		Private Sub radioGroup1_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles radioGroup1.SelectedIndexChanged
			tePassword.Enabled = radioGroup1.SelectedIndex <> 0
			teLogin.Enabled = tePassword.Enabled
		End Sub
		Private Sub sbExit_Click(ByVal sender As Object, ByVal e As EventArgs) Handles sbExit.Click
			DialogResult = If(DatabaseHelper.IsGenerating, System.Windows.Forms.DialogResult.OK, System.Windows.Forms.DialogResult.No)
			Close()
		End Sub
		Private Sub sbGenerateDB_Click(ByVal sender As Object, ByVal e As EventArgs) Handles sbGenerateDB.Click
			GenerateRecords()
		End Sub
		Private Sub DisableControls()
			sbGenerateDB.Enabled = False
			sbTestConfiguration.Enabled = False
			radioGroup1.Enabled = False
			teLogin.Enabled = False
			tePassword.Enabled = False
			teServer.Enabled = False
			seRecordCount.Enabled = False
		End Sub
		Private Sub WriteServerParameters()
			ServerParameters.Server = teServer.Text
			ServerParameters.UseWindowsAuthentication = radioGroup1.SelectedIndex = 0
			ServerParameters.Login = teLogin.Text
			ServerParameters.Password = tePassword.Text
		End Sub
		Private Sub GenerateRecords()
			WriteServerParameters()
			oldCursor = Cursor.Current
			Cursor.Current = Cursors.WaitCursor
			If (Not DatabaseHelper.CreateDataLayer()) Then
				Cursor.Current = oldCursor
				XtraMessageBox.Show("Failed to connect to the server.", "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
				Return
			End If
			Text = "Generating records..."
			progressBarControl1.Position = 0
			progressBarControl1.Properties.Maximum = CInt(Fix(seRecordCount.Value))
			DisableControls()
			DatabaseHelper.GenerateDatabaseAsync(CInt(Fix(seRecordCount.Value)), AddressOf UpdateProgress, AddressOf OnDatabaseGenerated)
		End Sub
		Private Sub UpdateProgress(ByVal rowsGenerated As Integer)
			progressBarControl1.Position = rowsGenerated
			sbExit.Text = String.Format("{0} rows is enough. {1}", rowsGenerated, DemoString)
		End Sub
		Private Sub OnDatabaseGenerated()
			DialogResult = System.Windows.Forms.DialogResult.OK
			Close()
		End Sub
		Private Sub sbTestConfiguration_Click(ByVal sender As Object, ByVal e As EventArgs) Handles sbTestConfiguration.Click
			lbRecords.Text = String.Empty
			Dim recordsCount As Integer = DatabaseHelper.CalculateRecordCount()
			If recordsCount <> -1 Then
				lbRecords.Text = String.Format("Current record count = {0}", recordsCount)
			Else
				XtraMessageBox.Show(String.Format("Unable to connect to the database. Make sure that connection parameters are correct or use the '{0}' button to generate a sample database.", sbGenerateDB.Text), "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
			End If
		End Sub
	End Class
End Namespace
