Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data

Namespace DevExpress.XtraGrid.Demos.Tutorials
	''' <summary>
	''' Summary description for GridCalcRowHeight.
	''' </summary>
	Public Partial Class GridCalcRowHeight
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

		Private Sub GridCalcRowHeight_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
			InitData()
			radioGroup1.SelectedIndex = 1
		End Sub

		Private Sub InitData()
			Dim ds As DataSet = New DataSet()
            Dim stream As System.IO.Stream = System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceStream("Employees.xml")
			ds.ReadXml(stream)
			stream.Close()
			gridControl1.DataSource = ds.Tables(0)
		End Sub

	  '<radioGroup1>
		Private Sub radioGroup1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles radioGroup1.SelectedIndexChanged
			gridView1.OptionsView.RowAutoHeight = radioGroup1.EditValue.Equals(1)
			gridView1.LayoutChanged()
		End Sub

		Private Sub gridView1_CalcRowHeight(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowHeightEventArgs) Handles gridView1.CalcRowHeight
			If radioGroup1.EditValue Is Nothing Then
			Return
			End If
			If e.RowHandle >= 0 AndAlso radioGroup1.EditValue.Equals(0) Then
				e.RowHeight = CInt(Fix(gridView1.GetDataRow(e.RowHandle)("RowHeight")))
			End If
		End Sub
	  '</radioGroup1>
	End Class
End Namespace
