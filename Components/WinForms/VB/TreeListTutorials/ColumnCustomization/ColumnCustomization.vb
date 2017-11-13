Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data

Namespace DevExpress.XtraTreeList.Demos.Tutorials
	''' <summary>
	''' Summary description for ColumnCustomization.
	''' </summary>
	Public Partial Class ColumnCustomization
		Inherits TutorialControl
		Public Sub New()
			'
			' Required for Windows Form Designer support
			'
			InitializeComponent()
			InitData()
			'
			' TODO: Add any constructor code after InitializeComponent call
			'
		End Sub

		Private customization As Boolean = False
		Private Sub InitData()
			Dim DBFileName As String = DevExpress.Utils.FilesHelper.FindingFileName(Application.StartupPath, "Data\BioLife.xml")
			If DBFileName <> "" Then
				Dim dataSet As DataSet = New DataSet()
				dataSet.ReadXml(DBFileName)
				treeList1.DataSource = dataSet.Tables(0).DefaultView
				treeList1.PopulateColumns()
				HideColumns(New String() { "Notes", "Picture", "RecordDate", "Mark" })
				treeList1.BestFitColumns()
				treeList1.ExpandAll()
			End If
		End Sub

		Private Sub HideColumns(ByVal names As String())
			For Each s As String In names
				treeList1.Columns(s).VisibleIndex = -1
			Next s
		End Sub


		Private Sub treeList1_ShowCustomizationForm(ByVal sender As Object, ByVal e As System.EventArgs) Handles treeList1.ShowCustomizationForm
			customization = True
			checkBox1.Checked = True
			customization = False
		End Sub

		Private Sub treeList1_HideCustomizationForm(ByVal sender As Object, ByVal e As System.EventArgs) Handles treeList1.HideCustomizationForm
			customization = True
			checkBox1.Checked = False
			customization = False
		End Sub

		'<checkBox1>
		Private Sub checkBox1_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkBox1.CheckedChanged
			If customization Then
			Return
			End If
			If checkBox1.Checked Then
				treeList1.ColumnsCustomization()
			Else
				treeList1.DestroyCustomization()
			End If
		End Sub
		'</checkBox1>

		Private Sub ColumnCustomization_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
			treeList1.ColumnsCustomization()
		End Sub

		Public Overrides Sub StartWhatsThis()
			checkBox1.Checked = False
		End Sub
	End Class
End Namespace
