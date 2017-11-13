Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Globalization
Imports System.Web.UI
Imports System.Xml
Imports System.Web
Imports DevExpress.Web
Imports System.Drawing

Partial Public Class ASPxCalendar_DayRender
	Inherits Page
	Private xml As XmlDocument

	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		Me.xml = New XmlDocument()
		Me.xml.Load(MapPath("~/App_Data/CalendarNotes.xml"))
	End Sub

	Protected Sub ASPxCalendar_DayCellInitialize(ByVal sender As Object, ByVal e As CalendarDayCellInitializeEventArgs)
		If GetNoteNodes(e.Date).Count > 0 Then
			e.IsWeekend = False
			e.NavigateUrl = String.Format("javascript:ShowNotes('{0}')", GetDateString(e.Date))
		Else
			e.IsWeekend = True
		End If
	End Sub

	Protected Sub ASPxCalendar_DayCellPrepared(ByVal sender As Object, ByVal e As CalendarDayCellPreparedEventArgs)
		If GetNoteNodes(e.Date).Count > 0 Then
			e.TextControl.ForeColor = Color.Black
			e.TextControl.Font.Bold = True
		End If
	End Sub

	Protected Sub ASPxCallback1_Callback(ByVal source As Object, ByVal e As DevExpress.Web.CallbackEventArgs)
		e.Result = GetNote(e.Parameter)
	End Sub

	Private Function GetDateString(ByVal [date] As DateTime) As String
		Return [date].ToString("M/d/yyyy", CultureInfo.InvariantCulture)
	End Function

	Private Function GetNote(ByVal dateString As String) As String
		Dim list As New List(Of String)()
		For Each node As XmlNode In GetNoteNodes(dateString)
			list.Add(HttpUtility.HtmlEncode(node.Attributes("Text").Value))
		Next node
		Return dateString & "|" & String.Join("<br/><br/>", list.ToArray())
	End Function

	Private Function GetNoteNodes(ByVal [date] As DateTime) As XmlNodeList
		Return GetNoteNodes(GetDateString([date]))
	End Function

	Private Function GetNoteNodes(ByVal dateString As String) As XmlNodeList
		Return Me.xml.SelectNodes(String.Format("//Notes/Note[@Date='{0}']", dateString))
	End Function
End Class
