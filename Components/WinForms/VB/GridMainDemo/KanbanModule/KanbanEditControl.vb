Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.Utils.Menu
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.Utils

Namespace DevExpress.XtraGrid.Demos
	Partial Public Class KanbanEditControl
		Inherits EditFormUserControl
		Private OwnerView As DevExpress.XtraGrid.Views.Tile.TileView
		Private ReadOnly Property OwnerGrid() As GridControl
			Get
				Return OwnerView.GridControl
			End Get
		End Property
		Private privateEmployees As DataTable
		Private Property Employees() As DataTable
			Get
				Return privateEmployees
			End Get
			Set(ByVal value As DataTable)
				privateEmployees = value
			End Set
		End Property
		Private privateMembers As DataTable
		Private Property Members() As DataTable
			Get
				Return privateMembers
			End Get
			Set(ByVal value As DataTable)
				privateMembers = value
			End Set
		End Property
		Private privateChecklist As DataTable
		Private Property Checklist() As DataTable
			Get
				Return privateChecklist
			End Get
			Set(ByVal value As DataTable)
				privateChecklist = value
			End Set
		End Property

		Public Sub New(ByVal ownerView As DevExpress.XtraGrid.Views.Tile.TileView, ByVal employees As DataTable, ByVal members As DataTable, ByVal checkList As DataTable)
			InitializeComponent()
			Me.OwnerView = ownerView
			Me.comboBoxEdit1.Properties.Items.AddRange(GetType(TaskLabel).GetEnumValues())
			Me.Employees = employees
			Me.Members = members
			Me.Checklist = checkList
			Me.gridControl1.DataSource = Checklist
			Me.memberTiles.AnimateArrival = False
			AddHandler Me.memberTiles.ItemClick, AddressOf tileControl1_ItemClick
			AddHandler Me.VisibleChanged, AddressOf AnonymousMethod1
			AddHandler Me.gridChecklist.CellValueChanged, AddressOf gridView1_CellValueChanged
			AddHandler Me.gridChecklist.RowCountChanged, AddressOf AnonymousMethod2
		End Sub
		
		Private Sub AnonymousMethod1(ByVal s As Object, ByVal e As Object)
			If Visible Then
				ControlShown()
			End If
		End Sub
		
		Private Sub AnonymousMethod2(ByVal s As Object, ByVal e As Object)
			UpdateProgressBar()
		End Sub

		Private Sub ControlShown()
			PopulateMembers()
			UpdateProgressBar()
		End Sub
		Private Sub PopulateMembers()
			tileGroup.Items.Clear()
			addMemberItem.Visible = True
			tileGroup.Items.Add(addMemberItem)

			Dim memberIDs = GetMemeberIDs()
			For Each memberId In memberIDs
				Dim bytes = Employees.Rows.Find(memberId)("Photo")
				Dim item = New TileItem()
				item.Image = ByteImageConverter.FromByteArray(TryCast(bytes, Byte()))
				item.ImageAlignment = TileItemContentAlignment.MiddleCenter
				Dim superTip = New SuperToolTip()
				superTip.Items.AddTitle(GetEmployeeFullName(memberId))
				item.SuperTip = superTip
				item.Tag = memberId
				tileGroup.Items.Insert(0, item)
				If tileGroup.Items.Count = 5 Then
					addMemberItem.Visible = False
				Else
					addMemberItem.Visible = True
				End If
			Next memberId
		End Sub
		Private Sub OnAddMemberMenuClick(ByVal sender As Object, ByVal e As EventArgs)
			Dim newId As String = TryCast((TryCast(sender, DXMenuItem)).Tag, String)
			Dim newRow = Members.NewRow()
			newRow("TaskID") = CurrentTaskID
			newRow("MemberID") = newId
			Members.Rows.Add(newRow)
			PopulateMembers()
		End Sub
		Private Sub addMemberItem_ItemClick(ByVal sender As Object, ByVal e As TileItemEventArgs) Handles addMemberItem.ItemClick
			Dim memberIDs = GetMemeberIDs()
			Dim menu = New DXPopupMenu()
			menu.MenuViewType = MenuViewType.Menu
			For i As Integer = 0 To Employees.Rows.Count - 1
				Dim row = Employees.Rows(i)
				Dim id As String = row("EmployeeID").ToString()
				If memberIDs.Contains(id) Then
					Continue For
				End If
				Dim fullName As String = GetEmployeeFullName(id)
				Dim memberMenuItem = New DXMenuItem(fullName, New EventHandler(AddressOf OnAddMemberMenuClick)) With {.Tag = id}
				menu.Items.Add(memberMenuItem)
			Next i
			ShowPopup(menu)
		End Sub
		Private Sub tileControl1_ItemClick(ByVal sender As Object, ByVal e As TileItemEventArgs)
            If e.Item Is addMemberItem Then
                Return
            End If
			Dim menu = New DXPopupMenu()
			menu.MenuViewType = MenuViewType.Menu
			Dim id As String = TryCast(e.Item.Tag, String)
			Dim removeItem = New DXMenuItem("Remove from card", New EventHandler(AddressOf OnRemoveItemClick)) With {.Tag = id}
			menu.Items.Add(removeItem)
			ShowPopup(menu)
		End Sub
		Private Sub OnRemoveItemClick(ByVal sender As Object, ByVal e As EventArgs)
			Dim memberId = TryCast((TryCast(sender, DXMenuItem)).Tag, String)
			Dim rowsToRemove = Members.Select("TaskID = " & CurrentTaskID & "AND MemberID = " & memberId)
			For Each rowToRemove In rowsToRemove
				Members.Rows.Remove(rowToRemove)
			Next rowToRemove
			PopulateMembers()
		End Sub
		Private Sub ShowPopup(ByVal menu As DXPopupMenu)
			Dim parentControl As Control = memberTiles
			Dim pt As Point = parentControl.PointToClient(Control.MousePosition)
			CType(menu, IDXDropDownControl).Show(StandardMenuManager.Default, parentControl, pt)
		End Sub
		Private Function GetEmployeeFullName(ByVal employeeId As String) As String
			Dim row = Employees.Rows.Find(employeeId)
			Return String.Format("{0} {1}", row("FirstName"), row("LastName"))
		End Function
		Private Function GetMemeberIDs() As List(Of String)
			Dim memberRows = Members.Select("TaskID = " & CurrentTaskID)
			Return memberRows.AsEnumerable().Select(Function(x) x("MemberID").ToString()).ToList()
		End Function
		Private ReadOnly Property CurrentTaskID() As String
			Get
				Return (TryCast(OwnerView.GetRow(OwnerView.FocusedRowHandle), TaskRecord)).Id.ToString()
			End Get
		End Property
		Private Sub gridView1_CustomRowFilter(ByVal sender As Object, ByVal e As Views.Base.RowFilterEventArgs) Handles gridChecklist.CustomRowFilter
			Dim view As GridView = TryCast(sender, GridView)
			Dim dv As DataView = TryCast(view.DataSource, DataView)
			If dv(e.ListSourceRow)("TaskID").ToString() = CurrentTaskID Then
				e.Visible = True
			Else
				e.Visible = False
			End If
			e.Handled = True
		End Sub
		Private Sub gridView1_InitNewRow(ByVal sender As Object, ByVal e As InitNewRowEventArgs) Handles gridChecklist.InitNewRow
			gridChecklist.SetRowCellValue(e.RowHandle, gridChecklist.Columns("TaskID"), Integer.Parse(CurrentTaskID))
			gridChecklist.SetRowCellValue(e.RowHandle, gridChecklist.Columns("Caption"), "New item")
			gridChecklist.SetRowCellValue(e.RowHandle, gridChecklist.Columns("Checked"), False)
		End Sub
		Private Sub gridView1_CellValueChanged(ByVal sender As Object, ByVal e As Views.Base.CellValueChangedEventArgs)
			gridChecklist.UpdateCurrentRow()
			UpdateProgressBar()
		End Sub
		Private Sub repositoryItemCheckEdit1_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles repositoryItemCheckEdit1.CheckedChanged
			gridChecklist.PostEditor()
		End Sub
		Private Sub UpdateProgressBar()
			Dim count As Integer = Checklist.Select("TaskID = " & CurrentTaskID).Count()
			If count = 0 Then
				progressBarControl1.Properties.Maximum = 1
				progressBarControl1.Position = 0
			Else
				progressBarControl1.Properties.Maximum = count
				progressBarControl1.Position = Checklist.Select("TaskID = " & CurrentTaskID & " AND Checked").Count()
			End If
		End Sub
	End Class
End Namespace
