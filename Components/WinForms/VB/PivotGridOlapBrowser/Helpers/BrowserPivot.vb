Imports Microsoft.VisualBasic
Imports DevExpress.Utils.Menu
Imports DevExpress.XtraEditors
Imports DevExpress.XtraPivotGrid
Imports PivotGridOlapBrowser.Helpers
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.IO
Imports System.Windows.Forms
Imports DevExpress.XtraReports.UI

Namespace PivotGridOlapBrowser
	Public Enum DataState
		[Default]
		SingleColumn
		SingleRow
	End Enum
	Partial Public Class BrowserPivot
		Inherits UserControl
		Implements IXRControlCreatable
		Private Shared ReadOnly evtIsBusyChanged As Object = New Object()

		Private fIsBusy As Boolean
		Private fConnectionString As String

		Private ReadOnly memberTooltipController As MemberPropertiesToolTipController

		Public Sub New()
			InitializeComponent()
			Me.memberTooltipController = New MemberPropertiesToolTipController(pivotGrid)
		End Sub

		<DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)> _
		Public Property IsBusy() As Boolean
			Get
				Return fIsBusy
			End Get
			Protected Set(ByVal value As Boolean)
				If fIsBusy = value Then
					Return
				End If
				fIsBusy = value
				OnIsBusyChanged()
			End Set
		End Property

		<DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)> _
		Public Property ConnectionString() As String
			Get
				Return fConnectionString
			End Get
			Set(ByVal value As String)
				If fConnectionString = value Then
					Return
				End If
				fConnectionString = value
				OnConnectionStringChanged()
			End Set
		End Property

		<DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)> _
		Public ReadOnly Property Fields() As PivotGridFieldCollection
			Get
				Return pivotGrid.Fields
			End Get
		End Property

		Public Sub SaveLayoutToStream(ByVal stream As Stream)
			pivotGrid.SaveLayoutToStream(stream)
		End Sub

		Public Sub SaveCollapsedStateToStream(ByVal stream As Stream)
			pivotGrid.SaveCollapsedStateToStream(stream)
		End Sub

		Public ReadOnly Property DataSourceClone() As PivotGridAdomdDataSource
			Get
				Return TryCast(pivotGrid.CreateOLAPDataSourceClone(), PivotGridAdomdDataSource)
			End Get
		End Property

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

		Public Custom Event CellDoubleClick As PivotCellEventHandler
			AddHandler(ByVal value As PivotCellEventHandler)
				AddHandler pivotGrid.CellDoubleClick, value
			End AddHandler
			RemoveHandler(ByVal value As PivotCellEventHandler)
				RemoveHandler pivotGrid.CellDoubleClick, value
			End RemoveHandler
			RaiseEvent(ByVal sender As Object, ByVal e As EventArgs)
			End RaiseEvent
		End Event

		Public ReadOnly Property Data() As DataTable
			Get
				Return PivotDataExtractor.GetDataTable(pivotGrid)
			End Get
		End Property

		Public ReadOnly Property State() As DataState
			Get
				Dim currentState As DataState = DataState.Default
				If pivotGrid.GetFieldsByArea(PivotArea.RowArea).Count = 0 Then
					currentState = DataState.SingleRow
				End If
				If pivotGrid.GetFieldsByArea(PivotArea.ColumnArea).Count = 0 Then
					currentState = DataState.SingleColumn
				End If
				If currentState = DataState.Default AndAlso pivotGrid.Cells.MultiSelection.SelectedCells.Count > 1 Then
					Dim rect As Rectangle = pivotGrid.Cells.MultiSelection.SelectedCells.Rectangle
					If rect.Width = 1 Then
						currentState = DataState.SingleRow
					End If
					If rect.Height = 1 Then
						currentState = DataState.SingleColumn
					End If
				End If
				Return currentState
			End Get
		End Property
		Protected Overrides Sub OnLoad(ByVal e As EventArgs)
			MyBase.OnLoad(e)
			pivotGrid.FieldsCustomization(fieldListContainer)
		End Sub

		Private Sub pivotGrid_ShowMenu(ByVal sender As Object, ByVal e As DevExpress.XtraPivotGrid.PopupMenuShowingEventArgs) Handles pivotGrid.PopupMenuShowing
			If e.MenuType <> PivotGridMenuType.Header AndAlso e.MenuType <> PivotGridMenuType.HeaderArea Then
				Return
			End If

			For Each item As DXMenuItem In e.Menu.Items
				If Object.Equals(item.Tag, -1001) Then
					e.Menu.Items.Remove(item)
					Exit For
				End If
			Next item
		End Sub

		Private Sub pivotGrid_BeginRefresh(ByVal sender As Object, ByVal e As EventArgs) Handles pivotGrid.BeginRefresh
			IsBusy = True
		End Sub

		Private Sub pivotGrid_EndRefresh(ByVal sender As Object, ByVal e As EventArgs) Handles pivotGrid.EndRefresh
			IsBusy = False
		End Sub

		Private Sub pivotGrid_FieldValueExpanding(ByVal sender As Object, ByVal e As PivotFieldValueCancelEventArgs) Handles pivotGrid.FieldValueExpanding
			IsBusy = True
		End Sub

		Private Sub pivotGrid_FieldValueCollapsing(ByVal sender As Object, ByVal e As PivotFieldValueCancelEventArgs) Handles pivotGrid.FieldValueCollapsing
			IsBusy = True
		End Sub

		Private Sub pivotGrid_FieldValueExpanded(ByVal sender As Object, ByVal e As PivotFieldValueEventArgs) Handles pivotGrid.FieldValueExpanded
			IsBusy = False
		End Sub

		Private Sub pivotGrid_FieldValueCollapsed(ByVal sender As Object, ByVal e As PivotFieldValueEventArgs) Handles pivotGrid.FieldValueCollapsed
			IsBusy = False
		End Sub

		Private Sub pivotGrid_FieldValueNotExpanded(ByVal sender As Object, ByVal e As PivotFieldValueEventArgs) Handles pivotGrid.FieldValueNotExpanded
			IsBusy = False
			XtraMessageBox.Show("Cannot show details for this item: it has no child items.", Nothing, MessageBoxButtons.OK, MessageBoxIcon.Information)
		End Sub

		Private Sub pivotGrid_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles pivotGrid.MouseMove
			Dim hitInfo As PivotGridHitInfo = pivotGrid.CalcHitInfo(e.Location)
			If hitInfo.HitTest = PivotGridHitTest.Value AndAlso hitInfo.ValueInfo.Field IsNot Nothing AndAlso hitInfo.ValueInfo.Field.IsColumnOrRow Then
				Dim member As IOLAPMember = pivotGrid.GetFieldValueOLAPMember(hitInfo.ValueInfo.Field, hitInfo.ValueInfo.MinIndex)
				If member IsNot Nothing Then
					Dim pt As Point = e.Location
					pt.Offset(10, 10)
					Me.memberTooltipController.ShowHint(member, pt)
					Return
				End If
			End If
			Me.memberTooltipController.HideHint(True)
		End Sub

		Protected Sub OnIsBusyChanged()
			Dim handler As EventHandler = CType(Events(evtIsBusyChanged), EventHandler)
			If handler IsNot Nothing Then
				handler(Me, EventArgs.Empty)
			End If
		End Sub

		Protected Sub OnConnectionStringChanged()
			IsBusy = True
			Try
				pivotGrid.Fields.Clear()
				pivotGrid.OLAPDataProvider = OLAPDataProvider.Adomd
				pivotGrid.OLAPConnectionString = ConnectionString
				RetrieveFields()
			Catch e As Exception
				Throw e
			Finally
				IsBusy = False
			End Try
		End Sub

		Protected Sub RetrieveFields()
			pivotGrid.BeginUpdate()
			pivotGrid.RetrieveFields(PivotArea.FilterArea, False)
			For i As Integer = 0 To pivotGrid.Fields.Count - 1
				pivotGrid.Fields(i).SortMode = PivotSortMode.None
			Next i
			pivotGrid.EndUpdate()
		End Sub

		#Region "IXRControlCreatable Members"
		Public Shadows Function CreateControl() As XRControl Implements IXRControlCreatable.CreateControl
			Return XRPivotGridEx.Create(Me)
		End Function
		#End Region
	End Class
End Namespace
