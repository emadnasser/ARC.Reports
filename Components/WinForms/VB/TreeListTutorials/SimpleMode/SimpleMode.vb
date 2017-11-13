Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data

Namespace DevExpress.XtraTreeList.Demos.Tutorials
	''' <summary>
	''' Summary description for SimpleMode.
	''' </summary>
	Public Partial Class SimpleMode
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
        Public Overrides ReadOnly Property SetNewWhatsThisPadding() As Boolean
            Get
                Return True
            End Get
        End Property
		'<treeList1>
		Private Sub InitData()
			treeList1.DataSource = New SimpleModeRecords()
			treeList1.PopulateColumns()
			treeList1.BestFitColumns()
			treeList1.ExpandAll()
			InitColumnsVisibleOrder()
			treeList1.Columns("Price").Format.FormatString = "c"
		End Sub
		'</treeList1>

		Private Sub InitColumnsVisibleOrder()
			treeList1.Columns("Name").VisibleIndex = 0
			treeList1.Columns("Status").VisibleIndex = 1
			treeList1.Columns("Price").VisibleIndex = 2
			treeList1.Columns("Supplier").VisibleIndex = 3
		End Sub

		Private Sub SimpleMode_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
			treeList1.BestFitColumns()
		End Sub
	End Class
End Namespace
