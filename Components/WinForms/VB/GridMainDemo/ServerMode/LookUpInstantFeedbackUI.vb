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
	Partial Public Class LookUpInstantFeedbackUI
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
            TutorialInfo.WhatsThisCodeFile = "VB\GridMainDemo\ServerMode\LookUpInstantFeedbackUI.vb;VB\GridMainDemo\Modules\SearchLookUpProperties.vb"
            TutorialInfo.WhatsThisXMLFile = "LookUpInstantFeedbackUI.xml"
			'<searchLookUpEdit1>
'             
'            ~Note: the following property is set at design time and listed here only for demonstration purposes.
'            ~Assign a data source to the grid via the DataSource property:
'            
'            searchLookUpEdit1.Properties.DataSource = xpAsyncServerModeSource1;
'            
			'</searchLookUpEdit1>
			colOid.AllowSummaryMenu = False
			colHasAttachment.AllowSummaryMenu = False
			colOid.OptionsColumn.AllowGroup = DefaultBoolean.False
			colSize.OptionsColumn.AllowGroup = DefaultBoolean.False
			InitEditors()
		End Sub
		Private loaded As Boolean = False
		Protected Overrides Sub OnLoad(ByVal e As EventArgs)
			MyBase.OnLoad(e)
			If loaded Then
				Return
			End If
			Me.loaded = True
			Dim lp As New SearchLookUpProperties(searchLookUpEdit1, False)
			lp.Dock = DockStyle.Right
			lp.Parent = pnlProperties
			'<dataNavigator1>
			Dim tbl As New DataTable()
			tbl.Columns.Add("Id", GetType(Integer))
			For i As Integer = 1 To 99
				tbl.Rows.Add(i * 3)
			Next i
			Me.searchLookUpEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", tbl, "ID"))
			dataNavigator1.DataSource = tbl
			'</dataNavigator1>
			CreateTimer()
		End Sub
		Protected Overrides Sub OnTick()
			If DemosInfo.CurrentModule Is Me Then
				searchLookUpEdit1.ShowPopup()
			End If
		End Sub
		Private Sub InitEditors()
			For Each mode As WaitAnimationOptions In System.Enum.GetValues(GetType(WaitAnimationOptions))
				icbAnimation.Properties.Items.Add(New ImageComboBoxItem(EnumTitlesKeeper(Of WaitAnimationOptions).GetTitle(mode), mode, -1))
			Next mode
			icbAnimation.EditValue = gridLookUpEdit1View.OptionsView.WaitAnimationOptions
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
			gridLookUpEdit1View.OptionsView.WaitAnimationOptions = CType(icbAnimation.EditValue, WaitAnimationOptions)
		End Sub
		'</icbAnimation>

		Protected Overrides Sub OnStyleChanged()
			MyBase.OnStyleChanged()
			ColorHelper.UpdateColor(imageList1, Me.LookAndFeel)
		End Sub
	End Class
End Namespace
