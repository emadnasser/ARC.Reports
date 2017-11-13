Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data

Namespace DevExpress.XtraVerticalGrid.Demos.Tutorials
	''' <summary>
	''' Summary description for RowAlignment.
	''' </summary>
	Public Partial Class RowAlignment
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

		Private Sub RowAlignment_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
			InitData()
			InitComboBoxes()
		End Sub

		Private Sub InitData()
			Dim DBFileName As String = DevExpress.Utils.FilesHelper.FindingFileName(Application.StartupPath, "Data\Cars.xml")
			If DBFileName <> "" Then
				Dim dataSet As DataSet = New DataSet()
				dataSet.ReadXml(DBFileName)
				vGridControl1.DataSource = dataSet.Tables(0).DefaultView
			End If
		End Sub

		Private Sub AddToComboBox(ByVal row As DevExpress.XtraVerticalGrid.Rows.BaseRow, ByVal cb As DevExpress.XtraEditors.ComboBoxEdit)
			If TypeOf row Is DevExpress.XtraVerticalGrid.Rows.EditorRow Then
				cb.Properties.Items.Add(row.Properties.Caption)
			End If
			For Each cRow As DevExpress.XtraVerticalGrid.Rows.BaseRow In row.ChildRows
				AddToComboBox(cRow, cb)
			Next cRow
		End Sub

		Private Sub InitComboBoxes()
			For Each row As DevExpress.XtraVerticalGrid.Rows.BaseRow In vGridControl1.Rows
				AddToComboBox(row, comboBox1)
			Next row
			comboBox1.SelectedIndex = 0
			comboBox2.Properties.Items.AddRange(System.Enum.GetNames(GetType(DevExpress.Utils.HorzAlignment)))
			comboBox2.SelectedIndex = 0
		End Sub

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

		'<comboBox2>
		Private Sub SetRowStyle(ByVal row As DevExpress.XtraVerticalGrid.Rows.BaseRow, ByVal alignment As String)
			row.Appearance.TextOptions.HAlignment = hAlignment(alignment)
		End Sub
		'</comboBox2>

		Private Function GetRowByCaptionChild(ByVal row As DevExpress.XtraVerticalGrid.Rows.BaseRow, ByVal s As String) As DevExpress.XtraVerticalGrid.Rows.BaseRow
			If row.Properties.Caption = s Then
			Return row
			End If
			Dim r As DevExpress.XtraVerticalGrid.Rows.BaseRow
			For Each cRow As DevExpress.XtraVerticalGrid.Rows.BaseRow In row.ChildRows
				r = GetRowByCaptionChild(cRow, s)
				If Not r Is Nothing Then
				Return r
				End If
			Next cRow
			Return Nothing
		End Function

		Private Function GetRowByCaption(ByVal s As String) As DevExpress.XtraVerticalGrid.Rows.BaseRow
			Dim r As DevExpress.XtraVerticalGrid.Rows.BaseRow
			For Each row As DevExpress.XtraVerticalGrid.Rows.BaseRow In vGridControl1.Rows
				r = GetRowByCaptionChild(row, s)
				If Not r Is Nothing Then
				Return r
				End If
			Next row
			Return Nothing
		End Function

		'<comboBox2>
		Private Sub comboBox_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles comboBox2.SelectedIndexChanged, comboBox1.SelectedIndexChanged
			Try
				SetRowStyle(GetRowByCaption(comboBox1.SelectedItem.ToString()), comboBox2.SelectedItem.ToString())
			Catch
			End Try
		End Sub
		'</comboBox2>
	End Class
End Namespace
