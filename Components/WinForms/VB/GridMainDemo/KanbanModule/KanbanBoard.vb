Imports Microsoft.VisualBasic
Imports DevExpress.Utils
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid.Views.Tile
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms

Namespace DevExpress.XtraGrid.Demos
	Partial Public Class KanbanBoard
		Inherits TutorialControl
		Private tasksData As BindingList(Of TaskRecord)
		Private employeesData As DataTable
		Private membersData As DataTable
		Private checklistData As DataTable
		Private checkBadge As Image
		Private checkBadgeDone As Image

		Public Sub New()
			InitializeComponent()
			InitData()
			tileView.OptionsEditForm.CustomEditFormLayout = New KanbanEditControl(tileView, employeesData, membersData, checklistData)
			checkBadge = KanbanHelper.CreateCheckBadge(Color.Gray)
			checkBadgeDone = KanbanHelper.CreateCheckBadge(GetLabelColor(TaskLabel.Green))
		End Sub

		Private Sub InitData()
			Dim dataSet = New DataSet()
			tasksData = KanbanHelper.LoadTasks()
			employeesData = KanbanHelper.LoadEmployees()
			membersData = KanbanHelper.LoadMembers()
			checklistData = KanbanHelper.LoadChecklist()
			KanbanHelper.ProcessMembersPhoto(employeesData)
			gridControl.DataSource = tasksData
		End Sub

		Private Sub tileView_ItemCustomize(ByVal sender As Object, ByVal e As Views.Tile.TileViewItemCustomizeEventArgs) Handles tileView.ItemCustomize
			Dim task = TryCast(tileView.GetRow(e.RowHandle), TaskRecord)
			If task Is Nothing Then
				Return
			End If
			e.Item("Label").Appearance.Normal.BackColor = GetLabelColor(task.Label)
			e.Item("Description").ImageVisible = Not String.IsNullOrEmpty(task.Description)
			If IsEmptyItem(e.RowHandle) Then
				e.Item("Caption").Text = "Add a card..."
				e.Item.AppearanceItem.Normal.BackColor = Color.LightGray
				e.Item.AppearanceItem.Normal.ForeColor = Color.DarkGray
				Return
			End If
			UpdateProgressElement(e.Item, task.Id.ToString())
			Dim elements = GetMembersElements(task.Id.ToString())
			If elements.Count = 0 Then
				Return
			End If
			Dim prev As TileViewItemElement = Nothing
			For Each element In elements
				e.Item.Elements.Add(element)
				If prev IsNot Nothing Then
					element.AnchorElement = prev
					element.AnchorAlignment = AnchorAlignment.Left
					element.AnchorIndent = 4
				Else
					element.ImageAlignment = TileItemContentAlignment.BottomRight
				End If
				prev = element
			Next element
		End Sub
		Private Sub tileView_BeforeItemDrag(ByVal sender As Object, ByVal e As BeforeItemDragEventArgs) Handles tileView.BeforeItemDrag
			e.Cancel = IsEmptyItem(e.RowHandle)
		End Sub
		Private Sub tileView_EditFormShowing(ByVal sender As Object, ByVal e As Views.Grid.EditFormShowingEventArgs) Handles tileView.EditFormShowing
			e.Allow = Not IsEmptyItem(e.RowHandle)
		End Sub
		Private Sub tileView_ItemDrop(ByVal sender As Object, ByVal e As ItemDropEventArgs) Handles tileView.ItemDrop
			Dim newStatus = CType(e.GroupColumnValue, TaskStatus)
			Dim prevStatus = CType(e.PrevGroupColumnValue, TaskStatus)
			If (Not prevStatus.Equals(newStatus)) Then
				tileView.BeginDataUpdate()
				RemoveEmptyItem(newStatus)
				AddEmptyItem(prevStatus)
				tileView.EndDataUpdate()
			End If
		End Sub
		Private Sub tileView_ItemClick(ByVal sender As Object, ByVal e As TileViewItemClickEventArgs) Handles tileView.ItemClick
			If (Not IsEmptyItem(e.Item.RowHandle)) Then
				Return
			End If
			Dim status As TaskStatus = CType(tileView.GetRowCellValue(e.Item.RowHandle, "Status"), TaskStatus)
			AddNewCard(status)
		End Sub
		Private Sub UpdateProgressElement(ByVal item As TileViewItem, ByVal taskId As String)
			Dim count As Integer = checklistData.Select("TaskID = " & taskId).Count()
			Dim doneCount As Integer = checklistData.Select("TaskID = " & taskId & " AND Checked").Count()
			Dim progressElement = item("Progress")
			If count = 0 Then
				progressElement.Text = String.Empty
				Return
			End If
			progressElement.ImageVisible = True
			progressElement.Image = checkBadge
			progressElement.Text = String.Format("{0}/{1}", doneCount, count)
			If (Not item("Description").ImageVisible) Then
				progressElement.AnchorIndent = 0
			End If
			If count = doneCount Then
				progressElement.Image = checkBadgeDone
				progressElement.Appearance.Normal.ForeColor = GetLabelColor(TaskLabel.Green)
			End If
		End Sub
		Private Function GetMembersElements(ByVal taskId As String) As List(Of TileViewItemElement)
			Dim memberRows = membersData.Select("TaskID = " & taskId)
			Dim result = New List(Of TileViewItemElement)()
			For Each memberRow In memberRows
				Dim photoBytes = employeesData.Rows.Find(memberRow("MemberID"))("Photo")
				Dim element = New TileViewItemElement()
				element.Image = ByteImageConverter.FromByteArray(TryCast(photoBytes, Byte()))
				result.Add(element)
			Next memberRow
			Return result
		End Function
		Private Function GetLabelColor(ByVal label As TaskLabel) As Color
			Select Case label
				Case TaskLabel.Red
					Return ColorTranslator.FromHtml("#f06562")
				Case TaskLabel.Green
					Return ColorTranslator.FromHtml("#069c47")
				Case TaskLabel.Yellow
					Return ColorTranslator.FromHtml("#e6c730")
				Case Else
					Return Color.Empty
			End Select
		End Function
		Private Function IsEmptyItem(ByVal rowHandle As Integer) As Boolean
			Dim row = tileView.GetRow(rowHandle)
			If row Is Nothing Then
				Return False
			End If
			Return CInt(Fix(tileView.GetRowCellValue(rowHandle, "Id"))) < 0
		End Function

		Private Sub AddNewCard(ByVal status As TaskStatus)
			Dim newCaption As String = XtraInputBox.Show("", "Add new card", "New Task")
			If String.IsNullOrEmpty(newCaption) Then
				Return
			End If
			Dim newRow = KanbanHelper.CreateNewTask()
			Dim maxId As Integer = tasksData.OrderByDescending(Function(x) x.Id).ToList()(0).Id
			newRow.Id = maxId + 1
			newRow.Status = status
			newRow.Caption = newCaption
			tasksData.Add(newRow)
			tileView.FocusedRowHandle = tileView.GetRowHandle(tasksData.IndexOf(newRow))
			RemoveEmptyItem(newRow.Status)
		End Sub

		Private Sub AddEmptyItem(ByVal status As TaskStatus)
			KanbanHelper.AddEmptyItem(tasksData, status)
		End Sub
		Private Sub RemoveEmptyItem(ByVal status As TaskStatus)
			KanbanHelper.RemoveEmptyItem(tasksData, status)
		End Sub
	End Class
End Namespace
