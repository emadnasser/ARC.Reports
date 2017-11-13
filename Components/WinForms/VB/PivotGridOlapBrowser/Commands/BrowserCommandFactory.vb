Imports Microsoft.VisualBasic
Imports System
Imports System.Text
Imports System.Reflection
Imports System.Collections.Generic
Imports DevExpress.Data
Imports DevExpress.Utils
Imports DevExpress.Utils.Commands

Namespace PivotGridOlapBrowser.Commands.Services
	#Region "Exceptions"
	Public NotInheritable Class Exceptions
		Private Sub New()
		End Sub
		Public Shared Sub ThrowArgumentException(ByVal propName As String, ByVal val As Object)
			Dim valueStr As String = If((val IsNot Nothing), val.ToString(), "null")
			Dim s As String = String.Format(BrowserLocalizer.GetString(BrowserStringId.Msg_IsNotValid), valueStr, propName)
			Throw New ArgumentException(s)
		End Sub
		Public Shared Sub ThrowInternalException()
			Throw New Exception(BrowserLocalizer.GetString(BrowserStringId.Msg_InternalError))
		End Sub
		Public Shared Sub ThrowArgumentNullException(ByVal propName As String)
			Throw New ArgumentNullException(propName)
		End Sub
		Public Shared Sub ThrowInvalidOperationException(ByVal id As BrowserStringId)
			Throw New InvalidOperationException(BrowserLocalizer.GetString(id))
		End Sub
	End Class
	#End Region

	#Region "IBrowserCommandFactoryService"
	Public Interface IBrowserCommandFactoryService
		Function CreateCommand(ByVal id As BrowserCommandId) As BrowserCommand
	End Interface
	#End Region    

	#Region "BrowserCommandConstructorTable"
	Public Class BrowserCommandConstructorTable
		Inherits Dictionary(Of BrowserCommandId, ConstructorInfo)
	End Class
	#End Region
	#Region "BrowserCommandFactoryService"
	Public Class BrowserCommandFactoryService
		Implements IBrowserCommandFactoryService
		#Region "Fields"
		Private ReadOnly control_Renamed As PivotGridBrowser
		Private Shared ReadOnly constructorParametersInterface() As Type = { GetType(PivotGridBrowser) }
		Private ReadOnly commandConstructorTable As BrowserCommandConstructorTable
		#End Region

		Public Sub New(ByVal control As PivotGridBrowser)
			Guard.ArgumentNotNull(control, "control")
			Me.control_Renamed = control
			Me.commandConstructorTable = CreateCommandConstructorTable()
		End Sub

		Public ReadOnly Property Control() As PivotGridBrowser
			Get
				Return control_Renamed
			End Get
		End Property

		Protected Friend Function CreateCommandConstructorTable() As BrowserCommandConstructorTable
			Dim result As New BrowserCommandConstructorTable()
			PopulateConstructorTable(result)
			Return result
		End Function
		Protected Sub AddCommandConstructor(ByVal table As BrowserCommandConstructorTable, ByVal commandId As BrowserCommandId, ByVal commandType As Type)
			Dim ci As ConstructorInfo = GetConstructorInfo(commandType)
			If ci Is Nothing Then
				Exceptions.ThrowArgumentException("commandType", commandType)
			End If
			table.Add(commandId, ci)
		End Sub
		Protected Friend Overridable Function GetConstructorInfo(ByVal commandType As Type) As ConstructorInfo
			Return commandType.GetConstructor(constructorParametersInterface)
		End Function
		Protected Friend Overridable Sub PopulateConstructorTable(ByVal table As BrowserCommandConstructorTable)
			AddCommandConstructor(table, BrowserCommandId.ConnectTo, GetType(ConnectToCommand))
			AddCommandConstructor(table, BrowserCommandId.CreateReport, GetType(CreateReportCommand))
			AddCommandConstructor(table, BrowserCommandId.ShowChartFromPivot, GetType(ShowChartFromPivotCommand))
			AddCommandConstructor(table, BrowserCommandId.ShowTotals, GetType(ShowTotalsCommand))
			AddCommandConstructor(table, BrowserCommandId.ShowSelection, GetType(ShowSelectionCommand))
			AddCommandConstructor(table, BrowserCommandId.ChartViewSet, GetType(ChartViewSetCommand))
			AddCommandConstructor(table, BrowserCommandId.ChartView, GetType(ChartViewCommand))
		End Sub

		#Region "ICommandFactoryService Members"
		Public Overridable Function CreateCommand(ByVal commandId As BrowserCommandId) As BrowserCommand Implements IBrowserCommandFactoryService.CreateCommand
			Dim ci As ConstructorInfo = Nothing
			If commandConstructorTable.TryGetValue(commandId, ci) Then
				Return CType(ci.Invoke(New Object() { Control }), BrowserCommand)
			Else
				Exceptions.ThrowArgumentException("commandId", commandId)
				Return Nothing
			End If
		End Function
		#End Region
	End Class
	#End Region
End Namespace
