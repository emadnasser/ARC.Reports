Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq.Expressions
Imports System.Reflection
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.Spreadsheet
Imports DevExpress.XtraSpreadsheet.Model
Imports DevExpress.XtraTreeList.Nodes
Imports DevExpress.DXperience.Demos

Namespace DevExpress.XtraSpreadsheet.Demos
	Partial Public Class SpreadsheetEventViewerModule
		Inherits SpreadSheetTutorialControlBase
		#Region "Fields"
		Private Const documentName As String = "UnitConverter_template.xlsx"
		Private Const customDrawRowText As String = "5"
		Private Const customDrawColumnText As String = "D"

		Private hooks As List(Of SpreadsheetEventHooker)
		Private customDrawCellEventsList As List(Of String)
		Private customDrawHeaderEventsList As List(Of String)
		Private customDrawCellPosition As New CellPosition(2, 3) ' C4
		#End Region

		Public Sub New()
			hooks = New List(Of SpreadsheetEventHooker)()
			customDrawCellEventsList = CreateCustomDrawCellEventsList()
			customDrawHeaderEventsList = CreateCustomDrawHeaderEventsList()
			InitializeComponent()
			Me.spreadsheetControl1.Options.Culture = DefaultCulture
			PrepareBookContent()
			EnumerateEvents()
			checkAllEdit.CheckState = CheckState.Checked
			customDrawCellBarEdit.EditValue = customDrawCellPosition.ToString()
		End Sub

		#Region "static helper functions"
		Private Shared Function CreateCustomDrawCellEventsList() As List(Of String)
			Dim result As New List(Of String)()
			result.Add("CustomDrawCell")
			result.Add("CustomDrawCellBackground")
			Return result
		End Function
		Private Shared Function CreateCustomDrawHeaderEventsList() As List(Of String)
			Dim result As New List(Of String)()
			result.Add("CustomDrawColumnHeader")
			result.Add("CustomDrawColumnHeaderBackground")
			result.Add("CustomDrawRowHeader")
			result.Add("CustomDrawRowHeaderBackground")
			Return result
		End Function

		Private Shared Function SortHooksByName(ByVal arg1 As SpreadsheetEventHooker, ByVal arg2 As SpreadsheetEventHooker) As Integer
			Return arg1.Name.CompareTo(arg2.Name)
		End Function
		#End Region

		Private Sub EnumerateEvents()
			Dim controlType As Type = spreadsheetControl1.GetType()
			Dim events() As EventInfo = controlType.GetEvents(BindingFlags.Instance Or BindingFlags.Public Or BindingFlags.DeclaredOnly)
			For Each item As EventInfo In events
				Dim eventName As String = item.Name
				If customDrawCellEventsList.Contains(eventName) Then
					hooks.Add(New SpreadsheetCustomDrawCellEventHooker(eventName, Me))
				ElseIf customDrawHeaderEventsList.Contains(eventName) Then
					hooks.Add(New SpreadsheetCustomDrawHeaderEventHooker(eventName, Me))
				Else
					hooks.Add(New SpreadsheetEventHooker(eventName, Me))
				End If
			Next item
			hooks.Sort(AddressOf SortHooksByName)
			For i As Integer = 0 To hooks.Count - 1
				Dim eventName As String = hooks(i).Name
				eventsCheckedListBox.Items.Add(i, eventName) ', CheckState.Checked, true);
				'hooks[i].HookEvent(spreadsheetControl1);
			Next i
		End Sub

		Private Sub PrepareBookContent()
			Dim book As IWorkbook = spreadsheetControl1.Document
			spreadsheetControl1.BeginUpdate()
			Try
				book.LoadDocument(DemoUtils.GetRelativePath(documentName))
			Finally
				spreadsheetControl1.EndUpdate()
			End Try
		End Sub

		Private Function GetEventParameter(ByVal item As PropertyInfo, ByVal value As Object) As String
			Dim strBuilder As New StringBuilder()
			strBuilder.Append(item.Name)
			If item.PropertyType Is GetType(String) Then
				strBuilder.Append("='")
				strBuilder.Append(value)
				strBuilder.Append("'"c)
			Else
				strBuilder.Append("="c)
				strBuilder.Append(value)
			End If
			Return strBuilder.ToString()
		End Function

		Public Sub CustomDrawCellEventLogger(ByVal eventName As String, ByVal sender As Object, ByVal args As CustomDrawCellEventArgsBase)
			If customDrawCellPosition.IsValid AndAlso (args.Cell.RowIndex = customDrawCellPosition.Row) AndAlso (args.Cell.ColumnIndex = customDrawCellPosition.Column) Then
				EventLogger(eventName, sender, args)
			End If
		End Sub
		Public Sub CustomDrawHeaderEventLogger(ByVal eventName As String, ByVal sender As Object, ByVal args As CustomDrawHeaderEventArgsBase)
			Dim headerText As String = args.Text
			If headerText = customDrawColumnText OrElse headerText = customDrawRowText Then
				EventLogger(eventName, sender, args)
			End If
		End Sub

		Public Sub EventLogger(ByVal eventName As String, ByVal sender As Object, ByVal args As EventArgs)
			Dim argsType As Type = args.GetType()
			Dim name As String = eventName
			Dim argsTypeName As String = argsType.Name
			Dim propInfoArray() As PropertyInfo = argsType.GetProperties()
			Dim rootListNode As TreeListNode = Nothing
			Dim firstLevelNode As TreeListNode = loggerControl.AppendNode(New Object() { name, argsTypeName }, rootListNode)
			For Each item As PropertyInfo In propInfoArray
				Dim value As String = GetEventParameter(item, item.GetValue(args, Nothing))
				Dim secondLevelNode As TreeListNode = loggerControl.AppendNode(New Object() { "", "", value }, firstLevelNode)
			Next item
			If appendExpandedBox.Checked AndAlso (propInfoArray.Length > 0) Then
				firstLevelNode.ExpandAll()
			End If
			loggerControl.MakeNodeVisible(firstLevelNode)
		End Sub

		Private Sub eventsCheckedListBox_ItemCheck(ByVal sender As Object, ByVal e As XtraEditors.Controls.ItemCheckEventArgs) Handles eventsCheckedListBox.ItemCheck
			Dim itemIndex As Integer = e.Index
			Dim state As Boolean = e.State = CheckState.Checked
			Dim hookIndex As Integer = Convert.ToInt32(eventsCheckedListBox.Items(itemIndex).Value)
			If state Then
				hooks(hookIndex).HookEvent(spreadsheetControl1)
			Else
				hooks(hookIndex).UnhookEvent(spreadsheetControl1)
			End If
		End Sub

		Private Sub checkAllEdit_CheckStateChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkAllEdit.CheckStateChanged
			Dim state As CheckState = checkAllEdit.CheckState
			Select Case state
				Case CheckState.Checked
					eventsCheckedListBox.CheckAll()
				Case CheckState.Unchecked
					eventsCheckedListBox.UnCheckAll()
			End Select
		End Sub

		Private Sub expandButtonItem_ItemClick(ByVal sender As Object, ByVal e As XtraBars.ItemClickEventArgs) Handles expandButtonItem.ItemClick
			loggerControl.ExpandAll()
		End Sub

		Private Sub collapseButtonItem_ItemClick(ByVal sender As Object, ByVal e As XtraBars.ItemClickEventArgs) Handles collapseButtonItem.ItemClick
			loggerControl.CollapseAll()
		End Sub

		Private Sub clearButtonItem_ItemClick(ByVal sender As Object, ByVal e As XtraBars.ItemClickEventArgs) Handles clearButtonItem.ItemClick
			loggerControl.ClearNodes()
		End Sub

		Private Sub customDrawCellBarEdit_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles customDrawCellBarEdit.EditValueChanged
			Dim newValue As String = customDrawCellBarEdit.EditValue.ToString()
			If String.IsNullOrEmpty(newValue) Then
				customDrawCellPosition = CellPosition.InvalidValue
			Else
				Dim newPosition As CellPosition = CellPosition.TryCreate(newValue)
				If newPosition.IsValid Then
					customDrawCellPosition = newPosition
				End If
			End If
		End Sub
	End Class

	#Region "SpreadsheetEventHooker"
	Public Class SpreadsheetEventHooker
		#Region "Fields"
		Private eventName As String
		Private owner As SpreadsheetEventViewerModule
		Private handler As System.Delegate
		#End Region

		Public Sub New(ByVal eventName As String, ByVal owner As SpreadsheetEventViewerModule)
			Me.eventName = eventName
			Me.owner = owner
		End Sub

		#Region "Properties"
		Public ReadOnly Property Name() As String
			Get
				Return eventName
			End Get
		End Property
		Protected Overridable ReadOnly Property MethodName() As String
			Get
				Return "EventLogger"
			End Get
		End Property
		#End Region

		#Region "CreateEventProxy"
		Private Function CreateEventProxy(ByVal eInfo As EventInfo) As System.Delegate
			Dim eventHandlerType As Type = eInfo.EventHandlerType
			Dim mInfo As MethodInfo = eventHandlerType.GetMethod("Invoke")
			Dim loggerMethodInfo As MethodInfo = GetType(SpreadsheetEventViewerModule).GetMethod(MethodName, BindingFlags.NonPublic Or BindingFlags.Public Or BindingFlags.Instance Or BindingFlags.Static)
			Dim pInfo() As ParameterInfo = mInfo.GetParameters()
			Dim eventSender As ParameterExpression = Expression.Parameter(GetType(Object), "sender")
			Dim eventArgs As ParameterExpression = Expression.Parameter(pInfo(1).ParameterType, "args")
			Return Expression.Lambda(eventHandlerType, Expression.Call(Expression.Constant(owner), loggerMethodInfo, Expression.Constant(eventName), eventSender, eventArgs), eventSender, eventArgs).Compile()
		End Function
		#End Region

		Public Function HookEvent(ByVal control As SpreadsheetControl) As Boolean
			Dim controlType As Type = GetType(SpreadsheetControl)
			Dim eInfo As EventInfo = controlType.GetEvent(eventName)

			If handler Is Nothing Then
				handler = CreateEventProxy(eInfo)
			End If

			Try
				eInfo.AddEventHandler(control, handler)
			Catch e As ArgumentException
				MessageBox.Show(e.Message, "Can't hook event", MessageBoxButtons.OK, MessageBoxIcon.Error)
				Return False
			End Try
			Return True
		End Function

		Public Sub UnhookEvent(ByVal control As SpreadsheetControl)
			If handler IsNot Nothing Then
				Dim controlType As Type = GetType(SpreadsheetControl)
				Dim eInfo As EventInfo = controlType.GetEvent(eventName)
				eInfo.RemoveEventHandler(control, handler)
			End If
		End Sub
	End Class

	Public Class SpreadsheetCustomDrawCellEventHooker
		Inherits SpreadsheetEventHooker
		Public Sub New(ByVal eventName As String, ByVal owner As SpreadsheetEventViewerModule)
			MyBase.New(eventName, owner)
		End Sub
		Protected Overrides ReadOnly Property MethodName() As String
			Get
				Return "CustomDrawCellEventLogger"
			End Get
		End Property
	End Class
	Public Class SpreadsheetCustomDrawHeaderEventHooker
		Inherits SpreadsheetEventHooker
		Public Sub New(ByVal eventName As String, ByVal owner As SpreadsheetEventViewerModule)
			MyBase.New(eventName, owner)
		End Sub
		Protected Overrides ReadOnly Property MethodName() As String
			Get
				Return "CustomDrawHeaderEventLogger"
			End Get
		End Property
	End Class
	#End Region
End Namespace
