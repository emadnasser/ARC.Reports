Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Text

Namespace PivotGridOlapBrowser.Commands
	Public Class BrowserLocalizer
		Shared Sub New()
		End Sub
		Public Shared Function GetString(ByVal id As BrowserCommandStringId) As String
			Select Case id
				Case BrowserCommandStringId.Caption_ConnectTo
					Return "Connect To..."
				Case BrowserCommandStringId.Caption_CreateReport
					Return "Create Report..."
				Case BrowserCommandStringId.Caption_ShowChartFromPivot
					Return "Show Chart From Pivot..."
				Case BrowserCommandStringId.Caption_ShowTotals
					Return "Show Totals"
				Case BrowserCommandStringId.Caption_ShowSelection
					Return "Show Selection Only"
				Case BrowserCommandStringId.Caption_ChartViewSet
					Return "Chart View: "
				Case Else
					Return "Custom..."
			End Select
		End Function
		Public Shared Function GetString(ByVal id As BrowserStringId) As String
			Select Case id
				Case BrowserStringId.Msg_IsNotValid
					Return "'{0}' is not a valid value for '{1}'"
				Case BrowserStringId.Msg_InternalError
					Return "An internal error occurred."
				Case Else
					Return "An undefined error occurred."
			End Select
		End Function
		Public Shared Function GetFailedString(ByVal id As BrowserCommandStringId) As String
			Select Case id
				Case BrowserCommandStringId.Caption_ConnectTo
					Return "Failed to connect to the datasource."
				Case BrowserCommandStringId.Caption_ShowChartFromPivot
					Return "This data can not be shown in a chart control."
				Case Else
					Return "Unexpected exception."
			End Select
		End Function
	End Class
End Namespace
