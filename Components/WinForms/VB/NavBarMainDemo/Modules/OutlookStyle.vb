Imports System.Collections
Imports System.ComponentModel
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo

Namespace DevExpress.XtraNavBar.Demos
	''' <summary>
	''' Summary description for OutlookStyle.
	''' </summary>
	Partial Public Class OutlookStyle
		Inherits DevExpress.XtraEditors.XtraUserControl
		Public Sub New()
			' This call is required by the Windows.Forms Form Designer.
			InitializeComponent()

			' TODO: Add any initialization after the InitForm call

		End Sub

		Private mFilter As MailFilter = MailFilter.Draft
		Public Property MailFilter() As MailFilter
			Get
				Return mFilter
			End Get
			Set(ByVal value As MailFilter)
				mFilter = value
				If mFilter = MailFilter.Inbox OrElse mFilter = MailFilter.Sent OrElse mFilter = MailFilter.Deleted Then
					gridControl1.DataSource = OutlookData.CreateDataTable()
					gridView1.SetRowExpanded(-1, True)
					gridView1.SetRowExpanded(-2, True)
				Else
					gridControl1.DataSource = Nothing
				End If
				If mFilter = MailFilter.Inbox OrElse mFilter = MailFilter.Deleted Then
					gridColumn5.Caption = "From"
					gridColumn6.Caption = "Received"
				Else
					gridColumn5.Caption = "To"
					gridColumn6.Caption = "Sent"
				End If
				gridColumn2.Visible = mFilter = MailFilter.Inbox
			End Set
		End Property

		Private Sub gridView1_CustomDrawGroupRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowObjectCustomDrawEventArgs) Handles gridView1.CustomDrawGroupRow
			Dim info As GridGroupRowInfo = TryCast(e.Info, GridGroupRowInfo)
			If info Is Nothing Then
				Return
			End If
			info.GroupText = info.GroupText.Replace("1 items", "1 item")
		End Sub

		Private Sub gridView1_CustomDrawCell(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs) Handles gridView1.CustomDrawCell
			If mFilter = MailFilter.Inbox Then
				Dim row As DataRow = gridView1.GetDataRow(e.RowHandle)
				If row("Read").Equals(0) Then
					e.Appearance.Font = New Font(e.Appearance.Font, FontStyle.Bold)
				End If
			End If
			If mFilter = MailFilter.Deleted Then
				e.Appearance.Font = New Font(e.Appearance.Font, FontStyle.Strikeout)
				e.Appearance.ForeColor = Color.Gray
			End If
		End Sub
	End Class
	Public Class OutlookData
		Public Shared rnd As New Random()
		Private Shared users() As String = {"Peter Dolan", "Ryan Fischer", "Richard Fisher", "Tom Hamlett", "Mark Hamilton", "Steve Lee", "Jimmy Lewis", "Jeffrey W McClain", "Andrew Miller", "Dave Murrel", "Bert Parkins", "Mike Roller", "Ray Shipman", "Paul Bailey", "Brad Barnes", "Carl Lucas", "Jerry Campbell"}
		Private Shared subject() As String = { "Implementing DevExpress MasterView control into Accounting System.", "Web Edition: Data Entry Page. The issue with date validation.", "Payables Due Calculator. It is ready for testing.", "Web Edition: Search Page. It is ready for testing.", "Main Menu: Duplicate Items. Somebody has to review all menu items in the system.", "Receivables Calculator. Where can I found the complete specs", "Ledger: Inconsistency. Please fix it.", "Receivables Printing. It is ready for testing.", "Screen Redraw. Somebody has to look at it.", "Email System. What library we are going to use?", "Adding New Vendors Fails. This module doesn't work completely!", "History. Will we track the sales history in our system?", "Main Menu: Add a File menu. File menu is missed!!!", "Currency Mask. The current currency mask in completely inconvinience.", "Drag & Drop. In the schedule module drag & drop is not available.", "Data Import. What competitors databases will we support?", "Reports. The list of incomplete reports.", "Data Archiving. This features is still missed in our application", "Email Attachments. How to add the multiple attachment? I did not find a way to do it.", "Check Register. We are using different paths for different modules.", "Data Export. Our customers asked for export into Excel"}

		Private Shared Function GetBoolean() As Boolean
			Dim ret As Integer = rnd.Next(7)
			Return ret > 4
		End Function

		Private Shared Function GetImportance() As Integer
			Dim ret As Integer = rnd.Next(7)
			If ret > 2 Then
				ret = 1
			End If
			Return ret
		End Function

		Private Shared Function GetIcon() As Integer
			Dim ret As Integer = rnd.Next(10)
			ret = If(ret > 2, 1, 0)
			Return ret
		End Function

		Private Shared Function GetSent() As Date
			Dim ret As Date = Date.Now
			Dim r As Integer = rnd.Next(12)
			If r > 1 Then
				ret = ret.AddDays(-rnd.Next(50))
			End If
			ret = ret.AddMinutes(-rnd.Next(ret.Minute + ret.Hour * 60 + 360))
			Return ret
		End Function

		Private Shared Function GetReceived(ByVal sent As Date) As Date
			Return sent.AddMinutes(10 + rnd.Next(120))
		End Function

		Private Shared Function GetSubject() As String
			Return subject(rnd.Next(subject.Length - 1))
		End Function

		Private Shared Function GetFrom() As String
			Return users(rnd.Next(users.Length - 2))
		End Function

		Private Shared Function GetTo() As String
			Return users(users.Length - 1)
		End Function

		Public Shared Function CreateDataTable() As DataTable
			Dim tbl As New DataTable("Outlook")
			tbl.Columns.Add("Priority", GetType(Integer))
			tbl.Columns.Add("Attachment", GetType(Integer))
			tbl.Columns.Add("Read", GetType(Integer))
			tbl.Columns.Add("Subject", GetType(String))
			tbl.Columns.Add("From", GetType(String))
			tbl.Columns.Add("To", GetType(String))
			tbl.Columns.Add("Sent", GetType(Date))
			tbl.Columns.Add("Received", GetType(Date))
			For i As Integer = 0 To 79
				Dim sent As Date = GetSent()
				tbl.Rows.Add(New Object() {GetImportance(), GetIcon(), GetIcon(), GetSubject(), GetFrom(), GetTo(), sent, GetReceived(sent)})
			Next i
			Return tbl
		End Function
		Public Shared Function CreateTaskTable() As DataTable
			Dim tbl As New DataTable("Task")
			tbl.Columns.Add("Image", GetType(Integer))
			tbl.Columns.Add("Check", GetType(Boolean))
			tbl.Columns.Add("Subject", GetType(String))
			tbl.Columns.Add("Date", GetType(Date))
			For i As Integer = 0 To 9
				tbl.Rows.Add(New Object() {0, GetBoolean(), GetSubject(), GetSent()})
			Next i
			Return tbl
		End Function
		Public Shared Function CreateNotesTable() As DataTable
			Dim tbl As New DataTable("Notes")
			tbl.Columns.Add("Name", GetType(String))
			tbl.Columns.Add("Description", GetType(String))
			For i As Integer = 0 To 9
				tbl.Rows.Add(New Object() {GetFrom(), GetSubject()})
			Next i
			Return tbl
		End Function
		Public Shared Function CreateJournalTable() As DataTable
			Dim tbl As New DataTable("Journal")
			tbl.Columns.Add("Date", GetType(Date))
			tbl.Columns.Add("Time", GetType(Date))
			tbl.Columns.Add("Description", GetType(String))
			For i As Integer = 0 To 9
				Dim sent As Date = GetSent()
				tbl.Rows.Add(New Object() {sent, sent, GetSubject()})
			Next i
			Return tbl
		End Function
	End Class
	Public Enum MailFilter
		Inbox
		Outbox
		Deleted
		Sent
		Draft
	End Enum
End Namespace
