Imports Microsoft.VisualBasic
Imports System
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports DevExpress.Web.ASPxPivotGrid
Imports System.Collections.Generic
Imports System.Web.SessionState

Partial Public Class UndoRedo
	Inherits Page

	Private _stateController As PivotStateController
	Private ReadOnly Property StateController() As PivotStateController
		Get
			If _stateController Is Nothing Then
				_stateController = New PivotStateController(ASPxPivotGrid1, Session)
			End If
			Return _stateController
		End Get
	End Property

	Private ReadOnly Property HasStateController() As Boolean
		Get
			Return _stateController IsNot Nothing
		End Get
	End Property

	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		If (Not IsPostBack) AndAlso (Not IsCallback) Then
			StateController.ClearState()
			SaveCurrentStateAndUpdateControlsState()
		End If
	End Sub

	Private Sub SaveCurrentStateAndUpdateControlsState()
		StateController.SaveCurrentState()
		CommitStateChanges()
	End Sub
	Private Sub CommitStateChanges()
		SetUpdateButtonsJSProperties()
		StateController.SaveStateToSession(Session)
	End Sub

	Private Sub SetUpdateButtonsJSProperties()
		ASPxPivotGrid1.JSProperties("cpIsUndoEnabled") = StateController.CanLoadPrevState
		ASPxPivotGrid1.JSProperties("cpIsRedoEnabled") = StateController.CanLoadNextState
	End Sub

	Protected Sub ASPxPivotGrid1_GridLayout(ByVal sender As Object, ByVal e As EventArgs)
		If (Not HasStateController) AndAlso (Not ASPxPivotGrid1.IsPrefilterPopupVisible) Then
			SaveCurrentStateAndUpdateControlsState()
		End If
	End Sub

	Protected Sub ASPxPivotGrid1_CustomCallback(ByVal sender As Object, ByVal e As PivotGridCustomCallbackEventArgs)
		If e.Parameters = "UNDO" Then
			StateController.LoadPrevState()
		ElseIf e.Parameters = "REDO" Then
			StateController.LoadNextState()
		End If
		CommitStateChanges()
	End Sub

	Private Class PivotStateController
		Private _storage As StateStorage
		Private Const SessionStateStorageKey As String = "StateStorage"

		Public Sub New(ByVal _pivotGrid As ASPxPivotGrid, ByVal session As HttpSessionState)
			PivotGrid = _pivotGrid
			Me._storage = CType(session(SessionStateStorageKey), StateStorage)
			If Me._storage Is Nothing Then
				Me._storage = New StateStorage()
			End If
		End Sub


		Private ReadOnly Property Storage() As StateStorage
			Get
				Return _storage
			End Get
		End Property
		Private Property PivotGrid() As ASPxPivotGrid

		Public ReadOnly Property CanLoadPrevState() As Boolean
			Get
				Return Not Storage.IsFirstLocation
			End Get
		End Property
		Public ReadOnly Property CanLoadNextState() As Boolean
			Get
				Return Not Storage.IsLastLocation
			End Get
		End Property

		Public Sub ClearState()
			Storage.Clear()
		End Sub

		Public Sub SaveCurrentState()
			Dim layoutState As String = PivotGrid.SaveLayoutToString()
			Dim collapsedState As String = PivotGrid.SaveCollapsedStateToString()
			Storage.AddNewState(New StateRecord(layoutState, collapsedState))
		End Sub

		Public Sub LoadPrevState()
			Dim state As StateRecord = Storage.GetPrevState()
			LoadState(state)
		End Sub

		Public Sub LoadNextState()
			Dim state As StateRecord = Storage.GetNextState()
			LoadState(state)
		End Sub

		Private Sub LoadState(ByVal state As StateRecord)
			If state Is Nothing Then
				Return
			End If
			PivotGrid.LoadLayoutFromString(state.LayoutState)
			PivotGrid.LoadCollapsedStateFromString(state.CollapsedState)
		End Sub

		Public Sub SaveStateToSession(ByVal session As HttpSessionState)
			session(SessionStateStorageKey) = _storage
		End Sub
	End Class

	<Serializable> _
	Private Class StateStorage
		Private _records As List(Of StateRecord)
		Public Sub New()
			_records = New List(Of StateRecord)()
			ClearState()
		End Sub

		Public Sub Clear()
			ClearState()
		End Sub
		Private Sub ClearState()
			Records.Clear()
			CurrentLocation = -1
		End Sub
		Public ReadOnly Property Records() As List(Of StateRecord)
			Get
				Return _records
			End Get
		End Property
		Public Property CurrentLocation() As Integer
		Private ReadOnly Property IsEmpty() As Boolean
			Get
				Return CurrentLocation = -1
			End Get
		End Property
		Public ReadOnly Property IsFirstLocation() As Boolean
			Get
				If IsEmpty Then
					Return True
				End If
				Return CurrentLocation = 0
			End Get
		End Property
		Public ReadOnly Property IsLastLocation() As Boolean
			Get
				If IsEmpty Then
					Return True
				End If
				Return CurrentLocation = Records.Count - 1
			End Get
		End Property
		Public Sub AddNewState(ByVal state As StateRecord)
			If (Not IsEmpty) AndAlso CurrentLocation <> Records.Count - 1 Then
				Records.RemoveRange(CurrentLocation + 1, Records.Count - (CurrentLocation + 1))
			End If
			CurrentLocation += 1
			Records.Insert(CurrentLocation, state)
		End Sub
		Public Function GetPrevState() As StateRecord
			If IsEmpty OrElse IsFirstLocation Then
				Return Nothing
			End If
			CurrentLocation -= 1
			Return Records(CurrentLocation)
		End Function
		Public Function GetNextState() As StateRecord
			If IsEmpty OrElse IsLastLocation Then
				Return Nothing
			End If
			CurrentLocation += 1
			Return Records(CurrentLocation)
		End Function
	End Class

	<Serializable> _
	Public Class StateRecord
		Public Sub New(ByVal layoutState As String, ByVal collapsedState As String)
			LayoutState = layoutState
			CollapsedState = collapsedState
		End Sub
		Public Property LayoutState() As String
		Public Property CollapsedState() As String
	End Class
End Class
