Imports System.ComponentModel
Imports System.Text
Imports DevExpress.XtraEditors
Imports DevExpress.Xpo.DB
Imports DevExpress.Xpo
Imports DevExpress.Xpo.Helpers
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.Utils
Imports DevExpress.DXperience.Demos

Namespace DevExpress.XtraGrid.Demos
	Partial Public Class GridInstantFeedbackUI
		Inherits DevExpress.XtraGrid.Demos.TutorialControl

		Private writer As New LogWriter()
		Public Sub New()
			 If ServerModeStrings.SQLConnectionString = String.Empty Then
				ShowConnectionWizard()
			 End If
			Try
				Dim store As IDataStore = XpoDefault.GetConnectionProvider(ServerModeStrings.SQLConnectionString, AutoCreateOption.DatabaseAndSchema)
				store = New WaitCursorWrapper(store)
				store = New DataStoreLogger(store, writer)
				XpoDefault.DataLayer = New SimpleDataLayer(store)
			Catch
				XtraMessageBox.Show(ServerModeStrings.failedConnection, ServerModeStrings.failedConnectionCaption, MessageBoxButtons.OK, MessageBoxIcon.Error)
				ServerModeStrings.SQLConnectionString = ""
			End Try
			InitializeComponent()
            TutorialInfo.WhatsThisCodeFile = "VB\GridMainDemo\ServerMode\GridInstantFeedbackUI.vb"
            TutorialInfo.WhatsThisXMLFile = "GridInstantFeedbackUI.xml"

			'<gridControl1>
'            
'            ~Note: the following property is set at design time and listed here only for demonstration purposes.
'            ~Assign a data source to the grid via the DataSource property:
'            
'            gridControl1.DataSource = xpAsyncServerModeSource1;
'            
'            ~Sort rows by the Sent column in descending order 
'            
			xpAsyncServerModeSource1.DefaultSorting = "Sent desc"
			'</gridControl1>
			colOid.AllowSummaryMenu = False
			colExpression.AllowSummaryMenu = False
			colHasAttachment.AllowSummaryMenu = False
			colOid.OptionsColumn.AllowGroup = DefaultBoolean.False
			colSize.OptionsColumn.AllowGroup = DefaultBoolean.False
			InitEditors()
		End Sub
		Protected Overrides Sub OnLoad(ByVal e As EventArgs)
			MyBase.OnLoad(e)
			OnStyleChanged()
		End Sub
		Protected Overrides Sub OnStyleChanged()
			MyBase.OnStyleChanged()
			ColorHelper.UpdateColor(ilColumns, gridControl1.LookAndFeel)
		End Sub
		Private Sub InitEditors()
			For Each mode As WaitAnimationOptions In System.Enum.GetValues(GetType(WaitAnimationOptions))
				icbAnimation.Properties.Items.Add(New ImageComboBoxItem(EnumTitlesKeeper(Of WaitAnimationOptions).GetTitle(mode), mode, -1))
			Next mode
			icbAnimation.EditValue = gridView1.OptionsView.WaitAnimationOptions
		End Sub
		Private Sub ShowConnectionWizard()
			ShowConnectionWizard(String.Empty)
		End Sub
		Private Sub ShowConnectionWizard(ByVal demoString As String)
			Dim frm As frmSQLConnector = If(demoString = String.Empty, New frmSQLConnector(), New frmSQLConnector(demoString))
			frm.ShowDialog()
			ServerModeStrings.SQLConnectionString = frm.GetDataBaseConnectionString()
		End Sub

		Private Sub sbShowSQLConnection_Click(ByVal sender As Object, ByVal e As EventArgs) Handles sbShowSQLConnection.Click
			ShowConnectionWizard("Return")
		End Sub

		 Private Sub xpAsyncServerModeSource1_ResolveSession(ByVal sender As Object, ByVal e As ResolveSessionEventArgs) Handles xpAsyncServerModeSource1.ResolveSession
			Try
				Dim session As New Session()
				session.ConnectionString = ServerModeStrings.SQLConnectionString
				session.Connect()
				e.Session = session
				e.Tag = session
			Catch
				e.Session = New Session(New SimpleDataLayer(New InMemoryDataStore()))
				e.Tag = Nothing
			End Try
		 End Sub

		Private Sub xpAsyncServerModeSource1_DismissSession(ByVal sender As Object, ByVal e As ResolveSessionEventArgs) Handles xpAsyncServerModeSource1.DismissSession
			Dim session As IDisposable = TryCast(e.Tag, IDisposable)
			If session IsNot Nothing Then
				session.Dispose()
			End If
		End Sub

		'<icbAnimation>
		Private Sub icbAnimation_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles icbAnimation.SelectedIndexChanged
			gridView1.OptionsView.WaitAnimationOptions = CType(icbAnimation.EditValue, WaitAnimationOptions)
		End Sub
		'</icbAnimation>

		Private Sub gridView1_CustomColumnDisplayText(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs) Handles gridView1.CustomColumnDisplayText
			If e.Column Is colExpression Then
				Dim value As Integer = Convert.ToInt32(e.Value)
				e.DisplayText = String.Format("{0}:{1:00}", value \ 60, value Mod 60)
			End If
		End Sub
	End Class
End Namespace
