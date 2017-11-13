Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Text
Imports System.Data
Imports System.Windows.Forms

Namespace DevExpress.XtraGrid.Demos.Tutorials
	Public Class OutlookData
		Public Shared rnd As New Random()
		Friend Shared users() As String = {"Peter Dolan", "Ryan Fischer", "Richard Fisher", "Tom Hamlett", "Mark Hamilton", "Steve Lee", "Jimmy Lewis", "Jeffrey W McClain", "Andrew Miller", "Dave Murrel", "Bert Parkins", "Mike Roller", "Ray Shipman", "Paul Bailey", "Brad Barnes", "Carl Lucas", "Jerry Campbell"}
		Private Shared subject() As String = { "Integrating Developer Express MasterView control into an Accounting System.", "Web Edition: Data Entry Page. There is an issue with date validation.", "Payables Due Calculator is ready for testing.", "Web Edition: Search Page is ready for testing.", "Main Menu: Duplicate Items. Somebody has to review all menu items in the system.", "Receivables Calculator. Where can I find the complete specs?", "Ledger: Inconsistency. Please fix it.", "Receivables Printing module is ready for testing.", "Screen Redraw. Somebody has to look at it.", "Email System. What library are we going to use?", "Cannot add new vendor. This module doesn't work!", "History. Will we track sales history in our system?", "Main Menu: Add a File menu. File menu item is missing.", "Currency Mask. The current currency mask in completely unusable.", "Drag & Drop operations are not available in the scheduler module.", "Data Import. What database types will we support?", "Reports. The list of incomplete reports.", "Data Archiving. We still don't have this features in our application.", "Email Attachments. Is it possible to add multiple attachments? I haven't found a way to do this.", "Check Register. We are using different paths for different modules.", "Data Export. Our customers asked us for export to Microsoft Excel"}

		Private Shared Function GetImportance(ByVal num As Integer) As Integer
			Dim ret As Integer = rnd.Next(num)
			If ret > 2 Then
			ret = 1
			End If
			Return ret
		End Function

		Private Shared Function GetIcon() As Integer
			Dim ret As Integer = rnd.Next(10)
			If ret > 2 Then
				ret = 1
			Else
				ret = 0
			End If
			Return ret
		End Function

		Private Shared Function GetAttach() As Integer
			Dim ret As Integer = rnd.Next(10)
			If ret > 5 Then
				ret = 1
			Else
				ret = 0
			End If
			Return ret
		End Function

		Private Shared Function GetSent() As DateTime
			Dim ret As DateTime = DateTime.Now
			Dim r As Integer = rnd.Next(12)
			If r > 1 Then
			ret = ret.AddDays(-rnd.Next(50))
			End If
			ret = ret.AddMinutes(-rnd.Next(ret.Minute + ret.Hour * 60 + 360))
			Return ret
		End Function

		Private Shared Function GetReceived(ByVal sent As DateTime) As DateTime
			Dim dt As DateTime = sent.AddMinutes(10 + rnd.Next(120))
			If dt > DateTime.Now Then
			dt = DateTime.Now.AddMinutes(-1)
			End If
			Return dt
		End Function

		Private Shared Function GetSubject() As String
			Return subject(rnd.Next(subject.Length - 1))
		End Function

		Public Shared Function GetFrom() As String
			Return users(rnd.Next(users.Length - 2))
		End Function

		Private Shared Function GetTo() As String
			Return users(users.Length - 1)
		End Function

		Private Shared Function GetSentDate() As DateTime
			Dim ret As DateTime = DateTime.Today
			Dim r As Integer = rnd.Next(12)
			If r > 1 Then
			ret = ret.AddDays(-rnd.Next(50))
			End If
			Return ret
		End Function

		Public Shared Function GetDueDate() As DateTime
			Dim ret As DateTime = DateTime.Today
			ret = ret.AddDays(60 + rnd.Next(50))
			Return ret
		End Function

		Private Shared Function GetSize(ByVal largeData As Boolean) As Integer
			If largeData Then
				Return 1000 + (20 * rnd.Next(10000))
			Else
				Return 1000 + (30 * rnd.Next(100))
			End If
		End Function
		Private Shared Function GetHasAttachment() As Boolean
			Return rnd.Next(10) > 5
		End Function

		Public Shared Function CreateDataTable() As DataTable
			Return CreateDataTable(7)
		End Function
		Public Shared Function CreateMailRow(ByVal num As Integer, ByVal realTime As Boolean) As Object()
			Dim sent As DateTime = GetSent()
			If realTime Then
				If realTime Then
					Return New Object() { GetImportance(num), GetAttach(),0, GetIcon(), GetSubject(), GetFrom(), GetTo(), sent,DateTime.Now}
				Else
					Return New Object() { GetImportance(num), GetAttach(),0, GetIcon(), GetSubject(), GetFrom(), GetTo(), sent,GetReceived(sent)}
				End If
			Else
				If realTime Then
					Return New Object() { GetImportance(num), GetAttach(),GetIcon(), GetIcon(), GetSubject(), GetFrom(), GetTo(), sent,DateTime.Now}
				Else
					Return New Object() { GetImportance(num), GetAttach(),GetIcon(), GetIcon(), GetSubject(), GetFrom(), GetTo(), sent,GetReceived(sent)}
				End If
			End If
		End Function
		Public Shared Function CreateDataTable(ByVal num As Integer) As DataTable
			Dim tbl As New DataTable("Outlook")
			tbl.Columns.Add("Priority", GetType(Integer))
			tbl.Columns.Add("Attachment", GetType(Integer))
			tbl.Columns.Add("Read", GetType(Integer))
			tbl.Columns.Add("Flag", GetType(Integer))
			tbl.Columns.Add("Subject", GetType(String))
			tbl.Columns.Add("From", GetType(String))
			tbl.Columns.Add("To", GetType(String))
			tbl.Columns.Add("Sent", GetType(DateTime))
			tbl.Columns.Add("Received", GetType(DateTime))
			For i As Integer = 0 To 79
				tbl.Rows.Add(CreateMailRow(num, False))
			Next i
			Return tbl
		End Function
		Public Shared Function CreateIssueList() As DataTable
			Dim tbl As New DataTable()
			tbl = New DataTable("IssueList")
			tbl.Columns.Add("ID", GetType(Integer))
			tbl.Columns.Add("Subject", GetType(String))
			tbl.Columns.Add("Implemented", GetType(Integer))
			tbl.Columns.Add("Suspended", GetType(Boolean))
			For i As Integer = 1 To subject.Length
				tbl.Rows.Add(New Object() { i, subject.GetValue(i - 1), rnd.Next(100), rnd.Next(10) > 8 })
			Next i
			Return tbl
		End Function
	End Class
End Namespace
