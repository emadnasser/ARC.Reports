Imports Microsoft.VisualBasic
Imports System.Collections.Generic
Imports System.Text.RegularExpressions
Imports DevExpress.Web

Public MustInherit Class BasePropertyChangedHandler
	Public Delegate Sub PropertyChangedAction(ByVal propValue As String)
	Private actionsCore As Dictionary(Of String, PropertyChangedAction)
	'
	Public Sub New()
		actionsCore = New Dictionary(Of String, PropertyChangedAction)()
		CreateActions()
	End Sub
	Public Sub ProcessPropertyChanged(ByVal propName As String, ByVal propValue As String)
		Dim action As PropertyChangedAction = Nothing
		If actionsCore.TryGetValue(propName, action) Then
			action(propValue)
		End If
	End Sub
	Protected ReadOnly Property Actions() As Dictionary(Of String, PropertyChangedAction)
		Get
			Return actionsCore
		End Get
	End Property
	Protected MustOverride Sub CreateActions()

	Protected Function GetIntValue(ByVal value As String, ByVal defaultValue As Integer) As Integer
		Dim result As Integer = defaultValue
		Integer.TryParse(value, result)
		Return result
	End Function
	Protected Function GetFloatValue(ByVal value As String, ByVal defaultValue As Single) As Single
		Dim result As Single = defaultValue
		Single.TryParse(value, result)
		Return result
	End Function
End Class
Public NotInheritable Class CallbackParameterParser
	Private Sub New()
	End Sub
	Public Shared Function TryParse(ByVal e As CallbackEventArgsBase, <System.Runtime.InteropServices.Out()> ByRef propName As String, <System.Runtime.InteropServices.Out()> ByRef propValue As String) As Boolean
		Dim pattern As String = "(?<propName>.*?)\s*=\s*(?<propValue>.*?)$"
		Dim matches As MatchCollection = Regex.Matches(e.Parameter, pattern)
		propValue = Nothing
		propName = propValue
		If matches.Count > 0 Then
			propName = matches(0).Groups("propName").Value
			propValue = matches(0).Groups("propValue").Value
		End If
		Return propName IsNot Nothing
	End Function
End Class
