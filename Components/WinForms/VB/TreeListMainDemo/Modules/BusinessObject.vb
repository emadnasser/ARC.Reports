Imports System.Text
Imports System.ComponentModel
Imports System.Collections

Namespace DevExpress.XtraTreeList.Demos
	Public Enum Priority
		Normal = 0
		Low = 1
		High = 2
	End Enum
	Public Class Project
		Private name_Renamed As String
		Private description_Renamed As String
		Private startDate_Renamed As Date
		Private endDate_Renamed As Date
		Private priority_Renamed As Priority
		Private owner_Renamed As Projects
		Private projects_Renamed As Projects
		Private isTask_Renamed As Boolean
		Public Sub New()
			Me.owner_Renamed = Nothing
			Me.name_Renamed = ""
			Me.description_Renamed = ""
			Me.isTask_Renamed = False
			Me.endDate_Renamed = Date.Today
			Me.startDate_Renamed = Me.endDate_Renamed
			Me.priority_Renamed = Priority.Normal
			Me.projects_Renamed = New Projects()
		End Sub
		Public Sub New(ByVal name As String, ByVal description As String, ByVal startDate As Date, ByVal endDate As Date, ByVal priority As Priority, ByVal isTask As Boolean)
			Me.name_Renamed = name
			Me.description_Renamed = description
			Me.isTask_Renamed = isTask
			Me.startDate_Renamed = startDate
			Me.endDate_Renamed = endDate
			Me.priority_Renamed = priority
			Me.projects_Renamed = New Projects()
		End Sub
		Public Sub New(ByVal projects As Projects, ByVal name As String, ByVal description As String, ByVal startDate As Date, ByVal endDate As Date, ByVal priority As Priority, ByVal isTask As Boolean)
			Me.New(name, description, startDate, endDate, priority, isTask)
			Me.projects_Renamed = projects
		End Sub
		<Browsable(False)> _
		Public Property Owner() As Projects
			Get
				Return owner_Renamed
			End Get
			Set(ByVal value As Projects)
				owner_Renamed = value
			End Set
		End Property
		Public Property IsTask() As Boolean
			Get
				Return isTask_Renamed
			End Get
			Set(ByVal value As Boolean)
				If isTask_Renamed = value Then
					Return
				End If
				isTask_Renamed = value
				OnChanged()
			End Set
		End Property
		Public Property Name() As String
			Get
				Return name_Renamed
			End Get
			Set(ByVal value As String)
				If Name = value Then
					Return
				End If
				name_Renamed = value
				OnChanged()
			End Set
		End Property
		<Browsable(False)> _
		Public Property Description() As String
			Get
				Return description_Renamed
			End Get
			Set(ByVal value As String)
				If Description = value Then
					Return
				End If
				description_Renamed = value
				OnChanged()
			End Set
		End Property
		Public Property StartDate() As Date
			Get
				Return startDate_Renamed
			End Get
			Set(ByVal value As Date)
				If StartDate = value Then
					Return
				End If
				startDate_Renamed = value
				OnChanged()
			End Set
		End Property
		Public Property EndDate() As Date
			Get
				Return endDate_Renamed
			End Get
			Set(ByVal value As Date)
				If StartDate = value Then
					Return
				End If
				endDate_Renamed = value
				OnChanged()
			End Set
		End Property
		Public Property Priority() As Priority
			Get
				Return priority_Renamed
			End Get
			Set(ByVal value As Priority)
				If Priority = value Then
					Return
				End If
				priority_Renamed = value
				OnChanged()
			End Set
		End Property
		<Browsable(False)> _
		Public ReadOnly Property Projects() As Projects
			Get
				Return projects_Renamed
			End Get
		End Property
		Private Sub OnChanged()
			If owner_Renamed Is Nothing Then
				Return
			End If
			Dim index As Integer = owner_Renamed.IndexOf(Me)
			owner_Renamed.ResetItem(index)
		End Sub
	End Class
	'<treeList1>
	Public Class Projects
		Inherits BindingList(Of Project)
		Implements TreeList.IVirtualTreeListData

		Private Sub IVirtualTreeListData_VirtualTreeGetChildNodes(ByVal info As VirtualTreeGetChildNodesInfo) Implements TreeList.IVirtualTreeListData.VirtualTreeGetChildNodes
			Dim obj As Project = TryCast(info.Node, Project)
			info.Children = obj.Projects
		End Sub
		Protected Overrides Sub InsertItem(ByVal index As Integer, ByVal item As Project)
			item.Owner = Me
			MyBase.InsertItem(index, item)
		End Sub
		Private Sub IVirtualTreeListData_VirtualTreeGetCellValue(ByVal info As VirtualTreeGetCellValueInfo) Implements TreeList.IVirtualTreeListData.VirtualTreeGetCellValue
			Dim obj As Project = TryCast(info.Node, Project)
			Select Case info.Column.Caption
				Case "Name"
					info.CellData = obj.Name
				Case "Description"
					info.CellData = obj.Description
				Case "StartDate"
					info.CellData = obj.StartDate
				Case "EndDate"
					info.CellData = obj.EndDate
				Case "Priority"
					info.CellData = obj.Priority
			End Select
		End Sub
		Private Sub IVirtualTreeListData_VirtualTreeSetCellValue(ByVal info As VirtualTreeSetCellValueInfo) Implements TreeList.IVirtualTreeListData.VirtualTreeSetCellValue
			Dim obj As Project = TryCast(info.Node, Project)
			Select Case info.Column.Caption
				Case "Name"
					obj.Name = CStr(info.NewCellData)
				Case "Description"
					obj.Description = CStr(info.NewCellData)
				Case "StartDate"
					obj.StartDate = CDate(info.NewCellData)
				Case "EndDate"
					obj.EndDate = CDate(info.NewCellData)
				Case "Priority"
					obj.Priority = CType(info.NewCellData, Priority)
			End Select
		End Sub
	End Class
	'</treeList1>
End Namespace
