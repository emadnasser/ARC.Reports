Imports System.Collections
Imports System.ComponentModel
Imports DevExpress.XtraGrid
Imports DevExpress.XtraEditors
Imports DevExpress.Data.Filtering
Imports DevExpress.XtraEditors.Controls


Namespace DevExpress.XtraTreeList.Demos
	Partial Public Class NodesFiltering
		Inherits DevExpress.XtraTreeList.Demos.TutorialControl
        Public Overrides ReadOnly Property ExportControl() As TreeList
            Get
                Return treeList1
            End Get
        End Property
		Public Sub New()
			InitializeComponent()
			TutorialInfo.WhatsThisCodeFile = "VB\TreeListMainDemo\Modules\NodesFiltering.vb"
			TutorialInfo.WhatsThisXMLFile = "NodesFiltering.xml"
			InitData()
			InitEditors()
			InitFilter()
			treeList1.Columns("JobTitle").AllNodesSummary = True
			treeList1.Columns("JobTitle").SummaryFooter = SummaryItemType.Count
			treeList1.Columns("JobTitle").OptionsFilter.FilterPopupMode = FilterPopupMode.CheckedList
			treeList1.OptionsView.ShowSummaryFooter = True
		End Sub
		Protected Overrides Sub OnLoad(ByVal e As EventArgs)
			MyBase.OnLoad(e)
			treeList1.ShowFindPanel()
		End Sub
		Private Sub InitEditors()
			ceAllowFilter.Checked = treeList1.OptionsBehavior.EnableFiltering
			ceAutoFilterRow.Checked = treeList1.OptionsView.ShowAutoFilterRow
			ceFilterEditor.Checked = treeList1.OptionsFilter.AllowFilterEditor
			ceFilterList.Checked = treeList1.OptionsFilter.AllowMRUFilterList
			ceAllowFindPanel.Checked = treeList1.OptionsFind.AllowFindPanel
			ceColumnFilterList.Checked = treeList1.OptionsFilter.AllowColumnMRUFilterList
			cbFilterMode.Properties.Items.AddEnum(GetType(FilterMode))
			cbFilterMode.EditValue = treeList1.OptionsFilter.FilterMode
			InitEnabled()
		End Sub
		Private Sub InitEnabled()
			labelControl.Enabled = ceAllowFilter.Checked
			cbFilterMode.Enabled = labelControl.Enabled
			ceAllowFindPanel.Enabled = cbFilterMode.Enabled
			ceColumnFilterList.Enabled = ceAllowFindPanel.Enabled
			ceAutoFilterRow.Enabled = ceColumnFilterList.Enabled
			ceFilterList.Enabled = ceAutoFilterRow.Enabled
			ceFilterEditor.Enabled = ceFilterList.Enabled
			btnFindPanelOptions.Enabled = ceAllowFilter.Checked AndAlso ceAllowFindPanel.Checked
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
		'<treeList1>
		Private Sub InitFilter()
			Dim opLeftDate As CriteriaOperator = New BinaryOperator("BirthDate", New Date(1957, 5, 1), BinaryOperatorType.GreaterOrEqual)
			Dim opRightDate As CriteriaOperator = New BinaryOperator("BirthDate", New Date(1980, 10, 1), BinaryOperatorType.LessOrEqual)
			Dim opDate As CriteriaOperator = New GroupOperator(GroupOperatorType.And, opLeftDate, opRightDate)
			Dim opCountry As New BinaryOperator("StateProvinceName", "California", BinaryOperatorType.Equal)
			treeList1.MRUFilters.Add(New TreeListFilterInfo(opCountry))
			treeList1.MRUFilters.Add(New TreeListFilterInfo(opDate))
			treeList1.Columns("StateProvinceName").MRUFilters.Add(New TreeListFilterInfo(opCountry))
			treeList1.ActiveFilterCriteria = treeList1.MRUFilters(1).FilterCriteria
		End Sub
		'</treeList1>

		'<ceAllowFilter>
		Private Sub ceAllowFilter_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ceAllowFilter.CheckedChanged
			treeList1.OptionsBehavior.EnableFiltering = ceAllowFilter.Checked
			If Not treeList1.OptionsBehavior.EnableFiltering Then
				treeList1.HideFindPanel()
			End If
			InitEnabled()
		End Sub
		'</ceAllowFilter>
		'<ceFilterEditor>
		Private Sub ceFilterEditor_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ceFilterEditor.CheckedChanged
			treeList1.OptionsFilter.AllowFilterEditor = ceFilterEditor.Checked
		End Sub
		'</ceFilterEditor>
		'<ceFilterList>
		Private Sub ceFilterList_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ceFilterList.CheckedChanged
			treeList1.OptionsFilter.AllowMRUFilterList = ceFilterList.Checked
		End Sub
		'</ceFilterList>
		'<ceColumnFilterList>
		Private Sub ceColumnFilterList_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ceColumnFilterList.CheckedChanged
			treeList1.OptionsFilter.AllowColumnMRUFilterList = ceColumnFilterList.Checked
		End Sub
		'</ceColumnFilterList>
		'<ceAutoFilterRow>
		Private Sub ceAutoFilterRow_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ceAutoFilterRow.CheckedChanged
			treeList1.OptionsView.ShowAutoFilterRow = ceAutoFilterRow.Checked
		End Sub
		'</ceAutoFilterRow>
		Private currentGroupName As String
		Private Sub treeList1_GetStateImage(ByVal sender As Object, ByVal e As GetStateImageEventArgs) Handles treeList1.GetStateImage
			Dim groupNames() As String = { "Administration", "Inventory", "Manufacturing", "Quality", "Research", "Sales" }
			currentGroupName = CStr(e.Node.GetValue("GroupName"))
			e.NodeImageIndex = Array.FindIndex(groupNames, New Predicate(Of String)(AddressOf IsCurrentGroupName))
		End Sub
		Private Function IsCurrentGroupName(ByVal groupName As String) As Boolean
			Return currentGroupName.Contains(groupName)
		End Function

		'<cbFilterMode>
		Private Sub cbFilterMode_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbFilterMode.SelectedIndexChanged
			treeList1.OptionsFilter.FilterMode = CType(cbFilterMode.EditValue, FilterMode)
		End Sub
		'</cbFilterMode>
		'<ceAllowFindPanel>
		Private Sub ceFindPanel_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles ceAllowFindPanel.CheckedChanged
			treeList1.OptionsFind.AllowFindPanel = ceAllowFindPanel.Checked
			btnFindPanelOptions.Enabled = treeList1.OptionsFind.AllowFindPanel
			If treeList1.OptionsFind.AllowFindPanel Then
				treeList1.ShowFindPanel()
			Else
				treeList1.HideFindPanel()
			End If
		End Sub
		'</ceAllowFindPanel>
		Private Sub btnFindPanelOptions_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnFindPanelOptions.Click
			Dim opt As New FindPanelOptions(treeList1)
			opt.ShowDialog()
		End Sub
	End Class
End Namespace

