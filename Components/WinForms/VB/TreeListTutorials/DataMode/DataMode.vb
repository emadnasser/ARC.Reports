Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data

Namespace DevExpress.XtraTreeList.Demos.Tutorials
	''' <summary>
	''' Summary description for DataMode.
	''' </summary>
	Public Partial Class DataMode
		Inherits TutorialControl
		'<treeList1>
		Public Sub New()
			InitializeComponent()
			InitData()
		End Sub
		'</treeList1>
        Public Overrides ReadOnly Property SetNewWhatsThisPadding() As Boolean
            Get
                Return True
            End Get
        End Property
		'<treeList1>
		Private Sub InitData()
			Dim DBFileName As String = DevExpress.Utils.FilesHelper.FindingFileName(Application.StartupPath, "Data\Departments.xml")
			If DBFileName <> "" Then
				Dim dataSet As DataSet = New DataSet()
				dataSet.ReadXml(DBFileName)
				treeList1.DataSource = dataSet.Tables(0).DefaultView
				treeList1.PopulateColumns()
				treeList1.BestFitColumns()
				treeList1.ExpandAll()
			End If
		End Sub
		'</treeList1>

        Private Sub DataMode_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
            If treeList1.Columns("Budget") Is Nothing Then
                Return
            End If
            treeList1.Columns("Budget").Format.FormatString = "c"
            treeList1.BestFitColumns()
        End Sub
	End Class
End Namespace
