Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data

Namespace DevExpress.XtraGrid.Demos.Tutorials
	''' <summary>
	''' Summary description for GridVirtualData.
	''' </summary>
	Public Partial Class GridVirtualData
		Inherits TutorialControl
		Public Sub New()
			'
			' Required for Windows Form Designer support
			'
			InitializeComponent()

			'
			' TODO: Add any constructor code after InitializeComponent call
			'
		End Sub

		Private Sub GridVirtualData_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
			InitData()
		End Sub

		'<checkEdit1>
		Private vList As VirtualList = New VirtualList()
		'</checkEdit1>
		Private Sub InitData()
			vList.RecordCount = CInt(Fix(spinEdit1.Value))
			vList.ColumnCount = CInt(Fix(spinEdit2.Value))
			vList.UseDataStore = checkEdit1.Checked

			'<checkEdit1>
			gridControl1.DataSource = vList
			'</checkEdit1>
			gridControl1.MainView.PopulateColumns()
			simpleButton1.Enabled = False
		End Sub

		Private Sub spinEdit_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles spinEdit2.EditValueChanged, spinEdit1.EditValueChanged
			simpleButton1.Enabled = True
		End Sub

		'<checkEdit1>
		Private Sub checkEdit1_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkEdit1.CheckedChanged
			vList.UseDataStore = checkEdit1.Checked
			gridView1.LayoutChanged()
		End Sub
		'</checkEdit1>

		'<simpleButton1>
		Private Sub simpleButton1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles simpleButton1.Click
			vList.RecordCount = CInt(Fix(spinEdit1.Value))
			vList.ColumnCount = CInt(Fix(spinEdit2.Value))
			gridControl1.DataSource = Nothing
			gridControl1.DataSource = vList
			gridControl1.MainView.PopulateColumns()
			simpleButton1.Enabled = False
		End Sub
		'</simpleButton1>
	End Class
End Namespace
