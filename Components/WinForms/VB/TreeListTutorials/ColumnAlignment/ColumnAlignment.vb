Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data

Namespace DevExpress.XtraTreeList.Demos.Tutorials
	''' <summary>
	''' Summary description for ColumnAlignment.
	''' </summary>
	Public Partial Class ColumnAlignment
		Inherits TutorialControl
		Public Sub New()
			'
			' Required for Windows Form Designer support
			'
			InitializeComponent()
			InitData()
			InitComboBoxes()
			'
			' TODO: Add any constructor code after InitializeComponent call
			'
		End Sub

		Private Sub InitData()
			Dim xv As DevExpress.XtraTreeList.Design.XViews = New DevExpress.XtraTreeList.Design.XViews(treeList1)
			treeList1.OptionsBehavior.Editable = True
		End Sub

		Private Sub InitComboBoxes()
			For Each col As DevExpress.XtraTreeList.Columns.TreeListColumn In treeList1.Columns
				comboBox1.Properties.Items.Add(col.FieldName)
			Next col
			comboBox1.SelectedIndex = 1
			comboBox2.Properties.Items.AddRange(System.Enum.GetNames(GetType(DevExpress.Utils.HorzAlignment)))
			comboBox2.SelectedIndex = 0
		End Sub

		'<comboBox1>
		'<comboBox2>
		Private Function hAlignment(ByVal s As String) As DevExpress.Utils.HorzAlignment
			Dim arr As Array = System.Enum.GetValues(GetType(DevExpress.Utils.HorzAlignment))
			Dim i As Integer = 0
			Do While i < arr.Length
				If s = arr.GetValue(i).ToString() Then
					Return CType(arr.GetValue(i), DevExpress.Utils.HorzAlignment)
				End If
				i += 1
			Loop
			Return DevExpress.Utils.HorzAlignment.Default
		End Function

		Private Sub SetColumnStyle(ByVal col As DevExpress.XtraTreeList.Columns.TreeListColumn, ByVal alignment As String)
			col.AppearanceCell.TextOptions.HAlignment = hAlignment(alignment)
		End Sub

		Private Sub comboBox_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles comboBox2.SelectedIndexChanged, comboBox1.SelectedIndexChanged
			Try
				SetColumnStyle(treeList1.Columns(comboBox1.SelectedItem.ToString()), comboBox2.SelectedItem.ToString())
			Catch
			End Try
		End Sub
		'</comboBox1>
		'</comboBox2>
	End Class
End Namespace
