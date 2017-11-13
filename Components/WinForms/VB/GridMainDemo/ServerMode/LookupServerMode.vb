Imports System.ComponentModel
Imports System.Text
Imports DevExpress.XtraEditors
Imports DevExpress.Xpo.DB
Imports DevExpress.Xpo
Imports DevExpress.Xpo.Helpers
Imports DevExpress.Utils

Namespace DevExpress.XtraGrid.Demos
	Partial Public Class LookUpServerMode
		Inherits DevExpress.XtraGrid.Demos.TutorialControl

		'<groupControl1>
		Private writer As New LogWriter()
		'</groupControl1>

		Public Sub New()
			If ServerModeStrings.SQLConnectionString = String.Empty Then
				ShowConnectionWizard()
			End If
			Try
				'<groupControl1>
				Dim store As IDataStore = XpoDefault.GetConnectionProvider(ServerModeStrings.SQLConnectionString, AutoCreateOption.DatabaseAndSchema)
				'<skip>
				store = New WaitCursorWrapper(store)
				'</skip>
				store = New DataStoreLogger(store, writer)
				XpoDefault.DataLayer = New SimpleDataLayer(store)
				'</groupControl1>

				CreateMainData()
			Catch
				XtraMessageBox.Show(ServerModeStrings.failedConnection, ServerModeStrings.failedConnectionCaption, MessageBoxButtons.OK, MessageBoxIcon.Error)
				ServerModeStrings.SQLConnectionString = ""
			End Try
			InitializeComponent()
            TutorialInfo.WhatsThisCodeFile = "VB\GridMainDemo\ServerMode\LookupServerMode.vb"
            TutorialInfo.WhatsThisXMLFile = "LookupServerMode.xml"

			'<gridControl1>
'            
'            ~Note: the following properties are set at design time and listed here only for demonstration purposes.
'            ~Assign a data source to the in-place GridLookUpEdit's DataSource property:
'            
'            repositoryItemGridLookUpEdit1.DataSource = xpServerCollectionSource1;
'            
'            ~Specify the field whose values are displayed in the edit box:
'            
'            repositoryItemGridLookUpEdit1.DisplayMember = "Subject";
'            
			'</gridControl1>



			colOid.AllowSummaryMenu = False
			colHasAttachment.AllowSummaryMenu = False
			colOid.OptionsColumn.AllowGroup = DefaultBoolean.False
			colSize.OptionsColumn.AllowGroup = DefaultBoolean.False
			writer.Enabled = ceTracing.Checked
			'<groupControl1>
			writer.Console = xtraConsole1
			'</groupControl1>
			repositoryItemComboBox1.Items.AddRange(OutlookData.users)
		End Sub

		Private Sub CreateMainData()
			Using uow As New UnitOfWork()
				If uow.FindObject(Of ServerSideLookUpTest)(Nothing) Is Nothing Then
					Dim rnd As New Random()
					Dim issues As New XPCollection(Of ServerSideGridTest)(uow)
					issues.TopReturnedObjects = 1999
					Do While issues.Count < 1000
						issues.Add(OutlookData.CreateNewObject(uow))
					Loop
					For i As Integer = 0 To 6
						Dim percent As Integer = 0
						If i = 2 Then
							percent = 50
						End If
						If i = 5 Then
							percent = 100
						End If
						Dim obj As New ServerSideLookUpTest(uow)
						obj.AssignTo = OutlookData.GetFrom()
						obj.DueDate = OutlookData.GetDueDate()
						obj.Issue = issues(rnd.Next(issues.Count))
						obj.PercentComplete = percent
					Next i
				End If
				uow.CommitChanges()
			End Using
		End Sub

		Private Sub ShowConnectionWizard()
			Dim frm As New frmSQLConnector()
			frm.ShowDialog()
			ServerModeStrings.SQLConnectionString = frm.GetDataBaseConnectionString()
		End Sub

		Private Sub ceTracing_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles ceTracing.CheckedChanged
			writer.Enabled = ceTracing.Checked
		End Sub

		Private Sub sbClear_Click(ByVal sender As Object, ByVal e As EventArgs) Handles sbClear.Click
			xtraConsole1.ClearText()
		End Sub

		Private Sub gridView1_CustomRowCellEditForEditing(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs) Handles gridView1.CustomRowCellEditForEditing
			If e.Column IsNot colPercentComplete Then
				Return
			End If
			e.RepositoryItem = repositoryItemSpinEdit1
		End Sub
	End Class
End Namespace
