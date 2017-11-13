Imports System.Collections
Imports System.ComponentModel
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors

Namespace DevExpress.XtraGrid.Demos
	Partial Public Class InplaceEditors
		Inherits TutorialControl

		<FlagsAttribute> _
		Private Enum Colors
			None = 0
			Red = 1
			Green = 2
			Blue = 4
			Yellow = 8
			Black = 16
		End Enum
		Public Overrides ReadOnly Property ExportView() As DevExpress.XtraGrid.Views.Base.BaseView
			Get
				Return gridView1
			End Get
		End Property

		'<gridControl1>
		Private gridEditors As GridEditorCollection
		'</gridControl1>

		Public Sub New()
			' This call is required by the Windows Form Designer.
			InitializeComponent()
            gridView1.OptionsMenu.ShowAutoFilterRowItem = False
            TutorialInfo.WhatsThisCodeFile = "VB\GridMainDemo\Modules\InplaceEditors.vb"
            TutorialInfo.WhatsThisXMLFile = "InplaceEditors.xml"
			InitLookUpDataTable()
			repositoryItemCheckedComboBoxEdit1.SetFlags(GetType(Colors))
			'<gridControl1>
			Me.gridEditors = New GridEditorCollection()
			InitInplaceEditors()
			Me.gridControl1.DataSource = gridEditors
			'</gridControl1>
			gridPopup.ForceInitialize()
			xtraPropertyGrid1.PropertyGrid.AutoGenerateRows = True
		End Sub


		Private Sub AddRecordToLookUpDataTable(ByVal fName As String, ByVal department As String)
			Dim row_Renamed As DataRow = Me.dataTableLookUp.NewRow()
			row_Renamed("clnId") = Me.dataTableLookUp.Rows.Count + 1
			row_Renamed("clnName") = fName
			row_Renamed("clnDepartment") = department
			Me.dataTableLookUp.Rows.Add(row_Renamed)
		End Sub
		Private Sub InitLookUpDataTable()
			AddRecordToLookUpDataTable("Paul Bailey", My.Resources.Management)
			AddRecordToLookUpDataTable("Brad Barnes", My.Resources.QA)
			AddRecordToLookUpDataTable("Jerry Campbell", My.Resources.RD)
			AddRecordToLookUpDataTable("Carl Lucas", My.Resources.Documentation)
			AddRecordToLookUpDataTable("Peter Dolan", My.Resources.Marketing)
			AddRecordToLookUpDataTable("Ryan Fischer", My.Resources.RD)
			AddRecordToLookUpDataTable("Ricard Fischer", My.Resources.Marketing)
			AddRecordToLookUpDataTable("Tom Hamlett", My.Resources.RD)
			AddRecordToLookUpDataTable("Mark Hamilton", My.Resources.QA)
			AddRecordToLookUpDataTable("Steve Lee", My.Resources.RD)
			AddRecordToLookUpDataTable("Jimmy Lewis", My.Resources.Support)
			AddRecordToLookUpDataTable("Jeffrey McClain", My.Resources.RD)
			AddRecordToLookUpDataTable("Andrew Miller", My.Resources.Documentation)
			AddRecordToLookUpDataTable("Dave Murrel", My.Resources.QA)
			AddRecordToLookUpDataTable("Bert Parkins", My.Resources.RD)
			AddRecordToLookUpDataTable("Mike Roller", My.Resources.RD)
			AddRecordToLookUpDataTable("Ray Shipman", My.Resources.Support)
		End Sub

		'<gridControl1>
		Private Sub InitInplaceEditors()
			Me.gridEditors.Add(Me.repositoryItemTextEdit, My.Resources.TextEdit, My.Resources.TextEditText)
			Me.gridEditors.Add(Me.repositoryItemButtonEdit, My.Resources.ButtonEdit, My.Resources.ClickMe)
			Me.gridEditors.Add(Me.repositoryItemCheckEdit, My.Resources.CheckEdit, False)
			Me.gridEditors.Add(Me.repositoryItemSpinEdit, My.Resources.SpinEdit, 20)
			Me.gridEditors.Add(Me.repositoryItemDateEdit, My.Resources.DateEdit, Date.Now)
			Me.gridEditors.Add(Me.repositoryItemTimeEdit, My.Resources.TimeEdit, Date.Now)
			Me.gridEditors.Add(Me.repositoryItemLookUpEdit, My.Resources.LookUpEdit, 3)
			Me.gridEditors.Add(Me.repositoryItemPopupContainerEdit, My.Resources.PopupContainer, 3)
			Me.gridEditors.Add(Me.repositoryItemProgressBar, My.Resources.ProgressBar, 30)
			Me.gridEditors.Add(Me.repositoryItemComboBox, My.Resources.ComboBox, "United States")
			Me.gridEditors.Add(Me.repositoryItemImageComboBox, My.Resources.ImageComboBox, 2)
			Me.gridEditors.Add(Me.repositoryItemMRUEdit, My.Resources.MRUEdit, My.Resources.MRUQuestion)
			Me.gridEditors.Add(Me.repositoryItemPictureEdit, My.Resources.Picture, Me.pictureBox1.Image)
			Me.gridEditors.Add(Me.repositoryItemMemoEdit, My.Resources.MemoEdit, My.Resources.MemoText)
			Me.gridEditors.Add(Me.repositoryItemImageEdit, My.Resources.ImageEdit, Me.pictureBox1.Image)
			Me.gridEditors.Add(Me.repositoryItemMemoExEdit, My.Resources.MemoExEdit, My.Resources.MemoText)
			Me.gridEditors.Add(Me.repositoryItemRadioGroup, My.Resources.RadioGroup, 1)
			Me.gridEditors.Add(Me.repositoryItemHyperLinkEdit, My.Resources.Hyperlink, "http://www.devexpress.com")
			Me.gridEditors.Add(Me.repositoryItemCalcEdit, My.Resources.Calculator, 100.25)
			Me.gridEditors.Add(Me.repositoryItemColorEdit, My.Resources.ColorEdit, System.Drawing.Color.Blue)
			Me.gridEditors.Add(Me.repositoryItemTrackBar1, My.Resources.TrackBar, 4)
			Me.gridEditors.Add(Me.repositoryItemFontEdit1, My.Resources.FontEdit, Me.Font.FontFamily.GetName(0))
			Me.gridEditors.Add(Me.repositoryItemCheckedComboBoxEdit1, My.Resources.CheckedComboBox, Colors.Red Or Colors.Blue Or Colors.Yellow)
		End Sub
		'</gridControl1>

		'<gridControl1>
		Private Sub gridView1_CustomRowCellEdit(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs) Handles gridView1.CustomRowCellEdit
			If e.Column Is Me.gridEditorValue Then
				Dim item As GridEditorItem = TryCast(gridView1.GetRow(e.RowHandle), GridEditorItem)
				If item IsNot Nothing Then
					e.RepositoryItem = item.RepositoryItem
				End If
			End If
		End Sub
		'</gridControl1>

		Private Sub repositoryItemButtonEdit_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles repositoryItemButtonEdit.ButtonClick
			XtraMessageBox.Show(My.Resources.ButtonMessage, Application.ProductName)
		End Sub

		Private Function PopupContainerUserByID(ByVal id As Object) As String
			For Each row_Renamed As DataRow In dataTableLookUp.Rows
				If row_Renamed("clnId").Equals(id) Then
					Return row_Renamed("clnName").ToString()
				End If
			Next row_Renamed
			Return ""
		End Function

		Private Sub PopupContainerFindRowByEditValue()
			If popupContainerControl.OwnerEdit Is Nothing Then
				Return
			End If
			Dim row_Renamed As DataRowView
			For i As Integer = 0 To dataTableLookUp.DefaultView.Count - 1
				row_Renamed = dataTableLookUp.DefaultView(i)
				If row_Renamed.Row("clnId").Equals(popupContainerControl.OwnerEdit.EditValue) Then
					For k As Integer = 0 To gridView1Popup.DataRowCount - 1
						If gridView1Popup.GetRow(k) Is row_Renamed Then
							gridView1Popup.FocusedRowHandle = k
							Return
						End If
					Next k
				End If
			Next i
		End Sub
		Private Sub PopupContainerClosePopup()
			If popupContainerControl.OwnerEdit IsNot Nothing Then
				popupContainerControl.OwnerEdit.ClosePopup()
			End If
		End Sub

		Private Sub repositoryItemPopupContainerEdit_QueryDisplayText(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.QueryDisplayTextEventArgs) Handles repositoryItemPopupContainerEdit.QueryDisplayText
			e.DisplayText = PopupContainerUserByID(e.EditValue)
		End Sub

		Private Sub repositoryItemPopupContainerEdit_QueryResultValue(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.QueryResultValueEventArgs) Handles repositoryItemPopupContainerEdit.QueryResultValue
			If Me.gridView1Popup.FocusedRowHandle >= 0 Then
				e.Value = Me.gridView1Popup.GetDataRow(Me.gridView1Popup.FocusedRowHandle)("clnId")
			End If
		End Sub
		Private Sub repositoryItemPopupContainerEdit_QueryPopUp(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles repositoryItemPopupContainerEdit.QueryPopUp
			PopupContainerFindRowByEditValue()
		End Sub

		Private Sub gridPopup_BindingContextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles gridPopup.BindingContextChanged
			PopupContainerFindRowByEditValue()
		End Sub

		Private Sub gridView1Popup_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles gridView1Popup.KeyDown
			If e.KeyCode = Keys.Enter Then
				PopupContainerClosePopup()
			End If
		End Sub

		Private Sub gridView1Popup_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles gridView1Popup.DoubleClick
			Dim info As DevExpress.XtraGrid.Views.Grid.ViewInfo.GridHitInfo = gridView1Popup.CalcHitInfo(gridPopup.PointToClient(MousePosition))
			If info.InRow Then
				PopupContainerClosePopup()
			End If
		End Sub

		Private Sub gridView1_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles gridView1.FocusedRowChanged
			Dim item As GridEditorItem = TryCast(gridView1.GetRow(e.FocusedRowHandle), GridEditorItem)
            If item Is Nothing Then Return
			xtraPropertyGrid1.PropertyGrid.SelectedObject = item.RepositoryItem
			gcProperties.Text = item.Name & String.Format(" {0}:", My.Resources.Properties)
		End Sub

		Private Sub repositoryItemMRUEdit_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles repositoryItemMRUEdit.ButtonClick
			Dim edit As DevExpress.XtraEditors.MRUEdit = TryCast(sender, DevExpress.XtraEditors.MRUEdit)
			If edit.Properties.Buttons.IndexOf(e.Button) <> edit.Properties.ActionButtonIndex Then
				Dim dlg As New ColorDialog()
				If dlg.ShowDialog() = DialogResult.OK Then
					Dim c As Color = dlg.Color
					Dim colorName As String = If(c.IsNamedColor, c.Name, c.ToString())
					edit.EditValue = colorName
					edit.Properties.Items.Add(edit.Text)
				End If
			End If
		End Sub
	End Class

	'<gridControl1>
	Public Class GridEditorItem
		Private fName As String
		Private fValue As Object
		Private fRepositoryItem As RepositoryItem

		Public Sub New(ByVal fRepositoryItem As RepositoryItem, ByVal fName As String, ByVal fValue As Object)
			Me.fRepositoryItem = fRepositoryItem
			Me.fName = fName
			Me.fValue = fValue
		End Sub
		Public ReadOnly Property Name() As String
			Get
				Return Me.fName
			End Get
		End Property
		Public Property Value() As Object
			Get
				Return Me.fValue
			End Get
			Set(ByVal value As Object)
				Me.fValue = value
			End Set
		End Property
		Public ReadOnly Property RepositoryItem() As RepositoryItem
			Get
				Return Me.fRepositoryItem
			End Get
		End Property
	End Class

	Friend Class GridEditorCollection
		Inherits ArrayList

		Public Sub New()
		End Sub
		Default Public Shadows ReadOnly Property Item(ByVal index As Integer) As GridEditorItem
			Get
				Return TryCast(MyBase.Item(index), GridEditorItem)
			End Get
		End Property
		Public Overloads Sub Add(ByVal fRepositoryItem As RepositoryItem, ByVal fName As String, ByVal fValue As Object)
			MyBase.Add(New GridEditorItem(fRepositoryItem, fName, fValue))
		End Sub
	End Class
	'</gridControl1>

End Namespace
