Imports Microsoft.VisualBasic
Imports System.Web

Public NotInheritable Class ReportDesignerUrlLogic
	Public Const QueryArgument As String = "fromDesigner=true"

	Private Sub New()
	End Sub
	Public Shared Function CleanUrl(ByVal redirectUrl As String, ByVal encode As Boolean) As String
		Dim garbageArgument As String = QueryArgument
		If encode Then
			garbageArgument = HttpUtility.UrlEncode(garbageArgument)
		End If
		Dim result As String = redirectUrl.Replace(garbageArgument, "")
		result = RemoveGarbageFromEnd(result, encode)
		Return result
	End Function

	Private Shared Function RemoveGarbageFromEnd(ByVal result As String, ByVal encode As Boolean) As String
		Dim garbageEnds() As String = GenerateGarbageEnds(encode)
		For Each garbageEnd As String In garbageEnds
			If result.EndsWith(garbageEnd) Then
				result = result.Substring(0, result.Length - garbageEnd.Length)
			End If
		Next garbageEnd
		Return result
	End Function

	Private Shared Function GenerateGarbageEnds(ByVal encode As Boolean) As String()
		Dim result = { "&", "?" }
		If encode Then
			For i As Integer = 0 To result.Length - 1
				result(i) = HttpUtility.UrlEncode(result(i))
			Next i
		End If
		Return result
	End Function
End Class
