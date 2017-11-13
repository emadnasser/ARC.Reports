Imports System.ComponentModel
Imports System.Text
Imports DevExpress.XtraEditors
Imports DevExpress.Xpo.DB
Imports DevExpress.Xpo
Imports DevExpress.Xpo.Helpers
Imports DevExpress.Utils

Namespace DevExpress.XtraGrid.Demos
	Partial Public Class GridServerMode
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
				'</groupControl1>
				XpoDefault.DataLayer = New SimpleDataLayer(store)
			Catch
				XtraMessageBox.Show(ServerModeStrings.failedConnection, ServerModeStrings.failedConnectionCaption, MessageBoxButtons.OK, MessageBoxIcon.Error)
				ServerModeStrings.SQLConnectionString = ""
			End Try
			InitializeComponent()
            TutorialInfo.WhatsThisCodeFile = "VB\GridMainDemo\ServerMode\GridServerMode.vb"
            TutorialInfo.WhatsThisXMLFile = "GridServerMode.xml"
			'<gridControl1>
'            
'            ~Note: the following property is set at design time and listed here only for demonstration purposes.
'            ~Assign a data source to the grid via the DataSource property:
'            
'            gridControl1.DataSource = xpServerCollectionSource1;
'            
'            ~Sort rows by the Sent column in descending order
'            
			xpServerCollectionSource1.DefaultSorting = "Sent desc"
			'</gridControl1>
			colOid.AllowSummaryMenu = False
			colHasAttachment.AllowSummaryMenu = False
			colOid.OptionsColumn.AllowGroup = DefaultBoolean.False
			colSize.OptionsColumn.AllowGroup = DefaultBoolean.False
			writer.Enabled = ceTracing.Checked
			'<groupControl1>
			writer.Console = xtraConsole1
			'</groupControl1>
		End Sub
		Protected Overrides Sub OnLoad(ByVal e As EventArgs)
			MyBase.OnLoad(e)
			OnStyleChanged()
		End Sub
		Protected Overrides Sub OnStyleChanged()
			MyBase.OnStyleChanged()
			ColorHelper.UpdateColor(ilColumns, gridControl1.LookAndFeel)
		End Sub
		Private Sub ShowConnectionWizard()
			ShowConnectionWizard(String.Empty)
		End Sub
		Private Sub ShowConnectionWizard(ByVal demoString As String)
			Dim frm As frmSQLConnector = If(demoString = String.Empty, New frmSQLConnector(), New frmSQLConnector(demoString))
			frm.ShowDialog()
			ServerModeStrings.SQLConnectionString = frm.GetDataBaseConnectionString()
		End Sub

		Private Sub ceTracing_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles ceTracing.CheckedChanged
			writer.Enabled = ceTracing.Checked
		End Sub

		Private Sub sbClear_Click(ByVal sender As Object, ByVal e As EventArgs) Handles sbClear.Click
			xtraConsole1.ClearText()
		End Sub

		Private Sub sbShowSQLConnection_Click(ByVal sender As Object, ByVal e As EventArgs) Handles sbShowSQLConnection.Click
			ShowConnectionWizard("Return")
			xpServerCollectionSource1.Reload()
		End Sub

		Private Sub simpleButton1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles simpleButton1.Click
			'<simpleButton1>
			unitOfWork1.CommitChanges()
			xpServerCollectionSource1.Reload()
			'</simpleButton1>
		End Sub
	End Class
End Namespace
