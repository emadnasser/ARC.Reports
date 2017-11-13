Imports System.ComponentModel
Imports System.Text
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.DXperience.Demos
Imports DevExpress.XtraTreeList.ViewInfo

Namespace DevExpress.XtraTreeList.Demos
    Partial Public Class LookUp
        Inherits TutorialControl

        Private lookUpProperties As RepositoryItemTreeListLookUpEdit
        Private treeList As TreeList
        Public Sub New()
            InitializeComponent()
            TutorialInfo.WhatsThisCodeFile = "VB\TreeListMainDemo\Modules\LookUp.vb"
            TutorialInfo.WhatsThisXMLFile = "LookUp.xml"
            InitProjectsData()
            InitSpaceObjectsData()
            InitProperties()
            CreateTimer()
            '<treeList1>
            '            
            '~Note: the following properties are set at design time and listed here only for demonstration purposes.
            '~Assign a TreeListLookUpEdit control as an in-place editor to the Owner column:
            '~colOwner.ColumnEdit = repositoryItemTreeListLookUpEdit1
            '~Set key fields to create a data hierarchy:
            '~repositoryItemTreeListLookUpEdit1.TreeList.KeyFieldName = "ID"
            '~repositoryItemTreeListLookUpEdit1.TreeList.ParentFieldName = "ParentID"
            '            
            '</treeList1>
        End Sub
        Protected Overrides Sub OnTick()
            If DemosInfo.CurrentModule Is Me Then
                treeListLookUpEdit1.MenuManager = RibbonMenuManager.Manager
                treeListLookUpEdit1.ShowPopup()
            End If
            MyBase.OnTick()
        End Sub
        Private updateValues As Boolean = False
        Private Sub InitProperties()
            Me.lookUpProperties = treeListLookUpEdit1.Properties
            Me.treeList = treeListLookUpEdit1TreeList
            updateValues = True
            lbDisplay.Text = lookUpProperties.DisplayMember
            lbValue.Text = lookUpProperties.ValueMember
            icbTextEditStyle.EditValue = lookUpProperties.TextEditStyle
            For Each style As TextEditStyles In System.Enum.GetValues(GetType(TextEditStyles))
                icbTextEditStyle.Properties.Items.Add(New ImageComboBoxItem(EnumTitlesKeeper(Of TextEditStyles).GetTitle(style), style, -1))
            Next style
            ceAutoComplete.Checked = lookUpProperties.AutoComplete
            ceImmediatePopup.Checked = lookUpProperties.ImmediatePopup
            cePopupSizeable.Checked = lookUpProperties.PopupSizeable
            ceShowPopupFooter.Checked = lookUpProperties.ShowFooter
            ceShowAutoFilterRow.Checked = treeList.OptionsView.ShowAutoFilterRow
            ceShowColumnHeaders.Checked = treeList.OptionsView.ShowColumns
            ceShowIndicator.Checked = treeList.OptionsView.ShowIndicator
            ceEnableAppearanceEvenRow.Checked = treeList.OptionsView.EnableAppearanceEvenRow
            ceEnableAppearanceOddRow.Checked = treeList.OptionsView.EnableAppearanceOddRow
            cePopupSizeable.Enabled = lookUpProperties.ShowFooter
            updateValues = False
        End Sub

        '<treeList1>
        Private Sub InitProjectsData()
            Dim DBFileName As String = DevExpress.Utils.FilesHelper.FindingFileName(Application.StartupPath, "Data\EmployeesGroups.xml")
            If DBFileName <> "" Then
                Dim dataSet As New DataSet()
                dataSet.ReadXml(DBFileName)
                dataSet.Tables(0).Columns.Add("FullName", GetType(String), "FirstName + ' ' + LastName")

                repositoryItemTreeListLookUpEdit1.DataSource = dataSet.Tables(0).DefaultView
                repositoryItemTreeListLookUpEdit1.DisplayMember = "FullName"
                repositoryItemTreeListLookUpEdit1.ValueMember = "Id"

                treeList1.ExpandAll()
            End If
        End Sub
        '</treeList1>

        '<treeListLookUpEdit1>
        Dim spaceObjectsTable As DataTable
        Private Sub InitSpaceObjectsData()
            Dim DBFileName As String = DevExpress.Utils.FilesHelper.FindingFileName(Application.StartupPath, "Data\SpaceObjects.xml")
            If DBFileName <> "" Then
                Dim dataSet As New DataSet()
                dataSet.ReadXml(DBFileName)
                spaceObjectsTable = dataSet.Tables(0)
                spaceObjectsTable.PrimaryKey = New DataColumn() {spaceObjectsTable.Columns("ObjectId")}

                treeListLookUpEdit1.Properties.TreeList.KeyFieldName = "ObjectId"
                treeListLookUpEdit1.Properties.TreeList.ParentFieldName = "ParentId"


                treeListLookUpEdit1.Properties.DataSource = spaceObjectsTable
                treeListLookUpEdit1.Properties.DisplayMember = "Name"
                treeListLookUpEdit1.Properties.ValueMember = "ObjectId"


                dataNavigator1.DataSource = spaceObjectsTable
                treeListLookUpEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", spaceObjectsTable, "ObjectId", False, DataSourceUpdateMode.Never))
            End If
        End Sub
        Private Sub treeListLookUpEdit1_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles treeListLookUpEdit1.EditValueChanged
            Dim editvalue As Object = treeListLookUpEdit1.EditValue
            If ((editvalue Is Nothing) Or (editvalue.GetType() IsNot GetType(Integer))) Then
                Return
            End If
            Dim position As Integer = spaceObjectsTable.Rows.IndexOf(spaceObjectsTable.Rows.Find(CType(treeListLookUpEdit1.EditValue, Integer)))
            If (position > -1) Then
                dataNavigator1.Position = position
            End If
        End Sub
        '</treeListLookUpEdit1>

        Private currentGroupName As String
        Private Sub treeList1_GetStateImage(ByVal sender As Object, ByVal e As GetStateImageEventArgs) Handles treeListLookUpEdit1TreeList.GetStateImage, repositoryItemTreeListLookUpEdit1TreeList.GetStateImage
            Dim groupNames() As String = {"Administration", "Inventory", "Manufacturing", "Quality", "Research", "Sales"}
            currentGroupName = CStr(e.Node.GetValue("GroupName"))
            e.NodeImageIndex = Array.FindIndex(groupNames, New Predicate(Of String)(AddressOf IsCurrentGroupName))
        End Sub
        Private Function IsCurrentGroupName(ByVal groupName As String) As Boolean
            Return currentGroupName.Contains(groupName)
        End Function

        '<icbTextEditStyle>
        Private Sub icbTextEditStyle_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles icbTextEditStyle.SelectedIndexChanged
            If updateValues Then
                Return
            End If
            lookUpProperties.TextEditStyle = CType(icbTextEditStyle.EditValue, TextEditStyles)
        End Sub
        '</icbTextEditStyle>
        '<ceAutoComplete>
        Private Sub ceAutoComplete_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles ceAutoComplete.CheckedChanged
            If updateValues Then
                Return
            End If
            lookUpProperties.AutoComplete = ceAutoComplete.Checked
        End Sub
        '</ceAutoComplete>
        '<ceImmediatePopup>
        Private Sub ceImmediatePopup_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ceImmediatePopup.CheckedChanged
            If updateValues Then
                Return
            End If
            lookUpProperties.ImmediatePopup = ceImmediatePopup.Checked
        End Sub
        '</ceImmediatePopup>
        '<cePopupSizeable>
        Private Sub cePopupSizeable_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cePopupSizeable.CheckedChanged
            If updateValues Then
                Return
            End If
            lookUpProperties.PopupSizeable = cePopupSizeable.Checked
        End Sub
        '</cePopupSizeable>
        '<ceShowPopupFooter>
        Private Sub ceShowPopupFooter_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ceShowPopupFooter.CheckedChanged
            If updateValues Then
                Return
            End If
            lookUpProperties.ShowFooter = ceShowPopupFooter.Checked
            cePopupSizeable.Enabled = lookUpProperties.ShowFooter
        End Sub
        '</ceShowPopupFooter>
        '<ceShowAutoFilterRow>
        Private Sub ceShowAutoFilterRow_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ceShowAutoFilterRow.CheckedChanged
            If updateValues Then
                Return
            End If
            treeList.OptionsView.ShowAutoFilterRow = ceShowAutoFilterRow.Checked
        End Sub
        '</ceShowAutoFilterRow>
        '<ceShowColumnHeaders>
        Private Sub ceShowColumnHeaders_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ceShowColumnHeaders.CheckedChanged
            If updateValues Then
                Return
            End If
            treeList.OptionsView.ShowColumns = ceShowColumnHeaders.Checked
        End Sub
        '</ceShowColumnHeaders>
        '<ceShowIndicator>
        Private Sub ceShowIndicator_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ceShowIndicator.CheckedChanged
            If updateValues Then
                Return
            End If
            treeList.OptionsView.ShowIndicator = ceShowIndicator.Checked
        End Sub
        '</ceShowIndicator>
        '<ceEnableAppearanceEvenRow>
        Private Sub ceEnableAppearanceEvenRow_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ceEnableAppearanceEvenRow.CheckedChanged
            If updateValues Then
                Return
            End If
            treeList.OptionsView.EnableAppearanceEvenRow = ceEnableAppearanceEvenRow.Checked
        End Sub
        '</ceEnableAppearanceEvenRow>
        '<ceEnableAppearanceOddRow>
        Private Sub ceEnableAppearanceOddRow_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ceEnableAppearanceOddRow.CheckedChanged
            If updateValues Then
                Return
            End If
            treeList.OptionsView.EnableAppearanceOddRow = ceEnableAppearanceOddRow.Checked
        End Sub
        '</ceEnableAppearanceOddRow>

        Private Sub toolTipController1_GetActiveObjectInfo(ByVal sender As Object, ByVal e As DevExpress.Utils.ToolTipControllerGetActiveObjectInfoEventArgs) Handles toolTipController1.GetActiveObjectInfo
            If TypeOf e.SelectedControl Is TreeList Then
                Dim tree As TreeList = CType(e.SelectedControl, TreeList)
                Dim hit As TreeListHitInfo = tree.CalcHitInfo(e.ControlMousePosition)
                If hit.HitInfoType = HitInfoType.Cell Then
                    Dim tooltip As String
                    If hit.Column Is tree.Columns("Name") OrElse hit.Column Is tree.Columns("TypeOfObject") Then
                        tooltip = String.Format("{0}", hit.Column.Caption)
                    ElseIf hit.Column Is tree.Columns("ImageData") Then
                        tooltip = "Image: Courtesy NASA/JPL-Caltec"
                    Else
                        tooltip = String.Format("{0} by Earth", hit.Column.Caption)
                    End If
                    e.Info = New DevExpress.Utils.ToolTipControlInfo(New TreeListCellToolTipInfo(hit.Node, hit.Column, Nothing), tooltip)
                End If
            End If
        End Sub
    End Class
End Namespace
