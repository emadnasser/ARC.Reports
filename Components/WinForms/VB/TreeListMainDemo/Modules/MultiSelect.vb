Imports System.Collections
Imports System.ComponentModel
Imports DevExpress.XtraGrid
Imports DevExpress.XtraEditors
Imports DevExpress.Data.Filtering
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraTreeList.Nodes
Imports DevExpress.XtraTreeList.Columns


Namespace DevExpress.XtraTreeList.Demos
    Partial Public Class MultiSelect
        Inherits DevExpress.XtraTreeList.Demos.TutorialControl
        Public Overrides ReadOnly Property ExportControl() As TreeList
            Get
                Return treeList1
            End Get
        End Property
        Public Sub New()
            InitializeComponent()
            TutorialInfo.WhatsThisCodeFile = "VB\\TreeListMainDemo\\Modules\\MultiSelect.cs"
            TutorialInfo.WhatsThisXMLFile = "MultiSelect.xml"
            InitData()
            InitEditors()
            InitSelection()
        End Sub
        Private Sub InitSelection()
            treeList1.ForceInitialize()
            treeList1.SelectCells(treeList1.Nodes(0).Nodes(0).Nodes(3), treeList1.VisibleColumns(1), treeList1.Nodes(0).Nodes(3), treeList1.VisibleColumns(3))
            treeList1.SelectCells(treeList1.Nodes(0).Nodes(0).Nodes(3), treeList1.VisibleColumns(6), treeList1.Nodes(0).Nodes(3), treeList1.VisibleColumns(6))
        End Sub
        Private Sub InitEditors()
            ceAllowMultiSelect.Checked = treeList1.OptionsSelection.MultiSelect
            cbMultiSelectMode.Properties.Items.AddEnum(GetType(TreeListMultiSelectMode))
            cbMultiSelectMode.EditValue = treeList1.OptionsSelection.MultiSelectMode
            InitEnabled()
        End Sub
        Private Sub InitEnabled()
            btnShowSelectedValues.Enabled = ceAllowMultiSelect.Checked
            labelControl.Enabled = btnShowSelectedValues.Enabled
            cbMultiSelectMode.Enabled = labelControl.Enabled
        End Sub
        Private Sub InitData()
            Dim DBFileName As String = DevExpress.Utils.FilesHelper.FindingFileName(Application.StartupPath, "Data\EmployeesGroups.xml")
            If DBFileName <> "" Then
                Dim dataSet As New DataSet()
                dataSet.ReadXml(DBFileName)
                treeList1.DataSource = dataSet.Tables(0).DefaultView
                treeList1.ForceInitialize()
                treeList1.ExpandAll()
                treeList1.BestFitColumns()
            End If
        End Sub
        Private currentGroupName As String
        Private Sub treeList1_GetStateImage(ByVal sender As Object, ByVal e As GetStateImageEventArgs) Handles treeList1.GetStateImage
            Dim groupNames() As String = {"Administration", "Inventory", "Manufacturing", "Quality", "Research", "Sales"}
            currentGroupName = CStr(e.Node.GetValue("GroupName"))
            e.NodeImageIndex = Array.FindIndex(groupNames, New Predicate(Of String)(AddressOf IsCurrentGroupName))
        End Sub
        Private Function IsCurrentGroupName(ByVal groupName As String) As Boolean
            Return currentGroupName.Contains(groupName)
        End Function
        Private Sub cbMultiSelectMode_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbMultiSelectMode.SelectedIndexChanged
            treeList1.OptionsSelection.MultiSelectMode = CType(cbMultiSelectMode.EditValue, TreeListMultiSelectMode)
        End Sub
        Private Sub ceAllowMultiSelect_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles ceAllowMultiSelect.CheckedChanged
            treeList1.OptionsSelection.MultiSelect = ceAllowMultiSelect.Checked
            InitEnabled()
        End Sub
        Private Sub btnShowSelectedValues_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnShowSelectedValues.Click
            DemosHelper.ShowDescriptionForm(Control.MousePosition, GetSelectionString(treeList1), If(treeList1.OptionsSelection.MultiSelectMode = TreeListMultiSelectMode.CellSelect, "Selected Cells", "Selected Rows"))
        End Sub
        Private Function GetSelectionString(ByVal treeList As TreeList) As String
            Dim result As String = ""
            For Each node As TreeListNode In treeList.Selection
                If result <> "" Then
                    result &= Environment.NewLine
                End If
                result &= String.Format("#{0}: {1} {2}", treeList.GetVisibleIndexByNode(node), node.GetDisplayText("FirstName"), node.GetDisplayText("LastName"))
                If treeList.OptionsSelection.MultiSelectMode = TreeListMultiSelectMode.CellSelect Then
                    For Each cell As TreeListColumn In treeList.GetSelectedCells(node)
                        result &= Environment.NewLine & "   " & String.Format("{0}: {1}", cell.FieldName, node.GetDisplayText(cell))
                    Next cell
                End If
            Next node
            Return result
        End Function
    End Class
End Namespace

