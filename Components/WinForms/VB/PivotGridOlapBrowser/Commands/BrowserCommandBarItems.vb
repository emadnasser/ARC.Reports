Imports Microsoft.VisualBasic
Imports DevExpress.Utils.Commands
Imports DevExpress.XtraBars
Imports DevExpress.XtraBars.Commands
Imports DevExpress.XtraCharts
Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.ComponentModel

Namespace PivotGridOlapBrowser.Commands.UI
	#Region "IPivotGridBrowserBarItem interface"
	Public Interface IPivotGridBrowserBarItem
		Property Browser() As PivotGridBrowser
		ReadOnly Property CommandId() As BrowserCommandId
		Sub Update()
	End Interface
	#End Region

	#Region "BrowserCommandBarButtonItem"
	Public MustInherit Class BrowserCommandBarButtonItem
		Inherits CommandBasedBarButtonItem
		Implements IPivotGridBrowserBarItem
		Private browserHelper As BrowserCommandBarItemHelper

		Public Sub New(ByVal manager As BarManager, ByVal pivotGridBrowser As PivotGridBrowser)
			MyBase.New(manager)
			browserHelper = New BrowserCommandBarItemHelper(pivotGridBrowser)
			UpdateItemCaption()
		End Sub

		Protected Property InternalBrowser() As PivotGridBrowser
			Get
				Return browserHelper.Browser
			End Get
			Set(ByVal value As PivotGridBrowser)
				If browserHelper.ChangeBrowser(value) Then
					OnBrowserChanged()
				End If
			End Set
		End Property
		Protected MustOverride ReadOnly Property InternalCommandId() As BrowserCommandId
		Protected Sub Update()
			UpdateItemVisibility()
		End Sub
		Protected Overridable Sub OnBrowserChanged()
		End Sub
		Protected Overrides Function CreateCommand() As Command
			If browserHelper Is Nothing Then
				Return Nothing
			End If
			Return browserHelper.CreateCommand(InternalCommandId)
		End Function
		Protected Overrides Sub OnClick(ByVal link As BarItemLink)
			MyBase.OnClick(link)
			CType(link.Item, BrowserCommandBarButtonItem).InvokeCommand()
		End Sub
		#Region "IPivotGridBrowserBarItem Members"
		<Browsable(False), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)> _
		Private Property IPivotGridBrowserBarItem_Browser() As PivotGridBrowser Implements IPivotGridBrowserBarItem.Browser
			Get
				Return Me.InternalBrowser
			End Get
			Set(ByVal value As PivotGridBrowser)
				Me.InternalBrowser = value
			End Set
		End Property

		Private ReadOnly Property IPivotGridBrowserBarItem_CommandId() As BrowserCommandId Implements IPivotGridBrowserBarItem.CommandId
			Get
				Return Me.InternalCommandId
			End Get
		End Property

		Private Sub IPivotGridBrowserBarItem_Update() Implements IPivotGridBrowserBarItem.Update
			Me.Update()
		End Sub
		#End Region

		#Region "IDisposable implementation"
		Protected Overrides Overloads Sub Dispose(ByVal disposing As Boolean)
			Try
				If disposing Then
					browserHelper.ChangeBrowser(Nothing)
				End If
			Finally
				MyBase.Dispose(disposing)
			End Try
		End Sub
		#End Region
	End Class
	#End Region

	#Region "BrowserCommandBarCheckItem"
	Public MustInherit Class BrowserCommandBarCheckItem
		Inherits CommandBasedBarCheckItem
		Implements IPivotGridBrowserBarItem
		Private browserHelper As BrowserCommandBarItemHelper

		Public Sub New(ByVal manager As BarManager, ByVal pivotGridBrowser As PivotGridBrowser)
			MyBase.New(manager)
			browserHelper = New BrowserCommandBarItemHelper(pivotGridBrowser)
			UpdateItemCaption()
		End Sub

		Protected Property InternalBrowser() As PivotGridBrowser
			Get
				Return browserHelper.Browser
			End Get
			Set(ByVal value As PivotGridBrowser)
				If browserHelper.ChangeBrowser(value) Then
					OnBrowserChanged()
				End If
			End Set
		End Property
		Protected MustOverride ReadOnly Property InternalCommandId() As BrowserCommandId
		Protected MustOverride Sub ApplyChecking()

		Protected Sub Update()
			UpdateItemVisibility()
			UpdateItemChecked()
		End Sub
		Protected Overridable Sub OnBrowserChanged()
		End Sub
		Protected Overrides Sub RaiseCheckedChanged()
			MyBase.RaiseCheckedChanged()
			ApplyChecking()
		End Sub
		Protected Overrides Function CreateCommand() As Command
			If browserHelper Is Nothing Then
				Return Nothing
			End If
			Return browserHelper.CreateCommand(InternalCommandId)
		End Function

		#Region "IPivotGridBrowserBarItem Members"
		<Browsable(False), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)> _
		Private Property IPivotGridBrowserBarItem_Browser() As PivotGridBrowser Implements IPivotGridBrowserBarItem.Browser
			Get
				Return Me.InternalBrowser
			End Get
			Set(ByVal value As PivotGridBrowser)
				Me.InternalBrowser = value
			End Set
		End Property

		Private ReadOnly Property IPivotGridBrowserBarItem_CommandId() As BrowserCommandId Implements IPivotGridBrowserBarItem.CommandId
			Get
				Return Me.InternalCommandId
			End Get
		End Property

		Private Sub IPivotGridBrowserBarItem_Update() Implements IPivotGridBrowserBarItem.Update
			Me.Update()
		End Sub
		#End Region

		#Region "IDisposable implementation"
		Protected Overrides Overloads Sub Dispose(ByVal disposing As Boolean)
			Try
				If disposing Then
					browserHelper.ChangeBrowser(Nothing)
				End If
			Finally
				MyBase.Dispose(disposing)
			End Try
		End Sub
		#End Region
	End Class
	#End Region

	#Region "BrowserCommandBasedBarSubItem"
	Public MustInherit Class BrowserCommandBasedBarSubItem
		Inherits CommandBasedBarSubItem
		Implements IPivotGridBrowserBarItem
		Private browserHelper As BrowserCommandBarItemHelper

		Public Sub New(ByVal manager As BarManager, ByVal pivotGridBrowser As PivotGridBrowser)
			MyBase.New(manager)
			browserHelper = New BrowserCommandBarItemHelper(pivotGridBrowser)
			UpdateItemCaption()
		End Sub

		Protected Property InternalBrowser() As PivotGridBrowser
			Get
				Return browserHelper.Browser
			End Get
			Set(ByVal value As PivotGridBrowser)
				If browserHelper.ChangeBrowser(value) Then
					OnBrowserChanged()
				End If
			End Set
		End Property
		Protected MustOverride ReadOnly Property InternalCommandId() As BrowserCommandId

		Protected Sub Update()
			UpdateItemVisibility()
			UpdateItemChecked()
		End Sub
		Protected Overridable Sub OnBrowserChanged()
		End Sub
		Protected Overrides Function CreateCommand() As Command
			If browserHelper Is Nothing Then
				Return Nothing
			End If
			Return browserHelper.CreateCommand(InternalCommandId)
		End Function

		#Region "IPivotGridBrowserBarItem Members"
		<Browsable(False), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)> _
		Private Property IPivotGridBrowserBarItem_Browser() As PivotGridBrowser Implements IPivotGridBrowserBarItem.Browser
			Get
				Return Me.InternalBrowser
			End Get
			Set(ByVal value As PivotGridBrowser)
				Me.InternalBrowser = value
			End Set
		End Property

		Private ReadOnly Property IPivotGridBrowserBarItem_CommandId() As BrowserCommandId Implements IPivotGridBrowserBarItem.CommandId
			Get
				Return Me.InternalCommandId
			End Get
		End Property

		Private Sub IPivotGridBrowserBarItem_Update() Implements IPivotGridBrowserBarItem.Update
			Me.Update()
		End Sub
		#End Region

		#Region "IDisposable implementation"
		Protected Overrides Overloads Sub Dispose(ByVal disposing As Boolean)
			Try
				If disposing Then
					browserHelper.ChangeBrowser(Nothing)
				End If
			Finally
				MyBase.Dispose(disposing)
			End Try
		End Sub
		#End Region
	End Class
	#End Region

	#Region "BrowserCommandBarItemHelper"
	Friend Class BrowserCommandBarItemHelper
		Private browser_Renamed As PivotGridBrowser

		Public Sub New(ByVal browser As PivotGridBrowser)
			Me.browser_Renamed = browser
		End Sub
		Public Function CreateCommand(ByVal commandId As BrowserCommandId) As Command
			If browser_Renamed Is Nothing Then
				Return Nothing
			End If
			Return browser_Renamed.CreateCommand(commandId)
		End Function
		Public Function ChangeBrowser(ByVal newBrowser As PivotGridBrowser) As Boolean
			If Object.ReferenceEquals(Me.browser_Renamed, newBrowser) Then
				Return False
			End If
			UnsubscribeControlEvents()
			Me.browser_Renamed = newBrowser
			If Me.browser_Renamed IsNot Nothing Then
				SubscribeControlEvents()
			End If
			Return True
		End Function
		Public ReadOnly Property Browser() As PivotGridBrowser
			Get
				Return Me.browser_Renamed
			End Get
		End Property

		Protected Overridable Sub SubscribeControlEvents()
			If Me.browser_Renamed Is Nothing Then
				Return
			End If
			'TODO: browser.BeforeDispose += new EventHandler(...);
		End Sub
		Protected Overridable Sub UnsubscribeControlEvents()
			If Me.browser_Renamed Is Nothing Then
				Return
			End If
			'TODO: browser.BeforeDispose -= new EventHandler(...);
		End Sub
	End Class
	#End Region

	#Region "ConnectToItem"
	Public Class ConnectToItem
		Inherits BrowserCommandBarButtonItem
		Public Sub New(ByVal manager As BarManager, ByVal pivotGridBrowser As PivotGridBrowser)
			MyBase.New(manager, pivotGridBrowser)
		End Sub
		Protected Overrides ReadOnly Property InternalCommandId() As BrowserCommandId
			Get
				Return BrowserCommandId.ConnectTo
			End Get
		End Property
	End Class
	#End Region

	#Region "CreateReportItem"
	Public Class CreateReportItem
		Inherits BrowserCommandBarButtonItem
		Public Sub New(ByVal manager As BarManager, ByVal pivotGridBrowser As PivotGridBrowser)
			MyBase.New(manager, pivotGridBrowser)
		End Sub
		Protected Overrides ReadOnly Property InternalCommandId() As BrowserCommandId
			Get
				Return BrowserCommandId.CreateReport
			End Get
		End Property
	End Class
	#End Region

	#Region "ShowChartFromPivotItem"
	Public Class ShowChartFromPivotItem
		Inherits BrowserCommandBarButtonItem
		Public Sub New(ByVal manager As BarManager, ByVal pivotGridBrowser As PivotGridBrowser)
			MyBase.New(manager, pivotGridBrowser)
		End Sub
		Protected Overrides ReadOnly Property InternalCommandId() As BrowserCommandId
			Get
				Return BrowserCommandId.ShowChartFromPivot
			End Get
		End Property
	End Class
	#End Region

	#Region "ShowTotalsItem"
	Public Class ShowTotalsItem
		Inherits BrowserCommandBarCheckItem
		Public Sub New(ByVal manager As BarManager, ByVal pivotGridBrowser As PivotGridBrowser)
			MyBase.New(manager, pivotGridBrowser)
		End Sub
		Protected Overrides ReadOnly Property InternalCommandId() As BrowserCommandId
			Get
				Return BrowserCommandId.ShowTotals
			End Get
		End Property
		Protected Overrides Sub ApplyChecking()
			InternalBrowser.ShowTotals = Me.Checked
		End Sub
	End Class
	#End Region

	#Region "ShowSelectionItem"
	Public Class ShowSelectionItem
		Inherits BrowserCommandBarCheckItem
		Public Sub New(ByVal manager As BarManager, ByVal pivotGridBrowser As PivotGridBrowser)
			MyBase.New(manager, pivotGridBrowser)
		End Sub
		Protected Overrides ReadOnly Property InternalCommandId() As BrowserCommandId
			Get
				Return BrowserCommandId.ShowSelection
			End Get
		End Property
		Protected Overrides Sub ApplyChecking()
			InternalBrowser.ShowSelection = Me.Checked
		End Sub
	End Class
	#End Region

	#Region "ChartViewSetSubItem"
	Public Class ChartViewSetSubItem
		Inherits BrowserCommandBasedBarSubItem
		Public Sub New(ByVal manager As BarManager, ByVal pivotGridBrowser As PivotGridBrowser)
			MyBase.New(manager, pivotGridBrowser)
			InitSubItems(manager, pivotGridBrowser)
		End Sub
		Private Sub InitSubItems(ByVal manager As BarManager, ByVal pivotGridBrowser As PivotGridBrowser)
			Dim viewTypes As Array = System.Enum.GetValues(GetType(ViewType))
			For Each viewType1 As Object In viewTypes
				Dim item As New ChartViewItem(manager, pivotGridBrowser, CType(viewType1, ViewType))
				AddItem(item)
				item.GroupIndex = 1
				AddHandler item.ItemClick, AddressOf OnItemCheckedChanged
				AddHandler item.CheckedChanged, AddressOf OnItemCheckedChanged
				If Comparer.Equals(item.ViewType, ViewType.Pie3D) Then
					item.Checked = True
				End If
			Next viewType1
		End Sub
		Protected Sub OnItemCheckedChanged(ByVal sender As Object, ByVal e As ItemClickEventArgs)
			Dim chartViewItem As ChartViewItem = CType(e.Item, ChartViewItem)
			Caption = GetDefaultCaption() + chartViewItem.ViewType.ToString()
		End Sub
		Protected Overrides ReadOnly Property InternalCommandId() As BrowserCommandId
			Get
				Return BrowserCommandId.ChartViewSet
			End Get
		End Property
	End Class
	#End Region
	#Region "ChartViewSubItemUIState"
	Public Class ChartViewSubItemUIState 'BarSubItemUIState
		Inherits DevExpress.XtraBars.Commands.Internal.BarCheckItemUIState
		Public Sub New(ByVal item As ChartViewItem)
			MyBase.New(item)
		End Sub
		Public Overrides Property EditValue() As Object
			Get
				Return Item.ViewType
			End Get
			Set(ByVal value As Object)
				Item.CheckViewType(CType(value, ViewType))
			End Set
		End Property
		Protected Shadows ReadOnly Property Item() As ChartViewItem
			Get
				Return CType(MyBase.Item, ChartViewItem)
			End Get
		End Property
	End Class
	#End Region

	#Region "ChartViewItem"
	Public Class ChartViewItem
		Inherits BrowserCommandBarCheckItem
		Private fViewType As ViewType

		Public Sub New(ByVal manager As BarManager, ByVal pivotGridBrowser As PivotGridBrowser, ByVal viewType As ViewType)
			MyBase.New(manager, pivotGridBrowser)
			Me.fViewType = viewType
			Me.Caption = viewType.ToString()
		End Sub
		Public ReadOnly Property ViewType() As ViewType
			Get
				Return fViewType
			End Get
		End Property
		Public Sub CheckViewType(ByVal viewType As ViewType)
			If Comparer.Equals(Me.fViewType, viewType) Then
				Me.Checked = True
			End If
		End Sub
		Protected Overrides ReadOnly Property InternalCommandId() As BrowserCommandId
			Get
				Return BrowserCommandId.ChartView
			End Get
		End Property
		Protected Overrides Function CreateCommandUIState(ByVal command As Command) As ICommandUIState
			Return New ChartViewSubItemUIState(Me)
		End Function
		Protected Overrides Sub ApplyChecking()
			InternalBrowser.ChartViewType = Me.fViewType
		End Sub
	End Class
	#End Region
End Namespace
