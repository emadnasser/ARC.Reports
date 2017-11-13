Imports Microsoft.VisualBasic
Imports DevExpress.Utils
Imports DevExpress.Utils.Commands
Imports System
Imports System.Collections.Generic
Imports System.Runtime.InteropServices

Namespace PivotGridOlapBrowser.Commands
	Public Enum BrowserStringId
		Msg_IsNotValid
		Msg_InternalError
	End Enum
	Public Enum BrowserCommandStringId
		Caption_None = -1
		Caption_ConnectTo = 0
		Caption_CreateReport = 1
		Caption_ShowChartFromPivot = 2
		Caption_ShowTotals = 3
		Caption_ShowSelection = 4
		Caption_ChartViewSet = 5
		Caption_ChartView = 6
	End Enum
	#Region "BrowserCommandId"
	<Serializable, StructLayout(LayoutKind.Sequential), ComVisible(False)> _
	Public Structure BrowserCommandId
		Implements IConvertToInt(Of BrowserCommandId), IEquatable(Of BrowserCommandId)
		Public Shared ReadOnly None As BrowserCommandId
		Public Shared ReadOnly ConnectTo As BrowserCommandId
		Public Shared ReadOnly CreateReport As BrowserCommandId
		Public Shared ReadOnly ShowChartFromPivot As BrowserCommandId
		Public Shared ReadOnly ShowTotals As BrowserCommandId
		Public Shared ReadOnly ShowSelection As BrowserCommandId
		Public Shared ReadOnly ChartViewSet As BrowserCommandId
		Public Shared ReadOnly ChartView As BrowserCommandId


		Private ReadOnly id As Integer

		Public Sub New(ByVal value As Integer)
			Me.id = value
		End Sub
		Public Overrides Overloads Function Equals(ByVal obj As Object) As Boolean
			Return ((TypeOf obj Is BrowserCommandId) AndAlso (Me.id = (CType(obj, BrowserCommandId)).id))
		End Function
		Public Overrides Function GetHashCode() As Integer
			Return id.GetHashCode()
		End Function
		Public Overrides Function ToString() As String
			Return id.ToString()
		End Function
		Public Shared Operator =(ByVal id1 As BrowserCommandId, ByVal id2 As BrowserCommandId) As Boolean
			Return id1.id = id2.id
		End Operator
		Public Shared Operator <>(ByVal id1 As BrowserCommandId, ByVal id2 As BrowserCommandId) As Boolean
			Return id1.id <> id2.id
		End Operator

		#Region "IConvertToInt<BrowserCommandId> Members"
		Private Function IConvertToInt_ToInt() As Integer Implements IConvertToInt(Of BrowserCommandId).ToInt
			Return id
		End Function
		Private Function FromInt(ByVal value As Integer) As BrowserCommandId Implements IConvertToInt(Of BrowserCommandId).FromInt
			Return New BrowserCommandId(value)
		End Function
		#End Region

		#Region "IEquatable<BrowserCommandId> Members"
		Public Overloads Function Equals(ByVal other As BrowserCommandId) As Boolean Implements IEquatable(Of BrowserCommandId).Equals
			Return Me.id = other.id
		End Function
		#End Region
		Shared Sub New()
			None = New BrowserCommandId(-1)
			ConnectTo = New BrowserCommandId(0)
			CreateReport = New BrowserCommandId(1)
			ShowChartFromPivot = New BrowserCommandId(2)
			ShowTotals = New BrowserCommandId(3)
			ShowSelection = New BrowserCommandId(4)
			ChartViewSet = New BrowserCommandId(5)
			ChartView = New BrowserCommandId(6)
		End Sub
	End Structure
	#End Region

	#Region "BrowserCommand (abstract class)"
	Public MustInherit Class BrowserCommand
		Inherits Command
		Private ReadOnly control_Renamed As PivotGridBrowser

		Public Sub New(ByVal control As PivotGridBrowser)
			Me.control_Renamed = control
		End Sub
		Public ReadOnly Property Control() As PivotGridBrowser
			Get
				Return control_Renamed
			End Get
		End Property
		Public MustOverride ReadOnly Property Id() As BrowserCommandId
		Public Overrides ReadOnly Property MenuCaption() As String
			Get
				Return BrowserLocalizer.GetString(MenuCaptionStringId)
			End Get
		End Property
		Public Overrides ReadOnly Property Description() As String
			Get
				Return BrowserLocalizer.GetString(DescriptionStringId)
			End Get
		End Property
		Public ReadOnly Property CommandFailedString() As String
			Get
				Return BrowserLocalizer.GetFailedString(MenuCaptionStringId)
			End Get
		End Property
		Public Overrides Sub Execute()
			If ExecuteCore() = False Then
				OnCommandFailed()
			End If
		End Sub
		Public Overrides Sub ForceExecute(ByVal state As ICommandUIState)
			' do nothing
		End Sub
		Protected Friend MustOverride ReadOnly Property MenuCaptionStringId() As BrowserCommandStringId
		Protected Friend ReadOnly Property DescriptionStringId() As BrowserCommandStringId
			Get
				Return MenuCaptionStringId
			End Get
		End Property
		Protected Friend MustOverride Function ExecuteCore() As Boolean?
		Protected Overrides Sub UpdateUIStateCore(ByVal state As ICommandUIState)
			Dim isCommandActual? As Boolean = Nothing
			If Control IsNot Nothing Then
				isCommandActual = Control.GetIsCommandActual(Id)
			End If
			state.Enabled = isCommandActual.GetValueOrDefault() = True
			state.Visible = state.Enabled
		End Sub
		Protected Overridable Sub OnCommandFailed()
			If Control IsNot Nothing Then
				Control.OnCommandFailed(Id, CommandFailedString)
			End If
		End Sub
	End Class
	#End Region

	Public Class ConnectToCommand
		Inherits BrowserCommand
		Public Sub New(ByVal control As PivotGridBrowser)
			MyBase.New(control)
		End Sub
		Public Overrides ReadOnly Property Id() As BrowserCommandId
			Get
				Return BrowserCommandId.ConnectTo
			End Get
		End Property
		Protected Friend Overrides ReadOnly Property MenuCaptionStringId() As BrowserCommandStringId
			Get
				Return BrowserCommandStringId.Caption_ConnectTo
			End Get
		End Property
		Protected Friend Overrides Function ExecuteCore() As Boolean?
			Return Control.ShowConnectionDialog()
		End Function
		Protected Overrides Sub UpdateUIStateCore(ByVal state As ICommandUIState)
			state.Visible = True
			state.Enabled = state.Visible
		End Sub
	End Class

	Public Class CreateReportCommand
		Inherits BrowserCommand
		Public Sub New(ByVal control As PivotGridBrowser)
			MyBase.New(control)
		End Sub
		Public Overrides ReadOnly Property Id() As BrowserCommandId
			Get
				Return BrowserCommandId.CreateReport
			End Get
		End Property
		Protected Friend Overrides ReadOnly Property MenuCaptionStringId() As BrowserCommandStringId
			Get
				Return BrowserCommandStringId.Caption_CreateReport
			End Get
		End Property
		Protected Friend Overrides Function ExecuteCore() As Boolean?
			Return Control.ShowReport()
		End Function
	End Class

	Public Class ShowChartFromPivotCommand
		Inherits BrowserCommand
		Public Sub New(ByVal control As PivotGridBrowser)
			MyBase.New(control)
		End Sub
		Public Overrides ReadOnly Property Id() As BrowserCommandId
			Get
				Return BrowserCommandId.ShowChartFromPivot
			End Get
		End Property
		Protected Friend Overrides ReadOnly Property MenuCaptionStringId() As BrowserCommandStringId
			Get
				Return BrowserCommandStringId.Caption_ShowChartFromPivot
			End Get
		End Property
		Protected Friend Overrides Function ExecuteCore() As Boolean?
			Return Control.ShowChartFromPivot()
		End Function
	End Class

	Public Class ShowTotalsCommand
		Inherits BrowserCommand
		Public Sub New(ByVal control As PivotGridBrowser)
			MyBase.New(control)
		End Sub
		Public Overrides ReadOnly Property Id() As BrowserCommandId
			Get
				Return BrowserCommandId.ShowTotals
			End Get
		End Property
		Protected Friend Overrides ReadOnly Property MenuCaptionStringId() As BrowserCommandStringId
			Get
				Return BrowserCommandStringId.Caption_ShowTotals
			End Get
		End Property
		Protected Friend Overrides Function ExecuteCore() As Boolean?
			Return Nothing
		End Function
		Protected Overrides Sub UpdateUIStateCore(ByVal state As ICommandUIState)
			MyBase.UpdateUIStateCore(state)
			state.Checked = Control.ShowTotals
		End Sub
	End Class

	Public Class ShowSelectionCommand
		Inherits BrowserCommand
		Public Sub New(ByVal control As PivotGridBrowser)
			MyBase.New(control)
		End Sub
		Public Overrides ReadOnly Property Id() As BrowserCommandId
			Get
				Return BrowserCommandId.ShowSelection
			End Get
		End Property
		Protected Friend Overrides ReadOnly Property MenuCaptionStringId() As BrowserCommandStringId
			Get
				Return BrowserCommandStringId.Caption_ShowSelection
			End Get
		End Property
		Protected Friend Overrides Function ExecuteCore() As Boolean?
			Return Nothing
		End Function
		Protected Overrides Sub UpdateUIStateCore(ByVal state As ICommandUIState)
			MyBase.UpdateUIStateCore(state)
			state.Enabled = Control.ShowSelection.HasValue
			state.Checked = Control.ShowSelection.Equals(CType(True, Boolean?))
		End Sub
	End Class

	Public Class ChartViewSetCommand
		Inherits BrowserCommand
		Public Sub New(ByVal control As PivotGridBrowser)
			MyBase.New(control)
		End Sub
		Public Overrides ReadOnly Property Id() As BrowserCommandId
			Get
				Return BrowserCommandId.ChartViewSet
			End Get
		End Property
		Protected Friend Overrides ReadOnly Property MenuCaptionStringId() As BrowserCommandStringId
			Get
				Return BrowserCommandStringId.Caption_ChartViewSet
			End Get
		End Property
		Protected Friend Overrides Function ExecuteCore() As Boolean?
			Return Nothing
		End Function
	End Class

	Public Class ChartViewCommand
		Inherits BrowserCommand
		Public Sub New(ByVal control As PivotGridBrowser)
			MyBase.New(control)
		End Sub
		Public Overrides ReadOnly Property Id() As BrowserCommandId
			Get
				Return BrowserCommandId.ChartView
			End Get
		End Property
		Protected Friend Overrides ReadOnly Property MenuCaptionStringId() As BrowserCommandStringId
			Get
				Return BrowserCommandStringId.Caption_ChartView
			End Get
		End Property
		Protected Friend Overrides Function ExecuteCore() As Boolean?
			Return Nothing
		End Function
		Protected Overrides Sub UpdateUIStateCore(ByVal state As ICommandUIState)
			MyBase.UpdateUIStateCore(state)
			state.EditValue = Control.ChartViewType
		End Sub
	End Class
End Namespace
