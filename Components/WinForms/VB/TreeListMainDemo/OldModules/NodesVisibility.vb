Imports System.Collections
Imports System.ComponentModel
Imports DevExpress.XtraTreeList.Nodes
Imports DevExpress.XtraEditors


Namespace DevExpress.XtraTreeList.Demos
	Partial Public Class NodesVisibility
		Inherits DevExpress.XtraTreeList.Demos.TutorialControl

		Public Sub New()
			InitializeComponent()
			TutorialInfo.WhatsThisCodeFile = "VB\TreeListMainDemo\Modules\NodesVisibility.vb"
			TutorialInfo.WhatsThisXMLFile = "NodesVisibility.xml"
			InitData()
			InitListBox()
			treeList1.Columns("Check").VisibleIndex = -1
			treeList1.BestFitColumns()
		End Sub
		Private Sub InitData()
			Dim DBFileName As String = DevExpress.Utils.FilesHelper.FindingFileName(Application.StartupPath, "Data\Departments.xml")
			If DBFileName <> "" Then
				Dim dataSet As New DataSet()
				dataSet.ReadXml(DBFileName)
				treeList1.DataSource = dataSet.Tables(0).DefaultView
				treeList1.PopulateColumns()
				treeList1.ExpandAll()
			End If
		End Sub
		'<treeList1>
		Private Sub InitListBox()
			Dim lastNode As TreeListNode = treeList1.Nodes(0).Nodes(2).Nodes(1).LastNode
			listBoxControl1.Items.Add(lastNode.GetDisplayText(0))
			lastNode.Visible = False
		End Sub

		Private Sub treeList1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles treeList1.MouseDown
			If e.Clicks <> 2 Then
				Return
			End If
			Dim hi As TreeListHitInfo = treeList1.CalcHitInfo(New Point(e.X, e.Y))
			Dim node As TreeListNode = hi.Node
			If node IsNot Nothing Then
				listBoxControl1.Items.Add(node.GetDisplayText(0))
				node.Visible = False
			End If
		End Sub
		'</treeList1>

		'<listBoxControl1>
		Private Sub listBoxControl1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles listBoxControl1.DoubleClick
			Dim selectedValue As String = CStr(listBoxControl1.SelectedValue)
			If selectedValue Is Nothing Then
				Return
			End If
			Dim node As TreeListNode = treeList1.FindNodeByFieldValue(treeList1.Columns(0).FieldName, selectedValue)
			If node.ParentNode IsNot Nothing AndAlso (Not node.ParentNode.Visible) Then
				XtraMessageBox.Show(Me, "Please make the node's parent visible before")
				Return
			End If
			node.Visible = True
			listBoxControl1.Items.Remove(selectedValue)
		End Sub
		Private Sub listBoxControl1_DrawItem(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.ListBoxDrawItemEventArgs) Handles listBoxControl1.DrawItem
			Dim item As String = TryCast(e.Item, String)
			Dim node As TreeListNode = treeList1.FindNodeByFieldValue(treeList1.Columns(0).FieldName, item)
			If node.ParentNode IsNot Nothing AndAlso (Not node.ParentNode.Visible) Then
				e.Appearance.ForeColor = Color.Gray
			End If
		End Sub
		'</listBoxControl1>
	End Class
End Namespace

