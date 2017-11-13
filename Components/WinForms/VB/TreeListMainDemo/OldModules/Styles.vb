Imports System.Collections
Imports System.ComponentModel
Imports DevExpress.XtraTreeList
Imports DevExpress.Utils
Imports DevExpress.XtraBars
Imports DevExpress.DXperience.Demos
Imports DevExpress.XtraEditors

Namespace DevExpress.XtraTreeList.Demos
	''' <summary>
	''' Summary description for TreeListStyles.
	''' </summary>
	Partial Public Class TreeListStyles
		Inherits TutorialControl

		Public Sub New()
			InitializeComponent()
			InitData()
			InitEditors()
			InitStyles()
		End Sub

		Private dataView As DataView
		Protected Overrides ReadOnly Property BarName() As String
			Get
				Return "Styles"
			End Get
		End Property
		Protected Overrides ReadOnly Property Manager() As BarManager
			Get
				Return barManager1
			End Get
		End Property
		Protected Overrides Sub InitBarInfo()
			Me.BarInfos.Add(New BarInfo("AutoWidth", New ItemClickEventHandler(AddressOf AutoWidthClick), imageList2.Images(0), True, False, False))
			Me.BarInfos.Add(New BarInfo("Show Indent As RowStyle", New ItemClickEventHandler(AddressOf ShowIndentAsRowStyleClick), imageList2.Images(1), True, False, False))
			Me.BarInfos.Add(New BarInfo("Show Buttons", New ItemClickEventHandler(AddressOf ShowButtonsClick), imageList2.Images(2), True, False, False))
			Me.BarInfos.Add(New BarInfo("Show Root", New ItemClickEventHandler(AddressOf ShowRootClick), imageList2.Images(3), True, False, False))
			Me.BarInfos.Add(New BarInfo("Show Focused Frame", New ItemClickEventHandler(AddressOf ShowFocusedFrameClick), imageList2.Images(4), True, False, False))
			Me.BarInfos.Add(New BarInfo("Show Indicator", New ItemClickEventHandler(AddressOf ShowIndicatorClick), imageList2.Images(5), True, False, False))
			Me.BarInfos.Add(New BarInfo("Show Columns", New ItemClickEventHandler(AddressOf ShowColumnsClick), imageList2.Images(6), True, False, False))
			Me.BarInfos.Add(New BarInfo("Show VertLines", New ItemClickEventHandler(AddressOf ShowVertLinesClick), imageList2.Images(7), True, False, False))
			Me.BarInfos.Add(New BarInfo("Show HorzLines", New ItemClickEventHandler(AddressOf ShowHorzLinesClick), imageList2.Images(8), True, False, False))
			Me.BarInfos.Add(New BarInfo("Show Row Footer Summary", New ItemClickEventHandler(AddressOf ShowRowFooterSummaryClick), imageList2.Images(13), True, False, False))
			Me.BarInfos.Add(New BarInfo("Show Summary Footer", New ItemClickEventHandler(AddressOf ShowSummaryFooterClick), imageList2.Images(14), True, False, False))
			Me.BarInfos.Add(New BarInfo("Show Button Mode", Nothing, imageList2.Images(10), False, False, True, New BarInfo() {New BarInfo("Show Always", New ItemClickEventHandler(AddressOf ShowAlwaysClick), Nothing, True, treeList1.ShowButtonMode = ShowButtonModeEnum.ShowAlways, False), New BarInfo("Show For Focused Cell", New ItemClickEventHandler(AddressOf ShowForFocusedCellClick), Nothing, True, treeList1.ShowButtonMode = ShowButtonModeEnum.ShowForFocusedCell, False), New BarInfo("Show For Focused Row", New ItemClickEventHandler(AddressOf ShowForFocusedRowClick), Nothing, True, treeList1.ShowButtonMode = ShowButtonModeEnum.ShowForFocusedRow, False), New BarInfo("Show Only In Editor", New ItemClickEventHandler(AddressOf ShowOnlyInEditorClick), Nothing, True, treeList1.ShowButtonMode = ShowButtonModeEnum.ShowOnlyInEditor, False)}, 1))
			Me.BarInfos.Add(New BarInfo("TreeLine Style", Nothing, imageList2.Images(11), False, False, False, New BarInfo() {New BarInfo("Dark", New ItemClickEventHandler(AddressOf DarkClick), Nothing, True, treeList1.TreeLineStyle = LineStyle.Dark, False), New BarInfo("Large", New ItemClickEventHandler(AddressOf LargeClick), Nothing, True, treeList1.TreeLineStyle = LineStyle.Large, False), New BarInfo("Light", New ItemClickEventHandler(AddressOf LightClick), Nothing, True, treeList1.TreeLineStyle = LineStyle.Light, False), New BarInfo("Percent50", New ItemClickEventHandler(AddressOf Percent50Click), Nothing, True, treeList1.TreeLineStyle = LineStyle.Percent50, False), New BarInfo("Solid", New ItemClickEventHandler(AddressOf SolidClick), Nothing, True, treeList1.TreeLineStyle = LineStyle.Solid, False), New BarInfo("Wide", New ItemClickEventHandler(AddressOf WideClick), Nothing, True, treeList1.TreeLineStyle = LineStyle.Wide, False), New BarInfo("None", New ItemClickEventHandler(AddressOf NoneClick), Nothing, True, treeList1.TreeLineStyle = LineStyle.None, False)}, 2))
			Me.BarInfos.Add(New BarInfo("Show Customization Form", New ItemClickEventHandler(AddressOf ShowCustomizationFormClick), imageList2.Images(15), True, False, True))
			Me.BarInfos.Add(New BarInfo("Drag Nodes", New ItemClickEventHandler(AddressOf DragNodesClick), imageList2.Images(12), True, False, False))
			Me.BarInfos.Add(New BarInfo("Print Preview", New ItemClickEventHandler(AddressOf PrintPreviewClick), imageList2.Images(16), False, False, True))
			Me.BarInfos.Add(New BarInfo("Print Designer", New ItemClickEventHandler(AddressOf PrintDesignerClick), imageList2.Images(17), False, False, False))

			InitOptions()
		End Sub

		Private Sub AutoWidthClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
			treeList1.OptionsView.AutoWidth = GetBarItemPushed(0)
		End Sub
		Private Sub ShowIndentAsRowStyleClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
			treeList1.OptionsView.ShowIndentAsRowStyle = GetBarItemPushed(1)
		End Sub
		Private Sub ShowButtonsClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
			treeList1.OptionsView.ShowButtons = GetBarItemPushed(2)
		End Sub
		Private Sub ShowRootClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
			treeList1.OptionsView.ShowRoot = GetBarItemPushed(3)
		End Sub
        Private Sub ShowFocusedFrameClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            If GetBarItemPushed(4) Then
                treeList1.OptionsView.FocusRectStyle = DrawFocusRectStyle.CellFocus
            Else
                treeList1.OptionsView.FocusRectStyle = DrawFocusRectStyle.None
            End If
        End Sub
		Private Sub ShowIndicatorClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
			treeList1.OptionsView.ShowIndicator = GetBarItemPushed(5)
		End Sub
		Private Sub ShowColumnsClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
			treeList1.OptionsView.ShowColumns = GetBarItemPushed(6)
		End Sub
		Private Sub ShowVertLinesClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
			treeList1.OptionsView.ShowVertLines = GetBarItemPushed(7)
		End Sub
		Private Sub ShowHorzLinesClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
			treeList1.OptionsView.ShowHorzLines = GetBarItemPushed(8)
		End Sub
		Private Sub ShowRowFooterSummaryClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
			treeList1.OptionsView.ShowRowFooterSummary = GetBarItemPushed(9)
		End Sub
		Private Sub ShowSummaryFooterClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
			treeList1.OptionsView.ShowSummaryFooter = GetBarItemPushed(10)
		End Sub
		Private Sub ShowCustomizationFormClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
			If GetBarItemPushed(13) Then
				treeList1.ColumnsCustomization()
			Else
				treeList1.DestroyCustomization()
			End If
		End Sub
        Private Sub DragNodesClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            If GetBarItemPushed(14) Then
                treeList1.OptionsDragAndDrop.DragNodesMode = DragNodesMode.Single
            Else
                treeList1.OptionsDragAndDrop.DragNodesMode = DragNodesMode.None
            End If
        End Sub

		Private Sub PrintPreviewClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
			Dim currentCursor As Cursor = Cursor.Current
			Cursor.Current = Cursors.WaitCursor
			treeList1.ShowPrintPreview()
			Cursor.Current = currentCursor
		End Sub

		Private Sub PrintDesignerClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
			Dim currentCursor As Cursor = Cursor.Current
			Cursor.Current = Cursors.WaitCursor
			Dim frm As New DevExpress.XtraEditors.XtraForm()
			frm.Text = "Print Designer"
			Dim print As New DevExpress.XtraTreeList.Frames.TreeListPrinting()
			print.InitFrame(treeList1, "PrintingReport management", Nothing)
			print.Dock = DockStyle.Fill
			frm.Controls.Add(print)
			frm.Size = print.UserControlSize
			frm.StartPosition = FormStartPosition.CenterScreen
			frm.ShowDialog()
			Cursor.Current = currentCursor
		End Sub

		Private Sub ShowAlwaysClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
			treeList1.ShowButtonMode = ShowButtonModeEnum.ShowAlways
		End Sub

		Private Sub ShowForFocusedCellClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
			treeList1.ShowButtonMode = ShowButtonModeEnum.ShowForFocusedCell
		End Sub

		Private Sub ShowForFocusedRowClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
			treeList1.ShowButtonMode = ShowButtonModeEnum.ShowForFocusedRow
		End Sub

		Private Sub ShowOnlyInEditorClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
			treeList1.ShowButtonMode = ShowButtonModeEnum.ShowOnlyInEditor
		End Sub

		Private Sub DarkClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
			treeList1.TreeLineStyle = LineStyle.Dark
		End Sub

		Private Sub LargeClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
			treeList1.TreeLineStyle = LineStyle.Large
		End Sub

		Private Sub LightClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
			treeList1.TreeLineStyle = LineStyle.Light
		End Sub

		Private Sub Percent50Click(ByVal sender As Object, ByVal e As ItemClickEventArgs)
			treeList1.TreeLineStyle = LineStyle.Percent50
		End Sub

		Private Sub SolidClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
			treeList1.TreeLineStyle = LineStyle.Solid
		End Sub

		Private Sub WideClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
			treeList1.TreeLineStyle = LineStyle.Wide
		End Sub

		Private Sub NoneClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
			treeList1.TreeLineStyle = LineStyle.None
		End Sub
		Private Sub InitOptions()
			SetBarItemChecked(0, treeList1.OptionsView.AutoWidth)
			SetBarItemChecked(1, treeList1.OptionsView.ShowIndentAsRowStyle)
			SetBarItemChecked(2, treeList1.OptionsView.ShowButtons)
			SetBarItemChecked(3, treeList1.OptionsView.ShowRoot)
            SetBarItemChecked(4, treeList1.OptionsView.FocusRectStyle <> DrawFocusRectStyle.None)
			SetBarItemChecked(5, treeList1.OptionsView.ShowIndicator)
			SetBarItemChecked(6, treeList1.OptionsView.ShowColumns)
			SetBarItemChecked(7, treeList1.OptionsView.ShowVertLines)
			SetBarItemChecked(8, treeList1.OptionsView.ShowHorzLines)
			SetBarItemChecked(9, treeList1.OptionsView.ShowRowFooterSummary)
			SetBarItemChecked(10, treeList1.OptionsView.ShowSummaryFooter)
            SetBarItemChecked(14, treeList1.OptionsDragAndDrop.DragNodesMode <> DragNodesMode.None)
		End Sub

		Private Sub InitData()
			Dim DBFileName As String = DevExpress.Utils.FilesHelper.FindingFileName(Application.StartupPath, "Data\Departments.xml")
			If DBFileName <> "" Then
				Dim dataSet As New DataSet()
				dataSet.ReadXml(DBFileName)
				dataView = dataSet.Tables(0).DefaultView
				treeList1.DataSource = dataView
				treeList1.PopulateColumns()
				treeList1.ExpandAll()
				treeList1.BestFitColumns()
			End If
		End Sub

		Private Sub InitEditors()
			Dim cb As New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
			treeList1.RepositoryItems.Add(cb)
			Dim se As New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
			treeList1.RepositoryItems.Add(se)

			Dim s As String, oldLocation As String = ""
			Dim dv As New DataView(dataView.Table)
			dv.Sort = "[Location] ASC"
			For i As Integer = 0 To dv.Count - 1
				s = TryCast(dv(i).Row.ItemArray.GetValue(5), String)
				If s <> oldLocation Then
					cb.Items.Add(s)
				End If
				oldLocation = s
			Next i
			cb.DropDownRows = 10

			Dim col As DevExpress.XtraTreeList.Columns.TreeListColumn

			treeList1.Columns("Location").ColumnEdit = cb
			col = treeList1.Columns("Budget")
			col.ColumnEdit = se
			col.Format.FormatString = "c"
			col.SummaryFooter = SummaryItemType.Sum
			col.RowFooterSummary = col.SummaryFooter
			col.SummaryFooterStrFormat = "Sum={0:c}"
			col.RowFooterSummaryStrFormat = col.SummaryFooterStrFormat
			col.AllNodesSummary = True
			col = treeList1.Columns("Check")
			col.RowFooterSummary = SummaryItemType.Sum
			col.RowFooterSummaryStrFormat = "Checked: {0}"
		End Sub

		Private Sub TreeListStyles_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
			chbAlphaBlending.Checked = False
		End Sub

		Private Sub InitStyles()
			xapp = New DevExpress.XtraTreeList.Design.XAppearances(System.Environment.GetFolderPath(System.Environment.SpecialFolder.System) & "\DevExpress.XtraTreeList.Appearances.xml", ceNewStyles.Checked)
			lsStyles.Items.AddRange(xapp.FormatNames)
			lsStyles.SelectedIndex = If(lsStyles.Items.Count > 1, 1, 0)
			InitAppearanceList(treeList1)
		End Sub

		Private Sub InitAppearanceList(ByVal tl As TreeList)
			lbcAppearances.Items.Clear()
			Dim collection As PropertyDescriptorCollection = TypeDescriptor.GetProperties(tl.Appearance)
			For i As Integer = 0 To collection.Count - 1
				If collection(i).PropertyType Is GetType(AppearanceObject) Then
					lbcAppearances.Items.Add(collection(i).Name)
				End If
			Next i
			lbcAppearances.SelectedIndex = 0
		End Sub

		Private Sub lsStyles_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lsStyles.SelectedIndexChanged
			If lsStyles.SelectedItem IsNot Nothing Then
				xapp.LoadScheme(lsStyles.SelectedItem.ToString(), treeList1)
			End If
			treeList1.SetDefaultRowHeight()
			If chbAlphaBlending.Checked Then
				xtraTreeListBlending1.RefreshStyles()
			End If
		End Sub

		Private Sub ceNewStyles_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ceNewStyles.CheckedChanged
			If xapp IsNot Nothing Then
				xapp.ShowNewStylesOnly = ceNewStyles.Checked
			End If
			Dim index As Integer = lsStyles.SelectedIndex
			lsStyles.Items.Clear()
			lsStyles.Items.AddRange(xapp.FormatNames)
			lsStyles.SelectedIndex = index
		End Sub

		Private Sub lbcAppearances_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lbcAppearances.SelectedIndexChanged
			propertyGrid1.SelectedObjects = SelectedObjects
		End Sub

		Private Function GetAppearanceObjectByName(ByVal tl As TreeList, ByVal name As String) As AppearanceObject
			If tl.Appearance Is Nothing Then
				Return Nothing
			Else
				Return tl.Appearance.GetAppearance(name)
			End If
		End Function
		Private ReadOnly Property SelectedObjects() As Object()
			Get
				If lbcAppearances.SelectedItem Is Nothing Then
					Return Nothing
				End If
				Dim ret As New ArrayList()
				For i As Integer = 0 To lbcAppearances.SelectedIndices.Count - 1
					Dim obj As Object = GetAppearanceObjectByName(treeList1, lbcAppearances.GetItem(lbcAppearances.SelectedIndices(i)).ToString())
					ret.Add(obj)
				Next i
				Return ret.ToArray()
			End Get
		End Property

		Private Sub treeList1_GetSelectImage(ByVal sender As Object, ByVal e As DevExpress.XtraTreeList.GetSelectImageEventArgs) Handles treeList1.GetSelectImage
			If e.FocusedNode Then
				e.NodeImageIndex += 7
			End If
		End Sub

		Private Sub chbAlphaBlending_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chbAlphaBlending.CheckedChanged
			Dim chb As DevExpress.XtraEditors.CheckEdit = TryCast(sender, DevExpress.XtraEditors.CheckEdit)
			xtraTreeListBlending1.Enabled = chb.Checked
			btnAlphaBlending.Enabled = chb.Checked
		End Sub

		Private Sub btnAlphaBlending_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAlphaBlending.Click
			xtraTreeListBlending1.ShowDialog()
		End Sub

		Private Sub treeList1_ShowCustomizationForm(ByVal sender As Object, ByVal e As System.EventArgs) Handles treeList1.ShowCustomizationForm
			SetBarItemChecked(13, True)
		End Sub

		Private Sub treeList1_HideCustomizationForm(ByVal sender As Object, ByVal e As System.EventArgs) Handles treeList1.HideCustomizationForm
			SetBarItemChecked(13, False)
		End Sub
	End Class
End Namespace
