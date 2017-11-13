Imports System.Collections
Imports System.ComponentModel
Imports DevExpress.XtraVerticalGrid
Imports DevExpress.XtraVerticalGrid.Rows
Imports DevExpress.Utils
Imports DevExpress.XtraTab

Namespace DevExpress.XtraVerticalGrid.Demos
	Partial Public Class PropertiesBase
		Inherits TutorialControl

		Public Sub New()
			InitializeComponent()
			InitData()
			InitDemoGrid()
			treeView1.ExpandAll()
			RowsCreator.CreateRows(0, vGridControl3)
		End Sub
		Private aboutBinding() As String = { "DataView obtained from the Cars.xml XML table via DataSet is used as a data source for this VerticalGrid.", "This VerticalGrid uses the Contacts class inherited from ArrayList as a data source. Public properties of arraylist objects are used as grid rows.", "This Grid creates rows at runtime and does not have any data source (unbound mode).", "This sample uses the XML table included in the XtraVerticalGrid demo application for its data source." }
		Private dataView As DataView
		Public Overrides ReadOnly Property ExportControl() As VGridControlBase
			Get
				If tcMain.SelectedTabPage Is tabPage1 Then
					Return vGridControl1
				End If
				If tcMain.SelectedTabPage Is tabPage5 Then
					Return vGridControl2
				End If
				If tcMain.SelectedTabPage Is tabPage7 Then
					Return vGridControl3
				End If
				If tcMain.SelectedTabPage Is tabPage8 Then
					Return vGridControl4
				End If
				Return vGridControl1
			End Get
		End Property

		#Region "Init"

		Private Sub PropertiesBase_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
			InitStyles()
			AdjustmentGrid()
		End Sub

		Protected Overridable Sub InitStyles()
		End Sub
		Protected Overridable Sub AdjustmentGrid()
			If tcMain.SelectedTabPageIndex = -1 Then
				Return
			End If
			lbHint.Text = aboutBinding(tcMain.SelectedTabPageIndex)
		End Sub
		Protected Overridable Sub InitAppearanceList(ByVal vg As VGridControl)
		End Sub


		Private Sub InitData()
			Dim DBFileName As String = DevExpress.Utils.FilesHelper.FindingFileName(Application.StartupPath, "Data\Cars.xml", False)
			If DBFileName <> "" Then
				Dim dataSet As New DataSet()
				dataSet.ReadXml(DBFileName)
				dataView = dataSet.Tables(0).DefaultView
				vGridControl1.DataSource = dataView
			End If
			vGridControl2.DataSource = New Contacts()
			repositoryItemLookUpEdit1.DataSource = New Products()
		End Sub

		Private Sub InitDemoGrid()
			DevExpress.XtraVerticalGrid.Design.XViews.ConfigureDemoView(vGridControl4)
		End Sub

		Protected Shared Sub InitOptions(ByVal options As Object, ByVal checkedListBox As DevExpress.XtraEditors.CheckedListBoxControl)
			checkedListBox.Items.Clear()
			Dim arr As ArrayList = DevExpress.Utils.SetOptions.GetOptionNames(options)
			For i As Integer = 0 To arr.Count - 1
				checkedListBox.Items.Add(New DevExpress.XtraEditors.Controls.CheckedListBoxItem(arr(i), DevExpress.Utils.SetOptions.OptionValueByString(arr(i).ToString(), options)))
			Next i
		End Sub
		#End Region
		#Region "Editing"
		Private Sub tcMain_SelectedIndexChanged(ByVal sender As Object, ByVal e As TabPageChangedEventArgs) Handles tcMain.SelectedPageChanged
			InitAppearanceList(CurrentGrid)
			CloseCustomizationForm()
			AdjustmentGrid()
			If VertGridRibbonMenuManager IsNot Nothing Then
				VertGridRibbonMenuManager.AllowExport(ExportControl)
			End If
		End Sub

		Private Sub CloseCustomizationForm()
			vGridControl1.DestroyCustomization()
			vGridControl2.DestroyCustomization()
			vGridControl3.DestroyCustomization()
			vGridControl4.DestroyCustomization()
		End Sub

		Protected Function GetAppearanceObjectByName(ByVal vg As VGridControl, ByVal name As String) As AppearanceObject
			If vg.Appearance Is Nothing Then
				Return Nothing
			Else
				Return vg.Appearance.GetAppearance(name)
			End If
		End Function

		Private Sub treeView1_AfterExpand(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles treeView1.AfterExpand
			If e.Node.Nodes.Count > 0 Then
				e.Node.ImageIndex = 2
				e.Node.SelectedImageIndex = 2
			End If
		End Sub

		Private Sub treeView1_AfterCollapse(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles treeView1.AfterCollapse
			If e.Node.Nodes.Count > 0 Then
				e.Node.ImageIndex = 1
				e.Node.SelectedImageIndex = 1
			End If
		End Sub

		Private Sub treeView1_AfterSelect(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles treeView1.AfterSelect
			If e.Node.Nodes.Count = 0 Then
				For Each node As TreeNode In treeView1.Nodes(0).Nodes
					node.ImageIndex = 0
					node.SelectedImageIndex = 0
				Next node
				e.Node.ImageIndex = 3
				e.Node.SelectedImageIndex = 3
				RowsCreator.CreateRows(e.Node.Index, vGridControl3)
			End If
		End Sub
		Protected Overridable Property ShowCustomization() As Boolean
			Get
				Return False
			End Get
			Set(ByVal value As Boolean)
			End Set
		End Property
		#End Region
		#Region "VertGrid events"
		Private Sub vGridControl3_CustomDrawRowValueCell(ByVal sender As Object, ByVal e As DevExpress.XtraVerticalGrid.Events.CustomDrawRowValueCellEventArgs) Handles vGridControl3.CustomDrawRowValueCell
			If Not e.Row.Tag.Equals(e.Row.Properties.Value) Then
				e.Appearance.Font = New Font(AppearanceObject.DefaultFont, FontStyle.Bold)
			End If
		End Sub

		Private Sub vGridControl_HideCustomizationForm(ByVal sender As Object, ByVal e As System.EventArgs) Handles vGridControl4.HideCustomizationForm, vGridControl1.HideCustomizationForm, vGridControl2.HideCustomizationForm, vGridControl3.HideCustomizationForm
			ShowCustomization = False
		End Sub
		#End Region
		#Region "CurrentGrid"
		Protected Function GridByIndex(ByVal index As Integer) As VGridControl
			Select Case index
				Case 1
					Return vGridControl2
				Case 2
					Return vGridControl3
				Case 3
					Return vGridControl4
			End Select
			Return vGridControl1
		End Function

		Protected ReadOnly Property CurrentGrid() As VGridControl
			Get
				Return GridByIndex(tcMain.SelectedTabPageIndex)
			End Get
		End Property
		#End Region

		Protected ReadOnly Property SelectedPageIndex() As Integer
			Get
				Return tcMain.SelectedTabPageIndex
			End Get
		End Property
		Protected ReadOnly Property IsLayoutGrid() As Boolean
			Get
				Return CurrentGrid Is vGridControl1
			End Get
		End Property
		Protected ReadOnly Property EditorRowDescription() As EditorRow
			Get
				Return rowDescription
			End Get
		End Property
		Protected ReadOnly Property EditorRowAutomaticTransmission() As EditorRow
			Get
				Return rowTransmiss_Automatic
			End Get
		End Property
		Protected Sub HideRows()
			categoryRow3.Visible = False
			categoryRow6.Visible = False
		End Sub
	End Class
End Namespace
