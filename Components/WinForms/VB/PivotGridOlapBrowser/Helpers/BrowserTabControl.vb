Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Text
Imports DevExpress.XtraTab
Imports DevExpress.XtraTab.ViewInfo
Imports DevExpress.Utils
Imports System.ComponentModel
Imports System.Windows.Forms
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraReports.UserDesigner
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Columns
Imports PivotGridOlapBrowser.Commands

Namespace PivotGridOlapBrowser.Helpers
	Public Class BrowserTabControl
		Inherits XtraTabControl
		Private allowCloseFirstPage_Renamed As Boolean

		Public Sub New()
			Me.allowCloseFirstPage_Renamed = True
			ClosePageButtonShowMode = ClosePageButtonShowMode.InAllTabPageHeaders
			UpdateTabHeaders()
		End Sub

		<DefaultValue(False)> _
		Public Property AllowCloseFirstPage() As Boolean
			Get
				Return allowCloseFirstPage_Renamed
			End Get
			Set(ByVal value As Boolean)
				If allowCloseFirstPage_Renamed = value Then
					Return
				End If
				allowCloseFirstPage_Renamed = value
				UpdateCloseButtonsVisible()
			End Set
		End Property
		Public ReadOnly Property ActiveBrowser() As BrowserPivot
			Get
				Dim tabPage As PivotTabPage = TryCast(Me.SelectedTabPage, PivotTabPage)
				Return If(tabPage IsNot Nothing, tabPage.Browser, Nothing)
			End Get
		End Property
		Public ReadOnly Property ActiveChart() As BrowserChart
			Get
				Dim tabPage As ChartTabPage = TryCast(Me.SelectedTabPage, ChartTabPage)
				Return If(tabPage IsNot Nothing, tabPage.Chart, Nothing)
			End Get
		End Property
		Public ReadOnly Property ReportControls() As List(Of Control)
			Get
				Dim controls As New List(Of Control)(TabPages.Count)
				For Each tabPage As BrowserTabPage In TabPages
					controls.Add(tabPage.Control)
				Next tabPage
				Return controls
			End Get
		End Property
		Protected Overrides Function CreateTabCollection() As XtraTabPageCollection
			Return New BrowserTabPageCollection(Me)
		End Function
		Public Shadows Property SelectedTabPage() As BrowserTabPage
			Get
				Return CType(MyBase.SelectedTabPage, BrowserTabPage)
			End Get
			Set(ByVal value As BrowserTabPage)
				MyBase.SelectedTabPage = value
			End Set
		End Property

		Public Sub AddTabPage(ByVal page As BrowserTabPage, ByVal addPadding As Boolean)
			page.Initialize()
			If addPadding Then
				page.Padding = New System.Windows.Forms.Padding(12)
			End If
			TabPages.Add(page)
			SelectedTabPage = page
		End Sub

		Protected Sub UpdateCloseButtonsVisible()
			For i As Integer = 0 To TabPages.Count - 1
				TabPages(i).ShowCloseButton = If(((Not AllowCloseFirstPage) AndAlso i = 0), DefaultBoolean.False, DefaultBoolean.Default)
			Next i
		End Sub

		Protected Sub UpdateTabHeaders()
			ShowTabHeader = If(AllowCloseFirstPage OrElse TabPages.Count > 1, DefaultBoolean.True, DefaultBoolean.False)
		End Sub

		Protected Overrides Sub OnTabPageAdded(ByVal page As XtraTabPage)
			MyBase.OnTabPageAdded(page)
			UpdateTabHeaders()
			UpdateCloseButtonsVisible()
		End Sub

		Protected Overrides Sub OnTabPageRemoved(ByVal page As XtraTabPage)
			MyBase.OnTabPageRemoved(page)
			UpdateTabHeaders()
		End Sub

		Protected Overrides Sub OnCloseButtonClick(ByVal sender As Object, ByVal e As EventArgs)
			MyBase.OnCloseButtonClick(sender, e)
			Dim args As ClosePageButtonEventArgs = CType(e, ClosePageButtonEventArgs)
			Dim page As XtraTabPage = CType(args.Page, XtraTabPage)
			page.Dispose()
			UpdateCloseButtonsVisible()
		End Sub
	End Class

	Public Class BrowserTabPageCollection
		Inherits XtraTabPageCollection
		Public Sub New(ByVal tabControl As XtraTabControl)
			MyBase.New(tabControl)
		End Sub
		Protected Overrides Function CreatePage() As XtraTabPage
			Return MyBase.CreatePage()
		End Function
	End Class

	Public MustInherit Class BrowserTabPage
		Inherits XtraTabPage
		Public Sub New(ByVal text As String)
			MyBase.New()
			Me.Text = text
		End Sub
		Public Sub Initialize()
			If IsEmpty Then
				Dim control As Control = Me.Control
				control.Dock = DockStyle.Fill
				Me.Controls.Add(control)
			End If
		End Sub
		Public ReadOnly Property IsEmpty() As Boolean
			Get
				Return Me.Controls.Count = 0
			End Get
		End Property
		Public Function GetIsCommandActual(ByVal commandId As BrowserCommandId) As Boolean?
			Return Array.Exists(Me.Commands, Function(item) item = commandId)
		End Function
		Public ReadOnly Property Control() As Control
			Get
				Return GetControlCore()
			End Get
		End Property
		Protected MustOverride ReadOnly Property Commands() As BrowserCommandId()
		Protected MustOverride Function GetControlCore() As Control
	End Class
	Public Class PivotTabPage
		Inherits BrowserTabPage
		Private browser_Renamed As BrowserPivot
		Public Sub New(ByVal browser As BrowserPivot, ByVal text As String)
			MyBase.New(text)
			Me.browser_Renamed = browser
		End Sub
		Public ReadOnly Property Browser() As BrowserPivot
			Get
				Return browser_Renamed
			End Get
		End Property
		Protected Overrides ReadOnly Property Commands() As BrowserCommandId()
			Get
				Return New BrowserCommandId() { BrowserCommandId.ConnectTo, BrowserCommandId.CreateReport, BrowserCommandId.ShowChartFromPivot }
			End Get
		End Property
		Protected Overrides Function GetControlCore() As Control
			Return browser_Renamed
		End Function
	End Class
	Public Class ChartTabPage
		Inherits BrowserTabPage
		Private chart_Renamed As BrowserChart

		Public Sub New(ByVal chart As BrowserChart, ByVal text As String)
			MyBase.New(text)
			Me.chart_Renamed = chart
		End Sub
		Public ReadOnly Property Chart() As BrowserChart
			Get
				Return chart_Renamed
			End Get
		End Property
		Protected Overrides ReadOnly Property Commands() As BrowserCommandId()
			Get
				Return New BrowserCommandId() { BrowserCommandId.ConnectTo, BrowserCommandId.CreateReport, BrowserCommandId.ShowTotals, BrowserCommandId.ShowSelection, BrowserCommandId.ChartViewSet, BrowserCommandId.ChartView }
			End Get
		End Property
		Protected Overrides Function GetControlCore() As Control
			Return chart_Renamed
		End Function
	End Class
	Public Class GridTabPage
		Inherits BrowserTabPage
		Private grid_Renamed As BrowserGrid

		Public Sub New(ByVal grid As BrowserGrid, ByVal text As String)
			MyBase.New(text)
			Me.grid_Renamed = grid
		End Sub
		Public ReadOnly Property Grid() As BrowserGrid
			Get
				Return grid_Renamed
			End Get
		End Property
		Protected Overrides ReadOnly Property Commands() As BrowserCommandId()
			Get
				Return New BrowserCommandId() { BrowserCommandId.ConnectTo, BrowserCommandId.CreateReport }
			End Get
		End Property
		Protected Overrides Function GetControlCore() As Control
			Return grid_Renamed
		End Function
	End Class
End Namespace
