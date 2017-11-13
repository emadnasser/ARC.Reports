Imports System
Imports System.Data
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.Xpo
Imports DevExpress.LookAndFeel
Imports DevExpress.Skins
Imports System.Collections.Generic
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors
Imports System.ComponentModel
Imports DevExpress.Utils
Imports DevExpress.Utils.Text
Imports DevExpress.XtraRichEdit
Imports System.IO
Imports DevExpress.XtraGrid.Views.Grid
Imports System.ComponentModel.DataAnnotations
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.Data
Imports DevExpress.XtraGrid.Views.Base
Imports System.Drawing.Drawing2D
Imports System.Data.OleDb

Namespace DevExpress.XtraGrid.Demos
    <Flags()>
    Public Enum MailFolder
        All = 0
        Announcements = 1
        ASP = 2
        WinForms = 4
        IDETools = 8
        Frameworks = 16
    End Enum
    Public Enum MailType
        Inbox
        Deleted
        Sent
        Draft
    End Enum
    Public Class OutlookData
        Public Shared rnd As New Random()
        Friend Shared users() As String = {"Peter Dolan", "Ryan Fischer", "Richard Fisher", "Tom Hamlett", "Mark Hamilton", "Steve Lee", "Jimmy Lewis", "Jeffrey W McClain", "Andrew Miller", "Dave Murrel", "Bert Parkins", "Mike Roller", "Ray Shipman", "Paul Bailey", "Brad Barnes", "Carl Lucas", "Jerry Campbell"}
        Private Shared subject() As String = {"Integrating DevExpress MasterView control into an Accounting System.", "Web Edition: Data Entry Page. There is an issue with date validation.", "Payables Due Calculator is ready for testing.", "Web Edition: Search Page is ready for testing.", "Main Menu: Duplicate Items. Somebody has to review all menu items in the system.", "Receivables Calculator. Where can I find the complete specs?", "Ledger: Inconsistency. Please fix it.", "Receivables Printing module is ready for testing.", "Screen Redraw. Somebody has to look at it.", "Email System. What library are we going to use?", "Cannot add new vendor. This module doesn't work!", "History. Will we track sales history in our system?", "Main Menu: Add a File menu. File menu item is missing.", "Currency Mask. The current currency mask in completely unusable.", "Drag & Drop operations are not available in the scheduler module.", "Data Import. What database types will we support?", "Reports. The list of incomplete reports.", "Data Archiving. We still don't have this features in our application.", "Email Attachments. Is it possible to add multiple attachments? I haven't found a way to do this.", "Check Register. We are using different paths for different modules.", "Data Export. Our customers asked us for export to Microsoft Excel"}

        Private Shared Function GetImportance(ByVal num As Integer) As Integer
            Dim ret As Integer = rnd.Next(num)
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

        Private Shared Function GetAttach() As Integer
            Dim ret As Integer = rnd.Next(10)
            ret = If(ret > 5, 1, 0)
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
            Dim dt As Date = sent.AddMinutes(10 + rnd.Next(120))
            If dt > Date.Now Then
                dt = Date.Now.AddMinutes(-1)
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

        Private Shared Function GetSentDate() As Date
            Dim ret As Date = Date.Today
            Dim r As Integer = rnd.Next(12)
            If r > 1 Then
                ret = ret.AddDays(-rnd.Next(50))
            End If
            Return ret
        End Function

        Private Shared Function GetSentDateWithTime() As Date
            Dim ret As Date = Date.Now.AddMinutes(-rnd.Next(60, 250000))
            Return ret
        End Function

        Public Shared Function GetDueDate() As Date
            Dim ret As Date = Date.Today
            ret = ret.AddDays(60 + rnd.Next(50))
            Return ret
        End Function

        Private Shared Function GetSize(ByVal largeData As Boolean) As Integer
            Return 1000 + (If(largeData, 20 * rnd.Next(10000), 30 * rnd.Next(100)))
        End Function
        Private Shared Function GetHasAttachment() As Boolean
            Return rnd.Next(10) > 5
        End Function

        Public Shared Function CreateDataTable() As DataTable
            Return CreateDataTable(7)
        End Function
        Public Shared Function CreateMailRow(ByVal num As Integer, ByVal realTime As Boolean) As Object()
            Dim sent As Date = GetSent()
            Return New Object() {GetImportance(num), GetAttach(), If(realTime, 0, GetIcon()), GetIcon(), GetSubject(), GetFrom(), GetTo(), sent, If(realTime, Date.Now, GetReceived(sent))}
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
            tbl.Columns.Add("Sent", GetType(Date))
            tbl.Columns.Add("Received", GetType(Date))
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
                tbl.Rows.Add(New Object() {i, subject.GetValue(i - 1), rnd.Next(100), rnd.Next(10) > 8})
            Next i
            Return tbl
        End Function

        Public Shared Function CreateNewObject(ByVal uow As UnitOfWork) As ServerSideGridTest
            Dim obj As New ServerSideGridTest(uow)
            obj.Subject = GetSubject()
            obj.From = GetFrom()
            obj.Sent = GetSentDateWithTime()
            obj.HasAttachment = GetHasAttachment()
            obj.Size = GetSize(obj.HasAttachment)
            obj.Priority = GetImportance(4)
            Return obj
        End Function
    End Class
    Public Class GroupIntervalData
        Public Shared rnd As New Random()
        Private Shared Function GetCount() As Decimal
            Return rnd.Next(50) + 10
        End Function
        Private Shared Function GetDate(ByVal range As Boolean) As Date
            Dim ret As Date = Date.Now
            Dim r As Integer = rnd.Next(20)
            If range Then
                If r > 1 Then
                    ret = ret.AddDays(rnd.Next(80) - 40)
                End If
                If r > 18 Then
                    ret = ret.AddMonths(rnd.Next(18))
                End If
            Else
                ret = ret.AddDays(rnd.Next(r * 30) - r * 15)
            End If
            Return ret
        End Function
        Public Shared Function CreateDataTable(ByVal maxRows As Integer) As DataTable
            Return CreateDataTable(maxRows, True)
        End Function
        Public Shared Function CreateDataTable(ByVal maxRows As Integer, ByVal range As Boolean) As DataTable
            Dim tbl As DataTable = Nothing
            Dim DBFileName As String = String.Empty
            DBFileName = DevExpress.Utils.FilesHelper.FindingFileName(Application.StartupPath, "Data\nwind.mdb")
            If DBFileName <> String.Empty Then
                Dim ds As New DataSet()
                Dim tblName As String = "Products"

                Dim con As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & DBFileName
                Dim oleDbDataAdapter As New System.Data.OleDb.OleDbDataAdapter("SELECT * FROM " & tblName, con)
                oleDbDataAdapter.Fill(ds, tblName)

                Dim product As DataTable = ds.Tables(tblName)
                tbl = New DataTable("GroupInterval")
                tbl.Columns.Add("Product Name", GetType(String))
                tbl.Columns.Add("Category", GetType(Integer))
                tbl.Columns.Add("Unit Price", GetType(Decimal))
                tbl.Columns.Add("Count", GetType(Integer))
                tbl.Columns.Add("Order Date", GetType(Date))
                tbl.Columns.Add("Order Sum", GetType(Decimal), "[Unit Price] * [Count]")
                For i As Integer = 0 To maxRows - 1
                    Dim row_Renamed As DataRow = product.Rows(rnd.Next(product.Rows.Count - 1))
                    tbl.Rows.Add(New Object() {row_Renamed("ProductName"), row_Renamed("CategoryID"), row_Renamed("UnitPrice"), GetCount(), GetDate(range)})
                Next i
            End If
            Return tbl
        End Function
    End Class
    Public Class MailData
        Private row_Renamed As DataRow
        Public Sub New(ByVal row_Renamed As DataRow)
            Me.row_Renamed = row_Renamed
        End Sub
        Public ReadOnly Property Row() As DataRow
            Get
                Return row_Renamed
            End Get
        End Property
        Public Property Priority() As Integer
            Get
                Return DirectCast(row_Renamed("Priority"), Integer)
            End Get
            Set(ByVal value As Integer)
                row_Renamed("Priority") = value
            End Set
        End Property
        Public ReadOnly Property Attachment() As Integer
            Get
                Return DirectCast(row_Renamed("Attachment"), Integer)
            End Get
        End Property
        Public Property Read() As Integer
            Get
                Return DirectCast(row_Renamed("Read"), Integer)
            End Get
            Set(ByVal value As Integer)
                row_Renamed("Read") = value
            End Set
        End Property
        Public Property Flag() As Integer
            Get
                Return DirectCast(row_Renamed("Flag"), Integer)
            End Get
            Set(ByVal value As Integer)
                row_Renamed("Flag") = value
            End Set
        End Property
        Public ReadOnly Property Subject() As String
            Get
                Return String.Format("{0}", row_Renamed("Subject"))
            End Get
        End Property
        Public ReadOnly Property [From]() As String
            Get
                Return String.Format("{0}", row_Renamed("From"))
            End Get
        End Property
    End Class
    Public Class ColorsObject
        Private fforeColor, fbackColor As Color
        Public Sub New(ByVal fforeColor As Color, ByVal fbackColor As Color)
            Me.fforeColor = fforeColor
            Me.fbackColor = fbackColor
        End Sub
        Public Property ForeColor() As Color
            Get
                Return fforeColor
            End Get
            Set(ByVal value As Color)
                fforeColor = value
            End Set
        End Property
        Public Property BackColor() As Color
            Get
                Return fbackColor
            End Get
            Set(ByVal value As Color)
                fbackColor = value
            End Set
        End Property
    End Class
    Public Class ColorHelper
        Public Shared Sub UpdateColor(ByVal list As ImageList, ByVal lf As UserLookAndFeel)
            For i As Integer = 0 To list.Images.Count - 1
                list.Images(i) = SetColor(TryCast(list.Images(i), Bitmap), GetHeaderForeColor(lf))
            Next i
        End Sub
        Public Shared Function GetHeaderForeColor(ByVal lf As UserLookAndFeel) As Color
            Dim ret As Color = SystemColors.ControlText
            If lf.ActiveStyle <> ActiveLookAndFeelStyle.Skin Then
                Return ret
            End If
            Return GridSkins.GetSkin(lf)(GridSkins.SkinHeader).Color.GetForeColor()
        End Function
        Private Shared Function SetColor(ByVal bmp As Bitmap, ByVal color As Color) As Bitmap
            For i As Integer = 0 To bmp.Width - 1
                For j As Integer = 0 To bmp.Height - 1
                    If bmp.GetPixel(i, j).Name <> "0" Then
                        bmp.SetPixel(i, j, color)
                    End If
                Next j
            Next i
            Return bmp
        End Function
    End Class
    Public Class LoanPayment
        Private monthNumber_Renamed As Integer
        Private balance_Renamed, interest_Renamed, principal_Renamed As Double
        Private month_Renamed As Date
        Public Sub New(ByVal balance As Double, ByVal monthlyPayment As Double, ByVal month As Integer, ByVal interestRate As Double, ByVal startMonth As Date)
            Me.monthNumber_Renamed = month
            Me.month_Renamed = startMonth.AddMonths(month - 1)
            Me.interest_Renamed = Trunc2(balance * interestRate)
            Me.principal_Renamed = Trunc2(monthlyPayment - Me.interest_Renamed)
            Me.balance_Renamed = Trunc2(balance - Me.principal_Renamed)
        End Sub
        Public Sub UpdateBalance()
            If Me.balance_Renamed < 0 Then
                Me.principal_Renamed += Me.balance_Renamed
            End If
            Me.balance_Renamed = 0
        End Sub

        Public ReadOnly Property Month() As Date
            Get
                Return month_Renamed
            End Get
        End Property
        Public ReadOnly Property MonthNumber() As Integer
            Get
                Return monthNumber_Renamed
            End Get
        End Property
        Public ReadOnly Property MonthlyPayment() As Double
            Get
                Return Interest + Principal
            End Get
        End Property
        Public ReadOnly Property Balance() As Double
            Get
                Return balance_Renamed
            End Get
        End Property
        Public ReadOnly Property Interest() As Double
            Get
                Return interest_Renamed
            End Get
        End Property
        Public ReadOnly Property Principal() As Double
            Get
                Return principal_Renamed
            End Get
        End Property
        Public ReadOnly Property MonthString() As String
            Get
                Return String.Format("{0}<size=-2> ({1:MMMM, yyyy})", MonthNumber, Month)
            End Get
        End Property
        Public Shared Function Trunc2(ByVal val As Double) As Double
            Return Convert.ToDouble(Convert.ToInt64(val * 100)) / 100
        End Function
        Public Shared Function Calculate(ByVal loanAmount As Double, ByVal interestRate As Double, ByVal months As Double, ByVal startMonth As Date, <System.Runtime.InteropServices.Out()> ByRef payment As Double) As List(Of LoanPayment)
            payment = (loanAmount * interestRate) / (1 - Math.Exp((-months) * Math.Log(1 + interestRate)))
            payment = LoanPayment.Trunc2(payment)
            Dim payments As New List(Of LoanPayment)()

            Dim balance_Renamed As Double = loanAmount
            For i As Integer = 1 To Convert.ToInt32(months)
                Dim lp As New LoanPayment(balance_Renamed, payment, i, interestRate, startMonth)
                balance_Renamed = lp.Balance
                payments.Add(lp)
                If lp.Balance <= 0 Then
                    Exit For
                End If
            Next i
            payments(payments.Count - 1).UpdateBalance()
            Return payments
        End Function
        Public Shared Sub InitStartMonth(ByVal edit As ImageComboBoxEdit)
            Dim start As New Date(Date.Today.Year, Date.Today.Month, 1)
            For i As Integer = 1 To 6
                edit.Properties.Items.Add(New ImageComboBoxItem(String.Format("{0:MMMM, yyyy}", start.AddMonths(i)), start.AddMonths(i), -1))
            Next i
            edit.SelectedIndex = 0
        End Sub
        Public Shared Sub InitTermOfLoan(ByVal edit As ImageComboBoxEdit)
            Dim terms() As Integer = {5, 10, 15, 20, 25, 30}
            For Each term As Integer In terms
                edit.Properties.Items.Add(New ImageComboBoxItem(String.Format("{0} {1}", term, My.Resources.Years), term, -1))
            Next term
            edit.SelectedIndex = 5
        End Sub
        Public Shared Sub InitInterestRateData(ByVal edit As ImageComboBoxEdit)
            For i As Double = 2.5 To 14 Step 0.125
                edit.Properties.Items.Add(New ImageComboBoxItem(String.Format("{0:n3} %", i), i, -1))
            Next i
            edit.SelectedIndex = 25
        End Sub
        Public Shared Function GetMonthString(ByVal month As Integer, ByVal data As List(Of LoanPayment)) As String
            For Each payment As LoanPayment In data
                If payment.MonthNumber.Equals(month) Then
                    Return StringPainter.Default.RemoveFormat(payment.MonthString)
                End If
            Next payment
            Return String.Empty
        End Function
    End Class
    Public Class PaymentTypeSum
        Private interestSum_Renamed As Double = 0
        Private principalSum_Renamed As Double = 0
        Public Sub New()
            interestSum_Renamed = 0
            principalSum_Renamed = 0
        End Sub
        Public ReadOnly Property InterestSum() As Double
            Get
                Return interestSum_Renamed
            End Get
        End Property
        Public ReadOnly Property PrincipalSum() As Double
            Get
                Return principalSum_Renamed
            End Get
        End Property
        Public Sub AddToSum(ByVal value1 As Double, ByVal value2 As Double)
            interestSum_Renamed += value1
            principalSum_Renamed += value2
        End Sub
    End Class
    Public Enum PropertyType
        <Description("Single Family Home")>
        SingleFamilyHome
        <Description("Condo/Townhouse")>
        Townhome
        <Description("Multi-Family Home")>
        MultiFamilyHome
    End Enum
    Public Enum PropertyStatus
        <Description("New Construction")>
        NewConstruction
        <Description("Foreclosures")>
        Foreclosures
        <Description("Recently Sold")>
        RecentlySold
    End Enum
    Public Class Home
        Private Shared homes_Renamed As List(Of Home)
        Private row As DataRow
        Private photo_Renamed As Image
        Public Sub New(ByVal row_Renamed As DataRow)
            Me.row = row_Renamed
            If Not (TypeOf row_Renamed("Photo") Is DBNull) Then
                photo_Renamed = ByteImageConverter.FromByteArray(DirectCast(row_Renamed("Photo"), Byte()))
            End If
        End Sub
        Public ReadOnly Property ID() As Integer
            Get
                Return DirectCast(row("ID"), Integer)
            End Get
        End Property
        Public ReadOnly Property Address() As String
            Get
                Return String.Format("{0}", row("Address"))
            End Get
        End Property
        Public ReadOnly Property Baths() As Short
            Get
                Return DirectCast(row("Baths"), Short)
            End Get
        End Property
        Public ReadOnly Property Beds() As Short
            Get
                Return DirectCast(row("Beds"), Short)
            End Get
        End Property
        Public ReadOnly Property HouseSize() As Double
            Get
                Return DirectCast(row("HouseSize"), Double)
            End Get
        End Property
        Public ReadOnly Property LotSize() As Double
            Get
                Return DirectCast(row("LotSize"), Double)
            End Get
        End Property
        Public ReadOnly Property Price() As Decimal
            Get
                Return Convert.ToDecimal(row("Price"))
            End Get
        End Property
        Public ReadOnly Property YearBuilt() As String
            Get
                Return String.Format("{0}", row("YearBuilt"))
            End Get
        End Property
        Public ReadOnly Property Photo() As Image
            Get
                Return photo_Renamed
            End Get
        End Property
        Public ReadOnly Property Features() As String
            Get
                Return String.Format("{0}", row("Features"))
            End Get
        End Property
        Public ReadOnly Property Type() As String
            Get
                Return DevExpress.Utils.EnumExtensions.GetEnumItemDisplayText(DirectCast(row("Type"), PropertyType))
            End Get
        End Property
        Public ReadOnly Property Status() As String
            Get
                Return DevExpress.Utils.EnumExtensions.GetEnumItemDisplayText(DirectCast(row("Status"), PropertyStatus))
            End Get
        End Property
        Private Shared Function GetHomes() As List(Of Home)
            Dim temp As New DataSet()
            Dim db As String = FilesHelper.FindingFileName(Application.StartupPath, "Data\Homes.xml")
            If String.IsNullOrEmpty(db) Then
                Return Nothing
            End If
            temp.ReadXml(db)
            Dim ret As New List(Of Home)()
            For Each row_Renamed As DataRow In temp.Tables("Homes").Rows
                ret.Add(New Home(row_Renamed))
            Next row_Renamed
            Return ret
        End Function
        Public Shared ReadOnly Property Homes() As List(Of Home)
            Get
                If homes_Renamed Is Nothing Then
                    homes_Renamed = GetHomes()
                End If
                Return homes_Renamed
            End Get
        End Property
    End Class
    Public Class HomeBedRoomChartData
        Public Property RoomName() As String
        Public Property RoomSize() As Double
    End Class
    Public Class Message
        Private row As DataRow
        Private date_Renamed As Date
        Private read_Renamed, deleted_Renamed, isReply_Renamed, hasAttachment As Boolean
        Private priority_Renamed As Integer = 1
        Private mailType_Renamed As MailType
        Private mailFolder_Renamed As MailFolder
        Private from_Renamed As String = String.Empty, subject_Renamed As String = String.Empty, text_Renamed As String = String.Empty, plainText_Renamed As String = String.Empty

        Public Sub New()
            Me.date_Renamed = Date.Now
        End Sub
        Public Sub New(ByVal row_Renamed As DataRow)
            Me.row = row_Renamed
            Me.date_Renamed = DirectCast(row_Renamed("Date"), Date).Add(Date.Now.Subtract(DataHelper.LastMailDate))
            Me.from_Renamed = String.Format("{0}", row_Renamed("From"))
            Me.subject_Renamed = String.Format("{0}", row_Renamed("Subject"))
            Me.isReply_Renamed = DirectCast(row_Renamed("IsReply"), Boolean)
            Me.hasAttachment = DirectCast(row_Renamed("HasAttachment"), Boolean)
            Me.read_Renamed = Delay > TimeSpan.FromHours(6)
            If Delay > TimeSpan.FromHours(50) AndAlso Delay < TimeSpan.FromHours(100) Then
                read_Renamed = False
            End If
            Me.text_Renamed = String.Format("{0}", row_Renamed("Text"))
            Me.deleted_Renamed = False
            If Not IsReply Then
                priority_Renamed = 2
            Else
                If String.IsNullOrEmpty(Folder) Then
                    priority_Renamed = 0
                End If
            End If
            mailType_Renamed = DevExpress.XtraGrid.Demos.MailType.Inbox
            mailFolder_Renamed = GetFolder(row_Renamed)
            DataTweaking()
        End Sub

        Public Property [Date]() As Date
            Get
                Return date_Renamed
            End Get
            Set(ByVal value As Date)
                date_Renamed = value
            End Set
        End Property
        Public Property [From]() As String
            Get
                Return from_Renamed
            End Get
            Set(ByVal value As String)
                from_Renamed = value
            End Set
        End Property
        Public Property Subject() As String
            Get
                Return subject_Renamed
            End Get
            Set(ByVal value As String)
                subject_Renamed = value
            End Set
        End Property
        Public ReadOnly Property SubjectDisplayText() As String
            Get
                Return String.Format("{1}{0}", Subject, If(IsReply, "RE: ", ""))
            End Get
        End Property
        Public ReadOnly Property Attachment() As Integer
            Get
                Return If(hasAttachment, 1, 0)
            End Get
        End Property
        Public ReadOnly Property Read() As Integer
            Get
                Return If(read_Renamed, 1, 0)
            End Get
        End Property
        Public Property Priority() As Integer
            Get
                Return priority_Renamed
            End Get
            Set(ByVal value As Integer)
                priority_Renamed = value
            End Set
        End Property
        Friend Property IsReply() As Boolean
            Get
                Return isReply_Renamed
            End Get
            Set(ByVal value As Boolean)
                isReply_Renamed = value
            End Set
        End Property
        Public ReadOnly Property IsUnread() As Boolean
            Get
                Return Not read_Renamed
            End Get
        End Property
        Friend ReadOnly Property Folder() As String
            Get
                Return String.Format("{0}", mailFolder_Renamed)
            End Get
        End Property
        Public Property Text() As String
            Get
                Return text_Renamed
            End Get
            Set(ByVal value As String)
                text_Renamed = value
            End Set
        End Property
        Public ReadOnly Property PlainText() As String
            Get
                Return GetPlainText()
            End Get
        End Property

        Private Function GetPlainText() As String
            If String.IsNullOrEmpty(plainText_Renamed) Then
                plainText_Renamed = ObjectHelper.GetPlainText(text_Renamed.Substring(0, Math.Min(100, text_Renamed.Length)))
            End If
            Return plainText_Renamed
        End Function
        Public Property MailType() As MailType
            Get
                Return mailType_Renamed
            End Get
            Set(ByVal value As MailType)
                mailType_Renamed = value
            End Set
        End Property
        Public Property MailFolder() As MailFolder
            Get
                Return mailFolder_Renamed
            End Get
            Set(ByVal value As MailFolder)
                mailFolder_Renamed = value
            End Set
        End Property
        Public Property Deleted() As Boolean
            Get
                Return deleted_Renamed
            End Get
            Set(ByVal value As Boolean)
                deleted_Renamed = value
            End Set
        End Property
        Friend ReadOnly Property Delay() As TimeSpan
            Get
                Return Date.Now.Subtract(date_Renamed)
            End Get
        End Property

        Public Sub ToggleRead()
            read_Renamed = Not read_Renamed
        End Sub
        Private Sub DataTweaking()
            If Me.IsReply Then
                Return
            End If
            If Me.Subject.IndexOf("IDataStore") > 0 Then
                read_Renamed = False
            End If
        End Sub
        Private Function GetFolder(ByVal row_Renamed As DataRow) As MailFolder
            Dim ret As String = String.Format("{0}", row_Renamed("Folder"))
            If String.IsNullOrEmpty(ret) Then
                Return DevExpress.XtraGrid.Demos.MailFolder.All
            End If
            Return DirectCast(System.Enum.Parse(GetType(MailFolder), ret.Replace(" ", "")), MailFolder)
        End Function
        Public Sub SetPlainText(ByVal text As String)
            plainText_Renamed = text
        End Sub
    End Class
    Public Class ObjectHelper
        Private Shared rich As New RichEditDocumentServer()
        Public Shared Function GetPlainText(ByVal htmlText As String) As String
            rich.HtmlText = htmlText
            Return rich.Text.TrimStart()
        End Function
        Public Shared Sub GetChildDataRowHandles(ByVal view As GridView, ByVal rowHandle As Integer, ByVal list As List(Of Message))
            For i As Integer = 0 To view.GetChildRowCount(rowHandle) - 1
                Dim row_Renamed As Integer = view.GetChildRowHandle(rowHandle, i)
                If row_Renamed >= 0 Then
                    list.Add(TryCast(view.GetRow(row_Renamed), Message))
                Else
                    GetChildDataRowHandles(view, row_Renamed, list)
                End If
            Next i
        End Sub
    End Class
    Public Class DataHelper
        Private Shared messages_Renamed As List(Of Message) = Nothing
        Friend Shared LastMailDate As Date = Date.Now
        Friend Shared ReadOnly Property MailTable() As DataTable
            Get
                Dim table As String = "Messages"
                Dim messages_Renamed As DataTable = CreateDataTable(table)
                If messages_Renamed IsNot Nothing AndAlso messages_Renamed.Rows.Count > 0 Then
                    LastMailDate = CDate(messages_Renamed.Rows(0)("Date"))
                End If
                Return messages_Renamed
            End Get
        End Property
        Public Shared ReadOnly Property Messages() As List(Of Message)
            Get
                Try
                    If messages_Renamed Is Nothing Then
                        messages_Renamed = New List(Of Message)()
                        Dim tbl As DataTable = MailTable
                        If tbl IsNot Nothing Then
                            For Each row_Renamed As DataRow In tbl.Rows
                                messages_Renamed.Add(New Message(row_Renamed))
                            Next row_Renamed
                        End If
                    End If
                Catch e As Exception
                    XtraMessageBox.Show(e.Message, e.Source)
                    messages_Renamed = New List(Of Message)()
                End Try
                Return messages_Renamed
            End Get
        End Property
        Private Shared Function CreateDataTable(ByVal table As String) As DataTable
            Dim dataSet As New DataSet()
            Dim dataFile As String = FilesHelper.FindingFileName(Application.StartupPath, "Data\Mail.xml")
            If dataFile <> String.Empty Then
                Dim fi As New FileInfo(dataFile)
                dataSet.ReadXml(fi.FullName)
                Return dataSet.Tables(table)
            End If
            Return Nothing
        End Function
        Public Shared Sub LogoGridLookupGetImageByValue(ByVal sender As Object, ByVal e As ImageByValueEventArgs)
            Dim repository As RepositoryItemGridLookUpEditWithGlyph = TryCast(sender, RepositoryItemGridLookUpEditWithGlyph)
            If repository Is Nothing OrElse repository.DataSource Is Nothing Then
                Return
            End If
            Dim dt As DataTable = TryCast(repository.DataSource, DataTable)
            Dim row_Renamed As DataRow = Nothing
            Try
                row_Renamed = dt.Rows(DirectCast(e.Value, Integer) - 1)
            Catch
            End Try
            If row_Renamed IsNot Nothing Then
                e.Image = DirectCast(row_Renamed("Logo"), Byte())
            End If
        End Sub
    End Class
    Public Class PreviewGridView
        Inherits GridView

        Protected Overrides ReadOnly Property IsAllowPixelScrollingPreview() As Boolean
            Get
                Return True
            End Get
        End Property
    End Class
    Public Class SaleOverviewData
        Public Sub New(ByVal state As String, ByVal sales As Double, ByVal salesVsTarget As Double, ByVal profit As Double, ByVal customersSatisfaction As Double, ByVal markerShare As Double)
            Me.State = state
            Me.Sales = sales
            Me.Profit = profit
            Me.SalesVsTarget = salesVsTarget
            Me.CustomersSatisfaction = customersSatisfaction
            Me.MarketShare = markerShare
        End Sub
        Public Property State() As String
        <DisplayFormat(DataFormatString:="#,##0,,M")>
        Public Property Sales() As Double
        <DisplayFormat(DataFormatString:="#,##0,,M")>
        Public Property Profit() As Double
        <DisplayFormat(DataFormatString:="p", ApplyFormatInEditMode:=True), Display(Name:="Sales vs Target")>
        Public Property SalesVsTarget() As Double
        <DisplayFormat(DataFormatString:="p0", ApplyFormatInEditMode:=True)>
        Public Property MarketShare() As Double
        <Display(Name:="Satisfaction")>
        Public Property CustomersSatisfaction() As Double
    End Class
    Public NotInheritable Class SaleOverviewDataGenerator

        Private Sub New()
        End Sub

        Public Shared Function GenerateSales() As SaleOverviewData()
            Return New SaleOverviewData() {
                New SaleOverviewData("California", 467949484.42, 0.0276, 44000000, 4.6, 0.34),
                New SaleOverviewData("South Dakota", 458113868.36, 0.0482, 27000000, 4.8, 0.32),
                New SaleOverviewData("Ohio", 250772304.63, -0.0288, -15000000, 3.4, 0.29),
                New SaleOverviewData("Wisconsin", 182660621.53, 0.0598, 14000000, 4.1, 0.22),
                New SaleOverviewData("New Hampshire", 158710257.91, 0.0132, 10000000, 4.0, 0.19),
                New SaleOverviewData("Maine", 156032947.24, -0.0996, -9000000, 2.9, 0.14),
                New SaleOverviewData("Utah", 131496479.72, 0.0445, 18000000, 4.7, 0.27),
                New SaleOverviewData("Idaho", 119199535.5, 0.0065, 14000000, 3.9, 0.3),
                New SaleOverviewData("Illinois", 102480457.66, -0.0039, 9000000, 4.2, 0.17),
                New SaleOverviewData("Washington", 102301309.53, 0.0242, 18000000, 4.6, 0.26),
                New SaleOverviewData("Wyoming", 98012761.36, 0.0021, 4000000, 3.7, 0.31),
                New SaleOverviewData("Indiana", 95976655.67, 0.0249, -7000000, 2.5, 0.17),
                New SaleOverviewData("Nevada", 91535057.56, 0.0284, 23000000, 4.5, 0.22),
                New SaleOverviewData("Massachusetts", 90602516.28, 0.0139, 12000000, 4.0, 0.24),
                New SaleOverviewData("Rhode Island", 90548513.43, 0.0137, 21000000, 4.4, 0.29),
                New SaleOverviewData("Montana", 89977272.49, -0.0049, -5000000, 2.0, 0.13),
                New SaleOverviewData("Alabama", 88237187.77, -0.0059, 6000000, 4.6, 0.15),
                New SaleOverviewData("Georgia", 88175277.25, 0.0045, 11000000, 4.2, 0.24),
                New SaleOverviewData("New York", 87774749.8, 0.0114, 15000000, 3.9, 0.3),
                New SaleOverviewData("Texas", 84291394.13, -0.0093, -20000000, 2.9, 0.13),
                New SaleOverviewData("Virginia", 83582665.33, -0.0057, 8000000, 3.9, 0.1),
                New SaleOverviewData("South Carolina", 83391264.21, 0.0384, 6000000, 4.4, 0.28),
                New SaleOverviewData("Missouri", 82106438.59, -0.0144, 2000000, 3.2, 0.18),
                New SaleOverviewData("Florida", 81751131.33, 0.0115, 7000000, 4.1, 0.24),
                New SaleOverviewData("Mississippi", 81203810.96, 0.0332, 6000000, 4.4, 0.31),
                New SaleOverviewData("New Mexico", 80452595.66, 0.0122, 13000000, 4.9, 0.23),
                New SaleOverviewData("Kentucky", 79995544.6, 0.0403, 10000000, 4.6, 0.27),
                New SaleOverviewData("Connecticut", 73220631.05, 0.0337, 8000000, 2.9, 0.24),
                New SaleOverviewData("Arizona", 72989023.31, -0.0094, -4000000, 3.6, 0.11),
                New SaleOverviewData("Tennessee", 72877959.11, 0.02915, 14000000, 4.9, 0.25),
                New SaleOverviewData("Colorado", 71391979.17, 0.0036, 5000000, 4.1, 0.28),
                New SaleOverviewData("Oregon", 70908060.11, 0.0042, 6000000, 4.5, 0.23),
                New SaleOverviewData("North Carolina", 70896926.22, -0.0111, -17000000, 3.0, 0.12),
                New SaleOverviewData("Michigan", 69466608.8, -0.0083, 3000000, 4.0, 0.2),
                New SaleOverviewData("Minnesota", 66473670.35, 0.0099, 8000000, 4.2, 0.19)
            }
        End Function
    End Class

    Public Class DemoHelper
        Private Shared connectionString As String = String.Empty
        Private Shared ic16 As ImageCollection = Nothing
        Private Shared ic24 As ImageCollection = Nothing
        Public Shared ReadOnly Property CategorySmallImages() As ImageCollection
            Get
                If ic16 Is Nothing Then
                    ic16 = New ImageCollection()
                    ic16.ImageSize = New Size(17, 17)
                    LoadImages(ic16, "Icon_17")
                End If
                Return ic16
            End Get
        End Property
        Public Shared ReadOnly Property CategoryLargeImages() As ImageCollection
            Get
                If ic24 Is Nothing Then
                    ic24 = New ImageCollection()
                    ic24.ImageSize = New Size(24, 24)
                    LoadImages(ic24, "Icon_25")
                End If
                Return ic24
            End Get
        End Property
        Private Shared Sub LoadImages(ByVal ic As ImageCollection, ByVal fieldName As String)
            Dim ds As New DataSet()
            Dim oleDBAdapter As New OleDbDataAdapter("SELECT * FROM Categories", connectionString)
            oleDBAdapter.Fill(ds)
            For Each row_Renamed As DataRow In ds.Tables(0).Rows
                ic.Images.Add(DevExpress.XtraEditors.Controls.ByteImageConverter.FromByteArray(TryCast(row_Renamed(fieldName), Byte())))
            Next row_Renamed
        End Sub
        Public Shared Sub AddCategoryImagesToEdit(ByVal connectionString As String, ByVal edit As RepositoryItemImageComboBox)
            DemoHelper.connectionString = connectionString
            If edit IsNot Nothing Then
                edit.SmallImages = CategorySmallImages
                edit.LargeImages = CategoryLargeImages
                edit.DropDownRows = CategorySmallImages.Images.Count
            End If
        End Sub
    End Class
    Public Class VehiclesData
        Public Enum Category
            Car = 1
            <Display(Name:="Crossover & SUV")> _
            CrossoverAndSUV = 2
            Truck = 3
            Minivan = 4
        End Enum
        Public Class Trademark
            Private captionLogo_Renamed As Bitmap = Nothing
            Public Property ID() As Integer
            Public Property Logo() As Image
            Public Property Name() As String
            Public ReadOnly Property CaptionLogo() As Bitmap
                Get
                    If captionLogo_Renamed Is Nothing Then
                        captionLogo_Renamed = ResizeImage(Logo, 24, 70)
                    End If
                    Return captionLogo_Renamed
                End Get
            End Property
        End Class
        Public Class OrderItem
            Friend Model As Model
            Public Sub New(ByVal model As Model, ByVal days As Integer, ByVal rnd As Random, ByVal id As Integer)
                Me.Model = model
                ModelPrice = model.Price
                Trademark = model.Trademark
                Name = model.Name
                Modification = model.Modification
                Category = model.Category
                MPGCity = model.MPGCity
                MPGHighway = model.MPGHighway
                Doors = model.Doors
                BodyStyle = model.BodyStyle
                Cylinders = model.Cylinders
                Horsepower = model.Horsepower
                Torque = model.Torque
                TransmissionSpeeds = model.TransmissionSpeeds
                TransmissionType = model.TransmissionType

                SalesDate = Date.Now.AddDays(-rnd.Next(days))
                Discount = Math.Round(0.05 * rnd.Next(4), 2)
                OrderID = id
            End Sub
            Public Property OrderID() As Integer
            Public Property SalesDate() As Date
            Public Property Discount() As Double
            <DataType(DataType.Currency)>
            Public Property ModelPrice() As Decimal
            Public Property Trademark() As Integer
            Public Property Name() As String
            Public Property Modification() As String
            Public Property Category() As Integer
            Public Property MPGCity() As Integer?
            Public Property MPGHighway() As Integer?
            Public Property Doors() As Integer
            Public Property BodyStyle() As Integer
            Public Property Cylinders() As Integer
            Public Property Horsepower() As String
            Public Property Torque() As String
            Public Property TransmissionSpeeds() As Integer
            Public Property TransmissionType() As Integer
            Public ReadOnly Property Photo() As Image
                Get
                    Return Model.Photo
                End Get
            End Property
        End Class
        Public Class Model
            Public Property ID() As Integer
            Public Property Trademark() As Integer
            Public Property Name() As String
            Public Property Modification() As String
            Public Property Category() As Integer
            Public Property Price() As Decimal
            Public Property MPGCity() As Integer?
            Public Property MPGHighway() As Integer?
            Public Property Doors() As Integer
            Public Property BodyStyle() As Integer
            Public Property Cylinders() As Integer
            Public Property Horsepower() As String
            Public Property Torque() As String
            Public Property TransmissionSpeeds() As Integer
            Public Property TransmissionType() As Integer
            Public Property Description() As String
            Public Property Image() As Image
            Public Property Photo() As Image
            Public Property DeliveryDate() As Date
            Public Property InStock() As Boolean
            Public ReadOnly Property TrademarkImage() As Image
                Get
                    Return If(Trademarks IsNot Nothing, Trademarks(Trademark - 1).Logo, Nothing)
                End Get
            End Property
            Public ReadOnly Property TrademarkName() As String
                Get
                    Return If(Trademarks IsNot Nothing, Trademarks(Trademark - 1).Name, String.Empty)
                End Get
            End Property
            Public Function GetSmallTrademarkImage() As Bitmap
                Return Trademarks(Trademark - 1).CaptionLogo
            End Function
            Public Trademarks As List(Of VehiclesData.Trademark) = Nothing
        End Class
        Public Shared Function ResizeImage(ByVal image As Image, ByVal height As Integer, ByVal maxWidth As Integer) As Bitmap
            Dim width As Integer = Math.Min(image.Width * height \ image.Height, maxWidth)
            Dim heightImage As Integer = image.Height * width \ image.Width
            Dim destRect As New Rectangle(0, (height - heightImage) \ 2, width, heightImage)
            Dim destImage As New Bitmap(width, height)

            Using graphics As Graphics = System.Drawing.Graphics.FromImage(destImage)
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic
                graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel)
            End Using

            Return destImage
        End Function
        Public Shared Sub LogoGridLookupGetImageByValue(ByVal sender As Object, ByVal e As ImageByValueEventArgs)
            Dim repository As RepositoryItemGridLookUpEditWithGlyph = TryCast(sender, RepositoryItemGridLookUpEditWithGlyph)
            If repository Is Nothing OrElse repository.DataSource Is Nothing Then
                Return
            End If
            Dim list As List(Of Trademark) = TryCast(repository.DataSource, List(Of Trademark))
            Dim val As Integer = DirectCast(e.Value, Integer)
            If val > 0 Then
                e.Image = list(DirectCast(e.Value, Integer) - 1).Logo
            End If
        End Sub
        Public Shared Sub InitMDBDataAndCreateEditors(ByVal connectionString As String, ByVal grid As GridControl, <System.Runtime.InteropServices.Out()> ByRef models As List(Of Model), <System.Runtime.InteropServices.Out()> ByRef trademarks As List(Of Trademark))
            Dim ds As DataSet = Nothing
            models = InitMDBDataCore(connectionString, ds, trademarks)
            CreateEditors(grid, ds, trademarks)
            InitColumnViewEditors(TryCast(grid.MainView, ColumnView))
        End Sub
        Public Shared Sub InitOrdersData(ByVal connectionString As String, ByVal grid As GridControl, ByVal itemCount As Integer, ByVal dataInterval As Integer)
            Dim ds As DataSet = Nothing
            Dim rnd As New Random()
            Dim listTrademarks As List(Of Trademark) = Nothing
            Dim listModels As List(Of Model) = InitMDBDataCore(connectionString, ds, listTrademarks, 1)
            Dim orders As New List(Of OrderItem)()
            For i As Integer = 0 To itemCount - 1
                orders.Add(New OrderItem(listModels(rnd.Next(0, listModels.Count - 1)), dataInterval, rnd, i + 1))
            Next i
            grid.DataSource = orders
            CreateEditors(grid, ds, listTrademarks)
        End Sub

        Public Shared Sub InitMDBData(ByVal connectionString As String, ByVal grid As GridControl)
            InitMDBData(connectionString, grid, 30)
        End Sub
        Public Shared Sub InitMDBData(ByVal connectionString As String, ByVal grid As GridControl, ByVal dataInterval As Integer)
            Dim ds As DataSet = Nothing
            Dim listTrademarks As List(Of Trademark) = Nothing
            Dim listModels As List(Of Model) = InitMDBDataCore(connectionString, ds, listTrademarks, dataInterval)
            SetGridDataSource(listModels, grid)
            CreateEditors(grid, ds, listTrademarks)
        End Sub
        Private Shared Sub CreateEditors(ByVal grid As GridControl, ByVal ds As DataSet, ByVal listTrademarks As List(Of Trademark))
            CreateSimpleLookUpEdit(grid, ds.Tables("Category"), "/Category")
            CreateSimpleLookUpEdit(grid, ds.Tables("BodyStyle"), "/BodyStyle")
            CreateSimpleLookUpEdit(grid, ds.Tables("TransmissionType"), "/TransmissionType")
            CreateTrademarkLookUpEdit(grid, listTrademarks, "/Trademark")
            CreateSpinEdit(grid, "/MPGCity/MPGHighway", 100, 1)
            CreateSpinEdit(grid, "/Doors", 10, 1)
            CreateSpinEdit(grid, "/Cylinders", 20, 1)
            CreateSpinEdit(grid, "/TransmissionSpeeds", 20, -1)
            CreateCurrencyEdit(grid, "/Price/ModelPrice")
            CreatePictureEdit(grid, "/TrademarkImage/Photo/Image")
        End Sub
        Private Shared Function InitMDBDataCore(ByVal connectionString As String, ByRef ds As DataSet, ByRef listTrademarks As List(Of Trademark)) As List(Of Model)
            Return InitMDBDataCore(connectionString, ds, listTrademarks, 30)
        End Function
        Private Shared Function InitMDBDataCore(ByVal connectionString As String, ByRef ds As DataSet, ByRef listTrademarks As List(Of Trademark), ByVal dataInterval As Integer) As List(Of Model)
            Dim Model As String = "Model"
            Dim Trademark As String = "Trademark"
            Dim Category As String = "Category"
            Dim BodyStyle As String = "BodyStyle"
            Dim TransmissionType As String = "TransmissionType"
            ds = New DataSet()
            FillTable(Model, Nothing, connectionString, ds)
            FillTable(Category, Nothing, connectionString, ds)
            FillTable(Trademark, Nothing, connectionString, ds)
            FillTable(BodyStyle, Nothing, connectionString, ds)
            FillTable(TransmissionType, Nothing, connectionString, ds)

            listTrademarks = New List(Of VehiclesData.Trademark)()
            For Each row_Renamed As DataRow In ds.Tables(Trademark).Rows
                listTrademarks.Add(New VehiclesData.Trademark() With {.ID = DirectCast(row_Renamed("ID"), Integer), .Name = DirectCast(row_Renamed("Name"), String), .Logo = ByteImageConverter.FromByteArray(DirectCast(row_Renamed("Logo"), Byte()))})
            Next row_Renamed

            Dim listModels = New List(Of VehiclesData.Model)()
            Dim rnd As New Random()
            For Each row_Renamed As DataRow In ds.Tables(Model).Rows
                listModels.Add(New VehiclesData.Model() With {.ID = DirectCast(row_Renamed("ID"), Integer), .Name = DirectCast(row_Renamed("Name"), String), .Trademark = DirectCast(row_Renamed("TrademarkID"), Integer), .Modification = DirectCast(row_Renamed("Modification"), String), .Category = DirectCast(row_Renamed("CategoryID"), Integer), .Price = DirectCast(row_Renamed("Price"), Decimal), .MPGCity = If(System.DBNull.Value.Equals(row_Renamed("MPG City")), Nothing, DirectCast(row_Renamed("MPG City"), Integer?)), .MPGHighway = If(System.DBNull.Value.Equals(row_Renamed("MPG City")), Nothing, DirectCast(row_Renamed("MPG Highway"), Integer?)), .Doors = DirectCast(row_Renamed("Doors"), Integer), .BodyStyle = DirectCast(row_Renamed("BodyStyleID"), Integer), .Cylinders = DirectCast(row_Renamed("Cylinders"), Integer), .Horsepower = DirectCast(row_Renamed("Horsepower"), String), .Torque = DirectCast(row_Renamed("Torque"), String), .TransmissionSpeeds = Convert.ToInt32(row_Renamed("Transmission Speeds")), .TransmissionType = DirectCast(row_Renamed("Transmission Type"), Integer), .Description = String.Format("{0}", row_Renamed("Description")), .Image = ByteImageConverter.FromByteArray(DirectCast(row_Renamed("Image"), Byte())), .Photo = ByteImageConverter.FromByteArray(DirectCast(row_Renamed("Photo"), Byte())), .DeliveryDate = Date.Now.AddDays(rnd.Next(dataInterval)), .InStock = rnd.Next(100) < 95, .Trademarks = listTrademarks})
            Next row_Renamed
            Return listModels
        End Function
        Public Shared Sub InitColumnViewEditors(ByVal view As ColumnView)
            If view.Columns.Count = 0 Then
                Return
            End If
            For Each col As GridColumn In view.Columns
                Dim item As RepositoryItem = GetEditByFielsName(col.FieldName, view.GridControl.RepositoryItems)
                If item IsNot Nothing AndAlso col.ColumnEdit Is Nothing Then
                    col.ColumnEdit = item
                End If
            Next col
            Dim gView As GridView = TryCast(view, GridView)
            If gView IsNot Nothing Then
                gView.GroupSummary.Add(SummaryItemType.Count, "ID")
            End If
            Dim colPrice As GridColumn = view.Columns("Price")
            If Not colPrice Is Nothing Then
                colPrice.DisplayFormat.FormatType = FormatType.Numeric
                colPrice.DisplayFormat.FormatString = "c"
            End If
            Dim colDeliveryDate As GridColumn = view.Columns("DeliveryDate")
            If Not colDeliveryDate Is Nothing Then
                colDeliveryDate.GroupInterval = ColumnGroupInterval.DateRange
            End If
        End Sub
        Private Shared Function GetEditByFielsName(ByVal fieldName As String, ByVal repositoryItemCollection As RepositoryItemCollection) As RepositoryItem
            For Each item As RepositoryItem In repositoryItemCollection
                If item.Name.IndexOf("/" & fieldName) >= 0 Then
                    Return item
                End If
            Next item
            Return Nothing
        End Function
        Private Shared Function CreatePictureEdit(ByVal grid As GridControl, ByVal name As String) As RepositoryItemPictureEdit
            Dim ret As New RepositoryItemPictureEdit()
            grid.RepositoryItems.Add(ret)
            ret.PictureInterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic
            ret.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze
            ret.Name = name
            Return ret
        End Function
        Private Shared Function CreateCurrencyEdit(ByVal grid As GridControl, ByVal name As String) As RepositoryItemTextEdit
            Dim ret As New RepositoryItemTextEdit()
            grid.RepositoryItems.Add(ret)
            ret.AutoHeight = False
            ret.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
            ret.Mask.EditMask = "c"
            ret.Mask.UseMaskAsDisplayFormat = True
            ret.Name = name
            Return ret
        End Function
        Private Shared Function CreateSpinEdit(ByVal grid As GridControl, ByVal name As String, ByVal maxValue As Integer, ByVal minValue As Integer) As RepositoryItemSpinEdit
            Dim ret As New RepositoryItemSpinEdit()
            grid.RepositoryItems.Add(ret)
            ret.AutoHeight = False
            ret.IsFloatValue = False
            ret.Mask.EditMask = "N00"
            ret.MaxValue = maxValue
            ret.MinValue = minValue
            ret.Name = name
            Return ret
        End Function
        Private Shared Function CreateSimpleLookUpEdit(ByVal grid As GridControl, ByVal tbl As DataTable, ByVal name As String) As RepositoryItemLookUpEdit
            Dim ret As New RepositoryItemLookUpEdit()
            grid.RepositoryItems.Add(ret)
            ret.AutoHeight = False
            ret.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Name")})
            ret.PopupFormMinSize = New Size(100, 0)
            ret.DisplayMember = "Name"
            ret.Name = name
            ret.ShowFooter = False
            ret.ShowHeader = False
            ret.ValueMember = "ID"
            ret.DataSource = tbl
            ret.DropDownRows = tbl.Rows.Count
            Return ret
        End Function
        Private Shared Function CreateTrademarkLookUpEdit(ByVal grid As GridControl, ByVal ds As Object, ByVal name As String) As RepositoryItemGridLookUpEditWithGlyph
            Dim ret As New RepositoryItemGridLookUpEditWithGlyph()
            Dim picture As New RepositoryItemPictureEdit()
            grid.RepositoryItems.Add(ret)
            ret.AutoHeight = False
            ret.DisplayMember = "Name"
            ret.Name = name
            picture.PictureInterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic
            picture.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze
            ret.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {picture})
            ret.ValueMember = "ID"
            Dim view As New GridView()
            ret.View = view
            Dim colLogo As New GridColumn()
            Dim colName As New GridColumn()
            view.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {colLogo, colName})
            view.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
            view.OptionsSelection.EnableAppearanceFocusedCell = False
            view.OptionsView.RowAutoHeight = True
            view.OptionsView.ShowColumnHeaders = False
            view.OptionsView.ShowGroupPanel = False
            view.OptionsView.ShowIndicator = False
            colLogo.ColumnEdit = picture
            colLogo.FieldName = "Logo"
            colLogo.Visible = True
            colLogo.VisibleIndex = 0
            colName.FieldName = "Name"
            colName.Visible = True
            colName.VisibleIndex = 1
            ret.DataSource = ds
            Return ret
        End Function
        Private Shared Sub FillTable(ByVal table As String, ByVal query As String, ByVal connectionString As String, ByVal ds As DataSet)
            If query Is Nothing Then
                query = String.Format("SELECT * FROM {0}", table)
            End If
            Dim oleDbDataAdapter As New System.Data.OleDb.OleDbDataAdapter(query, connectionString)
            'SetWaitDialogCaption(string.Format("Loading {0}...", table));
            oleDbDataAdapter.Fill(ds, table)
        End Sub

        Private Shared Sub SetGridDataSource(ByVal ds As Object, ByVal grid As GridControl)
            grid.DataMember = Nothing
            grid.DataSource = ds
        End Sub

        Private Shared Sub repositoryItemGridLookUpEdit1_GetImageByValue(ByVal sender As Object, ByVal e As ImageByValueEventArgs)
            VehiclesData.LogoGridLookupGetImageByValue(sender, e)
        End Sub
    End Class
End Namespace

