Imports Microsoft.VisualBasic
Imports DevExpress.XtraCharts
Imports DevExpress.XtraEditors
Imports DevExpress.XtraPivotGrid
Imports DevExpress.XtraPivotGrid.Data
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraTab
Imports PivotGridOlapBrowser.Commands
Imports PivotGridOlapBrowser.Commands.Services
Imports PivotGridOlapBrowser.Dialogs
Imports PivotGridOlapBrowser.Helpers
Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.Data
Imports System.Text
Imports System.Windows.Forms

Namespace PivotGridOlapBrowser
	Public Class CommandsUpdateEventArgs
		Inherits EventArgs
	End Class
	Public Class CommandFailedEventArgs
		Inherits EventArgs
		Private ReadOnly message_Renamed As String
		Private ReadOnly commandId_Renamed As BrowserCommandId

		Public Sub New(ByVal commandId As BrowserCommandId, ByVal message As String)
			Me.commandId_Renamed = commandId
			Me.message_Renamed = message
		End Sub
		Public ReadOnly Property CommandId() As BrowserCommandId
			Get
				Return commandId_Renamed
			End Get
		End Property
		Public ReadOnly Property Message() As String
			Get
				Return message_Renamed
			End Get
		End Property
	End Class
	Public Delegate Sub CommandsUpdateEventHandler(ByVal sender As Object, ByVal e As CommandsUpdateEventArgs)
	Public Delegate Sub CommandFailedEventHandler(ByVal sender As Object, ByVal e As CommandFailedEventArgs)
	Partial Public Class PivotGridBrowser
		Inherits UserControl
		Private Shared ReadOnly evtIsBusyChanged As Object = New Object()
		Private Shared ReadOnly evtCommandsUpdate As Object = New Object()
		Private Shared ReadOnly evtCommandFailed As Object = New Object()

		Private Shared Function GetDrillDownTabText(ByVal e As PivotCellEventArgs) As String
			Dim stb As New StringBuilder()
			stb.Append("DrillDown: ")
			If e.ColumnField IsNot Nothing Then
				stb.Append(e.GetFieldValue(e.ColumnField)).Append(", ")
			End If
			If e.RowField IsNot Nothing Then
				stb.Append(e.GetFieldValue(e.RowField)).Append(", ")
			End If
			stb.Append(e.DataField)
			Return stb.ToString()
		End Function
		Private Shared Function GetPivotTabText(ByVal connectionString As String) As String
			Dim builder As New OLAPConnectionStringBuilder(connectionString)
			Dim stb As New StringBuilder()
			stb.Append("Pivot Grid: '")
			stb.Append(builder.CubeName).Append("'")
			Return stb.ToString()
		End Function
		Private Shared Function GetChartTabText(ByVal dataTable As DataTable) As String
			If dataTable.Rows.Count = 0 Then
				Return "Chart"
			End If
			Dim stb As New StringBuilder()
			stb.Append("Chart: '")
			stb.Append(dataTable.Rows(0)(1).ToString()).Append(" - ")
			stb.Append(dataTable.Rows(dataTable.Rows.Count - 1)(1).ToString()).Append("'")
			Return stb.ToString()
		End Function
		Private Shared Function GetReportTabText() As String
			Dim stb As New StringBuilder()
			stb.Append("Report designer")
			Return stb.ToString()
		End Function

		Private busyCounter As Integer
		Private ReadOnly connectionDesigner As ConnectionDesigner
		Private ReadOnly serviceManager As PivotGridBrowserServiceManager

		Public Sub New()
			InitializeComponent()
			Me.serviceManager = New PivotGridBrowserServiceManager()
			AddServices()
			Me.connectionDesigner = New ConnectionDesigner()
		End Sub
		Public Function GetIsCommandActual(ByVal commandId As BrowserCommandId) As Boolean?
			If Me.browserTabs.SelectedTabPage Is Nothing Then
				Return Nothing
			End If
			Return Me.browserTabs.SelectedTabPage.GetIsCommandActual(commandId)
		End Function

		Private ReadOnly Property ActiveBrowser() As BrowserPivot
			Get
				Return browserTabs.ActiveBrowser
			End Get
		End Property
		Private ReadOnly Property ActiveChart() As BrowserChart
			Get
				Return browserTabs.ActiveChart
			End Get
		End Property

		Protected Overridable Function CreateReport(ByVal tabControl As BrowserTabControl) As XtraReport
			Dim report As New XtraReport()
			Return report
		End Function
		Protected Overridable Function CreateBrowserPivot() As BrowserPivot
			Dim browser As BrowserPivot = New PivotGridOlapBrowser.BrowserPivot()
			AddHandler browser.IsBusyChanged, AddressOf OnBrowserBusyChanged
			AddHandler browser.CellDoubleClick, AddressOf OnBrowserCellDoubleClick
			Return browser
		End Function
		Protected Overridable Function CreateChart(ByVal dataTable As DataTable, ByVal showSelection? As Boolean, ByVal state As DataState) As BrowserChart
			Dim chart As New BrowserChart(ViewType.Line, False, showSelection, state)
			chart.DataSource = dataTable
			Return chart
		End Function
        Protected Overridable Function CreateGrid(ByVal browser As BrowserPivot, ByVal dataTable As Object) As BrowserGrid
            Dim grid As New BrowserGrid(browser)
            grid.DataSource = dataTable
            Return grid
        End Function
		Public Overridable Function CreateCommand(ByVal commandId As BrowserCommandId) As BrowserCommand
			If serviceManager IsNot Nothing Then
				Return serviceManager.CreateCommand(commandId)
			Else
				Return Nothing
			End If
		End Function
		Protected Sub AddServices()
			AddService(GetType(IBrowserCommandFactoryService), New BrowserCommandFactoryService(Me))
		End Sub
		Protected Sub AddService(ByVal serviceType As Type, ByVal serviceInstance As Object)
			If serviceManager IsNot Nothing Then
				serviceManager.AddService(serviceType, serviceInstance)
			End If
		End Sub

		Public Custom Event IsBusyChanged As EventHandler
			AddHandler(ByVal value As EventHandler)
				Events.AddHandler(evtIsBusyChanged, value)
			End AddHandler
			RemoveHandler(ByVal value As EventHandler)
				Events.RemoveHandler(evtIsBusyChanged, value)
			End RemoveHandler
			RaiseEvent(ByVal sender As System.Object, ByVal e As System.EventArgs)
			End RaiseEvent
		End Event
		Public Custom Event CommandFailed As CommandFailedEventHandler
			AddHandler(ByVal value As CommandFailedEventHandler)
				Events.AddHandler(evtCommandFailed, value)
			End AddHandler
			RemoveHandler(ByVal value As CommandFailedEventHandler)
				Events.RemoveHandler(evtCommandFailed, value)
			End RemoveHandler
			RaiseEvent(ByVal sender As Object, ByVal e As CommandFailedEventArgs)
			End RaiseEvent
		End Event
		Public Custom Event CommandsUpdate As CommandsUpdateEventHandler
			AddHandler(ByVal value As CommandsUpdateEventHandler)
				Events.AddHandler(evtCommandsUpdate, value)
			End AddHandler
			RemoveHandler(ByVal value As CommandsUpdateEventHandler)
				Events.RemoveHandler(evtCommandsUpdate, value)
			End RemoveHandler
			RaiseEvent(ByVal sender As Object, ByVal e As CommandsUpdateEventArgs)
			End RaiseEvent
		End Event
		Public ReadOnly Property IsBusy() As Boolean
			Get
				Return busyCounter > 0
			End Get
		End Property
		Protected Sub SetBusy(ByVal busy As Boolean)
			Dim oldBusy As Boolean = IsBusy
			busyCounter += If(busy, 1, -1)
			If IsBusy <> oldBusy Then
				OnIsBusyChanged()
			End If
		End Sub
		Protected Friend Overridable Sub OnCommandFailed(ByVal commandId As BrowserCommandId, ByVal message As String)
			Dim handler As CommandFailedEventHandler = CType(Events(evtCommandFailed), CommandFailedEventHandler)
			If handler IsNot Nothing Then
				handler(Me, New CommandFailedEventArgs(commandId, message))
			End If
		End Sub
		Protected Overridable Sub OnCommandsUpdate()
			Dim handler As CommandsUpdateEventHandler = CType(Events(evtCommandsUpdate), CommandsUpdateEventHandler)
			If handler IsNot Nothing Then
				handler(Me, New CommandsUpdateEventArgs())
			End If
		End Sub
		Protected Overridable Sub OnIsBusyChanged()
			Dim handler As EventHandler = CType(Events(evtIsBusyChanged), EventHandler)
			If handler IsNot Nothing Then
				handler(Me, EventArgs.Empty)
			End If
		End Sub
		Private Sub OnBrowserBusyChanged(ByVal sender As Object, ByVal e As EventArgs)
			Dim browser As BrowserPivot = TryCast(sender, BrowserPivot)
			If browser Is Nothing Then
				Return
			End If
			SetBusy(browser.IsBusy)
		End Sub

		Private Sub OnBrowserCellDoubleClick(ByVal sender As Object, ByVal e As PivotCellEventArgs)
			Try
				Dim ds As PivotDrillDownDataSource = e.CreateDrillDownDataSource()
				If ds Is Nothing OrElse ds.RowCount = 0 Then
					XtraMessageBox.Show("DrillDown operation returned no rows", Nothing, MessageBoxButtons.OK, MessageBoxIcon.Information)
					Return
				End If
                Me.browserTabs.AddTabPage(New GridTabPage(CreateGrid(ActiveBrowser, ds), GetDrillDownTabText(e)), True)
			Catch exception As OLAPException
				If exception.InnerException IsNot Nothing Then
					XtraMessageBox.Show(String.Format("{0}: {1}", exception.Message, exception.InnerException.Message), Nothing, MessageBoxButtons.OK, MessageBoxIcon.Error)
				Else
					XtraMessageBox.Show(exception.Message, Nothing, MessageBoxButtons.OK, MessageBoxIcon.Error)
				End If
			End Try
		End Sub

		Public Function ShowReport() As Boolean
			Dim report As XtraReport = PivotReportGenerator.GenerateReport(Me.browserTabs.ReportControls)
			report.ShowDesignerDialog()
			Return True
		End Function
		Public Function ShowChartFromPivot() As Boolean
			Dim browser As BrowserPivot = ActiveBrowser
			If browser Is Nothing Then
				Return False
			End If
			Dim dataTable As DataTable = browser.Data
			Dim showSelection? As Boolean = True
			If dataTable.Columns(PivotDataExtractor.ColumnNameIsSelected) Is Nothing Then
				showSelection = Nothing
			End If
			Me.browserTabs.AddTabPage(New ChartTabPage(CreateChart(dataTable, showSelection, browser.State), GetChartTabText(dataTable)), True)
			Return True
		End Function
		Public Function ShowConnectionDialog() As Boolean?
			If connectionDesigner.ShowDialog() = DialogResult.OK Then
				Return AddConnectedBrowserPage(connectionDesigner.ConnectionString) IsNot Nothing
			End If
			Return Nothing
		End Function
		Protected Friend Overridable Property ShowSelection() As Boolean?
			Get
				If ActiveChart Is Nothing Then
					Return Nothing
				End If
				Return ActiveChart.ShowSelection
			End Get
			Set(ByVal value? As Boolean)
				If ActiveChart Is Nothing Then
					Return
				End If
				ActiveChart.ShowSelection = value
			End Set
		End Property
		Protected Friend Overridable Property ShowTotals() As Boolean
			Get
				If ActiveChart Is Nothing Then
					Return False
				End If
				Return ActiveChart.ShowTotals
			End Get
			Set(ByVal value As Boolean)
				If ActiveChart Is Nothing OrElse value = ActiveChart.ShowTotals Then
					Return
				End If
				ActiveChart.ShowTotals = value
			End Set
		End Property
		Protected Friend Overridable Property ChartViewType() As ViewType
			Get
				If ActiveChart Is Nothing Then
					Return ViewType.Line
				End If
				Return ActiveChart.ViewType
			End Get
			Set(ByVal value As ViewType)
				If ActiveChart Is Nothing OrElse Object.Equals(value, ActiveChart.ViewType) Then
					Return
				End If
				ActiveChart.ViewType = value
			End Set
		End Property

		Public Function LoadSampleConfiguration() As Boolean
			Dim browser As BrowserPivot = AddConnectedBrowserPage(ConnectionDesigner.SampleConnectionString)
			If browser Is Nothing Then
				Return False
			End If
			Dim fieldQuantity As PivotGridField = browser.Fields("[Measures].[Quantity]"), fieldCategories As PivotGridField = browser.Fields("[Categories].[Category Name].[Category Name]"), fieldProducts As PivotGridField = browser.Fields("[Products].[Products].[Products]")
			If fieldQuantity IsNot Nothing Then
				fieldQuantity.Visible = True
				fieldQuantity.Area = PivotArea.DataArea
			End If
			If fieldCategories IsNot Nothing Then
				fieldCategories.Visible = True
				fieldCategories.Area = PivotArea.RowArea
			End If
			If fieldProducts IsNot Nothing Then
				fieldProducts.Visible = True
				fieldProducts.Area = PivotArea.RowArea
			End If
			Return True
		End Function
		Private Function AddConnectedBrowserPage(ByVal connectionString As String) As BrowserPivot
			Dim browser As BrowserPivot = CreateBrowserPivot()
			If Connect(browser, connectionString) Then
				Me.browserTabs.AddTabPage(New PivotTabPage(browser, GetPivotTabText(connectionString)), True)
				Return browser
			End If
			Return Nothing
		End Function
		Private Function Connect(ByVal browser As BrowserPivot, ByVal connectionString As String) As Boolean
			If browser Is Nothing Then
				Return False
			End If
			Try
				SetBusy(True)
				browser.ConnectionString = connectionString
				Return True
			Catch e1 As OLAPConnectionException
				'XtraMessageBox.Show("Failed to connect to the datasource.", null, MessageBoxButtons.OK, MessageBoxIcon.Error);
				OnCommandsUpdate()
				Return False
			Finally
				SetBusy(False)
			End Try
		End Function
		Private Sub browserTabs_SelectedPageChanged(ByVal sender As Object, ByVal e As TabPageChangedEventArgs) Handles browserTabs.SelectedPageChanged
			OnCommandsUpdate()
		End Sub
	End Class

	Friend Class PivotGridBrowserServiceManager
		Inherits DevExpress.Services.Internal.ServiceManager
		Friend Sub New()
		End Sub
		Public Overridable Function CreateCommand(ByVal commandId As BrowserCommandId) As BrowserCommand
			Dim service As IBrowserCommandFactoryService = TryCast(GetService(GetType(IBrowserCommandFactoryService)), IBrowserCommandFactoryService)
			If service Is Nothing Then
				Return Nothing
			End If
			Return service.CreateCommand(commandId)
		End Function
	End Class
End Namespace
