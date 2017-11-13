Imports Microsoft.VisualBasic
Imports DevExpress.Utils
Imports DevExpress.Utils.Svg
Imports DevExpress.XtraEditors.Controls
Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Drawing.Imaging
Imports System.IO
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports System.Xml.Serialization

Namespace DevExpress.XtraGrid.Demos
	Public Class KanbanHelper
		Public Shared Function LoadTasks() As BindingList(Of TaskRecord)
			Dim file As String = FilesHelper.FindingFileName(Application.StartupPath, "Data\KanbanModuleData\KanbanTasks.xml")
			Dim tasks = New BindingList(Of TaskRecord)()
			Using reader = New StreamReader(file)
				Dim deserializer As New XmlSerializer(GetType(TaskList), New XmlRootAttribute("DocumentElement"))
				Dim taskList = CType(deserializer.Deserialize(reader), TaskList)
				tasks = taskList.List
			End Using
			Return tasks
		End Function
		Public Shared Function LoadChecklist() As DataTable
			Dim file As String = FilesHelper.FindingFileName(Application.StartupPath, "Data\KanbanModuleData\KanbanChecklist.xml")
			Dim checklist = New DataTable()
			checklist.TableName = "TaskChecklist"
			checklist.Columns.Add("TaskID", GetType(Int32))
			checklist.Columns.Add("Caption", GetType(String))
			checklist.Columns.Add("Checked", GetType(Boolean))
			If (Not String.IsNullOrEmpty(file)) AndAlso System.IO.File.Exists(file) Then
				checklist.ReadXml(file)
			End If
			Return checklist
		End Function
		Public Shared Function LoadMembers() As DataTable
			Dim file As String = FilesHelper.FindingFileName(Application.StartupPath, "Data\KanbanModuleData\KanbanMembers.xml")
			Dim members = New DataTable()
			members.TableName = "TaskMembers"
			members.Columns.Add("TaskID", GetType(Int32))
			members.Columns.Add("MemberID", GetType(Int32))
			If (Not String.IsNullOrEmpty(file)) AndAlso System.IO.File.Exists(file) Then
				members.ReadXml(file)
			End If
			Return members
		End Function
		Public Shared Function LoadEmployees() As DataTable
			Dim DBFileName As String = String.Empty
			Dim connectionString As String = String.Empty
			DBFileName = FilesHelper.FindingFileName(Application.StartupPath, "Data\nwind.mdb")
			If String.IsNullOrEmpty(DBFileName) Then
				Return Nothing
			End If
			connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & DBFileName
			Dim table = New DataTable()
			Dim oleDbDataAdapter As New System.Data.OleDb.OleDbDataAdapter("SELECT * FROM Employees", connectionString)
			oleDbDataAdapter.Fill(table)
			table.TableName = "Employees"
			table.PrimaryKey = New DataColumn() { table.Columns("EmployeeID") }
			Return table
		End Function
		Public Shared Sub ProcessMembersPhoto(ByVal employees As DataTable)
			For i As Integer = 0 To employees.Rows.Count - 1
				Dim row = employees.Rows(i)
				Dim bytes = row("Photo")
				Dim fullImage = ByteImageConverter.FromByteArray(TryCast(bytes, Byte()))

				Dim size = New Size(40, 40)
				Dim scaleX As Single = (CSng(size.Width)) / fullImage.Width
				Dim scaleY As Single = (CSng(size.Height)) / fullImage.Height
				Dim scale As Single
				If scaleX > scaleY Then
					scale = scaleX
				Else
					scale = scaleY
				End If

				Dim resizedImage = New Bitmap(size.Width, size.Height)
				Using g As Graphics = Graphics.FromImage(resizedImage)
					size = New Size(CInt(Fix(fullImage.Width * scale + 0.5f)), CInt(Fix(fullImage.Height * scale + 0.5f)))
					g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic
					g.DrawImage(fullImage, New Rectangle(Point.Empty, size))
				End Using
				Dim opt = New PictureEditOptionsMask(Nothing)
				Dim img = PictureMaskHelper.CreateCircleMaskImage(resizedImage, opt)
				Dim ms As New MemoryStream()
				img.Save(ms, ImageFormat.Png)
				Dim result = ms.ToArray()
				ms.Close()
				row("Photo") = result
			Next i
		End Sub
		Public Shared Sub AddEmptyItem(ByVal table As IList(Of TaskRecord), ByVal status As TaskStatus)
			Dim row = table.FirstOrDefault(Function(x) x.Status = status)
			If row Is Nothing Then
				Dim emptyRow = CreateNewTask()
				emptyRow.Id = -1
				emptyRow.Status = status
				table.Add(emptyRow)
			End If
		End Sub
		Public Shared Sub RemoveEmptyItem(ByVal table As IList(Of TaskRecord), ByVal status As TaskStatus)
			Dim row = table.FirstOrDefault(Function(x) x.IsEmpty AndAlso x.Status = status)
			If row IsNot Nothing Then
				table.Remove(row)
			End If
		End Sub
		Public Shared Function CreateNewTask() As TaskRecord
			Return New TaskRecord()
		End Function
		Public Shared Function CreateCheckBadge(ByVal color As Color) As Image
            Dim assembly = GetType(KanbanHelper).Assembly
            Dim svgBitmap As SvgBitmap
            Using stream = assembly.GetManifestResourceStream("CheckImage.svg")
                svgBitmap = svgBitmap.FromStream(stream)
            End Using
			If svgBitmap Is Nothing Then
				Return Nothing
			End If
			Dim pallet = New SvgPalette()
			pallet.Colors.Add(New SvgColor("Black", color))
			Return svgBitmap.Render(pallet)
		End Function
	End Class

	Public Enum TaskStatus
		ToDo
		Planned
		Doing
		Testing
		Done
	End Enum
	Public Enum TaskLabel
		None
		Red
		Yellow
		Green
	End Enum

	Public Class TaskRecord
		Public Sub New()
			Label = TaskLabel.None
		End Sub
		Private privateId As Integer
		Public Property Id() As Integer
			Get
				Return privateId
			End Get
			Set(ByVal value As Integer)
				privateId = value
			End Set
		End Property
		Private privateCaption As String
		Public Property Caption() As String
			Get
				Return privateCaption
			End Get
			Set(ByVal value As String)
				privateCaption = value
			End Set
		End Property
		Private privateDescription As String
		Public Property Description() As String
			Get
				Return privateDescription
			End Get
			Set(ByVal value As String)
				privateDescription = value
			End Set
		End Property
		Private privateStatus As TaskStatus
		<XmlIgnore> _
		Public Property Status() As TaskStatus
			Get
				Return privateStatus
			End Get
			Set(ByVal value As TaskStatus)
				privateStatus = value
			End Set
		End Property
		Private privateLabel As TaskLabel
		<XmlIgnore> _
		Public Property Label() As TaskLabel
			Get
				Return privateLabel
			End Get
			Set(ByVal value As TaskLabel)
				privateLabel = value
			End Set
		End Property
		Public ReadOnly Property IsEmpty() As Boolean
			Get
				Return Id = -1
			End Get
		End Property
		<XmlElement("Status")> _
		Public Property StatusCore() As Integer
			Get
				Return 0
			End Get
			Set(ByVal value As Integer)
				Status = CType(value, TaskStatus)
			End Set
		End Property
		<XmlElement("Label")> _
		Public Property LabelCore() As Integer
			Get
				Return 0
			End Get
			Set(ByVal value As Integer)
				Label = CType(value, TaskLabel)
			End Set
		End Property
	End Class

	<XmlRoot("DocumentElement")> _
	Public Class TaskList
		Public Sub New()
			List = New BindingList(Of TaskRecord)()
		End Sub
		Private privateList As BindingList(Of TaskRecord)
		<XmlElement("Tasks")> _
		Public Property List() As BindingList(Of TaskRecord)
			Get
				Return privateList
			End Get
			Set(ByVal value As BindingList(Of TaskRecord))
				privateList = value
			End Set
		End Property
	End Class
End Namespace
